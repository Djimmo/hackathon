namespace Binck.OpenApi.Models.User.Authorization
{
    /// <summary>
    /// Response type for get user authorization
    /// </summary>
    public class UserAuthorizationResponse : OpenApiResponse
    {
        /// <summary>
        /// User authorization data
        /// </summary>
        public UserAuthorizationModel UserAuthorization { get; set; }
    }

    /// <summary>
    /// Response type for get challenge
    /// </summary>
    public class ChallengeRequestResponse : OpenApiResponse
    {
        /// <summary>
        /// Challenge request data
        /// </summary>
        public ChallengeRequestModel ChallengeRequest { get; set; }
    }

    /// <summary>
    /// Response type for post challenge
    /// </summary>
    public class ChallengeValidateResponse : OpenApiResponse
    {
        /// <summary>
        /// Challenge validation data
        /// </summary>
        public ChallengeValidateModel ChallengeValidate { get; set; }
    }
}