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
  public class Permission {
    
    /// <summary>
    /// Grant permission to target user or public so they may access measurements within the given parameters. TODO: Rename target to something more intuitive.
    /// </summary>
    /// <value>Grant permission to target user or public so they may access measurements within the given parameters. TODO: Rename target to something more intuitive.</value>
    [DataMember(Name="target", EmitDefaultValue=false)]
    public int? Target { get; set; }

    
    /// <summary>
    /// ORIGINAL Variable name
    /// </summary>
    /// <value>ORIGINAL Variable name</value>
    [DataMember(Name="variableName", EmitDefaultValue=false)]
    public string VariableName { get; set; }

    
    /// <summary>
    /// Earliest time when measurements will be accessible in epoch seconds
    /// </summary>
    /// <value>Earliest time when measurements will be accessible in epoch seconds</value>
    [DataMember(Name="min_timestamp", EmitDefaultValue=false)]
    public int? MinTimestamp { get; set; }

    
    /// <summary>
    /// Latest time when measurements will be accessible in epoch seconds
    /// </summary>
    /// <value>Latest time when measurements will be accessible in epoch seconds</value>
    [DataMember(Name="max_timestamp", EmitDefaultValue=false)]
    public int? MaxTimestamp { get; set; }

    
    /// <summary>
    /// Earliest time of day when measurements will be accessible in epoch seconds
    /// </summary>
    /// <value>Earliest time of day when measurements will be accessible in epoch seconds</value>
    [DataMember(Name="min_time_of_day", EmitDefaultValue=false)]
    public int? MinTimeOfDay { get; set; }

    
    /// <summary>
    /// Latest time of day when measurements will be accessible in epoch seconds
    /// </summary>
    /// <value>Latest time of day when measurements will be accessible in epoch seconds</value>
    [DataMember(Name="max_time_of_day", EmitDefaultValue=false)]
    public int? MaxTimeOfDay { get; set; }

    
    /// <summary>
    /// Maybe specifies if only weekday measurements should be accessible
    /// </summary>
    /// <value>Maybe specifies if only weekday measurements should be accessible</value>
    [DataMember(Name="week", EmitDefaultValue=false)]
    public string Week { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
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

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
