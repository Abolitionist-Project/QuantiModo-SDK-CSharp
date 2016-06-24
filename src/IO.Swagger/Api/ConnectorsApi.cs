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
    public interface IConnectorsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get embeddable connect javascript
        /// </summary>
        /// <remarks>
        /// Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        void V1ConnectJsGet (string accessToken = null);

        /// <summary>
        /// Get embeddable connect javascript
        /// </summary>
        /// <remarks>
        /// Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1ConnectJsGetWithHttpInfo (string accessToken = null);
        /// <summary>
        /// Mobile connect page
        /// </summary>
        /// <remarks>
        /// This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns></returns>
        void V1ConnectMobileGet (string accessToken);

        /// <summary>
        /// Mobile connect page
        /// </summary>
        /// <remarks>
        /// This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1ConnectMobileGetWithHttpInfo (string accessToken);
        /// <summary>
        /// Obtain a token from 3rd party data source
        /// </summary>
        /// <remarks>
        /// Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        void V1ConnectorsConnectorConnectGet (string connector, string accessToken = null);

        /// <summary>
        /// Obtain a token from 3rd party data source
        /// </summary>
        /// <remarks>
        /// Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1ConnectorsConnectorConnectGetWithHttpInfo (string connector, string accessToken = null);
        /// <summary>
        /// Connection Instructions
        /// </summary>
        /// <remarks>
        /// Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        void V1ConnectorsConnectorConnectInstructionsGet (string connector, string parameters, string url, bool? usePopup, string accessToken = null);

        /// <summary>
        /// Connection Instructions
        /// </summary>
        /// <remarks>
        /// Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1ConnectorsConnectorConnectInstructionsGetWithHttpInfo (string connector, string parameters, string url, bool? usePopup, string accessToken = null);
        /// <summary>
        /// Connect Parameter
        /// </summary>
        /// <remarks>
        /// Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="defaultValue">Default parameter value (optional)</param>
        /// <returns>ConnectorInstruction</returns>
        ConnectorInstruction V1ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null);

        /// <summary>
        /// Connect Parameter
        /// </summary>
        /// <remarks>
        /// Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="defaultValue">Default parameter value (optional)</param>
        /// <returns>ApiResponse of ConnectorInstruction</returns>
        ApiResponse<ConnectorInstruction> V1ConnectorsConnectorConnectParameterGetWithHttpInfo (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null);
        /// <summary>
        /// Delete stored connection info
        /// </summary>
        /// <remarks>
        /// The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        void V1ConnectorsConnectorDisconnectGet (string connector);

        /// <summary>
        /// Delete stored connection info
        /// </summary>
        /// <remarks>
        /// The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1ConnectorsConnectorDisconnectGetWithHttpInfo (string connector);
        /// <summary>
        /// Get connector info for user
        /// </summary>
        /// <remarks>
        /// Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ConnectorInfo</returns>
        ConnectorInfo V1ConnectorsConnectorInfoGet (string connector, string accessToken = null);

        /// <summary>
        /// Get connector info for user
        /// </summary>
        /// <remarks>
        /// Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of ConnectorInfo</returns>
        ApiResponse<ConnectorInfo> V1ConnectorsConnectorInfoGetWithHttpInfo (string connector, string accessToken = null);
        /// <summary>
        /// Sync with data source
        /// </summary>
        /// <remarks>
        /// The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        void V1ConnectorsConnectorUpdateGet (string connector, string accessToken = null);

        /// <summary>
        /// Sync with data source
        /// </summary>
        /// <remarks>
        /// The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1ConnectorsConnectorUpdateGetWithHttpInfo (string connector, string accessToken = null);
        /// <summary>
        /// List of Connectors
        /// </summary>
        /// <remarks>
        /// A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Connector&gt;</returns>
        List<Connector> V1ConnectorsListGet ();

        /// <summary>
        /// List of Connectors
        /// </summary>
        /// <remarks>
        /// A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Connector&gt;</returns>
        ApiResponse<List<Connector>> V1ConnectorsListGetWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get embeddable connect javascript
        /// </summary>
        /// <remarks>
        /// Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1ConnectJsGetAsync (string accessToken = null);

        /// <summary>
        /// Get embeddable connect javascript
        /// </summary>
        /// <remarks>
        /// Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectJsGetAsyncWithHttpInfo (string accessToken = null);
        /// <summary>
        /// Mobile connect page
        /// </summary>
        /// <remarks>
        /// This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1ConnectMobileGetAsync (string accessToken);

        /// <summary>
        /// Mobile connect page
        /// </summary>
        /// <remarks>
        /// This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectMobileGetAsyncWithHttpInfo (string accessToken);
        /// <summary>
        /// Obtain a token from 3rd party data source
        /// </summary>
        /// <remarks>
        /// Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1ConnectorsConnectorConnectGetAsync (string connector, string accessToken = null);

        /// <summary>
        /// Obtain a token from 3rd party data source
        /// </summary>
        /// <remarks>
        /// Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectorsConnectorConnectGetAsyncWithHttpInfo (string connector, string accessToken = null);
        /// <summary>
        /// Connection Instructions
        /// </summary>
        /// <remarks>
        /// Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1ConnectorsConnectorConnectInstructionsGetAsync (string connector, string parameters, string url, bool? usePopup, string accessToken = null);

        /// <summary>
        /// Connection Instructions
        /// </summary>
        /// <remarks>
        /// Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectorsConnectorConnectInstructionsGetAsyncWithHttpInfo (string connector, string parameters, string url, bool? usePopup, string accessToken = null);
        /// <summary>
        /// Connect Parameter
        /// </summary>
        /// <remarks>
        /// Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="defaultValue">Default parameter value (optional)</param>
        /// <returns>Task of ConnectorInstruction</returns>
        System.Threading.Tasks.Task<ConnectorInstruction> V1ConnectorsConnectorConnectParameterGetAsync (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null);

        /// <summary>
        /// Connect Parameter
        /// </summary>
        /// <remarks>
        /// Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="defaultValue">Default parameter value (optional)</param>
        /// <returns>Task of ApiResponse (ConnectorInstruction)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConnectorInstruction>> V1ConnectorsConnectorConnectParameterGetAsyncWithHttpInfo (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null);
        /// <summary>
        /// Delete stored connection info
        /// </summary>
        /// <remarks>
        /// The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1ConnectorsConnectorDisconnectGetAsync (string connector);

        /// <summary>
        /// Delete stored connection info
        /// </summary>
        /// <remarks>
        /// The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectorsConnectorDisconnectGetAsyncWithHttpInfo (string connector);
        /// <summary>
        /// Get connector info for user
        /// </summary>
        /// <remarks>
        /// Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ConnectorInfo</returns>
        System.Threading.Tasks.Task<ConnectorInfo> V1ConnectorsConnectorInfoGetAsync (string connector, string accessToken = null);

        /// <summary>
        /// Get connector info for user
        /// </summary>
        /// <remarks>
        /// Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (ConnectorInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConnectorInfo>> V1ConnectorsConnectorInfoGetAsyncWithHttpInfo (string connector, string accessToken = null);
        /// <summary>
        /// Sync with data source
        /// </summary>
        /// <remarks>
        /// The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1ConnectorsConnectorUpdateGetAsync (string connector, string accessToken = null);

        /// <summary>
        /// Sync with data source
        /// </summary>
        /// <remarks>
        /// The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectorsConnectorUpdateGetAsyncWithHttpInfo (string connector, string accessToken = null);
        /// <summary>
        /// List of Connectors
        /// </summary>
        /// <remarks>
        /// A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Connector&gt;</returns>
        System.Threading.Tasks.Task<List<Connector>> V1ConnectorsListGetAsync ();

        /// <summary>
        /// List of Connectors
        /// </summary>
        /// <remarks>
        /// A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Connector&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Connector>>> V1ConnectorsListGetAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConnectorsApi : IConnectorsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectorsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ConnectorsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConnectorsApi(Configuration configuration = null)
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
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        public void V1ConnectJsGet (string accessToken = null)
        {
             V1ConnectJsGetWithHttpInfo(accessToken);
        }

        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1ConnectJsGetWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v1/connect.js";
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
                "application/x-javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectJsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1ConnectJsGetAsync (string accessToken = null)
        {
             await V1ConnectJsGetAsyncWithHttpInfo(accessToken);

        }

        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectJsGetAsyncWithHttpInfo (string accessToken = null)
        {

            var localVarPath = "/v1/connect.js";
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
                "application/x-javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectJsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Mobile connect page This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns></returns>
        public void V1ConnectMobileGet (string accessToken)
        {
             V1ConnectMobileGetWithHttpInfo(accessToken);
        }

        /// <summary>
        /// Mobile connect page This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1ConnectMobileGetWithHttpInfo (string accessToken)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null)
                throw new ApiException(400, "Missing required parameter 'accessToken' when calling ConnectorsApi->V1ConnectMobileGet");

            var localVarPath = "/v1/connect/mobile";
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
                "text/html"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectMobileGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Mobile connect page This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1ConnectMobileGetAsync (string accessToken)
        {
             await V1ConnectMobileGetAsyncWithHttpInfo(accessToken);

        }

        /// <summary>
        /// Mobile connect page This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectMobileGetAsyncWithHttpInfo (string accessToken)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null)
                throw new ApiException(400, "Missing required parameter 'accessToken' when calling ConnectorsApi->V1ConnectMobileGet");

            var localVarPath = "/v1/connect/mobile";
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
                "text/html"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectMobileGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        public void V1ConnectorsConnectorConnectGet (string connector, string accessToken = null)
        {
             V1ConnectorsConnectorConnectGetWithHttpInfo(connector, accessToken);
        }

        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1ConnectorsConnectorConnectGetWithHttpInfo (string connector, string accessToken = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorConnectGet");

            var localVarPath = "/v1/connectors/{connector}/connect";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorConnectGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1ConnectorsConnectorConnectGetAsync (string connector, string accessToken = null)
        {
             await V1ConnectorsConnectorConnectGetAsyncWithHttpInfo(connector, accessToken);

        }

        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectorsConnectorConnectGetAsyncWithHttpInfo (string connector, string accessToken = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorConnectGet");

            var localVarPath = "/v1/connectors/{connector}/connect";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorConnectGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        public void V1ConnectorsConnectorConnectInstructionsGet (string connector, string parameters, string url, bool? usePopup, string accessToken = null)
        {
             V1ConnectorsConnectorConnectInstructionsGetWithHttpInfo(connector, parameters, url, usePopup, accessToken);
        }

        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1ConnectorsConnectorConnectInstructionsGetWithHttpInfo (string connector, string parameters, string url, bool? usePopup, string accessToken = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'parameters' is set
            if (parameters == null)
                throw new ApiException(400, "Missing required parameter 'parameters' when calling ConnectorsApi->V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'url' is set
            if (url == null)
                throw new ApiException(400, "Missing required parameter 'url' when calling ConnectorsApi->V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'usePopup' is set
            if (usePopup == null)
                throw new ApiException(400, "Missing required parameter 'usePopup' when calling ConnectorsApi->V1ConnectorsConnectorConnectInstructionsGet");

            var localVarPath = "/v1/connectors/{connector}/connectInstructions";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (parameters != null) localVarQueryParams.Add("parameters", Configuration.ApiClient.ParameterToString(parameters)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            if (usePopup != null) localVarQueryParams.Add("usePopup", Configuration.ApiClient.ParameterToString(usePopup)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorConnectInstructionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1ConnectorsConnectorConnectInstructionsGetAsync (string connector, string parameters, string url, bool? usePopup, string accessToken = null)
        {
             await V1ConnectorsConnectorConnectInstructionsGetAsyncWithHttpInfo(connector, parameters, url, usePopup, accessToken);

        }

        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectorsConnectorConnectInstructionsGetAsyncWithHttpInfo (string connector, string parameters, string url, bool? usePopup, string accessToken = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'parameters' is set
            if (parameters == null)
                throw new ApiException(400, "Missing required parameter 'parameters' when calling ConnectorsApi->V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'url' is set
            if (url == null)
                throw new ApiException(400, "Missing required parameter 'url' when calling ConnectorsApi->V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'usePopup' is set
            if (usePopup == null)
                throw new ApiException(400, "Missing required parameter 'usePopup' when calling ConnectorsApi->V1ConnectorsConnectorConnectInstructionsGet");

            var localVarPath = "/v1/connectors/{connector}/connectInstructions";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (parameters != null) localVarQueryParams.Add("parameters", Configuration.ApiClient.ParameterToString(parameters)); // query parameter
            if (url != null) localVarQueryParams.Add("url", Configuration.ApiClient.ParameterToString(url)); // query parameter
            if (usePopup != null) localVarQueryParams.Add("usePopup", Configuration.ApiClient.ParameterToString(usePopup)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorConnectInstructionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="defaultValue">Default parameter value (optional)</param>
        /// <returns>ConnectorInstruction</returns>
        public ConnectorInstruction V1ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null)
        {
             ApiResponse<ConnectorInstruction> localVarResponse = V1ConnectorsConnectorConnectParameterGetWithHttpInfo(connector, displayName, key, placeholder, type, usePopup, accessToken, defaultValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="defaultValue">Default parameter value (optional)</param>
        /// <returns>ApiResponse of ConnectorInstruction</returns>
        public ApiResponse< ConnectorInstruction > V1ConnectorsConnectorConnectParameterGetWithHttpInfo (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'displayName' is set
            if (displayName == null)
                throw new ApiException(400, "Missing required parameter 'displayName' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'placeholder' is set
            if (placeholder == null)
                throw new ApiException(400, "Missing required parameter 'placeholder' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'usePopup' is set
            if (usePopup == null)
                throw new ApiException(400, "Missing required parameter 'usePopup' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");

            var localVarPath = "/v1/connectors/{connector}/connectParameter";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (defaultValue != null) localVarQueryParams.Add("defaultValue", Configuration.ApiClient.ParameterToString(defaultValue)); // query parameter
            if (displayName != null) localVarQueryParams.Add("displayName", Configuration.ApiClient.ParameterToString(displayName)); // query parameter
            if (key != null) localVarQueryParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // query parameter
            if (placeholder != null) localVarQueryParams.Add("placeholder", Configuration.ApiClient.ParameterToString(placeholder)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (usePopup != null) localVarQueryParams.Add("usePopup", Configuration.ApiClient.ParameterToString(usePopup)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorConnectParameterGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConnectorInstruction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConnectorInstruction) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConnectorInstruction)));
            
        }

        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="defaultValue">Default parameter value (optional)</param>
        /// <returns>Task of ConnectorInstruction</returns>
        public async System.Threading.Tasks.Task<ConnectorInstruction> V1ConnectorsConnectorConnectParameterGetAsync (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null)
        {
             ApiResponse<ConnectorInstruction> localVarResponse = await V1ConnectorsConnectorConnectParameterGetAsyncWithHttpInfo(connector, displayName, key, placeholder, type, usePopup, accessToken, defaultValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="defaultValue">Default parameter value (optional)</param>
        /// <returns>Task of ApiResponse (ConnectorInstruction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConnectorInstruction>> V1ConnectorsConnectorConnectParameterGetAsyncWithHttpInfo (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken = null, string defaultValue = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'displayName' is set
            if (displayName == null)
                throw new ApiException(400, "Missing required parameter 'displayName' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'placeholder' is set
            if (placeholder == null)
                throw new ApiException(400, "Missing required parameter 'placeholder' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'usePopup' is set
            if (usePopup == null)
                throw new ApiException(400, "Missing required parameter 'usePopup' when calling ConnectorsApi->V1ConnectorsConnectorConnectParameterGet");

            var localVarPath = "/v1/connectors/{connector}/connectParameter";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (defaultValue != null) localVarQueryParams.Add("defaultValue", Configuration.ApiClient.ParameterToString(defaultValue)); // query parameter
            if (displayName != null) localVarQueryParams.Add("displayName", Configuration.ApiClient.ParameterToString(displayName)); // query parameter
            if (key != null) localVarQueryParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // query parameter
            if (placeholder != null) localVarQueryParams.Add("placeholder", Configuration.ApiClient.ParameterToString(placeholder)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (usePopup != null) localVarQueryParams.Add("usePopup", Configuration.ApiClient.ParameterToString(usePopup)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorConnectParameterGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConnectorInstruction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConnectorInstruction) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConnectorInstruction)));
            
        }

        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        public void V1ConnectorsConnectorDisconnectGet (string connector)
        {
             V1ConnectorsConnectorDisconnectGetWithHttpInfo(connector);
        }

        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1ConnectorsConnectorDisconnectGetWithHttpInfo (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorDisconnectGet");

            var localVarPath = "/v1/connectors/{connector}/disconnect";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorDisconnectGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1ConnectorsConnectorDisconnectGetAsync (string connector)
        {
             await V1ConnectorsConnectorDisconnectGetAsyncWithHttpInfo(connector);

        }

        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectorsConnectorDisconnectGetAsyncWithHttpInfo (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorDisconnectGet");

            var localVarPath = "/v1/connectors/{connector}/disconnect";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorDisconnectGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ConnectorInfo</returns>
        public ConnectorInfo V1ConnectorsConnectorInfoGet (string connector, string accessToken = null)
        {
             ApiResponse<ConnectorInfo> localVarResponse = V1ConnectorsConnectorInfoGetWithHttpInfo(connector, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of ConnectorInfo</returns>
        public ApiResponse< ConnectorInfo > V1ConnectorsConnectorInfoGetWithHttpInfo (string connector, string accessToken = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorInfoGet");

            var localVarPath = "/v1/connectors/{connector}/info";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorInfoGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConnectorInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConnectorInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConnectorInfo)));
            
        }

        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ConnectorInfo</returns>
        public async System.Threading.Tasks.Task<ConnectorInfo> V1ConnectorsConnectorInfoGetAsync (string connector, string accessToken = null)
        {
             ApiResponse<ConnectorInfo> localVarResponse = await V1ConnectorsConnectorInfoGetAsyncWithHttpInfo(connector, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (ConnectorInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConnectorInfo>> V1ConnectorsConnectorInfoGetAsyncWithHttpInfo (string connector, string accessToken = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorInfoGet");

            var localVarPath = "/v1/connectors/{connector}/info";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorInfoGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConnectorInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConnectorInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConnectorInfo)));
            
        }

        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        public void V1ConnectorsConnectorUpdateGet (string connector, string accessToken = null)
        {
             V1ConnectorsConnectorUpdateGetWithHttpInfo(connector, accessToken);
        }

        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1ConnectorsConnectorUpdateGetWithHttpInfo (string connector, string accessToken = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorUpdateGet");

            var localVarPath = "/v1/connectors/{connector}/update";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorUpdateGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1ConnectorsConnectorUpdateGetAsync (string connector, string accessToken = null)
        {
             await V1ConnectorsConnectorUpdateGetAsyncWithHttpInfo(connector, accessToken);

        }

        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1ConnectorsConnectorUpdateGetAsyncWithHttpInfo (string connector, string accessToken = null)
        {
            // verify the required parameter 'connector' is set
            if (connector == null)
                throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsApi->V1ConnectorsConnectorUpdateGet");

            var localVarPath = "/v1/connectors/{connector}/update";
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
            if (connector != null) localVarPathParams.Add("connector", Configuration.ApiClient.ParameterToString(connector)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter

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
                Exception exception = ExceptionFactory("V1ConnectorsConnectorUpdateGet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Connector&gt;</returns>
        public List<Connector> V1ConnectorsListGet ()
        {
             ApiResponse<List<Connector>> localVarResponse = V1ConnectorsListGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Connector&gt;</returns>
        public ApiResponse< List<Connector> > V1ConnectorsListGetWithHttpInfo ()
        {

            var localVarPath = "/v1/connectors/list";
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
                Exception exception = ExceptionFactory("V1ConnectorsListGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Connector>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Connector>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Connector>)));
            
        }

        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Connector&gt;</returns>
        public async System.Threading.Tasks.Task<List<Connector>> V1ConnectorsListGetAsync ()
        {
             ApiResponse<List<Connector>> localVarResponse = await V1ConnectorsListGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Connector&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Connector>>> V1ConnectorsListGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/connectors/list";
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
                Exception exception = ExceptionFactory("V1ConnectorsListGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Connector>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Connector>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Connector>)));
            
        }

    }
}
