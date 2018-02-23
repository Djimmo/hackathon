namespace Binck.OpenApi.Models.Account.Order
{
    /// <summary>
    /// Specifies the possible values for the term for which the order is in effect
    /// </summary>
    public enum NewOrderDuration
    {
        /// <summary>
        /// The order automatically expires if not executed on the day the order was placed
        /// </summary>
        Day,

        /// <summary>
        /// The order remains active until is either cancelled by the investor or is executed
        /// </summary>
        GoodTillCancelled,

        /// <summary>
        /// The order remains active until the specified expiry date, unless it has been completely executed or cancelled
        /// </summary>
        GoodTillDate
    }
}