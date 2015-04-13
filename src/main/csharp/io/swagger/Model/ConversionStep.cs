using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class ConversionStep {
    

    /*  */
    
    public string Operation { get; set; }

    

    /*  */
    
    public double? Value { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConversionStep {\n");
      
      sb.Append("  Operation: ").Append(Operation).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}