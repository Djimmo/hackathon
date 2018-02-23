namespace Binck.OpenApi.Models.Instrument
{
    using System.Collections.Generic;

    /// <summary>
    /// Collection of instruments
    /// </summary>
    public class InstrumentsCollectionModel
    {
        /// <summary>
        /// Collection of instruments
        /// </summary>
        public IEnumerable<InstrumentModel> Instruments { get; set; }
    }
}