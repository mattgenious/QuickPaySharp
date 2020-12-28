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
    /// AcquirerSettingsKlarna
    /// </summary>
    [DataContract]
    public partial class AcquirerSettingsKlarna :  IEquatable<AcquirerSettingsKlarna>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcquirerSettingsKlarna" /> class.
        /// </summary>
        /// <param name="active">True if the acquirer is active.</param>
        /// <param name="eid">Klarna merchant id.</param>
        /// <param name="sharedSecret">Klarna shared secret.</param>
        public AcquirerSettingsKlarna(bool? active = default(bool?), int? eid = default(int?), string sharedSecret = default(string))
        {
            this.Active = active;
            this.Eid = eid;
            this.SharedSecret = sharedSecret;
        }
        
        /// <summary>
        /// True if the acquirer is active
        /// </summary>
        /// <value>True if the acquirer is active</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Klarna merchant id
        /// </summary>
        /// <value>Klarna merchant id</value>
        [DataMember(Name="eid", EmitDefaultValue=false)]
        public int? Eid { get; set; }

        /// <summary>
        /// Klarna shared secret
        /// </summary>
        /// <value>Klarna shared secret</value>
        [DataMember(Name="shared_secret", EmitDefaultValue=false)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcquirerSettingsKlarna {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Eid: ").Append(Eid).Append("\n");
            sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
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
            return this.Equals(input as AcquirerSettingsKlarna);
        }

        /// <summary>
        /// Returns true if AcquirerSettingsKlarna instances are equal
        /// </summary>
        /// <param name="input">Instance of AcquirerSettingsKlarna to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcquirerSettingsKlarna input)
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
                    this.Eid == input.Eid ||
                    (this.Eid != null &&
                    this.Eid.Equals(input.Eid))
                ) && 
                (
                    this.SharedSecret == input.SharedSecret ||
                    (this.SharedSecret != null &&
                    this.SharedSecret.Equals(input.SharedSecret))
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
                if (this.Eid != null)
                    hashCode = hashCode * 59 + this.Eid.GetHashCode();
                if (this.SharedSecret != null)
                    hashCode = hashCode * 59 + this.SharedSecret.GetHashCode();
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
