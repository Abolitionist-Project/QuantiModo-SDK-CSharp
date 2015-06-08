using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class ConversionStep {
    
    /*  */
    [DataMember(Name="operation", EmitDefaultValue=false)]
    public string Operation { get; set; }

    
    /*  */
    [DataMember(Name="value", EmitDefaultValue=false)]
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
