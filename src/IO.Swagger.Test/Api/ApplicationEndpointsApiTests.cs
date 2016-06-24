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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ApplicationEndpointsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ApplicationEndpointsApiTests
    {
        private ApplicationEndpointsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ApplicationEndpointsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApplicationEndpointsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' ApplicationEndpointsApi
            Assert.IsInstanceOfType(typeof(ApplicationEndpointsApi), instance, "instance is a ApplicationEndpointsApi");
        }

        
        /// <summary>
        /// Test V2ApplicationConnectionsGet
        /// </summary>
        [Test]
        public void V2ApplicationConnectionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //int? connectorId = null;
            //string connectStatus = null;
            //string connectError = null;
            //string updateRequestedAt = null;
            //string updateStatus = null;
            //string updateError = null;
            //string lastSuccessfulUpdatedAt = null;
            //string createdAt = null;
            //string updatedAt = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationConnectionsGet(accessToken, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test V2ApplicationCredentialsGet
        /// </summary>
        [Test]
        public void V2ApplicationCredentialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //int? connectorId = null;
            //string attrKey = null;
            //string attrValue = null;
            //string createdAt = null;
            //string updatedAt = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationCredentialsGet(accessToken, connectorId, attrKey, attrValue, createdAt, updatedAt, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse2004> (response, "response is InlineResponse2004");
        }
        
        /// <summary>
        /// Test V2ApplicationMeasurementsGet
        /// </summary>
        [Test]
        public void V2ApplicationMeasurementsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //string clientId = null;
            //int? connectorId = null;
            //int? variableId = null;
            //int? sourceId = null;
            //string startTime = null;
            //decimal? value = null;
            //int? unitId = null;
            //decimal? originalValue = null;
            //int? originalUnitId = null;
            //int? duration = null;
            //string note = null;
            //decimal? latitude = null;
            //decimal? longitude = null;
            //string location = null;
            //string createdAt = null;
            //string updatedAt = null;
            //string error = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationMeasurementsGet(accessToken, clientId, connectorId, variableId, sourceId, startTime, value, unitId, originalValue, originalUnitId, duration, note, latitude, longitude, location, createdAt, updatedAt, error, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse2005> (response, "response is InlineResponse2005");
        }
        
        /// <summary>
        /// Test V2ApplicationTrackingRemindersGet
        /// </summary>
        [Test]
        public void V2ApplicationTrackingRemindersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //string clientId = null;
            //string createdAt = null;
            //string updatedAt = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationTrackingRemindersGet(accessToken, clientId, createdAt, updatedAt, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test V2ApplicationUpdatesGet
        /// </summary>
        [Test]
        public void V2ApplicationUpdatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //int? connectorId = null;
            //int? numberOfMeasurements = null;
            //bool? success = null;
            //string message = null;
            //string createdAt = null;
            //string updatedAt = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationUpdatesGet(accessToken, connectorId, numberOfMeasurements, success, message, createdAt, updatedAt, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse2006> (response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test V2ApplicationUserVariableRelationshipsGet
        /// </summary>
        [Test]
        public void V2ApplicationUserVariableRelationshipsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //int? id = null;
            //string confidenceLevel = null;
            //decimal? confidenceScore = null;
            //string direction = null;
            //int? durationOfAction = null;
            //string errorMessage = null;
            //int? onsetDelay = null;
            //int? outcomeVariableId = null;
            //int? predictorVariableId = null;
            //int? predictorUnitId = null;
            //decimal? sinnRank = null;
            //string strengthLevel = null;
            //decimal? strengthScore = null;
            //string vote = null;
            //decimal? valuePredictingHighOutcome = null;
            //decimal? valuePredictingLowOutcome = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationUserVariableRelationshipsGet(accessToken, id, confidenceLevel, confidenceScore, direction, durationOfAction, errorMessage, onsetDelay, outcomeVariableId, predictorVariableId, predictorUnitId, sinnRank, strengthLevel, strengthScore, vote, valuePredictingHighOutcome, valuePredictingLowOutcome, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test V2ApplicationUserVariablesGet
        /// </summary>
        [Test]
        public void V2ApplicationUserVariablesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //string clientId = null;
            //int? parentId = null;
            //int? variableId = null;
            //int? defaultUnitId = null;
            //decimal? minimumAllowedValue = null;
            //decimal? maximumAllowedValue = null;
            //decimal? fillingValue = null;
            //int? joinWith = null;
            //int? onsetDelay = null;
            //int? durationOfAction = null;
            //int? variableCategoryId = null;
            //int? updated = null;
            //int? _public = null;
            //bool? causeOnly = null;
            //string fillingType = null;
            //int? numberOfMeasurements = null;
            //int? numberOfProcessedMeasurements = null;
            //int? measurementsAtLastAnalysis = null;
            //int? lastUnitId = null;
            //int? lastOriginalUnitId = null;
            //int? lastOriginalValue = null;
            //decimal? lastValue = null;
            //int? lastSourceId = null;
            //int? numberOfCorrelations = null;
            //string status = null;
            //string errorMessage = null;
            //string lastSuccessfulUpdateTime = null;
            //decimal? standardDeviation = null;
            //decimal? variance = null;
            //decimal? minimumRecordedValue = null;
            //decimal? maximumRecordedValue = null;
            //decimal? mean = null;
            //decimal? median = null;
            //int? mostCommonUnitId = null;
            //decimal? mostCommonValue = null;
            //decimal? numberOfUniqueDailyValues = null;
            //int? numberOfChanges = null;
            //decimal? skewness = null;
            //decimal? kurtosis = null;
            //decimal? latitude = null;
            //decimal? longitude = null;
            //string location = null;
            //string createdAt = null;
            //string updatedAt = null;
            //bool? outcome = null;
            //string sources = null;
            //int? earliestSourceTime = null;
            //int? latestSourceTime = null;
            //int? earliestMeasurementTime = null;
            //int? latestMeasurementTime = null;
            //int? earliestFillingTime = null;
            //int? latestFillingTime = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationUserVariablesGet(accessToken, clientId, parentId, variableId, defaultUnitId, minimumAllowedValue, maximumAllowedValue, fillingValue, joinWith, onsetDelay, durationOfAction, variableCategoryId, updated, _public, causeOnly, fillingType, numberOfMeasurements, numberOfProcessedMeasurements, measurementsAtLastAnalysis, lastUnitId, lastOriginalUnitId, lastOriginalValue, lastValue, lastSourceId, numberOfCorrelations, status, errorMessage, lastSuccessfulUpdateTime, standardDeviation, variance, minimumRecordedValue, maximumRecordedValue, mean, median, mostCommonUnitId, mostCommonValue, numberOfUniqueDailyValues, numberOfChanges, skewness, kurtosis, latitude, longitude, location, createdAt, updatedAt, outcome, sources, earliestSourceTime, latestSourceTime, earliestMeasurementTime, latestMeasurementTime, earliestFillingTime, latestFillingTime, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test V2ApplicationVariableUserSourcesGet
        /// </summary>
        [Test]
        public void V2ApplicationVariableUserSourcesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //int? variableId = null;
            //int? timestamp = null;
            //int? earliestMeasurementTime = null;
            //int? latestMeasurementTime = null;
            //string createdAt = null;
            //string updatedAt = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationVariableUserSourcesGet(accessToken, variableId, timestamp, earliestMeasurementTime, latestMeasurementTime, createdAt, updatedAt, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test V2ApplicationVotesGet
        /// </summary>
        [Test]
        public void V2ApplicationVotesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessToken = null;
            //string clientId = null;
            //int? causeId = null;
            //int? effectId = null;
            //int? value = null;
            //string createdAt = null;
            //string updatedAt = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //var response = instance.V2ApplicationVotesGet(accessToken, clientId, causeId, effectId, value, createdAt, updatedAt, limit, offset, sort);
            //Assert.IsInstanceOf<InlineResponse20010> (response, "response is InlineResponse20010");
        }
        
    }

}
