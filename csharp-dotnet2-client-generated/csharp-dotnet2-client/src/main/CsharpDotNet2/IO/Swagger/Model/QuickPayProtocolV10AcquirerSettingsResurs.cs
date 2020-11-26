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
  public class QuickPayProtocolV10AcquirerSettingsResurs {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Resurs user_name
    /// </summary>
    /// <value>Resurs user_name</value>
    [DataMember(Name="customer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_id")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Resurs password
    /// </summary>
    /// <value>Resurs password</value>
    [DataMember(Name="customer_password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_password")]
    public string CustomerPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10AcquirerSettingsResurs {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  CustomerPassword: ").Append(CustomerPassword).Append("\n");
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
