
namespace Binck.OpenApi.Models.Account.Order
{
    using System;

    /// <summary>
    /// This object is used in the response of the order validation call.
    /// </summary>
    public class PreviewOrderModel
    {
        /// <summary>
        /// True if the order can be placed
        /// </summary>
        public bool OrderCanBeRegistered { get; set; }

        /// <summary>
        /// For GTD en GTC orders the enddate will be limited to about 2 weeks maximum
        /// </summary>
        public DateTime? ExpectedExpirationDate { get; set; }

        /// <summary>
        /// Contains the position effect information (open, close)
        /// </summary>
        public string PositionEffect { get; set; }

        /// <summary>
        /// Effect of a succesfully placed order on the spending limit of the account
        /// </summary>
        public decimal EffectOnSpendingLimit { get; set; }
        
        /// <summary>
        /// The current spending limit of the account (before placing the order)
        /// </summary>
        public decimal CurrentSpendingLimit { get; set; }

        /// <summary>
        /// The new spending limit of the account (after placing the order)
        /// </summary>
        public decimal NewSpendingLimit { get; set; }

        /// <summary>
        /// The currency of the spending limit
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Risk number before placing the order
        /// </summary>
        public int OldRiskNumber { get; set; }

        /// <summary>
        /// Risk number after successfully placing the order
        /// </summary>
        public int NewRiskNumber { get; set; }

        /// <summary>
        /// Recommended risk number
        /// </summary>
        public int RecommendedRiskNumber { get; set; }

        /// <summary>
        /// Warnings or error messages about the requested order
        /// </summary>
        public string[] Warnings { get; set; }
    }
}