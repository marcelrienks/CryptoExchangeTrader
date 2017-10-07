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
            // Collect data
            FetchExchangeData(Exchange.ExchangeConfiguration.CoinPairs);

            // Farming logic:
            //==========================================================

            // For each open trade
            foreach (var openTrade in OpenTrades)
            {
                if (openTrade.Type == TradeType.Buy)
                {
                    //TODO: what should happen here?
                }
                else
                {
                    //TODO: what should happen here?
                }
            }

            // Get all coin pairs that do NOT have open orders
            var nonOpenCoinPairs = Exchange.ExchangeConfiguration.CoinPairs.FindAll(coinPair => !OpenTrades.Contains(new Trade() { CoinPair = coinPair }));

            // For each coin pair not in open orders
            foreach (var coinPair in nonOpenCoinPairs)
            {
                // If last trade was a Buy
                var lastTrade = LastTrades.Find(trade => trade.CoinPair == coinPair);
                if (lastTrade.Type == TradeType.Buy)
                {
                    var positiveDistance = (lastTrade.Price / 100) * double.Parse(StrategyConfiguration.Configurations["PositivePercentage"]);
                    var negativeDistance = (lastTrade.Price / 100) * double.Parse(StrategyConfiguration.Configurations["NegativePercentage"]);

                    // If last trade price is higher than last buy price + positive distance
                    if (Tickers.Find(ticker => ticker.CoinPair == coinPair).LastTradePrice > (lastTrade.Price + positiveDistance))
                    {
                        // Create trailing stop at configured TrailingStopPercent of difference
                        var difference = (lastTrade.Price + positiveDistance) - Tickers.Find(ticker => ticker.CoinPair == coinPair).LastTradePrice;
                        var trailingStopDistance = (difference / 100) * double.Parse(StrategyConfiguration.Configurations["TrailingStopPercent"]);
                        Exchange.CreateTrailingStop(coinPair, trailingStopDistance, InvestedBalances.Find(balance => balance.CoinPair == coinPair).Available);
                    }

                    // If current price is lower than last buy price - negative distance                    
                    else if (Tickers.Find(ticker => ticker.CoinPair == coinPair).LastTradePrice < (lastTrade.Price - negativeDistance))
                        // Create market sell order to cut our losses
                        Exchange.CreateMarketSell(coinPair, InvestedBalances.Find(balance => balance.CoinPair == coinPair).Available);
                }
                else
                {
                    // Create buy order at a percentage below last trade price (to prevent creating a taker order and paying more fee's)
                    //TODO: complete below
                    //Exchange.CreateBuyOrder(coinPair, );
                }
            }
        }

        /// <summary>
        /// Fetch all the data required from the Exchange
        /// </summary>
        /// <param name="coins">the coins for which to fetch all the data</param>
        private void FetchExchangeData(List<string> coins)
        {
            // Use exchange to collect all the data
            InvestedBalances = Exchange.GetMyInvestedBalances(coins);
            OpenTrades = Exchange.GetMyOpenTrades(coins);
            LastTrades = Exchange.GetMyLastTrades(coins);
            Tickers = Exchange.GetCurrentTickers(coins);
        }

        #endregion
    }
}
