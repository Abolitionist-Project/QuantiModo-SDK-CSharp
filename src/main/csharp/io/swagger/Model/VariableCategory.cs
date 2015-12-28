using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class VariableCategory : IEquatable<VariableCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableCategory" /> class.
        /// </summary>
        public VariableCategory()
        {
            
        }

        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Name of the category
        /// </summary>
        /// <value>Name of the category</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Value for replacing null measurements
        /// </summary>
        /// <value>Value for replacing null measurements</value>
        [DataMember(Name="filling_value", EmitDefaultValue=false)]
        public float? FillingValue { get; set; }
  
        
        /// <summary>
        /// Maximum recorded value of this category
        /// </summary>
        /// <value>Maximum recorded value of this category</value>
        [DataMember(Name="maximum_allowed_value", EmitDefaultValue=false)]
        public float? MaximumAllowedValue { get; set; }
  
        
        /// <summary>
        /// Minimum recorded value of this category
        /// </summary>
        /// <value>Minimum recorded value of this category</value>
        [DataMember(Name="minimum_allowed_value", EmitDefaultValue=false)]
        public float? MinimumAllowedValue { get; set; }
  
        
        /// <summary>
        /// How long the effect of a measurement in this variable lasts
        /// </summary>
        /// <value>How long the effect of a measurement in this variable lasts</value>
        [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
        public int? DurationOfAction { get; set; }
  
        
        /// <summary>
        /// How long it takes for a measurement in this variable to take effect
        /// </summary>
        /// <value>How long it takes for a measurement in this variable to take effect</value>
        [DataMember(Name="onset_delay", EmitDefaultValue=false)]
        public int? OnsetDelay { get; set; }
  
        
        /// <summary>
        /// How to combine values of this variable (for instance, to see a summary of the values over a month) 0 for sum OR 1 for mean
        /// </summary>
        /// <value>How to combine values of this variable (for instance, to see a summary of the values over a month) 0 for sum OR 1 for mean</value>
        [DataMember(Name="combination_operation", EmitDefaultValue=false)]
        public string CombinationOperation { get; set; }
  
        
        /// <summary>
        /// updated
        /// </summary>
        /// <value>updated</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public int? Updated { get; set; }
  
        
        /// <summary>
        /// A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user
        /// </summary>
        /// <value>A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</value>
        [DataMember(Name="cause_only", EmitDefaultValue=false)]
        public bool? CauseOnly { get; set; }
  
        
        /// <summary>
        /// Is category public
        /// </summary>
        /// <value>Is category public</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public int? Public { get; set; }
  
        
        /// <summary>
        /// outcome
        /// </summary>
        /// <value>outcome</value>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public bool? Outcome { get; set; }
  
        
        /// <summary>
        /// When the record was first created. Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the record was first created. Use ISO 8601 datetime format</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
  
        
        /// <summary>
        /// When the record in the database was last updated. Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the record in the database was last updated. Use ISO 8601 datetime format</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
  
        
        /// <summary>
        /// Image URL
        /// </summary>
        /// <value>Image URL</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }
  
        
        /// <summary>
        /// ID of the default unit for the category
        /// </summary>
        /// <value>ID of the default unit for the category</value>
        [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
        public int? DefaultUnitId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableCategory {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
            sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
            sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
            sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
            sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
            sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VariableCategory);
        }

        /// <summary>
        /// Returns true if VariableCategory instances are equal
        /// </summary>
        /// <param name="obj">Instance of VariableCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableCategory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FillingValue == other.FillingValue ||
                    this.FillingValue != null &&
                    this.FillingValue.Equals(other.FillingValue)
                ) && 
                (
                    this.MaximumAllowedValue == other.MaximumAllowedValue ||
                    this.MaximumAllowedValue != null &&
                    this.MaximumAllowedValue.Equals(other.MaximumAllowedValue)
                ) && 
                (
                    this.MinimumAllowedValue == other.MinimumAllowedValue ||
                    this.MinimumAllowedValue != null &&
                    this.MinimumAllowedValue.Equals(other.MinimumAllowedValue)
                ) && 
                (
                    this.DurationOfAction == other.DurationOfAction ||
                    this.DurationOfAction != null &&
                    this.DurationOfAction.Equals(other.DurationOfAction)
                ) && 
                (
                    this.OnsetDelay == other.OnsetDelay ||
                    this.OnsetDelay != null &&
                    this.OnsetDelay.Equals(other.OnsetDelay)
                ) && 
                (
                    this.CombinationOperation == other.CombinationOperation ||
                    this.CombinationOperation != null &&
                    this.CombinationOperation.Equals(other.CombinationOperation)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this.CauseOnly == other.CauseOnly ||
                    this.CauseOnly != null &&
                    this.CauseOnly.Equals(other.CauseOnly)
                ) && 
                (
                    this.Public == other.Public ||
                    this.Public != null &&
                    this.Public.Equals(other.Public)
                ) && 
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.DefaultUnitId == other.DefaultUnitId ||
                    this.DefaultUnitId != null &&
                    this.DefaultUnitId.Equals(other.DefaultUnitId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.FillingValue != null)
                    hash = hash * 57 + this.FillingValue.GetHashCode();
                
                if (this.MaximumAllowedValue != null)
                    hash = hash * 57 + this.MaximumAllowedValue.GetHashCode();
                
                if (this.MinimumAllowedValue != null)
                    hash = hash * 57 + this.MinimumAllowedValue.GetHashCode();
                
                if (this.DurationOfAction != null)
                    hash = hash * 57 + this.DurationOfAction.GetHashCode();
                
                if (this.OnsetDelay != null)
                    hash = hash * 57 + this.OnsetDelay.GetHashCode();
                
                if (this.CombinationOperation != null)
                    hash = hash * 57 + this.CombinationOperation.GetHashCode();
                
                if (this.Updated != null)
                    hash = hash * 57 + this.Updated.GetHashCode();
                
                if (this.CauseOnly != null)
                    hash = hash * 57 + this.CauseOnly.GetHashCode();
                
                if (this.Public != null)
                    hash = hash * 57 + this.Public.GetHashCode();
                
                if (this.Outcome != null)
                    hash = hash * 57 + this.Outcome.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                if (this.ImageUrl != null)
                    hash = hash * 57 + this.ImageUrl.GetHashCode();
                
                if (this.DefaultUnitId != null)
                    hash = hash * 57 + this.DefaultUnitId.GetHashCode();
                
                return hash;
            }
        }

    }
}
