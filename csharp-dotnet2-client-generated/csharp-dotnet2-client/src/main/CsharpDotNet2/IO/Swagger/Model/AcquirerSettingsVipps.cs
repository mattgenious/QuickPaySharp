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
  public class AcquirerSettingsVipps {
    /// <summary>
    /// Vipps Access-Token Subscription Key
    /// </summary>
    /// <value>Vipps Access-Token Subscription Key</value>
    [DataMember(Name="access_token_subscription_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token_subscription_key")]
    public string AccessTokenSubscriptionKey { get; set; }

    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Vipps OAuth Client ID
    /// </summary>
    /// <value>Vipps OAuth Client ID</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// Vipps OAuth Client Secret
    /// </summary>
    /// <value>Vipps OAuth Client Secret</value>
    [DataMember(Name="client_secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_secret")]
    public string ClientSecret { get; set; }

    /// <summary>
    /// Vipps eCommerce Subscription Key
    /// </summary>
    /// <value>Vipps eCommerce Subscription Key</value>
    [DataMember(Name="ecommerce_subscription_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ecommerce_subscription_key")]
    public string EcommerceSubscriptionKey { get; set; }

    /// <summary>
    /// Vipps company organization number
    /// </summary>
    /// <value>Vipps company organization number</value>
    [DataMember(Name="orgno", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orgno")]
    public string Orgno { get; set; }

    /// <summary>
    /// Vipps agreement serial number
    /// </summary>
    /// <value>Vipps agreement serial number</value>
    [DataMember(Name="serial_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serial_number")]
    public string SerialNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsVipps {\n");
      sb.Append("  AccessTokenSubscriptionKey: ").Append(AccessTokenSubscriptionKey).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
      sb.Append("  EcommerceSubscriptionKey: ").Append(EcommerceSubscriptionKey).Append("\n");
      sb.Append("  Orgno: ").Append(Orgno).Append("\n");
      sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
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
