using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IMeasurementsApi
    {
        
        /// <summary>
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <returns>MeasurementSource</returns>
        MeasurementSource V1MeasurementSourcesGet ();
  
        /// <summary>
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <returns>MeasurementSource</returns>
        System.Threading.Tasks.Task<MeasurementSource> V1MeasurementSourcesGetAsync ();
        
        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <param name="name">An array of names of data sources you want to add.</param>
        /// <returns></returns>
        void V1MeasurementSourcesPost (MeasurementSource name);
  
        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <param name="name">An array of names of data sources you want to add.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1MeasurementSourcesPostAsync (MeasurementSource name);
        
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="unit">The unit your want the measurements in</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Measurement</returns>
        Measurement V1MeasurementsGet (string variableName, string unit, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort);
  
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="unit">The unit your want the measurements in</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Measurement</returns>
        System.Threading.Tasks.Task<Measurement> V1MeasurementsGetAsync (string variableName, string unit, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort);
        
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <param name="measurements">An array of measurements you want to insert.</param>
        /// <returns></returns>
        void V1MeasurementsPost (MeasurementSet measurements);
  
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <param name="measurements">An array of measurements you want to insert.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1MeasurementsPostAsync (MeasurementSet measurements);
        
        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Measurement</returns>
        Measurement V1MeasurementsDailyGet (string variableName, string abbreviatedUnitName, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort);
  
        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Measurement</returns>
        System.Threading.Tasks.Task<Measurement> V1MeasurementsDailyGetAsync (string variableName, string abbreviatedUnitName, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort);
        
        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <param name="sources">Enter source name to limit to specific source (varchar)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint)</param>
        /// <returns>MeasurementRange</returns>
        MeasurementRange V1MeasurementsRangeGet (string sources, int? user);
  
        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <param name="sources">Enter source name to limit to specific source (varchar)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint)</param>
        /// <returns>MeasurementRange</returns>
        System.Threading.Tasks.Task<MeasurementRange> V1MeasurementsRangeGetAsync (string sources, int? user);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MeasurementsApi : IMeasurementsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MeasurementsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeasurementsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <returns>MeasurementSource</returns>            
        public MeasurementSource V1MeasurementSourcesGet ()
        {
            
    
            var path = "/v1/measurementSources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MeasurementSource) ApiClient.Deserialize(response.Content, typeof(MeasurementSource), response.Headers);
        }
    
        /// <summary>
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <returns>MeasurementSource</returns>
        public async System.Threading.Tasks.Task<MeasurementSource> V1MeasurementSourcesGetAsync ()
        {
            
    
            var path = "/v1/measurementSources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesGet: " + response.Content, response.Content);

            return (MeasurementSource) ApiClient.Deserialize(response.Content, typeof(MeasurementSource), response.Headers);
        }
        
        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <param name="name">An array of names of data sources you want to add.</param> 
        /// <returns></returns>            
        public void V1MeasurementSourcesPost (MeasurementSource name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling V1MeasurementSourcesPost");
            
    
            var path = "/v1/measurementSources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(name); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <param name="name">An array of names of data sources you want to add.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1MeasurementSourcesPostAsync (MeasurementSource name)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling V1MeasurementSourcesPost");
            
    
            var path = "/v1/measurementSources";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(name); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesPost: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param> 
        /// <param name="unit">The unit your want the measurements in</param> 
        /// <param name="startTime">The lower limit of measurements returned (Epoch)</param> 
        /// <param name="endTime">The upper limit of measurements returned (Epoch)</param> 
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param> 
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param> 
        /// <returns>Measurement</returns>            
        public Measurement V1MeasurementsGet (string variableName, string unit, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (variableName != null) queryParams.Add("variableName", ApiClient.ParameterToString(variableName)); // query parameter
            if (unit != null) queryParams.Add("unit", ApiClient.ParameterToString(unit)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            if (groupingWidth != null) queryParams.Add("groupingWidth", ApiClient.ParameterToString(groupingWidth)); // query parameter
            if (groupingTimezone != null) queryParams.Add("groupingTimezone", ApiClient.ParameterToString(groupingTimezone)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Measurement) ApiClient.Deserialize(response.Content, typeof(Measurement), response.Headers);
        }
    
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="unit">The unit your want the measurements in</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch)</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Measurement</returns>
        public async System.Threading.Tasks.Task<Measurement> V1MeasurementsGetAsync (string variableName, string unit, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (variableName != null) queryParams.Add("variableName", ApiClient.ParameterToString(variableName)); // query parameter
            if (unit != null) queryParams.Add("unit", ApiClient.ParameterToString(unit)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            if (groupingWidth != null) queryParams.Add("groupingWidth", ApiClient.ParameterToString(groupingWidth)); // query parameter
            if (groupingTimezone != null) queryParams.Add("groupingTimezone", ApiClient.ParameterToString(groupingTimezone)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsGet: " + response.Content, response.Content);

            return (Measurement) ApiClient.Deserialize(response.Content, typeof(Measurement), response.Headers);
        }
        
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <param name="measurements">An array of measurements you want to insert.</param> 
        /// <returns></returns>            
        public void V1MeasurementsPost (MeasurementSet measurements)
        {
            
            // verify the required parameter 'measurements' is set
            if (measurements == null) throw new ApiException(400, "Missing required parameter 'measurements' when calling V1MeasurementsPost");
            
    
            var path = "/v1/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(measurements); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;timestamp\&quot;:1406419860,\&quot;value\&quot;:\&quot;1\&quot;,\&quot;note\&quot;:\&quot;I am a note about back pain.\&quot;},{\&quot;timestamp\&quot;:1406519865,\&quot;value\&quot;:\&quot;3\&quot;,\&quot;note\&quot;:\&quot;I am another note about back pain.\&quot;}],\&quot;name\&quot;:\&quot;Back Pain\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <param name="measurements">An array of measurements you want to insert.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1MeasurementsPostAsync (MeasurementSet measurements)
        {
            // verify the required parameter 'measurements' is set
            if (measurements == null) throw new ApiException(400, "Missing required parameter 'measurements' when calling V1MeasurementsPost");
            
    
            var path = "/v1/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(measurements); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsPost: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param> 
        /// <param name="abbreviatedUnitName">The unit your want the measurements in</param> 
        /// <param name="startTime">The lower limit of measurements returned (Iso8601)</param> 
        /// <param name="endTime">The upper limit of measurements returned (Iso8601)</param> 
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param> 
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param> 
        /// <returns>Measurement</returns>            
        public Measurement V1MeasurementsDailyGet (string variableName, string abbreviatedUnitName, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1MeasurementsDailyGet");
            
    
            var path = "/v1/measurements/daily";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (variableName != null) queryParams.Add("variableName", ApiClient.ParameterToString(variableName)); // query parameter
            if (abbreviatedUnitName != null) queryParams.Add("abbreviatedUnitName", ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            if (groupingWidth != null) queryParams.Add("groupingWidth", ApiClient.ParameterToString(groupingWidth)); // query parameter
            if (groupingTimezone != null) queryParams.Add("groupingTimezone", ApiClient.ParameterToString(groupingTimezone)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsDailyGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsDailyGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Measurement) ApiClient.Deserialize(response.Content, typeof(Measurement), response.Headers);
        }
    
        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Measurement</returns>
        public async System.Threading.Tasks.Task<Measurement> V1MeasurementsDailyGetAsync (string variableName, string abbreviatedUnitName, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1MeasurementsDailyGet");
            
    
            var path = "/v1/measurements/daily";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (variableName != null) queryParams.Add("variableName", ApiClient.ParameterToString(variableName)); // query parameter
            if (abbreviatedUnitName != null) queryParams.Add("abbreviatedUnitName", ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            if (groupingWidth != null) queryParams.Add("groupingWidth", ApiClient.ParameterToString(groupingWidth)); // query parameter
            if (groupingTimezone != null) queryParams.Add("groupingTimezone", ApiClient.ParameterToString(groupingTimezone)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsDailyGet: " + response.Content, response.Content);

            return (Measurement) ApiClient.Deserialize(response.Content, typeof(Measurement), response.Headers);
        }
        
        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <param name="sources">Enter source name to limit to specific source (varchar)</param> 
        /// <param name="user">If not specified, uses currently logged in user (bigint)</param> 
        /// <returns>MeasurementRange</returns>            
        public MeasurementRange V1MeasurementsRangeGet (string sources, int? user)
        {
            
    
            var path = "/v1/measurementsRange";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (sources != null) queryParams.Add("sources", ApiClient.ParameterToString(sources)); // query parameter
            if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsRangeGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsRangeGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MeasurementRange) ApiClient.Deserialize(response.Content, typeof(MeasurementRange), response.Headers);
        }
    
        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <param name="sources">Enter source name to limit to specific source (varchar)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint)</param>
        /// <returns>MeasurementRange</returns>
        public async System.Threading.Tasks.Task<MeasurementRange> V1MeasurementsRangeGetAsync (string sources, int? user)
        {
            
    
            var path = "/v1/measurementsRange";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (sources != null) queryParams.Add("sources", ApiClient.ParameterToString(sources)); // query parameter
            if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsRangeGet: " + response.Content, response.Content);

            return (MeasurementRange) ApiClient.Deserialize(response.Content, typeof(MeasurementRange), response.Headers);
        }
        
    }
    
}
