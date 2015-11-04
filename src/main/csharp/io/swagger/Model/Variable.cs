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
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /// <summary>
    /// client_id
    /// </summary>
    /// <value>client_id</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    public string ClientId { get; set; }

    
    /// <summary>
    /// parent_id
    /// </summary>
    /// <value>parent_id</value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    public int? ParentId { get; set; }

    
    /// <summary>
    /// Name of the variable
    /// </summary>
    /// <value>Name of the variable</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Category of the variable
    /// </summary>
    /// <value>Category of the variable</value>
    [DataMember(Name="variable_category_id", EmitDefaultValue=false)]
    public int? VariableCategoryId { get; set; }

    
    /// <summary>
    /// ID of the default unit of measurement to use for this variable
    /// </summary>
    /// <value>ID of the default unit of measurement to use for this variable</value>
    [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
    public int? DefaultUnitId { get; set; }

    
    /// <summary>
    /// How to combine values of this variable (for instance, to see a summary of the values over a month) 0 for sum OR 1 for mean
    /// </summary>
    /// <value>How to combine values of this variable (for instance, to see a summary of the values over a month) 0 for sum OR 1 for mean</value>
    [DataMember(Name="combination_operation", EmitDefaultValue=false)]
    public string CombinationOperation { get; set; }

    
    /// <summary>
    /// filling_value
    /// </summary>
    /// <value>filling_value</value>
    [DataMember(Name="filling_value", EmitDefaultValue=false)]
    public float? FillingValue { get; set; }

    
    /// <summary>
    /// maximum_allowed_value
    /// </summary>
    /// <value>maximum_allowed_value</value>
    [DataMember(Name="maximum_allowed_value", EmitDefaultValue=false)]
    public float? MaximumAllowedValue { get; set; }

    
    /// <summary>
    /// minimum_allowed_value
    /// </summary>
    /// <value>minimum_allowed_value</value>
    [DataMember(Name="minimum_allowed_value", EmitDefaultValue=false)]
    public float? MinimumAllowedValue { get; set; }

    
    /// <summary>
    /// onset_delay
    /// </summary>
    /// <value>onset_delay</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// duration_of_action
    /// </summary>
    /// <value>duration_of_action</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// public
    /// </summary>
    /// <value>public</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    public int? Public { get; set; }

    
    /// <summary>
    /// cause_only
    /// </summary>
    /// <value>cause_only</value>
    [DataMember(Name="cause_only", EmitDefaultValue=false)]
    public bool? CauseOnly { get; set; }

    
    /// <summary>
    /// most_common_value
    /// </summary>
    /// <value>most_common_value</value>
    [DataMember(Name="most_common_value", EmitDefaultValue=false)]
    public float? MostCommonValue { get; set; }

    
    /// <summary>
    /// most_common_unit_id
    /// </summary>
    /// <value>most_common_unit_id</value>
    [DataMember(Name="most_common_unit_id", EmitDefaultValue=false)]
    public int? MostCommonUnitId { get; set; }

    
    /// <summary>
    /// standard_deviation
    /// </summary>
    /// <value>standard_deviation</value>
    [DataMember(Name="standard_deviation", EmitDefaultValue=false)]
    public float? StandardDeviation { get; set; }

    
    /// <summary>
    /// variance
    /// </summary>
    /// <value>variance</value>
    [DataMember(Name="variance", EmitDefaultValue=false)]
    public float? Variance { get; set; }

    
    /// <summary>
    /// mean
    /// </summary>
    /// <value>mean</value>
    [DataMember(Name="mean", EmitDefaultValue=false)]
    public float? Mean { get; set; }

    
    /// <summary>
    /// median
    /// </summary>
    /// <value>median</value>
    [DataMember(Name="median", EmitDefaultValue=false)]
    public float? Median { get; set; }

    
    /// <summary>
    /// number_of_measurements
    /// </summary>
    /// <value>number_of_measurements</value>
    [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
    public float? NumberOfMeasurements { get; set; }

    
    /// <summary>
    /// number_of_unique_values
    /// </summary>
    /// <value>number_of_unique_values</value>
    [DataMember(Name="number_of_unique_values", EmitDefaultValue=false)]
    public float? NumberOfUniqueValues { get; set; }

    
    /// <summary>
    /// skewness
    /// </summary>
    /// <value>skewness</value>
    [DataMember(Name="skewness", EmitDefaultValue=false)]
    public float? Skewness { get; set; }

    
    /// <summary>
    /// kurtosis
    /// </summary>
    /// <value>kurtosis</value>
    [DataMember(Name="kurtosis", EmitDefaultValue=false)]
    public float? Kurtosis { get; set; }

    
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
    /// last_successful_update_time
    /// </summary>
    /// <value>last_successful_update_time</value>
    [DataMember(Name="last_successful_update_time", EmitDefaultValue=false)]
    public DateTime? LastSuccessfulUpdateTime { get; set; }

    
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
    /// product_url
    /// </summary>
    /// <value>product_url</value>
    [DataMember(Name="product_url", EmitDefaultValue=false)]
    public string ProductUrl { get; set; }

    
    /// <summary>
    /// image_url
    /// </summary>
    /// <value>image_url</value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    public string ImageUrl { get; set; }

    
    /// <summary>
    /// price
    /// </summary>
    /// <value>price</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    public float? Price { get; set; }

    
    /// <summary>
    /// number_of_user_variables
    /// </summary>
    /// <value>number_of_user_variables</value>
    [DataMember(Name="number_of_user_variables", EmitDefaultValue=false)]
    public int? NumberOfUserVariables { get; set; }

    
    /// <summary>
    /// outcome
    /// </summary>
    /// <value>outcome</value>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    public bool? Outcome { get; set; }

    
    /// <summary>
    /// minimum_recorded_value
    /// </summary>
    /// <value>minimum_recorded_value</value>
    [DataMember(Name="minimum_recorded_value", EmitDefaultValue=false)]
    public float? MinimumRecordedValue { get; set; }

    
    /// <summary>
    /// maximum_recorded_value
    /// </summary>
    /// <value>maximum_recorded_value</value>
    [DataMember(Name="maximum_recorded_value", EmitDefaultValue=false)]
    public float? MaximumRecordedValue { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Variable {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  VariableCategoryId: ").Append(VariableCategoryId).Append("\n");
      
      sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
      
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
      
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      
      sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
      
      sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  Public: ").Append(Public).Append("\n");
      
      sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
      
      sb.Append("  MostCommonValue: ").Append(MostCommonValue).Append("\n");
      
      sb.Append("  MostCommonUnitId: ").Append(MostCommonUnitId).Append("\n");
      
      sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
      
      sb.Append("  Variance: ").Append(Variance).Append("\n");
      
      sb.Append("  Mean: ").Append(Mean).Append("\n");
      
      sb.Append("  Median: ").Append(Median).Append("\n");
      
      sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
      
      sb.Append("  NumberOfUniqueValues: ").Append(NumberOfUniqueValues).Append("\n");
      
      sb.Append("  Skewness: ").Append(Skewness).Append("\n");
      
      sb.Append("  Kurtosis: ").Append(Kurtosis).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      
      sb.Append("  LastSuccessfulUpdateTime: ").Append(LastSuccessfulUpdateTime).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
      sb.Append("  ProductUrl: ").Append(ProductUrl).Append("\n");
      
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      
      sb.Append("  Price: ").Append(Price).Append("\n");
      
      sb.Append("  NumberOfUserVariables: ").Append(NumberOfUserVariables).Append("\n");
      
      sb.Append("  Outcome: ").Append(Outcome).Append("\n");
      
      sb.Append("  MinimumRecordedValue: ").Append(MinimumRecordedValue).Append("\n");
      
      sb.Append("  MaximumRecordedValue: ").Append(MaximumRecordedValue).Append("\n");
      
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
