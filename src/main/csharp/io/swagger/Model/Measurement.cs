using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class Measurement {
    

    /* ORIGINAL Name of the variable for which we are creating the measurement records */
    
    public string Variable { get; set; }

    

    /* Application or device used to record the measurement values */
    
    public string Source { get; set; }

    

    /* Timestamp for the measurement event in epoch time */
    
    public long? Timestamp { get; set; }

    

    /* Measurement value */
    
    public double? Value { get; set; }

    

    /* Unit of Measurement */
    
    public string Unit { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Measurement {\n");
      
      sb.Append("  Variable: ").Append(Variable).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}