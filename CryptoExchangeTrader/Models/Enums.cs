namespace CryptoExchangeTrader.Models
{
    /// <summary>
    /// Log levels
    /// </summary>
    public enum LogLevel
    {
        None,
        Debug,
        Info,
        Error,
        Exception
    }

    /// <summary>
    /// The mode in which to run the trades in
    /// </summary>
    public enum Mode
    {
        Backtest,
        Paper,
        Live
    }

    /// <summary>
    /// The type of trade
    /// </summary>
    public enum TradeType
    {
        Buy,
        Sell
    }
}
