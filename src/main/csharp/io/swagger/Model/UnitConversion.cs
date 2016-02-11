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
    public partial class UnitConversion :  IEquatable<UnitConversion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitConversion" /> class.
        /// </summary>
        public UnitConversion()
        {
            
        }

        
        /// <summary>
        /// unit_id
        /// </summary>
        /// <value>unit_id</value>
        [DataMember(Name="unit_id", EmitDefaultValue=false)]
        public int? UnitId { get; set; }
  
        
        /// <summary>
        /// step in the conversion process
        /// </summary>
        /// <value>step in the conversion process</value>
        [DataMember(Name="step_number", EmitDefaultValue=false)]
        public bool? StepNumber { get; set; }
  
        
        /// <summary>
        /// 0 is add and 1 is multiply
        /// </summary>
        /// <value>0 is add and 1 is multiply</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public bool? Operation { get; set; }
  
        
        /// <summary>
        /// number used in the operation
        /// </summary>
        /// <value>number used in the operation</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public float? Value { get; set; }
  
        
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
            sb.Append("class UnitConversion {\n");
            sb.Append("  UnitId: ").Append(UnitId).Append("\n");
            sb.Append("  StepNumber: ").Append(StepNumber).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as UnitConversion);
        }

        /// <summary>
        /// Returns true if UnitConversion instances are equal
        /// </summary>
        /// <param name="other">Instance of UnitConversion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnitConversion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UnitId == other.UnitId ||
                    this.UnitId != null &&
                    this.UnitId.Equals(other.UnitId)
                ) && 
                (
                    this.StepNumber == other.StepNumber ||
                    this.StepNumber != null &&
                    this.StepNumber.Equals(other.StepNumber)
                ) && 
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                
                if (this.UnitId != null)
                    hash = hash * 59 + this.UnitId.GetHashCode();
                
                if (this.StepNumber != null)
                    hash = hash * 59 + this.StepNumber.GetHashCode();
                
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
