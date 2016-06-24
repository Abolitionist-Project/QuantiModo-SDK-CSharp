# IO.Swagger.Api.ApplicationEndpointsApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V2ApplicationConnectionsGet**](ApplicationEndpointsApi.md#v2applicationconnectionsget) | **GET** /v2/application/connections | Get all Connections
[**V2ApplicationCredentialsGet**](ApplicationEndpointsApi.md#v2applicationcredentialsget) | **GET** /v2/application/credentials | Get all Credentials
[**V2ApplicationMeasurementsGet**](ApplicationEndpointsApi.md#v2applicationmeasurementsget) | **GET** /v2/application/measurements | Get measurements for all users using your application
[**V2ApplicationTrackingRemindersGet**](ApplicationEndpointsApi.md#v2applicationtrackingremindersget) | **GET** /v2/application/trackingReminders | Get tracking reminders
[**V2ApplicationUpdatesGet**](ApplicationEndpointsApi.md#v2applicationupdatesget) | **GET** /v2/application/updates | Get all Updates
[**V2ApplicationUserVariableRelationshipsGet**](ApplicationEndpointsApi.md#v2applicationuservariablerelationshipsget) | **GET** /v2/application/userVariableRelationships | Get all UserVariableRelationships
[**V2ApplicationUserVariablesGet**](ApplicationEndpointsApi.md#v2applicationuservariablesget) | **GET** /v2/application/userVariables | Get all UserVariables
[**V2ApplicationVariableUserSourcesGet**](ApplicationEndpointsApi.md#v2applicationvariableusersourcesget) | **GET** /v2/application/variableUserSources | Get all VariableUserSources
[**V2ApplicationVotesGet**](ApplicationEndpointsApi.md#v2applicationvotesget) | **GET** /v2/application/votes | Get all Votes


# **V2ApplicationConnectionsGet**
> InlineResponse2003 V2ApplicationConnectionsGet (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)

Get all Connections

Get all Connections

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationConnectionsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | Application's OAuth2 access token (optional) 
            var connectorId = 56;  // int? | The id for the connector data source for which the connection is connected (optional) 
            var connectStatus = connectStatus_example;  // string | Indicates whether a connector is currently connected to a service for a user. (optional) 
            var connectError = connectError_example;  // string | Error message if there is a problem with authorizing this connection. (optional) 
            var updateRequestedAt = updateRequestedAt_example;  // string | Time at which an update was requested by a user. (optional) 
            var updateStatus = updateStatus_example;  // string | Indicates whether a connector is currently updated. (optional) 
            var updateError = updateError_example;  // string | Indicates if there was an error during the update. (optional) 
            var lastSuccessfulUpdatedAt = lastSuccessfulUpdatedAt_example;  // string | The time at which the connector was last successfully updated. (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get all Connections
                InlineResponse2003 result = apiInstance.V2ApplicationConnectionsGet(accessToken, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationConnectionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| Application&#39;s OAuth2 access token | [optional] 
 **connectorId** | **int?**| The id for the connector data source for which the connection is connected | [optional] 
 **connectStatus** | **string**| Indicates whether a connector is currently connected to a service for a user. | [optional] 
 **connectError** | **string**| Error message if there is a problem with authorizing this connection. | [optional] 
 **updateRequestedAt** | **string**| Time at which an update was requested by a user. | [optional] 
 **updateStatus** | **string**| Indicates whether a connector is currently updated. | [optional] 
 **updateError** | **string**| Indicates if there was an error during the update. | [optional] 
 **lastSuccessfulUpdatedAt** | **string**| The time at which the connector was last successfully updated. | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format  | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2ApplicationCredentialsGet**
> InlineResponse2004 V2ApplicationCredentialsGet (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)

Get all Credentials

Get all Credentials

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationCredentialsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | Application's OAuth2 access token (optional) 
            var connectorId = 56;  // int? | The id for the connector data source from which the credential was obtained (optional) 
            var attrKey = attrKey_example;  // string | Attribute name such as token, userid, username, or password (optional) 
            var attrValue = attrValue_example;  // string | Encrypted value for the attribute specified (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get all Credentials
                InlineResponse2004 result = apiInstance.V2ApplicationCredentialsGet(accessToken, connectorId, attrKey, attrValue, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationCredentialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| Application&#39;s OAuth2 access token | [optional] 
 **connectorId** | **int?**| The id for the connector data source from which the credential was obtained | [optional] 
 **attrKey** | **string**| Attribute name such as token, userid, username, or password | [optional] 
 **attrValue** | **string**| Encrypted value for the attribute specified | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format  | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2ApplicationMeasurementsGet**
> InlineResponse2005 V2ApplicationMeasurementsGet (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)

Get measurements for all users using your application

Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationMeasurementsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | Application's OAuth2 access token (optional) 
            var clientId = clientId_example;  // string | The ID of the client application which originally stored the measurement (optional) 
            var connectorId = 56;  // int? | The id for the connector data source from which the measurement was obtained (optional) 
            var variableId = 56;  // int? | ID of the variable for which we are creating the measurement records (optional) 
            var sourceId = 56;  // int? | Application or device used to record the measurement values (optional) 
            var startTime = startTime_example;  // string | start time for the measurement event. Use ISO 8601 datetime format  (optional) 
            var value = 3.4;  // decimal? | The value of the measurement after conversion to the default unit for that variable (optional) 
            var unitId = 56;  // int? | The default unit id for the variable (optional) 
            var originalValue = 3.4;  // decimal? | Unconverted value of measurement as originally posted (before conversion to default unit) (optional) 
            var originalUnitId = 56;  // int? | Unit id of the measurement as originally submitted (optional) 
            var duration = 56;  // int? | Duration of the event being measurement in seconds (optional) 
            var note = note_example;  // string | An optional note the user may include with their measurement (optional) 
            var latitude = 3.4;  // decimal? | Latitude at which the measurement was taken (optional) 
            var longitude = 3.4;  // decimal? | Longitude at which the measurement was taken (optional) 
            var location = location_example;  // string | Optional human readable name for the location where the measurement was recorded (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var error = error_example;  // string | An error message if there is a problem with the measurement (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get measurements for all users using your application
                InlineResponse2005 result = apiInstance.V2ApplicationMeasurementsGet(accessToken, clientId, connectorId, variableId, sourceId, startTime, value, unitId, originalValue, originalUnitId, duration, note, latitude, longitude, location, createdAt, updatedAt, error, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationMeasurementsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| Application&#39;s OAuth2 access token | [optional] 
 **clientId** | **string**| The ID of the client application which originally stored the measurement | [optional] 
 **connectorId** | **int?**| The id for the connector data source from which the measurement was obtained | [optional] 
 **variableId** | **int?**| ID of the variable for which we are creating the measurement records | [optional] 
 **sourceId** | **int?**| Application or device used to record the measurement values | [optional] 
 **startTime** | **string**| start time for the measurement event. Use ISO 8601 datetime format  | [optional] 
 **value** | **decimal?**| The value of the measurement after conversion to the default unit for that variable | [optional] 
 **unitId** | **int?**| The default unit id for the variable | [optional] 
 **originalValue** | **decimal?**| Unconverted value of measurement as originally posted (before conversion to default unit) | [optional] 
 **originalUnitId** | **int?**| Unit id of the measurement as originally submitted | [optional] 
 **duration** | **int?**| Duration of the event being measurement in seconds | [optional] 
 **note** | **string**| An optional note the user may include with their measurement | [optional] 
 **latitude** | **decimal?**| Latitude at which the measurement was taken | [optional] 
 **longitude** | **decimal?**| Longitude at which the measurement was taken | [optional] 
 **location** | **string**| Optional human readable name for the location where the measurement was recorded | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format  | [optional] 
 **error** | **string**| An error message if there is a problem with the measurement | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2ApplicationTrackingRemindersGet**
> InlineResponse2001 V2ApplicationTrackingRemindersGet (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)

Get tracking reminders

Get the variable id, frequency, and default value for the user tracking reminders 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationTrackingRemindersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var clientId = clientId_example;  // string | The ID of the client application which last created or updated this trackingReminder (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get tracking reminders
                InlineResponse2001 result = apiInstance.V2ApplicationTrackingRemindersGet(accessToken, clientId, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationTrackingRemindersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **clientId** | **string**| The ID of the client application which last created or updated this trackingReminder | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format  | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2ApplicationUpdatesGet**
> InlineResponse2006 V2ApplicationUpdatesGet (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)

Get all Updates

Get all Updates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationUpdatesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | Application's OAuth2 access token (optional) 
            var connectorId = 56;  // int? | connector_id (optional) 
            var numberOfMeasurements = 56;  // int? | number_of_measurements (optional) 
            var success = true;  // bool? | success (optional) 
            var message = message_example;  // string | message (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get all Updates
                InlineResponse2006 result = apiInstance.V2ApplicationUpdatesGet(accessToken, connectorId, numberOfMeasurements, success, message, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationUpdatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| Application&#39;s OAuth2 access token | [optional] 
 **connectorId** | **int?**| connector_id | [optional] 
 **numberOfMeasurements** | **int?**| number_of_measurements | [optional] 
 **success** | **bool?**| success | [optional] 
 **message** | **string**| message | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format  | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2ApplicationUserVariableRelationshipsGet**
> InlineResponse2007 V2ApplicationUserVariableRelationshipsGet (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)

Get all UserVariableRelationships

Get all UserVariableRelationships

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationUserVariableRelationshipsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var id = 56;  // int? | id (optional) 
            var confidenceLevel = confidenceLevel_example;  // string | Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional) 
            var confidenceScore = 3.4;  // decimal? | A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional) 
            var direction = direction_example;  // string | Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional) 
            var durationOfAction = 56;  // int? | Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional) 
            var errorMessage = errorMessage_example;  // string | error_message (optional) 
            var onsetDelay = 56;  // int? | Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional) 
            var outcomeVariableId = 56;  // int? | Variable ID for the outcome variable (optional) 
            var predictorVariableId = 56;  // int? | Variable ID for the predictor variable (optional) 
            var predictorUnitId = 56;  // int? | ID for default unit of the predictor variable (optional) 
            var sinnRank = 3.4;  // decimal? | A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional) 
            var strengthLevel = strengthLevel_example;  // string | Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional) 
            var strengthScore = 3.4;  // decimal? | A value represented to the size of the effect which the predictor appears to have on the outcome. (optional) 
            var vote = vote_example;  // string | vote (optional) 
            var valuePredictingHighOutcome = 3.4;  // decimal? | Value for the predictor variable (in it's default unit) which typically precedes an above average outcome value (optional) 
            var valuePredictingLowOutcome = 3.4;  // decimal? | Value for the predictor variable (in it's default unit) which typically precedes a below average outcome value (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get all UserVariableRelationships
                InlineResponse2007 result = apiInstance.V2ApplicationUserVariableRelationshipsGet(accessToken, id, confidenceLevel, confidenceScore, direction, durationOfAction, errorMessage, onsetDelay, outcomeVariableId, predictorVariableId, predictorUnitId, sinnRank, strengthLevel, strengthScore, vote, valuePredictingHighOutcome, valuePredictingLowOutcome, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationUserVariableRelationshipsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **id** | **int?**| id | [optional] 
 **confidenceLevel** | **string**| Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors | [optional] 
 **confidenceScore** | **decimal?**| A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors | [optional] 
 **direction** | **string**| Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. | [optional] 
 **durationOfAction** | **int?**| Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect | [optional] 
 **errorMessage** | **string**| error_message | [optional] 
 **onsetDelay** | **int?**| Estimated number of seconds that pass before a stimulus produces a perceivable effect | [optional] 
 **outcomeVariableId** | **int?**| Variable ID for the outcome variable | [optional] 
 **predictorVariableId** | **int?**| Variable ID for the predictor variable | [optional] 
 **predictorUnitId** | **int?**| ID for default unit of the predictor variable | [optional] 
 **sinnRank** | **decimal?**| A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. | [optional] 
 **strengthLevel** | **string**| Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. | [optional] 
 **strengthScore** | **decimal?**| A value represented to the size of the effect which the predictor appears to have on the outcome. | [optional] 
 **vote** | **string**| vote | [optional] 
 **valuePredictingHighOutcome** | **decimal?**| Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value | [optional] 
 **valuePredictingLowOutcome** | **decimal?**| Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2ApplicationUserVariablesGet**
> InlineResponse2008 V2ApplicationUserVariablesGet (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)

Get all UserVariables

Get all UserVariables

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationUserVariablesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var clientId = clientId_example;  // string | The ID of the client application which last created or updated this user variable (optional) 
            var parentId = 56;  // int? | ID of the parent variable if this variable has any parent (optional) 
            var variableId = 56;  // int? | ID of variable (optional) 
            var defaultUnitId = 56;  // int? | D of unit to use for this variable (optional) 
            var minimumAllowedValue = 3.4;  // decimal? | Minimum reasonable value for this variable (uses default unit) (optional) 
            var maximumAllowedValue = 3.4;  // decimal? | Maximum reasonable value for this variable (uses default unit) (optional) 
            var fillingValue = 3.4;  // decimal? | Value for replacing null measurements (optional) 
            var joinWith = 56;  // int? | The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional) 
            var onsetDelay = 56;  // int? | Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional) 
            var durationOfAction = 56;  // int? | Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional) 
            var variableCategoryId = 56;  // int? | ID of variable category (optional) 
            var updated = 56;  // int? | updated (optional) 
            var _public = 56;  // int? | Is variable public (optional) 
            var causeOnly = true;  // bool? | A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional) 
            var fillingType = fillingType_example;  // string | 0 -> No filling, 1 -> Use filling-value (optional) 
            var numberOfMeasurements = 56;  // int? | Number of measurements (optional) 
            var numberOfProcessedMeasurements = 56;  // int? | Number of processed measurements (optional) 
            var measurementsAtLastAnalysis = 56;  // int? | Number of measurements at last analysis (optional) 
            var lastUnitId = 56;  // int? | ID of last Unit (optional) 
            var lastOriginalUnitId = 56;  // int? | ID of last original Unit (optional) 
            var lastOriginalValue = 56;  // int? | Last original value which is stored (optional) 
            var lastValue = 3.4;  // decimal? | Last Value (optional) 
            var lastSourceId = 56;  // int? | ID of last source (optional) 
            var numberOfCorrelations = 56;  // int? | Number of correlations for this variable (optional) 
            var status = status_example;  // string | status (optional) 
            var errorMessage = errorMessage_example;  // string | error_message (optional) 
            var lastSuccessfulUpdateTime = lastSuccessfulUpdateTime_example;  // string | When this variable or its settings were last updated (optional) 
            var standardDeviation = 3.4;  // decimal? | Standard deviation (optional) 
            var variance = 3.4;  // decimal? | Variance (optional) 
            var minimumRecordedValue = 3.4;  // decimal? | Minimum recorded value of this variable (optional) 
            var maximumRecordedValue = 3.4;  // decimal? | Maximum recorded value of this variable (optional) 
            var mean = 3.4;  // decimal? | Mean (optional) 
            var median = 3.4;  // decimal? | Median (optional) 
            var mostCommonUnitId = 56;  // int? | Most common Unit ID (optional) 
            var mostCommonValue = 3.4;  // decimal? | Most common value (optional) 
            var numberOfUniqueDailyValues = 3.4;  // decimal? | Number of unique daily values (optional) 
            var numberOfChanges = 56;  // int? | Number of changes (optional) 
            var skewness = 3.4;  // decimal? | Skewness (optional) 
            var kurtosis = 3.4;  // decimal? | Kurtosis (optional) 
            var latitude = 3.4;  // decimal? | Latitude (optional) 
            var longitude = 3.4;  // decimal? | Longitude (optional) 
            var location = location_example;  // string | Location (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var outcome = true;  // bool? | Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional) 
            var sources = sources_example;  // string | Comma-separated list of source names to limit variables to those sources (optional) 
            var earliestSourceTime = 56;  // int? | Earliest source time (optional) 
            var latestSourceTime = 56;  // int? | Latest source time (optional) 
            var earliestMeasurementTime = 56;  // int? | Earliest measurement time (optional) 
            var latestMeasurementTime = 56;  // int? | Latest measurement time (optional) 
            var earliestFillingTime = 56;  // int? | Earliest filling time (optional) 
            var latestFillingTime = 56;  // int? | Latest filling time (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get all UserVariables
                InlineResponse2008 result = apiInstance.V2ApplicationUserVariablesGet(accessToken, clientId, parentId, variableId, defaultUnitId, minimumAllowedValue, maximumAllowedValue, fillingValue, joinWith, onsetDelay, durationOfAction, variableCategoryId, updated, _public, causeOnly, fillingType, numberOfMeasurements, numberOfProcessedMeasurements, measurementsAtLastAnalysis, lastUnitId, lastOriginalUnitId, lastOriginalValue, lastValue, lastSourceId, numberOfCorrelations, status, errorMessage, lastSuccessfulUpdateTime, standardDeviation, variance, minimumRecordedValue, maximumRecordedValue, mean, median, mostCommonUnitId, mostCommonValue, numberOfUniqueDailyValues, numberOfChanges, skewness, kurtosis, latitude, longitude, location, createdAt, updatedAt, outcome, sources, earliestSourceTime, latestSourceTime, earliestMeasurementTime, latestMeasurementTime, earliestFillingTime, latestFillingTime, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationUserVariablesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **clientId** | **string**| The ID of the client application which last created or updated this user variable | [optional] 
 **parentId** | **int?**| ID of the parent variable if this variable has any parent | [optional] 
 **variableId** | **int?**| ID of variable | [optional] 
 **defaultUnitId** | **int?**| D of unit to use for this variable | [optional] 
 **minimumAllowedValue** | **decimal?**| Minimum reasonable value for this variable (uses default unit) | [optional] 
 **maximumAllowedValue** | **decimal?**| Maximum reasonable value for this variable (uses default unit) | [optional] 
 **fillingValue** | **decimal?**| Value for replacing null measurements | [optional] 
 **joinWith** | **int?**| The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables | [optional] 
 **onsetDelay** | **int?**| Estimated number of seconds that pass before a stimulus produces a perceivable effect | [optional] 
 **durationOfAction** | **int?**| Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect | [optional] 
 **variableCategoryId** | **int?**| ID of variable category | [optional] 
 **updated** | **int?**| updated | [optional] 
 **_public** | **int?**| Is variable public | [optional] 
 **causeOnly** | **bool?**| A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user | [optional] 
 **fillingType** | **string**| 0 -&gt; No filling, 1 -&gt; Use filling-value | [optional] 
 **numberOfMeasurements** | **int?**| Number of measurements | [optional] 
 **numberOfProcessedMeasurements** | **int?**| Number of processed measurements | [optional] 
 **measurementsAtLastAnalysis** | **int?**| Number of measurements at last analysis | [optional] 
 **lastUnitId** | **int?**| ID of last Unit | [optional] 
 **lastOriginalUnitId** | **int?**| ID of last original Unit | [optional] 
 **lastOriginalValue** | **int?**| Last original value which is stored | [optional] 
 **lastValue** | **decimal?**| Last Value | [optional] 
 **lastSourceId** | **int?**| ID of last source | [optional] 
 **numberOfCorrelations** | **int?**| Number of correlations for this variable | [optional] 
 **status** | **string**| status | [optional] 
 **errorMessage** | **string**| error_message | [optional] 
 **lastSuccessfulUpdateTime** | **string**| When this variable or its settings were last updated | [optional] 
 **standardDeviation** | **decimal?**| Standard deviation | [optional] 
 **variance** | **decimal?**| Variance | [optional] 
 **minimumRecordedValue** | **decimal?**| Minimum recorded value of this variable | [optional] 
 **maximumRecordedValue** | **decimal?**| Maximum recorded value of this variable | [optional] 
 **mean** | **decimal?**| Mean | [optional] 
 **median** | **decimal?**| Median | [optional] 
 **mostCommonUnitId** | **int?**| Most common Unit ID | [optional] 
 **mostCommonValue** | **decimal?**| Most common value | [optional] 
 **numberOfUniqueDailyValues** | **decimal?**| Number of unique daily values | [optional] 
 **numberOfChanges** | **int?**| Number of changes | [optional] 
 **skewness** | **decimal?**| Skewness | [optional] 
 **kurtosis** | **decimal?**| Kurtosis | [optional] 
 **latitude** | **decimal?**| Latitude | [optional] 
 **longitude** | **decimal?**| Longitude | [optional] 
 **location** | **string**| Location | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format  | [optional] 
 **outcome** | **bool?**| Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables | [optional] 
 **sources** | **string**| Comma-separated list of source names to limit variables to those sources | [optional] 
 **earliestSourceTime** | **int?**| Earliest source time | [optional] 
 **latestSourceTime** | **int?**| Latest source time | [optional] 
 **earliestMeasurementTime** | **int?**| Earliest measurement time | [optional] 
 **latestMeasurementTime** | **int?**| Latest measurement time | [optional] 
 **earliestFillingTime** | **int?**| Earliest filling time | [optional] 
 **latestFillingTime** | **int?**| Latest filling time | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2ApplicationVariableUserSourcesGet**
> InlineResponse2009 V2ApplicationVariableUserSourcesGet (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)

Get all VariableUserSources

Get all VariableUserSources

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationVariableUserSourcesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var variableId = 56;  // int? | ID of variable (optional) 
            var timestamp = 56;  // int? | Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional) 
            var earliestMeasurementTime = 56;  // int? | Earliest measurement time (optional) 
            var latestMeasurementTime = 56;  // int? | Latest measurement time (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get all VariableUserSources
                InlineResponse2009 result = apiInstance.V2ApplicationVariableUserSourcesGet(accessToken, variableId, timestamp, earliestMeasurementTime, latestMeasurementTime, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationVariableUserSourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **variableId** | **int?**| ID of variable | [optional] 
 **timestamp** | **int?**| Time that this measurement occurred Uses epoch minute (epoch time divided by 60) | [optional] 
 **earliestMeasurementTime** | **int?**| Earliest measurement time | [optional] 
 **latestMeasurementTime** | **int?**| Latest measurement time | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format  | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2ApplicationVotesGet**
> InlineResponse20010 V2ApplicationVotesGet (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)

Get all Votes

Get all Votes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2ApplicationVotesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var clientId = clientId_example;  // string | The ID of the client application which last created or updated this vote (optional) 
            var causeId = 56;  // int? | ID of predictor variable (optional) 
            var effectId = 56;  // int? | ID of outcome variable (optional) 
            var value = 56;  // int? | Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get all Votes
                InlineResponse20010 result = apiInstance.V2ApplicationVotesGet(accessToken, clientId, causeId, effectId, value, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationVotesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **clientId** | **string**| The ID of the client application which last created or updated this vote | [optional] 
 **causeId** | **int?**| ID of predictor variable | [optional] 
 **effectId** | **int?**| ID of outcome variable | [optional] 
 **value** | **int?**| Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format  | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

