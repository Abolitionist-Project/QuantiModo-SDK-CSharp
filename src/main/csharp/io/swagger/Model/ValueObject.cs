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
  public class ValueObject {
    
    /// <summary>
    /// Timestamp for the measurement event in epoch time (unixtime)
    /// </summary>
    /// <value>Timestamp for the measurement event in epoch time (unixtime)</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    public long? Timestamp { get; set; }

    
    /// <summary>
    /// Measurement value
    /// </summary>
    /// <value>Measurement value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    public double? Value { get; set; }

    
    /// <summary>
    /// Optional note to include with the measurement
    /// </summary>
    /// <value>Optional note to include with the measurement</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    public string Note { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ValueObject {\n");
      
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  Note: ").Append(Note).Append("\n");
      
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
