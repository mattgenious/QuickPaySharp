using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuickPaySharp.Entities.Payments
{
    public class Metadata
    {
        [JsonProperty("type")]
        public object Type { get; set; }

        [JsonProperty("origin")]
        public object Origin { get; set; }

        [JsonProperty("brand")]
        public object Brand { get; set; }

        [JsonProperty("bin")]
        public object Bin { get; set; }

        [JsonProperty("corporate")]
        public object Corporate { get; set; }

        [JsonProperty("last4")]
        public object Last4 { get; set; }

        [JsonProperty("exp_month")]
        public object ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public object ExpYear { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("is_3d_secure")]
        public object Is3DSecure { get; set; }

        [JsonProperty("issued_to")]
        public object IssuedTo { get; set; }

        [JsonProperty("hash")]
        public object Hash { get; set; }

        [JsonProperty("number")]
        public object Number { get; set; }

        [JsonProperty("customer_ip")]
        public object CustomerIp { get; set; }

        [JsonProperty("customer_country")]
        public object CustomerCountry { get; set; }

        [JsonProperty("fraud_suspected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FraudSuspected { get; set; }

        [JsonProperty("fraud_remarks", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> FraudRemarks { get; set; }

        [JsonProperty("fraud_reported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FraudReported { get; set; }

        [JsonProperty("fraud_report_description")]
        public object FraudReportDescription { get; set; }

        [JsonProperty("fraud_reported_at")]
        public object FraudReportedAt { get; set; }

        [JsonProperty("nin_number")]
        public object NinNumber { get; set; }

        [JsonProperty("nin_country_code")]
        public object NinCountryCode { get; set; }

        [JsonProperty("nin_gender")]
        public object NinGender { get; set; }

        [JsonProperty("shopsystem_name")]
        public object ShopsystemName { get; set; }

        [JsonProperty("shopsystem_version")]
        public object ShopsystemVersion { get; set; }
    }
}