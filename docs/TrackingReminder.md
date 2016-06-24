# IO.Swagger.Model.TrackingReminder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | id | [optional] 
**ClientId** | **string** | clientId | [optional] 
**UserId** | **int?** | ID of User | [optional] 
**VariableId** | **int?** | Id for the variable to be tracked | 
**DefaultValue** | **float?** | Default value to use for the measurement when tracking | [optional] 
**ReminderStartTime** | **string** | Earliest time of day at which reminders should appear in UTC HH:MM:SS format | [optional] 
**ReminderEndTime** | **string** | Latest time of day at which reminders should appear in UTC HH:MM:SS format | [optional] 
**ReminderSound** | **string** | String identifier for the sound to accompany the reminder | [optional] 
**ReminderFrequency** | **int?** | Number of seconds between one reminder and the next | [optional] 
**PopUp** | **bool?** | True if the reminders should appear as a popup notification | [optional] 
**Sms** | **bool?** | True if the reminders should be delivered via SMS | [optional] 
**Email** | **bool?** | True if the reminders should be delivered via email | [optional] 
**NotificationBar** | **bool?** | True if the reminders should appear in the notification bar | [optional] 
**LastReminded** | **DateTime?** | ISO 8601 timestamp for the last time a reminder was sent | [optional] 
**LastTracked** | **DateTime?** | ISO 8601 timestamp for the last time a measurement was received for this user and variable | [optional] 
**FirstDailyReminderTime** | **string** | Specific first time of day that the user should be reminded to track in UTC HH:MM:SS format | [optional] 
**SecondDailyReminderTime** | **string** | Specific second time of day that the user should be reminded to track in UTC HH:MM:SS format | [optional] 
**ThirdDailyReminderTime** | **string** | Specific third time of day that the user should be reminded to track in UTC HH:MM:SS format | [optional] 
**StartTrackingDate** | **string** | Earliest date on which the user should be reminded to track in YYYY-MM-DD format | [optional] 
**StopTrackingDate** | **string** | Latest date on which the user should be reminded to track in YYYY-MM-DD format | [optional] 
**UpdatedAt** | **DateTime?** | When the record in the database was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local. | [optional] 
**VariableName** | **string** | Name of the variable to be used when sending measurements | [optional] 
**VariableCategoryName** | **string** | Name of the variable category to be used when sending measurements | [optional] 
**AbbreviatedUnitName** | **string** | Abbreviated name of the unit to be used when sending measurements | [optional] 
**CombinationOperation** | **string** | The way multiple measurements are aggregated over time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

