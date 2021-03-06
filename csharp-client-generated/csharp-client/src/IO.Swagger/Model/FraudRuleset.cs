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
    /// FraudRuleset
    /// </summary>
    [DataContract]
    public partial class FraudRuleset :  IEquatable<FraudRuleset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudRuleset" /> class.
        /// </summary>
        /// <param name="action">The action that happens if this ruleset is triggered (nothing, flag, force_3d or block).</param>
        /// <param name="combinator">The method used to combine filter rules (and, or).</param>
        /// <param name="filterRules">The rules of the ruleset.</param>
        /// <param name="id">Unique id.</param>
        /// <param name="merchantId">Owner of the ruleset.</param>
        /// <param name="name">Descriptive name.</param>
        public FraudRuleset(string action = default(string), string combinator = default(string), List<FraudFilterRule> filterRules = default(List<FraudFilterRule>), int? id = default(int?), int? merchantId = default(int?), string name = default(string))
        {
            this.Action = action;
            this.Combinator = combinator;
            this.FilterRules = filterRules;
            this.Id = id;
            this.MerchantId = merchantId;
            this.Name = name;
        }
        
        /// <summary>
        /// The action that happens if this ruleset is triggered (nothing, flag, force_3d or block)
        /// </summary>
        /// <value>The action that happens if this ruleset is triggered (nothing, flag, force_3d or block)</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// The method used to combine filter rules (and, or)
        /// </summary>
        /// <value>The method used to combine filter rules (and, or)</value>
        [DataMember(Name="combinator", EmitDefaultValue=false)]
        public string Combinator { get; set; }

        /// <summary>
        /// The rules of the ruleset
        /// </summary>
        /// <value>The rules of the ruleset</value>
        [DataMember(Name="filter_rules", EmitDefaultValue=false)]
        public List<FraudFilterRule> FilterRules { get; set; }

        /// <summary>
        /// Unique id
        /// </summary>
        /// <value>Unique id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Owner of the ruleset
        /// </summary>
        /// <value>Owner of the ruleset</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public int? MerchantId { get; set; }

        /// <summary>
        /// Descriptive name
        /// </summary>
        /// <value>Descriptive name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudRuleset {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Combinator: ").Append(Combinator).Append("\n");
            sb.Append("  FilterRules: ").Append(FilterRules).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as FraudRuleset);
        }

        /// <summary>
        /// Returns true if FraudRuleset instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudRuleset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudRuleset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Combinator == input.Combinator ||
                    (this.Combinator != null &&
                    this.Combinator.Equals(input.Combinator))
                ) && 
                (
                    this.FilterRules == input.FilterRules ||
                    this.FilterRules != null &&
                    this.FilterRules.SequenceEqual(input.FilterRules)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Combinator != null)
                    hashCode = hashCode * 59 + this.Combinator.GetHashCode();
                if (this.FilterRules != null)
                    hashCode = hashCode * 59 + this.FilterRules.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
