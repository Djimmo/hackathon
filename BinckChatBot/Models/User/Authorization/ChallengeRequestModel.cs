namespace Binck.OpenApi.Models.User.Authorization
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Result when a challenge is requested
    /// </summary>
    public class ChallengeRequestModel
    {
        /// <summary>
        /// The result of the request.
        /// </summary>
        [Required]
        public TwoFactorChallengeRequestResultType ChallengeRequestResultType { get; set; }

        /// <summary>
        /// If successful: Id of the challenge.
        /// </summary>
        public long? ChallengeId { get; set; }

        /// <summary>
        /// If successful: The number of the challenge. To be shown when entering the result.
        /// </summary>
        public long? ChallengeSequence { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <returns></returns>
        public ChallengeRequestModel()
        {
            ChallengeRequestResultType = TwoFactorChallengeRequestResultType.InvalidData;
            ChallengeId = 0;
            ChallengeSequence = 0;
        }
    }
}