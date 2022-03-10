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
    /// TextPosition describes the position of text in a box.   - TEXT_POSITION_UNSPECIFIED: No position specified.  - TEXT_POSITION_CENTER: The text is positioned in the horizontal and vertical center.  - TEXT_POSITION_TOP_LEFT: The text is positioned in the top left corner.  - TEXT_POSITION_TOP_RIGHT: The text is positioned in the top right corner.  - TEXT_POSITION_BOTTOM_LEFT: The text is positioned in the bottom left corner.  - TEXT_POSITION_BOTTOM_RIGHT: The text is positioned in the bottom right corner.
    /// </summary>
    /// <value>TextPosition describes the position of text in a box.   - TEXT_POSITION_UNSPECIFIED: No position specified.  - TEXT_POSITION_CENTER: The text is positioned in the horizontal and vertical center.  - TEXT_POSITION_TOP_LEFT: The text is positioned in the top left corner.  - TEXT_POSITION_TOP_RIGHT: The text is positioned in the top right corner.  - TEXT_POSITION_BOTTOM_LEFT: The text is positioned in the bottom left corner.  - TEXT_POSITION_BOTTOM_RIGHT: The text is positioned in the bottom right corner.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextPosition
    {
        /// <summary>
        /// Enum UNSPECIFIED for value: TEXT_POSITION_UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "TEXT_POSITION_UNSPECIFIED")]
        UNSPECIFIED = 1,

        /// <summary>
        /// Enum CENTER for value: TEXT_POSITION_CENTER
        /// </summary>
        [EnumMember(Value = "TEXT_POSITION_CENTER")]
        CENTER = 2,

        /// <summary>
        /// Enum TOPLEFT for value: TEXT_POSITION_TOP_LEFT
        /// </summary>
        [EnumMember(Value = "TEXT_POSITION_TOP_LEFT")]
        TOPLEFT = 3,

        /// <summary>
        /// Enum TOPRIGHT for value: TEXT_POSITION_TOP_RIGHT
        /// </summary>
        [EnumMember(Value = "TEXT_POSITION_TOP_RIGHT")]
        TOPRIGHT = 4,

        /// <summary>
        /// Enum BOTTOMLEFT for value: TEXT_POSITION_BOTTOM_LEFT
        /// </summary>
        [EnumMember(Value = "TEXT_POSITION_BOTTOM_LEFT")]
        BOTTOMLEFT = 5,

        /// <summary>
        /// Enum BOTTOMRIGHT for value: TEXT_POSITION_BOTTOM_RIGHT
        /// </summary>
        [EnumMember(Value = "TEXT_POSITION_BOTTOM_RIGHT")]
        BOTTOMRIGHT = 6

    }

}