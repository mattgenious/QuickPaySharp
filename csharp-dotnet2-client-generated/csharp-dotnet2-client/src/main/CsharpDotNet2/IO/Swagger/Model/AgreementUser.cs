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
  public class AgreementUser {
    /// <summary>
    /// Email of user
    /// </summary>
    /// <value>Email of user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Id of user
    /// </summary>
    /// <value>Id of user</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of user. Will be hidden until user has accepted agreement.
    /// </summary>
    /// <value>Name of user. Will be hidden until user has accepted agreement.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// If true, this user should only be used for api-access and services. Not to log into manager
    /// </summary>
    /// <value>If true, this user should only be used for api-access and services. Not to log into manager</value>
    [DataMember(Name="system_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_user")]
    public bool? SystemUser { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementUser {\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SystemUser: ").Append(SystemUser).Append("\n");
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
