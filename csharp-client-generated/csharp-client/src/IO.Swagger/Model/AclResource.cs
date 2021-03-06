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
    /// AclResource
    /// </summary>
    [DataContract]
    public partial class AclResource :  IEquatable<AclResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AclResource" /> class.
        /// </summary>
        /// <param name="accountType">Account type that this resource applies to.</param>
        /// <param name="actions">The valid http verbs for this resource.</param>
        /// <param name="description">Description of the resource.</param>
        /// <param name="resource">Path to the resource.</param>
        public AclResource(string accountType = default(string), List<string> actions = default(List<string>), string description = default(string), string resource = default(string))
        {
            this.AccountType = accountType;
            this.Actions = actions;
            this.Description = description;
            this.Resource = resource;
        }
        
        /// <summary>
        /// Account type that this resource applies to
        /// </summary>
        /// <value>Account type that this resource applies to</value>
        [DataMember(Name="account_type", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The valid http verbs for this resource
        /// </summary>
        /// <value>The valid http verbs for this resource</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// Description of the resource
        /// </summary>
        /// <value>Description of the resource</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Path to the resource
        /// </summary>
        /// <value>Path to the resource</value>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AclResource {\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(input as AclResource);
        }

        /// <summary>
        /// Returns true if AclResource instances are equal
        /// </summary>
        /// <param name="input">Instance of AclResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AclResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
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
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
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
