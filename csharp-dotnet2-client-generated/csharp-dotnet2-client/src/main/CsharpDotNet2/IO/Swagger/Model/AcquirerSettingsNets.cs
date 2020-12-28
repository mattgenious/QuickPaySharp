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
  public class AcquirerSettingsNets {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// (Depricated use Teller acquirer)
    /// </summary>
    /// <value>(Depricated use Teller acquirer)</value>
    [DataMember(Name="americanexpress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "americanexpress")]
    public bool? Americanexpress { get; set; }

    /// <summary>
    /// Nets business code
    /// </summary>
    /// <value>Nets business code</value>
    [DataMember(Name="business_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "business_code")]
    public string BusinessCode { get; set; }

    /// <summary>
    /// (Depricated use Teller acquirer)
    /// </summary>
    /// <value>(Depricated use Teller acquirer)</value>
    [DataMember(Name="dinersclub", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dinersclub")]
    public bool? Dinersclub { get; set; }

    /// <summary>
    /// True if Forbrugsforeningen is enabled
    /// </summary>
    /// <value>True if Forbrugsforeningen is enabled</value>
    [DataMember(Name="fbg1886", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fbg1886")]
    public bool? Fbg1886 { get; set; }

    /// <summary>
    /// Nets identification code
    /// </summary>
    /// <value>Nets identification code</value>
    [DataMember(Name="identification_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identification_code")]
    public string IdentificationCode { get; set; }

    /// <summary>
    /// (Depricated use Teller acquirer)
    /// </summary>
    /// <value>(Depricated use Teller acquirer)</value>
    [DataMember(Name="identification_code_int", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identification_code_int")]
    public string IdentificationCodeInt { get; set; }

    /// <summary>
    /// (Depricated use Teller acquirer)
    /// </summary>
    /// <value>(Depricated use Teller acquirer)</value>
    [DataMember(Name="mastercard_bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mastercard_bin")]
    public string MastercardBin { get; set; }

    /// <summary>
    /// (Depricated use Teller acquirer)
    /// </summary>
    /// <value>(Depricated use Teller acquirer)</value>
    [DataMember(Name="mastercard_mpi_merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mastercard_mpi_merchant_id")]
    public string MastercardMpiMerchantId { get; set; }

    /// <summary>
    /// True if recurring is enabled
    /// </summary>
    /// <value>True if recurring is enabled</value>
    [DataMember(Name="recurring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring")]
    public bool? Recurring { get; set; }

    /// <summary>
    /// True if SecuredByNets is enabled
    /// </summary>
    /// <value>True if SecuredByNets is enabled</value>
    [DataMember(Name="secured_by_nets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secured_by_nets")]
    public bool? SecuredByNets { get; set; }

    /// <summary>
    /// (Depricated use Teller acquirer)
    /// </summary>
    /// <value>(Depricated use Teller acquirer)</value>
    [DataMember(Name="securepay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securepay")]
    public bool? Securepay { get; set; }

    /// <summary>
    /// (Depricated use Teller acquirer)
    /// </summary>
    /// <value>(Depricated use Teller acquirer)</value>
    [DataMember(Name="visa_bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visa_bin")]
    public string VisaBin { get; set; }

    /// <summary>
    /// (Depricated use Teller acquirer)
    /// </summary>
    /// <value>(Depricated use Teller acquirer)</value>
    [DataMember(Name="visa_mpi_merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visa_mpi_merchant_id")]
    public string VisaMpiMerchantId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsNets {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Americanexpress: ").Append(Americanexpress).Append("\n");
      sb.Append("  BusinessCode: ").Append(BusinessCode).Append("\n");
      sb.Append("  Dinersclub: ").Append(Dinersclub).Append("\n");
      sb.Append("  Fbg1886: ").Append(Fbg1886).Append("\n");
      sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
      sb.Append("  IdentificationCodeInt: ").Append(IdentificationCodeInt).Append("\n");
      sb.Append("  MastercardBin: ").Append(MastercardBin).Append("\n");
      sb.Append("  MastercardMpiMerchantId: ").Append(MastercardMpiMerchantId).Append("\n");
      sb.Append("  Recurring: ").Append(Recurring).Append("\n");
      sb.Append("  SecuredByNets: ").Append(SecuredByNets).Append("\n");
      sb.Append("  Securepay: ").Append(Securepay).Append("\n");
      sb.Append("  VisaBin: ").Append(VisaBin).Append("\n");
      sb.Append("  VisaMpiMerchantId: ").Append(VisaMpiMerchantId).Append("\n");
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
