using System;
using System.Collections.Generic;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Data
{
    public interface IDataStore
    {
        void Log(LogLevel level, string message, Exception exception = null);
        List<TradingConfiguration> GetTradeingConfigurations();
        void SetTradingConfigurations(List<TradingConfiguration> exchanges);
    }
}
