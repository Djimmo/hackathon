
namespace Binck.OpenApi.Models.Account.Performance
{
    /// <summary>
    /// Summary for a year or a total summary (in case of year results requested)
    /// </summary>
    public class PerformanceSummaryModel
    {
        /// <summary>
        /// Year for this summary
        /// </summary>
        public string Year { get; set; } 
        
        /// <summary>
        /// Currency for this summary
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Realized profit/loss
        /// </summary>
        public decimal Realized { get; set; }

        /// <summary>
        /// Unrealized profit/loss
        /// </summary>
        public decimal Unrealized { get; set; }

        /// <summary>
        /// Total this year
        /// </summary>
        public decimal? Annual { get; set; }

        /// <summary>
        /// Including previous years
        /// </summary>
        public decimal? PreviousYearsTotal { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }
    }
}
