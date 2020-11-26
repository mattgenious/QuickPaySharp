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
    /// QuickPayProtocolV10AcquirerSettingsSwedbank
    /// </summary>
    [DataContract]
    public partial class QuickPayProtocolV10AcquirerSettingsSwedbank :  IEquatable<QuickPayProtocolV10AcquirerSettingsSwedbank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickPayProtocolV10AcquirerSettingsSwedbank" /> class.
        /// </summary>
        /// <param name="active">True if the acquirer is active.</param>
        /// <param name="americanexpress">True if american express is enabled.</param>
        /// <param name="businessCode">Swedbank business code.</param>
        /// <param name="dinersclub">True if Diners Club is enabled.</param>
        /// <param name="identificationCode">Swedbank identification number.</param>
        /// <param name="identificationCodeInt">Swedbank international identification number.</param>
        /// <param name="mastercardBin">Swedbank Mastercard acquirer bin used for 3D Secure.</param>
        /// <param name="mastercardMpiMerchantId">Mastercard MPI Merchant id used for 3D Secure.</param>
        /// <param name="recurring">True if recurring is enabled.</param>
        /// <param name="securepay">True if Teller SecurePay fraud detection is enabled.</param>
        /// <param name="visaBin">Swedbank VISA acquirer bin used for 3D Secure.</param>
        /// <param name="visaMpiMerchantId">VISA MPI Merchant id used for 3D Secure.</param>
        public QuickPayProtocolV10AcquirerSettingsSwedbank(bool? active = default(bool?), bool? americanexpress = default(bool?), string businessCode = default(string), bool? dinersclub = default(bool?), string identificationCode = default(string), string identificationCodeInt = default(string), string mastercardBin = default(string), string mastercardMpiMerchantId = default(string), bool? recurring = default(bool?), bool? securepay = default(bool?), string visaBin = default(string), string visaMpiMerchantId = default(string))
        {
            this.Active = active;
            this.Americanexpress = americanexpress;
            this.BusinessCode = businessCode;
            this.Dinersclub = dinersclub;
            this.IdentificationCode = identificationCode;
            this.IdentificationCodeInt = identificationCodeInt;
            this.MastercardBin = mastercardBin;
            this.MastercardMpiMerchantId = mastercardMpiMerchantId;
            this.Recurring = recurring;
            this.Securepay = securepay;
            this.VisaBin = visaBin;
            this.VisaMpiMerchantId = visaMpiMerchantId;
        }
        
        /// <summary>
        /// True if the acquirer is active
        /// </summary>
        /// <value>True if the acquirer is active</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// True if american express is enabled
        /// </summary>
        /// <value>True if american express is enabled</value>
        [DataMember(Name="americanexpress", EmitDefaultValue=false)]
        public bool? Americanexpress { get; set; }

        /// <summary>
        /// Swedbank business code
        /// </summary>
        /// <value>Swedbank business code</value>
        [DataMember(Name="business_code", EmitDefaultValue=false)]
        public string BusinessCode { get; set; }

        /// <summary>
        /// True if Diners Club is enabled
        /// </summary>
        /// <value>True if Diners Club is enabled</value>
        [DataMember(Name="dinersclub", EmitDefaultValue=false)]
        public bool? Dinersclub { get; set; }

        /// <summary>
        /// Swedbank identification number
        /// </summary>
        /// <value>Swedbank identification number</value>
        [DataMember(Name="identification_code", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Swedbank international identification number
        /// </summary>
        /// <value>Swedbank international identification number</value>
        [DataMember(Name="identification_code_int", EmitDefaultValue=false)]
        public string IdentificationCodeInt { get; set; }

        /// <summary>
        /// Swedbank Mastercard acquirer bin used for 3D Secure
        /// </summary>
        /// <value>Swedbank Mastercard acquirer bin used for 3D Secure</value>
        [DataMember(Name="mastercard_bin", EmitDefaultValue=false)]
        public string MastercardBin { get; set; }

        /// <summary>
        /// Mastercard MPI Merchant id used for 3D Secure
        /// </summary>
        /// <value>Mastercard MPI Merchant id used for 3D Secure</value>
        [DataMember(Name="mastercard_mpi_merchant_id", EmitDefaultValue=false)]
        public string MastercardMpiMerchantId { get; set; }

        /// <summary>
        /// True if recurring is enabled
        /// </summary>
        /// <value>True if recurring is enabled</value>
        [DataMember(Name="recurring", EmitDefaultValue=false)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// True if Teller SecurePay fraud detection is enabled
        /// </summary>
        /// <value>True if Teller SecurePay fraud detection is enabled</value>
        [DataMember(Name="securepay", EmitDefaultValue=false)]
        public bool? Securepay { get; set; }

        /// <summary>
        /// Swedbank VISA acquirer bin used for 3D Secure
        /// </summary>
        /// <value>Swedbank VISA acquirer bin used for 3D Secure</value>
        [DataMember(Name="visa_bin", EmitDefaultValue=false)]
        public string VisaBin { get; set; }

        /// <summary>
        /// VISA MPI Merchant id used for 3D Secure
        /// </summary>
        /// <value>VISA MPI Merchant id used for 3D Secure</value>
        [DataMember(Name="visa_mpi_merchant_id", EmitDefaultValue=false)]
        public string VisaMpiMerchantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickPayProtocolV10AcquirerSettingsSwedbank {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Americanexpress: ").Append(Americanexpress).Append("\n");
            sb.Append("  BusinessCode: ").Append(BusinessCode).Append("\n");
            sb.Append("  Dinersclub: ").Append(Dinersclub).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
            sb.Append("  IdentificationCodeInt: ").Append(IdentificationCodeInt).Append("\n");
            sb.Append("  MastercardBin: ").Append(MastercardBin).Append("\n");
            sb.Append("  MastercardMpiMerchantId: ").Append(MastercardMpiMerchantId).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Securepay: ").Append(Securepay).Append("\n");
            sb.Append("  VisaBin: ").Append(VisaBin).Append("\n");
            sb.Append("  VisaMpiMerchantId: ").Append(VisaMpiMerchantId).Append("\n");
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
            return this.Equals(input as QuickPayProtocolV10AcquirerSettingsSwedbank);
        }

        /// <summary>
        /// Returns true if QuickPayProtocolV10AcquirerSettingsSwedbank instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickPayProtocolV10AcquirerSettingsSwedbank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickPayProtocolV10AcquirerSettingsSwedbank input)
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
                    this.Americanexpress == input.Americanexpress ||
                    (this.Americanexpress != null &&
                    this.Americanexpress.Equals(input.Americanexpress))
                ) && 
                (
                    this.BusinessCode == input.BusinessCode ||
                    (this.BusinessCode != null &&
                    this.BusinessCode.Equals(input.BusinessCode))
                ) && 
                (
                    this.Dinersclub == input.Dinersclub ||
                    (this.Dinersclub != null &&
                    this.Dinersclub.Equals(input.Dinersclub))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
                ) && 
                (
                    this.IdentificationCodeInt == input.IdentificationCodeInt ||
                    (this.IdentificationCodeInt != null &&
                    this.IdentificationCodeInt.Equals(input.IdentificationCodeInt))
                ) && 
                (
                    this.MastercardBin == input.MastercardBin ||
                    (this.MastercardBin != null &&
                    this.MastercardBin.Equals(input.MastercardBin))
                ) && 
                (
                    this.MastercardMpiMerchantId == input.MastercardMpiMerchantId ||
                    (this.MastercardMpiMerchantId != null &&
                    this.MastercardMpiMerchantId.Equals(input.MastercardMpiMerchantId))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.Securepay == input.Securepay ||
                    (this.Securepay != null &&
                    this.Securepay.Equals(input.Securepay))
                ) && 
                (
                    this.VisaBin == input.VisaBin ||
                    (this.VisaBin != null &&
                    this.VisaBin.Equals(input.VisaBin))
                ) && 
                (
                    this.VisaMpiMerchantId == input.VisaMpiMerchantId ||
                    (this.VisaMpiMerchantId != null &&
                    this.VisaMpiMerchantId.Equals(input.VisaMpiMerchantId))
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
                if (this.Americanexpress != null)
                    hashCode = hashCode * 59 + this.Americanexpress.GetHashCode();
                if (this.BusinessCode != null)
                    hashCode = hashCode * 59 + this.BusinessCode.GetHashCode();
                if (this.Dinersclub != null)
                    hashCode = hashCode * 59 + this.Dinersclub.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
                if (this.IdentificationCodeInt != null)
                    hashCode = hashCode * 59 + this.IdentificationCodeInt.GetHashCode();
                if (this.MastercardBin != null)
                    hashCode = hashCode * 59 + this.MastercardBin.GetHashCode();
                if (this.MastercardMpiMerchantId != null)
                    hashCode = hashCode * 59 + this.MastercardMpiMerchantId.GetHashCode();
                if (this.Recurring != null)
                    hashCode = hashCode * 59 + this.Recurring.GetHashCode();
                if (this.Securepay != null)
                    hashCode = hashCode * 59 + this.Securepay.GetHashCode();
                if (this.VisaBin != null)
                    hashCode = hashCode * 59 + this.VisaBin.GetHashCode();
                if (this.VisaMpiMerchantId != null)
                    hashCode = hashCode * 59 + this.VisaMpiMerchantId.GetHashCode();
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
