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
  public class PostCorrelation {
    
    /// <summary>
    /// Cause variable name
    /// </summary>
    /// <value>Cause variable name</value>
    [DataMember(Name="cause", EmitDefaultValue=false)]
    public string Cause { get; set; }

    
    /// <summary>
    /// Effect variable name
    /// </summary>
    /// <value>Effect variable name</value>
    [DataMember(Name="effect", EmitDefaultValue=false)]
    public string Effect { get; set; }

    
    /// <summary>
    /// Correlation value
    /// </summary>
    /// <value>Correlation value</value>
    [DataMember(Name="correlation", EmitDefaultValue=false)]
    public double? Correlation { get; set; }

    
    /// <summary>
    /// Vote: 0 or 1
    /// </summary>
    /// <value>Vote: 0 or 1</value>
    [DataMember(Name="vote", EmitDefaultValue=false)]
    public int? Vote { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
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

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
