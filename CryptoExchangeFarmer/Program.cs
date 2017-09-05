using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using CryptoExchangeFarmer.Data;
using CryptoExchangeFarmer.Exchanges;
using CryptoExchangeFarmer.Handlers;

namespace CryptoExchangeFarmer
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
                new FarmingHandler(exchanges).Farm();
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
                    var initialisedExchange = (Exchange)Activator.CreateInstance(Type.GetType($"CryptoExchangeFarmer.Exchanges.{exchangeConfiguration.Name}"));
                    initialisedExchange.Initialise(exchangeConfiguration);
                    exchanges.Add(initialisedExchange);
                }
            }

            return exchanges;
        }
    }
}
