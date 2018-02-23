
namespace Binck.OpenApi.Models.Instrument.Derivative
{
    using System.Collections.Generic;

    /// <summary>
    /// Collection of instruments
    /// </summary>
    public class DerivativesCollectionModel
    {
        /// <summary>
        /// Derivative classes collection
        /// </summary>
        public IEnumerable<DerivativeClassInfoModel> Classes { get; set; }
    }
}