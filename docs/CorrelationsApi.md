# IO.Swagger.Api.CorrelationsApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1AggregatedCorrelationsGet**](CorrelationsApi.md#v1aggregatedcorrelationsget) | **GET** /v1/aggregatedCorrelations | Get aggregated correlations
[**V1AggregatedCorrelationsPost**](CorrelationsApi.md#v1aggregatedcorrelationspost) | **POST** /v1/aggregatedCorrelations | Store or Update a Correlation
[**V1CorrelationsGet**](CorrelationsApi.md#v1correlationsget) | **GET** /v1/correlations | Get correlations
[**V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet**](CorrelationsApi.md#v1organizationsorganizationidusersuseridvariablesvariablenamecausesget) | **GET** /v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes | Search user correlations for a given cause
[**V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet**](CorrelationsApi.md#v1organizationsorganizationidusersuseridvariablesvariablenameeffectsget) | **GET** /v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects | Search user correlations for a given cause
[**V1PublicCorrelationsSearchSearchGet**](CorrelationsApi.md#v1publiccorrelationssearchsearchget) | **GET** /v1/public/correlations/search/{search} | Get average correlations for variables containing search term
[**V1VariablesVariableNameCausesGet**](CorrelationsApi.md#v1variablesvariablenamecausesget) | **GET** /v1/variables/{variableName}/causes | Search user correlations for a given effect
[**V1VariablesVariableNameEffectsGet**](CorrelationsApi.md#v1variablesvariablenameeffectsget) | **GET** /v1/variables/{variableName}/effects | Search user correlations for a given cause
[**V1VariablesVariableNamePublicCausesGet**](CorrelationsApi.md#v1variablesvariablenamepubliccausesget) | **GET** /v1/variables/{variableName}/public/causes | Search public correlations for a given effect
[**V1VariablesVariableNamePublicEffectsGet**](CorrelationsApi.md#v1variablesvariablenamepubliceffectsget) | **GET** /v1/variables/{variableName}/public/effects | Search public correlations for a given cause
[**V1VotesDeletePost**](CorrelationsApi.md#v1votesdeletepost) | **POST** /v1/votes/delete | Delete vote
[**V1VotesPost**](CorrelationsApi.md#v1votespost) | **POST** /v1/votes | Post or update vote


# **V1AggregatedCorrelationsGet**
> List<Correlation> V1AggregatedCorrelationsGet (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)

Get aggregated correlations

Get correlations based on the anonymized aggregate data from all QuantiModo users.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1AggregatedCorrelationsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var effect = effect_example;  // string | ORIGINAL variable name of the effect variable for which the user desires correlations (optional) 
            var cause = cause_example;  // string | ORIGINAL variable name of the cause variable for which the user desires correlations (optional) 
            var correlationCoefficient = correlationCoefficient_example;  // string | Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional) 
            var onsetDelay = onsetDelay_example;  // string | The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional) 
            var durationOfAction = durationOfAction_example;  // string | The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional) 
            var lastUpdated = lastUpdated_example;  // string | The time that this measurement was last updated in the UTC format \"YYYY-MM-DDThh:mm:ss\" (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 
            var sort = 56;  // int? | Sort by given field. If the field is prefixed with `-, it will sort in descending order. (optional) 

            try
            {
                // Get aggregated correlations
                List&lt;Correlation&gt; result = apiInstance.V1AggregatedCorrelationsGet(accessToken, effect, cause, correlationCoefficient, onsetDelay, durationOfAction, lastUpdated, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1AggregatedCorrelationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **effect** | **string**| ORIGINAL variable name of the effect variable for which the user desires correlations | [optional] 
 **cause** | **string**| ORIGINAL variable name of the cause variable for which the user desires correlations | [optional] 
 **correlationCoefficient** | **string**| Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action | [optional] 
 **onsetDelay** | **string**| The number of seconds which pass following a cause measurement before an effect would likely be observed. | [optional] 
 **durationOfAction** | **string**| The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. | [optional] 
 **lastUpdated** | **string**| The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 
 **sort** | **int?**| Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. | [optional] 

### Return type

[**List<Correlation>**](Correlation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1AggregatedCorrelationsPost**
> void V1AggregatedCorrelationsPost (PostCorrelation body, string accessToken = null)

Store or Update a Correlation

Add correlation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1AggregatedCorrelationsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var body = new PostCorrelation(); // PostCorrelation | Provides correlation data
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Store or Update a Correlation
                apiInstance.V1AggregatedCorrelationsPost(body, accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1AggregatedCorrelationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostCorrelation**](PostCorrelation.md)| Provides correlation data | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1CorrelationsGet**
> List<Correlation> V1CorrelationsGet (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)

Get correlations

Get correlations.<br>Supported filter parameters:<br><ul><li><b>correlationCoefficient</b> - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</li><li><b>onsetDelay</b> - The number of seconds which pass following a cause measurement before an effect would likely be observed.</li><li><b>durationOfAction</b> - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</li><li><b>lastUpdated</b> - The time that this measurement was last updated in the UTC format \"YYYY-MM-DDThh:mm:ss\"</li></ul><br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CorrelationsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var effect = effect_example;  // string | ORIGINAL variable name of the effect variable for which the user desires correlations (optional) 
            var cause = cause_example;  // string | ORIGINAL variable name of the cause variable for which the user desires correlations (optional) 
            var correlationCoefficient = correlationCoefficient_example;  // string | Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional) 
            var onsetDelay = onsetDelay_example;  // string | The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional) 
            var durationOfAction = durationOfAction_example;  // string | The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional) 
            var lastUpdated = lastUpdated_example;  // string | The time that this measurement was last updated in the UTC format \"YYYY-MM-DDThh:mm:ss\" (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 
            var sort = 56;  // int? | Sort by given field. If the field is prefixed with `-, it will sort in descending order. (optional) 

            try
            {
                // Get correlations
                List&lt;Correlation&gt; result = apiInstance.V1CorrelationsGet(accessToken, effect, cause, correlationCoefficient, onsetDelay, durationOfAction, lastUpdated, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1CorrelationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **effect** | **string**| ORIGINAL variable name of the effect variable for which the user desires correlations | [optional] 
 **cause** | **string**| ORIGINAL variable name of the cause variable for which the user desires correlations | [optional] 
 **correlationCoefficient** | **string**| Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action | [optional] 
 **onsetDelay** | **string**| The number of seconds which pass following a cause measurement before an effect would likely be observed. | [optional] 
 **durationOfAction** | **string**| The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. | [optional] 
 **lastUpdated** | **string**| The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 
 **sort** | **int?**| Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. | [optional] 

### Return type

[**List<Correlation>**](Correlation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet**
> List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)

Search user correlations for a given cause

Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \"include_public\" is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var organizationId = 56;  // int? | Organization ID
            var userId = 56;  // int? | User id
            var variableName = variableName_example;  // string | Effect variable name
            var organizationToken = organizationToken_example;  // string | Organization access token
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var includePublic = includePublic_example;  // string | Include public correlations, Can be \"1\" or empty. (optional) 

            try
            {
                // Search user correlations for a given cause
                List&lt;Correlation&gt; result = apiInstance.V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet(organizationId, userId, variableName, organizationToken, accessToken, includePublic);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Organization ID | 
 **userId** | **int?**| User id | 
 **variableName** | **string**| Effect variable name | 
 **organizationToken** | **string**| Organization access token | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **includePublic** | **string**| Include public correlations, Can be \&quot;1\&quot; or empty. | [optional] 

### Return type

[**List<Correlation>**](Correlation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet**
> List<CommonResponse> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)

Search user correlations for a given cause

Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \"include_public\" is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var organizationId = 56;  // int? | Organization ID
            var userId = 56;  // int? | User id
            var variableName = variableName_example;  // string | Cause variable name
            var organizationToken = organizationToken_example;  // string | Organization access token
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var includePublic = includePublic_example;  // string | Include public correlations, Can be \"1\" or empty. (optional) 

            try
            {
                // Search user correlations for a given cause
                List&lt;CommonResponse&gt; result = apiInstance.V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet(organizationId, userId, variableName, organizationToken, accessToken, includePublic);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **int?**| Organization ID | 
 **userId** | **int?**| User id | 
 **variableName** | **string**| Cause variable name | 
 **organizationToken** | **string**| Organization access token | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **includePublic** | **string**| Include public correlations, Can be \&quot;1\&quot; or empty. | [optional] 

### Return type

[**List<CommonResponse>**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1PublicCorrelationsSearchSearchGet**
> List<Correlation> V1PublicCorrelationsSearchSearchGet (string search, string effectOrCause, string accessToken = null)

Get average correlations for variables containing search term

Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PublicCorrelationsSearchSearchGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var search = search_example;  // string | Name of the variable that you want to know the causes or effects of.
            var effectOrCause = effectOrCause_example;  // string | Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Get average correlations for variables containing search term
                List&lt;Correlation&gt; result = apiInstance.V1PublicCorrelationsSearchSearchGet(search, effectOrCause, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1PublicCorrelationsSearchSearchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Name of the variable that you want to know the causes or effects of. | 
 **effectOrCause** | **string**| Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**List<Correlation>**](Correlation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariablesVariableNameCausesGet**
> List<Correlation> V1VariablesVariableNameCausesGet (string variableName)

Search user correlations for a given effect

Returns average of all correlations and votes for all user cause variables for a given effect

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariablesVariableNameCausesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var variableName = variableName_example;  // string | Effect variable name

            try
            {
                // Search user correlations for a given effect
                List&lt;Correlation&gt; result = apiInstance.V1VariablesVariableNameCausesGet(variableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1VariablesVariableNameCausesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **variableName** | **string**| Effect variable name | 

### Return type

[**List<Correlation>**](Correlation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariablesVariableNameEffectsGet**
> List<Correlation> V1VariablesVariableNameEffectsGet (string variableName, string accessToken = null)

Search user correlations for a given cause

Returns average of all correlations and votes for all user effect variables for a given cause

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariablesVariableNameEffectsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var variableName = variableName_example;  // string | Cause variable name
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Search user correlations for a given cause
                List&lt;Correlation&gt; result = apiInstance.V1VariablesVariableNameEffectsGet(variableName, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1VariablesVariableNameEffectsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **variableName** | **string**| Cause variable name | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**List<Correlation>**](Correlation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariablesVariableNamePublicCausesGet**
> List<Correlation> V1VariablesVariableNamePublicCausesGet (string variableName, string accessToken = null)

Search public correlations for a given effect

Returns average of all correlations and votes for all public cause variables for a given effect

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariablesVariableNamePublicCausesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var variableName = variableName_example;  // string | Effect variable name
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Search public correlations for a given effect
                List&lt;Correlation&gt; result = apiInstance.V1VariablesVariableNamePublicCausesGet(variableName, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1VariablesVariableNamePublicCausesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **variableName** | **string**| Effect variable name | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**List<Correlation>**](Correlation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VariablesVariableNamePublicEffectsGet**
> List<Correlation> V1VariablesVariableNamePublicEffectsGet (string variableName, string accessToken = null)

Search public correlations for a given cause

Returns average of all correlations and votes for all public cause variables for a given cause

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VariablesVariableNamePublicEffectsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var variableName = variableName_example;  // string | Cause variable name
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Search public correlations for a given cause
                List&lt;Correlation&gt; result = apiInstance.V1VariablesVariableNamePublicEffectsGet(variableName, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1VariablesVariableNamePublicEffectsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **variableName** | **string**| Cause variable name | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**List<Correlation>**](Correlation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VotesDeletePost**
> CommonResponse V1VotesDeletePost (VoteDelete body, string accessToken = null)

Delete vote

Delete previously posted vote

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VotesDeletePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var body = new VoteDelete(); // VoteDelete | The cause and effect variable names for the predictor vote to be deleted.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Delete vote
                CommonResponse result = apiInstance.V1VotesDeletePost(body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1VotesDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VoteDelete**](VoteDelete.md)| The cause and effect variable names for the predictor vote to be deleted. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1VotesPost**
> CommonResponse V1VotesPost (PostVote body, string accessToken = null)

Post or update vote

This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1VotesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CorrelationsApi();
            var body = new PostVote(); // PostVote | Contains the cause variable, effect variable, and vote value.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Post or update vote
                CommonResponse result = apiInstance.V1VotesPost(body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorrelationsApi.V1VotesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostVote**](PostVote.md)| Contains the cause variable, effect variable, and vote value. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

