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
    /// ExperimentResponse
    /// </summary>
    [DataContract(Name = "ExperimentResponse")]
    public partial class ExperimentResponse : IEquatable<ExperimentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResponse" /> class.
        /// </summary>
        /// <param name="queryResponse">queryResponse.</param>
        public ExperimentResponse(QueryCollectionResponse queryResponse = default(QueryCollectionResponse))
        {
            this.QueryResponse = queryResponse;
        }

        /// <summary>
        /// Gets or Sets QueryResponse
        /// </summary>
        [DataMember(Name = "query_response", EmitDefaultValue = false)]
        public QueryCollectionResponse QueryResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExperimentResponse {\n");
            sb.Append("  QueryResponse: ").Append(QueryResponse).Append("\n");
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
            return this.Equals(input as ExperimentResponse);
        }

        /// <summary>
        /// Returns true if ExperimentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExperimentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExperimentResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QueryResponse == input.QueryResponse ||
                    (this.QueryResponse != null &&
                    this.QueryResponse.Equals(input.QueryResponse))
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
                if (this.QueryResponse != null)
                {
                    hashCode = (hashCode * 59) + this.QueryResponse.GetHashCode();
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
