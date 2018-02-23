namespace Binck.OpenApi.Models.Instrument.Derivative
{
    using System;

    /// <summary>
    /// Derivatives series information
    /// </summary>
    public class DerivativeSeriesInfoModel
    {
        /// <summary>
        /// Instrument Id of the serie
        /// </summary>
        public string InstrumentId { get; set; }

        /// <summary>
        /// Strike price (options only)
        /// </summary>
        public decimal? Strike { get; set; }

        /// <summary>
        /// Number of decimals in strike price (options only)
        /// </summary>
        public int? StrikeDecimals { get; set; }

        /// <summary>
        /// Option type (put or call) (options only)
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