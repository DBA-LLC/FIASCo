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
    /// IFetchChangesTaskStatus
    /// </summary>
    [DataContract(Name = "IFetchChangesTaskStatus")]
    public partial class IFetchChangesTaskStatus : IEquatable<IFetchChangesTaskStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IFetchChangesTaskStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public IFetchChangesTaskStatus()
        {
        }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name = "completed", EmitDefaultValue = true)]
        public bool Completed { get; private set; }

        /// <summary>
        /// Returns false as Completed should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompleted()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BlockCount
        /// </summary>
        [DataMember(Name = "blockCount", EmitDefaultValue = false)]
        public int BlockCount { get; private set; }

        /// <summary>
        /// Returns false as BlockCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBlockCount()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IFetchChangesTaskStatus {\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  BlockCount: ").Append(BlockCount).Append("\n");
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
            return this.Equals(input as IFetchChangesTaskStatus);
        }

        /// <summary>
        /// Returns true if IFetchChangesTaskStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of IFetchChangesTaskStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IFetchChangesTaskStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Completed == input.Completed ||
                    this.Completed.Equals(input.Completed)
                ) && 
                (
                    this.BlockCount == input.BlockCount ||
                    this.BlockCount.Equals(input.BlockCount)
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
                hashCode = (hashCode * 59) + this.Completed.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockCount.GetHashCode();
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