
namespace Binck.OpenApi.Models.Account.Order
{
    using Binck.OpenApi.Models;

    /// <summary>
    /// Preview Order API response
    /// </summary>
    public class PreviewOrderResponse : OpenApiResponse
    {
        /// <summary>
        /// Information related to the order validation such as if the order is processable, spending power, etc.
        /// </summary>
        public PreviewOrderModel PreviewOrder { get; set; }
    }
}