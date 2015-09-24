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
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:\n\n  - Embedding in applications with popups for 3rd-party authentication\nwindows.\n\n    Use `qmSetupInPopup` function after connecting `connect.js`.\n\n  - Embedding in applications with popups for 3rd-party authentication\nwindows.\n\n    Requires a selector to block. It will be embedded in this block.\n\n    Use `qmSetupOnPage` function after connecting `connect.js`.\n\n  - Embedding in mobile applications without popups for 3rd-party\nauthentication.\n\n    Use `qmSetupOnMobile` function after connecting `connect.js`.\n\n    if using the MoodiModo Clones, Use `qmSetupOnIonic` function after connecting `connect.js`.
        /// </summary>
        /// <param name="access token">User&#39;s access token</param>
        /// <param name="mashape key">Mashape API key</param>
        /// <returns></returns>
        void V1ConnectJsGet (string access token, string mashape key);
  
        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:\n\n  - Embedding in applications with popups for 3rd-party authentication\nwindows.\n\n    Use `qmSetupInPopup` function after connecting `connect.js`.\n\n  - Embedding in applications with popups for 3rd-party authentication\nwindows.\n\n    Requires a selector to block. It will be embedded in this block.\n\n    Use `qmSetupOnPage` function after connecting `connect.js`.\n\n  - Embedding in mobile applications without popups for 3rd-party\nauthentication.\n\n    Use `qmSetupOnMobile` function after connecting `connect.js`.\n\n    if using the MoodiModo Clones, Use `qmSetupOnIonic` function after connecting `connect.js`.
        /// </summary>
        /// <param name="access token">User&#39;s access token</param>
        /// <param name="mashape key">Mashape API key</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1ConnectJsGetAsync (string access token, string mashape key);
        
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
        
        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <returns>List<Connector></returns>
        List<Connector> V1ConnectorsListGet ();
  
        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <returns>List<Connector></returns>
        System.Threading.Tasks.Task<List<Connector>> V1ConnectorsListGetAsync ();
        
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        void V1ConnectorsConnectorConnectGet (string connector);
  
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1ConnectorsConnectorConnectGetAsync (string connector);
        
        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <returns></returns>
        void V1ConnectorsConnectorConnectInstructionsGet (string connector, string parameters, string url, bool? usePopup);
  
        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1ConnectorsConnectorConnectInstructionsGetAsync (string connector, string parameters, string url, bool? usePopup);
        
        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="defaultValue">Default parameter value</param>
        /// <returns>ConnectorInstruction</returns>
        ConnectorInstruction V1ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string defaultValue);
  
        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="defaultValue">Default parameter value</param>
        /// <returns>ConnectorInstruction</returns>
        System.Threading.Tasks.Task<ConnectorInstruction> V1ConnectorsConnectorConnectParameterGetAsync (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string defaultValue);
        
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        void V1ConnectorsConnectorDisconnectGet (string connector);
  
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1ConnectorsConnectorDisconnectGetAsync (string connector);
        
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>ConnectorInfo</returns>
        ConnectorInfo V1ConnectorsConnectorInfoGet (string connector);
  
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>ConnectorInfo</returns>
        System.Threading.Tasks.Task<ConnectorInfo> V1ConnectorsConnectorInfoGetAsync (string connector);
        
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <returns></returns>
        void V1ConnectorsConnectorUpdateGet (string connector);
  
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1ConnectorsConnectorUpdateGetAsync (string connector);
        
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
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:\n\n  - Embedding in applications with popups for 3rd-party authentication\nwindows.\n\n    Use `qmSetupInPopup` function after connecting `connect.js`.\n\n  - Embedding in applications with popups for 3rd-party authentication\nwindows.\n\n    Requires a selector to block. It will be embedded in this block.\n\n    Use `qmSetupOnPage` function after connecting `connect.js`.\n\n  - Embedding in mobile applications without popups for 3rd-party\nauthentication.\n\n    Use `qmSetupOnMobile` function after connecting `connect.js`.\n\n    if using the MoodiModo Clones, Use `qmSetupOnIonic` function after connecting `connect.js`.
        /// </summary>
        /// <param name="access token">User&#39;s access token</param> 
        /// <param name="mashape key">Mashape API key</param> 
        /// <returns></returns>            
        public void V1ConnectJsGet (string access token, string mashape key)
        {
            
            // verify the required parameter 'access token' is set
            if (access token == null) throw new ApiException(400, "Missing required parameter 'access token' when calling V1ConnectJsGet");
            
    
            var path = "/v1/connect.js";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (access token != null) queryParams.Add("access token", ApiClient.ParameterToString(access token)); // query parameter
            if (mashape key != null) queryParams.Add("mashape key", ApiClient.ParameterToString(mashape key)); // query parameter
            
            
            
            
    
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
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:\n\n  - Embedding in applications with popups for 3rd-party authentication\nwindows.\n\n    Use `qmSetupInPopup` function after connecting `connect.js`.\n\n  - Embedding in applications with popups for 3rd-party authentication\nwindows.\n\n    Requires a selector to block. It will be embedded in this block.\n\n    Use `qmSetupOnPage` function after connecting `connect.js`.\n\n  - Embedding in mobile applications without popups for 3rd-party\nauthentication.\n\n    Use `qmSetupOnMobile` function after connecting `connect.js`.\n\n    if using the MoodiModo Clones, Use `qmSetupOnIonic` function after connecting `connect.js`.
        /// </summary>
        /// <param name="access token">User&#39;s access token</param>
        /// <param name="mashape key">Mashape API key</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1ConnectJsGetAsync (string access token, string mashape key)
        {
            // verify the required parameter 'access token' is set
            if (access token == null) throw new ApiException(400, "Missing required parameter 'access token' when calling V1ConnectJsGet");
            
    
            var path = "/v1/connect.js";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (access token != null) queryParams.Add("access token", ApiClient.ParameterToString(access token)); // query parameter
            if (mashape key != null) queryParams.Add("mashape key", ApiClient.ParameterToString(mashape key)); // query parameter
            
            
            
            
    
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
        
        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <returns>List<Connector></returns>            
        public List<Connector> V1ConnectorsListGet ()
        {
            
    
            var path = "/v1/connectors/list";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsListGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsListGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Connector>) ApiClient.Deserialize(response.Content, typeof(List<Connector>), response.Headers);
        }
    
        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <returns>List<Connector></returns>
        public async System.Threading.Tasks.Task<List<Connector>> V1ConnectorsListGetAsync ()
        {
            
    
            var path = "/v1/connectors/list";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsListGet: " + response.Content, response.Content);

            return (List<Connector>) ApiClient.Deserialize(response.Content, typeof(List<Connector>), response.Headers);
        }
        
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <returns></returns>            
        public void V1ConnectorsConnectorConnectGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectGet");
            
    
            var path = "/v1/connectors/{connector}/connect";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1ConnectorsConnectorConnectGetAsync (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectGet");
            
    
            var path = "/v1/connectors/{connector}/connect";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param> 
        /// <param name="url">URL which should be used to enable the connector.</param> 
        /// <param name="usePopup">Should use popup when enabling connector</param> 
        /// <returns></returns>            
        public void V1ConnectorsConnectorConnectInstructionsGet (string connector, string parameters, string url, bool? usePopup)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'parameters' is set
            if (parameters == null) throw new ApiException(400, "Missing required parameter 'parameters' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
    
            var path = "/v1/connectors/{connector}/connectInstructions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            if (parameters != null) queryParams.Add("parameters", ApiClient.ParameterToString(parameters)); // query parameter
            if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
            if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectInstructionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectInstructionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1ConnectorsConnectorConnectInstructionsGetAsync (string connector, string parameters, string url, bool? usePopup)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'parameters' is set
            if (parameters == null) throw new ApiException(400, "Missing required parameter 'parameters' when calling V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling V1ConnectorsConnectorConnectInstructionsGet");
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
    
            var path = "/v1/connectors/{connector}/connectInstructions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            if (parameters != null) queryParams.Add("parameters", ApiClient.ParameterToString(parameters)); // query parameter
            if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
            if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectInstructionsGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <param name="displayName">Name of the parameter that is user visible in the form</param> 
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param> 
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param> 
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param> 
        /// <param name="usePopup">Should use popup when enabling connector</param> 
        /// <param name="defaultValue">Default parameter value</param> 
        /// <returns>ConnectorInstruction</returns>            
        public ConnectorInstruction V1ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string defaultValue)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'displayName' is set
            if (displayName == null) throw new ApiException(400, "Missing required parameter 'displayName' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'placeholder' is set
            if (placeholder == null) throw new ApiException(400, "Missing required parameter 'placeholder' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling V1ConnectorsConnectorConnectParameterGet");
            
    
            var path = "/v1/connectors/{connector}/connectParameter";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            if (defaultValue != null) queryParams.Add("defaultValue", ApiClient.ParameterToString(defaultValue)); // query parameter
            if (displayName != null) queryParams.Add("displayName", ApiClient.ParameterToString(displayName)); // query parameter
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            if (placeholder != null) queryParams.Add("placeholder", ApiClient.ParameterToString(placeholder)); // query parameter
            if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
            if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectParameterGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectParameterGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ConnectorInstruction) ApiClient.Deserialize(response.Content, typeof(ConnectorInstruction), response.Headers);
        }
    
        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="defaultValue">Default parameter value</param>
        /// <returns>ConnectorInstruction</returns>
        public async System.Threading.Tasks.Task<ConnectorInstruction> V1ConnectorsConnectorConnectParameterGetAsync (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string defaultValue)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'displayName' is set
            if (displayName == null) throw new ApiException(400, "Missing required parameter 'displayName' when calling V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'placeholder' is set
            if (placeholder == null) throw new ApiException(400, "Missing required parameter 'placeholder' when calling V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling V1ConnectorsConnectorConnectParameterGet");
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling V1ConnectorsConnectorConnectParameterGet");
            
    
            var path = "/v1/connectors/{connector}/connectParameter";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (connector != null) pathParams.Add("connector", ApiClient.ParameterToString(connector)); // path parameter
            
            if (defaultValue != null) queryParams.Add("defaultValue", ApiClient.ParameterToString(defaultValue)); // query parameter
            if (displayName != null) queryParams.Add("displayName", ApiClient.ParameterToString(displayName)); // query parameter
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            if (placeholder != null) queryParams.Add("placeholder", ApiClient.ParameterToString(placeholder)); // query parameter
            if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
            if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectParameterGet: " + response.Content, response.Content);

            return (ConnectorInstruction) ApiClient.Deserialize(response.Content, typeof(ConnectorInstruction), response.Headers);
        }
        
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <returns></returns>            
        public void V1ConnectorsConnectorDisconnectGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorDisconnectGet");
            
    
            var path = "/v1/connectors/{connector}/disconnect";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorDisconnectGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorDisconnectGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1ConnectorsConnectorDisconnectGetAsync (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorDisconnectGet");
            
    
            var path = "/v1/connectors/{connector}/disconnect";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorDisconnectGet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <returns>ConnectorInfo</returns>            
        public ConnectorInfo V1ConnectorsConnectorInfoGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorInfoGet");
            
    
            var path = "/v1/connectors/{connector}/info";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorInfoGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorInfoGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ConnectorInfo) ApiClient.Deserialize(response.Content, typeof(ConnectorInfo), response.Headers);
        }
    
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns>ConnectorInfo</returns>
        public async System.Threading.Tasks.Task<ConnectorInfo> V1ConnectorsConnectorInfoGetAsync (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorInfoGet");
            
    
            var path = "/v1/connectors/{connector}/info";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorInfoGet: " + response.Content, response.Content);

            return (ConnectorInfo) ApiClient.Deserialize(response.Content, typeof(ConnectorInfo), response.Headers);
        }
        
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param> 
        /// <returns></returns>            
        public void V1ConnectorsConnectorUpdateGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorUpdateGet");
            
    
            var path = "/v1/connectors/{connector}/update";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorUpdateGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorUpdateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1ConnectorsConnectorUpdateGetAsync (string connector)
        {
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorUpdateGet");
            
    
            var path = "/v1/connectors/{connector}/update";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorUpdateGet: " + response.Content, response.Content);

            
            return;
        }
        
    }
    
}
