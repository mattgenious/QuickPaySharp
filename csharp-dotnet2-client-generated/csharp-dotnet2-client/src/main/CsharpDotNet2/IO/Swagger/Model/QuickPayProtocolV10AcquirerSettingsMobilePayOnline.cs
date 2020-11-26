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
  public class QuickPayProtocolV10AcquirerSettingsMobilePayOnline {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// MobilePayOnline delivery address selection countries limited to
    /// </summary>
    /// <value>MobilePayOnline delivery address selection countries limited to</value>
    [DataMember(Name="delivery_limited_to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery_limited_to")]
    public string DeliveryLimitedTo { get; set; }

    /// <summary>
    /// Id of the merchant
    /// </summary>
    /// <value>Id of the merchant</value>
    [DataMember(Name="merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant_id")]
    public int? MerchantId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10AcquirerSettingsMobilePayOnline {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  DeliveryLimitedTo: ").Append(DeliveryLimitedTo).Append("\n");
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
