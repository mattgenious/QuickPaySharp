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
  public class QuickPayProtocolV10AgreementAccount {
    /// <summary>
    /// Callback URL (Merchant only)
    /// </summary>
    /// <value>Callback URL (Merchant only)</value>
    [DataMember(Name="callback_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback_url")]
    public string CallbackUrl { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    /// <value>ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Shop name (Merchant only)
    /// </summary>
    /// <value>Shop name (Merchant only)</value>
    [DataMember(Name="shop_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shop_name")]
    public string ShopName { get; set; }

    /// <summary>
    /// Type of account, e.g. \"Merchant\"
    /// </summary>
    /// <value>Type of account, e.g. \"Merchant\"</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10AgreementAccount {\n");
      sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ShopName: ").Append(ShopName).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
