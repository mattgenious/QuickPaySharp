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
  public class QuickPayProtocolV10FraudRuleset {
    /// <summary>
    /// The action that happens if this ruleset is triggered (nothing, flag, force_3d or block)
    /// </summary>
    /// <value>The action that happens if this ruleset is triggered (nothing, flag, force_3d or block)</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// The method used to combine filter rules (and, or)
    /// </summary>
    /// <value>The method used to combine filter rules (and, or)</value>
    [DataMember(Name="combinator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "combinator")]
    public string Combinator { get; set; }

    /// <summary>
    /// The rules of the ruleset
    /// </summary>
    /// <value>The rules of the ruleset</value>
    [DataMember(Name="filter_rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_rules")]
    public List<QuickPayProtocolV10FraudFilterRule> FilterRules { get; set; }

    /// <summary>
    /// Unique id
    /// </summary>
    /// <value>Unique id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Owner of the ruleset
    /// </summary>
    /// <value>Owner of the ruleset</value>
    [DataMember(Name="merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant_id")]
    public int? MerchantId { get; set; }

    /// <summary>
    /// Descriptive name
    /// </summary>
    /// <value>Descriptive name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10FraudRuleset {\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  Combinator: ").Append(Combinator).Append("\n");
      sb.Append("  FilterRules: ").Append(FilterRules).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
