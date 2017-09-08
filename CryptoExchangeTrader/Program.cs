using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using CryptoExchangeTrader.Data;
using CryptoExchangeTrader.Exchanges;
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
                var data = new DataStore(ConfigurationManager.AppSettings["Exchanges"], ConfigurationManager.AppSettings["Logs"]);
                var exchanges = InitialiseExchanges(data);

                // Start Farming
                foreach (var exchange in exchanges)
                {
                    new FarmingHandler(exchange).Farm(); 
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        /// <summary>
        /// Initialises configured exchanges
        /// </summary>
        /// <returns>list of configured exchanges</returns>
        private static List<Exchange> InitialiseExchanges(DataStore data)
        {
            List<Exchange> exchanges = null;

            // Retrieve all configured exchanges
            var exchangeConfigurations = data.GetExchangeConfigurations();
            if (exchangeConfigurations != null && exchangeConfigurations.Any())
            {
                exchanges = new List<Exchange>();
                foreach (var exchangeConfiguration in exchangeConfigurations)
                {
                    // Using reflection, instantiate configured exchange
                    var constructorParams = new object[] { exchangeConfiguration, new ServicesHandler(exchangeConfiguration.ApiUrl, exchangeConfiguration.DefaultApiHeaders) };
                    var type = Type.GetType($"CryptoExchangeTrader.Exchanges.{exchangeConfiguration.Name}");
                    var initialisedExchange = (Exchange)Activator.CreateInstance(type, constructorParams);

                    // Add concrete exchange to list
                    exchanges.Add(initialisedExchange);
                }
            }

            return exchanges;
        }

        /// <summary>
        /// This method will generate a new ExchangeConfiguration json file with dummy data.
        /// Set a breakpoint in the beginning of the main thread, and call this function through the immediate window
        /// </summary>
        private static void GenerateDummyExchangeConfiguration()
        {
            var data = new DataStore(ConfigurationManager.AppSettings["Exchanges"], ConfigurationManager.AppSettings["Logs"]);
            data.SetExchangeConfigurations(new List<Models.ExchangeConfiguration>() {
                new Models.ExchangeConfiguration()
                {
                    Name = "Dummy",
                    ApiUrl = "www",
                    CustomApiSettings = new Dictionary<string, string>()
                    {
                        { "header1", "value" },
                        { "header2", "value" }
                    },
                    CoinPairs = new List<string>()
                    {
                        "coin",
                        "coin"
                    }
                }
            });
        }
    }
}
