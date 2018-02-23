namespace Binck.OpenApi.Models.Account.Order
{
    using System.ComponentModel.DataAnnotations;
    using Binck.OpenApi.Models.Utilities.JSonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// For future orders (equities), this field is required
    /// </summary>
    public class NewOrderModelFuture
    {
        /// <summary>
        /// Buy or Sell
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
