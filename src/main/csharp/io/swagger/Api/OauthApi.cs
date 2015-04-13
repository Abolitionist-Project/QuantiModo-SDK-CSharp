using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class OauthApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public OauthApi(String basePath = "https://localhost/api")
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
    /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM  account.
    /// </summary>
    /// <param name="ResponseType">Response type</param>
     /// <param name="RedirectUri">Redirect uri</param>
     /// <param name="Realm">Realm</param>
     /// <param name="ClientId">Client id</param>
     /// <param name="Scope">Scope</param>
     /// <param name="State">State</param>
    
    /// <returns></returns>
    public void  oauth2AuthorizeGet (string ResponseType, string RedirectUri, string Realm, string ClientId, string Scope, string State) {
      // create path and map variables
      var path = "/oauth2/authorize".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (ResponseType != null){
        queryParams.Add("response_type", apiInvoker.ParameterToString(ResponseType));
      }
      if (RedirectUri != null){
        queryParams.Add("redirect_uri", apiInvoker.ParameterToString(RedirectUri));
      }
      if (Realm != null){
        queryParams.Add("realm", apiInvoker.ParameterToString(Realm));
      }
      if (ClientId != null){
        queryParams.Add("client_id", apiInvoker.ParameterToString(ClientId));
      }
      if (Scope != null){
        queryParams.Add("scope", apiInvoker.ParameterToString(Scope));
      }
      if (State != null){
        queryParams.Add("state", apiInvoker.ParameterToString(State));
      }
      

      

      

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
    
  }
  
}
