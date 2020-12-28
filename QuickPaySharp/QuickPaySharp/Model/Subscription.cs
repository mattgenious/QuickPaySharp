using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace QuickPaySharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Subscription {
    /// <summary>
    /// Accepted by acquirer
    /// </summary>
    /// <value>Accepted by acquirer</value>
    [DataMember(Name="accepted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accepted")]
    public bool? Accepted { get; set; }

    /// <summary>
    /// Acquirer that processed the transaction
    /// </summary>
    /// <value>Acquirer that processed the transaction</value>
    [DataMember(Name="acquirer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirer")]
    public string Acquirer { get; set; }

    /// <summary>
    /// Order items
    /// </summary>
    /// <value>Order items</value>
    [DataMember(Name="basket", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basket")]
    public Basket Basket { get; set; }

    /// <summary>
    /// Branding id
    /// </summary>
    /// <value>Branding id</value>
    [DataMember(Name="branding_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branding_id")]
    public int? BrandingId { get; set; }

    /// <summary>
    /// Timestamp of creation
    /// </summary>
    /// <value>Timestamp of creation</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    /// <value>Currency</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Authorize deadline
    /// </summary>
    /// <value>Authorize deadline</value>
    [DataMember(Name="deadline_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deadline_at")]
    public DateTime? DeadlineAt { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    /// <value>Description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Facilitator that facilitated the transaction
    /// </summary>
    /// <value>Facilitator that facilitated the transaction</value>
    [DataMember(Name="facilitator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "facilitator")]
    public string Facilitator { get; set; }

    /// <summary>
    /// Ids of subscription groups
    /// </summary>
    /// <value>Ids of subscription groups</value>
    [DataMember(Name="group_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_ids")]
    public List<int?> GroupIds { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    /// <value>Id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Invoice address set on payment creation
    /// </summary>
    /// <value>Invoice address set on payment creation</value>
    [DataMember(Name="invoice_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_address")]
    public OptionalAddress InvoiceAddress { get; set; }

    /// <summary>
    /// PaymentLink
    /// </summary>
    /// <value>PaymentLink</value>
    [DataMember(Name="link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link")]
    public PaymentLink Link { get; set; }

    /// <summary>
    /// Merchant id
    /// </summary>
    /// <value>Merchant id</value>
    [DataMember(Name="merchant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant_id")]
    public int? MerchantId { get; set; }

    /// <summary>
    /// Metadata
    /// </summary>
    /// <value>Metadata</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public Metadata Metadata { get; set; }

    /// <summary>
    /// Operations
    /// </summary>
    /// <value>Operations</value>
    [DataMember(Name="operations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operations")]
    public List<Operation> Operations { get; set; }

    /// <summary>
    /// Order number
    /// </summary>
    /// <value>Order number</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public string OrderId { get; set; }

    /// <summary>
    /// Timestamp of retention
    /// </summary>
    /// <value>Timestamp of retention</value>
    [DataMember(Name="retented_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retented_at")]
    public DateTime? RetentedAt { get; set; }

    /// <summary>
    /// Shipping
    /// </summary>
    /// <value>Shipping</value>
    [DataMember(Name="shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping")]
    public Shipping Shipping { get; set; }

    /// <summary>
    /// Shipping address set on payment creation
    /// </summary>
    /// <value>Shipping address set on payment creation</value>
    [DataMember(Name="shipping_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_address")]
    public OptionalAddress ShippingAddress { get; set; }

    /// <summary>
    /// State of transaction
    /// </summary>
    /// <value>State of transaction</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Test mode
    /// </summary>
    /// <value>Test mode</value>
    [DataMember(Name="test_mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "test_mode")]
    public bool? TestMode { get; set; }

    /// <summary>
    /// Text on statement
    /// </summary>
    /// <value>Text on statement</value>
    [DataMember(Name="text_on_statement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_on_statement")]
    public string TextOnStatement { get; set; }

    /// <summary>
    /// transaction type
    /// </summary>
    /// <value>transaction type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Timestamp of last updated
    /// </summary>
    /// <value>Timestamp of last updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Custom variables
    /// </summary>
    /// <value>Custom variables</value>
    [DataMember(Name="variables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variables")]
    public Dictionary<string, string> Variables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Subscription {\n");
      sb.Append("  Accepted: ").Append(Accepted).Append("\n");
      sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
      sb.Append("  Basket: ").Append(Basket).Append("\n");
      sb.Append("  BrandingId: ").Append(BrandingId).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  DeadlineAt: ").Append(DeadlineAt).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Facilitator: ").Append(Facilitator).Append("\n");
      sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
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
      sb.Append("  TestMode: ").Append(TestMode).Append("\n");
      sb.Append("  TextOnStatement: ").Append(TextOnStatement).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Variables: ").Append(Variables).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
