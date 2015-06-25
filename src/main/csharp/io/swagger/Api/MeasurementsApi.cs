using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IMeasurementsApi {
    
    /// <summary>
    /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
    /// </summary>
    
    /// <returns>MeasurementSource</returns>
    MeasurementSource MeasurementSourcesGet ();

    /// <summary>
    /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
    /// </summary>
    
    /// <returns>MeasurementSource</returns>
    Task<MeasurementSource> MeasurementSourcesGetAsync ();
    
    /// <summary>
    /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
    /// </summary>
    /// <param name="Name">An array of names of data sources you want to add.</param>
    /// <returns></returns>
    void MeasurementSourcesPost (MeasurementSource Name);

    /// <summary>
    /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
    /// </summary>
    /// <param name="Name">An array of names of data sources you want to add.</param>
    /// <returns></returns>
    Task MeasurementSourcesPostAsync (MeasurementSource Name);
    
    /// <summary>
    /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
    /// </summary>
    /// <param name="VariableName">Name of the variable you want measurements for</param>/// <param name="Unit">The unit your want the measurements in</param>/// <param name="StartTime">The lower limit of measurements returned (Epoch)</param>/// <param name="EndTime">The upper limit of measurements returned (Epoch)</param>/// <param name="GroupingWidth">The time (in seconds) over which measurements are grouped together</param>/// <param name="GroupingTimezone">The time (in seconds) over which measurements are grouped together</param>
    /// <returns>Measurement</returns>
    Measurement MeasurementsGet (string VariableName, string Unit, string StartTime, string EndTime, int? GroupingWidth, string GroupingTimezone);

    /// <summary>
    /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
    /// </summary>
    /// <param name="VariableName">Name of the variable you want measurements for</param>/// <param name="Unit">The unit your want the measurements in</param>/// <param name="StartTime">The lower limit of measurements returned (Epoch)</param>/// <param name="EndTime">The upper limit of measurements returned (Epoch)</param>/// <param name="GroupingWidth">The time (in seconds) over which measurements are grouped together</param>/// <param name="GroupingTimezone">The time (in seconds) over which measurements are grouped together</param>
    /// <returns>Measurement</returns>
    Task<Measurement> MeasurementsGetAsync (string VariableName, string Unit, string StartTime, string EndTime, int? GroupingWidth, string GroupingTimezone);
    
    /// <summary>
    /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
    /// </summary>
    /// <param name="Measurements">An array of measurements you want to insert.</param>
    /// <returns></returns>
    void MeasurementsV2Post (MeasurementSet Measurements);

    /// <summary>
    /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
    /// </summary>
    /// <param name="Measurements">An array of measurements you want to insert.</param>
    /// <returns></returns>
    Task MeasurementsV2PostAsync (MeasurementSet Measurements);
    
    /// <summary>
    /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
    /// </summary>
    /// <param name="Sources">Enter source name to limit to specific source (varchar)</param>/// <param name="User">If not specified, uses currently logged in user (bigint)</param>
    /// <returns>MeasurementRange</returns>
    MeasurementRange MeasurementsRangeGet (string Sources, int? User);

    /// <summary>
    /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
    /// </summary>
    /// <param name="Sources">Enter source name to limit to specific source (varchar)</param>/// <param name="User">If not specified, uses currently logged in user (bigint)</param>
    /// <returns>MeasurementRange</returns>
    Task<MeasurementRange> MeasurementsRangeGetAsync (string Sources, int? User);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class MeasurementsApi : IMeasurementsApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="MeasurementsApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public MeasurementsApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MeasurementsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public MeasurementsApi(String basePath)
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
    /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
    /// </summary>
    
    /// <returns>MeasurementSource</returns>
    public MeasurementSource MeasurementSourcesGet () {

      

      var path = "/measurementSources";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementSourcesGet: " + response.Content, response.Content);
      }
      return (MeasurementSource) apiClient.Deserialize(response.Content, typeof(MeasurementSource));
    }
	
	 /// <summary>
    /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
    /// </summary>
    
    /// <returns>MeasurementSource</returns>
    public async Task<MeasurementSource> MeasurementSourcesGetAsync () {

      

      var path = "/measurementSources";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementSourcesGet: " + response.Content, response.Content);
      }
      return (MeasurementSource) apiClient.Deserialize(response.Content, typeof(MeasurementSource));
    }
    
    /// <summary>
    /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
    /// </summary>
    /// <param name="Name">An array of names of data sources you want to add.</param>
    /// <returns></returns>
    public void MeasurementSourcesPost (MeasurementSource Name) {

      
      // verify the required parameter 'Name' is set
      if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling MeasurementSourcesPost");
      

      var path = "/measurementSources";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Name); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementSourcesPost: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
    /// </summary>
    /// <param name="Name">An array of names of data sources you want to add.</param>
    /// <returns></returns>
    public async Task MeasurementSourcesPostAsync (MeasurementSource Name) {

      
          // verify the required parameter 'Name' is set
          if (Name == null) throw new ApiException(400, "Missing required parameter 'Name' when calling MeasurementSourcesPost");
      

      var path = "/measurementSources";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Name); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementSourcesPost: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
    /// </summary>
    /// <param name="VariableName">Name of the variable you want measurements for</param>/// <param name="Unit">The unit your want the measurements in</param>/// <param name="StartTime">The lower limit of measurements returned (Epoch)</param>/// <param name="EndTime">The upper limit of measurements returned (Epoch)</param>/// <param name="GroupingWidth">The time (in seconds) over which measurements are grouped together</param>/// <param name="GroupingTimezone">The time (in seconds) over which measurements are grouped together</param>
    /// <returns>Measurement</returns>
    public Measurement MeasurementsGet (string VariableName, string Unit, string StartTime, string EndTime, int? GroupingWidth, string GroupingTimezone) {

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling MeasurementsGet");
      

      var path = "/measurements";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (VariableName != null) queryParams.Add("variableName", apiClient.ParameterToString(VariableName)); // query parameter
       if (Unit != null) queryParams.Add("unit", apiClient.ParameterToString(Unit)); // query parameter
       if (StartTime != null) queryParams.Add("startTime", apiClient.ParameterToString(StartTime)); // query parameter
       if (EndTime != null) queryParams.Add("endTime", apiClient.ParameterToString(EndTime)); // query parameter
       if (GroupingWidth != null) queryParams.Add("groupingWidth", apiClient.ParameterToString(GroupingWidth)); // query parameter
       if (GroupingTimezone != null) queryParams.Add("groupingTimezone", apiClient.ParameterToString(GroupingTimezone)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.Content, response.Content);
      }
      return (Measurement) apiClient.Deserialize(response.Content, typeof(Measurement));
    }
	
	 /// <summary>
    /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
    /// </summary>
    /// <param name="VariableName">Name of the variable you want measurements for</param>/// <param name="Unit">The unit your want the measurements in</param>/// <param name="StartTime">The lower limit of measurements returned (Epoch)</param>/// <param name="EndTime">The upper limit of measurements returned (Epoch)</param>/// <param name="GroupingWidth">The time (in seconds) over which measurements are grouped together</param>/// <param name="GroupingTimezone">The time (in seconds) over which measurements are grouped together</param>
    /// <returns>Measurement</returns>
    public async Task<Measurement> MeasurementsGetAsync (string VariableName, string Unit, string StartTime, string EndTime, int? GroupingWidth, string GroupingTimezone) {

      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling MeasurementsGet");
      

      var path = "/measurements";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (VariableName != null) queryParams.Add("variableName", apiClient.ParameterToString(VariableName)); // query parameter
       if (Unit != null) queryParams.Add("unit", apiClient.ParameterToString(Unit)); // query parameter
       if (StartTime != null) queryParams.Add("startTime", apiClient.ParameterToString(StartTime)); // query parameter
       if (EndTime != null) queryParams.Add("endTime", apiClient.ParameterToString(EndTime)); // query parameter
       if (GroupingWidth != null) queryParams.Add("groupingWidth", apiClient.ParameterToString(GroupingWidth)); // query parameter
       if (GroupingTimezone != null) queryParams.Add("groupingTimezone", apiClient.ParameterToString(GroupingTimezone)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.Content, response.Content);
      }
      return (Measurement) apiClient.Deserialize(response.Content, typeof(Measurement));
    }
    
    /// <summary>
    /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
    /// </summary>
    /// <param name="Measurements">An array of measurements you want to insert.</param>
    /// <returns></returns>
    public void MeasurementsV2Post (MeasurementSet Measurements) {

      
      // verify the required parameter 'Measurements' is set
      if (Measurements == null) throw new ApiException(400, "Missing required parameter 'Measurements' when calling MeasurementsV2Post");
      

      var path = "/measurements/v2";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Measurements); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsV2Post: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
    /// </summary>
    /// <param name="Measurements">An array of measurements you want to insert.</param>
    /// <returns></returns>
    public async Task MeasurementsV2PostAsync (MeasurementSet Measurements) {

      
          // verify the required parameter 'Measurements' is set
          if (Measurements == null) throw new ApiException(400, "Missing required parameter 'Measurements' when calling MeasurementsV2Post");
      

      var path = "/measurements/v2";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Measurements); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsV2Post: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
    /// </summary>
    /// <param name="Sources">Enter source name to limit to specific source (varchar)</param>/// <param name="User">If not specified, uses currently logged in user (bigint)</param>
    /// <returns>MeasurementRange</returns>
    public MeasurementRange MeasurementsRangeGet (string Sources, int? User) {

      

      var path = "/measurementsRange";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Sources != null) queryParams.Add("sources", apiClient.ParameterToString(Sources)); // query parameter
       if (User != null) queryParams.Add("user", apiClient.ParameterToString(User)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsRangeGet: " + response.Content, response.Content);
      }
      return (MeasurementRange) apiClient.Deserialize(response.Content, typeof(MeasurementRange));
    }
	
	 /// <summary>
    /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
    /// </summary>
    /// <param name="Sources">Enter source name to limit to specific source (varchar)</param>/// <param name="User">If not specified, uses currently logged in user (bigint)</param>
    /// <returns>MeasurementRange</returns>
    public async Task<MeasurementRange> MeasurementsRangeGetAsync (string Sources, int? User) {

      

      var path = "/measurementsRange";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Sources != null) queryParams.Add("sources", apiClient.ParameterToString(Sources)); // query parameter
       if (User != null) queryParams.Add("user", apiClient.ParameterToString(User)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsRangeGet: " + response.Content, response.Content);
      }
      return (MeasurementRange) apiClient.Deserialize(response.Content, typeof(MeasurementRange));
    }
    
  }  
  
}
