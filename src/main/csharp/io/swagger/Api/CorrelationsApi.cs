using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface ICorrelationsApi
    {
        
        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed.</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>List<Correlation></returns>
        List<Correlation> V1CorrelationsGet (string effect, string cause, string correlationCoefficient, string onsetDelay, string durationOfAction, string lastUpdated, int? limit, int? offset, int? sort);
  
        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed.</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>List<Correlation></returns>
        System.Threading.Tasks.Task<List<Correlation>> V1CorrelationsGetAsync (string effect, string cause, string correlationCoefficient, string onsetDelay, string durationOfAction, string lastUpdated, int? limit, int? offset, int? sort);
        
        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <param name="body">Provides correlation data</param>
        /// <returns></returns>
        void V1CorrelationsPost (PostCorrelation body);
  
        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <param name="body">Provides correlation data</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1CorrelationsPostAsync (PostCorrelation body);
        
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="includePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
        /// <returns>List<Correlation></returns>
        List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? organizationId, int? userId, string variableName, string organizationToken, string includePublic);
  
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="includePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
        /// <returns>List<Correlation></returns>
        System.Threading.Tasks.Task<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsync (int? organizationId, int? userId, string variableName, string organizationToken, string includePublic);
        
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="includePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
        /// <returns>List<CommonResponse></returns>
        List<CommonResponse> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? organizationId, int? userId, string variableName, string organizationToken, string includePublic);
  
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="includePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
        /// <returns>List<CommonResponse></returns>
        System.Threading.Tasks.Task<List<CommonResponse>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsync (int? organizationId, int? userId, string variableName, string organizationToken, string includePublic);
        
        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Specifies whether to return the effects or causes of the searched variable.</param>
        /// <returns>List<Correlation></returns>
        List<Correlation> V1PublicCorrelationsSearchSearchGet (string search, string effectOrCause);
  
        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Specifies whether to return the effects or causes of the searched variable.</param>
        /// <returns>List<Correlation></returns>
        System.Threading.Tasks.Task<List<Correlation>> V1PublicCorrelationsSearchSearchGetAsync (string search, string effectOrCause);
        
        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List<Correlation></returns>
        List<Correlation> V1VariablesVariableNameCausesGet (string variableName);
  
        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List<Correlation></returns>
        System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNameCausesGetAsync (string variableName);
        
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param>
        /// <returns>List<Correlation></returns>
        List<Correlation> V1VariablesVariableNameEffectsGet (string variableName);
  
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param>
        /// <returns>List<Correlation></returns>
        System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNameEffectsGetAsync (string variableName);
        
        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List<Correlation></returns>
        List<Correlation> V1VariablesVariableNamePublicCausesGet (string variableName);
  
        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List<Correlation></returns>
        System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNamePublicCausesGetAsync (string variableName);
        
        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param>
        /// <returns>List<Correlation></returns>
        List<Correlation> V1VariablesVariableNamePublicEffectsGet (string variableName);
  
        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param>
        /// <returns>List<Correlation></returns>
        System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNamePublicEffectsGetAsync (string variableName);
        
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="cause">Cause variable name</param>
        /// <param name="effect">Effect variable name</param>
        /// <param name="correlation">Correlation value</param>
        /// <param name="vote">Vote: 0 (for implausible) or 1 (for plausible)</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1VotesPost (string cause, string effect, double? correlation, bool? vote);
  
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="cause">Cause variable name</param>
        /// <param name="effect">Effect variable name</param>
        /// <param name="correlation">Correlation value</param>
        /// <param name="vote">Vote: 0 (for implausible) or 1 (for plausible)</param>
        /// <returns>CommonResponse</returns>
        System.Threading.Tasks.Task<CommonResponse> V1VotesPostAsync (string cause, string effect, double? correlation, bool? vote);
        
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
    public class CorrelationsApi : ICorrelationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CorrelationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CorrelationsApi(String basePath)
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
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param> 
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param> 
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</param> 
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed.</param> 
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</param> 
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param> 
        /// <returns>List<Correlation></returns>            
        public List<Correlation> V1CorrelationsGet (string effect, string cause, string correlationCoefficient, string onsetDelay, string durationOfAction, string lastUpdated, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/correlations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
            if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
            if (correlationCoefficient != null) queryParams.Add("correlationCoefficient", ApiClient.ParameterToString(correlationCoefficient)); // query parameter
            if (onsetDelay != null) queryParams.Add("onsetDelay", ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("durationOfAction", ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (lastUpdated != null) queryParams.Add("lastUpdated", ApiClient.ParameterToString(lastUpdated)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed.</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>List<Correlation></returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1CorrelationsGetAsync (string effect, string cause, string correlationCoefficient, string onsetDelay, string durationOfAction, string lastUpdated, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/correlations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
            if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
            if (correlationCoefficient != null) queryParams.Add("correlationCoefficient", ApiClient.ParameterToString(correlationCoefficient)); // query parameter
            if (onsetDelay != null) queryParams.Add("onsetDelay", ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("durationOfAction", ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (lastUpdated != null) queryParams.Add("lastUpdated", ApiClient.ParameterToString(lastUpdated)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsGet: " + response.Content, response.Content);

            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
        
        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <param name="body">Provides correlation data</param> 
        /// <returns></returns>            
        public void V1CorrelationsPost (PostCorrelation body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1CorrelationsPost");
            
    
            var path = "/v1/correlations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <param name="body">Provides correlation data</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1CorrelationsPostAsync (PostCorrelation body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1CorrelationsPost");
            
    
            var path = "/v1/correlations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsPost: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param> 
        /// <param name="userId">User id</param> 
        /// <param name="variableName">Effect variable name</param> 
        /// <param name="organizationToken">Organization access token</param> 
        /// <param name="includePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param> 
        /// <returns>List<Correlation></returns>            
        public List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? organizationId, int? userId, string variableName, string organizationToken, string includePublic)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null) throw new ApiException(400, "Missing required parameter 'organizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
    
            var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (organizationId != null) pathParams.Add("organizationId", ApiClient.ParameterToString(organizationId)); // path parameter
            if (userId != null) pathParams.Add("userId", ApiClient.ParameterToString(userId)); // path parameter
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            if (organizationToken != null) queryParams.Add("organization_token", ApiClient.ParameterToString(organizationToken)); // query parameter
            if (includePublic != null) queryParams.Add("include_public", ApiClient.ParameterToString(includePublic)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="includePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
        /// <returns>List<Correlation></returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsync (int? organizationId, int? userId, string variableName, string organizationToken, string includePublic)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null) throw new ApiException(400, "Missing required parameter 'organizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
    
            var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (organizationId != null) pathParams.Add("organizationId", ApiClient.ParameterToString(organizationId)); // path parameter
            if (userId != null) pathParams.Add("userId", ApiClient.ParameterToString(userId)); // path parameter
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            if (organizationToken != null) queryParams.Add("organization_token", ApiClient.ParameterToString(organizationToken)); // query parameter
            if (includePublic != null) queryParams.Add("include_public", ApiClient.ParameterToString(includePublic)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + response.Content, response.Content);

            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
        
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param> 
        /// <param name="userId">User id</param> 
        /// <param name="variableName">Cause variable name</param> 
        /// <param name="organizationToken">Organization access token</param> 
        /// <param name="includePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param> 
        /// <returns>List<CommonResponse></returns>            
        public List<CommonResponse> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? organizationId, int? userId, string variableName, string organizationToken, string includePublic)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null) throw new ApiException(400, "Missing required parameter 'organizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
    
            var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (organizationId != null) pathParams.Add("organizationId", ApiClient.ParameterToString(organizationId)); // path parameter
            if (userId != null) pathParams.Add("userId", ApiClient.ParameterToString(userId)); // path parameter
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            if (organizationToken != null) queryParams.Add("organization_token", ApiClient.ParameterToString(organizationToken)); // query parameter
            if (includePublic != null) queryParams.Add("include_public", ApiClient.ParameterToString(includePublic)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CommonResponse>) ApiClient.Deserialize(response.Content, typeof(List<CommonResponse>), response.Headers);
        }
    
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="includePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
        /// <returns>List<CommonResponse></returns>
        public async System.Threading.Tasks.Task<List<CommonResponse>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsync (int? organizationId, int? userId, string variableName, string organizationToken, string includePublic)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null) throw new ApiException(400, "Missing required parameter 'organizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
    
            var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (organizationId != null) pathParams.Add("organizationId", ApiClient.ParameterToString(organizationId)); // path parameter
            if (userId != null) pathParams.Add("userId", ApiClient.ParameterToString(userId)); // path parameter
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            if (organizationToken != null) queryParams.Add("organization_token", ApiClient.ParameterToString(organizationToken)); // query parameter
            if (includePublic != null) queryParams.Add("include_public", ApiClient.ParameterToString(includePublic)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + response.Content, response.Content);

            return (List<CommonResponse>) ApiClient.Deserialize(response.Content, typeof(List<CommonResponse>), response.Headers);
        }
        
        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param> 
        /// <param name="effectOrCause">Specifies whether to return the effects or causes of the searched variable.</param> 
        /// <returns>List<Correlation></returns>            
        public List<Correlation> V1PublicCorrelationsSearchSearchGet (string search, string effectOrCause)
        {
            
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling V1PublicCorrelationsSearchSearchGet");
            
            // verify the required parameter 'effectOrCause' is set
            if (effectOrCause == null) throw new ApiException(400, "Missing required parameter 'effectOrCause' when calling V1PublicCorrelationsSearchSearchGet");
            
    
            var path = "/v1/public/correlations/search/{search}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (search != null) pathParams.Add("search", ApiClient.ParameterToString(search)); // path parameter
            
            if (effectOrCause != null) queryParams.Add("effectOrCause", ApiClient.ParameterToString(effectOrCause)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicCorrelationsSearchSearchGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicCorrelationsSearchSearchGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Specifies whether to return the effects or causes of the searched variable.</param>
        /// <returns>List<Correlation></returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1PublicCorrelationsSearchSearchGetAsync (string search, string effectOrCause)
        {
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling V1PublicCorrelationsSearchSearchGet");
            // verify the required parameter 'effectOrCause' is set
            if (effectOrCause == null) throw new ApiException(400, "Missing required parameter 'effectOrCause' when calling V1PublicCorrelationsSearchSearchGet");
            
    
            var path = "/v1/public/correlations/search/{search}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (search != null) pathParams.Add("search", ApiClient.ParameterToString(search)); // path parameter
            
            if (effectOrCause != null) queryParams.Add("effectOrCause", ApiClient.ParameterToString(effectOrCause)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicCorrelationsSearchSearchGet: " + response.Content, response.Content);

            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
        
        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param> 
        /// <returns>List<Correlation></returns>            
        public List<Correlation> V1VariablesVariableNameCausesGet (string variableName)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNameCausesGet");
            
    
            var path = "/v1/variables/{variableName}/causes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameCausesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameCausesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List<Correlation></returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNameCausesGetAsync (string variableName)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNameCausesGet");
            
    
            var path = "/v1/variables/{variableName}/causes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameCausesGet: " + response.Content, response.Content);

            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
        
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param> 
        /// <returns>List<Correlation></returns>            
        public List<Correlation> V1VariablesVariableNameEffectsGet (string variableName)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNameEffectsGet");
            
    
            var path = "/v1/variables/{variableName}/effects";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameEffectsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameEffectsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param>
        /// <returns>List<Correlation></returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNameEffectsGetAsync (string variableName)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNameEffectsGet");
            
    
            var path = "/v1/variables/{variableName}/effects";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameEffectsGet: " + response.Content, response.Content);

            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
        
        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param> 
        /// <returns>List<Correlation></returns>            
        public List<Correlation> V1VariablesVariableNamePublicCausesGet (string variableName)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNamePublicCausesGet");
            
    
            var path = "/v1/variables/{variableName}/public/causes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicCausesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicCausesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List<Correlation></returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNamePublicCausesGetAsync (string variableName)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNamePublicCausesGet");
            
    
            var path = "/v1/variables/{variableName}/public/causes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicCausesGet: " + response.Content, response.Content);

            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
        
        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param> 
        /// <returns>List<Correlation></returns>            
        public List<Correlation> V1VariablesVariableNamePublicEffectsGet (string variableName)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNamePublicEffectsGet");
            
    
            var path = "/v1/variables/{variableName}/public/effects";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicEffectsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicEffectsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param>
        /// <returns>List<Correlation></returns>
        public async System.Threading.Tasks.Task<List<Correlation>> V1VariablesVariableNamePublicEffectsGetAsync (string variableName)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNamePublicEffectsGet");
            
    
            var path = "/v1/variables/{variableName}/public/effects";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicEffectsGet: " + response.Content, response.Content);

            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
        
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="cause">Cause variable name</param> 
        /// <param name="effect">Effect variable name</param> 
        /// <param name="correlation">Correlation value</param> 
        /// <param name="vote">Vote: 0 (for implausible) or 1 (for plausible)</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1VotesPost (string cause, string effect, double? correlation, bool? vote)
        {
            
            // verify the required parameter 'cause' is set
            if (cause == null) throw new ApiException(400, "Missing required parameter 'cause' when calling V1VotesPost");
            
            // verify the required parameter 'effect' is set
            if (effect == null) throw new ApiException(400, "Missing required parameter 'effect' when calling V1VotesPost");
            
            // verify the required parameter 'correlation' is set
            if (correlation == null) throw new ApiException(400, "Missing required parameter 'correlation' when calling V1VotesPost");
            
    
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
            if (correlation != null) queryParams.Add("correlation", ApiClient.ParameterToString(correlation)); // query parameter
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
        /// <param name="correlation">Correlation value</param>
        /// <param name="vote">Vote: 0 (for implausible) or 1 (for plausible)</param>
        /// <returns>CommonResponse</returns>
        public async System.Threading.Tasks.Task<CommonResponse> V1VotesPostAsync (string cause, string effect, double? correlation, bool? vote)
        {
            // verify the required parameter 'cause' is set
            if (cause == null) throw new ApiException(400, "Missing required parameter 'cause' when calling V1VotesPost");
            // verify the required parameter 'effect' is set
            if (effect == null) throw new ApiException(400, "Missing required parameter 'effect' when calling V1VotesPost");
            // verify the required parameter 'correlation' is set
            if (correlation == null) throw new ApiException(400, "Missing required parameter 'correlation' when calling V1VotesPost");
            
    
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
            if (correlation != null) queryParams.Add("correlation", ApiClient.ParameterToString(correlation)); // query parameter
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
