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
using SwaggerDateConverter = QuickPaySharp.Client.SwaggerDateConverter;

namespace QuickPaySharp.Model
{
    /// <summary>
    /// AcquirerSettingsSwish
    /// </summary>
    [DataContract]
    public partial class AcquirerSettingsSwish :  IEquatable<AcquirerSettingsSwish>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcquirerSettingsSwish" /> class.
        /// </summary>
        /// <param name="active">True if the acquirer is active.</param>
        /// <param name="cryptographyKeyId">Swish certificate and private-key cryptography key id.</param>
        /// <param name="merchantId">Swish merchant id.</param>
        public AcquirerSettingsSwish(bool? active = default(bool?), int? cryptographyKeyId = default(int?), string merchantId = default(string))
        {
            this.Active = active;
            this.CryptographyKeyId = cryptographyKeyId;
            this.MerchantId = merchantId;
        }
        
        /// <summary>
        /// True if the acquirer is active
        /// </summary>
        /// <value>True if the acquirer is active</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Swish certificate and private-key cryptography key id
        /// </summary>
        /// <value>Swish certificate and private-key cryptography key id</value>
        [DataMember(Name="cryptography_key_id", EmitDefaultValue=false)]
        public int? CryptographyKeyId { get; set; }

        /// <summary>
        /// Swish merchant id
        /// </summary>
        /// <value>Swish merchant id</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcquirerSettingsSwish {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CryptographyKeyId: ").Append(CryptographyKeyId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
            return this.Equals(input as AcquirerSettingsSwish);
        }

        /// <summary>
        /// Returns true if AcquirerSettingsSwish instances are equal
        /// </summary>
        /// <param name="input">Instance of AcquirerSettingsSwish to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcquirerSettingsSwish input)
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
                    this.CryptographyKeyId == input.CryptographyKeyId ||
                    (this.CryptographyKeyId != null &&
                    this.CryptographyKeyId.Equals(input.CryptographyKeyId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
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
                if (this.CryptographyKeyId != null)
                    hashCode = hashCode * 59 + this.CryptographyKeyId.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
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