using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVoteApi
    {
        
        /// <summary>
        /// Get all Votes
        /// </summary>
        /// <remarks>
        /// Get all Votes
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param>
        /// <param name="userId">ID of the user who voted</param>
        /// <param name="causeId">ID of predictor variable</param>
        /// <param name="effectId">ID of outcome variable</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 VotesGet (string accessToken = null, string clientId = null, int? userId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all Votes
        /// </summary>
        /// <remarks>
        /// Get all Votes
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param>
        /// <param name="userId">ID of the user who voted</param>
        /// <param name="causeId">ID of predictor variable</param>
        /// <param name="effectId">ID of outcome variable</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20020</returns>
        ApiResponse<InlineResponse20020> VotesGetWithHttpInfo (string accessToken = null, string clientId = null, int? userId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Votes
        /// </summary>
        /// <remarks>
        /// Get all Votes
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param>
        /// <param name="userId">ID of the user who voted</param>
        /// <param name="causeId">ID of predictor variable</param>
        /// <param name="effectId">ID of outcome variable</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20020</returns>
        System.Threading.Tasks.Task<InlineResponse20020> VotesGetAsync (string accessToken = null, string clientId = null, int? userId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Votes
        /// </summary>
        /// <remarks>
        /// Get all Votes
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param>
        /// <param name="userId">ID of the user who voted</param>
        /// <param name="causeId">ID of predictor variable</param>
        /// <param name="effectId">ID of outcome variable</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20020)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20020>> VotesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? userId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store Vote
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be stored</param>
        /// <returns>InlineResponse20036</returns>
        InlineResponse20036 VotesPost (string accessToken = null, Vote body = null);
  
        /// <summary>
        /// Store Vote
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20036</returns>
        ApiResponse<InlineResponse20036> VotesPostWithHttpInfo (string accessToken = null, Vote body = null);

        /// <summary>
        /// Store Vote
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be stored</param>
        /// <returns>Task of InlineResponse20036</returns>
        System.Threading.Tasks.Task<InlineResponse20036> VotesPostAsync (string accessToken = null, Vote body = null);

        /// <summary>
        /// Store Vote
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20036)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20036>> VotesPostAsyncWithHttpInfo (string accessToken = null, Vote body = null);
        
        /// <summary>
        /// Get Vote
        /// </summary>
        /// <remarks>
        /// Get Vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20036</returns>
        InlineResponse20036 VotesIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get Vote
        /// </summary>
        /// <remarks>
        /// Get Vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20036</returns>
        ApiResponse<InlineResponse20036> VotesIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get Vote
        /// </summary>
        /// <remarks>
        /// Get Vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20036</returns>
        System.Threading.Tasks.Task<InlineResponse20036> VotesIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get Vote
        /// </summary>
        /// <remarks>
        /// Get Vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20036)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20036>> VotesIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update Vote
        /// </summary>
        /// <remarks>
        /// Update Vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VotesIdPut (int? id, string accessToken = null, Vote body = null);
  
        /// <summary>
        /// Update Vote
        /// </summary>
        /// <remarks>
        /// Update Vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> VotesIdPutWithHttpInfo (int? id, string accessToken = null, Vote body = null);

        /// <summary>
        /// Update Vote
        /// </summary>
        /// <remarks>
        /// Update Vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VotesIdPutAsync (int? id, string accessToken = null, Vote body = null);

        /// <summary>
        /// Update Vote
        /// </summary>
        /// <remarks>
        /// Update Vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VotesIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Vote body = null);
        
        /// <summary>
        /// Delete Vote
        /// </summary>
        /// <remarks>
        /// Delete previously posted vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VotesIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete Vote
        /// </summary>
        /// <remarks>
        /// Delete previously posted vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> VotesIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete Vote
        /// </summary>
        /// <remarks>
        /// Delete previously posted vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VotesIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete Vote
        /// </summary>
        /// <remarks>
        /// Delete previously posted vote
        /// </remarks>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VotesIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VoteApi : IVoteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VoteApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VoteApi(Configuration configuration = null)
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
        /// Get all Votes Get all Votes
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param> 
        /// <param name="userId">ID of the user who voted</param> 
        /// <param name="causeId">ID of predictor variable</param> 
        /// <param name="effectId">ID of outcome variable</param> 
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20020</returns>
        public InlineResponse20020 VotesGet (string accessToken = null, string clientId = null, int? userId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20020> response = VotesGetWithHttpInfo(accessToken, clientId, userId, causeId, effectId, value, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param> 
        /// <param name="userId">ID of the user who voted</param> 
        /// <param name="causeId">ID of predictor variable</param> 
        /// <param name="effectId">ID of outcome variable</param> 
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20020</returns>
        public ApiResponse< InlineResponse20020 > VotesGetWithHttpInfo (string accessToken = null, string clientId = null, int? userId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/votes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (causeId != null) queryParams.Add("cause_id", Configuration.ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) queryParams.Add("effect_id", Configuration.ApiClient.ParameterToString(effectId)); // query parameter
            if (value != null) queryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20020>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20020) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20020)));
            
        }
    
        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param>
        /// <param name="userId">ID of the user who voted</param>
        /// <param name="causeId">ID of predictor variable</param>
        /// <param name="effectId">ID of outcome variable</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20020</returns>
        public async System.Threading.Tasks.Task<InlineResponse20020> VotesGetAsync (string accessToken = null, string clientId = null, int? userId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20020> response = await VotesGetAsyncWithHttpInfo(accessToken, clientId, userId, causeId, effectId, value, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param>
        /// <param name="userId">ID of the user who voted</param>
        /// <param name="causeId">ID of predictor variable</param>
        /// <param name="effectId">ID of outcome variable</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20020)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20020>> VotesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? userId = null, int? causeId = null, int? effectId = null, int? value = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/votes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (causeId != null) queryParams.Add("cause_id", Configuration.ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) queryParams.Add("effect_id", Configuration.ApiClient.ParameterToString(effectId)); // query parameter
            if (value != null) queryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20020>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20020) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20020)));
            
        }
        
        /// <summary>
        /// Store Vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Vote that should be stored</param> 
        /// <returns>InlineResponse20036</returns>
        public InlineResponse20036 VotesPost (string accessToken = null, Vote body = null)
        {
             ApiResponse<InlineResponse20036> response = VotesPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store Vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Vote that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20036</returns>
        public ApiResponse< InlineResponse20036 > VotesPostWithHttpInfo (string accessToken = null, Vote body = null)
        {
            
    
            var path_ = "/votes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20036>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20036) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20036)));
            
        }
    
        /// <summary>
        /// Store Vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be stored</param>
        /// <returns>Task of InlineResponse20036</returns>
        public async System.Threading.Tasks.Task<InlineResponse20036> VotesPostAsync (string accessToken = null, Vote body = null)
        {
             ApiResponse<InlineResponse20036> response = await VotesPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store Vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20036)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20036>> VotesPostAsyncWithHttpInfo (string accessToken = null, Vote body = null)
        {
            
    
            var path_ = "/votes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20036>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20036) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20036)));
            
        }
        
        /// <summary>
        /// Get Vote Get Vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20036</returns>
        public InlineResponse20036 VotesIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20036> response = VotesIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get Vote Get Vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20036</returns>
        public ApiResponse< InlineResponse20036 > VotesIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdGet");
            
    
            var path_ = "/votes/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20036>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20036) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20036)));
            
        }
    
        /// <summary>
        /// Get Vote Get Vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20036</returns>
        public async System.Threading.Tasks.Task<InlineResponse20036> VotesIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20036> response = await VotesIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get Vote Get Vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20036)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20036>> VotesIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdGet");
            
    
            var path_ = "/votes/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20036>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20036) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20036)));
            
        }
        
        /// <summary>
        /// Update Vote Update Vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Vote that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 VotesIdPut (int? id, string accessToken = null, Vote body = null)
        {
             ApiResponse<InlineResponse2002> response = VotesIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update Vote Update Vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Vote that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > VotesIdPutWithHttpInfo (int? id, string accessToken = null, Vote body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdPut");
            
    
            var path_ = "/votes/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update Vote Update Vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VotesIdPutAsync (int? id, string accessToken = null, Vote body = null)
        {
             ApiResponse<InlineResponse2002> response = await VotesIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update Vote Update Vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Vote that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VotesIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Vote body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdPut");
            
    
            var path_ = "/votes/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete Vote Delete previously posted vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 VotesIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = VotesIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete Vote Delete previously posted vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > VotesIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdDelete");
            
    
            var path_ = "/votes/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete Vote Delete previously posted vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VotesIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await VotesIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete Vote Delete previously posted vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VotesIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdDelete");
            
    
            var path_ = "/votes/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling VotesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VotesIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
