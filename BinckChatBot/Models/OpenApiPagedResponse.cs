namespace Binck.OpenApi.Models
{
    using System;
    using System.Configuration;

    /// <summary>
    /// OpenAPI paged response
    /// </summary>
    public class OpenApiPagedResponse : OpenApiResponse
    {
        /// <summary>
        /// Maximum number of rows per page
        /// </summary>
        public static readonly int MaxNrRowsInPage =
            Convert.ToInt32(ConfigurationManager.AppSettings["MaxNrRowsInPage"]);

        /// <summary>
        /// Maximum number of rows per page for instruments progressive search
        /// </summary>
        public static readonly int MaxNrRowsInProgressiveSearchPage = 20;

        /// <summary>
        /// Paging information
        /// </summary>
        public PagingModel Paging { get; set; }
    }
}