/*
 * Search.io API
 *
 * Search.io offers a search and discovery service with Neuralsearch®, the world's first instant AI search technology. Businesses of all sizes use Search.io to build site search and discovery solutions that maximize e-commerce revenue, optimize on-site customer experience, and scale their online presence.
 *
 * The version of the OpenAPI document: v4
 * Contact: support@search.io
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
using OpenAPIDateConverter = Com.Sajari.Sdk.Client.OpenAPIDateConverter;

namespace Com.Sajari.Sdk.Model
{
    /// <summary>
    /// PromotionCategory
    /// </summary>
    [DataContract(Name = "PromotionCategory")]
    public partial class PromotionCategory : IEquatable<PromotionCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionCategory" /> class.
        /// </summary>
        /// <param name="idField">The logical field that specifies a record&#39;s category, e.g. \&quot;product_type\&quot;..</param>
        /// <param name="mappingField">The field that contains a human-readable rendering of a record&#39;s category, e.g. \&quot;product_type_name\&quot;. When creating promotions, this field&#39;s text value is displayed instead of the &#x60;id_field&#x60;. If &#x60;mapping_field&#x60; is not provided, the text value of the record&#39;s &#x60;id_field&#x60; is displayed..</param>
        public PromotionCategory(string idField = default(string), string mappingField = default(string))
        {
            this.IdField = idField;
            this.MappingField = mappingField;
        }

        /// <summary>
        /// The logical field that specifies a record&#39;s category, e.g. \&quot;product_type\&quot;.
        /// </summary>
        /// <value>The logical field that specifies a record&#39;s category, e.g. \&quot;product_type\&quot;.</value>
        [DataMember(Name = "id_field", EmitDefaultValue = false)]
        public string IdField { get; set; }

        /// <summary>
        /// The field that contains a human-readable rendering of a record&#39;s category, e.g. \&quot;product_type_name\&quot;. When creating promotions, this field&#39;s text value is displayed instead of the &#x60;id_field&#x60;. If &#x60;mapping_field&#x60; is not provided, the text value of the record&#39;s &#x60;id_field&#x60; is displayed.
        /// </summary>
        /// <value>The field that contains a human-readable rendering of a record&#39;s category, e.g. \&quot;product_type_name\&quot;. When creating promotions, this field&#39;s text value is displayed instead of the &#x60;id_field&#x60;. If &#x60;mapping_field&#x60; is not provided, the text value of the record&#39;s &#x60;id_field&#x60; is displayed.</value>
        [DataMember(Name = "mapping_field", EmitDefaultValue = false)]
        public string MappingField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PromotionCategory {\n");
            sb.Append("  IdField: ").Append(IdField).Append("\n");
            sb.Append("  MappingField: ").Append(MappingField).Append("\n");
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
            return this.Equals(input as PromotionCategory);
        }

        /// <summary>
        /// Returns true if PromotionCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of PromotionCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromotionCategory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IdField == input.IdField ||
                    (this.IdField != null &&
                    this.IdField.Equals(input.IdField))
                ) && 
                (
                    this.MappingField == input.MappingField ||
                    (this.MappingField != null &&
                    this.MappingField.Equals(input.MappingField))
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
                if (this.IdField != null)
                {
                    hashCode = (hashCode * 59) + this.IdField.GetHashCode();
                }
                if (this.MappingField != null)
                {
                    hashCode = (hashCode * 59) + this.MappingField.GetHashCode();
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
