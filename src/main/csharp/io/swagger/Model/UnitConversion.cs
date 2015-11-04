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
  public class UnitConversion {
    
    /// <summary>
    /// unit_id
    /// </summary>
    /// <value>unit_id</value>
    [DataMember(Name="unit_id", EmitDefaultValue=false)]
    public int? UnitId { get; set; }

    
    /// <summary>
    /// step in the conversion process
    /// </summary>
    /// <value>step in the conversion process</value>
    [DataMember(Name="step_number", EmitDefaultValue=false)]
    public bool? StepNumber { get; set; }

    
    /// <summary>
    /// 0 is add and 1 is multiply
    /// </summary>
    /// <value>0 is add and 1 is multiply</value>
    [DataMember(Name="operation", EmitDefaultValue=false)]
    public bool? Operation { get; set; }

    
    /// <summary>
    /// number used in the operation
    /// </summary>
    /// <value>number used in the operation</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    public float? Value { get; set; }

    
    /// <summary>
    /// created_at
    /// </summary>
    /// <value>created_at</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    public DateTime? CreatedAt { get; set; }

    
    /// <summary>
    /// updated_at
    /// </summary>
    /// <value>updated_at</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    public DateTime? UpdatedAt { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnitConversion {\n");
      
      sb.Append("  UnitId: ").Append(UnitId).Append("\n");
      
      sb.Append("  StepNumber: ").Append(StepNumber).Append("\n");
      
      sb.Append("  Operation: ").Append(Operation).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
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
