namespace Binck.OpenApi.Models.Account.Position
{
    /// <summary>
    /// Position accrued interest
    /// </summary>
    public class PositionAccruedInterest
	{
        /// <summary>
        /// Value
        /// </summary>
		public decimal? Value { get; set; }

        /// <summary>
        /// Rate
        /// </summary>
        public decimal? Rate { get; set; }

        /// <summary>
        /// Suppress position accrued interest
        /// </summary>
        /// <returns>
        /// true when all attributes are 0, otherwise false
        /// </returns>
        public bool Suppress()
        {
            return (this.Value ?? 0) == 0 && (this.Rate ?? 0) == 0;
        }
    }
}