using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class AdministrationApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public AdministrationApi(String basePath = "https://localhost/api")
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
    /// getCacheClear Clears the memcached cache for the units and some other things.
    /// </summary>
    
    /// <returns></returns>
    public void  administrationCacheClearGet () {
      // create path and map variables
      var path = "/administration/cache/clear".Replace("{format}","json");

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
    /// getCorrelationsUpdate Recalculate correlations for a variable
    /// </summary>
    /// <param name="ModifiedVariable">Original name of variable for which correlations are to be calculated (varchar)</param>
     /// <param name="UserId">ID for user for whom the correlations should be recalculated.</param>
    
    /// <returns></returns>
    public void  administrationCorrelationsUpdateGet (string ModifiedVariable, int? UserId) {
      // create path and map variables
      var path = "/administration/correlations/update".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (ModifiedVariable != null){
        queryParams.Add("modifiedVariable", apiInvoker.ParameterToString(ModifiedVariable));
      }
      if (UserId != null){
        queryParams.Add("userId", apiInvoker.ParameterToString(UserId));
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
    

    /// <summary>
    /// getCorrelationsUpdateAllUsers Recalculates correlations for all variables, for all users.
    /// </summary>
    
    /// <returns></returns>
    public void  administrationCorrelationsUpdateAllUsersGet () {
      // create path and map variables
      var path = "/administration/correlations/updateAllUsers".Replace("{format}","json");

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
    /// getCorrelationsUpdateAllVariables Updates the correlations for all variables for a given user.
    /// </summary>
    /// <param name="UserId">ID for user for whom the correlations should be recalculated. If empty, uses currently logged in user.</param>
    
    /// <returns></returns>
    public void  administrationCorrelationsUpdateAllVariablesGet (int? UserId) {
      // create path and map variables
      var path = "/administration/correlations/updateAllVariables".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (UserId != null){
        queryParams.Add("userId", apiInvoker.ParameterToString(UserId));
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
