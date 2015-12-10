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
    public class Measurement : IEquatable<Measurement>
    {
        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// ID of user that owns this measurement
        /// </summary>
        /// <value>ID of user that owns this measurement</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
  
        
        /// <summary>
        /// client_id
        /// </summary>
        /// <value>client_id</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
  
        
        /// <summary>
        /// The id for the connector data source from which the measurement was obtained
        /// </summary>
        /// <value>The id for the connector data source from which the measurement was obtained</value>
        [DataMember(Name="connector_id", EmitDefaultValue=false)]
        public int? ConnectorId { get; set; }
  
        
        /// <summary>
        /// ID of the variable for which we are creating the measurement records
        /// </summary>
        /// <value>ID of the variable for which we are creating the measurement records</value>
        [DataMember(Name="variable_id", EmitDefaultValue=false)]
        public int? VariableId { get; set; }
  
        
        /// <summary>
        /// Application or device used to record the measurement values
        /// </summary>
        /// <value>Application or device used to record the measurement values</value>
        [DataMember(Name="source_id", EmitDefaultValue=false)]
        public int? SourceId { get; set; }
  
        
        /// <summary>
        /// Start Time for the measurement event. Use ISO 8601
        /// </summary>
        /// <value>Start Time for the measurement event. Use ISO 8601</value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public string StartTime { get; set; }
  
        
        /// <summary>
        /// The value of the measurement after conversion to the default unit for that variable
        /// </summary>
        /// <value>The value of the measurement after conversion to the default unit for that variable</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public float? Value { get; set; }
  
        
        /// <summary>
        /// The default unit for the variable
        /// </summary>
        /// <value>The default unit for the variable</value>
        [DataMember(Name="unit_id", EmitDefaultValue=false)]
        public int? UnitId { get; set; }
  
        
        /// <summary>
        /// Value of measurement as originally posted (before conversion to default unit)
        /// </summary>
        /// <value>Value of measurement as originally posted (before conversion to default unit)</value>
        [DataMember(Name="original_value", EmitDefaultValue=false)]
        public float? OriginalValue { get; set; }
  
        
        /// <summary>
        /// Unit ID of measurement as originally submitted
        /// </summary>
        /// <value>Unit ID of measurement as originally submitted</value>
        [DataMember(Name="original_unit_id", EmitDefaultValue=false)]
        public int? OriginalUnitId { get; set; }
  
        
        /// <summary>
        /// Duration of the event being measurement in seconds
        /// </summary>
        /// <value>Duration of the event being measurement in seconds</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
  
        
        /// <summary>
        /// An optional note the user may include with their measurement
        /// </summary>
        /// <value>An optional note the user may include with their measurement</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
  
        
        /// <summary>
        /// Latitude at which the measurement was taken
        /// </summary>
        /// <value>Latitude at which the measurement was taken</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public float? Latitude { get; set; }
  
        
        /// <summary>
        /// Longitude at which the measurement was taken
        /// </summary>
        /// <value>Longitude at which the measurement was taken</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public float? Longitude { get; set; }
  
        
        /// <summary>
        /// location
        /// </summary>
        /// <value>location</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
  
        
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
        /// error
        /// </summary>
        /// <value>error</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Measurement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  UnitId: ").Append(UnitId).Append("\n");
            sb.Append("  OriginalValue: ").Append(OriginalValue).Append("\n");
            sb.Append("  OriginalUnitId: ").Append(OriginalUnitId).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            
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
            return this.Equals(obj as Measurement);
        }

        /// <summary>
        /// Returns true if Measurement instances are equal
        /// </summary>
        /// <param name="obj">Instance of Measurement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Measurement other)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.ConnectorId == other.ConnectorId ||
                    this.ConnectorId != null &&
                    this.ConnectorId.Equals(other.ConnectorId)
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
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.UnitId == other.UnitId ||
                    this.UnitId != null &&
                    this.UnitId.Equals(other.UnitId)
                ) && 
                (
                    this.OriginalValue == other.OriginalValue ||
                    this.OriginalValue != null &&
                    this.OriginalValue.Equals(other.OriginalValue)
                ) && 
                (
                    this.OriginalUnitId == other.OriginalUnitId ||
                    this.OriginalUnitId != null &&
                    this.OriginalUnitId.Equals(other.OriginalUnitId)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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
                
                if (this.UserId != null)
                    hash = hash * 57 + this.UserId.GetHashCode();
                
                if (this.ClientId != null)
                    hash = hash * 57 + this.ClientId.GetHashCode();
                
                if (this.ConnectorId != null)
                    hash = hash * 57 + this.ConnectorId.GetHashCode();
                
                if (this.VariableId != null)
                    hash = hash * 57 + this.VariableId.GetHashCode();
                
                if (this.SourceId != null)
                    hash = hash * 57 + this.SourceId.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 57 + this.StartTime.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 57 + this.Value.GetHashCode();
                
                if (this.UnitId != null)
                    hash = hash * 57 + this.UnitId.GetHashCode();
                
                if (this.OriginalValue != null)
                    hash = hash * 57 + this.OriginalValue.GetHashCode();
                
                if (this.OriginalUnitId != null)
                    hash = hash * 57 + this.OriginalUnitId.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 57 + this.Duration.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 57 + this.Note.GetHashCode();
                
                if (this.Latitude != null)
                    hash = hash * 57 + this.Latitude.GetHashCode();
                
                if (this.Longitude != null)
                    hash = hash * 57 + this.Longitude.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 57 + this.Location.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 57 + this.Error.GetHashCode();
                
                return hash;
            }
        }

    }
}
