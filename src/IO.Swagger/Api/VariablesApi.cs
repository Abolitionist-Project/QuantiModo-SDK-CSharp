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
    public interface IVariablesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get public variables
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Variable</returns>
        Variable V1PublicVariablesGet ();

        /// <summary>
        /// Get public variables
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Variable</returns>
        ApiResponse<Variable> V1PublicVariablesGetWithHttpInfo ();
        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations
        /// </summary>
        /// <remarks>
        /// Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Variable</returns>
        Variable V1PublicVariablesSearchSearchGet (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations
        /// </summary>
        /// <remarks>
        /// Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of Variable</returns>
        ApiResponse<Variable> V1PublicVariablesSearchSearchGetWithHttpInfo (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Update User Settings for a Variable
        /// </summary>
        /// <remarks>
        /// Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userVariables">Variable user settings data</param>
        /// <returns></returns>
        void V1UserVariablesPost (UserVariables userVariables);

        /// <summary>
        /// Update User Settings for a Variable
        /// </summary>
        /// <remarks>
        /// Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userVariables">Variable user settings data</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1UserVariablesPostWithHttpInfo (UserVariables userVariables);
        /// <summary>
        /// Variable categories
        /// </summary>
        /// <remarks>
        /// The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;VariableCategory&gt;</returns>
        List<VariableCategory> V1VariableCategoriesGet ();

        /// <summary>
        /// Variable categories
        /// </summary>
        /// <remarks>
        /// The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;VariableCategory&gt;</returns>
        ApiResponse<List<VariableCategory>> V1VariableCategoriesGetWithHttpInfo ();
        /// <summary>
        /// Get variables by the category name
        /// </summary>
        /// <remarks>
        /// Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Common variable id (optional)</param>
        /// <param name="userId">User id (optional)</param>
        /// <param name="category">Filter data by category (optional)</param>
        /// <param name="name">Original name of the variable (supports exact name match only) (optional)</param>
        /// <param name="lastUpdated">Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="source">The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional)</param>
        /// <param name="latestMeasurementTime">Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="numberOfMeasurements">Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional)</param>
        /// <param name="lastSource">Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Variable</returns>
        Variable V1VariablesGet (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get variables by the category name
        /// </summary>
        /// <remarks>
        /// Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Common variable id (optional)</param>
        /// <param name="userId">User id (optional)</param>
        /// <param name="category">Filter data by category (optional)</param>
        /// <param name="name">Original name of the variable (supports exact name match only) (optional)</param>
        /// <param name="lastUpdated">Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="source">The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional)</param>
        /// <param name="latestMeasurementTime">Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="numberOfMeasurements">Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional)</param>
        /// <param name="lastSource">Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of Variable</returns>
        ApiResponse<Variable> V1VariablesGetWithHttpInfo (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Create Variables
        /// </summary>
        /// <remarks>
        /// Allows the client to create a new variable in the &#x60;variables&#x60; table.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Original name for the variable.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        void V1VariablesPost (VariablesNew body, string accessToken = null);

        /// <summary>
        /// Create Variables
        /// </summary>
        /// <remarks>
        /// Allows the client to create a new variable in the &#x60;variables&#x60; table.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Original name for the variable.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1VariablesPostWithHttpInfo (VariablesNew body, string accessToken = null);
        /// <summary>
        /// Get variables by search query
        /// </summary>
        /// <remarks>
        /// Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="includePublic">Set to true if you would like to include public variables when no user variables are found. (optional)</param>
        /// <param name="manualTracking">Set to true if you would like to exlude variables like apps and website names. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <returns>List&lt;Variable&gt;</returns>
        List<Variable> V1VariablesSearchSearchGet (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null);

        /// <summary>
        /// Get variables by search query
        /// </summary>
        /// <remarks>
        /// Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="includePublic">Set to true if you would like to include public variables when no user variables are found. (optional)</param>
        /// <param name="manualTracking">Set to true if you would like to exlude variables like apps and website names. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <returns>ApiResponse of List&lt;Variable&gt;</returns>
        ApiResponse<List<Variable>> V1VariablesSearchSearchGetWithHttpInfo (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null);
        /// <summary>
        /// Get info about a variable
        /// </summary>
        /// <remarks>
        /// Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Variable</returns>
        Variable V1VariablesVariableNameGet (string variableName, string accessToken = null);

        /// <summary>
        /// Get info about a variable
        /// </summary>
        /// <remarks>
        /// Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Variable</returns>
        ApiResponse<Variable> V1VariablesVariableNameGetWithHttpInfo (string variableName, string accessToken = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get public variables
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Variable</returns>
        System.Threading.Tasks.Task<Variable> V1PublicVariablesGetAsync ();

        /// <summary>
        /// Get public variables
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Variable)</returns>
        System.Threading.Tasks.Task<ApiResponse<Variable>> V1PublicVariablesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations
        /// </summary>
        /// <remarks>
        /// Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of Variable</returns>
        System.Threading.Tasks.Task<Variable> V1PublicVariablesSearchSearchGetAsync (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations
        /// </summary>
        /// <remarks>
        /// Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (Variable)</returns>
        System.Threading.Tasks.Task<ApiResponse<Variable>> V1PublicVariablesSearchSearchGetAsyncWithHttpInfo (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Update User Settings for a Variable
        /// </summary>
        /// <remarks>
        /// Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userVariables">Variable user settings data</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1UserVariablesPostAsync (UserVariables userVariables);

        /// <summary>
        /// Update User Settings for a Variable
        /// </summary>
        /// <remarks>
        /// Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userVariables">Variable user settings data</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1UserVariablesPostAsyncWithHttpInfo (UserVariables userVariables);
        /// <summary>
        /// Variable categories
        /// </summary>
        /// <remarks>
        /// The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;VariableCategory&gt;</returns>
        System.Threading.Tasks.Task<List<VariableCategory>> V1VariableCategoriesGetAsync ();

        /// <summary>
        /// Variable categories
        /// </summary>
        /// <remarks>
        /// The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;VariableCategory&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<VariableCategory>>> V1VariableCategoriesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get variables by the category name
        /// </summary>
        /// <remarks>
        /// Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Common variable id (optional)</param>
        /// <param name="userId">User id (optional)</param>
        /// <param name="category">Filter data by category (optional)</param>
        /// <param name="name">Original name of the variable (supports exact name match only) (optional)</param>
        /// <param name="lastUpdated">Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="source">The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional)</param>
        /// <param name="latestMeasurementTime">Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="numberOfMeasurements">Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional)</param>
        /// <param name="lastSource">Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of Variable</returns>
        System.Threading.Tasks.Task<Variable> V1VariablesGetAsync (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null);

        /// <summary>
        /// Get variables by the category name
        /// </summary>
        /// <remarks>
        /// Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Common variable id (optional)</param>
        /// <param name="userId">User id (optional)</param>
        /// <param name="category">Filter data by category (optional)</param>
        /// <param name="name">Original name of the variable (supports exact name match only) (optional)</param>
        /// <param name="lastUpdated">Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="source">The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional)</param>
        /// <param name="latestMeasurementTime">Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="numberOfMeasurements">Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional)</param>
        /// <param name="lastSource">Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (Variable)</returns>
        System.Threading.Tasks.Task<ApiResponse<Variable>> V1VariablesGetAsyncWithHttpInfo (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null);
        /// <summary>
        /// Create Variables
        /// </summary>
        /// <remarks>
        /// Allows the client to create a new variable in the &#x60;variables&#x60; table.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Original name for the variable.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1VariablesPostAsync (VariablesNew body, string accessToken = null);

        /// <summary>
        /// Create Variables
        /// </summary>
        /// <remarks>
        /// Allows the client to create a new variable in the &#x60;variables&#x60; table.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Original name for the variable.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1VariablesPostAsyncWithHttpInfo (VariablesNew body, string accessToken = null);
        /// <summary>
        /// Get variables by search query
        /// </summary>
        /// <remarks>
        /// Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="includePublic">Set to true if you would like to include public variables when no user variables are found. (optional)</param>
        /// <param name="manualTracking">Set to true if you would like to exlude variables like apps and website names. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <returns>Task of List&lt;Variable&gt;</returns>
        System.Threading.Tasks.Task<List<Variable>> V1VariablesSearchSearchGetAsync (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null);

        /// <summary>
        /// Get variables by search query
        /// </summary>
        /// <remarks>
        /// Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="includePublic">Set to true if you would like to include public variables when no user variables are found. (optional)</param>
        /// <param name="manualTracking">Set to true if you would like to exlude variables like apps and website names. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Variable&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Variable>>> V1VariablesSearchSearchGetAsyncWithHttpInfo (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null);
        /// <summary>
        /// Get info about a variable
        /// </summary>
        /// <remarks>
        /// Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of Variable</returns>
        System.Threading.Tasks.Task<Variable> V1VariablesVariableNameGetAsync (string variableName, string accessToken = null);

        /// <summary>
        /// Get info about a variable
        /// </summary>
        /// <remarks>
        /// Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (Variable)</returns>
        System.Threading.Tasks.Task<ApiResponse<Variable>> V1VariablesVariableNameGetAsyncWithHttpInfo (string variableName, string accessToken = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VariablesApi : IVariablesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VariablesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariablesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="VariablesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VariablesApi(Configuration configuration = null)
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
        /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Variable</returns>
        public Variable V1PublicVariablesGet ()
        {
             ApiResponse<Variable> localVarResponse = V1PublicVariablesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Variable</returns>
        public ApiResponse< Variable > V1PublicVariablesGetWithHttpInfo ()
        {

            var localVarPath = "/v1/public/variables";
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
                Exception exception = ExceptionFactory("V1PublicVariablesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Variable>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Variable) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Variable)));
            
        }

        /// <summary>
        /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Variable</returns>
        public async System.Threading.Tasks.Task<Variable> V1PublicVariablesGetAsync ()
        {
             ApiResponse<Variable> localVarResponse = await V1PublicVariablesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Variable)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Variable>> V1PublicVariablesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/public/variables";
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
                Exception exception = ExceptionFactory("V1PublicVariablesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Variable>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Variable) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Variable)));
            
        }

        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Variable</returns>
        public Variable V1PublicVariablesSearchSearchGet (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<Variable> localVarResponse = V1PublicVariablesSearchSearchGetWithHttpInfo(search, accessToken, categoryName, source, effectOrCause, publicEffectOrCause, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of Variable</returns>
        public ApiResponse< Variable > V1PublicVariablesSearchSearchGetWithHttpInfo (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null)
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling VariablesApi->V1PublicVariablesSearchSearchGet");

            var localVarPath = "/v1/public/variables/search/{search}";
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
            if (categoryName != null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName)); // query parameter
            if (source != null) localVarQueryParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // query parameter
            if (effectOrCause != null) localVarQueryParams.Add("effectOrCause", Configuration.ApiClient.ParameterToString(effectOrCause)); // query parameter
            if (publicEffectOrCause != null) localVarQueryParams.Add("publicEffectOrCause", Configuration.ApiClient.ParameterToString(publicEffectOrCause)); // query parameter
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
                Exception exception = ExceptionFactory("V1PublicVariablesSearchSearchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Variable>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Variable) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Variable)));
            
        }

        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of Variable</returns>
        public async System.Threading.Tasks.Task<Variable> V1PublicVariablesSearchSearchGetAsync (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<Variable> localVarResponse = await V1PublicVariablesSearchSearchGetAsyncWithHttpInfo(search, accessToken, categoryName, source, effectOrCause, publicEffectOrCause, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (Variable)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Variable>> V1PublicVariablesSearchSearchGetAsyncWithHttpInfo (string search, string accessToken = null, string categoryName = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null, int? sort = null)
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling VariablesApi->V1PublicVariablesSearchSearchGet");

            var localVarPath = "/v1/public/variables/search/{search}";
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
            if (categoryName != null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName)); // query parameter
            if (source != null) localVarQueryParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // query parameter
            if (effectOrCause != null) localVarQueryParams.Add("effectOrCause", Configuration.ApiClient.ParameterToString(effectOrCause)); // query parameter
            if (publicEffectOrCause != null) localVarQueryParams.Add("publicEffectOrCause", Configuration.ApiClient.ParameterToString(publicEffectOrCause)); // query parameter
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
                Exception exception = ExceptionFactory("V1PublicVariablesSearchSearchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Variable>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Variable) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Variable)));
            
        }

        /// <summary>
        /// Update User Settings for a Variable Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userVariables">Variable user settings data</param>
        /// <returns></returns>
        public void V1UserVariablesPost (UserVariables userVariables)
        {
             V1UserVariablesPostWithHttpInfo(userVariables);
        }

        /// <summary>
        /// Update User Settings for a Variable Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userVariables">Variable user settings data</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1UserVariablesPostWithHttpInfo (UserVariables userVariables)
        {
            // verify the required parameter 'userVariables' is set
            if (userVariables == null)
                throw new ApiException(400, "Missing required parameter 'userVariables' when calling VariablesApi->V1UserVariablesPost");

            var localVarPath = "/v1/userVariables";
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
            if (userVariables != null && userVariables.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(userVariables); // http body (model) parameter
            }
            else
            {
                localVarPostBody = userVariables; // byte array
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
                Exception exception = ExceptionFactory("V1UserVariablesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update User Settings for a Variable Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userVariables">Variable user settings data</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1UserVariablesPostAsync (UserVariables userVariables)
        {
             await V1UserVariablesPostAsyncWithHttpInfo(userVariables);

        }

        /// <summary>
        /// Update User Settings for a Variable Users can change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userVariables">Variable user settings data</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1UserVariablesPostAsyncWithHttpInfo (UserVariables userVariables)
        {
            // verify the required parameter 'userVariables' is set
            if (userVariables == null)
                throw new ApiException(400, "Missing required parameter 'userVariables' when calling VariablesApi->V1UserVariablesPost");

            var localVarPath = "/v1/userVariables";
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
            if (userVariables != null && userVariables.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(userVariables); // http body (model) parameter
            }
            else
            {
                localVarPostBody = userVariables; // byte array
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
                Exception exception = ExceptionFactory("V1UserVariablesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;VariableCategory&gt;</returns>
        public List<VariableCategory> V1VariableCategoriesGet ()
        {
             ApiResponse<List<VariableCategory>> localVarResponse = V1VariableCategoriesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;VariableCategory&gt;</returns>
        public ApiResponse< List<VariableCategory> > V1VariableCategoriesGetWithHttpInfo ()
        {

            var localVarPath = "/v1/variableCategories";
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
                Exception exception = ExceptionFactory("V1VariableCategoriesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<VariableCategory>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VariableCategory>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<VariableCategory>)));
            
        }

        /// <summary>
        /// Variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;VariableCategory&gt;</returns>
        public async System.Threading.Tasks.Task<List<VariableCategory>> V1VariableCategoriesGetAsync ()
        {
             ApiResponse<List<VariableCategory>> localVarResponse = await V1VariableCategoriesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;VariableCategory&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<VariableCategory>>> V1VariableCategoriesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/variableCategories";
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
                Exception exception = ExceptionFactory("V1VariableCategoriesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<VariableCategory>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VariableCategory>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<VariableCategory>)));
            
        }

        /// <summary>
        /// Get variables by the category name Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Common variable id (optional)</param>
        /// <param name="userId">User id (optional)</param>
        /// <param name="category">Filter data by category (optional)</param>
        /// <param name="name">Original name of the variable (supports exact name match only) (optional)</param>
        /// <param name="lastUpdated">Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="source">The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional)</param>
        /// <param name="latestMeasurementTime">Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="numberOfMeasurements">Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional)</param>
        /// <param name="lastSource">Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Variable</returns>
        public Variable V1VariablesGet (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<Variable> localVarResponse = V1VariablesGetWithHttpInfo(accessToken, id, userId, category, name, lastUpdated, source, latestMeasurementTime, numberOfMeasurements, lastSource, limit, offset, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get variables by the category name Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Common variable id (optional)</param>
        /// <param name="userId">User id (optional)</param>
        /// <param name="category">Filter data by category (optional)</param>
        /// <param name="name">Original name of the variable (supports exact name match only) (optional)</param>
        /// <param name="lastUpdated">Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="source">The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional)</param>
        /// <param name="latestMeasurementTime">Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="numberOfMeasurements">Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional)</param>
        /// <param name="lastSource">Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>ApiResponse of Variable</returns>
        public ApiResponse< Variable > V1VariablesGetWithHttpInfo (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null)
        {

            var localVarPath = "/v1/variables";
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
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (category != null) localVarQueryParams.Add("category", Configuration.ApiClient.ParameterToString(category)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (lastUpdated != null) localVarQueryParams.Add("lastUpdated", Configuration.ApiClient.ParameterToString(lastUpdated)); // query parameter
            if (source != null) localVarQueryParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // query parameter
            if (latestMeasurementTime != null) localVarQueryParams.Add("latestMeasurementTime", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (numberOfMeasurements != null) localVarQueryParams.Add("numberOfMeasurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (lastSource != null) localVarQueryParams.Add("lastSource", Configuration.ApiClient.ParameterToString(lastSource)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1VariablesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Variable>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Variable) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Variable)));
            
        }

        /// <summary>
        /// Get variables by the category name Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Common variable id (optional)</param>
        /// <param name="userId">User id (optional)</param>
        /// <param name="category">Filter data by category (optional)</param>
        /// <param name="name">Original name of the variable (supports exact name match only) (optional)</param>
        /// <param name="lastUpdated">Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="source">The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional)</param>
        /// <param name="latestMeasurementTime">Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="numberOfMeasurements">Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional)</param>
        /// <param name="lastSource">Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of Variable</returns>
        public async System.Threading.Tasks.Task<Variable> V1VariablesGetAsync (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null)
        {
             ApiResponse<Variable> localVarResponse = await V1VariablesGetAsyncWithHttpInfo(accessToken, id, userId, category, name, lastUpdated, source, latestMeasurementTime, numberOfMeasurements, lastSource, limit, offset, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get variables by the category name Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="id">Common variable id (optional)</param>
        /// <param name="userId">User id (optional)</param>
        /// <param name="category">Filter data by category (optional)</param>
        /// <param name="name">Original name of the variable (supports exact name match only) (optional)</param>
        /// <param name="lastUpdated">Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="source">The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here (optional)</param>
        /// <param name="latestMeasurementTime">Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot; (optional)</param>
        /// <param name="numberOfMeasurements">Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity. (optional)</param>
        /// <param name="lastSource">Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only) (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order. (optional)</param>
        /// <returns>Task of ApiResponse (Variable)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Variable>> V1VariablesGetAsyncWithHttpInfo (string accessToken = null, int? id = null, int? userId = null, string category = null, string name = null, string lastUpdated = null, string source = null, string latestMeasurementTime = null, string numberOfMeasurements = null, string lastSource = null, int? limit = null, int? offset = null, int? sort = null)
        {

            var localVarPath = "/v1/variables";
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
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (category != null) localVarQueryParams.Add("category", Configuration.ApiClient.ParameterToString(category)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (lastUpdated != null) localVarQueryParams.Add("lastUpdated", Configuration.ApiClient.ParameterToString(lastUpdated)); // query parameter
            if (source != null) localVarQueryParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // query parameter
            if (latestMeasurementTime != null) localVarQueryParams.Add("latestMeasurementTime", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (numberOfMeasurements != null) localVarQueryParams.Add("numberOfMeasurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (lastSource != null) localVarQueryParams.Add("lastSource", Configuration.ApiClient.ParameterToString(lastSource)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1VariablesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Variable>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Variable) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Variable)));
            
        }

        /// <summary>
        /// Create Variables Allows the client to create a new variable in the &#x60;variables&#x60; table.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Original name for the variable.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns></returns>
        public void V1VariablesPost (VariablesNew body, string accessToken = null)
        {
             V1VariablesPostWithHttpInfo(body, accessToken);
        }

        /// <summary>
        /// Create Variables Allows the client to create a new variable in the &#x60;variables&#x60; table.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Original name for the variable.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1VariablesPostWithHttpInfo (VariablesNew body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VariablesApi->V1VariablesPost");

            var localVarPath = "/v1/variables";
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
                Exception exception = ExceptionFactory("V1VariablesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create Variables Allows the client to create a new variable in the &#x60;variables&#x60; table.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Original name for the variable.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1VariablesPostAsync (VariablesNew body, string accessToken = null)
        {
             await V1VariablesPostAsyncWithHttpInfo(body, accessToken);

        }

        /// <summary>
        /// Create Variables Allows the client to create a new variable in the &#x60;variables&#x60; table.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Original name for the variable.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1VariablesPostAsyncWithHttpInfo (VariablesNew body, string accessToken = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VariablesApi->V1VariablesPost");

            var localVarPath = "/v1/variables";
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
                Exception exception = ExceptionFactory("V1VariablesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="includePublic">Set to true if you would like to include public variables when no user variables are found. (optional)</param>
        /// <param name="manualTracking">Set to true if you would like to exlude variables like apps and website names. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <returns>List&lt;Variable&gt;</returns>
        public List<Variable> V1VariablesSearchSearchGet (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null)
        {
             ApiResponse<List<Variable>> localVarResponse = V1VariablesSearchSearchGetWithHttpInfo(search, accessToken, categoryName, includePublic, manualTracking, source, effectOrCause, publicEffectOrCause, limit, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="includePublic">Set to true if you would like to include public variables when no user variables are found. (optional)</param>
        /// <param name="manualTracking">Set to true if you would like to exlude variables like apps and website names. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <returns>ApiResponse of List&lt;Variable&gt;</returns>
        public ApiResponse< List<Variable> > V1VariablesSearchSearchGetWithHttpInfo (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null)
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling VariablesApi->V1VariablesSearchSearchGet");

            var localVarPath = "/v1/variables/search/{search}";
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
            if (categoryName != null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName)); // query parameter
            if (includePublic != null) localVarQueryParams.Add("includePublic", Configuration.ApiClient.ParameterToString(includePublic)); // query parameter
            if (manualTracking != null) localVarQueryParams.Add("manualTracking", Configuration.ApiClient.ParameterToString(manualTracking)); // query parameter
            if (source != null) localVarQueryParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // query parameter
            if (effectOrCause != null) localVarQueryParams.Add("effectOrCause", Configuration.ApiClient.ParameterToString(effectOrCause)); // query parameter
            if (publicEffectOrCause != null) localVarQueryParams.Add("publicEffectOrCause", Configuration.ApiClient.ParameterToString(publicEffectOrCause)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter

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
                Exception exception = ExceptionFactory("V1VariablesSearchSearchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Variable>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Variable>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Variable>)));
            
        }

        /// <summary>
        /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="includePublic">Set to true if you would like to include public variables when no user variables are found. (optional)</param>
        /// <param name="manualTracking">Set to true if you would like to exlude variables like apps and website names. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <returns>Task of List&lt;Variable&gt;</returns>
        public async System.Threading.Tasks.Task<List<Variable>> V1VariablesSearchSearchGetAsync (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null)
        {
             ApiResponse<List<Variable>> localVarResponse = await V1VariablesSearchSearchGetAsyncWithHttpInfo(search, accessToken, categoryName, includePublic, manualTracking, source, effectOrCause, publicEffectOrCause, limit, offset);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work. (optional)</param>
        /// <param name="includePublic">Set to true if you would like to include public variables when no user variables are found. (optional)</param>
        /// <param name="manualTracking">Set to true if you would like to exlude variables like apps and website names. (optional)</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source. (optional)</param>
        /// <param name="effectOrCause">Indicate if you only want variables that have user correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="publicEffectOrCause">Indicate if you only want variables that have aggregated correlations.  Possible values are effect and cause. (optional)</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. (optional)</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Variable&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Variable>>> V1VariablesSearchSearchGetAsyncWithHttpInfo (string search, string accessToken = null, string categoryName = null, bool? includePublic = null, bool? manualTracking = null, string source = null, string effectOrCause = null, string publicEffectOrCause = null, int? limit = null, int? offset = null)
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling VariablesApi->V1VariablesSearchSearchGet");

            var localVarPath = "/v1/variables/search/{search}";
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
            if (categoryName != null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName)); // query parameter
            if (includePublic != null) localVarQueryParams.Add("includePublic", Configuration.ApiClient.ParameterToString(includePublic)); // query parameter
            if (manualTracking != null) localVarQueryParams.Add("manualTracking", Configuration.ApiClient.ParameterToString(manualTracking)); // query parameter
            if (source != null) localVarQueryParams.Add("source", Configuration.ApiClient.ParameterToString(source)); // query parameter
            if (effectOrCause != null) localVarQueryParams.Add("effectOrCause", Configuration.ApiClient.ParameterToString(effectOrCause)); // query parameter
            if (publicEffectOrCause != null) localVarQueryParams.Add("publicEffectOrCause", Configuration.ApiClient.ParameterToString(publicEffectOrCause)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter

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
                Exception exception = ExceptionFactory("V1VariablesSearchSearchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Variable>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Variable>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Variable>)));
            
        }

        /// <summary>
        /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Variable</returns>
        public Variable V1VariablesVariableNameGet (string variableName, string accessToken = null)
        {
             ApiResponse<Variable> localVarResponse = V1VariablesVariableNameGetWithHttpInfo(variableName, accessToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>ApiResponse of Variable</returns>
        public ApiResponse< Variable > V1VariablesVariableNameGetWithHttpInfo (string variableName, string accessToken = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling VariablesApi->V1VariablesVariableNameGet");

            var localVarPath = "/v1/variables/{variableName}";
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
                Exception exception = ExceptionFactory("V1VariablesVariableNameGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Variable>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Variable) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Variable)));
            
        }

        /// <summary>
        /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of Variable</returns>
        public async System.Threading.Tasks.Task<Variable> V1VariablesVariableNameGetAsync (string variableName, string accessToken = null)
        {
             ApiResponse<Variable> localVarResponse = await V1VariablesVariableNameGetAsyncWithHttpInfo(variableName, accessToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="variableName">Variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token (optional)</param>
        /// <returns>Task of ApiResponse (Variable)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Variable>> V1VariablesVariableNameGetAsyncWithHttpInfo (string variableName, string accessToken = null)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null)
                throw new ApiException(400, "Missing required parameter 'variableName' when calling VariablesApi->V1VariablesVariableNameGet");

            var localVarPath = "/v1/variables/{variableName}";
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
                Exception exception = ExceptionFactory("V1VariablesVariableNameGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Variable>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Variable) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Variable)));
            
        }

    }
}
