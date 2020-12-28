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
  public class AcquirerSettingsKlarna {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Klarna merchant id
    /// </summary>
    /// <value>Klarna merchant id</value>
    [DataMember(Name="eid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eid")]
    public int? Eid { get; set; }

    /// <summary>
    /// Klarna shared secret
    /// </summary>
    /// <value>Klarna shared secret</value>
    [DataMember(Name="shared_secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shared_secret")]
    public string SharedSecret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsKlarna {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Eid: ").Append(Eid).Append("\n");
      sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
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
