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
    /// QuickPayProtocolV10PaymentLinkUrl
    /// </summary>
    [DataContract]
    public partial class QuickPayProtocolV10PaymentLinkUrl :  IEquatable<QuickPayProtocolV10PaymentLinkUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickPayProtocolV10PaymentLinkUrl" /> class.
        /// </summary>
        /// <param name="url">Url to payment window for this payment link.</param>
        public QuickPayProtocolV10PaymentLinkUrl(string url = default(string))
        {
            this.Url = url;
        }
        
        /// <summary>
        /// Url to payment window for this payment link
        /// </summary>
        /// <value>Url to payment window for this payment link</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickPayProtocolV10PaymentLinkUrl {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as QuickPayProtocolV10PaymentLinkUrl);
        }

        /// <summary>
        /// Returns true if QuickPayProtocolV10PaymentLinkUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickPayProtocolV10PaymentLinkUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickPayProtocolV10PaymentLinkUrl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
