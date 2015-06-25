using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IConnectorsApi {
    
    /// <summary>
    /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
    /// </summary>
    
    /// <returns>List<Connector></returns>
    List<Connector> ConnectorsListGet ();

    /// <summary>
    /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
    /// </summary>
    
    /// <returns>List<Connector></returns>
    Task<List<Connector>> ConnectorsListGetAsync ();
    
    /// <summary>
    /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    void ConnectorsConnectorConnectGet (string Connector);

    /// <summary>
    /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    Task ConnectorsConnectorConnectGetAsync (string Connector);
    
    /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>/// <param name="Url">URL which should be used to enable the connector</param>/// <param name="Parameters">Array of Parameters for the request to enable connector</param>/// <param name="UsePopup">Should use popup when enabling connector</param>
    /// <returns></returns>
    void ConnectorsConnectorConnectInstructionsGet (string Connector, string Url, List<string> Parameters, bool? UsePopup);

    /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>/// <param name="Url">URL which should be used to enable the connector</param>/// <param name="Parameters">Array of Parameters for the request to enable connector</param>/// <param name="UsePopup">Should use popup when enabling connector</param>
    /// <returns></returns>
    Task ConnectorsConnectorConnectInstructionsGetAsync (string Connector, string Url, List<string> Parameters, bool? UsePopup);
    
    /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>/// <param name="DisplayName">Name of the parameter that is user visible in the form</param>/// <param name="Key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request) TODO What&#39;s a connector key?</param>/// <param name="UsePopup">Should use popup when enabling connector</param>/// <param name="Type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>/// <param name="Placeholder">Placeholder hint value for the parameter input tag</param>/// <param name="DefaultValue">Default parameter value</param>
    /// <returns></returns>
    void ConnectorsConnectorConnectParameterGet (string Connector, string DisplayName, string Key, bool? UsePopup, string Type, string Placeholder, string DefaultValue);

    /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>/// <param name="DisplayName">Name of the parameter that is user visible in the form</param>/// <param name="Key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request) TODO What&#39;s a connector key?</param>/// <param name="UsePopup">Should use popup when enabling connector</param>/// <param name="Type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>/// <param name="Placeholder">Placeholder hint value for the parameter input tag</param>/// <param name="DefaultValue">Default parameter value</param>
    /// <returns></returns>
    Task ConnectorsConnectorConnectParameterGetAsync (string Connector, string DisplayName, string Key, bool? UsePopup, string Type, string Placeholder, string DefaultValue);
    
    /// <summary>
    /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    void ConnectorsConnectorDisconnectGet (string Connector);

    /// <summary>
    /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    Task ConnectorsConnectorDisconnectGetAsync (string Connector);
    
    /// <summary>
    /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    void ConnectorsConnectorInfoGet (string Connector);

    /// <summary>
    /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    Task ConnectorsConnectorInfoGetAsync (string Connector);
    
    /// <summary>
    /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    /// <returns></returns>
    void ConnectorsConnectorUpdateGet (string Connector);

    /// <summary>
    /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    /// <returns></returns>
    Task ConnectorsConnectorUpdateGetAsync (string Connector);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class ConnectorsApi : IConnectorsApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="ConnectorsApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public ConnectorsApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConnectorsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ConnectorsApi(String basePath)
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
    /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
    /// </summary>
    
    /// <returns>List<Connector></returns>
    public List<Connector> ConnectorsListGet () {

      

      var path = "/connectors/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsListGet: " + response.Content, response.Content);
      }
      return (List<Connector>) apiClient.Deserialize(response.Content, typeof(List<Connector>));
    }
	
	 /// <summary>
    /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
    /// </summary>
    
    /// <returns>List<Connector></returns>
    public async Task<List<Connector>> ConnectorsListGetAsync () {

      

      var path = "/connectors/list";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsListGet: " + response.Content, response.Content);
      }
      return (List<Connector>) apiClient.Deserialize(response.Content, typeof(List<Connector>));
    }
    
    /// <summary>
    /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public void ConnectorsConnectorConnectGet (string Connector) {

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorConnectGet");
      

      var path = "/connectors/{connector}/connect";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public async Task ConnectorsConnectorConnectGetAsync (string Connector) {

      
          // verify the required parameter 'Connector' is set
          if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorConnectGet");
      

      var path = "/connectors/{connector}/connect";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>/// <param name="Url">URL which should be used to enable the connector</param>/// <param name="Parameters">Array of Parameters for the request to enable connector</param>/// <param name="UsePopup">Should use popup when enabling connector</param>
    /// <returns></returns>
    public void ConnectorsConnectorConnectInstructionsGet (string Connector, string Url, List<string> Parameters, bool? UsePopup) {

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorConnectInstructionsGet");
      
      // verify the required parameter 'Url' is set
      if (Url == null) throw new ApiException(400, "Missing required parameter 'Url' when calling ConnectorsConnectorConnectInstructionsGet");
      
      // verify the required parameter 'Parameters' is set
      if (Parameters == null) throw new ApiException(400, "Missing required parameter 'Parameters' when calling ConnectorsConnectorConnectInstructionsGet");
      
      // verify the required parameter 'UsePopup' is set
      if (UsePopup == null) throw new ApiException(400, "Missing required parameter 'UsePopup' when calling ConnectorsConnectorConnectInstructionsGet");
      

      var path = "/connectors/{connector}/connectInstructions";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Url != null) queryParams.Add("url", apiClient.ParameterToString(Url)); // query parameter
       if (Parameters != null) queryParams.Add("parameters", apiClient.ParameterToString(Parameters)); // query parameter
       if (UsePopup != null) queryParams.Add("usePopup", apiClient.ParameterToString(UsePopup)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectInstructionsGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>/// <param name="Url">URL which should be used to enable the connector</param>/// <param name="Parameters">Array of Parameters for the request to enable connector</param>/// <param name="UsePopup">Should use popup when enabling connector</param>
    /// <returns></returns>
    public async Task ConnectorsConnectorConnectInstructionsGetAsync (string Connector, string Url, List<string> Parameters, bool? UsePopup) {

      
          // verify the required parameter 'Connector' is set
          if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorConnectInstructionsGet");
      
          // verify the required parameter 'Url' is set
          if (Url == null) throw new ApiException(400, "Missing required parameter 'Url' when calling ConnectorsConnectorConnectInstructionsGet");
      
          // verify the required parameter 'Parameters' is set
          if (Parameters == null) throw new ApiException(400, "Missing required parameter 'Parameters' when calling ConnectorsConnectorConnectInstructionsGet");
      
          // verify the required parameter 'UsePopup' is set
          if (UsePopup == null) throw new ApiException(400, "Missing required parameter 'UsePopup' when calling ConnectorsConnectorConnectInstructionsGet");
      

      var path = "/connectors/{connector}/connectInstructions";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Url != null) queryParams.Add("url", apiClient.ParameterToString(Url)); // query parameter
       if (Parameters != null) queryParams.Add("parameters", apiClient.ParameterToString(Parameters)); // query parameter
       if (UsePopup != null) queryParams.Add("usePopup", apiClient.ParameterToString(UsePopup)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectInstructionsGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>/// <param name="DisplayName">Name of the parameter that is user visible in the form</param>/// <param name="Key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request) TODO What&#39;s a connector key?</param>/// <param name="UsePopup">Should use popup when enabling connector</param>/// <param name="Type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>/// <param name="Placeholder">Placeholder hint value for the parameter input tag</param>/// <param name="DefaultValue">Default parameter value</param>
    /// <returns></returns>
    public void ConnectorsConnectorConnectParameterGet (string Connector, string DisplayName, string Key, bool? UsePopup, string Type, string Placeholder, string DefaultValue) {

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorConnectParameterGet");
      
      // verify the required parameter 'DisplayName' is set
      if (DisplayName == null) throw new ApiException(400, "Missing required parameter 'DisplayName' when calling ConnectorsConnectorConnectParameterGet");
      
      // verify the required parameter 'Key' is set
      if (Key == null) throw new ApiException(400, "Missing required parameter 'Key' when calling ConnectorsConnectorConnectParameterGet");
      
      // verify the required parameter 'UsePopup' is set
      if (UsePopup == null) throw new ApiException(400, "Missing required parameter 'UsePopup' when calling ConnectorsConnectorConnectParameterGet");
      
      // verify the required parameter 'Type' is set
      if (Type == null) throw new ApiException(400, "Missing required parameter 'Type' when calling ConnectorsConnectorConnectParameterGet");
      
      // verify the required parameter 'Placeholder' is set
      if (Placeholder == null) throw new ApiException(400, "Missing required parameter 'Placeholder' when calling ConnectorsConnectorConnectParameterGet");
      
      // verify the required parameter 'DefaultValue' is set
      if (DefaultValue == null) throw new ApiException(400, "Missing required parameter 'DefaultValue' when calling ConnectorsConnectorConnectParameterGet");
      

      var path = "/connectors/{connector}/connectParameter";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DisplayName != null) queryParams.Add("displayName", apiClient.ParameterToString(DisplayName)); // query parameter
       if (Key != null) queryParams.Add("key", apiClient.ParameterToString(Key)); // query parameter
       if (UsePopup != null) queryParams.Add("usePopup", apiClient.ParameterToString(UsePopup)); // query parameter
       if (Type != null) queryParams.Add("type", apiClient.ParameterToString(Type)); // query parameter
       if (Placeholder != null) queryParams.Add("placeholder", apiClient.ParameterToString(Placeholder)); // query parameter
       if (DefaultValue != null) queryParams.Add("defaultValue", apiClient.ParameterToString(DefaultValue)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectParameterGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>/// <param name="DisplayName">Name of the parameter that is user visible in the form</param>/// <param name="Key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request) TODO What&#39;s a connector key?</param>/// <param name="UsePopup">Should use popup when enabling connector</param>/// <param name="Type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>/// <param name="Placeholder">Placeholder hint value for the parameter input tag</param>/// <param name="DefaultValue">Default parameter value</param>
    /// <returns></returns>
    public async Task ConnectorsConnectorConnectParameterGetAsync (string Connector, string DisplayName, string Key, bool? UsePopup, string Type, string Placeholder, string DefaultValue) {

      
          // verify the required parameter 'Connector' is set
          if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorConnectParameterGet");
      
          // verify the required parameter 'DisplayName' is set
          if (DisplayName == null) throw new ApiException(400, "Missing required parameter 'DisplayName' when calling ConnectorsConnectorConnectParameterGet");
      
          // verify the required parameter 'Key' is set
          if (Key == null) throw new ApiException(400, "Missing required parameter 'Key' when calling ConnectorsConnectorConnectParameterGet");
      
          // verify the required parameter 'UsePopup' is set
          if (UsePopup == null) throw new ApiException(400, "Missing required parameter 'UsePopup' when calling ConnectorsConnectorConnectParameterGet");
      
          // verify the required parameter 'Type' is set
          if (Type == null) throw new ApiException(400, "Missing required parameter 'Type' when calling ConnectorsConnectorConnectParameterGet");
      
          // verify the required parameter 'Placeholder' is set
          if (Placeholder == null) throw new ApiException(400, "Missing required parameter 'Placeholder' when calling ConnectorsConnectorConnectParameterGet");
      
          // verify the required parameter 'DefaultValue' is set
          if (DefaultValue == null) throw new ApiException(400, "Missing required parameter 'DefaultValue' when calling ConnectorsConnectorConnectParameterGet");
      

      var path = "/connectors/{connector}/connectParameter";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (DisplayName != null) queryParams.Add("displayName", apiClient.ParameterToString(DisplayName)); // query parameter
       if (Key != null) queryParams.Add("key", apiClient.ParameterToString(Key)); // query parameter
       if (UsePopup != null) queryParams.Add("usePopup", apiClient.ParameterToString(UsePopup)); // query parameter
       if (Type != null) queryParams.Add("type", apiClient.ParameterToString(Type)); // query parameter
       if (Placeholder != null) queryParams.Add("placeholder", apiClient.ParameterToString(Placeholder)); // query parameter
       if (DefaultValue != null) queryParams.Add("defaultValue", apiClient.ParameterToString(DefaultValue)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectParameterGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public void ConnectorsConnectorDisconnectGet (string Connector) {

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorDisconnectGet");
      

      var path = "/connectors/{connector}/disconnect";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorDisconnectGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public async Task ConnectorsConnectorDisconnectGetAsync (string Connector) {

      
          // verify the required parameter 'Connector' is set
          if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorDisconnectGet");
      

      var path = "/connectors/{connector}/disconnect";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorDisconnectGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public void ConnectorsConnectorInfoGet (string Connector) {

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorInfoGet");
      

      var path = "/connectors/{connector}/info";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorInfoGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
    /// <returns></returns>
    public async Task ConnectorsConnectorInfoGetAsync (string Connector) {

      
          // verify the required parameter 'Connector' is set
          if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorInfoGet");
      

      var path = "/connectors/{connector}/info";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorInfoGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    /// <returns></returns>
    public void ConnectorsConnectorUpdateGet (string Connector) {

      
      // verify the required parameter 'Connector' is set
      if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorUpdateGet");
      

      var path = "/connectors/{connector}/update";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorUpdateGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    /// <returns></returns>
    public async Task ConnectorsConnectorUpdateGetAsync (string Connector) {

      
          // verify the required parameter 'Connector' is set
          if (Connector == null) throw new ApiException(400, "Missing required parameter 'Connector' when calling ConnectorsConnectorUpdateGet");
      

      var path = "/connectors/{connector}/update";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "connector" + "}", apiClient.ParameterToString(Connector));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorUpdateGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
  }  
  
}
