using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectionApi
    {
        
        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 ConnectionsGet (string accessToken = null, int? userId = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> ConnectionsGetWithHttpInfo (string accessToken = null, int? userId = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> ConnectionsGetAsync (string accessToken = null, int? userId = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> ConnectionsGetAsyncWithHttpInfo (string accessToken = null, int? userId = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store Connection
        /// </summary>
        /// <remarks>
        /// Store Connection
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 ConnectionsPost (string accessToken = null, Connection body = null);
  
        /// <summary>
        /// Store Connection
        /// </summary>
        /// <remarks>
        /// Store Connection
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20014</returns>
        ApiResponse<InlineResponse20014> ConnectionsPostWithHttpInfo (string accessToken = null, Connection body = null);

        /// <summary>
        /// Store Connection
        /// </summary>
        /// <remarks>
        /// Store Connection
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>Task of InlineResponse20014</returns>
        System.Threading.Tasks.Task<InlineResponse20014> ConnectionsPostAsync (string accessToken = null, Connection body = null);

        /// <summary>
        /// Store Connection
        /// </summary>
        /// <remarks>
        /// Store Connection
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20014)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20014>> ConnectionsPostAsyncWithHttpInfo (string accessToken = null, Connection body = null);
        
        /// <summary>
        /// Get Connection
        /// </summary>
        /// <remarks>
        /// Get Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 ConnectionsIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get Connection
        /// </summary>
        /// <remarks>
        /// Get Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20014</returns>
        ApiResponse<InlineResponse20014> ConnectionsIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get Connection
        /// </summary>
        /// <remarks>
        /// Get Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20014</returns>
        System.Threading.Tasks.Task<InlineResponse20014> ConnectionsIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get Connection
        /// </summary>
        /// <remarks>
        /// Get Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20014)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20014>> ConnectionsIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update Connection
        /// </summary>
        /// <remarks>
        /// Update Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 ConnectionsIdPut (int? id, string accessToken = null, Connection body = null);
  
        /// <summary>
        /// Update Connection
        /// </summary>
        /// <remarks>
        /// Update Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> ConnectionsIdPutWithHttpInfo (int? id, string accessToken = null, Connection body = null);

        /// <summary>
        /// Update Connection
        /// </summary>
        /// <remarks>
        /// Update Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> ConnectionsIdPutAsync (int? id, string accessToken = null, Connection body = null);

        /// <summary>
        /// Update Connection
        /// </summary>
        /// <remarks>
        /// Update Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> ConnectionsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Connection body = null);
        
        /// <summary>
        /// Delete Connection
        /// </summary>
        /// <remarks>
        /// Delete Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 ConnectionsIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete Connection
        /// </summary>
        /// <remarks>
        /// Delete Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> ConnectionsIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete Connection
        /// </summary>
        /// <remarks>
        /// Delete Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> ConnectionsIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete Connection
        /// </summary>
        /// <remarks>
        /// Delete Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> ConnectionsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectionApi : IConnectionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConnectionApi(Configuration configuration = null)
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
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="userId">ID of user that owns this correlation</param> 
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param> 
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param> 
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param> 
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param> 
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param> 
        /// <param name="updateError">Indicates if there was an error during the update.</param> 
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 ConnectionsGet (string accessToken = null, int? userId = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2003> response = ConnectionsGetWithHttpInfo(accessToken, userId, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="userId">ID of user that owns this correlation</param> 
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param> 
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param> 
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param> 
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param> 
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param> 
        /// <param name="updateError">Indicates if there was an error during the update.</param> 
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > ConnectionsGetWithHttpInfo (string accessToken = null, int? userId = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/connections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (connectStatus != null) queryParams.Add("connect_status", Configuration.ApiClient.ParameterToString(connectStatus)); // query parameter
            if (connectError != null) queryParams.Add("connect_error", Configuration.ApiClient.ParameterToString(connectError)); // query parameter
            if (updateRequestedAt != null) queryParams.Add("update_requested_at", Configuration.ApiClient.ParameterToString(updateRequestedAt)); // query parameter
            if (updateStatus != null) queryParams.Add("update_status", Configuration.ApiClient.ParameterToString(updateStatus)); // query parameter
            if (updateError != null) queryParams.Add("update_error", Configuration.ApiClient.ParameterToString(updateError)); // query parameter
            if (lastSuccessfulUpdatedAt != null) queryParams.Add("last_successful_updated_at", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2003>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2003)));
            
        }
    
        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> ConnectionsGetAsync (string accessToken = null, int? userId = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2003> response = await ConnectionsGetAsyncWithHttpInfo(accessToken, userId, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> ConnectionsGetAsyncWithHttpInfo (string accessToken = null, int? userId = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/connections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (connectStatus != null) queryParams.Add("connect_status", Configuration.ApiClient.ParameterToString(connectStatus)); // query parameter
            if (connectError != null) queryParams.Add("connect_error", Configuration.ApiClient.ParameterToString(connectError)); // query parameter
            if (updateRequestedAt != null) queryParams.Add("update_requested_at", Configuration.ApiClient.ParameterToString(updateRequestedAt)); // query parameter
            if (updateStatus != null) queryParams.Add("update_status", Configuration.ApiClient.ParameterToString(updateStatus)); // query parameter
            if (updateError != null) queryParams.Add("update_error", Configuration.ApiClient.ParameterToString(updateError)); // query parameter
            if (lastSuccessfulUpdatedAt != null) queryParams.Add("last_successful_updated_at", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2003>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2003)));
            
        }
        
        /// <summary>
        /// Store Connection Store Connection
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Connection that should be stored</param> 
        /// <returns>InlineResponse20014</returns>
        public InlineResponse20014 ConnectionsPost (string accessToken = null, Connection body = null)
        {
             ApiResponse<InlineResponse20014> response = ConnectionsPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store Connection Store Connection
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Connection that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20014</returns>
        public ApiResponse< InlineResponse20014 > ConnectionsPostWithHttpInfo (string accessToken = null, Connection body = null)
        {
            
    
            var path_ = "/connections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20014>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20014) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20014)));
            
        }
    
        /// <summary>
        /// Store Connection Store Connection
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>Task of InlineResponse20014</returns>
        public async System.Threading.Tasks.Task<InlineResponse20014> ConnectionsPostAsync (string accessToken = null, Connection body = null)
        {
             ApiResponse<InlineResponse20014> response = await ConnectionsPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store Connection Store Connection
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20014)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20014>> ConnectionsPostAsyncWithHttpInfo (string accessToken = null, Connection body = null)
        {
            
    
            var path_ = "/connections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20014>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20014) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20014)));
            
        }
        
        /// <summary>
        /// Get Connection Get Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20014</returns>
        public InlineResponse20014 ConnectionsIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20014> response = ConnectionsIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get Connection Get Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20014</returns>
        public ApiResponse< InlineResponse20014 > ConnectionsIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionApi->ConnectionsIdGet");
            
    
            var path_ = "/connections/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20014>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20014) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20014)));
            
        }
    
        /// <summary>
        /// Get Connection Get Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20014</returns>
        public async System.Threading.Tasks.Task<InlineResponse20014> ConnectionsIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20014> response = await ConnectionsIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get Connection Get Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20014)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20014>> ConnectionsIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdGet");
            
    
            var path_ = "/connections/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20014>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20014) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20014)));
            
        }
        
        /// <summary>
        /// Update Connection Update Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Connection that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 ConnectionsIdPut (int? id, string accessToken = null, Connection body = null)
        {
             ApiResponse<InlineResponse2002> response = ConnectionsIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update Connection Update Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Connection that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > ConnectionsIdPutWithHttpInfo (int? id, string accessToken = null, Connection body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionApi->ConnectionsIdPut");
            
    
            var path_ = "/connections/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update Connection Update Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> ConnectionsIdPutAsync (int? id, string accessToken = null, Connection body = null)
        {
             ApiResponse<InlineResponse2002> response = await ConnectionsIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update Connection Update Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> ConnectionsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Connection body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdPut");
            
    
            var path_ = "/connections/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete Connection Delete Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 ConnectionsIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = ConnectionsIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete Connection Delete Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > ConnectionsIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionApi->ConnectionsIdDelete");
            
    
            var path_ = "/connections/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete Connection Delete Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> ConnectionsIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await ConnectionsIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete Connection Delete Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> ConnectionsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdDelete");
            
    
            var path_ = "/connections/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConnectionsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConnectionsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
