using System;
using System.Configuration;
using CryptoExchangeFarmer.Data;
using CryptoExchangeFarmer.Interfaces;

namespace CryptoExchangeFarmer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var datastore = new DataStore(ConfigurationManager.AppSettings["DataStore"]);
            var exchanges = datastore.GetConfiguredExchanges();

            var exchange = (IExchange)Activator.CreateInstance(Type.GetType($"CryptoExchangeFarmer.Exchanges.{exchanges[0].Name}"));
            exchange.GetTickers();
        }
    }
}
