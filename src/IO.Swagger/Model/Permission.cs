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
    /// Permission
    /// </summary>
    [DataContract]
    public partial class Permission :  IEquatable<Permission>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Permission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="Target">Grant permission to target user or public so they may access measurements within the given parameters. TODO: Rename target to something more intuitive. (required).</param>
        /// <param name="VariableName">ORIGINAL Variable name (required).</param>
        /// <param name="MinTimestamp">Earliest time when measurements will be accessible in epoch seconds (required).</param>
        /// <param name="MaxTimestamp">Latest time when measurements will be accessible in epoch seconds (required).</param>
        /// <param name="MinTimeOfDay">Earliest time of day when measurements will be accessible in epoch seconds (required).</param>
        /// <param name="MaxTimeOfDay">Latest time of day when measurements will be accessible in epoch seconds (required).</param>
        /// <param name="Week">Maybe specifies if only weekday measurements should be accessible (required).</param>
        public Permission(int? Target = null, string VariableName = null, int? MinTimestamp = null, int? MaxTimestamp = null, int? MinTimeOfDay = null, int? MaxTimeOfDay = null, string Week = null)
        {
            // to ensure "Target" is required (not null)
            if (Target == null)
            {
                throw new InvalidDataException("Target is a required property for Permission and cannot be null");
            }
            else
            {
                this.Target = Target;
            }
            // to ensure "VariableName" is required (not null)
            if (VariableName == null)
            {
                throw new InvalidDataException("VariableName is a required property for Permission and cannot be null");
            }
            else
            {
                this.VariableName = VariableName;
            }
            // to ensure "MinTimestamp" is required (not null)
            if (MinTimestamp == null)
            {
                throw new InvalidDataException("MinTimestamp is a required property for Permission and cannot be null");
            }
            else
            {
                this.MinTimestamp = MinTimestamp;
            }
            // to ensure "MaxTimestamp" is required (not null)
            if (MaxTimestamp == null)
            {
                throw new InvalidDataException("MaxTimestamp is a required property for Permission and cannot be null");
            }
            else
            {
                this.MaxTimestamp = MaxTimestamp;
            }
            // to ensure "MinTimeOfDay" is required (not null)
            if (MinTimeOfDay == null)
            {
                throw new InvalidDataException("MinTimeOfDay is a required property for Permission and cannot be null");
            }
            else
            {
                this.MinTimeOfDay = MinTimeOfDay;
            }
            // to ensure "MaxTimeOfDay" is required (not null)
            if (MaxTimeOfDay == null)
            {
                throw new InvalidDataException("MaxTimeOfDay is a required property for Permission and cannot be null");
            }
            else
            {
                this.MaxTimeOfDay = MaxTimeOfDay;
            }
            // to ensure "Week" is required (not null)
            if (Week == null)
            {
                throw new InvalidDataException("Week is a required property for Permission and cannot be null");
            }
            else
            {
                this.Week = Week;
            }
        }
        
        /// <summary>
        /// Grant permission to target user or public so they may access measurements within the given parameters. TODO: Rename target to something more intuitive.
        /// </summary>
        /// <value>Grant permission to target user or public so they may access measurements within the given parameters. TODO: Rename target to something more intuitive.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public int? Target { get; set; }
        /// <summary>
        /// ORIGINAL Variable name
        /// </summary>
        /// <value>ORIGINAL Variable name</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }
        /// <summary>
        /// Earliest time when measurements will be accessible in epoch seconds
        /// </summary>
        /// <value>Earliest time when measurements will be accessible in epoch seconds</value>
        [DataMember(Name="minTimestamp", EmitDefaultValue=false)]
        public int? MinTimestamp { get; set; }
        /// <summary>
        /// Latest time when measurements will be accessible in epoch seconds
        /// </summary>
        /// <value>Latest time when measurements will be accessible in epoch seconds</value>
        [DataMember(Name="maxTimestamp", EmitDefaultValue=false)]
        public int? MaxTimestamp { get; set; }
        /// <summary>
        /// Earliest time of day when measurements will be accessible in epoch seconds
        /// </summary>
        /// <value>Earliest time of day when measurements will be accessible in epoch seconds</value>
        [DataMember(Name="minTimeOfDay", EmitDefaultValue=false)]
        public int? MinTimeOfDay { get; set; }
        /// <summary>
        /// Latest time of day when measurements will be accessible in epoch seconds
        /// </summary>
        /// <value>Latest time of day when measurements will be accessible in epoch seconds</value>
        [DataMember(Name="maxTimeOfDay", EmitDefaultValue=false)]
        public int? MaxTimeOfDay { get; set; }
        /// <summary>
        /// Maybe specifies if only weekday measurements should be accessible
        /// </summary>
        /// <value>Maybe specifies if only weekday measurements should be accessible</value>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public string Week { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permission {\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  MinTimestamp: ").Append(MinTimestamp).Append("\n");
            sb.Append("  MaxTimestamp: ").Append(MaxTimestamp).Append("\n");
            sb.Append("  MinTimeOfDay: ").Append(MinTimeOfDay).Append("\n");
            sb.Append("  MaxTimeOfDay: ").Append(MaxTimeOfDay).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
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
            return this.Equals(obj as Permission);
        }

        /// <summary>
        /// Returns true if Permission instances are equal
        /// </summary>
        /// <param name="other">Instance of Permission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permission other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) && 
                (
                    this.VariableName == other.VariableName ||
                    this.VariableName != null &&
                    this.VariableName.Equals(other.VariableName)
                ) && 
                (
                    this.MinTimestamp == other.MinTimestamp ||
                    this.MinTimestamp != null &&
                    this.MinTimestamp.Equals(other.MinTimestamp)
                ) && 
                (
                    this.MaxTimestamp == other.MaxTimestamp ||
                    this.MaxTimestamp != null &&
                    this.MaxTimestamp.Equals(other.MaxTimestamp)
                ) && 
                (
                    this.MinTimeOfDay == other.MinTimeOfDay ||
                    this.MinTimeOfDay != null &&
                    this.MinTimeOfDay.Equals(other.MinTimeOfDay)
                ) && 
                (
                    this.MaxTimeOfDay == other.MaxTimeOfDay ||
                    this.MaxTimeOfDay != null &&
                    this.MaxTimeOfDay.Equals(other.MaxTimeOfDay)
                ) && 
                (
                    this.Week == other.Week ||
                    this.Week != null &&
                    this.Week.Equals(other.Week)
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
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                if (this.VariableName != null)
                    hash = hash * 59 + this.VariableName.GetHashCode();
                if (this.MinTimestamp != null)
                    hash = hash * 59 + this.MinTimestamp.GetHashCode();
                if (this.MaxTimestamp != null)
                    hash = hash * 59 + this.MaxTimestamp.GetHashCode();
                if (this.MinTimeOfDay != null)
                    hash = hash * 59 + this.MinTimeOfDay.GetHashCode();
                if (this.MaxTimeOfDay != null)
                    hash = hash * 59 + this.MaxTimeOfDay.GetHashCode();
                if (this.Week != null)
                    hash = hash * 59 + this.Week.GetHashCode();
                return hash;
            }
        }
    }

}
