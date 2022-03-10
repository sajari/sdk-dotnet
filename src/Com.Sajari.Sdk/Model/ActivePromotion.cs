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
    /// A promotion that is active for a given search.
    /// </summary>
    [DataContract(Name = "ActivePromotion")]
    public partial class ActivePromotion : IEquatable<ActivePromotion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivePromotion" /> class.
        /// </summary>
        /// <param name="activeExclusions">The records that are excluded from the result set by the active promotion..</param>
        /// <param name="activePins">The pins that belong to the active promotion. Note that the positions in these pins are the positions specified at pin creation time, which is not necessarily the position that a pin ends up in. For example, if a pin is created at position 2, but the query that the pin is active in has zero results, the pinned result actually appears in position 1..</param>
        /// <param name="promotionId">The ID of the active promotion..</param>
        public ActivePromotion(List<PromotionExclusion> activeExclusions = default(List<PromotionExclusion>), List<PromotionPin> activePins = default(List<PromotionPin>), string promotionId = default(string))
        {
            this.ActiveExclusions = activeExclusions;
            this.ActivePins = activePins;
            this.PromotionId = promotionId;
        }

        /// <summary>
        /// The records that are excluded from the result set by the active promotion.
        /// </summary>
        /// <value>The records that are excluded from the result set by the active promotion.</value>
        [DataMember(Name = "active_exclusions", EmitDefaultValue = false)]
        public List<PromotionExclusion> ActiveExclusions { get; set; }

        /// <summary>
        /// The pins that belong to the active promotion. Note that the positions in these pins are the positions specified at pin creation time, which is not necessarily the position that a pin ends up in. For example, if a pin is created at position 2, but the query that the pin is active in has zero results, the pinned result actually appears in position 1.
        /// </summary>
        /// <value>The pins that belong to the active promotion. Note that the positions in these pins are the positions specified at pin creation time, which is not necessarily the position that a pin ends up in. For example, if a pin is created at position 2, but the query that the pin is active in has zero results, the pinned result actually appears in position 1.</value>
        [DataMember(Name = "active_pins", EmitDefaultValue = false)]
        public List<PromotionPin> ActivePins { get; set; }

        /// <summary>
        /// The ID of the active promotion.
        /// </summary>
        /// <value>The ID of the active promotion.</value>
        [DataMember(Name = "promotion_id", EmitDefaultValue = false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivePromotion {\n");
            sb.Append("  ActiveExclusions: ").Append(ActiveExclusions).Append("\n");
            sb.Append("  ActivePins: ").Append(ActivePins).Append("\n");
            sb.Append("  PromotionId: ").Append(PromotionId).Append("\n");
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
            return this.Equals(input as ActivePromotion);
        }

        /// <summary>
        /// Returns true if ActivePromotion instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivePromotion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivePromotion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActiveExclusions == input.ActiveExclusions ||
                    this.ActiveExclusions != null &&
                    input.ActiveExclusions != null &&
                    this.ActiveExclusions.SequenceEqual(input.ActiveExclusions)
                ) && 
                (
                    this.ActivePins == input.ActivePins ||
                    this.ActivePins != null &&
                    input.ActivePins != null &&
                    this.ActivePins.SequenceEqual(input.ActivePins)
                ) && 
                (
                    this.PromotionId == input.PromotionId ||
                    (this.PromotionId != null &&
                    this.PromotionId.Equals(input.PromotionId))
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
                if (this.ActiveExclusions != null)
                {
                    hashCode = (hashCode * 59) + this.ActiveExclusions.GetHashCode();
                }
                if (this.ActivePins != null)
                {
                    hashCode = (hashCode * 59) + this.ActivePins.GetHashCode();
                }
                if (this.PromotionId != null)
                {
                    hashCode = (hashCode * 59) + this.PromotionId.GetHashCode();
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
