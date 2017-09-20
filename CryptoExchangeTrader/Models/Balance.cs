namespace CryptoExchangeTrader.Models
{
    public class Balance
    {
        public string CurrencyPair { get; set; }
        public double Total { get; set; }
        public double Available { get; set; }
    }
}
