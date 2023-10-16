/*
 * Kinde Management API
 *
 * Provides endpoints to manage your Kinde Businesses
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Kinde.Api.Client.FileParameter;
using OpenAPIDateConverter = Kinde.Api.Client.OpenAPIDateConverter;

namespace Kinde.Api.Model
{
    /// <summary>
    /// UpdateRolePermissionsRequestPermissionsInner
    /// </summary>
    [DataContract(Name = "UpdateRolePermissions_request_permissions_inner")]
    public partial class UpdateRolePermissionsRequestPermissionsInner : IEquatable<UpdateRolePermissionsRequestPermissionsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRolePermissionsRequestPermissionsInner" /> class.
        /// </summary>
        /// <param name="id">The permission id..</param>
        /// <param name="operation">Optional operation, set to &#39;delete&#39; to remove the permission from the role..</param>
        public UpdateRolePermissionsRequestPermissionsInner(string id = default(string), string operation = default(string))
        {
            this.Id = id;
            this.Operation = operation;
        }

        /// <summary>
        /// The permission id.
        /// </summary>
        /// <value>The permission id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Optional operation, set to &#39;delete&#39; to remove the permission from the role.
        /// </summary>
        /// <value>Optional operation, set to &#39;delete&#39; to remove the permission from the role.</value>
        [DataMember(Name = "operation", EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateRolePermissionsRequestPermissionsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRolePermissionsRequestPermissionsInner);
        }

        /// <summary>
        /// Returns true if UpdateRolePermissionsRequestPermissionsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateRolePermissionsRequestPermissionsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateRolePermissionsRequestPermissionsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
