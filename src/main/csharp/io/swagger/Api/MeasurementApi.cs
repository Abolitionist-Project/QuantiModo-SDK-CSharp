using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMeasurementApi
    {
        
        /// <summary>
        /// Get all Measurements
        /// </summary>
        /// <remarks>
        /// Get all Measurements
        /// </remarks>
        /// <param name="userId">user_id</param>
        /// <param name="clientId">client_id</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="variableId">variable_id</param>
        /// <param name="startTime">start_time</param>
        /// <param name="value">value</param>
        /// <param name="originalValue">original_value</param>
        /// <param name="duration">duration</param>
        /// <param name="note">note</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="error">error</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 MeasurementsGet (int? userId, string clientId, int? connectorId, int? variableId, int? startTime, double? value, double? originalValue, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort);
  
        /// <summary>
        /// Get all Measurements
        /// </summary>
        /// <remarks>
        /// Get all Measurements
        /// </remarks>
        /// <param name="userId">user_id</param>
        /// <param name="clientId">client_id</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="variableId">variable_id</param>
        /// <param name="startTime">start_time</param>
        /// <param name="value">value</param>
        /// <param name="originalValue">original_value</param>
        /// <param name="duration">duration</param>
        /// <param name="note">note</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="error">error</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20011</returns>
        System.Threading.Tasks.Task<InlineResponse20011> MeasurementsGetAsync (int? userId, string clientId, int? connectorId, int? variableId, int? startTime, double? value, double? originalValue, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Measurement
        /// </summary>
        /// <remarks>
        /// Store Measurement
        /// </remarks>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 MeasurementsPost (MeasurementPost body);
  
        /// <summary>
        /// Store Measurement
        /// </summary>
        /// <remarks>
        /// Store Measurement
        /// </remarks>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>InlineResponse20011</returns>
        System.Threading.Tasks.Task<InlineResponse20011> MeasurementsPostAsync (MeasurementPost body);
        
        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Get Measurements CSV
        /// </remarks>
        /// <returns>Stream</returns>
        Stream MeasurementsCsvGet ();
  
        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Get Measurements CSV
        /// </remarks>
        /// <returns>Stream</returns>
        System.Threading.Tasks.Task<Stream> MeasurementsCsvGetAsync ();
        
        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Post Request for Measurements CSV
        /// </remarks>
        /// <returns>int?</returns>
        int? MeasurementsRequestCsvPost ();
  
        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Post Request for Measurements CSV
        /// </remarks>
        /// <returns>int?</returns>
        System.Threading.Tasks.Task<int?> MeasurementsRequestCsvPostAsync ();
        
        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 MeasurementsIdGet (int? id);
  
        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <returns>InlineResponse20012</returns>
        System.Threading.Tasks.Task<InlineResponse20012> MeasurementsIdGetAsync (int? id);
        
        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 MeasurementsIdPut (int? id, Measurement body);
  
        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> MeasurementsIdPutAsync (int? id, Measurement body);
        
        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 MeasurementsIdDelete (int? id);
  
        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> MeasurementsIdDeleteAsync (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MeasurementApi : IMeasurementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MeasurementApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeasurementApi(String basePath)
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
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get all Measurements Get all Measurements
        /// </summary>
        /// <param name="userId">user_id</param> 
        /// <param name="clientId">client_id</param> 
        /// <param name="connectorId">connector_id</param> 
        /// <param name="variableId">variable_id</param> 
        /// <param name="startTime">start_time</param> 
        /// <param name="value">value</param> 
        /// <param name="originalValue">original_value</param> 
        /// <param name="duration">duration</param> 
        /// <param name="note">note</param> 
        /// <param name="latitude">latitude</param> 
        /// <param name="longitude">longitude</param> 
        /// <param name="location">location</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="error">error</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 MeasurementsGet (int? userId, string clientId, int? connectorId, int? variableId, int? startTime, double? value, double? originalValue, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
            if (startTime != null) queryParams.Add("start_time", ApiClient.ParameterToString(startTime)); // query parameter
            if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
            if (originalValue != null) queryParams.Add("original_value", ApiClient.ParameterToString(originalValue)); // query parameter
            if (duration != null) queryParams.Add("duration", ApiClient.ParameterToString(duration)); // query parameter
            if (note != null) queryParams.Add("note", ApiClient.ParameterToString(note)); // query parameter
            if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (error != null) queryParams.Add("error", ApiClient.ParameterToString(error)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response, typeof(InlineResponse20011));
        }
    
        /// <summary>
        /// Get all Measurements Get all Measurements
        /// </summary>
        /// <param name="userId">user_id</param>
        /// <param name="clientId">client_id</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="variableId">variable_id</param>
        /// <param name="startTime">start_time</param>
        /// <param name="value">value</param>
        /// <param name="originalValue">original_value</param>
        /// <param name="duration">duration</param>
        /// <param name="note">note</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="error">error</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20011</returns>
        public async System.Threading.Tasks.Task<InlineResponse20011> MeasurementsGetAsync (int? userId, string clientId, int? connectorId, int? variableId, int? startTime, double? value, double? originalValue, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
            if (startTime != null) queryParams.Add("start_time", ApiClient.ParameterToString(startTime)); // query parameter
            if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
            if (originalValue != null) queryParams.Add("original_value", ApiClient.ParameterToString(originalValue)); // query parameter
            if (duration != null) queryParams.Add("duration", ApiClient.ParameterToString(duration)); // query parameter
            if (note != null) queryParams.Add("note", ApiClient.ParameterToString(note)); // query parameter
            if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (error != null) queryParams.Add("error", ApiClient.ParameterToString(error)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.Content, response.Content);

            return (InlineResponse20011) ApiClient.Deserialize(response, typeof(InlineResponse20011));
        }
        
        /// <summary>
        /// Store Measurement Store Measurement
        /// </summary>
        /// <param name="body">Measurement that should be stored</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 MeasurementsPost (MeasurementPost body)
        {
            
    
            var path_ = "/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response, typeof(InlineResponse20011));
        }
    
        /// <summary>
        /// Store Measurement Store Measurement
        /// </summary>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>InlineResponse20011</returns>
        public async System.Threading.Tasks.Task<InlineResponse20011> MeasurementsPostAsync (MeasurementPost body)
        {
            
    
            var path_ = "/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsPost: " + response.Content, response.Content);

            return (InlineResponse20011) ApiClient.Deserialize(response, typeof(InlineResponse20011));
        }
        
        /// <summary>
        /// Get Measurements CSV Get Measurements CSV
        /// </summary>
        /// <returns>Stream</returns>            
        public Stream MeasurementsCsvGet ()
        {
            
    
            var path_ = "/measurements/csv";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/csv"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsCsvGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Stream) ApiClient.Deserialize(response, typeof(Stream));
        }
    
        /// <summary>
        /// Get Measurements CSV Get Measurements CSV
        /// </summary>
        /// <returns>Stream</returns>
        public async System.Threading.Tasks.Task<Stream> MeasurementsCsvGetAsync ()
        {
            
    
            var path_ = "/measurements/csv";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/csv"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsCsvGet: " + response.Content, response.Content);

            return (Stream) ApiClient.Deserialize(response, typeof(Stream));
        }
        
        /// <summary>
        /// Post Request for Measurements CSV Post Request for Measurements CSV
        /// </summary>
        /// <returns>int?</returns>            
        public int? MeasurementsRequestCsvPost ()
        {
            
    
            var path_ = "/measurements/request_csv";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsRequestCsvPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsRequestCsvPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response, typeof(int?));
        }
    
        /// <summary>
        /// Post Request for Measurements CSV Post Request for Measurements CSV
        /// </summary>
        /// <returns>int?</returns>
        public async System.Threading.Tasks.Task<int?> MeasurementsRequestCsvPostAsync ()
        {
            
    
            var path_ = "/measurements/request_csv";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsRequestCsvPost: " + response.Content, response.Content);

            return (int?) ApiClient.Deserialize(response, typeof(int?));
        }
        
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 MeasurementsIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdGet");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response, typeof(InlineResponse20012));
        }
    
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <returns>InlineResponse20012</returns>
        public async System.Threading.Tasks.Task<InlineResponse20012> MeasurementsIdGetAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdGet");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdGet: " + response.Content, response.Content);

            return (InlineResponse20012) ApiClient.Deserialize(response, typeof(InlineResponse20012));
        }
        
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="body">Measurement that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 MeasurementsIdPut (int? id, Measurement body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdPut");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> MeasurementsIdPutAsync (int? id, Measurement body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdPut");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdPut: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 MeasurementsIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdDelete");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> MeasurementsIdDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdDelete");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdDelete: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
    }
    
}
