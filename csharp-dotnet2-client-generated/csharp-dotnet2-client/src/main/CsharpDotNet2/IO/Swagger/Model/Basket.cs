using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Basket {
    /// <summary>
    /// Item name
    /// </summary>
    /// <value>Item name</value>
    [DataMember(Name="item_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_name")]
    public string ItemName { get; set; }

    /// <summary>
    /// Item number (SKU)
    /// </summary>
    /// <value>Item number (SKU)</value>
    [DataMember(Name="item_no", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_no")]
    public string ItemNo { get; set; }

    /// <summary>
    /// Item price
    /// </summary>
    /// <value>Item price</value>
    [DataMember(Name="item_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_price")]
    public int? ItemPrice { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    /// <value>Quantity</value>
    [DataMember(Name="qty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qty")]
    public int? Qty { get; set; }

    /// <summary>
    /// VAT rate
    /// </summary>
    /// <value>VAT rate</value>
    [DataMember(Name="vat_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vat_rate")]
    public float? VatRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Basket {\n");
      sb.Append("  ItemName: ").Append(ItemName).Append("\n");
      sb.Append("  ItemNo: ").Append(ItemNo).Append("\n");
      sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
      sb.Append("  Qty: ").Append(Qty).Append("\n");
      sb.Append("  VatRate: ").Append(VatRate).Append("\n");
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
