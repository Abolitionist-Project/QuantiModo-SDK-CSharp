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
    public interface ICommonVariableRelationshipApi
    {
        
        /// <summary>
        /// Get all CommonVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all CommonVariableRelationships
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param>
        /// <param name="dataSource">data_source</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 CommonVariableRelationshipsGet (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, double? strengthScore = null, string strengthLevel = null, int? upVotes = null, int? downVotes = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? numberOfUsers = null, string dataSource = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all CommonVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all CommonVariableRelationships
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param>
        /// <param name="dataSource">data_source</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        ApiResponse<InlineResponse20012> CommonVariableRelationshipsGetWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, double? strengthScore = null, string strengthLevel = null, int? upVotes = null, int? downVotes = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? numberOfUsers = null, string dataSource = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all CommonVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all CommonVariableRelationships
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param>
        /// <param name="dataSource">data_source</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20012</returns>
        System.Threading.Tasks.Task<InlineResponse20012> CommonVariableRelationshipsGetAsync (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, double? strengthScore = null, string strengthLevel = null, int? upVotes = null, int? downVotes = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? numberOfUsers = null, string dataSource = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all CommonVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all CommonVariableRelationships
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param>
        /// <param name="dataSource">data_source</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> CommonVariableRelationshipsGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, double? strengthScore = null, string strengthLevel = null, int? upVotes = null, int? downVotes = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? numberOfUsers = null, string dataSource = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Store CommonVariableRelationship
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be stored</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 CommonVariableRelationshipsPost (string accessToken = null, CommonVariableRelationship body = null);
  
        /// <summary>
        /// Store CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Store CommonVariableRelationship
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> CommonVariableRelationshipsPostWithHttpInfo (string accessToken = null, CommonVariableRelationship body = null);

        /// <summary>
        /// Store CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Store CommonVariableRelationship
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be stored</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> CommonVariableRelationshipsPostAsync (string accessToken = null, CommonVariableRelationship body = null);

        /// <summary>
        /// Store CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Store CommonVariableRelationship
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> CommonVariableRelationshipsPostAsyncWithHttpInfo (string accessToken = null, CommonVariableRelationship body = null);
        
        /// <summary>
        /// Get CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Get CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 CommonVariableRelationshipsIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Get CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> CommonVariableRelationshipsIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Get CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> CommonVariableRelationshipsIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Get CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> CommonVariableRelationshipsIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Update CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CommonVariableRelationshipsIdPut (int? id, string accessToken = null, CommonVariableRelationship body = null);
  
        /// <summary>
        /// Update CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Update CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> CommonVariableRelationshipsIdPutWithHttpInfo (int? id, string accessToken = null, CommonVariableRelationship body = null);

        /// <summary>
        /// Update CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Update CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CommonVariableRelationshipsIdPutAsync (int? id, string accessToken = null, CommonVariableRelationship body = null);

        /// <summary>
        /// Update CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Update CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CommonVariableRelationshipsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, CommonVariableRelationship body = null);
        
        /// <summary>
        /// Delete CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Delete CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CommonVariableRelationshipsIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Delete CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> CommonVariableRelationshipsIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Delete CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CommonVariableRelationshipsIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete CommonVariableRelationship
        /// </summary>
        /// <remarks>
        /// Delete CommonVariableRelationship
        /// </remarks>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CommonVariableRelationshipsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CommonVariableRelationshipApi : ICommonVariableRelationshipApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonVariableRelationshipApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommonVariableRelationshipApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonVariableRelationshipApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CommonVariableRelationshipApi(Configuration configuration = null)
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
        /// Get all CommonVariableRelationships Get all CommonVariableRelationships
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="id">id</param> 
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param> 
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param> 
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param> 
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param> 
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param> 
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param> 
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param> 
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param> 
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param> 
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param> 
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param> 
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param> 
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param> 
        /// <param name="dataSource">data_source</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20012</returns>
        public InlineResponse20012 CommonVariableRelationshipsGet (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, double? strengthScore = null, string strengthLevel = null, int? upVotes = null, int? downVotes = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? numberOfUsers = null, string dataSource = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20012> response = CommonVariableRelationshipsGetWithHttpInfo(accessToken, id, confidenceLevel, confidenceScore, direction, durationOfAction, errorMessage, onsetDelay, outcomeVariableId, predictorVariableId, predictorUnitId, sinnRank, strengthScore, strengthLevel, upVotes, downVotes, valuePredictingHighOutcome, valuePredictingLowOutcome, numberOfUsers, dataSource, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all CommonVariableRelationships Get all CommonVariableRelationships
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="id">id</param> 
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param> 
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param> 
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param> 
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param> 
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param> 
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param> 
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param> 
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param> 
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param> 
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param> 
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param> 
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param> 
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param> 
        /// <param name="dataSource">data_source</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20012</returns>
        public ApiResponse< InlineResponse20012 > CommonVariableRelationshipsGetWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, double? strengthScore = null, string strengthLevel = null, int? upVotes = null, int? downVotes = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? numberOfUsers = null, string dataSource = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/commonVariableRelationships";
    
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
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (confidenceLevel != null) queryParams.Add("confidence_level", Configuration.ApiClient.ParameterToString(confidenceLevel)); // query parameter
            if (confidenceScore != null) queryParams.Add("confidence_score", Configuration.ApiClient.ParameterToString(confidenceScore)); // query parameter
            if (direction != null) queryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (outcomeVariableId != null) queryParams.Add("outcome_variable_id", Configuration.ApiClient.ParameterToString(outcomeVariableId)); // query parameter
            if (predictorVariableId != null) queryParams.Add("predictor_variable_id", Configuration.ApiClient.ParameterToString(predictorVariableId)); // query parameter
            if (predictorUnitId != null) queryParams.Add("predictor_unit_id", Configuration.ApiClient.ParameterToString(predictorUnitId)); // query parameter
            if (sinnRank != null) queryParams.Add("sinn_rank", Configuration.ApiClient.ParameterToString(sinnRank)); // query parameter
            if (strengthScore != null) queryParams.Add("strength_score", Configuration.ApiClient.ParameterToString(strengthScore)); // query parameter
            if (strengthLevel != null) queryParams.Add("strength_level", Configuration.ApiClient.ParameterToString(strengthLevel)); // query parameter
            if (upVotes != null) queryParams.Add("up_votes", Configuration.ApiClient.ParameterToString(upVotes)); // query parameter
            if (downVotes != null) queryParams.Add("down_votes", Configuration.ApiClient.ParameterToString(downVotes)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (numberOfUsers != null) queryParams.Add("number_of_users", Configuration.ApiClient.ParameterToString(numberOfUsers)); // query parameter
            if (dataSource != null) queryParams.Add("data_source", Configuration.ApiClient.ParameterToString(dataSource)); // query parameter
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20012>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20012) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20012)));
            
        }
    
        /// <summary>
        /// Get all CommonVariableRelationships Get all CommonVariableRelationships
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param>
        /// <param name="dataSource">data_source</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20012</returns>
        public async System.Threading.Tasks.Task<InlineResponse20012> CommonVariableRelationshipsGetAsync (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, double? strengthScore = null, string strengthLevel = null, int? upVotes = null, int? downVotes = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? numberOfUsers = null, string dataSource = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20012> response = await CommonVariableRelationshipsGetAsyncWithHttpInfo(accessToken, id, confidenceLevel, confidenceScore, direction, durationOfAction, errorMessage, onsetDelay, outcomeVariableId, predictorVariableId, predictorUnitId, sinnRank, strengthScore, strengthLevel, upVotes, downVotes, valuePredictingHighOutcome, valuePredictingLowOutcome, numberOfUsers, dataSource, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all CommonVariableRelationships Get all CommonVariableRelationships
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param>
        /// <param name="dataSource">data_source</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> CommonVariableRelationshipsGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, double? strengthScore = null, string strengthLevel = null, int? upVotes = null, int? downVotes = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? numberOfUsers = null, string dataSource = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/commonVariableRelationships";
    
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
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (confidenceLevel != null) queryParams.Add("confidence_level", Configuration.ApiClient.ParameterToString(confidenceLevel)); // query parameter
            if (confidenceScore != null) queryParams.Add("confidence_score", Configuration.ApiClient.ParameterToString(confidenceScore)); // query parameter
            if (direction != null) queryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (outcomeVariableId != null) queryParams.Add("outcome_variable_id", Configuration.ApiClient.ParameterToString(outcomeVariableId)); // query parameter
            if (predictorVariableId != null) queryParams.Add("predictor_variable_id", Configuration.ApiClient.ParameterToString(predictorVariableId)); // query parameter
            if (predictorUnitId != null) queryParams.Add("predictor_unit_id", Configuration.ApiClient.ParameterToString(predictorUnitId)); // query parameter
            if (sinnRank != null) queryParams.Add("sinn_rank", Configuration.ApiClient.ParameterToString(sinnRank)); // query parameter
            if (strengthScore != null) queryParams.Add("strength_score", Configuration.ApiClient.ParameterToString(strengthScore)); // query parameter
            if (strengthLevel != null) queryParams.Add("strength_level", Configuration.ApiClient.ParameterToString(strengthLevel)); // query parameter
            if (upVotes != null) queryParams.Add("up_votes", Configuration.ApiClient.ParameterToString(upVotes)); // query parameter
            if (downVotes != null) queryParams.Add("down_votes", Configuration.ApiClient.ParameterToString(downVotes)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (numberOfUsers != null) queryParams.Add("number_of_users", Configuration.ApiClient.ParameterToString(numberOfUsers)); // query parameter
            if (dataSource != null) queryParams.Add("data_source", Configuration.ApiClient.ParameterToString(dataSource)); // query parameter
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20012>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20012) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20012)));
            
        }
        
        /// <summary>
        /// Store CommonVariableRelationship Store CommonVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">CommonVariableRelationship that should be stored</param> 
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 CommonVariableRelationshipsPost (string accessToken = null, CommonVariableRelationship body = null)
        {
             ApiResponse<InlineResponse20013> response = CommonVariableRelationshipsPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store CommonVariableRelationship Store CommonVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">CommonVariableRelationship that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public ApiResponse< InlineResponse20013 > CommonVariableRelationshipsPostWithHttpInfo (string accessToken = null, CommonVariableRelationship body = null)
        {
            
    
            var path_ = "/commonVariableRelationships";
    
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
    
        /// <summary>
        /// Store CommonVariableRelationship Store CommonVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be stored</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> CommonVariableRelationshipsPostAsync (string accessToken = null, CommonVariableRelationship body = null)
        {
             ApiResponse<InlineResponse20013> response = await CommonVariableRelationshipsPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store CommonVariableRelationship Store CommonVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> CommonVariableRelationshipsPostAsyncWithHttpInfo (string accessToken = null, CommonVariableRelationship body = null)
        {
            
    
            var path_ = "/commonVariableRelationships";
    
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
        
        /// <summary>
        /// Get CommonVariableRelationship Get CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 CommonVariableRelationshipsIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20013> response = CommonVariableRelationshipsIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get CommonVariableRelationship Get CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public ApiResponse< InlineResponse20013 > CommonVariableRelationshipsIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipApi->CommonVariableRelationshipsIdGet");
            
    
            var path_ = "/commonVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
    
        /// <summary>
        /// Get CommonVariableRelationship Get CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> CommonVariableRelationshipsIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20013> response = await CommonVariableRelationshipsIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get CommonVariableRelationship Get CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> CommonVariableRelationshipsIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipsIdGet");
            
    
            var path_ = "/commonVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
        
        /// <summary>
        /// Update CommonVariableRelationship Update CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">CommonVariableRelationship that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 CommonVariableRelationshipsIdPut (int? id, string accessToken = null, CommonVariableRelationship body = null)
        {
             ApiResponse<InlineResponse2002> response = CommonVariableRelationshipsIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update CommonVariableRelationship Update CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">CommonVariableRelationship that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > CommonVariableRelationshipsIdPutWithHttpInfo (int? id, string accessToken = null, CommonVariableRelationship body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipApi->CommonVariableRelationshipsIdPut");
            
    
            var path_ = "/commonVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update CommonVariableRelationship Update CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CommonVariableRelationshipsIdPutAsync (int? id, string accessToken = null, CommonVariableRelationship body = null)
        {
             ApiResponse<InlineResponse2002> response = await CommonVariableRelationshipsIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update CommonVariableRelationship Update CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CommonVariableRelationshipsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, CommonVariableRelationship body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipsIdPut");
            
    
            var path_ = "/commonVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete CommonVariableRelationship Delete CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 CommonVariableRelationshipsIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = CommonVariableRelationshipsIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete CommonVariableRelationship Delete CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > CommonVariableRelationshipsIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipApi->CommonVariableRelationshipsIdDelete");
            
    
            var path_ = "/commonVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete CommonVariableRelationship Delete CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CommonVariableRelationshipsIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await CommonVariableRelationshipsIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete CommonVariableRelationship Delete CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CommonVariableRelationshipsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipsIdDelete");
            
    
            var path_ = "/commonVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CommonVariableRelationshipsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
