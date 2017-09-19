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
                var dataStore = new DataStore(ConfigurationManager.AppSettings["TradingConfigurationStore"], ConfigurationManager.AppSettings["LogLocation"]);

                // Retrieve all configured exchanges
                var tradingConfigurations = dataStore.GetTradingConfigurations();

                // Run trade for each configuration
                tradingConfigurations?.ForEach(tradingConfiguration => new TradingHandler(dataStore, tradingConfiguration).Trade());
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
            var data = new DataStore(ConfigurationManager.AppSettings["TradingConfigurationStore"], ConfigurationManager.AppSettings["Logs"]);
            data.SetTradingConfigurations(new List<Models.TradingConfiguration>() {
                new Models.TradingConfiguration()
                {
                    Exchange = new Models.ExchangeConfiguration()
                    {
                        Name = "Dummy",
                        ApiUrl = "www",
                        DefaultApiHeaders = new Dictionary<string, string>()
                        {
                            { "header1", "value" },
                            { "header2", "value" }
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
                    },
                    Strategy = new Models.StrategyConfiguration()
                    {
                        Name = "Farming"
                    },
                    TradingMode = Models.Mode.Paper,
                }
            });
        }
    }
}
