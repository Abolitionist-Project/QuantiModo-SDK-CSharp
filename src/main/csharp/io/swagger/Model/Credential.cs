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
    public class Credential : IEquatable<Credential>
    {
        
        /// <summary>
        /// ID of user that owns this credential
        /// </summary>
        /// <value>ID of user that owns this credential</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
  
        
        /// <summary>
        /// The id for the connector data source from which the credential was obtained
        /// </summary>
        /// <value>The id for the connector data source from which the credential was obtained</value>
        [DataMember(Name="connector_id", EmitDefaultValue=false)]
        public int? ConnectorId { get; set; }
  
        
        /// <summary>
        /// Attribute name such as token, userid, username, or password
        /// </summary>
        /// <value>Attribute name such as token, userid, username, or password</value>
        [DataMember(Name="attr_key", EmitDefaultValue=false)]
        public string AttrKey { get; set; }
  
        
        /// <summary>
        /// Encrypted value for the attribute specified
        /// </summary>
        /// <value>Encrypted value for the attribute specified</value>
        [DataMember(Name="attr_value", EmitDefaultValue=false)]
        public string AttrValue { get; set; }
  
        
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
            sb.Append("class Credential {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  AttrKey: ").Append(AttrKey).Append("\n");
            sb.Append("  AttrValue: ").Append(AttrValue).Append("\n");
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
            return this.Equals(obj as Credential);
        }

        /// <summary>
        /// Returns true if Credential instances are equal
        /// </summary>
        /// <param name="obj">Instance of Credential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Credential other)
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
                    this.ConnectorId == other.ConnectorId ||
                    this.ConnectorId != null &&
                    this.ConnectorId.Equals(other.ConnectorId)
                ) && 
                (
                    this.AttrKey == other.AttrKey ||
                    this.AttrKey != null &&
                    this.AttrKey.Equals(other.AttrKey)
                ) && 
                (
                    this.AttrValue == other.AttrValue ||
                    this.AttrValue != null &&
                    this.AttrValue.Equals(other.AttrValue)
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
                
                if (this.ConnectorId != null)
                    hash = hash * 57 + this.ConnectorId.GetHashCode();
                
                if (this.AttrKey != null)
                    hash = hash * 57 + this.AttrKey.GetHashCode();
                
                if (this.AttrValue != null)
                    hash = hash * 57 + this.AttrValue.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
