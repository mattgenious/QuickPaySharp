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
    /// QuickPayProtocolV10AclPermission
    /// </summary>
    [DataContract]
    public partial class QuickPayProtocolV10AclPermission :  IEquatable<QuickPayProtocolV10AclPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickPayProtocolV10AclPermission" /> class.
        /// </summary>
        /// <param name="delete">Allow DELETE.</param>
        /// <param name="get">Allow GET.</param>
        /// <param name="patch">Allow PATCH.</param>
        /// <param name="post">Allow POST.</param>
        /// <param name="put">Allow PUT.</param>
        /// <param name="resource">Resource URI.</param>
        public QuickPayProtocolV10AclPermission(bool? delete = default(bool?), bool? get = default(bool?), bool? patch = default(bool?), bool? post = default(bool?), bool? put = default(bool?), string resource = default(string))
        {
            this.Delete = delete;
            this.Get = get;
            this.Patch = patch;
            this.Post = post;
            this.Put = put;
            this.Resource = resource;
        }
        
        /// <summary>
        /// Allow DELETE
        /// </summary>
        /// <value>Allow DELETE</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// Allow GET
        /// </summary>
        /// <value>Allow GET</value>
        [DataMember(Name="get", EmitDefaultValue=false)]
        public bool? Get { get; set; }

        /// <summary>
        /// Allow PATCH
        /// </summary>
        /// <value>Allow PATCH</value>
        [DataMember(Name="patch", EmitDefaultValue=false)]
        public bool? Patch { get; set; }

        /// <summary>
        /// Allow POST
        /// </summary>
        /// <value>Allow POST</value>
        [DataMember(Name="post", EmitDefaultValue=false)]
        public bool? Post { get; set; }

        /// <summary>
        /// Allow PUT
        /// </summary>
        /// <value>Allow PUT</value>
        [DataMember(Name="put", EmitDefaultValue=false)]
        public bool? Put { get; set; }

        /// <summary>
        /// Resource URI
        /// </summary>
        /// <value>Resource URI</value>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickPayProtocolV10AclPermission {\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  Get: ").Append(Get).Append("\n");
            sb.Append("  Patch: ").Append(Patch).Append("\n");
            sb.Append("  Post: ").Append(Post).Append("\n");
            sb.Append("  Put: ").Append(Put).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(input as QuickPayProtocolV10AclPermission);
        }

        /// <summary>
        /// Returns true if QuickPayProtocolV10AclPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of QuickPayProtocolV10AclPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickPayProtocolV10AclPermission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Delete == input.Delete ||
                    (this.Delete != null &&
                    this.Delete.Equals(input.Delete))
                ) && 
                (
                    this.Get == input.Get ||
                    (this.Get != null &&
                    this.Get.Equals(input.Get))
                ) && 
                (
                    this.Patch == input.Patch ||
                    (this.Patch != null &&
                    this.Patch.Equals(input.Patch))
                ) && 
                (
                    this.Post == input.Post ||
                    (this.Post != null &&
                    this.Post.Equals(input.Post))
                ) && 
                (
                    this.Put == input.Put ||
                    (this.Put != null &&
                    this.Put.Equals(input.Put))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
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
                if (this.Delete != null)
                    hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.Get != null)
                    hashCode = hashCode * 59 + this.Get.GetHashCode();
                if (this.Patch != null)
                    hashCode = hashCode * 59 + this.Patch.GetHashCode();
                if (this.Post != null)
                    hashCode = hashCode * 59 + this.Post.GetHashCode();
                if (this.Put != null)
                    hashCode = hashCode * 59 + this.Put.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
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
