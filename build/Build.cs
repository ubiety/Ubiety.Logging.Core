using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.DotNetSonarScanner;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.DotNetSonarScanner.DotNetSonarScannerTasks;

// [GitHubActions("dotnetcore",
//     GitHubActionsImage.UbuntuLatest,
//     GitHubActionsImage.WindowsLatest,
//     On = new[] {GitHubActionsTrigger.Push},
//     InvokedTargets = new []{nameof(SonarEnd)})]
[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
class Build : NukeBuild
{
    [Parameter] readonly string AssemblyFileVer;
    [Parameter] readonly string AssemblySemVer;

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Parameter] readonly bool? Cover = true;
    readonly string GithubSource = "github";
    [GitRepository] readonly GitRepository GitRepository;
    [Parameter] readonly string InformationalVersion;
    [Parameter] readonly string NuGetKey;

    readonly string NuGetSource = "https://api.nuget.org/v3/index.json";
    [Parameter] readonly string NuGetVersion;

    [Solution] readonly Solution Solution;

    [Parameter] readonly string SonarKey;
    readonly string SonarProjectKey = "ubiety_Ubiety.Logging.Core";

    Project UbietyLoggingCoreProject => Solution.GetProject("Ubiety.Logging.Core");

    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath TestsDirectory => RootDirectory / "tests";
    AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
            SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            TestsDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            EnsureCleanDirectory(ArtifactsDirectory);
        });

    Target Restore => _ => _
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(Solution));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            Logger.Info($"Build Configuration: {Configuration}");
            Logger.Info($"Current Branch: {GitRepository.Branch}");
            Logger.Info($"IsOnDevelopBranch Value: {GitRepository.IsOnDevelopBranch()}");
            Logger.Info($"IsOnMasterBranch Value: {GitRepository.IsOnMasterBranch()}");

            var settings = new DotNetBuildSettings()
                .SetProjectFile(UbietyLoggingCoreProject)
                .SetConfiguration(Configuration)
                .SetAssemblyVersion(AssemblySemVer)
                .SetFileVersion(AssemblyFileVer)
                .SetInformationalVersion(InformationalVersion)
                .EnableNoRestore();

            DotNetBuild(settings);
        });

    Target SonarBegin => _ => _
        .Before(Compile)
        .Requires(() => SonarKey)
        .Unlisted()
        .Executes(() =>
        {
            DotNetSonarScannerBegin(s => s
                .SetLogin(SonarKey)
                .SetProjectKey(SonarProjectKey)
                .SetOrganization("ubiety")
                .SetServer("https://sonarcloud.io")
                .SetVersion(NuGetVersion)
                .SetOpenCoverPaths(ArtifactsDirectory / "coverage.opencover.xml"));
        });

    Target SonarEnd => _ => _
        .After(Test)
        .After(Compile)
        .DependsOn(SonarBegin)
        .Requires(() => SonarKey)
        .Unlisted()
        .Executes(() =>
        {
            DotNetSonarScannerEnd(s => s.SetLogin(SonarKey));
        });

    Target Test => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetTest(s => s
                .EnableNoBuild()
                .SetConfiguration(Configuration)
                .SetArgumentConfigurator(args => args.Add("/p:CollectCoverage={0}", Cover)
                    .Add("/p:CoverletOutput={0}", ArtifactsDirectory / "coverage")
                    .Add("/p:CoverletOutputFormat={0}", "opencover")
                    .Add("/p:Exclude={0}", "[xunit.*]*")));
        });

    Target Pack => _ => _
        // .After(Test)
        .DependsOn(Compile)
        .Requires(() => Configuration.Equals(Configuration.Release))
        .Executes(() =>
        {
            DotNetPack(s => s
                .EnableNoBuild()
                .SetProject(UbietyLoggingCoreProject)
                .SetConfiguration(Configuration)
                .SetOutputDirectory(ArtifactsDirectory)
                .SetVersion(NuGetVersion));
        });

    Target PublishNuGet => _ => _
        .DependsOn(Pack)
        .Requires(() => NuGetKey)
        .Requires(() => Configuration.Equals(Configuration.Release))
        .OnlyWhenStatic(() => GitRepository.IsOnMasterBranch())
        .Executes(() =>
        {
            DotNetNuGetPush(s => s
                    .SetApiKey(NuGetKey)
                    .SetSource(NuGetSource)
                    .CombineWith(
                        ArtifactsDirectory.GlobFiles("*.nupkg").NotEmpty(), (cs, v) =>
                            cs.SetTargetPath(v)),
                5,
                true);
        });

    Target PublishGithub => _ => _
        .DependsOn(Pack)
        .Requires(() => Configuration.Equals(Configuration.Release))
        .OnlyWhenStatic(() => GitRepository.IsOnDevelopBranch())
        .Executes(() =>
        {
            DotNetNuGetPush(s => s
                    .SetSource(GithubSource)
                    .CombineWith(ArtifactsDirectory.GlobFiles("*.nupkg").NotEmpty(), (cs, v) =>
                        cs.SetTargetPath(v)),
                5,
                true);
        });

    Target Github => _ => _
        .DependsOn(PublishGithub, PublishNuGet);

    Target Appveyor => _ => _
        .DependsOn(SonarEnd, PublishNuGet);

    public static int Main() => Execute<Build>(x => x.Github);
}
