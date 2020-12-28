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
  public class PciSettings {
    /// <summary>
    /// true if SAQ A is set
    /// </summary>
    /// <value>true if SAQ A is set</value>
    [DataMember(Name="saq_a", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_a")]
    public bool? SaqA { get; set; }

    /// <summary>
    /// true if SAQ A-EP is set
    /// </summary>
    /// <value>true if SAQ A-EP is set</value>
    [DataMember(Name="saq_a_ep", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_a_ep")]
    public bool? SaqAEp { get; set; }

    /// <summary>
    /// true if SAQ B is set
    /// </summary>
    /// <value>true if SAQ B is set</value>
    [DataMember(Name="saq_b", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_b")]
    public bool? SaqB { get; set; }

    /// <summary>
    /// true if SAQ B-IP is set
    /// </summary>
    /// <value>true if SAQ B-IP is set</value>
    [DataMember(Name="saq_b_ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_b_ip")]
    public bool? SaqBIp { get; set; }

    /// <summary>
    /// true if SAQ C is set
    /// </summary>
    /// <value>true if SAQ C is set</value>
    [DataMember(Name="saq_c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_c")]
    public bool? SaqC { get; set; }

    /// <summary>
    /// true if SAQ C-VT is set
    /// </summary>
    /// <value>true if SAQ C-VT is set</value>
    [DataMember(Name="saq_c_vt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_c_vt")]
    public bool? SaqCVt { get; set; }

    /// <summary>
    /// true if SAQ D Merchant is set
    /// </summary>
    /// <value>true if SAQ D Merchant is set</value>
    [DataMember(Name="saq_d_merchant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_d_merchant")]
    public bool? SaqDMerchant { get; set; }

    /// <summary>
    /// true if SAQ D Service Provider is set
    /// </summary>
    /// <value>true if SAQ D Service Provider is set</value>
    [DataMember(Name="saq_d_service_provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_d_service_provider")]
    public bool? SaqDServiceProvider { get; set; }

    /// <summary>
    /// true if SAQ P2PE-HW is set
    /// </summary>
    /// <value>true if SAQ P2PE-HW is set</value>
    [DataMember(Name="saq_p2pe_hw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saq_p2pe_hw")]
    public bool? SaqP2peHw { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PciSettings {\n");
      sb.Append("  SaqA: ").Append(SaqA).Append("\n");
      sb.Append("  SaqAEp: ").Append(SaqAEp).Append("\n");
      sb.Append("  SaqB: ").Append(SaqB).Append("\n");
      sb.Append("  SaqBIp: ").Append(SaqBIp).Append("\n");
      sb.Append("  SaqC: ").Append(SaqC).Append("\n");
      sb.Append("  SaqCVt: ").Append(SaqCVt).Append("\n");
      sb.Append("  SaqDMerchant: ").Append(SaqDMerchant).Append("\n");
      sb.Append("  SaqDServiceProvider: ").Append(SaqDServiceProvider).Append("\n");
      sb.Append("  SaqP2peHw: ").Append(SaqP2peHw).Append("\n");
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
