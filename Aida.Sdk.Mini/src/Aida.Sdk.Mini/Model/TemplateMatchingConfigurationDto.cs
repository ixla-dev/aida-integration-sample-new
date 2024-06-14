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
    /// TemplateMatchingConfigurationDto
    /// </summary>
    [DataContract(Name = "TemplateMatchingConfigurationDto")]
    public partial class TemplateMatchingConfigurationDto : IEquatable<TemplateMatchingConfigurationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateMatchingConfigurationDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="description">description.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="warpPerspective">warpPerspective.</param>
        /// <param name="scannerId">scannerId.</param>
        /// <param name="cameraId">cameraId.</param>
        /// <param name="acquisitionPresetName">acquisitionPresetName.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="searchArea">searchArea.</param>
        /// <param name="templateArea">templateArea.</param>
        /// <param name="searchPatternImage">searchPatternImage.</param>
        /// <param name="debugUrl">debugUrl.</param>
        /// <param name="scannerModule">scannerModule.</param>
        public TemplateMatchingConfigurationDto(int id = default(int), string name = default(string), string displayName = default(string), string description = default(string), double threshold = default(double), bool warpPerspective = default(bool), string scannerId = default(string), string cameraId = default(string), string acquisitionPresetName = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), RectangleDto searchArea = default(RectangleDto), RectangleDto templateArea = default(RectangleDto), ApplicationImageDto searchPatternImage = default(ApplicationImageDto), string debugUrl = default(string), ScannerModuleDefinition scannerModule = default(ScannerModuleDefinition))
        {
            this.Id = id;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.Threshold = threshold;
            this.WarpPerspective = warpPerspective;
            this.ScannerId = scannerId;
            this.CameraId = cameraId;
            this.AcquisitionPresetName = acquisitionPresetName;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SearchArea = searchArea;
            this.TemplateArea = templateArea;
            this.SearchPatternImage = searchPatternImage;
            this.DebugUrl = debugUrl;
            this.ScannerModule = scannerModule;
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
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name = "threshold", EmitDefaultValue = false)]
        public double Threshold { get; set; }

        /// <summary>
        /// Gets or Sets WarpPerspective
        /// </summary>
        [DataMember(Name = "warpPerspective", EmitDefaultValue = true)]
        public bool WarpPerspective { get; set; }

        /// <summary>
        /// Gets or Sets ScannerId
        /// </summary>
        [DataMember(Name = "scannerId", EmitDefaultValue = true)]
        public string ScannerId { get; set; }

        /// <summary>
        /// Gets or Sets CameraId
        /// </summary>
        [DataMember(Name = "cameraId", EmitDefaultValue = true)]
        public string CameraId { get; set; }

        /// <summary>
        /// Gets or Sets AcquisitionPresetName
        /// </summary>
        [DataMember(Name = "acquisitionPresetName", EmitDefaultValue = true)]
        public string AcquisitionPresetName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets SearchArea
        /// </summary>
        [DataMember(Name = "searchArea", EmitDefaultValue = false)]
        public RectangleDto SearchArea { get; set; }

        /// <summary>
        /// Gets or Sets TemplateArea
        /// </summary>
        [DataMember(Name = "templateArea", EmitDefaultValue = false)]
        public RectangleDto TemplateArea { get; set; }

        /// <summary>
        /// Gets or Sets SearchPatternImage
        /// </summary>
        [DataMember(Name = "searchPatternImage", EmitDefaultValue = false)]
        public ApplicationImageDto SearchPatternImage { get; set; }

        /// <summary>
        /// Gets or Sets IsConfigured
        /// </summary>
        [DataMember(Name = "isConfigured", EmitDefaultValue = true)]
        public bool IsConfigured { get; private set; }

        /// <summary>
        /// Returns false as IsConfigured should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsConfigured()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DebugUrl
        /// </summary>
        [DataMember(Name = "debugUrl", EmitDefaultValue = true)]
        public string DebugUrl { get; set; }

        /// <summary>
        /// Gets or Sets ScannerModule
        /// </summary>
        [DataMember(Name = "scannerModule", EmitDefaultValue = false)]
        public ScannerModuleDefinition ScannerModule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateMatchingConfigurationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  WarpPerspective: ").Append(WarpPerspective).Append("\n");
            sb.Append("  ScannerId: ").Append(ScannerId).Append("\n");
            sb.Append("  CameraId: ").Append(CameraId).Append("\n");
            sb.Append("  AcquisitionPresetName: ").Append(AcquisitionPresetName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  SearchArea: ").Append(SearchArea).Append("\n");
            sb.Append("  TemplateArea: ").Append(TemplateArea).Append("\n");
            sb.Append("  SearchPatternImage: ").Append(SearchPatternImage).Append("\n");
            sb.Append("  IsConfigured: ").Append(IsConfigured).Append("\n");
            sb.Append("  DebugUrl: ").Append(DebugUrl).Append("\n");
            sb.Append("  ScannerModule: ").Append(ScannerModule).Append("\n");
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
            return this.Equals(input as TemplateMatchingConfigurationDto);
        }

        /// <summary>
        /// Returns true if TemplateMatchingConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateMatchingConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateMatchingConfigurationDto input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    this.Threshold.Equals(input.Threshold)
                ) && 
                (
                    this.WarpPerspective == input.WarpPerspective ||
                    this.WarpPerspective.Equals(input.WarpPerspective)
                ) && 
                (
                    this.ScannerId == input.ScannerId ||
                    (this.ScannerId != null &&
                    this.ScannerId.Equals(input.ScannerId))
                ) && 
                (
                    this.CameraId == input.CameraId ||
                    (this.CameraId != null &&
                    this.CameraId.Equals(input.CameraId))
                ) && 
                (
                    this.AcquisitionPresetName == input.AcquisitionPresetName ||
                    (this.AcquisitionPresetName != null &&
                    this.AcquisitionPresetName.Equals(input.AcquisitionPresetName))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.SearchArea == input.SearchArea ||
                    (this.SearchArea != null &&
                    this.SearchArea.Equals(input.SearchArea))
                ) && 
                (
                    this.TemplateArea == input.TemplateArea ||
                    (this.TemplateArea != null &&
                    this.TemplateArea.Equals(input.TemplateArea))
                ) && 
                (
                    this.SearchPatternImage == input.SearchPatternImage ||
                    (this.SearchPatternImage != null &&
                    this.SearchPatternImage.Equals(input.SearchPatternImage))
                ) && 
                (
                    this.IsConfigured == input.IsConfigured ||
                    this.IsConfigured.Equals(input.IsConfigured)
                ) && 
                (
                    this.DebugUrl == input.DebugUrl ||
                    (this.DebugUrl != null &&
                    this.DebugUrl.Equals(input.DebugUrl))
                ) && 
                (
                    this.ScannerModule == input.ScannerModule ||
                    (this.ScannerModule != null &&
                    this.ScannerModule.Equals(input.ScannerModule))
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
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Threshold.GetHashCode();
                hashCode = (hashCode * 59) + this.WarpPerspective.GetHashCode();
                if (this.ScannerId != null)
                {
                    hashCode = (hashCode * 59) + this.ScannerId.GetHashCode();
                }
                if (this.CameraId != null)
                {
                    hashCode = (hashCode * 59) + this.CameraId.GetHashCode();
                }
                if (this.AcquisitionPresetName != null)
                {
                    hashCode = (hashCode * 59) + this.AcquisitionPresetName.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.SearchArea != null)
                {
                    hashCode = (hashCode * 59) + this.SearchArea.GetHashCode();
                }
                if (this.TemplateArea != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateArea.GetHashCode();
                }
                if (this.SearchPatternImage != null)
                {
                    hashCode = (hashCode * 59) + this.SearchPatternImage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsConfigured.GetHashCode();
                if (this.DebugUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DebugUrl.GetHashCode();
                }
                if (this.ScannerModule != null)
                {
                    hashCode = (hashCode * 59) + this.ScannerModule.GetHashCode();
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
