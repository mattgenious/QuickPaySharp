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
  public class AcquirerStatus {
    /// <summary>
    /// Acquirer
    /// </summary>
    /// <value>Acquirer</value>
    [DataMember(Name="acquirer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirer")]
    public string Acquirer { get; set; }

    /// <summary>
    /// Health of the acquirer in %
    /// </summary>
    /// <value>Health of the acquirer in %</value>
    [DataMember(Name="health", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "health")]
    public int? Health { get; set; }

    /// <summary>
    /// Status of the acquirer. Can be 'ok', 'irregular' or 'down'
    /// </summary>
    /// <value>Status of the acquirer. Can be 'ok', 'irregular' or 'down'</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerStatus {\n");
      sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
      sb.Append("  Health: ").Append(Health).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
