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
  public class Agreement {
    /// <summary>
    /// Is agreement accepted by user
    /// </summary>
    /// <value>Is agreement accepted by user</value>
    [DataMember(Name="accepted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accepted")]
    public bool? Accepted { get; set; }

    /// <summary>
    /// Account details
    /// </summary>
    /// <value>Account details</value>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public AgreementAccount Account { get; set; }

    /// <summary>
    /// ACL permissions
    /// </summary>
    /// <value>ACL permissions</value>
    [DataMember(Name="acl_permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acl_permissions")]
    public List<AclPermission> AclPermissions { get; set; }

    /// <summary>
    /// API key. This will show as null unless it is owned by your user or by a system user
    /// </summary>
    /// <value>API key. This will show as null unless it is owned by your user or by a system user</value>
    [DataMember(Name="api_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api_key")]
    public string ApiKey { get; set; }

    /// <summary>
    /// Timestamp of creation
    /// </summary>
    /// <value>Timestamp of creation</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    /// <value>Description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    /// <value>ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// IP restriction
    /// </summary>
    /// <value>IP restriction</value>
    [DataMember(Name="ip_restriction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ip_restriction")]
    public List<IPRestriction> IpRestriction { get; set; }

    /// <summary>
    /// If true, the agreement can not be changed
    /// </summary>
    /// <value>If true, the agreement can not be changed</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// Is account owner
    /// </summary>
    /// <value>Is account owner</value>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public bool? Owner { get; set; }

    /// <summary>
    /// Service name (only for system/service agreements)
    /// </summary>
    /// <value>Service name (only for system/service agreements)</value>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public string Service { get; set; }

    /// <summary>
    /// Support agreement
    /// </summary>
    /// <value>Support agreement</value>
    [DataMember(Name="support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "support")]
    public bool? Support { get; set; }

    /// <summary>
    /// User details
    /// </summary>
    /// <value>User details</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public AgreementUser User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Agreement {\n");
      sb.Append("  Accepted: ").Append(Accepted).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  AclPermissions: ").Append(AclPermissions).Append("\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IpRestriction: ").Append(IpRestriction).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
      sb.Append("  Support: ").Append(Support).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
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
