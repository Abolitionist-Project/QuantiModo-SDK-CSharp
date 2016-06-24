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
    /// UserVariableRelationship
    /// </summary>
    [DataContract]
    public partial class UserVariableRelationship :  IEquatable<UserVariableRelationship>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableRelationship" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserVariableRelationship() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableRelationship" /> class.
        /// </summary>
        /// <param name="Id">id.</param>
        /// <param name="ConfidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (required).</param>
        /// <param name="ConfidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors (required).</param>
        /// <param name="Direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values. (required).</param>
        /// <param name="DurationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay (required).</param>
        /// <param name="ErrorMessage">error_message.</param>
        /// <param name="OnsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed.</param>
        /// <param name="OutcomeVariableId">Variable ID for the outcome variable (required).</param>
        /// <param name="PredictorVariableId">Variable ID for the predictor variable (required).</param>
        /// <param name="PredictorUnitId">ID for default unit of the predictor variable (required).</param>
        /// <param name="SinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting. (required).</param>
        /// <param name="StrengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores. (required).</param>
        /// <param name="StrengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome. (required).</param>
        /// <param name="UserId">user_id.</param>
        /// <param name="Vote">vote.</param>
        /// <param name="ValuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value (required).</param>
        /// <param name="ValuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value (required).</param>
        public UserVariableRelationship(int? Id = null, string ConfidenceLevel = null, float? ConfidenceScore = null, string Direction = null, int? DurationOfAction = null, string ErrorMessage = null, int? OnsetDelay = null, int? OutcomeVariableId = null, int? PredictorVariableId = null, int? PredictorUnitId = null, float? SinnRank = null, string StrengthLevel = null, float? StrengthScore = null, int? UserId = null, string Vote = null, float? ValuePredictingHighOutcome = null, float? ValuePredictingLowOutcome = null)
        {
            // to ensure "ConfidenceLevel" is required (not null)
            if (ConfidenceLevel == null)
            {
                throw new InvalidDataException("ConfidenceLevel is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.ConfidenceLevel = ConfidenceLevel;
            }
            // to ensure "ConfidenceScore" is required (not null)
            if (ConfidenceScore == null)
            {
                throw new InvalidDataException("ConfidenceScore is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.ConfidenceScore = ConfidenceScore;
            }
            // to ensure "Direction" is required (not null)
            if (Direction == null)
            {
                throw new InvalidDataException("Direction is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.Direction = Direction;
            }
            // to ensure "DurationOfAction" is required (not null)
            if (DurationOfAction == null)
            {
                throw new InvalidDataException("DurationOfAction is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.DurationOfAction = DurationOfAction;
            }
            // to ensure "OutcomeVariableId" is required (not null)
            if (OutcomeVariableId == null)
            {
                throw new InvalidDataException("OutcomeVariableId is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.OutcomeVariableId = OutcomeVariableId;
            }
            // to ensure "PredictorVariableId" is required (not null)
            if (PredictorVariableId == null)
            {
                throw new InvalidDataException("PredictorVariableId is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.PredictorVariableId = PredictorVariableId;
            }
            // to ensure "PredictorUnitId" is required (not null)
            if (PredictorUnitId == null)
            {
                throw new InvalidDataException("PredictorUnitId is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.PredictorUnitId = PredictorUnitId;
            }
            // to ensure "SinnRank" is required (not null)
            if (SinnRank == null)
            {
                throw new InvalidDataException("SinnRank is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.SinnRank = SinnRank;
            }
            // to ensure "StrengthLevel" is required (not null)
            if (StrengthLevel == null)
            {
                throw new InvalidDataException("StrengthLevel is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.StrengthLevel = StrengthLevel;
            }
            // to ensure "StrengthScore" is required (not null)
            if (StrengthScore == null)
            {
                throw new InvalidDataException("StrengthScore is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.StrengthScore = StrengthScore;
            }
            // to ensure "ValuePredictingHighOutcome" is required (not null)
            if (ValuePredictingHighOutcome == null)
            {
                throw new InvalidDataException("ValuePredictingHighOutcome is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.ValuePredictingHighOutcome = ValuePredictingHighOutcome;
            }
            // to ensure "ValuePredictingLowOutcome" is required (not null)
            if (ValuePredictingLowOutcome == null)
            {
                throw new InvalidDataException("ValuePredictingLowOutcome is a required property for UserVariableRelationship and cannot be null");
            }
            else
            {
                this.ValuePredictingLowOutcome = ValuePredictingLowOutcome;
            }
            this.Id = Id;
            this.ErrorMessage = ErrorMessage;
            this.OnsetDelay = OnsetDelay;
            this.UserId = UserId;
            this.Vote = Vote;
        }
        
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors
        /// </summary>
        /// <value>Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</value>
        [DataMember(Name="confidence_level", EmitDefaultValue=false)]
        public string ConfidenceLevel { get; set; }
        /// <summary>
        /// A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors
        /// </summary>
        /// <value>A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</value>
        [DataMember(Name="confidence_score", EmitDefaultValue=false)]
        public float? ConfidenceScore { get; set; }
        /// <summary>
        /// Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.
        /// </summary>
        /// <value>Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }
        /// <summary>
        /// Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay
        /// </summary>
        /// <value>Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</value>
        [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
        public int? DurationOfAction { get; set; }
        /// <summary>
        /// error_message
        /// </summary>
        /// <value>error_message</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed
        /// </summary>
        /// <value>User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</value>
        [DataMember(Name="onset_delay", EmitDefaultValue=false)]
        public int? OnsetDelay { get; set; }
        /// <summary>
        /// Variable ID for the outcome variable
        /// </summary>
        /// <value>Variable ID for the outcome variable</value>
        [DataMember(Name="outcome_variable_id", EmitDefaultValue=false)]
        public int? OutcomeVariableId { get; set; }
        /// <summary>
        /// Variable ID for the predictor variable
        /// </summary>
        /// <value>Variable ID for the predictor variable</value>
        [DataMember(Name="predictor_variable_id", EmitDefaultValue=false)]
        public int? PredictorVariableId { get; set; }
        /// <summary>
        /// ID for default unit of the predictor variable
        /// </summary>
        /// <value>ID for default unit of the predictor variable</value>
        [DataMember(Name="predictor_unit_id", EmitDefaultValue=false)]
        public int? PredictorUnitId { get; set; }
        /// <summary>
        /// A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.
        /// </summary>
        /// <value>A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</value>
        [DataMember(Name="sinn_rank", EmitDefaultValue=false)]
        public float? SinnRank { get; set; }
        /// <summary>
        /// Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.
        /// </summary>
        /// <value>Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</value>
        [DataMember(Name="strength_level", EmitDefaultValue=false)]
        public string StrengthLevel { get; set; }
        /// <summary>
        /// A value represented to the size of the effect which the predictor appears to have on the outcome.
        /// </summary>
        /// <value>A value represented to the size of the effect which the predictor appears to have on the outcome.</value>
        [DataMember(Name="strength_score", EmitDefaultValue=false)]
        public float? StrengthScore { get; set; }
        /// <summary>
        /// user_id
        /// </summary>
        /// <value>user_id</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// vote
        /// </summary>
        /// <value>vote</value>
        [DataMember(Name="vote", EmitDefaultValue=false)]
        public string Vote { get; set; }
        /// <summary>
        /// Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value
        /// </summary>
        /// <value>Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</value>
        [DataMember(Name="value_predicting_high_outcome", EmitDefaultValue=false)]
        public float? ValuePredictingHighOutcome { get; set; }
        /// <summary>
        /// Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value
        /// </summary>
        /// <value>Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</value>
        [DataMember(Name="value_predicting_low_outcome", EmitDefaultValue=false)]
        public float? ValuePredictingLowOutcome { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserVariableRelationship {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConfidenceLevel: ").Append(ConfidenceLevel).Append("\n");
            sb.Append("  ConfidenceScore: ").Append(ConfidenceScore).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
            sb.Append("  OutcomeVariableId: ").Append(OutcomeVariableId).Append("\n");
            sb.Append("  PredictorVariableId: ").Append(PredictorVariableId).Append("\n");
            sb.Append("  PredictorUnitId: ").Append(PredictorUnitId).Append("\n");
            sb.Append("  SinnRank: ").Append(SinnRank).Append("\n");
            sb.Append("  StrengthLevel: ").Append(StrengthLevel).Append("\n");
            sb.Append("  StrengthScore: ").Append(StrengthScore).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Vote: ").Append(Vote).Append("\n");
            sb.Append("  ValuePredictingHighOutcome: ").Append(ValuePredictingHighOutcome).Append("\n");
            sb.Append("  ValuePredictingLowOutcome: ").Append(ValuePredictingLowOutcome).Append("\n");
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
            return this.Equals(obj as UserVariableRelationship);
        }

        /// <summary>
        /// Returns true if UserVariableRelationship instances are equal
        /// </summary>
        /// <param name="other">Instance of UserVariableRelationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserVariableRelationship other)
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
                    this.ConfidenceLevel == other.ConfidenceLevel ||
                    this.ConfidenceLevel != null &&
                    this.ConfidenceLevel.Equals(other.ConfidenceLevel)
                ) && 
                (
                    this.ConfidenceScore == other.ConfidenceScore ||
                    this.ConfidenceScore != null &&
                    this.ConfidenceScore.Equals(other.ConfidenceScore)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.DurationOfAction == other.DurationOfAction ||
                    this.DurationOfAction != null &&
                    this.DurationOfAction.Equals(other.DurationOfAction)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.OnsetDelay == other.OnsetDelay ||
                    this.OnsetDelay != null &&
                    this.OnsetDelay.Equals(other.OnsetDelay)
                ) && 
                (
                    this.OutcomeVariableId == other.OutcomeVariableId ||
                    this.OutcomeVariableId != null &&
                    this.OutcomeVariableId.Equals(other.OutcomeVariableId)
                ) && 
                (
                    this.PredictorVariableId == other.PredictorVariableId ||
                    this.PredictorVariableId != null &&
                    this.PredictorVariableId.Equals(other.PredictorVariableId)
                ) && 
                (
                    this.PredictorUnitId == other.PredictorUnitId ||
                    this.PredictorUnitId != null &&
                    this.PredictorUnitId.Equals(other.PredictorUnitId)
                ) && 
                (
                    this.SinnRank == other.SinnRank ||
                    this.SinnRank != null &&
                    this.SinnRank.Equals(other.SinnRank)
                ) && 
                (
                    this.StrengthLevel == other.StrengthLevel ||
                    this.StrengthLevel != null &&
                    this.StrengthLevel.Equals(other.StrengthLevel)
                ) && 
                (
                    this.StrengthScore == other.StrengthScore ||
                    this.StrengthScore != null &&
                    this.StrengthScore.Equals(other.StrengthScore)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Vote == other.Vote ||
                    this.Vote != null &&
                    this.Vote.Equals(other.Vote)
                ) && 
                (
                    this.ValuePredictingHighOutcome == other.ValuePredictingHighOutcome ||
                    this.ValuePredictingHighOutcome != null &&
                    this.ValuePredictingHighOutcome.Equals(other.ValuePredictingHighOutcome)
                ) && 
                (
                    this.ValuePredictingLowOutcome == other.ValuePredictingLowOutcome ||
                    this.ValuePredictingLowOutcome != null &&
                    this.ValuePredictingLowOutcome.Equals(other.ValuePredictingLowOutcome)
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
                if (this.ConfidenceLevel != null)
                    hash = hash * 59 + this.ConfidenceLevel.GetHashCode();
                if (this.ConfidenceScore != null)
                    hash = hash * 59 + this.ConfidenceScore.GetHashCode();
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                if (this.DurationOfAction != null)
                    hash = hash * 59 + this.DurationOfAction.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.OnsetDelay != null)
                    hash = hash * 59 + this.OnsetDelay.GetHashCode();
                if (this.OutcomeVariableId != null)
                    hash = hash * 59 + this.OutcomeVariableId.GetHashCode();
                if (this.PredictorVariableId != null)
                    hash = hash * 59 + this.PredictorVariableId.GetHashCode();
                if (this.PredictorUnitId != null)
                    hash = hash * 59 + this.PredictorUnitId.GetHashCode();
                if (this.SinnRank != null)
                    hash = hash * 59 + this.SinnRank.GetHashCode();
                if (this.StrengthLevel != null)
                    hash = hash * 59 + this.StrengthLevel.GetHashCode();
                if (this.StrengthScore != null)
                    hash = hash * 59 + this.StrengthScore.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Vote != null)
                    hash = hash * 59 + this.Vote.GetHashCode();
                if (this.ValuePredictingHighOutcome != null)
                    hash = hash * 59 + this.ValuePredictingHighOutcome.GetHashCode();
                if (this.ValuePredictingLowOutcome != null)
                    hash = hash * 59 + this.ValuePredictingLowOutcome.GetHashCode();
                return hash;
            }
        }
    }

}
