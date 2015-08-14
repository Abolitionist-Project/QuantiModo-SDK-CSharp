using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IVotesApi
    {
        
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="cause">Cause variable name</param>
        /// <param name="effect">Effect variable name</param>
        /// <param name="vote">Vote: 0 (for implausible) or 1 (for plausible)</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1VotesPost (string cause, string effect, bool? vote);
  
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="cause">Cause variable name</param>
        /// <param name="effect">Effect variable name</param>
        /// <param name="vote">Vote: 0 (for implausible) or 1 (for plausible)</param>
        /// <returns>CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1VotesPostAsync (string cause, string effect, bool? vote);
        
        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <param name="cause">Cause variable name</param>
        /// <param name="effect">Effect variable name</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1VotesDeletePost (string cause, string effect);
  
        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <param name="cause">Cause variable name</param>
        /// <param name="effect">Effect variable name</param>
        /// <returns>CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1VotesDeletePostAsync (string cause, string effect);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VotesApi : IVotesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VotesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VotesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VotesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VotesApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="cause">Cause variable name</param> 
        /// <param name="effect">Effect variable name</param> 
        /// <param name="vote">Vote: 0 (for implausible) or 1 (for plausible)</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1VotesPost (string cause, string effect, bool? vote)
        {
            
            // verify the required parameter 'cause' is set
            if (cause == null) throw new ApiException(400, "Missing required parameter 'cause' when calling V1VotesPost");
            
            // verify the required parameter 'effect' is set
            if (effect == null) throw new ApiException(400, "Missing required parameter 'effect' when calling V1VotesPost");
            
    
            var path = "/v1/votes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
            if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
            if (vote != null) queryParams.Add("vote", ApiClient.ParameterToString(vote)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="cause">Cause variable name</param>
        /// <param name="effect">Effect variable name</param>
        /// <param name="vote">Vote: 0 (for implausible) or 1 (for plausible)</param>
        /// <returns>CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1VotesPostAsync (string cause, string effect, bool? vote)
        {
            // verify the required parameter 'cause' is set
            if (cause == null) throw new ApiException(400, "Missing required parameter 'cause' when calling V1VotesPost");
            // verify the required parameter 'effect' is set
            if (effect == null) throw new ApiException(400, "Missing required parameter 'effect' when calling V1VotesPost");
            
    
            var path = "/v1/votes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
            if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
            if (vote != null) queryParams.Add("vote", ApiClient.ParameterToString(vote)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesPost: " + response.Content, response.Content);

            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
        
        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <param name="cause">Cause variable name</param> 
        /// <param name="effect">Effect variable name</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1VotesDeletePost (string cause, string effect)
        {
            
            // verify the required parameter 'cause' is set
            if (cause == null) throw new ApiException(400, "Missing required parameter 'cause' when calling V1VotesDeletePost");
            
            // verify the required parameter 'effect' is set
            if (effect == null) throw new ApiException(400, "Missing required parameter 'effect' when calling V1VotesDeletePost");
            
    
            var path = "/v1/votes/delete";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
            if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesDeletePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesDeletePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <param name="cause">Cause variable name</param>
        /// <param name="effect">Effect variable name</param>
        /// <returns>CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1VotesDeletePostAsync (string cause, string effect)
        {
            // verify the required parameter 'cause' is set
            if (cause == null) throw new ApiException(400, "Missing required parameter 'cause' when calling V1VotesDeletePost");
            // verify the required parameter 'effect' is set
            if (effect == null) throw new ApiException(400, "Missing required parameter 'effect' when calling V1VotesDeletePost");
            
    
            var path = "/v1/votes/delete";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
            if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesDeletePost: " + response.Content, response.Content);

            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
        
    }
    
}
