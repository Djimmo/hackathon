namespace Binck.OpenApi.Models.User.Authorization
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Change password model.
    /// </summary>
    public class PasswordUpdateArgumentsModel
    {
        /// <summary>
        /// Session.
        /// </summary>
        [Required]
        public long SessionId { get; set; }

        /// <summary>
        /// Account.
        /// </summary>
        [Required]
        public long AccountId { get; set; }

        /// <summary>
        /// Relation.
        /// </summary>
        [Required]
        public long RelationId { get; set; }

        /// <summary>
        /// Current password.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        /// <summary>
        /// The new password.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9]+$")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <returns></returns>
        public PasswordUpdateArgumentsModel()
        {
            SessionId = 0;
            AccountId = 0;
            RelationId = 0;
            OldPassword = "";
            NewPassword = "";
        }
    }
}
