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
  public class FeeFormula {
    /// <summary>
    /// Acquirer
    /// </summary>
    /// <value>Acquirer</value>
    [DataMember(Name="acquirer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirer")]
    public string Acquirer { get; set; }

    /// <summary>
    /// The formula
    /// </summary>
    /// <value>The formula</value>
    [DataMember(Name="formula", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formula")]
    public string Formula { get; set; }

    /// <summary>
    /// Payment method
    /// </summary>
    /// <value>Payment method</value>
    [DataMember(Name="payment_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_method")]
    public string PaymentMethod { get; set; }

    /// <summary>
    /// True if this is the standard fee formula
    /// </summary>
    /// <value>True if this is the standard fee formula</value>
    [DataMember(Name="standard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standard")]
    public bool? Standard { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeeFormula {\n");
      sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
      sb.Append("  Formula: ").Append(Formula).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  Standard: ").Append(Standard).Append("\n");
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
