namespace BinckChatBot.Contracts
{
    using System;

    public class INDaily
    {
        public DateTime date { get; set; }

        // Data
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public long volume { get; set; }

        public double ex_dividend { get; set; }
        public double split_ratio { get; set; }

        // Adjusted
        public double adj_open { get; set; }
        public double adj_high { get; set; }
        public double adj_low { get; set; }
        public double adj_close { get; set; }
        public long adj_volume { get; set; }
    }
}
