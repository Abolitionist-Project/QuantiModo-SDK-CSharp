using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface ICorrelationsApi {
    
    /// <summary>
    /// Get correlations Get correlations
    /// </summary>
    /// <param name="Effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>/// <param name="Cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
    /// <returns>List<Correlation></returns>
    List<Correlation> CorrelationsGet (string Effect, string Cause);

    /// <summary>
    /// Get correlations Get correlations
    /// </summary>
    /// <param name="Effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>/// <param name="Cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
    /// <returns>List<Correlation></returns>
    Task<List<Correlation>> CorrelationsGetAsync (string Effect, string Cause);
    
    /// <summary>
    /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
    /// </summary>
    /// <param name="Search">Name of the variable that you want to know the causes or effects of.</param>/// <param name="EffectOrCause">Specifies whether to return the effects or causes of the searched variable.</param>
    /// <returns>List<Correlation></returns>
    List<Correlation> PublicCorrelationsSearchSearchGet (string Search, string EffectOrCause);

    /// <summary>
    /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
    /// </summary>
    /// <param name="Search">Name of the variable that you want to know the causes or effects of.</param>/// <param name="EffectOrCause">Specifies whether to return the effects or causes of the searched variable.</param>
    /// <returns>List<Correlation></returns>
    Task<List<Correlation>> PublicCorrelationsSearchSearchGetAsync (string Search, string EffectOrCause);
    
    /// <summary>
    /// Add correlation or/and vote for it Add correlation or/and vote for it
    /// </summary>
    /// <param name="Body">Provides correlation data</param>
    /// <returns></returns>
    void V1CorrelationsPost (PostCorrelation Body);

    /// <summary>
    /// Add correlation or/and vote for it Add correlation or/and vote for it
    /// </summary>
    /// <param name="Body">Provides correlation data</param>
    /// <returns></returns>
    Task V1CorrelationsPostAsync (PostCorrelation Body);
    
    /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="UserId">User id</param>/// <param name="VariableName">Effect variable name</param>/// <param name="OrganizationToken">Organization access token</param>/// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic);

    /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="UserId">User id</param>/// <param name="VariableName">Effect variable name</param>/// <param name="OrganizationToken">Organization access token</param>/// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    Task<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsync (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic);
    
    /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="UserId">User id</param>/// <param name="VariableName">Cause variable name</param>/// <param name="OrganizationToken">Organization access token</param>/// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic);

    /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="UserId">User id</param>/// <param name="VariableName">Cause variable name</param>/// <param name="OrganizationToken">Organization access token</param>/// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    Task<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsync (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic);
    
    /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    List<Correlation> V1VariablesVariableNameCausesGet (string VariableName);

    /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    Task<List<Correlation>> V1VariablesVariableNameCausesGetAsync (string VariableName);
    
    /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    List<Correlation> V1VariablesVariableNameEffectsGet (string VariableName);

    /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    Task<List<Correlation>> V1VariablesVariableNameEffectsGetAsync (string VariableName);
    
    /// <summary>
    /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    List<Correlation> V1VariablesVariableNamePublicCausesGet (string VariableName);

    /// <summary>
    /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    Task<List<Correlation>> V1VariablesVariableNamePublicCausesGetAsync (string VariableName);
    
    /// <summary>
    /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    List<Correlation> V1VariablesVariableNamePublicEffectsGet (string VariableName);

    /// <summary>
    /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    Task<List<Correlation>> V1VariablesVariableNamePublicEffectsGetAsync (string VariableName);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class CorrelationsApi : ICorrelationsApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="CorrelationsApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public CorrelationsApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CorrelationsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public CorrelationsApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Get correlations Get correlations
    /// </summary>
    /// <param name="Effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>/// <param name="Cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> CorrelationsGet (string Effect, string Cause) {

      

      var path = "/correlations";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Effect != null) queryParams.Add("effect", apiClient.ParameterToString(Effect)); // query parameter
       if (Cause != null) queryParams.Add("cause", apiClient.ParameterToString(Cause)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
	
	 /// <summary>
    /// Get correlations Get correlations
    /// </summary>
    /// <param name="Effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>/// <param name="Cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
    /// <returns>List<Correlation></returns>
    public async Task<List<Correlation>> CorrelationsGetAsync (string Effect, string Cause) {

      

      var path = "/correlations";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Effect != null) queryParams.Add("effect", apiClient.ParameterToString(Effect)); // query parameter
       if (Cause != null) queryParams.Add("cause", apiClient.ParameterToString(Cause)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    /// <summary>
    /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
    /// </summary>
    /// <param name="Search">Name of the variable that you want to know the causes or effects of.</param>/// <param name="EffectOrCause">Specifies whether to return the effects or causes of the searched variable.</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> PublicCorrelationsSearchSearchGet (string Search, string EffectOrCause) {

      
      // verify the required parameter 'Search' is set
      if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling PublicCorrelationsSearchSearchGet");
      
      // verify the required parameter 'EffectOrCause' is set
      if (EffectOrCause == null) throw new ApiException(400, "Missing required parameter 'EffectOrCause' when calling PublicCorrelationsSearchSearchGet");
      

      var path = "/public/correlations/search/{search}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "search" + "}", apiClient.ParameterToString(Search));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (EffectOrCause != null) queryParams.Add("effectOrCause", apiClient.ParameterToString(EffectOrCause)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicCorrelationsSearchSearchGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
	
	 /// <summary>
    /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
    /// </summary>
    /// <param name="Search">Name of the variable that you want to know the causes or effects of.</param>/// <param name="EffectOrCause">Specifies whether to return the effects or causes of the searched variable.</param>
    /// <returns>List<Correlation></returns>
    public async Task<List<Correlation>> PublicCorrelationsSearchSearchGetAsync (string Search, string EffectOrCause) {

      
          // verify the required parameter 'Search' is set
          if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling PublicCorrelationsSearchSearchGet");
      
          // verify the required parameter 'EffectOrCause' is set
          if (EffectOrCause == null) throw new ApiException(400, "Missing required parameter 'EffectOrCause' when calling PublicCorrelationsSearchSearchGet");
      

      var path = "/public/correlations/search/{search}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "search" + "}", apiClient.ParameterToString(Search));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (EffectOrCause != null) queryParams.Add("effectOrCause", apiClient.ParameterToString(EffectOrCause)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicCorrelationsSearchSearchGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    /// <summary>
    /// Add correlation or/and vote for it Add correlation or/and vote for it
    /// </summary>
    /// <param name="Body">Provides correlation data</param>
    /// <returns></returns>
    public void V1CorrelationsPost (PostCorrelation Body) {

      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling V1CorrelationsPost");
      

      var path = "/v1/correlations";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsPost: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Add correlation or/and vote for it Add correlation or/and vote for it
    /// </summary>
    /// <param name="Body">Provides correlation data</param>
    /// <returns></returns>
    public async Task V1CorrelationsPostAsync (PostCorrelation Body) {

      
          // verify the required parameter 'Body' is set
          if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling V1CorrelationsPost");
      

      var path = "/v1/correlations";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsPost: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="UserId">User id</param>/// <param name="VariableName">Effect variable name</param>/// <param name="OrganizationToken">Organization access token</param>/// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic) {

      
      // verify the required parameter 'OrganizationId' is set
      if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
      // verify the required parameter 'UserId' is set
      if (UserId == null) throw new ApiException(400, "Missing required parameter 'UserId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
      // verify the required parameter 'OrganizationToken' is set
      if (OrganizationToken == null) throw new ApiException(400, "Missing required parameter 'OrganizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      

      var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "organizationId" + "}", apiClient.ParameterToString(OrganizationId));
      path = path.Replace("{" + "userId" + "}", apiClient.ParameterToString(UserId));
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (OrganizationToken != null) queryParams.Add("organization_token", apiClient.ParameterToString(OrganizationToken)); // query parameter
       if (IncludePublic != null) queryParams.Add("include_public", apiClient.ParameterToString(IncludePublic)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
	
	 /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="UserId">User id</param>/// <param name="VariableName">Effect variable name</param>/// <param name="OrganizationToken">Organization access token</param>/// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    public async Task<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGetAsync (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic) {

      
          // verify the required parameter 'OrganizationId' is set
          if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
          // verify the required parameter 'UserId' is set
          if (UserId == null) throw new ApiException(400, "Missing required parameter 'UserId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
          // verify the required parameter 'OrganizationToken' is set
          if (OrganizationToken == null) throw new ApiException(400, "Missing required parameter 'OrganizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      

      var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "organizationId" + "}", apiClient.ParameterToString(OrganizationId));
      path = path.Replace("{" + "userId" + "}", apiClient.ParameterToString(UserId));
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (OrganizationToken != null) queryParams.Add("organization_token", apiClient.ParameterToString(OrganizationToken)); // query parameter
       if (IncludePublic != null) queryParams.Add("include_public", apiClient.ParameterToString(IncludePublic)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="UserId">User id</param>/// <param name="VariableName">Cause variable name</param>/// <param name="OrganizationToken">Organization access token</param>/// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic) {

      
      // verify the required parameter 'OrganizationId' is set
      if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
      // verify the required parameter 'UserId' is set
      if (UserId == null) throw new ApiException(400, "Missing required parameter 'UserId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
      // verify the required parameter 'OrganizationToken' is set
      if (OrganizationToken == null) throw new ApiException(400, "Missing required parameter 'OrganizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      

      var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "organizationId" + "}", apiClient.ParameterToString(OrganizationId));
      path = path.Replace("{" + "userId" + "}", apiClient.ParameterToString(UserId));
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (OrganizationToken != null) queryParams.Add("organization_token", apiClient.ParameterToString(OrganizationToken)); // query parameter
       if (IncludePublic != null) queryParams.Add("include_public", apiClient.ParameterToString(IncludePublic)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
	
	 /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="UserId">User id</param>/// <param name="VariableName">Cause variable name</param>/// <param name="OrganizationToken">Organization access token</param>/// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    public async Task<List<Correlation>> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGetAsync (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic) {

      
          // verify the required parameter 'OrganizationId' is set
          if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
          // verify the required parameter 'UserId' is set
          if (UserId == null) throw new ApiException(400, "Missing required parameter 'UserId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
          // verify the required parameter 'OrganizationToken' is set
          if (OrganizationToken == null) throw new ApiException(400, "Missing required parameter 'OrganizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      

      var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "organizationId" + "}", apiClient.ParameterToString(OrganizationId));
      path = path.Replace("{" + "userId" + "}", apiClient.ParameterToString(UserId));
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (OrganizationToken != null) queryParams.Add("organization_token", apiClient.ParameterToString(OrganizationToken)); // query parameter
       if (IncludePublic != null) queryParams.Add("include_public", apiClient.ParameterToString(IncludePublic)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1VariablesVariableNameCausesGet (string VariableName) {

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNameCausesGet");
      

      var path = "/v1/variables/{variableName}/causes";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameCausesGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
	
	 /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    public async Task<List<Correlation>> V1VariablesVariableNameCausesGetAsync (string VariableName) {

      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNameCausesGet");
      

      var path = "/v1/variables/{variableName}/causes";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameCausesGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1VariablesVariableNameEffectsGet (string VariableName) {

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNameEffectsGet");
      

      var path = "/v1/variables/{variableName}/effects";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameEffectsGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
	
	 /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    public async Task<List<Correlation>> V1VariablesVariableNameEffectsGetAsync (string VariableName) {

      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNameEffectsGet");
      

      var path = "/v1/variables/{variableName}/effects";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameEffectsGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    /// <summary>
    /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1VariablesVariableNamePublicCausesGet (string VariableName) {

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNamePublicCausesGet");
      

      var path = "/v1/variables/{variableName}/public/causes";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicCausesGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
	
	 /// <summary>
    /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    public async Task<List<Correlation>> V1VariablesVariableNamePublicCausesGetAsync (string VariableName) {

      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNamePublicCausesGet");
      

      var path = "/v1/variables/{variableName}/public/causes";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicCausesGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    /// <summary>
    /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1VariablesVariableNamePublicEffectsGet (string VariableName) {

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNamePublicEffectsGet");
      

      var path = "/v1/variables/{variableName}/public/effects";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicEffectsGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
	
	 /// <summary>
    /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    public async Task<List<Correlation>> V1VariablesVariableNamePublicEffectsGetAsync (string VariableName) {

      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNamePublicEffectsGet");
      

      var path = "/v1/variables/{variableName}/public/effects";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicEffectsGet: " + response.Content, response.Content);
      }
      return (List<Correlation>) apiClient.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
  }  
  
}
