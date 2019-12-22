namespace Ubiety.Logging.Core
{
    /// <summary>
    ///     Defines an interface for a log manager.
    /// </summary>
    public interface IUbietyLogManager
    {
        /// <summary>
        ///     Get a logger for the given name.
        /// </summary>
        /// <param name="name">Name of the logger.</param>
        /// <returns>Logger.</returns>
        IUbietyLogger GetLogger(string name);
    }
}