/*
 * Licensed under the MIT license
 * See the LICENSE file in the project root for more information
 */

namespace Ubiety.Logging.Core
{
    /// <summary>
    ///     Log severity level.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        ///     Critical level message.
        /// </summary>
        Critical,

        /// <summary>
        ///     Error level message.
        /// </summary>
        Error,

        /// <summary>
        ///     Warning level message.
        /// </summary>
        Warning,

        /// <summary>
        ///     Information level message.
        /// </summary>
        Information,

        /// <summary>
        ///     Debug level message.
        /// </summary>
        Debug,
    }
}