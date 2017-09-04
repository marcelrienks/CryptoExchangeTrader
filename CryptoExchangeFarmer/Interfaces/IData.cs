using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Interfaces
{
    public interface IData
    {
        IQueryable<Exchange> GetConfiguredExchanges();
    }
}
