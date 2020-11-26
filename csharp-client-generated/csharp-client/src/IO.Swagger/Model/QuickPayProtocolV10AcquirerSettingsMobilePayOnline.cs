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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// QuickPayProtocolV10AcquirerSettingsMobilePayOnline
    /// </summary>
    [DataContract]
    public partial class QuickPayProtocolV10AcquirerSettingsMobilePayOnline :  IEquatable<QuickPayProtocolV10AcquirerSettingsMobilePayOnline>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickPayProtocolV10AcquirerSettingsMobilePayOnline" /> class.
        /// </summary>
        /// <param name="active">True if the acquirer is active.</param>
        /// <param name="deliveryLimitedTo">MobilePayOnline delivery address selection countries limited to.</param>
        /// <param name="merchantId">Id of the merchant.</param>
        public QuickPayProtocolV10AcquirerSettingsMobilePayOnline(bool? active = default(bool?), string deliveryLimitedTo = default(string), int? merchantId = default(int?))
        {
            this.Active = active;
            this.DeliveryLimitedTo = deliveryLimitedTo;
            this.MerchantId = merchantId;
        }
        
        /// <summary>
        /// True if the acquirer is active
        /// </summary>
        /// <value>True if the acquirer is active</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// MobilePayOnline delivery address selection countries limited to
        /// </summary>
        /// <value>MobilePayOnline delivery address selection countries limited to</value>
        [DataMember(Name="delivery_limited_to", EmitDefaultValue=false)]
        public string DeliveryLimitedTo { get; set; }

        /// <summary>
        /// Id of the merchant
        /// </summary>
        /// <value>Id of the merchant</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public int? MerchantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickPayProtocolV10AcquirerSettingsMobilePayOnline {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DeliveryLimitedTo: ").Append(DeliveryLimitedTo).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
            return this.Equals(input as QuickPayProtocolV10AcquirerSettingsMobilePayOnline);
        }

        /// <summary>
        /// Returns true if QuickPayProtocolV10AcquirerSettingsMobilePayOnline instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickPayProtocolV10AcquirerSettingsMobilePayOnline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickPayProtocolV10AcquirerSettingsMobilePayOnline input)
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
                    this.DeliveryLimitedTo == input.DeliveryLimitedTo ||
                    (this.DeliveryLimitedTo != null &&
                    this.DeliveryLimitedTo.Equals(input.DeliveryLimitedTo))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
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
                if (this.DeliveryLimitedTo != null)
                    hashCode = hashCode * 59 + this.DeliveryLimitedTo.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
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
