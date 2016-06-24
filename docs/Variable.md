# IO.Swagger.Model.Variable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Variable ID | [optional] 
**Name** | **string** | User-defined variable display name. | 
**OriginalName** | **string** | Name used when the variable was originally created in the &#x60;variables&#x60; table. | 
**Category** | **string** | Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc. | 
**AbbreviatedUnitName** | **string** | Abbreviated name of the default unit for the variable | 
**AbbreviatedUnitId** | **int?** | Id of the default unit for the variable | 
**Sources** | **string** | Comma-separated list of source names to limit variables to those sources | 
**MinimumValue** | **double?** | Minimum reasonable value for this variable (uses default unit) | 
**MaximumValue** | **double?** | Maximum reasonable value for this variable (uses default unit) | 
**CombinationOperation** | **string** | Way to aggregate measurements over time. Options are \&quot;MEAN\&quot; or \&quot;SUM\&quot;.  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED. | 
**FillingValue** | **double?** | Value for replacing null measurements | 
**JoinWith** | **string** | The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables. | 
**JoinedVariables** | [**List&lt;Variable&gt;**](Variable.md) | Array of Variables that are joined with this Variable | 
**Parent** | **int?** | Id of the parent variable if this variable has any parent | 
**SubVariables** | [**List&lt;Variable&gt;**](Variable.md) | Array of Variables that are sub variables to this Variable | 
**OnsetDelay** | **int?** | How long it takes for a measurement in this variable to take effect | 
**DurationOfAction** | **int?** | How long the effect of a measurement in this variable lasts | 
**EarliestMeasurementTime** | **int?** | Earliest measurement time | 
**LatestMeasurementTime** | **int?** | Latest measurement time | 
**Updated** | **int?** | When this variable or its settings were last updated | 
**CauseOnly** | **int?** | A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user. | 
**NumberOfCorrelations** | **int?** | Number of correlations | 
**Outcome** | **int?** | Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables. | 
**MeasurementsAtLastAnalysis** | **int?** | The number of measurements that a given user had for this variable the last time a correlation calculation was performed. Generally correlation values are only updated once the current number of measurements for a variable is more than 10% greater than the measurementsAtLastAnalysis.  This avoids a computationally-demanding recalculation when there&#39;s not enough new data to make a significant difference in the correlation. | 
**NumberOfMeasurements** | **int?** | Number of measurements | 
**LastUnit** | **string** | Last unit | 
**LastValue** | **int?** | Last value | 
**MostCommonValue** | **int?** | Most common value | 
**MostCommonUnit** | **string** | Most common unit | 
**LastSource** | **int?** | Last source | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

