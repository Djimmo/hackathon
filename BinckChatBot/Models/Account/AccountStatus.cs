namespace Binck.OpenApi.Models.Account
{
    /// <summary>
    /// Specifies the status of an account
    /// </summary>
    public enum AccountStatus
    {
        /// <summary>
        /// The account is activated and can be used
        /// </summary>
        Active = 0,

        /// <summary>
        /// The account is not activated or deactivated and can not be used
        /// </summary>
        Inactive = 1,

        /// <summary>
        /// The account is pending and can not be used until the application process ends
        /// </summary>
        PendingApplication = 2
    }
}
