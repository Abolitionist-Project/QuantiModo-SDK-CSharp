using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class UserVariableRelationship :  IEquatable<UserVariableRelationship>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableRelationship" /> class.
        /// </summary>
        public UserVariableRelationship()
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
        /// Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay
        /// </summary>
        /// <value>Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</value>
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
        /// Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.
        /// </summary>
        /// <value>Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</value>
        [DataMember(Name="strength_level", EmitDefaultValue=false)]
        public string StrengthLevel { get; set; }
  
        
        /// <summary>
        /// A value represented to the size of the effect which the predictor appears to have on the outcome.
        /// </summary>
        /// <value>A value represented to the size of the effect which the predictor appears to have on the outcome.</value>
        [DataMember(Name="strength_score", EmitDefaultValue=false)]
        public float? StrengthScore { get; set; }
  
        
        /// <summary>
        /// user_id
        /// </summary>
        /// <value>user_id</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
  
        
        /// <summary>
        /// vote
        /// </summary>
        /// <value>vote</value>
        [DataMember(Name="vote", EmitDefaultValue=false)]
        public string Vote { get; set; }
  
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserVariableRelationship {\n");
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
            sb.Append("  StrengthLevel: ").Append(StrengthLevel).Append("\n");
            sb.Append("  StrengthScore: ").Append(StrengthScore).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Vote: ").Append(Vote).Append("\n");
            sb.Append("  ValuePredictingHighOutcome: ").Append(ValuePredictingHighOutcome).Append("\n");
            sb.Append("  ValuePredictingLowOutcome: ").Append(ValuePredictingLowOutcome).Append("\n");
            
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
            return this.Equals(obj as UserVariableRelationship);
        }

        /// <summary>
        /// Returns true if UserVariableRelationship instances are equal
        /// </summary>
        /// <param name="other">Instance of UserVariableRelationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserVariableRelationship other)
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
                    this.StrengthLevel == other.StrengthLevel ||
                    this.StrengthLevel != null &&
                    this.StrengthLevel.Equals(other.StrengthLevel)
                ) && 
                (
                    this.StrengthScore == other.StrengthScore ||
                    this.StrengthScore != null &&
                    this.StrengthScore.Equals(other.StrengthScore)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Vote == other.Vote ||
                    this.Vote != null &&
                    this.Vote.Equals(other.Vote)
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
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ConfidenceLevel != null)
                    hash = hash * 59 + this.ConfidenceLevel.GetHashCode();
                
                if (this.ConfidenceScore != null)
                    hash = hash * 59 + this.ConfidenceScore.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                
                if (this.DurationOfAction != null)
                    hash = hash * 59 + this.DurationOfAction.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                if (this.OnsetDelay != null)
                    hash = hash * 59 + this.OnsetDelay.GetHashCode();
                
                if (this.OutcomeVariableId != null)
                    hash = hash * 59 + this.OutcomeVariableId.GetHashCode();
                
                if (this.PredictorVariableId != null)
                    hash = hash * 59 + this.PredictorVariableId.GetHashCode();
                
                if (this.PredictorUnitId != null)
                    hash = hash * 59 + this.PredictorUnitId.GetHashCode();
                
                if (this.SinnRank != null)
                    hash = hash * 59 + this.SinnRank.GetHashCode();
                
                if (this.StrengthLevel != null)
                    hash = hash * 59 + this.StrengthLevel.GetHashCode();
                
                if (this.StrengthScore != null)
                    hash = hash * 59 + this.StrengthScore.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.Vote != null)
                    hash = hash * 59 + this.Vote.GetHashCode();
                
                if (this.ValuePredictingHighOutcome != null)
                    hash = hash * 59 + this.ValuePredictingHighOutcome.GetHashCode();
                
                if (this.ValuePredictingLowOutcome != null)
                    hash = hash * 59 + this.ValuePredictingLowOutcome.GetHashCode();
                
                return hash;
            }
        }

    }
}
