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
                var data = new DataStore(ConfigurationManager.AppSettings["TradingConfiguration"], ConfigurationManager.AppSettings["Logs"]);
                var configurations = InitialiseConfigurations(data);

                // Start Farming
                foreach (var configuration in configurations)
                {
                    //new TradingHandler(configuration).Trade(); 
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        //TODO: the mothod below needs to be rewritten after adding both exchange and stratagy to a configuration
        // It should return an concrete IExchange and IStrategy

        /// <summary>
        /// Initialises configured exchanges
        /// </summary>
        /// <returns>list of configured exchanges</returns>
        private static List<IExchange> InitialiseConfigurations(DataStore data)
        {
            List<IExchange> exchanges = null;

            // Retrieve all configured exchanges
            var exchangeConfigurations = data.GetTradeingConfigurations();
            if (exchangeConfigurations != null && exchangeConfigurations.Any())
            {
                exchanges = new List<IExchange>();
                foreach (var exchangeConfiguration in exchangeConfigurations)
                {
                    // Using reflection, instantiate configured exchange
                    var constructorParams = new object[] { exchangeConfiguration, new ServicesHandler(exchangeConfiguration.ApiUrl, exchangeConfiguration.DefaultApiHeaders) };
                    var type = Type.GetType($"CryptoExchangeTrader.Exchanges.{exchangeConfiguration.ExchangeName}");
                    var initialisedExchange = (IExchange)Activator.CreateInstance(type, constructorParams);

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
            var data = new DataStore(ConfigurationManager.AppSettings["TradingConfiguration"], ConfigurationManager.AppSettings["Logs"]);
            data.SetTradingConfigurations(new List<Models.TradingConfiguration>() {
                new Models.TradingConfiguration()
                {
                    ExchangeName = "Dummy",
                    StratagyName = "Dummy",
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
