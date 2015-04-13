using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class Permission {
    

    /* Grant permission to target user or public so they may access measurements within the given parameters. TODO: Rename target to something more intuitive. */
    
    public int? Target { get; set; }

    

    /* ORIGINAL Variable name */
    
    public string VariableName { get; set; }

    

    /* Earliest time when measurements will be accessible in epoch seconds */
    
    public int? MinTimestamp { get; set; }

    

    /* Latest time when measurements will be accessible in epoch seconds */
    
    public int? MaxTimestamp { get; set; }

    

    /* Earliest time of day when measurements will be accessible in epoch seconds */
    
    public int? MinTimeOfDay { get; set; }

    

    /* Latest time of day when measurements will be accessible in epoch seconds */
    
    public int? MaxTimeOfDay { get; set; }

    

    /* Maybe specifies if only weekday measurements should be accessible */
    
    public string Week { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Permission {\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  VariableName: ").Append(VariableName).Append("\n");
      
      sb.Append("  MinTimestamp: ").Append(MinTimestamp).Append("\n");
      
      sb.Append("  MaxTimestamp: ").Append(MaxTimestamp).Append("\n");
      
      sb.Append("  MinTimeOfDay: ").Append(MinTimeOfDay).Append("\n");
      
      sb.Append("  MaxTimeOfDay: ").Append(MaxTimeOfDay).Append("\n");
      
      sb.Append("  Week: ").Append(Week).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}