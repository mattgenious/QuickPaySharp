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
  public class Card {
    /// <summary>
    /// Accepted by acquirer
    /// </summary>
    /// <value>Accepted by acquirer</value>
    [DataMember(Name="accepted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accepted")]
    public bool? Accepted { get; set; }

    /// <summary>
    /// Acquirer that processed the card
    /// </summary>
    /// <value>Acquirer that processed the card</value>
    [DataMember(Name="acquirer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirer")]
    public string Acquirer { get; set; }

    /// <summary>
    /// Timestamp of creation
    /// </summary>
    /// <value>Timestamp of creation</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Card id
    /// </summary>
    /// <value>Card id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Sharable link to payment window
    /// </summary>
    /// <value>Sharable link to payment window</value>
    [DataMember(Name="link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link")]
    public CardLink Link { get; set; }

    /// <summary>
    /// Merchant id
    /// </summary>
    /// <value>Merchant id</value>
    [DataMember(Name="merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant_id")]
    public int? MerchantId { get; set; }

    /// <summary>
    /// Card metadata
    /// </summary>
    /// <value>Card metadata</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public Metadata Metadata { get; set; }

    /// <summary>
    /// Operations
    /// </summary>
    /// <value>Operations</value>
    [DataMember(Name="operations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operations")]
    public List<CardOperation> Operations { get; set; }

    /// <summary>
    /// Test mode
    /// </summary>
    /// <value>Test mode</value>
    [DataMember(Name="test_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "test_mode")]
    public bool? TestMode { get; set; }

    /// <summary>
    /// Type of transaction
    /// </summary>
    /// <value>Type of transaction</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Custom variables
    /// </summary>
    /// <value>Custom variables</value>
    [DataMember(Name="variables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variables")]
    public Dictionary<string, string> Variables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Card {\n");
      sb.Append("  Accepted: ").Append(Accepted).Append("\n");
      sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Operations: ").Append(Operations).Append("\n");
      sb.Append("  TestMode: ").Append(TestMode).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Variables: ").Append(Variables).Append("\n");
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
