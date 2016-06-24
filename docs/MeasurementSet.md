# IO.Swagger.Model.MeasurementSet
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Measurements** | [**List&lt;ValueObject&gt;**](ValueObject.md) | Array of timestamps, values, and optional notes | 
**VariableName** | **string** | ORIGINAL name of the variable for which we are creating the measurement records | 
**SourceName** | **string** | Name of the application or device used to record the measurement values | 
**VariableCategoryName** | **string** | Variable category name | [optional] 
**CombinationOperation** | **string** | Way to aggregate measurements over time. Options are \&quot;MEAN\&quot; or \&quot;SUM\&quot;.  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED. | [optional] 
**AbbreviatedUnitName** | **string** | Unit of measurement | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

