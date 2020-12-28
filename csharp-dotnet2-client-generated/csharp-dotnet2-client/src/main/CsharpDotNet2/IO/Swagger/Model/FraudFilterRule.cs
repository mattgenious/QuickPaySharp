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
  public class FraudFilterRule {
    /// <summary>
    /// The variable metric this rule applies to
    /// </summary>
    /// <value>The variable metric this rule applies to</value>
    [DataMember(Name="metric_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metric_name")]
    public string MetricName { get; set; }

    /// <summary>
    /// The operator (==, !=, <, <=, >, >=, in, not_in)
    /// </summary>
    /// <value>The operator (==, !=, <, <=, >, >=, in, not_in)</value>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string Operator { get; set; }

    /// <summary>
    /// The string representation of the value used for comparison with the metric. E.g. '42' or 'DNK'
    /// </summary>
    /// <value>The string representation of the value used for comparison with the metric. E.g. '42' or 'DNK'</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FraudFilterRule {\n");
      sb.Append("  MetricName: ").Append(MetricName).Append("\n");
      sb.Append("  Operator: ").Append(Operator).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
