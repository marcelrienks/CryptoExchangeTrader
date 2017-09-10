using System.Collections.Generic;

namespace CryptoExchangeTrader.Exchanges
{
    public interface IExchange
    {
        #region Abstract

        object GetTickersForConfiguredCoins(List<string> CoinPairs);
        object GetInvestedBalancesForConfiguredCoins(List<string> CoinPairs);
        object GetOpenTradeForConfiguredCoins(List<string> CoinPairs);
        object GetLastTradeForConfiguredCoins(List<string> CoinPairs);

        #endregion
    }
}

