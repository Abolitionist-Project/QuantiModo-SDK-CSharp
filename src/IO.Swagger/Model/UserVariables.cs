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
    /// UserVariables
    /// </summary>
    [DataContract]
    public partial class UserVariables :  IEquatable<UserVariables>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariables" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserVariables() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariables" /> class.
        /// </summary>
        /// <param name="User">User ID (required).</param>
        /// <param name="VariableId">Common variable id (required).</param>
        /// <param name="DurationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect.</param>
        /// <param name="FillingValue">fillingValue.</param>
        /// <param name="JoinWith">joinWith.</param>
        /// <param name="MaximumAllowedValue">maximumAllowedValue.</param>
        /// <param name="MinimumAllowedValue">minimumAllowedValue.</param>
        /// <param name="OnsetDelay">onsetDelay.</param>
        /// <param name="ExperimentStartTime">Earliest measurement startTime that should be used in analysis in ISO format.</param>
        /// <param name="ExperimentEndTime">Latest measurement startTime that should be used in analysis in ISO format.</param>
        public UserVariables(int? User = null, int? VariableId = null, int? DurationOfAction = null, int? FillingValue = null, string JoinWith = null, float? MaximumAllowedValue = null, float? MinimumAllowedValue = null, int? OnsetDelay = null, string ExperimentStartTime = null, string ExperimentEndTime = null)
        {
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for UserVariables and cannot be null");
            }
            else
            {
                this.User = User;
            }
            // to ensure "VariableId" is required (not null)
            if (VariableId == null)
            {
                throw new InvalidDataException("VariableId is a required property for UserVariables and cannot be null");
            }
            else
            {
                this.VariableId = VariableId;
            }
            this.DurationOfAction = DurationOfAction;
            this.FillingValue = FillingValue;
            this.JoinWith = JoinWith;
            this.MaximumAllowedValue = MaximumAllowedValue;
            this.MinimumAllowedValue = MinimumAllowedValue;
            this.OnsetDelay = OnsetDelay;
            this.ExperimentStartTime = ExperimentStartTime;
            this.ExperimentEndTime = ExperimentEndTime;
        }
        
        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }
        /// <summary>
        /// Common variable id
        /// </summary>
        /// <value>Common variable id</value>
        [DataMember(Name="variableId", EmitDefaultValue=false)]
        public int? VariableId { get; set; }
        /// <summary>
        /// Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect
        /// </summary>
        /// <value>Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</value>
        [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
        public int? DurationOfAction { get; set; }
        /// <summary>
        /// fillingValue
        /// </summary>
        /// <value>fillingValue</value>
        [DataMember(Name="fillingValue", EmitDefaultValue=false)]
        public int? FillingValue { get; set; }
        /// <summary>
        /// joinWith
        /// </summary>
        /// <value>joinWith</value>
        [DataMember(Name="joinWith", EmitDefaultValue=false)]
        public string JoinWith { get; set; }
        /// <summary>
        /// maximumAllowedValue
        /// </summary>
        /// <value>maximumAllowedValue</value>
        [DataMember(Name="maximumAllowedValue", EmitDefaultValue=false)]
        public float? MaximumAllowedValue { get; set; }
        /// <summary>
        /// minimumAllowedValue
        /// </summary>
        /// <value>minimumAllowedValue</value>
        [DataMember(Name="minimumAllowedValue", EmitDefaultValue=false)]
        public float? MinimumAllowedValue { get; set; }
        /// <summary>
        /// onsetDelay
        /// </summary>
        /// <value>onsetDelay</value>
        [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
        public int? OnsetDelay { get; set; }
        /// <summary>
        /// Earliest measurement startTime that should be used in analysis in ISO format
        /// </summary>
        /// <value>Earliest measurement startTime that should be used in analysis in ISO format</value>
        [DataMember(Name="experimentStartTime", EmitDefaultValue=false)]
        public string ExperimentStartTime { get; set; }
        /// <summary>
        /// Latest measurement startTime that should be used in analysis in ISO format
        /// </summary>
        /// <value>Latest measurement startTime that should be used in analysis in ISO format</value>
        [DataMember(Name="experimentEndTime", EmitDefaultValue=false)]
        public string ExperimentEndTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserVariables {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
            sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
            sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
            sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
            sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
            sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
            sb.Append("  ExperimentStartTime: ").Append(ExperimentStartTime).Append("\n");
            sb.Append("  ExperimentEndTime: ").Append(ExperimentEndTime).Append("\n");
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
            return this.Equals(obj as UserVariables);
        }

        /// <summary>
        /// Returns true if UserVariables instances are equal
        /// </summary>
        /// <param name="other">Instance of UserVariables to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserVariables other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.VariableId == other.VariableId ||
                    this.VariableId != null &&
                    this.VariableId.Equals(other.VariableId)
                ) && 
                (
                    this.DurationOfAction == other.DurationOfAction ||
                    this.DurationOfAction != null &&
                    this.DurationOfAction.Equals(other.DurationOfAction)
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
                    this.MaximumAllowedValue == other.MaximumAllowedValue ||
                    this.MaximumAllowedValue != null &&
                    this.MaximumAllowedValue.Equals(other.MaximumAllowedValue)
                ) && 
                (
                    this.MinimumAllowedValue == other.MinimumAllowedValue ||
                    this.MinimumAllowedValue != null &&
                    this.MinimumAllowedValue.Equals(other.MinimumAllowedValue)
                ) && 
                (
                    this.OnsetDelay == other.OnsetDelay ||
                    this.OnsetDelay != null &&
                    this.OnsetDelay.Equals(other.OnsetDelay)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.VariableId != null)
                    hash = hash * 59 + this.VariableId.GetHashCode();
                if (this.DurationOfAction != null)
                    hash = hash * 59 + this.DurationOfAction.GetHashCode();
                if (this.FillingValue != null)
                    hash = hash * 59 + this.FillingValue.GetHashCode();
                if (this.JoinWith != null)
                    hash = hash * 59 + this.JoinWith.GetHashCode();
                if (this.MaximumAllowedValue != null)
                    hash = hash * 59 + this.MaximumAllowedValue.GetHashCode();
                if (this.MinimumAllowedValue != null)
                    hash = hash * 59 + this.MinimumAllowedValue.GetHashCode();
                if (this.OnsetDelay != null)
                    hash = hash * 59 + this.OnsetDelay.GetHashCode();
                if (this.ExperimentStartTime != null)
                    hash = hash * 59 + this.ExperimentStartTime.GetHashCode();
                if (this.ExperimentEndTime != null)
                    hash = hash * 59 + this.ExperimentEndTime.GetHashCode();
                return hash;
            }
        }
    }

}
