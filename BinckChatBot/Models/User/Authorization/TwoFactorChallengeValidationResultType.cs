namespace Binck.OpenApi.Models.User.Authorization
{
    /// <summary>
    /// Specifies the values which are returned by the initiation of the second factor
    /// </summary>
    public enum TwoFactorChallengeValidationResultType
    {
        /// <summary>
        /// New session was created
        /// </summary>
        Success = 1,

        /// <summary>
        /// Invalid or conflicting arguments were passed
        /// </summary>
        InvalidData = 2,

        /// <summary>
        /// The challenge has expired, a new challenge should be requested
        /// </summary>
        Expired = 3,

        /// <summary>
        /// A validation was already tried and failed for this challenge, user should request a new challenge
        /// </summary>
        AlreadyFailed = 4,

        /// <summary>
        /// The client challenge value did not match. This counts as a failed attempt (the number of failed attempts is limited per relation)
        /// </summary>
        Failed = 5,

        /// <summary>
        /// Validation failed and account has reached maximum attempts: account will be locked for further logins until reset by service desk
        /// </summary>
        FailedAndMaxFailuresReached = 6
    }
}
