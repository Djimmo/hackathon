namespace Binck.OpenApi.Models.Models.Account.Order
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// History of the order status
    /// </summary>
    public class StatusHistory
    {
        /// <summary>
        /// DateTime of the status
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// name of the status
        /// </summary>
        [Required]
        public OrderHistoryStatus Status { get; set; }

        /// <summary>
        /// The number of orders executed
        /// </summary>
        public decimal? ExecutedQuantity { get; set; }
    }
}
