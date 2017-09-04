using System;
using System.Configuration;
using System.Reflection;
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

            var myObject = Activator.CreateInstance("CryptoExchangeFarmer", exchanges[0].Name);
        }
    }
}
