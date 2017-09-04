using System.Collections.Generic;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Interfaces
{
    public interface IData
    {
        List<Exchange> GetConfiguredExchanges();
        void SetConfiguredExchanges(List<Exchange> exchanges);
    }
}
