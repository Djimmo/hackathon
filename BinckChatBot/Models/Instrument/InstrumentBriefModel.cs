namespace Binck.OpenApi.Models.Instrument
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Brief instrument information
    /// </summary>
    public class InstrumentBriefModel
	{
        /// <summary>
        /// Identification of the instrument
        /// </summary>
        [Required]
		public string Id { get; set; }

        /// <summary>
        /// Instrument's name
        /// </summary>
        [Required]
        public string Name { get; set; }
        
        /// <summary>
        /// True is no instrument information is available (object is 'empty')
        /// </summary>
        /// <returns></returns>
        public bool Suppress()
        {
            return string.IsNullOrEmpty(this.Id);
        }
	}
}