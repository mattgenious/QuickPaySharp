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
  public class IntegrationSettingsEconomic {
    /// <summary>
    /// True if the settings are active
    /// </summary>
    /// <value>True if the settings are active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// e-conomic agreement id
    /// </summary>
    /// <value>e-conomic agreement id</value>
    [DataMember(Name="agreement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreement")]
    public string Agreement { get; set; }

    /// <summary>
    /// e-conomic agreement grant token
    /// </summary>
    /// <value>e-conomic agreement grant token</value>
    [DataMember(Name="agreement_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreement_token")]
    public string AgreementToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntegrationSettingsEconomic {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Agreement: ").Append(Agreement).Append("\n");
      sb.Append("  AgreementToken: ").Append(AgreementToken).Append("\n");
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
