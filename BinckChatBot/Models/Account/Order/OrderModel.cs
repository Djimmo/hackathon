namespace Binck.OpenApi.Models.Account.Order
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Binck.OpenApi.Models.Instrument;
    using Binck.OpenApi.Models.Models.Account.Order;

    /// <summary>
    /// Order model
    /// </summary>
    public class OrderModel
    {
        /// <summary>
        /// The identification of the order
        /// </summary>
        [Required]
        public long Number { get; set; }

        /// <summary>
        /// Attributes of the financial instrument ordered
        /// </summary>
        [Required]
        public InstrumentBriefModel Instrument { get; set; }

        /// <summary>
        /// Miscellaneous characteristic of the order
        /// </summary>
        [Required]
        public OrderMiscellaneousType MiscellaneousType { get; set; }

        /// <summary>
        /// The price type of the order
        /// </summary>
        [Required]
        public OrderType Type { get; set; }

        /// <summary>
        /// Status history of the order
        /// </summary>
        [Required]
        public StatusHistory[] StatusHistory { get; set; }

        /// <summary>
        /// The currency of the security
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Specifies the term for which the order is in effect
        /// </summary>
        [Required]
        public OrderDuration Duration { get; set; }

        /// <summary>
        /// Line number of this order in case of a multi line order
        /// </summary>
        public long Line { get; set; }

        /// <summary>
        /// Kind of transaction as text
        /// </summary>
        [Required]
        public string TransactionKind { get; set; }

        /// <summary>
        /// Number of instruments (equities), nominal value (odds) or number of contracts (options and futures) to be executed
        /// </summary>
        public decimal? Executed { get; set; }

        /// <summary>
        /// Value of the order's limit
        /// </summary>
        public decimal? LimitPrice { get; set; }

        /// <summary>
        /// Average price of all fills on this order
        /// </summary>
        public decimal? AveragePrice { get; set; }

        /// <summary>
        /// Quantity ordered
        /// </summary>
        [Required]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Expiration date and time for a good till date order
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Status of the order last executed
        /// </summary>
        [Required]
        public OrderHistoryStatus LastStatus { get; set; }

        /// <summary>
        /// Stop price for a stop or stop limit order
        /// </summary>
        public decimal? StopPrice { get; set; }

        /// <summary>
        /// The reason of rejection in case of a rejected order
        /// </summary>
        public string RejectionReason { get; set; }

        /// <summary>
        /// Fixing price of the order
        /// </summary>
        public decimal? FixingPrice { get; set; }

        /// <summary>
        /// Detail explanation of the reason for rejection of the order
        /// </summary>
        public string RejectionReasonDetail { get; set; }
    }
}