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
  public class AcquirerSettingsCoinify {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Coinify API key
    /// </summary>
    /// <value>Coinify API key</value>
    [DataMember(Name="api_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api_key")]
    public string ApiKey { get; set; }

    /// <summary>
    /// Coinify API secret
    /// </summary>
    /// <value>Coinify API secret</value>
    [DataMember(Name="api_secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api_secret")]
    public string ApiSecret { get; set; }

    /// <summary>
    /// Coinify IPN secret
    /// </summary>
    /// <value>Coinify IPN secret</value>
    [DataMember(Name="ipn_secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipn_secret")]
    public string IpnSecret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsCoinify {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      sb.Append("  ApiSecret: ").Append(ApiSecret).Append("\n");
      sb.Append("  IpnSecret: ").Append(IpnSecret).Append("\n");
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
