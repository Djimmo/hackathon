namespace Binck.OpenApi.Models.Account.Balance
{
    using System.Collections.Generic;

    /// <summary>
    /// Collection of zero, one or more balances
    /// </summary>
    public class BalancesCollectionModel
    {
        /// <summary>
        /// Collection of zero, one or more balances
        /// </summary>
        public IEnumerable<BalanceModel> Balances { get; set; }

        /// <summary>
        /// The base currency
        /// </summary>
        public string Currency { get; set; }
    }
}