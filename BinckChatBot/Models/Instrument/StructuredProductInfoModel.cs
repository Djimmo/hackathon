
namespace Binck.OpenApi.Models.Instrument
{
    /// <summary>
    /// In topline : leveraged product info
    /// Intentionally left empty
    /// </summary>
    public class StructuredProductInfoModel
    {
        /// <summary>
        /// Suppress structured product information
        /// </summary>
        /// <returns>
        /// true when all attributes are 0 or null, otherwise false
        /// </returns>
        public bool Suppress()
        {
            return true;
        }
    }
}
