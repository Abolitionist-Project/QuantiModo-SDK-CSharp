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
  public class Measurement {
    
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
    /// Connector ID
    /// </summary>
    /// <value>Connector ID</value>
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
    /// Start Time for the measurement event in ISO 8601
    /// </summary>
    /// <value>Start Time for the measurement event in ISO 8601</value>
    [DataMember(Name="start_time", EmitDefaultValue=false)]
    public int? StartTime { get; set; }

    
    /// <summary>
    /// Converted measurement value in requested unit
    /// </summary>
    /// <value>Converted measurement value in requested unit</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    public float? Value { get; set; }

    
    /// <summary>
    /// Unit ID of measurement as requested in GET request
    /// </summary>
    /// <value>Unit ID of measurement as requested in GET request</value>
    [DataMember(Name="unit_id", EmitDefaultValue=false)]
    public int? UnitId { get; set; }

    
    /// <summary>
    /// Original value
    /// </summary>
    /// <value>Original value</value>
    [DataMember(Name="original_value", EmitDefaultValue=false)]
    public float? OriginalValue { get; set; }

    
    /// <summary>
    /// Unit ID of measurement as originally submitted
    /// </summary>
    /// <value>Unit ID of measurement as originally submitted</value>
    [DataMember(Name="original_unit_id", EmitDefaultValue=false)]
    public int? OriginalUnitId { get; set; }

    
    /// <summary>
    /// duration of measurement in seconds
    /// </summary>
    /// <value>duration of measurement in seconds</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    public int? Duration { get; set; }

    
    /// <summary>
    /// Note of measurement
    /// </summary>
    /// <value>Note of measurement</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    public string Note { get; set; }

    
    /// <summary>
    /// latitude
    /// </summary>
    /// <value>latitude</value>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    public float? Latitude { get; set; }

    
    /// <summary>
    /// longitude
    /// </summary>
    /// <value>longitude</value>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    public float? Longitude { get; set; }

    
    /// <summary>
    /// location
    /// </summary>
    /// <value>location</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    public string Location { get; set; }

    
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
    /// error
    /// </summary>
    /// <value>error</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
