using System;

namespace Ubiety.Logging.Core
{
    /// <summary>
    ///     Extensions for logger to make logging easier.
    /// </summary>
    public static class UbietyLoggerExtensions
    {
        /// <summary>
        ///     Log a debug message.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        public static void Debug(this IUbietyLogger logger, object message)
        {
            logger?.Log(LogLevel.Debug, message);
        }

        /// <summary>
        ///     Log an error message.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        public static void Error(this IUbietyLogger logger, object message)
        {
            logger?.Log(LogLevel.Error, message);
        }

        /// <summary>
        ///     Log an error exception.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="exception">Exception to log.</param>
        /// <param name="message">Message to log.</param>
        public static void Error(this IUbietyLogger logger, Exception exception, object message)
        {
            logger?.Log(LogLevel.Error, message, exception);
        }
    }
}