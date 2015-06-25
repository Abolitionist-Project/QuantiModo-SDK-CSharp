using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IUserApi {
    
    /// <summary>
    /// Get all available units for variableGet authenticated user Returns user info for the currently authenticated user.
    /// </summary>
    
    /// <returns>User</returns>
    User UserMeGet ();

    /// <summary>
    /// Get all available units for variableGet authenticated user Returns user info for the currently authenticated user.
    /// </summary>
    
    /// <returns>User</returns>
    Task<User> UserMeGetAsync ();
    
    /// <summary>
    /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="Body">Provides organization token and user ID</param>
    /// <returns>UserTokenSuccessfulResponse</returns>
    UserTokenSuccessfulResponse V1OrganizationsOrganizationIdUsersPost (int? OrganizationId, UserTokenRequest Body);

    /// <summary>
    /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="Body">Provides organization token and user ID</param>
    /// <returns>UserTokenSuccessfulResponse</returns>
    Task<UserTokenSuccessfulResponse> V1OrganizationsOrganizationIdUsersPostAsync (int? OrganizationId, UserTokenRequest Body);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class UserApi : IUserApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="UserApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public UserApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserApi"/> class.
    /// </summary>
    /// <returns></returns>
    public UserApi(String basePath)
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
    /// Get all available units for variableGet authenticated user Returns user info for the currently authenticated user.
    /// </summary>
    
    /// <returns>User</returns>
    public User UserMeGet () {

      

      var path = "/user/me";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UserMeGet: " + response.Content, response.Content);
      }
      return (User) apiClient.Deserialize(response.Content, typeof(User));
    }
	
	 /// <summary>
    /// Get all available units for variableGet authenticated user Returns user info for the currently authenticated user.
    /// </summary>
    
    /// <returns>User</returns>
    public async Task<User> UserMeGetAsync () {

      

      var path = "/user/me";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UserMeGet: " + response.Content, response.Content);
      }
      return (User) apiClient.Deserialize(response.Content, typeof(User));
    }
    
    /// <summary>
    /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="Body">Provides organization token and user ID</param>
    /// <returns>UserTokenSuccessfulResponse</returns>
    public UserTokenSuccessfulResponse V1OrganizationsOrganizationIdUsersPost (int? OrganizationId, UserTokenRequest Body) {

      
      // verify the required parameter 'OrganizationId' is set
      if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersPost");
      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling V1OrganizationsOrganizationIdUsersPost");
      

      var path = "/v1/organizations/{organizationId}/users";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "organizationId" + "}", apiClient.ParameterToString(OrganizationId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersPost: " + response.Content, response.Content);
      }
      return (UserTokenSuccessfulResponse) apiClient.Deserialize(response.Content, typeof(UserTokenSuccessfulResponse));
    }
	
	 /// <summary>
    /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>/// <param name="Body">Provides organization token and user ID</param>
    /// <returns>UserTokenSuccessfulResponse</returns>
    public async Task<UserTokenSuccessfulResponse> V1OrganizationsOrganizationIdUsersPostAsync (int? OrganizationId, UserTokenRequest Body) {

      
          // verify the required parameter 'OrganizationId' is set
          if (OrganizationId == null) throw new ApiException(400, "Missing required parameter 'OrganizationId' when calling V1OrganizationsOrganizationIdUsersPost");
      
          // verify the required parameter 'Body' is set
          if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling V1OrganizationsOrganizationIdUsersPost");
      

      var path = "/v1/organizations/{organizationId}/users";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "organizationId" + "}", apiClient.ParameterToString(OrganizationId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersPost: " + response.Content, response.Content);
      }
      return (UserTokenSuccessfulResponse) apiClient.Deserialize(response.Content, typeof(UserTokenSuccessfulResponse));
    }
    
  }  
  
}
