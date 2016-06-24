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
    public interface IApplicationEndpointsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected (optional)</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user. (optional)</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection. (optional)</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user. (optional)</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated. (optional)</param>
        /// <param name="updateError">Indicates if there was an error during the update. (optional)</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 V2ApplicationConnectionsGet (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected (optional)</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user. (optional)</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection. (optional)</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user. (optional)</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated. (optional)</param>
        /// <param name="updateError">Indicates if there was an error during the update. (optional)</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> V2ApplicationConnectionsGetWithHttpInfo (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained (optional)</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password (optional)</param>
        /// <param name="attrValue">Encrypted value for the attribute specified (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 V2ApplicationCredentialsGet (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained (optional)</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password (optional)</param>
        /// <param name="attrValue">Encrypted value for the attribute specified (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        ApiResponse<InlineResponse2004> V2ApplicationCredentialsGetWithHttpInfo (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get measurements for all users using your application
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained (optional)</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records (optional)</param>
        /// <param name="sourceId">Application or device used to record the measurement values (optional)</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable (optional)</param>
        /// <param name="unitId">The default unit id for the variable (optional)</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit) (optional)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted (optional)</param>
        /// <param name="duration">Duration of the event being measurement in seconds (optional)</param>
        /// <param name="note">An optional note the user may include with their measurement (optional)</param>
        /// <param name="latitude">Latitude at which the measurement was taken (optional)</param>
        /// <param name="longitude">Longitude at which the measurement was taken (optional)</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="error">An error message if there is a problem with the measurement (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 V2ApplicationMeasurementsGet (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get measurements for all users using your application
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained (optional)</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records (optional)</param>
        /// <param name="sourceId">Application or device used to record the measurement values (optional)</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable (optional)</param>
        /// <param name="unitId">The default unit id for the variable (optional)</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit) (optional)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted (optional)</param>
        /// <param name="duration">Duration of the event being measurement in seconds (optional)</param>
        /// <param name="note">An optional note the user may include with their measurement (optional)</param>
        /// <param name="latitude">Latitude at which the measurement was taken (optional)</param>
        /// <param name="longitude">Longitude at which the measurement was taken (optional)</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="error">An error message if there is a problem with the measurement (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> V2ApplicationMeasurementsGetWithHttpInfo (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get tracking reminders
        /// </summary>
        /// <remarks>
        /// Get the variable id, frequency, and default value for the user tracking reminders 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 V2ApplicationTrackingRemindersGet (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get tracking reminders
        /// </summary>
        /// <remarks>
        /// Get the variable id, frequency, and default value for the user tracking reminders 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> V2ApplicationTrackingRemindersGetWithHttpInfo (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all Updates
        /// </summary>
        /// <remarks>
        /// Get all Updates
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">connector_id (optional)</param>
        /// <param name="numberOfMeasurements">number_of_measurements (optional)</param>
        /// <param name="success">success (optional)</param>
        /// <param name="message">message (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 V2ApplicationUpdatesGet (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Updates
        /// </summary>
        /// <remarks>
        /// Get all Updates
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">connector_id (optional)</param>
        /// <param name="numberOfMeasurements">number_of_measurements (optional)</param>
        /// <param name="success">success (optional)</param>
        /// <param name="message">message (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> V2ApplicationUpdatesGetWithHttpInfo (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all UserVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all UserVariableRelationships
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional)</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable (optional)</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable (optional)</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable (optional)</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional)</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional)</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (optional)</param>
        /// <param name="vote">vote (optional)</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (optional)</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 V2ApplicationUserVariableRelationshipsGet (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all UserVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all UserVariableRelationships
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional)</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable (optional)</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable (optional)</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable (optional)</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional)</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional)</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (optional)</param>
        /// <param name="vote">vote (optional)</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (optional)</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        ApiResponse<InlineResponse2007> V2ApplicationUserVariableRelationshipsGetWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable (optional)</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="defaultUnitId">D of unit to use for this variable (optional)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="fillingValue">Value for replacing null measurements (optional)</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="variableCategoryId">ID of variable category (optional)</param>
        /// <param name="updated">updated (optional)</param>
        /// <param name="_public">Is variable public (optional)</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional)</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value (optional)</param>
        /// <param name="numberOfMeasurements">Number of measurements (optional)</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements (optional)</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis (optional)</param>
        /// <param name="lastUnitId">ID of last Unit (optional)</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit (optional)</param>
        /// <param name="lastOriginalValue">Last original value which is stored (optional)</param>
        /// <param name="lastValue">Last Value (optional)</param>
        /// <param name="lastSourceId">ID of last source (optional)</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated (optional)</param>
        /// <param name="standardDeviation">Standard deviation (optional)</param>
        /// <param name="variance">Variance (optional)</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable (optional)</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable (optional)</param>
        /// <param name="mean">Mean (optional)</param>
        /// <param name="median">Median (optional)</param>
        /// <param name="mostCommonUnitId">Most common Unit ID (optional)</param>
        /// <param name="mostCommonValue">Most common value (optional)</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values (optional)</param>
        /// <param name="numberOfChanges">Number of changes (optional)</param>
        /// <param name="skewness">Skewness (optional)</param>
        /// <param name="kurtosis">Kurtosis (optional)</param>
        /// <param name="latitude">Latitude (optional)</param>
        /// <param name="longitude">Longitude (optional)</param>
        /// <param name="location">Location (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional)</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources (optional)</param>
        /// <param name="earliestSourceTime">Earliest source time (optional)</param>
        /// <param name="latestSourceTime">Latest source time (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="earliestFillingTime">Earliest filling time (optional)</param>
        /// <param name="latestFillingTime">Latest filling time (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 V2ApplicationUserVariablesGet (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable (optional)</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="defaultUnitId">D of unit to use for this variable (optional)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="fillingValue">Value for replacing null measurements (optional)</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="variableCategoryId">ID of variable category (optional)</param>
        /// <param name="updated">updated (optional)</param>
        /// <param name="_public">Is variable public (optional)</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional)</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value (optional)</param>
        /// <param name="numberOfMeasurements">Number of measurements (optional)</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements (optional)</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis (optional)</param>
        /// <param name="lastUnitId">ID of last Unit (optional)</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit (optional)</param>
        /// <param name="lastOriginalValue">Last original value which is stored (optional)</param>
        /// <param name="lastValue">Last Value (optional)</param>
        /// <param name="lastSourceId">ID of last source (optional)</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated (optional)</param>
        /// <param name="standardDeviation">Standard deviation (optional)</param>
        /// <param name="variance">Variance (optional)</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable (optional)</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable (optional)</param>
        /// <param name="mean">Mean (optional)</param>
        /// <param name="median">Median (optional)</param>
        /// <param name="mostCommonUnitId">Most common Unit ID (optional)</param>
        /// <param name="mostCommonValue">Most common value (optional)</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values (optional)</param>
        /// <param name="numberOfChanges">Number of changes (optional)</param>
        /// <param name="skewness">Skewness (optional)</param>
        /// <param name="kurtosis">Kurtosis (optional)</param>
        /// <param name="latitude">Latitude (optional)</param>
        /// <param name="longitude">Longitude (optional)</param>
        /// <param name="location">Location (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional)</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources (optional)</param>
        /// <param name="earliestSourceTime">Earliest source time (optional)</param>
        /// <param name="latestSourceTime">Latest source time (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="earliestFillingTime">Earliest filling time (optional)</param>
        /// <param name="latestFillingTime">Latest filling time (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        ApiResponse<InlineResponse2008> V2ApplicationUserVariablesGetWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 V2ApplicationVariableUserSourcesGet (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2009</returns>
        ApiResponse<InlineResponse2009> V2ApplicationVariableUserSourcesGetWithHttpInfo (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all Votes
        /// </summary>
        /// <remarks>
        /// Get all Votes
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote (optional)</param>
        /// <param name="causeId">ID of predictor variable (optional)</param>
        /// <param name="effectId">ID of outcome variable (optional)</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 V2ApplicationVotesGet (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Votes
        /// </summary>
        /// <remarks>
        /// Get all Votes
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote (optional)</param>
        /// <param name="causeId">ID of predictor variable (optional)</param>
        /// <param name="effectId">ID of outcome variable (optional)</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        ApiResponse<InlineResponse20010> V2ApplicationVotesGetWithHttpInfo (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected (optional)</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user. (optional)</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection. (optional)</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user. (optional)</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated. (optional)</param>
        /// <param name="updateError">Indicates if there was an error during the update. (optional)</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> V2ApplicationConnectionsGetAsync (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected (optional)</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user. (optional)</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection. (optional)</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user. (optional)</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated. (optional)</param>
        /// <param name="updateError">Indicates if there was an error during the update. (optional)</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> V2ApplicationConnectionsGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained (optional)</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password (optional)</param>
        /// <param name="attrValue">Encrypted value for the attribute specified (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2004</returns>
        System.Threading.Tasks.Task<InlineResponse2004> V2ApplicationCredentialsGetAsync (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained (optional)</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password (optional)</param>
        /// <param name="attrValue">Encrypted value for the attribute specified (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> V2ApplicationCredentialsGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get measurements for all users using your application
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained (optional)</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records (optional)</param>
        /// <param name="sourceId">Application or device used to record the measurement values (optional)</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable (optional)</param>
        /// <param name="unitId">The default unit id for the variable (optional)</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit) (optional)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted (optional)</param>
        /// <param name="duration">Duration of the event being measurement in seconds (optional)</param>
        /// <param name="note">An optional note the user may include with their measurement (optional)</param>
        /// <param name="latitude">Latitude at which the measurement was taken (optional)</param>
        /// <param name="longitude">Longitude at which the measurement was taken (optional)</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="error">An error message if there is a problem with the measurement (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> V2ApplicationMeasurementsGetAsync (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get measurements for all users using your application
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained (optional)</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records (optional)</param>
        /// <param name="sourceId">Application or device used to record the measurement values (optional)</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable (optional)</param>
        /// <param name="unitId">The default unit id for the variable (optional)</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit) (optional)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted (optional)</param>
        /// <param name="duration">Duration of the event being measurement in seconds (optional)</param>
        /// <param name="note">An optional note the user may include with their measurement (optional)</param>
        /// <param name="latitude">Latitude at which the measurement was taken (optional)</param>
        /// <param name="longitude">Longitude at which the measurement was taken (optional)</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="error">An error message if there is a problem with the measurement (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> V2ApplicationMeasurementsGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get tracking reminders
        /// </summary>
        /// <remarks>
        /// Get the variable id, frequency, and default value for the user tracking reminders 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> V2ApplicationTrackingRemindersGetAsync (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get tracking reminders
        /// </summary>
        /// <remarks>
        /// Get the variable id, frequency, and default value for the user tracking reminders 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> V2ApplicationTrackingRemindersGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all Updates
        /// </summary>
        /// <remarks>
        /// Get all Updates
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">connector_id (optional)</param>
        /// <param name="numberOfMeasurements">number_of_measurements (optional)</param>
        /// <param name="success">success (optional)</param>
        /// <param name="message">message (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> V2ApplicationUpdatesGetAsync (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Updates
        /// </summary>
        /// <remarks>
        /// Get all Updates
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">connector_id (optional)</param>
        /// <param name="numberOfMeasurements">number_of_measurements (optional)</param>
        /// <param name="success">success (optional)</param>
        /// <param name="message">message (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> V2ApplicationUpdatesGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all UserVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all UserVariableRelationships
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional)</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable (optional)</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable (optional)</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable (optional)</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional)</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional)</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (optional)</param>
        /// <param name="vote">vote (optional)</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (optional)</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2007</returns>
        System.Threading.Tasks.Task<InlineResponse2007> V2ApplicationUserVariableRelationshipsGetAsync (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all UserVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all UserVariableRelationships
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional)</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable (optional)</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable (optional)</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable (optional)</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional)</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional)</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (optional)</param>
        /// <param name="vote">vote (optional)</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (optional)</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> V2ApplicationUserVariableRelationshipsGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable (optional)</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="defaultUnitId">D of unit to use for this variable (optional)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="fillingValue">Value for replacing null measurements (optional)</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="variableCategoryId">ID of variable category (optional)</param>
        /// <param name="updated">updated (optional)</param>
        /// <param name="_public">Is variable public (optional)</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional)</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value (optional)</param>
        /// <param name="numberOfMeasurements">Number of measurements (optional)</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements (optional)</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis (optional)</param>
        /// <param name="lastUnitId">ID of last Unit (optional)</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit (optional)</param>
        /// <param name="lastOriginalValue">Last original value which is stored (optional)</param>
        /// <param name="lastValue">Last Value (optional)</param>
        /// <param name="lastSourceId">ID of last source (optional)</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated (optional)</param>
        /// <param name="standardDeviation">Standard deviation (optional)</param>
        /// <param name="variance">Variance (optional)</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable (optional)</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable (optional)</param>
        /// <param name="mean">Mean (optional)</param>
        /// <param name="median">Median (optional)</param>
        /// <param name="mostCommonUnitId">Most common Unit ID (optional)</param>
        /// <param name="mostCommonValue">Most common value (optional)</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values (optional)</param>
        /// <param name="numberOfChanges">Number of changes (optional)</param>
        /// <param name="skewness">Skewness (optional)</param>
        /// <param name="kurtosis">Kurtosis (optional)</param>
        /// <param name="latitude">Latitude (optional)</param>
        /// <param name="longitude">Longitude (optional)</param>
        /// <param name="location">Location (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional)</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources (optional)</param>
        /// <param name="earliestSourceTime">Earliest source time (optional)</param>
        /// <param name="latestSourceTime">Latest source time (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="earliestFillingTime">Earliest filling time (optional)</param>
        /// <param name="latestFillingTime">Latest filling time (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2008</returns>
        System.Threading.Tasks.Task<InlineResponse2008> V2ApplicationUserVariablesGetAsync (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable (optional)</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="defaultUnitId">D of unit to use for this variable (optional)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="fillingValue">Value for replacing null measurements (optional)</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="variableCategoryId">ID of variable category (optional)</param>
        /// <param name="updated">updated (optional)</param>
        /// <param name="_public">Is variable public (optional)</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional)</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value (optional)</param>
        /// <param name="numberOfMeasurements">Number of measurements (optional)</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements (optional)</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis (optional)</param>
        /// <param name="lastUnitId">ID of last Unit (optional)</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit (optional)</param>
        /// <param name="lastOriginalValue">Last original value which is stored (optional)</param>
        /// <param name="lastValue">Last Value (optional)</param>
        /// <param name="lastSourceId">ID of last source (optional)</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated (optional)</param>
        /// <param name="standardDeviation">Standard deviation (optional)</param>
        /// <param name="variance">Variance (optional)</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable (optional)</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable (optional)</param>
        /// <param name="mean">Mean (optional)</param>
        /// <param name="median">Median (optional)</param>
        /// <param name="mostCommonUnitId">Most common Unit ID (optional)</param>
        /// <param name="mostCommonValue">Most common value (optional)</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values (optional)</param>
        /// <param name="numberOfChanges">Number of changes (optional)</param>
        /// <param name="skewness">Skewness (optional)</param>
        /// <param name="kurtosis">Kurtosis (optional)</param>
        /// <param name="latitude">Latitude (optional)</param>
        /// <param name="longitude">Longitude (optional)</param>
        /// <param name="location">Location (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional)</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources (optional)</param>
        /// <param name="earliestSourceTime">Earliest source time (optional)</param>
        /// <param name="latestSourceTime">Latest source time (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="earliestFillingTime">Earliest filling time (optional)</param>
        /// <param name="latestFillingTime">Latest filling time (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> V2ApplicationUserVariablesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2009</returns>
        System.Threading.Tasks.Task<InlineResponse2009> V2ApplicationVariableUserSourcesGetAsync (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2009)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2009>> V2ApplicationVariableUserSourcesGetAsyncWithHttpInfo (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        /// <summary>
        /// Get all Votes
        /// </summary>
        /// <remarks>
        /// Get all Votes
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote (optional)</param>
        /// <param name="causeId">ID of predictor variable (optional)</param>
        /// <param name="effectId">ID of outcome variable (optional)</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse20010</returns>
        System.Threading.Tasks.Task<InlineResponse20010> V2ApplicationVotesGetAsync (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Votes
        /// </summary>
        /// <remarks>
        /// Get all Votes
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote (optional)</param>
        /// <param name="causeId">ID of predictor variable (optional)</param>
        /// <param name="effectId">ID of outcome variable (optional)</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> V2ApplicationVotesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplicationEndpointsApi : IApplicationEndpointsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationEndpointsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationEndpointsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ApplicationEndpointsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApplicationEndpointsApi(Configuration configuration = null)
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
        /// Get all Connections Get all Connections
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected (optional)</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user. (optional)</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection. (optional)</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user. (optional)</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated. (optional)</param>
        /// <param name="updateError">Indicates if there was an error during the update. (optional)</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 V2ApplicationConnectionsGet (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2003> localVarResponse = V2ApplicationConnectionsGetWithHttpInfo(accessToken, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected (optional)</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user. (optional)</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection. (optional)</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user. (optional)</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated. (optional)</param>
        /// <param name="updateError">Indicates if there was an error during the update. (optional)</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > V2ApplicationConnectionsGetWithHttpInfo (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/connections";
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
            if (connectorId != null) localVarQueryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (connectStatus != null) localVarQueryParams.Add("connect_status", Configuration.ApiClient.ParameterToString(connectStatus)); // query parameter
            if (connectError != null) localVarQueryParams.Add("connect_error", Configuration.ApiClient.ParameterToString(connectError)); // query parameter
            if (updateRequestedAt != null) localVarQueryParams.Add("update_requested_at", Configuration.ApiClient.ParameterToString(updateRequestedAt)); // query parameter
            if (updateStatus != null) localVarQueryParams.Add("update_status", Configuration.ApiClient.ParameterToString(updateStatus)); // query parameter
            if (updateError != null) localVarQueryParams.Add("update_error", Configuration.ApiClient.ParameterToString(updateError)); // query parameter
            if (lastSuccessfulUpdatedAt != null) localVarQueryParams.Add("last_successful_updated_at", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationConnectionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
            
        }

        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected (optional)</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user. (optional)</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection. (optional)</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user. (optional)</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated. (optional)</param>
        /// <param name="updateError">Indicates if there was an error during the update. (optional)</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> V2ApplicationConnectionsGetAsync (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2003> localVarResponse = await V2ApplicationConnectionsGetAsyncWithHttpInfo(accessToken, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected (optional)</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user. (optional)</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection. (optional)</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user. (optional)</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated. (optional)</param>
        /// <param name="updateError">Indicates if there was an error during the update. (optional)</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> V2ApplicationConnectionsGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/connections";
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
            if (connectorId != null) localVarQueryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (connectStatus != null) localVarQueryParams.Add("connect_status", Configuration.ApiClient.ParameterToString(connectStatus)); // query parameter
            if (connectError != null) localVarQueryParams.Add("connect_error", Configuration.ApiClient.ParameterToString(connectError)); // query parameter
            if (updateRequestedAt != null) localVarQueryParams.Add("update_requested_at", Configuration.ApiClient.ParameterToString(updateRequestedAt)); // query parameter
            if (updateStatus != null) localVarQueryParams.Add("update_status", Configuration.ApiClient.ParameterToString(updateStatus)); // query parameter
            if (updateError != null) localVarQueryParams.Add("update_error", Configuration.ApiClient.ParameterToString(updateError)); // query parameter
            if (lastSuccessfulUpdatedAt != null) localVarQueryParams.Add("last_successful_updated_at", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationConnectionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
            
        }

        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained (optional)</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password (optional)</param>
        /// <param name="attrValue">Encrypted value for the attribute specified (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 V2ApplicationCredentialsGet (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2004> localVarResponse = V2ApplicationCredentialsGetWithHttpInfo(accessToken, connectorId, attrKey, attrValue, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained (optional)</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password (optional)</param>
        /// <param name="attrValue">Encrypted value for the attribute specified (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        public ApiResponse< InlineResponse2004 > V2ApplicationCredentialsGetWithHttpInfo (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/credentials";
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
            if (connectorId != null) localVarQueryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (attrKey != null) localVarQueryParams.Add("attr_key", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            if (attrValue != null) localVarQueryParams.Add("attr_value", Configuration.ApiClient.ParameterToString(attrValue)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationCredentialsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2004>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2004) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2004)));
            
        }

        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained (optional)</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password (optional)</param>
        /// <param name="attrValue">Encrypted value for the attribute specified (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2004</returns>
        public async System.Threading.Tasks.Task<InlineResponse2004> V2ApplicationCredentialsGetAsync (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2004> localVarResponse = await V2ApplicationCredentialsGetAsyncWithHttpInfo(accessToken, connectorId, attrKey, attrValue, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained (optional)</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password (optional)</param>
        /// <param name="attrValue">Encrypted value for the attribute specified (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> V2ApplicationCredentialsGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/credentials";
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
            if (connectorId != null) localVarQueryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (attrKey != null) localVarQueryParams.Add("attr_key", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            if (attrValue != null) localVarQueryParams.Add("attr_value", Configuration.ApiClient.ParameterToString(attrValue)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationCredentialsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2004>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2004) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2004)));
            
        }

        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained (optional)</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records (optional)</param>
        /// <param name="sourceId">Application or device used to record the measurement values (optional)</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable (optional)</param>
        /// <param name="unitId">The default unit id for the variable (optional)</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit) (optional)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted (optional)</param>
        /// <param name="duration">Duration of the event being measurement in seconds (optional)</param>
        /// <param name="note">An optional note the user may include with their measurement (optional)</param>
        /// <param name="latitude">Latitude at which the measurement was taken (optional)</param>
        /// <param name="longitude">Longitude at which the measurement was taken (optional)</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="error">An error message if there is a problem with the measurement (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 V2ApplicationMeasurementsGet (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2005> localVarResponse = V2ApplicationMeasurementsGetWithHttpInfo(accessToken, clientId, connectorId, variableId, sourceId, startTime, value, unitId, originalValue, originalUnitId, duration, note, latitude, longitude, location, createdAt, updatedAt, error, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained (optional)</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records (optional)</param>
        /// <param name="sourceId">Application or device used to record the measurement values (optional)</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable (optional)</param>
        /// <param name="unitId">The default unit id for the variable (optional)</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit) (optional)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted (optional)</param>
        /// <param name="duration">Duration of the event being measurement in seconds (optional)</param>
        /// <param name="note">An optional note the user may include with their measurement (optional)</param>
        /// <param name="latitude">Latitude at which the measurement was taken (optional)</param>
        /// <param name="longitude">Longitude at which the measurement was taken (optional)</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="error">An error message if there is a problem with the measurement (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > V2ApplicationMeasurementsGetWithHttpInfo (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/measurements";
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
            if (clientId != null) localVarQueryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (connectorId != null) localVarQueryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (variableId != null) localVarQueryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (sourceId != null) localVarQueryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("start_time", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (unitId != null) localVarQueryParams.Add("unit_id", Configuration.ApiClient.ParameterToString(unitId)); // query parameter
            if (originalValue != null) localVarQueryParams.Add("original_value", Configuration.ApiClient.ParameterToString(originalValue)); // query parameter
            if (originalUnitId != null) localVarQueryParams.Add("original_unit_id", Configuration.ApiClient.ParameterToString(originalUnitId)); // query parameter
            if (duration != null) localVarQueryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (note != null) localVarQueryParams.Add("note", Configuration.ApiClient.ParameterToString(note)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) localVarQueryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (error != null) localVarQueryParams.Add("error", Configuration.ApiClient.ParameterToString(error)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationMeasurementsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
            
        }

        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained (optional)</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records (optional)</param>
        /// <param name="sourceId">Application or device used to record the measurement values (optional)</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable (optional)</param>
        /// <param name="unitId">The default unit id for the variable (optional)</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit) (optional)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted (optional)</param>
        /// <param name="duration">Duration of the event being measurement in seconds (optional)</param>
        /// <param name="note">An optional note the user may include with their measurement (optional)</param>
        /// <param name="latitude">Latitude at which the measurement was taken (optional)</param>
        /// <param name="longitude">Longitude at which the measurement was taken (optional)</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="error">An error message if there is a problem with the measurement (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> V2ApplicationMeasurementsGetAsync (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2005> localVarResponse = await V2ApplicationMeasurementsGetAsyncWithHttpInfo(accessToken, clientId, connectorId, variableId, sourceId, startTime, value, unitId, originalValue, originalUnitId, duration, note, latitude, longitude, location, createdAt, updatedAt, error, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement (optional)</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained (optional)</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records (optional)</param>
        /// <param name="sourceId">Application or device used to record the measurement values (optional)</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable (optional)</param>
        /// <param name="unitId">The default unit id for the variable (optional)</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit) (optional)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted (optional)</param>
        /// <param name="duration">Duration of the event being measurement in seconds (optional)</param>
        /// <param name="note">An optional note the user may include with their measurement (optional)</param>
        /// <param name="latitude">Latitude at which the measurement was taken (optional)</param>
        /// <param name="longitude">Longitude at which the measurement was taken (optional)</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="error">An error message if there is a problem with the measurement (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> V2ApplicationMeasurementsGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, decimal? value = null, int? unitId = null, decimal? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/measurements";
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
            if (clientId != null) localVarQueryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (connectorId != null) localVarQueryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (variableId != null) localVarQueryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (sourceId != null) localVarQueryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("start_time", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (unitId != null) localVarQueryParams.Add("unit_id", Configuration.ApiClient.ParameterToString(unitId)); // query parameter
            if (originalValue != null) localVarQueryParams.Add("original_value", Configuration.ApiClient.ParameterToString(originalValue)); // query parameter
            if (originalUnitId != null) localVarQueryParams.Add("original_unit_id", Configuration.ApiClient.ParameterToString(originalUnitId)); // query parameter
            if (duration != null) localVarQueryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (note != null) localVarQueryParams.Add("note", Configuration.ApiClient.ParameterToString(note)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) localVarQueryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (error != null) localVarQueryParams.Add("error", Configuration.ApiClient.ParameterToString(error)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationMeasurementsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
            
        }

        /// <summary>
        /// Get tracking reminders Get the variable id, frequency, and default value for the user tracking reminders 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 V2ApplicationTrackingRemindersGet (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = V2ApplicationTrackingRemindersGetWithHttpInfo(accessToken, clientId, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get tracking reminders Get the variable id, frequency, and default value for the user tracking reminders 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > V2ApplicationTrackingRemindersGetWithHttpInfo (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/trackingReminders";
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
            if (clientId != null) localVarQueryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationTrackingRemindersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
            
        }

        /// <summary>
        /// Get tracking reminders Get the variable id, frequency, and default value for the user tracking reminders 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> V2ApplicationTrackingRemindersGetAsync (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = await V2ApplicationTrackingRemindersGetAsyncWithHttpInfo(accessToken, clientId, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get tracking reminders Get the variable id, frequency, and default value for the user tracking reminders 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> V2ApplicationTrackingRemindersGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/trackingReminders";
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
            if (clientId != null) localVarQueryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationTrackingRemindersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
            
        }

        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">connector_id (optional)</param>
        /// <param name="numberOfMeasurements">number_of_measurements (optional)</param>
        /// <param name="success">success (optional)</param>
        /// <param name="message">message (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 V2ApplicationUpdatesGet (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2006> localVarResponse = V2ApplicationUpdatesGetWithHttpInfo(accessToken, connectorId, numberOfMeasurements, success, message, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">connector_id (optional)</param>
        /// <param name="numberOfMeasurements">number_of_measurements (optional)</param>
        /// <param name="success">success (optional)</param>
        /// <param name="message">message (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > V2ApplicationUpdatesGetWithHttpInfo (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/updates";
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
            if (connectorId != null) localVarQueryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (numberOfMeasurements != null) localVarQueryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (success != null) localVarQueryParams.Add("success", Configuration.ApiClient.ParameterToString(success)); // query parameter
            if (message != null) localVarQueryParams.Add("message", Configuration.ApiClient.ParameterToString(message)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationUpdatesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
            
        }

        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">connector_id (optional)</param>
        /// <param name="numberOfMeasurements">number_of_measurements (optional)</param>
        /// <param name="success">success (optional)</param>
        /// <param name="message">message (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> V2ApplicationUpdatesGetAsync (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2006> localVarResponse = await V2ApplicationUpdatesGetAsyncWithHttpInfo(accessToken, connectorId, numberOfMeasurements, success, message, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Application&#39;s OAuth2 access token (optional)</param>
        /// <param name="connectorId">connector_id (optional)</param>
        /// <param name="numberOfMeasurements">number_of_measurements (optional)</param>
        /// <param name="success">success (optional)</param>
        /// <param name="message">message (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> V2ApplicationUpdatesGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/updates";
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
            if (connectorId != null) localVarQueryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (numberOfMeasurements != null) localVarQueryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (success != null) localVarQueryParams.Add("success", Configuration.ApiClient.ParameterToString(success)); // query parameter
            if (message != null) localVarQueryParams.Add("message", Configuration.ApiClient.ParameterToString(message)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationUpdatesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
            
        }

        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional)</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable (optional)</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable (optional)</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable (optional)</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional)</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional)</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (optional)</param>
        /// <param name="vote">vote (optional)</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (optional)</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2007</returns>
        public InlineResponse2007 V2ApplicationUserVariableRelationshipsGet (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2007> localVarResponse = V2ApplicationUserVariableRelationshipsGetWithHttpInfo(accessToken, id, confidenceLevel, confidenceScore, direction, durationOfAction, errorMessage, onsetDelay, outcomeVariableId, predictorVariableId, predictorUnitId, sinnRank, strengthLevel, strengthScore, vote, valuePredictingHighOutcome, valuePredictingLowOutcome, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional)</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable (optional)</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable (optional)</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable (optional)</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional)</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional)</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (optional)</param>
        /// <param name="vote">vote (optional)</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (optional)</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        public ApiResponse< InlineResponse2007 > V2ApplicationUserVariableRelationshipsGetWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/userVariableRelationships";
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (confidenceLevel != null) localVarQueryParams.Add("confidence_level", Configuration.ApiClient.ParameterToString(confidenceLevel)); // query parameter
            if (confidenceScore != null) localVarQueryParams.Add("confidence_score", Configuration.ApiClient.ParameterToString(confidenceScore)); // query parameter
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (durationOfAction != null) localVarQueryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (errorMessage != null) localVarQueryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (onsetDelay != null) localVarQueryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (outcomeVariableId != null) localVarQueryParams.Add("outcome_variable_id", Configuration.ApiClient.ParameterToString(outcomeVariableId)); // query parameter
            if (predictorVariableId != null) localVarQueryParams.Add("predictor_variable_id", Configuration.ApiClient.ParameterToString(predictorVariableId)); // query parameter
            if (predictorUnitId != null) localVarQueryParams.Add("predictor_unit_id", Configuration.ApiClient.ParameterToString(predictorUnitId)); // query parameter
            if (sinnRank != null) localVarQueryParams.Add("sinn_rank", Configuration.ApiClient.ParameterToString(sinnRank)); // query parameter
            if (strengthLevel != null) localVarQueryParams.Add("strength_level", Configuration.ApiClient.ParameterToString(strengthLevel)); // query parameter
            if (strengthScore != null) localVarQueryParams.Add("strength_score", Configuration.ApiClient.ParameterToString(strengthScore)); // query parameter
            if (vote != null) localVarQueryParams.Add("vote", Configuration.ApiClient.ParameterToString(vote)); // query parameter
            if (valuePredictingHighOutcome != null) localVarQueryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) localVarQueryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationUserVariableRelationshipsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2007>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2007) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2007)));
            
        }

        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional)</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable (optional)</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable (optional)</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable (optional)</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional)</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional)</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (optional)</param>
        /// <param name="vote">vote (optional)</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (optional)</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2007</returns>
        public async System.Threading.Tasks.Task<InlineResponse2007> V2ApplicationUserVariableRelationshipsGetAsync (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2007> localVarResponse = await V2ApplicationUserVariableRelationshipsGetAsyncWithHttpInfo(accessToken, id, confidenceLevel, confidenceScore, direction, durationOfAction, errorMessage, onsetDelay, outcomeVariableId, predictorVariableId, predictorUnitId, sinnRank, strengthLevel, strengthScore, vote, valuePredictingHighOutcome, valuePredictingLowOutcome, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">id (optional)</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (optional)</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (optional)</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable (optional)</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable (optional)</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable (optional)</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (optional)</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (optional)</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (optional)</param>
        /// <param name="vote">vote (optional)</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (optional)</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> V2ApplicationUserVariableRelationshipsGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, decimal? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, decimal? sinnRank = null, string strengthLevel = null, decimal? strengthScore = null, string vote = null, decimal? valuePredictingHighOutcome = null, decimal? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/userVariableRelationships";
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (confidenceLevel != null) localVarQueryParams.Add("confidence_level", Configuration.ApiClient.ParameterToString(confidenceLevel)); // query parameter
            if (confidenceScore != null) localVarQueryParams.Add("confidence_score", Configuration.ApiClient.ParameterToString(confidenceScore)); // query parameter
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (durationOfAction != null) localVarQueryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (errorMessage != null) localVarQueryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (onsetDelay != null) localVarQueryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (outcomeVariableId != null) localVarQueryParams.Add("outcome_variable_id", Configuration.ApiClient.ParameterToString(outcomeVariableId)); // query parameter
            if (predictorVariableId != null) localVarQueryParams.Add("predictor_variable_id", Configuration.ApiClient.ParameterToString(predictorVariableId)); // query parameter
            if (predictorUnitId != null) localVarQueryParams.Add("predictor_unit_id", Configuration.ApiClient.ParameterToString(predictorUnitId)); // query parameter
            if (sinnRank != null) localVarQueryParams.Add("sinn_rank", Configuration.ApiClient.ParameterToString(sinnRank)); // query parameter
            if (strengthLevel != null) localVarQueryParams.Add("strength_level", Configuration.ApiClient.ParameterToString(strengthLevel)); // query parameter
            if (strengthScore != null) localVarQueryParams.Add("strength_score", Configuration.ApiClient.ParameterToString(strengthScore)); // query parameter
            if (vote != null) localVarQueryParams.Add("vote", Configuration.ApiClient.ParameterToString(vote)); // query parameter
            if (valuePredictingHighOutcome != null) localVarQueryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) localVarQueryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationUserVariableRelationshipsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2007>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2007) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2007)));
            
        }

        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable (optional)</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="defaultUnitId">D of unit to use for this variable (optional)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="fillingValue">Value for replacing null measurements (optional)</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="variableCategoryId">ID of variable category (optional)</param>
        /// <param name="updated">updated (optional)</param>
        /// <param name="_public">Is variable public (optional)</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional)</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value (optional)</param>
        /// <param name="numberOfMeasurements">Number of measurements (optional)</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements (optional)</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis (optional)</param>
        /// <param name="lastUnitId">ID of last Unit (optional)</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit (optional)</param>
        /// <param name="lastOriginalValue">Last original value which is stored (optional)</param>
        /// <param name="lastValue">Last Value (optional)</param>
        /// <param name="lastSourceId">ID of last source (optional)</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated (optional)</param>
        /// <param name="standardDeviation">Standard deviation (optional)</param>
        /// <param name="variance">Variance (optional)</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable (optional)</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable (optional)</param>
        /// <param name="mean">Mean (optional)</param>
        /// <param name="median">Median (optional)</param>
        /// <param name="mostCommonUnitId">Most common Unit ID (optional)</param>
        /// <param name="mostCommonValue">Most common value (optional)</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values (optional)</param>
        /// <param name="numberOfChanges">Number of changes (optional)</param>
        /// <param name="skewness">Skewness (optional)</param>
        /// <param name="kurtosis">Kurtosis (optional)</param>
        /// <param name="latitude">Latitude (optional)</param>
        /// <param name="longitude">Longitude (optional)</param>
        /// <param name="location">Location (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional)</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources (optional)</param>
        /// <param name="earliestSourceTime">Earliest source time (optional)</param>
        /// <param name="latestSourceTime">Latest source time (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="earliestFillingTime">Earliest filling time (optional)</param>
        /// <param name="latestFillingTime">Latest filling time (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 V2ApplicationUserVariablesGet (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2008> localVarResponse = V2ApplicationUserVariablesGetWithHttpInfo(accessToken, clientId, parentId, variableId, defaultUnitId, minimumAllowedValue, maximumAllowedValue, fillingValue, joinWith, onsetDelay, durationOfAction, variableCategoryId, updated, _public, causeOnly, fillingType, numberOfMeasurements, numberOfProcessedMeasurements, measurementsAtLastAnalysis, lastUnitId, lastOriginalUnitId, lastOriginalValue, lastValue, lastSourceId, numberOfCorrelations, status, errorMessage, lastSuccessfulUpdateTime, standardDeviation, variance, minimumRecordedValue, maximumRecordedValue, mean, median, mostCommonUnitId, mostCommonValue, numberOfUniqueDailyValues, numberOfChanges, skewness, kurtosis, latitude, longitude, location, createdAt, updatedAt, outcome, sources, earliestSourceTime, latestSourceTime, earliestMeasurementTime, latestMeasurementTime, earliestFillingTime, latestFillingTime, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable (optional)</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="defaultUnitId">D of unit to use for this variable (optional)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="fillingValue">Value for replacing null measurements (optional)</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="variableCategoryId">ID of variable category (optional)</param>
        /// <param name="updated">updated (optional)</param>
        /// <param name="_public">Is variable public (optional)</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional)</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value (optional)</param>
        /// <param name="numberOfMeasurements">Number of measurements (optional)</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements (optional)</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis (optional)</param>
        /// <param name="lastUnitId">ID of last Unit (optional)</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit (optional)</param>
        /// <param name="lastOriginalValue">Last original value which is stored (optional)</param>
        /// <param name="lastValue">Last Value (optional)</param>
        /// <param name="lastSourceId">ID of last source (optional)</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated (optional)</param>
        /// <param name="standardDeviation">Standard deviation (optional)</param>
        /// <param name="variance">Variance (optional)</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable (optional)</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable (optional)</param>
        /// <param name="mean">Mean (optional)</param>
        /// <param name="median">Median (optional)</param>
        /// <param name="mostCommonUnitId">Most common Unit ID (optional)</param>
        /// <param name="mostCommonValue">Most common value (optional)</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values (optional)</param>
        /// <param name="numberOfChanges">Number of changes (optional)</param>
        /// <param name="skewness">Skewness (optional)</param>
        /// <param name="kurtosis">Kurtosis (optional)</param>
        /// <param name="latitude">Latitude (optional)</param>
        /// <param name="longitude">Longitude (optional)</param>
        /// <param name="location">Location (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional)</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources (optional)</param>
        /// <param name="earliestSourceTime">Earliest source time (optional)</param>
        /// <param name="latestSourceTime">Latest source time (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="earliestFillingTime">Earliest filling time (optional)</param>
        /// <param name="latestFillingTime">Latest filling time (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        public ApiResponse< InlineResponse2008 > V2ApplicationUserVariablesGetWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/userVariables";
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
            if (clientId != null) localVarQueryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (parentId != null) localVarQueryParams.Add("parent_id", Configuration.ApiClient.ParameterToString(parentId)); // query parameter
            if (variableId != null) localVarQueryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (defaultUnitId != null) localVarQueryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (minimumAllowedValue != null) localVarQueryParams.Add("minimum_allowed_value", Configuration.ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (maximumAllowedValue != null) localVarQueryParams.Add("maximum_allowed_value", Configuration.ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (fillingValue != null) localVarQueryParams.Add("filling_value", Configuration.ApiClient.ParameterToString(fillingValue)); // query parameter
            if (joinWith != null) localVarQueryParams.Add("join_with", Configuration.ApiClient.ParameterToString(joinWith)); // query parameter
            if (onsetDelay != null) localVarQueryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) localVarQueryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (variableCategoryId != null) localVarQueryParams.Add("variable_category_id", Configuration.ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (updated != null) localVarQueryParams.Add("updated", Configuration.ApiClient.ParameterToString(updated)); // query parameter
            if (_public != null) localVarQueryParams.Add("public", Configuration.ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) localVarQueryParams.Add("cause_only", Configuration.ApiClient.ParameterToString(causeOnly)); // query parameter
            if (fillingType != null) localVarQueryParams.Add("filling_type", Configuration.ApiClient.ParameterToString(fillingType)); // query parameter
            if (numberOfMeasurements != null) localVarQueryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfProcessedMeasurements != null) localVarQueryParams.Add("number_of_processed_measurements", Configuration.ApiClient.ParameterToString(numberOfProcessedMeasurements)); // query parameter
            if (measurementsAtLastAnalysis != null) localVarQueryParams.Add("measurements_at_last_analysis", Configuration.ApiClient.ParameterToString(measurementsAtLastAnalysis)); // query parameter
            if (lastUnitId != null) localVarQueryParams.Add("last_unit_id", Configuration.ApiClient.ParameterToString(lastUnitId)); // query parameter
            if (lastOriginalUnitId != null) localVarQueryParams.Add("last_original_unit_id", Configuration.ApiClient.ParameterToString(lastOriginalUnitId)); // query parameter
            if (lastOriginalValue != null) localVarQueryParams.Add("last_original_value", Configuration.ApiClient.ParameterToString(lastOriginalValue)); // query parameter
            if (lastValue != null) localVarQueryParams.Add("last_value", Configuration.ApiClient.ParameterToString(lastValue)); // query parameter
            if (lastSourceId != null) localVarQueryParams.Add("last_source_id", Configuration.ApiClient.ParameterToString(lastSourceId)); // query parameter
            if (numberOfCorrelations != null) localVarQueryParams.Add("number_of_correlations", Configuration.ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) localVarQueryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) localVarQueryParams.Add("last_successful_update_time", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (standardDeviation != null) localVarQueryParams.Add("standard_deviation", Configuration.ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) localVarQueryParams.Add("variance", Configuration.ApiClient.ParameterToString(variance)); // query parameter
            if (minimumRecordedValue != null) localVarQueryParams.Add("minimum_recorded_value", Configuration.ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
            if (maximumRecordedValue != null) localVarQueryParams.Add("maximum_recorded_value", Configuration.ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
            if (mean != null) localVarQueryParams.Add("mean", Configuration.ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) localVarQueryParams.Add("median", Configuration.ApiClient.ParameterToString(median)); // query parameter
            if (mostCommonUnitId != null) localVarQueryParams.Add("most_common_unit_id", Configuration.ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (mostCommonValue != null) localVarQueryParams.Add("most_common_value", Configuration.ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (numberOfUniqueDailyValues != null) localVarQueryParams.Add("number_of_unique_daily_values", Configuration.ApiClient.ParameterToString(numberOfUniqueDailyValues)); // query parameter
            if (numberOfChanges != null) localVarQueryParams.Add("number_of_changes", Configuration.ApiClient.ParameterToString(numberOfChanges)); // query parameter
            if (skewness != null) localVarQueryParams.Add("skewness", Configuration.ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) localVarQueryParams.Add("kurtosis", Configuration.ApiClient.ParameterToString(kurtosis)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) localVarQueryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (outcome != null) localVarQueryParams.Add("outcome", Configuration.ApiClient.ParameterToString(outcome)); // query parameter
            if (sources != null) localVarQueryParams.Add("sources", Configuration.ApiClient.ParameterToString(sources)); // query parameter
            if (earliestSourceTime != null) localVarQueryParams.Add("earliest_source_time", Configuration.ApiClient.ParameterToString(earliestSourceTime)); // query parameter
            if (latestSourceTime != null) localVarQueryParams.Add("latest_source_time", Configuration.ApiClient.ParameterToString(latestSourceTime)); // query parameter
            if (earliestMeasurementTime != null) localVarQueryParams.Add("earliest_measurement_time", Configuration.ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) localVarQueryParams.Add("latest_measurement_time", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (earliestFillingTime != null) localVarQueryParams.Add("earliest_filling_time", Configuration.ApiClient.ParameterToString(earliestFillingTime)); // query parameter
            if (latestFillingTime != null) localVarQueryParams.Add("latest_filling_time", Configuration.ApiClient.ParameterToString(latestFillingTime)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationUserVariablesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2008>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2008) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2008)));
            
        }

        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable (optional)</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="defaultUnitId">D of unit to use for this variable (optional)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="fillingValue">Value for replacing null measurements (optional)</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="variableCategoryId">ID of variable category (optional)</param>
        /// <param name="updated">updated (optional)</param>
        /// <param name="_public">Is variable public (optional)</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional)</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value (optional)</param>
        /// <param name="numberOfMeasurements">Number of measurements (optional)</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements (optional)</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis (optional)</param>
        /// <param name="lastUnitId">ID of last Unit (optional)</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit (optional)</param>
        /// <param name="lastOriginalValue">Last original value which is stored (optional)</param>
        /// <param name="lastValue">Last Value (optional)</param>
        /// <param name="lastSourceId">ID of last source (optional)</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated (optional)</param>
        /// <param name="standardDeviation">Standard deviation (optional)</param>
        /// <param name="variance">Variance (optional)</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable (optional)</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable (optional)</param>
        /// <param name="mean">Mean (optional)</param>
        /// <param name="median">Median (optional)</param>
        /// <param name="mostCommonUnitId">Most common Unit ID (optional)</param>
        /// <param name="mostCommonValue">Most common value (optional)</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values (optional)</param>
        /// <param name="numberOfChanges">Number of changes (optional)</param>
        /// <param name="skewness">Skewness (optional)</param>
        /// <param name="kurtosis">Kurtosis (optional)</param>
        /// <param name="latitude">Latitude (optional)</param>
        /// <param name="longitude">Longitude (optional)</param>
        /// <param name="location">Location (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional)</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources (optional)</param>
        /// <param name="earliestSourceTime">Earliest source time (optional)</param>
        /// <param name="latestSourceTime">Latest source time (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="earliestFillingTime">Earliest filling time (optional)</param>
        /// <param name="latestFillingTime">Latest filling time (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2008</returns>
        public async System.Threading.Tasks.Task<InlineResponse2008> V2ApplicationUserVariablesGetAsync (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2008> localVarResponse = await V2ApplicationUserVariablesGetAsyncWithHttpInfo(accessToken, clientId, parentId, variableId, defaultUnitId, minimumAllowedValue, maximumAllowedValue, fillingValue, joinWith, onsetDelay, durationOfAction, variableCategoryId, updated, _public, causeOnly, fillingType, numberOfMeasurements, numberOfProcessedMeasurements, measurementsAtLastAnalysis, lastUnitId, lastOriginalUnitId, lastOriginalValue, lastValue, lastSourceId, numberOfCorrelations, status, errorMessage, lastSuccessfulUpdateTime, standardDeviation, variance, minimumRecordedValue, maximumRecordedValue, mean, median, mostCommonUnitId, mostCommonValue, numberOfUniqueDailyValues, numberOfChanges, skewness, kurtosis, latitude, longitude, location, createdAt, updatedAt, outcome, sources, earliestSourceTime, latestSourceTime, earliestMeasurementTime, latestMeasurementTime, earliestFillingTime, latestFillingTime, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable (optional)</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="defaultUnitId">D of unit to use for this variable (optional)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit) (optional)</param>
        /// <param name="fillingValue">Value for replacing null measurements (optional)</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables (optional)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect (optional)</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect (optional)</param>
        /// <param name="variableCategoryId">ID of variable category (optional)</param>
        /// <param name="updated">updated (optional)</param>
        /// <param name="_public">Is variable public (optional)</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user (optional)</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value (optional)</param>
        /// <param name="numberOfMeasurements">Number of measurements (optional)</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements (optional)</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis (optional)</param>
        /// <param name="lastUnitId">ID of last Unit (optional)</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit (optional)</param>
        /// <param name="lastOriginalValue">Last original value which is stored (optional)</param>
        /// <param name="lastValue">Last Value (optional)</param>
        /// <param name="lastSourceId">ID of last source (optional)</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable (optional)</param>
        /// <param name="status">status (optional)</param>
        /// <param name="errorMessage">error_message (optional)</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated (optional)</param>
        /// <param name="standardDeviation">Standard deviation (optional)</param>
        /// <param name="variance">Variance (optional)</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable (optional)</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable (optional)</param>
        /// <param name="mean">Mean (optional)</param>
        /// <param name="median">Median (optional)</param>
        /// <param name="mostCommonUnitId">Most common Unit ID (optional)</param>
        /// <param name="mostCommonValue">Most common value (optional)</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values (optional)</param>
        /// <param name="numberOfChanges">Number of changes (optional)</param>
        /// <param name="skewness">Skewness (optional)</param>
        /// <param name="kurtosis">Kurtosis (optional)</param>
        /// <param name="latitude">Latitude (optional)</param>
        /// <param name="longitude">Longitude (optional)</param>
        /// <param name="location">Location (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables (optional)</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources (optional)</param>
        /// <param name="earliestSourceTime">Earliest source time (optional)</param>
        /// <param name="latestSourceTime">Latest source time (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="earliestFillingTime">Earliest filling time (optional)</param>
        /// <param name="latestFillingTime">Latest filling time (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> V2ApplicationUserVariablesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, decimal? minimumAllowedValue = null, decimal? maximumAllowedValue = null, decimal? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, decimal? lastValue = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, decimal? standardDeviation = null, decimal? variance = null, decimal? minimumRecordedValue = null, decimal? maximumRecordedValue = null, decimal? mean = null, decimal? median = null, int? mostCommonUnitId = null, decimal? mostCommonValue = null, decimal? numberOfUniqueDailyValues = null, int? numberOfChanges = null, decimal? skewness = null, decimal? kurtosis = null, decimal? latitude = null, decimal? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/userVariables";
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
            if (clientId != null) localVarQueryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (parentId != null) localVarQueryParams.Add("parent_id", Configuration.ApiClient.ParameterToString(parentId)); // query parameter
            if (variableId != null) localVarQueryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (defaultUnitId != null) localVarQueryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (minimumAllowedValue != null) localVarQueryParams.Add("minimum_allowed_value", Configuration.ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (maximumAllowedValue != null) localVarQueryParams.Add("maximum_allowed_value", Configuration.ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (fillingValue != null) localVarQueryParams.Add("filling_value", Configuration.ApiClient.ParameterToString(fillingValue)); // query parameter
            if (joinWith != null) localVarQueryParams.Add("join_with", Configuration.ApiClient.ParameterToString(joinWith)); // query parameter
            if (onsetDelay != null) localVarQueryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) localVarQueryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (variableCategoryId != null) localVarQueryParams.Add("variable_category_id", Configuration.ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (updated != null) localVarQueryParams.Add("updated", Configuration.ApiClient.ParameterToString(updated)); // query parameter
            if (_public != null) localVarQueryParams.Add("public", Configuration.ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) localVarQueryParams.Add("cause_only", Configuration.ApiClient.ParameterToString(causeOnly)); // query parameter
            if (fillingType != null) localVarQueryParams.Add("filling_type", Configuration.ApiClient.ParameterToString(fillingType)); // query parameter
            if (numberOfMeasurements != null) localVarQueryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfProcessedMeasurements != null) localVarQueryParams.Add("number_of_processed_measurements", Configuration.ApiClient.ParameterToString(numberOfProcessedMeasurements)); // query parameter
            if (measurementsAtLastAnalysis != null) localVarQueryParams.Add("measurements_at_last_analysis", Configuration.ApiClient.ParameterToString(measurementsAtLastAnalysis)); // query parameter
            if (lastUnitId != null) localVarQueryParams.Add("last_unit_id", Configuration.ApiClient.ParameterToString(lastUnitId)); // query parameter
            if (lastOriginalUnitId != null) localVarQueryParams.Add("last_original_unit_id", Configuration.ApiClient.ParameterToString(lastOriginalUnitId)); // query parameter
            if (lastOriginalValue != null) localVarQueryParams.Add("last_original_value", Configuration.ApiClient.ParameterToString(lastOriginalValue)); // query parameter
            if (lastValue != null) localVarQueryParams.Add("last_value", Configuration.ApiClient.ParameterToString(lastValue)); // query parameter
            if (lastSourceId != null) localVarQueryParams.Add("last_source_id", Configuration.ApiClient.ParameterToString(lastSourceId)); // query parameter
            if (numberOfCorrelations != null) localVarQueryParams.Add("number_of_correlations", Configuration.ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) localVarQueryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) localVarQueryParams.Add("last_successful_update_time", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (standardDeviation != null) localVarQueryParams.Add("standard_deviation", Configuration.ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) localVarQueryParams.Add("variance", Configuration.ApiClient.ParameterToString(variance)); // query parameter
            if (minimumRecordedValue != null) localVarQueryParams.Add("minimum_recorded_value", Configuration.ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
            if (maximumRecordedValue != null) localVarQueryParams.Add("maximum_recorded_value", Configuration.ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
            if (mean != null) localVarQueryParams.Add("mean", Configuration.ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) localVarQueryParams.Add("median", Configuration.ApiClient.ParameterToString(median)); // query parameter
            if (mostCommonUnitId != null) localVarQueryParams.Add("most_common_unit_id", Configuration.ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (mostCommonValue != null) localVarQueryParams.Add("most_common_value", Configuration.ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (numberOfUniqueDailyValues != null) localVarQueryParams.Add("number_of_unique_daily_values", Configuration.ApiClient.ParameterToString(numberOfUniqueDailyValues)); // query parameter
            if (numberOfChanges != null) localVarQueryParams.Add("number_of_changes", Configuration.ApiClient.ParameterToString(numberOfChanges)); // query parameter
            if (skewness != null) localVarQueryParams.Add("skewness", Configuration.ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) localVarQueryParams.Add("kurtosis", Configuration.ApiClient.ParameterToString(kurtosis)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) localVarQueryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (outcome != null) localVarQueryParams.Add("outcome", Configuration.ApiClient.ParameterToString(outcome)); // query parameter
            if (sources != null) localVarQueryParams.Add("sources", Configuration.ApiClient.ParameterToString(sources)); // query parameter
            if (earliestSourceTime != null) localVarQueryParams.Add("earliest_source_time", Configuration.ApiClient.ParameterToString(earliestSourceTime)); // query parameter
            if (latestSourceTime != null) localVarQueryParams.Add("latest_source_time", Configuration.ApiClient.ParameterToString(latestSourceTime)); // query parameter
            if (earliestMeasurementTime != null) localVarQueryParams.Add("earliest_measurement_time", Configuration.ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) localVarQueryParams.Add("latest_measurement_time", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (earliestFillingTime != null) localVarQueryParams.Add("earliest_filling_time", Configuration.ApiClient.ParameterToString(earliestFillingTime)); // query parameter
            if (latestFillingTime != null) localVarQueryParams.Add("latest_filling_time", Configuration.ApiClient.ParameterToString(latestFillingTime)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationUserVariablesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2008>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2008) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2008)));
            
        }

        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse2009</returns>
        public InlineResponse2009 V2ApplicationVariableUserSourcesGet (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2009> localVarResponse = V2ApplicationVariableUserSourcesGetWithHttpInfo(accessToken, variableId, timestamp, earliestMeasurementTime, latestMeasurementTime, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2009</returns>
        public ApiResponse< InlineResponse2009 > V2ApplicationVariableUserSourcesGetWithHttpInfo (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/variableUserSources";
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
            if (variableId != null) localVarQueryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (timestamp != null) localVarQueryParams.Add("timestamp", Configuration.ApiClient.ParameterToString(timestamp)); // query parameter
            if (earliestMeasurementTime != null) localVarQueryParams.Add("earliest_measurement_time", Configuration.ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) localVarQueryParams.Add("latest_measurement_time", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationVariableUserSourcesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2009>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2009) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2009)));
            
        }

        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse2009</returns>
        public async System.Threading.Tasks.Task<InlineResponse2009> V2ApplicationVariableUserSourcesGetAsync (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2009> localVarResponse = await V2ApplicationVariableUserSourcesGetAsyncWithHttpInfo(accessToken, variableId, timestamp, earliestMeasurementTime, latestMeasurementTime, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableId">ID of variable (optional)</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (optional)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time (optional)</param>
        /// <param name="latestMeasurementTime">Latest measurement time (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2009)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2009>> V2ApplicationVariableUserSourcesGetAsyncWithHttpInfo (string accessToken = null, int? variableId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/variableUserSources";
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
            if (variableId != null) localVarQueryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (timestamp != null) localVarQueryParams.Add("timestamp", Configuration.ApiClient.ParameterToString(timestamp)); // query parameter
            if (earliestMeasurementTime != null) localVarQueryParams.Add("earliest_measurement_time", Configuration.ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) localVarQueryParams.Add("latest_measurement_time", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationVariableUserSourcesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2009>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2009) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2009)));
            
        }

        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote (optional)</param>
        /// <param name="causeId">ID of predictor variable (optional)</param>
        /// <param name="effectId">ID of outcome variable (optional)</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>InlineResponse20010</returns>
        public InlineResponse20010 V2ApplicationVotesGet (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20010> localVarResponse = V2ApplicationVotesGetWithHttpInfo(accessToken, clientId, causeId, effectId, value, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote (optional)</param>
        /// <param name="causeId">ID of predictor variable (optional)</param>
        /// <param name="effectId">ID of outcome variable (optional)</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        public ApiResponse< InlineResponse20010 > V2ApplicationVotesGetWithHttpInfo (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/votes";
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
            if (clientId != null) localVarQueryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (causeId != null) localVarQueryParams.Add("cause_id", Configuration.ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) localVarQueryParams.Add("effect_id", Configuration.ApiClient.ParameterToString(effectId)); // query parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationVotesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20010>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20010) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20010)));
            
        }

        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote (optional)</param>
        /// <param name="causeId">ID of predictor variable (optional)</param>
        /// <param name="effectId">ID of outcome variable (optional)</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of InlineResponse20010</returns>
        public async System.Threading.Tasks.Task<InlineResponse20010> V2ApplicationVotesGetAsync (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20010> localVarResponse = await V2ApplicationVotesGetAsyncWithHttpInfo(accessToken, clientId, causeId, effectId, value, createdAt, updatedAt, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote (optional)</param>
        /// <param name="causeId">ID of predictor variable (optional)</param>
        /// <param name="effectId">ID of outcome variable (optional)</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote. (optional)</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format  (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional)</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> V2ApplicationVotesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {

            var localVarPath = "/v2/application/votes";
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
            if (clientId != null) localVarQueryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (causeId != null) localVarQueryParams.Add("cause_id", Configuration.ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) localVarQueryParams.Add("effect_id", Configuration.ApiClient.ParameterToString(effectId)); // query parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (internalApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2ApplicationVotesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20010>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20010) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20010)));
            
        }

    }
}
