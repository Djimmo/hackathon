namespace Binck.OpenApi.Models.Account.Position
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Position API response
    /// </summary>
    public class PositionResponse : OpenApiResponse
    {
        /// <summary>
        /// Position information
        /// </summary>
        [Required]
        public PositionsCollectionModel PositionsCollection;
    }
}