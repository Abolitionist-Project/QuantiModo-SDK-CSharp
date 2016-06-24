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
    /// TrackingReminderNotification
    /// </summary>
    [DataContract]
    public partial class TrackingReminderNotification :  IEquatable<TrackingReminderNotification>
    {
        /// <summary>
        /// The way multiple measurements are aggregated over time
        /// </summary>
        /// <value>The way multiple measurements are aggregated over time</value>
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
        /// The way multiple measurements are aggregated over time
        /// </summary>
        /// <value>The way multiple measurements are aggregated over time</value>
        [DataMember(Name="combinationOperation", EmitDefaultValue=false)]
        public CombinationOperationEnum? CombinationOperation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingReminderNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackingReminderNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingReminderNotification" /> class.
        /// </summary>
        /// <param name="Id">id for the specific PENDING tracking remidner (required).</param>
        /// <param name="TrackingReminderId">id for the repeating tracking remidner (required).</param>
        /// <param name="ClientId">clientId.</param>
        /// <param name="UserId">ID of User.</param>
        /// <param name="VariableId">Id for the variable to be tracked.</param>
        /// <param name="PendingReminderTime">ISO 8601 timestamp for the specific time the variable should be tracked in UTC.  This will be used for the measurement startTime if the track endpoint is used..</param>
        /// <param name="DefaultValue">Default value to use for the measurement when tracking.</param>
        /// <param name="ReminderSound">String identifier for the sound to accompany the reminder.</param>
        /// <param name="PopUp">True if the reminders should appear as a popup notification.</param>
        /// <param name="Sms">True if the reminders should be delivered via SMS.</param>
        /// <param name="Email">True if the reminders should be delivered via email.</param>
        /// <param name="NotificationBar">True if the reminders should appear in the notification bar.</param>
        /// <param name="UpdatedAt">When the record in the database was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local..</param>
        /// <param name="VariableName">Name of the variable to be used when sending measurements.</param>
        /// <param name="VariableCategoryName">Name of the variable category to be used when sending measurements.</param>
        /// <param name="AbbreviatedUnitName">Abbreviated name of the unit to be used when sending measurements.</param>
        /// <param name="CombinationOperation">The way multiple measurements are aggregated over time.</param>
        public TrackingReminderNotification(int? Id = null, int? TrackingReminderId = null, string ClientId = null, int? UserId = null, int? VariableId = null, DateTime? PendingReminderTime = null, float? DefaultValue = null, string ReminderSound = null, bool? PopUp = null, bool? Sms = null, bool? Email = null, bool? NotificationBar = null, DateTime? UpdatedAt = null, string VariableName = null, string VariableCategoryName = null, string AbbreviatedUnitName = null, CombinationOperationEnum? CombinationOperation = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for TrackingReminderNotification and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "TrackingReminderId" is required (not null)
            if (TrackingReminderId == null)
            {
                throw new InvalidDataException("TrackingReminderId is a required property for TrackingReminderNotification and cannot be null");
            }
            else
            {
                this.TrackingReminderId = TrackingReminderId;
            }
            this.ClientId = ClientId;
            this.UserId = UserId;
            this.VariableId = VariableId;
            this.PendingReminderTime = PendingReminderTime;
            this.DefaultValue = DefaultValue;
            this.ReminderSound = ReminderSound;
            this.PopUp = PopUp;
            this.Sms = Sms;
            this.Email = Email;
            this.NotificationBar = NotificationBar;
            this.UpdatedAt = UpdatedAt;
            this.VariableName = VariableName;
            this.VariableCategoryName = VariableCategoryName;
            this.AbbreviatedUnitName = AbbreviatedUnitName;
            this.CombinationOperation = CombinationOperation;
        }
        
        /// <summary>
        /// id for the specific PENDING tracking remidner
        /// </summary>
        /// <value>id for the specific PENDING tracking remidner</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// id for the repeating tracking remidner
        /// </summary>
        /// <value>id for the repeating tracking remidner</value>
        [DataMember(Name="trackingReminderId", EmitDefaultValue=false)]
        public int? TrackingReminderId { get; set; }
        /// <summary>
        /// clientId
        /// </summary>
        /// <value>clientId</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }
        /// <summary>
        /// ID of User
        /// </summary>
        /// <value>ID of User</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Id for the variable to be tracked
        /// </summary>
        /// <value>Id for the variable to be tracked</value>
        [DataMember(Name="variableId", EmitDefaultValue=false)]
        public int? VariableId { get; set; }
        /// <summary>
        /// ISO 8601 timestamp for the specific time the variable should be tracked in UTC.  This will be used for the measurement startTime if the track endpoint is used.
        /// </summary>
        /// <value>ISO 8601 timestamp for the specific time the variable should be tracked in UTC.  This will be used for the measurement startTime if the track endpoint is used.</value>
        [DataMember(Name="pendingReminderTime", EmitDefaultValue=false)]
        public DateTime? PendingReminderTime { get; set; }
        /// <summary>
        /// Default value to use for the measurement when tracking
        /// </summary>
        /// <value>Default value to use for the measurement when tracking</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public float? DefaultValue { get; set; }
        /// <summary>
        /// String identifier for the sound to accompany the reminder
        /// </summary>
        /// <value>String identifier for the sound to accompany the reminder</value>
        [DataMember(Name="reminderSound", EmitDefaultValue=false)]
        public string ReminderSound { get; set; }
        /// <summary>
        /// True if the reminders should appear as a popup notification
        /// </summary>
        /// <value>True if the reminders should appear as a popup notification</value>
        [DataMember(Name="popUp", EmitDefaultValue=false)]
        public bool? PopUp { get; set; }
        /// <summary>
        /// True if the reminders should be delivered via SMS
        /// </summary>
        /// <value>True if the reminders should be delivered via SMS</value>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public bool? Sms { get; set; }
        /// <summary>
        /// True if the reminders should be delivered via email
        /// </summary>
        /// <value>True if the reminders should be delivered via email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public bool? Email { get; set; }
        /// <summary>
        /// True if the reminders should appear in the notification bar
        /// </summary>
        /// <value>True if the reminders should appear in the notification bar</value>
        [DataMember(Name="notificationBar", EmitDefaultValue=false)]
        public bool? NotificationBar { get; set; }
        /// <summary>
        /// When the record in the database was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.
        /// </summary>
        /// <value>When the record in the database was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// Name of the variable to be used when sending measurements
        /// </summary>
        /// <value>Name of the variable to be used when sending measurements</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }
        /// <summary>
        /// Name of the variable category to be used when sending measurements
        /// </summary>
        /// <value>Name of the variable category to be used when sending measurements</value>
        [DataMember(Name="variableCategoryName", EmitDefaultValue=false)]
        public string VariableCategoryName { get; set; }
        /// <summary>
        /// Abbreviated name of the unit to be used when sending measurements
        /// </summary>
        /// <value>Abbreviated name of the unit to be used when sending measurements</value>
        [DataMember(Name="abbreviatedUnitName", EmitDefaultValue=false)]
        public string AbbreviatedUnitName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingReminderNotification {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TrackingReminderId: ").Append(TrackingReminderId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  PendingReminderTime: ").Append(PendingReminderTime).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  ReminderSound: ").Append(ReminderSound).Append("\n");
            sb.Append("  PopUp: ").Append(PopUp).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NotificationBar: ").Append(NotificationBar).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  VariableCategoryName: ").Append(VariableCategoryName).Append("\n");
            sb.Append("  AbbreviatedUnitName: ").Append(AbbreviatedUnitName).Append("\n");
            sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
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
            return this.Equals(obj as TrackingReminderNotification);
        }

        /// <summary>
        /// Returns true if TrackingReminderNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of TrackingReminderNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingReminderNotification other)
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
                    this.TrackingReminderId == other.TrackingReminderId ||
                    this.TrackingReminderId != null &&
                    this.TrackingReminderId.Equals(other.TrackingReminderId)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
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
                    this.PendingReminderTime == other.PendingReminderTime ||
                    this.PendingReminderTime != null &&
                    this.PendingReminderTime.Equals(other.PendingReminderTime)
                ) && 
                (
                    this.DefaultValue == other.DefaultValue ||
                    this.DefaultValue != null &&
                    this.DefaultValue.Equals(other.DefaultValue)
                ) && 
                (
                    this.ReminderSound == other.ReminderSound ||
                    this.ReminderSound != null &&
                    this.ReminderSound.Equals(other.ReminderSound)
                ) && 
                (
                    this.PopUp == other.PopUp ||
                    this.PopUp != null &&
                    this.PopUp.Equals(other.PopUp)
                ) && 
                (
                    this.Sms == other.Sms ||
                    this.Sms != null &&
                    this.Sms.Equals(other.Sms)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.NotificationBar == other.NotificationBar ||
                    this.NotificationBar != null &&
                    this.NotificationBar.Equals(other.NotificationBar)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.VariableName == other.VariableName ||
                    this.VariableName != null &&
                    this.VariableName.Equals(other.VariableName)
                ) && 
                (
                    this.VariableCategoryName == other.VariableCategoryName ||
                    this.VariableCategoryName != null &&
                    this.VariableCategoryName.Equals(other.VariableCategoryName)
                ) && 
                (
                    this.AbbreviatedUnitName == other.AbbreviatedUnitName ||
                    this.AbbreviatedUnitName != null &&
                    this.AbbreviatedUnitName.Equals(other.AbbreviatedUnitName)
                ) && 
                (
                    this.CombinationOperation == other.CombinationOperation ||
                    this.CombinationOperation != null &&
                    this.CombinationOperation.Equals(other.CombinationOperation)
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
                if (this.TrackingReminderId != null)
                    hash = hash * 59 + this.TrackingReminderId.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.VariableId != null)
                    hash = hash * 59 + this.VariableId.GetHashCode();
                if (this.PendingReminderTime != null)
                    hash = hash * 59 + this.PendingReminderTime.GetHashCode();
                if (this.DefaultValue != null)
                    hash = hash * 59 + this.DefaultValue.GetHashCode();
                if (this.ReminderSound != null)
                    hash = hash * 59 + this.ReminderSound.GetHashCode();
                if (this.PopUp != null)
                    hash = hash * 59 + this.PopUp.GetHashCode();
                if (this.Sms != null)
                    hash = hash * 59 + this.Sms.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.NotificationBar != null)
                    hash = hash * 59 + this.NotificationBar.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.VariableName != null)
                    hash = hash * 59 + this.VariableName.GetHashCode();
                if (this.VariableCategoryName != null)
                    hash = hash * 59 + this.VariableCategoryName.GetHashCode();
                if (this.AbbreviatedUnitName != null)
                    hash = hash * 59 + this.AbbreviatedUnitName.GetHashCode();
                if (this.CombinationOperation != null)
                    hash = hash * 59 + this.CombinationOperation.GetHashCode();
                return hash;
            }
        }
    }

}
