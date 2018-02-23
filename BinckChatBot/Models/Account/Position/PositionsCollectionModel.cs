namespace Binck.OpenApi.Models.Account.Position
{
    using System.Collections.Generic;

    /// <summary>
    /// Collection of positions
    /// </summary>
    public class PositionsCollectionModel
    {
        /// <summary>
        /// Collection of positions
        /// </summary>
        public IEnumerable<PositionModel> Positions { get; set; }
    }
}