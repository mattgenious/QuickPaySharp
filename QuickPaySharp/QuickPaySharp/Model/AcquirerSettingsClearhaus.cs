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
  public class AcquirerSettingsClearhaus {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Clearhaus api key
    /// </summary>
    /// <value>Clearhaus api key</value>
    [DataMember(Name="api_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api_key")]
    public string ApiKey { get; set; }

    /// <summary>
    /// True if Apple Pay is enabled
    /// </summary>
    /// <value>True if Apple Pay is enabled</value>
    [DataMember(Name="apple_pay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apple_pay")]
    public bool? ApplePay { get; set; }

    /// <summary>
    /// Clearhaus business code(mcc)
    /// </summary>
    /// <value>Clearhaus business code(mcc)</value>
    [DataMember(Name="business_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "business_code")]
    public string BusinessCode { get; set; }

    /// <summary>
    /// MPI Merchant id used for 3D Secure. This field is maintained by QuickPay.
    /// </summary>
    /// <value>MPI Merchant id used for 3D Secure. This field is maintained by QuickPay.</value>
    [DataMember(Name="mpi_merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mpi_merchant_id")]
    public string MpiMerchantId { get; set; }

    /// <summary>
    /// True if payout is enabled
    /// </summary>
    /// <value>True if payout is enabled</value>
    [DataMember(Name="payout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payout")]
    public bool? Payout { get; set; }

    /// <summary>
    /// True if recurring is enabled
    /// </summary>
    /// <value>True if recurring is enabled</value>
    [DataMember(Name="recurring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring")]
    public bool? Recurring { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsClearhaus {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      sb.Append("  ApplePay: ").Append(ApplePay).Append("\n");
      sb.Append("  BusinessCode: ").Append(BusinessCode).Append("\n");
      sb.Append("  MpiMerchantId: ").Append(MpiMerchantId).Append("\n");
      sb.Append("  Payout: ").Append(Payout).Append("\n");
      sb.Append("  Recurring: ").Append(Recurring).Append("\n");
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
