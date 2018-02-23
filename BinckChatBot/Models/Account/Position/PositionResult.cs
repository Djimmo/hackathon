namespace Binck.OpenApi.Models.Account.Position
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Position result
    /// </summary>
    public class PositionResult
	{
        /// <summary>
        /// Currency the result is expressed in
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Unrealized result
        /// </summary>
		public decimal? Unrealized { get; set; }

        /// <summary>
        /// Realized result
        /// </summary>
        [Required]
        public decimal Realized { get; set; }

        /// <summary>
        /// Total result
        /// </summary>
        [Required]
        public decimal Total { get; set; }

        /// <summary>
        /// Unrealized result in a percentage of ... (?)
        /// </summary>
		public decimal? UnrealizedPercentage { get; set; }

        /// <summary>
        /// Purchase value
        /// </summary>
        [Required]
        public decimal PurchaseValue { get; set; }
    }
}