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
    /// Payment
    /// </summary>
    [DataContract]
    public partial class Payment :  IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// State of transaction
        /// </summary>
        /// <value>State of transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Initial for value: initial
            /// </summary>
            [EnumMember(Value = "initial")]
            Initial = 1,
            
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,
            
            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 3,
            
            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 4,
            
            /// <summary>
            /// Enum Processed for value: processed
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed = 5
        }

        /// <summary>
        /// State of transaction
        /// </summary>
        /// <value>State of transaction</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="accepted">Accepted by acquirer.</param>
        /// <param name="acquirer">Acquirer that processed the transaction.</param>
        /// <param name="balance">Balance.</param>
        /// <param name="basket">Order items.</param>
        /// <param name="brandingId">Branding id (required).</param>
        /// <param name="createdAt">Timestamp of creation.</param>
        /// <param name="currency">Currency.</param>
        /// <param name="deadlineAt">Authorize deadline.</param>
        /// <param name="facilitator">Facilitator that facilitated the transaction.</param>
        /// <param name="fee">Fee added to authorization amount (only relevant on auto-fee).</param>
        /// <param name="id">Id.</param>
        /// <param name="invoiceAddress">Invoice address set on payment creation.</param>
        /// <param name="link">PaymentLink.</param>
        /// <param name="merchantId">Merchant id.</param>
        /// <param name="metadata">Metadata.</param>
        /// <param name="operations">Operations.</param>
        /// <param name="orderId">Order number.</param>
        /// <param name="retentedAt">Timestamp of retention.</param>
        /// <param name="shipping">Shipping.</param>
        /// <param name="shippingAddress">Shipping address set on payment creation.</param>
        /// <param name="state">State of transaction.</param>
        /// <param name="subscriptionId">Parent subscription id (only recurring).</param>
        /// <param name="testMode">Test mode.</param>
        /// <param name="textOnStatement">Text on statement.</param>
        /// <param name="type">transaction type.</param>
        /// <param name="updatedAt">Timestamp of last updated.</param>
        /// <param name="variables">Custom variables (required).</param>
        public Payment(bool? accepted = default(bool?), string acquirer = default(string), int? balance = default(int?), Basket basket = default(Basket), int? brandingId = default(int?), DateTime? createdAt = default(DateTime?), string currency = default(string), DateTime? deadlineAt = default(DateTime?), string facilitator = default(string), int? fee = default(int?), int? id = default(int?), OptionalAddress invoiceAddress = default(OptionalAddress), PaymentLink link = default(PaymentLink), int? merchantId = default(int?), Metadata metadata = default(Metadata), List<Operation> operations = default(List<Operation>), string orderId = default(string), DateTime? retentedAt = default(DateTime?), Shipping shipping = default(Shipping), OptionalAddress shippingAddress = default(OptionalAddress), StateEnum? state = default(StateEnum?), int? subscriptionId = default(int?), bool? testMode = default(bool?), string textOnStatement = default(string), string type = default(string), DateTime? updatedAt = default(DateTime?), Dictionary<string, string> variables = default(Dictionary<string, string>))
        {
            // to ensure "brandingId" is required (not null)
            if (brandingId == null)
            {
                throw new InvalidDataException("brandingId is a required property for Payment and cannot be null");
            }
            else
            {
                this.BrandingId = brandingId;
            }
            // to ensure "variables" is required (not null)
            if (variables == null)
            {
                throw new InvalidDataException("variables is a required property for Payment and cannot be null");
            }
            else
            {
                this.Variables = variables;
            }
            this.Accepted = accepted;
            this.Acquirer = acquirer;
            this.Balance = balance;
            this.Basket = basket;
            this.CreatedAt = createdAt;
            this.Currency = currency;
            this.DeadlineAt = deadlineAt;
            this.Facilitator = facilitator;
            this.Fee = fee;
            this.Id = id;
            this.InvoiceAddress = invoiceAddress;
            this.Link = link;
            this.MerchantId = merchantId;
            this.Metadata = metadata;
            this.Operations = operations;
            this.OrderId = orderId;
            this.RetentedAt = retentedAt;
            this.Shipping = shipping;
            this.ShippingAddress = shippingAddress;
            this.State = state;
            this.SubscriptionId = subscriptionId;
            this.TestMode = testMode;
            this.TextOnStatement = textOnStatement;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Accepted by acquirer
        /// </summary>
        /// <value>Accepted by acquirer</value>
        [DataMember(Name="accepted", EmitDefaultValue=false)]
        public bool? Accepted { get; set; }

        /// <summary>
        /// Acquirer that processed the transaction
        /// </summary>
        /// <value>Acquirer that processed the transaction</value>
        [DataMember(Name="acquirer", EmitDefaultValue=false)]
        public string Acquirer { get; set; }

        /// <summary>
        /// Balance
        /// </summary>
        /// <value>Balance</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public int? Balance { get; set; }

        /// <summary>
        /// Order items
        /// </summary>
        /// <value>Order items</value>
        [DataMember(Name="basket", EmitDefaultValue=false)]
        public Basket Basket { get; set; }

        /// <summary>
        /// Branding id
        /// </summary>
        /// <value>Branding id</value>
        [DataMember(Name="branding_id", EmitDefaultValue=false)]
        public int? BrandingId { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        /// <value>Timestamp of creation</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Authorize deadline
        /// </summary>
        /// <value>Authorize deadline</value>
        [DataMember(Name="deadline_at", EmitDefaultValue=false)]
        public DateTime? DeadlineAt { get; set; }

        /// <summary>
        /// Facilitator that facilitated the transaction
        /// </summary>
        /// <value>Facilitator that facilitated the transaction</value>
        [DataMember(Name="facilitator", EmitDefaultValue=false)]
        public string Facilitator { get; set; }

        /// <summary>
        /// Fee added to authorization amount (only relevant on auto-fee)
        /// </summary>
        /// <value>Fee added to authorization amount (only relevant on auto-fee)</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public int? Fee { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Invoice address set on payment creation
        /// </summary>
        /// <value>Invoice address set on payment creation</value>
        [DataMember(Name="invoice_address", EmitDefaultValue=false)]
        public OptionalAddress InvoiceAddress { get; set; }

        /// <summary>
        /// PaymentLink
        /// </summary>
        /// <value>PaymentLink</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public PaymentLink Link { get; set; }

        /// <summary>
        /// Merchant id
        /// </summary>
        /// <value>Merchant id</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public int? MerchantId { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        /// <value>Metadata</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Operations
        /// </summary>
        /// <value>Operations</value>
        [DataMember(Name="operations", EmitDefaultValue=false)]
        public List<Operation> Operations { get; set; }

        /// <summary>
        /// Order number
        /// </summary>
        /// <value>Order number</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Timestamp of retention
        /// </summary>
        /// <value>Timestamp of retention</value>
        [DataMember(Name="retented_at", EmitDefaultValue=false)]
        public DateTime? RetentedAt { get; set; }

        /// <summary>
        /// Shipping
        /// </summary>
        /// <value>Shipping</value>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// Shipping address set on payment creation
        /// </summary>
        /// <value>Shipping address set on payment creation</value>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public OptionalAddress ShippingAddress { get; set; }


        /// <summary>
        /// Parent subscription id (only recurring)
        /// </summary>
        /// <value>Parent subscription id (only recurring)</value>
        [DataMember(Name="subscription_id", EmitDefaultValue=false)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Test mode
        /// </summary>
        /// <value>Test mode</value>
        [DataMember(Name="test_mode", EmitDefaultValue=false)]
        public bool? TestMode { get; set; }

        /// <summary>
        /// Text on statement
        /// </summary>
        /// <value>Text on statement</value>
        [DataMember(Name="text_on_statement", EmitDefaultValue=false)]
        public string TextOnStatement { get; set; }

        /// <summary>
        /// transaction type
        /// </summary>
        /// <value>transaction type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Timestamp of last updated
        /// </summary>
        /// <value>Timestamp of last updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

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
            sb.Append("class Payment {\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Basket: ").Append(Basket).Append("\n");
            sb.Append("  BrandingId: ").Append(BrandingId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DeadlineAt: ").Append(DeadlineAt).Append("\n");
            sb.Append("  Facilitator: ").Append(Facilitator).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceAddress: ").Append(InvoiceAddress).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  RetentedAt: ").Append(RetentedAt).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
            sb.Append("  TextOnStatement: ").Append(TextOnStatement).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
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
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Basket == input.Basket ||
                    (this.Basket != null &&
                    this.Basket.Equals(input.Basket))
                ) && 
                (
                    this.BrandingId == input.BrandingId ||
                    (this.BrandingId != null &&
                    this.BrandingId.Equals(input.BrandingId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.DeadlineAt == input.DeadlineAt ||
                    (this.DeadlineAt != null &&
                    this.DeadlineAt.Equals(input.DeadlineAt))
                ) && 
                (
                    this.Facilitator == input.Facilitator ||
                    (this.Facilitator != null &&
                    this.Facilitator.Equals(input.Facilitator))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InvoiceAddress == input.InvoiceAddress ||
                    (this.InvoiceAddress != null &&
                    this.InvoiceAddress.Equals(input.InvoiceAddress))
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
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.RetentedAt == input.RetentedAt ||
                    (this.RetentedAt != null &&
                    this.RetentedAt.Equals(input.RetentedAt))
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.TestMode == input.TestMode ||
                    (this.TestMode != null &&
                    this.TestMode.Equals(input.TestMode))
                ) && 
                (
                    this.TextOnStatement == input.TextOnStatement ||
                    (this.TextOnStatement != null &&
                    this.TextOnStatement.Equals(input.TextOnStatement))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Basket != null)
                    hashCode = hashCode * 59 + this.Basket.GetHashCode();
                if (this.BrandingId != null)
                    hashCode = hashCode * 59 + this.BrandingId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DeadlineAt != null)
                    hashCode = hashCode * 59 + this.DeadlineAt.GetHashCode();
                if (this.Facilitator != null)
                    hashCode = hashCode * 59 + this.Facilitator.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InvoiceAddress != null)
                    hashCode = hashCode * 59 + this.InvoiceAddress.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.RetentedAt != null)
                    hashCode = hashCode * 59 + this.RetentedAt.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.TestMode != null)
                    hashCode = hashCode * 59 + this.TestMode.GetHashCode();
                if (this.TextOnStatement != null)
                    hashCode = hashCode * 59 + this.TextOnStatement.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
