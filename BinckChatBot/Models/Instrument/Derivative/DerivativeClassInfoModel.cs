
namespace Binck.OpenApi.Models.Instrument.Derivative
{
    using System.Collections.Generic;

    /// <summary>
    /// The model for derivatives - future ans option classes
    /// </summary>
    public class DerivativeClassInfoModel
    {
        /// <summary>
        /// Identification of the underlying instrument
        /// </summary>
        public string UnderlyingInstrumentId { get; set; }

        /// <summary>
        /// Name of the class
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Symbol of the class
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// ISIN Code of the class
        /// </summary>
        public string Isincode { get; set; }

        /// <summary>
        /// ISO MIC of the class
        /// </summary>
        public string MarketIdentificationCode { get; set; }

        /// <summary>
        /// Currency of the class
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Type of the class (option or future class)
        /// </summary>
        public InstrumentType Type { get; set; }

        /// <summary>
        /// Contract Size of the class
        /// </summary>
        public decimal? ContractSize { get; set; }

        /// <summary>
        /// Collection of series for this class
        /// </summary>
        public IEnumerable<DerivativeSeriesInfoModel> Series { get; set; }
    }
}