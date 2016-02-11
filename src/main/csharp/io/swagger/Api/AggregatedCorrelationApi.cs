using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAggregatedCorrelationApi
    {
        
        /// <summary>
        /// Get all AggregatedCorrelations
        /// </summary>
        /// <remarks>
        /// Get all AggregatedCorrelations
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param>
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param>
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param>
        /// <param name="causeUnitId">Unit ID for the predictor variable</param>
        /// <param name="causeChanges">Number of times that the predictor time series changes</param>
        /// <param name="effectChanges">Number of times that the predictor time series changes</param>
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param>
        /// <param name="createdAt">Date at which the analysis was first performed</param>
        /// <param name="updatedAt">Date at which the analysis was last updated</param>
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param>
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param>
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AggregatedCorrelationsGet (string accessToken = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, int? numberOfUsers = null, int? numberOfCorrelations = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? aggregateQmScore = null, string createdAt = null, string updatedAt = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all AggregatedCorrelations
        /// </summary>
        /// <remarks>
        /// Get all AggregatedCorrelations
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param>
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param>
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param>
        /// <param name="causeUnitId">Unit ID for the predictor variable</param>
        /// <param name="causeChanges">Number of times that the predictor time series changes</param>
        /// <param name="effectChanges">Number of times that the predictor time series changes</param>
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param>
        /// <param name="createdAt">Date at which the analysis was first performed</param>
        /// <param name="updatedAt">Date at which the analysis was last updated</param>
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param>
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param>
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> AggregatedCorrelationsGetWithHttpInfo (string accessToken = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, int? numberOfUsers = null, int? numberOfCorrelations = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? aggregateQmScore = null, string createdAt = null, string updatedAt = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all AggregatedCorrelations
        /// </summary>
        /// <remarks>
        /// Get all AggregatedCorrelations
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param>
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param>
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param>
        /// <param name="causeUnitId">Unit ID for the predictor variable</param>
        /// <param name="causeChanges">Number of times that the predictor time series changes</param>
        /// <param name="effectChanges">Number of times that the predictor time series changes</param>
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param>
        /// <param name="createdAt">Date at which the analysis was first performed</param>
        /// <param name="updatedAt">Date at which the analysis was last updated</param>
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param>
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param>
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> AggregatedCorrelationsGetAsync (string accessToken = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, int? numberOfUsers = null, int? numberOfCorrelations = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? aggregateQmScore = null, string createdAt = null, string updatedAt = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all AggregatedCorrelations
        /// </summary>
        /// <remarks>
        /// Get all AggregatedCorrelations
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param>
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param>
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param>
        /// <param name="causeUnitId">Unit ID for the predictor variable</param>
        /// <param name="causeChanges">Number of times that the predictor time series changes</param>
        /// <param name="effectChanges">Number of times that the predictor time series changes</param>
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param>
        /// <param name="createdAt">Date at which the analysis was first performed</param>
        /// <param name="updatedAt">Date at which the analysis was last updated</param>
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param>
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param>
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> AggregatedCorrelationsGetAsyncWithHttpInfo (string accessToken = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, int? numberOfUsers = null, int? numberOfCorrelations = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? aggregateQmScore = null, string createdAt = null, string updatedAt = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Store AggregatedCorrelation
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AggregatedCorrelationsPost (string accessToken = null, AggregatedCorrelation body = null);
  
        /// <summary>
        /// Store AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Store AggregatedCorrelation
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> AggregatedCorrelationsPostWithHttpInfo (string accessToken = null, AggregatedCorrelation body = null);

        /// <summary>
        /// Store AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Store AggregatedCorrelation
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> AggregatedCorrelationsPostAsync (string accessToken = null, AggregatedCorrelation body = null);

        /// <summary>
        /// Store AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Store AggregatedCorrelation
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> AggregatedCorrelationsPostAsyncWithHttpInfo (string accessToken = null, AggregatedCorrelation body = null);
        
        /// <summary>
        /// Get AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Get AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AggregatedCorrelationsIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Get AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> AggregatedCorrelationsIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Get AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> AggregatedCorrelationsIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Get AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> AggregatedCorrelationsIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Update AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 AggregatedCorrelationsIdPut (int? id, string accessToken = null, AggregatedCorrelation body = null);
  
        /// <summary>
        /// Update AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Update AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> AggregatedCorrelationsIdPutWithHttpInfo (int? id, string accessToken = null, AggregatedCorrelation body = null);

        /// <summary>
        /// Update AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Update AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> AggregatedCorrelationsIdPutAsync (int? id, string accessToken = null, AggregatedCorrelation body = null);

        /// <summary>
        /// Update AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Update AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> AggregatedCorrelationsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, AggregatedCorrelation body = null);
        
        /// <summary>
        /// Delete AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Delete AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 AggregatedCorrelationsIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Delete AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> AggregatedCorrelationsIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Delete AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> AggregatedCorrelationsIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Delete AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> AggregatedCorrelationsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AggregatedCorrelationApi : IAggregatedCorrelationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedCorrelationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AggregatedCorrelationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedCorrelationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AggregatedCorrelationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Get all AggregatedCorrelations Get all AggregatedCorrelations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param> 
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param> 
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param> 
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param> 
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param> 
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param> 
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param> 
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param> 
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param> 
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param> 
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param> 
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param> 
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param> 
        /// <param name="causeUnitId">Unit ID for the predictor variable</param> 
        /// <param name="causeChanges">Number of times that the predictor time series changes</param> 
        /// <param name="effectChanges">Number of times that the predictor time series changes</param> 
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param> 
        /// <param name="createdAt">Date at which the analysis was first performed</param> 
        /// <param name="updatedAt">Date at which the analysis was last updated</param> 
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param> 
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param> 
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param> 
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param> 
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param> 
        /// <param name="limit">Limit the number of results returned</param> 
        /// <param name="offset">Records from give Offset</param> 
        /// <param name="sort">Sort records by given field</param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 AggregatedCorrelationsGet (string accessToken = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, int? numberOfUsers = null, int? numberOfCorrelations = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? aggregateQmScore = null, string createdAt = null, string updatedAt = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse200> response = AggregatedCorrelationsGetWithHttpInfo(accessToken, correlation, causeId, effectId, onsetDelay, durationOfAction, numberOfPairs, valuePredictingHighOutcome, valuePredictingLowOutcome, optimalPearsonProduct, numberOfUsers, numberOfCorrelations, statisticalSignificance, causeUnit, causeUnitId, causeChanges, effectChanges, aggregateQmScore, createdAt, updatedAt, status, errorMessage, lastSuccessfulUpdateTime, reversePearsonCorrelationCoefficient, predictivePearsonCorrelationCoefficient, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all AggregatedCorrelations Get all AggregatedCorrelations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param> 
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param> 
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param> 
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param> 
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param> 
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param> 
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param> 
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param> 
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param> 
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param> 
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param> 
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param> 
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param> 
        /// <param name="causeUnitId">Unit ID for the predictor variable</param> 
        /// <param name="causeChanges">Number of times that the predictor time series changes</param> 
        /// <param name="effectChanges">Number of times that the predictor time series changes</param> 
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param> 
        /// <param name="createdAt">Date at which the analysis was first performed</param> 
        /// <param name="updatedAt">Date at which the analysis was last updated</param> 
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param> 
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param> 
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param> 
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param> 
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param> 
        /// <param name="limit">Limit the number of results returned</param> 
        /// <param name="offset">Records from give Offset</param> 
        /// <param name="sort">Sort records by given field</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > AggregatedCorrelationsGetWithHttpInfo (string accessToken = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, int? numberOfUsers = null, int? numberOfCorrelations = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? aggregateQmScore = null, string createdAt = null, string updatedAt = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/aggregatedCorrelations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (correlation != null) queryParams.Add("correlation", Configuration.ApiClient.ParameterToString(correlation)); // query parameter
            if (causeId != null) queryParams.Add("cause_id", Configuration.ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) queryParams.Add("effect_id", Configuration.ApiClient.ParameterToString(effectId)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (numberOfPairs != null) queryParams.Add("number_of_pairs", Configuration.ApiClient.ParameterToString(numberOfPairs)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (optimalPearsonProduct != null) queryParams.Add("optimal_pearson_product", Configuration.ApiClient.ParameterToString(optimalPearsonProduct)); // query parameter
            if (numberOfUsers != null) queryParams.Add("number_of_users", Configuration.ApiClient.ParameterToString(numberOfUsers)); // query parameter
            if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", Configuration.ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (statisticalSignificance != null) queryParams.Add("statistical_significance", Configuration.ApiClient.ParameterToString(statisticalSignificance)); // query parameter
            if (causeUnit != null) queryParams.Add("cause_unit", Configuration.ApiClient.ParameterToString(causeUnit)); // query parameter
            if (causeUnitId != null) queryParams.Add("cause_unit_id", Configuration.ApiClient.ParameterToString(causeUnitId)); // query parameter
            if (causeChanges != null) queryParams.Add("cause_changes", Configuration.ApiClient.ParameterToString(causeChanges)); // query parameter
            if (effectChanges != null) queryParams.Add("effect_changes", Configuration.ApiClient.ParameterToString(effectChanges)); // query parameter
            if (aggregateQmScore != null) queryParams.Add("aggregate_qm_score", Configuration.ApiClient.ParameterToString(aggregateQmScore)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (reversePearsonCorrelationCoefficient != null) queryParams.Add("reverse_pearson_correlation_coefficient", Configuration.ApiClient.ParameterToString(reversePearsonCorrelationCoefficient)); // query parameter
            if (predictivePearsonCorrelationCoefficient != null) queryParams.Add("predictive_pearson_correlation_coefficient", Configuration.ApiClient.ParameterToString(predictivePearsonCorrelationCoefficient)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
    
        /// <summary>
        /// Get all AggregatedCorrelations Get all AggregatedCorrelations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param>
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param>
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param>
        /// <param name="causeUnitId">Unit ID for the predictor variable</param>
        /// <param name="causeChanges">Number of times that the predictor time series changes</param>
        /// <param name="effectChanges">Number of times that the predictor time series changes</param>
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param>
        /// <param name="createdAt">Date at which the analysis was first performed</param>
        /// <param name="updatedAt">Date at which the analysis was last updated</param>
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param>
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param>
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> AggregatedCorrelationsGetAsync (string accessToken = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, int? numberOfUsers = null, int? numberOfCorrelations = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? aggregateQmScore = null, string createdAt = null, string updatedAt = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse200> response = await AggregatedCorrelationsGetAsyncWithHttpInfo(accessToken, correlation, causeId, effectId, onsetDelay, durationOfAction, numberOfPairs, valuePredictingHighOutcome, valuePredictingLowOutcome, optimalPearsonProduct, numberOfUsers, numberOfCorrelations, statisticalSignificance, causeUnit, causeUnitId, causeChanges, effectChanges, aggregateQmScore, createdAt, updatedAt, status, errorMessage, lastSuccessfulUpdateTime, reversePearsonCorrelationCoefficient, predictivePearsonCorrelationCoefficient, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all AggregatedCorrelations Get all AggregatedCorrelations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param>
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param>
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param>
        /// <param name="causeUnitId">Unit ID for the predictor variable</param>
        /// <param name="causeChanges">Number of times that the predictor time series changes</param>
        /// <param name="effectChanges">Number of times that the predictor time series changes</param>
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param>
        /// <param name="createdAt">Date at which the analysis was first performed</param>
        /// <param name="updatedAt">Date at which the analysis was last updated</param>
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param>
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param>
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> AggregatedCorrelationsGetAsyncWithHttpInfo (string accessToken = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, int? numberOfUsers = null, int? numberOfCorrelations = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? aggregateQmScore = null, string createdAt = null, string updatedAt = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/aggregatedCorrelations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (correlation != null) queryParams.Add("correlation", Configuration.ApiClient.ParameterToString(correlation)); // query parameter
            if (causeId != null) queryParams.Add("cause_id", Configuration.ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) queryParams.Add("effect_id", Configuration.ApiClient.ParameterToString(effectId)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (numberOfPairs != null) queryParams.Add("number_of_pairs", Configuration.ApiClient.ParameterToString(numberOfPairs)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (optimalPearsonProduct != null) queryParams.Add("optimal_pearson_product", Configuration.ApiClient.ParameterToString(optimalPearsonProduct)); // query parameter
            if (numberOfUsers != null) queryParams.Add("number_of_users", Configuration.ApiClient.ParameterToString(numberOfUsers)); // query parameter
            if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", Configuration.ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (statisticalSignificance != null) queryParams.Add("statistical_significance", Configuration.ApiClient.ParameterToString(statisticalSignificance)); // query parameter
            if (causeUnit != null) queryParams.Add("cause_unit", Configuration.ApiClient.ParameterToString(causeUnit)); // query parameter
            if (causeUnitId != null) queryParams.Add("cause_unit_id", Configuration.ApiClient.ParameterToString(causeUnitId)); // query parameter
            if (causeChanges != null) queryParams.Add("cause_changes", Configuration.ApiClient.ParameterToString(causeChanges)); // query parameter
            if (effectChanges != null) queryParams.Add("effect_changes", Configuration.ApiClient.ParameterToString(effectChanges)); // query parameter
            if (aggregateQmScore != null) queryParams.Add("aggregate_qm_score", Configuration.ApiClient.ParameterToString(aggregateQmScore)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (reversePearsonCorrelationCoefficient != null) queryParams.Add("reverse_pearson_correlation_coefficient", Configuration.ApiClient.ParameterToString(reversePearsonCorrelationCoefficient)); // query parameter
            if (predictivePearsonCorrelationCoefficient != null) queryParams.Add("predictive_pearson_correlation_coefficient", Configuration.ApiClient.ParameterToString(predictivePearsonCorrelationCoefficient)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
        /// <summary>
        /// Store AggregatedCorrelation Store AggregatedCorrelation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">AggregatedCorrelation that should be stored</param> 
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 AggregatedCorrelationsPost (string accessToken = null, AggregatedCorrelation body = null)
        {
             ApiResponse<InlineResponse2001> response = AggregatedCorrelationsPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store AggregatedCorrelation Store AggregatedCorrelation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">AggregatedCorrelation that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > AggregatedCorrelationsPostWithHttpInfo (string accessToken = null, AggregatedCorrelation body = null)
        {
            
    
            var path_ = "/aggregatedCorrelations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
    
        /// <summary>
        /// Store AggregatedCorrelation Store AggregatedCorrelation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> AggregatedCorrelationsPostAsync (string accessToken = null, AggregatedCorrelation body = null)
        {
             ApiResponse<InlineResponse2001> response = await AggregatedCorrelationsPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store AggregatedCorrelation Store AggregatedCorrelation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> AggregatedCorrelationsPostAsyncWithHttpInfo (string accessToken = null, AggregatedCorrelation body = null)
        {
            
    
            var path_ = "/aggregatedCorrelations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
        
        /// <summary>
        /// Get AggregatedCorrelation Get AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 AggregatedCorrelationsIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2001> response = AggregatedCorrelationsIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get AggregatedCorrelation Get AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > AggregatedCorrelationsIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationApi->AggregatedCorrelationsIdGet");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
    
        /// <summary>
        /// Get AggregatedCorrelation Get AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> AggregatedCorrelationsIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2001> response = await AggregatedCorrelationsIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get AggregatedCorrelation Get AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> AggregatedCorrelationsIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdGet");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
        
        /// <summary>
        /// Update AggregatedCorrelation Update AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">AggregatedCorrelation that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 AggregatedCorrelationsIdPut (int? id, string accessToken = null, AggregatedCorrelation body = null)
        {
             ApiResponse<InlineResponse2002> response = AggregatedCorrelationsIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update AggregatedCorrelation Update AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">AggregatedCorrelation that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > AggregatedCorrelationsIdPutWithHttpInfo (int? id, string accessToken = null, AggregatedCorrelation body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationApi->AggregatedCorrelationsIdPut");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update AggregatedCorrelation Update AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> AggregatedCorrelationsIdPutAsync (int? id, string accessToken = null, AggregatedCorrelation body = null)
        {
             ApiResponse<InlineResponse2002> response = await AggregatedCorrelationsIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update AggregatedCorrelation Update AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> AggregatedCorrelationsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, AggregatedCorrelation body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdPut");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete AggregatedCorrelation Delete AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 AggregatedCorrelationsIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = AggregatedCorrelationsIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete AggregatedCorrelation Delete AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > AggregatedCorrelationsIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationApi->AggregatedCorrelationsIdDelete");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete AggregatedCorrelation Delete AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> AggregatedCorrelationsIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await AggregatedCorrelationsIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete AggregatedCorrelation Delete AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> AggregatedCorrelationsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdDelete");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
