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
    ///  - TYPE_UNSPECIFIED: Pipeline type not specified.  - RECORD: Record pipeline.  - QUERY: Query pipeline.
    /// </summary>
    /// <value> - TYPE_UNSPECIFIED: Pipeline type not specified.  - RECORD: Record pipeline.  - QUERY: Query pipeline.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PipelineType
    {
        /// <summary>
        /// Enum TYPEUNSPECIFIED for value: TYPE_UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPEUNSPECIFIED = 1,

        /// <summary>
        /// Enum RECORD for value: RECORD
        /// </summary>
        [EnumMember(Value = "RECORD")]
        RECORD = 2,

        /// <summary>
        /// Enum QUERY for value: QUERY
        /// </summary>
        [EnumMember(Value = "QUERY")]
        QUERY = 3

    }

}
