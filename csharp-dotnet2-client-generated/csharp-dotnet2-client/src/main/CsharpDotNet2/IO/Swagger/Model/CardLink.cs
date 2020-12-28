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
  public class CardLink {
    /// <summary>
    /// Force usage of this acquirer
    /// </summary>
    /// <value>Force usage of this acquirer</value>
    [DataMember(Name="acquirer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirer")]
    public string Acquirer { get; set; }

    /// <summary>
    /// Id of agreement that will be used in the payment window
    /// </summary>
    /// <value>Id of agreement that will be used in the payment window</value>
    [DataMember(Name="agreement_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreement_id")]
    public int? AgreementId { get; set; }

    /// <summary>
    /// Branding config
    /// </summary>
    /// <value>Branding config</value>
    [DataMember(Name="branding_config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branding_config")]
    public Object BrandingConfig { get; set; }

    /// <summary>
    /// The branding to use in the payment window
    /// </summary>
    /// <value>The branding to use in the payment window</value>
    [DataMember(Name="branding_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branding_id")]
    public int? BrandingId { get; set; }

    /// <summary>
    /// Endpoint for a POST callback
    /// </summary>
    /// <value>Endpoint for a POST callback</value>
    [DataMember(Name="callbackurl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callbackurl")]
    public string Callbackurl { get; set; }

    /// <summary>
    /// Where cardholder is redirected after cancel
    /// </summary>
    /// <value>Where cardholder is redirected after cancel</value>
    [DataMember(Name="cancelurl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancelurl")]
    public string Cancelurl { get; set; }

    /// <summary>
    /// Where cardholder is redirected after success
    /// </summary>
    /// <value>Where cardholder is redirected after success</value>
    [DataMember(Name="continueurl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "continueurl")]
    public string Continueurl { get; set; }

    /// <summary>
    /// Allowed in iframe
    /// </summary>
    /// <value>Allowed in iframe</value>
    [DataMember(Name="framed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "framed")]
    public bool? Framed { get; set; }

    /// <summary>
    /// Set this to enable Google Analytics events from the payment window
    /// </summary>
    /// <value>Set this to enable Google Analytics events from the payment window</value>
    [DataMember(Name="google_analytics_client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "google_analytics_client_id")]
    public string GoogleAnalyticsClientId { get; set; }

    /// <summary>
    /// Set this to enable Google Analytics events from the payment window
    /// </summary>
    /// <value>Set this to enable Google Analytics events from the payment window</value>
    [DataMember(Name="google_analytics_tracking_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "google_analytics_tracking_id")]
    public string GoogleAnalyticsTrackingId { get; set; }

    /// <summary>
    /// Two letter language code that determines the language of the payment window
    /// </summary>
    /// <value>Two letter language code that determines the language of the payment window</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Lock to these payment methods
    /// </summary>
    /// <value>Lock to these payment methods</value>
    [DataMember(Name="payment_methods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_methods")]
    public string PaymentMethods { get; set; }

    /// <summary>
    /// Url to payment window for this payment link
    /// </summary>
    /// <value>Url to payment window for this payment link</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Version of payment window and API
    /// </summary>
    /// <value>Version of payment window and API</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardLink {\n");
      sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
      sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
      sb.Append("  BrandingConfig: ").Append(BrandingConfig).Append("\n");
      sb.Append("  BrandingId: ").Append(BrandingId).Append("\n");
      sb.Append("  Callbackurl: ").Append(Callbackurl).Append("\n");
      sb.Append("  Cancelurl: ").Append(Cancelurl).Append("\n");
      sb.Append("  Continueurl: ").Append(Continueurl).Append("\n");
      sb.Append("  Framed: ").Append(Framed).Append("\n");
      sb.Append("  GoogleAnalyticsClientId: ").Append(GoogleAnalyticsClientId).Append("\n");
      sb.Append("  GoogleAnalyticsTrackingId: ").Append(GoogleAnalyticsTrackingId).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
