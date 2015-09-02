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
        List<Connector> V1ConnectorsListGet ();
  
        /// <summary>
        /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
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
        /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
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
