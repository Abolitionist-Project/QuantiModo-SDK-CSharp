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
    /// Variable
    /// </summary>
    [DataContract]
    public partial class Variable :  IEquatable<Variable>
    {
        /// <summary>
        /// Way to aggregate measurements over time. Options are \"MEAN\" or \"SUM\".  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED.
        /// </summary>
        /// <value>Way to aggregate measurements over time. Options are \"MEAN\" or \"SUM\".  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CombinationOperationEnum
        {
            
            /// <summary>
            /// Enum Mean for "MEAN"
            /// </summary>
            [EnumMember(Value = "MEAN")]
            Mean,
            
            /// <summary>
            /// Enum Sum for "SUM"
            /// </summary>
            [EnumMember(Value = "SUM")]
            Sum
        }

        /// <summary>
        /// Way to aggregate measurements over time. Options are \"MEAN\" or \"SUM\".  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED.
        /// </summary>
        /// <value>Way to aggregate measurements over time. Options are \"MEAN\" or \"SUM\".  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED.</value>
        [DataMember(Name="combinationOperation", EmitDefaultValue=false)]
        public CombinationOperationEnum? CombinationOperation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Variable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Variable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Variable" /> class.
        /// </summary>
        /// <param name="Id">Variable ID.</param>
        /// <param name="Name">User-defined variable display name. (required).</param>
        /// <param name="OriginalName">Name used when the variable was originally created in the &#x60;variables&#x60; table. (required).</param>
        /// <param name="Category">Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc. (required).</param>
        /// <param name="AbbreviatedUnitName">Abbreviated name of the default unit for the variable (required).</param>
        /// <param name="AbbreviatedUnitId">Id of the default unit for the variable (required).</param>
        /// <param name="Sources">Comma-separated list of source names to limit variables to those sources (required).</param>
        /// <param name="MinimumValue">Minimum reasonable value for this variable (uses default unit) (required).</param>
        /// <param name="MaximumValue">Maximum reasonable value for this variable (uses default unit) (required).</param>
        /// <param name="CombinationOperation">Way to aggregate measurements over time. Options are \&quot;MEAN\&quot; or \&quot;SUM\&quot;.  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED. (required).</param>
        /// <param name="FillingValue">Value for replacing null measurements (required).</param>
        /// <param name="JoinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables. (required).</param>
        /// <param name="JoinedVariables">Array of Variables that are joined with this Variable (required).</param>
        /// <param name="Parent">Id of the parent variable if this variable has any parent (required).</param>
        /// <param name="SubVariables">Array of Variables that are sub variables to this Variable (required).</param>
        /// <param name="OnsetDelay">How long it takes for a measurement in this variable to take effect (required).</param>
        /// <param name="DurationOfAction">How long the effect of a measurement in this variable lasts (required).</param>
        /// <param name="EarliestMeasurementTime">Earliest measurement time (required).</param>
        /// <param name="LatestMeasurementTime">Latest measurement time (required).</param>
        /// <param name="Updated">When this variable or its settings were last updated (required).</param>
        /// <param name="CauseOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user. (required).</param>
        /// <param name="NumberOfCorrelations">Number of correlations (required).</param>
        /// <param name="Outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables. (required).</param>
        /// <param name="MeasurementsAtLastAnalysis">The number of measurements that a given user had for this variable the last time a correlation calculation was performed. Generally correlation values are only updated once the current number of measurements for a variable is more than 10% greater than the measurementsAtLastAnalysis.  This avoids a computationally-demanding recalculation when there&#39;s not enough new data to make a significant difference in the correlation. (required).</param>
        /// <param name="NumberOfMeasurements">Number of measurements (required).</param>
        /// <param name="LastUnit">Last unit (required).</param>
        /// <param name="LastValue">Last value (required).</param>
        /// <param name="MostCommonValue">Most common value (required).</param>
        /// <param name="MostCommonUnit">Most common unit (required).</param>
        /// <param name="LastSource">Last source (required).</param>
        public Variable(int? Id = null, string Name = null, string OriginalName = null, string Category = null, string AbbreviatedUnitName = null, int? AbbreviatedUnitId = null, string Sources = null, double? MinimumValue = null, double? MaximumValue = null, CombinationOperationEnum? CombinationOperation = null, double? FillingValue = null, string JoinWith = null, List<Variable> JoinedVariables = null, int? Parent = null, List<Variable> SubVariables = null, int? OnsetDelay = null, int? DurationOfAction = null, int? EarliestMeasurementTime = null, int? LatestMeasurementTime = null, int? Updated = null, int? CauseOnly = null, int? NumberOfCorrelations = null, int? Outcome = null, int? MeasurementsAtLastAnalysis = null, int? NumberOfMeasurements = null, string LastUnit = null, int? LastValue = null, int? MostCommonValue = null, string MostCommonUnit = null, int? LastSource = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Variable and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "OriginalName" is required (not null)
            if (OriginalName == null)
            {
                throw new InvalidDataException("OriginalName is a required property for Variable and cannot be null");
            }
            else
            {
                this.OriginalName = OriginalName;
            }
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for Variable and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            // to ensure "AbbreviatedUnitName" is required (not null)
            if (AbbreviatedUnitName == null)
            {
                throw new InvalidDataException("AbbreviatedUnitName is a required property for Variable and cannot be null");
            }
            else
            {
                this.AbbreviatedUnitName = AbbreviatedUnitName;
            }
            // to ensure "AbbreviatedUnitId" is required (not null)
            if (AbbreviatedUnitId == null)
            {
                throw new InvalidDataException("AbbreviatedUnitId is a required property for Variable and cannot be null");
            }
            else
            {
                this.AbbreviatedUnitId = AbbreviatedUnitId;
            }
            // to ensure "Sources" is required (not null)
            if (Sources == null)
            {
                throw new InvalidDataException("Sources is a required property for Variable and cannot be null");
            }
            else
            {
                this.Sources = Sources;
            }
            // to ensure "MinimumValue" is required (not null)
            if (MinimumValue == null)
            {
                throw new InvalidDataException("MinimumValue is a required property for Variable and cannot be null");
            }
            else
            {
                this.MinimumValue = MinimumValue;
            }
            // to ensure "MaximumValue" is required (not null)
            if (MaximumValue == null)
            {
                throw new InvalidDataException("MaximumValue is a required property for Variable and cannot be null");
            }
            else
            {
                this.MaximumValue = MaximumValue;
            }
            // to ensure "CombinationOperation" is required (not null)
            if (CombinationOperation == null)
            {
                throw new InvalidDataException("CombinationOperation is a required property for Variable and cannot be null");
            }
            else
            {
                this.CombinationOperation = CombinationOperation;
            }
            // to ensure "FillingValue" is required (not null)
            if (FillingValue == null)
            {
                throw new InvalidDataException("FillingValue is a required property for Variable and cannot be null");
            }
            else
            {
                this.FillingValue = FillingValue;
            }
            // to ensure "JoinWith" is required (not null)
            if (JoinWith == null)
            {
                throw new InvalidDataException("JoinWith is a required property for Variable and cannot be null");
            }
            else
            {
                this.JoinWith = JoinWith;
            }
            // to ensure "JoinedVariables" is required (not null)
            if (JoinedVariables == null)
            {
                throw new InvalidDataException("JoinedVariables is a required property for Variable and cannot be null");
            }
            else
            {
                this.JoinedVariables = JoinedVariables;
            }
            // to ensure "Parent" is required (not null)
            if (Parent == null)
            {
                throw new InvalidDataException("Parent is a required property for Variable and cannot be null");
            }
            else
            {
                this.Parent = Parent;
            }
            // to ensure "SubVariables" is required (not null)
            if (SubVariables == null)
            {
                throw new InvalidDataException("SubVariables is a required property for Variable and cannot be null");
            }
            else
            {
                this.SubVariables = SubVariables;
            }
            // to ensure "OnsetDelay" is required (not null)
            if (OnsetDelay == null)
            {
                throw new InvalidDataException("OnsetDelay is a required property for Variable and cannot be null");
            }
            else
            {
                this.OnsetDelay = OnsetDelay;
            }
            // to ensure "DurationOfAction" is required (not null)
            if (DurationOfAction == null)
            {
                throw new InvalidDataException("DurationOfAction is a required property for Variable and cannot be null");
            }
            else
            {
                this.DurationOfAction = DurationOfAction;
            }
            // to ensure "EarliestMeasurementTime" is required (not null)
            if (EarliestMeasurementTime == null)
            {
                throw new InvalidDataException("EarliestMeasurementTime is a required property for Variable and cannot be null");
            }
            else
            {
                this.EarliestMeasurementTime = EarliestMeasurementTime;
            }
            // to ensure "LatestMeasurementTime" is required (not null)
            if (LatestMeasurementTime == null)
            {
                throw new InvalidDataException("LatestMeasurementTime is a required property for Variable and cannot be null");
            }
            else
            {
                this.LatestMeasurementTime = LatestMeasurementTime;
            }
            // to ensure "Updated" is required (not null)
            if (Updated == null)
            {
                throw new InvalidDataException("Updated is a required property for Variable and cannot be null");
            }
            else
            {
                this.Updated = Updated;
            }
            // to ensure "CauseOnly" is required (not null)
            if (CauseOnly == null)
            {
                throw new InvalidDataException("CauseOnly is a required property for Variable and cannot be null");
            }
            else
            {
                this.CauseOnly = CauseOnly;
            }
            // to ensure "NumberOfCorrelations" is required (not null)
            if (NumberOfCorrelations == null)
            {
                throw new InvalidDataException("NumberOfCorrelations is a required property for Variable and cannot be null");
            }
            else
            {
                this.NumberOfCorrelations = NumberOfCorrelations;
            }
            // to ensure "Outcome" is required (not null)
            if (Outcome == null)
            {
                throw new InvalidDataException("Outcome is a required property for Variable and cannot be null");
            }
            else
            {
                this.Outcome = Outcome;
            }
            // to ensure "MeasurementsAtLastAnalysis" is required (not null)
            if (MeasurementsAtLastAnalysis == null)
            {
                throw new InvalidDataException("MeasurementsAtLastAnalysis is a required property for Variable and cannot be null");
            }
            else
            {
                this.MeasurementsAtLastAnalysis = MeasurementsAtLastAnalysis;
            }
            // to ensure "NumberOfMeasurements" is required (not null)
            if (NumberOfMeasurements == null)
            {
                throw new InvalidDataException("NumberOfMeasurements is a required property for Variable and cannot be null");
            }
            else
            {
                this.NumberOfMeasurements = NumberOfMeasurements;
            }
            // to ensure "LastUnit" is required (not null)
            if (LastUnit == null)
            {
                throw new InvalidDataException("LastUnit is a required property for Variable and cannot be null");
            }
            else
            {
                this.LastUnit = LastUnit;
            }
            // to ensure "LastValue" is required (not null)
            if (LastValue == null)
            {
                throw new InvalidDataException("LastValue is a required property for Variable and cannot be null");
            }
            else
            {
                this.LastValue = LastValue;
            }
            // to ensure "MostCommonValue" is required (not null)
            if (MostCommonValue == null)
            {
                throw new InvalidDataException("MostCommonValue is a required property for Variable and cannot be null");
            }
            else
            {
                this.MostCommonValue = MostCommonValue;
            }
            // to ensure "MostCommonUnit" is required (not null)
            if (MostCommonUnit == null)
            {
                throw new InvalidDataException("MostCommonUnit is a required property for Variable and cannot be null");
            }
            else
            {
                this.MostCommonUnit = MostCommonUnit;
            }
            // to ensure "LastSource" is required (not null)
            if (LastSource == null)
            {
                throw new InvalidDataException("LastSource is a required property for Variable and cannot be null");
            }
            else
            {
                this.LastSource = LastSource;
            }
            this.Id = Id;
        }
        
        /// <summary>
        /// Variable ID
        /// </summary>
        /// <value>Variable ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// User-defined variable display name.
        /// </summary>
        /// <value>User-defined variable display name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Name used when the variable was originally created in the &#x60;variables&#x60; table.
        /// </summary>
        /// <value>Name used when the variable was originally created in the &#x60;variables&#x60; table.</value>
        [DataMember(Name="originalName", EmitDefaultValue=false)]
        public string OriginalName { get; set; }
        /// <summary>
        /// Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc.
        /// </summary>
        /// <value>Variable category like Mood, Sleep, Physical Activity, Treatment, Symptom, etc.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// Abbreviated name of the default unit for the variable
        /// </summary>
        /// <value>Abbreviated name of the default unit for the variable</value>
        [DataMember(Name="abbreviatedUnitName", EmitDefaultValue=false)]
        public string AbbreviatedUnitName { get; set; }
        /// <summary>
        /// Id of the default unit for the variable
        /// </summary>
        /// <value>Id of the default unit for the variable</value>
        [DataMember(Name="abbreviatedUnitId", EmitDefaultValue=false)]
        public int? AbbreviatedUnitId { get; set; }
        /// <summary>
        /// Comma-separated list of source names to limit variables to those sources
        /// </summary>
        /// <value>Comma-separated list of source names to limit variables to those sources</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public string Sources { get; set; }
        /// <summary>
        /// Minimum reasonable value for this variable (uses default unit)
        /// </summary>
        /// <value>Minimum reasonable value for this variable (uses default unit)</value>
        [DataMember(Name="minimumValue", EmitDefaultValue=false)]
        public double? MinimumValue { get; set; }
        /// <summary>
        /// Maximum reasonable value for this variable (uses default unit)
        /// </summary>
        /// <value>Maximum reasonable value for this variable (uses default unit)</value>
        [DataMember(Name="maximumValue", EmitDefaultValue=false)]
        public double? MaximumValue { get; set; }
        /// <summary>
        /// Value for replacing null measurements
        /// </summary>
        /// <value>Value for replacing null measurements</value>
        [DataMember(Name="fillingValue", EmitDefaultValue=false)]
        public double? FillingValue { get; set; }
        /// <summary>
        /// The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables.
        /// </summary>
        /// <value>The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables.</value>
        [DataMember(Name="joinWith", EmitDefaultValue=false)]
        public string JoinWith { get; set; }
        /// <summary>
        /// Array of Variables that are joined with this Variable
        /// </summary>
        /// <value>Array of Variables that are joined with this Variable</value>
        [DataMember(Name="joinedVariables", EmitDefaultValue=false)]
        public List<Variable> JoinedVariables { get; set; }
        /// <summary>
        /// Id of the parent variable if this variable has any parent
        /// </summary>
        /// <value>Id of the parent variable if this variable has any parent</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public int? Parent { get; set; }
        /// <summary>
        /// Array of Variables that are sub variables to this Variable
        /// </summary>
        /// <value>Array of Variables that are sub variables to this Variable</value>
        [DataMember(Name="subVariables", EmitDefaultValue=false)]
        public List<Variable> SubVariables { get; set; }
        /// <summary>
        /// How long it takes for a measurement in this variable to take effect
        /// </summary>
        /// <value>How long it takes for a measurement in this variable to take effect</value>
        [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
        public int? OnsetDelay { get; set; }
        /// <summary>
        /// How long the effect of a measurement in this variable lasts
        /// </summary>
        /// <value>How long the effect of a measurement in this variable lasts</value>
        [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
        public int? DurationOfAction { get; set; }
        /// <summary>
        /// Earliest measurement time
        /// </summary>
        /// <value>Earliest measurement time</value>
        [DataMember(Name="earliestMeasurementTime", EmitDefaultValue=false)]
        public int? EarliestMeasurementTime { get; set; }
        /// <summary>
        /// Latest measurement time
        /// </summary>
        /// <value>Latest measurement time</value>
        [DataMember(Name="latestMeasurementTime", EmitDefaultValue=false)]
        public int? LatestMeasurementTime { get; set; }
        /// <summary>
        /// When this variable or its settings were last updated
        /// </summary>
        /// <value>When this variable or its settings were last updated</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public int? Updated { get; set; }
        /// <summary>
        /// A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user.
        /// </summary>
        /// <value>A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user.</value>
        [DataMember(Name="causeOnly", EmitDefaultValue=false)]
        public int? CauseOnly { get; set; }
        /// <summary>
        /// Number of correlations
        /// </summary>
        /// <value>Number of correlations</value>
        [DataMember(Name="numberOfCorrelations", EmitDefaultValue=false)]
        public int? NumberOfCorrelations { get; set; }
        /// <summary>
        /// Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.
        /// </summary>
        /// <value>Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</value>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public int? Outcome { get; set; }
        /// <summary>
        /// The number of measurements that a given user had for this variable the last time a correlation calculation was performed. Generally correlation values are only updated once the current number of measurements for a variable is more than 10% greater than the measurementsAtLastAnalysis.  This avoids a computationally-demanding recalculation when there&#39;s not enough new data to make a significant difference in the correlation.
        /// </summary>
        /// <value>The number of measurements that a given user had for this variable the last time a correlation calculation was performed. Generally correlation values are only updated once the current number of measurements for a variable is more than 10% greater than the measurementsAtLastAnalysis.  This avoids a computationally-demanding recalculation when there&#39;s not enough new data to make a significant difference in the correlation.</value>
        [DataMember(Name="measurementsAtLastAnalysis", EmitDefaultValue=false)]
        public int? MeasurementsAtLastAnalysis { get; set; }
        /// <summary>
        /// Number of measurements
        /// </summary>
        /// <value>Number of measurements</value>
        [DataMember(Name="numberOfMeasurements", EmitDefaultValue=false)]
        public int? NumberOfMeasurements { get; set; }
        /// <summary>
        /// Last unit
        /// </summary>
        /// <value>Last unit</value>
        [DataMember(Name="lastUnit", EmitDefaultValue=false)]
        public string LastUnit { get; set; }
        /// <summary>
        /// Last value
        /// </summary>
        /// <value>Last value</value>
        [DataMember(Name="lastValue", EmitDefaultValue=false)]
        public int? LastValue { get; set; }
        /// <summary>
        /// Most common value
        /// </summary>
        /// <value>Most common value</value>
        [DataMember(Name="mostCommonValue", EmitDefaultValue=false)]
        public int? MostCommonValue { get; set; }
        /// <summary>
        /// Most common unit
        /// </summary>
        /// <value>Most common unit</value>
        [DataMember(Name="mostCommonUnit", EmitDefaultValue=false)]
        public string MostCommonUnit { get; set; }
        /// <summary>
        /// Last source
        /// </summary>
        /// <value>Last source</value>
        [DataMember(Name="lastSource", EmitDefaultValue=false)]
        public int? LastSource { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Variable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  AbbreviatedUnitName: ").Append(AbbreviatedUnitName).Append("\n");
            sb.Append("  AbbreviatedUnitId: ").Append(AbbreviatedUnitId).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
            sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
            sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
            sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
            sb.Append("  JoinedVariables: ").Append(JoinedVariables).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  SubVariables: ").Append(SubVariables).Append("\n");
            sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
            sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
            sb.Append("  EarliestMeasurementTime: ").Append(EarliestMeasurementTime).Append("\n");
            sb.Append("  LatestMeasurementTime: ").Append(LatestMeasurementTime).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
            sb.Append("  NumberOfCorrelations: ").Append(NumberOfCorrelations).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  MeasurementsAtLastAnalysis: ").Append(MeasurementsAtLastAnalysis).Append("\n");
            sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
            sb.Append("  LastUnit: ").Append(LastUnit).Append("\n");
            sb.Append("  LastValue: ").Append(LastValue).Append("\n");
            sb.Append("  MostCommonValue: ").Append(MostCommonValue).Append("\n");
            sb.Append("  MostCommonUnit: ").Append(MostCommonUnit).Append("\n");
            sb.Append("  LastSource: ").Append(LastSource).Append("\n");
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
            return this.Equals(obj as Variable);
        }

        /// <summary>
        /// Returns true if Variable instances are equal
        /// </summary>
        /// <param name="other">Instance of Variable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Variable other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OriginalName == other.OriginalName ||
                    this.OriginalName != null &&
                    this.OriginalName.Equals(other.OriginalName)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.AbbreviatedUnitName == other.AbbreviatedUnitName ||
                    this.AbbreviatedUnitName != null &&
                    this.AbbreviatedUnitName.Equals(other.AbbreviatedUnitName)
                ) && 
                (
                    this.AbbreviatedUnitId == other.AbbreviatedUnitId ||
                    this.AbbreviatedUnitId != null &&
                    this.AbbreviatedUnitId.Equals(other.AbbreviatedUnitId)
                ) && 
                (
                    this.Sources == other.Sources ||
                    this.Sources != null &&
                    this.Sources.Equals(other.Sources)
                ) && 
                (
                    this.MinimumValue == other.MinimumValue ||
                    this.MinimumValue != null &&
                    this.MinimumValue.Equals(other.MinimumValue)
                ) && 
                (
                    this.MaximumValue == other.MaximumValue ||
                    this.MaximumValue != null &&
                    this.MaximumValue.Equals(other.MaximumValue)
                ) && 
                (
                    this.CombinationOperation == other.CombinationOperation ||
                    this.CombinationOperation != null &&
                    this.CombinationOperation.Equals(other.CombinationOperation)
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
                    this.JoinedVariables == other.JoinedVariables ||
                    this.JoinedVariables != null &&
                    this.JoinedVariables.SequenceEqual(other.JoinedVariables)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.SubVariables == other.SubVariables ||
                    this.SubVariables != null &&
                    this.SubVariables.SequenceEqual(other.SubVariables)
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
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this.CauseOnly == other.CauseOnly ||
                    this.CauseOnly != null &&
                    this.CauseOnly.Equals(other.CauseOnly)
                ) && 
                (
                    this.NumberOfCorrelations == other.NumberOfCorrelations ||
                    this.NumberOfCorrelations != null &&
                    this.NumberOfCorrelations.Equals(other.NumberOfCorrelations)
                ) && 
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
                ) && 
                (
                    this.MeasurementsAtLastAnalysis == other.MeasurementsAtLastAnalysis ||
                    this.MeasurementsAtLastAnalysis != null &&
                    this.MeasurementsAtLastAnalysis.Equals(other.MeasurementsAtLastAnalysis)
                ) && 
                (
                    this.NumberOfMeasurements == other.NumberOfMeasurements ||
                    this.NumberOfMeasurements != null &&
                    this.NumberOfMeasurements.Equals(other.NumberOfMeasurements)
                ) && 
                (
                    this.LastUnit == other.LastUnit ||
                    this.LastUnit != null &&
                    this.LastUnit.Equals(other.LastUnit)
                ) && 
                (
                    this.LastValue == other.LastValue ||
                    this.LastValue != null &&
                    this.LastValue.Equals(other.LastValue)
                ) && 
                (
                    this.MostCommonValue == other.MostCommonValue ||
                    this.MostCommonValue != null &&
                    this.MostCommonValue.Equals(other.MostCommonValue)
                ) && 
                (
                    this.MostCommonUnit == other.MostCommonUnit ||
                    this.MostCommonUnit != null &&
                    this.MostCommonUnit.Equals(other.MostCommonUnit)
                ) && 
                (
                    this.LastSource == other.LastSource ||
                    this.LastSource != null &&
                    this.LastSource.Equals(other.LastSource)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OriginalName != null)
                    hash = hash * 59 + this.OriginalName.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.AbbreviatedUnitName != null)
                    hash = hash * 59 + this.AbbreviatedUnitName.GetHashCode();
                if (this.AbbreviatedUnitId != null)
                    hash = hash * 59 + this.AbbreviatedUnitId.GetHashCode();
                if (this.Sources != null)
                    hash = hash * 59 + this.Sources.GetHashCode();
                if (this.MinimumValue != null)
                    hash = hash * 59 + this.MinimumValue.GetHashCode();
                if (this.MaximumValue != null)
                    hash = hash * 59 + this.MaximumValue.GetHashCode();
                if (this.CombinationOperation != null)
                    hash = hash * 59 + this.CombinationOperation.GetHashCode();
                if (this.FillingValue != null)
                    hash = hash * 59 + this.FillingValue.GetHashCode();
                if (this.JoinWith != null)
                    hash = hash * 59 + this.JoinWith.GetHashCode();
                if (this.JoinedVariables != null)
                    hash = hash * 59 + this.JoinedVariables.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.SubVariables != null)
                    hash = hash * 59 + this.SubVariables.GetHashCode();
                if (this.OnsetDelay != null)
                    hash = hash * 59 + this.OnsetDelay.GetHashCode();
                if (this.DurationOfAction != null)
                    hash = hash * 59 + this.DurationOfAction.GetHashCode();
                if (this.EarliestMeasurementTime != null)
                    hash = hash * 59 + this.EarliestMeasurementTime.GetHashCode();
                if (this.LatestMeasurementTime != null)
                    hash = hash * 59 + this.LatestMeasurementTime.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.CauseOnly != null)
                    hash = hash * 59 + this.CauseOnly.GetHashCode();
                if (this.NumberOfCorrelations != null)
                    hash = hash * 59 + this.NumberOfCorrelations.GetHashCode();
                if (this.Outcome != null)
                    hash = hash * 59 + this.Outcome.GetHashCode();
                if (this.MeasurementsAtLastAnalysis != null)
                    hash = hash * 59 + this.MeasurementsAtLastAnalysis.GetHashCode();
                if (this.NumberOfMeasurements != null)
                    hash = hash * 59 + this.NumberOfMeasurements.GetHashCode();
                if (this.LastUnit != null)
                    hash = hash * 59 + this.LastUnit.GetHashCode();
                if (this.LastValue != null)
                    hash = hash * 59 + this.LastValue.GetHashCode();
                if (this.MostCommonValue != null)
                    hash = hash * 59 + this.MostCommonValue.GetHashCode();
                if (this.MostCommonUnit != null)
                    hash = hash * 59 + this.MostCommonUnit.GetHashCode();
                if (this.LastSource != null)
                    hash = hash * 59 + this.LastSource.GetHashCode();
                return hash;
            }
        }
    }

}
