namespace Binck.OpenApi.Models.Account
{
    using System.Collections.Generic;

    /// <summary>
    /// Collection of zero, one or more accounts
    /// </summary>
    public class AccountsCollectionModel
    {
        /// <summary>
        /// Collection of zero, one or more accounts
        /// </summary>
        public IEnumerable<AccountModel> Accounts { get; set; }
    }
}