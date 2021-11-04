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
    /// BatchUpsertRecordsResponseKey
    /// </summary>
    [DataContract(Name = "BatchUpsertRecordsResponseKey")]
    public partial class BatchUpsertRecordsResponseKey : IEquatable<BatchUpsertRecordsResponseKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUpsertRecordsResponseKey" /> class.
        /// </summary>
        /// <param name="index">Index of the record in &#x60;records&#x60; that this key corresponds to..</param>
        /// <param name="key">key.</param>
        public BatchUpsertRecordsResponseKey(int index = default(int), RecordKey key = default(RecordKey))
        {
            this.Index = index;
            this.Key = key;
        }

        /// <summary>
        /// Index of the record in &#x60;records&#x60; that this key corresponds to.
        /// </summary>
        /// <value>Index of the record in &#x60;records&#x60; that this key corresponds to.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public RecordKey Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpsertRecordsResponseKey {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as BatchUpsertRecordsResponseKey);
        }

        /// <summary>
        /// Returns true if BatchUpsertRecordsResponseKey instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchUpsertRecordsResponseKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchUpsertRecordsResponseKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
