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
    /// QueryAggregateResultAnalysis
    /// </summary>
    [DataContract(Name = "QueryAggregateResultAnalysis")]
    public partial class QueryAggregateResultAnalysis : IEquatable<QueryAggregateResultAnalysis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAggregateResultAnalysis" /> class.
        /// </summary>
        /// <param name="avgLength">Average number of items in an array field..</param>
        /// <param name="cardinality">Cardinality is the number of different values in a field..</param>
        /// <param name="coverage">Coverage is the number of records which have a value set..</param>
        /// <param name="maxLength">Maximum number of values in an array field..</param>
        /// <param name="minLength">Minimum length of an array field..</param>
        public QueryAggregateResultAnalysis(float avgLength = default(float), int cardinality = default(int), int coverage = default(int), int maxLength = default(int), int minLength = default(int))
        {
            this.AvgLength = avgLength;
            this.Cardinality = cardinality;
            this.Coverage = coverage;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
        }

        /// <summary>
        /// Average number of items in an array field.
        /// </summary>
        /// <value>Average number of items in an array field.</value>
        [DataMember(Name = "avg_length", EmitDefaultValue = false)]
        public float AvgLength { get; set; }

        /// <summary>
        /// Cardinality is the number of different values in a field.
        /// </summary>
        /// <value>Cardinality is the number of different values in a field.</value>
        [DataMember(Name = "cardinality", EmitDefaultValue = false)]
        public int Cardinality { get; set; }

        /// <summary>
        /// Coverage is the number of records which have a value set.
        /// </summary>
        /// <value>Coverage is the number of records which have a value set.</value>
        [DataMember(Name = "coverage", EmitDefaultValue = false)]
        public int Coverage { get; set; }

        /// <summary>
        /// Maximum number of values in an array field.
        /// </summary>
        /// <value>Maximum number of values in an array field.</value>
        [DataMember(Name = "max_length", EmitDefaultValue = false)]
        public int MaxLength { get; set; }

        /// <summary>
        /// Minimum length of an array field.
        /// </summary>
        /// <value>Minimum length of an array field.</value>
        [DataMember(Name = "min_length", EmitDefaultValue = false)]
        public int MinLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryAggregateResultAnalysis {\n");
            sb.Append("  AvgLength: ").Append(AvgLength).Append("\n");
            sb.Append("  Cardinality: ").Append(Cardinality).Append("\n");
            sb.Append("  Coverage: ").Append(Coverage).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
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
            return this.Equals(input as QueryAggregateResultAnalysis);
        }

        /// <summary>
        /// Returns true if QueryAggregateResultAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryAggregateResultAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAggregateResultAnalysis input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvgLength == input.AvgLength ||
                    this.AvgLength.Equals(input.AvgLength)
                ) && 
                (
                    this.Cardinality == input.Cardinality ||
                    this.Cardinality.Equals(input.Cardinality)
                ) && 
                (
                    this.Coverage == input.Coverage ||
                    this.Coverage.Equals(input.Coverage)
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    this.MaxLength.Equals(input.MaxLength)
                ) && 
                (
                    this.MinLength == input.MinLength ||
                    this.MinLength.Equals(input.MinLength)
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
                hashCode = (hashCode * 59) + this.AvgLength.GetHashCode();
                hashCode = (hashCode * 59) + this.Cardinality.GetHashCode();
                hashCode = (hashCode * 59) + this.Coverage.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxLength.GetHashCode();
                hashCode = (hashCode * 59) + this.MinLength.GetHashCode();
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
