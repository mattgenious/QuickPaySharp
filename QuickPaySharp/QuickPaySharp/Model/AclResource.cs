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
  public class AclResource {
    /// <summary>
    /// Account type that this resource applies to
    /// </summary>
    /// <value>Account type that this resource applies to</value>
    [DataMember(Name="account_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_type")]
    public string AccountType { get; set; }

    /// <summary>
    /// The valid http verbs for this resource
    /// </summary>
    /// <value>The valid http verbs for this resource</value>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public List<string> Actions { get; set; }

    /// <summary>
    /// Description of the resource
    /// </summary>
    /// <value>Description of the resource</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Path to the resource
    /// </summary>
    /// <value>Path to the resource</value>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AclResource {\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
