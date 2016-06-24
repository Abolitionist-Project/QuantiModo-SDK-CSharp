# IO.Swagger.Model.Correlation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationCoefficient** | **decimal?** | Pearson correlation coefficient between cause and effect measurements | 
**Cause** | **string** | ORIGINAL variable name of the cause variable for which the user desires correlations. | 
**OriginalCause** | **string** | original name of the cause. | [optional] 
**Effect** | **string** | ORIGINAL variable name of the effect variable for which the user desires correlations. | 
**OriginalEffect** | **string** | effect variable original name. | [optional] 
**OnsetDelay** | **double?** | User estimated or default time after cause measurement before a perceivable effect is observed | 
**DurationOfAction** | **decimal?** | Time over which the cause is expected to produce a perceivable effect following the onset delay | 
**NumberOfPairs** | **decimal?** | Number of points that went into the correlation calculation | 
**EffectSize** | **string** | Magnitude of the effects of a cause indicating whether it&#39;s practically meaningful. | [optional] 
**StatisticalSignificance** | **string** | A function of the effect size and sample size | [optional] 
**Timestamp** | **decimal?** | Time at which correlation was calculated | 
**ReverseCorrelation** | **decimal?** | Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation. | [optional] 
**CausalityFactor** | **decimal?** |  | [optional] 
**CauseCategory** | **string** | Variable category of the cause variable. | [optional] 
**EffectCategory** | **string** | Variable category of the effect variable. | [optional] 
**ValuePredictingHighOutcome** | **decimal?** | cause value that predicts an above average effect value (in default unit for cause variable) | [optional] 
**ValuePredictingLowOutcome** | **decimal?** | cause value that predicts a below average effect value (in default unit for cause variable) | [optional] 
**OptimalPearsonProduct** | **decimal?** | Optimal Pearson Product | [optional] 
**AverageVote** | **decimal?** | Average Vote | [optional] 
**UserVote** | **decimal?** | User Vote | [optional] 
**CauseUnit** | **string** | Unit of the predictor variable | [optional] 
**CauseUnitId** | **int?** | Unit Id of the predictor variable | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

