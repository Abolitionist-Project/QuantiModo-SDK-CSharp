using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class PostCorrelation {
    
    /* Cause variable name */
    [DataMember(Name="cause", EmitDefaultValue=false)]
    public string Cause { get; set; }

    
    /* Effect variable name */
    [DataMember(Name="effect", EmitDefaultValue=false)]
    public string Effect { get; set; }

    
    /* Correlation value */
    [DataMember(Name="correlation", EmitDefaultValue=false)]
    public double? Correlation { get; set; }

    
    /* Vote: 0 or 1 */
    [DataMember(Name="vote", EmitDefaultValue=false)]
    public int? Vote { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostCorrelation {\n");
      
      sb.Append("  Cause: ").Append(Cause).Append("\n");
      
      sb.Append("  Effect: ").Append(Effect).Append("\n");
      
      sb.Append("  Correlation: ").Append(Correlation).Append("\n");
      
      sb.Append("  Vote: ").Append(Vote).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}
