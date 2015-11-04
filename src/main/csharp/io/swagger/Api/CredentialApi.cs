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
    public interface ICredentialApi
    {
        
        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="connectorId">connector_id</param>
        /// <param name="attrKey">attr_key</param>
        /// <param name="attrValue">attr_value</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 CredentialsGet (bool? connectorId, string attrKey, string attrValue, string createdAt, string updatedAt, int? limit, int? offset, string sort);
  
        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="connectorId">connector_id</param>
        /// <param name="attrKey">attr_key</param>
        /// <param name="attrValue">attr_value</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2009</returns>
        System.Threading.Tasks.Task<InlineResponse2009> CredentialsGetAsync (bool? connectorId, string attrKey, string attrValue, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Credential
        /// </summary>
        /// <remarks>
        /// Store Credential
        /// </remarks>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 CredentialsPost (Credential body);
  
        /// <summary>
        /// Store Credential
        /// </summary>
        /// <remarks>
        /// Store Credential
        /// </remarks>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>InlineResponse20010</returns>
        System.Threading.Tasks.Task<InlineResponse20010> CredentialsPostAsync (Credential body);
        
        /// <summary>
        /// Get Credential
        /// </summary>
        /// <remarks>
        /// Get Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 CredentialsIdGet (int? id, string attrKey);
  
        /// <summary>
        /// Get Credential
        /// </summary>
        /// <remarks>
        /// Get Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <returns>InlineResponse20010</returns>
        System.Threading.Tasks.Task<InlineResponse20010> CredentialsIdGetAsync (int? id, string attrKey);
        
        /// <summary>
        /// Update Credential
        /// </summary>
        /// <remarks>
        /// Update Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CredentialsIdPut (int? id, string attrKey, Credential body);
  
        /// <summary>
        /// Update Credential
        /// </summary>
        /// <remarks>
        /// Update Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CredentialsIdPutAsync (int? id, string attrKey, Credential body);
        
        /// <summary>
        /// Delete Credential
        /// </summary>
        /// <remarks>
        /// Delete Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CredentialsIdDelete (int? id, string attrKey);
  
        /// <summary>
        /// Delete Credential
        /// </summary>
        /// <remarks>
        /// Delete Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CredentialsIdDeleteAsync (int? id, string attrKey);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CredentialApi : ICredentialApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CredentialApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CredentialApi(String basePath)
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
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="connectorId">connector_id</param> 
        /// <param name="attrKey">attr_key</param> 
        /// <param name="attrValue">attr_value</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse2009</returns>            
        public InlineResponse2009 CredentialsGet (bool? connectorId, string attrKey, string attrValue, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/credentials";
    
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
            
            if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
            if (attrKey != null) queryParams.Add("attr_key", ApiClient.ParameterToString(attrKey)); // query parameter
            if (attrValue != null) queryParams.Add("attr_value", ApiClient.ParameterToString(attrValue)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response, typeof(InlineResponse2009));
        }
    
        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="connectorId">connector_id</param>
        /// <param name="attrKey">attr_key</param>
        /// <param name="attrValue">attr_value</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2009</returns>
        public async System.Threading.Tasks.Task<InlineResponse2009> CredentialsGetAsync (bool? connectorId, string attrKey, string attrValue, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/credentials";
    
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
            
            if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
            if (attrKey != null) queryParams.Add("attr_key", ApiClient.ParameterToString(attrKey)); // query parameter
            if (attrValue != null) queryParams.Add("attr_value", ApiClient.ParameterToString(attrValue)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsGet: " + response.Content, response.Content);

            return (InlineResponse2009) ApiClient.Deserialize(response, typeof(InlineResponse2009));
        }
        
        /// <summary>
        /// Store Credential Store Credential
        /// </summary>
        /// <param name="body">Credential that should be stored</param> 
        /// <returns>InlineResponse20010</returns>            
        public InlineResponse20010 CredentialsPost (Credential body)
        {
            
    
            var path_ = "/credentials";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response, typeof(InlineResponse20010));
        }
    
        /// <summary>
        /// Store Credential Store Credential
        /// </summary>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>InlineResponse20010</returns>
        public async System.Threading.Tasks.Task<InlineResponse20010> CredentialsPostAsync (Credential body)
        {
            
    
            var path_ = "/credentials";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsPost: " + response.Content, response.Content);

            return (InlineResponse20010) ApiClient.Deserialize(response, typeof(InlineResponse20010));
        }
        
        /// <summary>
        /// Get Credential Get Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <returns>InlineResponse20010</returns>            
        public InlineResponse20010 CredentialsIdGet (int? id, string attrKey)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdGet");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdGet");
            
    
            var path_ = "/credentials/{id}";
    
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
            
            if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response, typeof(InlineResponse20010));
        }
    
        /// <summary>
        /// Get Credential Get Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <returns>InlineResponse20010</returns>
        public async System.Threading.Tasks.Task<InlineResponse20010> CredentialsIdGetAsync (int? id, string attrKey)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdGet");
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdGet");
            
    
            var path_ = "/credentials/{id}";
    
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
            
            if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdGet: " + response.Content, response.Content);

            return (InlineResponse20010) ApiClient.Deserialize(response, typeof(InlineResponse20010));
        }
        
        /// <summary>
        /// Update Credential Update Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="body">Credential that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CredentialsIdPut (int? id, string attrKey, Credential body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdPut");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdPut");
            
    
            var path_ = "/credentials/{id}";
    
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
            
            if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Update Credential Update Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CredentialsIdPutAsync (int? id, string attrKey, Credential body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdPut");
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdPut");
            
    
            var path_ = "/credentials/{id}";
    
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
            
            if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdPut: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
        /// <summary>
        /// Delete Credential Delete Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CredentialsIdDelete (int? id, string attrKey)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdDelete");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdDelete");
            
    
            var path_ = "/credentials/{id}";
    
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
            
            if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Delete Credential Delete Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CredentialsIdDeleteAsync (int? id, string attrKey)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdDelete");
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdDelete");
            
    
            var path_ = "/credentials/{id}";
    
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
            
            if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdDelete: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
    }
    
}
