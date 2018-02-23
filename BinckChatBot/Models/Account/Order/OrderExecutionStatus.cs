namespace Binck.OpenApi.Models.Account.Order
{
    /// <summary>
    /// Status of the executions of the order
    /// </summary>
    public enum OrderExecutionStatus
    {
        /// <summary>
        /// Open
        /// </summary>
        Open = 0,

        /// <summary>
        /// Completely executed
        /// </summary>
        CompletelyExecuted = 1,

        /// <summary>
        /// Partially executed
        /// </summary>
        PartiallyExecuted = 2,

        /// <summary>
        /// Remainder is executed
        /// </summary>
        RemainderExecuted = 3,
    }
}
