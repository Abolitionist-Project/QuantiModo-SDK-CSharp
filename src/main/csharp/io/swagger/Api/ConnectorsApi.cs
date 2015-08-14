using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IConnectorsApi
    {
        
        /// <summary>
        /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
        /// </summary>
        /// <returns>List<Connector></returns>
        List<Connector> ConnectorsListGet ();
  
        /// <summary>
        /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
        /// </summary>
        /// <returns>List<Connector></returns>
        System.Threading.Tasks.Task<List<Connector>> ConnectorsListGetAsync ();
        
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        void ConnectorsConnectorConnectGet (string connector);
  
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task ConnectorsConnectorConnectGetAsync (string connector);
        
        /// <summary>
        /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="url">URL which should be used to enable the connector</param>
        /// <param name="parameters">Array of Parameters for the request to enable connector</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <returns></returns>
        void ConnectorsConnectorConnectInstructionsGet (string connector, string url, List<string> parameters, bool? usePopup);
  
        /// <summary>
        /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="url">URL which should be used to enable the connector</param>
        /// <param name="parameters">Array of Parameters for the request to enable connector</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <returns></returns>
        System.Threading.Tasks.Task ConnectorsConnectorConnectInstructionsGetAsync (string connector, string url, List<string> parameters, bool? usePopup);
        
        /// <summary>
        /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request) TODO What&#39;s a connector key?</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag</param>
        /// <param name="defaultValue">Default parameter value</param>
        /// <returns></returns>
        void ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, bool? usePopup, string type, string placeholder, string defaultValue);
  
        /// <summary>
        /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request) TODO What&#39;s a connector key?</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag</param>
        /// <param name="defaultValue">Default parameter value</param>
        /// <returns></returns>
        System.Threading.Tasks.Task ConnectorsConnectorConnectParameterGetAsync (string connector, string displayName, string key, bool? usePopup, string type, string placeholder, string defaultValue);
        
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        void ConnectorsConnectorDisconnectGet (string connector);
  
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task ConnectorsConnectorDisconnectGetAsync (string connector);
        
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        void ConnectorsConnectorInfoGet (string connector);
  
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task ConnectorsConnectorInfoGetAsync (string connector);
        
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <returns></returns>
        void ConnectorsConnectorUpdateGet (string connector);
  
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <returns></returns>
        System.Threading.Tasks.Task ConnectorsConnectorUpdateGetAsync (string connector);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectorsApi : IConnectorsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConnectorsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectorsApi(String basePath)
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
        /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
        /// </summary>
        /// <returns>List<Connector></returns>            
        public List<Connector> ConnectorsListGet ()
        {
            
    
            var path = "/connectors/list";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsListGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsListGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Connector>) ApiClient.Deserialize(response.Content, typeof(List<Connector>), response.Headers);
        }
    
        /// <summary>
        /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
        /// </summary>
        /// <returns>List<Connector></returns>
        public async System.Threading.Tasks.Task<List<Connector>> ConnectorsListGetAsync ()
        {
            
    
            var path = "/connectors/list";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsListGet: " + response.Content, response.Content);

            return (List<Connector>) ApiClient.Deserialize(response.Content, typeof(List<Connector>), response.Headers);
        }
        
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <returns></returns>            
        public void ConnectorsConnectorConnectGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorConnectGet");
            
    
            var path = "/connectors/{connector}/connect";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task ConnectorsConnectorConnectGetAsync (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorConnectGet");
            
    
            var path = "/connectors/{connector}/connect";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <param name="url">URL which should be used to enable the connector</param> 
        /// <param name="parameters">Array of Parameters for the request to enable connector</param> 
        /// <param name="usePopup">Should use popup when enabling connector</param> 
        /// <returns></returns>            
        public void ConnectorsConnectorConnectInstructionsGet (string connector, string url, List<string> parameters, bool? usePopup)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'parameters' is set
            if (parameters == null) throw new ApiException(400, "Missing required parameter 'parameters' when calling ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling ConnectorsConnectorConnectInstructionsGet");
            
    
            var path = "/connectors/{connector}/connectInstructions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
            if (parameters != null) queryParams.Add("parameters", ApiClient.ParameterToString(parameters)); // query parameter
            if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectInstructionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectInstructionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="url">URL which should be used to enable the connector</param>
        /// <param name="parameters">Array of Parameters for the request to enable connector</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task ConnectorsConnectorConnectInstructionsGetAsync (string connector, string url, List<string> parameters, bool? usePopup)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'parameters' is set
            if (parameters == null) throw new ApiException(400, "Missing required parameter 'parameters' when calling ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling ConnectorsConnectorConnectInstructionsGet");
            
    
            var path = "/connectors/{connector}/connectInstructions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
            if (parameters != null) queryParams.Add("parameters", ApiClient.ParameterToString(parameters)); // query parameter
            if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectInstructionsGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <param name="displayName">Name of the parameter that is user visible in the form</param> 
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request) TODO What&#39;s a connector key?</param> 
        /// <param name="usePopup">Should use popup when enabling connector</param> 
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param> 
        /// <param name="placeholder">Placeholder hint value for the parameter input tag</param> 
        /// <param name="defaultValue">Default parameter value</param> 
        /// <returns></returns>            
        public void ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, bool? usePopup, string type, string placeholder, string defaultValue)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'displayName' is set
            if (displayName == null) throw new ApiException(400, "Missing required parameter 'displayName' when calling ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'placeholder' is set
            if (placeholder == null) throw new ApiException(400, "Missing required parameter 'placeholder' when calling ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'defaultValue' is set
            if (defaultValue == null) throw new ApiException(400, "Missing required parameter 'defaultValue' when calling ConnectorsConnectorConnectParameterGet");
            
    
            var path = "/connectors/{connector}/connectParameter";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            if (displayName != null) queryParams.Add("displayName", ApiClient.ParameterToString(displayName)); // query parameter
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
            if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
            if (placeholder != null) queryParams.Add("placeholder", ApiClient.ParameterToString(placeholder)); // query parameter
            if (defaultValue != null) queryParams.Add("defaultValue", ApiClient.ParameterToString(defaultValue)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectParameterGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectParameterGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get connection parameters Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request) TODO What&#39;s a connector key?</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag</param>
        /// <param name="defaultValue">Default parameter value</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task ConnectorsConnectorConnectParameterGetAsync (string connector, string displayName, string key, bool? usePopup, string type, string placeholder, string defaultValue)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'displayName' is set
            if (displayName == null) throw new ApiException(400, "Missing required parameter 'displayName' when calling ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'placeholder' is set
            if (placeholder == null) throw new ApiException(400, "Missing required parameter 'placeholder' when calling ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'defaultValue' is set
            if (defaultValue == null) throw new ApiException(400, "Missing required parameter 'defaultValue' when calling ConnectorsConnectorConnectParameterGet");
            
    
            var path = "/connectors/{connector}/connectParameter";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            if (displayName != null) queryParams.Add("displayName", ApiClient.ParameterToString(displayName)); // query parameter
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
            if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
            if (placeholder != null) queryParams.Add("placeholder", ApiClient.ParameterToString(placeholder)); // query parameter
            if (defaultValue != null) queryParams.Add("defaultValue", ApiClient.ParameterToString(defaultValue)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorConnectParameterGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <returns></returns>            
        public void ConnectorsConnectorDisconnectGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorDisconnectGet");
            
    
            var path = "/connectors/{connector}/disconnect";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorDisconnectGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorDisconnectGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task ConnectorsConnectorDisconnectGetAsync (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorDisconnectGet");
            
    
            var path = "/connectors/{connector}/disconnect";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorDisconnectGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <returns></returns>            
        public void ConnectorsConnectorInfoGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorInfoGet");
            
    
            var path = "/connectors/{connector}/info";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorInfoGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorInfoGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task ConnectorsConnectorInfoGetAsync (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorInfoGet");
            
    
            var path = "/connectors/{connector}/info";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorInfoGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param> 
        /// <returns></returns>            
        public void ConnectorsConnectorUpdateGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorUpdateGet");
            
    
            var path = "/connectors/{connector}/update";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorUpdateGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorUpdateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task ConnectorsConnectorUpdateGetAsync (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling ConnectorsConnectorUpdateGet");
            
    
            var path = "/connectors/{connector}/update";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsConnectorUpdateGet: " + response.Content, response.Content);

            
            return;
        }
        
    }
    
}
