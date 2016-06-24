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
    public interface ICorrelationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get aggregated correlations
        /// </summary>
        /// <remarks>
        /// Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1AggregatedCorrelationsGet (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get aggregated correlations
        /// </summary>
        /// <remarks>
        /// Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        ApiResponse<List<Correlation>> V1AggregatedCorrelationsGetWithHttpInfo (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Store or Update a Correlation
        /// </summary>
        /// <remarks>
        /// Add correlation
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        void V1AggregatedCorrelationsPost (PostCorrelation body, string accessToken = null);

        /// <summary>
        /// Store or Update a Correlation
        /// </summary>
        /// <remarks>
        /// Add correlation
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1AggregatedCorrelationsPostWithHttpInfo (PostCorrelation body, string accessToken = null);
        /// <summary>
        /// Get correlations
        /// </summary>
        /// <remarks>
        /// Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1CorrelationsGet (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get correlations
        /// </summary>
        /// <remarks>
        /// Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        ApiResponse<List<Correlation>> V1CorrelationsGetWithHttpInfo (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null);

        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        ApiResponse<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetWithHttpInfo (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null);
        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>List&lt;CommonResponse&gt;</returns>
        List<CommonResponse> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null);

        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>ApiResponse of List&lt;CommonResponse&gt;</returns>
        ApiResponse<List<CommonResponse>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetWithHttpInfo (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null);
        /// <summary>
        /// Get average correlations for variables containing search term
        /// </summary>
        /// <remarks>
        /// Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1PublicCorrelationsSearchSearchGet (string search, string effectOrCause, string accessToken = null);

        /// <summary>
        /// Get average correlations for variables containing search term
        /// </summary>
        /// <remarks>
        /// Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        ApiResponse<List<Correlation>> V1PublicCorrelationsSearchSearchGetWithHttpInfo (string search, string effectOrCause, string accessToken = null);
        /// <summary>
        /// Search user correlations for a given effect
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given effect
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1VariablesVariableNameCausesGet (string variableName);

        /// <summary>
        /// Search user correlations for a given effect
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given effect
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        ApiResponse<List<Correlation>> V1VariablesVariableNameCausesGetWithHttpInfo (string variableName);
        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user effect variables for a given cause
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1VariablesVariableNameEffectsGet (string variableName, string accessToken = null);

        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user effect variables for a given cause
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        ApiResponse<List<Correlation>> V1VariablesVariableNameEffectsGetWithHttpInfo (string variableName, string accessToken = null);
        /// <summary>
        /// Search public correlations for a given effect
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all public cause variables for a given effect
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1VariablesVariableNamePublicCausesGet (string variableName, string accessToken = null);

        /// <summary>
        /// Search public correlations for a given effect
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all public cause variables for a given effect
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        ApiResponse<List<Correlation>> V1VariablesVariableNamePublicCausesGetWithHttpInfo (string variableName, string accessToken = null);
        /// <summary>
        /// Search public correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all public cause variables for a given cause
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1VariablesVariableNamePublicEffectsGet (string variableName, string accessToken = null);

        /// <summary>
        /// Search public correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all public cause variables for a given cause
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        ApiResponse<List<Correlation>> V1VariablesVariableNamePublicEffectsGetWithHttpInfo (string variableName, string accessToken = null);
        /// <summary>
        /// Delete vote
        /// </summary>
        /// <remarks>
        /// Delete previously posted vote
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1VotesDeletePost (VoteDelete body, string accessToken = null);

        /// <summary>
        /// Delete vote
        /// </summary>
        /// <remarks>
        /// Delete previously posted vote
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        ApiResponse<CommonResponse> V1VotesDeletePostWithHttpInfo (VoteDelete body, string accessToken = null);
        /// <summary>
        /// Post or update vote
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1VotesPost (PostVote body, string accessToken = null);

        /// <summary>
        /// Post or update vote
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        ApiResponse<CommonResponse> V1VotesPostWithHttpInfo (PostVote body, string accessToken = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get aggregated correlations
        /// </summary>
        /// <remarks>
        /// Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        System.Threading.Tasks.Task<List<Correlation>> V1AggregatedCorrelationsGetAsync (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get aggregated correlations
        /// </summary>
        /// <remarks>
        /// Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1AggregatedCorrelationsGetAsyncWithHttpInfo (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Store or Update a Correlation
        /// </summary>
        /// <remarks>
        /// Add correlation
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1AggregatedCorrelationsPostAsync (PostCorrelation body, string accessToken = null);

        /// <summary>
        /// Store or Update a Correlation
        /// </summary>
        /// <remarks>
        /// Add correlation
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1AggregatedCorrelationsPostAsyncWithHttpInfo (PostCorrelation body, string accessToken = null);
        /// <summary>
        /// Get correlations
        /// </summary>
        /// <remarks>
        /// Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        System.Threading.Tasks.Task<List<Correlation>> V1CorrelationsGetAsync (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get correlations
        /// </summary>
        /// <remarks>
        /// Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1CorrelationsGetAsyncWithHttpInfo (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        System.Threading.Tasks.Task<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsync (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null);

        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsyncWithHttpInfo (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null);
        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>Task of List&lt;CommonResponse&gt;</returns>
        System.Threading.Tasks.Task<List<CommonResponse>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsync (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null);

        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CommonResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CommonResponse>>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsyncWithHttpInfo (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null);
        /// <summary>
        /// Get average correlations for variables containing search term
        /// </summary>
        /// <remarks>
        /// Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        System.Threading.Tasks.Task<List<Correlation>> V1PublicCorrelationsSearchSearchGetAsync (string search, string effectOrCause, string accessToken = null);

        /// <summary>
        /// Get average correlations for variables containing search term
        /// </summary>
        /// <remarks>
        /// Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1PublicCorrelationsSearchSearchGetAsyncWithHttpInfo (string search, string effectOrCause, string accessToken = null);
        /// <summary>
        /// Search user correlations for a given effect
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given effect
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNameCausesGetAsync (string variableName);

        /// <summary>
        /// Search user correlations for a given effect
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user cause variables for a given effect
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1VariablesVariableNameCausesGetAsyncWithHttpInfo (string variableName);
        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user effect variables for a given cause
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNameEffectsGetAsync (string variableName, string accessToken = null);

        /// <summary>
        /// Search user correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all user effect variables for a given cause
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1VariablesVariableNameEffectsGetAsyncWithHttpInfo (string variableName, string accessToken = null);
        /// <summary>
        /// Search public correlations for a given effect
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all public cause variables for a given effect
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNamePublicCausesGetAsync (string variableName, string accessToken = null);

        /// <summary>
        /// Search public correlations for a given effect
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all public cause variables for a given effect
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1VariablesVariableNamePublicCausesGetAsyncWithHttpInfo (string variableName, string accessToken = null);
        /// <summary>
        /// Search public correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all public cause variables for a given cause
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNamePublicEffectsGetAsync (string variableName, string accessToken = null);

        /// <summary>
        /// Search public correlations for a given cause
        /// </summary>
        /// <remarks>
        /// Returns average of all correlations and votes for all public cause variables for a given cause
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1VariablesVariableNamePublicEffectsGetAsyncWithHttpInfo (string variableName, string accessToken = null);
        /// <summary>
        /// Delete vote
        /// </summary>
        /// <remarks>
        /// Delete previously posted vote
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1VotesDeletePostAsync (VoteDelete body, string accessToken = null);

        /// <summary>
        /// Delete vote
        /// </summary>
        /// <remarks>
        /// Delete previously posted vote
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1VotesDeletePostAsyncWithHttpInfo (VoteDelete body, string accessToken = null);
        /// <summary>
        /// Post or update vote
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1VotesPostAsync (PostVote body, string accessToken = null);

        /// <summary>
        /// Post or update vote
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1VotesPostAsyncWithHttpInfo (PostVote body, string accessToken = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CorrelationsApi : ICorrelationsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CorrelationsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CorrelationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CorrelationsApi(Configuration configuration = null)
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
        /// Get aggregated correlations Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        public List<Correlation> V1AggregatedCorrelationsGet (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = V1AggregatedCorrelationsGetWithHttpInfo(accessToken, effect, cause, correlationCoefficient, onsetDelay, durationOfAction, lastUpdated, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get aggregated correlations Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        public ApiResponse< List<Correlation> > V1AggregatedCorrelationsGetWithHttpInfo (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)
        {

            var localVarPath = "/v1/aggregatedCorrelations";
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
            if (effect != null) localVarQueryParams.Add("effect", Configuration.ApiClient.ParameterToString(effect)); // query parameter
            if (cause != null) localVarQueryParams.Add("cause", Configuration.ApiClient.ParameterToString(cause)); // query parameter
            if (correlationCoefficient != null) localVarQueryParams.Add("correlationCoefficient", Configuration.ApiClient.ParameterToString(correlationCoefficient)); // query parameter
            if (onsetDelay != null) localVarQueryParams.Add("onsetDelay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) localVarQueryParams.Add("durationOfAction", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (lastUpdated != null) localVarQueryParams.Add("lastUpdated", Configuration.ApiClient.ParameterToString(lastUpdated)); // query parameter
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
                Exception exception = ExceptionFactory("V1AggregatedCorrelationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Get aggregated correlations Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1AggregatedCorrelationsGetAsync (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = await V1AggregatedCorrelationsGetAsyncWithHttpInfo(accessToken, effect, cause, correlationCoefficient, onsetDelay, durationOfAction, lastUpdated, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get aggregated correlations Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1AggregatedCorrelationsGetAsyncWithHttpInfo (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)
        {

            var localVarPath = "/v1/aggregatedCorrelations";
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
            if (effect != null) localVarQueryParams.Add("effect", Configuration.ApiClient.ParameterToString(effect)); // query parameter
            if (cause != null) localVarQueryParams.Add("cause", Configuration.ApiClient.ParameterToString(cause)); // query parameter
            if (correlationCoefficient != null) localVarQueryParams.Add("correlationCoefficient", Configuration.ApiClient.ParameterToString(correlationCoefficient)); // query parameter
            if (onsetDelay != null) localVarQueryParams.Add("onsetDelay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) localVarQueryParams.Add("durationOfAction", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (lastUpdated != null) localVarQueryParams.Add("lastUpdated", Configuration.ApiClient.ParameterToString(lastUpdated)); // query parameter
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
                Exception exception = ExceptionFactory("V1AggregatedCorrelationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        public void V1AggregatedCorrelationsPost (PostCorrelation body, string accessToken = null)
        {
             V1AggregatedCorrelationsPostWithHttpInfo(body, accessToken);
        }

        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1AggregatedCorrelationsPostWithHttpInfo (PostCorrelation body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CorrelationsApi->V1AggregatedCorrelationsPost");

            var localVarPath = "/v1/aggregatedCorrelations";
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
                Exception exception = ExceptionFactory("V1AggregatedCorrelationsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1AggregatedCorrelationsPostAsync (PostCorrelation body, string accessToken = null)
        {
             await V1AggregatedCorrelationsPostAsyncWithHttpInfo(body, accessToken);

        }

        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1AggregatedCorrelationsPostAsyncWithHttpInfo (PostCorrelation body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CorrelationsApi->V1AggregatedCorrelationsPost");

            var localVarPath = "/v1/aggregatedCorrelations";
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
                Exception exception = ExceptionFactory("V1AggregatedCorrelationsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        public List<Correlation> V1CorrelationsGet (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = V1CorrelationsGetWithHttpInfo(accessToken, effect, cause, correlationCoefficient, onsetDelay, durationOfAction, lastUpdated, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        public ApiResponse< List<Correlation> > V1CorrelationsGetWithHttpInfo (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)
        {

            var localVarPath = "/v1/correlations";
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
            if (effect != null) localVarQueryParams.Add("effect", Configuration.ApiClient.ParameterToString(effect)); // query parameter
            if (cause != null) localVarQueryParams.Add("cause", Configuration.ApiClient.ParameterToString(cause)); // query parameter
            if (correlationCoefficient != null) localVarQueryParams.Add("correlationCoefficient", Configuration.ApiClient.ParameterToString(correlationCoefficient)); // query parameter
            if (onsetDelay != null) localVarQueryParams.Add("onsetDelay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) localVarQueryParams.Add("durationOfAction", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (lastUpdated != null) localVarQueryParams.Add("lastUpdated", Configuration.ApiClient.ParameterToString(lastUpdated)); // query parameter
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
                Exception exception = ExceptionFactory("V1CorrelationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1CorrelationsGetAsync (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = await V1CorrelationsGetAsyncWithHttpInfo(accessToken, effect, cause, correlationCoefficient, onsetDelay, durationOfAction, lastUpdated, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations (optional)</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations (optional)</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action (optional)</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed. (optional)</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings. (optional)</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1CorrelationsGetAsyncWithHttpInfo (string accessToken = null, string effect = null, string cause = null, string correlationCoefficient = null, string onsetDelay = null, string durationOfAction = null, string lastUpdated = null, int? limit = null, int? offset = null, int? sort = null)
        {

            var localVarPath = "/v1/correlations";
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
            if (effect != null) localVarQueryParams.Add("effect", Configuration.ApiClient.ParameterToString(effect)); // query parameter
            if (cause != null) localVarQueryParams.Add("cause", Configuration.ApiClient.ParameterToString(cause)); // query parameter
            if (correlationCoefficient != null) localVarQueryParams.Add("correlationCoefficient", Configuration.ApiClient.ParameterToString(correlationCoefficient)); // query parameter
            if (onsetDelay != null) localVarQueryParams.Add("onsetDelay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) localVarQueryParams.Add("durationOfAction", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (lastUpdated != null) localVarQueryParams.Add("lastUpdated", Configuration.ApiClient.ParameterToString(lastUpdated)); // query parameter
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
                Exception exception = ExceptionFactory("V1CorrelationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        public List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetWithHttpInfo(organizationId, userId, variableName, organizationToken, accessToken, includePublic);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        public ApiResponse< List<Correlation> > V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetWithHttpInfo (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null)
                throw new ApiException(400, "Missing required parameter 'organizationToken' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");

            var localVarPath = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes";
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
            if (organizationId != null) localVarPathParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (organizationToken != null) localVarQueryParams.Add("organization_token", Configuration.ApiClient.ParameterToString(organizationToken)); // query parameter
            if (includePublic != null) localVarQueryParams.Add("includePublic", Configuration.ApiClient.ParameterToString(includePublic)); // query parameter

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
                Exception exception = ExceptionFactory("V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsync (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = await V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsyncWithHttpInfo(organizationId, userId, variableName, organizationToken, accessToken, includePublic);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsyncWithHttpInfo (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null)
                throw new ApiException(400, "Missing required parameter 'organizationToken' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");

            var localVarPath = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes";
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
            if (organizationId != null) localVarPathParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (organizationToken != null) localVarQueryParams.Add("organization_token", Configuration.ApiClient.ParameterToString(organizationToken)); // query parameter
            if (includePublic != null) localVarQueryParams.Add("includePublic", Configuration.ApiClient.ParameterToString(includePublic)); // query parameter

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
                Exception exception = ExceptionFactory("V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>List&lt;CommonResponse&gt;</returns>
        public List<CommonResponse> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)
        {
             ApiResponse<List<CommonResponse>> localVarResponse = V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetWithHttpInfo(organizationId, userId, variableName, organizationToken, accessToken, includePublic);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>ApiResponse of List&lt;CommonResponse&gt;</returns>
        public ApiResponse< List<CommonResponse> > V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetWithHttpInfo (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null)
                throw new ApiException(400, "Missing required parameter 'organizationToken' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");

            var localVarPath = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects";
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
            if (organizationId != null) localVarPathParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (organizationToken != null) localVarQueryParams.Add("organization_token", Configuration.ApiClient.ParameterToString(organizationToken)); // query parameter
            if (includePublic != null) localVarQueryParams.Add("include_public", Configuration.ApiClient.ParameterToString(includePublic)); // query parameter

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
                Exception exception = ExceptionFactory("V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CommonResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CommonResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CommonResponse>)));
            
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>Task of List&lt;CommonResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<CommonResponse>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsync (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)
        {
             ApiResponse<List<CommonResponse>> localVarResponse = await V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsyncWithHttpInfo(organizationId, userId, variableName, organizationToken, accessToken, includePublic);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CommonResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CommonResponse>>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsyncWithHttpInfo (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken = null, string includePublic = null)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null)
                throw new ApiException(400, "Missing required parameter 'organizationToken' when calling CorrelationsApi->V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");

            var localVarPath = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects";
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
            if (organizationId != null) localVarPathParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (organizationToken != null) localVarQueryParams.Add("organization_token", Configuration.ApiClient.ParameterToString(organizationToken)); // query parameter
            if (includePublic != null) localVarQueryParams.Add("include_public", Configuration.ApiClient.ParameterToString(includePublic)); // query parameter

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
                Exception exception = ExceptionFactory("V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CommonResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CommonResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CommonResponse>)));
            
        }

        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        public List<Correlation> V1PublicCorrelationsSearchSearchGet (string search, string effectOrCause, string accessToken = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = V1PublicCorrelationsSearchSearchGetWithHttpInfo(search, effectOrCause, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        public ApiResponse< List<Correlation> > V1PublicCorrelationsSearchSearchGetWithHttpInfo (string search, string effectOrCause, string accessToken = null)
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling CorrelationsApi->V1PublicCorrelationsSearchSearchGet");
            // verify the required parameter 'effectOrCause' is set
            if (effectOrCause == null)
                throw new ApiException(400, "Missing required parameter 'effectOrCause' when calling CorrelationsApi->V1PublicCorrelationsSearchSearchGet");

            var localVarPath = "/v1/public/correlations/search/{search}";
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
            if (search != null) localVarPathParams.Add("search", Configuration.ApiClient.ParameterToString(search)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (effectOrCause != null) localVarQueryParams.Add("effectOrCause", Configuration.ApiClient.ParameterToString(effectOrCause)); // query parameter

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
                Exception exception = ExceptionFactory("V1PublicCorrelationsSearchSearchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1PublicCorrelationsSearchSearchGetAsync (string search, string effectOrCause, string accessToken = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = await V1PublicCorrelationsSearchSearchGetAsyncWithHttpInfo(search, effectOrCause, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1PublicCorrelationsSearchSearchGetAsyncWithHttpInfo (string search, string effectOrCause, string accessToken = null)
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling CorrelationsApi->V1PublicCorrelationsSearchSearchGet");
            // verify the required parameter 'effectOrCause' is set
            if (effectOrCause == null)
                throw new ApiException(400, "Missing required parameter 'effectOrCause' when calling CorrelationsApi->V1PublicCorrelationsSearchSearchGet");

            var localVarPath = "/v1/public/correlations/search/{search}";
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
            if (search != null) localVarPathParams.Add("search", Configuration.ApiClient.ParameterToString(search)); // path parameter
            if (accessToken != null) localVarQueryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (effectOrCause != null) localVarQueryParams.Add("effectOrCause", Configuration.ApiClient.ParameterToString(effectOrCause)); // query parameter

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
                Exception exception = ExceptionFactory("V1PublicCorrelationsSearchSearchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        public List<Correlation> V1VariablesVariableNameCausesGet (string variableName)
        {
             ApiResponse<List<Correlation>> localVarResponse = V1VariablesVariableNameCausesGetWithHttpInfo(variableName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        public ApiResponse< List<Correlation> > V1VariablesVariableNameCausesGetWithHttpInfo (string variableName)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1VariablesVariableNameCausesGet");

            var localVarPath = "/v1/variables/{variableName}/causes";
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
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter

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
                Exception exception = ExceptionFactory("V1VariablesVariableNameCausesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNameCausesGetAsync (string variableName)
        {
             ApiResponse<List<Correlation>> localVarResponse = await V1VariablesVariableNameCausesGetAsyncWithHttpInfo(variableName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1VariablesVariableNameCausesGetAsyncWithHttpInfo (string variableName)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1VariablesVariableNameCausesGet");

            var localVarPath = "/v1/variables/{variableName}/causes";
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
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter

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
                Exception exception = ExceptionFactory("V1VariablesVariableNameCausesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        public List<Correlation> V1VariablesVariableNameEffectsGet (string variableName, string accessToken = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = V1VariablesVariableNameEffectsGetWithHttpInfo(variableName, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        public ApiResponse< List<Correlation> > V1VariablesVariableNameEffectsGetWithHttpInfo (string variableName, string accessToken = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1VariablesVariableNameEffectsGet");

            var localVarPath = "/v1/variables/{variableName}/effects";
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
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
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
                Exception exception = ExceptionFactory("V1VariablesVariableNameEffectsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNameEffectsGetAsync (string variableName, string accessToken = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = await V1VariablesVariableNameEffectsGetAsyncWithHttpInfo(variableName, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1VariablesVariableNameEffectsGetAsyncWithHttpInfo (string variableName, string accessToken = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1VariablesVariableNameEffectsGet");

            var localVarPath = "/v1/variables/{variableName}/effects";
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
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
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
                Exception exception = ExceptionFactory("V1VariablesVariableNameEffectsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        public List<Correlation> V1VariablesVariableNamePublicCausesGet (string variableName, string accessToken = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = V1VariablesVariableNamePublicCausesGetWithHttpInfo(variableName, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        public ApiResponse< List<Correlation> > V1VariablesVariableNamePublicCausesGetWithHttpInfo (string variableName, string accessToken = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1VariablesVariableNamePublicCausesGet");

            var localVarPath = "/v1/variables/{variableName}/public/causes";
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
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
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
                Exception exception = ExceptionFactory("V1VariablesVariableNamePublicCausesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNamePublicCausesGetAsync (string variableName, string accessToken = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = await V1VariablesVariableNamePublicCausesGetAsyncWithHttpInfo(variableName, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1VariablesVariableNamePublicCausesGetAsyncWithHttpInfo (string variableName, string accessToken = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1VariablesVariableNamePublicCausesGet");

            var localVarPath = "/v1/variables/{variableName}/public/causes";
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
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
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
                Exception exception = ExceptionFactory("V1VariablesVariableNamePublicCausesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        public List<Correlation> V1VariablesVariableNamePublicEffectsGet (string variableName, string accessToken = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = V1VariablesVariableNamePublicEffectsGetWithHttpInfo(variableName, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of List&lt;Correlation&gt;</returns>
        public ApiResponse< List<Correlation> > V1VariablesVariableNamePublicEffectsGetWithHttpInfo (string variableName, string accessToken = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1VariablesVariableNamePublicEffectsGet");

            var localVarPath = "/v1/variables/{variableName}/public/effects";
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
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
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
                Exception exception = ExceptionFactory("V1VariablesVariableNamePublicEffectsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of List&lt;Correlation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNamePublicEffectsGetAsync (string variableName, string accessToken = null)
        {
             ApiResponse<List<Correlation>> localVarResponse = await V1VariablesVariableNamePublicEffectsGetAsyncWithHttpInfo(variableName, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Correlation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Correlation>>> V1VariablesVariableNamePublicEffectsGetAsyncWithHttpInfo (string variableName, string accessToken = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling CorrelationsApi->V1VariablesVariableNamePublicEffectsGet");

            var localVarPath = "/v1/variables/{variableName}/public/effects";
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
            if (variableName != null) localVarPathParams.Add("variableName", Configuration.ApiClient.ParameterToString(variableName)); // path parameter
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
                Exception exception = ExceptionFactory("V1VariablesVariableNamePublicEffectsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Correlation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Correlation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Correlation>)));
            
        }

        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        public CommonResponse V1VotesDeletePost (VoteDelete body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = V1VotesDeletePostWithHttpInfo(body, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        public ApiResponse< CommonResponse > V1VotesDeletePostWithHttpInfo (VoteDelete body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CorrelationsApi->V1VotesDeletePost");

            var localVarPath = "/v1/votes/delete";
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
                Exception exception = ExceptionFactory("V1VotesDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1VotesDeletePostAsync (VoteDelete body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = await V1VotesDeletePostAsyncWithHttpInfo(body, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1VotesDeletePostAsyncWithHttpInfo (VoteDelete body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CorrelationsApi->V1VotesDeletePost");

            var localVarPath = "/v1/votes/delete";
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
                Exception exception = ExceptionFactory("V1VotesDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>CommonResponse</returns>
        public CommonResponse V1VotesPost (PostVote body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = V1VotesPostWithHttpInfo(body, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of CommonResponse</returns>
        public ApiResponse< CommonResponse > V1VotesPostWithHttpInfo (PostVote body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CorrelationsApi->V1VotesPost");

            var localVarPath = "/v1/votes";
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
                Exception exception = ExceptionFactory("V1VotesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1VotesPostAsync (PostVote body, string accessToken = null)
        {
             ApiResponse<CommonResponse> localVarResponse = await V1VotesPostAsyncWithHttpInfo(body, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (CommonResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommonResponse>> V1VotesPostAsyncWithHttpInfo (PostVote body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CorrelationsApi->V1VotesPost");

            var localVarPath = "/v1/votes";
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
                Exception exception = ExceptionFactory("V1VotesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CommonResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonResponse)));
            
        }

    }
}
