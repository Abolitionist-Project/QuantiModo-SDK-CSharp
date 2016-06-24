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
    public interface IPairsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get pairs
        /// </summary>
        /// <remarks>
        /// Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>List&lt;Pairs&gt;</returns>
        List<Pairs> V1PairsCsvGet (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get pairs
        /// </summary>
        /// <remarks>
        /// Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of List&lt;Pairs&gt;</returns>
        ApiResponse<List<Pairs>> V1PairsCsvGetWithHttpInfo (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Get pairs
        /// </summary>
        /// <remarks>
        /// Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>List&lt;Pairs&gt;</returns>
        List<Pairs> V1PairsGet (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get pairs
        /// </summary>
        /// <remarks>
        /// Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of List&lt;Pairs&gt;</returns>
        ApiResponse<List<Pairs>> V1PairsGetWithHttpInfo (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get pairs
        /// </summary>
        /// <remarks>
        /// Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of List&lt;Pairs&gt;</returns>
        System.Threading.Tasks.Task<List<Pairs>> V1PairsCsvGetAsync (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get pairs
        /// </summary>
        /// <remarks>
        /// Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Pairs&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Pairs>>> V1PairsCsvGetAsyncWithHttpInfo (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Get pairs
        /// </summary>
        /// <remarks>
        /// Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of List&lt;Pairs&gt;</returns>
        System.Threading.Tasks.Task<List<Pairs>> V1PairsGetAsync (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get pairs
        /// </summary>
        /// <remarks>
        /// Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Pairs&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Pairs>>> V1PairsGetAsyncWithHttpInfo (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PairsApi : IPairsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PairsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PairsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PairsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PairsApi(Configuration configuration = null)
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
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>List&lt;Pairs&gt;</returns>
        public List<Pairs> V1PairsCsvGet (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<List<Pairs>> localVarResponse = V1PairsCsvGetWithHttpInfo(cause, effect, accessToken, causeSource, causeUnit, delay, duration, effectSource, effectUnit, endTime, startTime, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of List&lt;Pairs&gt;</returns>
        public ApiResponse< List<Pairs> > V1PairsCsvGetWithHttpInfo (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)
        {
            // verify the required parameter 'cause' is set
            if (cause == null)
                throw new ApiException(400, "Missing required parameter 'cause' when calling PairsApi->V1PairsCsvGet");
            // verify the required parameter 'effect' is set
            if (effect == null)
                throw new ApiException(400, "Missing required parameter 'effect' when calling PairsApi->V1PairsCsvGet");

            var localVarPath = "/v1/pairsCsv";
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
            if (cause != null) localVarQueryParams.Add("cause", Configuration.ApiClient.ParameterToString(cause)); // query parameter
            if (causeSource != null) localVarQueryParams.Add("causeSource", Configuration.ApiClient.ParameterToString(causeSource)); // query parameter
            if (causeUnit != null) localVarQueryParams.Add("causeUnit", Configuration.ApiClient.ParameterToString(causeUnit)); // query parameter
            if (delay != null) localVarQueryParams.Add("delay", Configuration.ApiClient.ParameterToString(delay)); // query parameter
            if (duration != null) localVarQueryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (effect != null) localVarQueryParams.Add("effect", Configuration.ApiClient.ParameterToString(effect)); // query parameter
            if (effectSource != null) localVarQueryParams.Add("effectSource", Configuration.ApiClient.ParameterToString(effectSource)); // query parameter
            if (effectUnit != null) localVarQueryParams.Add("effectUnit", Configuration.ApiClient.ParameterToString(effectUnit)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
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
                Exception exception = ExceptionFactory("V1PairsCsvGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Pairs>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Pairs>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Pairs>)));
            
        }

        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of List&lt;Pairs&gt;</returns>
        public async System.Threading.Tasks.Task<List<Pairs>> V1PairsCsvGetAsync (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<List<Pairs>> localVarResponse = await V1PairsCsvGetAsyncWithHttpInfo(cause, effect, accessToken, causeSource, causeUnit, delay, duration, effectSource, effectUnit, endTime, startTime, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Pairs&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Pairs>>> V1PairsCsvGetAsyncWithHttpInfo (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)
        {
            // verify the required parameter 'cause' is set
            if (cause == null)
                throw new ApiException(400, "Missing required parameter 'cause' when calling PairsApi->V1PairsCsvGet");
            // verify the required parameter 'effect' is set
            if (effect == null)
                throw new ApiException(400, "Missing required parameter 'effect' when calling PairsApi->V1PairsCsvGet");

            var localVarPath = "/v1/pairsCsv";
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
            if (cause != null) localVarQueryParams.Add("cause", Configuration.ApiClient.ParameterToString(cause)); // query parameter
            if (causeSource != null) localVarQueryParams.Add("causeSource", Configuration.ApiClient.ParameterToString(causeSource)); // query parameter
            if (causeUnit != null) localVarQueryParams.Add("causeUnit", Configuration.ApiClient.ParameterToString(causeUnit)); // query parameter
            if (delay != null) localVarQueryParams.Add("delay", Configuration.ApiClient.ParameterToString(delay)); // query parameter
            if (duration != null) localVarQueryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (effect != null) localVarQueryParams.Add("effect", Configuration.ApiClient.ParameterToString(effect)); // query parameter
            if (effectSource != null) localVarQueryParams.Add("effectSource", Configuration.ApiClient.ParameterToString(effectSource)); // query parameter
            if (effectUnit != null) localVarQueryParams.Add("effectUnit", Configuration.ApiClient.ParameterToString(effectUnit)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
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
                Exception exception = ExceptionFactory("V1PairsCsvGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Pairs>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Pairs>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Pairs>)));
            
        }

        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>List&lt;Pairs&gt;</returns>
        public List<Pairs> V1PairsGet (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<List<Pairs>> localVarResponse = V1PairsGetWithHttpInfo(cause, effect, accessToken, causeSource, causeUnit, delay, duration, effectSource, effectUnit, endTime, startTime, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of List&lt;Pairs&gt;</returns>
        public ApiResponse< List<Pairs> > V1PairsGetWithHttpInfo (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)
        {
            // verify the required parameter 'cause' is set
            if (cause == null)
                throw new ApiException(400, "Missing required parameter 'cause' when calling PairsApi->V1PairsGet");
            // verify the required parameter 'effect' is set
            if (effect == null)
                throw new ApiException(400, "Missing required parameter 'effect' when calling PairsApi->V1PairsGet");

            var localVarPath = "/v1/pairs";
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
            if (cause != null) localVarQueryParams.Add("cause", Configuration.ApiClient.ParameterToString(cause)); // query parameter
            if (causeSource != null) localVarQueryParams.Add("causeSource", Configuration.ApiClient.ParameterToString(causeSource)); // query parameter
            if (causeUnit != null) localVarQueryParams.Add("causeUnit", Configuration.ApiClient.ParameterToString(causeUnit)); // query parameter
            if (delay != null) localVarQueryParams.Add("delay", Configuration.ApiClient.ParameterToString(delay)); // query parameter
            if (duration != null) localVarQueryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (effect != null) localVarQueryParams.Add("effect", Configuration.ApiClient.ParameterToString(effect)); // query parameter
            if (effectSource != null) localVarQueryParams.Add("effectSource", Configuration.ApiClient.ParameterToString(effectSource)); // query parameter
            if (effectUnit != null) localVarQueryParams.Add("effectUnit", Configuration.ApiClient.ParameterToString(effectUnit)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
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
                Exception exception = ExceptionFactory("V1PairsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Pairs>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Pairs>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Pairs>)));
            
        }

        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of List&lt;Pairs&gt;</returns>
        public async System.Threading.Tasks.Task<List<Pairs>> V1PairsGetAsync (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<List<Pairs>> localVarResponse = await V1PairsGetAsyncWithHttpInfo(cause, effect, accessToken, causeSource, causeUnit, delay, duration, effectSource, effectUnit, endTime, startTime, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from (optional)</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in (optional)</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings. (optional)</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from (optional)</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in (optional)</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Pairs&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Pairs>>> V1PairsGetAsyncWithHttpInfo (string cause, string effect, string accessToken = null, string causeSource = null, string causeUnit = null, string delay = null, string duration = null, string effectSource = null, string effectUnit = null, string endTime = null, string startTime = null, int? limit = null, int? offset = null, int? sort = null)
        {
            // verify the required parameter 'cause' is set
            if (cause == null)
                throw new ApiException(400, "Missing required parameter 'cause' when calling PairsApi->V1PairsGet");
            // verify the required parameter 'effect' is set
            if (effect == null)
                throw new ApiException(400, "Missing required parameter 'effect' when calling PairsApi->V1PairsGet");

            var localVarPath = "/v1/pairs";
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
            if (cause != null) localVarQueryParams.Add("cause", Configuration.ApiClient.ParameterToString(cause)); // query parameter
            if (causeSource != null) localVarQueryParams.Add("causeSource", Configuration.ApiClient.ParameterToString(causeSource)); // query parameter
            if (causeUnit != null) localVarQueryParams.Add("causeUnit", Configuration.ApiClient.ParameterToString(causeUnit)); // query parameter
            if (delay != null) localVarQueryParams.Add("delay", Configuration.ApiClient.ParameterToString(delay)); // query parameter
            if (duration != null) localVarQueryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (effect != null) localVarQueryParams.Add("effect", Configuration.ApiClient.ParameterToString(effect)); // query parameter
            if (effectSource != null) localVarQueryParams.Add("effectSource", Configuration.ApiClient.ParameterToString(effectSource)); // query parameter
            if (effectUnit != null) localVarQueryParams.Add("effectUnit", Configuration.ApiClient.ParameterToString(effectUnit)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
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
                Exception exception = ExceptionFactory("V1PairsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Pairs>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Pairs>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Pairs>)));
            
        }

    }
}
