
namespace Binck.OpenApi.Models.Instrument
{
    using System;
    using Binck.OpenApi.Models.Instrument.Derivative;

    /// <summary>
    /// Derivatives series model
    /// </summary>
    public class DerivativesInfoModel
    {
        /// <summary>
        /// Instrument Id
        /// </summary>
        public string UnderlyingInstrumentId { get; set; }

        /// <summary>
        /// Strike price
        /// </summary>
        public decimal? Strike { get; set; }

        /// <summary>
        /// Maximum number of decimals in strike price
        /// </summary>
        public int? StrikeDecimals { get; set; }

        /// <summary>
        /// Option type (put or call)
        /// </summary>
        public OptionType? OptionType { get; set; }

        /// <summary>
        /// Contract size
        /// </summary>
        public decimal? ContractSize { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        public DateTime? ExpirationDate { get; set; }
    }
}