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
  public class UserVariable {
    
    /// <summary>
    /// ID of the parent variable if this variable has any parent
    /// </summary>
    /// <value>ID of the parent variable if this variable has any parent</value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    public int? ParentId { get; set; }

    
    /// <summary>
    /// client_id
    /// </summary>
    /// <value>client_id</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    public string ClientId { get; set; }

    
    /// <summary>
    /// ID of variable
    /// </summary>
    /// <value>ID of variable</value>
    [DataMember(Name="variable_id", EmitDefaultValue=false)]
    public int? VariableId { get; set; }

    
    /// <summary>
    /// ID of unit to use for this variable
    /// </summary>
    /// <value>ID of unit to use for this variable</value>
    [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
    public int? DefaultUnitId { get; set; }

    
    /// <summary>
    /// Minimum reasonable value for this variable (uses default unit)
    /// </summary>
    /// <value>Minimum reasonable value for this variable (uses default unit)</value>
    [DataMember(Name="minimum_allowed_value", EmitDefaultValue=false)]
    public float? MinimumAllowedValue { get; set; }

    
    /// <summary>
    /// Maximum reasonable value for this variable (uses default unit)
    /// </summary>
    /// <value>Maximum reasonable value for this variable (uses default unit)</value>
    [DataMember(Name="maximum_allowed_value", EmitDefaultValue=false)]
    public float? MaximumAllowedValue { get; set; }

    
    /// <summary>
    /// Value for replacing null measurements
    /// </summary>
    /// <value>Value for replacing null measurements</value>
    [DataMember(Name="filling_value", EmitDefaultValue=false)]
    public float? FillingValue { get; set; }

    
    /// <summary>
    /// The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables
    /// </summary>
    /// <value>The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</value>
    [DataMember(Name="join_with", EmitDefaultValue=false)]
    public int? JoinWith { get; set; }

    
    /// <summary>
    /// How long it takes for a measurement in this variable to take effect
    /// </summary>
    /// <value>How long it takes for a measurement in this variable to take effect</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect
    /// </summary>
    /// <value>Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// ID of variable category
    /// </summary>
    /// <value>ID of variable category</value>
    [DataMember(Name="variable_category_id", EmitDefaultValue=false)]
    public int? VariableCategoryId { get; set; }

    
    /// <summary>
    /// updated
    /// </summary>
    /// <value>updated</value>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    public int? Updated { get; set; }

    
    /// <summary>
    /// Is variable public
    /// </summary>
    /// <value>Is variable public</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    public int? Public { get; set; }

    
    /// <summary>
    /// A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user
    /// </summary>
    /// <value>A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</value>
    [DataMember(Name="cause_only", EmitDefaultValue=false)]
    public bool? CauseOnly { get; set; }

    
    /// <summary>
    /// 0 -> No filling, 1 -> Use filling-value
    /// </summary>
    /// <value>0 -> No filling, 1 -> Use filling-value</value>
    [DataMember(Name="filling_type", EmitDefaultValue=false)]
    public string FillingType { get; set; }

    
    /// <summary>
    /// Number of measurements
    /// </summary>
    /// <value>Number of measurements</value>
    [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
    public int? NumberOfMeasurements { get; set; }

    
    /// <summary>
    /// Number of processed measurements
    /// </summary>
    /// <value>Number of processed measurements</value>
    [DataMember(Name="number_of_processed_measurements", EmitDefaultValue=false)]
    public int? NumberOfProcessedMeasurements { get; set; }

    
    /// <summary>
    /// Number of measurements at last analysis
    /// </summary>
    /// <value>Number of measurements at last analysis</value>
    [DataMember(Name="measurements_at_last_analysis", EmitDefaultValue=false)]
    public int? MeasurementsAtLastAnalysis { get; set; }

    
    /// <summary>
    /// ID of last Unit
    /// </summary>
    /// <value>ID of last Unit</value>
    [DataMember(Name="last_unit_id", EmitDefaultValue=false)]
    public int? LastUnitId { get; set; }

    
    /// <summary>
    /// ID of last original Unit
    /// </summary>
    /// <value>ID of last original Unit</value>
    [DataMember(Name="last_original_unit_id", EmitDefaultValue=false)]
    public int? LastOriginalUnitId { get; set; }

    
    /// <summary>
    /// Last Value
    /// </summary>
    /// <value>Last Value</value>
    [DataMember(Name="last_value", EmitDefaultValue=false)]
    public float? LastValue { get; set; }

    
    /// <summary>
    /// Last original value which is stored
    /// </summary>
    /// <value>Last original value which is stored</value>
    [DataMember(Name="last_original_value", EmitDefaultValue=false)]
    public int? LastOriginalValue { get; set; }

    
    /// <summary>
    /// ID of last source
    /// </summary>
    /// <value>ID of last source</value>
    [DataMember(Name="last_source_id", EmitDefaultValue=false)]
    public int? LastSourceId { get; set; }

    
    /// <summary>
    /// Number of correlations for this variable
    /// </summary>
    /// <value>Number of correlations for this variable</value>
    [DataMember(Name="number_of_correlations", EmitDefaultValue=false)]
    public int? NumberOfCorrelations { get; set; }

    
    /// <summary>
    /// status
    /// </summary>
    /// <value>status</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /// <summary>
    /// error_message
    /// </summary>
    /// <value>error_message</value>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    public string ErrorMessage { get; set; }

    
    /// <summary>
    /// When this variable or its settings were last updated
    /// </summary>
    /// <value>When this variable or its settings were last updated</value>
    [DataMember(Name="last_successful_update_time", EmitDefaultValue=false)]
    public DateTime? LastSuccessfulUpdateTime { get; set; }

    
    /// <summary>
    /// Standard deviation
    /// </summary>
    /// <value>Standard deviation</value>
    [DataMember(Name="standard_deviation", EmitDefaultValue=false)]
    public float? StandardDeviation { get; set; }

    
    /// <summary>
    /// Variance
    /// </summary>
    /// <value>Variance</value>
    [DataMember(Name="variance", EmitDefaultValue=false)]
    public float? Variance { get; set; }

    
    /// <summary>
    /// Minimum recorded daily value of this variable
    /// </summary>
    /// <value>Minimum recorded daily value of this variable</value>
    [DataMember(Name="minimum_recorded_daily_value", EmitDefaultValue=false)]
    public float? MinimumRecordedDailyValue { get; set; }

    
    /// <summary>
    /// Maximum recorded daily value of this variable
    /// </summary>
    /// <value>Maximum recorded daily value of this variable</value>
    [DataMember(Name="maximum_recorded_daily_value", EmitDefaultValue=false)]
    public float? MaximumRecordedDailyValue { get; set; }

    
    /// <summary>
    /// Mean
    /// </summary>
    /// <value>Mean</value>
    [DataMember(Name="mean", EmitDefaultValue=false)]
    public float? Mean { get; set; }

    
    /// <summary>
    /// Median
    /// </summary>
    /// <value>Median</value>
    [DataMember(Name="median", EmitDefaultValue=false)]
    public float? Median { get; set; }

    
    /// <summary>
    /// Most common Unit ID
    /// </summary>
    /// <value>Most common Unit ID</value>
    [DataMember(Name="most_common_unit_id", EmitDefaultValue=false)]
    public int? MostCommonUnitId { get; set; }

    
    /// <summary>
    /// Most common value
    /// </summary>
    /// <value>Most common value</value>
    [DataMember(Name="most_common_value", EmitDefaultValue=false)]
    public float? MostCommonValue { get; set; }

    
    /// <summary>
    /// Number of unique daily values
    /// </summary>
    /// <value>Number of unique daily values</value>
    [DataMember(Name="number_of_unique_daily_values", EmitDefaultValue=false)]
    public float? NumberOfUniqueDailyValues { get; set; }

    
    /// <summary>
    /// Number of changes
    /// </summary>
    /// <value>Number of changes</value>
    [DataMember(Name="number_of_changes", EmitDefaultValue=false)]
    public int? NumberOfChanges { get; set; }

    
    /// <summary>
    /// Skewness
    /// </summary>
    /// <value>Skewness</value>
    [DataMember(Name="skewness", EmitDefaultValue=false)]
    public float? Skewness { get; set; }

    
    /// <summary>
    /// Kurtosis
    /// </summary>
    /// <value>Kurtosis</value>
    [DataMember(Name="kurtosis", EmitDefaultValue=false)]
    public float? Kurtosis { get; set; }

    
    /// <summary>
    /// Latitude
    /// </summary>
    /// <value>Latitude</value>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    public float? Latitude { get; set; }

    
    /// <summary>
    /// Longitude
    /// </summary>
    /// <value>Longitude</value>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    public float? Longitude { get; set; }

    
    /// <summary>
    /// Location
    /// </summary>
    /// <value>Location</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    public string Location { get; set; }

    
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
    /// Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables
    /// </summary>
    /// <value>Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</value>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    public bool? Outcome { get; set; }

    
    /// <summary>
    /// Comma-separated list of source names to limit variables to those sources
    /// </summary>
    /// <value>Comma-separated list of source names to limit variables to those sources</value>
    [DataMember(Name="sources", EmitDefaultValue=false)]
    public string Sources { get; set; }

    
    /// <summary>
    /// Earliest source time
    /// </summary>
    /// <value>Earliest source time</value>
    [DataMember(Name="earliest_source_time", EmitDefaultValue=false)]
    public int? EarliestSourceTime { get; set; }

    
    /// <summary>
    /// Latest source time
    /// </summary>
    /// <value>Latest source time</value>
    [DataMember(Name="latest_source_time", EmitDefaultValue=false)]
    public int? LatestSourceTime { get; set; }

    
    /// <summary>
    /// Earliest measurement time
    /// </summary>
    /// <value>Earliest measurement time</value>
    [DataMember(Name="earliest_measurement_time", EmitDefaultValue=false)]
    public int? EarliestMeasurementTime { get; set; }

    
    /// <summary>
    /// Latest measurement time
    /// </summary>
    /// <value>Latest measurement time</value>
    [DataMember(Name="latest_measurement_time", EmitDefaultValue=false)]
    public int? LatestMeasurementTime { get; set; }

    
    /// <summary>
    /// Earliest filling time
    /// </summary>
    /// <value>Earliest filling time</value>
    [DataMember(Name="earliest_filling_time", EmitDefaultValue=false)]
    public int? EarliestFillingTime { get; set; }

    
    /// <summary>
    /// Latest filling time
    /// </summary>
    /// <value>Latest filling time</value>
    [DataMember(Name="latest_filling_time", EmitDefaultValue=false)]
    public int? LatestFillingTime { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserVariable {\n");
      
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      
      sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
      
      sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
      
      sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
      
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      
      sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  VariableCategoryId: ").Append(VariableCategoryId).Append("\n");
      
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      
      sb.Append("  Public: ").Append(Public).Append("\n");
      
      sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
      
      sb.Append("  FillingType: ").Append(FillingType).Append("\n");
      
      sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
      
      sb.Append("  NumberOfProcessedMeasurements: ").Append(NumberOfProcessedMeasurements).Append("\n");
      
      sb.Append("  MeasurementsAtLastAnalysis: ").Append(MeasurementsAtLastAnalysis).Append("\n");
      
      sb.Append("  LastUnitId: ").Append(LastUnitId).Append("\n");
      
      sb.Append("  LastOriginalUnitId: ").Append(LastOriginalUnitId).Append("\n");
      
      sb.Append("  LastValue: ").Append(LastValue).Append("\n");
      
      sb.Append("  LastOriginalValue: ").Append(LastOriginalValue).Append("\n");
      
      sb.Append("  LastSourceId: ").Append(LastSourceId).Append("\n");
      
      sb.Append("  NumberOfCorrelations: ").Append(NumberOfCorrelations).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      
      sb.Append("  LastSuccessfulUpdateTime: ").Append(LastSuccessfulUpdateTime).Append("\n");
      
      sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
      
      sb.Append("  Variance: ").Append(Variance).Append("\n");
      
      sb.Append("  MinimumRecordedDailyValue: ").Append(MinimumRecordedDailyValue).Append("\n");
      
      sb.Append("  MaximumRecordedDailyValue: ").Append(MaximumRecordedDailyValue).Append("\n");
      
      sb.Append("  Mean: ").Append(Mean).Append("\n");
      
      sb.Append("  Median: ").Append(Median).Append("\n");
      
      sb.Append("  MostCommonUnitId: ").Append(MostCommonUnitId).Append("\n");
      
      sb.Append("  MostCommonValue: ").Append(MostCommonValue).Append("\n");
      
      sb.Append("  NumberOfUniqueDailyValues: ").Append(NumberOfUniqueDailyValues).Append("\n");
      
      sb.Append("  NumberOfChanges: ").Append(NumberOfChanges).Append("\n");
      
      sb.Append("  Skewness: ").Append(Skewness).Append("\n");
      
      sb.Append("  Kurtosis: ").Append(Kurtosis).Append("\n");
      
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      
      sb.Append("  Location: ").Append(Location).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
      sb.Append("  Outcome: ").Append(Outcome).Append("\n");
      
      sb.Append("  Sources: ").Append(Sources).Append("\n");
      
      sb.Append("  EarliestSourceTime: ").Append(EarliestSourceTime).Append("\n");
      
      sb.Append("  LatestSourceTime: ").Append(LatestSourceTime).Append("\n");
      
      sb.Append("  EarliestMeasurementTime: ").Append(EarliestMeasurementTime).Append("\n");
      
      sb.Append("  LatestMeasurementTime: ").Append(LatestMeasurementTime).Append("\n");
      
      sb.Append("  EarliestFillingTime: ").Append(EarliestFillingTime).Append("\n");
      
      sb.Append("  LatestFillingTime: ").Append(LatestFillingTime).Append("\n");
      
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
