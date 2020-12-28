/* 
 * Quickpay API v10
 *
 * <h2 id=\"authorization\">Authorization</h2>  Authorization is done using basic-auth. Authorization can be done with a user or an agreement.  <ul>   <li>When authorized with a user one is able to edit own settings, create new merchant or request access to existing merchant.</li>   <li>When authorized with an agreement one is able to perform anything on the account that agreement gives permissions to.</li> </ul>  
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
    /// Agreement
    /// </summary>
    [DataContract]
    public partial class Agreement :  IEquatable<Agreement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Agreement" /> class.
        /// </summary>
        /// <param name="accepted">Is agreement accepted by user.</param>
        /// <param name="account">Account details.</param>
        /// <param name="aclPermissions">ACL permissions.</param>
        /// <param name="apiKey">API key. This will show as null unless it is owned by your user or by a system user.</param>
        /// <param name="createdAt">Timestamp of creation.</param>
        /// <param name="description">Description.</param>
        /// <param name="id">ID.</param>
        /// <param name="ipRestriction">IP restriction.</param>
        /// <param name="locked">If true, the agreement can not be changed.</param>
        /// <param name="owner">Is account owner.</param>
        /// <param name="service">Service name (only for system/service agreements).</param>
        /// <param name="support">Support agreement.</param>
        /// <param name="user">User details.</param>
        public Agreement(bool? accepted = default(bool?), AgreementAccount account = default(AgreementAccount), List<AclPermission> aclPermissions = default(List<AclPermission>), string apiKey = default(string), DateTime? createdAt = default(DateTime?), string description = default(string), int? id = default(int?), List<IPRestriction> ipRestriction = default(List<IPRestriction>), bool? locked = default(bool?), bool? owner = default(bool?), string service = default(string), bool? support = default(bool?), AgreementUser user = default(AgreementUser))
        {
            this.Accepted = accepted;
            this.Account = account;
            this.AclPermissions = aclPermissions;
            this.ApiKey = apiKey;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Id = id;
            this.IpRestriction = ipRestriction;
            this.Locked = locked;
            this.Owner = owner;
            this.Service = service;
            this.Support = support;
            this.User = user;
        }
        
        /// <summary>
        /// Is agreement accepted by user
        /// </summary>
        /// <value>Is agreement accepted by user</value>
        [DataMember(Name="accepted", EmitDefaultValue=false)]
        public bool? Accepted { get; set; }

        /// <summary>
        /// Account details
        /// </summary>
        /// <value>Account details</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public AgreementAccount Account { get; set; }

        /// <summary>
        /// ACL permissions
        /// </summary>
        /// <value>ACL permissions</value>
        [DataMember(Name="acl_permissions", EmitDefaultValue=false)]
        public List<AclPermission> AclPermissions { get; set; }

        /// <summary>
        /// API key. This will show as null unless it is owned by your user or by a system user
        /// </summary>
        /// <value>API key. This will show as null unless it is owned by your user or by a system user</value>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        /// <value>Timestamp of creation</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        /// <value>ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// IP restriction
        /// </summary>
        /// <value>IP restriction</value>
        [DataMember(Name="ip_restriction", EmitDefaultValue=false)]
        public List<IPRestriction> IpRestriction { get; set; }

        /// <summary>
        /// If true, the agreement can not be changed
        /// </summary>
        /// <value>If true, the agreement can not be changed</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Is account owner
        /// </summary>
        /// <value>Is account owner</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public bool? Owner { get; set; }

        /// <summary>
        /// Service name (only for system/service agreements)
        /// </summary>
        /// <value>Service name (only for system/service agreements)</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }

        /// <summary>
        /// Support agreement
        /// </summary>
        /// <value>Support agreement</value>
        [DataMember(Name="support", EmitDefaultValue=false)]
        public bool? Support { get; set; }

        /// <summary>
        /// User details
        /// </summary>
        /// <value>User details</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AgreementUser User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Agreement {\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AclPermissions: ").Append(AclPermissions).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IpRestriction: ").Append(IpRestriction).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Support: ").Append(Support).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as Agreement);
        }

        /// <summary>
        /// Returns true if Agreement instances are equal
        /// </summary>
        /// <param name="input">Instance of Agreement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Agreement input)
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
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.AclPermissions == input.AclPermissions ||
                    this.AclPermissions != null &&
                    this.AclPermissions.SequenceEqual(input.AclPermissions)
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IpRestriction == input.IpRestriction ||
                    this.IpRestriction != null &&
                    this.IpRestriction.SequenceEqual(input.IpRestriction)
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Support == input.Support ||
                    (this.Support != null &&
                    this.Support.Equals(input.Support))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.AclPermissions != null)
                    hashCode = hashCode * 59 + this.AclPermissions.GetHashCode();
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpRestriction != null)
                    hashCode = hashCode * 59 + this.IpRestriction.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Support != null)
                    hashCode = hashCode * 59 + this.Support.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
