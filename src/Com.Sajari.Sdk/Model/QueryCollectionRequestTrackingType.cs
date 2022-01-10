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
    ///  - TYPE_UNSPECIFIED: The default / unset value. The API defaults to &#x60;NONE&#x60; tracking.  - NONE: No tracking.  - CLICK: Click tracking.  A click token is be generated for each result. Results which do not receive clicks fall down the rankings, and similarly low-ranked records which receive clicks are moved up the rankings.  - POS_NEG: Pos/neg tracking.  Pos/neg tokens are generated for each result. Each record in the result set can be marked with pos/neg value for the search. This is then fed back into the ranking algorithm to improve future results. Unlike &#x60;CLICK&#x60;, if no tokens are reported for records then no action is taken.
    /// </summary>
    /// <value> - TYPE_UNSPECIFIED: The default / unset value. The API defaults to &#x60;NONE&#x60; tracking.  - NONE: No tracking.  - CLICK: Click tracking.  A click token is be generated for each result. Results which do not receive clicks fall down the rankings, and similarly low-ranked records which receive clicks are moved up the rankings.  - POS_NEG: Pos/neg tracking.  Pos/neg tokens are generated for each result. Each record in the result set can be marked with pos/neg value for the search. This is then fed back into the ranking algorithm to improve future results. Unlike &#x60;CLICK&#x60;, if no tokens are reported for records then no action is taken.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueryCollectionRequestTrackingType
    {
        /// <summary>
        /// Enum TYPEUNSPECIFIED for value: TYPE_UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPEUNSPECIFIED = 1,

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 2,

        /// <summary>
        /// Enum CLICK for value: CLICK
        /// </summary>
        [EnumMember(Value = "CLICK")]
        CLICK = 3,

        /// <summary>
        /// Enum POSNEG for value: POS_NEG
        /// </summary>
        [EnumMember(Value = "POS_NEG")]
        POSNEG = 4

    }

}
