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
    /// AcquirerSettingsResurs
    /// </summary>
    [DataContract]
    public partial class AcquirerSettingsResurs :  IEquatable<AcquirerSettingsResurs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcquirerSettingsResurs" /> class.
        /// </summary>
        /// <param name="active">True if the acquirer is active.</param>
        /// <param name="customerId">Resurs user_name.</param>
        /// <param name="customerPassword">Resurs password.</param>
        public AcquirerSettingsResurs(bool? active = default(bool?), string customerId = default(string), string customerPassword = default(string))
        {
            this.Active = active;
            this.CustomerId = customerId;
            this.CustomerPassword = customerPassword;
        }
        
        /// <summary>
        /// True if the acquirer is active
        /// </summary>
        /// <value>True if the acquirer is active</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Resurs user_name
        /// </summary>
        /// <value>Resurs user_name</value>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Resurs password
        /// </summary>
        /// <value>Resurs password</value>
        [DataMember(Name="customer_password", EmitDefaultValue=false)]
        public string CustomerPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcquirerSettingsResurs {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerPassword: ").Append(CustomerPassword).Append("\n");
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
            return this.Equals(input as AcquirerSettingsResurs);
        }

        /// <summary>
        /// Returns true if AcquirerSettingsResurs instances are equal
        /// </summary>
        /// <param name="input">Instance of AcquirerSettingsResurs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcquirerSettingsResurs input)
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
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.CustomerPassword == input.CustomerPassword ||
                    (this.CustomerPassword != null &&
                    this.CustomerPassword.Equals(input.CustomerPassword))
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
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.CustomerPassword != null)
                    hashCode = hashCode * 59 + this.CustomerPassword.GetHashCode();
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
