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
    /// QuickPayProtocolV10AcquirerSettingsPayPal
    /// </summary>
    [DataContract]
    public partial class QuickPayProtocolV10AcquirerSettingsPayPal :  IEquatable<QuickPayProtocolV10AcquirerSettingsPayPal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickPayProtocolV10AcquirerSettingsPayPal" /> class.
        /// </summary>
        /// <param name="active">True if the acquirer is active.</param>
        /// <param name="creditCard">True if credit-card payments is enabled.</param>
        /// <param name="recurring">True if recurring is enabled.</param>
        /// <param name="scope">Scopes token grants access to.</param>
        /// <param name="token">Authentication token.</param>
        /// <param name="tokenSecret">Authentication token secret.</param>
        public QuickPayProtocolV10AcquirerSettingsPayPal(bool? active = default(bool?), bool? creditCard = default(bool?), bool? recurring = default(bool?), List<string> scope = default(List<string>), string token = default(string), string tokenSecret = default(string))
        {
            this.Active = active;
            this.CreditCard = creditCard;
            this.Recurring = recurring;
            this.Scope = scope;
            this.Token = token;
            this.TokenSecret = tokenSecret;
        }
        
        /// <summary>
        /// True if the acquirer is active
        /// </summary>
        /// <value>True if the acquirer is active</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// True if credit-card payments is enabled
        /// </summary>
        /// <value>True if credit-card payments is enabled</value>
        [DataMember(Name="credit_card", EmitDefaultValue=false)]
        public bool? CreditCard { get; set; }

        /// <summary>
        /// True if recurring is enabled
        /// </summary>
        /// <value>True if recurring is enabled</value>
        [DataMember(Name="recurring", EmitDefaultValue=false)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// Scopes token grants access to
        /// </summary>
        /// <value>Scopes token grants access to</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public List<string> Scope { get; set; }

        /// <summary>
        /// Authentication token
        /// </summary>
        /// <value>Authentication token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Authentication token secret
        /// </summary>
        /// <value>Authentication token secret</value>
        [DataMember(Name="token_secret", EmitDefaultValue=false)]
        public string TokenSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickPayProtocolV10AcquirerSettingsPayPal {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenSecret: ").Append(TokenSecret).Append("\n");
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
            return this.Equals(input as QuickPayProtocolV10AcquirerSettingsPayPal);
        }

        /// <summary>
        /// Returns true if QuickPayProtocolV10AcquirerSettingsPayPal instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickPayProtocolV10AcquirerSettingsPayPal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickPayProtocolV10AcquirerSettingsPayPal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.CreditCard == input.CreditCard ||
                    (this.CreditCard != null &&
                    this.CreditCard.Equals(input.CreditCard))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope != null &&
                    this.Scope.SequenceEqual(input.Scope)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokenSecret == input.TokenSecret ||
                    (this.TokenSecret != null &&
                    this.TokenSecret.Equals(input.TokenSecret))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CreditCard != null)
                    hashCode = hashCode * 59 + this.CreditCard.GetHashCode();
                if (this.Recurring != null)
                    hashCode = hashCode * 59 + this.Recurring.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenSecret != null)
                    hashCode = hashCode * 59 + this.TokenSecret.GetHashCode();
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
