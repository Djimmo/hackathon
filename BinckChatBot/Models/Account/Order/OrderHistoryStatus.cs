namespace Binck.OpenApi.Models.Models.Account.Order
{
    /// <summary>
    /// Status of the order history
    /// </summary>
    public enum OrderHistoryStatus
    {
        /// <summary>
        /// Order is created but still hasn't been confirmed by the exchange
        /// </summary>
        Placed = 4005,

        /// <summary>
        /// Order placement is confirmed by the exchange
        /// </summary>
        PlacementConfimred = 3134,

        /// <summary>
        /// Order is partially executed
        /// </summary>
        PartiallyExecuted = 4010,

        /// <summary>
        /// Order is completely executed
        /// </summary>
        Executed = 4009,

        /// <summary>
        /// Order is completely expired
        /// </summary>
        Expired = 4006,

        /// <summary>
        /// Order has been requested to be canceled
        /// </summary>
        CancelationRequested = 4003,

        /// <summary>
        /// Order is completely canceled
        /// </summary>
        Canceled = 4004,

        /// <summary>
        ///  Order has been requested to be modified
        /// </summary>
        ModificationRequested = 3136,

        /// <summary>
        /// Order is partially or completely modified
        /// </summary>
        Modified = 3137,

        /// <summary>
        /// Execution is refused
        /// </summary>
        Refused = 3112,

        /// <summary>
        /// Modification request is refused by the exchange but the order is still valid
        /// </summary>
        ModificationRefused = 3138,

        /// <summary>
        /// Cancelation request is refused by the exchange but the order is still valid
        /// </summary>
        CancelationRefused = 3140,

        /// <summary>
        /// Remainder of the order is canceled
        /// </summary>
        RemainderCanceled = 3303,

        /// <summary>
        /// Remainder of the order is expired
        /// </summary>
        RemainderExpired = 7000,

        /// <summary>
        /// Remainder of the order is executed
        /// </summary>
        RemainderExecuted = 4008,

        /// <summary>
        /// All the other statuses which cannot be mapped to statuses in the order status enum
        /// </summary>
        Other = 0
    }
}
