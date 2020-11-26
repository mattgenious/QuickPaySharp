/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  <p>Authorization is done using basic-auth. Authorization can be done with a user or an agreement.</p>  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
 *
 * OpenAPI spec version: 10.0
 * Contact: support@quickpay.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// QuickPayProtocolV10Merchant
    /// </summary>
    [DataContract]
    public partial class QuickPayProtocolV10Merchant :  IEquatable<QuickPayProtocolV10Merchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickPayProtocolV10Merchant" /> class.
        /// </summary>
        /// <param name="acquirerSettings">Acquirer settings.</param>
        /// <param name="allowTestTransactions">Allow test transactions.</param>
        /// <param name="autofee">Include acquirer fee on payments.</param>
        /// <param name="billingAddress">Billing address.</param>
        /// <param name="callbackUrl">Callback url.</param>
        /// <param name="contactEmail">Contact email.</param>
        /// <param name="createdAt">Timestamp of creation.</param>
        /// <param name="customerAddress">Customer address.</param>
        /// <param name="defaultBrandingConfig">Default branding config.</param>
        /// <param name="defaultBrandingId">Id of default branding, or null.</param>
        /// <param name="defaultPaymentLanguage">Default payment language (Two letter language code, ISO-639-1).</param>
        /// <param name="defaultPaymentMethods">Comma separated list of default payment methods.</param>
        /// <param name="defaultTextOnStatement">Text to be displayed on cardholder&#39;s statement. Currently supported by Clearhaus only.</param>
        /// <param name="id">ID.</param>
        /// <param name="integrationSettings">Integration settings.</param>
        /// <param name="locale">Locale.</param>
        /// <param name="loggingStopsAt">Timestamp when logging is active .</param>
        /// <param name="pci">PCI settings.</param>
        /// <param name="reseller">Reseller of Merchant.</param>
        /// <param name="shopName">Shop name.</param>
        /// <param name="shopUrl">Shop url (deprecated, use shop_urls instead).</param>
        /// <param name="shopUrls">Shop urls.</param>
        /// <param name="shopsystem">Shop system.</param>
        /// <param name="suspendedAt">Timestamp when merchant was suspended or null if it is not suspended.</param>
        /// <param name="timezone">Timezone.</param>
        /// <param name="type">Type of account.</param>
        public QuickPayProtocolV10Merchant(QuickPayProtocolV10AcquirerSettings acquirerSettings = default(QuickPayProtocolV10AcquirerSettings), bool? allowTestTransactions = default(bool?), bool? autofee = default(bool?), QuickPayProtocolV10Address billingAddress = default(QuickPayProtocolV10Address), string callbackUrl = default(string), string contactEmail = default(string), DateTime? createdAt = default(DateTime?), QuickPayProtocolV10Address customerAddress = default(QuickPayProtocolV10Address), Object defaultBrandingConfig = default(Object), int? defaultBrandingId = default(int?), string defaultPaymentLanguage = default(string), string defaultPaymentMethods = default(string), string defaultTextOnStatement = default(string), int? id = default(int?), QuickPayProtocolV10IntegrationSettings integrationSettings = default(QuickPayProtocolV10IntegrationSettings), string locale = default(string), DateTime? loggingStopsAt = default(DateTime?), QuickPayProtocolV10PciSettings pci = default(QuickPayProtocolV10PciSettings), QuickPayProtocolV10MerchantReseller reseller = default(QuickPayProtocolV10MerchantReseller), string shopName = default(string), string shopUrl = default(string), List<Object> shopUrls = default(List<Object>), string shopsystem = default(string), DateTime? suspendedAt = default(DateTime?), string timezone = default(string), string type = default(string))
        {
            this.AcquirerSettings = acquirerSettings;
            this.AllowTestTransactions = allowTestTransactions;
            this.Autofee = autofee;
            this.BillingAddress = billingAddress;
            this.CallbackUrl = callbackUrl;
            this.ContactEmail = contactEmail;
            this.CreatedAt = createdAt;
            this.CustomerAddress = customerAddress;
            this.DefaultBrandingConfig = defaultBrandingConfig;
            this.DefaultBrandingId = defaultBrandingId;
            this.DefaultPaymentLanguage = defaultPaymentLanguage;
            this.DefaultPaymentMethods = defaultPaymentMethods;
            this.DefaultTextOnStatement = defaultTextOnStatement;
            this.Id = id;
            this.IntegrationSettings = integrationSettings;
            this.Locale = locale;
            this.LoggingStopsAt = loggingStopsAt;
            this.Pci = pci;
            this.Reseller = reseller;
            this.ShopName = shopName;
            this.ShopUrl = shopUrl;
            this.ShopUrls = shopUrls;
            this.Shopsystem = shopsystem;
            this.SuspendedAt = suspendedAt;
            this.Timezone = timezone;
            this.Type = type;
        }
        
        /// <summary>
        /// Acquirer settings
        /// </summary>
        /// <value>Acquirer settings</value>
        [DataMember(Name="acquirer_settings", EmitDefaultValue=false)]
        public QuickPayProtocolV10AcquirerSettings AcquirerSettings { get; set; }

        /// <summary>
        /// Allow test transactions
        /// </summary>
        /// <value>Allow test transactions</value>
        [DataMember(Name="allow_test_transactions", EmitDefaultValue=false)]
        public bool? AllowTestTransactions { get; set; }

        /// <summary>
        /// Include acquirer fee on payments
        /// </summary>
        /// <value>Include acquirer fee on payments</value>
        [DataMember(Name="autofee", EmitDefaultValue=false)]
        public bool? Autofee { get; set; }

        /// <summary>
        /// Billing address
        /// </summary>
        /// <value>Billing address</value>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public QuickPayProtocolV10Address BillingAddress { get; set; }

        /// <summary>
        /// Callback url
        /// </summary>
        /// <value>Callback url</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Contact email
        /// </summary>
        /// <value>Contact email</value>
        [DataMember(Name="contact_email", EmitDefaultValue=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        /// <value>Timestamp of creation</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Customer address
        /// </summary>
        /// <value>Customer address</value>
        [DataMember(Name="customer_address", EmitDefaultValue=false)]
        public QuickPayProtocolV10Address CustomerAddress { get; set; }

        /// <summary>
        /// Default branding config
        /// </summary>
        /// <value>Default branding config</value>
        [DataMember(Name="default_branding_config", EmitDefaultValue=false)]
        public Object DefaultBrandingConfig { get; set; }

        /// <summary>
        /// Id of default branding, or null
        /// </summary>
        /// <value>Id of default branding, or null</value>
        [DataMember(Name="default_branding_id", EmitDefaultValue=false)]
        public int? DefaultBrandingId { get; set; }

        /// <summary>
        /// Default payment language (Two letter language code, ISO-639-1)
        /// </summary>
        /// <value>Default payment language (Two letter language code, ISO-639-1)</value>
        [DataMember(Name="default_payment_language", EmitDefaultValue=false)]
        public string DefaultPaymentLanguage { get; set; }

        /// <summary>
        /// Comma separated list of default payment methods
        /// </summary>
        /// <value>Comma separated list of default payment methods</value>
        [DataMember(Name="default_payment_methods", EmitDefaultValue=false)]
        public string DefaultPaymentMethods { get; set; }

        /// <summary>
        /// Text to be displayed on cardholder&#39;s statement. Currently supported by Clearhaus only
        /// </summary>
        /// <value>Text to be displayed on cardholder&#39;s statement. Currently supported by Clearhaus only</value>
        [DataMember(Name="default_text_on_statement", EmitDefaultValue=false)]
        public string DefaultTextOnStatement { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        /// <value>ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Integration settings
        /// </summary>
        /// <value>Integration settings</value>
        [DataMember(Name="integration_settings", EmitDefaultValue=false)]
        public QuickPayProtocolV10IntegrationSettings IntegrationSettings { get; set; }

        /// <summary>
        /// Locale
        /// </summary>
        /// <value>Locale</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Timestamp when logging is active 
        /// </summary>
        /// <value>Timestamp when logging is active </value>
        [DataMember(Name="logging_stops_at", EmitDefaultValue=false)]
        public DateTime? LoggingStopsAt { get; set; }

        /// <summary>
        /// PCI settings
        /// </summary>
        /// <value>PCI settings</value>
        [DataMember(Name="pci", EmitDefaultValue=false)]
        public QuickPayProtocolV10PciSettings Pci { get; set; }

        /// <summary>
        /// Reseller of Merchant
        /// </summary>
        /// <value>Reseller of Merchant</value>
        [DataMember(Name="reseller", EmitDefaultValue=false)]
        public QuickPayProtocolV10MerchantReseller Reseller { get; set; }

        /// <summary>
        /// Shop name
        /// </summary>
        /// <value>Shop name</value>
        [DataMember(Name="shop_name", EmitDefaultValue=false)]
        public string ShopName { get; set; }

        /// <summary>
        /// Shop url (deprecated, use shop_urls instead)
        /// </summary>
        /// <value>Shop url (deprecated, use shop_urls instead)</value>
        [DataMember(Name="shop_url", EmitDefaultValue=false)]
        public string ShopUrl { get; set; }

        /// <summary>
        /// Shop urls
        /// </summary>
        /// <value>Shop urls</value>
        [DataMember(Name="shop_urls", EmitDefaultValue=false)]
        public List<Object> ShopUrls { get; set; }

        /// <summary>
        /// Shop system
        /// </summary>
        /// <value>Shop system</value>
        [DataMember(Name="shopsystem", EmitDefaultValue=false)]
        public string Shopsystem { get; set; }

        /// <summary>
        /// Timestamp when merchant was suspended or null if it is not suspended
        /// </summary>
        /// <value>Timestamp when merchant was suspended or null if it is not suspended</value>
        [DataMember(Name="suspended_at", EmitDefaultValue=false)]
        public DateTime? SuspendedAt { get; set; }

        /// <summary>
        /// Timezone
        /// </summary>
        /// <value>Timezone</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Type of account
        /// </summary>
        /// <value>Type of account</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickPayProtocolV10Merchant {\n");
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuickPayProtocolV10Merchant);
        }

        /// <summary>
        /// Returns true if QuickPayProtocolV10Merchant instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickPayProtocolV10Merchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickPayProtocolV10Merchant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcquirerSettings == input.AcquirerSettings ||
                    (this.AcquirerSettings != null &&
                    this.AcquirerSettings.Equals(input.AcquirerSettings))
                ) && 
                (
                    this.AllowTestTransactions == input.AllowTestTransactions ||
                    (this.AllowTestTransactions != null &&
                    this.AllowTestTransactions.Equals(input.AllowTestTransactions))
                ) && 
                (
                    this.Autofee == input.Autofee ||
                    (this.Autofee != null &&
                    this.Autofee.Equals(input.Autofee))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CustomerAddress == input.CustomerAddress ||
                    (this.CustomerAddress != null &&
                    this.CustomerAddress.Equals(input.CustomerAddress))
                ) && 
                (
                    this.DefaultBrandingConfig == input.DefaultBrandingConfig ||
                    (this.DefaultBrandingConfig != null &&
                    this.DefaultBrandingConfig.Equals(input.DefaultBrandingConfig))
                ) && 
                (
                    this.DefaultBrandingId == input.DefaultBrandingId ||
                    (this.DefaultBrandingId != null &&
                    this.DefaultBrandingId.Equals(input.DefaultBrandingId))
                ) && 
                (
                    this.DefaultPaymentLanguage == input.DefaultPaymentLanguage ||
                    (this.DefaultPaymentLanguage != null &&
                    this.DefaultPaymentLanguage.Equals(input.DefaultPaymentLanguage))
                ) && 
                (
                    this.DefaultPaymentMethods == input.DefaultPaymentMethods ||
                    (this.DefaultPaymentMethods != null &&
                    this.DefaultPaymentMethods.Equals(input.DefaultPaymentMethods))
                ) && 
                (
                    this.DefaultTextOnStatement == input.DefaultTextOnStatement ||
                    (this.DefaultTextOnStatement != null &&
                    this.DefaultTextOnStatement.Equals(input.DefaultTextOnStatement))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IntegrationSettings == input.IntegrationSettings ||
                    (this.IntegrationSettings != null &&
                    this.IntegrationSettings.Equals(input.IntegrationSettings))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.LoggingStopsAt == input.LoggingStopsAt ||
                    (this.LoggingStopsAt != null &&
                    this.LoggingStopsAt.Equals(input.LoggingStopsAt))
                ) && 
                (
                    this.Pci == input.Pci ||
                    (this.Pci != null &&
                    this.Pci.Equals(input.Pci))
                ) && 
                (
                    this.Reseller == input.Reseller ||
                    (this.Reseller != null &&
                    this.Reseller.Equals(input.Reseller))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShopUrl == input.ShopUrl ||
                    (this.ShopUrl != null &&
                    this.ShopUrl.Equals(input.ShopUrl))
                ) && 
                (
                    this.ShopUrls == input.ShopUrls ||
                    this.ShopUrls != null &&
                    this.ShopUrls.SequenceEqual(input.ShopUrls)
                ) && 
                (
                    this.Shopsystem == input.Shopsystem ||
                    (this.Shopsystem != null &&
                    this.Shopsystem.Equals(input.Shopsystem))
                ) && 
                (
                    this.SuspendedAt == input.SuspendedAt ||
                    (this.SuspendedAt != null &&
                    this.SuspendedAt.Equals(input.SuspendedAt))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AcquirerSettings != null)
                    hashCode = hashCode * 59 + this.AcquirerSettings.GetHashCode();
                if (this.AllowTestTransactions != null)
                    hashCode = hashCode * 59 + this.AllowTestTransactions.GetHashCode();
                if (this.Autofee != null)
                    hashCode = hashCode * 59 + this.Autofee.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.ContactEmail != null)
                    hashCode = hashCode * 59 + this.ContactEmail.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CustomerAddress != null)
                    hashCode = hashCode * 59 + this.CustomerAddress.GetHashCode();
                if (this.DefaultBrandingConfig != null)
                    hashCode = hashCode * 59 + this.DefaultBrandingConfig.GetHashCode();
                if (this.DefaultBrandingId != null)
                    hashCode = hashCode * 59 + this.DefaultBrandingId.GetHashCode();
                if (this.DefaultPaymentLanguage != null)
                    hashCode = hashCode * 59 + this.DefaultPaymentLanguage.GetHashCode();
                if (this.DefaultPaymentMethods != null)
                    hashCode = hashCode * 59 + this.DefaultPaymentMethods.GetHashCode();
                if (this.DefaultTextOnStatement != null)
                    hashCode = hashCode * 59 + this.DefaultTextOnStatement.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IntegrationSettings != null)
                    hashCode = hashCode * 59 + this.IntegrationSettings.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.LoggingStopsAt != null)
                    hashCode = hashCode * 59 + this.LoggingStopsAt.GetHashCode();
                if (this.Pci != null)
                    hashCode = hashCode * 59 + this.Pci.GetHashCode();
                if (this.Reseller != null)
                    hashCode = hashCode * 59 + this.Reseller.GetHashCode();
                if (this.ShopName != null)
                    hashCode = hashCode * 59 + this.ShopName.GetHashCode();
                if (this.ShopUrl != null)
                    hashCode = hashCode * 59 + this.ShopUrl.GetHashCode();
                if (this.ShopUrls != null)
                    hashCode = hashCode * 59 + this.ShopUrls.GetHashCode();
                if (this.Shopsystem != null)
                    hashCode = hashCode * 59 + this.Shopsystem.GetHashCode();
                if (this.SuspendedAt != null)
                    hashCode = hashCode * 59 + this.SuspendedAt.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
