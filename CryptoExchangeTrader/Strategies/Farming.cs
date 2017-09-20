using System.Collections.Generic;
using CryptoExchangeTrader.Exchanges;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Stratagies
{
    public class Farming : Strategy
    {
        /// <summary>
        /// Construct a concrete Farming Strategy
        /// </summary>
        /// <param name="exchange">concrete dependency injected Exchange</param>
        public Farming(StrategyConfiguration strategyConfiguration, Exchange exchange) : base(strategyConfiguration, exchange)
        {
        }

        #region Public

        public override void ExecuteStrategy()
        {
            FetchExchangeData(Exchange.ExchangeConfiguration.CoinPairs);
            //TODO:
            // 2. TODO: Logic to handle open trades
            // 3. Foreach Currency Pair if last trade was a Buy
            // 3.1 If current price is higher than last buy price + positive distance
            // 3.1.1 Create trailing stop at positive distance
            // 3.2 If current price is lower than last buy price + negative distance
            // 3.2.1 Create stop order at current price
            // 4. Foreach Currency Pair if last trade was a Sell
            // 4.1 TODO: Logic for when last trade was a sell
        }

        /// <summary>
        /// Fetch all the data required from the Exchange
        /// </summary>
        /// <param name="coins">the coins for which to fetch all the data</param>
        private void FetchExchangeData(List<string> coins)
        {
            // Use exchange to collect all the data
            InvestedBalances = Exchange.GetMyInvestedBalances(coins);
            OpenTrade = Exchange.GetMyOpenTrades(coins);
            LastTrade = Exchange.GetMyLastTrades(coins);
            Tickers = Exchange.GetCurrentTickers(coins);
        }
        
        #endregion
    }
}
