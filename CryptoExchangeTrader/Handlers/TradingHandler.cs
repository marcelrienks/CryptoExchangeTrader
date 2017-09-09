using System;
using CryptoExchangeTrader.Data;
using CryptoExchangeTrader.Exchanges;
using CryptoExchangeTrader.Models;
using CryptoExchangeTrader.Stratagies;

namespace CryptoExchangeTrader.Handlers
{
    public class TradingHandler
    {
        private DataStore _data;
        private IExchange _exchange;
        private IStrategy _strategy;
        private TradingConfiguration _tradingConfiguration;

        /// <summary>
        /// Initialse a new Trading handler with supplied exchange and strategy
        /// </summary>
        /// <param name="exchange">dependancy injected exchange</param>
        /// <param name="strategy">dependancy injected strategy</param>
        public TradingHandler(DataStore data, TradingConfiguration tradingConfiguration)
        {
            _data = data;
            _tradingConfiguration = tradingConfiguration;
            InitialiseExchange();
            InitialiseStrategy();
        }

        /// <summary>
        /// Instantiate a concrete exchange
        /// </summary>
        /// <returns>list of configured exchanges</returns>
        private void InitialiseExchange()
        {
            // Using reflection, instantiate a concrete exchange
            var constructorParams = new object[] { _tradingConfiguration, new ServicesHandler(_tradingConfiguration.ApiUrl, _tradingConfiguration.DefaultApiHeaders) };
            var type = Type.GetType($"CryptoExchangeTrader.Exchanges.{_tradingConfiguration.ExchangeName}");
            _exchange = (IExchange)Activator.CreateInstance(type, constructorParams);
        }

        /// <summary>
        /// Instantiate a concrete strategy
        /// </summary>
        private void InitialiseStrategy()
        {
            // Using reflection, instantiate a concrete strategy
            var type = Type.GetType($"CryptoExchangeTrader.Strategy.{_tradingConfiguration.StrategyName}");
            _strategy = (IStrategy)Activator.CreateInstance(type);
        }

        public void Trade()
        {
            
        }
    }
}
