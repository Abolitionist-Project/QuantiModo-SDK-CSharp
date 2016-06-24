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
    /// Measurement
    /// </summary>
    [DataContract]
    public partial class Measurement :  IEquatable<Measurement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Measurement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Measurement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Measurement" /> class.
        /// </summary>
        /// <param name="Variable">ORIGINAL Name of the variable for which we are creating the measurement records (required).</param>
        /// <param name="Source">Application or device used to record the measurement values (required).</param>
        /// <param name="StartTime">Start Time for the measurement event in ISO 8601 (required).</param>
        /// <param name="HumanTime">Start Time for the measurement event in ISO 8601.</param>
        /// <param name="Value">Converted measurement value in requested unit (required).</param>
        /// <param name="Unit">Unit of measurement as requested in GET request (required).</param>
        /// <param name="OriginalValue">Original value.</param>
        /// <param name="StoredValue">Measurement value in the unit as orignally submitted.</param>
        /// <param name="StoredAbbreviatedUnitName">Unit of measurement as originally submitted.</param>
        /// <param name="OriginalAbbreviatedUnitName">Original Unit of measurement as originally submitted.</param>
        /// <param name="AbbreviatedUnitName">Unit of measurement as originally submitted.</param>
        /// <param name="Note">Note of measurement.</param>
        public Measurement(string Variable = null, string Source = null, string StartTime = null, HumanTime HumanTime = null, double? Value = null, string Unit = null, int? OriginalValue = null, double? StoredValue = null, string StoredAbbreviatedUnitName = null, string OriginalAbbreviatedUnitName = null, string AbbreviatedUnitName = null, string Note = null)
        {
            // to ensure "Variable" is required (not null)
            if (Variable == null)
            {
                throw new InvalidDataException("Variable is a required property for Measurement and cannot be null");
            }
            else
            {
                this.Variable = Variable;
            }
            // to ensure "Source" is required (not null)
            if (Source == null)
            {
                throw new InvalidDataException("Source is a required property for Measurement and cannot be null");
            }
            else
            {
                this.Source = Source;
            }
            // to ensure "StartTime" is required (not null)
            if (StartTime == null)
            {
                throw new InvalidDataException("StartTime is a required property for Measurement and cannot be null");
            }
            else
            {
                this.StartTime = StartTime;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for Measurement and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            // to ensure "Unit" is required (not null)
            if (Unit == null)
            {
                throw new InvalidDataException("Unit is a required property for Measurement and cannot be null");
            }
            else
            {
                this.Unit = Unit;
            }
            this.HumanTime = HumanTime;
            this.OriginalValue = OriginalValue;
            this.StoredValue = StoredValue;
            this.StoredAbbreviatedUnitName = StoredAbbreviatedUnitName;
            this.OriginalAbbreviatedUnitName = OriginalAbbreviatedUnitName;
            this.AbbreviatedUnitName = AbbreviatedUnitName;
            this.Note = Note;
        }
        
        /// <summary>
        /// ORIGINAL Name of the variable for which we are creating the measurement records
        /// </summary>
        /// <value>ORIGINAL Name of the variable for which we are creating the measurement records</value>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        public string Variable { get; set; }
        /// <summary>
        /// Application or device used to record the measurement values
        /// </summary>
        /// <value>Application or device used to record the measurement values</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
        /// <summary>
        /// Start Time for the measurement event in ISO 8601
        /// </summary>
        /// <value>Start Time for the measurement event in ISO 8601</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }
        /// <summary>
        /// Start Time for the measurement event in ISO 8601
        /// </summary>
        /// <value>Start Time for the measurement event in ISO 8601</value>
        [DataMember(Name="humanTime", EmitDefaultValue=false)]
        public HumanTime HumanTime { get; set; }
        /// <summary>
        /// Converted measurement value in requested unit
        /// </summary>
        /// <value>Converted measurement value in requested unit</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }
        /// <summary>
        /// Unit of measurement as requested in GET request
        /// </summary>
        /// <value>Unit of measurement as requested in GET request</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }
        /// <summary>
        /// Original value
        /// </summary>
        /// <value>Original value</value>
        [DataMember(Name="originalValue", EmitDefaultValue=false)]
        public int? OriginalValue { get; set; }
        /// <summary>
        /// Measurement value in the unit as orignally submitted
        /// </summary>
        /// <value>Measurement value in the unit as orignally submitted</value>
        [DataMember(Name="storedValue", EmitDefaultValue=false)]
        public double? StoredValue { get; set; }
        /// <summary>
        /// Unit of measurement as originally submitted
        /// </summary>
        /// <value>Unit of measurement as originally submitted</value>
        [DataMember(Name="storedAbbreviatedUnitName", EmitDefaultValue=false)]
        public string StoredAbbreviatedUnitName { get; set; }
        /// <summary>
        /// Original Unit of measurement as originally submitted
        /// </summary>
        /// <value>Original Unit of measurement as originally submitted</value>
        [DataMember(Name="originalAbbreviatedUnitName", EmitDefaultValue=false)]
        public string OriginalAbbreviatedUnitName { get; set; }
        /// <summary>
        /// Unit of measurement as originally submitted
        /// </summary>
        /// <value>Unit of measurement as originally submitted</value>
        [DataMember(Name="abbreviatedUnitName", EmitDefaultValue=false)]
        public string AbbreviatedUnitName { get; set; }
        /// <summary>
        /// Note of measurement
        /// </summary>
        /// <value>Note of measurement</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Measurement {\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  HumanTime: ").Append(HumanTime).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  OriginalValue: ").Append(OriginalValue).Append("\n");
            sb.Append("  StoredValue: ").Append(StoredValue).Append("\n");
            sb.Append("  StoredAbbreviatedUnitName: ").Append(StoredAbbreviatedUnitName).Append("\n");
            sb.Append("  OriginalAbbreviatedUnitName: ").Append(OriginalAbbreviatedUnitName).Append("\n");
            sb.Append("  AbbreviatedUnitName: ").Append(AbbreviatedUnitName).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return this.Equals(obj as Measurement);
        }

        /// <summary>
        /// Returns true if Measurement instances are equal
        /// </summary>
        /// <param name="other">Instance of Measurement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Measurement other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Variable == other.Variable ||
                    this.Variable != null &&
                    this.Variable.Equals(other.Variable)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.HumanTime == other.HumanTime ||
                    this.HumanTime != null &&
                    this.HumanTime.Equals(other.HumanTime)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Unit == other.Unit ||
                    this.Unit != null &&
                    this.Unit.Equals(other.Unit)
                ) && 
                (
                    this.OriginalValue == other.OriginalValue ||
                    this.OriginalValue != null &&
                    this.OriginalValue.Equals(other.OriginalValue)
                ) && 
                (
                    this.StoredValue == other.StoredValue ||
                    this.StoredValue != null &&
                    this.StoredValue.Equals(other.StoredValue)
                ) && 
                (
                    this.StoredAbbreviatedUnitName == other.StoredAbbreviatedUnitName ||
                    this.StoredAbbreviatedUnitName != null &&
                    this.StoredAbbreviatedUnitName.Equals(other.StoredAbbreviatedUnitName)
                ) && 
                (
                    this.OriginalAbbreviatedUnitName == other.OriginalAbbreviatedUnitName ||
                    this.OriginalAbbreviatedUnitName != null &&
                    this.OriginalAbbreviatedUnitName.Equals(other.OriginalAbbreviatedUnitName)
                ) && 
                (
                    this.AbbreviatedUnitName == other.AbbreviatedUnitName ||
                    this.AbbreviatedUnitName != null &&
                    this.AbbreviatedUnitName.Equals(other.AbbreviatedUnitName)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
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
                if (this.Variable != null)
                    hash = hash * 59 + this.Variable.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.HumanTime != null)
                    hash = hash * 59 + this.HumanTime.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Unit != null)
                    hash = hash * 59 + this.Unit.GetHashCode();
                if (this.OriginalValue != null)
                    hash = hash * 59 + this.OriginalValue.GetHashCode();
                if (this.StoredValue != null)
                    hash = hash * 59 + this.StoredValue.GetHashCode();
                if (this.StoredAbbreviatedUnitName != null)
                    hash = hash * 59 + this.StoredAbbreviatedUnitName.GetHashCode();
                if (this.OriginalAbbreviatedUnitName != null)
                    hash = hash * 59 + this.OriginalAbbreviatedUnitName.GetHashCode();
                if (this.AbbreviatedUnitName != null)
                    hash = hash * 59 + this.AbbreviatedUnitName.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                return hash;
            }
        }
    }

}
