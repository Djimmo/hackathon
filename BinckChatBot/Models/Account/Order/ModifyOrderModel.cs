namespace Binck.OpenApi.Models.Account.Order
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Modify order model
    /// </summary>
    public class ModifyOrderModel
    {
        /// <summary>
        /// Order Number of Account.
        /// </summary>
        [Required]
        public long OrderNumber { get; set; }

        /// <summary>
        /// Order Linenumber of Account.
        /// </summary>
        [Required]
        public int OrderLineNumber { get; set; }

        /// <summary>
        /// New Limit Price of the Order.
        /// </summary>
        [Required]
        public decimal NewLimitPrice { get; set; }
    }
}