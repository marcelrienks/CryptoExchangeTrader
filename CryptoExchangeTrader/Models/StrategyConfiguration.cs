using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchangeTrader.Models
{
    public class StrategyConfiguration
    {
        public string Name { get; set; }
        public Dictionary<string, string> Configurations { get; set; }
    }
}
