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
  public class QuickPayProtocolV10PaymentMethodPriority {
    /// <summary>
    /// Payment method priority
    /// </summary>
    /// <value>Payment method priority</value>
    [DataMember(Name="payment_method_priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_method_priority")]
    public Dictionary<string, string> PaymentMethodPriority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10PaymentMethodPriority {\n");
      sb.Append("  PaymentMethodPriority: ").Append(PaymentMethodPriority).Append("\n");
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
