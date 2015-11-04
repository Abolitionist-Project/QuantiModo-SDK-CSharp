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
  public class MeasurementPost {
    
    /// <summary>
    /// variable_id
    /// </summary>
    /// <value>variable_id</value>
    [DataMember(Name="variable_id", EmitDefaultValue=false)]
    public int? VariableId { get; set; }

    
    /// <summary>
    /// source_id
    /// </summary>
    /// <value>source_id</value>
    [DataMember(Name="source_id", EmitDefaultValue=false)]
    public int? SourceId { get; set; }

    
    /// <summary>
    /// unit_id
    /// </summary>
    /// <value>unit_id</value>
    [DataMember(Name="unit_id", EmitDefaultValue=false)]
    public int? UnitId { get; set; }

    
    /// <summary>
    /// measurements
    /// </summary>
    /// <value>measurements</value>
    [DataMember(Name="measurements", EmitDefaultValue=false)]
    public List<MeasurementValue> Measurements { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeasurementPost {\n");
      
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      
      sb.Append("  UnitId: ").Append(UnitId).Append("\n");
      
      sb.Append("  Measurements: ").Append(Measurements).Append("\n");
      
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
