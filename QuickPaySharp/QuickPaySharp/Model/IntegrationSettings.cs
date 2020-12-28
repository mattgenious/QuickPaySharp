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
  public class IntegrationSettings {
    /// <summary>
    /// e-conomic settings
    /// </summary>
    /// <value>e-conomic settings</value>
    [DataMember(Name="economic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "economic")]
    public IntegrationSettingsEconomic Economic { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntegrationSettings {\n");
      sb.Append("  Economic: ").Append(Economic).Append("\n");
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
