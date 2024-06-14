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
    /// NameValidationResultDto
    /// </summary>
    [DataContract(Name = "NameValidationResultDto")]
    public partial class NameValidationResultDto : IEquatable<NameValidationResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameValidationResultDto" /> class.
        /// </summary>
        /// <param name="input">input.</param>
        /// <param name="valid">valid.</param>
        /// <param name="suggested">suggested.</param>
        /// <param name="errors">errors.</param>
        public NameValidationResultDto(string input = default(string), bool valid = default(bool), string suggested = default(string), List<NameValidationErrorReason> errors = default(List<NameValidationErrorReason>))
        {
            this.Input = input;
            this.Valid = valid;
            this.Suggested = suggested;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", EmitDefaultValue = true)]
        public string Input { get; set; }

        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name = "valid", EmitDefaultValue = true)]
        public bool Valid { get; set; }

        /// <summary>
        /// Gets or Sets Suggested
        /// </summary>
        [DataMember(Name = "suggested", EmitDefaultValue = true)]
        public string Suggested { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = true)]
        public List<NameValidationErrorReason> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NameValidationResultDto {\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Suggested: ").Append(Suggested).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NameValidationResultDto);
        }

        /// <summary>
        /// Returns true if NameValidationResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of NameValidationResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NameValidationResultDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Valid == input.Valid ||
                    this.Valid.Equals(input.Valid)
                ) && 
                (
                    this.Suggested == input.Suggested ||
                    (this.Suggested != null &&
                    this.Suggested.Equals(input.Suggested))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Input != null)
                {
                    hashCode = (hashCode * 59) + this.Input.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Valid.GetHashCode();
                if (this.Suggested != null)
                {
                    hashCode = (hashCode * 59) + this.Suggested.GetHashCode();
                }
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
