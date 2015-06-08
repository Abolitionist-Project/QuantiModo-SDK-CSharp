using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class CorrelationsApi {
    string basePath;
    protected RestClient restClient;

    public CorrelationsApi(String basePath = "https://localhost/api")
    {
      this.basePath = basePath;
      this.restClient = new RestClient(basePath);
    }

    /// <summary>
    /// Sets the endpoint base url for the services being accessed
    /// </summary>
    /// <param name="basePath"> Base URL
    /// <returns></returns>
    public void SetBasePath(string basePath) {
      this.basePath = basePath;
    }

    /// <summary>
    /// Gets the endpoint base url for the services being accessed
    /// <returns>Base URL</returns>
    /// </summary>
    public String GetBasePath() {
      return this.basePath;
    }

    
    
    /// <summary>
    /// Get correlations Get correlations
    /// </summary>
    /// <param name="Effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>
    /// <param name="Cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> CorrelationsGet (string Effect, string Cause) {

      var _request = new RestRequest("/correlations", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (Effect != null) _request.AddParameter("effect", ApiInvoker.ParameterToString(Effect)); // query parameter
       if (Cause != null) _request.AddParameter("cause", ApiInvoker.ParameterToString(Cause)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsGet: " + response.Content);
      }
      return (List<Correlation>) ApiInvoker.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    
    /// <summary>
    /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
    /// </summary>
    /// <param name="Search">Name of the variable that you want to know the causes or effects of.</param>
    /// <param name="EffectOrCause">Specifies whether to return the effects or causes of the searched variable.</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> PublicCorrelationsSearchSearchGet (string Search, string EffectOrCause) {

      var _request = new RestRequest("/public/correlations/search/{search}", Method.GET);

      
      // verify the required parameter 'Search' is set
      if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling PublicCorrelationsSearchSearchGet");
      
      // verify the required parameter 'EffectOrCause' is set
      if (EffectOrCause == null) throw new ApiException(400, "Missing required parameter 'EffectOrCause' when calling PublicCorrelationsSearchSearchGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("search", ApiInvoker.ParameterToString(Search)); // path (url segment) parameter
      
       if (EffectOrCause != null) _request.AddParameter("effectOrCause", ApiInvoker.ParameterToString(EffectOrCause)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicCorrelationsSearchSearchGet: " + response.Content);
      }
      return (List<Correlation>) ApiInvoker.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    
    /// <summary>
    /// Add correlation or/and vote for it Add correlation or/and vote for it
    /// </summary>
    /// <param name="Body">Provides correlation data</param>
    /// <returns></returns>
    public void V1CorrelationsPost (PostCorrelation Body) {

      var _request = new RestRequest("/v1/correlations", Method.POST);

      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling V1CorrelationsPost");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      _request.AddParameter("application/json", ApiInvoker.Serialize(Body), ParameterType.RequestBody); // http body (model) parameter
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsPost: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>
    /// <param name="UserId">User id</param>
    /// <param name="VariableName">Effect variable name</param>
    /// <param name="OrganizationToken">Organization access token</param>
    /// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic) {

      var _request = new RestRequest("/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes", Method.GET);

      
      // verify the required parameter 'OrganizationId' is set
      if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
      // verify the required parameter 'UserId' is set
      if (UserId == null) throw new ApiException(400, "Missing required parameter 'UserId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      
      // verify the required parameter 'OrganizationToken' is set
      if (OrganizationToken == null) throw new ApiException(400, "Missing required parameter 'OrganizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("organizationId", ApiInvoker.ParameterToString(OrganizationId)); // path (url segment) parameter
      _request.AddUrlSegment("userId", ApiInvoker.ParameterToString(UserId)); // path (url segment) parameter
      _request.AddUrlSegment("variableName", ApiInvoker.ParameterToString(VariableName)); // path (url segment) parameter
      
       if (OrganizationToken != null) _request.AddParameter("organization_token", ApiInvoker.ParameterToString(OrganizationToken)); // query parameter
       if (IncludePublic != null) _request.AddParameter("include_public", ApiInvoker.ParameterToString(IncludePublic)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + response.Content);
      }
      return (List<Correlation>) ApiInvoker.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    
    /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>
    /// <param name="UserId">User id</param>
    /// <param name="VariableName">Cause variable name</param>
    /// <param name="OrganizationToken">Organization access token</param>
    /// <param name="IncludePublic">Include bublic correlations, Can be \&quot;1\&quot; or empty.</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? OrganizationId, int? UserId, string VariableName, string OrganizationToken, string IncludePublic) {

      var _request = new RestRequest("/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects", Method.GET);

      
      // verify the required parameter 'OrganizationId' is set
      if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
      // verify the required parameter 'UserId' is set
      if (UserId == null) throw new ApiException(400, "Missing required parameter 'UserId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      
      // verify the required parameter 'OrganizationToken' is set
      if (OrganizationToken == null) throw new ApiException(400, "Missing required parameter 'OrganizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("organizationId", ApiInvoker.ParameterToString(OrganizationId)); // path (url segment) parameter
      _request.AddUrlSegment("userId", ApiInvoker.ParameterToString(UserId)); // path (url segment) parameter
      _request.AddUrlSegment("variableName", ApiInvoker.ParameterToString(VariableName)); // path (url segment) parameter
      
       if (OrganizationToken != null) _request.AddParameter("organization_token", ApiInvoker.ParameterToString(OrganizationToken)); // query parameter
       if (IncludePublic != null) _request.AddParameter("include_public", ApiInvoker.ParameterToString(IncludePublic)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + response.Content);
      }
      return (List<Correlation>) ApiInvoker.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    
    /// <summary>
    /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1VariablesVariableNameCausesGet (string VariableName) {

      var _request = new RestRequest("/v1/variables/{variableName}/causes", Method.GET);

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNameCausesGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("variableName", ApiInvoker.ParameterToString(VariableName)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameCausesGet: " + response.Content);
      }
      return (List<Correlation>) ApiInvoker.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    
    /// <summary>
    /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1VariablesVariableNameEffectsGet (string VariableName) {

      var _request = new RestRequest("/v1/variables/{variableName}/effects", Method.GET);

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNameEffectsGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("variableName", ApiInvoker.ParameterToString(VariableName)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameEffectsGet: " + response.Content);
      }
      return (List<Correlation>) ApiInvoker.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    
    /// <summary>
    /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
    /// </summary>
    /// <param name="VariableName">Effect variable name</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1VariablesVariableNamePublicCausesGet (string VariableName) {

      var _request = new RestRequest("/v1/variables/{variableName}/public/causes", Method.GET);

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNamePublicCausesGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("variableName", ApiInvoker.ParameterToString(VariableName)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicCausesGet: " + response.Content);
      }
      return (List<Correlation>) ApiInvoker.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
    
    /// <summary>
    /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
    /// </summary>
    /// <param name="VariableName">Cause variable name</param>
    /// <returns>List<Correlation></returns>
    public List<Correlation> V1VariablesVariableNamePublicEffectsGet (string VariableName) {

      var _request = new RestRequest("/v1/variables/{variableName}/public/effects", Method.GET);

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling V1VariablesVariableNamePublicEffectsGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("variableName", ApiInvoker.ParameterToString(VariableName)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicEffectsGet: " + response.Content);
      }
      return (List<Correlation>) ApiInvoker.Deserialize(response.Content, typeof(List<Correlation>));
    }
    
  }
  
}
