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
  public class QuickPayProtocolV10MerchantReseller {
    /// <summary>
    /// Id of default branding, or null
    /// </summary>
    /// <value>Id of default branding, or null</value>
    [DataMember(Name="default_branding_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_branding_id")]
    public int? DefaultBrandingId { get; set; }

    /// <summary>
    /// Comma separated list of default payment methods
    /// </summary>
    /// <value>Comma separated list of default payment methods</value>
    [DataMember(Name="default_payment_methods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_payment_methods")]
    public string DefaultPaymentMethods { get; set; }

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
    /// Email address to reseller for support
    /// </summary>
    /// <value>Email address to reseller for support</value>
    [DataMember(Name="support_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "support_email")]
    public string SupportEmail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10MerchantReseller {\n");
      sb.Append("  DefaultBrandingId: ").Append(DefaultBrandingId).Append("\n");
      sb.Append("  DefaultPaymentMethods: ").Append(DefaultPaymentMethods).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
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
