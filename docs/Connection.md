# IO.Swagger.Model.Connection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | id | [optional] 
**UserId** | **int?** | ID of user that owns this correlation | [optional] 
**ConnectorId** | **int?** | The id for the connector data source for which the connection is connected | 
**ConnectStatus** | **string** | Indicates whether a connector is currently connected to a service for a user. | [optional] 
**ConnectError** | **string** | Error message if there is a problem with authorizing this connection. | [optional] 
**UpdateRequestedAt** | **DateTime?** | Time at which an update was requested by a user. | [optional] 
**UpdateStatus** | **string** | Indicates whether a connector is currently updated. | [optional] 
**UpdateError** | **string** | Indicates if there was an error during the update. | [optional] 
**LastSuccessfulUpdatedAt** | **DateTime?** | The time at which the connector was last successfully updated. | [optional] 
**CreatedAt** | **DateTime?** | When the record was first created. Use ISO 8601 datetime format | [optional] 
**UpdatedAt** | **DateTime?** | When the record in the database was last updated. Use ISO 8601 datetime format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

