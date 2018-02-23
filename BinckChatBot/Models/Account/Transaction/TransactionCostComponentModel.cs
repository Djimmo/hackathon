namespace Binck.OpenApi.Models.Account.Transaction
{
    using Binck.OpenApi.Models.Models.Account.Transaction;

    /// <summary>
    /// Transaction costs components
    /// </summary>
    public class TransactionCostComponentModel
    {
        /// <summary>
        /// Amount for the costs
        /// </summary>
        public decimal Cost { get; set; }
 
        /// <summary>
        /// Currency of these costs
        /// </summary>
        public string Currency { get; set; }
        
        /// <summary>
        /// Costs category
        /// </summary>
        public CostTypeCategory CostTypeCategory { get; set; }

        /// <summary>
        /// Percentage of the transaction amount
        /// </summary>
        public decimal? AmountPercentage { get; set; }

    }
}
