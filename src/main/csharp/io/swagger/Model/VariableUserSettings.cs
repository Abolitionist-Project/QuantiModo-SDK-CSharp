using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class VariableUserSettings {
    

    /* User ID */
    
    public int? User { get; set; }

    

    /* Variable DISPLAY name */
    
    public string Variable { get; set; }

    

    /* Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect */
    
    public int? DurationOfAction { get; set; }

    

    /* fillingValue */
    
    public int? FillingValue { get; set; }

    

    /* joinWith */
    
    public string JoinWith { get; set; }

    

    /* maximumValue */
    
    public float? MaximumValue { get; set; }

    

    /* minimumValue */
    
    public float? MinimumValue { get; set; }

    

    /* name */
    
    public string Name { get; set; }

    

    /* onsetDelay */
    
    public int? OnsetDelay { get; set; }

    

    /* unit */
    
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