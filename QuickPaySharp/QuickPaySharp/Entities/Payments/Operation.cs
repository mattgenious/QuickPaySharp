using Newtonsoft.Json;

namespace QuickPaySharp.Entities.Payments
{
    public class Operation
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("pending", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pending { get; set; }

        [JsonProperty("qp_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string QpStatusCode { get; set; }

        [JsonProperty("qp_status_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string QpStatusMsg { get; set; }

        [JsonProperty("aq_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AqStatusCode { get; set; }

        [JsonProperty("aq_status_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string AqStatusMsg { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Variables Data { get; set; }

        [JsonProperty("callback_url")]
        public object CallbackUrl { get; set; }

        [JsonProperty("callback_success")]
        public object CallbackSuccess { get; set; }

        [JsonProperty("callback_response_code")]
        public object CallbackResponseCode { get; set; }

        [JsonProperty("callback_duration")]
        public object CallbackDuration { get; set; }

        [JsonProperty("acquirer", NullValueHandling = NullValueHandling.Ignore)]
        public string Acquirer { get; set; }

        [JsonProperty("3d_secure_status")]
        public object The3DSecureStatus { get; set; }

        [JsonProperty("callback_at")]
        public object CallbackAt { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }
    }
}