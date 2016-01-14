using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
        /// Get measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this measurement</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 MeasurementsGet (string accessToken = null, int? userId = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this measurement</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> MeasurementsGetWithHttpInfo (string accessToken = null, int? userId = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this measurement</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> MeasurementsGetAsync (string accessToken = null, int? userId = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get measurements for this user
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this measurement</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> MeasurementsGetAsyncWithHttpInfo (string accessToken = null, int? userId = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Post a new set or update existing measurements to the database
        /// </summary>
        /// <remarks>
        /// You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 MeasurementsPost (string accessToken = null, MeasurementPost body = null);
  
        /// <summary>
        /// Post a new set or update existing measurements to the database
        /// </summary>
        /// <remarks>
        /// You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> MeasurementsPostWithHttpInfo (string accessToken = null, MeasurementPost body = null);

        /// <summary>
        /// Post a new set or update existing measurements to the database
        /// </summary>
        /// <remarks>
        /// You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> MeasurementsPostAsync (string accessToken = null, MeasurementPost body = null);

        /// <summary>
        /// Post a new set or update existing measurements to the database
        /// </summary>
        /// <remarks>
        /// You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> MeasurementsPostAsyncWithHttpInfo (string accessToken = null, MeasurementPost body = null);
        
        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Download a CSV containing all user measurements
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Stream</returns>
        Stream MeasurementsCsvGet (string accessToken = null);
  
        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Download a CSV containing all user measurements
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of Stream</returns>
        ApiResponse<Stream> MeasurementsCsvGetWithHttpInfo (string accessToken = null);

        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Download a CSV containing all user measurements
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> MeasurementsCsvGetAsync (string accessToken = null);

        /// <summary>
        /// Get Measurements CSV
        /// </summary>
        /// <remarks>
        /// Download a CSV containing all user measurements
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> MeasurementsCsvGetAsyncWithHttpInfo (string accessToken = null);
        
        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>int?</returns>
        int? MeasurementsRequestCsvPost (string accessToken = null);
  
        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> MeasurementsRequestCsvPostWithHttpInfo (string accessToken = null);

        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> MeasurementsRequestCsvPostAsync (string accessToken = null);

        /// <summary>
        /// Post Request for Measurements CSV
        /// </summary>
        /// <remarks>
        /// Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> MeasurementsRequestCsvPostAsyncWithHttpInfo (string accessToken = null);
        
        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 MeasurementsIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20014</returns>
        ApiResponse<InlineResponse20014> MeasurementsIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20014</returns>
        System.Threading.Tasks.Task<InlineResponse20014> MeasurementsIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get Measurement
        /// </summary>
        /// <remarks>
        /// Get Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20014)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20014>> MeasurementsIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 MeasurementsIdPut (int? id, string accessToken = null, Measurement body = null);
  
        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> MeasurementsIdPutWithHttpInfo (int? id, string accessToken = null, Measurement body = null);

        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> MeasurementsIdPutAsync (int? id, string accessToken = null, Measurement body = null);

        /// <summary>
        /// Update Measurement
        /// </summary>
        /// <remarks>
        /// Update Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> MeasurementsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Measurement body = null);
        
        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 MeasurementsIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> MeasurementsIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> MeasurementsIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete Measurement
        /// </summary>
        /// <remarks>
        /// Delete Measurement
        /// </remarks>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> MeasurementsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MeasurementApi : IMeasurementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeasurementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MeasurementApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="userId">ID of user that owns this measurement</param> 
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param> 
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param> 
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param> 
        /// <param name="sourceId">Application or device used to record the measurement values</param> 
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param> 
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param> 
        /// <param name="unitId">The default unit id for the variable</param> 
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param> 
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param> 
        /// <param name="duration">Duration of the event being measurement in seconds</param> 
        /// <param name="note">An optional note the user may include with their measurement</param> 
        /// <param name="latitude">Latitude at which the measurement was taken</param> 
        /// <param name="longitude">Longitude at which the measurement was taken</param> 
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="error">An error message if there is a problem with the measurement</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 MeasurementsGet (string accessToken = null, int? userId = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20013> response = MeasurementsGetWithHttpInfo(accessToken, userId, clientId, connectorId, variableId, sourceId, startTime, value, unitId, originalValue, originalUnitId, duration, note, latitude, longitude, location, createdAt, updatedAt, error, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="userId">ID of user that owns this measurement</param> 
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param> 
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param> 
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param> 
        /// <param name="sourceId">Application or device used to record the measurement values</param> 
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param> 
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param> 
        /// <param name="unitId">The default unit id for the variable</param> 
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param> 
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param> 
        /// <param name="duration">Duration of the event being measurement in seconds</param> 
        /// <param name="note">An optional note the user may include with their measurement</param> 
        /// <param name="latitude">Latitude at which the measurement was taken</param> 
        /// <param name="longitude">Longitude at which the measurement was taken</param> 
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="error">An error message if there is a problem with the measurement</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public ApiResponse< InlineResponse20013 > MeasurementsGetWithHttpInfo (string accessToken = null, int? userId = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            if (startTime != null) queryParams.Add("start_time", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (value != null) queryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (unitId != null) queryParams.Add("unit_id", Configuration.ApiClient.ParameterToString(unitId)); // query parameter
            if (originalValue != null) queryParams.Add("original_value", Configuration.ApiClient.ParameterToString(originalValue)); // query parameter
            if (originalUnitId != null) queryParams.Add("original_unit_id", Configuration.ApiClient.ParameterToString(originalUnitId)); // query parameter
            if (duration != null) queryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (note != null) queryParams.Add("note", Configuration.ApiClient.ParameterToString(note)); // query parameter
            if (latitude != null) queryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (error != null) queryParams.Add("error", Configuration.ApiClient.ParameterToString(error)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
    
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this measurement</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> MeasurementsGetAsync (string accessToken = null, int? userId = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20013> response = await MeasurementsGetAsyncWithHttpInfo(accessToken, userId, clientId, connectorId, variableId, sourceId, startTime, value, unitId, originalValue, originalUnitId, duration, note, latitude, longitude, location, createdAt, updatedAt, error, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this measurement</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> MeasurementsGetAsyncWithHttpInfo (string accessToken = null, int? userId = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            if (startTime != null) queryParams.Add("start_time", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (value != null) queryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (unitId != null) queryParams.Add("unit_id", Configuration.ApiClient.ParameterToString(unitId)); // query parameter
            if (originalValue != null) queryParams.Add("original_value", Configuration.ApiClient.ParameterToString(originalValue)); // query parameter
            if (originalUnitId != null) queryParams.Add("original_unit_id", Configuration.ApiClient.ParameterToString(originalUnitId)); // query parameter
            if (duration != null) queryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (note != null) queryParams.Add("note", Configuration.ApiClient.ParameterToString(note)); // query parameter
            if (latitude != null) queryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (error != null) queryParams.Add("error", Configuration.ApiClient.ParameterToString(error)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
        
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Measurement that should be stored</param> 
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 MeasurementsPost (string accessToken = null, MeasurementPost body = null)
        {
             ApiResponse<InlineResponse20013> response = MeasurementsPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Measurement that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public ApiResponse< InlineResponse20013 > MeasurementsPostWithHttpInfo (string accessToken = null, MeasurementPost body = null)
        {
            
    
            var path_ = "/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
    
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> MeasurementsPostAsync (string accessToken = null, MeasurementPost body = null)
        {
             ApiResponse<InlineResponse20013> response = await MeasurementsPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> MeasurementsPostAsyncWithHttpInfo (string accessToken = null, MeasurementPost body = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
        
        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>Stream</returns>
        public Stream MeasurementsCsvGet (string accessToken = null)
        {
             ApiResponse<Stream> response = MeasurementsCsvGetWithHttpInfo(accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of Stream</returns>
        public ApiResponse< Stream > MeasurementsCsvGetWithHttpInfo (string accessToken = null)
        {
            
    
            var path_ = "/measurements/csv";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/csv"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsCsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
    
        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> MeasurementsCsvGetAsync (string accessToken = null)
        {
             ApiResponse<Stream> response = await MeasurementsCsvGetAsyncWithHttpInfo(accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> MeasurementsCsvGetAsyncWithHttpInfo (string accessToken = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsCsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsCsvGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
        
        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>int?</returns>
        public int? MeasurementsRequestCsvPost (string accessToken = null)
        {
             ApiResponse<int?> response = MeasurementsRequestCsvPostWithHttpInfo(accessToken);
             return response.Data;
        }

        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > MeasurementsRequestCsvPostWithHttpInfo (string accessToken = null)
        {
            
    
            var path_ = "/measurements/request_csv";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsRequestCsvPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsRequestCsvPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> MeasurementsRequestCsvPostAsync (string accessToken = null)
        {
             ApiResponse<int?> response = await MeasurementsRequestCsvPostAsyncWithHttpInfo(accessToken);
             return response.Data;

        }

        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> MeasurementsRequestCsvPostAsyncWithHttpInfo (string accessToken = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsRequestCsvPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsRequestCsvPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20014</returns>
        public InlineResponse20014 MeasurementsIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20014> response = MeasurementsIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20014</returns>
        public ApiResponse< InlineResponse20014 > MeasurementsIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdGet");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20014>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20014) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20014)));
            
        }
    
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20014</returns>
        public async System.Threading.Tasks.Task<InlineResponse20014> MeasurementsIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20014> response = await MeasurementsIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20014)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20014>> MeasurementsIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20014>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20014) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20014)));
            
        }
        
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Measurement that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 MeasurementsIdPut (int? id, string accessToken = null, Measurement body = null)
        {
             ApiResponse<InlineResponse2002> response = MeasurementsIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Measurement that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > MeasurementsIdPutWithHttpInfo (int? id, string accessToken = null, Measurement body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdPut");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> MeasurementsIdPutAsync (int? id, string accessToken = null, Measurement body = null)
        {
             ApiResponse<InlineResponse2002> response = await MeasurementsIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> MeasurementsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Measurement body = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 MeasurementsIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = MeasurementsIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > MeasurementsIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdDelete");
            
    
            var path_ = "/measurements/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> MeasurementsIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await MeasurementsIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> MeasurementsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MeasurementsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MeasurementsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
