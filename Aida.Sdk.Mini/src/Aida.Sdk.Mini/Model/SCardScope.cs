/*
 * aida-mini
 *
 * 1.0.543
 *
 * The version of the OpenAPI document: 1.0.543
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
using FileParameter = Aida.Sdk.Mini.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Mini.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Mini.Model
{
    /// <summary>
    /// Defines SCardScope
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SCardScope
    {
        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User = 1,

        /// <summary>
        /// Enum Terminal for value: Terminal
        /// </summary>
        [EnumMember(Value = "Terminal")]
        Terminal = 2,

        /// <summary>
        /// Enum System for value: System
        /// </summary>
        [EnumMember(Value = "System")]
        System = 3,

        /// <summary>
        /// Enum Global for value: Global
        /// </summary>
        [EnumMember(Value = "Global")]
        Global = 4

    }

}
