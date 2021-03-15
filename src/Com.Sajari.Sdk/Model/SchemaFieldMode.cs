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