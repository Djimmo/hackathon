
namespace Binck.OpenApi.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Response on token request to OpenAm
    /// </summary>
    public class OAuthTokenResponse
    {
        /// <summary>
        /// Bearer token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken;

        /// <summary>
        /// seconds till expiration
        /// </summary>
        [JsonProperty("expires_in")]
        public string ExpiresIn;

        /// <summary>
        /// read / write
        /// </summary>
        [JsonProperty("scope")]
        public string Scope;

        /// <summary>
        /// bearer
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType;
    }
}
