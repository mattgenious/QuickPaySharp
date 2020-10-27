using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuickPaySharp.Entities.Payments
{
    public class Payments
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MerchantId { get; set; }

        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        [JsonProperty("accepted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accepted { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("text_on_statement")]
        public object TextOnStatement { get; set; }

        [JsonProperty("branding_id")]
        public object BrandingId { get; set; }

        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Variables Variables { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("shipping_address")]
        public OptionalAddress ShippingAddress { get; set; }

        [JsonProperty("invoice_address")]
        public OptionalAddress InvoiceAddress { get; set; }

        [JsonProperty("basket", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Basket { get; set; }

        [JsonProperty("shipping")]
        public object Shipping { get; set; }

        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Operation> Operations { get; set; }

        [JsonProperty("test_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TestMode { get; set; }

        [JsonProperty("acquirer")]
        public string Acquirer { get; set; }

        [JsonProperty("facilitator")]
        public object Facilitator { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        [JsonProperty("retented_at")]
        public object RetentedAt { get; set; }

        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public long? Balance { get; set; }

        [JsonProperty("fee")]
        public object Fee { get; set; }

        [JsonProperty("deadline_at")]
        public object DeadlineAt { get; set; }
    }
}
