using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    
    public interface IConnectApi
    {
        
        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript
        /// </summary>
        /// <param name="t">User token</param>
        /// <returns></returns>
        void V1ConnectJsGet (string t);
  
        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript
        /// </summary>
        /// <param name="t">User token</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1ConnectJsGetAsync (string t);
        
        /// <summary>
        /// Mobile connect page Mobile connect page
        /// </summary>
        /// <param name="t">User token</param>
        /// <returns></returns>
        void V1ConnectMobileGet (string t);
  
        /// <summary>
        /// Mobile connect page Mobile connect page
        /// </summary>
        /// <param name="t">User token</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1ConnectMobileGetAsync (string t);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectApi : IConnectApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConnectApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectApi(String basePath)
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
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript
        /// </summary>
        /// <param name="t">User token</param> 
        /// <returns></returns>            
        public void V1ConnectJsGet (string t)
        {
            
    
            var path = "/v1/connect.js";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (t != null) queryParams.Add("t", ApiClient.ParameterToString(t)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectJsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectJsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript
        /// </summary>
        /// <param name="t">User token</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1ConnectJsGetAsync (string t)
        {
            
    
            var path = "/v1/connect.js";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (t != null) queryParams.Add("t", ApiClient.ParameterToString(t)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectJsGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Mobile connect page Mobile connect page
        /// </summary>
        /// <param name="t">User token</param> 
        /// <returns></returns>            
        public void V1ConnectMobileGet (string t)
        {
            
            // verify the required parameter 't' is set
            if (t == null) throw new ApiException(400, "Missing required parameter 't' when calling V1ConnectMobileGet");
            
    
            var path = "/v1/connect/mobile";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (t != null) queryParams.Add("t", ApiClient.ParameterToString(t)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectMobileGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectMobileGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Mobile connect page Mobile connect page
        /// </summary>
        /// <param name="t">User token</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1ConnectMobileGetAsync (string t)
        {
            // verify the required parameter 't' is set
            if (t == null) throw new ApiException(400, "Missing required parameter 't' when calling V1ConnectMobileGet");
            
    
            var path = "/v1/connect/mobile";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (t != null) queryParams.Add("t", ApiClient.ParameterToString(t)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectMobileGet: " + response.Content, response.Content);

            
            return;
        }
        
    }
    
}
