/*
 * SPAS API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0
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
using OpenAPIDateConverter = FIASCo.Client.OpenAPIDateConverter;

namespace FIASCo.Model
{
    /// <summary>
    /// ConvertionRecord
    /// </summary>
    [DataContract(Name = "ConvertionRecord")]
    public partial class ConvertionRecord : IEquatable<ConvertionRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertionRecord" /> class.
        /// </summary>
        /// <param name="extId">extId.</param>
        public ConvertionRecord(string extId = default(string))
        {
            this.ExtId = extId;
        }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "data_type", EmitDefaultValue = true)]
        public string DataType { get; private set; }

        /// <summary>
        /// Returns false as DataType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDataType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ExtId
        /// </summary>
        [DataMember(Name = "ext_id", EmitDefaultValue = true)]
        public string ExtId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConvertionRecord {\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  ExtId: ").Append(ExtId).Append("\n");
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
            return this.Equals(input as ConvertionRecord);
        }

        /// <summary>
        /// Returns true if ConvertionRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvertionRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertionRecord input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.ExtId == input.ExtId ||
                    (this.ExtId != null &&
                    this.ExtId.Equals(input.ExtId))
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
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                if (this.ExtId != null)
                {
                    hashCode = (hashCode * 59) + this.ExtId.GetHashCode();
                }
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
