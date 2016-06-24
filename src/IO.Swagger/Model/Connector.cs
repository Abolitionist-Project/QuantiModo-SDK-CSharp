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
    /// Connector
    /// </summary>
    [DataContract]
    public partial class Connector :  IEquatable<Connector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Connector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Connector() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Connector" /> class.
        /// </summary>
        /// <param name="Id">Connector ID number (required).</param>
        /// <param name="Name">Connector lowercase system name (required).</param>
        /// <param name="DisplayName">Connector pretty display name (required).</param>
        /// <param name="Image">URL to the image of the connector logo (required).</param>
        /// <param name="GetItUrl">URL to a site where one can get this device or application (required).</param>
        /// <param name="Connected">True if the authenticated user has this connector enabled (required).</param>
        /// <param name="ConnectInstructions">URL and parameters used when connecting to a service (required).</param>
        /// <param name="LastUpdate">Epoch timestamp of last sync (required).</param>
        /// <param name="TotalMeasurementsInLastUpdate">Number of measurements obtained during latest update (required).</param>
        /// <param name="NoDataYet">True if user has no measurements for this connector (required).</param>
        public Connector(int? Id = null, string Name = null, string DisplayName = null, string Image = null, string GetItUrl = null, string Connected = null, string ConnectInstructions = null, int? LastUpdate = null, int? TotalMeasurementsInLastUpdate = null, bool? NoDataYet = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Connector and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Connector and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for Connector and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            // to ensure "Image" is required (not null)
            if (Image == null)
            {
                throw new InvalidDataException("Image is a required property for Connector and cannot be null");
            }
            else
            {
                this.Image = Image;
            }
            // to ensure "GetItUrl" is required (not null)
            if (GetItUrl == null)
            {
                throw new InvalidDataException("GetItUrl is a required property for Connector and cannot be null");
            }
            else
            {
                this.GetItUrl = GetItUrl;
            }
            // to ensure "Connected" is required (not null)
            if (Connected == null)
            {
                throw new InvalidDataException("Connected is a required property for Connector and cannot be null");
            }
            else
            {
                this.Connected = Connected;
            }
            // to ensure "ConnectInstructions" is required (not null)
            if (ConnectInstructions == null)
            {
                throw new InvalidDataException("ConnectInstructions is a required property for Connector and cannot be null");
            }
            else
            {
                this.ConnectInstructions = ConnectInstructions;
            }
            // to ensure "LastUpdate" is required (not null)
            if (LastUpdate == null)
            {
                throw new InvalidDataException("LastUpdate is a required property for Connector and cannot be null");
            }
            else
            {
                this.LastUpdate = LastUpdate;
            }
            // to ensure "TotalMeasurementsInLastUpdate" is required (not null)
            if (TotalMeasurementsInLastUpdate == null)
            {
                throw new InvalidDataException("TotalMeasurementsInLastUpdate is a required property for Connector and cannot be null");
            }
            else
            {
                this.TotalMeasurementsInLastUpdate = TotalMeasurementsInLastUpdate;
            }
            // to ensure "NoDataYet" is required (not null)
            if (NoDataYet == null)
            {
                throw new InvalidDataException("NoDataYet is a required property for Connector and cannot be null");
            }
            else
            {
                this.NoDataYet = NoDataYet;
            }
        }
        
        /// <summary>
        /// Connector ID number
        /// </summary>
        /// <value>Connector ID number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Connector lowercase system name
        /// </summary>
        /// <value>Connector lowercase system name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Connector pretty display name
        /// </summary>
        /// <value>Connector pretty display name</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// URL to the image of the connector logo
        /// </summary>
        /// <value>URL to the image of the connector logo</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
        /// <summary>
        /// URL to a site where one can get this device or application
        /// </summary>
        /// <value>URL to a site where one can get this device or application</value>
        [DataMember(Name="getItUrl", EmitDefaultValue=false)]
        public string GetItUrl { get; set; }
        /// <summary>
        /// True if the authenticated user has this connector enabled
        /// </summary>
        /// <value>True if the authenticated user has this connector enabled</value>
        [DataMember(Name="connected", EmitDefaultValue=false)]
        public string Connected { get; set; }
        /// <summary>
        /// URL and parameters used when connecting to a service
        /// </summary>
        /// <value>URL and parameters used when connecting to a service</value>
        [DataMember(Name="connectInstructions", EmitDefaultValue=false)]
        public string ConnectInstructions { get; set; }
        /// <summary>
        /// Epoch timestamp of last sync
        /// </summary>
        /// <value>Epoch timestamp of last sync</value>
        [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
        public int? LastUpdate { get; set; }
        /// <summary>
        /// Number of measurements obtained during latest update
        /// </summary>
        /// <value>Number of measurements obtained during latest update</value>
        [DataMember(Name="totalMeasurementsInLastUpdate", EmitDefaultValue=false)]
        public int? TotalMeasurementsInLastUpdate { get; set; }
        /// <summary>
        /// True if user has no measurements for this connector
        /// </summary>
        /// <value>True if user has no measurements for this connector</value>
        [DataMember(Name="noDataYet", EmitDefaultValue=false)]
        public bool? NoDataYet { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Connector {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  GetItUrl: ").Append(GetItUrl).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  ConnectInstructions: ").Append(ConnectInstructions).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  TotalMeasurementsInLastUpdate: ").Append(TotalMeasurementsInLastUpdate).Append("\n");
            sb.Append("  NoDataYet: ").Append(NoDataYet).Append("\n");
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
            return this.Equals(obj as Connector);
        }

        /// <summary>
        /// Returns true if Connector instances are equal
        /// </summary>
        /// <param name="other">Instance of Connector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connector other)
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
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.GetItUrl == other.GetItUrl ||
                    this.GetItUrl != null &&
                    this.GetItUrl.Equals(other.GetItUrl)
                ) && 
                (
                    this.Connected == other.Connected ||
                    this.Connected != null &&
                    this.Connected.Equals(other.Connected)
                ) && 
                (
                    this.ConnectInstructions == other.ConnectInstructions ||
                    this.ConnectInstructions != null &&
                    this.ConnectInstructions.Equals(other.ConnectInstructions)
                ) && 
                (
                    this.LastUpdate == other.LastUpdate ||
                    this.LastUpdate != null &&
                    this.LastUpdate.Equals(other.LastUpdate)
                ) && 
                (
                    this.TotalMeasurementsInLastUpdate == other.TotalMeasurementsInLastUpdate ||
                    this.TotalMeasurementsInLastUpdate != null &&
                    this.TotalMeasurementsInLastUpdate.Equals(other.TotalMeasurementsInLastUpdate)
                ) && 
                (
                    this.NoDataYet == other.NoDataYet ||
                    this.NoDataYet != null &&
                    this.NoDataYet.Equals(other.NoDataYet)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.GetItUrl != null)
                    hash = hash * 59 + this.GetItUrl.GetHashCode();
                if (this.Connected != null)
                    hash = hash * 59 + this.Connected.GetHashCode();
                if (this.ConnectInstructions != null)
                    hash = hash * 59 + this.ConnectInstructions.GetHashCode();
                if (this.LastUpdate != null)
                    hash = hash * 59 + this.LastUpdate.GetHashCode();
                if (this.TotalMeasurementsInLastUpdate != null)
                    hash = hash * 59 + this.TotalMeasurementsInLastUpdate.GetHashCode();
                if (this.NoDataYet != null)
                    hash = hash * 59 + this.NoDataYet.GetHashCode();
                return hash;
            }
        }
    }

}
