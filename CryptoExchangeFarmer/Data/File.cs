using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CryptoExchangeFarmer.Interfaces;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Data
{
    public class File : IData
    {
        private string _location;

        public File()
        {
            _location = 
        }

        public IQueryable<Exchange> GetConfiguredExchanges()
        {
            throw new NotImplementedException();
        }
    }
}
