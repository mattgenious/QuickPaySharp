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
  public class AcquirerSettingsPayPal {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// True if credit-card payments is enabled
    /// </summary>
    /// <value>True if credit-card payments is enabled</value>
    [DataMember(Name="credit_card", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credit_card")]
    public bool? CreditCard { get; set; }

    /// <summary>
    /// True if recurring is enabled
    /// </summary>
    /// <value>True if recurring is enabled</value>
    [DataMember(Name="recurring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring")]
    public bool? Recurring { get; set; }

    /// <summary>
    /// Scopes token grants access to
    /// </summary>
    /// <value>Scopes token grants access to</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public List<string> Scope { get; set; }

    /// <summary>
    /// Authentication token
    /// </summary>
    /// <value>Authentication token</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Authentication token secret
    /// </summary>
    /// <value>Authentication token secret</value>
    [DataMember(Name="token_secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token_secret")]
    public string TokenSecret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsPayPal {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
      sb.Append("  Recurring: ").Append(Recurring).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  TokenSecret: ").Append(TokenSecret).Append("\n");
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
