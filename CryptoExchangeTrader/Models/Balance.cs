namespace CryptoExchangeTrader.Models
{
    public class Balance
    {
        public string CoinPair { get; set; }
        public double Total { get; set; }
        public double Available { get; set; }
    }
}
