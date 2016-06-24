# IO.Swagger.Api.MeasurementsApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1MeasurementSourcesGet**](MeasurementsApi.md#v1measurementsourcesget) | **GET** /v1/measurementSources | Get measurement sources
[**V1MeasurementSourcesPost**](MeasurementsApi.md#v1measurementsourcespost) | **POST** /v1/measurementSources | Add a data source
[**V1MeasurementsDailyGet**](MeasurementsApi.md#v1measurementsdailyget) | **GET** /v1/measurements/daily | Get daily measurements for this user
[**V1MeasurementsDeletePost**](MeasurementsApi.md#v1measurementsdeletepost) | **POST** /v1/measurements/delete | Delete a measurement
[**V1MeasurementsGet**](MeasurementsApi.md#v1measurementsget) | **GET** /v1/measurements | Get measurements for this user
[**V1MeasurementsPost**](MeasurementsApi.md#v1measurementspost) | **POST** /v1/measurements | Post a new set or update existing measurements to the database
[**V1MeasurementsRangeGet**](MeasurementsApi.md#v1measurementsrangeget) | **GET** /v1/measurementsRange | Get measurements range for this user
[**V2MeasurementsCsvGet**](MeasurementsApi.md#v2measurementscsvget) | **GET** /v2/measurements/csv | Get Measurements CSV
[**V2MeasurementsIdDelete**](MeasurementsApi.md#v2measurementsiddelete) | **DELETE** /v2/measurements/{id} | Delete Measurement
[**V2MeasurementsIdGet**](MeasurementsApi.md#v2measurementsidget) | **GET** /v2/measurements/{id} | Get Measurement
[**V2MeasurementsIdPut**](MeasurementsApi.md#v2measurementsidput) | **PUT** /v2/measurements/{id} | Update Measurement
[**V2MeasurementsRequestCsvPost**](MeasurementsApi.md#v2measurementsrequestcsvpost) | **POST** /v2/measurements/request_csv | Post Request for Measurements CSV
[**V2MeasurementsRequestPdfPost**](MeasurementsApi.md#v2measurementsrequestpdfpost) | **POST** /v2/measurements/request_pdf | Post Request for Measurements PDF
[**V2MeasurementsRequestXlsPost**](MeasurementsApi.md#v2measurementsrequestxlspost) | **POST** /v2/measurements/request_xls | Post Request for Measurements XLS


# **V1MeasurementSourcesGet**
> MeasurementSource V1MeasurementSourcesGet ()

Get measurement sources

Returns a list of all the apps from which measurement data is obtained.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MeasurementSourcesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();

            try
            {
                // Get measurement sources
                MeasurementSource result = apiInstance.V1MeasurementSourcesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V1MeasurementSourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MeasurementSource**](MeasurementSource.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1MeasurementSourcesPost**
> void V1MeasurementSourcesPost (MeasurementSource body, string accessToken = null)

Add a data source

Add a life-tracking app or device to the QuantiModo list of data sources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MeasurementSourcesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var body = new MeasurementSource(); // MeasurementSource | An array of names of data sources you want to add.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Add a data source
                apiInstance.V1MeasurementSourcesPost(body, accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V1MeasurementSourcesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MeasurementSource**](MeasurementSource.md)| An array of names of data sources you want to add. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1MeasurementsDailyGet**
> Measurement V1MeasurementsDailyGet (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)

Get daily measurements for this user

Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. <br>Supported filter parameters:<br><ul><li><b>value</b> - Value of measurement</li><li><b>lastUpdated</b> - The time that this measurement was created or last updated in the UTC format \"YYYY-MM-DDThh:mm:ss\"</li></ul><br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MeasurementsDailyGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var variableName = variableName_example;  // string | Name of the variable you want measurements for
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var abbreviatedUnitName = abbreviatedUnitName_example;  // string | The unit your want the measurements in (optional) 
            var startTime = startTime_example;  // string | The lower limit of measurements returned (Iso8601) (optional) 
            var endTime = endTime_example;  // string | The upper limit of measurements returned (Iso8601) (optional) 
            var groupingWidth = 56;  // int? | The time (in seconds) over which measurements are grouped together (optional) 
            var groupingTimezone = groupingTimezone_example;  // string | The time (in seconds) over which measurements are grouped together (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 
            var sort = 56;  // int? | Sort by given field. If the field is prefixed with `-, it will sort in descending order. (optional) 

            try
            {
                // Get daily measurements for this user
                Measurement result = apiInstance.V1MeasurementsDailyGet(variableName, accessToken, abbreviatedUnitName, startTime, endTime, groupingWidth, groupingTimezone, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V1MeasurementsDailyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **variableName** | **string**| Name of the variable you want measurements for | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **abbreviatedUnitName** | **string**| The unit your want the measurements in | [optional] 
 **startTime** | **string**| The lower limit of measurements returned (Iso8601) | [optional] 
 **endTime** | **string**| The upper limit of measurements returned (Iso8601) | [optional] 
 **groupingWidth** | **int?**| The time (in seconds) over which measurements are grouped together | [optional] 
 **groupingTimezone** | **string**| The time (in seconds) over which measurements are grouped together | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 
 **sort** | **int?**| Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. | [optional] 

### Return type

[**Measurement**](Measurement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1MeasurementsDeletePost**
> CommonResponse V1MeasurementsDeletePost (MeasurementDelete body)

Delete a measurement

Delete a previously submitted measurement

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MeasurementsDeletePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var body = new MeasurementDelete(); // MeasurementDelete | The startTime and variableId of the measurement to be deleted.

            try
            {
                // Delete a measurement
                CommonResponse result = apiInstance.V1MeasurementsDeletePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V1MeasurementsDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MeasurementDelete**](MeasurementDelete.md)| The startTime and variableId of the measurement to be deleted. | 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1MeasurementsGet**
> Measurement V1MeasurementsGet (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)

Get measurements for this user

Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. <br>Supported filter parameters:<br><ul><li><b>value</b> - Value of measurement</li><li><b>lastUpdated</b> - The time that this measurement was created or last updated in the UTC format \"YYYY-MM-DDThh:mm:ss\"</li></ul><br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MeasurementsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var variableName = variableName_example;  // string | Name of the variable you want measurements for (optional) 
            var variableCategoryName = variableCategoryName_example;  // string | Name of the variable category you want measurements for (optional) 
            var source = source_example;  // string | Name of the source you want measurements for (supports exact name match only) (optional) 
            var value = value_example;  // string | Value of measurement (optional) 
            var lastUpdated = lastUpdated_example;  // string | The time that this measurement was created or last updated in the format \"YYYY-MM-DDThh:mm:ss\" (optional) 
            var unit = unit_example;  // string | The unit you want the measurements returned in (optional) 
            var startTime = startTime_example;  // string | The lower limit of measurements returned (Epoch) (optional) 
            var createdAt = createdAt_example;  // string | The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional) 
            var updatedAt = updatedAt_example;  // string | The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional) 
            var endTime = endTime_example;  // string | The upper limit of measurements returned (Epoch) (optional) 
            var groupingWidth = 56;  // int? | The time (in seconds) over which measurements are grouped together (optional) 
            var groupingTimezone = groupingTimezone_example;  // string | The time (in seconds) over which measurements are grouped together (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional) 
            var offset = 56;  // int? | Now suppose you wanted to show results 11-20. You'd set the offset to 10 and the limit to 10. (optional) 
            var sort = 56;  // int? | Sort by given field. If the field is prefixed with `-, it will sort in descending order. (optional) 

            try
            {
                // Get measurements for this user
                Measurement result = apiInstance.V1MeasurementsGet(accessToken, variableName, variableCategoryName, source, value, lastUpdated, unit, startTime, createdAt, updatedAt, endTime, groupingWidth, groupingTimezone, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V1MeasurementsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **variableName** | **string**| Name of the variable you want measurements for | [optional] 
 **variableCategoryName** | **string**| Name of the variable category you want measurements for | [optional] 
 **source** | **string**| Name of the source you want measurements for (supports exact name match only) | [optional] 
 **value** | **string**| Value of measurement | [optional] 
 **lastUpdated** | **string**| The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; | [optional] 
 **unit** | **string**| The unit you want the measurements returned in | [optional] 
 **startTime** | **string**| The lower limit of measurements returned (Epoch) | [optional] 
 **createdAt** | **string**| The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. | [optional] 
 **updatedAt** | **string**| The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. | [optional] 
 **endTime** | **string**| The upper limit of measurements returned (Epoch) | [optional] 
 **groupingWidth** | **int?**| The time (in seconds) over which measurements are grouped together | [optional] 
 **groupingTimezone** | **string**| The time (in seconds) over which measurements are grouped together | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. | [optional] 
 **offset** | **int?**| Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. | [optional] 
 **sort** | **int?**| Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. | [optional] 

### Return type

[**Measurement**](Measurement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1MeasurementsPost**
> void V1MeasurementsPost (MeasurementSet body, string accessToken = null)

Post a new set or update existing measurements to the database

You can submit or update multiple measurements in a \"measurements\" sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\"measurements\":[{\"startTime\":1439389320,\"value\":\"3\"}, {\"startTime\":1439389319,\"value\":\"2\"}],\"name\":\"Acne (out of 5)\",\"source\":\"QuantiModo\",\"category\":\"Symptoms\",\"combinationOperation\":\"MEAN\",\"unit\":\"/5\"}]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MeasurementsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var body = new MeasurementSet(); // MeasurementSet | An array of measurements you want to insert.
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Post a new set or update existing measurements to the database
                apiInstance.V1MeasurementsPost(body, accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V1MeasurementsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MeasurementSet**](MeasurementSet.md)| An array of measurements you want to insert. | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1MeasurementsRangeGet**
> MeasurementRange V1MeasurementsRangeGet (string sources = null, int? user = null)

Get measurements range for this user

Get Unix time-stamp (epoch time) of the user's first and last measurements taken.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MeasurementsRangeGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var sources = sources_example;  // string | Enter source name to limit to specific source (varchar) (optional) 
            var user = 56;  // int? | If not specified, uses currently logged in user (bigint) (optional) 

            try
            {
                // Get measurements range for this user
                MeasurementRange result = apiInstance.V1MeasurementsRangeGet(sources, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V1MeasurementsRangeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sources** | **string**| Enter source name to limit to specific source (varchar) | [optional] 
 **user** | **int?**| If not specified, uses currently logged in user (bigint) | [optional] 

### Return type

[**MeasurementRange**](MeasurementRange.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2MeasurementsCsvGet**
> System.IO.Stream V2MeasurementsCsvGet (string accessToken = null)

Get Measurements CSV

Download a CSV containing all user measurements

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MeasurementsCsvGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Get Measurements CSV
                System.IO.Stream result = apiInstance.V2MeasurementsCsvGet(accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V2MeasurementsCsvGet: " + e.Message );
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

**System.IO.Stream**

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2MeasurementsIdDelete**
> InlineResponse20012 V2MeasurementsIdDelete (int? id, string accessToken = null)

Delete Measurement

Delete Measurement

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MeasurementsIdDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var id = 56;  // int? | id of Measurement
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Delete Measurement
                InlineResponse20012 result = apiInstance.V2MeasurementsIdDelete(id, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V2MeasurementsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of Measurement | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2MeasurementsIdGet**
> InlineResponse20011 V2MeasurementsIdGet (int? id, string accessToken = null)

Get Measurement

Get Measurement

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MeasurementsIdGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var id = 56;  // int? | id of Measurement
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Get Measurement
                InlineResponse20011 result = apiInstance.V2MeasurementsIdGet(id, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V2MeasurementsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of Measurement | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2MeasurementsIdPut**
> InlineResponse20012 V2MeasurementsIdPut (int? id, string accessToken = null, Measurement body = null)

Update Measurement

Update Measurement

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MeasurementsIdPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var id = 56;  // int? | id of Measurement
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var body = new Measurement(); // Measurement | Measurement that should be updated (optional) 

            try
            {
                // Update Measurement
                InlineResponse20012 result = apiInstance.V2MeasurementsIdPut(id, accessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V2MeasurementsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of Measurement | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **body** | [**Measurement**](Measurement.md)| Measurement that should be updated | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2MeasurementsRequestCsvPost**
> int? V2MeasurementsRequestCsvPost (string accessToken = null)

Post Request for Measurements CSV

Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MeasurementsRequestCsvPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Post Request for Measurements CSV
                int? result = apiInstance.V2MeasurementsRequestCsvPost(accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V2MeasurementsRequestCsvPost: " + e.Message );
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

**int?**

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2MeasurementsRequestPdfPost**
> int? V2MeasurementsRequestPdfPost (string accessToken = null)

Post Request for Measurements PDF

Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MeasurementsRequestPdfPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Post Request for Measurements PDF
                int? result = apiInstance.V2MeasurementsRequestPdfPost(accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V2MeasurementsRequestPdfPost: " + e.Message );
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

**int?**

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V2MeasurementsRequestXlsPost**
> int? V2MeasurementsRequestXlsPost (string accessToken = null)

Post Request for Measurements XLS

Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MeasurementsRequestXlsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new MeasurementsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Post Request for Measurements XLS
                int? result = apiInstance.V2MeasurementsRequestXlsPost(accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeasurementsApi.V2MeasurementsRequestXlsPost: " + e.Message );
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

**int?**

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

