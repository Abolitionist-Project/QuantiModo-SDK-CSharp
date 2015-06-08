using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
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

    
    /* Measurement value */
    [DataMember(Name="value", EmitDefaultValue=false)]
    public double? Value { get; set; }

    
    /* Unit of Measurement */
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    
    /* Optional note supplied with the measurement. Can be up to 255 characters in length. */
    [DataMember(Name="note", EmitDefaultValue=false)]
    public string Note { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Measurement {\n");
      
      sb.Append("  Variable: ").Append(Variable).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
      sb.Append("  Note: ").Append(Note).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
