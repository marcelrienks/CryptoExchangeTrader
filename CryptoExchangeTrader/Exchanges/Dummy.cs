using System;
using System.Collections.Generic;
using CryptoExchangeTrader.Handlers;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Exchanges
{
    public class Dummy : Exchange
    {
        /// <summary>
        /// Initialise a Dummy Exchange used for testing
        /// </summary>
        /// <param name="tradingConfiguration">concrete dependency injected TradingConfiguration</param>
        /// <param name="servicesHandler">concrete dependency injected ServicesHandler</param>
        public Dummy(ExchangeConfiguration exchangeConfiguration, ServicesHandler servicesHandler) : base(exchangeConfiguration, servicesHandler)
        {
        }

        #region Public

        /// <summary>
        /// Generates a Dummy list of balances for testing
        /// </summary>
        /// <param name="CurrencyPairs">the currency pairs to generate dummy data for</param>
        /// <returns></returns>
        public override List<Balance> GetMyInvestedBalances(List<string> CurrencyPairs)
        {
            var result = new List<Balance>();
            foreach (var currencyPair in CurrencyPairs)
            {
                result.Add(new Balance()
                {
                    CurrencyPair = currencyPair,
                    Total = 0.0005,
                    Available = 0.0003
                });
            }

            return result;
        }

        /// <summary>
        /// Generates a Dummy list of closed trades for testing
        /// </summary>
        /// <param name="CurrencyPairs">the currency pairs to generate dummy data for</param>
        /// <returns></returns>
        public override List<Trade> GetMyLastTrades(List<string> CurrencyPairs)
        {
            var result = new List<Trade>();
            foreach (var currencyPair in CurrencyPairs)
            {
                result.Add(new Trade()
                {
                    CurrencyPair = currencyPair,
                    Date = DateTime.Now,
                    Price = 0.001,
                    Amount = 0.0005,
                    Type = TradeType.Sell
                });
            }

            return result;
        }

        /// <summary>
        /// Generates a Dummy list of open trades for testing
        /// </summary>
        /// <param name="CurrencyPairs">the currency pairs to generate dummy data for</param>
        /// <returns></returns>
        public override List<Trade> GetMyOpenTrades(List<string> CurrencyPairs)
        {
            var result = new List<Trade>();
            foreach (var currencyPair in CurrencyPairs)
            {
                result.Add(new Trade()
                {
                    CurrencyPair = currencyPair,
                    Date = DateTime.Now,
                    Price = 0.001,
                    Amount = 0.0005,
                    Type = TradeType.Sell
                });
            }

            return result;
        }

        /// <summary>
        /// Generates a Dummy list of Tickers for testing
        /// </summary>
        /// <param name="CurrencyPairs">the currency pairs to generate dummy data for</param>
        /// <returns></returns>
        public override List<Ticker> GetCurrentTickers(List<string> CurrencyPairs)
        {
            var result = new List<Ticker>();
            foreach (var currencyPair in CurrencyPairs)
            {
                result.Add(new Ticker()
                {
                    CurrencyPair = currencyPair,
                    LastTradePrice = "4000"
                });
            }

            return result;
        }

        #endregion
    }
}
