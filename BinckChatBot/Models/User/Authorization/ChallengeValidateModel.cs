namespace Binck.OpenApi.Models.User.Authorization
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Result when a challenge is validated
    /// </summary>
    public class ChallengeValidateModel
    {
        /// <summary>
        /// The result of the request.
        /// </summary>
        [Required]
        public TwoFactorChallengeValidationResultType ChallengeValidateResultType { get; set; }

        /// <summary>
        /// If successful: The newly created session, with mutation rights.
        /// </summary>
        public long? SessionId { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <returns></returns>
        public ChallengeValidateModel()
        {
            ChallengeValidateResultType = TwoFactorChallengeValidationResultType.InvalidData;
        }
    }
}