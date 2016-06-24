# IO.Swagger.Api.TagsApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1UserTagsDeletePost**](TagsApi.md#v1usertagsdeletepost) | **POST** /v1/userTags/delete | Delete user tag or ingredient
[**V1UserTagsPost**](TagsApi.md#v1usertagspost) | **POST** /v1/userTags | Post or update user tags or ingredients


# **V1UserTagsDeletePost**
> CommonResponse V1UserTagsDeletePost (int? taggedVariableId, int? tagVariableId)

Delete user tag or ingredient

Delete previously created user tags or ingredients.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1UserTagsDeletePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TagsApi();
            var taggedVariableId = 56;  // int? | This is the id of the variable being tagged with an ingredient or something.
            var tagVariableId = 56;  // int? | This is the id of the ingredient variable whose value is determined based on the value of the tagged variable.

            try
            {
                // Delete user tag or ingredient
                CommonResponse result = apiInstance.V1UserTagsDeletePost(taggedVariableId, tagVariableId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.V1UserTagsDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taggedVariableId** | **int?**| This is the id of the variable being tagged with an ingredient or something. | 
 **tagVariableId** | **int?**| This is the id of the ingredient variable whose value is determined based on the value of the tagged variable. | 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1UserTagsPost**
> CommonResponse V1UserTagsPost (UserTag body, string accessToken = null)

Post or update user tags or ingredients

This endpoint allows users to tag foods with their ingredients.  This information will then be used to infer the user intake of the different ingredients by just entering the foods. The inferred intake levels will then be used to determine the effects of different nutrients on the user during analysis.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1UserTagsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TagsApi();
            var body = new UserTag(); // UserTag | Contains the new user tag data
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Post or update user tags or ingredients
                CommonResponse result = apiInstance.V1UserTagsPost(body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.V1UserTagsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserTag**](UserTag.md)| Contains the new user tag data | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

