namespace Binck.OpenApi.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The properties used to authenticate
    /// </summary>
    public class LogonArgumentsModel
    {
        /// <summary>
        /// The logon name
        /// </summary>
        [Required]
        public string Username { get; set; }
        
        /// <summary>
        /// The password of this customer
        /// </summary>
        [Required]
        public string Password { get; set; }
        
        /// <summary>
        /// The company of this customer
        /// </summary>
        [Required]
        public string SelectedCompany { get; set; }

        /// <summary>
        /// The IP address of the connecting machine
        /// </summary>
        [Required]
        public string IpAddress { get; set; }

        /// <summary>
        /// The Client ID (or Application ID) used
        /// </summary>
        [Required]
        public string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializePassword()
        {
            return false;
        }
    }
}