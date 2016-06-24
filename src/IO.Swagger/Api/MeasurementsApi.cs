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
    public interface IMeasurementsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get measurement sources
        /// </summary>
        /// <remarks>
        /// Returns a list of all the apps from which measurement data is obtained.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MeasurementSource</returns>
        MeasurementSource V1MeasurementSourcesGet ();

        /// <summary>
        /// Get measurement sources
        /// </summary>
        /// <remarks>
        /// Returns a list of all the apps from which measurement data is obtained.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MeasurementSource</returns>
        ApiResponse<MeasurementSource> V1MeasurementSourcesGetWithHttpInfo ();
        /// <summary>
        /// Add a data source
        /// </summary>
        /// <remarks>
        /// Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        void V1MeasurementSourcesPost (MeasurementSource body, string accessToken = null);

        /// <summary>
        /// Add a data source
        /// </summary>
        /// <remarks>
        /// Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1MeasurementSourcesPostWithHttpInfo (MeasurementSource body, string accessToken = null);
        /// <summary>
        /// Get daily measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Measurement</returns>
        Measurement V1MeasurementsDailyGet (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get daily measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of Measurement</returns>
        ApiResponse<Measurement> V1MeasurementsDailyGetWithHttpInfo (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Delete a measurement
        /// </summary>
        /// <remarks>
        /// Delete a previously submitted measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1MeasurementsDeletePost (MeasurementDelete body);

        /// <summary>
        /// Delete a measurement
        /// </summary>
        /// <remarks>
        /// Delete a previously submitted measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        ApiResponse<CommonResponse> V1MeasurementsDeletePostWithHttpInfo (MeasurementDelete body);
        /// <summary>
        /// Get measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableName">Name of the variable you want measurements for (optional)</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for (optional)</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only) (optional)</param>
        /// <param name="value">Value of measurement (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="unit">The unit you want the measurements returned in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch) (optional)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Measurement</returns>
        Measurement V1MeasurementsGet (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableName">Name of the variable you want measurements for (optional)</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for (optional)</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only) (optional)</param>
        /// <param name="value">Value of measurement (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="unit">The unit you want the measurements returned in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch) (optional)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of Measurement</returns>
        ApiResponse<Measurement> V1MeasurementsGetWithHttpInfo (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Post a new set or update existing measurements to the database
        /// </summary>
        /// <remarks>
        /// You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        void V1MeasurementsPost (MeasurementSet body, string accessToken = null);

        /// <summary>
        /// Post a new set or update existing measurements to the database
        /// </summary>
        /// <remarks>
        /// You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1MeasurementsPostWithHttpInfo (MeasurementSet body, string accessToken = null);
        /// <summary>
        /// Get measurements range for this user
        /// </summary>
        /// <remarks>
        /// Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sources">Enter source name to limit to specific source (varchar) (optional)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint) (optional)</param>
        /// <returns>MeasurementRange</returns>
        MeasurementRange V1MeasurementsRangeGet (string sources = null, int? user = null);

        /// <summary>
        /// Get measurements range for this user
        /// </summary>
        /// <remarks>
        /// Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sources">Enter source name to limit to specific source (varchar) (optional)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint) (optional)</param>
        /// <returns>ApiResponse of MeasurementRange</returns>
        ApiResponse<MeasurementRange> V1MeasurementsRangeGetWithHttpInfo (string sources = null, int? user = null);
        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Download a CSV containing all user measurements
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream V2MeasurementsCsvGet (string accessToken = null);

        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Download a CSV containing all user measurements
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> V2MeasurementsCsvGetWithHttpInfo (string accessToken = null);
        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 V2MeasurementsIdDelete (int? id, string accessToken = null);

        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        ApiResponse<InlineResponse20012> V2MeasurementsIdDeleteWithHttpInfo (int? id, string accessToken = null);
        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 V2MeasurementsIdGet (int? id, string accessToken = null);

        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of InlineResponse20011</returns>
        ApiResponse<InlineResponse20011> V2MeasurementsIdGetWithHttpInfo (int? id, string accessToken = null);
        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">Measurement that should be updated (optional)</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 V2MeasurementsIdPut (int? id, string accessToken = null, Measurement body = null);

        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">Measurement that should be updated (optional)</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        ApiResponse<InlineResponse20012> V2MeasurementsIdPutWithHttpInfo (int? id, string accessToken = null, Measurement body = null);
        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>int?</returns>
        int? V2MeasurementsRequestCsvPost (string accessToken = null);

        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> V2MeasurementsRequestCsvPostWithHttpInfo (string accessToken = null);
        /// <summary>
        /// Post Request for Measurements PDF
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>int?</returns>
        int? V2MeasurementsRequestPdfPost (string accessToken = null);

        /// <summary>
        /// Post Request for Measurements PDF
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> V2MeasurementsRequestPdfPostWithHttpInfo (string accessToken = null);
        /// <summary>
        /// Post Request for Measurements XLS
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>int?</returns>
        int? V2MeasurementsRequestXlsPost (string accessToken = null);

        /// <summary>
        /// Post Request for Measurements XLS
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> V2MeasurementsRequestXlsPostWithHttpInfo (string accessToken = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get measurement sources
        /// </summary>
        /// <remarks>
        /// Returns a list of all the apps from which measurement data is obtained.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MeasurementSource</returns>
        System.Threading.Tasks.Task<MeasurementSource> V1MeasurementSourcesGetAsync ();

        /// <summary>
        /// Get measurement sources
        /// </summary>
        /// <remarks>
        /// Returns a list of all the apps from which measurement data is obtained.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MeasurementSource)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeasurementSource>> V1MeasurementSourcesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Add a data source
        /// </summary>
        /// <remarks>
        /// Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1MeasurementSourcesPostAsync (MeasurementSource body, string accessToken = null);

        /// <summary>
        /// Add a data source
        /// </summary>
        /// <remarks>
        /// Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1MeasurementSourcesPostAsyncWithHttpInfo (MeasurementSource body, string accessToken = null);
        /// <summary>
        /// Get daily measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of Measurement</returns>
        System.Threading.Tasks.Task<Measurement> V1MeasurementsDailyGetAsync (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get daily measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (Measurement)</returns>
        System.Threading.Tasks.Task<ApiResponse<Measurement>> V1MeasurementsDailyGetAsyncWithHttpInfo (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Delete a measurement
        /// </summary>
        /// <remarks>
        /// Delete a previously submitted measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>Task of CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1MeasurementsDeletePostAsync (MeasurementDelete body);

        /// <summary>
        /// Delete a measurement
        /// </summary>
        /// <remarks>
        /// Delete a previously submitted measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1MeasurementsDeletePostAsyncWithHttpInfo (MeasurementDelete body);
        /// <summary>
        /// Get measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableName">Name of the variable you want measurements for (optional)</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for (optional)</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only) (optional)</param>
        /// <param name="value">Value of measurement (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="unit">The unit you want the measurements returned in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch) (optional)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of Measurement</returns>
        System.Threading.Tasks.Task<Measurement> V1MeasurementsGetAsync (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableName">Name of the variable you want measurements for (optional)</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for (optional)</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only) (optional)</param>
        /// <param name="value">Value of measurement (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="unit">The unit you want the measurements returned in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch) (optional)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (Measurement)</returns>
        System.Threading.Tasks.Task<ApiResponse<Measurement>> V1MeasurementsGetAsyncWithHttpInfo (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Post a new set or update existing measurements to the database
        /// </summary>
        /// <remarks>
        /// You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1MeasurementsPostAsync (MeasurementSet body, string accessToken = null);

        /// <summary>
        /// Post a new set or update existing measurements to the database
        /// </summary>
        /// <remarks>
        /// You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1MeasurementsPostAsyncWithHttpInfo (MeasurementSet body, string accessToken = null);
        /// <summary>
        /// Get measurements range for this user
        /// </summary>
        /// <remarks>
        /// Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sources">Enter source name to limit to specific source (varchar) (optional)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint) (optional)</param>
        /// <returns>Task of MeasurementRange</returns>
        System.Threading.Tasks.Task<MeasurementRange> V1MeasurementsRangeGetAsync (string sources = null, int? user = null);

        /// <summary>
        /// Get measurements range for this user
        /// </summary>
        /// <remarks>
        /// Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sources">Enter source name to limit to specific source (varchar) (optional)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint) (optional)</param>
        /// <returns>Task of ApiResponse (MeasurementRange)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeasurementRange>> V1MeasurementsRangeGetAsyncWithHttpInfo (string sources = null, int? user = null);
        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Download a CSV containing all user measurements
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> V2MeasurementsCsvGetAsync (string accessToken = null);

        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Download a CSV containing all user measurements
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> V2MeasurementsCsvGetAsyncWithHttpInfo (string accessToken = null);
        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of InlineResponse20012</returns>
        System.Threading.Tasks.Task<InlineResponse20012> V2MeasurementsIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> V2MeasurementsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of InlineResponse20011</returns>
        System.Threading.Tasks.Task<InlineResponse20011> V2MeasurementsIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20011>> V2MeasurementsIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">Measurement that should be updated (optional)</param>
        /// <returns>Task of InlineResponse20012</returns>
        System.Threading.Tasks.Task<InlineResponse20012> V2MeasurementsIdPutAsync (int? id, string accessToken = null, Measurement body = null);

        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">Measurement that should be updated (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> V2MeasurementsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Measurement body = null);
        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> V2MeasurementsRequestCsvPostAsync (string accessToken = null);

        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> V2MeasurementsRequestCsvPostAsyncWithHttpInfo (string accessToken = null);
        /// <summary>
        /// Post Request for Measurements PDF
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> V2MeasurementsRequestPdfPostAsync (string accessToken = null);

        /// <summary>
        /// Post Request for Measurements PDF
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> V2MeasurementsRequestPdfPostAsyncWithHttpInfo (string accessToken = null);
        /// <summary>
        /// Post Request for Measurements XLS
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> V2MeasurementsRequestXlsPostAsync (string accessToken = null);

        /// <summary>
        /// Post Request for Measurements XLS
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> V2MeasurementsRequestXlsPostAsyncWithHttpInfo (string accessToken = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MeasurementsApi : IMeasurementsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeasurementsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="MeasurementsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MeasurementsApi(Configuration configuration = null)
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
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MeasurementSource</returns>
        public MeasurementSource V1MeasurementSourcesGet ()
        {
             ApiResponse<MeasurementSource> localVarResponse = V1MeasurementSourcesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MeasurementSource</returns>
        public ApiResponse< MeasurementSource > V1MeasurementSourcesGetWithHttpInfo ()
        {

            var localVarPath = "/v1/measurementSources";
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

            // authentication (oauth2) required
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
                Exception exception = ExceptionFactory("V1MeasurementSourcesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeasurementSource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeasurementSource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeasurementSource)));
            
        }

        /// <summary>
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MeasurementSource</returns>
        public async System.Threading.Tasks.Task<MeasurementSource> V1MeasurementSourcesGetAsync ()
        {
             ApiResponse<MeasurementSource> localVarResponse = await V1MeasurementSourcesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MeasurementSource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeasurementSource>> V1MeasurementSourcesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/measurementSources";
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

            // authentication (oauth2) required
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
                Exception exception = ExceptionFactory("V1MeasurementSourcesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeasurementSource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeasurementSource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeasurementSource)));
            
        }

        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        public void V1MeasurementSourcesPost (MeasurementSource body, string accessToken = null)
        {
             V1MeasurementSourcesPostWithHttpInfo(body, accessToken);
        }

        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1MeasurementSourcesPostWithHttpInfo (MeasurementSource body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MeasurementsApi->V1MeasurementSourcesPost");

            var localVarPath = "/v1/measurementSources";
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
                Exception exception = ExceptionFactory("V1MeasurementSourcesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1MeasurementSourcesPostAsync (MeasurementSource body, string accessToken = null)
        {
             await V1MeasurementSourcesPostAsyncWithHttpInfo(body, accessToken);

        }

        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1MeasurementSourcesPostAsyncWithHttpInfo (MeasurementSource body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MeasurementsApi->V1MeasurementSourcesPost");

            var localVarPath = "/v1/measurementSources";
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
                Exception exception = ExceptionFactory("V1MeasurementSourcesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Measurement</returns>
        public Measurement V1MeasurementsDailyGet (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<Measurement> localVarResponse = V1MeasurementsDailyGetWithHttpInfo(variableName, accessToken, abbreviatedUnitName, startTime, endTime, groupingWidth, groupingTimezone, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of Measurement</returns>
        public ApiResponse< Measurement > V1MeasurementsDailyGetWithHttpInfo (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling MeasurementsApi->V1MeasurementsDailyGet");

            var localVarPath = "/v1/measurements/daily";
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
            if (variableName != null) localVarQueryParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // query parameter
            if (abbreviatedUnitName != null) localVarQueryParams.Add("abbreviatedUnitName", Configuration.ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (groupingWidth != null) localVarQueryParams.Add("groupingWidth", Configuration.ApiClient.ParameterToString(groupingWidth)); // query parameter
            if (groupingTimezone != null) localVarQueryParams.Add("groupingTimezone", Configuration.ApiClient.ParameterToString(groupingTimezone)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
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
                Exception exception = ExceptionFactory("V1MeasurementsDailyGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Measurement>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Measurement) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Measurement)));
            
        }

        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of Measurement</returns>
        public async System.Threading.Tasks.Task<Measurement> V1MeasurementsDailyGetAsync (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<Measurement> localVarResponse = await V1MeasurementsDailyGetAsyncWithHttpInfo(variableName, accessToken, abbreviatedUnitName, startTime, endTime, groupingWidth, groupingTimezone, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (Measurement)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Measurement>> V1MeasurementsDailyGetAsyncWithHttpInfo (string variableName, string accessToken = null, string abbreviatedUnitName = null, string startTime = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling MeasurementsApi->V1MeasurementsDailyGet");

            var localVarPath = "/v1/measurements/daily";
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
            if (variableName != null) localVarQueryParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // query parameter
            if (abbreviatedUnitName != null) localVarQueryParams.Add("abbreviatedUnitName", Configuration.ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (groupingWidth != null) localVarQueryParams.Add("groupingWidth", Configuration.ApiClient.ParameterToString(groupingWidth)); // query parameter
            if (groupingTimezone != null) localVarQueryParams.Add("groupingTimezone", Configuration.ApiClient.ParameterToString(groupingTimezone)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
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
                Exception exception = ExceptionFactory("V1MeasurementsDailyGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Measurement>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Measurement) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Measurement)));
            
        }

        /// <summary>
        /// Delete a measurement Delete a previously submitted measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>CommonResponse</returns>
        public CommonResponse V1MeasurementsDeletePost (MeasurementDelete body)
        {
             ApiResponse<CommonResponse> localVarResponse = V1MeasurementsDeletePostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a measurement Delete a previously submitted measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        public ApiResponse< CommonResponse > V1MeasurementsDeletePostWithHttpInfo (MeasurementDelete body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MeasurementsApi->V1MeasurementsDeletePost");

            var localVarPath = "/v1/measurements/delete";
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
                Exception exception = ExceptionFactory("V1MeasurementsDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Delete a measurement Delete a previously submitted measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>Task of CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1MeasurementsDeletePostAsync (MeasurementDelete body)
        {
             ApiResponse<CommonResponse> localVarResponse = await V1MeasurementsDeletePostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a measurement Delete a previously submitted measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1MeasurementsDeletePostAsyncWithHttpInfo (MeasurementDelete body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MeasurementsApi->V1MeasurementsDeletePost");

            var localVarPath = "/v1/measurements/delete";
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
                Exception exception = ExceptionFactory("V1MeasurementsDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableName">Name of the variable you want measurements for (optional)</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for (optional)</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only) (optional)</param>
        /// <param name="value">Value of measurement (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="unit">The unit you want the measurements returned in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch) (optional)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Measurement</returns>
        public Measurement V1MeasurementsGet (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<Measurement> localVarResponse = V1MeasurementsGetWithHttpInfo(accessToken, variableName, variableCategoryName, source, value, lastUpdated, unit, startTime, createdAt, updatedAt, endTime, groupingWidth, groupingTimezone, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableName">Name of the variable you want measurements for (optional)</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for (optional)</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only) (optional)</param>
        /// <param name="value">Value of measurement (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="unit">The unit you want the measurements returned in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch) (optional)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of Measurement</returns>
        public ApiResponse< Measurement > V1MeasurementsGetWithHttpInfo (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)
        {

            var localVarPath = "/v1/measurements";
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
            if (variableName != null) localVarQueryParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // query parameter
            if (variableCategoryName != null) localVarQueryParams.Add("variableCategoryName", Configuration.ApiClient.ParameterToString(variableCategoryName)); // query parameter
            if (source != null) localVarQueryParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // query parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (lastUpdated != null) localVarQueryParams.Add("lastUpdated", Configuration.ApiClient.ParameterToString(lastUpdated)); // query parameter
            if (unit != null) localVarQueryParams.Add("unit", Configuration.ApiClient.ParameterToString(unit)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("createdAt", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updatedAt", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (groupingWidth != null) localVarQueryParams.Add("groupingWidth", Configuration.ApiClient.ParameterToString(groupingWidth)); // query parameter
            if (groupingTimezone != null) localVarQueryParams.Add("groupingTimezone", Configuration.ApiClient.ParameterToString(groupingTimezone)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
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
                Exception exception = ExceptionFactory("V1MeasurementsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Measurement>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Measurement) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Measurement)));
            
        }

        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableName">Name of the variable you want measurements for (optional)</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for (optional)</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only) (optional)</param>
        /// <param name="value">Value of measurement (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="unit">The unit you want the measurements returned in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch) (optional)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of Measurement</returns>
        public async System.Threading.Tasks.Task<Measurement> V1MeasurementsGetAsync (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<Measurement> localVarResponse = await V1MeasurementsGetAsyncWithHttpInfo(accessToken, variableName, variableCategoryName, source, value, lastUpdated, unit, startTime, createdAt, updatedAt, endTime, groupingWidth, groupingTimezone, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="variableName">Name of the variable you want measurements for (optional)</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for (optional)</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only) (optional)</param>
        /// <param name="value">Value of measurement (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="unit">The unit you want the measurements returned in (optional)</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch) (optional)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local. (optional)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch) (optional)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (Measurement)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Measurement>> V1MeasurementsGetAsyncWithHttpInfo (string accessToken = null, string variableName = null, string variableCategoryName = null, string source = null, string value = null, string lastUpdated = null, string unit = null, string startTime = null, string createdAt = null, string updatedAt = null, string endTime = null, int? groupingWidth = null, string groupingTimezone = null, int? limit = null, int? offset = null, int? sort = null)
        {

            var localVarPath = "/v1/measurements";
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
            if (variableName != null) localVarQueryParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // query parameter
            if (variableCategoryName != null) localVarQueryParams.Add("variableCategoryName", Configuration.ApiClient.ParameterToString(variableCategoryName)); // query parameter
            if (source != null) localVarQueryParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // query parameter
            if (value != null) localVarQueryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (lastUpdated != null) localVarQueryParams.Add("lastUpdated", Configuration.ApiClient.ParameterToString(lastUpdated)); // query parameter
            if (unit != null) localVarQueryParams.Add("unit", Configuration.ApiClient.ParameterToString(unit)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("createdAt", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updatedAt", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (groupingWidth != null) localVarQueryParams.Add("groupingWidth", Configuration.ApiClient.ParameterToString(groupingWidth)); // query parameter
            if (groupingTimezone != null) localVarQueryParams.Add("groupingTimezone", Configuration.ApiClient.ParameterToString(groupingTimezone)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
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
                Exception exception = ExceptionFactory("V1MeasurementsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Measurement>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Measurement) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Measurement)));
            
        }

        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        public void V1MeasurementsPost (MeasurementSet body, string accessToken = null)
        {
             V1MeasurementsPostWithHttpInfo(body, accessToken);
        }

        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1MeasurementsPostWithHttpInfo (MeasurementSet body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MeasurementsApi->V1MeasurementsPost");

            var localVarPath = "/v1/measurements";
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
                Exception exception = ExceptionFactory("V1MeasurementsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1MeasurementsPostAsync (MeasurementSet body, string accessToken = null)
        {
             await V1MeasurementsPostAsyncWithHttpInfo(body, accessToken);

        }

        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1MeasurementsPostAsyncWithHttpInfo (MeasurementSet body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MeasurementsApi->V1MeasurementsPost");

            var localVarPath = "/v1/measurements";
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
                Exception exception = ExceptionFactory("V1MeasurementsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sources">Enter source name to limit to specific source (varchar) (optional)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint) (optional)</param>
        /// <returns>MeasurementRange</returns>
        public MeasurementRange V1MeasurementsRangeGet (string sources = null, int? user = null)
        {
             ApiResponse<MeasurementRange> localVarResponse = V1MeasurementsRangeGetWithHttpInfo(sources, user);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sources">Enter source name to limit to specific source (varchar) (optional)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint) (optional)</param>
        /// <returns>ApiResponse of MeasurementRange</returns>
        public ApiResponse< MeasurementRange > V1MeasurementsRangeGetWithHttpInfo (string sources = null, int? user = null)
        {

            var localVarPath = "/v1/measurementsRange";
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
            if (sources != null) localVarQueryParams.Add("sources", Configuration.ApiClient.ParameterToString(sources)); // query parameter
            if (user != null) localVarQueryParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // query parameter

            // authentication (oauth2) required
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
                Exception exception = ExceptionFactory("V1MeasurementsRangeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeasurementRange>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeasurementRange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeasurementRange)));
            
        }

        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sources">Enter source name to limit to specific source (varchar) (optional)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint) (optional)</param>
        /// <returns>Task of MeasurementRange</returns>
        public async System.Threading.Tasks.Task<MeasurementRange> V1MeasurementsRangeGetAsync (string sources = null, int? user = null)
        {
             ApiResponse<MeasurementRange> localVarResponse = await V1MeasurementsRangeGetAsyncWithHttpInfo(sources, user);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sources">Enter source name to limit to specific source (varchar) (optional)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint) (optional)</param>
        /// <returns>Task of ApiResponse (MeasurementRange)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeasurementRange>> V1MeasurementsRangeGetAsyncWithHttpInfo (string sources = null, int? user = null)
        {

            var localVarPath = "/v1/measurementsRange";
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
            if (sources != null) localVarQueryParams.Add("sources", Configuration.ApiClient.ParameterToString(sources)); // query parameter
            if (user != null) localVarQueryParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // query parameter

            // authentication (oauth2) required
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
                Exception exception = ExceptionFactory("V1MeasurementsRangeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeasurementRange>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeasurementRange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeasurementRange)));
            
        }

        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream V2MeasurementsCsvGet (string accessToken = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = V2MeasurementsCsvGetWithHttpInfo(accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > V2MeasurementsCsvGetWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v2/measurements/csv";
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
                "text/csv"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V2MeasurementsCsvGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
            
        }

        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> V2MeasurementsCsvGetAsync (string accessToken = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await V2MeasurementsCsvGetAsyncWithHttpInfo(accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> V2MeasurementsCsvGetAsyncWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v2/measurements/csv";
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
                "text/csv"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V2MeasurementsCsvGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
            
        }

        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>InlineResponse20012</returns>
        public InlineResponse20012 V2MeasurementsIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20012> localVarResponse = V2MeasurementsIdDeleteWithHttpInfo(id, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        public ApiResponse< InlineResponse20012 > V2MeasurementsIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsApi->V2MeasurementsIdDelete");

            var localVarPath = "/v2/measurements/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

            // authentication (quantimodo_oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2MeasurementsIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20012)));
            
        }

        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of InlineResponse20012</returns>
        public async System.Threading.Tasks.Task<InlineResponse20012> V2MeasurementsIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20012> localVarResponse = await V2MeasurementsIdDeleteAsyncWithHttpInfo(id, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> V2MeasurementsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsApi->V2MeasurementsIdDelete");

            var localVarPath = "/v2/measurements/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

            // authentication (quantimodo_oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2MeasurementsIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20012)));
            
        }

        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>InlineResponse20011</returns>
        public InlineResponse20011 V2MeasurementsIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20011> localVarResponse = V2MeasurementsIdGetWithHttpInfo(id, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of InlineResponse20011</returns>
        public ApiResponse< InlineResponse20011 > V2MeasurementsIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsApi->V2MeasurementsIdGet");

            var localVarPath = "/v2/measurements/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V2MeasurementsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20011>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20011) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20011)));
            
        }

        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of InlineResponse20011</returns>
        public async System.Threading.Tasks.Task<InlineResponse20011> V2MeasurementsIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20011> localVarResponse = await V2MeasurementsIdGetAsyncWithHttpInfo(id, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20011>> V2MeasurementsIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsApi->V2MeasurementsIdGet");

            var localVarPath = "/v2/measurements/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V2MeasurementsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20011>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20011) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20011)));
            
        }

        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">Measurement that should be updated (optional)</param>
        /// <returns>InlineResponse20012</returns>
        public InlineResponse20012 V2MeasurementsIdPut (int? id, string accessToken = null, Measurement body = null)
        {
             ApiResponse<InlineResponse20012> localVarResponse = V2MeasurementsIdPutWithHttpInfo(id, accessToken, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">Measurement that should be updated (optional)</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        public ApiResponse< InlineResponse20012 > V2MeasurementsIdPutWithHttpInfo (int? id, string accessToken = null, Measurement body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsApi->V2MeasurementsIdPut");

            var localVarPath = "/v2/measurements/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2MeasurementsIdPut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20012)));
            
        }

        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">Measurement that should be updated (optional)</param>
        /// <returns>Task of InlineResponse20012</returns>
        public async System.Threading.Tasks.Task<InlineResponse20012> V2MeasurementsIdPutAsync (int? id, string accessToken = null, Measurement body = null)
        {
             ApiResponse<InlineResponse20012> localVarResponse = await V2MeasurementsIdPutAsyncWithHttpInfo(id, accessToken, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="body">Measurement that should be updated (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> V2MeasurementsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Measurement body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsApi->V2MeasurementsIdPut");

            var localVarPath = "/v2/measurements/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2MeasurementsIdPut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20012)));
            
        }

        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>int?</returns>
        public int? V2MeasurementsRequestCsvPost (string accessToken = null)
        {
             ApiResponse<int?> localVarResponse = V2MeasurementsRequestCsvPostWithHttpInfo(accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > V2MeasurementsRequestCsvPostWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v2/measurements/request_csv";
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
                Exception exception = ExceptionFactory("V2MeasurementsRequestCsvPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> V2MeasurementsRequestCsvPostAsync (string accessToken = null)
        {
             ApiResponse<int?> localVarResponse = await V2MeasurementsRequestCsvPostAsyncWithHttpInfo(accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> V2MeasurementsRequestCsvPostAsyncWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v2/measurements/request_csv";
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
                Exception exception = ExceptionFactory("V2MeasurementsRequestCsvPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        /// <summary>
        /// Post Request for Measurements PDF Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>int?</returns>
        public int? V2MeasurementsRequestPdfPost (string accessToken = null)
        {
             ApiResponse<int?> localVarResponse = V2MeasurementsRequestPdfPostWithHttpInfo(accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Post Request for Measurements PDF Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > V2MeasurementsRequestPdfPostWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v2/measurements/request_pdf";
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
                Exception exception = ExceptionFactory("V2MeasurementsRequestPdfPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        /// <summary>
        /// Post Request for Measurements PDF Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> V2MeasurementsRequestPdfPostAsync (string accessToken = null)
        {
             ApiResponse<int?> localVarResponse = await V2MeasurementsRequestPdfPostAsyncWithHttpInfo(accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Post Request for Measurements PDF Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> V2MeasurementsRequestPdfPostAsyncWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v2/measurements/request_pdf";
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
                Exception exception = ExceptionFactory("V2MeasurementsRequestPdfPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        /// <summary>
        /// Post Request for Measurements XLS Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>int?</returns>
        public int? V2MeasurementsRequestXlsPost (string accessToken = null)
        {
             ApiResponse<int?> localVarResponse = V2MeasurementsRequestXlsPostWithHttpInfo(accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Post Request for Measurements XLS Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > V2MeasurementsRequestXlsPostWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v2/measurements/request_xls";
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
                Exception exception = ExceptionFactory("V2MeasurementsRequestXlsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        /// <summary>
        /// Post Request for Measurements XLS Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> V2MeasurementsRequestXlsPostAsync (string accessToken = null)
        {
             ApiResponse<int?> localVarResponse = await V2MeasurementsRequestXlsPostAsyncWithHttpInfo(accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Post Request for Measurements XLS Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> V2MeasurementsRequestXlsPostAsyncWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v2/measurements/request_xls";
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
                Exception exception = ExceptionFactory("V2MeasurementsRequestXlsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

    }
}
