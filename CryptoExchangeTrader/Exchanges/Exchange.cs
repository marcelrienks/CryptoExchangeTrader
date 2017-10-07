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

        // Get Data
        public abstract List<Balance> GetMyInvestedBalances(List<string> currencyPairs);
        public abstract List<Trade> GetMyOpenTrades(List<string> currencyPairs);
        public abstract List<Trade> GetMyLastTrades(List<string> currencyPairs);
        public abstract List<Ticker> GetCurrentTickers(List<string> currencyPairs);

        // Create
        public abstract void CreateTrailingStop(string currencyPair, double distance, double sellAmount);
        public abstract void CreateMarketSell(string currencyPair, double sellAmount);
        public abstract void CreateBuyOrder(string currencyPair, double buyAmount);

        #endregion
    }
}

