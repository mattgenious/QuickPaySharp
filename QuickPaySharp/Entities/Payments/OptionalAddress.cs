using Newtonsoft.Json;

namespace QuickPaySharp.Entities.Payments
{
    public class OptionalAddress
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("att")]
        public object Att { get; set; }

        [JsonProperty("street")]
        public object Street { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("zip_code")]
        public object ZipCode { get; set; }

        [JsonProperty("region")]
        public object Region { get; set; }

        [JsonProperty("country_code")]
        public object CountryCode { get; set; }

        [JsonProperty("vat_no")]
        public object VatNo { get; set; }

        [JsonProperty("company_name")]
        public object CompanyName { get; set; }

        [JsonProperty("house_number")]
        public object HouseNumber { get; set; }

        [JsonProperty("house_extension")]
        public object HouseExtension { get; set; }

        [JsonProperty("phone_number")]
        public object PhoneNumber { get; set; }

        [JsonProperty("mobile_number")]
        public object MobileNumber { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }
    }
}