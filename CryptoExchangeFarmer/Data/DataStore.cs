using System.Collections.Generic;
using System.IO;
using CryptoExchangeFarmer.Interfaces;
using CryptoExchangeFarmer.Models;
using Newtonsoft.Json;

namespace CryptoExchangeFarmer.Data
{
    public class DataStore : IData
    {
        private string _location;

        public DataStore(string location)
        {
            _location = location;
        }

        public List<Exchange> GetConfiguredExchanges()
        {
            List<Exchange> exchanges;

            using (var file = File.OpenText(_location))
            {
                var serializer = new JsonSerializer();
                exchanges = (List<Exchange>)serializer.Deserialize(file, typeof(List<Exchange>));
            }

            return exchanges;
        }

        public void SetConfiguredExchanges(List<Exchange> exchanges)
        {
            using (var file = File.CreateText(_location))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, exchanges);
            }
        }
    }
}
