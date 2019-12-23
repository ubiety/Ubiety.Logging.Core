/*
 * Licensed under the MIT license
 * See the LICENSE file in the project root for more information
 */

using System;

namespace Ubiety.Logging.Core
{
    /// <summary>
    ///     Defines a logger for the library.
    /// </summary>
    public interface IUbietyLogger
    {
        /// <summary>
        ///     Log a message.
        /// </summary>
        /// <param name="level">Severity level of the message.</param>
        /// <param name="message">Message to log.</param>
        void Log(LogLevel level, object message);

        /// <summary>
        ///     Log an exception with a message.
        /// </summary>
        /// <param name="level">Severity level of the message.</param>
        /// <param name="message">Message to log.</param>
        /// <param name="exception">Exception to log.</param>
        void Log(LogLevel level, object message, Exception exception);
    }
}