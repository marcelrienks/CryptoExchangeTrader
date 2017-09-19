using System.Collections.Generic;
using CryptoExchangeTrader.Handlers;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Exchanges
{
    public abstract class Exchange
    {
        public TradingConfiguration _tradingConfiguration;
        public ServicesHandler _servicesHandler;

        /// <summary>
        /// Construct a concrete Exchange
        /// </summary>
        /// <param name="tradingConfiguration">concrete dependency injected TradingConfiguration</param>
        /// <param name="servicesHandler">concrete dependency injected ServicesHandler</param>
        public Exchange(TradingConfiguration tradingConfiguration, ServicesHandler servicesHandler)
        {
            _tradingConfiguration = tradingConfiguration;
            _servicesHandler = servicesHandler;
        }

        #region Abstract

        public abstract object GetTickersForConfiguredCoins(List<string> CoinPairs);
        public abstract object GetInvestedBalancesForConfiguredCoins(List<string> CoinPairs);
        public abstract object GetOpenTradeForConfiguredCoins(List<string> CoinPairs);
        public abstract object GetLastTradeForConfiguredCoins(List<string> CoinPairs);

        #endregion
    }
}

