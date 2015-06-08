using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class Pairs {
    
    /* Category name */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Pairs {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
