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
    /// Mode is an enumeration of modes for a field.   - MODE_UNSPECIFIED: Mode not specified.  - NULLABLE: Nullable fields do not need to be specified.  - REQUIRED: Required fields must be specified and cannot be null.  - UNIQUE: Unique fields must be specified and must be unique.
    /// </summary>
    /// <value>Mode is an enumeration of modes for a field.   - MODE_UNSPECIFIED: Mode not specified.  - NULLABLE: Nullable fields do not need to be specified.  - REQUIRED: Required fields must be specified and cannot be null.  - UNIQUE: Unique fields must be specified and must be unique.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SchemaFieldMode
    {
        /// <summary>
        /// Enum MODEUNSPECIFIED for value: MODE_UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "MODE_UNSPECIFIED")]
        MODEUNSPECIFIED = 1,

        /// <summary>
        /// Enum NULLABLE for value: NULLABLE
        /// </summary>
        [EnumMember(Value = "NULLABLE")]
        NULLABLE = 2,

        /// <summary>
        /// Enum REQUIRED for value: REQUIRED
        /// </summary>
        [EnumMember(Value = "REQUIRED")]
        REQUIRED = 3,

        /// <summary>
        /// Enum UNIQUE for value: UNIQUE
        /// </summary>
        [EnumMember(Value = "UNIQUE")]
        UNIQUE = 4

    }

}
