using System;
using System.Collections.Generic;
using System.Text;

namespace BittrexSharp.Domain
{
    public class Ticker
    {
        public string MarketName { get; set; }
        public decimal? Bid { get; set; }
        public decimal? Ask { get; set; }
        public decimal? Last { get; set; }
    }

    public class TickerV2
    {
        public string MarketName { get; set; }
        public decimal? BV { get; set; }
        public decimal? C { get; set; }
        public decimal? H { get; set; }
        public decimal? L { get; set; }
        public decimal? O { get; set; }
        public DateTime? T { get; set; }
        public decimal? V { get; set; }

    }
}
