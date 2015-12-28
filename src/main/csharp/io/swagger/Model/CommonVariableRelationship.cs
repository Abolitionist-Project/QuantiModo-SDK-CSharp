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
    public class CommonVariableRelationship : IEquatable<CommonVariableRelationship>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonVariableRelationship" /> class.
        /// </summary>
        public CommonVariableRelationship()
        {
            
        }

        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
  
        
        /// <summary>
        /// Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors
        /// </summary>
        /// <value>Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</value>
        [DataMember(Name="confidence_level", EmitDefaultValue=false)]
        public string ConfidenceLevel { get; set; }
  
        
        /// <summary>
        /// A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors
        /// </summary>
        /// <value>A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</value>
        [DataMember(Name="confidence_score", EmitDefaultValue=false)]
        public float? ConfidenceScore { get; set; }
  
        
        /// <summary>
        /// Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.
        /// </summary>
        /// <value>Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }
  
        
        /// <summary>
        /// duration_of_action
        /// </summary>
        /// <value>duration_of_action</value>
        [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
        public int? DurationOfAction { get; set; }
  
        
        /// <summary>
        /// error_message
        /// </summary>
        /// <value>error_message</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
  
        
        /// <summary>
        /// User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed
        /// </summary>
        /// <value>User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</value>
        [DataMember(Name="onset_delay", EmitDefaultValue=false)]
        public int? OnsetDelay { get; set; }
  
        
        /// <summary>
        /// Variable ID for the outcome variable
        /// </summary>
        /// <value>Variable ID for the outcome variable</value>
        [DataMember(Name="outcome_variable_id", EmitDefaultValue=false)]
        public int? OutcomeVariableId { get; set; }
  
        
        /// <summary>
        /// Variable ID for the predictor variable
        /// </summary>
        /// <value>Variable ID for the predictor variable</value>
        [DataMember(Name="predictor_variable_id", EmitDefaultValue=false)]
        public int? PredictorVariableId { get; set; }
  
        
        /// <summary>
        /// ID for default unit of the predictor variable
        /// </summary>
        /// <value>ID for default unit of the predictor variable</value>
        [DataMember(Name="predictor_unit_id", EmitDefaultValue=false)]
        public int? PredictorUnitId { get; set; }
  
        
        /// <summary>
        /// A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.
        /// </summary>
        /// <value>A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</value>
        [DataMember(Name="sinn_rank", EmitDefaultValue=false)]
        public float? SinnRank { get; set; }
  
        
        /// <summary>
        /// A value represented to the size of the effect which the predictor appears to have on the outcome.
        /// </summary>
        /// <value>A value represented to the size of the effect which the predictor appears to have on the outcome.</value>
        [DataMember(Name="strength_score", EmitDefaultValue=false)]
        public float? StrengthScore { get; set; }
  
        
        /// <summary>
        /// Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.
        /// </summary>
        /// <value>Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</value>
        [DataMember(Name="strength_level", EmitDefaultValue=false)]
        public string StrengthLevel { get; set; }
  
        
        /// <summary>
        /// Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.
        /// </summary>
        /// <value>Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</value>
        [DataMember(Name="up_votes", EmitDefaultValue=false)]
        public int? UpVotes { get; set; }
  
        
        /// <summary>
        /// Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.
        /// </summary>
        /// <value>Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</value>
        [DataMember(Name="down_votes", EmitDefaultValue=false)]
        public int? DownVotes { get; set; }
  
        
        /// <summary>
        /// Value for the predictor variable (in it's default unit) which typically precedes an above average outcome value
        /// </summary>
        /// <value>Value for the predictor variable (in it's default unit) which typically precedes an above average outcome value</value>
        [DataMember(Name="value_predicting_high_outcome", EmitDefaultValue=false)]
        public float? ValuePredictingHighOutcome { get; set; }
  
        
        /// <summary>
        /// Value for the predictor variable (in it's default unit) which typically precedes a below average outcome value
        /// </summary>
        /// <value>Value for the predictor variable (in it's default unit) which typically precedes a below average outcome value</value>
        [DataMember(Name="value_predicting_low_outcome", EmitDefaultValue=false)]
        public float? ValuePredictingLowOutcome { get; set; }
  
        
        /// <summary>
        /// Number of users whose data was aggregated to obtain this relationship
        /// </summary>
        /// <value>Number of users whose data was aggregated to obtain this relationship</value>
        [DataMember(Name="number_of_users", EmitDefaultValue=false)]
        public int? NumberOfUsers { get; set; }
  
        
        /// <summary>
        /// Source of data for this common variable relationship
        /// </summary>
        /// <value>Source of data for this common variable relationship</value>
        [DataMember(Name="data_source", EmitDefaultValue=false)]
        public string DataSource { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonVariableRelationship {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConfidenceLevel: ").Append(ConfidenceLevel).Append("\n");
            sb.Append("  ConfidenceScore: ").Append(ConfidenceScore).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
            sb.Append("  OutcomeVariableId: ").Append(OutcomeVariableId).Append("\n");
            sb.Append("  PredictorVariableId: ").Append(PredictorVariableId).Append("\n");
            sb.Append("  PredictorUnitId: ").Append(PredictorUnitId).Append("\n");
            sb.Append("  SinnRank: ").Append(SinnRank).Append("\n");
            sb.Append("  StrengthScore: ").Append(StrengthScore).Append("\n");
            sb.Append("  StrengthLevel: ").Append(StrengthLevel).Append("\n");
            sb.Append("  UpVotes: ").Append(UpVotes).Append("\n");
            sb.Append("  DownVotes: ").Append(DownVotes).Append("\n");
            sb.Append("  ValuePredictingHighOutcome: ").Append(ValuePredictingHighOutcome).Append("\n");
            sb.Append("  ValuePredictingLowOutcome: ").Append(ValuePredictingLowOutcome).Append("\n");
            sb.Append("  NumberOfUsers: ").Append(NumberOfUsers).Append("\n");
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
            return this.Equals(obj as CommonVariableRelationship);
        }

        /// <summary>
        /// Returns true if CommonVariableRelationship instances are equal
        /// </summary>
        /// <param name="obj">Instance of CommonVariableRelationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonVariableRelationship other)
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
                    this.ConfidenceLevel == other.ConfidenceLevel ||
                    this.ConfidenceLevel != null &&
                    this.ConfidenceLevel.Equals(other.ConfidenceLevel)
                ) && 
                (
                    this.ConfidenceScore == other.ConfidenceScore ||
                    this.ConfidenceScore != null &&
                    this.ConfidenceScore.Equals(other.ConfidenceScore)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.DurationOfAction == other.DurationOfAction ||
                    this.DurationOfAction != null &&
                    this.DurationOfAction.Equals(other.DurationOfAction)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.OnsetDelay == other.OnsetDelay ||
                    this.OnsetDelay != null &&
                    this.OnsetDelay.Equals(other.OnsetDelay)
                ) && 
                (
                    this.OutcomeVariableId == other.OutcomeVariableId ||
                    this.OutcomeVariableId != null &&
                    this.OutcomeVariableId.Equals(other.OutcomeVariableId)
                ) && 
                (
                    this.PredictorVariableId == other.PredictorVariableId ||
                    this.PredictorVariableId != null &&
                    this.PredictorVariableId.Equals(other.PredictorVariableId)
                ) && 
                (
                    this.PredictorUnitId == other.PredictorUnitId ||
                    this.PredictorUnitId != null &&
                    this.PredictorUnitId.Equals(other.PredictorUnitId)
                ) && 
                (
                    this.SinnRank == other.SinnRank ||
                    this.SinnRank != null &&
                    this.SinnRank.Equals(other.SinnRank)
                ) && 
                (
                    this.StrengthScore == other.StrengthScore ||
                    this.StrengthScore != null &&
                    this.StrengthScore.Equals(other.StrengthScore)
                ) && 
                (
                    this.StrengthLevel == other.StrengthLevel ||
                    this.StrengthLevel != null &&
                    this.StrengthLevel.Equals(other.StrengthLevel)
                ) && 
                (
                    this.UpVotes == other.UpVotes ||
                    this.UpVotes != null &&
                    this.UpVotes.Equals(other.UpVotes)
                ) && 
                (
                    this.DownVotes == other.DownVotes ||
                    this.DownVotes != null &&
                    this.DownVotes.Equals(other.DownVotes)
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
                    this.NumberOfUsers == other.NumberOfUsers ||
                    this.NumberOfUsers != null &&
                    this.NumberOfUsers.Equals(other.NumberOfUsers)
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
                
                if (this.ConfidenceLevel != null)
                    hash = hash * 57 + this.ConfidenceLevel.GetHashCode();
                
                if (this.ConfidenceScore != null)
                    hash = hash * 57 + this.ConfidenceScore.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 57 + this.Direction.GetHashCode();
                
                if (this.DurationOfAction != null)
                    hash = hash * 57 + this.DurationOfAction.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 57 + this.ErrorMessage.GetHashCode();
                
                if (this.OnsetDelay != null)
                    hash = hash * 57 + this.OnsetDelay.GetHashCode();
                
                if (this.OutcomeVariableId != null)
                    hash = hash * 57 + this.OutcomeVariableId.GetHashCode();
                
                if (this.PredictorVariableId != null)
                    hash = hash * 57 + this.PredictorVariableId.GetHashCode();
                
                if (this.PredictorUnitId != null)
                    hash = hash * 57 + this.PredictorUnitId.GetHashCode();
                
                if (this.SinnRank != null)
                    hash = hash * 57 + this.SinnRank.GetHashCode();
                
                if (this.StrengthScore != null)
                    hash = hash * 57 + this.StrengthScore.GetHashCode();
                
                if (this.StrengthLevel != null)
                    hash = hash * 57 + this.StrengthLevel.GetHashCode();
                
                if (this.UpVotes != null)
                    hash = hash * 57 + this.UpVotes.GetHashCode();
                
                if (this.DownVotes != null)
                    hash = hash * 57 + this.DownVotes.GetHashCode();
                
                if (this.ValuePredictingHighOutcome != null)
                    hash = hash * 57 + this.ValuePredictingHighOutcome.GetHashCode();
                
                if (this.ValuePredictingLowOutcome != null)
                    hash = hash * 57 + this.ValuePredictingLowOutcome.GetHashCode();
                
                if (this.NumberOfUsers != null)
                    hash = hash * 57 + this.NumberOfUsers.GetHashCode();
                
                if (this.DataSource != null)
                    hash = hash * 57 + this.DataSource.GetHashCode();
                
                return hash;
            }
        }

    }
}
