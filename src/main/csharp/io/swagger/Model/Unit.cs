using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class Unit {
    

    /* Unit name */
    
    public string Name { get; set; }

    

    /* Unit abbreviation */
    
    public string AbbreviatedName { get; set; }

    

    /* Unit category */
    
    public string Category { get; set; }

    

    /* Unit minimum value */
    
    public double? Minimum { get; set; }

    

    /* Unit maximum value */
    
    public double? Maximum { get; set; }

    

    /* Conversion steps list */
    
    public List<ConversionStep> ConversionSteps { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Unit {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  AbbreviatedName: ").Append(AbbreviatedName).Append("\n");
      
      sb.Append("  Category: ").Append(Category).Append("\n");
      
      sb.Append("  Minimum: ").Append(Minimum).Append("\n");
      
      sb.Append("  Maximum: ").Append(Maximum).Append("\n");
      
      sb.Append("  ConversionSteps: ").Append(ConversionSteps).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}