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
    ///  - VIEW_UNSPECIFIED: The default / unset value. The API defaults to the &#x60;BASIC&#x60; view.  - BASIC: Include basic information including type, name, version and description but not the full step configuration. This is the default value (for both [ListPipelines](/api#operation/ListPipelines) and [GetPipeline](/api#operation/GetPipeline)).  - FULL: Include the information from &#x60;BASIC&#x60;, plus full step configuration.
    /// </summary>
    /// <value> - VIEW_UNSPECIFIED: The default / unset value. The API defaults to the &#x60;BASIC&#x60; view.  - BASIC: Include basic information including type, name, version and description but not the full step configuration. This is the default value (for both [ListPipelines](/api#operation/ListPipelines) and [GetPipeline](/api#operation/GetPipeline)).  - FULL: Include the information from &#x60;BASIC&#x60;, plus full step configuration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum GetDefaultVersionRequestView
    {
        /// <summary>
        /// Enum VIEWUNSPECIFIED for value: VIEW_UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "VIEW_UNSPECIFIED")]
        VIEWUNSPECIFIED = 1,

        /// <summary>
        /// Enum BASIC for value: BASIC
        /// </summary>
        [EnumMember(Value = "BASIC")]
        BASIC = 2,

        /// <summary>
        /// Enum FULL for value: FULL
        /// </summary>
        [EnumMember(Value = "FULL")]
        FULL = 3

    }

}
