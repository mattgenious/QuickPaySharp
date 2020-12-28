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
  public class AcquirerSettingsMobilePaySubscriptions {
    /// <summary>
    /// True if the acquirer is active
    /// </summary>
    /// <value>True if the acquirer is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Identifier MobilePay Subscriptions uses to link requests to callbacks
    /// </summary>
    /// <value>Identifier MobilePay Subscriptions uses to link requests to callbacks</value>
    [DataMember(Name="auth_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auth_state")]
    public string AuthState { get; set; }

    /// <summary>
    /// Verifies received code challenge
    /// </summary>
    /// <value>Verifies received code challenge</value>
    [DataMember(Name="code_verifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code_verifier")]
    public string CodeVerifier { get; set; }

    /// <summary>
    /// Unix-timestamp of last time token was refreshed
    /// </summary>
    /// <value>Unix-timestamp of last time token was refreshed</value>
    [DataMember(Name="last_token_refresh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_token_refresh")]
    public int? LastTokenRefresh { get; set; }

    /// <summary>
    /// Associate client sessions with ID Tokens to mitigate replay attacks
    /// </summary>
    /// <value>Associate client sessions with ID Tokens to mitigate replay attacks</value>
    [DataMember(Name="nonce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonce")]
    public string Nonce { get; set; }

    /// <summary>
    /// 0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed
    /// </summary>
    /// <value>0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed</value>
    [DataMember(Name="pending_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending_status")]
    public int? PendingStatus { get; set; }

    /// <summary>
    /// The MobilePay Subscriptions provider / sales-place chosen by the merchant
    /// </summary>
    /// <value>The MobilePay Subscriptions provider / sales-place chosen by the merchant</value>
    [DataMember(Name="provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provider")]
    public Object Provider { get; set; }

    /// <summary>
    /// Token to refresh access token for up to 1 year
    /// </summary>
    /// <value>Token to refresh access token for up to 1 year</value>
    [DataMember(Name="refresh_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refresh_token")]
    public string RefreshToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AcquirerSettingsMobilePaySubscriptions {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  AuthState: ").Append(AuthState).Append("\n");
      sb.Append("  CodeVerifier: ").Append(CodeVerifier).Append("\n");
      sb.Append("  LastTokenRefresh: ").Append(LastTokenRefresh).Append("\n");
      sb.Append("  Nonce: ").Append(Nonce).Append("\n");
      sb.Append("  PendingStatus: ").Append(PendingStatus).Append("\n");
      sb.Append("  Provider: ").Append(Provider).Append("\n");
      sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
