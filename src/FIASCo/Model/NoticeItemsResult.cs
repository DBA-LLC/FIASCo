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
    /// Результат возвращающий идентификатор уведомления
    /// </summary>
    [DataContract(Name = "NoticeItemsResult")]
    public partial class NoticeItemsResult : IEquatable<NoticeItemsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoticeItemsResult" /> class.
        /// </summary>
        /// <param name="notices">Список уведомлений.</param>
        public NoticeItemsResult(List<NoticeItem> notices = default(List<NoticeItem>))
        {
            this.Notices = notices;
        }

        /// <summary>
        /// Список уведомлений
        /// </summary>
        /// <value>Список уведомлений</value>
        [DataMember(Name = "notices", EmitDefaultValue = true)]
        public List<NoticeItem> Notices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NoticeItemsResult {\n");
            sb.Append("  Notices: ").Append(Notices).Append("\n");
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
            return this.Equals(input as NoticeItemsResult);
        }

        /// <summary>
        /// Returns true if NoticeItemsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of NoticeItemsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoticeItemsResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Notices == input.Notices ||
                    this.Notices != null &&
                    input.Notices != null &&
                    this.Notices.SequenceEqual(input.Notices)
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
                if (this.Notices != null)
                {
                    hashCode = (hashCode * 59) + this.Notices.GetHashCode();
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
