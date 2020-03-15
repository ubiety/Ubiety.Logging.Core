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