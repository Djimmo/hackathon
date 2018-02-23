namespace Binck.OpenApi.Models.Account.Balance
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Balances API response
    /// </summary>
    public class BalancesResponse : OpenApiResponse
    {
        /// <summary>
        /// Collection of zero, one or more balances
        /// </summary>
        [Required]
        public BalancesCollectionModel BalancesCollection { get; set; }
    }
}