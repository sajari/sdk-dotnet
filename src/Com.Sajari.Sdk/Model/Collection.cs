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
    /// Collection
    /// </summary>
    [DataContract(Name = "Collection")]
    public partial class Collection : IEquatable<Collection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Collection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Collection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Collection" /> class.
        /// </summary>
        /// <param name="displayName">The collection&#39;s display name. You can change this at any time. (required).</param>
        /// <param name="authorizedQueryDomains">The list of authorized query domains for the collection.  Client-side / browser requests to the [QueryCollection](/api#operation/QueryCollection) call can be made by any authorized query domain or any of its subdomains. This allows your interface to make search requests without having to provide an API key in the client-side request..</param>
        public Collection(string displayName = default(string), List<string> authorizedQueryDomains = default(List<string>))
        {
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for Collection and cannot be null");
            this.AuthorizedQueryDomains = authorizedQueryDomains;
        }

        /// <summary>
        /// Output only. The collection&#39;s ID.
        /// </summary>
        /// <value>Output only. The collection&#39;s ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }

        /// <summary>
        /// Output only. The ID of the account that owns this collection.
        /// </summary>
        /// <value>Output only. The ID of the account that owns this collection.</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; private set; }

        /// <summary>
        /// Returns false as AccountId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountId()
        {
            return false;
        }

        /// <summary>
        /// Output only. Creation time of the collection.
        /// </summary>
        /// <value>Output only. Creation time of the collection.</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public DateTime CreateTime { get; private set; }

        /// <summary>
        /// Returns false as CreateTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreateTime()
        {
            return false;
        }

        /// <summary>
        /// The collection&#39;s display name. You can change this at any time.
        /// </summary>
        /// <value>The collection&#39;s display name. You can change this at any time.</value>
        [DataMember(Name = "display_name", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The list of authorized query domains for the collection.  Client-side / browser requests to the [QueryCollection](/api#operation/QueryCollection) call can be made by any authorized query domain or any of its subdomains. This allows your interface to make search requests without having to provide an API key in the client-side request.
        /// </summary>
        /// <value>The list of authorized query domains for the collection.  Client-side / browser requests to the [QueryCollection](/api#operation/QueryCollection) call can be made by any authorized query domain or any of its subdomains. This allows your interface to make search requests without having to provide an API key in the client-side request.</value>
        [DataMember(Name = "authorized_query_domains", EmitDefaultValue = false)]
        public List<string> AuthorizedQueryDomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Collection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  AuthorizedQueryDomains: ").Append(AuthorizedQueryDomains).Append("\n");
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
            return this.Equals(input as Collection);
        }

        /// <summary>
        /// Returns true if Collection instances are equal
        /// </summary>
        /// <param name="input">Instance of Collection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Collection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.AuthorizedQueryDomains == input.AuthorizedQueryDomains ||
                    this.AuthorizedQueryDomains != null &&
                    input.AuthorizedQueryDomains != null &&
                    this.AuthorizedQueryDomains.SequenceEqual(input.AuthorizedQueryDomains)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.AuthorizedQueryDomains != null)
                    hashCode = hashCode * 59 + this.AuthorizedQueryDomains.GetHashCode();
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