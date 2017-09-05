using System;
using System.Collections.Generic;
using CryptoExchangeFarmer.Models;

namespace CryptoExchangeFarmer.Data
{
    public interface IDataStore
    {
        void Log(LogLevel level, string message, Exception exception = null);
        List<ExchangeConfiguration> GetExchangeConfigurations();
        void SetExchangeConfigurations(List<ExchangeConfiguration> exchanges);
    }
}
