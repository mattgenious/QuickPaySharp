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
  public class Operation {
    /// <summary>
    /// 3D Secure status
    /// </summary>
    /// <value>3D Secure status</value>
    [DataMember(Name="3d_secure_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "3d_secure_status")]
    public string _3dSecureStatus { get; set; }

    /// <summary>
    /// Acquirer that processed this operation
    /// </summary>
    /// <value>Acquirer that processed this operation</value>
    [DataMember(Name="acquirer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquirer")]
    public string Acquirer { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    /// <value>Amount</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// Acquirer status code
    /// </summary>
    /// <value>Acquirer status code</value>
    [DataMember(Name="aq_status_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aq_status_code")]
    public string AqStatusCode { get; set; }

    /// <summary>
    /// Acquirer status message
    /// </summary>
    /// <value>Acquirer status message</value>
    [DataMember(Name="aq_status_msg", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aq_status_msg")]
    public string AqStatusMsg { get; set; }

    /// <summary>
    /// Timestamp of callback
    /// </summary>
    /// <value>Timestamp of callback</value>
    [DataMember(Name="callback_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback_at")]
    public DateTime? CallbackAt { get; set; }

    /// <summary>
    /// Callback duration (ms)
    /// </summary>
    /// <value>Callback duration (ms)</value>
    [DataMember(Name="callback_duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback_duration")]
    public int? CallbackDuration { get; set; }

    /// <summary>
    /// The http response code from the callback operation
    /// </summary>
    /// <value>The http response code from the callback operation</value>
    [DataMember(Name="callback_response_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback_response_code")]
    public bool? CallbackResponseCode { get; set; }

    /// <summary>
    /// Did the callback succeed
    /// </summary>
    /// <value>Did the callback succeed</value>
    [DataMember(Name="callback_success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback_success")]
    public bool? CallbackSuccess { get; set; }

    /// <summary>
    /// Operation callback url
    /// </summary>
    /// <value>Operation callback url</value>
    [DataMember(Name="callback_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback_url")]
    public string CallbackUrl { get; set; }

    /// <summary>
    /// Timestamp of creation
    /// </summary>
    /// <value>Timestamp of creation</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Acquirer specific data
    /// </summary>
    /// <value>Acquirer specific data</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Dictionary<string, string> Data { get; set; }

    /// <summary>
    /// Operation ID
    /// </summary>
    /// <value>Operation ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// If the operation is pending
    /// </summary>
    /// <value>If the operation is pending</value>
    [DataMember(Name="pending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending")]
    public bool? Pending { get; set; }

    /// <summary>
    /// QuickPay status code
    /// </summary>
    /// <value>QuickPay status code</value>
    [DataMember(Name="qp_status_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qp_status_code")]
    public string QpStatusCode { get; set; }

    /// <summary>
    /// QuickPay status message
    /// </summary>
    /// <value>QuickPay status message</value>
    [DataMember(Name="qp_status_msg", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qp_status_msg")]
    public string QpStatusMsg { get; set; }

    /// <summary>
    /// Type of operation
    /// </summary>
    /// <value>Type of operation</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Operation {\n");
      sb.Append("  _3dSecureStatus: ").Append(_3dSecureStatus).Append("\n");
      sb.Append("  Acquirer: ").Append(Acquirer).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  AqStatusCode: ").Append(AqStatusCode).Append("\n");
      sb.Append("  AqStatusMsg: ").Append(AqStatusMsg).Append("\n");
      sb.Append("  CallbackAt: ").Append(CallbackAt).Append("\n");
      sb.Append("  CallbackDuration: ").Append(CallbackDuration).Append("\n");
      sb.Append("  CallbackResponseCode: ").Append(CallbackResponseCode).Append("\n");
      sb.Append("  CallbackSuccess: ").Append(CallbackSuccess).Append("\n");
      sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Pending: ").Append(Pending).Append("\n");
      sb.Append("  QpStatusCode: ").Append(QpStatusCode).Append("\n");
      sb.Append("  QpStatusMsg: ").Append(QpStatusMsg).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
