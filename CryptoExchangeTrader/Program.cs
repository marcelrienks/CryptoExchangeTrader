using System;
using System.Collections.Generic;
using System.Configuration;
using CryptoExchangeTrader.Data;
using CryptoExchangeTrader.Handlers;

namespace CryptoExchangeTrader
{
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                // Initialise
                var data = new DataStore(ConfigurationManager.AppSettings["TradingConfiguration"], ConfigurationManager.AppSettings["Logs"]);

                // Retrieve all configured exchanges
                var tradingConfigurations = data.GetTradingConfigurations();

                // Run trade for each configuration
                tradingConfigurations?.ForEach(tradingConfiguration => new TradingHandler(data, tradingConfiguration).Trade());
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        /// <summary>
        /// This method will generate a new ExchangeConfiguration json file with dummy data.
        /// Set a breakpoint in the beginning of the main thread, and call this function through the immediate window
        /// </summary>
        private static void GenerateDummyExchangeConfiguration()
        {
            var data = new DataStore(ConfigurationManager.AppSettings["TradingConfiguration"], ConfigurationManager.AppSettings["Logs"]);
            data.SetTradingConfigurations(new List<Models.TradingConfiguration>() {
                new Models.TradingConfiguration()
                {
                    ExchangeName = "Dummy",
                    StrategyName = "Farming",
                    TradingMode = Models.Mode.Paper,
                    ApiUrl = "www",
                    DefaultApiHeaders = new Dictionary<string, string>()
                    {
                        { "header1", "value" },
                        { "header1", "value" }
                    },
                    CustomApiSettings = new Dictionary<string, string>()
                    {
                        { "header1", "value" },
                        { "header2", "value" }
                    },
                    CoinPairs = new List<string>()
                    {
                        "btcusd",
                        "ethbtc",
                        "ltcbtc"
                    }
                }
            });
        }
    }
}
