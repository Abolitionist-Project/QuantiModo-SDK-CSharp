# IO.Swagger.Api.ConnectorsApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1ConnectJsGet**](ConnectorsApi.md#v1connectjsget) | **GET** /v1/connect.js | Get embeddable connect javascript
[**V1ConnectMobileGet**](ConnectorsApi.md#v1connectmobileget) | **GET** /v1/connect/mobile | Mobile connect page
[**V1ConnectorsConnectorConnectGet**](ConnectorsApi.md#v1connectorsconnectorconnectget) | **GET** /v1/connectors/{connector}/connect | Obtain a token from 3rd party data source
[**V1ConnectorsConnectorConnectInstructionsGet**](ConnectorsApi.md#v1connectorsconnectorconnectinstructionsget) | **GET** /v1/connectors/{connector}/connectInstructions | Connection Instructions
[**V1ConnectorsConnectorConnectParameterGet**](ConnectorsApi.md#v1connectorsconnectorconnectparameterget) | **GET** /v1/connectors/{connector}/connectParameter | Connect Parameter
[**V1ConnectorsConnectorDisconnectGet**](ConnectorsApi.md#v1connectorsconnectordisconnectget) | **GET** /v1/connectors/{connector}/disconnect | Delete stored connection info
[**V1ConnectorsConnectorInfoGet**](ConnectorsApi.md#v1connectorsconnectorinfoget) | **GET** /v1/connectors/{connector}/info | Get connector info for user
[**V1ConnectorsConnectorUpdateGet**](ConnectorsApi.md#v1connectorsconnectorupdateget) | **GET** /v1/connectors/{connector}/update | Sync with data source
[**V1ConnectorsListGet**](ConnectorsApi.md#v1connectorslistget) | **GET** /v1/connectors/list | List of Connectors


# **V1ConnectJsGet**
> void V1ConnectJsGet (string accessToken = null)

Get embeddable connect javascript

Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use `qmSetupInPopup` function after connecting `connect.js`.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use `qmSetupOnPage` function after connecting `connect.js`.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use `qmSetupOnMobile` function after connecting `connect.js`.      if using the MoodiModo Clones, Use `qmSetupOnIonic` function after connecting `connect.js`. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectJsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ConnectorsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Get embeddable connect javascript
                apiInstance.V1ConnectJsGet(accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectJsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/x-javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1ConnectMobileGet**
> void V1ConnectMobileGet (string accessToken)

Mobile connect page

This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user's access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token=123

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectMobileGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ConnectorsApi();
            var accessToken = accessToken_example;  // string | User OAuth access token

            try
            {
                // Mobile connect page
                apiInstance.V1ConnectMobileGet(accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectMobileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User OAuth access token | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1ConnectorsConnectorConnectGet**
> void V1ConnectorsConnectorConnectGet (string connector, string accessToken = null)

Obtain a token from 3rd party data source

Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectorsConnectorConnectGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConnectorsApi();
            var connector = connector_example;  // string | Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Obtain a token from 3rd party data source
                apiInstance.V1ConnectorsConnectorConnectGet(connector, accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectorsConnectorConnectGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connector** | **string**| Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1ConnectorsConnectorConnectInstructionsGet**
> void V1ConnectorsConnectorConnectInstructionsGet (string connector, string parameters, string url, bool? usePopup, string accessToken = null)

Connection Instructions

Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectorsConnectorConnectInstructionsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConnectorsApi();
            var connector = connector_example;  // string | Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.
            var parameters = parameters_example;  // string | JSON Array of Parameters for the request to enable connector.
            var url = url_example;  // string | URL which should be used to enable the connector.
            var usePopup = true;  // bool? | Should use popup when enabling connector
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Connection Instructions
                apiInstance.V1ConnectorsConnectorConnectInstructionsGet(connector, parameters, url, usePopup, accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectorsConnectorConnectInstructionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connector** | **string**| Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint. | 
 **parameters** | **string**| JSON Array of Parameters for the request to enable connector. | 
 **url** | **string**| URL which should be used to enable the connector. | 
 **usePopup** | **bool?**| Should use popup when enabling connector | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1ConnectorsConnectorConnectParameterGet**
> ConnectorInstruction V1ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null)

Connect Parameter

Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectorsConnectorConnectParameterGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConnectorsApi();
            var connector = connector_example;  // string | Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.
            var displayName = displayName_example;  // string | Name of the parameter that is user visible in the form
            var key = key_example;  // string | Name of the property that the user has to enter such as username or password Connector (used in HTTP request)
            var placeholder = placeholder_example;  // string | Placeholder hint value for the parameter input tag.
            var type = type_example;  // string | Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp
            var usePopup = true;  // bool? | Should use popup when enabling connector
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var defaultValue = defaultValue_example;  // string | Default parameter value (optional) 

            try
            {
                // Connect Parameter
                ConnectorInstruction result = apiInstance.V1ConnectorsConnectorConnectParameterGet(connector, displayName, key, placeholder, type, usePopup, accessToken, defaultValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectorsConnectorConnectParameterGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connector** | **string**| Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint. | 
 **displayName** | **string**| Name of the parameter that is user visible in the form | 
 **key** | **string**| Name of the property that the user has to enter such as username or password Connector (used in HTTP request) | 
 **placeholder** | **string**| Placeholder hint value for the parameter input tag. | 
 **type** | **string**| Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp | 
 **usePopup** | **bool?**| Should use popup when enabling connector | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **defaultValue** | **string**| Default parameter value | [optional] 

### Return type

[**ConnectorInstruction**](ConnectorInstruction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1ConnectorsConnectorDisconnectGet**
> void V1ConnectorsConnectorDisconnectGet (string connector)

Delete stored connection info

The disconnect method deletes any stored tokens or connection information from the connectors database.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectorsConnectorDisconnectGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConnectorsApi();
            var connector = connector_example;  // string | Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.

            try
            {
                // Delete stored connection info
                apiInstance.V1ConnectorsConnectorDisconnectGet(connector);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectorsConnectorDisconnectGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connector** | **string**| Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1ConnectorsConnectorInfoGet**
> ConnectorInfo V1ConnectorsConnectorInfoGet (string connector, string accessToken = null)

Get connector info for user

Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectorsConnectorInfoGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConnectorsApi();
            var connector = connector_example;  // string | Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Get connector info for user
                ConnectorInfo result = apiInstance.V1ConnectorsConnectorInfoGet(connector, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectorsConnectorInfoGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connector** | **string**| Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**ConnectorInfo**](ConnectorInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1ConnectorsConnectorUpdateGet**
> void V1ConnectorsConnectorUpdateGet (string connector, string accessToken = null)

Sync with data source

The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectorsConnectorUpdateGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConnectorsApi();
            var connector = connector_example;  // string | Lowercase system name of the source application or device
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Sync with data source
                apiInstance.V1ConnectorsConnectorUpdateGet(connector, accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectorsConnectorUpdateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connector** | **string**| Lowercase system name of the source application or device | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1ConnectorsListGet**
> List<Connector> V1ConnectorsListGet ()

List of Connectors

A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ConnectorsListGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConnectorsApi();

            try
            {
                // List of Connectors
                List&lt;Connector&gt; result = apiInstance.V1ConnectorsListGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectorsApi.V1ConnectorsListGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Connector>**](Connector.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

