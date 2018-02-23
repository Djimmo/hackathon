namespace Binck.OpenApi.Models.Account.Order
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// For option orders, this field is required
    /// </summary>
    public class NewOrderModelOption
    {
        /// <summary>
        /// The information about the first leg
        /// </summary>
        [Required]
        public NewOrderModelOptionLeg Leg1 { get; set;  }

        /// <summary>
        /// For a stategy the second leg is required
        /// </summary>
        public NewOrderModelOptionLeg Leg2 { get; set;  }
    }
}
