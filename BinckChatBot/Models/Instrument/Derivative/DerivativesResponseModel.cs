
namespace Binck.OpenApi.Models.Instrument.Derivative
{
    /// <summary>
    /// Derivatives API response
    /// </summary>
    public class DerivativesResponseModel : OpenApiPagedResponse
    {
        /// <summary>
        /// Derivative classes information
        /// </summary>
        public DerivativesCollectionModel DerivativesCollection { get; set; }
    }
}