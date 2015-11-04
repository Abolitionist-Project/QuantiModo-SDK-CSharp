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
  public class VariableCategory {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// Name of the category
    /// </summary>
    /// <value>Name of the category</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Value for replacing null measurements
    /// </summary>
    /// <value>Value for replacing null measurements</value>
    [DataMember(Name="filling_value", EmitDefaultValue=false)]
    public float? FillingValue { get; set; }

    
    /// <summary>
    /// Maximum recorded value of this category
    /// </summary>
    /// <value>Maximum recorded value of this category</value>
    [DataMember(Name="maximum_allowed_value", EmitDefaultValue=false)]
    public float? MaximumAllowedValue { get; set; }

    
    /// <summary>
    /// Minimum recorded value of this category
    /// </summary>
    /// <value>Minimum recorded value of this category</value>
    [DataMember(Name="minimum_allowed_value", EmitDefaultValue=false)]
    public float? MinimumAllowedValue { get; set; }

    
    /// <summary>
    /// How long the effect of a measurement in this variable lasts
    /// </summary>
    /// <value>How long the effect of a measurement in this variable lasts</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// How long it takes for a measurement in this variable to take effect
    /// </summary>
    /// <value>How long it takes for a measurement in this variable to take effect</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// How to combine values of this variable (for instance, to see a summary of the values over a month) 0 for sum OR 1 for mean
    /// </summary>
    /// <value>How to combine values of this variable (for instance, to see a summary of the values over a month) 0 for sum OR 1 for mean</value>
    [DataMember(Name="combination_operation", EmitDefaultValue=false)]
    public string CombinationOperation { get; set; }

    
    /// <summary>
    /// updated
    /// </summary>
    /// <value>updated</value>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    public int? Updated { get; set; }

    
    /// <summary>
    /// A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user
    /// </summary>
    /// <value>A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</value>
    [DataMember(Name="cause_only", EmitDefaultValue=false)]
    public bool? CauseOnly { get; set; }

    
    /// <summary>
    /// Is category public
    /// </summary>
    /// <value>Is category public</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    public int? Public { get; set; }

    
    /// <summary>
    /// outcome
    /// </summary>
    /// <value>outcome</value>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    public bool? Outcome { get; set; }

    
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
    /// Image URL
    /// </summary>
    /// <value>Image URL</value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    public string ImageUrl { get; set; }

    
    /// <summary>
    /// ID of the default unit for the category
    /// </summary>
    /// <value>ID of the default unit for the category</value>
    [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
    public int? DefaultUnitId { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VariableCategory {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      
      sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
      
      sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
      
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      
      sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
      
      sb.Append("  Public: ").Append(Public).Append("\n");
      
      sb.Append("  Outcome: ").Append(Outcome).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      
      sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
      
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
