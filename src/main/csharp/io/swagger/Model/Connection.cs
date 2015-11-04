using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Connection {
    
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
    /// connect_status
    /// </summary>
    /// <value>connect_status</value>
    [DataMember(Name="connect_status", EmitDefaultValue=false)]
    public string ConnectStatus { get; set; }

    
    /// <summary>
    /// connect_error
    /// </summary>
    /// <value>connect_error</value>
    [DataMember(Name="connect_error", EmitDefaultValue=false)]
    public string ConnectError { get; set; }

    
    /// <summary>
    /// update_requested_at
    /// </summary>
    /// <value>update_requested_at</value>
    [DataMember(Name="update_requested_at", EmitDefaultValue=false)]
    public DateTime? UpdateRequestedAt { get; set; }

    
    /// <summary>
    /// update_status
    /// </summary>
    /// <value>update_status</value>
    [DataMember(Name="update_status", EmitDefaultValue=false)]
    public string UpdateStatus { get; set; }

    
    /// <summary>
    /// update_error
    /// </summary>
    /// <value>update_error</value>
    [DataMember(Name="update_error", EmitDefaultValue=false)]
    public string UpdateError { get; set; }

    
    /// <summary>
    /// last_successful_updated_at
    /// </summary>
    /// <value>last_successful_updated_at</value>
    [DataMember(Name="last_successful_updated_at", EmitDefaultValue=false)]
    public DateTime? LastSuccessfulUpdatedAt { get; set; }

    
    /// <summary>
    /// created_at
    /// </summary>
    /// <value>created_at</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    public DateTime? CreatedAt { get; set; }

    
    /// <summary>
    /// updated_at
    /// </summary>
    /// <value>updated_at</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    public DateTime? UpdatedAt { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
