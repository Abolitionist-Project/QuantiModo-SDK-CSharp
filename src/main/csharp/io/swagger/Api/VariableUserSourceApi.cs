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
    public interface IVariableUserSourceApi
    {
        
        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="userId">ID of User</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 VariableUserSourcesGet (string accessToken = null, int? variableId = null, int? userId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="userId">ID of User</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20029</returns>
        ApiResponse<InlineResponse20029> VariableUserSourcesGetWithHttpInfo (string accessToken = null, int? variableId = null, int? userId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="userId">ID of User</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20029</returns>
        System.Threading.Tasks.Task<InlineResponse20029> VariableUserSourcesGetAsync (string accessToken = null, int? variableId = null, int? userId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="userId">ID of User</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20029)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20029>> VariableUserSourcesGetAsyncWithHttpInfo (string accessToken = null, int? variableId = null, int? userId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store VariableUserSource
        /// </summary>
        /// <remarks>
        /// Store VariableUserSource
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 VariableUserSourcesPost (string accessToken = null, VariableUserSource body = null);
  
        /// <summary>
        /// Store VariableUserSource
        /// </summary>
        /// <remarks>
        /// Store VariableUserSource
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20030</returns>
        ApiResponse<InlineResponse20030> VariableUserSourcesPostWithHttpInfo (string accessToken = null, VariableUserSource body = null);

        /// <summary>
        /// Store VariableUserSource
        /// </summary>
        /// <remarks>
        /// Store VariableUserSource
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>Task of InlineResponse20030</returns>
        System.Threading.Tasks.Task<InlineResponse20030> VariableUserSourcesPostAsync (string accessToken = null, VariableUserSource body = null);

        /// <summary>
        /// Store VariableUserSource
        /// </summary>
        /// <remarks>
        /// Store VariableUserSource
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20030)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20030>> VariableUserSourcesPostAsyncWithHttpInfo (string accessToken = null, VariableUserSource body = null);
        
        /// <summary>
        /// Get VariableUserSource
        /// </summary>
        /// <remarks>
        /// Get VariableUserSource
        /// </remarks>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 VariableUserSourcesIdGet (int? id, int? sourceId, string accessToken = null);
  
        /// <summary>
        /// Get VariableUserSource
        /// </summary>
        /// <remarks>
        /// Get VariableUserSource
        /// </remarks>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20030</returns>
        ApiResponse<InlineResponse20030> VariableUserSourcesIdGetWithHttpInfo (int? id, int? sourceId, string accessToken = null);

        /// <summary>
        /// Get VariableUserSource
        /// </summary>
        /// <remarks>
        /// Get VariableUserSource
        /// </remarks>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20030</returns>
        System.Threading.Tasks.Task<InlineResponse20030> VariableUserSourcesIdGetAsync (int? id, int? sourceId, string accessToken = null);

        /// <summary>
        /// Get VariableUserSource
        /// </summary>
        /// <remarks>
        /// Get VariableUserSource
        /// </remarks>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20030)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20030>> VariableUserSourcesIdGetAsyncWithHttpInfo (int? id, int? sourceId, string accessToken = null);
        
        /// <summary>
        /// Update VariableUserSource
        /// </summary>
        /// <remarks>
        /// Update VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableUserSourcesIdPut (int? id, int? sourceId, string accessToken = null, VariableUserSource body = null);
  
        /// <summary>
        /// Update VariableUserSource
        /// </summary>
        /// <remarks>
        /// Update VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> VariableUserSourcesIdPutWithHttpInfo (int? id, int? sourceId, string accessToken = null, VariableUserSource body = null);

        /// <summary>
        /// Update VariableUserSource
        /// </summary>
        /// <remarks>
        /// Update VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariableUserSourcesIdPutAsync (int? id, int? sourceId, string accessToken = null, VariableUserSource body = null);

        /// <summary>
        /// Update VariableUserSource
        /// </summary>
        /// <remarks>
        /// Update VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariableUserSourcesIdPutAsyncWithHttpInfo (int? id, int? sourceId, string accessToken = null, VariableUserSource body = null);
        
        /// <summary>
        /// Delete VariableUserSource
        /// </summary>
        /// <remarks>
        /// Delete VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableUserSourcesIdDelete (int? id, int? sourceId, string accessToken = null);
  
        /// <summary>
        /// Delete VariableUserSource
        /// </summary>
        /// <remarks>
        /// Delete VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> VariableUserSourcesIdDeleteWithHttpInfo (int? id, int? sourceId, string accessToken = null);

        /// <summary>
        /// Delete VariableUserSource
        /// </summary>
        /// <remarks>
        /// Delete VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariableUserSourcesIdDeleteAsync (int? id, int? sourceId, string accessToken = null);

        /// <summary>
        /// Delete VariableUserSource
        /// </summary>
        /// <remarks>
        /// Delete VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariableUserSourcesIdDeleteAsyncWithHttpInfo (int? id, int? sourceId, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariableUserSourceApi : IVariableUserSourceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableUserSourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariableUserSourceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableUserSourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VariableUserSourceApi(Configuration configuration = null)
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
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="variableId">ID of variable</param> 
        /// <param name="userId">ID of User</param> 
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param> 
        /// <param name="earliestMeasurementTime">Earliest measurement time</param> 
        /// <param name="latestMeasurementTime">Latest measurement time</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20029</returns>
        public InlineResponse20029 VariableUserSourcesGet (string accessToken = null, int? variableId = null, int? userId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20029> response = VariableUserSourcesGetWithHttpInfo(accessToken, variableId, userId, timestamp, earliestMeasurementTime, latestMeasurementTime, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="variableId">ID of variable</param> 
        /// <param name="userId">ID of User</param> 
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param> 
        /// <param name="earliestMeasurementTime">Earliest measurement time</param> 
        /// <param name="latestMeasurementTime">Latest measurement time</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20029</returns>
        public ApiResponse< InlineResponse20029 > VariableUserSourcesGetWithHttpInfo (string accessToken = null, int? variableId = null, int? userId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/variableUserSources";
    
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
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (timestamp != null) queryParams.Add("timestamp", Configuration.ApiClient.ParameterToString(timestamp)); // query parameter
            if (earliestMeasurementTime != null) queryParams.Add("earliest_measurement_time", Configuration.ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) queryParams.Add("latest_measurement_time", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20029>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20029) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20029)));
            
        }
    
        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="userId">ID of User</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20029</returns>
        public async System.Threading.Tasks.Task<InlineResponse20029> VariableUserSourcesGetAsync (string accessToken = null, int? variableId = null, int? userId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20029> response = await VariableUserSourcesGetAsyncWithHttpInfo(accessToken, variableId, userId, timestamp, earliestMeasurementTime, latestMeasurementTime, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="userId">ID of User</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20029)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20029>> VariableUserSourcesGetAsyncWithHttpInfo (string accessToken = null, int? variableId = null, int? userId = null, int? timestamp = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/variableUserSources";
    
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
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (timestamp != null) queryParams.Add("timestamp", Configuration.ApiClient.ParameterToString(timestamp)); // query parameter
            if (earliestMeasurementTime != null) queryParams.Add("earliest_measurement_time", Configuration.ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) queryParams.Add("latest_measurement_time", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20029>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20029) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20029)));
            
        }
        
        /// <summary>
        /// Store VariableUserSource Store VariableUserSource
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableUserSource that should be stored</param> 
        /// <returns>InlineResponse20030</returns>
        public InlineResponse20030 VariableUserSourcesPost (string accessToken = null, VariableUserSource body = null)
        {
             ApiResponse<InlineResponse20030> response = VariableUserSourcesPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store VariableUserSource Store VariableUserSource
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableUserSource that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20030</returns>
        public ApiResponse< InlineResponse20030 > VariableUserSourcesPostWithHttpInfo (string accessToken = null, VariableUserSource body = null)
        {
            
    
            var path_ = "/variableUserSources";
    
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20030>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20030) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20030)));
            
        }
    
        /// <summary>
        /// Store VariableUserSource Store VariableUserSource
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>Task of InlineResponse20030</returns>
        public async System.Threading.Tasks.Task<InlineResponse20030> VariableUserSourcesPostAsync (string accessToken = null, VariableUserSource body = null)
        {
             ApiResponse<InlineResponse20030> response = await VariableUserSourcesPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store VariableUserSource Store VariableUserSource
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20030)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20030>> VariableUserSourcesPostAsyncWithHttpInfo (string accessToken = null, VariableUserSource body = null)
        {
            
    
            var path_ = "/variableUserSources";
    
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20030>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20030) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20030)));
            
        }
        
        /// <summary>
        /// Get VariableUserSource Get VariableUserSource
        /// </summary>
        /// <param name="id">id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20030</returns>
        public InlineResponse20030 VariableUserSourcesIdGet (int? id, int? sourceId, string accessToken = null)
        {
             ApiResponse<InlineResponse20030> response = VariableUserSourcesIdGetWithHttpInfo(id, sourceId, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get VariableUserSource Get VariableUserSource
        /// </summary>
        /// <param name="id">id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20030</returns>
        public ApiResponse< InlineResponse20030 > VariableUserSourcesIdGetWithHttpInfo (int? id, int? sourceId, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableUserSourcesIdGet");
            
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling VariableUserSourcesIdGet");
            
    
            var path_ = "/variableUserSources/{id}";
    
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
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20030>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20030) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20030)));
            
        }
    
        /// <summary>
        /// Get VariableUserSource Get VariableUserSource
        /// </summary>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20030</returns>
        public async System.Threading.Tasks.Task<InlineResponse20030> VariableUserSourcesIdGetAsync (int? id, int? sourceId, string accessToken = null)
        {
             ApiResponse<InlineResponse20030> response = await VariableUserSourcesIdGetAsyncWithHttpInfo(id, sourceId, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get VariableUserSource Get VariableUserSource
        /// </summary>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20030)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20030>> VariableUserSourcesIdGetAsyncWithHttpInfo (int? id, int? sourceId, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableUserSourcesIdGet");
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling VariableUserSourcesIdGet");
            
    
            var path_ = "/variableUserSources/{id}";
    
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
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20030>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20030) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20030)));
            
        }
        
        /// <summary>
        /// Update VariableUserSource Update VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableUserSource that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 VariableUserSourcesIdPut (int? id, int? sourceId, string accessToken = null, VariableUserSource body = null)
        {
             ApiResponse<InlineResponse2002> response = VariableUserSourcesIdPutWithHttpInfo(id, sourceId, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update VariableUserSource Update VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableUserSource that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > VariableUserSourcesIdPutWithHttpInfo (int? id, int? sourceId, string accessToken = null, VariableUserSource body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableUserSourcesIdPut");
            
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling VariableUserSourcesIdPut");
            
    
            var path_ = "/variableUserSources/{id}";
    
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
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update VariableUserSource Update VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariableUserSourcesIdPutAsync (int? id, int? sourceId, string accessToken = null, VariableUserSource body = null)
        {
             ApiResponse<InlineResponse2002> response = await VariableUserSourcesIdPutAsyncWithHttpInfo(id, sourceId, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update VariableUserSource Update VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariableUserSourcesIdPutAsyncWithHttpInfo (int? id, int? sourceId, string accessToken = null, VariableUserSource body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableUserSourcesIdPut");
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling VariableUserSourcesIdPut");
            
    
            var path_ = "/variableUserSources/{id}";
    
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
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete VariableUserSource Delete VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 VariableUserSourcesIdDelete (int? id, int? sourceId, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = VariableUserSourcesIdDeleteWithHttpInfo(id, sourceId, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete VariableUserSource Delete VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > VariableUserSourcesIdDeleteWithHttpInfo (int? id, int? sourceId, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableUserSourcesIdDelete");
            
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling VariableUserSourcesIdDelete");
            
    
            var path_ = "/variableUserSources/{id}";
    
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
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete VariableUserSource Delete VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariableUserSourcesIdDeleteAsync (int? id, int? sourceId, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await VariableUserSourcesIdDeleteAsyncWithHttpInfo(id, sourceId, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete VariableUserSource Delete VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariableUserSourcesIdDeleteAsyncWithHttpInfo (int? id, int? sourceId, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableUserSourcesIdDelete");
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling VariableUserSourcesIdDelete");
            
    
            var path_ = "/variableUserSources/{id}";
    
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
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableUserSourcesIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
