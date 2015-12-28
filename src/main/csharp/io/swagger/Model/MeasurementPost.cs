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
    public class MeasurementPost : IEquatable<MeasurementPost>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementPost" /> class.
        /// </summary>
        public MeasurementPost()
        {
            
        }

        
        /// <summary>
        /// ID of the variable for the measurement as obtained from the GET variables endpoint
        /// </summary>
        /// <value>ID of the variable for the measurement as obtained from the GET variables endpoint</value>
        [DataMember(Name="variable_id", EmitDefaultValue=false)]
        public int? VariableId { get; set; }
  
        
        /// <summary>
        /// Source ID of the app or device as obtained from the GET sources endpoint
        /// </summary>
        /// <value>Source ID of the app or device as obtained from the GET sources endpoint</value>
        [DataMember(Name="source_id", EmitDefaultValue=false)]
        public int? SourceId { get; set; }
  
        
        /// <summary>
        /// Unit id for the measurement value as obtained from the GET units endpoint
        /// </summary>
        /// <value>Unit id for the measurement value as obtained from the GET units endpoint</value>
        [DataMember(Name="unit_id", EmitDefaultValue=false)]
        public int? UnitId { get; set; }
  
        
        /// <summary>
        /// measurements
        /// </summary>
        /// <value>measurements</value>
        [DataMember(Name="measurements", EmitDefaultValue=false)]
        public List<MeasurementValue> Measurements { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeasurementPost {\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  UnitId: ").Append(UnitId).Append("\n");
            sb.Append("  Measurements: ").Append(Measurements).Append("\n");
            
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
            return this.Equals(obj as MeasurementPost);
        }

        /// <summary>
        /// Returns true if MeasurementPost instances are equal
        /// </summary>
        /// <param name="obj">Instance of MeasurementPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeasurementPost other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VariableId == other.VariableId ||
                    this.VariableId != null &&
                    this.VariableId.Equals(other.VariableId)
                ) && 
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) && 
                (
                    this.UnitId == other.UnitId ||
                    this.UnitId != null &&
                    this.UnitId.Equals(other.UnitId)
                ) && 
                (
                    this.Measurements == other.Measurements ||
                    this.Measurements != null &&
                    this.Measurements.SequenceEqual(other.Measurements)
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
                
                if (this.VariableId != null)
                    hash = hash * 57 + this.VariableId.GetHashCode();
                
                if (this.SourceId != null)
                    hash = hash * 57 + this.SourceId.GetHashCode();
                
                if (this.UnitId != null)
                    hash = hash * 57 + this.UnitId.GetHashCode();
                
                if (this.Measurements != null)
                    hash = hash * 57 + this.Measurements.GetHashCode();
                
                return hash;
            }
        }

    }
}
