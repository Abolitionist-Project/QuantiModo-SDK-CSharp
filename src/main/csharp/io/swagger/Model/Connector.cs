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
    public class Connector : IEquatable<Connector>
    {
        
        /// <summary>
        /// Connector ID number
        /// </summary>
        /// <value>Connector ID number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Lowercase system name for the data source
        /// </summary>
        /// <value>Lowercase system name for the data source</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Pretty display name for the data source
        /// </summary>
        /// <value>Pretty display name for the data source</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
  
        
        /// <summary>
        /// URL to the image of the connector logo
        /// </summary>
        /// <value>URL to the image of the connector logo</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
  
        
        /// <summary>
        /// URL to a site where one can get this device or application
        /// </summary>
        /// <value>URL to a site where one can get this device or application</value>
        [DataMember(Name="get_it_url", EmitDefaultValue=false)]
        public string GetItUrl { get; set; }
  
        
        /// <summary>
        /// Short description of the service (such as the categories it tracks)
        /// </summary>
        /// <value>Short description of the service (such as the categories it tracks)</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }
  
        
        /// <summary>
        /// Longer paragraph description of the data provider
        /// </summary>
        /// <value>Longer paragraph description of the data provider</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }
  
        
        /// <summary>
        /// Set to 1 if the connector should be returned when listing connectors
        /// </summary>
        /// <value>Set to 1 if the connector should be returned when listing connectors</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
  
        
        /// <summary>
        /// Set to 1 if the connector uses OAuth authentication as opposed to username/password
        /// </summary>
        /// <value>Set to 1 if the connector uses OAuth authentication as opposed to username/password</value>
        [DataMember(Name="oauth", EmitDefaultValue=false)]
        public bool? Oauth { get; set; }
  
        
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
            sb.Append("class Connector {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  GetItUrl: ").Append(GetItUrl).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Oauth: ").Append(Oauth).Append("\n");
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
            return this.Equals(obj as Connector);
        }

        /// <summary>
        /// Returns true if Connector instances are equal
        /// </summary>
        /// <param name="obj">Instance of Connector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connector other)
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
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.GetItUrl == other.GetItUrl ||
                    this.GetItUrl != null &&
                    this.GetItUrl.Equals(other.GetItUrl)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.LongDescription == other.LongDescription ||
                    this.LongDescription != null &&
                    this.LongDescription.Equals(other.LongDescription)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Oauth == other.Oauth ||
                    this.Oauth != null &&
                    this.Oauth.Equals(other.Oauth)
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
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.DisplayName != null)
                    hash = hash * 57 + this.DisplayName.GetHashCode();
                
                if (this.Image != null)
                    hash = hash * 57 + this.Image.GetHashCode();
                
                if (this.GetItUrl != null)
                    hash = hash * 57 + this.GetItUrl.GetHashCode();
                
                if (this.ShortDescription != null)
                    hash = hash * 57 + this.ShortDescription.GetHashCode();
                
                if (this.LongDescription != null)
                    hash = hash * 57 + this.LongDescription.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 57 + this.Enabled.GetHashCode();
                
                if (this.Oauth != null)
                    hash = hash * 57 + this.Oauth.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                return hash;
            }
        }

    }
}
