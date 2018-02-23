namespace Binck.OpenApi.Models.Account.Order
{
    using System.Collections.Generic;
    using Binck.OpenApi.Models;

	/// <summary>
	/// Collection of orders
	/// </summary>
	public class OrdersCollectionModel
	{
	    /// <summary>
	    /// Collection of orders
	    /// </summary>
	    public IEnumerable <OrderModel> Orders { get; set; }
    }
}

