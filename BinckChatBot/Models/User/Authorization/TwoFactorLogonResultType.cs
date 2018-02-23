namespace Binck.OpenApi.Models.User.Authorization
{
    /// <summary>
    /// Specifies the values which are returned by the logon call.
    /// </summary>
    public enum TwoFactorLogonResultType
    {
        /// <summary>
        /// Two factor logon is not enabled for the relation (does not apply)
        /// </summary>
        NotEnabled = 1,

        /// <summary>
        /// This is a readonly password login, so no two factor authentication is needed.
        /// </summary>
        EnabledButReadonlyLogin = 2,

        /// <summary>
        /// Two factor authentication applies, but customer has no mobile number to do it. Session will be in readonly mode except for password changes.
        /// </summary>
        EnabledButNoMobile = 3,

        /// <summary>
        /// Session is in 'readonly except password change' mode but can be upgraded.
        /// </summary>
        EnabledAndEffective = 4,

        /// <summary>
        /// Password has expired or account is blocked for orders for the medium. User is in 'readonly except for password change' mode, so no two factor authentication is needed.
        /// </summary>
        EnabledButNoFullRightsLogin = 5,

        /// <summary>
        /// Client has already passed the TFA so he has full rights. This situation only applies if a TFA login is performed based on an earlier created session which passed TFA already.
        /// </summary>
        EnabledAndPassed = 6
    }
}
