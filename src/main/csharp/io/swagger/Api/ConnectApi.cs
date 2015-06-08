using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class ConnectApi {
    string basePath;
    protected RestClient restClient;

    public ConnectApi(String basePath = "https://localhost/api")
    {
      this.basePath = basePath;
      this.restClient = new RestClient(basePath);
    }

    /// <summary>
    /// Sets the endpoint base url for the services being accessed
    /// </summary>
    /// <param name="basePath"> Base URL
    /// <returns></returns>
    public void SetBasePath(string basePath) {
      this.basePath = basePath;
    }

    /// <summary>
    /// Gets the endpoint base url for the services being accessed
    /// <returns>Base URL</returns>
    /// </summary>
    public String GetBasePath() {
      return this.basePath;
    }

    
    
    /// <summary>
    /// Get embeddable connect javascript Get embeddable connect javascript
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    public void V1ConnectJsGet (string T) {

      var _request = new RestRequest("/v1/connect.js", Method.GET);

      
      // verify the required parameter 'T' is set
      if (T == null) throw new ApiException(400, "Missing required parameter 'T' when calling V1ConnectJsGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (T != null) _request.AddParameter("t", ApiInvoker.ParameterToString(T)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectJsGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Mobile connect page Mobile connect page
    /// </summary>
    /// <param name="T">User token</param>
    /// <returns></returns>
    public void V1ConnectMobileGet (string T) {

      var _request = new RestRequest("/v1/connect/mobile", Method.GET);

      
      // verify the required parameter 'T' is set
      if (T == null) throw new ApiException(400, "Missing required parameter 'T' when calling V1ConnectMobileGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (T != null) _request.AddParameter("t", ApiInvoker.ParameterToString(T)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectMobileGet: " + response.Content);
      }
      
      return;
    }
    
  }
  
}
