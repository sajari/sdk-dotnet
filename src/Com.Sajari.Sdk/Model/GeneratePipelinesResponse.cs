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
    /// GeneratePipelinesResponse
    /// </summary>
    [DataContract(Name = "GeneratePipelinesResponse")]
    public partial class GeneratePipelinesResponse : IEquatable<GeneratePipelinesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePipelinesResponse" /> class.
        /// </summary>
        /// <param name="recordPipeline">recordPipeline.</param>
        /// <param name="queryPipeline">queryPipeline.</param>
        /// <param name="autocompletePipeline">autocompletePipeline.</param>
        public GeneratePipelinesResponse(Pipeline recordPipeline = default(Pipeline), Pipeline queryPipeline = default(Pipeline), Pipeline autocompletePipeline = default(Pipeline))
        {
            this.RecordPipeline = recordPipeline;
            this.QueryPipeline = queryPipeline;
            this.AutocompletePipeline = autocompletePipeline;
        }

        /// <summary>
        /// Gets or Sets RecordPipeline
        /// </summary>
        [DataMember(Name = "record_pipeline", EmitDefaultValue = false)]
        public Pipeline RecordPipeline { get; set; }

        /// <summary>
        /// Gets or Sets QueryPipeline
        /// </summary>
        [DataMember(Name = "query_pipeline", EmitDefaultValue = false)]
        public Pipeline QueryPipeline { get; set; }

        /// <summary>
        /// Gets or Sets AutocompletePipeline
        /// </summary>
        [DataMember(Name = "autocomplete_pipeline", EmitDefaultValue = false)]
        public Pipeline AutocompletePipeline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneratePipelinesResponse {\n");
            sb.Append("  RecordPipeline: ").Append(RecordPipeline).Append("\n");
            sb.Append("  QueryPipeline: ").Append(QueryPipeline).Append("\n");
            sb.Append("  AutocompletePipeline: ").Append(AutocompletePipeline).Append("\n");
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
            return this.Equals(input as GeneratePipelinesResponse);
        }

        /// <summary>
        /// Returns true if GeneratePipelinesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GeneratePipelinesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneratePipelinesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordPipeline == input.RecordPipeline ||
                    (this.RecordPipeline != null &&
                    this.RecordPipeline.Equals(input.RecordPipeline))
                ) && 
                (
                    this.QueryPipeline == input.QueryPipeline ||
                    (this.QueryPipeline != null &&
                    this.QueryPipeline.Equals(input.QueryPipeline))
                ) && 
                (
                    this.AutocompletePipeline == input.AutocompletePipeline ||
                    (this.AutocompletePipeline != null &&
                    this.AutocompletePipeline.Equals(input.AutocompletePipeline))
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
                if (this.RecordPipeline != null)
                    hashCode = hashCode * 59 + this.RecordPipeline.GetHashCode();
                if (this.QueryPipeline != null)
                    hashCode = hashCode * 59 + this.QueryPipeline.GetHashCode();
                if (this.AutocompletePipeline != null)
                    hashCode = hashCode * 59 + this.AutocompletePipeline.GetHashCode();
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