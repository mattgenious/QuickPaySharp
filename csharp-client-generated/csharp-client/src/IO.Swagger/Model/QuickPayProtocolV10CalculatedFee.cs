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
    /// QuickPayProtocolV10CalculatedFee
    /// </summary>
    [DataContract]
    public partial class QuickPayProtocolV10CalculatedFee :  IEquatable<QuickPayProtocolV10CalculatedFee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickPayProtocolV10CalculatedFee" /> class.
        /// </summary>
        /// <param name="acquirer">Acquirer.</param>
        /// <param name="amount">Amount that the fee is calculated from.</param>
        /// <param name="fee">The calculated fee in smallest unit.</param>
        /// <param name="formula">The formula.</param>
        /// <param name="paymentMethod">Payment method.</param>
        /// <param name="total">Amount + Fee.</param>
        public QuickPayProtocolV10CalculatedFee(string acquirer = default(string), int? amount = default(int?), int? fee = default(int?), string formula = default(string), string paymentMethod = default(string), int? total = default(int?))
        {
            this.Acquirer = acquirer;
            this.Amount = amount;
            this.Fee = fee;
            this.Formula = formula;
            this.PaymentMethod = paymentMethod;
            this.Total = total;
        }
        
        /// <summary>
        /// Acquirer
        /// </summary>
        /// <value>Acquirer</value>
        [DataMember(Name="acquirer", EmitDefaultValue=false)]
        public string Acquirer { get; set; }

        /// <summary>
        /// Amount that the fee is calculated from
        /// </summary>
        /// <value>Amount that the fee is calculated from</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// The calculated fee in smallest unit
        /// </summary>
        /// <value>The calculated fee in smallest unit</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public int? Fee { get; set; }

        /// <summary>
        /// The formula
        /// </summary>
        /// <value>The formula</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public string Formula { get; set; }

        /// <summary>
        /// Payment method
        /// </summary>
        /// <value>Payment method</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Amount + Fee
        /// </summary>
        /// <value>Amount + Fee</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickPayProtocolV10CalculatedFee {\n");
            sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as QuickPayProtocolV10CalculatedFee);
        }

        /// <summary>
        /// Returns true if QuickPayProtocolV10CalculatedFee instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickPayProtocolV10CalculatedFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickPayProtocolV10CalculatedFee input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Acquirer == input.Acquirer ||
                    (this.Acquirer != null &&
                    this.Acquirer.Equals(input.Acquirer))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Acquirer != null)
                    hashCode = hashCode * 59 + this.Acquirer.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
