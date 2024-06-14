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
    /// ScannerModuleDefinition
    /// </summary>
    [DataContract(Name = "ScannerModuleDefinition")]
    public partial class ScannerModuleDefinition : IEquatable<ScannerModuleDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerModuleDefinition" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="baseAddress">baseAddress.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="positionId">positionId.</param>
        /// <param name="devices">devices.</param>
        public ScannerModuleDefinition(string id = default(string), string baseAddress = default(string), string name = default(string), string displayName = default(string), string positionId = default(string), List<DeviceDefinition> devices = default(List<DeviceDefinition>))
        {
            this.Id = id;
            this.BaseAddress = baseAddress;
            this.Name = name;
            this.DisplayName = displayName;
            this.PositionId = positionId;
            this.Devices = devices;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets BaseAddress
        /// </summary>
        [DataMember(Name = "baseAddress", EmitDefaultValue = true)]
        public string BaseAddress { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets PositionId
        /// </summary>
        [DataMember(Name = "positionId", EmitDefaultValue = true)]
        public string PositionId { get; set; }

        /// <summary>
        /// Gets or Sets Devices
        /// </summary>
        [DataMember(Name = "devices", EmitDefaultValue = true)]
        public List<DeviceDefinition> Devices { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", EmitDefaultValue = true)]
        public string DeviceId { get; private set; }

        /// <summary>
        /// Returns false as DeviceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeviceId()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScannerModuleDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BaseAddress: ").Append(BaseAddress).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
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
            return this.Equals(input as ScannerModuleDefinition);
        }

        /// <summary>
        /// Returns true if ScannerModuleDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ScannerModuleDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScannerModuleDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BaseAddress == input.BaseAddress ||
                    (this.BaseAddress != null &&
                    this.BaseAddress.Equals(input.BaseAddress))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.PositionId == input.PositionId ||
                    (this.PositionId != null &&
                    this.PositionId.Equals(input.PositionId))
                ) && 
                (
                    this.Devices == input.Devices ||
                    this.Devices != null &&
                    input.Devices != null &&
                    this.Devices.SequenceEqual(input.Devices)
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.BaseAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BaseAddress.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.PositionId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionId.GetHashCode();
                }
                if (this.Devices != null)
                {
                    hashCode = (hashCode * 59) + this.Devices.GetHashCode();
                }
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
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
