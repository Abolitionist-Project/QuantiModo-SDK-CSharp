using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class PairsApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public PairsApi(String basePath = "https://localhost/api")
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
    /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
    /// </summary>
    /// <param name="Cause">Original variable name for the explanatory or independent variable</param>
     /// <param name="Effect">Original variable name for the outcome or dependent variable</param>
     /// <param name="Duration">Duration of action (in seconds) from the cause variable settings.</param>
     /// <param name="Delay">Delay before onset of action (in seconds) from the cause variable settings.</param>
     /// <param name="StartTime">The earliest date (in epoch time) for which we should return measurements</param>
     /// <param name="EndTime">The most recent date (in epoch time) for which we should return measurements</param>
     /// <param name="CauseSource">Name of data source that the cause measurements should come from</param>
     /// <param name="EffectSource">Name of data source that the effectmeasurements should come from</param>
     /// <param name="CauseUnit">Abbreviated name for the unit cause measurements to be returned in</param>
     /// <param name="EffectUnit">Abbreviated name for the unit effect measurements to be returned in</param>
    
    /// <returns></returns>
    public void  pairsGet (string Cause, string Effect, string Duration, string Delay, string StartTime, string EndTime, string CauseSource, string EffectSource, string CauseUnit, string EffectUnit) {
      // create path and map variables
      var path = "/pairs".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (Cause != null){
        queryParams.Add("cause", apiInvoker.ParameterToString(Cause));
      }
      if (Effect != null){
        queryParams.Add("effect", apiInvoker.ParameterToString(Effect));
      }
      if (Duration != null){
        queryParams.Add("duration", apiInvoker.ParameterToString(Duration));
      }
      if (Delay != null){
        queryParams.Add("delay", apiInvoker.ParameterToString(Delay));
      }
      if (StartTime != null){
        queryParams.Add("startTime", apiInvoker.ParameterToString(StartTime));
      }
      if (EndTime != null){
        queryParams.Add("endTime", apiInvoker.ParameterToString(EndTime));
      }
      if (CauseSource != null){
        queryParams.Add("causeSource", apiInvoker.ParameterToString(CauseSource));
      }
      if (EffectSource != null){
        queryParams.Add("effectSource", apiInvoker.ParameterToString(EffectSource));
      }
      if (CauseUnit != null){
        queryParams.Add("causeUnit", apiInvoker.ParameterToString(CauseUnit));
      }
      if (EffectUnit != null){
        queryParams.Add("effectUnit", apiInvoker.ParameterToString(EffectUnit));
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
