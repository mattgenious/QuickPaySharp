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
    /// MerchantCryptographyKey
    /// </summary>
    [DataContract]
    public partial class MerchantCryptographyKey :  IEquatable<MerchantCryptographyKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCryptographyKey" /> class.
        /// </summary>
        /// <param name="certificateExpiresAt">Certificate expiration timestamp.</param>
        /// <param name="createdAt">Timestamp of creation.</param>
        /// <param name="id">KMS id.</param>
        /// <param name="publicKeyHash">Public Key identification hash.</param>
        /// <param name="shortDescription">Short description.</param>
        /// <param name="type">Key type (ec/rsa).</param>
        /// <param name="updatedAt">Timestamp of update.</param>
        public MerchantCryptographyKey(DateTime? certificateExpiresAt = default(DateTime?), DateTime? createdAt = default(DateTime?), int? id = default(int?), string publicKeyHash = default(string), string shortDescription = default(string), string type = default(string), DateTime? updatedAt = default(DateTime?))
        {
            this.CertificateExpiresAt = certificateExpiresAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.PublicKeyHash = publicKeyHash;
            this.ShortDescription = shortDescription;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Certificate expiration timestamp
        /// </summary>
        /// <value>Certificate expiration timestamp</value>
        [DataMember(Name="certificate_expires_at", EmitDefaultValue=false)]
        public DateTime? CertificateExpiresAt { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        /// <value>Timestamp of creation</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// KMS id
        /// </summary>
        /// <value>KMS id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Public Key identification hash
        /// </summary>
        /// <value>Public Key identification hash</value>
        [DataMember(Name="public_key_hash", EmitDefaultValue=false)]
        public string PublicKeyHash { get; set; }

        /// <summary>
        /// Short description
        /// </summary>
        /// <value>Short description</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Key type (ec/rsa)
        /// </summary>
        /// <value>Key type (ec/rsa)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Timestamp of update
        /// </summary>
        /// <value>Timestamp of update</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantCryptographyKey {\n");
            sb.Append("  CertificateExpiresAt: ").Append(CertificateExpiresAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PublicKeyHash: ").Append(PublicKeyHash).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as MerchantCryptographyKey);
        }

        /// <summary>
        /// Returns true if MerchantCryptographyKey instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantCryptographyKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantCryptographyKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificateExpiresAt == input.CertificateExpiresAt ||
                    (this.CertificateExpiresAt != null &&
                    this.CertificateExpiresAt.Equals(input.CertificateExpiresAt))
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
                    this.PublicKeyHash == input.PublicKeyHash ||
                    (this.PublicKeyHash != null &&
                    this.PublicKeyHash.Equals(input.PublicKeyHash))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
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
                if (this.CertificateExpiresAt != null)
                    hashCode = hashCode * 59 + this.CertificateExpiresAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PublicKeyHash != null)
                    hashCode = hashCode * 59 + this.PublicKeyHash.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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