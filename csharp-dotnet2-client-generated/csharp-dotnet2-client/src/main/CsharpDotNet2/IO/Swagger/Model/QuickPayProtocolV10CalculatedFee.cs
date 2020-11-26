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
  public class QuickPayProtocolV10CalculatedFee {
    /// <summary>
    /// Acquirer
    /// </summary>
    /// <value>Acquirer</value>
    [DataMember(Name="acquirer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirer")]
    public string Acquirer { get; set; }

    /// <summary>
    /// Amount that the fee is calculated from
    /// </summary>
    /// <value>Amount that the fee is calculated from</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// The calculated fee in smallest unit
    /// </summary>
    /// <value>The calculated fee in smallest unit</value>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public int? Fee { get; set; }

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
    /// Amount + Fee
    /// </summary>
    /// <value>Amount + Fee</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10CalculatedFee {\n");
      sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  Formula: ").Append(Formula).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
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
