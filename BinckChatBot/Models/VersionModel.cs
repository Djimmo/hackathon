namespace Binck.OpenApi.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Version model
    /// </summary>
    public class VersionModel : OpenApiResponse
    {
        /// <summary>
        /// Current version
        /// </summary>
        [Required]
        public string CurrentVersion { get; set; }
        /// <summary>
        /// Build date 
        /// </summary>
        [Required]
        public string BuildDate { get; set; }
    }
}