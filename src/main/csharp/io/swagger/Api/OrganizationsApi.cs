using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class OrganizationsApi {
    string basePath;
    protected RestClient restClient;

    public OrganizationsApi(String basePath = "https://localhost/api")
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
    /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>
    /// <param name="Body">Provides organization token and user ID</param>
    /// <returns>UserTokenSuccessfulResponse</returns>
    public UserTokenSuccessfulResponse V1OrganizationsOrganizationIdUsersPost (int? OrganizationId, UserTokenRequest Body) {

      var _request = new RestRequest("/v1/organizations/{organizationId}/users", Method.POST);

      
      // verify the required parameter 'OrganizationId' is set
      if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersPost");
      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling V1OrganizationsOrganizationIdUsersPost");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("organizationId", ApiInvoker.ParameterToString(OrganizationId)); // path (url segment) parameter
      
      
      
      
      _request.AddParameter("application/json", ApiInvoker.Serialize(Body), ParameterType.RequestBody); // http body (model) parameter
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersPost: " + response.Content);
      }
      return (UserTokenSuccessfulResponse) ApiInvoker.Deserialize(response.Content, typeof(UserTokenSuccessfulResponse));
    }
    
  }
  
}
