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
    /// Correlation
    /// </summary>
    [DataContract]
    public partial class Correlation :  IEquatable<Correlation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Correlation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Correlation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Correlation" /> class.
        /// </summary>
        /// <param name="CorrelationCoefficient">Pearson correlation coefficient between cause and effect measurements (required).</param>
        /// <param name="Cause">ORIGINAL variable name of the cause variable for which the user desires correlations. (required).</param>
        /// <param name="OriginalCause">original name of the cause..</param>
        /// <param name="Effect">ORIGINAL variable name of the effect variable for which the user desires correlations. (required).</param>
        /// <param name="OriginalEffect">effect variable original name..</param>
        /// <param name="OnsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed (required).</param>
        /// <param name="DurationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay (required).</param>
        /// <param name="NumberOfPairs">Number of points that went into the correlation calculation (required).</param>
        /// <param name="EffectSize">Magnitude of the effects of a cause indicating whether it&#39;s practically meaningful..</param>
        /// <param name="StatisticalSignificance">A function of the effect size and sample size.</param>
        /// <param name="Timestamp">Time at which correlation was calculated (required).</param>
        /// <param name="ReverseCorrelation">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation..</param>
        /// <param name="CausalityFactor">.</param>
        /// <param name="CauseCategory">Variable category of the cause variable..</param>
        /// <param name="EffectCategory">Variable category of the effect variable..</param>
        /// <param name="ValuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for cause variable).</param>
        /// <param name="ValuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for cause variable).</param>
        /// <param name="OptimalPearsonProduct">Optimal Pearson Product.</param>
        /// <param name="AverageVote">Average Vote.</param>
        /// <param name="UserVote">User Vote.</param>
        /// <param name="CauseUnit">Unit of the predictor variable.</param>
        /// <param name="CauseUnitId">Unit Id of the predictor variable.</param>
        public Correlation(decimal? CorrelationCoefficient = null, string Cause = null, string OriginalCause = null, string Effect = null, string OriginalEffect = null, double? OnsetDelay = null, decimal? DurationOfAction = null, decimal? NumberOfPairs = null, string EffectSize = null, string StatisticalSignificance = null, decimal? Timestamp = null, decimal? ReverseCorrelation = null, decimal? CausalityFactor = null, string CauseCategory = null, string EffectCategory = null, decimal? ValuePredictingHighOutcome = null, decimal? ValuePredictingLowOutcome = null, decimal? OptimalPearsonProduct = null, decimal? AverageVote = null, decimal? UserVote = null, string CauseUnit = null, int? CauseUnitId = null)
        {
            // to ensure "CorrelationCoefficient" is required (not null)
            if (CorrelationCoefficient == null)
            {
                throw new InvalidDataException("CorrelationCoefficient is a required property for Correlation and cannot be null");
            }
            else
            {
                this.CorrelationCoefficient = CorrelationCoefficient;
            }
            // to ensure "Cause" is required (not null)
            if (Cause == null)
            {
                throw new InvalidDataException("Cause is a required property for Correlation and cannot be null");
            }
            else
            {
                this.Cause = Cause;
            }
            // to ensure "Effect" is required (not null)
            if (Effect == null)
            {
                throw new InvalidDataException("Effect is a required property for Correlation and cannot be null");
            }
            else
            {
                this.Effect = Effect;
            }
            // to ensure "OnsetDelay" is required (not null)
            if (OnsetDelay == null)
            {
                throw new InvalidDataException("OnsetDelay is a required property for Correlation and cannot be null");
            }
            else
            {
                this.OnsetDelay = OnsetDelay;
            }
            // to ensure "DurationOfAction" is required (not null)
            if (DurationOfAction == null)
            {
                throw new InvalidDataException("DurationOfAction is a required property for Correlation and cannot be null");
            }
            else
            {
                this.DurationOfAction = DurationOfAction;
            }
            // to ensure "NumberOfPairs" is required (not null)
            if (NumberOfPairs == null)
            {
                throw new InvalidDataException("NumberOfPairs is a required property for Correlation and cannot be null");
            }
            else
            {
                this.NumberOfPairs = NumberOfPairs;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for Correlation and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            this.OriginalCause = OriginalCause;
            this.OriginalEffect = OriginalEffect;
            this.EffectSize = EffectSize;
            this.StatisticalSignificance = StatisticalSignificance;
            this.ReverseCorrelation = ReverseCorrelation;
            this.CausalityFactor = CausalityFactor;
            this.CauseCategory = CauseCategory;
            this.EffectCategory = EffectCategory;
            this.ValuePredictingHighOutcome = ValuePredictingHighOutcome;
            this.ValuePredictingLowOutcome = ValuePredictingLowOutcome;
            this.OptimalPearsonProduct = OptimalPearsonProduct;
            this.AverageVote = AverageVote;
            this.UserVote = UserVote;
            this.CauseUnit = CauseUnit;
            this.CauseUnitId = CauseUnitId;
        }
        
        /// <summary>
        /// Pearson correlation coefficient between cause and effect measurements
        /// </summary>
        /// <value>Pearson correlation coefficient between cause and effect measurements</value>
        [DataMember(Name="correlationCoefficient", EmitDefaultValue=false)]
        public decimal? CorrelationCoefficient { get; set; }
        /// <summary>
        /// ORIGINAL variable name of the cause variable for which the user desires correlations.
        /// </summary>
        /// <value>ORIGINAL variable name of the cause variable for which the user desires correlations.</value>
        [DataMember(Name="cause", EmitDefaultValue=false)]
        public string Cause { get; set; }
        /// <summary>
        /// original name of the cause.
        /// </summary>
        /// <value>original name of the cause.</value>
        [DataMember(Name="originalCause", EmitDefaultValue=false)]
        public string OriginalCause { get; set; }
        /// <summary>
        /// ORIGINAL variable name of the effect variable for which the user desires correlations.
        /// </summary>
        /// <value>ORIGINAL variable name of the effect variable for which the user desires correlations.</value>
        [DataMember(Name="effect", EmitDefaultValue=false)]
        public string Effect { get; set; }
        /// <summary>
        /// effect variable original name.
        /// </summary>
        /// <value>effect variable original name.</value>
        [DataMember(Name="originalEffect", EmitDefaultValue=false)]
        public string OriginalEffect { get; set; }
        /// <summary>
        /// User estimated or default time after cause measurement before a perceivable effect is observed
        /// </summary>
        /// <value>User estimated or default time after cause measurement before a perceivable effect is observed</value>
        [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
        public double? OnsetDelay { get; set; }
        /// <summary>
        /// Time over which the cause is expected to produce a perceivable effect following the onset delay
        /// </summary>
        /// <value>Time over which the cause is expected to produce a perceivable effect following the onset delay</value>
        [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
        public decimal? DurationOfAction { get; set; }
        /// <summary>
        /// Number of points that went into the correlation calculation
        /// </summary>
        /// <value>Number of points that went into the correlation calculation</value>
        [DataMember(Name="numberOfPairs", EmitDefaultValue=false)]
        public decimal? NumberOfPairs { get; set; }
        /// <summary>
        /// Magnitude of the effects of a cause indicating whether it&#39;s practically meaningful.
        /// </summary>
        /// <value>Magnitude of the effects of a cause indicating whether it&#39;s practically meaningful.</value>
        [DataMember(Name="effectSize", EmitDefaultValue=false)]
        public string EffectSize { get; set; }
        /// <summary>
        /// A function of the effect size and sample size
        /// </summary>
        /// <value>A function of the effect size and sample size</value>
        [DataMember(Name="statisticalSignificance", EmitDefaultValue=false)]
        public string StatisticalSignificance { get; set; }
        /// <summary>
        /// Time at which correlation was calculated
        /// </summary>
        /// <value>Time at which correlation was calculated</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public decimal? Timestamp { get; set; }
        /// <summary>
        /// Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation.
        /// </summary>
        /// <value>Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation.</value>
        [DataMember(Name="reverseCorrelation", EmitDefaultValue=false)]
        public decimal? ReverseCorrelation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="causalityFactor", EmitDefaultValue=false)]
        public decimal? CausalityFactor { get; set; }
        /// <summary>
        /// Variable category of the cause variable.
        /// </summary>
        /// <value>Variable category of the cause variable.</value>
        [DataMember(Name="causeCategory", EmitDefaultValue=false)]
        public string CauseCategory { get; set; }
        /// <summary>
        /// Variable category of the effect variable.
        /// </summary>
        /// <value>Variable category of the effect variable.</value>
        [DataMember(Name="effectCategory", EmitDefaultValue=false)]
        public string EffectCategory { get; set; }
        /// <summary>
        /// cause value that predicts an above average effect value (in default unit for cause variable)
        /// </summary>
        /// <value>cause value that predicts an above average effect value (in default unit for cause variable)</value>
        [DataMember(Name="valuePredictingHighOutcome", EmitDefaultValue=false)]
        public decimal? ValuePredictingHighOutcome { get; set; }
        /// <summary>
        /// cause value that predicts a below average effect value (in default unit for cause variable)
        /// </summary>
        /// <value>cause value that predicts a below average effect value (in default unit for cause variable)</value>
        [DataMember(Name="valuePredictingLowOutcome", EmitDefaultValue=false)]
        public decimal? ValuePredictingLowOutcome { get; set; }
        /// <summary>
        /// Optimal Pearson Product
        /// </summary>
        /// <value>Optimal Pearson Product</value>
        [DataMember(Name="optimalPearsonProduct", EmitDefaultValue=false)]
        public decimal? OptimalPearsonProduct { get; set; }
        /// <summary>
        /// Average Vote
        /// </summary>
        /// <value>Average Vote</value>
        [DataMember(Name="averageVote", EmitDefaultValue=false)]
        public decimal? AverageVote { get; set; }
        /// <summary>
        /// User Vote
        /// </summary>
        /// <value>User Vote</value>
        [DataMember(Name="userVote", EmitDefaultValue=false)]
        public decimal? UserVote { get; set; }
        /// <summary>
        /// Unit of the predictor variable
        /// </summary>
        /// <value>Unit of the predictor variable</value>
        [DataMember(Name="causeUnit", EmitDefaultValue=false)]
        public string CauseUnit { get; set; }
        /// <summary>
        /// Unit Id of the predictor variable
        /// </summary>
        /// <value>Unit Id of the predictor variable</value>
        [DataMember(Name="causeUnitId", EmitDefaultValue=false)]
        public int? CauseUnitId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Correlation {\n");
            sb.Append("  CorrelationCoefficient: ").Append(CorrelationCoefficient).Append("\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
            sb.Append("  OriginalCause: ").Append(OriginalCause).Append("\n");
            sb.Append("  Effect: ").Append(Effect).Append("\n");
            sb.Append("  OriginalEffect: ").Append(OriginalEffect).Append("\n");
            sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
            sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
            sb.Append("  NumberOfPairs: ").Append(NumberOfPairs).Append("\n");
            sb.Append("  EffectSize: ").Append(EffectSize).Append("\n");
            sb.Append("  StatisticalSignificance: ").Append(StatisticalSignificance).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ReverseCorrelation: ").Append(ReverseCorrelation).Append("\n");
            sb.Append("  CausalityFactor: ").Append(CausalityFactor).Append("\n");
            sb.Append("  CauseCategory: ").Append(CauseCategory).Append("\n");
            sb.Append("  EffectCategory: ").Append(EffectCategory).Append("\n");
            sb.Append("  ValuePredictingHighOutcome: ").Append(ValuePredictingHighOutcome).Append("\n");
            sb.Append("  ValuePredictingLowOutcome: ").Append(ValuePredictingLowOutcome).Append("\n");
            sb.Append("  OptimalPearsonProduct: ").Append(OptimalPearsonProduct).Append("\n");
            sb.Append("  AverageVote: ").Append(AverageVote).Append("\n");
            sb.Append("  UserVote: ").Append(UserVote).Append("\n");
            sb.Append("  CauseUnit: ").Append(CauseUnit).Append("\n");
            sb.Append("  CauseUnitId: ").Append(CauseUnitId).Append("\n");
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
            return this.Equals(obj as Correlation);
        }

        /// <summary>
        /// Returns true if Correlation instances are equal
        /// </summary>
        /// <param name="other">Instance of Correlation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Correlation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CorrelationCoefficient == other.CorrelationCoefficient ||
                    this.CorrelationCoefficient != null &&
                    this.CorrelationCoefficient.Equals(other.CorrelationCoefficient)
                ) && 
                (
                    this.Cause == other.Cause ||
                    this.Cause != null &&
                    this.Cause.Equals(other.Cause)
                ) && 
                (
                    this.OriginalCause == other.OriginalCause ||
                    this.OriginalCause != null &&
                    this.OriginalCause.Equals(other.OriginalCause)
                ) && 
                (
                    this.Effect == other.Effect ||
                    this.Effect != null &&
                    this.Effect.Equals(other.Effect)
                ) && 
                (
                    this.OriginalEffect == other.OriginalEffect ||
                    this.OriginalEffect != null &&
                    this.OriginalEffect.Equals(other.OriginalEffect)
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
                    this.NumberOfPairs == other.NumberOfPairs ||
                    this.NumberOfPairs != null &&
                    this.NumberOfPairs.Equals(other.NumberOfPairs)
                ) && 
                (
                    this.EffectSize == other.EffectSize ||
                    this.EffectSize != null &&
                    this.EffectSize.Equals(other.EffectSize)
                ) && 
                (
                    this.StatisticalSignificance == other.StatisticalSignificance ||
                    this.StatisticalSignificance != null &&
                    this.StatisticalSignificance.Equals(other.StatisticalSignificance)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.ReverseCorrelation == other.ReverseCorrelation ||
                    this.ReverseCorrelation != null &&
                    this.ReverseCorrelation.Equals(other.ReverseCorrelation)
                ) && 
                (
                    this.CausalityFactor == other.CausalityFactor ||
                    this.CausalityFactor != null &&
                    this.CausalityFactor.Equals(other.CausalityFactor)
                ) && 
                (
                    this.CauseCategory == other.CauseCategory ||
                    this.CauseCategory != null &&
                    this.CauseCategory.Equals(other.CauseCategory)
                ) && 
                (
                    this.EffectCategory == other.EffectCategory ||
                    this.EffectCategory != null &&
                    this.EffectCategory.Equals(other.EffectCategory)
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
                ) && 
                (
                    this.OptimalPearsonProduct == other.OptimalPearsonProduct ||
                    this.OptimalPearsonProduct != null &&
                    this.OptimalPearsonProduct.Equals(other.OptimalPearsonProduct)
                ) && 
                (
                    this.AverageVote == other.AverageVote ||
                    this.AverageVote != null &&
                    this.AverageVote.Equals(other.AverageVote)
                ) && 
                (
                    this.UserVote == other.UserVote ||
                    this.UserVote != null &&
                    this.UserVote.Equals(other.UserVote)
                ) && 
                (
                    this.CauseUnit == other.CauseUnit ||
                    this.CauseUnit != null &&
                    this.CauseUnit.Equals(other.CauseUnit)
                ) && 
                (
                    this.CauseUnitId == other.CauseUnitId ||
                    this.CauseUnitId != null &&
                    this.CauseUnitId.Equals(other.CauseUnitId)
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
                if (this.CorrelationCoefficient != null)
                    hash = hash * 59 + this.CorrelationCoefficient.GetHashCode();
                if (this.Cause != null)
                    hash = hash * 59 + this.Cause.GetHashCode();
                if (this.OriginalCause != null)
                    hash = hash * 59 + this.OriginalCause.GetHashCode();
                if (this.Effect != null)
                    hash = hash * 59 + this.Effect.GetHashCode();
                if (this.OriginalEffect != null)
                    hash = hash * 59 + this.OriginalEffect.GetHashCode();
                if (this.OnsetDelay != null)
                    hash = hash * 59 + this.OnsetDelay.GetHashCode();
                if (this.DurationOfAction != null)
                    hash = hash * 59 + this.DurationOfAction.GetHashCode();
                if (this.NumberOfPairs != null)
                    hash = hash * 59 + this.NumberOfPairs.GetHashCode();
                if (this.EffectSize != null)
                    hash = hash * 59 + this.EffectSize.GetHashCode();
                if (this.StatisticalSignificance != null)
                    hash = hash * 59 + this.StatisticalSignificance.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.ReverseCorrelation != null)
                    hash = hash * 59 + this.ReverseCorrelation.GetHashCode();
                if (this.CausalityFactor != null)
                    hash = hash * 59 + this.CausalityFactor.GetHashCode();
                if (this.CauseCategory != null)
                    hash = hash * 59 + this.CauseCategory.GetHashCode();
                if (this.EffectCategory != null)
                    hash = hash * 59 + this.EffectCategory.GetHashCode();
                if (this.ValuePredictingHighOutcome != null)
                    hash = hash * 59 + this.ValuePredictingHighOutcome.GetHashCode();
                if (this.ValuePredictingLowOutcome != null)
                    hash = hash * 59 + this.ValuePredictingLowOutcome.GetHashCode();
                if (this.OptimalPearsonProduct != null)
                    hash = hash * 59 + this.OptimalPearsonProduct.GetHashCode();
                if (this.AverageVote != null)
                    hash = hash * 59 + this.AverageVote.GetHashCode();
                if (this.UserVote != null)
                    hash = hash * 59 + this.UserVote.GetHashCode();
                if (this.CauseUnit != null)
                    hash = hash * 59 + this.CauseUnit.GetHashCode();
                if (this.CauseUnitId != null)
                    hash = hash * 59 + this.CauseUnitId.GetHashCode();
                return hash;
            }
        }
    }

}
