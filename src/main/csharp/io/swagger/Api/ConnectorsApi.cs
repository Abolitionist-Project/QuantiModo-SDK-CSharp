using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class ConnectorsApi {
    string basePath;
    protected RestClient restClient;

    public ConnectorsApi(String basePath = "https://localhost/api")
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
    /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
    /// </summary>
    /// <returns>List<Connector></returns>
    public List<Connector> ConnectorsListGet () {

      var _request = new RestRequest("/connectors/list", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsListGet: " + response.Content);
      }
      return (List<Connector>) ApiInvoker.Deserialize(response.Content, typeof(List<Connector>));
    }
    
    
    /// <summary>
    /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public void ConnectorsConnectorConnectGet (string Connector) {

      var _request = new RestRequest("/connectors/{connector}/connect", Method.GET);

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorConnectGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("connector", ApiInvoker.ParameterToString(Connector)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public void ConnectorsConnectorConnectInstructionsGet (string Connector) {

      var _request = new RestRequest("/connectors/{connector}/connectInstructions", Method.GET);

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorConnectInstructionsGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("connector", ApiInvoker.ParameterToString(Connector)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectInstructionsGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public void ConnectorsConnectorDisconnectGet (string Connector) {

      var _request = new RestRequest("/connectors/{connector}/disconnect", Method.GET);

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorDisconnectGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("connector", ApiInvoker.ParameterToString(Connector)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorDisconnectGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public void ConnectorsConnectorInfoGet (string Connector) {

      var _request = new RestRequest("/connectors/{connector}/info", Method.GET);

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorInfoGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("connector", ApiInvoker.ParameterToString(Connector)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorInfoGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    /// <returns></returns>
    public void ConnectorsConnectorUpdateGet (string Connector) {

      var _request = new RestRequest("/connectors/{connector}/update", Method.GET);

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorUpdateGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("connector", ApiInvoker.ParameterToString(Connector)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorUpdateGet: " + response.Content);
      }
      
      return;
    }
    
  }
  
}
