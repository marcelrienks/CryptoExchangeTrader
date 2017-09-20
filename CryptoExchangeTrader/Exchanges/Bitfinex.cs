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
        public Bitfinex(ExchangeConfiguration exchangeConfiguration, ServicesHandler servicesHandler) : base (exchangeConfiguration, servicesHandler)
        {
        }

        #region Public

        public override List<Balance> GetMyInvestedBalances(List<string> CurrencyPairs)
        {
            throw new NotImplementedException();
        }

        public override List<Trade> GetMyOpenTrades(List<string> CurrencyPairs)
        {
            throw new NotImplementedException();
        }

        public override List<Trade> GetMyLastTrades(List<string> CurrencyPairs)
        {
            throw new NotImplementedException();
        }

        public override List<Ticker> GetCurrentTickers(List<string> CurrencyPairs)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
