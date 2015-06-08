using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class MeasurementsApi {
    string basePath;
    protected RestClient restClient;

    public MeasurementsApi(String basePath = "https://localhost/api")
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
    /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
    /// </summary>
    /// <returns></returns>
    public void MeasurementSourcesGet () {

      var _request = new RestRequest("/measurementSources", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementSourcesGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
    /// </summary>
    /// <param name="Name">An array of names of data sources you want to add.</param>
    /// <returns></returns>
    public void MeasurementSourcesPost (List<MeasurementSource> Name) {

      var _request = new RestRequest("/measurementSources", Method.POST);

      
      // verify the required parameter 'Name' is set
      if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling MeasurementSourcesPost");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      _request.AddParameter("application/json", ApiInvoker.Serialize(Name), ParameterType.RequestBody); // http body (model) parameter
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementSourcesPost: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
    /// </summary>
    /// <param name="VariableName">Name of the variable you want measurements for</param>
    /// <param name="Unit">The unit your want the measurements in</param>
    /// <param name="StartTime">The lower limit of measurements returned (Epoch)</param>
    /// <param name="EndTime">The upper limit of measurements returned (Epoch)</param>
    /// <param name="GroupingWidth">The time (in seconds) over which measurements are grouped together</param>
    /// <param name="GroupingTimezone">The time (in seconds) over which measurements are grouped together</param>
    /// <returns></returns>
    public void MeasurementsGet (string VariableName, string Unit, string StartTime, string EndTime, int? GroupingWidth, string GroupingTimezone) {

      var _request = new RestRequest("/measurements", Method.GET);

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling MeasurementsGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (VariableName != null) _request.AddParameter("variableName", ApiInvoker.ParameterToString(VariableName)); // query parameter
       if (Unit != null) _request.AddParameter("unit", ApiInvoker.ParameterToString(Unit)); // query parameter
       if (StartTime != null) _request.AddParameter("startTime", ApiInvoker.ParameterToString(StartTime)); // query parameter
       if (EndTime != null) _request.AddParameter("endTime", ApiInvoker.ParameterToString(EndTime)); // query parameter
       if (GroupingWidth != null) _request.AddParameter("groupingWidth", ApiInvoker.ParameterToString(GroupingWidth)); // query parameter
       if (GroupingTimezone != null) _request.AddParameter("groupingTimezone", ApiInvoker.ParameterToString(GroupingTimezone)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Post a new set of measurements to the database You can submit multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
    /// </summary>
    /// <param name="Measurements">An array of measurements you want to insert.</param>
    /// <returns></returns>
    public void MeasurementsV2Post (List<Measurement> Measurements) {

      var _request = new RestRequest("/measurements/v2", Method.POST);

      
      // verify the required parameter 'Measurements' is set
      if (Measurements == null) throw new ApiException(400, "Missing required parameter 'Measurements' when calling MeasurementsV2Post");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      _request.AddParameter("application/json", ApiInvoker.Serialize(Measurements), ParameterType.RequestBody); // http body (model) parameter
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsV2Post: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
    /// </summary>
    /// <param name="Sources">Enter source name to limit to specific source (varchar)</param>
    /// <param name="User">If not specified, uses currently logged in user (bigint)</param>
    /// <returns></returns>
    public void MeasurementsRangeGet (string Sources, int? User) {

      var _request = new RestRequest("/measurementsRange", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (Sources != null) _request.AddParameter("sources", ApiInvoker.ParameterToString(Sources)); // query parameter
       if (User != null) _request.AddParameter("user", ApiInvoker.ParameterToString(User)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsRangeGet: " + response.Content);
      }
      
      return;
    }
    
  }
  
}
