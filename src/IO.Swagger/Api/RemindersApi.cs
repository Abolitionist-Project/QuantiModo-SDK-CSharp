/* 
 * QuantiModo
 *
 * Welcome to QuantiModo API! QuantiModo makes it easy to retrieve normalized user data from a wide array of devices and applications. [Learn about QuantiModo](https://quantimo.do) or contact us at <api@quantimo.do>.         Before you get started, you will need to: * Sign in/Sign up, and add some data at [https://app.quantimo.do/api/v2/account/connectors](https://app.quantimo.do/api/v2/account/connectors) to try out the API for yourself * Create an app to get your client id and secret at [https://app.quantimo.do/api/v2/apps](https://app.quantimo.do/api/v2/apps) * As long as you're signed in, it will use your browser's cookie for authentication.  However, client applications must use OAuth2 tokens to access the API.     ## Application Endpoints These endpoints give you access to all authorized users' data for that application. ### Getting Application Token Make a `POST` request to `/api/v2/oauth/access_token`         * `grant_type` Must be `client_credentials`.         * `clientId` Your application's clientId.         * `client_secret` Your application's client_secret.         * `redirect_uri` Your application's redirect url.                ## Example Queries ### Query Options The standard query options for QuantiModo API are as described in the table below. These are the available query options in QuantiModo API: <table>            <thead>                <tr>                    <th>Parameter</th>                    <th>Description</th>                </tr>            </thead>            <tbody>                <tr>                    <td>limit</td>                    <td>The LIMIT is used to limit the number of results returned.  So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</td>                </tr>                <tr>                    <td>offset</td>                    <td>Suppose you wanted to show results 11-20. You'd set the    offset to 10 and the limit to 10.</td>                </tr>                <tr>                    <td>sort</td>                    <td>Sort by given field. If the field is prefixed with '-', it    will sort in descending order.</td>                </tr>            </tbody>        </table>         ### Pagination Conventions Since the maximum limit is 200 records, to get more than that you'll have to make multiple API calls and page through the results. To retrieve all the data, you can iterate through data by using the `limit` and `offset` query parameters.For example, if you want to retrieve data from 61-80 then you can use a query with the following parameters,         `/v2/variables?limit=20&offset=60`         Generally, you'll be retrieving new or updated user data. To avoid unnecessary API calls, you'll want to store your last refresh time locally.  Initially, it should be set to 0. Then whenever you make a request to get new data, you should limit the returned results to those updated since your last refresh by appending append         `?lastUpdated=(ge)&quot2013-01-D01T01:01:01&quot`         to your request.         Also for better pagination, you can get link to the records of first, last, next and previous page from response headers: * `Total-Count` - Total number of results for given query * `Link-First` - Link to get first page records * `Link-Last` - Link to get last page records * `Link-Prev` - Link to get previous records set * `Link-Next` - Link to get next records set         Remember, response header will be only sent when the record set is available. e.g. You will not get a ```Link-Last``` & ```Link-Next``` when you query for the last page.         ### Filter operators support API supports the following operators with filter parameters: <br> **Comparison operators**         Comparison operators allow you to limit results to those greater than, less than, or equal to a specified value for a specified attribute. These operators can be used with strings, numbers, and dates. The following comparison operators are available: * `gt` for `greater than` comparison * `ge` for `greater than or equal` comparison * `lt` for `less than` comparison * `le` for `less than or equal` comparison         They are included in queries using the following format:         `(<operator>)<value>`         For example, in order to filter value which is greater than 21, the following query parameter should be used:         `?value=(gt)21` <br><br> **Equals/In Operators**         It also allows filtering by the exact value of an attribute or by a set of values, depending on the type of value passed as a query parameter. If the value contains commas, the parameter is split on commas and used as array input for `IN` filtering, otherwise the exact match is applied. In order to only show records which have the value 42, the following query should be used:         `?value=42`         In order to filter records which have value 42 or 43, the following query should be used:         `?value=42,43` <br><br> **Like operators**         Like operators allow filtering using `LIKE` query. This operator is triggered if exact match operator is used, but value contains `%` sign as the first or last character. In order to filter records which category that start with `Food`, the following query should be used:         `?category=Food%` <br><br> **Negation operator**         It is possible to get negated results of a query by prefixed the operator with `!`. Some examples:         `//filter records except those with value are not 42 or 43`<br> `?value=!42,43`         `//filter records with value not greater than 21`<br> `?value=!(ge)21` <br><br> **Multiple constraints for single attribute**         It is possible to apply multiple constraints by providing an array of query filters:         Filter all records which value is greater than 20.2 and less than 20.3<br> `?value[]=(gt)20.2&value[]=(lt)20.3`         Filter all records which value is greater than 20.2 and less than 20.3 but not 20.2778<br> `?value[]=(gt)20.2&value[]=(lt)20.3&value[]=!20.2778`<br><br> 
 *
 * OpenAPI spec version: 2.0.6
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRemindersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get specific pending tracking reminders
        /// </summary>
        /// <remarks>
        /// Specfic pending reminder instances that still need to be tracked.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 V1TrackingReminderNotificationsGet (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get specific pending tracking reminders
        /// </summary>
        /// <remarks>
        /// Specfic pending reminder instances that still need to be tracked.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> V1TrackingReminderNotificationsGetWithHttpInfo (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Skip a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Deletes the pending tracking reminder
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1TrackingReminderNotificationsSkipPost (TrackingReminderNotificationSkip body, string accessToken = null);

        /// <summary>
        /// Skip a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Deletes the pending tracking reminder
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        ApiResponse<CommonResponse> V1TrackingReminderNotificationsSkipPostWithHttpInfo (TrackingReminderNotificationSkip body, string accessToken = null);
        /// <summary>
        /// Snooze a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Changes the reminder time to now plus one hour
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1TrackingReminderNotificationsSnoozePost (TrackingReminderNotificationSnooze body, string accessToken = null);

        /// <summary>
        /// Snooze a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Changes the reminder time to now plus one hour
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        ApiResponse<CommonResponse> V1TrackingReminderNotificationsSnoozePostWithHttpInfo (TrackingReminderNotificationSnooze body, string accessToken = null);
        /// <summary>
        /// Track a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1TrackingReminderNotificationsTrackPost (TrackingReminderNotificationTrack body, string accessToken = null);

        /// <summary>
        /// Track a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        ApiResponse<CommonResponse> V1TrackingReminderNotificationsTrackPostWithHttpInfo (TrackingReminderNotificationTrack body, string accessToken = null);
        /// <summary>
        /// Delete tracking reminder
        /// </summary>
        /// <remarks>
        /// Delete previously created tracking reminder
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1TrackingRemindersDeletePost (TrackingReminderDelete body, string accessToken = null);

        /// <summary>
        /// Delete tracking reminder
        /// </summary>
        /// <remarks>
        /// Delete previously created tracking reminder
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        ApiResponse<CommonResponse> V1TrackingRemindersDeletePostWithHttpInfo (TrackingReminderDelete body, string accessToken = null);
        /// <summary>
        /// Get repeating tracking reminder settings
        /// </summary>
        /// <remarks>
        /// Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 V1TrackingRemindersGet (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get repeating tracking reminder settings
        /// </summary>
        /// <remarks>
        /// Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> V1TrackingRemindersGetWithHttpInfo (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Store a Tracking Reminder
        /// </summary>
        /// <remarks>
        /// This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">TrackingReminder that should be stored (optional)</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 V1TrackingRemindersPost (string accessToken = null, TrackingReminder body = null);

        /// <summary>
        /// Store a Tracking Reminder
        /// </summary>
        /// <remarks>
        /// This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">TrackingReminder that should be stored (optional)</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> V1TrackingRemindersPostWithHttpInfo (string accessToken = null, TrackingReminder body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get specific pending tracking reminders
        /// </summary>
        /// <remarks>
        /// Specfic pending reminder instances that still need to be tracked.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> V1TrackingReminderNotificationsGetAsync (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get specific pending tracking reminders
        /// </summary>
        /// <remarks>
        /// Specfic pending reminder instances that still need to be tracked.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> V1TrackingReminderNotificationsGetAsyncWithHttpInfo (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Skip a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Deletes the pending tracking reminder
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1TrackingReminderNotificationsSkipPostAsync (TrackingReminderNotificationSkip body, string accessToken = null);

        /// <summary>
        /// Skip a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Deletes the pending tracking reminder
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1TrackingReminderNotificationsSkipPostAsyncWithHttpInfo (TrackingReminderNotificationSkip body, string accessToken = null);
        /// <summary>
        /// Snooze a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Changes the reminder time to now plus one hour
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1TrackingReminderNotificationsSnoozePostAsync (TrackingReminderNotificationSnooze body, string accessToken = null);

        /// <summary>
        /// Snooze a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Changes the reminder time to now plus one hour
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1TrackingReminderNotificationsSnoozePostAsyncWithHttpInfo (TrackingReminderNotificationSnooze body, string accessToken = null);
        /// <summary>
        /// Track a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1TrackingReminderNotificationsTrackPostAsync (TrackingReminderNotificationTrack body, string accessToken = null);

        /// <summary>
        /// Track a pending tracking reminder
        /// </summary>
        /// <remarks>
        /// Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1TrackingReminderNotificationsTrackPostAsyncWithHttpInfo (TrackingReminderNotificationTrack body, string accessToken = null);
        /// <summary>
        /// Delete tracking reminder
        /// </summary>
        /// <remarks>
        /// Delete previously created tracking reminder
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1TrackingRemindersDeletePostAsync (TrackingReminderDelete body, string accessToken = null);

        /// <summary>
        /// Delete tracking reminder
        /// </summary>
        /// <remarks>
        /// Delete previously created tracking reminder
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1TrackingRemindersDeletePostAsyncWithHttpInfo (TrackingReminderDelete body, string accessToken = null);
        /// <summary>
        /// Get repeating tracking reminder settings
        /// </summary>
        /// <remarks>
        /// Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> V1TrackingRemindersGetAsync (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get repeating tracking reminder settings
        /// </summary>
        /// <remarks>
        /// Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> V1TrackingRemindersGetAsyncWithHttpInfo (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Store a Tracking Reminder
        /// </summary>
        /// <remarks>
        /// This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">TrackingReminder that should be stored (optional)</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> V1TrackingRemindersPostAsync (string accessToken = null, TrackingReminder body = null);

        /// <summary>
        /// Store a Tracking Reminder
        /// </summary>
        /// <remarks>
        /// This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">TrackingReminder that should be stored (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> V1TrackingRemindersPostAsyncWithHttpInfo (string accessToken = null, TrackingReminder body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RemindersApi : IRemindersApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RemindersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RemindersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemindersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RemindersApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get specific pending tracking reminders Specfic pending reminder instances that still need to be tracked.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 V1TrackingReminderNotificationsGet (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse200> localVarResponse = V1TrackingReminderNotificationsGetWithHttpInfo(accessToken, variableCategoryName, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get specific pending tracking reminders Specfic pending reminder instances that still need to be tracked.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > V1TrackingReminderNotificationsGetWithHttpInfo (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v1/trackingReminderNotifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (variableCategoryName != null) localVarQueryParams.Add("variableCategoryName", Configuration.ApiClient.ParameterToString(variableCategoryName)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("createdAt", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updatedAt", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (quantimodo_oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingReminderNotificationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Get specific pending tracking reminders Specfic pending reminder instances that still need to be tracked.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> V1TrackingReminderNotificationsGetAsync (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse200> localVarResponse = await V1TrackingReminderNotificationsGetAsyncWithHttpInfo(accessToken, variableCategoryName, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get specific pending tracking reminders Specfic pending reminder instances that still need to be tracked.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> V1TrackingReminderNotificationsGetAsyncWithHttpInfo (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v1/trackingReminderNotifications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (variableCategoryName != null) localVarQueryParams.Add("variableCategoryName", Configuration.ApiClient.ParameterToString(variableCategoryName)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("createdAt", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updatedAt", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (quantimodo_oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingReminderNotificationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Skip a pending tracking reminder Deletes the pending tracking reminder
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        public CommonResponse V1TrackingReminderNotificationsSkipPost (TrackingReminderNotificationSkip body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = V1TrackingReminderNotificationsSkipPostWithHttpInfo(body, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Skip a pending tracking reminder Deletes the pending tracking reminder
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        public ApiResponse< CommonResponse > V1TrackingReminderNotificationsSkipPostWithHttpInfo (TrackingReminderNotificationSkip body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RemindersApi->V1TrackingReminderNotificationsSkipPost");

            var localVarPath = "/v1/trackingReminderNotifications/skip";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingReminderNotificationsSkipPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Skip a pending tracking reminder Deletes the pending tracking reminder
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1TrackingReminderNotificationsSkipPostAsync (TrackingReminderNotificationSkip body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = await V1TrackingReminderNotificationsSkipPostAsyncWithHttpInfo(body, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Skip a pending tracking reminder Deletes the pending tracking reminder
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1TrackingReminderNotificationsSkipPostAsyncWithHttpInfo (TrackingReminderNotificationSkip body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RemindersApi->V1TrackingReminderNotificationsSkipPost");

            var localVarPath = "/v1/trackingReminderNotifications/skip";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingReminderNotificationsSkipPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Snooze a pending tracking reminder Changes the reminder time to now plus one hour
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        public CommonResponse V1TrackingReminderNotificationsSnoozePost (TrackingReminderNotificationSnooze body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = V1TrackingReminderNotificationsSnoozePostWithHttpInfo(body, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Snooze a pending tracking reminder Changes the reminder time to now plus one hour
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        public ApiResponse< CommonResponse > V1TrackingReminderNotificationsSnoozePostWithHttpInfo (TrackingReminderNotificationSnooze body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RemindersApi->V1TrackingReminderNotificationsSnoozePost");

            var localVarPath = "/v1/trackingReminderNotifications/snooze";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingReminderNotificationsSnoozePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Snooze a pending tracking reminder Changes the reminder time to now plus one hour
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1TrackingReminderNotificationsSnoozePostAsync (TrackingReminderNotificationSnooze body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = await V1TrackingReminderNotificationsSnoozePostAsyncWithHttpInfo(body, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Snooze a pending tracking reminder Changes the reminder time to now plus one hour
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1TrackingReminderNotificationsSnoozePostAsyncWithHttpInfo (TrackingReminderNotificationSnooze body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RemindersApi->V1TrackingReminderNotificationsSnoozePost");

            var localVarPath = "/v1/trackingReminderNotifications/snooze";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingReminderNotificationsSnoozePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Track a pending tracking reminder Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        public CommonResponse V1TrackingReminderNotificationsTrackPost (TrackingReminderNotificationTrack body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = V1TrackingReminderNotificationsTrackPostWithHttpInfo(body, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Track a pending tracking reminder Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        public ApiResponse< CommonResponse > V1TrackingReminderNotificationsTrackPostWithHttpInfo (TrackingReminderNotificationTrack body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RemindersApi->V1TrackingReminderNotificationsTrackPost");

            var localVarPath = "/v1/trackingReminderNotifications/track";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingReminderNotificationsTrackPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Track a pending tracking reminder Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1TrackingReminderNotificationsTrackPostAsync (TrackingReminderNotificationTrack body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = await V1TrackingReminderNotificationsTrackPostAsyncWithHttpInfo(body, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Track a pending tracking reminder Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1TrackingReminderNotificationsTrackPostAsyncWithHttpInfo (TrackingReminderNotificationTrack body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RemindersApi->V1TrackingReminderNotificationsTrackPost");

            var localVarPath = "/v1/trackingReminderNotifications/track";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingReminderNotificationsTrackPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Delete tracking reminder Delete previously created tracking reminder
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        public CommonResponse V1TrackingRemindersDeletePost (TrackingReminderDelete body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = V1TrackingRemindersDeletePostWithHttpInfo(body, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete tracking reminder Delete previously created tracking reminder
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        public ApiResponse< CommonResponse > V1TrackingRemindersDeletePostWithHttpInfo (TrackingReminderDelete body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RemindersApi->V1TrackingRemindersDeletePost");

            var localVarPath = "/v1/trackingReminders/delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingRemindersDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Delete tracking reminder Delete previously created tracking reminder
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1TrackingRemindersDeletePostAsync (TrackingReminderDelete body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = await V1TrackingRemindersDeletePostAsyncWithHttpInfo(body, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete tracking reminder Delete previously created tracking reminder
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1TrackingRemindersDeletePostAsyncWithHttpInfo (TrackingReminderDelete body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RemindersApi->V1TrackingRemindersDeletePost");

            var localVarPath = "/v1/trackingReminders/delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingRemindersDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Get repeating tracking reminder settings Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 V1TrackingRemindersGet (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = V1TrackingRemindersGetWithHttpInfo(accessToken, variableCategoryName, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get repeating tracking reminder settings Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > V1TrackingRemindersGetWithHttpInfo (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v1/trackingReminders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (variableCategoryName != null) localVarQueryParams.Add("variableCategoryName", Configuration.ApiClient.ParameterToString(variableCategoryName)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("createdAt", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updatedAt", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (quantimodo_oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingRemindersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
            
        }

        /// <summary>
        /// Get repeating tracking reminder settings Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> V1TrackingRemindersGetAsync (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = await V1TrackingRemindersGetAsyncWithHttpInfo(accessToken, variableCategoryName, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get repeating tracking reminder settings Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> V1TrackingRemindersGetAsyncWithHttpInfo (string accessToken = null, string variableCategoryName = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v1/trackingReminders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (variableCategoryName != null) localVarQueryParams.Add("variableCategoryName", Configuration.ApiClient.ParameterToString(variableCategoryName)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("createdAt", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updatedAt", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (quantimodo_oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingRemindersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
            
        }

        /// <summary>
        /// Store a Tracking Reminder This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">TrackingReminder that should be stored (optional)</param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 V1TrackingRemindersPost (string accessToken = null, TrackingReminder body = null)
        {
             ApiResponse<InlineResponse2002> localVarResponse = V1TrackingRemindersPostWithHttpInfo(accessToken, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Store a Tracking Reminder This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">TrackingReminder that should be stored (optional)</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > V1TrackingRemindersPostWithHttpInfo (string accessToken = null, TrackingReminder body = null)
        {

            var localVarPath = "/v1/trackingReminders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (quantimodo_oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingRemindersPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002)));
            
        }

        /// <summary>
        /// Store a Tracking Reminder This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">TrackingReminder that should be stored (optional)</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> V1TrackingRemindersPostAsync (string accessToken = null, TrackingReminder body = null)
        {
             ApiResponse<InlineResponse2002> localVarResponse = await V1TrackingRemindersPostAsyncWithHttpInfo(accessToken, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Store a Tracking Reminder This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">TrackingReminder that should be stored (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> V1TrackingRemindersPostAsyncWithHttpInfo (string accessToken = null, TrackingReminder body = null)
        {

            var localVarPath = "/v1/trackingReminders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (quantimodo_oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TrackingRemindersPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002)));
            
        }

    }
}
