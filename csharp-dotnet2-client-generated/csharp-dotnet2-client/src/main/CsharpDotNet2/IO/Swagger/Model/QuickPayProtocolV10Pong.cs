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
  public class QuickPayProtocolV10Pong {
    /// <summary>
    /// Friendly message
    /// </summary>
    /// <value>Friendly message</value>
    [DataMember(Name="msg", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "msg")]
    public string Msg { get; set; }

    /// <summary>
    /// Echo params send in the request
    /// </summary>
    /// <value>Echo params send in the request</value>
    [DataMember(Name="params", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "params")]
    public Dictionary<string, string> Params { get; set; }

    /// <summary>
    /// API scope
    /// </summary>
    /// <value>API scope</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// The version ('v10')
    /// </summary>
    /// <value>The version ('v10')</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10Pong {\n");
      sb.Append("  Msg: ").Append(Msg).Append("\n");
      sb.Append("  Params: ").Append(Params).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
