using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace QuickPaySharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OptionalAddress {
    /// <summary>
    /// Att.
    /// </summary>
    /// <value>Att.</value>
    [DataMember(Name="att", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "att")]
    public string Att { get; set; }

    /// <summary>
    /// City
    /// </summary>
    /// <value>City</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Company name
    /// </summary>
    /// <value>Company name</value>
    [DataMember(Name="company_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_name")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Country code
    /// </summary>
    /// <value>Country code</value>
    [DataMember(Name="country_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// E-mail address
    /// </summary>
    /// <value>E-mail address</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// House extension
    /// </summary>
    /// <value>House extension</value>
    [DataMember(Name="house_extension", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "house_extension")]
    public string HouseExtension { get; set; }

    /// <summary>
    /// House number
    /// </summary>
    /// <value>House number</value>
    [DataMember(Name="house_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "house_number")]
    public string HouseNumber { get; set; }

    /// <summary>
    /// Mobile number
    /// </summary>
    /// <value>Mobile number</value>
    [DataMember(Name="mobile_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile_number")]
    public string MobileNumber { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Phone number
    /// </summary>
    /// <value>Phone number</value>
    [DataMember(Name="phone_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_number")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Region
    /// </summary>
    /// <value>Region</value>
    [DataMember(Name="region", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// Street
    /// </summary>
    /// <value>Street</value>
    [DataMember(Name="street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street")]
    public string Street { get; set; }

    /// <summary>
    /// VAT reg. no.
    /// </summary>
    /// <value>VAT reg. no.</value>
    [DataMember(Name="vat_no", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vat_no")]
    public string VatNo { get; set; }

    /// <summary>
    /// Zip code
    /// </summary>
    /// <value>Zip code</value>
    [DataMember(Name="zip_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zip_code")]
    public string ZipCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OptionalAddress {\n");
      sb.Append("  Att: ").Append(Att).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  HouseExtension: ").Append(HouseExtension).Append("\n");
      sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
      sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  Region: ").Append(Region).Append("\n");
      sb.Append("  Street: ").Append(Street).Append("\n");
      sb.Append("  VatNo: ").Append(VatNo).Append("\n");
      sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
