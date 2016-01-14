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
    public class AggregatedCorrelation :  IEquatable<AggregatedCorrelation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedCorrelation" /> class.
        /// </summary>
        public AggregatedCorrelation()
        {
            
        }

        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Pearson correlation coefficient between cause and effect measurements
        /// </summary>
        /// <value>Pearson correlation coefficient between cause and effect measurements</value>
        [DataMember(Name="correlation", EmitDefaultValue=false)]
        public float? Correlation { get; set; }
  
        
        /// <summary>
        /// variable ID of the cause variable for which the user desires correlations
        /// </summary>
        /// <value>variable ID of the cause variable for which the user desires correlations</value>
        [DataMember(Name="cause_id", EmitDefaultValue=false)]
        public int? CauseId { get; set; }
  
        
        /// <summary>
        /// variable ID of the effect variable for which the user desires correlations
        /// </summary>
        /// <value>variable ID of the effect variable for which the user desires correlations</value>
        [DataMember(Name="effect_id", EmitDefaultValue=false)]
        public int? EffectId { get; set; }
  
        
        /// <summary>
        /// User estimated or default time after cause measurement before a perceivable effect is observed
        /// </summary>
        /// <value>User estimated or default time after cause measurement before a perceivable effect is observed</value>
        [DataMember(Name="onset_delay", EmitDefaultValue=false)]
        public int? OnsetDelay { get; set; }
  
        
        /// <summary>
        /// Time over which the cause is expected to produce a perceivable effect following the onset delay
        /// </summary>
        /// <value>Time over which the cause is expected to produce a perceivable effect following the onset delay</value>
        [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
        public int? DurationOfAction { get; set; }
  
        
        /// <summary>
        /// Number of points that went into the correlation calculation
        /// </summary>
        /// <value>Number of points that went into the correlation calculation</value>
        [DataMember(Name="number_of_pairs", EmitDefaultValue=false)]
        public int? NumberOfPairs { get; set; }
  
        
        /// <summary>
        /// cause value that predicts an above average effect value (in default unit for cause variable)
        /// </summary>
        /// <value>cause value that predicts an above average effect value (in default unit for cause variable)</value>
        [DataMember(Name="value_predicting_high_outcome", EmitDefaultValue=false)]
        public float? ValuePredictingHighOutcome { get; set; }
  
        
        /// <summary>
        /// cause value that predicts a below average effect value (in default unit for cause variable)
        /// </summary>
        /// <value>cause value that predicts a below average effect value (in default unit for cause variable)</value>
        [DataMember(Name="value_predicting_low_outcome", EmitDefaultValue=false)]
        public float? ValuePredictingLowOutcome { get; set; }
  
        
        /// <summary>
        /// Optimal Pearson Product
        /// </summary>
        /// <value>Optimal Pearson Product</value>
        [DataMember(Name="optimal_pearson_product", EmitDefaultValue=false)]
        public float? OptimalPearsonProduct { get; set; }
  
        
        /// <summary>
        /// Vote
        /// </summary>
        /// <value>Vote</value>
        [DataMember(Name="vote", EmitDefaultValue=false)]
        public float? Vote { get; set; }
  
        
        /// <summary>
        /// Number of Users by which correlation is aggregated
        /// </summary>
        /// <value>Number of Users by which correlation is aggregated</value>
        [DataMember(Name="number_of_users", EmitDefaultValue=false)]
        public int? NumberOfUsers { get; set; }
  
        
        /// <summary>
        /// Number of Correlations by which correlation is aggregated
        /// </summary>
        /// <value>Number of Correlations by which correlation is aggregated</value>
        [DataMember(Name="number_of_correlations", EmitDefaultValue=false)]
        public int? NumberOfCorrelations { get; set; }
  
        
        /// <summary>
        /// A function of the effect size and sample size
        /// </summary>
        /// <value>A function of the effect size and sample size</value>
        [DataMember(Name="statistical_significance", EmitDefaultValue=false)]
        public float? StatisticalSignificance { get; set; }
  
        
        /// <summary>
        /// Unit of the predictor variable
        /// </summary>
        /// <value>Unit of the predictor variable</value>
        [DataMember(Name="cause_unit", EmitDefaultValue=false)]
        public string CauseUnit { get; set; }
  
        
        /// <summary>
        /// Unit ID of the predictor variable
        /// </summary>
        /// <value>Unit ID of the predictor variable</value>
        [DataMember(Name="cause_unit_id", EmitDefaultValue=false)]
        public int? CauseUnitId { get; set; }
  
        
        /// <summary>
        /// Cause changes
        /// </summary>
        /// <value>Cause changes</value>
        [DataMember(Name="cause_changes", EmitDefaultValue=false)]
        public int? CauseChanges { get; set; }
  
        
        /// <summary>
        /// Effect changes
        /// </summary>
        /// <value>Effect changes</value>
        [DataMember(Name="effect_changes", EmitDefaultValue=false)]
        public int? EffectChanges { get; set; }
  
        
        /// <summary>
        /// Aggregated QM Score
        /// </summary>
        /// <value>Aggregated QM Score</value>
        [DataMember(Name="aggregate_qm_score", EmitDefaultValue=false)]
        public float? AggregateQmScore { get; set; }
  
        
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
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Error Message
        /// </summary>
        /// <value>Error Message</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
  
        
        /// <summary>
        /// Last Successful update time
        /// </summary>
        /// <value>Last Successful update time</value>
        [DataMember(Name="last_successful_update_time", EmitDefaultValue=false)]
        public DateTime? LastSuccessfulUpdateTime { get; set; }
  
        
        /// <summary>
        /// Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation
        /// </summary>
        /// <value>Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</value>
        [DataMember(Name="reverse_pearson_correlation_coefficient", EmitDefaultValue=false)]
        public float? ReversePearsonCorrelationCoefficient { get; set; }
  
        
        /// <summary>
        /// Predictive Pearson Correlation Coefficient
        /// </summary>
        /// <value>Predictive Pearson Correlation Coefficient</value>
        [DataMember(Name="predictive_pearson_correlation_coefficient", EmitDefaultValue=false)]
        public float? PredictivePearsonCorrelationCoefficient { get; set; }
  
        
        /// <summary>
        /// Source of data for this correlation
        /// </summary>
        /// <value>Source of data for this correlation</value>
        [DataMember(Name="data_source", EmitDefaultValue=false)]
        public string DataSource { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatedCorrelation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Correlation: ").Append(Correlation).Append("\n");
            sb.Append("  CauseId: ").Append(CauseId).Append("\n");
            sb.Append("  EffectId: ").Append(EffectId).Append("\n");
            sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
            sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
            sb.Append("  NumberOfPairs: ").Append(NumberOfPairs).Append("\n");
            sb.Append("  ValuePredictingHighOutcome: ").Append(ValuePredictingHighOutcome).Append("\n");
            sb.Append("  ValuePredictingLowOutcome: ").Append(ValuePredictingLowOutcome).Append("\n");
            sb.Append("  OptimalPearsonProduct: ").Append(OptimalPearsonProduct).Append("\n");
            sb.Append("  Vote: ").Append(Vote).Append("\n");
            sb.Append("  NumberOfUsers: ").Append(NumberOfUsers).Append("\n");
            sb.Append("  NumberOfCorrelations: ").Append(NumberOfCorrelations).Append("\n");
            sb.Append("  StatisticalSignificance: ").Append(StatisticalSignificance).Append("\n");
            sb.Append("  CauseUnit: ").Append(CauseUnit).Append("\n");
            sb.Append("  CauseUnitId: ").Append(CauseUnitId).Append("\n");
            sb.Append("  CauseChanges: ").Append(CauseChanges).Append("\n");
            sb.Append("  EffectChanges: ").Append(EffectChanges).Append("\n");
            sb.Append("  AggregateQmScore: ").Append(AggregateQmScore).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  LastSuccessfulUpdateTime: ").Append(LastSuccessfulUpdateTime).Append("\n");
            sb.Append("  ReversePearsonCorrelationCoefficient: ").Append(ReversePearsonCorrelationCoefficient).Append("\n");
            sb.Append("  PredictivePearsonCorrelationCoefficient: ").Append(PredictivePearsonCorrelationCoefficient).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            
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
            return this.Equals(obj as AggregatedCorrelation);
        }

        /// <summary>
        /// Returns true if AggregatedCorrelation instances are equal
        /// </summary>
        /// <param name="obj">Instance of AggregatedCorrelation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregatedCorrelation other)
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
                    this.Correlation == other.Correlation ||
                    this.Correlation != null &&
                    this.Correlation.Equals(other.Correlation)
                ) && 
                (
                    this.CauseId == other.CauseId ||
                    this.CauseId != null &&
                    this.CauseId.Equals(other.CauseId)
                ) && 
                (
                    this.EffectId == other.EffectId ||
                    this.EffectId != null &&
                    this.EffectId.Equals(other.EffectId)
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
                    this.NumberOfPairs == other.NumberOfPairs ||
                    this.NumberOfPairs != null &&
                    this.NumberOfPairs.Equals(other.NumberOfPairs)
                ) && 
                (
                    this.ValuePredictingHighOutcome == other.ValuePredictingHighOutcome ||
                    this.ValuePredictingHighOutcome != null &&
                    this.ValuePredictingHighOutcome.Equals(other.ValuePredictingHighOutcome)
                ) && 
                (
                    this.ValuePredictingLowOutcome == other.ValuePredictingLowOutcome ||
                    this.ValuePredictingLowOutcome != null &&
                    this.ValuePredictingLowOutcome.Equals(other.ValuePredictingLowOutcome)
                ) && 
                (
                    this.OptimalPearsonProduct == other.OptimalPearsonProduct ||
                    this.OptimalPearsonProduct != null &&
                    this.OptimalPearsonProduct.Equals(other.OptimalPearsonProduct)
                ) && 
                (
                    this.Vote == other.Vote ||
                    this.Vote != null &&
                    this.Vote.Equals(other.Vote)
                ) && 
                (
                    this.NumberOfUsers == other.NumberOfUsers ||
                    this.NumberOfUsers != null &&
                    this.NumberOfUsers.Equals(other.NumberOfUsers)
                ) && 
                (
                    this.NumberOfCorrelations == other.NumberOfCorrelations ||
                    this.NumberOfCorrelations != null &&
                    this.NumberOfCorrelations.Equals(other.NumberOfCorrelations)
                ) && 
                (
                    this.StatisticalSignificance == other.StatisticalSignificance ||
                    this.StatisticalSignificance != null &&
                    this.StatisticalSignificance.Equals(other.StatisticalSignificance)
                ) && 
                (
                    this.CauseUnit == other.CauseUnit ||
                    this.CauseUnit != null &&
                    this.CauseUnit.Equals(other.CauseUnit)
                ) && 
                (
                    this.CauseUnitId == other.CauseUnitId ||
                    this.CauseUnitId != null &&
                    this.CauseUnitId.Equals(other.CauseUnitId)
                ) && 
                (
                    this.CauseChanges == other.CauseChanges ||
                    this.CauseChanges != null &&
                    this.CauseChanges.Equals(other.CauseChanges)
                ) && 
                (
                    this.EffectChanges == other.EffectChanges ||
                    this.EffectChanges != null &&
                    this.EffectChanges.Equals(other.EffectChanges)
                ) && 
                (
                    this.AggregateQmScore == other.AggregateQmScore ||
                    this.AggregateQmScore != null &&
                    this.AggregateQmScore.Equals(other.AggregateQmScore)
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
                    this.ReversePearsonCorrelationCoefficient == other.ReversePearsonCorrelationCoefficient ||
                    this.ReversePearsonCorrelationCoefficient != null &&
                    this.ReversePearsonCorrelationCoefficient.Equals(other.ReversePearsonCorrelationCoefficient)
                ) && 
                (
                    this.PredictivePearsonCorrelationCoefficient == other.PredictivePearsonCorrelationCoefficient ||
                    this.PredictivePearsonCorrelationCoefficient != null &&
                    this.PredictivePearsonCorrelationCoefficient.Equals(other.PredictivePearsonCorrelationCoefficient)
                ) && 
                (
                    this.DataSource == other.DataSource ||
                    this.DataSource != null &&
                    this.DataSource.Equals(other.DataSource)
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
                
                if (this.Correlation != null)
                    hash = hash * 57 + this.Correlation.GetHashCode();
                
                if (this.CauseId != null)
                    hash = hash * 57 + this.CauseId.GetHashCode();
                
                if (this.EffectId != null)
                    hash = hash * 57 + this.EffectId.GetHashCode();
                
                if (this.OnsetDelay != null)
                    hash = hash * 57 + this.OnsetDelay.GetHashCode();
                
                if (this.DurationOfAction != null)
                    hash = hash * 57 + this.DurationOfAction.GetHashCode();
                
                if (this.NumberOfPairs != null)
                    hash = hash * 57 + this.NumberOfPairs.GetHashCode();
                
                if (this.ValuePredictingHighOutcome != null)
                    hash = hash * 57 + this.ValuePredictingHighOutcome.GetHashCode();
                
                if (this.ValuePredictingLowOutcome != null)
                    hash = hash * 57 + this.ValuePredictingLowOutcome.GetHashCode();
                
                if (this.OptimalPearsonProduct != null)
                    hash = hash * 57 + this.OptimalPearsonProduct.GetHashCode();
                
                if (this.Vote != null)
                    hash = hash * 57 + this.Vote.GetHashCode();
                
                if (this.NumberOfUsers != null)
                    hash = hash * 57 + this.NumberOfUsers.GetHashCode();
                
                if (this.NumberOfCorrelations != null)
                    hash = hash * 57 + this.NumberOfCorrelations.GetHashCode();
                
                if (this.StatisticalSignificance != null)
                    hash = hash * 57 + this.StatisticalSignificance.GetHashCode();
                
                if (this.CauseUnit != null)
                    hash = hash * 57 + this.CauseUnit.GetHashCode();
                
                if (this.CauseUnitId != null)
                    hash = hash * 57 + this.CauseUnitId.GetHashCode();
                
                if (this.CauseChanges != null)
                    hash = hash * 57 + this.CauseChanges.GetHashCode();
                
                if (this.EffectChanges != null)
                    hash = hash * 57 + this.EffectChanges.GetHashCode();
                
                if (this.AggregateQmScore != null)
                    hash = hash * 57 + this.AggregateQmScore.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 57 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 57 + this.UpdatedAt.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 57 + this.ErrorMessage.GetHashCode();
                
                if (this.LastSuccessfulUpdateTime != null)
                    hash = hash * 57 + this.LastSuccessfulUpdateTime.GetHashCode();
                
                if (this.ReversePearsonCorrelationCoefficient != null)
                    hash = hash * 57 + this.ReversePearsonCorrelationCoefficient.GetHashCode();
                
                if (this.PredictivePearsonCorrelationCoefficient != null)
                    hash = hash * 57 + this.PredictivePearsonCorrelationCoefficient.GetHashCode();
                
                if (this.DataSource != null)
                    hash = hash * 57 + this.DataSource.GetHashCode();
                
                return hash;
            }
        }

    }
}
