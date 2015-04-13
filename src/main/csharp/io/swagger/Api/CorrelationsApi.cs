using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class CorrelationsApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public CorrelationsApi(String basePath = "https://localhost/api")
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
    /// Get correlations Get correlations
    /// </summary>
    /// <param name="Effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>
     /// <param name="Cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
    
    /// <returns></returns>
    public List<Correlation>  correlationsGet (string Effect, string Cause) {
      // create path and map variables
      var path = "/correlations".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (Effect != null){
        queryParams.Add("effect", apiInvoker.ParameterToString(Effect));
      }
      if (Cause != null){
        queryParams.Add("cause", apiInvoker.ParameterToString(Cause));
      }
      

      

      

      try {
        if (typeof(List<Correlation>) == typeof(byte[])) {
          
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return ((object)response) as List<Correlation>;
          
          
        } else {
          
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          if (response != null){
             return (List<Correlation>) ApiInvoker.deserialize(response, typeof(List<Correlation>));
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
    

    /// <summary>
    /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query.
    /// </summary>
    /// <param name="Search">Search query</param>
     /// <param name="EffectOrCause">Specifies whehter to return the effects or causes of the searched variable.</param>
    
    /// <returns></returns>
    public List<Correlation>  publicCorrelationsSearchSearchGet (string Search, string EffectOrCause) {
      // create path and map variables
      var path = "/public/correlations/search/{search}".Replace("{format}","json").Replace("{" + "search" + "}", apiInvoker.ParameterToString(Search));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (EffectOrCause != null){
        queryParams.Add("effectOrCause", apiInvoker.ParameterToString(EffectOrCause));
      }
      

      

      

      try {
        if (typeof(List<Correlation>) == typeof(byte[])) {
          
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return ((object)response) as List<Correlation>;
          
          
        } else {
          
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          if (response != null){
             return (List<Correlation>) ApiInvoker.deserialize(response, typeof(List<Correlation>));
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
