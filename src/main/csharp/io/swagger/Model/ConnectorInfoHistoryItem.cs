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
  public class ConnectorInfoHistoryItem {
    
    /// <summary>
    /// Number of measurements
    /// </summary>
    /// <value>Number of measurements</value>
    [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
    public int? NumberOfMeasurements { get; set; }

    
    /// <summary>
    /// True if the update was successfull
    /// </summary>
    /// <value>True if the update was successfull</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    public bool? Success { get; set; }

    
    /// <summary>
    /// Error message.
    /// </summary>
    /// <value>Error message.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// Date and time of the update
    /// </summary>
    /// <value>Date and time of the update</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    public string CreatedAt { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConnectorInfoHistoryItem {\n");
      
      sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
      
      sb.Append("  Success: ").Append(Success).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
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
