using System;
using CryptoExchangeFarmer.Data;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Handlers
{
    public class LoggingHandler
    {
        private static string _previousMessage;
        private static IDataStore _dataStore;

        internal static void LogEvent(object exception, string message, Exception ex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initialises this log handler with a supplied Data Source handler
        /// </summary>
        /// <param name="dataStore"></param>
        public static void InitialiseLoggingHandler(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        /// <summary>
        /// Log to console, vary the colour based on log level
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        public static void LogEvent(LogLevel level, string message, Exception exception = null)
        {
            if (_previousMessage == message)
                return;

            _previousMessage = message;

            // Log to various locations
            ConsoleLog(level, message, exception);
            DataLog(level, message, exception);
        }

        /// <summary>
        /// Log to Console
        /// </summary>
        /// <param name="level">the log level of the message</param>
        /// <param name="message">the message to be logged</param>
        private static void ConsoleLog(LogLevel level, string message, Exception exception = null)
        {
            // Set console font colour
            switch (level)
            {
                case LogLevel.None:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogLevel.Debug:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevel.Exception:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }

            // Log to console
            Console.WriteLine($"{level.ToString()} : {message.PadRight(Console.WindowWidth - 1)}");

            if (exception != null)
            {
                Console.WriteLine($"MESSAGE: {exception.Message?.PadRight(Console.WindowWidth - 1)}");
                Console.WriteLine($"STACK: {exception.StackTrace?.PadRight(Console.WindowWidth - 1)}");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"INNER: {exception.InnerException?.Message?.PadRight(Console.WindowWidth - 1)}");
            }

            Console.ResetColor();
        }

        /// <summary>
        /// Log to supplied Data Source handler
        /// </summary>
        /// <param name="level">the log level of the message</param>
        /// <param name="message">the message to be logged</param>
        private static void DataLog(LogLevel level, string message, Exception exception = null)
        {
            _dataStore.Log(level, message, exception);
        }
    }
}
