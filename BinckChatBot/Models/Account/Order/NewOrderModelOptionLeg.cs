namespace Binck.OpenApi.Models.Account.Order
{
    using Binck.OpenApi.Models.Utilities.JSonConverters;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The details of a leg
    /// </summary>
    public class NewOrderModelOptionLeg
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
