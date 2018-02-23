namespace Binck.OpenApi.Models.Account.Order
{
    using Binck.OpenApi.Models.Utilities.JSonConverters;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    /// <summary>
    /// For SRD orders (equities), this field is required
    /// </summary>
    public class NewOrderModelSrd
    {
        /// <summary>
        /// Buy or sell?
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        [JsonConverter(typeof(JsonEnumConverter<NewOrderSide>))]
        [Required]
        public NewOrderSide Side { get; set; }

        /// <summary>
        /// Instrument Id
        /// </summary>
        [Required]
        public string InstrumentId { get; set; }
    }
}
