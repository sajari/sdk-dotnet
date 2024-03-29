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
    /// An analytics event that relates to a query made on a collection.
    /// </summary>
    [DataContract(Name = "Event")]
    public partial class Event : IEquatable<Event>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="bannerId">The identifier of the promotion banner the event is about..</param>
        /// <param name="metadata">An object made up of field-value pairs that contains additional metadata to record with the event..</param>
        /// <param name="queryId">The query identifier. (required).</param>
        /// <param name="redirectId">The identifier of the redirect the event is about..</param>
        /// <param name="resultId">The identifier of the result the event is about..</param>
        /// <param name="type">The type of event, e.g. &#x60;click&#x60;, &#x60;redirect&#x60;, &#x60;purchase&#x60;, &#x60;add_to_cart&#x60;. (required).</param>
        public Event(string bannerId = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string queryId = default(string), string redirectId = default(string), string resultId = default(string), string type = default(string))
        {
            // to ensure "queryId" is required (not null)
            if (queryId == null) {
                throw new ArgumentNullException("queryId is a required property for Event and cannot be null");
            }
            this.QueryId = queryId;
            // to ensure "type" is required (not null)
            if (type == null) {
                throw new ArgumentNullException("type is a required property for Event and cannot be null");
            }
            this.Type = type;
            this.BannerId = bannerId;
            this.Metadata = metadata;
            this.RedirectId = redirectId;
            this.ResultId = resultId;
        }

        /// <summary>
        /// The identifier of the promotion banner the event is about.
        /// </summary>
        /// <value>The identifier of the promotion banner the event is about.</value>
        [DataMember(Name = "banner_id", EmitDefaultValue = false)]
        public string BannerId { get; set; }

        /// <summary>
        /// An object made up of field-value pairs that contains additional metadata to record with the event.
        /// </summary>
        /// <value>An object made up of field-value pairs that contains additional metadata to record with the event.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// The query identifier.
        /// </summary>
        /// <value>The query identifier.</value>
        [DataMember(Name = "query_id", IsRequired = true, EmitDefaultValue = false)]
        public string QueryId { get; set; }

        /// <summary>
        /// The identifier of the redirect the event is about.
        /// </summary>
        /// <value>The identifier of the redirect the event is about.</value>
        [DataMember(Name = "redirect_id", EmitDefaultValue = false)]
        public string RedirectId { get; set; }

        /// <summary>
        /// The identifier of the result the event is about.
        /// </summary>
        /// <value>The identifier of the result the event is about.</value>
        [DataMember(Name = "result_id", EmitDefaultValue = false)]
        public string ResultId { get; set; }

        /// <summary>
        /// The type of event, e.g. &#x60;click&#x60;, &#x60;redirect&#x60;, &#x60;purchase&#x60;, &#x60;add_to_cart&#x60;.
        /// </summary>
        /// <value>The type of event, e.g. &#x60;click&#x60;, &#x60;redirect&#x60;, &#x60;purchase&#x60;, &#x60;add_to_cart&#x60;.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  BannerId: ").Append(BannerId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  QueryId: ").Append(QueryId).Append("\n");
            sb.Append("  RedirectId: ").Append(RedirectId).Append("\n");
            sb.Append("  ResultId: ").Append(ResultId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Event);
        }

        /// <summary>
        /// Returns true if Event instances are equal
        /// </summary>
        /// <param name="input">Instance of Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Event input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.QueryId == input.QueryId ||
                    (this.QueryId != null &&
                    this.QueryId.Equals(input.QueryId))
                ) && 
                (
                    this.RedirectId == input.RedirectId ||
                    (this.RedirectId != null &&
                    this.RedirectId.Equals(input.RedirectId))
                ) && 
                (
                    this.ResultId == input.ResultId ||
                    (this.ResultId != null &&
                    this.ResultId.Equals(input.ResultId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.BannerId != null)
                {
                    hashCode = (hashCode * 59) + this.BannerId.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.QueryId != null)
                {
                    hashCode = (hashCode * 59) + this.QueryId.GetHashCode();
                }
                if (this.RedirectId != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectId.GetHashCode();
                }
                if (this.ResultId != null)
                {
                    hashCode = (hashCode * 59) + this.ResultId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
