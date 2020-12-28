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
  public class AcquirerSettingsPaysafecard {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Paysafecard currencies
    /// </summary>
    /// <value>Paysafecard currencies</value>
    [DataMember(Name="currencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencies")]
    public List<string> Currencies { get; set; }

    /// <summary>
    /// Paysafecard password
    /// </summary>
    /// <value>Paysafecard password</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// Paysafecard username
    /// </summary>
    /// <value>Paysafecard username</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsPaysafecard {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Currencies: ").Append(Currencies).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
