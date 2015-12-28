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
    public class VariableUserSource : IEquatable<VariableUserSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableUserSource" /> class.
        /// </summary>
        public VariableUserSource()
        {
            
        }

        
        /// <summary>
        /// ID of User
        /// </summary>
        /// <value>ID of User</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
  
        
        /// <summary>
        /// ID of variable
        /// </summary>
        /// <value>ID of variable</value>
        [DataMember(Name="variable_id", EmitDefaultValue=false)]
        public int? VariableId { get; set; }
  
        
        /// <summary>
        /// ID of source
        /// </summary>
        /// <value>ID of source</value>
        [DataMember(Name="source_id", EmitDefaultValue=false)]
        public int? SourceId { get; set; }
  
        
        /// <summary>
        /// Time that this measurement occurred Uses epoch minute (epoch time divided by 60)
        /// </summary>
        /// <value>Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }
  
        
        /// <summary>
        /// Earliest measurement time
        /// </summary>
        /// <value>Earliest measurement time</value>
        [DataMember(Name="earliest_measurement_time", EmitDefaultValue=false)]
        public int? EarliestMeasurementTime { get; set; }
  
        
        /// <summary>
        /// Latest measurement time
        /// </summary>
        /// <value>Latest measurement time</value>
        [DataMember(Name="latest_measurement_time", EmitDefaultValue=false)]
        public int? LatestMeasurementTime { get; set; }
  
        
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
            sb.Append("class VariableUserSource {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  EarliestMeasurementTime: ").Append(EarliestMeasurementTime).Append("\n");
            sb.Append("  LatestMeasurementTime: ").Append(LatestMeasurementTime).Append("\n");
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
            return this.Equals(obj as VariableUserSource);
        }

        /// <summary>
        /// Returns true if VariableUserSource instances are equal
        /// </summary>
        /// <param name="obj">Instance of VariableUserSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableUserSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
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
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.EarliestMeasurementTime == other.EarliestMeasurementTime ||
                    this.EarliestMeasurementTime != null &&
                    this.EarliestMeasurementTime.Equals(other.EarliestMeasurementTime)
                ) && 
                (
                    this.LatestMeasurementTime == other.LatestMeasurementTime ||
                    this.LatestMeasurementTime != null &&
                    this.LatestMeasurementTime.Equals(other.LatestMeasurementTime)
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
                
                if (this.UserId != null)
                    hash = hash * 57 + this.UserId.GetHashCode();
                
                if (this.VariableId != null)
                    hash = hash * 57 + this.VariableId.GetHashCode();
                
                if (this.SourceId != null)
                    hash = hash * 57 + this.SourceId.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 57 + this.Timestamp.GetHashCode();
                
                if (this.EarliestMeasurementTime != null)
                    hash = hash * 57 + this.EarliestMeasurementTime.GetHashCode();
                
                if (this.LatestMeasurementTime != null)
                    hash = hash * 57 + this.LatestMeasurementTime.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
