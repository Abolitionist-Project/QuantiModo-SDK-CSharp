using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class UserApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public UserApi(String basePath = "https://localhost/api")
    {
      this.basePath = basePath;
    }

    public ApiInvoker getInvoker() {
      return apiInvoker;
    }

    // Sets the endpoint base url for the services being accessed
    public void setBasePath(string basePath) {
      this.basePath = basePath;
    }

    // Gets the endpoint base url for the services being accessed
    public String getBasePath() {
      return basePath;
    }

    

    /// <summary>
    /// Get all available units for variableGet authenticated user 
    /// </summary>
    
    /// <returns></returns>
    public void  userMeGet () {
      // create path and map variables
      var path = "/user/me".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ;
        }
        else {
          throw ex;
        }
      }
    }
    

    /// <summary>
    /// Get user tokens for existing users, create new users Get user tokens for existing users, create new users
    /// </summary>
    /// <param name="OrganizationId">Organization ID</param>
     /// <param name="Body">Provides organization token and user ID</param>
    
    /// <returns></returns>
    public UserTokenSuccessfulResponse  v1OrganizationsOrganizationIdUsersPost (int? OrganizationId, UserTokenRequest Body) {
      // create path and map variables
      var path = "/v1/organizations/{organizationId}/users".Replace("{format}","json").Replace("{" + "organizationId" + "}", apiInvoker.ParameterToString(OrganizationId));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(UserTokenSuccessfulResponse) == typeof(byte[])) {
          
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return ((object)response) as UserTokenSuccessfulResponse;
          
          
        } else {
          
          var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, Body, headerParams, formParams);
          if (response != null){
             return (UserTokenSuccessfulResponse) ApiInvoker.deserialize(response, typeof(UserTokenSuccessfulResponse));
          }
          else {
            return null;
          }
          
          
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return null;
        }
        else {
          throw ex;
        }
      }
    }
    
  }
  
}
