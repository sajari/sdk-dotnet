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
    /// Tokens are used to carry ranking information for query results.
    /// </summary>
    [DataContract(Name = "QueryResultToken")]
    public partial class QueryResultToken : IEquatable<QueryResultToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultToken" /> class.
        /// </summary>
        /// <param name="click">click.</param>
        /// <param name="posNeg">posNeg.</param>
        public QueryResultToken(QueryResultTokenClick click = default(QueryResultTokenClick), QueryResultTokenPosNeg posNeg = default(QueryResultTokenPosNeg))
        {
            this.Click = click;
            this.PosNeg = posNeg;
        }

        /// <summary>
        /// Gets or Sets Click
        /// </summary>
        [DataMember(Name = "click", EmitDefaultValue = false)]
        public QueryResultTokenClick Click { get; set; }

        /// <summary>
        /// Gets or Sets PosNeg
        /// </summary>
        [DataMember(Name = "pos_neg", EmitDefaultValue = false)]
        public QueryResultTokenPosNeg PosNeg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResultToken {\n");
            sb.Append("  Click: ").Append(Click).Append("\n");
            sb.Append("  PosNeg: ").Append(PosNeg).Append("\n");
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
            return this.Equals(input as QueryResultToken);
        }

        /// <summary>
        /// Returns true if QueryResultToken instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryResultToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryResultToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Click == input.Click ||
                    (this.Click != null &&
                    this.Click.Equals(input.Click))
                ) && 
                (
                    this.PosNeg == input.PosNeg ||
                    (this.PosNeg != null &&
                    this.PosNeg.Equals(input.PosNeg))
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
                if (this.Click != null)
                    hashCode = hashCode * 59 + this.Click.GetHashCode();
                if (this.PosNeg != null)
                    hashCode = hashCode * 59 + this.PosNeg.GetHashCode();
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
