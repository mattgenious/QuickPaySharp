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
  public class QuickPayProtocolV10Activity {
    /// <summary>
    /// Activity performed on
    /// </summary>
    /// <value>Activity performed on</value>
    [DataMember(Name="account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_id")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Activity action
    /// </summary>
    /// <value>Activity action</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// Activity changes
    /// </summary>
    /// <value>Activity changes</value>
    [DataMember(Name="changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changes")]
    public Dictionary<string, string> Changes { get; set; }

    /// <summary>
    /// Timestamp of activity
    /// </summary>
    /// <value>Timestamp of activity</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Extra data
    /// </summary>
    /// <value>Extra data</value>
    [DataMember(Name="extra", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extra")]
    public Dictionary<string, string> Extra { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    /// <value>ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Whether activity was created by a supporter
    /// </summary>
    /// <value>Whether activity was created by a supporter</value>
    [DataMember(Name="support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "support")]
    public bool? Support { get; set; }

    /// <summary>
    /// Activity target id
    /// </summary>
    /// <value>Activity target id</value>
    [DataMember(Name="target_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_id")]
    public int? TargetId { get; set; }

    /// <summary>
    /// Activity target
    /// </summary>
    /// <value>Activity target</value>
    [DataMember(Name="target_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_type")]
    public string TargetType { get; set; }

    /// <summary>
    /// Activity performed by
    /// </summary>
    /// <value>Activity performed by</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10Activity {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  Changes: ").Append(Changes).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Extra: ").Append(Extra).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Support: ").Append(Support).Append("\n");
      sb.Append("  TargetId: ").Append(TargetId).Append("\n");
      sb.Append("  TargetType: ").Append(TargetType).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
