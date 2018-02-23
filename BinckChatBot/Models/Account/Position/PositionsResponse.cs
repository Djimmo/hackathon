namespace Binck.OpenApi.Models.Account.Position
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Positions API response (includes paging)
    /// </summary>
    public class PositionsResponse : OpenApiPagedResponse
    {
        /// <summary>
        /// Collection of zero, one or more positions
        /// </summary>
        [Required]
        public PositionsCollectionModel PositionsCollection { get; set; }
    }
}