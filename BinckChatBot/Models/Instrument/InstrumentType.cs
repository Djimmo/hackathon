namespace Binck.OpenApi.Models.Instrument
{
    /// <summary>
    /// Specifies the type of the instrument
    /// </summary>
    /// 
    /// InstrumentType is based on Topline type 'ProgressiveSearchCategorie'
    /// 
    public enum InstrumentType
    {
        /// <summary>
        /// Exchange Indexes
        /// </summary>
        Index = 0,

        /// <summary>
        /// Equities
        /// </summary>
        Equity = 1,

        /// <summary>
        /// Sprinters
        /// </summary>
        Sprinter = 2,

        /// <summary>
        /// Turbos
        /// </summary>
        Turbo = 3,

        /// <summary>
        /// Speeders
        /// </summary>
        Speeder = 4,

        /// <summary>
        /// Other Leveraged products
        /// </summary>
        OtherLeveragedProduct = 5,

        /// <summary>
        /// Discounters
        /// </summary>
        Discounter = 6,

        /// <summary>
        /// Option class
        /// </summary>
        OptionClass = 7,

        /// <summary>
        /// Options
        /// </summary>
        Option = 8,

        /// <summary>
        /// Investment Funds
        /// </summary>
        InvestmentFund = 9,

        /// <summary>
        /// Trackers
        /// </summary>
        Tracker = 10,

        /// <summary>
        /// Future classes
        /// </summary>
        FutureClass = 11,

        /// <summary>
        /// Futures
        /// </summary>
        Future = 12,

        /// <summary>
        /// Bonds
        /// </summary>
        Bond = 13,

        /// <summary>
        /// Warrants
        /// </summary>
        Warrant = 14,

        /// <summary>
        /// Certificates
        /// </summary>
        Certificate = 15,

        /// <summary>
        /// Structured Products
        /// </summary>
        StructuredProduct = 16,

        /// <summary>
        /// SRD classes
        /// </summary>
        SrdClass = 17,

        /// <summary>
        /// SRD instruments
        /// </summary>
        Srd = 18,

        /// <summary>
        /// Emissions
        /// </summary>
        Ipo = 19,

        /// <summary>
        /// Claims
        /// </summary>
        Claim = 20,

        /// <summary>
        /// Choice Dividends
        /// </summary>
        ChoiceDividend = 21,

        /// <summary>
        /// Stock Dividends
        /// </summary>
        StockDividend = 22,

        /// <summary>
        /// Cash Dividends
        /// </summary>
        CashDividend = 23,

        /// <summary>
        /// Coupons
        /// </summary>
        Coupon = 24,

        /// <summary>
        /// Unclassified
        /// </summary>
        Unclassified = 25
    }
}