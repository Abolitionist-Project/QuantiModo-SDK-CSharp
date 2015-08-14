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
  public class VariableUserSettings {
    
    /// <summary>
    /// User ID
    /// </summary>
    /// <value>User ID</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    public int? User { get; set; }

    
    /// <summary>
    /// Variable DISPLAY name
    /// </summary>
    /// <value>Variable DISPLAY name</value>
    [DataMember(Name="variable", EmitDefaultValue=false)]
    public string Variable { get; set; }

    
    /// <summary>
    /// Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect
    /// </summary>
    /// <value>Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</value>
    [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// fillingValue
    /// </summary>
    /// <value>fillingValue</value>
    [DataMember(Name="fillingValue", EmitDefaultValue=false)]
    public int? FillingValue { get; set; }

    
    /// <summary>
    /// joinWith
    /// </summary>
    /// <value>joinWith</value>
    [DataMember(Name="joinWith", EmitDefaultValue=false)]
    public string JoinWith { get; set; }

    
    /// <summary>
    /// maximumValue
    /// </summary>
    /// <value>maximumValue</value>
    [DataMember(Name="maximumValue", EmitDefaultValue=false)]
    public float? MaximumValue { get; set; }

    
    /// <summary>
    /// minimumValue
    /// </summary>
    /// <value>minimumValue</value>
    [DataMember(Name="minimumValue", EmitDefaultValue=false)]
    public float? MinimumValue { get; set; }

    
    /// <summary>
    /// name
    /// </summary>
    /// <value>name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// onsetDelay
    /// </summary>
    /// <value>onsetDelay</value>
    [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// unit
    /// </summary>
    /// <value>unit</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VariableUserSettings {\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("  Variable: ").Append(Variable).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      
      sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
      
      sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
      
      sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
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
