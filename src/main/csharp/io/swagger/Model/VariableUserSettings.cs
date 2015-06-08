using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class VariableUserSettings {
    
    /* User ID */
    [DataMember(Name="user", EmitDefaultValue=false)]
    public int? User { get; set; }

    
    /* Variable DISPLAY name */
    [DataMember(Name="variable", EmitDefaultValue=false)]
    public string Variable { get; set; }

    
    /* Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect */
    [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
    public int? DurationOfAction { get; set; }

    
    /* fillingValue */
    [DataMember(Name="fillingValue", EmitDefaultValue=false)]
    public int? FillingValue { get; set; }

    
    /* joinWith */
    [DataMember(Name="joinWith", EmitDefaultValue=false)]
    public string JoinWith { get; set; }

    
    /* maximumValue */
    [DataMember(Name="maximumValue", EmitDefaultValue=false)]
    public float? MaximumValue { get; set; }

    
    /* minimumValue */
    [DataMember(Name="minimumValue", EmitDefaultValue=false)]
    public float? MinimumValue { get; set; }

    
    /* name */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* onsetDelay */
    [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
    public int? OnsetDelay { get; set; }

    
    /* unit */
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VariableUserSettings {\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("  Variable: ").Append(Variable).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      
      sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
      
      sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
      
      sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
