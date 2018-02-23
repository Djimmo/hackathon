namespace Binck.OpenApi.Models.Account.Transaction
{
    using System.Collections.Generic;

    /// <summary>
    /// The model for the transactions endpoint
    /// </summary>
    public class TransactionsCollectionModel
    {
        /// <summary>
        /// Collection of transactions
        /// </summary>
        public IEnumerable<TransactionModel> Transactions { get; set; }
    }
}
