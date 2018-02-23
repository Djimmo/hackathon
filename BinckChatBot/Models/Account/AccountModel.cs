namespace Binck.OpenApi.Models.Account
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Account model
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        /// The name of the account
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The IBAN of the account
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// Accountnumber
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Type of account
        /// </summary>
        [Required]
        public AccountType Type { get; set; }

        /// <summary>
        /// Status of the account
        /// </summary>
        [Required]
        public AccountStatus Status { get; set; }

        /// <summary>
        /// Scope for the account
        /// </summary>
        [Required]
        public bool IsReadOnly { get; set; }
    }
}