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
    /// PromotionRangeBoost
    /// </summary>
    [DataContract(Name = "PromotionRangeBoost")]
    public partial class PromotionRangeBoost : IEquatable<PromotionRangeBoost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionRangeBoost" /> class.
        /// </summary>
        /// <param name="boost">Number that determines the size of the boost that is applied to matching records. Must be greater than or equal to 0 and less than or equal to 1..</param>
        /// <param name="end">The end value to apply 1 boost to..</param>
        /// <param name="field">The field to apply the boost to..</param>
        /// <param name="nullBoost">The boost given to null/empty values. Must be greater than or equal to 0 and less than or equal to 1. The default value is 0..</param>
        /// <param name="start">The start value to apply 0 boost to..</param>
        public PromotionRangeBoost(float boost = default(float), float end = default(float), string field = default(string), float nullBoost = default(float), float start = default(float))
        {
            this.Boost = boost;
            this.End = end;
            this.Field = field;
            this.NullBoost = nullBoost;
            this.Start = start;
        }

        /// <summary>
        /// Number that determines the size of the boost that is applied to matching records. Must be greater than or equal to 0 and less than or equal to 1.
        /// </summary>
        /// <value>Number that determines the size of the boost that is applied to matching records. Must be greater than or equal to 0 and less than or equal to 1.</value>
        [DataMember(Name = "boost", EmitDefaultValue = false)]
        public float Boost { get; set; }

        /// <summary>
        /// The end value to apply 1 boost to.
        /// </summary>
        /// <value>The end value to apply 1 boost to.</value>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public float End { get; set; }

        /// <summary>
        /// The field to apply the boost to.
        /// </summary>
        /// <value>The field to apply the boost to.</value>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// The boost given to null/empty values. Must be greater than or equal to 0 and less than or equal to 1. The default value is 0.
        /// </summary>
        /// <value>The boost given to null/empty values. Must be greater than or equal to 0 and less than or equal to 1. The default value is 0.</value>
        [DataMember(Name = "null_boost", EmitDefaultValue = false)]
        public float NullBoost { get; set; }

        /// <summary>
        /// The start value to apply 0 boost to.
        /// </summary>
        /// <value>The start value to apply 0 boost to.</value>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public float Start { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PromotionRangeBoost {\n");
            sb.Append("  Boost: ").Append(Boost).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  NullBoost: ").Append(NullBoost).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
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
            return this.Equals(input as PromotionRangeBoost);
        }

        /// <summary>
        /// Returns true if PromotionRangeBoost instances are equal
        /// </summary>
        /// <param name="input">Instance of PromotionRangeBoost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromotionRangeBoost input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Boost == input.Boost ||
                    this.Boost.Equals(input.Boost)
                ) && 
                (
                    this.End == input.End ||
                    this.End.Equals(input.End)
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.NullBoost == input.NullBoost ||
                    this.NullBoost.Equals(input.NullBoost)
                ) && 
                (
                    this.Start == input.Start ||
                    this.Start.Equals(input.Start)
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
                hashCode = (hashCode * 59) + this.Boost.GetHashCode();
                hashCode = (hashCode * 59) + this.End.GetHashCode();
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NullBoost.GetHashCode();
                hashCode = (hashCode * 59) + this.Start.GetHashCode();
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