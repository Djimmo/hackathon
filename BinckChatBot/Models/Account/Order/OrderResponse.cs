namespace Binck.OpenApi.Models.Account.Order
{
    using Binck.OpenApi.Models;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Order API response
    /// </summary>
	public class OrderResponse : OpenApiResponse
	{
        /// <summary>
        /// Collection of zero, one or more orders
        /// </summary>
        [Required]
        public OrdersCollectionModel OrdersCollection { get; set; }
    }
}