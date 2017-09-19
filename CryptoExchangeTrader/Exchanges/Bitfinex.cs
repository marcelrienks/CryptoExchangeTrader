using System;
using System.Collections.Generic;
using CryptoExchangeTrader.Handlers;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Exchanges
{
    public class Bitfinex : Exchange
    {
        /// <summary>
        /// Initialise a Bitfinex Exchange
        /// </summary>
        /// <param name="tradingConfiguration">concrete dependency injected tradingConfiguration</param>
        /// <param name="servicesHandler">concrete dependency injected servicesHandler</param>
        public Bitfinex(TradingConfiguration tradingConfiguration, ServicesHandler servicesHandler) : base (tradingConfiguration, servicesHandler)
        {
        }

        #region Public

        public override object GetTickersForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public override object GetInvestedBalancesForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public override object GetOpenTradeForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        public override object GetLastTradeForConfiguredCoins(List<string> CoinPairs)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
