using System;
using System.Linq;
using CryptoExchangeFarmer.Interfaces;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Data
{
    public class File : IData
    {
        private string _location;

        public File(string location)
        {
            _location = location;
        }

        public IQueryable<Exchange> GetConfiguredExchanges()
        {
            throw new NotImplementedException();
        }
    }
}
