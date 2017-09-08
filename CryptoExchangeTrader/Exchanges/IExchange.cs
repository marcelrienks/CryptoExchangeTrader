namespace CryptoExchangeTrader.Exchanges
{
    public interface IExchange
    {
        #region Abstract

        object GetTickersForConfiguredCoins();
        object GetInvestedCoinBalances();
        object GetOpenTrades();
        object GetLastTradesForConfiguredCoins();

        #endregion
    }
}
