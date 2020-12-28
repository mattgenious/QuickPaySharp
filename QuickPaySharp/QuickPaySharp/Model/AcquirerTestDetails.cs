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
    /// AcquirerTestDetails
    /// </summary>
    [DataContract]
    public partial class AcquirerTestDetails :  IEquatable<AcquirerTestDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcquirerTestDetails" /> class.
        /// </summary>
        /// <param name="_3dSecure">3d_secure test status.</param>
        /// <param name="dankort">dankort test status.</param>
        /// <param name="diners">diners test status.</param>
        /// <param name="fbg1886">fbg1886 test status.</param>
        /// <param name="mastercard">mastercard test status.</param>
        /// <param name="recurring">recurring test status.</param>
        /// <param name="visa">visa test status.</param>
        public AcquirerTestDetails(AcquirerTestResult _3dSecure = default(AcquirerTestResult), AcquirerTestResult dankort = default(AcquirerTestResult), AcquirerTestResult diners = default(AcquirerTestResult), AcquirerTestResult fbg1886 = default(AcquirerTestResult), AcquirerTestResult mastercard = default(AcquirerTestResult), AcquirerTestResult recurring = default(AcquirerTestResult), AcquirerTestResult visa = default(AcquirerTestResult))
        {
            this._3dSecure = _3dSecure;
            this.Dankort = dankort;
            this.Diners = diners;
            this.Fbg1886 = fbg1886;
            this.Mastercard = mastercard;
            this.Recurring = recurring;
            this.Visa = visa;
        }
        
        /// <summary>
        /// 3d_secure test status
        /// </summary>
        /// <value>3d_secure test status</value>
        [DataMember(Name="3d_secure", EmitDefaultValue=false)]
        public AcquirerTestResult _3dSecure { get; set; }

        /// <summary>
        /// dankort test status
        /// </summary>
        /// <value>dankort test status</value>
        [DataMember(Name="dankort", EmitDefaultValue=false)]
        public AcquirerTestResult Dankort { get; set; }

        /// <summary>
        /// diners test status
        /// </summary>
        /// <value>diners test status</value>
        [DataMember(Name="diners", EmitDefaultValue=false)]
        public AcquirerTestResult Diners { get; set; }

        /// <summary>
        /// fbg1886 test status
        /// </summary>
        /// <value>fbg1886 test status</value>
        [DataMember(Name="fbg1886", EmitDefaultValue=false)]
        public AcquirerTestResult Fbg1886 { get; set; }

        /// <summary>
        /// mastercard test status
        /// </summary>
        /// <value>mastercard test status</value>
        [DataMember(Name="mastercard", EmitDefaultValue=false)]
        public AcquirerTestResult Mastercard { get; set; }

        /// <summary>
        /// recurring test status
        /// </summary>
        /// <value>recurring test status</value>
        [DataMember(Name="recurring", EmitDefaultValue=false)]
        public AcquirerTestResult Recurring { get; set; }

        /// <summary>
        /// visa test status
        /// </summary>
        /// <value>visa test status</value>
        [DataMember(Name="visa", EmitDefaultValue=false)]
        public AcquirerTestResult Visa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcquirerTestDetails {\n");
            sb.Append("  _3dSecure: ").Append(_3dSecure).Append("\n");
            sb.Append("  Dankort: ").Append(Dankort).Append("\n");
            sb.Append("  Diners: ").Append(Diners).Append("\n");
            sb.Append("  Fbg1886: ").Append(Fbg1886).Append("\n");
            sb.Append("  Mastercard: ").Append(Mastercard).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Visa: ").Append(Visa).Append("\n");
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
            return this.Equals(input as AcquirerTestDetails);
        }

        /// <summary>
        /// Returns true if AcquirerTestDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AcquirerTestDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcquirerTestDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._3dSecure == input._3dSecure ||
                    (this._3dSecure != null &&
                    this._3dSecure.Equals(input._3dSecure))
                ) && 
                (
                    this.Dankort == input.Dankort ||
                    (this.Dankort != null &&
                    this.Dankort.Equals(input.Dankort))
                ) && 
                (
                    this.Diners == input.Diners ||
                    (this.Diners != null &&
                    this.Diners.Equals(input.Diners))
                ) && 
                (
                    this.Fbg1886 == input.Fbg1886 ||
                    (this.Fbg1886 != null &&
                    this.Fbg1886.Equals(input.Fbg1886))
                ) && 
                (
                    this.Mastercard == input.Mastercard ||
                    (this.Mastercard != null &&
                    this.Mastercard.Equals(input.Mastercard))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.Visa == input.Visa ||
                    (this.Visa != null &&
                    this.Visa.Equals(input.Visa))
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
                if (this._3dSecure != null)
                    hashCode = hashCode * 59 + this._3dSecure.GetHashCode();
                if (this.Dankort != null)
                    hashCode = hashCode * 59 + this.Dankort.GetHashCode();
                if (this.Diners != null)
                    hashCode = hashCode * 59 + this.Diners.GetHashCode();
                if (this.Fbg1886 != null)
                    hashCode = hashCode * 59 + this.Fbg1886.GetHashCode();
                if (this.Mastercard != null)
                    hashCode = hashCode * 59 + this.Mastercard.GetHashCode();
                if (this.Recurring != null)
                    hashCode = hashCode * 59 + this.Recurring.GetHashCode();
                if (this.Visa != null)
                    hashCode = hashCode * 59 + this.Visa.GetHashCode();
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