namespace Binck.OpenApi.Models
{
    using Binck.OpenApi.Models.Constants;

    /// <summary>
    /// Error message model
    /// </summary>
    public class ErrorMessageModel
    {
        /// <summary>
        /// Gets or sets the developer message
        /// </summary>
        /// <value>
        /// The message
        /// </value>
        public string DeveloperMessage { set; get; }

        /// <summary>
        /// Gets or sets the enduser message
        /// </summary>
        /// <value>
        /// The message
        /// </value>
        public string EndUserMessage { set; get; }

        /// <summary>
        /// Gets or sets the error code
        /// </summary>
        /// <value>
        /// The error code
        /// </value>
        public string ErrorCode { set; get; }

        /// <summary>
        /// Gets or sets the error identifier
        /// </summary>
        /// <value>
        /// The error identifier
        /// </value>
        public ErrorCode? ErrorId { set; get; }
    }
}