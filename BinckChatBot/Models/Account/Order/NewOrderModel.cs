namespace Binck.OpenApi.Models.Account.Order
{
    using Binck.OpenApi.Models.Utilities.JSonConverters;
    using System;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    /// <summary>
    /// New order model
    /// </summary>
    public class NewOrderModel
    {
        /// <summary>
        /// The kind of order to be placed
        /// </summary>
        [JsonConverter(typeof(JsonEnumConverter<NewOrderType>))]
        [Required]
        public NewOrderType Type { get; set; }

        /// <summary>
        /// The number of financial instruments to buy or sell
        /// </summary>
        [Required]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Specifies the term for which the order is active
        /// </summary>
        [JsonConverter(typeof(JsonEnumConverter<NewOrderDuration>))]
        [Required]
        public NewOrderDuration Duration { get; set; }

        /// <summary>
        /// The date when the order will be expired, used in combination with duration GooddTillDateTime
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The highest price at which to buy or the lowest price at which to sell (only if type is limit or stopLimit)
        /// </summary>
        public decimal LimitPrice { get; set; }

        /// <summary>
        /// The trigger price to initiate a buy or sell order, applicable when type is stop or stopLimit
        /// </summary>
        public decimal StopPrice { get; set; }

        /// <summary>
        /// For cash orders (equities), this field is required
        /// </summary>
        public NewOrderModelCash Cash { get; set; }

        /// <summary>
        /// For SRD orders (equities, France), this field is required
        /// </summary>
        public NewOrderModelSrd Srd { get; set; }

        /// <summary>
        /// For option orders, this field is required
        /// </summary>
        public NewOrderModelOption Option { get; set; }

        /// <summary>
        /// For future orders, this field is required
        /// </summary>
        public NewOrderModelFuture Future { get; set; }
    }
}