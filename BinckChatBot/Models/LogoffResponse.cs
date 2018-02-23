namespace Binck.OpenApi.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Response of the logoff request.
    /// </summary>
    public class LogoffResponse : OpenApiResponse
    {
        /// <summary>
        /// A message confirming the sign out is complete
        /// </summary>
        [Required]
        public string Message { get; set; }
    }
}