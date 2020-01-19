# ![Logo](https://github.com/ubiety/Ubiety.Logging.Core/raw/develop/images/logs64.png) Ubiety.Logging.Core ![Nuget](https://img.shields.io/nuget/v/Ubiety.Logging.Core.svg?style=flat-square)

> Generic logging interface for class libraries

| Branch  | Quality                                                                                                                                                                                                       | GitHub                                                                                                                                                                                          | Coverage                                                                                                                                                        |
| ------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Master  | [![CodeFactor](https://img.shields.io/codefactor/grade/github/ubiety/ubiety.logging.core/master?style=flat-square)](https://www.codefactor.io/repository/github/ubiety/ubiety.logging.core)                   | [![Travis (.org) branch](https://img.shields.io/github/workflow/status/ubiety/ubiety.logging.core/dotnetcore/master?style=flat-square)](https://github.com/ubiety/Ubiety.Logging.Core/actions)  | [![Codecov branch](https://img.shields.io/codecov/c/github/ubiety/Ubiety.Dns.Core/master.svg?style=flat-square)](https://codecov.io/gh/ubiety/Ubiety.Dns.Core)  |
| Develop | [![CodeFactor](https://img.shields.io/codefactor/grade/github/ubiety/ubiety.logging.core/develop?style=flat-square)](https://www.codefactor.io/repository/github/ubiety/ubiety.logging.core/overview/develop) | [![Travis (.org) branch](https://img.shields.io/github/workflow/status/ubiety/ubiety.logging.core/dotnetcore/develop?style=flat-square)](https://github.com/ubiety/Ubiety.Logging.Core/actions) | [![Codecov branch](https://img.shields.io/codecov/c/github/ubiety/Ubiety.Dns.Core/develop.svg?style=flat-square)](https://codecov.io/gh/ubiety/Ubiety.Dns.Core) |

## Installing / Getting started

Ubiety Logging Core is available from NuGet

```shell
dotnet package install Ubiety.Logging.Core
```

You can also use your favorite NuGet client.

## Developing

Here's a brief intro about what a developer must do in order to start developing
the project further:

```shell
git clone https://github.com/ubiety/Ubiety.Logging.Core.git
cd Ubiety.Dns.Core
dotnet restore
```

Clone the repository and then restore the development requirements. You can use
any editor, Rider, VS Code or VS 2017. The library supports all .NET Core
platforms.

### Building

Building is simple

```shell
./build.ps1
```

### Deploying / Publishing

```shell
git pull
versionize
dotnet pack
dotnet nuget push
git push
```

## Contributing

When you publish something open source, one of the greatest motivations is that
anyone can just jump in and start contributing to your project.

These paragraphs are meant to welcome those kind souls to feel that they are
needed. You should state something like:

"If you'd like to contribute, please fork the repository and use a feature
branch. Pull requests are warmly welcome."

If there's anything else the developer needs to know (e.g. the code style
guide), you should link it here. If there's a lot of things to take into
consideration, it is common to separate this section to its own file called
`CONTRIBUTING.md` (or similar). If so, you should say that it exists here.

## Links

- Project homepage: <https://logging.ubiety.ca>
- Repository: <https://github.com/ubiety/Ubiety.Logging.Core/>
- Issue tracker: <https://github.com/ubiety/Ubiety.Logging.Core/issues>
  - In case of sensitive bugs like security vulnerabilities, please use the 
    [Tidelift security contact](https://tidelift.com/security) instead of using issue tracker. 
    We value your effort to improve the security and privacy of this project! Tidelift will coordinate the fix and disclosure.
- Related projects:
  - Ubiety VersionIt: <https://github.com/ubiety/Ubiety.VersionIt/>
  - Ubiety Toolset: <https://github.com/ubiety/Ubiety.Toolset/>
  - Ubiety Xmpp: <https://github.com/ubiety/Ubiety.Xmpp.Core/>
  - Ubiety Stringprep: <https://github.com/ubiety/Ubiety.Stringprep.Core/>
  - Ubiety SCRAM: <https://github.com/ubiety/Ubiety.Scram.Core/>
  - Ubiety Dns: <https://github.com/ubiety/Ubiety.Dns.Core/>

## Ubiety.Logging.Core for enterprise

Available as part of the Tidelift Subscription

The maintainers of Ubiety.Dns.Core and thousands of other packages are working with Tidelift to deliver commercial support and maintenance for the open source dependencies you use to build your applications. Save time, reduce risk, and improve code health, while paying the maintainers of the exact dependencies you use. [Learn more.](https://tidelift.com/subscription/pkg/nuget-ubiety-dns-core?utm_source=nuget-ubiety-dns-core&utm_medium=referral&utm_campaign=enterprise&utm_term=repo)

## Sponsors

### Gold Sponsors

[![Gold Sponsors](https://opencollective.com/ubiety/tiers/gold-sponsor.svg?avatarHeight=36)](https://opencollective.com/ubiety/)

### Silver Sponsors

[![Silver Sponsors](https://opencollective.com/ubiety/tiers/silver-sponsor.svg?avatarHeight=36)](https://opencollective.com/ubiety/)

### Bronze Sponsors

[![Bronze Sponsors](https://opencollective.com/ubiety/tiers/bronze-sponsor.svg?avatarHeight=36)](https://opencollective.com/ubiety/)

## Licensing

The code in this project is licensed under the Apache License version 2.
