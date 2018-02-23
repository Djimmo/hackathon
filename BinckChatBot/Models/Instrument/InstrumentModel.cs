
namespace Binck.OpenApi.Models.Instrument
{
    /// <summary>
    /// Instrument model
    /// </summary>
    public class InstrumentModel
    {
        /// <summary>
        /// Identification of the instrument
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the instrument
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Symbol of the instrument
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// ISIN-code of the instrument
        /// </summary>
        public string Isincode { get; set; }

        /// <summary>
        /// OptionType of the instrument
        /// </summary>
        public InstrumentType Type { get; set; }

        /// <summary>
        /// Market Identification Code of the instrument
        /// </summary>
        //     not int the Design
        public string MarketIdentificationCode { get; set; }

        /// <summary>
        /// Derivative serie information
        /// </summary>
        public DerivativesInfoModel DerivativesInfo { get; set; }

        /// <summary>
        /// Bond only information
        /// </summary>
        public BondInfoModel BondInfo { get; set; }

        /// <summary>
        /// Currency of the instrument
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Ticker symbol of the instrument
        /// </summary>
        public string TickerSymbol { get; set; }
    }
}