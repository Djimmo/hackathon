namespace Binck.OpenApi.Models.Account.Position
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Position margin
    /// </summary>
    public class PositionMargin
	{
        /// <summary>
        /// Value
        /// </summary>
		public decimal? Value { get; set; }

        /// <summary>
        /// Factor
        /// </summary>
        public decimal? Factor { get; set; }

        /// <summary>
        /// Suppress margin information
        /// </summary>
        /// <returns>
        /// true when all attributes are 0, otherwise false
        /// </returns>
        public bool Suppress()
        {
            return (this.Value ?? 0) == 0 && (this.Factor ?? 0) == 0;
        }
    }
}