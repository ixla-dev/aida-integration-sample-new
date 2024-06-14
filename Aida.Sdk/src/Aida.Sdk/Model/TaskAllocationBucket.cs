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
    /// TaskAllocationBucket
    /// </summary>
    [DataContract(Name = "TaskAllocationBucket")]
    public partial class TaskAllocationBucket : IEquatable<TaskAllocationBucket>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAllocationBucket" /> class.
        /// </summary>
        /// <param name="scannerId">scannerId.</param>
        /// <param name="supportSide">supportSide.</param>
        public TaskAllocationBucket(string scannerId = default(string), string supportSide = default(string))
        {
            this.ScannerId = scannerId;
            this.SupportSide = supportSide;
        }

        /// <summary>
        /// Gets or Sets ScannerId
        /// </summary>
        [DataMember(Name = "scannerId", EmitDefaultValue = true)]
        public string ScannerId { get; set; }

        /// <summary>
        /// Gets or Sets SupportSide
        /// </summary>
        [DataMember(Name = "supportSide", EmitDefaultValue = true)]
        public string SupportSide { get; set; }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name = "tasks", EmitDefaultValue = true)]
        public List<TaskDescriptor> Tasks { get; private set; }

        /// <summary>
        /// Returns false as Tasks should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTasks()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TotalMilliseconds
        /// </summary>
        [DataMember(Name = "totalMilliseconds", EmitDefaultValue = false)]
        public double TotalMilliseconds { get; private set; }

        /// <summary>
        /// Returns false as TotalMilliseconds should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalMilliseconds()
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
            sb.Append("class TaskAllocationBucket {\n");
            sb.Append("  ScannerId: ").Append(ScannerId).Append("\n");
            sb.Append("  SupportSide: ").Append(SupportSide).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  TotalMilliseconds: ").Append(TotalMilliseconds).Append("\n");
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
            return this.Equals(input as TaskAllocationBucket);
        }

        /// <summary>
        /// Returns true if TaskAllocationBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskAllocationBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskAllocationBucket input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ScannerId == input.ScannerId ||
                    (this.ScannerId != null &&
                    this.ScannerId.Equals(input.ScannerId))
                ) && 
                (
                    this.SupportSide == input.SupportSide ||
                    (this.SupportSide != null &&
                    this.SupportSide.Equals(input.SupportSide))
                ) && 
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    input.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
                ) && 
                (
                    this.TotalMilliseconds == input.TotalMilliseconds ||
                    this.TotalMilliseconds.Equals(input.TotalMilliseconds)
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
                if (this.ScannerId != null)
                {
                    hashCode = (hashCode * 59) + this.ScannerId.GetHashCode();
                }
                if (this.SupportSide != null)
                {
                    hashCode = (hashCode * 59) + this.SupportSide.GetHashCode();
                }
                if (this.Tasks != null)
                {
                    hashCode = (hashCode * 59) + this.Tasks.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalMilliseconds.GetHashCode();
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
