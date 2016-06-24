# IO.Swagger.Api.VariablesApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PublicVariablesGet**](VariablesApi.md#v1publicvariablesget) | **GET** /v1/public/variables | Get public variables
[**V1PublicVariablesSearchSearchGet**](VariablesApi.md#v1publicvariablessearchsearchget) | **GET** /v1/public/variables/search/{search} | Get top 5 PUBLIC variables with the most correlations
[**V1UserVariablesPost**](VariablesApi.md#v1uservariablespost) | **POST** /v1/userVariables | Update User Settings for a Variable
[**V1VariableCategoriesGet**](VariablesApi.md#v1variablecategoriesget) | **GET** /v1/variableCategories | Variable categories
[**V1VariablesGet**](VariablesApi.md#v1variablesget) | **GET** /v1/variables | Get variables by the category name
[**V1VariablesPost**](VariablesApi.md#v1variablespost) | **POST** /v1/variables | Create Variables
[**V1VariablesSearchSearchGet**](VariablesApi.md#v1variablessearchsearchget) | **GET** /v1/variables/search/{search} | Get variables by search query
[**V1VariablesVariableNameGet**](VariablesApi.md#v1variablesvariablenameget) | **GET** /v1/variables/{variableName} | Get info about a variable


# **V1PublicVariablesGet**
> Variable V1PublicVariablesGet ()

Get public variables

This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PublicVariablesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VariablesApi();

            try
            {
                // Get public variables
                Variable result = apiInstance.V1PublicVariablesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.V1PublicVariablesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Variable**](Variable.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1PublicVariablesSearchSearchGet**
> Variable V1PublicVariablesSearchSearchGet (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null)

Get top 5 PUBLIC variables with the most correlations

Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for 'mood' as an effect. Since 'Overall Mood' has a lot of correlations with other variables, it should be in the autocomplete list.<br>Supported filter parameters:<br><ul><li><b>category</b> - Category of Variable</li></ul><br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PublicVariablesSearchSearchGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VariablesApi();
            var search = search_example;  // string | Search query can be some fraction of a variable name.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var categoryName = categoryName_example;  // string | Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional) 
            var source = source_example;  // string | Specify a data source name to only return variables from a specific data source. (optional) 
            var effectOrCause = effectOrCause_example;  // string | Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional) 
            var publicEffectOrCause = publicEffectOrCause_example;  // string | Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 
            var sort = 56;  // int? | Sort by given field. If the field is prefixed with `-, it will sort in descending order. (optional) 

            try
            {
                // Get top 5 PUBLIC variables with the most correlations
                Variable result = apiInstance.V1PublicVariablesSearchSearchGet(search, accessToken, categoryName, source, effectOrCause, publicEffectOrCause, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.V1PublicVariablesSearchSearchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Search query can be some fraction of a variable name. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **categoryName** | **string**| Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. | [optional] 
 **source** | **string**| Specify a data source name to only return variables from a specific data source. | [optional] 
 **effectOrCause** | **string**| Indicate if you only want variables that have user correlations.  Possible values are effect and cause. | [optional] 
 **publicEffectOrCause** | **string**| Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 
 **sort** | **int?**| Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. | [optional] 

### Return type

[**Variable**](Variable.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1UserVariablesPost**
> void V1UserVariablesPost (UserVariables userVariables)

Update User Settings for a Variable

Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1UserVariablesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VariablesApi();
            var userVariables = new UserVariables(); // UserVariables | Variable user settings data

            try
            {
                // Update User Settings for a Variable
                apiInstance.V1UserVariablesPost(userVariables);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.V1UserVariablesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userVariables** | [**UserVariables**](UserVariables.md)| Variable user settings data | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariableCategoriesGet**
> List<VariableCategory> V1VariableCategoriesGet ()

Variable categories

The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariableCategoriesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VariablesApi();

            try
            {
                // Variable categories
                List&lt;VariableCategory&gt; result = apiInstance.V1VariableCategoriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.V1VariableCategoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<VariableCategory>**](VariableCategory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariablesGet**
> Variable V1VariablesGet (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null)

Get variables by the category name

Get variables by the category name. <br>Supported filter parameters:<br><ul><li><b>name</b> - Original name of the variable (supports exact name match only)</li><li><b>lastUpdated</b> - Filter by the last time any of the properties of the variable were changed. Uses UTC format \"YYYY-MM-DDThh:mm:ss\"</li><li><b>source</b> - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here</li><li><b>latestMeasurementTime</b> - Filter variables based on the last time a measurement for them was created or updated in the UTC format \"YYYY-MM-DDThh:mm:ss\"</li><li><b>numberOfMeasurements</b> - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.</li><li><b>lastSource</b> - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)</li></ul><br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariablesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = 'YOUR_USERNAME';
            Configuration.Default.Password = 'YOUR_PASSWORD';

            var apiInstance = new VariablesApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var id = 56;  // int? | Common variable id (optional) 
            var userId = 56;  // int? | User id (optional) 
            var category = category_example;  // string | Filter data by category (optional) 
            var name = name_example;  // string | Original name of the variable (supports exact name match only) (optional) 
            var lastUpdated = lastUpdated_example;  // string | Filter by the last time any of the properties of the variable were changed. Uses UTC format \"YYYY-MM-DDThh:mm:ss\" (optional) 
            var source = source_example;  // string | The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional) 
            var latestMeasurementTime = latestMeasurementTime_example;  // string | Filter variables based on the last time a measurement for them was created or updated in the UTC format \"YYYY-MM-DDThh:mm:ss\" (optional) 
            var numberOfMeasurements = numberOfMeasurements_example;  // string | Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional) 
            var lastSource = lastSource_example;  // string | Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 
            var sort = 56;  // int? | Sort by given field. If the field is prefixed with `-, it will sort in descending order. (optional) 

            try
            {
                // Get variables by the category name
                Variable result = apiInstance.V1VariablesGet(accessToken, id, userId, category, name, lastUpdated, source, latestMeasurementTime, numberOfMeasurements, lastSource, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.V1VariablesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **id** | **int?**| Common variable id | [optional] 
 **userId** | **int?**| User id | [optional] 
 **category** | **string**| Filter data by category | [optional] 
 **name** | **string**| Original name of the variable (supports exact name match only) | [optional] 
 **lastUpdated** | **string**| Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; | [optional] 
 **source** | **string**| The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here | [optional] 
 **latestMeasurementTime** | **string**| Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; | [optional] 
 **numberOfMeasurements** | **string**| Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. | [optional] 
 **lastSource** | **string**| Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 
 **sort** | **int?**| Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. | [optional] 

### Return type

[**Variable**](Variable.md)

### Authorization

[oauth2](../README.md#oauth2), [basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariablesPost**
> void V1VariablesPost (VariablesNew body, string accessToken = null)

Create Variables

Allows the client to create a new variable in the `variables` table.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariablesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VariablesApi();
            var body = new VariablesNew(); // VariablesNew | Original name for the variable.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Create Variables
                apiInstance.V1VariablesPost(body, accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.V1VariablesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VariablesNew**](VariablesNew.md)| Original name for the variable. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariablesSearchSearchGet**
> List<Variable> V1VariablesSearchSearchGet (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null)

Get variables by search query

Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariablesSearchSearchGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VariablesApi();
            var search = search_example;  // string | Search query which may be an entire variable name or a fragment of one.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var categoryName = categoryName_example;  // string | Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional) 
            var includePublic = true;  // bool? | Set to true if you would like to include public variables when no user variables are found. (optional) 
            var manualTracking = true;  // bool? | Set to true if you would like to exlude variables like apps and website names. (optional) 
            var source = source_example;  // string | Specify a data source name to only return variables from a specific data source. (optional) 
            var effectOrCause = effectOrCause_example;  // string | Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional) 
            var publicEffectOrCause = publicEffectOrCause_example;  // string | Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 

            try
            {
                // Get variables by search query
                List&lt;Variable&gt; result = apiInstance.V1VariablesSearchSearchGet(search, accessToken, categoryName, includePublic, manualTracking, source, effectOrCause, publicEffectOrCause, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.V1VariablesSearchSearchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Search query which may be an entire variable name or a fragment of one. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **categoryName** | **string**| Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. | [optional] 
 **includePublic** | **bool?**| Set to true if you would like to include public variables when no user variables are found. | [optional] 
 **manualTracking** | **bool?**| Set to true if you would like to exlude variables like apps and website names. | [optional] 
 **source** | **string**| Specify a data source name to only return variables from a specific data source. | [optional] 
 **effectOrCause** | **string**| Indicate if you only want variables that have user correlations.  Possible values are effect and cause. | [optional] 
 **publicEffectOrCause** | **string**| Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 

### Return type

[**List<Variable>**](Variable.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariablesVariableNameGet**
> Variable V1VariablesVariableNameGet (string variableName, string accessToken = null)

Get info about a variable

Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariablesVariableNameGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VariablesApi();
            var variableName = variableName_example;  // string | Variable name
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Get info about a variable
                Variable result = apiInstance.V1VariablesVariableNameGet(variableName, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.V1VariablesVariableNameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **variableName** | **string**| Variable name | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**Variable**](Variable.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

