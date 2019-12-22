using System;
using System.Linq;

namespace Ubiety.Logging.Core
{
    /// <summary>
    ///     DNS logger class.
    /// </summary>
    public static class UbietyLogger
    {
        private static IUbietyLogManager _dnsLogManager = new DefaultLogManager();

        /// <summary>
        ///     Gets logger for the provided type.
        /// </summary>
        /// <typeparam name="T">Type to name the logger.</typeparam>
        /// <returns>Logger named for the type.</returns>
        public static IUbietyLogger Get<T>()
        {
            return _dnsLogManager.GetLogger(NameFor<T>());
        }

        /// <summary>
        ///     Initializes logger.
        /// </summary>
        /// <param name="logManager">Log manager instance.</param>
        public static void Initialize(IUbietyLogManager logManager)
        {
            _dnsLogManager = logManager;
        }

        private static string NameFor<T>()
        {
            return NameFor(typeof(T));
        }

        private static string NameFor(Type type)
        {
            if (!type.IsGenericType)
            {
                return type.FullName;
            }

            var name = type.GetGenericTypeDefinition().FullName;

            return
                $"{name?.Substring(0, name.IndexOf('`'))}<{string.Join(",", type.GetGenericArguments().Select(NameFor).ToArray())}>";
        }

        private class DefaultLogManager : IUbietyLogManager
        {
            public IUbietyLogger GetLogger(string name)
            {
                return new DefaultLogger(name);
            }

            private class DefaultLogger : IUbietyLogger
            {
                private readonly string _name;

                public DefaultLogger(string name)
                {
                    _name = name;
                }

                public void Log(LogLevel level, object message)
                {
                    throw new NotImplementedException();
                }

                public void Log(LogLevel level, object message, Exception exception)
                {
                    throw new NotImplementedException();
                }

                private void Log(LogLevel level, string message)
                {
                    Console.WriteLine($"[{_name}::{level}] {message}");
                }
            }
        }
    }
}