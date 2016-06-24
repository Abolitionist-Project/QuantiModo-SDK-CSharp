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
    /// VariableUserSource
    /// </summary>
    [DataContract]
    public partial class VariableUserSource :  IEquatable<VariableUserSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableUserSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VariableUserSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableUserSource" /> class.
        /// </summary>
        /// <param name="UserId">ID of User.</param>
        /// <param name="VariableId">ID of variable (required).</param>
        /// <param name="SourceId">ID of source (required).</param>
        /// <param name="Timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60) (required).</param>
        /// <param name="EarliestMeasurementTime">Earliest measurement time (required).</param>
        /// <param name="LatestMeasurementTime">Latest measurement time (required).</param>
        /// <param name="CreatedAt">When the record was first created. Use ISO 8601 datetime format.</param>
        /// <param name="UpdatedAt">When the record in the database was last updated. Use ISO 8601 datetime format.</param>
        public VariableUserSource(int? UserId = null, int? VariableId = null, int? SourceId = null, int? Timestamp = null, int? EarliestMeasurementTime = null, int? LatestMeasurementTime = null, DateTime? CreatedAt = null, DateTime? UpdatedAt = null)
        {
            // to ensure "VariableId" is required (not null)
            if (VariableId == null)
            {
                throw new InvalidDataException("VariableId is a required property for VariableUserSource and cannot be null");
            }
            else
            {
                this.VariableId = VariableId;
            }
            // to ensure "SourceId" is required (not null)
            if (SourceId == null)
            {
                throw new InvalidDataException("SourceId is a required property for VariableUserSource and cannot be null");
            }
            else
            {
                this.SourceId = SourceId;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for VariableUserSource and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "EarliestMeasurementTime" is required (not null)
            if (EarliestMeasurementTime == null)
            {
                throw new InvalidDataException("EarliestMeasurementTime is a required property for VariableUserSource and cannot be null");
            }
            else
            {
                this.EarliestMeasurementTime = EarliestMeasurementTime;
            }
            // to ensure "LatestMeasurementTime" is required (not null)
            if (LatestMeasurementTime == null)
            {
                throw new InvalidDataException("LatestMeasurementTime is a required property for VariableUserSource and cannot be null");
            }
            else
            {
                this.LatestMeasurementTime = LatestMeasurementTime;
            }
            this.UserId = UserId;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// ID of User
        /// </summary>
        /// <value>ID of User</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// ID of variable
        /// </summary>
        /// <value>ID of variable</value>
        [DataMember(Name="variable_id", EmitDefaultValue=false)]
        public int? VariableId { get; set; }
        /// <summary>
        /// ID of source
        /// </summary>
        /// <value>ID of source</value>
        [DataMember(Name="source_id", EmitDefaultValue=false)]
        public int? SourceId { get; set; }
        /// <summary>
        /// Time that this measurement occurred Uses epoch minute (epoch time divided by 60)
        /// </summary>
        /// <value>Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableUserSource {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  EarliestMeasurementTime: ").Append(EarliestMeasurementTime).Append("\n");
            sb.Append("  LatestMeasurementTime: ").Append(LatestMeasurementTime).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as VariableUserSource);
        }

        /// <summary>
        /// Returns true if VariableUserSource instances are equal
        /// </summary>
        /// <param name="other">Instance of VariableUserSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableUserSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.VariableId == other.VariableId ||
                    this.VariableId != null &&
                    this.VariableId.Equals(other.VariableId)
                ) && 
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.VariableId != null)
                    hash = hash * 59 + this.VariableId.GetHashCode();
                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.EarliestMeasurementTime != null)
                    hash = hash * 59 + this.EarliestMeasurementTime.GetHashCode();
                if (this.LatestMeasurementTime != null)
                    hash = hash * 59 + this.LatestMeasurementTime.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }
    }

}
