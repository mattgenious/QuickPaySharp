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
    /// Card
    /// </summary>
    [DataContract]
    public partial class Card :  IEquatable<Card>, IValidatableObject
    {
        /// <summary>
        /// Type of transaction
        /// </summary>
        /// <value>Type of transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")]
            Card = 1
        }

        /// <summary>
        /// Type of transaction
        /// </summary>
        /// <value>Type of transaction</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Card() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        /// <param name="accepted">Accepted by acquirer.</param>
        /// <param name="acquirer">Acquirer that processed the card.</param>
        /// <param name="createdAt">Timestamp of creation.</param>
        /// <param name="id">Card id.</param>
        /// <param name="link">Sharable link to payment window.</param>
        /// <param name="merchantId">Merchant id.</param>
        /// <param name="metadata">Card metadata.</param>
        /// <param name="operations">Operations.</param>
        /// <param name="testMode">Test mode.</param>
        /// <param name="type">Type of transaction.</param>
        /// <param name="variables">Custom variables (required).</param>
        public Card(bool? accepted = default(bool?), string acquirer = default(string), DateTime? createdAt = default(DateTime?), int? id = default(int?), CardLink link = default(CardLink), int? merchantId = default(int?), Metadata metadata = default(Metadata), List<CardOperation> operations = default(List<CardOperation>), bool? testMode = default(bool?), TypeEnum? type = default(TypeEnum?), Dictionary<string, string> variables = default(Dictionary<string, string>))
        {
            // to ensure "variables" is required (not null)
            if (variables == null)
            {
                throw new InvalidDataException("variables is a required property for Card and cannot be null");
            }
            else
            {
                this.Variables = variables;
            }
            this.Accepted = accepted;
            this.Acquirer = acquirer;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Link = link;
            this.MerchantId = merchantId;
            this.Metadata = metadata;
            this.Operations = operations;
            this.TestMode = testMode;
            this.Type = type;
        }
        
        /// <summary>
        /// Accepted by acquirer
        /// </summary>
        /// <value>Accepted by acquirer</value>
        [DataMember(Name="accepted", EmitDefaultValue=false)]
        public bool? Accepted { get; set; }

        /// <summary>
        /// Acquirer that processed the card
        /// </summary>
        /// <value>Acquirer that processed the card</value>
        [DataMember(Name="acquirer", EmitDefaultValue=false)]
        public string Acquirer { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        /// <value>Timestamp of creation</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Card id
        /// </summary>
        /// <value>Card id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Sharable link to payment window
        /// </summary>
        /// <value>Sharable link to payment window</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public CardLink Link { get; set; }

        /// <summary>
        /// Merchant id
        /// </summary>
        /// <value>Merchant id</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public int? MerchantId { get; set; }

        /// <summary>
        /// Card metadata
        /// </summary>
        /// <value>Card metadata</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Operations
        /// </summary>
        /// <value>Operations</value>
        [DataMember(Name="operations", EmitDefaultValue=false)]
        public List<CardOperation> Operations { get; set; }

        /// <summary>
        /// Test mode
        /// </summary>
        /// <value>Test mode</value>
        [DataMember(Name="test_mode", EmitDefaultValue=false)]
        public bool? TestMode { get; set; }


        /// <summary>
        /// Custom variables
        /// </summary>
        /// <value>Custom variables</value>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public Dictionary<string, string> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return this.Equals(input as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="input">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accepted == input.Accepted ||
                    (this.Accepted != null &&
                    this.Accepted.Equals(input.Accepted))
                ) && 
                (
                    this.Acquirer == input.Acquirer ||
                    (this.Acquirer != null &&
                    this.Acquirer.Equals(input.Acquirer))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
                ) && 
                (
                    this.TestMode == input.TestMode ||
                    (this.TestMode != null &&
                    this.TestMode.Equals(input.TestMode))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
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
                if (this.Accepted != null)
                    hashCode = hashCode * 59 + this.Accepted.GetHashCode();
                if (this.Acquirer != null)
                    hashCode = hashCode * 59 + this.Acquirer.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.TestMode != null)
                    hashCode = hashCode * 59 + this.TestMode.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
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
