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
  public class Update {
    
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
