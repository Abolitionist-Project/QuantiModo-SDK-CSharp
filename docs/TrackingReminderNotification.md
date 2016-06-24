# IO.Swagger.Model.TrackingReminderNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | id for the specific PENDING tracking remidner | 
**TrackingReminderId** | **int?** | id for the repeating tracking remidner | 
**ClientId** | **string** | clientId | [optional] 
**UserId** | **int?** | ID of User | [optional] 
**VariableId** | **int?** | Id for the variable to be tracked | [optional] 
**PendingReminderTime** | **DateTime?** | ISO 8601 timestamp for the specific time the variable should be tracked in UTC.  This will be used for the measurement startTime if the track endpoint is used. | [optional] 
**DefaultValue** | **float?** | Default value to use for the measurement when tracking | [optional] 
**ReminderSound** | **string** | String identifier for the sound to accompany the reminder | [optional] 
**PopUp** | **bool?** | True if the reminders should appear as a popup notification | [optional] 
**Sms** | **bool?** | True if the reminders should be delivered via SMS | [optional] 
**Email** | **bool?** | True if the reminders should be delivered via email | [optional] 
**NotificationBar** | **bool?** | True if the reminders should appear in the notification bar | [optional] 
**UpdatedAt** | **DateTime?** | When the record in the database was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local. | [optional] 
**VariableName** | **string** | Name of the variable to be used when sending measurements | [optional] 
**VariableCategoryName** | **string** | Name of the variable category to be used when sending measurements | [optional] 
**AbbreviatedUnitName** | **string** | Abbreviated name of the unit to be used when sending measurements | [optional] 
**CombinationOperation** | **string** | The way multiple measurements are aggregated over time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

