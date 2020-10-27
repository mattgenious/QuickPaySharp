using System;
using Newtonsoft.Json;

namespace QuickPaySharp.Entities.Payments
{
    public class Link
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AgreementId { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }

        [JsonProperty("continue_url")]
        public object ContinueUrl { get; set; }

        [JsonProperty("cancel_url")]
        public object CancelUrl { get; set; }

        [JsonProperty("callback_url")]
        public object CallbackUrl { get; set; }

        [JsonProperty("payment_methods")]
        public object PaymentMethods { get; set; }

        [JsonProperty("auto_fee")]
        public object AutoFee { get; set; }

        [JsonProperty("auto_capture")]
        public object AutoCapture { get; set; }

        [JsonProperty("branding_id")]
        public object BrandingId { get; set; }

        [JsonProperty("google_analytics_client_id")]
        public object GoogleAnalyticsClientId { get; set; }

        [JsonProperty("google_analytics_tracking_id")]
        public object GoogleAnalyticsTrackingId { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("acquirer")]
        public object Acquirer { get; set; }

        [JsonProperty("deadline")]
        public object Deadline { get; set; }

        [JsonProperty("framed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Framed { get; set; }

        [JsonProperty("branding_config", NullValueHandling = NullValueHandling.Ignore)]
        public Variables BrandingConfig { get; set; }

        [JsonProperty("invoice_address_selection")]
        public object InvoiceAddressSelection { get; set; }

        [JsonProperty("shipping_address_selection")]
        public object ShippingAddressSelection { get; set; }

        [JsonProperty("customer_email")]
        public object CustomerEmail { get; set; }
    }
}