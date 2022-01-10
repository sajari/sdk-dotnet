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
    /// The resolved query pipeline that was used to run the query.
    /// </summary>
    [DataContract(Name = "QueryCollectionResponsePipeline")]
    public partial class QueryCollectionResponsePipeline : IEquatable<QueryCollectionResponsePipeline>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCollectionResponsePipeline" /> class.
        /// </summary>
        /// <param name="name">The pipeline&#39;s name, e.g. &#x60;my-pipeline&#x60;..</param>
        /// <param name="version">The pipeline&#39;s version, e.g. &#x60;42&#x60;..</param>
        public QueryCollectionResponsePipeline(string name = default(string), string version = default(string))
        {
            this.Name = name;
            this._Version = version;
        }

        /// <summary>
        /// The pipeline&#39;s name, e.g. &#x60;my-pipeline&#x60;.
        /// </summary>
        /// <value>The pipeline&#39;s name, e.g. &#x60;my-pipeline&#x60;.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The pipeline&#39;s version, e.g. &#x60;42&#x60;.
        /// </summary>
        /// <value>The pipeline&#39;s version, e.g. &#x60;42&#x60;.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryCollectionResponsePipeline {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as QueryCollectionResponsePipeline);
        }

        /// <summary>
        /// Returns true if QueryCollectionResponsePipeline instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryCollectionResponsePipeline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryCollectionResponsePipeline input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
