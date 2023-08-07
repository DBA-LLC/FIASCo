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
    /// Результат создания задачи на конвертацию адресов
    /// </summary>
    [DataContract(Name = "CreateConversionTaskResult")]
    public partial class CreateConversionTaskResult : IEquatable<CreateConversionTaskResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversionTaskResult" /> class.
        /// </summary>
        /// <param name="taskGuid">Идентификатор задачи.</param>
        public CreateConversionTaskResult(Guid taskGuid = default(Guid))
        {
            this.TaskGuid = taskGuid;
        }

        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        /// <value>Идентификатор задачи</value>
        [DataMember(Name = "task_guid", EmitDefaultValue = false)]
        public Guid TaskGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateConversionTaskResult {\n");
            sb.Append("  TaskGuid: ").Append(TaskGuid).Append("\n");
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
            return this.Equals(input as CreateConversionTaskResult);
        }

        /// <summary>
        /// Returns true if CreateConversionTaskResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConversionTaskResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConversionTaskResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TaskGuid == input.TaskGuid ||
                    (this.TaskGuid != null &&
                    this.TaskGuid.Equals(input.TaskGuid))
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
                if (this.TaskGuid != null)
                {
                    hashCode = (hashCode * 59) + this.TaskGuid.GetHashCode();
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