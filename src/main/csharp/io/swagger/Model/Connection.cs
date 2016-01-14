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
    public class Connection :  IEquatable<Connection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        public Connection()
        {
            
        }

        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// ID of user that owns this correlation
        /// </summary>
        /// <value>ID of user that owns this correlation</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
  
        
        /// <summary>
        /// The id for the connector data source for which the connection is connected
        /// </summary>
        /// <value>The id for the connector data source for which the connection is connected</value>
        [DataMember(Name="connector_id", EmitDefaultValue=false)]
        public int? ConnectorId { get; set; }
  
        
        /// <summary>
        /// Indicates whether a connector is currently connected to a service for a user.
        /// </summary>
        /// <value>Indicates whether a connector is currently connected to a service for a user.</value>
        [DataMember(Name="connect_status", EmitDefaultValue=false)]
        public string ConnectStatus { get; set; }
  
        
        /// <summary>
        /// Error message if there is a problem with authorizing this connection.
        /// </summary>
        /// <value>Error message if there is a problem with authorizing this connection.</value>
        [DataMember(Name="connect_error", EmitDefaultValue=false)]
        public string ConnectError { get; set; }
  
        
        /// <summary>
        /// Time at which an update was requested by a user.
        /// </summary>
        /// <value>Time at which an update was requested by a user.</value>
        [DataMember(Name="update_requested_at", EmitDefaultValue=false)]
        public DateTime? UpdateRequestedAt { get; set; }
  
        
        /// <summary>
        /// Indicates whether a connector is currently updated.
        /// </summary>
        /// <value>Indicates whether a connector is currently updated.</value>
        [DataMember(Name="update_status", EmitDefaultValue=false)]
        public string UpdateStatus { get; set; }
  
        
        /// <summary>
        /// Indicates if there was an error during the update.
        /// </summary>
        /// <value>Indicates if there was an error during the update.</value>
        [DataMember(Name="update_error", EmitDefaultValue=false)]
        public string UpdateError { get; set; }
  
        
        /// <summary>
        /// The time at which the connector was last successfully updated.
        /// </summary>
        /// <value>The time at which the connector was last successfully updated.</value>
        [DataMember(Name="last_successful_updated_at", EmitDefaultValue=false)]
        public DateTime? LastSuccessfulUpdatedAt { get; set; }
  
        
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
            sb.Append("class Connection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  ConnectStatus: ").Append(ConnectStatus).Append("\n");
            sb.Append("  ConnectError: ").Append(ConnectError).Append("\n");
            sb.Append("  UpdateRequestedAt: ").Append(UpdateRequestedAt).Append("\n");
            sb.Append("  UpdateStatus: ").Append(UpdateStatus).Append("\n");
            sb.Append("  UpdateError: ").Append(UpdateError).Append("\n");
            sb.Append("  LastSuccessfulUpdatedAt: ").Append(LastSuccessfulUpdatedAt).Append("\n");
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
            return this.Equals(obj as Connection);
        }

        /// <summary>
        /// Returns true if Connection instances are equal
        /// </summary>
        /// <param name="obj">Instance of Connection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connection other)
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
                    this.ConnectStatus == other.ConnectStatus ||
                    this.ConnectStatus != null &&
                    this.ConnectStatus.Equals(other.ConnectStatus)
                ) && 
                (
                    this.ConnectError == other.ConnectError ||
                    this.ConnectError != null &&
                    this.ConnectError.Equals(other.ConnectError)
                ) && 
                (
                    this.UpdateRequestedAt == other.UpdateRequestedAt ||
                    this.UpdateRequestedAt != null &&
                    this.UpdateRequestedAt.Equals(other.UpdateRequestedAt)
                ) && 
                (
                    this.UpdateStatus == other.UpdateStatus ||
                    this.UpdateStatus != null &&
                    this.UpdateStatus.Equals(other.UpdateStatus)
                ) && 
                (
                    this.UpdateError == other.UpdateError ||
                    this.UpdateError != null &&
                    this.UpdateError.Equals(other.UpdateError)
                ) && 
                (
                    this.LastSuccessfulUpdatedAt == other.LastSuccessfulUpdatedAt ||
                    this.LastSuccessfulUpdatedAt != null &&
                    this.LastSuccessfulUpdatedAt.Equals(other.LastSuccessfulUpdatedAt)
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
                
                if (this.ConnectStatus != null)
                    hash = hash * 57 + this.ConnectStatus.GetHashCode();
                
                if (this.ConnectError != null)
                    hash = hash * 57 + this.ConnectError.GetHashCode();
                
                if (this.UpdateRequestedAt != null)
                    hash = hash * 57 + this.UpdateRequestedAt.GetHashCode();
                
                if (this.UpdateStatus != null)
                    hash = hash * 57 + this.UpdateStatus.GetHashCode();
                
                if (this.UpdateError != null)
                    hash = hash * 57 + this.UpdateError.GetHashCode();
                
                if (this.LastSuccessfulUpdatedAt != null)
                    hash = hash * 57 + this.LastSuccessfulUpdatedAt.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
