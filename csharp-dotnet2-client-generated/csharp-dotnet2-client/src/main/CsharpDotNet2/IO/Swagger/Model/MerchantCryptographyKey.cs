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
  public class MerchantCryptographyKey {
    /// <summary>
    /// Certificate expiration timestamp
    /// </summary>
    /// <value>Certificate expiration timestamp</value>
    [DataMember(Name="certificate_expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "certificate_expires_at")]
    public DateTime? CertificateExpiresAt { get; set; }

    /// <summary>
    /// Timestamp of creation
    /// </summary>
    /// <value>Timestamp of creation</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// KMS id
    /// </summary>
    /// <value>KMS id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Public Key identification hash
    /// </summary>
    /// <value>Public Key identification hash</value>
    [DataMember(Name="public_key_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_key_hash")]
    public string PublicKeyHash { get; set; }

    /// <summary>
    /// Short description
    /// </summary>
    /// <value>Short description</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Key type (ec/rsa)
    /// </summary>
    /// <value>Key type (ec/rsa)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Timestamp of update
    /// </summary>
    /// <value>Timestamp of update</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantCryptographyKey {\n");
      sb.Append("  CertificateExpiresAt: ").Append(CertificateExpiresAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PublicKeyHash: ").Append(PublicKeyHash).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
