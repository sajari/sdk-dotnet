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
    /// UpsertRecordRequest
    /// </summary>
    [DataContract(Name = "UpsertRecordRequest")]
    public partial class UpsertRecordRequest : IEquatable<UpsertRecordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRecordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertRecordRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRecordRequest" /> class.
        /// </summary>
        /// <param name="pipeline">pipeline.</param>
        /// <param name="record">An object made up of field-value pairs that contains the record data. (required).</param>
        /// <param name="variables">The initial values for the variables the pipeline operates on and transforms throughout its steps..</param>
        public UpsertRecordRequest(UpsertRecordRequestPipeline pipeline = default(UpsertRecordRequestPipeline), Object record = default(Object), Dictionary<string, Object> variables = default(Dictionary<string, Object>))
        {
            // to ensure "record" is required (not null)
            if (record == null) {
                throw new ArgumentNullException("record is a required property for UpsertRecordRequest and cannot be null");
            }
            this.Record = record;
            this.Pipeline = pipeline;
            this.Variables = variables;
        }

        /// <summary>
        /// Gets or Sets Pipeline
        /// </summary>
        [DataMember(Name = "pipeline", EmitDefaultValue = false)]
        public UpsertRecordRequestPipeline Pipeline { get; set; }

        /// <summary>
        /// An object made up of field-value pairs that contains the record data.
        /// </summary>
        /// <value>An object made up of field-value pairs that contains the record data.</value>
        [DataMember(Name = "record", IsRequired = true, EmitDefaultValue = false)]
        public Object Record { get; set; }

        /// <summary>
        /// The initial values for the variables the pipeline operates on and transforms throughout its steps.
        /// </summary>
        /// <value>The initial values for the variables the pipeline operates on and transforms throughout its steps.</value>
        [DataMember(Name = "variables", EmitDefaultValue = false)]
        public Dictionary<string, Object> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpsertRecordRequest {\n");
            sb.Append("  Pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return this.Equals(input as UpsertRecordRequest);
        }

        /// <summary>
        /// Returns true if UpsertRecordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertRecordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertRecordRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pipeline == input.Pipeline ||
                    (this.Pipeline != null &&
                    this.Pipeline.Equals(input.Pipeline))
                ) && 
                (
                    this.Record == input.Record ||
                    (this.Record != null &&
                    this.Record.Equals(input.Record))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
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
                {
                    hashCode = (hashCode * 59) + this.Pipeline.GetHashCode();
                }
                if (this.Record != null)
                {
                    hashCode = (hashCode * 59) + this.Record.GetHashCode();
                }
                if (this.Variables != null)
                {
                    hashCode = (hashCode * 59) + this.Variables.GetHashCode();
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
