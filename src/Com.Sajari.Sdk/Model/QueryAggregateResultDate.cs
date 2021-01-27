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
    /// QueryAggregateResultDate
    /// </summary>
    [DataContract(Name = "QueryAggregateResultDate")]
    public partial class QueryAggregateResultDate : IEquatable<QueryAggregateResultDate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAggregateResultDate" /> class.
        /// </summary>
        /// <param name="dates">dates.</param>
        public QueryAggregateResultDate(Dictionary<string, int> dates = default(Dictionary<string, int>))
        {
            this.Dates = dates;
        }

        /// <summary>
        /// Gets or Sets Dates
        /// </summary>
        [DataMember(Name = "dates", EmitDefaultValue = false)]
        public Dictionary<string, int> Dates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAggregateResultDate {\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
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
            return this.Equals(input as QueryAggregateResultDate);
        }

        /// <summary>
        /// Returns true if QueryAggregateResultDate instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryAggregateResultDate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAggregateResultDate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dates == input.Dates ||
                    this.Dates != null &&
                    input.Dates != null &&
                    this.Dates.SequenceEqual(input.Dates)
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
                if (this.Dates != null)
                    hashCode = hashCode * 59 + this.Dates.GetHashCode();
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
