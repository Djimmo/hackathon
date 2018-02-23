
namespace Binck.OpenApi.Models.Account.Order
{
    /// <summary>
    /// Specifies a miscellaneous characteristic of an order
    /// </summary>
    public enum OrderMiscellaneousType
    {
        /// <summary>
        /// Normal order
        /// </summary>
        Normal,

        /// <summary>
        /// Wholesale order
        /// </summary>
        Wholesale,

        /// <summary>
        /// Evening trade order
        /// </summary>
        EveningTrade,

        /// <summary>
        /// Batch order
        /// </summary>
        BatchOrder
    }
}