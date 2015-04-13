using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class MeasurementRange {
    

    /* The timestamp of the earliest measurement for a user. */
    
    public int? LowerLimit { get; set; }

    

    /* The timestamp of the most recent measurement for a user. */
    
    public int? UpperLimit { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeasurementRange {\n");
      
      sb.Append("  LowerLimit: ").Append(LowerLimit).Append("\n");
      
      sb.Append("  UpperLimit: ").Append(UpperLimit).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}