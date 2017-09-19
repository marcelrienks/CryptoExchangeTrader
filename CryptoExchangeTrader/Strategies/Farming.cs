using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoExchangeTrader.Exchanges;

namespace CryptoExchangeTrader.Stratagies
{
    public class Farming : Strategy
    {
        /// <summary>
        /// Construct a concrete Farming Strategy
        /// </summary>
        /// <param name="exchange">concrete dependency injected Exchange</param>
        public Farming(Exchange exchange) : base(exchange)
        {
        }

        #region Public

        public override void ExecuteStrategy()
        {
            //TODO:
            // 2. TODO: Logic to handle open trades
            // 3. Foreach Currency Pair if last trade was a Buy
            // 3.1 If current price is higher than last buy price + positive distance
            // 3.1.1 Create trailing stop at positive distance
            // 3.2 If current price is lower than last buy price + negative distance
            // 3.2.1 Create stop order at current price
            // 4. Foreach Currency Pair if last trade was a Sell
            // 4.1 TODO: Logic for when last trade was a sell

            // Use exchange to collect all the data
            var investedCoinBalances = _exchange.GetInvestedBalancesForConfiguredCoins(_tradingConfiguration.CoinPairs);
            var openTrades = _exchange.GetOpenTradeForConfiguredCoins(_tradingConfiguration.CoinPairs);
            var lastClosedTrade = _exchange.GetLastTradeForConfiguredCoins(_tradingConfiguration.CoinPairs);
            var currentTickers = _exchange.GetTickersForConfiguredCoins(_tradingConfiguration.CoinPairs);
        }
        
        #endregion
    }
}
