using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class Variable {
    

    /* User-defined variable display name. */
    
    public string Name { get; set; }

    

    /* Name used when the variable was originally created in the `variables` table. */
    
    public string OriginalName { get; set; }

    

    /* Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc. */
    
    public string Category { get; set; }

    

    /* Abbreviated name of the default unit for the variable */
    
    public string Unit { get; set; }

    

    /* Comma-separated list of source names to limit variables to those sources */
    
    public string Sources { get; set; }

    

    /* Minimum reasonable value for this variable (uses default unit) */
    
    public double? MinimumValue { get; set; }

    

    /* Maximum reasonable value for this variable (uses default unit) */
    
    public double? MaximumValue { get; set; }

    

    /* How to aggregate measurements over time. */
    
    public string CombinationOperation { get; set; }

    

    /* Value for replacing null measurements */
    
    public double? FillingValue { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Variable {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
      
      sb.Append("  Category: ").Append(Category).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
      sb.Append("  Sources: ").Append(Sources).Append("\n");
      
      sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
      
      sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
      
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
      
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}