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
    /// A request to perform a search using a pipeline.
    /// </summary>
    [DataContract(Name = "QueryCollectionRequest")]
    public partial class QueryCollectionRequest : IEquatable<QueryCollectionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCollectionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryCollectionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCollectionRequest" /> class.
        /// </summary>
        /// <param name="pipeline">pipeline.</param>
        /// <param name="variables">The initial values for the variables the pipeline operates on and transforms throughout its steps.  The most important variable is &#x60;q&#x60; which is the query the user entered, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot; } &#x60;&#x60;&#x60;  To paginate through results, set the variables &#x60;page&#x60; and &#x60;resultsPerPage&#x60;, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;page\&quot;: 5, \&quot;resultsPerPage\&quot;: 20 } &#x60;&#x60;&#x60;  To sort results, set the variable &#x60;sort&#x60; to the name of one of your collection&#39;s schema fields, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;sort\&quot;: \&quot;name\&quot; } &#x60;&#x60;&#x60;  To sort in reverse, prefix the schema field with a minus sign &#x60;-&#x60;, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;sort\&quot;: \&quot;-name\&quot; } &#x60;&#x60;&#x60; (required).</param>
        /// <param name="tracking">tracking.</param>
        public QueryCollectionRequest(QueryCollectionRequestPipeline pipeline = default(QueryCollectionRequestPipeline), Object variables = default(Object), QueryCollectionRequestTracking tracking = default(QueryCollectionRequestTracking))
        {
            // to ensure "variables" is required (not null)
            this.Variables = variables ?? throw new ArgumentNullException("variables is a required property for QueryCollectionRequest and cannot be null");
            this.Pipeline = pipeline;
            this.Tracking = tracking;
        }

        /// <summary>
        /// Gets or Sets Pipeline
        /// </summary>
        [DataMember(Name = "pipeline", EmitDefaultValue = false)]
        public QueryCollectionRequestPipeline Pipeline { get; set; }

        /// <summary>
        /// The initial values for the variables the pipeline operates on and transforms throughout its steps.  The most important variable is &#x60;q&#x60; which is the query the user entered, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot; } &#x60;&#x60;&#x60;  To paginate through results, set the variables &#x60;page&#x60; and &#x60;resultsPerPage&#x60;, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;page\&quot;: 5, \&quot;resultsPerPage\&quot;: 20 } &#x60;&#x60;&#x60;  To sort results, set the variable &#x60;sort&#x60; to the name of one of your collection&#39;s schema fields, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;sort\&quot;: \&quot;name\&quot; } &#x60;&#x60;&#x60;  To sort in reverse, prefix the schema field with a minus sign &#x60;-&#x60;, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;sort\&quot;: \&quot;-name\&quot; } &#x60;&#x60;&#x60;
        /// </summary>
        /// <value>The initial values for the variables the pipeline operates on and transforms throughout its steps.  The most important variable is &#x60;q&#x60; which is the query the user entered, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot; } &#x60;&#x60;&#x60;  To paginate through results, set the variables &#x60;page&#x60; and &#x60;resultsPerPage&#x60;, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;page\&quot;: 5, \&quot;resultsPerPage\&quot;: 20 } &#x60;&#x60;&#x60;  To sort results, set the variable &#x60;sort&#x60; to the name of one of your collection&#39;s schema fields, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;sort\&quot;: \&quot;name\&quot; } &#x60;&#x60;&#x60;  To sort in reverse, prefix the schema field with a minus sign &#x60;-&#x60;, for example:  &#x60;&#x60;&#x60;json { \&quot;q\&quot;: \&quot;search terms\&quot;, \&quot;sort\&quot;: \&quot;-name\&quot; } &#x60;&#x60;&#x60;</value>
        [DataMember(Name = "variables", IsRequired = true, EmitDefaultValue = false)]
        public Object Variables { get; set; }

        /// <summary>
        /// Gets or Sets Tracking
        /// </summary>
        [DataMember(Name = "tracking", EmitDefaultValue = false)]
        public QueryCollectionRequestTracking Tracking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCollectionRequest {\n");
            sb.Append("  Pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  Tracking: ").Append(Tracking).Append("\n");
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
            return this.Equals(input as QueryCollectionRequest);
        }

        /// <summary>
        /// Returns true if QueryCollectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryCollectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryCollectionRequest input)
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
                    this.Tracking == input.Tracking ||
                    (this.Tracking != null &&
                    this.Tracking.Equals(input.Tracking))
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
                if (this.Tracking != null)
                    hashCode = hashCode * 59 + this.Tracking.GetHashCode();
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
