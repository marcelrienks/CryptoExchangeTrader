using System;
using CryptoExchangeTrader.Handlers;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Exchanges
{
    public class Bitfinex : IExchange
    {
        private TradingConfiguration _exchangeConfiguration;
        private IServicesHandler _servicesHandler;

        /// <summary>
        /// Initialise a Bitfinex Exchange
        /// </summary>
        /// <param name="exchangeConfiguration"></param>
        protected Bitfinex(TradingConfiguration exchangeConfiguration, IServicesHandler servicesHandler)
        {
            _exchangeConfiguration = exchangeConfiguration;
            _servicesHandler = servicesHandler;
        }

        #region Public

        public object GetTickersForConfiguredCoins()
        {
            throw new NotImplementedException();
        }

        public object GetInvestedCoinBalances()
        {
            throw new NotImplementedException();
        }

        public object GetOpenTrades()
        {
            throw new NotImplementedException();
        }

        public object GetLastTradesForConfiguredCoins()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
