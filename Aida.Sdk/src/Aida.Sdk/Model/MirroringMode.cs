/*
 * aida
 *
 * 1.0.385
 *
 * The version of the OpenAPI document: 1.0.385
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines MirroringMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MirroringMode
    {
        /// <summary>
        /// Enum Off for value: Off
        /// </summary>
        [EnumMember(Value = "Off")]
        Off = 1,

        /// <summary>
        /// Enum InvertY for value: InvertY
        /// </summary>
        [EnumMember(Value = "InvertY")]
        InvertY = 2,

        /// <summary>
        /// Enum InvertX for value: InvertX
        /// </summary>
        [EnumMember(Value = "InvertX")]
        InvertX = 3,

        /// <summary>
        /// Enum Both for value: Both
        /// </summary>
        [EnumMember(Value = "Both")]
        Both = 4

    }

}
