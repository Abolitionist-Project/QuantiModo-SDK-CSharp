# IO.Swagger.Api.PairsApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PairsCsvGet**](PairsApi.md#v1pairscsvget) | **GET** /v1/pairsCsv | Get pairs
[**V1PairsGet**](PairsApi.md#v1pairsget) | **GET** /v1/pairs | Get pairs


# **V1PairsCsvGet**
> List<Pairs> V1PairsCsvGet (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)

Get pairs

Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PairsCsvGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PairsApi();
            var cause = cause_example;  // string | Original variable name for the explanatory or independent variable
            var effect = effect_example;  // string | Original variable name for the outcome or dependent variable
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var causeSource = causeSource_example;  // string | Name of data source that the cause measurements should come from (optional) 
            var causeUnit = causeUnit_example;  // string | Abbreviated name for the unit cause measurements to be returned in (optional) 
            var delay = delay_example;  // string | Delay before onset of action (in seconds) from the cause variable settings. (optional) 
            var duration = duration_example;  // string | Duration of action (in seconds) from the cause variable settings. (optional) 
            var effectSource = effectSource_example;  // string | Name of data source that the effectmeasurements should come from (optional) 
            var effectUnit = effectUnit_example;  // string | Abbreviated name for the unit effect measurements to be returned in (optional) 
            var endTime = endTime_example;  // string | The most recent date (in epoch time) for which we should return measurements (optional) 
            var startTime = startTime_example;  // string | The earliest date (in epoch time) for which we should return measurements (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 
            var sort = 56;  // int? | Sort by given field. If the field is prefixed with `-, it will sort in descending order. (optional) 

            try
            {
                // Get pairs
                List&lt;Pairs&gt; result = apiInstance.V1PairsCsvGet(cause, effect, accessToken, causeSource, causeUnit, delay, duration, effectSource, effectUnit, endTime, startTime, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PairsApi.V1PairsCsvGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cause** | **string**| Original variable name for the explanatory or independent variable | 
 **effect** | **string**| Original variable name for the outcome or dependent variable | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **causeSource** | **string**| Name of data source that the cause measurements should come from | [optional] 
 **causeUnit** | **string**| Abbreviated name for the unit cause measurements to be returned in | [optional] 
 **delay** | **string**| Delay before onset of action (in seconds) from the cause variable settings. | [optional] 
 **duration** | **string**| Duration of action (in seconds) from the cause variable settings. | [optional] 
 **effectSource** | **string**| Name of data source that the effectmeasurements should come from | [optional] 
 **effectUnit** | **string**| Abbreviated name for the unit effect measurements to be returned in | [optional] 
 **endTime** | **string**| The most recent date (in epoch time) for which we should return measurements | [optional] 
 **startTime** | **string**| The earliest date (in epoch time) for which we should return measurements | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 
 **sort** | **int?**| Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. | [optional] 

### Return type

[**List<Pairs>**](Pairs.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1PairsGet**
> List<Pairs> V1PairsGet (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)

Get pairs

Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PairsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new PairsApi();
            var cause = cause_example;  // string | Original variable name for the explanatory or independent variable
            var effect = effect_example;  // string | Original variable name for the outcome or dependent variable
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var causeSource = causeSource_example;  // string | Name of data source that the cause measurements should come from (optional) 
            var causeUnit = causeUnit_example;  // string | Abbreviated name for the unit cause measurements to be returned in (optional) 
            var delay = delay_example;  // string | Delay before onset of action (in seconds) from the cause variable settings. (optional) 
            var duration = duration_example;  // string | Duration of action (in seconds) from the cause variable settings. (optional) 
            var effectSource = effectSource_example;  // string | Name of data source that the effectmeasurements should come from (optional) 
            var effectUnit = effectUnit_example;  // string | Abbreviated name for the unit effect measurements to be returned in (optional) 
            var endTime = endTime_example;  // string | The most recent date (in epoch time) for which we should return measurements (optional) 
            var startTime = startTime_example;  // string | The earliest date (in epoch time) for which we should return measurements (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 
            var sort = 56;  // int? | Sort by given field. If the field is prefixed with `-, it will sort in descending order. (optional) 

            try
            {
                // Get pairs
                List&lt;Pairs&gt; result = apiInstance.V1PairsGet(cause, effect, accessToken, causeSource, causeUnit, delay, duration, effectSource, effectUnit, endTime, startTime, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PairsApi.V1PairsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cause** | **string**| Original variable name for the explanatory or independent variable | 
 **effect** | **string**| Original variable name for the outcome or dependent variable | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **causeSource** | **string**| Name of data source that the cause measurements should come from | [optional] 
 **causeUnit** | **string**| Abbreviated name for the unit cause measurements to be returned in | [optional] 
 **delay** | **string**| Delay before onset of action (in seconds) from the cause variable settings. | [optional] 
 **duration** | **string**| Duration of action (in seconds) from the cause variable settings. | [optional] 
 **effectSource** | **string**| Name of data source that the effectmeasurements should come from | [optional] 
 **effectUnit** | **string**| Abbreviated name for the unit effect measurements to be returned in | [optional] 
 **endTime** | **string**| The most recent date (in epoch time) for which we should return measurements | [optional] 
 **startTime** | **string**| The earliest date (in epoch time) for which we should return measurements | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 
 **sort** | **int?**| Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. | [optional] 

### Return type

[**List<Pairs>**](Pairs.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

