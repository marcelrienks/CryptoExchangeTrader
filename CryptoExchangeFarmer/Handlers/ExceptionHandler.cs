using System;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Handlers
{
    public static class ExceptionHandler
    {
        /// <summary>
        /// Handles the exception that was rasied
        /// </summary>
        /// <param name="ex">the exception that was raised</param>
        public static void HandleException(Exception ex)
        {
            LoggingHandler.LogEvent(LogLevel.Exception, ex.Message, ex);
            //TODO: handle disposing and shutting down app, But only if we're headless
            //If we're running in console, don't shut down
        }
    }
}
