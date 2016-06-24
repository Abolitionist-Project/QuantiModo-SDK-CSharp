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
    /// Connection
    /// </summary>
    [DataContract]
    public partial class Connection :  IEquatable<Connection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Connection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="Id">id.</param>
        /// <param name="UserId">ID of user that owns this correlation.</param>
        /// <param name="ConnectorId">The id for the connector data source for which the connection is connected (required).</param>
        /// <param name="ConnectStatus">Indicates whether a connector is currently connected to a service for a user..</param>
        /// <param name="ConnectError">Error message if there is a problem with authorizing this connection..</param>
        /// <param name="UpdateRequestedAt">Time at which an update was requested by a user..</param>
        /// <param name="UpdateStatus">Indicates whether a connector is currently updated..</param>
        /// <param name="UpdateError">Indicates if there was an error during the update..</param>
        /// <param name="LastSuccessfulUpdatedAt">The time at which the connector was last successfully updated..</param>
        /// <param name="CreatedAt">When the record was first created. Use ISO 8601 datetime format.</param>
        /// <param name="UpdatedAt">When the record in the database was last updated. Use ISO 8601 datetime format.</param>
        public Connection(int? Id = null, int? UserId = null, int? ConnectorId = null, string ConnectStatus = null, string ConnectError = null, DateTime? UpdateRequestedAt = null, string UpdateStatus = null, string UpdateError = null, DateTime? LastSuccessfulUpdatedAt = null, DateTime? CreatedAt = null, DateTime? UpdatedAt = null)
        {
            // to ensure "ConnectorId" is required (not null)
            if (ConnectorId == null)
            {
                throw new InvalidDataException("ConnectorId is a required property for Connection and cannot be null");
            }
            else
            {
                this.ConnectorId = ConnectorId;
            }
            this.Id = Id;
            this.UserId = UserId;
            this.ConnectStatus = ConnectStatus;
            this.ConnectError = ConnectError;
            this.UpdateRequestedAt = UpdateRequestedAt;
            this.UpdateStatus = UpdateStatus;
            this.UpdateError = UpdateError;
            this.LastSuccessfulUpdatedAt = LastSuccessfulUpdatedAt;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// ID of user that owns this correlation
        /// </summary>
        /// <value>ID of user that owns this correlation</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// The id for the connector data source for which the connection is connected
        /// </summary>
        /// <value>The id for the connector data source for which the connection is connected</value>
        [DataMember(Name="connector_id", EmitDefaultValue=false)]
        public int? ConnectorId { get; set; }
        /// <summary>
        /// Indicates whether a connector is currently connected to a service for a user.
        /// </summary>
        /// <value>Indicates whether a connector is currently connected to a service for a user.</value>
        [DataMember(Name="connect_status", EmitDefaultValue=false)]
        public string ConnectStatus { get; set; }
        /// <summary>
        /// Error message if there is a problem with authorizing this connection.
        /// </summary>
        /// <value>Error message if there is a problem with authorizing this connection.</value>
        [DataMember(Name="connect_error", EmitDefaultValue=false)]
        public string ConnectError { get; set; }
        /// <summary>
        /// Time at which an update was requested by a user.
        /// </summary>
        /// <value>Time at which an update was requested by a user.</value>
        [DataMember(Name="update_requested_at", EmitDefaultValue=false)]
        public DateTime? UpdateRequestedAt { get; set; }
        /// <summary>
        /// Indicates whether a connector is currently updated.
        /// </summary>
        /// <value>Indicates whether a connector is currently updated.</value>
        [DataMember(Name="update_status", EmitDefaultValue=false)]
        public string UpdateStatus { get; set; }
        /// <summary>
        /// Indicates if there was an error during the update.
        /// </summary>
        /// <value>Indicates if there was an error during the update.</value>
        [DataMember(Name="update_error", EmitDefaultValue=false)]
        public string UpdateError { get; set; }
        /// <summary>
        /// The time at which the connector was last successfully updated.
        /// </summary>
        /// <value>The time at which the connector was last successfully updated.</value>
        [DataMember(Name="last_successful_updated_at", EmitDefaultValue=false)]
        public DateTime? LastSuccessfulUpdatedAt { get; set; }
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
            sb.Append("class Connection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  ConnectStatus: ").Append(ConnectStatus).Append("\n");
            sb.Append("  ConnectError: ").Append(ConnectError).Append("\n");
            sb.Append("  UpdateRequestedAt: ").Append(UpdateRequestedAt).Append("\n");
            sb.Append("  UpdateStatus: ").Append(UpdateStatus).Append("\n");
            sb.Append("  UpdateError: ").Append(UpdateError).Append("\n");
            sb.Append("  LastSuccessfulUpdatedAt: ").Append(LastSuccessfulUpdatedAt).Append("\n");
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
            return this.Equals(obj as Connection);
        }

        /// <summary>
        /// Returns true if Connection instances are equal
        /// </summary>
        /// <param name="other">Instance of Connection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connection other)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.ConnectorId == other.ConnectorId ||
                    this.ConnectorId != null &&
                    this.ConnectorId.Equals(other.ConnectorId)
                ) && 
                (
                    this.ConnectStatus == other.ConnectStatus ||
                    this.ConnectStatus != null &&
                    this.ConnectStatus.Equals(other.ConnectStatus)
                ) && 
                (
                    this.ConnectError == other.ConnectError ||
                    this.ConnectError != null &&
                    this.ConnectError.Equals(other.ConnectError)
                ) && 
                (
                    this.UpdateRequestedAt == other.UpdateRequestedAt ||
                    this.UpdateRequestedAt != null &&
                    this.UpdateRequestedAt.Equals(other.UpdateRequestedAt)
                ) && 
                (
                    this.UpdateStatus == other.UpdateStatus ||
                    this.UpdateStatus != null &&
                    this.UpdateStatus.Equals(other.UpdateStatus)
                ) && 
                (
                    this.UpdateError == other.UpdateError ||
                    this.UpdateError != null &&
                    this.UpdateError.Equals(other.UpdateError)
                ) && 
                (
                    this.LastSuccessfulUpdatedAt == other.LastSuccessfulUpdatedAt ||
                    this.LastSuccessfulUpdatedAt != null &&
                    this.LastSuccessfulUpdatedAt.Equals(other.LastSuccessfulUpdatedAt)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.ConnectorId != null)
                    hash = hash * 59 + this.ConnectorId.GetHashCode();
                if (this.ConnectStatus != null)
                    hash = hash * 59 + this.ConnectStatus.GetHashCode();
                if (this.ConnectError != null)
                    hash = hash * 59 + this.ConnectError.GetHashCode();
                if (this.UpdateRequestedAt != null)
                    hash = hash * 59 + this.UpdateRequestedAt.GetHashCode();
                if (this.UpdateStatus != null)
                    hash = hash * 59 + this.UpdateStatus.GetHashCode();
                if (this.UpdateError != null)
                    hash = hash * 59 + this.UpdateError.GetHashCode();
                if (this.LastSuccessfulUpdatedAt != null)
                    hash = hash * 59 + this.LastSuccessfulUpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }
    }

}
