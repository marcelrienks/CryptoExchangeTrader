using System.Collections.Generic;
using CryptoExchangeTrader.Handlers;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Exchanges
{
    public abstract class Exchange
    {
        public ExchangeConfiguration ExchangeConfiguration;
        private ServicesHandler _servicesHandler;

        /// <summary>
        /// Construct a concrete Exchange
        /// </summary>
        /// <param name="tradingConfiguration">concrete dependency injected TradingConfiguration</param>
        /// <param name="servicesHandler">concrete dependency injected ServicesHandler</param>
        public Exchange(ExchangeConfiguration exchangeConfiguration, ServicesHandler servicesHandler)
        {
            ExchangeConfiguration = exchangeConfiguration;
            _servicesHandler = servicesHandler;
        }

        /// <summary>
        /// Returns the configured coin pairs for this esxchange
        /// </summary>
        /// <returns>List<string></returns>
        public List<string> GetCoinPairs()
        {
            return ExchangeConfiguration.CoinPairs;
        }

        #region Abstract

        public abstract object GetTickersForConfiguredCoins(List<string> CoinPairs);
        public abstract object GetInvestedBalancesForConfiguredCoins(List<string> CoinPairs);
        public abstract object GetOpenTradeForConfiguredCoins(List<string> CoinPairs);
        public abstract object GetLastTradeForConfiguredCoins(List<string> CoinPairs);

        #endregion
    }
}

