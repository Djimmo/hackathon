namespace Binck.OpenApi.Models.User.Authorization
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System;

    /// <summary>
    /// User authorization data
    /// </summary>
    public class UserAuthorizationModel
    {
        /// <summary>
        /// Relation Id.
        /// </summary>
        [Required]
        public long RelationId { get; set; }

        /// <summary>
        /// Person Id.
        /// </summary>
        public long? PersonId { get; set; }

        /// <summary>
        /// Id of the currently active account.
        /// </summary>
        [Required]
        public long AccountId { get; set; }

        /// <summary>
        /// Id of the created session.
        /// </summary>
        [Required]
        public long SessionId { get; set; }

        /// <summary>
        /// When the customer signed in previously - can be shown to the customer for security reasons.
        /// </summary>
        public DateTime LastLogonDateTime { get; set; }

        /// <summary>
        /// How long the password will be valid.
        /// </summary>
        [Required]
        public int DaysToPasswordChange { get; set; }

        /// <summary>
        /// The language of the customer, represented in ISO standard.
        /// </summary>
        [Required]
        public string LanguageCultureCode { get; set; }

        /// <summary>
        /// The company where this user has been signed in.
        /// </summary>
        [Required]
        public string Company { get; set; }

        /// <summary>
        /// The mobile phone number(s), to be used for the second factor authentication.
        /// </summary>
        [Required]
        public List<string> MobilePhoneNumbers { get; set; }

        /// <summary>
        /// This result describes the state of the created session. For example, the created session can be a readonly one.
        /// </summary>
        [Required]
        public TwoFactorLogonResultType LogonResultType { get; set; }

        /// <summary>
        /// Indicates whether the Session is readonly
        /// </summary>
        public Boolean IsReadOnlySession { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <returns></returns>
        public UserAuthorizationModel()
        {
            RelationId = 0;
            AccountId = 0;
            SessionId = 0;
            LastLogonDateTime = DateTime.Now;
            DaysToPasswordChange = 0;
            LanguageCultureCode = "";
            Company = "";
            MobilePhoneNumbers = new List<string>();
            IsReadOnlySession = true;
        }
    }
}