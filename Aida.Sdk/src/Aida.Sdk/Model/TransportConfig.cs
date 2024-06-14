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
    /// TransportConfig
    /// </summary>
    [DataContract(Name = "TransportConfig")]
    public partial class TransportConfig : IEquatable<TransportConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportConfig" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="serialPorts">serialPorts.</param>
        /// <param name="xliType">xliType.</param>
        /// <param name="feeders">feeders.</param>
        public TransportConfig(string type = default(string), List<string> serialPorts = default(List<string>), string xliType = default(string), List<string> feeders = default(List<string>))
        {
            this.Type = type;
            this.SerialPorts = serialPorts;
            this.XliType = xliType;
            this.Feeders = feeders;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SerialPorts
        /// </summary>
        [DataMember(Name = "serialPorts", EmitDefaultValue = true)]
        public List<string> SerialPorts { get; set; }

        /// <summary>
        /// Gets or Sets XliType
        /// </summary>
        [DataMember(Name = "xliType", EmitDefaultValue = true)]
        public string XliType { get; set; }

        /// <summary>
        /// Gets or Sets Feeders
        /// </summary>
        [DataMember(Name = "feeders", EmitDefaultValue = true)]
        public List<string> Feeders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransportConfig {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SerialPorts: ").Append(SerialPorts).Append("\n");
            sb.Append("  XliType: ").Append(XliType).Append("\n");
            sb.Append("  Feeders: ").Append(Feeders).Append("\n");
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
            return this.Equals(input as TransportConfig);
        }

        /// <summary>
        /// Returns true if TransportConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SerialPorts == input.SerialPorts ||
                    this.SerialPorts != null &&
                    input.SerialPorts != null &&
                    this.SerialPorts.SequenceEqual(input.SerialPorts)
                ) && 
                (
                    this.XliType == input.XliType ||
                    (this.XliType != null &&
                    this.XliType.Equals(input.XliType))
                ) && 
                (
                    this.Feeders == input.Feeders ||
                    this.Feeders != null &&
                    input.Feeders != null &&
                    this.Feeders.SequenceEqual(input.Feeders)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.SerialPorts != null)
                {
                    hashCode = (hashCode * 59) + this.SerialPorts.GetHashCode();
                }
                if (this.XliType != null)
                {
                    hashCode = (hashCode * 59) + this.XliType.GetHashCode();
                }
                if (this.Feeders != null)
                {
                    hashCode = (hashCode * 59) + this.Feeders.GetHashCode();
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
