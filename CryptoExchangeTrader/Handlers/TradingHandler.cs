using CryptoExchangeTrader.Exchanges;
using CryptoExchangeTrader.Models;
using CryptoExchangeTrader.Stratagies;

namespace CryptoExchangeTrader.Handlers
{
    public class TradingHandler
    {
        private IExchange _exchange;
        private IStrategy _strategy;
        private TradingConfiguration _tradingConfiguration;

        /// <summary>
        /// Initialse a new Trading handler with supplied exchange and strategy
        /// </summary>
        /// <param name="exchange">dependancy injected exchange</param>
        /// <param name="strategy">dependancy injected strategy</param>
        public TradingHandler(IExchange exchange, IStrategy strategy, TradingConfiguration tradingConfiguration)
        {
            _exchange = exchange;
            _strategy = strategy;
            _tradingConfiguration = tradingConfiguration;
        }

        /// <summary>
        /// Run through each configured Exchange, and start Farming
        /// </summary>
        public void Trade()
        {
            
        }
    }
}
