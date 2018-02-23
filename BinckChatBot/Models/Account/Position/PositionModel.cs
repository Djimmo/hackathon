namespace Binck.OpenApi.Models.Account.Position
{
    using System.ComponentModel.DataAnnotations;
    using Binck.OpenApi.Models.Instrument;

    /// <summary>
    /// Position model
    /// </summary>
    public class PositionModel
	{
        /// <summary>
        /// Instrument information
        /// </summary>
        [Required]
        public InstrumentBriefModel Instrument { get; set; }

        /// <summary>
        /// Number of securities or contracts or nominal value
        /// </summary>
        [Required]
		public long Quantity { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [Required]
		public string Currency { get; set; }

        /// <summary>
        /// Accrued interest in case of a debt instrument
        /// </summary>
        public PositionAccruedInterest AccruedInterest { get; set; }

        /// <summary>
        /// Volume weighted average price paid at the time of purchase
        /// </summary>
        public decimal? AverageHistoricalPrice { get; set; }

        /// <summary>
        /// Value of the position expressed in the EURO currency
        /// </summary>
        public decimal? ValueInEuro { get; set; }

	    /// <summary>
	    /// Margin
	    /// </summary>
	    public PositionMargin Margin { get; set; }

        /// <summary>
        /// Result expressed in mentioned currency of instrument
        /// </summary>
        [Required]
        public PositionResult Result { get; set; }

        /// <summary>
        /// Result expressed in the EURO currency
        /// </summary>
        [Required]
        public PositionResult ResultInEuro { get; set; }

        /// <summary>
        /// Value of the portfolio
        /// </summary>
        [Required]
        public decimal Value { get; set; }
    }
}