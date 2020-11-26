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
  public class QuickPayProtocolV10Shipping {
    /// <summary>
    /// Delivery price
    /// </summary>
    /// <value>Delivery price</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// Delivery company
    /// </summary>
    /// <value>Delivery company</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Delivery method
    /// </summary>
    /// <value>Delivery method</value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Tracking number
    /// </summary>
    /// <value>Tracking number</value>
    [DataMember(Name="tracking_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_number")]
    public string TrackingNumber { get; set; }

    /// <summary>
    /// Link to delivery status page
    /// </summary>
    /// <value>Link to delivery status page</value>
    [DataMember(Name="tracking_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_url")]
    public string TrackingUrl { get; set; }

    /// <summary>
    /// Delivery VAT rate
    /// </summary>
    /// <value>Delivery VAT rate</value>
    [DataMember(Name="vat_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vat_rate")]
    public float? VatRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10Shipping {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
      sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
      sb.Append("  VatRate: ").Append(VatRate).Append("\n");
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
