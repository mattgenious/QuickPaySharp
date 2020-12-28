/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  Authorization is done using basic-auth. Authorization can be done with a user or an agreement.  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
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
    /// IntegrationSettingsEconomic
    /// </summary>
    [DataContract]
    public partial class IntegrationSettingsEconomic :  IEquatable<IntegrationSettingsEconomic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationSettingsEconomic" /> class.
        /// </summary>
        /// <param name="active">True if the settings are active.</param>
        /// <param name="agreement">e-conomic agreement id.</param>
        /// <param name="agreementToken">e-conomic agreement grant token.</param>
        public IntegrationSettingsEconomic(bool? active = default(bool?), string agreement = default(string), string agreementToken = default(string))
        {
            this.Active = active;
            this.Agreement = agreement;
            this.AgreementToken = agreementToken;
        }
        
        /// <summary>
        /// True if the settings are active
        /// </summary>
        /// <value>True if the settings are active</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// e-conomic agreement id
        /// </summary>
        /// <value>e-conomic agreement id</value>
        [DataMember(Name="agreement", EmitDefaultValue=false)]
        public string Agreement { get; set; }

        /// <summary>
        /// e-conomic agreement grant token
        /// </summary>
        /// <value>e-conomic agreement grant token</value>
        [DataMember(Name="agreement_token", EmitDefaultValue=false)]
        public string AgreementToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationSettingsEconomic {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Agreement: ").Append(Agreement).Append("\n");
            sb.Append("  AgreementToken: ").Append(AgreementToken).Append("\n");
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
            return this.Equals(input as IntegrationSettingsEconomic);
        }

        /// <summary>
        /// Returns true if IntegrationSettingsEconomic instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationSettingsEconomic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationSettingsEconomic input)
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
                    this.Agreement == input.Agreement ||
                    (this.Agreement != null &&
                    this.Agreement.Equals(input.Agreement))
                ) && 
                (
                    this.AgreementToken == input.AgreementToken ||
                    (this.AgreementToken != null &&
                    this.AgreementToken.Equals(input.AgreementToken))
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
                if (this.Agreement != null)
                    hashCode = hashCode * 59 + this.Agreement.GetHashCode();
                if (this.AgreementToken != null)
                    hashCode = hashCode * 59 + this.AgreementToken.GetHashCode();
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
