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
  public class QuickPayProtocolV10AcquirerSettingsSofort {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Sofort api-key
    /// </summary>
    /// <value>Sofort api-key</value>
    [DataMember(Name="api_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api_key")]
    public string ApiKey { get; set; }

    /// <summary>
    /// Sofort customer number
    /// </summary>
    /// <value>Sofort customer number</value>
    [DataMember(Name="customer_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_number")]
    public int? CustomerNumber { get; set; }

    /// <summary>
    /// Sofort gateway feature enabled
    /// </summary>
    /// <value>Sofort gateway feature enabled</value>
    [DataMember(Name="gateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gateway")]
    public bool? Gateway { get; set; }

    /// <summary>
    /// Sofort iDeal feature enabled
    /// </summary>
    /// <value>Sofort iDeal feature enabled</value>
    [DataMember(Name="ideal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ideal")]
    public bool? Ideal { get; set; }

    /// <summary>
    /// Sofort iDeal notification password
    /// </summary>
    /// <value>Sofort iDeal notification password</value>
    [DataMember(Name="ideal_notification_password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ideal_notification_password")]
    public string IdealNotificationPassword { get; set; }

    /// <summary>
    /// Sofort iDeal project id
    /// </summary>
    /// <value>Sofort iDeal project id</value>
    [DataMember(Name="ideal_project_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ideal_project_id")]
    public int? IdealProjectId { get; set; }

    /// <summary>
    /// Sofort iDeal project password
    /// </summary>
    /// <value>Sofort iDeal project password</value>
    [DataMember(Name="ideal_project_password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ideal_project_password")]
    public string IdealProjectPassword { get; set; }

    /// <summary>
    /// Sofort gateway project id
    /// </summary>
    /// <value>Sofort gateway project id</value>
    [DataMember(Name="project_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project_id")]
    public int? ProjectId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuickPayProtocolV10AcquirerSettingsSofort {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
      sb.Append("  Gateway: ").Append(Gateway).Append("\n");
      sb.Append("  Ideal: ").Append(Ideal).Append("\n");
      sb.Append("  IdealNotificationPassword: ").Append(IdealNotificationPassword).Append("\n");
      sb.Append("  IdealProjectId: ").Append(IdealProjectId).Append("\n");
      sb.Append("  IdealProjectPassword: ").Append(IdealProjectPassword).Append("\n");
      sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
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
