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
    public interface IUnitsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get unit categories
        /// </summary>
        /// <remarks>
        /// Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnitCategory</returns>
        UnitCategory V1UnitCategoriesGet ();

        /// <summary>
        /// Get unit categories
        /// </summary>
        /// <remarks>
        /// Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnitCategory</returns>
        ApiResponse<UnitCategory> V1UnitCategoriesGetWithHttpInfo ();
        /// <summary>
        /// Get all available units
        /// </summary>
        /// <remarks>
        /// Get all available units
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Unit id (optional)</param>
        /// <param name="unitName">Unit name (optional)</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation. (optional)</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name. (optional)</param>
        /// <returns>List&lt;Unit&gt;</returns>
        List<Unit> V1UnitsGet (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null);

        /// <summary>
        /// Get all available units
        /// </summary>
        /// <remarks>
        /// Get all available units
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Unit id (optional)</param>
        /// <param name="unitName">Unit name (optional)</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation. (optional)</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name. (optional)</param>
        /// <returns>ApiResponse of List&lt;Unit&gt;</returns>
        ApiResponse<List<Unit>> V1UnitsGetWithHttpInfo (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null);
        /// <summary>
        /// Units for Variable
        /// </summary>
        /// <remarks>
        /// Get a list of all possible units to use for a given variable
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="unitName">Name of Unit you want to retrieve (optional)</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want (optional)</param>
        /// <param name="categoryName">Name of the category you want units for (optional)</param>
        /// <param name="variable">Name of the variable you want units for (optional)</param>
        /// <returns>List&lt;Unit&gt;</returns>
        List<Unit> V1UnitsVariableGet (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null);

        /// <summary>
        /// Units for Variable
        /// </summary>
        /// <remarks>
        /// Get a list of all possible units to use for a given variable
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="unitName">Name of Unit you want to retrieve (optional)</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want (optional)</param>
        /// <param name="categoryName">Name of the category you want units for (optional)</param>
        /// <param name="variable">Name of the variable you want units for (optional)</param>
        /// <returns>ApiResponse of List&lt;Unit&gt;</returns>
        ApiResponse<List<Unit>> V1UnitsVariableGetWithHttpInfo (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get unit categories
        /// </summary>
        /// <remarks>
        /// Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnitCategory</returns>
        System.Threading.Tasks.Task<UnitCategory> V1UnitCategoriesGetAsync ();

        /// <summary>
        /// Get unit categories
        /// </summary>
        /// <remarks>
        /// Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnitCategory)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnitCategory>> V1UnitCategoriesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get all available units
        /// </summary>
        /// <remarks>
        /// Get all available units
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Unit id (optional)</param>
        /// <param name="unitName">Unit name (optional)</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation. (optional)</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name. (optional)</param>
        /// <returns>Task of List&lt;Unit&gt;</returns>
        System.Threading.Tasks.Task<List<Unit>> V1UnitsGetAsync (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null);

        /// <summary>
        /// Get all available units
        /// </summary>
        /// <remarks>
        /// Get all available units
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Unit id (optional)</param>
        /// <param name="unitName">Unit name (optional)</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation. (optional)</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Unit&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Unit>>> V1UnitsGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null);
        /// <summary>
        /// Units for Variable
        /// </summary>
        /// <remarks>
        /// Get a list of all possible units to use for a given variable
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="unitName">Name of Unit you want to retrieve (optional)</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want (optional)</param>
        /// <param name="categoryName">Name of the category you want units for (optional)</param>
        /// <param name="variable">Name of the variable you want units for (optional)</param>
        /// <returns>Task of List&lt;Unit&gt;</returns>
        System.Threading.Tasks.Task<List<Unit>> V1UnitsVariableGetAsync (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null);

        /// <summary>
        /// Units for Variable
        /// </summary>
        /// <remarks>
        /// Get a list of all possible units to use for a given variable
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="unitName">Name of Unit you want to retrieve (optional)</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want (optional)</param>
        /// <param name="categoryName">Name of the category you want units for (optional)</param>
        /// <param name="variable">Name of the variable you want units for (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Unit&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Unit>>> V1UnitsVariableGetAsyncWithHttpInfo (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UnitsApi : IUnitsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UnitsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="UnitsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UnitsApi(Configuration configuration = null)
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
        /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnitCategory</returns>
        public UnitCategory V1UnitCategoriesGet ()
        {
             ApiResponse<UnitCategory> localVarResponse = V1UnitCategoriesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnitCategory</returns>
        public ApiResponse< UnitCategory > V1UnitCategoriesGetWithHttpInfo ()
        {

            var localVarPath = "/v1/unitCategories";
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
                Exception exception = ExceptionFactory("V1UnitCategoriesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UnitCategory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnitCategory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnitCategory)));
            
        }

        /// <summary>
        /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnitCategory</returns>
        public async System.Threading.Tasks.Task<UnitCategory> V1UnitCategoriesGetAsync ()
        {
             ApiResponse<UnitCategory> localVarResponse = await V1UnitCategoriesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnitCategory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnitCategory>> V1UnitCategoriesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/unitCategories";
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
                Exception exception = ExceptionFactory("V1UnitCategoriesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UnitCategory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnitCategory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnitCategory)));
            
        }

        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Unit id (optional)</param>
        /// <param name="unitName">Unit name (optional)</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation. (optional)</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name. (optional)</param>
        /// <returns>List&lt;Unit&gt;</returns>
        public List<Unit> V1UnitsGet (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null)
        {
             ApiResponse<List<Unit>> localVarResponse = V1UnitsGetWithHttpInfo(accessToken, id, unitName, abbreviatedUnitName, categoryName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Unit id (optional)</param>
        /// <param name="unitName">Unit name (optional)</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation. (optional)</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name. (optional)</param>
        /// <returns>ApiResponse of List&lt;Unit&gt;</returns>
        public ApiResponse< List<Unit> > V1UnitsGetWithHttpInfo (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null)
        {

            var localVarPath = "/v1/units";
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
            if (unitName != null) localVarQueryParams.Add("unitName", Configuration.ApiClient.ParameterToString(unitName)); // query parameter
            if (abbreviatedUnitName != null) localVarQueryParams.Add("abbreviatedUnitName", Configuration.ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
            if (categoryName != null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName)); // query parameter

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
                Exception exception = ExceptionFactory("V1UnitsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Unit>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Unit>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Unit>)));
            
        }

        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Unit id (optional)</param>
        /// <param name="unitName">Unit name (optional)</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation. (optional)</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name. (optional)</param>
        /// <returns>Task of List&lt;Unit&gt;</returns>
        public async System.Threading.Tasks.Task<List<Unit>> V1UnitsGetAsync (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null)
        {
             ApiResponse<List<Unit>> localVarResponse = await V1UnitsGetAsyncWithHttpInfo(accessToken, id, unitName, abbreviatedUnitName, categoryName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Unit id (optional)</param>
        /// <param name="unitName">Unit name (optional)</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation. (optional)</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Unit&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Unit>>> V1UnitsGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null)
        {

            var localVarPath = "/v1/units";
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
            if (unitName != null) localVarQueryParams.Add("unitName", Configuration.ApiClient.ParameterToString(unitName)); // query parameter
            if (abbreviatedUnitName != null) localVarQueryParams.Add("abbreviatedUnitName", Configuration.ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
            if (categoryName != null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName)); // query parameter

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
                Exception exception = ExceptionFactory("V1UnitsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Unit>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Unit>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Unit>)));
            
        }

        /// <summary>
        /// Units for Variable Get a list of all possible units to use for a given variable
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="unitName">Name of Unit you want to retrieve (optional)</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want (optional)</param>
        /// <param name="categoryName">Name of the category you want units for (optional)</param>
        /// <param name="variable">Name of the variable you want units for (optional)</param>
        /// <returns>List&lt;Unit&gt;</returns>
        public List<Unit> V1UnitsVariableGet (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null)
        {
             ApiResponse<List<Unit>> localVarResponse = V1UnitsVariableGetWithHttpInfo(accessToken, unitName, abbreviatedUnitName, categoryName, variable);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Units for Variable Get a list of all possible units to use for a given variable
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="unitName">Name of Unit you want to retrieve (optional)</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want (optional)</param>
        /// <param name="categoryName">Name of the category you want units for (optional)</param>
        /// <param name="variable">Name of the variable you want units for (optional)</param>
        /// <returns>ApiResponse of List&lt;Unit&gt;</returns>
        public ApiResponse< List<Unit> > V1UnitsVariableGetWithHttpInfo (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null)
        {

            var localVarPath = "/v1/unitsVariable";
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
            if (unitName != null) localVarQueryParams.Add("unitName", Configuration.ApiClient.ParameterToString(unitName)); // query parameter
            if (abbreviatedUnitName != null) localVarQueryParams.Add("abbreviatedUnitName", Configuration.ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
            if (categoryName != null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName)); // query parameter
            if (variable != null) localVarQueryParams.Add("variable", Configuration.ApiClient.ParameterToString(variable)); // query parameter

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
                Exception exception = ExceptionFactory("V1UnitsVariableGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Unit>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Unit>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Unit>)));
            
        }

        /// <summary>
        /// Units for Variable Get a list of all possible units to use for a given variable
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="unitName">Name of Unit you want to retrieve (optional)</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want (optional)</param>
        /// <param name="categoryName">Name of the category you want units for (optional)</param>
        /// <param name="variable">Name of the variable you want units for (optional)</param>
        /// <returns>Task of List&lt;Unit&gt;</returns>
        public async System.Threading.Tasks.Task<List<Unit>> V1UnitsVariableGetAsync (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null)
        {
             ApiResponse<List<Unit>> localVarResponse = await V1UnitsVariableGetAsyncWithHttpInfo(accessToken, unitName, abbreviatedUnitName, categoryName, variable);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Units for Variable Get a list of all possible units to use for a given variable
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="unitName">Name of Unit you want to retrieve (optional)</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want (optional)</param>
        /// <param name="categoryName">Name of the category you want units for (optional)</param>
        /// <param name="variable">Name of the variable you want units for (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Unit&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Unit>>> V1UnitsVariableGetAsyncWithHttpInfo (string accessToken = null, string unitName = null, string abbreviatedUnitName = null, string categoryName = null, string variable = null)
        {

            var localVarPath = "/v1/unitsVariable";
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
            if (unitName != null) localVarQueryParams.Add("unitName", Configuration.ApiClient.ParameterToString(unitName)); // query parameter
            if (abbreviatedUnitName != null) localVarQueryParams.Add("abbreviatedUnitName", Configuration.ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
            if (categoryName != null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName)); // query parameter
            if (variable != null) localVarQueryParams.Add("variable", Configuration.ApiClient.ParameterToString(variable)); // query parameter

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
                Exception exception = ExceptionFactory("V1UnitsVariableGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Unit>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Unit>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Unit>)));
            
        }

    }
}
