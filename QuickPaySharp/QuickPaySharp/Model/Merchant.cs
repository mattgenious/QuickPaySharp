using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace QuickPaySharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Merchant {
    /// <summary>
    /// Acquirer settings
    /// </summary>
    /// <value>Acquirer settings</value>
    [DataMember(Name="acquirer_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirer_settings")]
    public AcquirerSettings AcquirerSettings { get; set; }

    /// <summary>
    /// Allow test transactions
    /// </summary>
    /// <value>Allow test transactions</value>
    [DataMember(Name="allow_test_transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_test_transactions")]
    public bool? AllowTestTransactions { get; set; }

    /// <summary>
    /// Include acquirer fee on payments
    /// </summary>
    /// <value>Include acquirer fee on payments</value>
    [DataMember(Name="autofee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autofee")]
    public bool? Autofee { get; set; }

    /// <summary>
    /// Billing address
    /// </summary>
    /// <value>Billing address</value>
    [DataMember(Name="billing_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_address")]
    public Address BillingAddress { get; set; }

    /// <summary>
    /// Callback url
    /// </summary>
    /// <value>Callback url</value>
    [DataMember(Name="callback_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback_url")]
    public string CallbackUrl { get; set; }

    /// <summary>
    /// Contact email
    /// </summary>
    /// <value>Contact email</value>
    [DataMember(Name="contact_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact_email")]
    public string ContactEmail { get; set; }

    /// <summary>
    /// Timestamp of creation
    /// </summary>
    /// <value>Timestamp of creation</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Customer address
    /// </summary>
    /// <value>Customer address</value>
    [DataMember(Name="customer_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_address")]
    public Address CustomerAddress { get; set; }

    /// <summary>
    /// Default branding config
    /// </summary>
    /// <value>Default branding config</value>
    [DataMember(Name="default_branding_config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_branding_config")]
    public Object DefaultBrandingConfig { get; set; }

    /// <summary>
    /// Id of default branding, or null
    /// </summary>
    /// <value>Id of default branding, or null</value>
    [DataMember(Name="default_branding_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_branding_id")]
    public int? DefaultBrandingId { get; set; }

    /// <summary>
    /// Default payment language (Two letter language code, ISO-639-1)
    /// </summary>
    /// <value>Default payment language (Two letter language code, ISO-639-1)</value>
    [DataMember(Name="default_payment_language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_payment_language")]
    public string DefaultPaymentLanguage { get; set; }

    /// <summary>
    /// Comma separated list of default payment methods
    /// </summary>
    /// <value>Comma separated list of default payment methods</value>
    [DataMember(Name="default_payment_methods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_payment_methods")]
    public string DefaultPaymentMethods { get; set; }

    /// <summary>
    /// Text to be displayed on cardholder's statement. Currently supported by Clearhaus only
    /// </summary>
    /// <value>Text to be displayed on cardholder's statement. Currently supported by Clearhaus only</value>
    [DataMember(Name="default_text_on_statement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_text_on_statement")]
    public string DefaultTextOnStatement { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    /// <value>ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Integration settings
    /// </summary>
    /// <value>Integration settings</value>
    [DataMember(Name="integration_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "integration_settings")]
    public IntegrationSettings IntegrationSettings { get; set; }

    /// <summary>
    /// Locale
    /// </summary>
    /// <value>Locale</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Timestamp when logging is active 
    /// </summary>
    /// <value>Timestamp when logging is active </value>
    [DataMember(Name="logging_stops_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logging_stops_at")]
    public DateTime? LoggingStopsAt { get; set; }

    /// <summary>
    /// PCI settings
    /// </summary>
    /// <value>PCI settings</value>
    [DataMember(Name="pci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pci")]
    public PciSettings Pci { get; set; }

    /// <summary>
    /// Reseller of Merchant
    /// </summary>
    /// <value>Reseller of Merchant</value>
    [DataMember(Name="reseller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reseller")]
    public MerchantReseller Reseller { get; set; }

    /// <summary>
    /// Shop name
    /// </summary>
    /// <value>Shop name</value>
    [DataMember(Name="shop_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shop_name")]
    public string ShopName { get; set; }

    /// <summary>
    /// Shop url (deprecated, use shop_urls instead)
    /// </summary>
    /// <value>Shop url (deprecated, use shop_urls instead)</value>
    [DataMember(Name="shop_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shop_url")]
    public string ShopUrl { get; set; }

    /// <summary>
    /// Shop urls
    /// </summary>
    /// <value>Shop urls</value>
    [DataMember(Name="shop_urls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shop_urls")]
    public List<Object> ShopUrls { get; set; }

    /// <summary>
    /// Shop system
    /// </summary>
    /// <value>Shop system</value>
    [DataMember(Name="shopsystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shopsystem")]
    public string Shopsystem { get; set; }

    /// <summary>
    /// Timestamp when merchant was suspended or null if it is not suspended
    /// </summary>
    /// <value>Timestamp when merchant was suspended or null if it is not suspended</value>
    [DataMember(Name="suspended_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspended_at")]
    public DateTime? SuspendedAt { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    /// <value>Timezone</value>
    [DataMember(Name="timezone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Type of account
    /// </summary>
    /// <value>Type of account</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Merchant {\n");
      sb.Append("  AcquirerSettings: ").Append(AcquirerSettings).Append("\n");
      sb.Append("  AllowTestTransactions: ").Append(AllowTestTransactions).Append("\n");
      sb.Append("  Autofee: ").Append(Autofee).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
      sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  CustomerAddress: ").Append(CustomerAddress).Append("\n");
      sb.Append("  DefaultBrandingConfig: ").Append(DefaultBrandingConfig).Append("\n");
      sb.Append("  DefaultBrandingId: ").Append(DefaultBrandingId).Append("\n");
      sb.Append("  DefaultPaymentLanguage: ").Append(DefaultPaymentLanguage).Append("\n");
      sb.Append("  DefaultPaymentMethods: ").Append(DefaultPaymentMethods).Append("\n");
      sb.Append("  DefaultTextOnStatement: ").Append(DefaultTextOnStatement).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IntegrationSettings: ").Append(IntegrationSettings).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  LoggingStopsAt: ").Append(LoggingStopsAt).Append("\n");
      sb.Append("  Pci: ").Append(Pci).Append("\n");
      sb.Append("  Reseller: ").Append(Reseller).Append("\n");
      sb.Append("  ShopName: ").Append(ShopName).Append("\n");
      sb.Append("  ShopUrl: ").Append(ShopUrl).Append("\n");
      sb.Append("  ShopUrls: ").Append(ShopUrls).Append("\n");
      sb.Append("  Shopsystem: ").Append(Shopsystem).Append("\n");
      sb.Append("  SuspendedAt: ").Append(SuspendedAt).Append("\n");
      sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
