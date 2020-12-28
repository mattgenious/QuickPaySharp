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
  public class PaymentLink {
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
    /// Amount to authorize.
    /// </summary>
    /// <value>Amount to authorize.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// If true, will capture the transaction after authorize succeeds
    /// </summary>
    /// <value>If true, will capture the transaction after authorize succeeds</value>
    [DataMember(Name="auto_capture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_capture")]
    public bool? AutoCapture { get; set; }

    /// <summary>
    /// If true, will add acquirer fee to the amount
    /// </summary>
    /// <value>If true, will add acquirer fee to the amount</value>
    [DataMember(Name="auto_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_fee")]
    public bool? AutoFee { get; set; }

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
    [DataMember(Name="callback_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback_url")]
    public string CallbackUrl { get; set; }

    /// <summary>
    /// Where cardholder is redirected after cancel
    /// </summary>
    /// <value>Where cardholder is redirected after cancel</value>
    [DataMember(Name="cancel_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_url")]
    public string CancelUrl { get; set; }

    /// <summary>
    /// Where cardholder is redirected after success
    /// </summary>
    /// <value>Where cardholder is redirected after success</value>
    [DataMember(Name="continue_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "continue_url")]
    public string ContinueUrl { get; set; }

    /// <summary>
    /// PayPal specific: Customer email
    /// </summary>
    /// <value>PayPal specific: Customer email</value>
    [DataMember(Name="customer_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_email")]
    public string CustomerEmail { get; set; }

    /// <summary>
    /// Deadline in seconds for the cardholder to complete
    /// </summary>
    /// <value>Deadline in seconds for the cardholder to complete</value>
    [DataMember(Name="deadline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deadline")]
    public string Deadline { get; set; }

    /// <summary>
    /// Allow in iframe
    /// </summary>
    /// <value>Allow in iframe</value>
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
    /// Get customer invoice address via acquirer (Currently MobilePay and PayPal only)
    /// </summary>
    /// <value>Get customer invoice address via acquirer (Currently MobilePay and PayPal only)</value>
    [DataMember(Name="invoice_address_selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_address_selection")]
    public bool? InvoiceAddressSelection { get; set; }

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
    /// Get customer shipping address via acquirer (Currently MobilePay and PayPal only)
    /// </summary>
    /// <value>Get customer shipping address via acquirer (Currently MobilePay and PayPal only)</value>
    [DataMember(Name="shipping_address_selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_address_selection")]
    public bool? ShippingAddressSelection { get; set; }

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
      sb.Append("class PaymentLink {\n");
      sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
      sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  AutoCapture: ").Append(AutoCapture).Append("\n");
      sb.Append("  AutoFee: ").Append(AutoFee).Append("\n");
      sb.Append("  BrandingConfig: ").Append(BrandingConfig).Append("\n");
      sb.Append("  BrandingId: ").Append(BrandingId).Append("\n");
      sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
      sb.Append("  CancelUrl: ").Append(CancelUrl).Append("\n");
      sb.Append("  ContinueUrl: ").Append(ContinueUrl).Append("\n");
      sb.Append("  CustomerEmail: ").Append(CustomerEmail).Append("\n");
      sb.Append("  Deadline: ").Append(Deadline).Append("\n");
      sb.Append("  Framed: ").Append(Framed).Append("\n");
      sb.Append("  GoogleAnalyticsClientId: ").Append(GoogleAnalyticsClientId).Append("\n");
      sb.Append("  GoogleAnalyticsTrackingId: ").Append(GoogleAnalyticsTrackingId).Append("\n");
      sb.Append("  InvoiceAddressSelection: ").Append(InvoiceAddressSelection).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
      sb.Append("  ShippingAddressSelection: ").Append(ShippingAddressSelection).Append("\n");
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
