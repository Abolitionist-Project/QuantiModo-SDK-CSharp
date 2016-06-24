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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing UserVariable
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserVariableTests
    {
        // TODO uncomment below to declare an instance variable for UserVariable
        //private UserVariable instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UserVariable
            //instance = new UserVariable();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserVariable
        /// </summary>
        [Test]
        public void UserVariableInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UserVariable
            //Assert.IsInstanceOfType<UserVariable> (instance, "variable 'instance' is a UserVariable");
        }

        /// <summary>
        /// Test the property 'ParentId'
        /// </summary>
        [Test]
        public void ParentIdTest()
        {
            // TODO unit test for the property 'ParentId'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'ClientId'
        /// </summary>
        [Test]
        public void ClientIdTest()
        {
            // TODO unit test for the property 'ClientId'
        }
        /// <summary>
        /// Test the property 'VariableId'
        /// </summary>
        [Test]
        public void VariableIdTest()
        {
            // TODO unit test for the property 'VariableId'
        }
        /// <summary>
        /// Test the property 'DefaultUnitId'
        /// </summary>
        [Test]
        public void DefaultUnitIdTest()
        {
            // TODO unit test for the property 'DefaultUnitId'
        }
        /// <summary>
        /// Test the property 'MinimumAllowedValue'
        /// </summary>
        [Test]
        public void MinimumAllowedValueTest()
        {
            // TODO unit test for the property 'MinimumAllowedValue'
        }
        /// <summary>
        /// Test the property 'MaximumAllowedValue'
        /// </summary>
        [Test]
        public void MaximumAllowedValueTest()
        {
            // TODO unit test for the property 'MaximumAllowedValue'
        }
        /// <summary>
        /// Test the property 'FillingValue'
        /// </summary>
        [Test]
        public void FillingValueTest()
        {
            // TODO unit test for the property 'FillingValue'
        }
        /// <summary>
        /// Test the property 'JoinWith'
        /// </summary>
        [Test]
        public void JoinWithTest()
        {
            // TODO unit test for the property 'JoinWith'
        }
        /// <summary>
        /// Test the property 'OnsetDelay'
        /// </summary>
        [Test]
        public void OnsetDelayTest()
        {
            // TODO unit test for the property 'OnsetDelay'
        }
        /// <summary>
        /// Test the property 'DurationOfAction'
        /// </summary>
        [Test]
        public void DurationOfActionTest()
        {
            // TODO unit test for the property 'DurationOfAction'
        }
        /// <summary>
        /// Test the property 'VariableCategoryId'
        /// </summary>
        [Test]
        public void VariableCategoryIdTest()
        {
            // TODO unit test for the property 'VariableCategoryId'
        }
        /// <summary>
        /// Test the property 'Updated'
        /// </summary>
        [Test]
        public void UpdatedTest()
        {
            // TODO unit test for the property 'Updated'
        }
        /// <summary>
        /// Test the property '_Public'
        /// </summary>
        [Test]
        public void _PublicTest()
        {
            // TODO unit test for the property '_Public'
        }
        /// <summary>
        /// Test the property 'CauseOnly'
        /// </summary>
        [Test]
        public void CauseOnlyTest()
        {
            // TODO unit test for the property 'CauseOnly'
        }
        /// <summary>
        /// Test the property 'FillingType'
        /// </summary>
        [Test]
        public void FillingTypeTest()
        {
            // TODO unit test for the property 'FillingType'
        }
        /// <summary>
        /// Test the property 'NumberOfMeasurements'
        /// </summary>
        [Test]
        public void NumberOfMeasurementsTest()
        {
            // TODO unit test for the property 'NumberOfMeasurements'
        }
        /// <summary>
        /// Test the property 'NumberOfProcessedMeasurements'
        /// </summary>
        [Test]
        public void NumberOfProcessedMeasurementsTest()
        {
            // TODO unit test for the property 'NumberOfProcessedMeasurements'
        }
        /// <summary>
        /// Test the property 'MeasurementsAtLastAnalysis'
        /// </summary>
        [Test]
        public void MeasurementsAtLastAnalysisTest()
        {
            // TODO unit test for the property 'MeasurementsAtLastAnalysis'
        }
        /// <summary>
        /// Test the property 'LastUnitId'
        /// </summary>
        [Test]
        public void LastUnitIdTest()
        {
            // TODO unit test for the property 'LastUnitId'
        }
        /// <summary>
        /// Test the property 'LastOriginalUnitId'
        /// </summary>
        [Test]
        public void LastOriginalUnitIdTest()
        {
            // TODO unit test for the property 'LastOriginalUnitId'
        }
        /// <summary>
        /// Test the property 'LastValue'
        /// </summary>
        [Test]
        public void LastValueTest()
        {
            // TODO unit test for the property 'LastValue'
        }
        /// <summary>
        /// Test the property 'LastOriginalValue'
        /// </summary>
        [Test]
        public void LastOriginalValueTest()
        {
            // TODO unit test for the property 'LastOriginalValue'
        }
        /// <summary>
        /// Test the property 'LastSourceId'
        /// </summary>
        [Test]
        public void LastSourceIdTest()
        {
            // TODO unit test for the property 'LastSourceId'
        }
        /// <summary>
        /// Test the property 'NumberOfCorrelations'
        /// </summary>
        [Test]
        public void NumberOfCorrelationsTest()
        {
            // TODO unit test for the property 'NumberOfCorrelations'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'ErrorMessage'
        /// </summary>
        [Test]
        public void ErrorMessageTest()
        {
            // TODO unit test for the property 'ErrorMessage'
        }
        /// <summary>
        /// Test the property 'LastSuccessfulUpdateTime'
        /// </summary>
        [Test]
        public void LastSuccessfulUpdateTimeTest()
        {
            // TODO unit test for the property 'LastSuccessfulUpdateTime'
        }
        /// <summary>
        /// Test the property 'StandardDeviation'
        /// </summary>
        [Test]
        public void StandardDeviationTest()
        {
            // TODO unit test for the property 'StandardDeviation'
        }
        /// <summary>
        /// Test the property 'Variance'
        /// </summary>
        [Test]
        public void VarianceTest()
        {
            // TODO unit test for the property 'Variance'
        }
        /// <summary>
        /// Test the property 'MinimumRecordedValue'
        /// </summary>
        [Test]
        public void MinimumRecordedValueTest()
        {
            // TODO unit test for the property 'MinimumRecordedValue'
        }
        /// <summary>
        /// Test the property 'MaximumRecordedDailyValue'
        /// </summary>
        [Test]
        public void MaximumRecordedDailyValueTest()
        {
            // TODO unit test for the property 'MaximumRecordedDailyValue'
        }
        /// <summary>
        /// Test the property 'Mean'
        /// </summary>
        [Test]
        public void MeanTest()
        {
            // TODO unit test for the property 'Mean'
        }
        /// <summary>
        /// Test the property 'Median'
        /// </summary>
        [Test]
        public void MedianTest()
        {
            // TODO unit test for the property 'Median'
        }
        /// <summary>
        /// Test the property 'MostCommonUnitId'
        /// </summary>
        [Test]
        public void MostCommonUnitIdTest()
        {
            // TODO unit test for the property 'MostCommonUnitId'
        }
        /// <summary>
        /// Test the property 'MostCommonValue'
        /// </summary>
        [Test]
        public void MostCommonValueTest()
        {
            // TODO unit test for the property 'MostCommonValue'
        }
        /// <summary>
        /// Test the property 'NumberOfUniqueDailyValues'
        /// </summary>
        [Test]
        public void NumberOfUniqueDailyValuesTest()
        {
            // TODO unit test for the property 'NumberOfUniqueDailyValues'
        }
        /// <summary>
        /// Test the property 'NumberOfChanges'
        /// </summary>
        [Test]
        public void NumberOfChangesTest()
        {
            // TODO unit test for the property 'NumberOfChanges'
        }
        /// <summary>
        /// Test the property 'Skewness'
        /// </summary>
        [Test]
        public void SkewnessTest()
        {
            // TODO unit test for the property 'Skewness'
        }
        /// <summary>
        /// Test the property 'Kurtosis'
        /// </summary>
        [Test]
        public void KurtosisTest()
        {
            // TODO unit test for the property 'Kurtosis'
        }
        /// <summary>
        /// Test the property 'Latitude'
        /// </summary>
        [Test]
        public void LatitudeTest()
        {
            // TODO unit test for the property 'Latitude'
        }
        /// <summary>
        /// Test the property 'Longitude'
        /// </summary>
        [Test]
        public void LongitudeTest()
        {
            // TODO unit test for the property 'Longitude'
        }
        /// <summary>
        /// Test the property 'Location'
        /// </summary>
        [Test]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }
        /// <summary>
        /// Test the property 'ExperimentStartTime'
        /// </summary>
        [Test]
        public void ExperimentStartTimeTest()
        {
            // TODO unit test for the property 'ExperimentStartTime'
        }
        /// <summary>
        /// Test the property 'ExperimentEndTime'
        /// </summary>
        [Test]
        public void ExperimentEndTimeTest()
        {
            // TODO unit test for the property 'ExperimentEndTime'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'Outcome'
        /// </summary>
        [Test]
        public void OutcomeTest()
        {
            // TODO unit test for the property 'Outcome'
        }
        /// <summary>
        /// Test the property 'Sources'
        /// </summary>
        [Test]
        public void SourcesTest()
        {
            // TODO unit test for the property 'Sources'
        }
        /// <summary>
        /// Test the property 'EarliestSourceTime'
        /// </summary>
        [Test]
        public void EarliestSourceTimeTest()
        {
            // TODO unit test for the property 'EarliestSourceTime'
        }
        /// <summary>
        /// Test the property 'LatestSourceTime'
        /// </summary>
        [Test]
        public void LatestSourceTimeTest()
        {
            // TODO unit test for the property 'LatestSourceTime'
        }
        /// <summary>
        /// Test the property 'EarliestMeasurementTime'
        /// </summary>
        [Test]
        public void EarliestMeasurementTimeTest()
        {
            // TODO unit test for the property 'EarliestMeasurementTime'
        }
        /// <summary>
        /// Test the property 'LatestMeasurementTime'
        /// </summary>
        [Test]
        public void LatestMeasurementTimeTest()
        {
            // TODO unit test for the property 'LatestMeasurementTime'
        }
        /// <summary>
        /// Test the property 'EarliestFillingTime'
        /// </summary>
        [Test]
        public void EarliestFillingTimeTest()
        {
            // TODO unit test for the property 'EarliestFillingTime'
        }
        /// <summary>
        /// Test the property 'LatestFillingTime'
        /// </summary>
        [Test]
        public void LatestFillingTimeTest()
        {
            // TODO unit test for the property 'LatestFillingTime'
        }

    }

}
