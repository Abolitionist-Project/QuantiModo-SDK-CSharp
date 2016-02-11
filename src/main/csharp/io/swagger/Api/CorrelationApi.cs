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
    public interface ICorrelationApi
    {
        
        /// <summary>
        /// Get all Correlations
        /// </summary>
        /// <remarks>
        /// Get all Correlations
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="timestamp">Time at which correlation was calculated</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param>
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="vote">Vote</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Unit of the predictor variable</param>
        /// <param name="causeUnitId">Unit ID of the predictor variable</param>
        /// <param name="causeChanges">Cause changes</param>
        /// <param name="effectChanges">Effect changes</param>
        /// <param name="qmScore">QM Score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 CorrelationsGet (string accessToken = null, int? timestamp = null, int? userId = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, double? vote = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? qmScore = null, string error = null, string createdAt = null, string updatedAt = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all Correlations
        /// </summary>
        /// <remarks>
        /// Get all Correlations
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="timestamp">Time at which correlation was calculated</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param>
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="vote">Vote</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Unit of the predictor variable</param>
        /// <param name="causeUnitId">Unit ID of the predictor variable</param>
        /// <param name="causeChanges">Cause changes</param>
        /// <param name="effectChanges">Effect changes</param>
        /// <param name="qmScore">QM Score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>ApiResponse of InlineResponse20017</returns>
        ApiResponse<InlineResponse20017> CorrelationsGetWithHttpInfo (string accessToken = null, int? timestamp = null, int? userId = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, double? vote = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? qmScore = null, string error = null, string createdAt = null, string updatedAt = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Correlations
        /// </summary>
        /// <remarks>
        /// Get all Correlations
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="timestamp">Time at which correlation was calculated</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param>
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="vote">Vote</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Unit of the predictor variable</param>
        /// <param name="causeUnitId">Unit ID of the predictor variable</param>
        /// <param name="causeChanges">Cause changes</param>
        /// <param name="effectChanges">Effect changes</param>
        /// <param name="qmScore">QM Score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>Task of InlineResponse20017</returns>
        System.Threading.Tasks.Task<InlineResponse20017> CorrelationsGetAsync (string accessToken = null, int? timestamp = null, int? userId = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, double? vote = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? qmScore = null, string error = null, string createdAt = null, string updatedAt = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Correlations
        /// </summary>
        /// <remarks>
        /// Get all Correlations
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="timestamp">Time at which correlation was calculated</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param>
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="vote">Vote</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Unit of the predictor variable</param>
        /// <param name="causeUnitId">Unit ID of the predictor variable</param>
        /// <param name="causeChanges">Cause changes</param>
        /// <param name="effectChanges">Effect changes</param>
        /// <param name="qmScore">QM Score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>Task of ApiResponse (InlineResponse20017)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20017>> CorrelationsGetAsyncWithHttpInfo (string accessToken = null, int? timestamp = null, int? userId = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, double? vote = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? qmScore = null, string error = null, string createdAt = null, string updatedAt = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store Correlation
        /// </summary>
        /// <remarks>
        /// Store Correlation
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 CorrelationsPost (string accessToken = null, Correlation body = null);
  
        /// <summary>
        /// Store Correlation
        /// </summary>
        /// <remarks>
        /// Store Correlation
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20018</returns>
        ApiResponse<InlineResponse20018> CorrelationsPostWithHttpInfo (string accessToken = null, Correlation body = null);

        /// <summary>
        /// Store Correlation
        /// </summary>
        /// <remarks>
        /// Store Correlation
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>Task of InlineResponse20018</returns>
        System.Threading.Tasks.Task<InlineResponse20018> CorrelationsPostAsync (string accessToken = null, Correlation body = null);

        /// <summary>
        /// Store Correlation
        /// </summary>
        /// <remarks>
        /// Store Correlation
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20018)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20018>> CorrelationsPostAsyncWithHttpInfo (string accessToken = null, Correlation body = null);
        
        /// <summary>
        /// Get Correlation Details
        /// </summary>
        /// <remarks>
        /// Get Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 CorrelationsIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get Correlation Details
        /// </summary>
        /// <remarks>
        /// Get Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20018</returns>
        ApiResponse<InlineResponse20018> CorrelationsIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get Correlation Details
        /// </summary>
        /// <remarks>
        /// Get Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20018</returns>
        System.Threading.Tasks.Task<InlineResponse20018> CorrelationsIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get Correlation Details
        /// </summary>
        /// <remarks>
        /// Get Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20018)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20018>> CorrelationsIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update Correlation
        /// </summary>
        /// <remarks>
        /// Update Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CorrelationsIdPut (int? id, string accessToken = null, Correlation body = null);
  
        /// <summary>
        /// Update Correlation
        /// </summary>
        /// <remarks>
        /// Update Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> CorrelationsIdPutWithHttpInfo (int? id, string accessToken = null, Correlation body = null);

        /// <summary>
        /// Update Correlation
        /// </summary>
        /// <remarks>
        /// Update Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CorrelationsIdPutAsync (int? id, string accessToken = null, Correlation body = null);

        /// <summary>
        /// Update Correlation
        /// </summary>
        /// <remarks>
        /// Update Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CorrelationsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Correlation body = null);
        
        /// <summary>
        /// Delete Correlation
        /// </summary>
        /// <remarks>
        /// Delete Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CorrelationsIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete Correlation
        /// </summary>
        /// <remarks>
        /// Delete Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> CorrelationsIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete Correlation
        /// </summary>
        /// <remarks>
        /// Delete Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CorrelationsIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete Correlation
        /// </summary>
        /// <remarks>
        /// Delete Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CorrelationsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CorrelationApi : ICorrelationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CorrelationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CorrelationApi(Configuration configuration = null)
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
        /// Get all Correlations Get all Correlations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="timestamp">Time at which correlation was calculated</param> 
        /// <param name="userId">ID of user that owns this correlation</param> 
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param> 
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param> 
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param> 
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param> 
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param> 
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param> 
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param> 
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param> 
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param> 
        /// <param name="vote">Vote</param> 
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param> 
        /// <param name="causeUnit">Unit of the predictor variable</param> 
        /// <param name="causeUnitId">Unit ID of the predictor variable</param> 
        /// <param name="causeChanges">Cause changes</param> 
        /// <param name="effectChanges">Effect changes</param> 
        /// <param name="qmScore">QM Score</param> 
        /// <param name="error">error</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param> 
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param> 
        /// <param name="limit">Limit the number of results returned</param> 
        /// <param name="offset">Records from give Offset</param> 
        /// <param name="sort">Sort records by given field</param> 
        /// <returns>InlineResponse20017</returns>
        public InlineResponse20017 CorrelationsGet (string accessToken = null, int? timestamp = null, int? userId = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, double? vote = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? qmScore = null, string error = null, string createdAt = null, string updatedAt = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20017> response = CorrelationsGetWithHttpInfo(accessToken, timestamp, userId, correlation, causeId, effectId, onsetDelay, durationOfAction, numberOfPairs, valuePredictingHighOutcome, valuePredictingLowOutcome, optimalPearsonProduct, vote, statisticalSignificance, causeUnit, causeUnitId, causeChanges, effectChanges, qmScore, error, createdAt, updatedAt, reversePearsonCorrelationCoefficient, predictivePearsonCorrelationCoefficient, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all Correlations Get all Correlations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="timestamp">Time at which correlation was calculated</param> 
        /// <param name="userId">ID of user that owns this correlation</param> 
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param> 
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param> 
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param> 
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param> 
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param> 
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param> 
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param> 
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param> 
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param> 
        /// <param name="vote">Vote</param> 
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param> 
        /// <param name="causeUnit">Unit of the predictor variable</param> 
        /// <param name="causeUnitId">Unit ID of the predictor variable</param> 
        /// <param name="causeChanges">Cause changes</param> 
        /// <param name="effectChanges">Effect changes</param> 
        /// <param name="qmScore">QM Score</param> 
        /// <param name="error">error</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param> 
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param> 
        /// <param name="limit">Limit the number of results returned</param> 
        /// <param name="offset">Records from give Offset</param> 
        /// <param name="sort">Sort records by given field</param> 
        /// <returns>ApiResponse of InlineResponse20017</returns>
        public ApiResponse< InlineResponse20017 > CorrelationsGetWithHttpInfo (string accessToken = null, int? timestamp = null, int? userId = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, double? vote = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? qmScore = null, string error = null, string createdAt = null, string updatedAt = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/correlations";
    
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
            if (timestamp != null) queryParams.Add("timestamp", Configuration.ApiClient.ParameterToString(timestamp)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (correlation != null) queryParams.Add("correlation", Configuration.ApiClient.ParameterToString(correlation)); // query parameter
            if (causeId != null) queryParams.Add("cause_id", Configuration.ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) queryParams.Add("effect_id", Configuration.ApiClient.ParameterToString(effectId)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (numberOfPairs != null) queryParams.Add("number_of_pairs", Configuration.ApiClient.ParameterToString(numberOfPairs)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (optimalPearsonProduct != null) queryParams.Add("optimal_pearson_product", Configuration.ApiClient.ParameterToString(optimalPearsonProduct)); // query parameter
            if (vote != null) queryParams.Add("vote", Configuration.ApiClient.ParameterToString(vote)); // query parameter
            if (statisticalSignificance != null) queryParams.Add("statistical_significance", Configuration.ApiClient.ParameterToString(statisticalSignificance)); // query parameter
            if (causeUnit != null) queryParams.Add("cause_unit", Configuration.ApiClient.ParameterToString(causeUnit)); // query parameter
            if (causeUnitId != null) queryParams.Add("cause_unit_id", Configuration.ApiClient.ParameterToString(causeUnitId)); // query parameter
            if (causeChanges != null) queryParams.Add("cause_changes", Configuration.ApiClient.ParameterToString(causeChanges)); // query parameter
            if (effectChanges != null) queryParams.Add("effect_changes", Configuration.ApiClient.ParameterToString(effectChanges)); // query parameter
            if (qmScore != null) queryParams.Add("qm_score", Configuration.ApiClient.ParameterToString(qmScore)); // query parameter
            if (error != null) queryParams.Add("error", Configuration.ApiClient.ParameterToString(error)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
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
                throw new ApiException (statusCode, "Error calling CorrelationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20017>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20017) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20017)));
            
        }
    
        /// <summary>
        /// Get all Correlations Get all Correlations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="timestamp">Time at which correlation was calculated</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param>
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="vote">Vote</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Unit of the predictor variable</param>
        /// <param name="causeUnitId">Unit ID of the predictor variable</param>
        /// <param name="causeChanges">Cause changes</param>
        /// <param name="effectChanges">Effect changes</param>
        /// <param name="qmScore">QM Score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>Task of InlineResponse20017</returns>
        public async System.Threading.Tasks.Task<InlineResponse20017> CorrelationsGetAsync (string accessToken = null, int? timestamp = null, int? userId = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, double? vote = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? qmScore = null, string error = null, string createdAt = null, string updatedAt = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20017> response = await CorrelationsGetAsyncWithHttpInfo(accessToken, timestamp, userId, correlation, causeId, effectId, onsetDelay, durationOfAction, numberOfPairs, valuePredictingHighOutcome, valuePredictingLowOutcome, optimalPearsonProduct, vote, statisticalSignificance, causeUnit, causeUnitId, causeChanges, effectChanges, qmScore, error, createdAt, updatedAt, reversePearsonCorrelationCoefficient, predictivePearsonCorrelationCoefficient, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all Correlations Get all Correlations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="timestamp">Time at which correlation was calculated</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param>
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="vote">Vote</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Unit of the predictor variable</param>
        /// <param name="causeUnitId">Unit ID of the predictor variable</param>
        /// <param name="causeChanges">Cause changes</param>
        /// <param name="effectChanges">Effect changes</param>
        /// <param name="qmScore">QM Score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>Task of ApiResponse (InlineResponse20017)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20017>> CorrelationsGetAsyncWithHttpInfo (string accessToken = null, int? timestamp = null, int? userId = null, double? correlation = null, int? causeId = null, int? effectId = null, int? onsetDelay = null, int? durationOfAction = null, int? numberOfPairs = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, double? optimalPearsonProduct = null, double? vote = null, double? statisticalSignificance = null, string causeUnit = null, int? causeUnitId = null, int? causeChanges = null, int? effectChanges = null, double? qmScore = null, string error = null, string createdAt = null, string updatedAt = null, double? reversePearsonCorrelationCoefficient = null, double? predictivePearsonCorrelationCoefficient = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/correlations";
    
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
            if (timestamp != null) queryParams.Add("timestamp", Configuration.ApiClient.ParameterToString(timestamp)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (correlation != null) queryParams.Add("correlation", Configuration.ApiClient.ParameterToString(correlation)); // query parameter
            if (causeId != null) queryParams.Add("cause_id", Configuration.ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) queryParams.Add("effect_id", Configuration.ApiClient.ParameterToString(effectId)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (numberOfPairs != null) queryParams.Add("number_of_pairs", Configuration.ApiClient.ParameterToString(numberOfPairs)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (optimalPearsonProduct != null) queryParams.Add("optimal_pearson_product", Configuration.ApiClient.ParameterToString(optimalPearsonProduct)); // query parameter
            if (vote != null) queryParams.Add("vote", Configuration.ApiClient.ParameterToString(vote)); // query parameter
            if (statisticalSignificance != null) queryParams.Add("statistical_significance", Configuration.ApiClient.ParameterToString(statisticalSignificance)); // query parameter
            if (causeUnit != null) queryParams.Add("cause_unit", Configuration.ApiClient.ParameterToString(causeUnit)); // query parameter
            if (causeUnitId != null) queryParams.Add("cause_unit_id", Configuration.ApiClient.ParameterToString(causeUnitId)); // query parameter
            if (causeChanges != null) queryParams.Add("cause_changes", Configuration.ApiClient.ParameterToString(causeChanges)); // query parameter
            if (effectChanges != null) queryParams.Add("effect_changes", Configuration.ApiClient.ParameterToString(effectChanges)); // query parameter
            if (qmScore != null) queryParams.Add("qm_score", Configuration.ApiClient.ParameterToString(qmScore)); // query parameter
            if (error != null) queryParams.Add("error", Configuration.ApiClient.ParameterToString(error)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
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
                throw new ApiException (statusCode, "Error calling CorrelationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20017>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20017) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20017)));
            
        }
        
        /// <summary>
        /// Store Correlation Store Correlation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Correlation that should be stored</param> 
        /// <returns>InlineResponse20018</returns>
        public InlineResponse20018 CorrelationsPost (string accessToken = null, Correlation body = null)
        {
             ApiResponse<InlineResponse20018> response = CorrelationsPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store Correlation Store Correlation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Correlation that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20018</returns>
        public ApiResponse< InlineResponse20018 > CorrelationsPostWithHttpInfo (string accessToken = null, Correlation body = null)
        {
            
    
            var path_ = "/correlations";
    
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
                throw new ApiException (statusCode, "Error calling CorrelationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20018>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20018) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20018)));
            
        }
    
        /// <summary>
        /// Store Correlation Store Correlation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>Task of InlineResponse20018</returns>
        public async System.Threading.Tasks.Task<InlineResponse20018> CorrelationsPostAsync (string accessToken = null, Correlation body = null)
        {
             ApiResponse<InlineResponse20018> response = await CorrelationsPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store Correlation Store Correlation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20018)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20018>> CorrelationsPostAsyncWithHttpInfo (string accessToken = null, Correlation body = null)
        {
            
    
            var path_ = "/correlations";
    
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
                throw new ApiException (statusCode, "Error calling CorrelationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20018>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20018) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20018)));
            
        }
        
        /// <summary>
        /// Get Correlation Details Get Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20018</returns>
        public InlineResponse20018 CorrelationsIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20018> response = CorrelationsIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get Correlation Details Get Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20018</returns>
        public ApiResponse< InlineResponse20018 > CorrelationsIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationApi->CorrelationsIdGet");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CorrelationsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20018>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20018) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20018)));
            
        }
    
        /// <summary>
        /// Get Correlation Details Get Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20018</returns>
        public async System.Threading.Tasks.Task<InlineResponse20018> CorrelationsIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20018> response = await CorrelationsIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get Correlation Details Get Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20018)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20018>> CorrelationsIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdGet");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CorrelationsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20018>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20018) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20018)));
            
        }
        
        /// <summary>
        /// Update Correlation Update Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Correlation that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 CorrelationsIdPut (int? id, string accessToken = null, Correlation body = null)
        {
             ApiResponse<InlineResponse2002> response = CorrelationsIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update Correlation Update Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Correlation that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > CorrelationsIdPutWithHttpInfo (int? id, string accessToken = null, Correlation body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationApi->CorrelationsIdPut");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CorrelationsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update Correlation Update Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CorrelationsIdPutAsync (int? id, string accessToken = null, Correlation body = null)
        {
             ApiResponse<InlineResponse2002> response = await CorrelationsIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update Correlation Update Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CorrelationsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Correlation body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdPut");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CorrelationsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete Correlation Delete Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 CorrelationsIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = CorrelationsIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete Correlation Delete Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > CorrelationsIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationApi->CorrelationsIdDelete");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CorrelationsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete Correlation Delete Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CorrelationsIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await CorrelationsIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete Correlation Delete Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CorrelationsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdDelete");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CorrelationsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CorrelationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
