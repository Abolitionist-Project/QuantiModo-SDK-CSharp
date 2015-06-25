using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IPairsApi {
    
    /// <summary>
    /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
    /// </summary>
    /// <param name="Cause">Original variable name for the explanatory or independent variable</param>/// <param name="CauseSource">Name of data source that the cause measurements should come from</param>/// <param name="CauseUnit">Abbreviated name for the unit cause measurements to be returned in</param>/// <param name="Delay">Delay before onset of action (in seconds) from the cause variable settings.</param>/// <param name="Duration">Duration of action (in seconds) from the cause variable settings.</param>/// <param name="Effect">Original variable name for the outcome or dependent variable</param>/// <param name="EffectSource">Name of data source that the effectmeasurements should come from</param>/// <param name="EffectUnit">Abbreviated name for the unit effect measurements to be returned in</param>/// <param name="EndTime">The most recent date (in epoch time) for which we should return measurements</param>/// <param name="StartTime">The earliest date (in epoch time) for which we should return measurements</param>
    /// <returns>List<Pairs></returns>
    List<Pairs> PairsGet (string Cause, string CauseSource, string CauseUnit, string Delay, string Duration, string Effect, string EffectSource, string EffectUnit, string EndTime, string StartTime);

    /// <summary>
    /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
    /// </summary>
    /// <param name="Cause">Original variable name for the explanatory or independent variable</param>/// <param name="CauseSource">Name of data source that the cause measurements should come from</param>/// <param name="CauseUnit">Abbreviated name for the unit cause measurements to be returned in</param>/// <param name="Delay">Delay before onset of action (in seconds) from the cause variable settings.</param>/// <param name="Duration">Duration of action (in seconds) from the cause variable settings.</param>/// <param name="Effect">Original variable name for the outcome or dependent variable</param>/// <param name="EffectSource">Name of data source that the effectmeasurements should come from</param>/// <param name="EffectUnit">Abbreviated name for the unit effect measurements to be returned in</param>/// <param name="EndTime">The most recent date (in epoch time) for which we should return measurements</param>/// <param name="StartTime">The earliest date (in epoch time) for which we should return measurements</param>
    /// <returns>List<Pairs></returns>
    Task<List<Pairs>> PairsGetAsync (string Cause, string CauseSource, string CauseUnit, string Delay, string Duration, string Effect, string EffectSource, string EffectUnit, string EndTime, string StartTime);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class PairsApi : IPairsApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="PairsApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public PairsApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PairsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public PairsApi(String basePath)
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
    /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
    /// </summary>
    /// <param name="Cause">Original variable name for the explanatory or independent variable</param>/// <param name="CauseSource">Name of data source that the cause measurements should come from</param>/// <param name="CauseUnit">Abbreviated name for the unit cause measurements to be returned in</param>/// <param name="Delay">Delay before onset of action (in seconds) from the cause variable settings.</param>/// <param name="Duration">Duration of action (in seconds) from the cause variable settings.</param>/// <param name="Effect">Original variable name for the outcome or dependent variable</param>/// <param name="EffectSource">Name of data source that the effectmeasurements should come from</param>/// <param name="EffectUnit">Abbreviated name for the unit effect measurements to be returned in</param>/// <param name="EndTime">The most recent date (in epoch time) for which we should return measurements</param>/// <param name="StartTime">The earliest date (in epoch time) for which we should return measurements</param>
    /// <returns>List<Pairs></returns>
    public List<Pairs> PairsGet (string Cause, string CauseSource, string CauseUnit, string Delay, string Duration, string Effect, string EffectSource, string EffectUnit, string EndTime, string StartTime) {

      
      // verify the required parameter 'Cause' is set
      if (Cause == null) throw new ApiException(400, "Missing required parameter 'Cause' when calling PairsGet");
      
      // verify the required parameter 'Effect' is set
      if (Effect == null) throw new ApiException(400, "Missing required parameter 'Effect' when calling PairsGet");
      

      var path = "/pairs";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Cause != null) queryParams.Add("cause", apiClient.ParameterToString(Cause)); // query parameter
       if (CauseSource != null) queryParams.Add("causeSource", apiClient.ParameterToString(CauseSource)); // query parameter
       if (CauseUnit != null) queryParams.Add("causeUnit", apiClient.ParameterToString(CauseUnit)); // query parameter
       if (Delay != null) queryParams.Add("delay", apiClient.ParameterToString(Delay)); // query parameter
       if (Duration != null) queryParams.Add("duration", apiClient.ParameterToString(Duration)); // query parameter
       if (Effect != null) queryParams.Add("effect", apiClient.ParameterToString(Effect)); // query parameter
       if (EffectSource != null) queryParams.Add("effectSource", apiClient.ParameterToString(EffectSource)); // query parameter
       if (EffectUnit != null) queryParams.Add("effectUnit", apiClient.ParameterToString(EffectUnit)); // query parameter
       if (EndTime != null) queryParams.Add("endTime", apiClient.ParameterToString(EndTime)); // query parameter
       if (StartTime != null) queryParams.Add("startTime", apiClient.ParameterToString(StartTime)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PairsGet: " + response.Content, response.Content);
      }
      return (List<Pairs>) apiClient.Deserialize(response.Content, typeof(List<Pairs>));
    }
	
	 /// <summary>
    /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
    /// </summary>
    /// <param name="Cause">Original variable name for the explanatory or independent variable</param>/// <param name="CauseSource">Name of data source that the cause measurements should come from</param>/// <param name="CauseUnit">Abbreviated name for the unit cause measurements to be returned in</param>/// <param name="Delay">Delay before onset of action (in seconds) from the cause variable settings.</param>/// <param name="Duration">Duration of action (in seconds) from the cause variable settings.</param>/// <param name="Effect">Original variable name for the outcome or dependent variable</param>/// <param name="EffectSource">Name of data source that the effectmeasurements should come from</param>/// <param name="EffectUnit">Abbreviated name for the unit effect measurements to be returned in</param>/// <param name="EndTime">The most recent date (in epoch time) for which we should return measurements</param>/// <param name="StartTime">The earliest date (in epoch time) for which we should return measurements</param>
    /// <returns>List<Pairs></returns>
    public async Task<List<Pairs>> PairsGetAsync (string Cause, string CauseSource, string CauseUnit, string Delay, string Duration, string Effect, string EffectSource, string EffectUnit, string EndTime, string StartTime) {

      
          // verify the required parameter 'Cause' is set
          if (Cause == null) throw new ApiException(400, "Missing required parameter 'Cause' when calling PairsGet");
      
          // verify the required parameter 'Effect' is set
          if (Effect == null) throw new ApiException(400, "Missing required parameter 'Effect' when calling PairsGet");
      

      var path = "/pairs";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Cause != null) queryParams.Add("cause", apiClient.ParameterToString(Cause)); // query parameter
       if (CauseSource != null) queryParams.Add("causeSource", apiClient.ParameterToString(CauseSource)); // query parameter
       if (CauseUnit != null) queryParams.Add("causeUnit", apiClient.ParameterToString(CauseUnit)); // query parameter
       if (Delay != null) queryParams.Add("delay", apiClient.ParameterToString(Delay)); // query parameter
       if (Duration != null) queryParams.Add("duration", apiClient.ParameterToString(Duration)); // query parameter
       if (Effect != null) queryParams.Add("effect", apiClient.ParameterToString(Effect)); // query parameter
       if (EffectSource != null) queryParams.Add("effectSource", apiClient.ParameterToString(EffectSource)); // query parameter
       if (EffectUnit != null) queryParams.Add("effectUnit", apiClient.ParameterToString(EffectUnit)); // query parameter
       if (EndTime != null) queryParams.Add("endTime", apiClient.ParameterToString(EndTime)); // query parameter
       if (StartTime != null) queryParams.Add("startTime", apiClient.ParameterToString(StartTime)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PairsGet: " + response.Content, response.Content);
      }
      return (List<Pairs>) apiClient.Deserialize(response.Content, typeof(List<Pairs>));
    }
    
  }  
  
}
