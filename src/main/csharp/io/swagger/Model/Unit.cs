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
  public class Unit {
    
    /* Unit name */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* Unit abbreviation */
    [DataMember(Name="abbreviatedName", EmitDefaultValue=false)]
    public string AbbreviatedName { get; set; }

    
    /* Unit category */
    [DataMember(Name="category", EmitDefaultValue=false)]
    public string Category { get; set; }

    
    /* Unit minimum value */
    [DataMember(Name="minimum", EmitDefaultValue=false)]
    public double? Minimum { get; set; }

    
    /* Unit maximum value */
    [DataMember(Name="maximum", EmitDefaultValue=false)]
    public double? Maximum { get; set; }

    
    /* Conversion steps list */
    [DataMember(Name="conversionSteps", EmitDefaultValue=false)]
    public List<ConversionStep> ConversionSteps { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
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

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}
