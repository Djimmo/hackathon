namespace Binck.OpenApi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Binck.OpenApi.Models.Utilies.JSonConverters;

    using Newtonsoft.Json;

    /// <summary>
    /// API response meta data 
    /// </summary>
    public class MetadataModel
    {
        /// <summary>
        /// Version information
        /// </summary>
        [Required]
        public string Version { get; set; }

        /// <summary>
        /// Date and time the response is created
        /// </summary>
        [Required]
        [JsonConverter(typeof(JsonDateTime_WithTimezone))]
        public DateTime? Timestamp { get; set; }
    }
}