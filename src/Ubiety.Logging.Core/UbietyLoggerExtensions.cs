/*
 * Copyright (C) 2019,2020  Dieter (coder2000) Lunn <coder2000-at-gmail.com>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

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