using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class PairsApi {
    string basePath;
    protected RestClient restClient;

    public PairsApi(String basePath = "https://localhost/api")
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
    /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
    /// </summary>
    /// <param name="Cause">Original variable name for the explanatory or independent variable</param>
    /// <param name="CauseSource">Name of data source that the cause measurements should come from</param>
    /// <param name="CauseUnit">Abbreviated name for the unit cause measurements to be returned in</param>
    /// <param name="Delay">Delay before onset of action (in seconds) from the cause variable settings.</param>
    /// <param name="Duration">Duration of action (in seconds) from the cause variable settings.</param>
    /// <param name="Effect">Original variable name for the outcome or dependent variable</param>
    /// <param name="EffectSource">Name of data source that the effectmeasurements should come from</param>
    /// <param name="EffectUnit">Abbreviated name for the unit effect measurements to be returned in</param>
    /// <param name="EndTime">The most recent date (in epoch time) for which we should return measurements</param>
    /// <param name="StartTime">The earliest date (in epoch time) for which we should return measurements</param>
    /// <returns></returns>
    public void PairsGet (string Cause, string CauseSource, string CauseUnit, string Delay, string Duration, string Effect, string EffectSource, string EffectUnit, string EndTime, string StartTime) {

      var _request = new RestRequest("/pairs", Method.GET);

      
      // verify the required parameter 'Cause' is set
      if (Cause == null) throw new ApiException(400, "Missing required parameter 'Cause' when calling PairsGet");
      
      // verify the required parameter 'Effect' is set
      if (Effect == null) throw new ApiException(400, "Missing required parameter 'Effect' when calling PairsGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (Cause != null) _request.AddParameter("cause", ApiInvoker.ParameterToString(Cause)); // query parameter
       if (CauseSource != null) _request.AddParameter("causeSource", ApiInvoker.ParameterToString(CauseSource)); // query parameter
       if (CauseUnit != null) _request.AddParameter("causeUnit", ApiInvoker.ParameterToString(CauseUnit)); // query parameter
       if (Delay != null) _request.AddParameter("delay", ApiInvoker.ParameterToString(Delay)); // query parameter
       if (Duration != null) _request.AddParameter("duration", ApiInvoker.ParameterToString(Duration)); // query parameter
       if (Effect != null) _request.AddParameter("effect", ApiInvoker.ParameterToString(Effect)); // query parameter
       if (EffectSource != null) _request.AddParameter("effectSource", ApiInvoker.ParameterToString(EffectSource)); // query parameter
       if (EffectUnit != null) _request.AddParameter("effectUnit", ApiInvoker.ParameterToString(EffectUnit)); // query parameter
       if (EndTime != null) _request.AddParameter("endTime", ApiInvoker.ParameterToString(EndTime)); // query parameter
       if (StartTime != null) _request.AddParameter("startTime", ApiInvoker.ParameterToString(StartTime)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PairsGet: " + response.Content);
      }
      
      return;
    }
    
  }
  
}
