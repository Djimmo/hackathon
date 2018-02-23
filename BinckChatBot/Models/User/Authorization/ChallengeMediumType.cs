namespace Binck.OpenApi.Models.User.Authorization
{
    /// <summary>
    /// The media which can be used to receive the challenge.
    /// </summary>
    public enum ChallengeMediumType
    {
        /// <summary>
        /// Use text messaging system for receiving the challenge.
        /// </summary>
        Sms = 1,

        /// <summary>
        /// Push notification.
        /// </summary>
        Push = 2,

        /// <summary>
        /// EmailAddress.
        /// </summary>
        Email = 3
    }
}
