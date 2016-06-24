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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// UserVariable
    /// </summary>
    [DataContract]
    public partial class UserVariable :  IEquatable<UserVariable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserVariable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariable" /> class.
        /// </summary>
        /// <param name="ParentId">ID of the parent variable if this variable has any parent.</param>
        /// <param name="UserId">User ID.</param>
        /// <param name="ClientId">client_id.</param>
        /// <param name="VariableId">ID of variable (required).</param>
        /// <param name="DefaultUnitId">ID of unit to use for this variable.</param>
        /// <param name="MinimumAllowedValue">Minimum reasonable value for this variable (uses default unit).</param>
        /// <param name="MaximumAllowedValue">Maximum reasonable value for this variable (uses default unit).</param>
        /// <param name="FillingValue">Value for replacing null measurements.</param>
        /// <param name="JoinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables.</param>
        /// <param name="OnsetDelay">How long it takes for a measurement in this variable to take effect.</param>
        /// <param name="DurationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect.</param>
        /// <param name="VariableCategoryId">ID of variable category.</param>
        /// <param name="Updated">updated.</param>
        /// <param name="_Public">Is variable public.</param>
        /// <param name="CauseOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user.</param>
        /// <param name="FillingType">0 -&gt; No filling, 1 -&gt; Use filling-value.</param>
        /// <param name="NumberOfMeasurements">Number of measurements.</param>
        /// <param name="NumberOfProcessedMeasurements">Number of processed measurements.</param>
        /// <param name="MeasurementsAtLastAnalysis">Number of measurements at last analysis.</param>
        /// <param name="LastUnitId">ID of last Unit.</param>
        /// <param name="LastOriginalUnitId">ID of last original Unit.</param>
        /// <param name="LastValue">Last Value.</param>
        /// <param name="LastOriginalValue">Last original value which is stored.</param>
        /// <param name="LastSourceId">ID of last source.</param>
        /// <param name="NumberOfCorrelations">Number of correlations for this variable.</param>
        /// <param name="Status">status.</param>
        /// <param name="ErrorMessage">error_message.</param>
        /// <param name="LastSuccessfulUpdateTime">When this variable or its settings were last updated.</param>
        /// <param name="StandardDeviation">Standard deviation.</param>
        /// <param name="Variance">Variance.</param>
        /// <param name="MinimumRecordedValue">Minimum recorded value of this variable.</param>
        /// <param name="MaximumRecordedDailyValue">Maximum recorded daily value of this variable.</param>
        /// <param name="Mean">Mean.</param>
        /// <param name="Median">Median.</param>
        /// <param name="MostCommonUnitId">Most common Unit ID.</param>
        /// <param name="MostCommonValue">Most common value.</param>
        /// <param name="NumberOfUniqueDailyValues">Number of unique daily values.</param>
        /// <param name="NumberOfChanges">Number of changes.</param>
        /// <param name="Skewness">Skewness.</param>
        /// <param name="Kurtosis">Kurtosis.</param>
        /// <param name="Latitude">Latitude.</param>
        /// <param name="Longitude">Longitude.</param>
        /// <param name="Location">Location.</param>
        /// <param name="ExperimentStartTime">Earliest measurement start_time to be used in analysis. Use ISO 8601 datetime format.</param>
        /// <param name="ExperimentEndTime">Latest measurement start_time to be used in analysis. Use ISO 8601 datetime format.</param>
        /// <param name="CreatedAt">When the record was first created. Use ISO 8601 datetime format.</param>
        /// <param name="UpdatedAt">When the record in the database was last updated. Use ISO 8601 datetime format.</param>
        /// <param name="Outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param>
        /// <param name="Sources">Comma-separated list of source names to limit variables to those sources.</param>
        /// <param name="EarliestSourceTime">Earliest source time.</param>
        /// <param name="LatestSourceTime">Latest source time.</param>
        /// <param name="EarliestMeasurementTime">Earliest measurement time.</param>
        /// <param name="LatestMeasurementTime">Latest measurement time.</param>
        /// <param name="EarliestFillingTime">Earliest filling time.</param>
        /// <param name="LatestFillingTime">Latest filling time.</param>
        public UserVariable(int? ParentId = null, int? UserId = null, string ClientId = null, int? VariableId = null, int? DefaultUnitId = null, float? MinimumAllowedValue = null, float? MaximumAllowedValue = null, float? FillingValue = null, int? JoinWith = null, int? OnsetDelay = null, int? DurationOfAction = null, int? VariableCategoryId = null, int? Updated = null, int? _Public = null, bool? CauseOnly = null, string FillingType = null, int? NumberOfMeasurements = null, int? NumberOfProcessedMeasurements = null, int? MeasurementsAtLastAnalysis = null, int? LastUnitId = null, int? LastOriginalUnitId = null, float? LastValue = null, int? LastOriginalValue = null, int? LastSourceId = null, int? NumberOfCorrelations = null, string Status = null, string ErrorMessage = null, DateTime? LastSuccessfulUpdateTime = null, float? StandardDeviation = null, float? Variance = null, float? MinimumRecordedValue = null, float? MaximumRecordedDailyValue = null, float? Mean = null, float? Median = null, int? MostCommonUnitId = null, float? MostCommonValue = null, float? NumberOfUniqueDailyValues = null, int? NumberOfChanges = null, float? Skewness = null, float? Kurtosis = null, float? Latitude = null, float? Longitude = null, string Location = null, DateTime? ExperimentStartTime = null, DateTime? ExperimentEndTime = null, DateTime? CreatedAt = null, DateTime? UpdatedAt = null, bool? Outcome = null, string Sources = null, int? EarliestSourceTime = null, int? LatestSourceTime = null, int? EarliestMeasurementTime = null, int? LatestMeasurementTime = null, int? EarliestFillingTime = null, int? LatestFillingTime = null)
        {
            // to ensure "VariableId" is required (not null)
            if (VariableId == null)
            {
                throw new InvalidDataException("VariableId is a required property for UserVariable and cannot be null");
            }
            else
            {
                this.VariableId = VariableId;
            }
            this.ParentId = ParentId;
            this.UserId = UserId;
            this.ClientId = ClientId;
            this.DefaultUnitId = DefaultUnitId;
            this.MinimumAllowedValue = MinimumAllowedValue;
            this.MaximumAllowedValue = MaximumAllowedValue;
            this.FillingValue = FillingValue;
            this.JoinWith = JoinWith;
            this.OnsetDelay = OnsetDelay;
            this.DurationOfAction = DurationOfAction;
            this.VariableCategoryId = VariableCategoryId;
            this.Updated = Updated;
            this._Public = _Public;
            this.CauseOnly = CauseOnly;
            this.FillingType = FillingType;
            this.NumberOfMeasurements = NumberOfMeasurements;
            this.NumberOfProcessedMeasurements = NumberOfProcessedMeasurements;
            this.MeasurementsAtLastAnalysis = MeasurementsAtLastAnalysis;
            this.LastUnitId = LastUnitId;
            this.LastOriginalUnitId = LastOriginalUnitId;
            this.LastValue = LastValue;
            this.LastOriginalValue = LastOriginalValue;
            this.LastSourceId = LastSourceId;
            this.NumberOfCorrelations = NumberOfCorrelations;
            this.Status = Status;
            this.ErrorMessage = ErrorMessage;
            this.LastSuccessfulUpdateTime = LastSuccessfulUpdateTime;
            this.StandardDeviation = StandardDeviation;
            this.Variance = Variance;
            this.MinimumRecordedValue = MinimumRecordedValue;
            this.MaximumRecordedDailyValue = MaximumRecordedDailyValue;
            this.Mean = Mean;
            this.Median = Median;
            this.MostCommonUnitId = MostCommonUnitId;
            this.MostCommonValue = MostCommonValue;
            this.NumberOfUniqueDailyValues = NumberOfUniqueDailyValues;
            this.NumberOfChanges = NumberOfChanges;
            this.Skewness = Skewness;
            this.Kurtosis = Kurtosis;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Location = Location;
            this.ExperimentStartTime = ExperimentStartTime;
            this.ExperimentEndTime = ExperimentEndTime;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.Outcome = Outcome;
            this.Sources = Sources;
            this.EarliestSourceTime = EarliestSourceTime;
            this.LatestSourceTime = LatestSourceTime;
            this.EarliestMeasurementTime = EarliestMeasurementTime;
            this.LatestMeasurementTime = LatestMeasurementTime;
            this.EarliestFillingTime = EarliestFillingTime;
            this.LatestFillingTime = LatestFillingTime;
        }
        
        /// <summary>
        /// ID of the parent variable if this variable has any parent
        /// </summary>
        /// <value>ID of the parent variable if this variable has any parent</value>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public int? ParentId { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// client_id
        /// </summary>
        /// <value>client_id</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
        /// <summary>
        /// ID of variable
        /// </summary>
        /// <value>ID of variable</value>
        [DataMember(Name="variable_id", EmitDefaultValue=false)]
        public int? VariableId { get; set; }
        /// <summary>
        /// ID of unit to use for this variable
        /// </summary>
        /// <value>ID of unit to use for this variable</value>
        [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
        public int? DefaultUnitId { get; set; }
        /// <summary>
        /// Minimum reasonable value for this variable (uses default unit)
        /// </summary>
        /// <value>Minimum reasonable value for this variable (uses default unit)</value>
        [DataMember(Name="minimum_allowed_value", EmitDefaultValue=false)]
        public float? MinimumAllowedValue { get; set; }
        /// <summary>
        /// Maximum reasonable value for this variable (uses default unit)
        /// </summary>
        /// <value>Maximum reasonable value for this variable (uses default unit)</value>
        [DataMember(Name="maximum_allowed_value", EmitDefaultValue=false)]
        public float? MaximumAllowedValue { get; set; }
        /// <summary>
        /// Value for replacing null measurements
        /// </summary>
        /// <value>Value for replacing null measurements</value>
        [DataMember(Name="filling_value", EmitDefaultValue=false)]
        public float? FillingValue { get; set; }
        /// <summary>
        /// The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables
        /// </summary>
        /// <value>The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</value>
        [DataMember(Name="join_with", EmitDefaultValue=false)]
        public int? JoinWith { get; set; }
        /// <summary>
        /// How long it takes for a measurement in this variable to take effect
        /// </summary>
        /// <value>How long it takes for a measurement in this variable to take effect</value>
        [DataMember(Name="onset_delay", EmitDefaultValue=false)]
        public int? OnsetDelay { get; set; }
        /// <summary>
        /// Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect
        /// </summary>
        /// <value>Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</value>
        [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
        public int? DurationOfAction { get; set; }
        /// <summary>
        /// ID of variable category
        /// </summary>
        /// <value>ID of variable category</value>
        [DataMember(Name="variable_category_id", EmitDefaultValue=false)]
        public int? VariableCategoryId { get; set; }
        /// <summary>
        /// updated
        /// </summary>
        /// <value>updated</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public int? Updated { get; set; }
        /// <summary>
        /// Is variable public
        /// </summary>
        /// <value>Is variable public</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public int? _Public { get; set; }
        /// <summary>
        /// A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user
        /// </summary>
        /// <value>A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</value>
        [DataMember(Name="cause_only", EmitDefaultValue=false)]
        public bool? CauseOnly { get; set; }
        /// <summary>
        /// 0 -&gt; No filling, 1 -&gt; Use filling-value
        /// </summary>
        /// <value>0 -&gt; No filling, 1 -&gt; Use filling-value</value>
        [DataMember(Name="filling_type", EmitDefaultValue=false)]
        public string FillingType { get; set; }
        /// <summary>
        /// Number of measurements
        /// </summary>
        /// <value>Number of measurements</value>
        [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
        public int? NumberOfMeasurements { get; set; }
        /// <summary>
        /// Number of processed measurements
        /// </summary>
        /// <value>Number of processed measurements</value>
        [DataMember(Name="number_of_processed_measurements", EmitDefaultValue=false)]
        public int? NumberOfProcessedMeasurements { get; set; }
        /// <summary>
        /// Number of measurements at last analysis
        /// </summary>
        /// <value>Number of measurements at last analysis</value>
        [DataMember(Name="measurements_at_last_analysis", EmitDefaultValue=false)]
        public int? MeasurementsAtLastAnalysis { get; set; }
        /// <summary>
        /// ID of last Unit
        /// </summary>
        /// <value>ID of last Unit</value>
        [DataMember(Name="last_unit_id", EmitDefaultValue=false)]
        public int? LastUnitId { get; set; }
        /// <summary>
        /// ID of last original Unit
        /// </summary>
        /// <value>ID of last original Unit</value>
        [DataMember(Name="last_original_unit_id", EmitDefaultValue=false)]
        public int? LastOriginalUnitId { get; set; }
        /// <summary>
        /// Last Value
        /// </summary>
        /// <value>Last Value</value>
        [DataMember(Name="last_value", EmitDefaultValue=false)]
        public float? LastValue { get; set; }
        /// <summary>
        /// Last original value which is stored
        /// </summary>
        /// <value>Last original value which is stored</value>
        [DataMember(Name="last_original_value", EmitDefaultValue=false)]
        public int? LastOriginalValue { get; set; }
        /// <summary>
        /// ID of last source
        /// </summary>
        /// <value>ID of last source</value>
        [DataMember(Name="last_source_id", EmitDefaultValue=false)]
        public int? LastSourceId { get; set; }
        /// <summary>
        /// Number of correlations for this variable
        /// </summary>
        /// <value>Number of correlations for this variable</value>
        [DataMember(Name="number_of_correlations", EmitDefaultValue=false)]
        public int? NumberOfCorrelations { get; set; }
        /// <summary>
        /// status
        /// </summary>
        /// <value>status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// error_message
        /// </summary>
        /// <value>error_message</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// When this variable or its settings were last updated
        /// </summary>
        /// <value>When this variable or its settings were last updated</value>
        [DataMember(Name="last_successful_update_time", EmitDefaultValue=false)]
        public DateTime? LastSuccessfulUpdateTime { get; set; }
        /// <summary>
        /// Standard deviation
        /// </summary>
        /// <value>Standard deviation</value>
        [DataMember(Name="standard_deviation", EmitDefaultValue=false)]
        public float? StandardDeviation { get; set; }
        /// <summary>
        /// Variance
        /// </summary>
        /// <value>Variance</value>
        [DataMember(Name="variance", EmitDefaultValue=false)]
        public float? Variance { get; set; }
        /// <summary>
        /// Minimum recorded value of this variable
        /// </summary>
        /// <value>Minimum recorded value of this variable</value>
        [DataMember(Name="minimum_recorded_value", EmitDefaultValue=false)]
        public float? MinimumRecordedValue { get; set; }
        /// <summary>
        /// Maximum recorded daily value of this variable
        /// </summary>
        /// <value>Maximum recorded daily value of this variable</value>
        [DataMember(Name="maximum_recorded_daily_value", EmitDefaultValue=false)]
        public float? MaximumRecordedDailyValue { get; set; }
        /// <summary>
        /// Mean
        /// </summary>
        /// <value>Mean</value>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public float? Mean { get; set; }
        /// <summary>
        /// Median
        /// </summary>
        /// <value>Median</value>
        [DataMember(Name="median", EmitDefaultValue=false)]
        public float? Median { get; set; }
        /// <summary>
        /// Most common Unit ID
        /// </summary>
        /// <value>Most common Unit ID</value>
        [DataMember(Name="most_common_unit_id", EmitDefaultValue=false)]
        public int? MostCommonUnitId { get; set; }
        /// <summary>
        /// Most common value
        /// </summary>
        /// <value>Most common value</value>
        [DataMember(Name="most_common_value", EmitDefaultValue=false)]
        public float? MostCommonValue { get; set; }
        /// <summary>
        /// Number of unique daily values
        /// </summary>
        /// <value>Number of unique daily values</value>
        [DataMember(Name="number_of_unique_daily_values", EmitDefaultValue=false)]
        public float? NumberOfUniqueDailyValues { get; set; }
        /// <summary>
        /// Number of changes
        /// </summary>
        /// <value>Number of changes</value>
        [DataMember(Name="number_of_changes", EmitDefaultValue=false)]
        public int? NumberOfChanges { get; set; }
        /// <summary>
        /// Skewness
        /// </summary>
        /// <value>Skewness</value>
        [DataMember(Name="skewness", EmitDefaultValue=false)]
        public float? Skewness { get; set; }
        /// <summary>
        /// Kurtosis
        /// </summary>
        /// <value>Kurtosis</value>
        [DataMember(Name="kurtosis", EmitDefaultValue=false)]
        public float? Kurtosis { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        /// <value>Latitude</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public float? Latitude { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        /// <value>Longitude</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public float? Longitude { get; set; }
        /// <summary>
        /// Location
        /// </summary>
        /// <value>Location</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// Earliest measurement start_time to be used in analysis. Use ISO 8601 datetime format
        /// </summary>
        /// <value>Earliest measurement start_time to be used in analysis. Use ISO 8601 datetime format</value>
        [DataMember(Name="experiment_start_time", EmitDefaultValue=false)]
        public DateTime? ExperimentStartTime { get; set; }
        /// <summary>
        /// Latest measurement start_time to be used in analysis. Use ISO 8601 datetime format
        /// </summary>
        /// <value>Latest measurement start_time to be used in analysis. Use ISO 8601 datetime format</value>
        [DataMember(Name="experiment_end_time", EmitDefaultValue=false)]
        public DateTime? ExperimentEndTime { get; set; }
        /// <summary>
        /// When the record was first created. Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the record was first created. Use ISO 8601 datetime format</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// When the record in the database was last updated. Use ISO 8601 datetime format
        /// </summary>
        /// <value>When the record in the database was last updated. Use ISO 8601 datetime format</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables
        /// </summary>
        /// <value>Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</value>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public bool? Outcome { get; set; }
        /// <summary>
        /// Comma-separated list of source names to limit variables to those sources
        /// </summary>
        /// <value>Comma-separated list of source names to limit variables to those sources</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public string Sources { get; set; }
        /// <summary>
        /// Earliest source time
        /// </summary>
        /// <value>Earliest source time</value>
        [DataMember(Name="earliest_source_time", EmitDefaultValue=false)]
        public int? EarliestSourceTime { get; set; }
        /// <summary>
        /// Latest source time
        /// </summary>
        /// <value>Latest source time</value>
        [DataMember(Name="latest_source_time", EmitDefaultValue=false)]
        public int? LatestSourceTime { get; set; }
        /// <summary>
        /// Earliest measurement time
        /// </summary>
        /// <value>Earliest measurement time</value>
        [DataMember(Name="earliest_measurement_time", EmitDefaultValue=false)]
        public int? EarliestMeasurementTime { get; set; }
        /// <summary>
        /// Latest measurement time
        /// </summary>
        /// <value>Latest measurement time</value>
        [DataMember(Name="latest_measurement_time", EmitDefaultValue=false)]
        public int? LatestMeasurementTime { get; set; }
        /// <summary>
        /// Earliest filling time
        /// </summary>
        /// <value>Earliest filling time</value>
        [DataMember(Name="earliest_filling_time", EmitDefaultValue=false)]
        public int? EarliestFillingTime { get; set; }
        /// <summary>
        /// Latest filling time
        /// </summary>
        /// <value>Latest filling time</value>
        [DataMember(Name="latest_filling_time", EmitDefaultValue=false)]
        public int? LatestFillingTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserVariable {\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
            sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
            sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
            sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
            sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
            sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
            sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
            sb.Append("  VariableCategoryId: ").Append(VariableCategoryId).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  _Public: ").Append(_Public).Append("\n");
            sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
            sb.Append("  FillingType: ").Append(FillingType).Append("\n");
            sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
            sb.Append("  NumberOfProcessedMeasurements: ").Append(NumberOfProcessedMeasurements).Append("\n");
            sb.Append("  MeasurementsAtLastAnalysis: ").Append(MeasurementsAtLastAnalysis).Append("\n");
            sb.Append("  LastUnitId: ").Append(LastUnitId).Append("\n");
            sb.Append("  LastOriginalUnitId: ").Append(LastOriginalUnitId).Append("\n");
            sb.Append("  LastValue: ").Append(LastValue).Append("\n");
            sb.Append("  LastOriginalValue: ").Append(LastOriginalValue).Append("\n");
            sb.Append("  LastSourceId: ").Append(LastSourceId).Append("\n");
            sb.Append("  NumberOfCorrelations: ").Append(NumberOfCorrelations).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  LastSuccessfulUpdateTime: ").Append(LastSuccessfulUpdateTime).Append("\n");
            sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
            sb.Append("  Variance: ").Append(Variance).Append("\n");
            sb.Append("  MinimumRecordedValue: ").Append(MinimumRecordedValue).Append("\n");
            sb.Append("  MaximumRecordedDailyValue: ").Append(MaximumRecordedDailyValue).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Median: ").Append(Median).Append("\n");
            sb.Append("  MostCommonUnitId: ").Append(MostCommonUnitId).Append("\n");
            sb.Append("  MostCommonValue: ").Append(MostCommonValue).Append("\n");
            sb.Append("  NumberOfUniqueDailyValues: ").Append(NumberOfUniqueDailyValues).Append("\n");
            sb.Append("  NumberOfChanges: ").Append(NumberOfChanges).Append("\n");
            sb.Append("  Skewness: ").Append(Skewness).Append("\n");
            sb.Append("  Kurtosis: ").Append(Kurtosis).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ExperimentStartTime: ").Append(ExperimentStartTime).Append("\n");
            sb.Append("  ExperimentEndTime: ").Append(ExperimentEndTime).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  EarliestSourceTime: ").Append(EarliestSourceTime).Append("\n");
            sb.Append("  LatestSourceTime: ").Append(LatestSourceTime).Append("\n");
            sb.Append("  EarliestMeasurementTime: ").Append(EarliestMeasurementTime).Append("\n");
            sb.Append("  LatestMeasurementTime: ").Append(LatestMeasurementTime).Append("\n");
            sb.Append("  EarliestFillingTime: ").Append(EarliestFillingTime).Append("\n");
            sb.Append("  LatestFillingTime: ").Append(LatestFillingTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserVariable);
        }

        /// <summary>
        /// Returns true if UserVariable instances are equal
        /// </summary>
        /// <param name="other">Instance of UserVariable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserVariable other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.VariableId == other.VariableId ||
                    this.VariableId != null &&
                    this.VariableId.Equals(other.VariableId)
                ) && 
                (
                    this.DefaultUnitId == other.DefaultUnitId ||
                    this.DefaultUnitId != null &&
                    this.DefaultUnitId.Equals(other.DefaultUnitId)
                ) && 
                (
                    this.MinimumAllowedValue == other.MinimumAllowedValue ||
                    this.MinimumAllowedValue != null &&
                    this.MinimumAllowedValue.Equals(other.MinimumAllowedValue)
                ) && 
                (
                    this.MaximumAllowedValue == other.MaximumAllowedValue ||
                    this.MaximumAllowedValue != null &&
                    this.MaximumAllowedValue.Equals(other.MaximumAllowedValue)
                ) && 
                (
                    this.FillingValue == other.FillingValue ||
                    this.FillingValue != null &&
                    this.FillingValue.Equals(other.FillingValue)
                ) && 
                (
                    this.JoinWith == other.JoinWith ||
                    this.JoinWith != null &&
                    this.JoinWith.Equals(other.JoinWith)
                ) && 
                (
                    this.OnsetDelay == other.OnsetDelay ||
                    this.OnsetDelay != null &&
                    this.OnsetDelay.Equals(other.OnsetDelay)
                ) && 
                (
                    this.DurationOfAction == other.DurationOfAction ||
                    this.DurationOfAction != null &&
                    this.DurationOfAction.Equals(other.DurationOfAction)
                ) && 
                (
                    this.VariableCategoryId == other.VariableCategoryId ||
                    this.VariableCategoryId != null &&
                    this.VariableCategoryId.Equals(other.VariableCategoryId)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this._Public == other._Public ||
                    this._Public != null &&
                    this._Public.Equals(other._Public)
                ) && 
                (
                    this.CauseOnly == other.CauseOnly ||
                    this.CauseOnly != null &&
                    this.CauseOnly.Equals(other.CauseOnly)
                ) && 
                (
                    this.FillingType == other.FillingType ||
                    this.FillingType != null &&
                    this.FillingType.Equals(other.FillingType)
                ) && 
                (
                    this.NumberOfMeasurements == other.NumberOfMeasurements ||
                    this.NumberOfMeasurements != null &&
                    this.NumberOfMeasurements.Equals(other.NumberOfMeasurements)
                ) && 
                (
                    this.NumberOfProcessedMeasurements == other.NumberOfProcessedMeasurements ||
                    this.NumberOfProcessedMeasurements != null &&
                    this.NumberOfProcessedMeasurements.Equals(other.NumberOfProcessedMeasurements)
                ) && 
                (
                    this.MeasurementsAtLastAnalysis == other.MeasurementsAtLastAnalysis ||
                    this.MeasurementsAtLastAnalysis != null &&
                    this.MeasurementsAtLastAnalysis.Equals(other.MeasurementsAtLastAnalysis)
                ) && 
                (
                    this.LastUnitId == other.LastUnitId ||
                    this.LastUnitId != null &&
                    this.LastUnitId.Equals(other.LastUnitId)
                ) && 
                (
                    this.LastOriginalUnitId == other.LastOriginalUnitId ||
                    this.LastOriginalUnitId != null &&
                    this.LastOriginalUnitId.Equals(other.LastOriginalUnitId)
                ) && 
                (
                    this.LastValue == other.LastValue ||
                    this.LastValue != null &&
                    this.LastValue.Equals(other.LastValue)
                ) && 
                (
                    this.LastOriginalValue == other.LastOriginalValue ||
                    this.LastOriginalValue != null &&
                    this.LastOriginalValue.Equals(other.LastOriginalValue)
                ) && 
                (
                    this.LastSourceId == other.LastSourceId ||
                    this.LastSourceId != null &&
                    this.LastSourceId.Equals(other.LastSourceId)
                ) && 
                (
                    this.NumberOfCorrelations == other.NumberOfCorrelations ||
                    this.NumberOfCorrelations != null &&
                    this.NumberOfCorrelations.Equals(other.NumberOfCorrelations)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.LastSuccessfulUpdateTime == other.LastSuccessfulUpdateTime ||
                    this.LastSuccessfulUpdateTime != null &&
                    this.LastSuccessfulUpdateTime.Equals(other.LastSuccessfulUpdateTime)
                ) && 
                (
                    this.StandardDeviation == other.StandardDeviation ||
                    this.StandardDeviation != null &&
                    this.StandardDeviation.Equals(other.StandardDeviation)
                ) && 
                (
                    this.Variance == other.Variance ||
                    this.Variance != null &&
                    this.Variance.Equals(other.Variance)
                ) && 
                (
                    this.MinimumRecordedValue == other.MinimumRecordedValue ||
                    this.MinimumRecordedValue != null &&
                    this.MinimumRecordedValue.Equals(other.MinimumRecordedValue)
                ) && 
                (
                    this.MaximumRecordedDailyValue == other.MaximumRecordedDailyValue ||
                    this.MaximumRecordedDailyValue != null &&
                    this.MaximumRecordedDailyValue.Equals(other.MaximumRecordedDailyValue)
                ) && 
                (
                    this.Mean == other.Mean ||
                    this.Mean != null &&
                    this.Mean.Equals(other.Mean)
                ) && 
                (
                    this.Median == other.Median ||
                    this.Median != null &&
                    this.Median.Equals(other.Median)
                ) && 
                (
                    this.MostCommonUnitId == other.MostCommonUnitId ||
                    this.MostCommonUnitId != null &&
                    this.MostCommonUnitId.Equals(other.MostCommonUnitId)
                ) && 
                (
                    this.MostCommonValue == other.MostCommonValue ||
                    this.MostCommonValue != null &&
                    this.MostCommonValue.Equals(other.MostCommonValue)
                ) && 
                (
                    this.NumberOfUniqueDailyValues == other.NumberOfUniqueDailyValues ||
                    this.NumberOfUniqueDailyValues != null &&
                    this.NumberOfUniqueDailyValues.Equals(other.NumberOfUniqueDailyValues)
                ) && 
                (
                    this.NumberOfChanges == other.NumberOfChanges ||
                    this.NumberOfChanges != null &&
                    this.NumberOfChanges.Equals(other.NumberOfChanges)
                ) && 
                (
                    this.Skewness == other.Skewness ||
                    this.Skewness != null &&
                    this.Skewness.Equals(other.Skewness)
                ) && 
                (
                    this.Kurtosis == other.Kurtosis ||
                    this.Kurtosis != null &&
                    this.Kurtosis.Equals(other.Kurtosis)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.ExperimentStartTime == other.ExperimentStartTime ||
                    this.ExperimentStartTime != null &&
                    this.ExperimentStartTime.Equals(other.ExperimentStartTime)
                ) && 
                (
                    this.ExperimentEndTime == other.ExperimentEndTime ||
                    this.ExperimentEndTime != null &&
                    this.ExperimentEndTime.Equals(other.ExperimentEndTime)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
                ) && 
                (
                    this.Sources == other.Sources ||
                    this.Sources != null &&
                    this.Sources.Equals(other.Sources)
                ) && 
                (
                    this.EarliestSourceTime == other.EarliestSourceTime ||
                    this.EarliestSourceTime != null &&
                    this.EarliestSourceTime.Equals(other.EarliestSourceTime)
                ) && 
                (
                    this.LatestSourceTime == other.LatestSourceTime ||
                    this.LatestSourceTime != null &&
                    this.LatestSourceTime.Equals(other.LatestSourceTime)
                ) && 
                (
                    this.EarliestMeasurementTime == other.EarliestMeasurementTime ||
                    this.EarliestMeasurementTime != null &&
                    this.EarliestMeasurementTime.Equals(other.EarliestMeasurementTime)
                ) && 
                (
                    this.LatestMeasurementTime == other.LatestMeasurementTime ||
                    this.LatestMeasurementTime != null &&
                    this.LatestMeasurementTime.Equals(other.LatestMeasurementTime)
                ) && 
                (
                    this.EarliestFillingTime == other.EarliestFillingTime ||
                    this.EarliestFillingTime != null &&
                    this.EarliestFillingTime.Equals(other.EarliestFillingTime)
                ) && 
                (
                    this.LatestFillingTime == other.LatestFillingTime ||
                    this.LatestFillingTime != null &&
                    this.LatestFillingTime.Equals(other.LatestFillingTime)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.VariableId != null)
                    hash = hash * 59 + this.VariableId.GetHashCode();
                if (this.DefaultUnitId != null)
                    hash = hash * 59 + this.DefaultUnitId.GetHashCode();
                if (this.MinimumAllowedValue != null)
                    hash = hash * 59 + this.MinimumAllowedValue.GetHashCode();
                if (this.MaximumAllowedValue != null)
                    hash = hash * 59 + this.MaximumAllowedValue.GetHashCode();
                if (this.FillingValue != null)
                    hash = hash * 59 + this.FillingValue.GetHashCode();
                if (this.JoinWith != null)
                    hash = hash * 59 + this.JoinWith.GetHashCode();
                if (this.OnsetDelay != null)
                    hash = hash * 59 + this.OnsetDelay.GetHashCode();
                if (this.DurationOfAction != null)
                    hash = hash * 59 + this.DurationOfAction.GetHashCode();
                if (this.VariableCategoryId != null)
                    hash = hash * 59 + this.VariableCategoryId.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this._Public != null)
                    hash = hash * 59 + this._Public.GetHashCode();
                if (this.CauseOnly != null)
                    hash = hash * 59 + this.CauseOnly.GetHashCode();
                if (this.FillingType != null)
                    hash = hash * 59 + this.FillingType.GetHashCode();
                if (this.NumberOfMeasurements != null)
                    hash = hash * 59 + this.NumberOfMeasurements.GetHashCode();
                if (this.NumberOfProcessedMeasurements != null)
                    hash = hash * 59 + this.NumberOfProcessedMeasurements.GetHashCode();
                if (this.MeasurementsAtLastAnalysis != null)
                    hash = hash * 59 + this.MeasurementsAtLastAnalysis.GetHashCode();
                if (this.LastUnitId != null)
                    hash = hash * 59 + this.LastUnitId.GetHashCode();
                if (this.LastOriginalUnitId != null)
                    hash = hash * 59 + this.LastOriginalUnitId.GetHashCode();
                if (this.LastValue != null)
                    hash = hash * 59 + this.LastValue.GetHashCode();
                if (this.LastOriginalValue != null)
                    hash = hash * 59 + this.LastOriginalValue.GetHashCode();
                if (this.LastSourceId != null)
                    hash = hash * 59 + this.LastSourceId.GetHashCode();
                if (this.NumberOfCorrelations != null)
                    hash = hash * 59 + this.NumberOfCorrelations.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.LastSuccessfulUpdateTime != null)
                    hash = hash * 59 + this.LastSuccessfulUpdateTime.GetHashCode();
                if (this.StandardDeviation != null)
                    hash = hash * 59 + this.StandardDeviation.GetHashCode();
                if (this.Variance != null)
                    hash = hash * 59 + this.Variance.GetHashCode();
                if (this.MinimumRecordedValue != null)
                    hash = hash * 59 + this.MinimumRecordedValue.GetHashCode();
                if (this.MaximumRecordedDailyValue != null)
                    hash = hash * 59 + this.MaximumRecordedDailyValue.GetHashCode();
                if (this.Mean != null)
                    hash = hash * 59 + this.Mean.GetHashCode();
                if (this.Median != null)
                    hash = hash * 59 + this.Median.GetHashCode();
                if (this.MostCommonUnitId != null)
                    hash = hash * 59 + this.MostCommonUnitId.GetHashCode();
                if (this.MostCommonValue != null)
                    hash = hash * 59 + this.MostCommonValue.GetHashCode();
                if (this.NumberOfUniqueDailyValues != null)
                    hash = hash * 59 + this.NumberOfUniqueDailyValues.GetHashCode();
                if (this.NumberOfChanges != null)
                    hash = hash * 59 + this.NumberOfChanges.GetHashCode();
                if (this.Skewness != null)
                    hash = hash * 59 + this.Skewness.GetHashCode();
                if (this.Kurtosis != null)
                    hash = hash * 59 + this.Kurtosis.GetHashCode();
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.ExperimentStartTime != null)
                    hash = hash * 59 + this.ExperimentStartTime.GetHashCode();
                if (this.ExperimentEndTime != null)
                    hash = hash * 59 + this.ExperimentEndTime.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.Outcome != null)
                    hash = hash * 59 + this.Outcome.GetHashCode();
                if (this.Sources != null)
                    hash = hash * 59 + this.Sources.GetHashCode();
                if (this.EarliestSourceTime != null)
                    hash = hash * 59 + this.EarliestSourceTime.GetHashCode();
                if (this.LatestSourceTime != null)
                    hash = hash * 59 + this.LatestSourceTime.GetHashCode();
                if (this.EarliestMeasurementTime != null)
                    hash = hash * 59 + this.EarliestMeasurementTime.GetHashCode();
                if (this.LatestMeasurementTime != null)
                    hash = hash * 59 + this.LatestMeasurementTime.GetHashCode();
                if (this.EarliestFillingTime != null)
                    hash = hash * 59 + this.EarliestFillingTime.GetHashCode();
                if (this.LatestFillingTime != null)
                    hash = hash * 59 + this.LatestFillingTime.GetHashCode();
                return hash;
            }
        }
    }

}
