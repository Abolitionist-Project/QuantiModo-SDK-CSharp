using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Unit :  IEquatable<Unit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Unit" /> class.
        /// </summary>
        public Unit()
        {
            
        }

        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// client_id
        /// </summary>
        /// <value>client_id</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
  
        
        /// <summary>
        /// Unit name
        /// </summary>
        /// <value>Unit name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Unit abbreviation
        /// </summary>
        /// <value>Unit abbreviation</value>
        [DataMember(Name="abbreviated_name", EmitDefaultValue=false)]
        public string AbbreviatedName { get; set; }
  
        
        /// <summary>
        /// Unit category ID
        /// </summary>
        /// <value>Unit category ID</value>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public int? CategoryId { get; set; }
  
        
        /// <summary>
        /// Minimum value permitted for this unit
        /// </summary>
        /// <value>Minimum value permitted for this unit</value>
        [DataMember(Name="minimum_value", EmitDefaultValue=false)]
        public float? MinimumValue { get; set; }
  
        
        /// <summary>
        /// Maximum value permitted for this unit
        /// </summary>
        /// <value>Maximum value permitted for this unit</value>
        [DataMember(Name="maximum_value", EmitDefaultValue=false)]
        public float? MaximumValue { get; set; }
  
        
        /// <summary>
        /// updated
        /// </summary>
        /// <value>updated</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public int? Updated { get; set; }
  
        
        /// <summary>
        /// ID of default unit for this units category
        /// </summary>
        /// <value>ID of default unit for this units category</value>
        [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
        public int? DefaultUnitId { get; set; }
  
        
        /// <summary>
        /// Value multiplied to convert to default unit in this unit category
        /// </summary>
        /// <value>Value multiplied to convert to default unit in this unit category</value>
        [DataMember(Name="multiply", EmitDefaultValue=false)]
        public float? Multiply { get; set; }
  
        
        /// <summary>
        /// Value which should be added to convert to default unit
        /// </summary>
        /// <value>Value which should be added to convert to default unit</value>
        [DataMember(Name="add", EmitDefaultValue=false)]
        public float? Add { get; set; }
  
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Unit {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AbbreviatedName: ").Append(AbbreviatedName).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
            sb.Append("  Multiply: ").Append(Multiply).Append("\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            
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
            return this.Equals(obj as Unit);
        }

        /// <summary>
        /// Returns true if Unit instances are equal
        /// </summary>
        /// <param name="other">Instance of Unit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Unit other)
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
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AbbreviatedName == other.AbbreviatedName ||
                    this.AbbreviatedName != null &&
                    this.AbbreviatedName.Equals(other.AbbreviatedName)
                ) && 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    this.MinimumValue == other.MinimumValue ||
                    this.MinimumValue != null &&
                    this.MinimumValue.Equals(other.MinimumValue)
                ) && 
                (
                    this.MaximumValue == other.MaximumValue ||
                    this.MaximumValue != null &&
                    this.MaximumValue.Equals(other.MaximumValue)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this.DefaultUnitId == other.DefaultUnitId ||
                    this.DefaultUnitId != null &&
                    this.DefaultUnitId.Equals(other.DefaultUnitId)
                ) && 
                (
                    this.Multiply == other.Multiply ||
                    this.Multiply != null &&
                    this.Multiply.Equals(other.Multiply)
                ) && 
                (
                    this.Add == other.Add ||
                    this.Add != null &&
                    this.Add.Equals(other.Add)
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
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.AbbreviatedName != null)
                    hash = hash * 59 + this.AbbreviatedName.GetHashCode();
                
                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();
                
                if (this.MinimumValue != null)
                    hash = hash * 59 + this.MinimumValue.GetHashCode();
                
                if (this.MaximumValue != null)
                    hash = hash * 59 + this.MaximumValue.GetHashCode();
                
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                
                if (this.DefaultUnitId != null)
                    hash = hash * 59 + this.DefaultUnitId.GetHashCode();
                
                if (this.Multiply != null)
                    hash = hash * 59 + this.Multiply.GetHashCode();
                
                if (this.Add != null)
                    hash = hash * 59 + this.Add.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
