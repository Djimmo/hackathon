namespace Binck.OpenApi.Models.Account.Performance
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Performances API response
    /// </summary>
    public class PerformancesResponse : OpenApiResponse
    {
        /// <summary>
        /// Collection of zero, one or more performances for positions
        /// </summary>
        [Required]
        public PerformanceCollectionModel PerformancesCollection;

        /// <summary>
        /// Summary of the performances
        /// </summary>
        public PerformanceSummaryModel Summary;
    }
}
