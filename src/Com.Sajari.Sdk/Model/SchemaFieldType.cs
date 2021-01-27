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
    /// Type represents the underlying data type of the field.   - TYPE_UNSPECIFIED: Type not specified.  - STRING: String values.  - INTEGER: Integer values (64-bit).  - FLOAT: Floating point values (32-bit).  - DOUBLE: Double floating point values (64-bit).  - BOOLEAN: Boolean values.  - TIMESTAMP: Timestamp values.
    /// </summary>
    /// <value>Type represents the underlying data type of the field.   - TYPE_UNSPECIFIED: Type not specified.  - STRING: String values.  - INTEGER: Integer values (64-bit).  - FLOAT: Floating point values (32-bit).  - DOUBLE: Double floating point values (64-bit).  - BOOLEAN: Boolean values.  - TIMESTAMP: Timestamp values.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SchemaFieldType
    {
        /// <summary>
        /// Enum TYPEUNSPECIFIED for value: TYPE_UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPEUNSPECIFIED = 1,

        /// <summary>
        /// Enum STRING for value: STRING
        /// </summary>
        [EnumMember(Value = "STRING")]
        STRING = 2,

        /// <summary>
        /// Enum INTEGER for value: INTEGER
        /// </summary>
        [EnumMember(Value = "INTEGER")]
        INTEGER = 3,

        /// <summary>
        /// Enum FLOAT for value: FLOAT
        /// </summary>
        [EnumMember(Value = "FLOAT")]
        FLOAT = 4,

        /// <summary>
        /// Enum DOUBLE for value: DOUBLE
        /// </summary>
        [EnumMember(Value = "DOUBLE")]
        DOUBLE = 5,

        /// <summary>
        /// Enum BOOLEAN for value: BOOLEAN
        /// </summary>
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN = 6,

        /// <summary>
        /// Enum TIMESTAMP for value: TIMESTAMP
        /// </summary>
        [EnumMember(Value = "TIMESTAMP")]
        TIMESTAMP = 7

    }

}
