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
  public class QuickPayProtocolV10AcquirerSettings {
    /// <summary>
    /// Bambora settings
    /// </summary>
    /// <value>Bambora settings</value>
    [DataMember(Name="bambora", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bambora")]
    public QuickPayProtocolV10AcquirerSettingsBambora Bambora { get; set; }

    /// <summary>
    /// Clearhaus settings
    /// </summary>
    /// <value>Clearhaus settings</value>
    [DataMember(Name="clearhaus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clearhaus")]
    public QuickPayProtocolV10AcquirerSettingsClearhaus Clearhaus { get; set; }

    /// <summary>
    /// Coinify settings
    /// </summary>
    /// <value>Coinify settings</value>
    [DataMember(Name="coinify", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coinify")]
    public QuickPayProtocolV10AcquirerSettingsCoinify Coinify { get; set; }

    /// <summary>
    /// Elavon settings
    /// </summary>
    /// <value>Elavon settings</value>
    [DataMember(Name="elavon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elavon")]
    public QuickPayProtocolV10AcquirerSettingsElavon Elavon { get; set; }

    /// <summary>
    /// Handelsbanken settings
    /// </summary>
    /// <value>Handelsbanken settings</value>
    [DataMember(Name="handelsbanken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handelsbanken")]
    public QuickPayProtocolV10AcquirerSettingsHandelsbanken Handelsbanken { get; set; }

    /// <summary>
    /// Klarna settings
    /// </summary>
    /// <value>Klarna settings</value>
    [DataMember(Name="klarna", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "klarna")]
    public QuickPayProtocolV10AcquirerSettingsKlarna Klarna { get; set; }

    /// <summary>
    /// KlarnaPayments settings
    /// </summary>
    /// <value>KlarnaPayments settings</value>
    [DataMember(Name="klarnapayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "klarnapayments")]
    public QuickPayProtocolV10AcquirerSettingsKlarnaPayments Klarnapayments { get; set; }

    /// <summary>
    /// MobilePay settings
    /// </summary>
    /// <value>MobilePay settings</value>
    [DataMember(Name="mobilepay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobilepay")]
    public QuickPayProtocolV10AcquirerSettingsMobilePay Mobilepay { get; set; }

    /// <summary>
    /// MobilePayOnline settings
    /// </summary>
    /// <value>MobilePayOnline settings</value>
    [DataMember(Name="mobilepayonline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobilepayonline")]
    public QuickPayProtocolV10AcquirerSettingsMobilePayOnline Mobilepayonline { get; set; }

    /// <summary>
    /// MobilePay Subscription settings
    /// </summary>
    /// <value>MobilePay Subscription settings</value>
    [DataMember(Name="mobilepaysubscriptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobilepaysubscriptions")]
    public QuickPayProtocolV10AcquirerSettingsMobilePaySubscriptions Mobilepaysubscriptions { get; set; }

    /// <summary>
    /// Nets settings
    /// </summary>
    /// <value>Nets settings</value>
    [DataMember(Name="nets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nets")]
    public QuickPayProtocolV10AcquirerSettingsNets Nets { get; set; }

    /// <summary>
    /// PayPal settings
    /// </summary>
    /// <value>PayPal settings</value>
    [DataMember(Name="paypal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paypal")]
    public QuickPayProtocolV10AcquirerSettingsPayPal Paypal { get; set; }

    /// <summary>
    /// Paysafecard settings
    /// </summary>
    /// <value>Paysafecard settings</value>
    [DataMember(Name="paysafecard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paysafecard")]
    public QuickPayProtocolV10AcquirerSettingsPaysafecard Paysafecard { get; set; }

    /// <summary>
    /// Resurs settings
    /// </summary>
    /// <value>Resurs settings</value>
    [DataMember(Name="resurs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resurs")]
    public QuickPayProtocolV10AcquirerSettingsResurs Resurs { get; set; }

    /// <summary>
    /// Sofort settings
    /// </summary>
    /// <value>Sofort settings</value>
    [DataMember(Name="sofort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sofort")]
    public QuickPayProtocolV10AcquirerSettingsSofort Sofort { get; set; }

    /// <summary>
    /// Swedbank settings
    /// </summary>
    /// <value>Swedbank settings</value>
    [DataMember(Name="swedbank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "swedbank")]
    public QuickPayProtocolV10AcquirerSettingsSwedbank Swedbank { get; set; }

    /// <summary>
    /// Swish settings
    /// </summary>
    /// <value>Swish settings</value>
    [DataMember(Name="swish", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "swish")]
    public QuickPayProtocolV10AcquirerSettingsSwish Swish { get; set; }

    /// <summary>
    /// Teller settings
    /// </summary>
    /// <value>Teller settings</value>
    [DataMember(Name="teller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teller")]
    public QuickPayProtocolV10AcquirerSettingsTeller Teller { get; set; }

    /// <summary>
    /// Trustly settings
    /// </summary>
    /// <value>Trustly settings</value>
    [DataMember(Name="trustly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trustly")]
    public QuickPayProtocolV10AcquirerSettingsTrustly Trustly { get; set; }

    /// <summary>
    /// Valitor settings
    /// </summary>
    /// <value>Valitor settings</value>
    [DataMember(Name="valitor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valitor")]
    public QuickPayProtocolV10AcquirerSettingsValitor Valitor { get; set; }

    /// <summary>
    /// ViaBill settings
    /// </summary>
    /// <value>ViaBill settings</value>
    [DataMember(Name="viabill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viabill")]
    public QuickPayProtocolV10AcquirerSettingsViaBill Viabill { get; set; }

    /// <summary>
    /// Vipps settings
    /// </summary>
    /// <value>Vipps settings</value>
    [DataMember(Name="vipps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vipps")]
    public QuickPayProtocolV10AcquirerSettingsVipps Vipps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10AcquirerSettings {\n");
      sb.Append("  Bambora: ").Append(Bambora).Append("\n");
      sb.Append("  Clearhaus: ").Append(Clearhaus).Append("\n");
      sb.Append("  Coinify: ").Append(Coinify).Append("\n");
      sb.Append("  Elavon: ").Append(Elavon).Append("\n");
      sb.Append("  Handelsbanken: ").Append(Handelsbanken).Append("\n");
      sb.Append("  Klarna: ").Append(Klarna).Append("\n");
      sb.Append("  Klarnapayments: ").Append(Klarnapayments).Append("\n");
      sb.Append("  Mobilepay: ").Append(Mobilepay).Append("\n");
      sb.Append("  Mobilepayonline: ").Append(Mobilepayonline).Append("\n");
      sb.Append("  Mobilepaysubscriptions: ").Append(Mobilepaysubscriptions).Append("\n");
      sb.Append("  Nets: ").Append(Nets).Append("\n");
      sb.Append("  Paypal: ").Append(Paypal).Append("\n");
      sb.Append("  Paysafecard: ").Append(Paysafecard).Append("\n");
      sb.Append("  Resurs: ").Append(Resurs).Append("\n");
      sb.Append("  Sofort: ").Append(Sofort).Append("\n");
      sb.Append("  Swedbank: ").Append(Swedbank).Append("\n");
      sb.Append("  Swish: ").Append(Swish).Append("\n");
      sb.Append("  Teller: ").Append(Teller).Append("\n");
      sb.Append("  Trustly: ").Append(Trustly).Append("\n");
      sb.Append("  Valitor: ").Append(Valitor).Append("\n");
      sb.Append("  Viabill: ").Append(Viabill).Append("\n");
      sb.Append("  Vipps: ").Append(Vipps).Append("\n");
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
