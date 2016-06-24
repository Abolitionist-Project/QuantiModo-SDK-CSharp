# IO.Swagger.Api.RemindersApi

All URIs are relative to *https://app.quantimo.do/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1TrackingReminderNotificationsGet**](RemindersApi.md#v1trackingremindernotificationsget) | **GET** /v1/trackingReminderNotifications | Get specific pending tracking reminders
[**V1TrackingReminderNotificationsSkipPost**](RemindersApi.md#v1trackingremindernotificationsskippost) | **POST** /v1/trackingReminderNotifications/skip | Skip a pending tracking reminder
[**V1TrackingReminderNotificationsSnoozePost**](RemindersApi.md#v1trackingremindernotificationssnoozepost) | **POST** /v1/trackingReminderNotifications/snooze | Snooze a pending tracking reminder
[**V1TrackingReminderNotificationsTrackPost**](RemindersApi.md#v1trackingremindernotificationstrackpost) | **POST** /v1/trackingReminderNotifications/track | Track a pending tracking reminder
[**V1TrackingRemindersDeletePost**](RemindersApi.md#v1trackingremindersdeletepost) | **POST** /v1/trackingReminders/delete | Delete tracking reminder
[**V1TrackingRemindersGet**](RemindersApi.md#v1trackingremindersget) | **GET** /v1/trackingReminders | Get repeating tracking reminder settings
[**V1TrackingRemindersPost**](RemindersApi.md#v1trackingreminderspost) | **POST** /v1/trackingReminders | Store a Tracking Reminder


# **V1TrackingReminderNotificationsGet**
> InlineResponse200 V1TrackingReminderNotificationsGet (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)

Get specific pending tracking reminders

Specfic pending reminder instances that still need to be tracked.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1TrackingReminderNotificationsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RemindersApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var variableCategoryName = variableCategoryName_example;  // string | Limit tracking reminder notifications to a specific variable category (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get specific pending tracking reminders
                InlineResponse200 result = apiInstance.V1TrackingReminderNotificationsGet(accessToken, variableCategoryName, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemindersApi.V1TrackingReminderNotificationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **variableCategoryName** | **string**| Limit tracking reminder notifications to a specific variable category | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1TrackingReminderNotificationsSkipPost**
> CommonResponse V1TrackingReminderNotificationsSkipPost (TrackingReminderNotificationSkip body, string accessToken = null)

Skip a pending tracking reminder

Deletes the pending tracking reminder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1TrackingReminderNotificationsSkipPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RemindersApi();
            var body = new TrackingReminderNotificationSkip(); // TrackingReminderNotificationSkip | Id of the pending reminder to be skipped or deleted
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Skip a pending tracking reminder
                CommonResponse result = apiInstance.V1TrackingReminderNotificationsSkipPost(body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemindersApi.V1TrackingReminderNotificationsSkipPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackingReminderNotificationSkip**](TrackingReminderNotificationSkip.md)| Id of the pending reminder to be skipped or deleted | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1TrackingReminderNotificationsSnoozePost**
> CommonResponse V1TrackingReminderNotificationsSnoozePost (TrackingReminderNotificationSnooze body, string accessToken = null)

Snooze a pending tracking reminder

Changes the reminder time to now plus one hour

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1TrackingReminderNotificationsSnoozePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RemindersApi();
            var body = new TrackingReminderNotificationSnooze(); // TrackingReminderNotificationSnooze | Id of the pending reminder to be snoozed
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Snooze a pending tracking reminder
                CommonResponse result = apiInstance.V1TrackingReminderNotificationsSnoozePost(body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemindersApi.V1TrackingReminderNotificationsSnoozePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackingReminderNotificationSnooze**](TrackingReminderNotificationSnooze.md)| Id of the pending reminder to be snoozed | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1TrackingReminderNotificationsTrackPost**
> CommonResponse V1TrackingReminderNotificationsTrackPost (TrackingReminderNotificationTrack body, string accessToken = null)

Track a pending tracking reminder

Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1TrackingReminderNotificationsTrackPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RemindersApi();
            var body = new TrackingReminderNotificationTrack(); // TrackingReminderNotificationTrack | Id of the pending reminder to be tracked
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Track a pending tracking reminder
                CommonResponse result = apiInstance.V1TrackingReminderNotificationsTrackPost(body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemindersApi.V1TrackingReminderNotificationsTrackPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackingReminderNotificationTrack**](TrackingReminderNotificationTrack.md)| Id of the pending reminder to be tracked | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1TrackingRemindersDeletePost**
> CommonResponse V1TrackingRemindersDeletePost (TrackingReminderDelete body, string accessToken = null)

Delete tracking reminder

Delete previously created tracking reminder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1TrackingRemindersDeletePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RemindersApi();
            var body = new TrackingReminderDelete(); // TrackingReminderDelete | Id of reminder to be deleted
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 

            try
            {
                // Delete tracking reminder
                CommonResponse result = apiInstance.V1TrackingRemindersDeletePost(body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemindersApi.V1TrackingRemindersDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrackingReminderDelete**](TrackingReminderDelete.md)| Id of reminder to be deleted | 
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 

### Return type

[**CommonResponse**](CommonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1TrackingRemindersGet**
> InlineResponse2001 V1TrackingRemindersGet (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)

Get repeating tracking reminder settings

Users can be reminded to track certain variables at a specified frequency with a default value.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1TrackingRemindersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RemindersApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var variableCategoryName = variableCategoryName_example;  // string | Limit tracking reminders to a specific variable category (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get repeating tracking reminder settings
                InlineResponse2001 result = apiInstance.V1TrackingRemindersGet(accessToken, variableCategoryName, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemindersApi.V1TrackingRemindersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **variableCategoryName** | **string**| Limit tracking reminders to a specific variable category | [optional] 
 **createdAt** | **string**| When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  | [optional] 
 **updatedAt** | **string**| When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  | [optional] 
 **limit** | **int?**| The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. | [optional] 
 **offset** | **int?**| OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. | [optional] 
 **sort** | **string**| Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **V1TrackingRemindersPost**
> InlineResponse2002 V1TrackingRemindersPost (string accessToken = null, TrackingReminder body = null)

Store a Tracking Reminder

This is to enable users to create reminders to track a variable with a default value at a specified frequency

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1TrackingRemindersPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: quantimodo_oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RemindersApi();
            var accessToken = accessToken_example;  // string | User's OAuth2 access token (optional) 
            var body = new TrackingReminder(); // TrackingReminder | TrackingReminder that should be stored (optional) 

            try
            {
                // Store a Tracking Reminder
                InlineResponse2002 result = apiInstance.V1TrackingRemindersPost(accessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemindersApi.V1TrackingRemindersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| User&#39;s OAuth2 access token | [optional] 
 **body** | [**TrackingReminder**](TrackingReminder.md)| TrackingReminder that should be stored | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[quantimodo_oauth2](../README.md#quantimodo_oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

