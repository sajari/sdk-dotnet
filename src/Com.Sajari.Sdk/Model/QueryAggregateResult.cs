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
    /// A query aggregate result contains results of aggregations.
    /// </summary>
    [DataContract(Name = "QueryAggregateResult")]
    public partial class QueryAggregateResult : IEquatable<QueryAggregateResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAggregateResult" /> class.
        /// </summary>
        /// <param name="metric">metric.</param>
        /// <param name="count">count.</param>
        /// <param name="buckets">buckets.</param>
        /// <param name="date">date.</param>
        /// <param name="analysis">analysis.</param>
        public QueryAggregateResult(QueryAggregateResultMetric metric = default(QueryAggregateResultMetric), QueryAggregateResultCount count = default(QueryAggregateResultCount), QueryAggregateResultBuckets buckets = default(QueryAggregateResultBuckets), QueryAggregateResultDate date = default(QueryAggregateResultDate), QueryAggregateResultAnalysis analysis = default(QueryAggregateResultAnalysis))
        {
            this.Metric = metric;
            this.Count = count;
            this.Buckets = buckets;
            this.Date = date;
            this.Analysis = analysis;
        }

        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name = "metric", EmitDefaultValue = false)]
        public QueryAggregateResultMetric Metric { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public QueryAggregateResultCount Count { get; set; }

        /// <summary>
        /// Gets or Sets Buckets
        /// </summary>
        [DataMember(Name = "buckets", EmitDefaultValue = false)]
        public QueryAggregateResultBuckets Buckets { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public QueryAggregateResultDate Date { get; set; }

        /// <summary>
        /// Gets or Sets Analysis
        /// </summary>
        [DataMember(Name = "analysis", EmitDefaultValue = false)]
        public QueryAggregateResultAnalysis Analysis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAggregateResult {\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Analysis: ").Append(Analysis).Append("\n");
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
            return this.Equals(input as QueryAggregateResult);
        }

        /// <summary>
        /// Returns true if QueryAggregateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryAggregateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryAggregateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Buckets == input.Buckets ||
                    (this.Buckets != null &&
                    this.Buckets.Equals(input.Buckets))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Analysis == input.Analysis ||
                    (this.Analysis != null &&
                    this.Analysis.Equals(input.Analysis))
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
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Buckets != null)
                    hashCode = hashCode * 59 + this.Buckets.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Analysis != null)
                    hashCode = hashCode * 59 + this.Analysis.GetHashCode();
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
