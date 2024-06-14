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
    /// PenDto
    /// </summary>
    [DataContract(Name = "PenDto")]
    public partial class PenDto : IEquatable<PenDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PenDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="laserPower">laserPower.</param>
        /// <param name="markSpeed">markSpeed.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="pulseLenght">pulseLenght.</param>
        /// <param name="firstPulseLength">firstPulseLength.</param>
        /// <param name="halfPeriod">halfPeriod.</param>
        /// <param name="longDelay">longDelay.</param>
        /// <param name="jumpDelay">jumpDelay.</param>
        /// <param name="markDelay">markDelay.</param>
        /// <param name="polyDelay">polyDelay.</param>
        /// <param name="laserOnDelay">laserOnDelay.</param>
        /// <param name="laserOffDelay">laserOffDelay.</param>
        /// <param name="jumpSpeed">jumpSpeed.</param>
        /// <param name="pixelMap">pixelMap.</param>
        /// <param name="flags">flags.</param>
        public PenDto(int id = default(int), string name = default(string), double? laserPower = default(double?), double? markSpeed = default(double?), double? frequency = default(double?), double? pulseLenght = default(double?), double? firstPulseLength = default(double?), double? halfPeriod = default(double?), double? longDelay = default(double?), double? jumpDelay = default(double?), double? markDelay = default(double?), double? polyDelay = default(double?), double? laserOnDelay = default(double?), double? laserOffDelay = default(double?), double? jumpSpeed = default(double?), PixelMapDto pixelMap = default(PixelMapDto), PenFlagsDto flags = default(PenFlagsDto))
        {
            this.Id = id;
            this.Name = name;
            this.LaserPower = laserPower;
            this.MarkSpeed = markSpeed;
            this.Frequency = frequency;
            this.PulseLenght = pulseLenght;
            this.FirstPulseLength = firstPulseLength;
            this.HalfPeriod = halfPeriod;
            this.LongDelay = longDelay;
            this.JumpDelay = jumpDelay;
            this.MarkDelay = markDelay;
            this.PolyDelay = polyDelay;
            this.LaserOnDelay = laserOnDelay;
            this.LaserOffDelay = laserOffDelay;
            this.JumpSpeed = jumpSpeed;
            this.PixelMap = pixelMap;
            this.Flags = flags;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LaserPower
        /// </summary>
        [DataMember(Name = "laserPower", EmitDefaultValue = true)]
        public double? LaserPower { get; set; }

        /// <summary>
        /// Gets or Sets MarkSpeed
        /// </summary>
        [DataMember(Name = "markSpeed", EmitDefaultValue = true)]
        public double? MarkSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", EmitDefaultValue = true)]
        public double? Frequency { get; set; }

        /// <summary>
        /// Gets or Sets PulseLenght
        /// </summary>
        [DataMember(Name = "pulseLenght", EmitDefaultValue = true)]
        public double? PulseLenght { get; set; }

        /// <summary>
        /// Gets or Sets FirstPulseLength
        /// </summary>
        [DataMember(Name = "firstPulseLength", EmitDefaultValue = true)]
        public double? FirstPulseLength { get; set; }

        /// <summary>
        /// Gets or Sets HalfPeriod
        /// </summary>
        [DataMember(Name = "halfPeriod", EmitDefaultValue = true)]
        public double? HalfPeriod { get; set; }

        /// <summary>
        /// Gets or Sets LongDelay
        /// </summary>
        [DataMember(Name = "longDelay", EmitDefaultValue = true)]
        public double? LongDelay { get; set; }

        /// <summary>
        /// Gets or Sets JumpDelay
        /// </summary>
        [DataMember(Name = "jumpDelay", EmitDefaultValue = true)]
        public double? JumpDelay { get; set; }

        /// <summary>
        /// Gets or Sets MarkDelay
        /// </summary>
        [DataMember(Name = "markDelay", EmitDefaultValue = true)]
        public double? MarkDelay { get; set; }

        /// <summary>
        /// Gets or Sets PolyDelay
        /// </summary>
        [DataMember(Name = "polyDelay", EmitDefaultValue = true)]
        public double? PolyDelay { get; set; }

        /// <summary>
        /// Gets or Sets LaserOnDelay
        /// </summary>
        [DataMember(Name = "laserOnDelay", EmitDefaultValue = true)]
        public double? LaserOnDelay { get; set; }

        /// <summary>
        /// Gets or Sets LaserOffDelay
        /// </summary>
        [DataMember(Name = "laserOffDelay", EmitDefaultValue = true)]
        public double? LaserOffDelay { get; set; }

        /// <summary>
        /// Gets or Sets JumpSpeed
        /// </summary>
        [DataMember(Name = "jumpSpeed", EmitDefaultValue = true)]
        public double? JumpSpeed { get; set; }

        /// <summary>
        /// Gets or Sets PixelMap
        /// </summary>
        [DataMember(Name = "pixelMap", EmitDefaultValue = false)]
        public PixelMapDto PixelMap { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public PenFlagsDto Flags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PenDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LaserPower: ").Append(LaserPower).Append("\n");
            sb.Append("  MarkSpeed: ").Append(MarkSpeed).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  PulseLenght: ").Append(PulseLenght).Append("\n");
            sb.Append("  FirstPulseLength: ").Append(FirstPulseLength).Append("\n");
            sb.Append("  HalfPeriod: ").Append(HalfPeriod).Append("\n");
            sb.Append("  LongDelay: ").Append(LongDelay).Append("\n");
            sb.Append("  JumpDelay: ").Append(JumpDelay).Append("\n");
            sb.Append("  MarkDelay: ").Append(MarkDelay).Append("\n");
            sb.Append("  PolyDelay: ").Append(PolyDelay).Append("\n");
            sb.Append("  LaserOnDelay: ").Append(LaserOnDelay).Append("\n");
            sb.Append("  LaserOffDelay: ").Append(LaserOffDelay).Append("\n");
            sb.Append("  JumpSpeed: ").Append(JumpSpeed).Append("\n");
            sb.Append("  PixelMap: ").Append(PixelMap).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
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
            return this.Equals(input as PenDto);
        }

        /// <summary>
        /// Returns true if PenDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PenDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PenDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LaserPower == input.LaserPower ||
                    (this.LaserPower != null &&
                    this.LaserPower.Equals(input.LaserPower))
                ) && 
                (
                    this.MarkSpeed == input.MarkSpeed ||
                    (this.MarkSpeed != null &&
                    this.MarkSpeed.Equals(input.MarkSpeed))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.PulseLenght == input.PulseLenght ||
                    (this.PulseLenght != null &&
                    this.PulseLenght.Equals(input.PulseLenght))
                ) && 
                (
                    this.FirstPulseLength == input.FirstPulseLength ||
                    (this.FirstPulseLength != null &&
                    this.FirstPulseLength.Equals(input.FirstPulseLength))
                ) && 
                (
                    this.HalfPeriod == input.HalfPeriod ||
                    (this.HalfPeriod != null &&
                    this.HalfPeriod.Equals(input.HalfPeriod))
                ) && 
                (
                    this.LongDelay == input.LongDelay ||
                    (this.LongDelay != null &&
                    this.LongDelay.Equals(input.LongDelay))
                ) && 
                (
                    this.JumpDelay == input.JumpDelay ||
                    (this.JumpDelay != null &&
                    this.JumpDelay.Equals(input.JumpDelay))
                ) && 
                (
                    this.MarkDelay == input.MarkDelay ||
                    (this.MarkDelay != null &&
                    this.MarkDelay.Equals(input.MarkDelay))
                ) && 
                (
                    this.PolyDelay == input.PolyDelay ||
                    (this.PolyDelay != null &&
                    this.PolyDelay.Equals(input.PolyDelay))
                ) && 
                (
                    this.LaserOnDelay == input.LaserOnDelay ||
                    (this.LaserOnDelay != null &&
                    this.LaserOnDelay.Equals(input.LaserOnDelay))
                ) && 
                (
                    this.LaserOffDelay == input.LaserOffDelay ||
                    (this.LaserOffDelay != null &&
                    this.LaserOffDelay.Equals(input.LaserOffDelay))
                ) && 
                (
                    this.JumpSpeed == input.JumpSpeed ||
                    (this.JumpSpeed != null &&
                    this.JumpSpeed.Equals(input.JumpSpeed))
                ) && 
                (
                    this.PixelMap == input.PixelMap ||
                    (this.PixelMap != null &&
                    this.PixelMap.Equals(input.PixelMap))
                ) && 
                (
                    this.Flags == input.Flags ||
                    (this.Flags != null &&
                    this.Flags.Equals(input.Flags))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LaserPower != null)
                {
                    hashCode = (hashCode * 59) + this.LaserPower.GetHashCode();
                }
                if (this.MarkSpeed != null)
                {
                    hashCode = (hashCode * 59) + this.MarkSpeed.GetHashCode();
                }
                if (this.Frequency != null)
                {
                    hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                }
                if (this.PulseLenght != null)
                {
                    hashCode = (hashCode * 59) + this.PulseLenght.GetHashCode();
                }
                if (this.FirstPulseLength != null)
                {
                    hashCode = (hashCode * 59) + this.FirstPulseLength.GetHashCode();
                }
                if (this.HalfPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.HalfPeriod.GetHashCode();
                }
                if (this.LongDelay != null)
                {
                    hashCode = (hashCode * 59) + this.LongDelay.GetHashCode();
                }
                if (this.JumpDelay != null)
                {
                    hashCode = (hashCode * 59) + this.JumpDelay.GetHashCode();
                }
                if (this.MarkDelay != null)
                {
                    hashCode = (hashCode * 59) + this.MarkDelay.GetHashCode();
                }
                if (this.PolyDelay != null)
                {
                    hashCode = (hashCode * 59) + this.PolyDelay.GetHashCode();
                }
                if (this.LaserOnDelay != null)
                {
                    hashCode = (hashCode * 59) + this.LaserOnDelay.GetHashCode();
                }
                if (this.LaserOffDelay != null)
                {
                    hashCode = (hashCode * 59) + this.LaserOffDelay.GetHashCode();
                }
                if (this.JumpSpeed != null)
                {
                    hashCode = (hashCode * 59) + this.JumpSpeed.GetHashCode();
                }
                if (this.PixelMap != null)
                {
                    hashCode = (hashCode * 59) + this.PixelMap.GetHashCode();
                }
                if (this.Flags != null)
                {
                    hashCode = (hashCode * 59) + this.Flags.GetHashCode();
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
