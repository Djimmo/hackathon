namespace Binck.OpenApi.Models.Instrument
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Instruments API response (includes paging)
    /// </summary>
    public class InstrumentsResponseModel : OpenApiPagedResponse
    {
        /// <summary>
        /// Collection of zero, one or more instruments
        /// </summary>
        [Required]
        public InstrumentsCollectionModel InstrumentsCollection { get; set; }
    }
}