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
    /// Shipping
    /// </summary>
    [DataContract]
    public partial class Shipping :  IEquatable<Shipping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipping" /> class.
        /// </summary>
        /// <param name="amount">Delivery price.</param>
        /// <param name="company">Delivery company.</param>
        /// <param name="method">Delivery method.</param>
        /// <param name="trackingNumber">Tracking number.</param>
        /// <param name="trackingUrl">Link to delivery status page.</param>
        /// <param name="vatRate">Delivery VAT rate.</param>
        public Shipping(int? amount = default(int?), string company = default(string), string method = default(string), string trackingNumber = default(string), string trackingUrl = default(string), float? vatRate = default(float?))
        {
            this.Amount = amount;
            this.Company = company;
            this.Method = method;
            this.TrackingNumber = trackingNumber;
            this.TrackingUrl = trackingUrl;
            this.VatRate = vatRate;
        }
        
        /// <summary>
        /// Delivery price
        /// </summary>
        /// <value>Delivery price</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// Delivery company
        /// </summary>
        /// <value>Delivery company</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Delivery method
        /// </summary>
        /// <value>Delivery method</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Tracking number
        /// </summary>
        /// <value>Tracking number</value>
        [DataMember(Name="tracking_number", EmitDefaultValue=false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Link to delivery status page
        /// </summary>
        /// <value>Link to delivery status page</value>
        [DataMember(Name="tracking_url", EmitDefaultValue=false)]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Delivery VAT rate
        /// </summary>
        /// <value>Delivery VAT rate</value>
        [DataMember(Name="vat_rate", EmitDefaultValue=false)]
        public float? VatRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shipping {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  VatRate: ").Append(VatRate).Append("\n");
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
            return this.Equals(input as Shipping);
        }

        /// <summary>
        /// Returns true if Shipping instances are equal
        /// </summary>
        /// <param name="input">Instance of Shipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shipping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.TrackingNumber == input.TrackingNumber ||
                    (this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(input.TrackingNumber))
                ) && 
                (
                    this.TrackingUrl == input.TrackingUrl ||
                    (this.TrackingUrl != null &&
                    this.TrackingUrl.Equals(input.TrackingUrl))
                ) && 
                (
                    this.VatRate == input.VatRate ||
                    (this.VatRate != null &&
                    this.VatRate.Equals(input.VatRate))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.TrackingNumber != null)
                    hashCode = hashCode * 59 + this.TrackingNumber.GetHashCode();
                if (this.TrackingUrl != null)
                    hashCode = hashCode * 59 + this.TrackingUrl.GetHashCode();
                if (this.VatRate != null)
                    hashCode = hashCode * 59 + this.VatRate.GetHashCode();
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
