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
    
    /* ORIGINAL Name of the variable for which we are creating the measurement records */
    [DataMember(Name="variable", EmitDefaultValue=false)]
    public string Variable { get; set; }

    
    /* Application or device used to record the measurement values */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /* Timestamp for the measurement event in epoch time */
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    public long? Timestamp { get; set; }

    
    /* Converted measurement value in requested unit */
    [DataMember(Name="value", EmitDefaultValue=false)]
    public double? Value { get; set; }

    
    /* Unit of measurement as requested in GET request */
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    
    /* Measurement value in the unit as orignally submitted */
    [DataMember(Name="storedValue", EmitDefaultValue=false)]
    public double? StoredValue { get; set; }

    
    /* Unit of measurement as originally submitted */
    [DataMember(Name="storedUnit", EmitDefaultValue=false)]
    public string StoredUnit { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Measurement {\n");
      
      sb.Append("  Variable: ").Append(Variable).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
      sb.Append("  StoredValue: ").Append(StoredValue).Append("\n");
      
      sb.Append("  StoredUnit: ").Append(StoredUnit).Append("\n");
      
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
