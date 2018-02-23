namespace Binck.OpenApi.Models
{
    /// <summary>
    /// Paging model for offset base pagination
    /// </summary>
    public class PagingModel
    {
        /// <summary>
        /// Number of entries in the complete collection
        /// </summary>
        public long Count { get; set; }

        /// <summary>
        /// Offset of the last entry in this subset
        /// </summary>
        public long Limit { get; set; }

        /// <summary>
        /// Maximum number of entries per subset
        /// </summary>
        public long Max { get; set; }

        /// <summary>
        /// Offset of the first entry in this subset
        /// </summary>
        public long Offset { get; set; }

        /// <summary>
        /// parameter and value to add to the request to retrieve the next subset
        /// </summary>
        public string Next { get; set; }

        /// <summary>
        /// parameter and value to add to the request to retrieve the previous subset
        /// </summary>
        public string Previous { get; set; }

        /// <summary>
        /// parameter and value to add to the request to retrieve the same subset
        /// </summary>
        public string Refresh { get; set; }
    }
}