using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class QuickPayProtocolV10Metadata {
    /// <summary>
    /// Card type only: Card BIN
    /// </summary>
    /// <value>Card type only: Card BIN</value>
    [DataMember(Name="bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; set; }

    /// <summary>
    /// Card type only: The card brand
    /// </summary>
    /// <value>Card type only: The card brand</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Card type only: Corporate status
    /// </summary>
    /// <value>Card type only: Corporate status</value>
    [DataMember(Name="corporate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporate")]
    public bool? Corporate { get; set; }

    /// <summary>
    /// Card type only: The card country in ISO 3166-1 alpha-3
    /// </summary>
    /// <value>Card type only: The card country in ISO 3166-1 alpha-3</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Customer country based on IP geo-data, ISO 3166-1 alpha-2
    /// </summary>
    /// <value>Customer country based on IP geo-data, ISO 3166-1 alpha-2</value>
    [DataMember(Name="customer_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_country")]
    public string CustomerCountry { get; set; }

    /// <summary>
    /// Customer IP
    /// </summary>
    /// <value>Customer IP</value>
    [DataMember(Name="customer_ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_ip")]
    public string CustomerIp { get; set; }

    /// <summary>
    /// Card type only: The expiration month
    /// </summary>
    /// <value>Card type only: The expiration month</value>
    [DataMember(Name="exp_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exp_month")]
    public int? ExpMonth { get; set; }

    /// <summary>
    /// Card type only: The expiration year (YYYY)
    /// </summary>
    /// <value>Card type only: The expiration year (YYYY)</value>
    [DataMember(Name="exp_year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exp_year")]
    public int? ExpYear { get; set; }

    /// <summary>
    /// Fraud remarks
    /// </summary>
    /// <value>Fraud remarks</value>
    [DataMember(Name="fraud_remarks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraud_remarks")]
    public List<string> FraudRemarks { get; set; }

    /// <summary>
    /// Fraud report description
    /// </summary>
    /// <value>Fraud report description</value>
    [DataMember(Name="fraud_report_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraud_report_description")]
    public string FraudReportDescription { get; set; }

    /// <summary>
    /// Reported as fraudulent
    /// </summary>
    /// <value>Reported as fraudulent</value>
    [DataMember(Name="fraud_reported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraud_reported")]
    public bool? FraudReported { get; set; }

    /// <summary>
    /// Fraud report description
    /// </summary>
    /// <value>Fraud report description</value>
    [DataMember(Name="fraud_reported_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraud_reported_at")]
    public string FraudReportedAt { get; set; }

    /// <summary>
    /// Suspected fraud
    /// </summary>
    /// <value>Suspected fraud</value>
    [DataMember(Name="fraud_suspected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fraud_suspected")]
    public bool? FraudSuspected { get; set; }

    /// <summary>
    /// Card type only: PCI safe hash of card number
    /// </summary>
    /// <value>Card type only: PCI safe hash of card number</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public string Hash { get; set; }

    /// <summary>
    /// Card type only: Verified via 3D-Secure
    /// </summary>
    /// <value>Card type only: Verified via 3D-Secure</value>
    [DataMember(Name="is_3d_secure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_3d_secure")]
    public string Is3dSecure { get; set; }

    /// <summary>
    /// Name of cardholder
    /// </summary>
    /// <value>Name of cardholder</value>
    [DataMember(Name="issued_to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issued_to")]
    public string IssuedTo { get; set; }

    /// <summary>
    /// Card type only: The last 4 digits of the card number
    /// </summary>
    /// <value>Card type only: The last 4 digits of the card number</value>
    [DataMember(Name="last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// NIN type only. NIN country code, ISO 3166-1 alpha-3
    /// </summary>
    /// <value>NIN type only. NIN country code, ISO 3166-1 alpha-3</value>
    [DataMember(Name="nin_country_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nin_country_code")]
    public string NinCountryCode { get; set; }

    /// <summary>
    /// NIN type only. NIN gender
    /// </summary>
    /// <value>NIN type only. NIN gender</value>
    [DataMember(Name="nin_gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nin_gender")]
    public string NinGender { get; set; }

    /// <summary>
    /// NIN type only. NIN number
    /// </summary>
    /// <value>NIN type only. NIN number</value>
    [DataMember(Name="nin_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nin_number")]
    public string NinNumber { get; set; }

    /// <summary>
    /// Mobile type only: The mobile number
    /// </summary>
    /// <value>Mobile type only: The mobile number</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// Origin of this transaction or card. If set, describes where it came from.
    /// </summary>
    /// <value>Origin of this transaction or card. If set, describes where it came from.</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Shop system module name
    /// </summary>
    /// <value>Shop system module name</value>
    [DataMember(Name="shopsystem_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopsystem_name")]
    public string ShopsystemName { get; set; }

    /// <summary>
    /// Shop system module version
    /// </summary>
    /// <value>Shop system module version</value>
    [DataMember(Name="shopsystem_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopsystem_version")]
    public string ShopsystemVersion { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    /// <value>Type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10Metadata {\n");
      sb.Append("  Bin: ").Append(Bin).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  Corporate: ").Append(Corporate).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  CustomerCountry: ").Append(CustomerCountry).Append("\n");
      sb.Append("  CustomerIp: ").Append(CustomerIp).Append("\n");
      sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
      sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
      sb.Append("  FraudRemarks: ").Append(FraudRemarks).Append("\n");
      sb.Append("  FraudReportDescription: ").Append(FraudReportDescription).Append("\n");
      sb.Append("  FraudReported: ").Append(FraudReported).Append("\n");
      sb.Append("  FraudReportedAt: ").Append(FraudReportedAt).Append("\n");
      sb.Append("  FraudSuspected: ").Append(FraudSuspected).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Is3dSecure: ").Append(Is3dSecure).Append("\n");
      sb.Append("  IssuedTo: ").Append(IssuedTo).Append("\n");
      sb.Append("  Last4: ").Append(Last4).Append("\n");
      sb.Append("  NinCountryCode: ").Append(NinCountryCode).Append("\n");
      sb.Append("  NinGender: ").Append(NinGender).Append("\n");
      sb.Append("  NinNumber: ").Append(NinNumber).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  ShopsystemName: ").Append(ShopsystemName).Append("\n");
      sb.Append("  ShopsystemVersion: ").Append(ShopsystemVersion).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
