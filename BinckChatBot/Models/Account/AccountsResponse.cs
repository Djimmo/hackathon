namespace Binck.OpenApi.Models.Account
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Accounts API response
    /// </summary>
    public class AccountsResponse : OpenApiResponse
    {
        /// <summary>
        /// Collection of zero, one or more accounts
        /// </summary>
        [Required]
        public AccountsCollectionModel AccountsCollection { get; set; }
    }
}