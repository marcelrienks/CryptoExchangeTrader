using System;
using System.Collections.Generic;
using System.IO;
using CryptoExchangeTrader.Models;
using Newtonsoft.Json;

namespace CryptoExchangeTrader.Data
{
    public class DataStore : IDataStore
    {
        private string _exchangesLocation;
        private string _logsLocation;

        /// <summary>
        /// Initialise Data Store
        /// </summary>
        /// <param name="location"></param>
        public DataStore(string exchangesLocation, string logsLocation)
        {
            _exchangesLocation = exchangesLocation;
            _logsLocation = logsLocation;
        }

        /// <summary>
        /// Logs events or exceptions to a log file
        /// </summary>
        /// <param name="level">level of the log</param>
        /// <param name="message">message of the log</param>
        /// <param name="exception">the exception to be logged</param>
        public void Log(LogLevel level, string message, Exception exception = null)
        {
            // Check location
            if (!File.Exists(_logsLocation))
                File.Create(_logsLocation);

            // Generate message
            string log;
            if (exception == null)
                log = $"{DateTime.Now}: {level} - {message}";

            else
                log = $"{DateTime.Now}: {level} - {message}{Environment.NewLine}Exception: {exception.Message}{Environment.NewLine}StackTrace: {exception.StackTrace}{Environment.NewLine}Inner: {exception.InnerException?.Message}";

            // Write logs to file
            using (var file = File.AppendText(_exchangesLocation))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, log);
            }
        }

        /// <summary>
        /// Get configured trading from Data Store
        /// </summary>
        /// <returns>list of trading configurations</returns>
        public List<TradingConfiguration> GetTradeingConfigurations()
        {
            List<TradingConfiguration> tradingConfigurations;

            // Write data to file
            using (var file = File.OpenText(_exchangesLocation))
            {
                var serializer = new JsonSerializer();
                tradingConfigurations = (List<TradingConfiguration>)serializer.Deserialize(file, typeof(List<TradingConfiguration>));
            }

            return tradingConfigurations;
        }

        /// <summary>
        /// Set configured trading into Data Store
        /// </summary>
        /// <param name="tradingConfigurations">list of trading configurations</param>
        public void SetTradingConfigurations(List<TradingConfiguration> tradingConfigurations)
        {
            // Read data from file
            using (var file = File.CreateText(_exchangesLocation))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, tradingConfigurations);
            }
        }
    }
}
