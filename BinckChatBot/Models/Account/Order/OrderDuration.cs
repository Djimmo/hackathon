namespace Binck.OpenApi.Models.Account.Order
{
    /// <summary>
    /// Specifies the possible values for the term for which the order is in effect
    /// </summary>

    public enum OrderDuration
    {
        /// <summary>
        /// Execute the order immediately and completely or not at all
        /// </summary>
        FillOrKill,

        /// <summary>
        /// Execute the order immediately and any portion of the order that cannot be immediately filled is cancelled
        /// </summary>
        ImmediateOrCancel,

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
        GoodTillDate,

        /// <summary>
        /// Execute the order at the opening of the market or not at all
        /// </summary>
        AtTheOpening,

        /// <summary>
        /// Cancel any remaining portion of the order before the market enters the auction or crossing phase
        /// </summary>
        GoodTillCrossing
    }
}