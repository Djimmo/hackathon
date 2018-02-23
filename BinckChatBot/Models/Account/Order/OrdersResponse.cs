namespace Binck.OpenApi.Models.Account.Order
{
    using Binck.OpenApi.Models;
    using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// Orders API response (includes paging)
	/// </summary>
	public class OrdersResponse : OpenApiPagedResponse
	{
        /// <summary>
        /// Collection of zero, one or more orders
        /// </summary>
        [Required]
        public OrdersCollectionModel OrdersCollection { get; set; }
    }
}