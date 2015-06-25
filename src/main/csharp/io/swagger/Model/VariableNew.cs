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
  public class VariableNew {
    
    /* User-defined variable display name. */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc. */
    [DataMember(Name="category", EmitDefaultValue=false)]
    public string Category { get; set; }

    
    /* Abbreviated name of the default unit for the variable */
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    
    /* How to aggregate measurements over time. */
    [DataMember(Name="combinationOperation", EmitDefaultValue=false)]
    public string CombinationOperation { get; set; }

    
    /* Parent */
    [DataMember(Name="parent", EmitDefaultValue=false)]
    public string Parent { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VariableNew {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Category: ").Append(Category).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
      
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      
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
