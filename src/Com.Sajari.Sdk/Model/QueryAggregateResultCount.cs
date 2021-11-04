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
    /// Count contains the counts for the set of values returned.
    /// </summary>
    [DataContract(Name = "QueryAggregateResultCount")]
    public partial class QueryAggregateResultCount : IEquatable<QueryAggregateResultCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAggregateResultCount" /> class.
        /// </summary>
        /// <param name="counts">counts.</param>
        public QueryAggregateResultCount(Dictionary<string, int> counts = default(Dictionary<string, int>))
        {
            this.Counts = counts;
        }

        /// <summary>
        /// Gets or Sets Counts
        /// </summary>
        [DataMember(Name = "counts", EmitDefaultValue = false)]
        public Dictionary<string, int> Counts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAggregateResultCount {\n");
            sb.Append("  Counts: ").Append(Counts).Append("\n");
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
            return this.Equals(input as QueryAggregateResultCount);
        }

        /// <summary>
        /// Returns true if QueryAggregateResultCount instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryAggregateResultCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAggregateResultCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Counts == input.Counts ||
                    this.Counts != null &&
                    input.Counts != null &&
                    this.Counts.SequenceEqual(input.Counts)
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
                if (this.Counts != null)
                    hashCode = hashCode * 59 + this.Counts.GetHashCode();
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
