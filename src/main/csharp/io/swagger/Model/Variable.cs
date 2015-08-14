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
    
    /// <summary>
    /// Variable ID
    /// </summary>
    /// <value>Variable ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// User-defined variable display name.
    /// </summary>
    /// <value>User-defined variable display name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Name used when the variable was originally created in the `variables` table.
    /// </summary>
    /// <value>Name used when the variable was originally created in the `variables` table.</value>
    [DataMember(Name="originalName", EmitDefaultValue=false)]
    public string OriginalName { get; set; }

    
    /// <summary>
    /// Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc.
    /// </summary>
    /// <value>Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    public string Category { get; set; }

    
    /// <summary>
    /// Abbreviated name of the default unit for the variable
    /// </summary>
    /// <value>Abbreviated name of the default unit for the variable</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    
    /// <summary>
    /// Comma-separated list of source names to limit variables to those sources
    /// </summary>
    /// <value>Comma-separated list of source names to limit variables to those sources</value>
    [DataMember(Name="sources", EmitDefaultValue=false)]
    public string Sources { get; set; }

    
    /// <summary>
    /// Minimum reasonable value for this variable (uses default unit)
    /// </summary>
    /// <value>Minimum reasonable value for this variable (uses default unit)</value>
    [DataMember(Name="minimumValue", EmitDefaultValue=false)]
    public double? MinimumValue { get; set; }

    
    /// <summary>
    /// Maximum reasonable value for this variable (uses default unit)
    /// </summary>
    /// <value>Maximum reasonable value for this variable (uses default unit)</value>
    [DataMember(Name="maximumValue", EmitDefaultValue=false)]
    public double? MaximumValue { get; set; }

    
    /// <summary>
    /// How to aggregate measurements over time.
    /// </summary>
    /// <value>How to aggregate measurements over time.</value>
    [DataMember(Name="combinationOperation", EmitDefaultValue=false)]
    public string CombinationOperation { get; set; }

    
    /// <summary>
    /// Value for replacing null measurements
    /// </summary>
    /// <value>Value for replacing null measurements</value>
    [DataMember(Name="fillingValue", EmitDefaultValue=false)]
    public double? FillingValue { get; set; }

    
    /// <summary>
    /// The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables.
    /// </summary>
    /// <value>The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables.</value>
    [DataMember(Name="joinWith", EmitDefaultValue=false)]
    public string JoinWith { get; set; }

    
    /// <summary>
    /// Array of Variables that are joined with this Variable
    /// </summary>
    /// <value>Array of Variables that are joined with this Variable</value>
    [DataMember(Name="joinedVariables", EmitDefaultValue=false)]
    public List<Variable> JoinedVariables { get; set; }

    
    /// <summary>
    /// Id of the parent variable if this variable has any parent
    /// </summary>
    /// <value>Id of the parent variable if this variable has any parent</value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    public int? Parent { get; set; }

    
    /// <summary>
    /// Array of Variables that are sub variables to this Variable
    /// </summary>
    /// <value>Array of Variables that are sub variables to this Variable</value>
    [DataMember(Name="subVariables", EmitDefaultValue=false)]
    public List<Variable> SubVariables { get; set; }

    
    /// <summary>
    /// How long it takes for a measurement in this variable to take effect
    /// </summary>
    /// <value>How long it takes for a measurement in this variable to take effect</value>
    [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// How long the effect of a measurement in this variable lasts
    /// </summary>
    /// <value>How long the effect of a measurement in this variable lasts</value>
    [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// Earliest measurement time
    /// </summary>
    /// <value>Earliest measurement time</value>
    [DataMember(Name="earliestMeasurementTime", EmitDefaultValue=false)]
    public int? EarliestMeasurementTime { get; set; }

    
    /// <summary>
    /// Latest measurement time
    /// </summary>
    /// <value>Latest measurement time</value>
    [DataMember(Name="latestMeasurementTime", EmitDefaultValue=false)]
    public int? LatestMeasurementTime { get; set; }

    
    /// <summary>
    /// When this variable or its settings were last updated
    /// </summary>
    /// <value>When this variable or its settings were last updated</value>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    public int? Updated { get; set; }

    
    /// <summary>
    /// A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user.
    /// </summary>
    /// <value>A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user.</value>
    [DataMember(Name="causeOnly", EmitDefaultValue=false)]
    public int? CauseOnly { get; set; }

    
    /// <summary>
    /// Number of correlations
    /// </summary>
    /// <value>Number of correlations</value>
    [DataMember(Name="numberOfCorrelations", EmitDefaultValue=false)]
    public int? NumberOfCorrelations { get; set; }

    
    /// <summary>
    /// Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.
    /// </summary>
    /// <value>Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</value>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    public int? Outcome { get; set; }

    
    /// <summary>
    /// The number of measurements that a given user had for this variable the last time a correlation calculation was performed. Generally correlation values are only updated once the current number of measurements for a variable is more than 10% greater than the measurementsAtLastAnalysis.  This avoids a computationally-demanding recalculation when there's not enough new data to make a significant difference in the correlation.
    /// </summary>
    /// <value>The number of measurements that a given user had for this variable the last time a correlation calculation was performed. Generally correlation values are only updated once the current number of measurements for a variable is more than 10% greater than the measurementsAtLastAnalysis.  This avoids a computationally-demanding recalculation when there's not enough new data to make a significant difference in the correlation.</value>
    [DataMember(Name="measurementsAtLastAnalysis", EmitDefaultValue=false)]
    public int? MeasurementsAtLastAnalysis { get; set; }

    
    /// <summary>
    /// Number of measurements
    /// </summary>
    /// <value>Number of measurements</value>
    [DataMember(Name="numberOfMeasurements", EmitDefaultValue=false)]
    public int? NumberOfMeasurements { get; set; }

    
    /// <summary>
    /// Last unit
    /// </summary>
    /// <value>Last unit</value>
    [DataMember(Name="lastUnit", EmitDefaultValue=false)]
    public int? LastUnit { get; set; }

    
    /// <summary>
    /// Last value
    /// </summary>
    /// <value>Last value</value>
    [DataMember(Name="lastValue", EmitDefaultValue=false)]
    public int? LastValue { get; set; }

    
    /// <summary>
    /// Most common value
    /// </summary>
    /// <value>Most common value</value>
    [DataMember(Name="mostCommonValue", EmitDefaultValue=false)]
    public int? MostCommonValue { get; set; }

    
    /// <summary>
    /// Most common unit
    /// </summary>
    /// <value>Most common unit</value>
    [DataMember(Name="mostCommonUnit", EmitDefaultValue=false)]
    public int? MostCommonUnit { get; set; }

    
    /// <summary>
    /// Last source
    /// </summary>
    /// <value>Last source</value>
    [DataMember(Name="lastSource", EmitDefaultValue=false)]
    public int? LastSource { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Variable {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
      
      sb.Append("  Category: ").Append(Category).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
      sb.Append("  Sources: ").Append(Sources).Append("\n");
      
      sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
      
      sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
      
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
      
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      
      sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
      
      sb.Append("  JoinedVariables: ").Append(JoinedVariables).Append("\n");
      
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      
      sb.Append("  SubVariables: ").Append(SubVariables).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  EarliestMeasurementTime: ").Append(EarliestMeasurementTime).Append("\n");
      
      sb.Append("  LatestMeasurementTime: ").Append(LatestMeasurementTime).Append("\n");
      
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      
      sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
      
      sb.Append("  NumberOfCorrelations: ").Append(NumberOfCorrelations).Append("\n");
      
      sb.Append("  Outcome: ").Append(Outcome).Append("\n");
      
      sb.Append("  MeasurementsAtLastAnalysis: ").Append(MeasurementsAtLastAnalysis).Append("\n");
      
      sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
      
      sb.Append("  LastUnit: ").Append(LastUnit).Append("\n");
      
      sb.Append("  LastValue: ").Append(LastValue).Append("\n");
      
      sb.Append("  MostCommonValue: ").Append(MostCommonValue).Append("\n");
      
      sb.Append("  MostCommonUnit: ").Append(MostCommonUnit).Append("\n");
      
      sb.Append("  LastSource: ").Append(LastSource).Append("\n");
      
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
