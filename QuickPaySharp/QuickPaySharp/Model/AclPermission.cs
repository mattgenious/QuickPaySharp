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
  public class AclPermission {
    /// <summary>
    /// Allow DELETE
    /// </summary>
    /// <value>Allow DELETE</value>
    [DataMember(Name="delete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delete")]
    public bool? Delete { get; set; }

    /// <summary>
    /// Allow GET
    /// </summary>
    /// <value>Allow GET</value>
    [DataMember(Name="get", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "get")]
    public bool? Get { get; set; }

    /// <summary>
    /// Allow PATCH
    /// </summary>
    /// <value>Allow PATCH</value>
    [DataMember(Name="patch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "patch")]
    public bool? Patch { get; set; }

    /// <summary>
    /// Allow POST
    /// </summary>
    /// <value>Allow POST</value>
    [DataMember(Name="post", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "post")]
    public bool? Post { get; set; }

    /// <summary>
    /// Allow PUT
    /// </summary>
    /// <value>Allow PUT</value>
    [DataMember(Name="put", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "put")]
    public bool? Put { get; set; }

    /// <summary>
    /// Resource URI
    /// </summary>
    /// <value>Resource URI</value>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AclPermission {\n");
      sb.Append("  Delete: ").Append(Delete).Append("\n");
      sb.Append("  Get: ").Append(Get).Append("\n");
      sb.Append("  Patch: ").Append(Patch).Append("\n");
      sb.Append("  Post: ").Append(Post).Append("\n");
      sb.Append("  Put: ").Append(Put).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
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
