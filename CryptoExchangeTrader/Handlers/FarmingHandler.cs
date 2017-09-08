using System.Collections.Generic;
using CryptoExchangeTrader.Exchanges;

namespace CryptoExchangeTrader.Handlers
{
    public class FarmingHandler
    {
        private Exchange _exchange;

        public FarmingHandler(Exchange exchange)
        {
            _exchange = exchange;
        }

        /// <summary>
        /// Run through each configured Exchange, and start Farming
        /// </summary>
        public void Farm()
        {
            //TODO:
            // 1. Collect
            // 1.1 Configured Currency Pair tickers
            // 1.2 Coin balances
            // 1.3 Open Trades
            // 1.4 Last Closed trade for each Currency Pair
            // 2. TODO: Logic to handle open trades
            // 3. Foreach Currency Pair if last trade was a Buy
            // 3.1 If current price is higher than last buy price + positive distance
            // 3.1.1 Create trailing stop at positive distance
            // 3.2 If current price is lower than last buy price + negative distance
            // 3.2.1 Create stop order at current price
            // 4. Foreach Currency Pair if last trade was a Sell
            // 4.1 TODO: Logic for when last trade was a sell
        }
    }
}
