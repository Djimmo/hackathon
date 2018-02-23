namespace Binck.OpenApi.Models.Account.Transaction
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Transaction API response
    /// </summary>
    public class TransactionsResponse : OpenApiPagedResponse
    {
        /// <summary>
        /// Collection of zero, one or more Transactions
        /// </summary>
        [Required]
        public TransactionsCollectionModel TransactionsCollection { get; set; }
    }
}
