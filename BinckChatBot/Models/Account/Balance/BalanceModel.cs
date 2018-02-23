namespace Binck.OpenApi.Models.Account.Balance
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Balance model
    /// </summary>
    public class BalanceModel
    {
        /// <summary>
        /// Assets total value
        /// </summary>
        [Required]
        public decimal AssetsTotalValue { get; set; }

        /// <summary>
        /// Cash balance
        /// </summary>
        [Required]
        public decimal CashBalance { get; set; }

        /// <summary>
        /// Portfolio value
        /// </summary>
        [Required]
        public decimal PortfolioValue { get; set; }

        /// <summary>
        /// Spending power
        /// </summary>
        public decimal AvailableSpendingLimit { get; set; }
    }
}