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
  public class MeasurementRange {
    
    /// <summary>
    /// The timestamp of the earliest measurement for a user.
    /// </summary>
    /// <value>The timestamp of the earliest measurement for a user.</value>
    [DataMember(Name="lowerLimit", EmitDefaultValue=false)]
    public int? LowerLimit { get; set; }

    
    /// <summary>
    /// The timestamp of the most recent measurement for a user.
    /// </summary>
    /// <value>The timestamp of the most recent measurement for a user.</value>
    [DataMember(Name="upperLimit", EmitDefaultValue=false)]
    public int? UpperLimit { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeasurementRange {\n");
      
      sb.Append("  LowerLimit: ").Append(LowerLimit).Append("\n");
      
      sb.Append("  UpperLimit: ").Append(UpperLimit).Append("\n");
      
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
