/*
 * Sajari API
 *
 * Sajari is a smart, highly-configurable, real-time search service that enables thousands of businesses worldwide to provide amazing search experiences on their websites, stores, and applications.
 *
 * The version of the OpenAPI document: v4
 * Contact: support@sajari.com
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
    /// PercentileDataPoint
    /// </summary>
    [DataContract(Name = "PercentileDataPoint")]
    public partial class PercentileDataPoint : IEquatable<PercentileDataPoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PercentileDataPoint" /> class.
        /// </summary>
        /// <param name="point">The input point..</param>
        /// <param name="value">The corresponding value for the given point..</param>
        public PercentileDataPoint(double point = default(double), double value = default(double))
        {
            this.Point = point;
            this.Value = value;
        }

        /// <summary>
        /// The input point.
        /// </summary>
        /// <value>The input point.</value>
        [DataMember(Name = "point", EmitDefaultValue = false)]
        public double Point { get; set; }

        /// <summary>
        /// The corresponding value for the given point.
        /// </summary>
        /// <value>The corresponding value for the given point.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PercentileDataPoint {\n");
            sb.Append("  Point: ").Append(Point).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as PercentileDataPoint);
        }

        /// <summary>
        /// Returns true if PercentileDataPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of PercentileDataPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PercentileDataPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Point == input.Point ||
                    this.Point.Equals(input.Point)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                hashCode = hashCode * 59 + this.Point.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
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
