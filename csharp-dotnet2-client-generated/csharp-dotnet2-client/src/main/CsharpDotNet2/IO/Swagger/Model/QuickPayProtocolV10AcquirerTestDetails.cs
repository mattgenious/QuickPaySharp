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
  public class QuickPayProtocolV10AcquirerTestDetails {
    /// <summary>
    /// 3d_secure test status
    /// </summary>
    /// <value>3d_secure test status</value>
    [DataMember(Name="3d_secure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "3d_secure")]
    public QuickPayProtocolV10AcquirerTestResult _3dSecure { get; set; }

    /// <summary>
    /// dankort test status
    /// </summary>
    /// <value>dankort test status</value>
    [DataMember(Name="dankort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dankort")]
    public QuickPayProtocolV10AcquirerTestResult Dankort { get; set; }

    /// <summary>
    /// diners test status
    /// </summary>
    /// <value>diners test status</value>
    [DataMember(Name="diners", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diners")]
    public QuickPayProtocolV10AcquirerTestResult Diners { get; set; }

    /// <summary>
    /// fbg1886 test status
    /// </summary>
    /// <value>fbg1886 test status</value>
    [DataMember(Name="fbg1886", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fbg1886")]
    public QuickPayProtocolV10AcquirerTestResult Fbg1886 { get; set; }

    /// <summary>
    /// mastercard test status
    /// </summary>
    /// <value>mastercard test status</value>
    [DataMember(Name="mastercard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mastercard")]
    public QuickPayProtocolV10AcquirerTestResult Mastercard { get; set; }

    /// <summary>
    /// recurring test status
    /// </summary>
    /// <value>recurring test status</value>
    [DataMember(Name="recurring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring")]
    public QuickPayProtocolV10AcquirerTestResult Recurring { get; set; }

    /// <summary>
    /// visa test status
    /// </summary>
    /// <value>visa test status</value>
    [DataMember(Name="visa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visa")]
    public QuickPayProtocolV10AcquirerTestResult Visa { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10AcquirerTestDetails {\n");
      sb.Append("  _3dSecure: ").Append(_3dSecure).Append("\n");
      sb.Append("  Dankort: ").Append(Dankort).Append("\n");
      sb.Append("  Diners: ").Append(Diners).Append("\n");
      sb.Append("  Fbg1886: ").Append(Fbg1886).Append("\n");
      sb.Append("  Mastercard: ").Append(Mastercard).Append("\n");
      sb.Append("  Recurring: ").Append(Recurring).Append("\n");
      sb.Append("  Visa: ").Append(Visa).Append("\n");
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
