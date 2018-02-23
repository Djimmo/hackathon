namespace Binck.OpenApi.Models.Account.Transaction
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Binck.OpenApi.Models.Instrument;

    /// <summary>
    /// Transaction model
    /// </summary>
    public class TransactionModel
    {
        /// <summary>
        /// Currency code for an account
        /// </summary>
        [Required]
        public string AccountCurrency { get; set; }

        /// <summary>
        /// State the uniqueness of this number for an account
        /// </summary>
        [Required]
        public long Number { get; set; }

        /// <summary>
        /// The transaction date is the date when the transaction is effective
        /// </summary>
        [Required]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// The date on which the transfer between two parties is executed
        /// </summary>
        public DateTime? SettlementDate { get; set; }

        /// <summary>
        /// Enumerated value of the mutation type 
        /// </summary>
        [Required]
        public MutationType MutationType { get; set; }

        /// <summary>
        /// Human readable description of the mutation details
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Total amount when the transaction is completed
        /// </summary>
        public decimal? BalanceMutation { get; set; }

        /// <summary>
        /// Total amount when the transaction is completed
        /// </summary>
        public decimal? MutatedBalance { get; set; }

        /// <summary>
        /// The instrument object
        /// </summary>
        public InstrumentBriefModel Instrument { get; set; }

        /// <summary>
        /// The price of one instrument
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// The number of financial instruments to buy or sell
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Name of the exchange where this instrument was handled
        /// </summary>
        public string Exchange { get; set; }

        /// <summary>
        /// All costs for this transaction
        /// </summary>
        public decimal? TotalCosts { get; set; }

        /// <summary>
        /// Transaction currency. This currency was used to complete this transaction
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// The total amount for this transaction without the costs
        /// </summary>
        public decimal? NetAmount { get; set; }

        /// <summary>
        /// The exchange rate used for the transaction currency
        /// </summary>
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// All Cost components for this transactions
        /// </summary>
        public TransactionCostComponentModel[] TransactionCostComponents;
    }
}
