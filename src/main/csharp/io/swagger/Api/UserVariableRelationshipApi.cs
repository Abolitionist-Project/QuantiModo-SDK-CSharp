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
    public interface IUserVariableRelationshipApi
    {
        
        /// <summary>
        /// Get all UserVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all UserVariableRelationships
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
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="userId">user_id</param>
        /// <param name="vote">vote</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 UserVariableRelationshipsGet (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, string strengthLevel = null, double? strengthScore = null, int? userId = null, string vote = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all UserVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all UserVariableRelationships
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
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="userId">user_id</param>
        /// <param name="vote">vote</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        ApiResponse<InlineResponse2008> UserVariableRelationshipsGetWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, string strengthLevel = null, double? strengthScore = null, int? userId = null, string vote = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all UserVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all UserVariableRelationships
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
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="userId">user_id</param>
        /// <param name="vote">vote</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2008</returns>
        System.Threading.Tasks.Task<InlineResponse2008> UserVariableRelationshipsGetAsync (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, string strengthLevel = null, double? strengthScore = null, int? userId = null, string vote = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all UserVariableRelationships
        /// </summary>
        /// <remarks>
        /// Get all UserVariableRelationships
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
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="userId">user_id</param>
        /// <param name="vote">vote</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> UserVariableRelationshipsGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, string strengthLevel = null, double? strengthScore = null, int? userId = null, string vote = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Store UserVariableRelationship
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be stored</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 UserVariableRelationshipsPost (string accessToken = null, UserVariableRelationship body = null);
  
        /// <summary>
        /// Store UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Store UserVariableRelationship
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20029</returns>
        ApiResponse<InlineResponse20029> UserVariableRelationshipsPostWithHttpInfo (string accessToken = null, UserVariableRelationship body = null);

        /// <summary>
        /// Store UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Store UserVariableRelationship
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be stored</param>
        /// <returns>Task of InlineResponse20029</returns>
        System.Threading.Tasks.Task<InlineResponse20029> UserVariableRelationshipsPostAsync (string accessToken = null, UserVariableRelationship body = null);

        /// <summary>
        /// Store UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Store UserVariableRelationship
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20029)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20029>> UserVariableRelationshipsPostAsyncWithHttpInfo (string accessToken = null, UserVariableRelationship body = null);
        
        /// <summary>
        /// Get UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Get UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 UserVariableRelationshipsIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Get UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20029</returns>
        ApiResponse<InlineResponse20029> UserVariableRelationshipsIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Get UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20029</returns>
        System.Threading.Tasks.Task<InlineResponse20029> UserVariableRelationshipsIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Get UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20029)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20029>> UserVariableRelationshipsIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Update UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariableRelationshipsIdPut (int? id, string accessToken = null, UserVariableRelationship body = null);
  
        /// <summary>
        /// Update UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Update UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> UserVariableRelationshipsIdPutWithHttpInfo (int? id, string accessToken = null, UserVariableRelationship body = null);

        /// <summary>
        /// Update UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Update UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> UserVariableRelationshipsIdPutAsync (int? id, string accessToken = null, UserVariableRelationship body = null);

        /// <summary>
        /// Update UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Update UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UserVariableRelationshipsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, UserVariableRelationship body = null);
        
        /// <summary>
        /// Delete UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Delete UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariableRelationshipsIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Delete UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> UserVariableRelationshipsIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Delete UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> UserVariableRelationshipsIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete UserVariableRelationship
        /// </summary>
        /// <remarks>
        /// Delete UserVariableRelationship
        /// </remarks>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UserVariableRelationshipsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserVariableRelationshipApi : IUserVariableRelationshipApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableRelationshipApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserVariableRelationshipApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableRelationshipApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserVariableRelationshipApi(Configuration configuration = null)
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
        /// Get all UserVariableRelationships Get all UserVariableRelationships
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
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param> 
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param> 
        /// <param name="userId">user_id</param> 
        /// <param name="vote">vote</param> 
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param> 
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 UserVariableRelationshipsGet (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, string strengthLevel = null, double? strengthScore = null, int? userId = null, string vote = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2008> response = UserVariableRelationshipsGetWithHttpInfo(accessToken, id, confidenceLevel, confidenceScore, direction, durationOfAction, errorMessage, onsetDelay, outcomeVariableId, predictorVariableId, predictorUnitId, sinnRank, strengthLevel, strengthScore, userId, vote, valuePredictingHighOutcome, valuePredictingLowOutcome, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
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
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param> 
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param> 
        /// <param name="userId">user_id</param> 
        /// <param name="vote">vote</param> 
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param> 
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse2008</returns>
        public ApiResponse< InlineResponse2008 > UserVariableRelationshipsGetWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, string strengthLevel = null, double? strengthScore = null, int? userId = null, string vote = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/userVariableRelationships";
    
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
            if (strengthLevel != null) queryParams.Add("strength_level", Configuration.ApiClient.ParameterToString(strengthLevel)); // query parameter
            if (strengthScore != null) queryParams.Add("strength_score", Configuration.ApiClient.ParameterToString(strengthScore)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (vote != null) queryParams.Add("vote", Configuration.ApiClient.ParameterToString(vote)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2008>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2008) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2008)));
            
        }
    
        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
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
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="userId">user_id</param>
        /// <param name="vote">vote</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2008</returns>
        public async System.Threading.Tasks.Task<InlineResponse2008> UserVariableRelationshipsGetAsync (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, string strengthLevel = null, double? strengthScore = null, int? userId = null, string vote = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2008> response = await UserVariableRelationshipsGetAsyncWithHttpInfo(accessToken, id, confidenceLevel, confidenceScore, direction, durationOfAction, errorMessage, onsetDelay, outcomeVariableId, predictorVariableId, predictorUnitId, sinnRank, strengthLevel, strengthScore, userId, vote, valuePredictingHighOutcome, valuePredictingLowOutcome, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
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
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="userId">user_id</param>
        /// <param name="vote">vote</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> UserVariableRelationshipsGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string confidenceLevel = null, double? confidenceScore = null, string direction = null, int? durationOfAction = null, string errorMessage = null, int? onsetDelay = null, int? outcomeVariableId = null, int? predictorVariableId = null, int? predictorUnitId = null, double? sinnRank = null, string strengthLevel = null, double? strengthScore = null, int? userId = null, string vote = null, double? valuePredictingHighOutcome = null, double? valuePredictingLowOutcome = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/userVariableRelationships";
    
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
            if (strengthLevel != null) queryParams.Add("strength_level", Configuration.ApiClient.ParameterToString(strengthLevel)); // query parameter
            if (strengthScore != null) queryParams.Add("strength_score", Configuration.ApiClient.ParameterToString(strengthScore)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (vote != null) queryParams.Add("vote", Configuration.ApiClient.ParameterToString(vote)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", Configuration.ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", Configuration.ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2008>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2008) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2008)));
            
        }
        
        /// <summary>
        /// Store UserVariableRelationship Store UserVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariableRelationship that should be stored</param> 
        /// <returns>InlineResponse20029</returns>
        public InlineResponse20029 UserVariableRelationshipsPost (string accessToken = null, UserVariableRelationship body = null)
        {
             ApiResponse<InlineResponse20029> response = UserVariableRelationshipsPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store UserVariableRelationship Store UserVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariableRelationship that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20029</returns>
        public ApiResponse< InlineResponse20029 > UserVariableRelationshipsPostWithHttpInfo (string accessToken = null, UserVariableRelationship body = null)
        {
            
    
            var path_ = "/userVariableRelationships";
    
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20029>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20029) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20029)));
            
        }
    
        /// <summary>
        /// Store UserVariableRelationship Store UserVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be stored</param>
        /// <returns>Task of InlineResponse20029</returns>
        public async System.Threading.Tasks.Task<InlineResponse20029> UserVariableRelationshipsPostAsync (string accessToken = null, UserVariableRelationship body = null)
        {
             ApiResponse<InlineResponse20029> response = await UserVariableRelationshipsPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store UserVariableRelationship Store UserVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20029)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20029>> UserVariableRelationshipsPostAsyncWithHttpInfo (string accessToken = null, UserVariableRelationship body = null)
        {
            
    
            var path_ = "/userVariableRelationships";
    
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20029>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20029) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20029)));
            
        }
        
        /// <summary>
        /// Get UserVariableRelationship Get UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20029</returns>
        public InlineResponse20029 UserVariableRelationshipsIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20029> response = UserVariableRelationshipsIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get UserVariableRelationship Get UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20029</returns>
        public ApiResponse< InlineResponse20029 > UserVariableRelationshipsIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipApi->UserVariableRelationshipsIdGet");
            
    
            var path_ = "/userVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20029>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20029) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20029)));
            
        }
    
        /// <summary>
        /// Get UserVariableRelationship Get UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20029</returns>
        public async System.Threading.Tasks.Task<InlineResponse20029> UserVariableRelationshipsIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20029> response = await UserVariableRelationshipsIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get UserVariableRelationship Get UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20029)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20029>> UserVariableRelationshipsIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipsIdGet");
            
    
            var path_ = "/userVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20029>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20029) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20029)));
            
        }
        
        /// <summary>
        /// Update UserVariableRelationship Update UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariableRelationship that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 UserVariableRelationshipsIdPut (int? id, string accessToken = null, UserVariableRelationship body = null)
        {
             ApiResponse<InlineResponse2002> response = UserVariableRelationshipsIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update UserVariableRelationship Update UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariableRelationship that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > UserVariableRelationshipsIdPutWithHttpInfo (int? id, string accessToken = null, UserVariableRelationship body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipApi->UserVariableRelationshipsIdPut");
            
    
            var path_ = "/userVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update UserVariableRelationship Update UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> UserVariableRelationshipsIdPutAsync (int? id, string accessToken = null, UserVariableRelationship body = null)
        {
             ApiResponse<InlineResponse2002> response = await UserVariableRelationshipsIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update UserVariableRelationship Update UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UserVariableRelationshipsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, UserVariableRelationship body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipsIdPut");
            
    
            var path_ = "/userVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete UserVariableRelationship Delete UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 UserVariableRelationshipsIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = UserVariableRelationshipsIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete UserVariableRelationship Delete UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > UserVariableRelationshipsIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipApi->UserVariableRelationshipsIdDelete");
            
    
            var path_ = "/userVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete UserVariableRelationship Delete UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> UserVariableRelationshipsIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await UserVariableRelationshipsIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete UserVariableRelationship Delete UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UserVariableRelationshipsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipsIdDelete");
            
    
            var path_ = "/userVariableRelationships/{id}";
    
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
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariableRelationshipsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
