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
    /// QueryCollectionResponse
    /// </summary>
    [DataContract(Name = "QueryCollectionResponse")]
    public partial class QueryCollectionResponse : IEquatable<QueryCollectionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCollectionResponse" /> class.
        /// </summary>
        /// <param name="pipeline">pipeline.</param>
        /// <param name="variables">The modified variables returned by the pipeline after it has finished processing..</param>
        /// <param name="results">The results returned by the query..</param>
        /// <param name="totalSize">The total number of results that match the query..</param>
        /// <param name="processingDuration">The total time taken to perform the query..</param>
        /// <param name="aggregates">The aggregates returned by the query..</param>
        /// <param name="aggregateFilters">The aggregates run with filters..</param>
        public QueryCollectionResponse(QueryCollectionResponsePipeline pipeline = default(QueryCollectionResponsePipeline), Object variables = default(Object), List<QueryResult> results = default(List<QueryResult>), string totalSize = default(string), string processingDuration = default(string), Dictionary<string, QueryAggregateResult> aggregates = default(Dictionary<string, QueryAggregateResult>), Dictionary<string, QueryAggregateResult> aggregateFilters = default(Dictionary<string, QueryAggregateResult>))
        {
            this.Pipeline = pipeline;
            this.Variables = variables;
            this.Results = results;
            this.TotalSize = totalSize;
            this.ProcessingDuration = processingDuration;
            this.Aggregates = aggregates;
            this.AggregateFilters = aggregateFilters;
        }

        /// <summary>
        /// Gets or Sets Pipeline
        /// </summary>
        [DataMember(Name = "pipeline", EmitDefaultValue = false)]
        public QueryCollectionResponsePipeline Pipeline { get; set; }

        /// <summary>
        /// The modified variables returned by the pipeline after it has finished processing.
        /// </summary>
        /// <value>The modified variables returned by the pipeline after it has finished processing.</value>
        [DataMember(Name = "variables", EmitDefaultValue = false)]
        public Object Variables { get; set; }

        /// <summary>
        /// The results returned by the query.
        /// </summary>
        /// <value>The results returned by the query.</value>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<QueryResult> Results { get; set; }

        /// <summary>
        /// The total number of results that match the query.
        /// </summary>
        /// <value>The total number of results that match the query.</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public string TotalSize { get; set; }

        /// <summary>
        /// The total time taken to perform the query.
        /// </summary>
        /// <value>The total time taken to perform the query.</value>
        [DataMember(Name = "processing_duration", EmitDefaultValue = false)]
        public string ProcessingDuration { get; set; }

        /// <summary>
        /// The aggregates returned by the query.
        /// </summary>
        /// <value>The aggregates returned by the query.</value>
        [DataMember(Name = "aggregates", EmitDefaultValue = false)]
        public Dictionary<string, QueryAggregateResult> Aggregates { get; set; }

        /// <summary>
        /// The aggregates run with filters.
        /// </summary>
        /// <value>The aggregates run with filters.</value>
        [DataMember(Name = "aggregate_filters", EmitDefaultValue = false)]
        public Dictionary<string, QueryAggregateResult> AggregateFilters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCollectionResponse {\n");
            sb.Append("  Pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  ProcessingDuration: ").Append(ProcessingDuration).Append("\n");
            sb.Append("  Aggregates: ").Append(Aggregates).Append("\n");
            sb.Append("  AggregateFilters: ").Append(AggregateFilters).Append("\n");
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
            return this.Equals(input as QueryCollectionResponse);
        }

        /// <summary>
        /// Returns true if QueryCollectionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryCollectionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryCollectionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pipeline == input.Pipeline ||
                    (this.Pipeline != null &&
                    this.Pipeline.Equals(input.Pipeline))
                ) && 
                (
                    this.Variables == input.Variables ||
                    (this.Variables != null &&
                    this.Variables.Equals(input.Variables))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    (this.TotalSize != null &&
                    this.TotalSize.Equals(input.TotalSize))
                ) && 
                (
                    this.ProcessingDuration == input.ProcessingDuration ||
                    (this.ProcessingDuration != null &&
                    this.ProcessingDuration.Equals(input.ProcessingDuration))
                ) && 
                (
                    this.Aggregates == input.Aggregates ||
                    this.Aggregates != null &&
                    input.Aggregates != null &&
                    this.Aggregates.SequenceEqual(input.Aggregates)
                ) && 
                (
                    this.AggregateFilters == input.AggregateFilters ||
                    this.AggregateFilters != null &&
                    input.AggregateFilters != null &&
                    this.AggregateFilters.SequenceEqual(input.AggregateFilters)
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
                if (this.Pipeline != null)
                    hashCode = hashCode * 59 + this.Pipeline.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.TotalSize != null)
                    hashCode = hashCode * 59 + this.TotalSize.GetHashCode();
                if (this.ProcessingDuration != null)
                    hashCode = hashCode * 59 + this.ProcessingDuration.GetHashCode();
                if (this.Aggregates != null)
                    hashCode = hashCode * 59 + this.Aggregates.GetHashCode();
                if (this.AggregateFilters != null)
                    hashCode = hashCode * 59 + this.AggregateFilters.GetHashCode();
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
