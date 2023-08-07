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
    /// Данные для добавления в задачу на конвертацию адресов
    /// </summary>
    [DataContract(Name = "AddConversionDataInput")]
    public partial class AddConversionDataInput : IEquatable<AddConversionDataInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddConversionDataInput" /> class.
        /// </summary>
        /// <param name="taskGuid">Идентификатор задачи на конвертацию адресов.</param>
        /// <param name="data">Блок данных.</param>
        public AddConversionDataInput(Guid taskGuid = default(Guid), List<ConvertionRecord> data = default(List<ConvertionRecord>))
        {
            this.TaskGuid = taskGuid;
            this.Data = data;
        }

        /// <summary>
        /// Идентификатор задачи на конвертацию адресов
        /// </summary>
        /// <value>Идентификатор задачи на конвертацию адресов</value>
        [DataMember(Name = "task_guid", EmitDefaultValue = false)]
        public Guid TaskGuid { get; set; }

        /// <summary>
        /// Блок данных
        /// </summary>
        /// <value>Блок данных</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<ConvertionRecord> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddConversionDataInput {\n");
            sb.Append("  TaskGuid: ").Append(TaskGuid).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as AddConversionDataInput);
        }

        /// <summary>
        /// Returns true if AddConversionDataInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddConversionDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddConversionDataInput input)
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
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
