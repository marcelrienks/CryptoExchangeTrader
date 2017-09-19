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
        private TradingConfiguration _tradingConfiguration;
        private Strategy _strategy;

        /// <summary>
        /// Initialse a new Trading handler with supplied exchange and strategy
        /// </summary>
        /// <param name="exchange">dependancy injected exchange</param>
        /// <param name="strategy">dependancy injected strategy</param>
        public TradingHandler(DataStore data, TradingConfiguration tradingConfiguration)
        {
            _data = data; //QUESTION will this be used in here, or passed to exchange and stratagy
            _tradingConfiguration = tradingConfiguration;

            // Initialise an Exchange and a Strategy 
            var exchange = InitialiseExchange();
            _strategy = InitialiseStrategy(exchange);
        }

        /// <summary>
        /// Instantiate a concrete exchange using reflection
        /// </summary>
        /// <returns>list of configured exchanges</returns>
        private Exchange InitialiseExchange()
        {
            // Using reflection, instantiate a concrete exchange
            var constructorParams = new object[] { _tradingConfiguration, new ServicesHandler(_tradingConfiguration.ApiUrl, _tradingConfiguration.DefaultApiHeaders) };
            var type = Type.GetType($"CryptoExchangeTrader.Exchanges.{_tradingConfiguration.ExchangeName}");
            return (Exchange)Activator.CreateInstance(type, constructorParams);
        }

        /// <summary>
        /// Instantiate a concrete strategy using reflection
        /// </summary>
        private Strategy InitialiseStrategy(Exchange exchange)
        {
            // Using reflection, instantiate a concrete strategy
            var constructorParams = new object[] { exchange };
            var type = Type.GetType($"CryptoExchangeTrader.Strategy.{_tradingConfiguration.StrategyName}");
            return (Strategy)Activator.CreateInstance(type, constructorParams);
        }

        public void Trade()
        {
            // Start Trading
            _strategy.ExecuteStrategy();
        }
    }
}
