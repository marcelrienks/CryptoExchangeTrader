using System;

namespace CryptoExchangeTrader.Models
{
    public class Trade
    {
        public string CurrencyPair { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public TradeType Type { get; set; }
    }
}
