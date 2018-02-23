
namespace Binck.OpenApi.Models.Instrument
{
    /// <summary>
    /// One FundList entry
    /// </summary>
    public class InstrumentListModel
    {
        /// <summary>
        /// Name of the list as can be used in the instruments calls
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Short description of the list
        /// </summary>
        public string Description { get; set; }
    }
}
