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
    public interface IVariableUserSourceApi
    {
        
        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <param name="variableId">variable_id</param>
        /// <param name="userId">user_id</param>
        /// <param name="timestamp">timestamp</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20025</returns>
        InlineResponse20025 VariableUserSourcesGet (int? variableId, int? userId, int? timestamp, string createdAt, string updatedAt, int? limit, int? offset, string sort);
  
        /// <summary>
        /// Get all VariableUserSources
        /// </summary>
        /// <remarks>
        /// Get all VariableUserSources
        /// </remarks>
        /// <param name="variableId">variable_id</param>
        /// <param name="userId">user_id</param>
        /// <param name="timestamp">timestamp</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20025</returns>
        System.Threading.Tasks.Task<InlineResponse20025> VariableUserSourcesGetAsync (int? variableId, int? userId, int? timestamp, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store VariableUserSource
        /// </summary>
        /// <remarks>
        /// Store VariableUserSource
        /// </remarks>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 VariableUserSourcesPost (VariableUserSource body);
  
        /// <summary>
        /// Store VariableUserSource
        /// </summary>
        /// <remarks>
        /// Store VariableUserSource
        /// </remarks>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>InlineResponse20026</returns>
        System.Threading.Tasks.Task<InlineResponse20026> VariableUserSourcesPostAsync (VariableUserSource body);
        
        /// <summary>
        /// Get VariableUserSource
        /// </summary>
        /// <remarks>
        /// Get VariableUserSource
        /// </remarks>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 VariableUserSourcesIdGet (int? id, int? sourceId);
  
        /// <summary>
        /// Get VariableUserSource
        /// </summary>
        /// <remarks>
        /// Get VariableUserSource
        /// </remarks>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <returns>InlineResponse20026</returns>
        System.Threading.Tasks.Task<InlineResponse20026> VariableUserSourcesIdGetAsync (int? id, int? sourceId);
        
        /// <summary>
        /// Update VariableUserSource
        /// </summary>
        /// <remarks>
        /// Update VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableUserSourcesIdPut (int? id, int? sourceId, VariableUserSource body);
  
        /// <summary>
        /// Update VariableUserSource
        /// </summary>
        /// <remarks>
        /// Update VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariableUserSourcesIdPutAsync (int? id, int? sourceId, VariableUserSource body);
        
        /// <summary>
        /// Delete VariableUserSource
        /// </summary>
        /// <remarks>
        /// Delete VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableUserSourcesIdDelete (int? id, int? sourceId);
  
        /// <summary>
        /// Delete VariableUserSource
        /// </summary>
        /// <remarks>
        /// Delete VariableUserSource
        /// </remarks>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariableUserSourcesIdDeleteAsync (int? id, int? sourceId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariableUserSourceApi : IVariableUserSourceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableUserSourceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VariableUserSourceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableUserSourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariableUserSourceApi(String basePath)
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
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <param name="variableId">variable_id</param> 
        /// <param name="userId">user_id</param> 
        /// <param name="timestamp">timestamp</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20025</returns>            
        public InlineResponse20025 VariableUserSourcesGet (int? variableId, int? userId, int? timestamp, string createdAt, string updatedAt, int? limit, int? offset, string sort)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
            if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
            if (timestamp != null) queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20025) ApiClient.Deserialize(response, typeof(InlineResponse20025));
        }
    
        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <param name="variableId">variable_id</param>
        /// <param name="userId">user_id</param>
        /// <param name="timestamp">timestamp</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20025</returns>
        public async System.Threading.Tasks.Task<InlineResponse20025> VariableUserSourcesGetAsync (int? variableId, int? userId, int? timestamp, string createdAt, string updatedAt, int? limit, int? offset, string sort)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
            if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
            if (timestamp != null) queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesGet: " + response.Content, response.Content);

            return (InlineResponse20025) ApiClient.Deserialize(response, typeof(InlineResponse20025));
        }
        
        /// <summary>
        /// Store VariableUserSource Store VariableUserSource
        /// </summary>
        /// <param name="body">VariableUserSource that should be stored</param> 
        /// <returns>InlineResponse20026</returns>            
        public InlineResponse20026 VariableUserSourcesPost (VariableUserSource body)
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20026) ApiClient.Deserialize(response, typeof(InlineResponse20026));
        }
    
        /// <summary>
        /// Store VariableUserSource Store VariableUserSource
        /// </summary>
        /// <param name="body">VariableUserSource that should be stored</param>
        /// <returns>InlineResponse20026</returns>
        public async System.Threading.Tasks.Task<InlineResponse20026> VariableUserSourcesPostAsync (VariableUserSource body)
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesPost: " + response.Content, response.Content);

            return (InlineResponse20026) ApiClient.Deserialize(response, typeof(InlineResponse20026));
        }
        
        /// <summary>
        /// Get VariableUserSource Get VariableUserSource
        /// </summary>
        /// <param name="id">id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <returns>InlineResponse20026</returns>            
        public InlineResponse20026 VariableUserSourcesIdGet (int? id, int? sourceId)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            if (sourceId != null) queryParams.Add("source_id", ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20026) ApiClient.Deserialize(response, typeof(InlineResponse20026));
        }
    
        /// <summary>
        /// Get VariableUserSource Get VariableUserSource
        /// </summary>
        /// <param name="id">id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <returns>InlineResponse20026</returns>
        public async System.Threading.Tasks.Task<InlineResponse20026> VariableUserSourcesIdGetAsync (int? id, int? sourceId)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            if (sourceId != null) queryParams.Add("source_id", ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdGet: " + response.Content, response.Content);

            return (InlineResponse20026) ApiClient.Deserialize(response, typeof(InlineResponse20026));
        }
        
        /// <summary>
        /// Update VariableUserSource Update VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <param name="body">VariableUserSource that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariableUserSourcesIdPut (int? id, int? sourceId, VariableUserSource body)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            if (sourceId != null) queryParams.Add("source_id", ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Update VariableUserSource Update VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <param name="body">VariableUserSource that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariableUserSourcesIdPutAsync (int? id, int? sourceId, VariableUserSource body)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            if (sourceId != null) queryParams.Add("source_id", ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdPut: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
        /// <summary>
        /// Delete VariableUserSource Delete VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param> 
        /// <param name="sourceId">source id of VariableUserSource</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariableUserSourcesIdDelete (int? id, int? sourceId)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            if (sourceId != null) queryParams.Add("source_id", ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Delete VariableUserSource Delete VariableUserSource
        /// </summary>
        /// <param name="id">variable_id of VariableUserSource</param>
        /// <param name="sourceId">source id of VariableUserSource</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariableUserSourcesIdDeleteAsync (int? id, int? sourceId)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            if (sourceId != null) queryParams.Add("source_id", ApiClient.ParameterToString(sourceId)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSourcesIdDelete: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
    }
    
}
