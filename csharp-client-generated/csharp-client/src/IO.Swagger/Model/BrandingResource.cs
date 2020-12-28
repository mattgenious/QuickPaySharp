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
    /// BrandingResource
    /// </summary>
    [DataContract]
    public partial class BrandingResource :  IEquatable<BrandingResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandingResource" /> class.
        /// </summary>
        /// <param name="data">Binary data encoded in Base64.</param>
        /// <param name="mime">Mime type.</param>
        /// <param name="name">Name.</param>
        /// <param name="size">Size in bytes.</param>
        public BrandingResource(string data = default(string), string mime = default(string), string name = default(string), string size = default(string))
        {
            this.Data = data;
            this.Mime = mime;
            this.Name = name;
            this.Size = size;
        }
        
        /// <summary>
        /// Binary data encoded in Base64
        /// </summary>
        /// <value>Binary data encoded in Base64</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Mime type
        /// </summary>
        /// <value>Mime type</value>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Size in bytes
        /// </summary>
        /// <value>Size in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandingResource {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as BrandingResource);
        }

        /// <summary>
        /// Returns true if BrandingResource instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandingResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Mime == input.Mime ||
                    (this.Mime != null &&
                    this.Mime.Equals(input.Mime))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Mime != null)
                    hashCode = hashCode * 59 + this.Mime.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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
