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
    /// PosNeg is a pair of tokens which are used to mark a record as a good/bad result for a request.
    /// </summary>
    [DataContract(Name = "QueryResultTokenPosNeg")]
    public partial class QueryResultTokenPosNeg : IEquatable<QueryResultTokenPosNeg>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultTokenPosNeg" /> class.
        /// </summary>
        /// <param name="neg">neg.</param>
        /// <param name="pos">pos.</param>
        public QueryResultTokenPosNeg(string neg = default(string), string pos = default(string))
        {
            this.Neg = neg;
            this.Pos = pos;
        }

        /// <summary>
        /// Gets or Sets Neg
        /// </summary>
        [DataMember(Name = "neg", EmitDefaultValue = false)]
        public string Neg { get; set; }

        /// <summary>
        /// Gets or Sets Pos
        /// </summary>
        [DataMember(Name = "pos", EmitDefaultValue = false)]
        public string Pos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryResultTokenPosNeg {\n");
            sb.Append("  Neg: ").Append(Neg).Append("\n");
            sb.Append("  Pos: ").Append(Pos).Append("\n");
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
            return this.Equals(input as QueryResultTokenPosNeg);
        }

        /// <summary>
        /// Returns true if QueryResultTokenPosNeg instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryResultTokenPosNeg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryResultTokenPosNeg input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Neg == input.Neg ||
                    (this.Neg != null &&
                    this.Neg.Equals(input.Neg))
                ) && 
                (
                    this.Pos == input.Pos ||
                    (this.Pos != null &&
                    this.Pos.Equals(input.Pos))
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
                if (this.Neg != null)
                {
                    hashCode = (hashCode * 59) + this.Neg.GetHashCode();
                }
                if (this.Pos != null)
                {
                    hashCode = (hashCode * 59) + this.Pos.GetHashCode();
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
