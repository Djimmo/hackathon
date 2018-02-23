namespace Binck.OpenApi.Models.Instrument
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Response type for list of all instrument lists
    /// </summary>
    public class InstrumentListsResponse : OpenApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public InstrumentListsCollectionModel InstrumentListsCollection { get; set; }
    }
}
