namespace Binck.OpenApi.Models.User.Authorization
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Request new password model
    /// </summary>
    public class PasswordResetArgumentsModel
    {
        /// <summary>
        /// Email address, to validate the request.
        /// </summary>
        [Required]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The label where this customer wants to login to.
        /// </summary>
        [Required]
        public string Company { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <returns></returns>
        public PasswordResetArgumentsModel()
        {
            EmailAddress = "";
            Company = "Binck_NL";
        }
    }
}
