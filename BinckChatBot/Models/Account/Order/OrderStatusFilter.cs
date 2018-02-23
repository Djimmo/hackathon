namespace Binck.OpenApi.Models.Account.Order
{
    /// <summary>
    /// Different order statusses
    /// </summary>
    public enum OrderStatusFilter
    {
        /// <summary>
        /// All orders
        /// </summary>
        All,
        /// <summary>
        /// Open orders
        /// </summary>
        Open,
        /// <summary>
        /// Execured orders
        /// </summary>
        Executed,
        /// <summary>
        /// Cancelled orders
        /// </summary>
        Cancelled
    }
}
