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
        ///     Log a debug exception.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        /// <param name="exception">Exception to log.</param>
        public static void Debug(this IUbietyLogger logger, object message, Exception exception)
        {
            logger?.Log(LogLevel.Debug, message, exception);
        }

        /// <summary>
        ///     Log a warning message.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        public static void Warning(this IUbietyLogger logger, object message)
        {
            logger?.Log(LogLevel.Warning, message);
        }

        /// <summary>
        ///     Log a warning exception.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        /// <param name="exception">Exception to log.</param>
        public static void Warning(this IUbietyLogger logger, object message, Exception exception)
        {
            logger?.Log(LogLevel.Warning, message, exception);
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

        /// <summary>
        ///     Log a critical message.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        public static void Critical(this IUbietyLogger logger, object message)
        {
            logger?.Log(LogLevel.Critical, message);
        }

        /// <summary>
        ///     Log a critical exception.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        /// <param name="exception">Exception to log.</param>
        public static void Critical(this IUbietyLogger logger, object message, Exception exception)
        {
            logger?.Log(LogLevel.Critical, message, exception);
        }

        /// <summary>
        ///     Log an information message.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        public static void Information(this IUbietyLogger logger, object message)
        {
            logger?.Log(LogLevel.Information, message);
        }

        /// <summary>
        ///     Log an information exception.
        /// </summary>
        /// <param name="logger">Logger to use.</param>
        /// <param name="message">Message to log.</param>
        /// <param name="exception">Exception to log.</param>
        public static void Information(this IUbietyLogger logger, object message, Exception exception)
        {
            logger?.Log(LogLevel.Information, message, exception);
        }
    }
}