namespace Binck.OpenApi.Models.Account.Transaction
{
    /// <summary>
    /// Mutation Groups
    /// </summary>
    public enum MutationGroup
    {
        /// <summary>
        /// Money transfers
        /// Money transfers in and out. Includes mutation types: OGEX, OGIN, REG
        /// </summary>
        MoneyTransfer,
        /// <summary>
        /// Dividend payments
        /// Dividend payments. Includes mutation types: UKDVD
        /// </summary>
        DividendPayments,
        /// <summary>
        /// Coupon payments
        /// Coupon Payments. Dividend payments. Includes mutation types: UKCPN
        /// </summary>
        CouponPayments,
        /// <summary>
        /// Interest payments
        /// Interest payments. Dividend payments. Includes mutation types: RTCR, RTDB
        /// </summary>
        InterestPayments,
        /// <summary>
        /// Position Mutations trades
        /// Position mutations trades. Includes mutation types: K, V, OK, OKF, OV, OBF, SK, SV, SVF, EX C, EX P, AS C,AS P
        /// </summary>
        PositionMutations,
        /// <summary>
        /// Costs
        /// Costs. Includes mutation types: VRKV
        /// </summary>
        Costs,
        /// <summary>
        /// Only buys and sells
        /// Buy and sell. Includes mutation types: K, V
        /// </summary>
        BuyAndSell,
        /// <summary>
        /// Securities lending
        /// </summary>
        SecLenPayments
    }
}
