
namespace Binck.OpenApi.Models.Account.Performance
{
    using Binck.OpenApi.Models.Instrument;
    using Constants;

    /// <summary>
    /// Performance for one instrument. Due to rounding errors some calculation have difference of one cent. 
    /// </summary>
    public class PerformanceDetailModel
    {
        /// <summary>
        /// Currency of the reported amounts
        /// </summary>
        public readonly string Currency = Constants.CurrencyEuro;

        /// <summary>
        /// Instrument information
        /// </summary>
        public InstrumentBriefModel Instrument { get; set; }

        /// <summary>
        /// Year in case of summary info
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// Realized profit/loss
        /// </summary>
        public decimal Realized { get; set; }

        /// <summary>
        /// Unrealized profit/loss
        /// </summary>
        public decimal Unrealized { get; set; }

        /// <summary>
        /// This year
        /// </summary>
        public decimal? Annual { get; set; }

        /// <summary>
        /// Including previous years
        /// </summary>
        public decimal? PreviousYearsTotal { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        public decimal? Total { get; set; }
    }
}