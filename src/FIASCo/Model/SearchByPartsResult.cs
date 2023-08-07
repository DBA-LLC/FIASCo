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
    /// SearchByPartsResult
    /// </summary>
    [DataContract(Name = "SearchByPartsResult")]
    public partial class SearchByPartsResult : IEquatable<SearchByPartsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchByPartsResult" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="description">description.</param>
        /// <param name="addressItem">addressItem.</param>
        /// <param name="lastFoundItem">lastFoundItem.</param>
        public SearchByPartsResult(string error = default(string), string description = default(string), AddressItem addressItem = default(AddressItem), AddressItem lastFoundItem = default(AddressItem))
        {
            this.Error = error;
            this.Description = description;
            this.AddressItem = addressItem;
            this.LastFoundItem = lastFoundItem;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AddressItem
        /// </summary>
        [DataMember(Name = "address_item", EmitDefaultValue = false)]
        public AddressItem AddressItem { get; set; }

        /// <summary>
        /// Gets or Sets LastFoundItem
        /// </summary>
        [DataMember(Name = "last_found_item", EmitDefaultValue = false)]
        public AddressItem LastFoundItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchByPartsResult {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AddressItem: ").Append(AddressItem).Append("\n");
            sb.Append("  LastFoundItem: ").Append(LastFoundItem).Append("\n");
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
            return this.Equals(input as SearchByPartsResult);
        }

        /// <summary>
        /// Returns true if SearchByPartsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchByPartsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchByPartsResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AddressItem == input.AddressItem ||
                    (this.AddressItem != null &&
                    this.AddressItem.Equals(input.AddressItem))
                ) && 
                (
                    this.LastFoundItem == input.LastFoundItem ||
                    (this.LastFoundItem != null &&
                    this.LastFoundItem.Equals(input.LastFoundItem))
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
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AddressItem != null)
                {
                    hashCode = (hashCode * 59) + this.AddressItem.GetHashCode();
                }
                if (this.LastFoundItem != null)
                {
                    hashCode = (hashCode * 59) + this.LastFoundItem.GetHashCode();
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