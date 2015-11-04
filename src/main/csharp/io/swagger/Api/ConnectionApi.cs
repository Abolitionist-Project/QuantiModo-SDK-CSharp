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
    public interface IConnectionApi
    {
        
        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="userId">user_id</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="connectStatus">connect_status</param>
        /// <param name="connectError">connect_error</param>
        /// <param name="updateRequestedAt">update_requested_at</param>
        /// <param name="updateStatus">update_status</param>
        /// <param name="updateError">update_error</param>
        /// <param name="lastSuccessfulUpdatedAt">last_successful_updated_at</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 ConnectionsGet (int? userId, int? connectorId, string connectStatus, string connectError, string updateRequestedAt, string updateStatus, string updateError, string lastSuccessfulUpdatedAt, string createdAt, string updatedAt, int? limit, int? offset, string sort);
  
        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="userId">user_id</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="connectStatus">connect_status</param>
        /// <param name="connectError">connect_error</param>
        /// <param name="updateRequestedAt">update_requested_at</param>
        /// <param name="updateStatus">update_status</param>
        /// <param name="updateError">update_error</param>
        /// <param name="lastSuccessfulUpdatedAt">last_successful_updated_at</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> ConnectionsGetAsync (int? userId, int? connectorId, string connectStatus, string connectError, string updateRequestedAt, string updateStatus, string updateError, string lastSuccessfulUpdatedAt, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Connection
        /// </summary>
        /// <remarks>
        /// Store Connection
        /// </remarks>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 ConnectionsPost (Connection body);
  
        /// <summary>
        /// Store Connection
        /// </summary>
        /// <remarks>
        /// Store Connection
        /// </remarks>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>InlineResponse2004</returns>
        System.Threading.Tasks.Task<InlineResponse2004> ConnectionsPostAsync (Connection body);
        
        /// <summary>
        /// Get Connection
        /// </summary>
        /// <remarks>
        /// Get Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 ConnectionsIdGet (int? id);
  
        /// <summary>
        /// Get Connection
        /// </summary>
        /// <remarks>
        /// Get Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <returns>InlineResponse2004</returns>
        System.Threading.Tasks.Task<InlineResponse2004> ConnectionsIdGetAsync (int? id);
        
        /// <summary>
        /// Update Connection
        /// </summary>
        /// <remarks>
        /// Update Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 ConnectionsIdPut (int? id, Connection body);
  
        /// <summary>
        /// Update Connection
        /// </summary>
        /// <remarks>
        /// Update Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> ConnectionsIdPutAsync (int? id, Connection body);
        
        /// <summary>
        /// Delete Connection
        /// </summary>
        /// <remarks>
        /// Delete Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 ConnectionsIdDelete (int? id);
  
        /// <summary>
        /// Delete Connection
        /// </summary>
        /// <remarks>
        /// Delete Connection
        /// </remarks>
        /// <param name="id">id of Connection</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> ConnectionsIdDeleteAsync (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectionApi : IConnectionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConnectionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionApi(String basePath)
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
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="userId">user_id</param> 
        /// <param name="connectorId">connector_id</param> 
        /// <param name="connectStatus">connect_status</param> 
        /// <param name="connectError">connect_error</param> 
        /// <param name="updateRequestedAt">update_requested_at</param> 
        /// <param name="updateStatus">update_status</param> 
        /// <param name="updateError">update_error</param> 
        /// <param name="lastSuccessfulUpdatedAt">last_successful_updated_at</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 ConnectionsGet (int? userId, int? connectorId, string connectStatus, string connectError, string updateRequestedAt, string updateStatus, string updateError, string lastSuccessfulUpdatedAt, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/connections";
    
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
            if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
            if (connectStatus != null) queryParams.Add("connect_status", ApiClient.ParameterToString(connectStatus)); // query parameter
            if (connectError != null) queryParams.Add("connect_error", ApiClient.ParameterToString(connectError)); // query parameter
            if (updateRequestedAt != null) queryParams.Add("update_requested_at", ApiClient.ParameterToString(updateRequestedAt)); // query parameter
            if (updateStatus != null) queryParams.Add("update_status", ApiClient.ParameterToString(updateStatus)); // query parameter
            if (updateError != null) queryParams.Add("update_error", ApiClient.ParameterToString(updateError)); // query parameter
            if (lastSuccessfulUpdatedAt != null) queryParams.Add("last_successful_updated_at", ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response, typeof(InlineResponse2003));
        }
    
        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="userId">user_id</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="connectStatus">connect_status</param>
        /// <param name="connectError">connect_error</param>
        /// <param name="updateRequestedAt">update_requested_at</param>
        /// <param name="updateStatus">update_status</param>
        /// <param name="updateError">update_error</param>
        /// <param name="lastSuccessfulUpdatedAt">last_successful_updated_at</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> ConnectionsGetAsync (int? userId, int? connectorId, string connectStatus, string connectError, string updateRequestedAt, string updateStatus, string updateError, string lastSuccessfulUpdatedAt, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/connections";
    
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
            if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
            if (connectStatus != null) queryParams.Add("connect_status", ApiClient.ParameterToString(connectStatus)); // query parameter
            if (connectError != null) queryParams.Add("connect_error", ApiClient.ParameterToString(connectError)); // query parameter
            if (updateRequestedAt != null) queryParams.Add("update_requested_at", ApiClient.ParameterToString(updateRequestedAt)); // query parameter
            if (updateStatus != null) queryParams.Add("update_status", ApiClient.ParameterToString(updateStatus)); // query parameter
            if (updateError != null) queryParams.Add("update_error", ApiClient.ParameterToString(updateError)); // query parameter
            if (lastSuccessfulUpdatedAt != null) queryParams.Add("last_successful_updated_at", ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsGet: " + response.Content, response.Content);

            return (InlineResponse2003) ApiClient.Deserialize(response, typeof(InlineResponse2003));
        }
        
        /// <summary>
        /// Store Connection Store Connection
        /// </summary>
        /// <param name="body">Connection that should be stored</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 ConnectionsPost (Connection body)
        {
            
    
            var path_ = "/connections";
    
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response, typeof(InlineResponse2004));
        }
    
        /// <summary>
        /// Store Connection Store Connection
        /// </summary>
        /// <param name="body">Connection that should be stored</param>
        /// <returns>InlineResponse2004</returns>
        public async System.Threading.Tasks.Task<InlineResponse2004> ConnectionsPostAsync (Connection body)
        {
            
    
            var path_ = "/connections";
    
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsPost: " + response.Content, response.Content);

            return (InlineResponse2004) ApiClient.Deserialize(response, typeof(InlineResponse2004));
        }
        
        /// <summary>
        /// Get Connection Get Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 ConnectionsIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdGet");
            
    
            var path_ = "/connections/{id}";
    
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response, typeof(InlineResponse2004));
        }
    
        /// <summary>
        /// Get Connection Get Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <returns>InlineResponse2004</returns>
        public async System.Threading.Tasks.Task<InlineResponse2004> ConnectionsIdGetAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdGet");
            
    
            var path_ = "/connections/{id}";
    
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdGet: " + response.Content, response.Content);

            return (InlineResponse2004) ApiClient.Deserialize(response, typeof(InlineResponse2004));
        }
        
        /// <summary>
        /// Update Connection Update Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <param name="body">Connection that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 ConnectionsIdPut (int? id, Connection body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdPut");
            
    
            var path_ = "/connections/{id}";
    
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Update Connection Update Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <param name="body">Connection that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> ConnectionsIdPutAsync (int? id, Connection body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdPut");
            
    
            var path_ = "/connections/{id}";
    
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdPut: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
        /// <summary>
        /// Delete Connection Delete Connection
        /// </summary>
        /// <param name="id">id of Connection</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 ConnectionsIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdDelete");
            
    
            var path_ = "/connections/{id}";
    
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Delete Connection Delete Connection
        /// </summary>
        /// <param name="id">id of Connection</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> ConnectionsIdDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsIdDelete");
            
    
            var path_ = "/connections/{id}";
    
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectionsIdDelete: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
    }
    
}
