using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IUserApi
    {
        
        /// <summary>
        /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="body">Provides organization token and user ID</param>
        /// <returns>UserTokenSuccessfulResponse</returns>
        UserTokenSuccessfulResponse V1OrganizationsOrganizationIdUsersPost (int? organizationId, UserTokenRequest body);
  
        /// <summary>
        /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="body">Provides organization token and user ID</param>
        /// <returns>UserTokenSuccessfulResponse</returns>
        System.Threading.Tasks.Task<UserTokenSuccessfulResponse> V1OrganizationsOrganizationIdUsersPostAsync (int? organizationId, UserTokenRequest body);
        
        /// <summary>
        /// Get all available units for variableGet authenticated user Returns user info for the currently authenticated user.
        /// </summary>
        /// <returns>User</returns>
        User V1UserMeGet ();
  
        /// <summary>
        /// Get all available units for variableGet authenticated user Returns user info for the currently authenticated user.
        /// </summary>
        /// <returns>User</returns>
        System.Threading.Tasks.Task<User> V1UserMeGetAsync ();
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
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
        /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
        /// </summary>
        /// <param name="organizationId">Organization ID</param> 
        /// <param name="body">Provides organization token and user ID</param> 
        /// <returns>UserTokenSuccessfulResponse</returns>            
        public UserTokenSuccessfulResponse V1OrganizationsOrganizationIdUsersPost (int? organizationId, UserTokenRequest body)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling V1OrganizationsOrganizationIdUsersPost");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1OrganizationsOrganizationIdUsersPost");
            
    
            var path = "/v1/organizations/{organizationId}/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (organizationId != null) pathParams.Add("organizationId", ApiClient.ParameterToString(organizationId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserTokenSuccessfulResponse) ApiClient.Deserialize(response.Content, typeof(UserTokenSuccessfulResponse), response.Headers);
        }
    
        /// <summary>
        /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="body">Provides organization token and user ID</param>
        /// <returns>UserTokenSuccessfulResponse</returns>
        public async System.Threading.Tasks.Task<UserTokenSuccessfulResponse> V1OrganizationsOrganizationIdUsersPostAsync (int? organizationId, UserTokenRequest body)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling V1OrganizationsOrganizationIdUsersPost");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1OrganizationsOrganizationIdUsersPost");
            
    
            var path = "/v1/organizations/{organizationId}/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (organizationId != null) pathParams.Add("organizationId", ApiClient.ParameterToString(organizationId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersPost: " + response.Content, response.Content);

            return (UserTokenSuccessfulResponse) ApiClient.Deserialize(response.Content, typeof(UserTokenSuccessfulResponse), response.Headers);
        }
        
        /// <summary>
        /// Get all available units for variableGet authenticated user Returns user info for the currently authenticated user.
        /// </summary>
        /// <returns>User</returns>            
        public User V1UserMeGet ()
        {
            
    
            var path = "/v1/user/me";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserMeGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserMeGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Get all available units for variableGet authenticated user Returns user info for the currently authenticated user.
        /// </summary>
        /// <returns>User</returns>
        public async System.Threading.Tasks.Task<User> V1UserMeGetAsync ()
        {
            
    
            var path = "/v1/user/me";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserMeGet: " + response.Content, response.Content);

            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
        
    }
    
}
