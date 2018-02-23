namespace Binck.OpenApi.Models.Account.Position
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Position coverage
    /// </summary>
    public class PositionCoverage
	{
        /// <summary>
        /// Value
        /// </summary>
		public decimal? Value { get; set; }

        /// <summary>
        /// Dynamic rate
        /// </summary>
        public long? DynamicRate { get; set; }

        /// <summary>
        /// Static rate
        /// </summary>
        public long? StaticRate { get; set; }

        /// <summary>
        /// Suppress position coverage information
        /// </summary>
        /// <returns>
        /// true when all attributes are 0, otherwise false
        /// </returns>
        public bool Suppress()
        {
            return (this.Value ?? 0) == 0 && (this.DynamicRate ?? 0) == 0 && (this.StaticRate ?? 0) == 0;
        }
	}
}