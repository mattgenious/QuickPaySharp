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
  public class QuickPayProtocolV10SubscriptionGroupResult {
    /// <summary>
    /// Error message if anything went wrong, else null
    /// </summary>
    /// <value>Error message if anything went wrong, else null</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// HTTP status code of recurring enqueue request
    /// </summary>
    /// <value>HTTP status code of recurring enqueue request</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// Id of subscription
    /// </summary>
    /// <value>Id of subscription</value>
    [DataMember(Name="subscription_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_id")]
    public int? SubscriptionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10SubscriptionGroupResult {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
