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
    /// MeasurementSet
    /// </summary>
    [DataContract]
    public partial class MeasurementSet :  IEquatable<MeasurementSet>
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
        /// Initializes a new instance of the <see cref="MeasurementSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MeasurementSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementSet" /> class.
        /// </summary>
        /// <param name="Measurements">Array of timestamps, values, and optional notes (required).</param>
        /// <param name="VariableName">ORIGINAL name of the variable for which we are creating the measurement records (required).</param>
        /// <param name="SourceName">Name of the application or device used to record the measurement values (required).</param>
        /// <param name="VariableCategoryName">Variable category name.</param>
        /// <param name="CombinationOperation">Way to aggregate measurements over time. Options are \&quot;MEAN\&quot; or \&quot;SUM\&quot;.  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED..</param>
        /// <param name="AbbreviatedUnitName">Unit of measurement (required).</param>
        public MeasurementSet(List<ValueObject> Measurements = null, string VariableName = null, string SourceName = null, string VariableCategoryName = null, CombinationOperationEnum? CombinationOperation = null, string AbbreviatedUnitName = null)
        {
            // to ensure "Measurements" is required (not null)
            if (Measurements == null)
            {
                throw new InvalidDataException("Measurements is a required property for MeasurementSet and cannot be null");
            }
            else
            {
                this.Measurements = Measurements;
            }
            // to ensure "VariableName" is required (not null)
            if (VariableName == null)
            {
                throw new InvalidDataException("VariableName is a required property for MeasurementSet and cannot be null");
            }
            else
            {
                this.VariableName = VariableName;
            }
            // to ensure "SourceName" is required (not null)
            if (SourceName == null)
            {
                throw new InvalidDataException("SourceName is a required property for MeasurementSet and cannot be null");
            }
            else
            {
                this.SourceName = SourceName;
            }
            // to ensure "AbbreviatedUnitName" is required (not null)
            if (AbbreviatedUnitName == null)
            {
                throw new InvalidDataException("AbbreviatedUnitName is a required property for MeasurementSet and cannot be null");
            }
            else
            {
                this.AbbreviatedUnitName = AbbreviatedUnitName;
            }
            this.VariableCategoryName = VariableCategoryName;
            this.CombinationOperation = CombinationOperation;
        }
        
        /// <summary>
        /// Array of timestamps, values, and optional notes
        /// </summary>
        /// <value>Array of timestamps, values, and optional notes</value>
        [DataMember(Name="measurements", EmitDefaultValue=false)]
        public List<ValueObject> Measurements { get; set; }
        /// <summary>
        /// ORIGINAL name of the variable for which we are creating the measurement records
        /// </summary>
        /// <value>ORIGINAL name of the variable for which we are creating the measurement records</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }
        /// <summary>
        /// Name of the application or device used to record the measurement values
        /// </summary>
        /// <value>Name of the application or device used to record the measurement values</value>
        [DataMember(Name="sourceName", EmitDefaultValue=false)]
        public string SourceName { get; set; }
        /// <summary>
        /// Variable category name
        /// </summary>
        /// <value>Variable category name</value>
        [DataMember(Name="variableCategoryName", EmitDefaultValue=false)]
        public string VariableCategoryName { get; set; }
        /// <summary>
        /// Unit of measurement
        /// </summary>
        /// <value>Unit of measurement</value>
        [DataMember(Name="abbreviatedUnitName", EmitDefaultValue=false)]
        public string AbbreviatedUnitName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeasurementSet {\n");
            sb.Append("  Measurements: ").Append(Measurements).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
            sb.Append("  VariableCategoryName: ").Append(VariableCategoryName).Append("\n");
            sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
            sb.Append("  AbbreviatedUnitName: ").Append(AbbreviatedUnitName).Append("\n");
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
            return this.Equals(obj as MeasurementSet);
        }

        /// <summary>
        /// Returns true if MeasurementSet instances are equal
        /// </summary>
        /// <param name="other">Instance of MeasurementSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeasurementSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Measurements == other.Measurements ||
                    this.Measurements != null &&
                    this.Measurements.SequenceEqual(other.Measurements)
                ) && 
                (
                    this.VariableName == other.VariableName ||
                    this.VariableName != null &&
                    this.VariableName.Equals(other.VariableName)
                ) && 
                (
                    this.SourceName == other.SourceName ||
                    this.SourceName != null &&
                    this.SourceName.Equals(other.SourceName)
                ) && 
                (
                    this.VariableCategoryName == other.VariableCategoryName ||
                    this.VariableCategoryName != null &&
                    this.VariableCategoryName.Equals(other.VariableCategoryName)
                ) && 
                (
                    this.CombinationOperation == other.CombinationOperation ||
                    this.CombinationOperation != null &&
                    this.CombinationOperation.Equals(other.CombinationOperation)
                ) && 
                (
                    this.AbbreviatedUnitName == other.AbbreviatedUnitName ||
                    this.AbbreviatedUnitName != null &&
                    this.AbbreviatedUnitName.Equals(other.AbbreviatedUnitName)
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
                if (this.Measurements != null)
                    hash = hash * 59 + this.Measurements.GetHashCode();
                if (this.VariableName != null)
                    hash = hash * 59 + this.VariableName.GetHashCode();
                if (this.SourceName != null)
                    hash = hash * 59 + this.SourceName.GetHashCode();
                if (this.VariableCategoryName != null)
                    hash = hash * 59 + this.VariableCategoryName.GetHashCode();
                if (this.CombinationOperation != null)
                    hash = hash * 59 + this.CombinationOperation.GetHashCode();
                if (this.AbbreviatedUnitName != null)
                    hash = hash * 59 + this.AbbreviatedUnitName.GetHashCode();
                return hash;
            }
        }
    }

}
