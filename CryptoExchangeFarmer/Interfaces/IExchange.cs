using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoExchangeFarmer.Interfaces
{
    public interface IExchange
    {
        object GetTickers();
    }
}
