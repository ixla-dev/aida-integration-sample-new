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
    /// Defines SCardProtocol
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SCardProtocol
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum T0 for value: T0
        /// </summary>
        [EnumMember(Value = "T0")]
        T0 = 2,

        /// <summary>
        /// Enum T1 for value: T1
        /// </summary>
        [EnumMember(Value = "T1")]
        T1 = 3,

        /// <summary>
        /// Enum Any for value: Any
        /// </summary>
        [EnumMember(Value = "Any")]
        Any = 4,

        /// <summary>
        /// Enum Default for value: Default
        /// </summary>
        [EnumMember(Value = "Default")]
        Default = 5

    }

}