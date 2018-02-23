
namespace Binck.OpenApi.Models.Account.Performance
{
    using System.Collections.Generic;

    /// <summary>
    /// Collection of zero, one or more performances for positions
    /// </summary>
    public class PerformanceCollectionModel
    {
        /// <summary>
        /// Collection of zero, one or more performances for positions
        /// </summary>
        public IEnumerable<PerformanceDetailModel> Performances;
    }
}
