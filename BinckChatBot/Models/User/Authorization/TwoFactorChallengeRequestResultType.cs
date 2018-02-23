namespace Binck.OpenApi.Models.User.Authorization
{
    /// <summary>
    /// Specifies the values which are returned by the initiation of the second factor
    /// </summary>
    public enum TwoFactorChallengeRequestResultType
    {
        /// <summary>
        /// Challenge is created and sent to user
        /// </summary>
        Success = 1,

        /// <summary>
        /// Invalid session id/account id/relation id combination or client has no phone number - this should not happen unless the the client disregards the 'NoMobile' result from the logon
        /// </summary>
        InvalidData = 2,

        /// <summary>
        /// Too many challenges were requested recent were requested in a 'short' period. Current limit is max. of 5 in last 5 minutes - waiting a short amount of time will allow a new challenge again
        /// </summary>
        TooManyChallengesShortPeriod = 3,

        /// <summary>
        /// Too many challenges were requested recent were requested in a 'long' period. Current limit is 100 in 24 hours
        /// </summary>
        TooManyChallengesLongPeriod = 4
    }
}
