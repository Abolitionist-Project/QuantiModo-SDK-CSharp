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
  public class Variable {
    
    /* User-defined variable display name. */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* Name used when the variable was originally created in the `variables` table. */
    [DataMember(Name="originalName", EmitDefaultValue=false)]
    public string OriginalName { get; set; }

    
    /* Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc. */
    [DataMember(Name="category", EmitDefaultValue=false)]
    public string Category { get; set; }

    
    /* Abbreviated name of the default unit for the variable */
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    
    /* Comma-separated list of source names to limit variables to those sources */
    [DataMember(Name="sources", EmitDefaultValue=false)]
    public string Sources { get; set; }

    
    /* Minimum reasonable value for this variable (uses default unit) */
    [DataMember(Name="minimumValue", EmitDefaultValue=false)]
    public double? MinimumValue { get; set; }

    
    /* Maximum reasonable value for this variable (uses default unit) */
    [DataMember(Name="maximumValue", EmitDefaultValue=false)]
    public double? MaximumValue { get; set; }

    
    /* How to aggregate measurements over time. */
    [DataMember(Name="combinationOperation", EmitDefaultValue=false)]
    public string CombinationOperation { get; set; }

    
    /* Value for replacing null measurements */
    [DataMember(Name="fillingValue", EmitDefaultValue=false)]
    public double? FillingValue { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
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

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}
