# IO.Swagger.Model.UserVariableRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | id | [optional] 
**ConfidenceLevel** | **string** | Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors | 
**ConfidenceScore** | **float?** | A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors | 
**Direction** | **string** | Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. | 
**DurationOfAction** | **int?** | Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay | 
**ErrorMessage** | **string** | error_message | [optional] 
**OnsetDelay** | **int?** | User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed | [optional] 
**OutcomeVariableId** | **int?** | Variable ID for the outcome variable | 
**PredictorVariableId** | **int?** | Variable ID for the predictor variable | 
**PredictorUnitId** | **int?** | ID for default unit of the predictor variable | 
**SinnRank** | **float?** | A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. | 
**StrengthLevel** | **string** | Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. | 
**StrengthScore** | **float?** | A value represented to the size of the effect which the predictor appears to have on the outcome. | 
**UserId** | **int?** | user_id | [optional] 
**Vote** | **string** | vote | [optional] 
**ValuePredictingHighOutcome** | **float?** | Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value | 
**ValuePredictingLowOutcome** | **float?** | Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

