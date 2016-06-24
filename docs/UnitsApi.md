# IO.Swagger.Api.UnitsApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1UnitCategoriesGet**](UnitsApi.md#v1unitcategoriesget) | **GET** /v1/unitCategories | Get unit categories
[**V1UnitsGet**](UnitsApi.md#v1unitsget) | **GET** /v1/units | Get all available units
[**V1UnitsVariableGet**](UnitsApi.md#v1unitsvariableget) | **GET** /v1/unitsVariable | Units for Variable


# **V1UnitCategoriesGet**
> UnitCategory V1UnitCategoriesGet ()

Get unit categories

Get a list of the categories of measurement units such as 'Distance', 'Duration', 'Energy', 'Frequency', 'Miscellany', 'Pressure', 'Proportion', 'Rating', 'Temperature', 'Volume', and 'Weight'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1UnitCategoriesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UnitsApi();

            try
            {
                // Get unit categories
                UnitCategory result = apiInstance.V1UnitCategoriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UnitsApi.V1UnitCategoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UnitCategory**](UnitCategory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1UnitsGet**
> List<Unit> V1UnitsGet (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null)

Get all available units

Get all available units

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1UnitsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UnitsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var id = 56;  // int? | Unit id (optional) 
            var unitName = unitName_example;  // string | Unit name (optional) 
            var abbreviatedUnitName = abbreviatedUnitName_example;  // string | Restrict the results to a specific unit by providing the unit abbreviation. (optional) 
            var categoryName = categoryName_example;  // string | Restrict the results to a specific unit category by providing the unit category name. (optional) 

            try
            {
                // Get all available units
                List&lt;Unit&gt; result = apiInstance.V1UnitsGet(accessToken, id, unitName, abbreviatedUnitName, categoryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UnitsApi.V1UnitsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **id** | **int?**| Unit id | [optional] 
 **unitName** | **string**| Unit name | [optional] 
 **abbreviatedUnitName** | **string**| Restrict the results to a specific unit by providing the unit abbreviation. | [optional] 
 **categoryName** | **string**| Restrict the results to a specific unit category by providing the unit category name. | [optional] 

### Return type

[**List<Unit>**](Unit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1UnitsVariableGet**
> List<Unit> V1UnitsVariableGet (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null)

Units for Variable

Get a list of all possible units to use for a given variable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1UnitsVariableGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new UnitsApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var unitName = unitName_example;  // string | Name of Unit you want to retrieve (optional) 
            var abbreviatedUnitName = abbreviatedUnitName_example;  // string | Abbreviated Unit Name of the unit you want (optional) 
            var categoryName = categoryName_example;  // string | Name of the category you want units for (optional) 
            var variable = variable_example;  // string | Name of the variable you want units for (optional) 

            try
            {
                // Units for Variable
                List&lt;Unit&gt; result = apiInstance.V1UnitsVariableGet(accessToken, unitName, abbreviatedUnitName, categoryName, variable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UnitsApi.V1UnitsVariableGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **unitName** | **string**| Name of Unit you want to retrieve | [optional] 
 **abbreviatedUnitName** | **string**| Abbreviated Unit Name of the unit you want | [optional] 
 **categoryName** | **string**| Name of the category you want units for | [optional] 
 **variable** | **string**| Name of the variable you want units for | [optional] 

### Return type

[**List<Unit>**](Unit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

