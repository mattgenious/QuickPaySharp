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
  public class QuickPayProtocolV10AcquirerSettingsValitor {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// True if american express is enabled
    /// </summary>
    /// <value>True if american express is enabled</value>
    [DataMember(Name="americanexpress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "americanexpress")]
    public bool? Americanexpress { get; set; }

    /// <summary>
    /// Valitor business code
    /// </summary>
    /// <value>Valitor business code</value>
    [DataMember(Name="business_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "business_code")]
    public string BusinessCode { get; set; }

    /// <summary>
    /// True if Diners Club is enabled
    /// </summary>
    /// <value>True if Diners Club is enabled</value>
    [DataMember(Name="dinersclub", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dinersclub")]
    public bool? Dinersclub { get; set; }

    /// <summary>
    /// Valitor identification number
    /// </summary>
    /// <value>Valitor identification number</value>
    [DataMember(Name="identification_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identification_code")]
    public string IdentificationCode { get; set; }

    /// <summary>
    /// Valitor international identification number
    /// </summary>
    /// <value>Valitor international identification number</value>
    [DataMember(Name="identification_code_int", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identification_code_int")]
    public string IdentificationCodeInt { get; set; }

    /// <summary>
    /// Valitor Mastercard acquirer bin used for 3D Secure
    /// </summary>
    /// <value>Valitor Mastercard acquirer bin used for 3D Secure</value>
    [DataMember(Name="mastercard_bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mastercard_bin")]
    public string MastercardBin { get; set; }

    /// <summary>
    /// Mastercard MPI Merchant id used for 3D Secure
    /// </summary>
    /// <value>Mastercard MPI Merchant id used for 3D Secure</value>
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
    /// True if Teller SecurePay fraud detection is enabled
    /// </summary>
    /// <value>True if Teller SecurePay fraud detection is enabled</value>
    [DataMember(Name="securepay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securepay")]
    public bool? Securepay { get; set; }

    /// <summary>
    /// Valitor VISA acquirer bin used for 3D Secure
    /// </summary>
    /// <value>Valitor VISA acquirer bin used for 3D Secure</value>
    [DataMember(Name="visa_bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visa_bin")]
    public string VisaBin { get; set; }

    /// <summary>
    /// VISA MPI Merchant id used for 3D Secure
    /// </summary>
    /// <value>VISA MPI Merchant id used for 3D Secure</value>
    [DataMember(Name="visa_mpi_merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visa_mpi_merchant_id")]
    public string VisaMpiMerchantId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10AcquirerSettingsValitor {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Americanexpress: ").Append(Americanexpress).Append("\n");
      sb.Append("  BusinessCode: ").Append(BusinessCode).Append("\n");
      sb.Append("  Dinersclub: ").Append(Dinersclub).Append("\n");
      sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
      sb.Append("  IdentificationCodeInt: ").Append(IdentificationCodeInt).Append("\n");
      sb.Append("  MastercardBin: ").Append(MastercardBin).Append("\n");
      sb.Append("  MastercardMpiMerchantId: ").Append(MastercardMpiMerchantId).Append("\n");
      sb.Append("  Recurring: ").Append(Recurring).Append("\n");
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
