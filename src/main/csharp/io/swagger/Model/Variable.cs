using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Variable : IEquatable<Variable>
    {
        
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
        /// ID of the parent variable if this variable has any parent
        /// </summary>
        /// <value>ID of the parent variable if this variable has any parent</value>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public int? ParentId { get; set; }
  
        
        /// <summary>
        /// User-defined variable display name
        /// </summary>
        /// <value>User-defined variable display name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Variable category ID
        /// </summary>
        /// <value>Variable category ID</value>
        [DataMember(Name="variable_category_id", EmitDefaultValue=false)]
        public int? VariableCategoryId { get; set; }
  
        
        /// <summary>
        /// ID of the default unit of measurement to use for this variable
        /// </summary>
        /// <value>ID of the default unit of measurement to use for this variable</value>
        [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
        public int? DefaultUnitId { get; set; }
  
        
        /// <summary>
        /// How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN
        /// </summary>
        /// <value>How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</value>
        [DataMember(Name="combination_operation", EmitDefaultValue=false)]
        public string CombinationOperation { get; set; }
  
        
        /// <summary>
        /// Value for replacing null measurements
        /// </summary>
        /// <value>Value for replacing null measurements</value>
        [DataMember(Name="filling_value", EmitDefaultValue=false)]
        public float? FillingValue { get; set; }
  
        
        /// <summary>
        /// Maximum reasonable value for this variable (uses default unit)
        /// </summary>
        /// <value>Maximum reasonable value for this variable (uses default unit)</value>
        [DataMember(Name="maximum_allowed_value", EmitDefaultValue=false)]
        public float? MaximumAllowedValue { get; set; }
  
        
        /// <summary>
        /// Minimum reasonable value for this variable (uses default unit)
        /// </summary>
        /// <value>Minimum reasonable value for this variable (uses default unit)</value>
        [DataMember(Name="minimum_allowed_value", EmitDefaultValue=false)]
        public float? MinimumAllowedValue { get; set; }
  
        
        /// <summary>
        /// How long it takes for a measurement in this variable to take effect
        /// </summary>
        /// <value>How long it takes for a measurement in this variable to take effect</value>
        [DataMember(Name="onset_delay", EmitDefaultValue=false)]
        public int? OnsetDelay { get; set; }
  
        
        /// <summary>
        /// How long the effect of a measurement in this variable lasts
        /// </summary>
        /// <value>How long the effect of a measurement in this variable lasts</value>
        [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
        public int? DurationOfAction { get; set; }
  
        
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
        /// Most common value
        /// </summary>
        /// <value>Most common value</value>
        [DataMember(Name="most_common_value", EmitDefaultValue=false)]
        public float? MostCommonValue { get; set; }
  
        
        /// <summary>
        /// Most common Unit
        /// </summary>
        /// <value>Most common Unit</value>
        [DataMember(Name="most_common_unit_id", EmitDefaultValue=false)]
        public int? MostCommonUnitId { get; set; }
  
        
        /// <summary>
        /// Standard Deviation
        /// </summary>
        /// <value>Standard Deviation</value>
        [DataMember(Name="standard_deviation", EmitDefaultValue=false)]
        public float? StandardDeviation { get; set; }
  
        
        /// <summary>
        /// Variance
        /// </summary>
        /// <value>Variance</value>
        [DataMember(Name="variance", EmitDefaultValue=false)]
        public float? Variance { get; set; }
  
        
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
        /// Number of measurements
        /// </summary>
        /// <value>Number of measurements</value>
        [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
        public float? NumberOfMeasurements { get; set; }
  
        
        /// <summary>
        /// Number of unique values
        /// </summary>
        /// <value>Number of unique values</value>
        [DataMember(Name="number_of_unique_values", EmitDefaultValue=false)]
        public float? NumberOfUniqueValues { get; set; }
  
        
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
        /// When the record was first created. Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the record was first created. Use ISO 8601 datetime format</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
  
        
        /// <summary>
        /// When the record in the database was last updated. Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the record in the database was last updated. Use ISO 8601 datetime format</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
  
        
        /// <summary>
        /// Product URL
        /// </summary>
        /// <value>Product URL</value>
        [DataMember(Name="product_url", EmitDefaultValue=false)]
        public string ProductUrl { get; set; }
  
        
        /// <summary>
        /// Image URL
        /// </summary>
        /// <value>Image URL</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }
  
        
        /// <summary>
        /// Price
        /// </summary>
        /// <value>Price</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public float? Price { get; set; }
  
        
        /// <summary>
        /// Number of variables
        /// </summary>
        /// <value>Number of variables</value>
        [DataMember(Name="number_of_user_variables", EmitDefaultValue=false)]
        public int? NumberOfUserVariables { get; set; }
  
        
        /// <summary>
        /// Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.
        /// </summary>
        /// <value>Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</value>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public bool? Outcome { get; set; }
  
        
        /// <summary>
        /// Minimum recorded value of this variable
        /// </summary>
        /// <value>Minimum recorded value of this variable</value>
        [DataMember(Name="minimum_recorded_value", EmitDefaultValue=false)]
        public float? MinimumRecordedValue { get; set; }
  
        
        /// <summary>
        /// Maximum recorded value of this variable
        /// </summary>
        /// <value>Maximum recorded value of this variable</value>
        [DataMember(Name="maximum_recorded_value", EmitDefaultValue=false)]
        public float? MaximumRecordedValue { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Variable);
        }

        /// <summary>
        /// Returns true if Variable instances are equal
        /// </summary>
        /// <param name="obj">Instance of Variable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Variable other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.VariableCategoryId == other.VariableCategoryId ||
                    this.VariableCategoryId != null &&
                    this.VariableCategoryId.Equals(other.VariableCategoryId)
                ) && 
                (
                    this.DefaultUnitId == other.DefaultUnitId ||
                    this.DefaultUnitId != null &&
                    this.DefaultUnitId.Equals(other.DefaultUnitId)
                ) && 
                (
                    this.CombinationOperation == other.CombinationOperation ||
                    this.CombinationOperation != null &&
                    this.CombinationOperation.Equals(other.CombinationOperation)
                ) && 
                (
                    this.FillingValue == other.FillingValue ||
                    this.FillingValue != null &&
                    this.FillingValue.Equals(other.FillingValue)
                ) && 
                (
                    this.MaximumAllowedValue == other.MaximumAllowedValue ||
                    this.MaximumAllowedValue != null &&
                    this.MaximumAllowedValue.Equals(other.MaximumAllowedValue)
                ) && 
                (
                    this.MinimumAllowedValue == other.MinimumAllowedValue ||
                    this.MinimumAllowedValue != null &&
                    this.MinimumAllowedValue.Equals(other.MinimumAllowedValue)
                ) && 
                (
                    this.OnsetDelay == other.OnsetDelay ||
                    this.OnsetDelay != null &&
                    this.OnsetDelay.Equals(other.OnsetDelay)
                ) && 
                (
                    this.DurationOfAction == other.DurationOfAction ||
                    this.DurationOfAction != null &&
                    this.DurationOfAction.Equals(other.DurationOfAction)
                ) && 
                (
                    this.Public == other.Public ||
                    this.Public != null &&
                    this.Public.Equals(other.Public)
                ) && 
                (
                    this.CauseOnly == other.CauseOnly ||
                    this.CauseOnly != null &&
                    this.CauseOnly.Equals(other.CauseOnly)
                ) && 
                (
                    this.MostCommonValue == other.MostCommonValue ||
                    this.MostCommonValue != null &&
                    this.MostCommonValue.Equals(other.MostCommonValue)
                ) && 
                (
                    this.MostCommonUnitId == other.MostCommonUnitId ||
                    this.MostCommonUnitId != null &&
                    this.MostCommonUnitId.Equals(other.MostCommonUnitId)
                ) && 
                (
                    this.StandardDeviation == other.StandardDeviation ||
                    this.StandardDeviation != null &&
                    this.StandardDeviation.Equals(other.StandardDeviation)
                ) && 
                (
                    this.Variance == other.Variance ||
                    this.Variance != null &&
                    this.Variance.Equals(other.Variance)
                ) && 
                (
                    this.Mean == other.Mean ||
                    this.Mean != null &&
                    this.Mean.Equals(other.Mean)
                ) && 
                (
                    this.Median == other.Median ||
                    this.Median != null &&
                    this.Median.Equals(other.Median)
                ) && 
                (
                    this.NumberOfMeasurements == other.NumberOfMeasurements ||
                    this.NumberOfMeasurements != null &&
                    this.NumberOfMeasurements.Equals(other.NumberOfMeasurements)
                ) && 
                (
                    this.NumberOfUniqueValues == other.NumberOfUniqueValues ||
                    this.NumberOfUniqueValues != null &&
                    this.NumberOfUniqueValues.Equals(other.NumberOfUniqueValues)
                ) && 
                (
                    this.Skewness == other.Skewness ||
                    this.Skewness != null &&
                    this.Skewness.Equals(other.Skewness)
                ) && 
                (
                    this.Kurtosis == other.Kurtosis ||
                    this.Kurtosis != null &&
                    this.Kurtosis.Equals(other.Kurtosis)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.LastSuccessfulUpdateTime == other.LastSuccessfulUpdateTime ||
                    this.LastSuccessfulUpdateTime != null &&
                    this.LastSuccessfulUpdateTime.Equals(other.LastSuccessfulUpdateTime)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.ProductUrl == other.ProductUrl ||
                    this.ProductUrl != null &&
                    this.ProductUrl.Equals(other.ProductUrl)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.NumberOfUserVariables == other.NumberOfUserVariables ||
                    this.NumberOfUserVariables != null &&
                    this.NumberOfUserVariables.Equals(other.NumberOfUserVariables)
                ) && 
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
                ) && 
                (
                    this.MinimumRecordedValue == other.MinimumRecordedValue ||
                    this.MinimumRecordedValue != null &&
                    this.MinimumRecordedValue.Equals(other.MinimumRecordedValue)
                ) && 
                (
                    this.MaximumRecordedValue == other.MaximumRecordedValue ||
                    this.MaximumRecordedValue != null &&
                    this.MaximumRecordedValue.Equals(other.MaximumRecordedValue)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.ClientId != null)
                    hash = hash * 57 + this.ClientId.GetHashCode();
                
                if (this.ParentId != null)
                    hash = hash * 57 + this.ParentId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.VariableCategoryId != null)
                    hash = hash * 57 + this.VariableCategoryId.GetHashCode();
                
                if (this.DefaultUnitId != null)
                    hash = hash * 57 + this.DefaultUnitId.GetHashCode();
                
                if (this.CombinationOperation != null)
                    hash = hash * 57 + this.CombinationOperation.GetHashCode();
                
                if (this.FillingValue != null)
                    hash = hash * 57 + this.FillingValue.GetHashCode();
                
                if (this.MaximumAllowedValue != null)
                    hash = hash * 57 + this.MaximumAllowedValue.GetHashCode();
                
                if (this.MinimumAllowedValue != null)
                    hash = hash * 57 + this.MinimumAllowedValue.GetHashCode();
                
                if (this.OnsetDelay != null)
                    hash = hash * 57 + this.OnsetDelay.GetHashCode();
                
                if (this.DurationOfAction != null)
                    hash = hash * 57 + this.DurationOfAction.GetHashCode();
                
                if (this.Public != null)
                    hash = hash * 57 + this.Public.GetHashCode();
                
                if (this.CauseOnly != null)
                    hash = hash * 57 + this.CauseOnly.GetHashCode();
                
                if (this.MostCommonValue != null)
                    hash = hash * 57 + this.MostCommonValue.GetHashCode();
                
                if (this.MostCommonUnitId != null)
                    hash = hash * 57 + this.MostCommonUnitId.GetHashCode();
                
                if (this.StandardDeviation != null)
                    hash = hash * 57 + this.StandardDeviation.GetHashCode();
                
                if (this.Variance != null)
                    hash = hash * 57 + this.Variance.GetHashCode();
                
                if (this.Mean != null)
                    hash = hash * 57 + this.Mean.GetHashCode();
                
                if (this.Median != null)
                    hash = hash * 57 + this.Median.GetHashCode();
                
                if (this.NumberOfMeasurements != null)
                    hash = hash * 57 + this.NumberOfMeasurements.GetHashCode();
                
                if (this.NumberOfUniqueValues != null)
                    hash = hash * 57 + this.NumberOfUniqueValues.GetHashCode();
                
                if (this.Skewness != null)
                    hash = hash * 57 + this.Skewness.GetHashCode();
                
                if (this.Kurtosis != null)
                    hash = hash * 57 + this.Kurtosis.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 57 + this.ErrorMessage.GetHashCode();
                
                if (this.LastSuccessfulUpdateTime != null)
                    hash = hash * 57 + this.LastSuccessfulUpdateTime.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                if (this.ProductUrl != null)
                    hash = hash * 57 + this.ProductUrl.GetHashCode();
                
                if (this.ImageUrl != null)
                    hash = hash * 57 + this.ImageUrl.GetHashCode();
                
                if (this.Price != null)
                    hash = hash * 57 + this.Price.GetHashCode();
                
                if (this.NumberOfUserVariables != null)
                    hash = hash * 57 + this.NumberOfUserVariables.GetHashCode();
                
                if (this.Outcome != null)
                    hash = hash * 57 + this.Outcome.GetHashCode();
                
                if (this.MinimumRecordedValue != null)
                    hash = hash * 57 + this.MinimumRecordedValue.GetHashCode();
                
                if (this.MaximumRecordedValue != null)
                    hash = hash * 57 + this.MaximumRecordedValue.GetHashCode();
                
                return hash;
            }
        }

    }
}
