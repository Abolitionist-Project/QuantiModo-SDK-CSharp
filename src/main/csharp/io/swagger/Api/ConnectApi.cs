using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IConnectApi {
    
    /// <summary>
    /// Get embeddable connect javascript Get embeddable connect javascript
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    void V1ConnectJsGet (string T);

    /// <summary>
    /// Get embeddable connect javascript Get embeddable connect javascript
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    Task V1ConnectJsGetAsync (string T);
    
    /// <summary>
    /// Mobile connect page Mobile connect page
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    void V1ConnectMobileGet (string T);

    /// <summary>
    /// Mobile connect page Mobile connect page
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    Task V1ConnectMobileGetAsync (string T);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class ConnectApi : IConnectApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="ConnectApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public ConnectApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConnectApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ConnectApi(String basePath)
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
    /// Get embeddable connect javascript Get embeddable connect javascript
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    public void V1ConnectJsGet (string T) {

      
      // verify the required parameter 'T' is set
      if (T == null) throw new ApiException(400, "Missing required parameter 'T' when calling V1ConnectJsGet");
      

      var path = "/v1/connect.js";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (T != null) queryParams.Add("t", apiClient.ParameterToString(T)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectJsGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Get embeddable connect javascript Get embeddable connect javascript
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    public async Task V1ConnectJsGetAsync (string T) {

      
          // verify the required parameter 'T' is set
          if (T == null) throw new ApiException(400, "Missing required parameter 'T' when calling V1ConnectJsGet");
      

      var path = "/v1/connect.js";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (T != null) queryParams.Add("t", apiClient.ParameterToString(T)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectJsGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Mobile connect page Mobile connect page
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    public void V1ConnectMobileGet (string T) {

      
      // verify the required parameter 'T' is set
      if (T == null) throw new ApiException(400, "Missing required parameter 'T' when calling V1ConnectMobileGet");
      

      var path = "/v1/connect/mobile";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (T != null) queryParams.Add("t", apiClient.ParameterToString(T)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectMobileGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Mobile connect page Mobile connect page
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    public async Task V1ConnectMobileGetAsync (string T) {

      
          // verify the required parameter 'T' is set
          if (T == null) throw new ApiException(400, "Missing required parameter 'T' when calling V1ConnectMobileGet");
      

      var path = "/v1/connect/mobile";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (T != null) queryParams.Add("t", apiClient.ParameterToString(T)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectMobileGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
  }  
  
}
