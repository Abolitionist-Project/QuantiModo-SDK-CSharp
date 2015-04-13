using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class MeasurementsApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public MeasurementsApi(String basePath = "https://localhost/api")
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
    /// Get measurement sources 
    /// </summary>
    
    /// <returns></returns>
    public void  measurementSourcesGet () {
      // create path and map variables
      var path = "/measurementSources".Replace("{format}","json");

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
    /// Set measurement source Set measurement source
    /// </summary>
    /// <param name="Measurements">An array of measurements you want to insert</param>
    
    /// <returns></returns>
    public void  measurementSourcesPost (List<MeasurementSource> Measurements) {
      // create path and map variables
      var path = "/measurementSources".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "POST", queryParams, Measurements, headerParams, formParams);
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
    /// Get measurements for this user Get measurements for this user
    /// </summary>
    /// <param name="VariableName">Name of the variable you want measurements for</param>
     /// <param name="Unit">The unit your want the measurements in</param>
     /// <param name="StartTime">The lower limit of measurements returned (Epoch)</param>
     /// <param name="EndTime">The upper limit of measurements returned (Epoch)</param>
     /// <param name="GroupingWidth">The time (in seconds) over which measurements are grouped together</param>
     /// <param name="GroupingTimezone">The time (in seconds) over which measurements are grouped together</param>
    
    /// <returns></returns>
    public void  measurementsGet (string VariableName, string Unit, string StartTime, string EndTime, int? GroupingWidth, string GroupingTimezone) {
      // create path and map variables
      var path = "/measurements".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (VariableName != null){
        queryParams.Add("variableName", apiInvoker.ParameterToString(VariableName));
      }
      if (Unit != null){
        queryParams.Add("unit", apiInvoker.ParameterToString(Unit));
      }
      if (StartTime != null){
        queryParams.Add("startTime", apiInvoker.ParameterToString(StartTime));
      }
      if (EndTime != null){
        queryParams.Add("endTime", apiInvoker.ParameterToString(EndTime));
      }
      if (GroupingWidth != null){
        queryParams.Add("groupingWidth", apiInvoker.ParameterToString(GroupingWidth));
      }
      if (GroupingTimezone != null){
        queryParams.Add("groupingTimezone", apiInvoker.ParameterToString(GroupingTimezone));
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
    /// Set measurement Set measurement
    /// </summary>
    /// <param name="Measurements">An array of measurements you want to insert</param>
    
    /// <returns></returns>
    public void  measurementsV2Post (List<Measurement> Measurements) {
      // create path and map variables
      var path = "/measurements/v2".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "POST", queryParams, Measurements, headerParams, formParams);
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
    /// Get measurements range for this user Get timestamp of the user&#39;s first and last measurements taken.
    /// </summary>
    /// <param name="Sources">Enter source name to limit to specific source (varchar)</param>
     /// <param name="User">If not specified, uses currently logged in user (bigint)</param>
    
    /// <returns></returns>
    public void  measurementsRangeGet (string Sources, int? User) {
      // create path and map variables
      var path = "/measurementsRange".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (Sources != null){
        queryParams.Add("sources", apiInvoker.ParameterToString(Sources));
      }
      if (User != null){
        queryParams.Add("user", apiInvoker.ParameterToString(User));
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
