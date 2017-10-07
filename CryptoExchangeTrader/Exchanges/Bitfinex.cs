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

        //TODO: Implement methods below

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

        public override void CreateTrailingStop(string currencyPair, double distance, double sellAmount)
        {
            throw new NotImplementedException();
        }

        public override void CreateMarketSell(string currencyPair, double sellAmount)
        {
            throw new NotImplementedException();
        }

        public override void CreateBuyOrder(string currencyPair, double buyAmount)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
