using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class ConnectorsApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public ConnectorsApi(String basePath = "https://localhost/api")
    {
      this.basePath = basePath;
    }

    public ApiInvoker getInvoker() {
      return apiInvoker;
    }

    // Sets the endpoint base url for the services being accessed
    public void setBasePath(string basePath) {
      this.basePath = basePath;
    }

    // Gets the endpoint base url for the services being accessed
    public String getBasePath() {
      return basePath;
    }

    

    /// <summary>
    /// List of Connectors Returns a list of all available connectors. A connector pulls data from other data providers using their API or a screenscraper.
    /// </summary>
    
    /// <returns></returns>
    public List<Connector>  connectorsListGet () {
      // create path and map variables
      var path = "/connectors/list".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(List<Connector>) == typeof(byte[])) {
          
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return ((object)response) as List<Connector>;
          
          
        } else {
          
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          if (response != null){
             return (List<Connector>) ApiInvoker.deserialize(response, typeof(List<Connector>));
          }
          else {
            return null;
          }
          
          
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return null;
        }
        else {
          throw ex;
        }
      }
    }
    

    /// <summary>
    /// Obtain a token from 3rd party data source The `connect` method tells it to attempt to obtain a token from the data provider, store it in `connect`.`credentials`, allowing the connector to obtain user data.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    
    /// <returns></returns>
    public void  connectorsConnectorConnectGet (string Connector) {
      // create path and map variables
      var path = "/connectors/{connector}/connect".Replace("{format}","json").Replace("{" + "connector" + "}", apiInvoker.ParameterToString(Connector));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ;
        }
        else {
          throw ex;
        }
      }
    }
    

    /// <summary>
    /// Get connection parameters The `connectInstructions` method returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    
    /// <returns></returns>
    public void  connectorsConnectorConnectInstructionsGet (string Connector) {
      // create path and map variables
      var path = "/connectors/{connector}/connectInstructions".Replace("{format}","json").Replace("{" + "connector" + "}", apiInvoker.ParameterToString(Connector));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ;
        }
        else {
          throw ex;
        }
      }
    }
    

    /// <summary>
    /// Delete stored connection info The `disconnect` method deletes any stored tokens or connection information from the `connectors` database.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    
    /// <returns></returns>
    public void  connectorsConnectorDisconnectGet (string Connector) {
      // create path and map variables
      var path = "/connectors/{connector}/disconnect".Replace("{format}","json").Replace("{" + "connector" + "}", apiInvoker.ParameterToString(Connector));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ;
        }
        else {
          throw ex;
        }
      }
    }
    

    /// <summary>
    /// Get connector info for user The `info` method returns information about the connector such as the connector id, whether or not is connected (i.e. we have a token in the `connector`.`credentials` table, and the update history from the `connector`.`updates` table.)
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    
    /// <returns></returns>
    public void  connectorsConnectorInfoGet (string Connector) {
      // create path and map variables
      var path = "/connectors/{connector}/info".Replace("{format}","json").Replace("{" + "connector" + "}", apiInvoker.ParameterToString(Connector));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ;
        }
        else {
          throw ex;
        }
      }
    }
    

    /// <summary>
    /// Sync with data source The `update` method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and put any new data in the `quantimodo`.`measurements` table.
    /// </summary>
    /// <param name="Connector">Lowercase system name of the source application or device</param>
    
    /// <returns></returns>
    public void  connectorsConnectorUpdateGet (string Connector) {
      // create path and map variables
      var path = "/connectors/{connector}/update".Replace("{format}","json").Replace("{" + "connector" + "}", apiInvoker.ParameterToString(Connector));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ;
        }
        else {
          throw ex;
        }
      }
    }
    
  }
  
}
