namespace Binck.OpenApi.Models.Account.Order
{
    /// <summary>
    /// Specifies the possible values for the order type
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// buy or sell at a specified price or better
        /// </summary>
        Limit,

        /// <summary>
        /// buy or sell immediately at the best available current price
        /// </summary>
        Market,

        /// <summary>
        /// buy or sell immediately at the best available current price when the price surpasses the specified stop price
        /// </summary>
        Stop,

        /// <summary>
        /// buy or sell at a specified price or better when the price surpasses the specified stop price
        /// </summary>
        StopLimit,

        /// <summary>
        /// buy or sell only when the complete order can be filled at once. When not filled the order is canceled when the market closes
        /// </summary>
        AllOrNone
    }
}