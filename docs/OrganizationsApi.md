# IO.Swagger.Api.OrganizationsApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1OrganizationsOrganizationIdUsersPost**](OrganizationsApi.md#v1organizationsorganizationiduserspost) | **POST** /v1/organizations/{organizationId}/users | Get user tokens for existing users, create new users


# **V1OrganizationsOrganizationIdUsersPost**
> UserTokenSuccessfulResponse V1OrganizationsOrganizationIdUsersPost (int? organizationId, UserTokenRequest body, string accessToken = null)

Get user tokens for existing users, create new users

Get user tokens for existing users, create new users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1OrganizationsOrganizationIdUsersPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new OrganizationsApi();
            var organizationId = 56;  // int? | Organization ID
            var body = new UserTokenRequest(); // UserTokenRequest | Provides organization token and user ID
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Get user tokens for existing users, create new users
                UserTokenSuccessfulResponse result = apiInstance.V1OrganizationsOrganizationIdUsersPost(organizationId, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsOrganizationIdUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Organization ID | 
 **body** | [**UserTokenRequest**](UserTokenRequest.md)| Provides organization token and user ID | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**UserTokenSuccessfulResponse**](UserTokenSuccessfulResponse.md)

### Authorization

[oauth2](../README.md#oauth2), [internalApiKey](../README.md#internalApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

