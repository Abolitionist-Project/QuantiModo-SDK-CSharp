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
    public class Update :  IEquatable<Update>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Update" /> class.
        /// </summary>
        public Update()
        {
            
        }

        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// user_id
        /// </summary>
        /// <value>user_id</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
  
        
        /// <summary>
        /// connector_id
        /// </summary>
        /// <value>connector_id</value>
        [DataMember(Name="connector_id", EmitDefaultValue=false)]
        public int? ConnectorId { get; set; }
  
        
        /// <summary>
        /// number_of_measurements
        /// </summary>
        /// <value>number_of_measurements</value>
        [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
        public int? NumberOfMeasurements { get; set; }
  
        
        /// <summary>
        /// success
        /// </summary>
        /// <value>success</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }
  
        
        /// <summary>
        /// message
        /// </summary>
        /// <value>message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
  
        
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
            sb.Append("class Update {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as Update);
        }

        /// <summary>
        /// Returns true if Update instances are equal
        /// </summary>
        /// <param name="obj">Instance of Update to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Update other)
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
                    this.ConnectorId == other.ConnectorId ||
                    this.ConnectorId != null &&
                    this.ConnectorId.Equals(other.ConnectorId)
                ) && 
                (
                    this.NumberOfMeasurements == other.NumberOfMeasurements ||
                    this.NumberOfMeasurements != null &&
                    this.NumberOfMeasurements.Equals(other.NumberOfMeasurements)
                ) && 
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 57 + this.UserId.GetHashCode();
                
                if (this.ConnectorId != null)
                    hash = hash * 57 + this.ConnectorId.GetHashCode();
                
                if (this.NumberOfMeasurements != null)
                    hash = hash * 57 + this.NumberOfMeasurements.GetHashCode();
                
                if (this.Success != null)
                    hash = hash * 57 + this.Success.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 57 + this.Message.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
