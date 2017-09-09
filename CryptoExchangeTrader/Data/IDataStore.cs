using System;
using System.Collections.Generic;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Data
{
    public interface IDataStore
    {
        void Log(LogLevel level, string message, Exception exception = null);
        List<TradingConfiguration> GetTradingConfigurations();
        void SetTradingConfigurations(List<TradingConfiguration> exchanges);
    }
}
