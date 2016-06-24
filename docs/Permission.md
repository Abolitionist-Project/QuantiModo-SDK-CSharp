# IO.Swagger.Model.Permission
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Target** | **int?** | Grant permission to target user or public so they may access measurements within the given parameters. TODO: Rename target to something more intuitive. | 
**VariableName** | **string** | ORIGINAL Variable name | 
**MinTimestamp** | **int?** | Earliest time when measurements will be accessible in epoch seconds | 
**MaxTimestamp** | **int?** | Latest time when measurements will be accessible in epoch seconds | 
**MinTimeOfDay** | **int?** | Earliest time of day when measurements will be accessible in epoch seconds | 
**MaxTimeOfDay** | **int?** | Latest time of day when measurements will be accessible in epoch seconds | 
**Week** | **string** | Maybe specifies if only weekday measurements should be accessible | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

