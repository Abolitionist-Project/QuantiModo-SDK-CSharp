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
  public class MeasurementSet {
    
    /// <summary>
    /// Array of timestamps, values, and optional notes
    /// </summary>
    /// <value>Array of timestamps, values, and optional notes</value>
    [DataMember(Name="measurements", EmitDefaultValue=false)]
    public List<ValueObject> Measurements { get; set; }

    
    /// <summary>
    /// ORIGINAL name of the variable for which we are creating the measurement records
    /// </summary>
    /// <value>ORIGINAL name of the variable for which we are creating the measurement records</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Name of the application or device used to record the measurement values
    /// </summary>
    /// <value>Name of the application or device used to record the measurement values</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /// <summary>
    /// Variable category name
    /// </summary>
    /// <value>Variable category name</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    public string Category { get; set; }

    
    /// <summary>
    /// Way to aggregate measurements over time. Options are \"MEAN\" or \"SUM\"
    /// </summary>
    /// <value>Way to aggregate measurements over time. Options are \"MEAN\" or \"SUM\"</value>
    [DataMember(Name="combinationOperation", EmitDefaultValue=false)]
    public string CombinationOperation { get; set; }

    
    /// <summary>
    /// Unit of measurement
    /// </summary>
    /// <value>Unit of measurement</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeasurementSet {\n");
      
      sb.Append("  Measurements: ").Append(Measurements).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Category: ").Append(Category).Append("\n");
      
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
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
