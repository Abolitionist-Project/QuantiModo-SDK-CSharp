using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class Permission {
    
    /* Grant permission to target user or public so they may access measurements within the given parameters. TODO: Rename target to something more intuitive. */
    [DataMember(Name="target", EmitDefaultValue=false)]
    public int? Target { get; set; }

    
    /* ORIGINAL Variable name */
    [DataMember(Name="variableName", EmitDefaultValue=false)]
    public string VariableName { get; set; }

    
    /* Earliest time when measurements will be accessible in epoch seconds */
    [DataMember(Name="min_timestamp", EmitDefaultValue=false)]
    public int? MinTimestamp { get; set; }

    
    /* Latest time when measurements will be accessible in epoch seconds */
    [DataMember(Name="max_timestamp", EmitDefaultValue=false)]
    public int? MaxTimestamp { get; set; }

    
    /* Earliest time of day when measurements will be accessible in epoch seconds */
    [DataMember(Name="min_time_of_day", EmitDefaultValue=false)]
    public int? MinTimeOfDay { get; set; }

    
    /* Latest time of day when measurements will be accessible in epoch seconds */
    [DataMember(Name="max_time_of_day", EmitDefaultValue=false)]
    public int? MaxTimeOfDay { get; set; }

    
    /* Maybe specifies if only weekday measurements should be accessible */
    [DataMember(Name="week", EmitDefaultValue=false)]
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
