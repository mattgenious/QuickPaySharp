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
  public class AcquirerSettingsSwish {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Swish certificate and private-key cryptography key id
    /// </summary>
    /// <value>Swish certificate and private-key cryptography key id</value>
    [DataMember(Name="cryptography_key_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cryptography_key_id")]
    public int? CryptographyKeyId { get; set; }

    /// <summary>
    /// Swish merchant id
    /// </summary>
    /// <value>Swish merchant id</value>
    [DataMember(Name="merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant_id")]
    public string MerchantId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsSwish {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  CryptographyKeyId: ").Append(CryptographyKeyId).Append("\n");
      sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
