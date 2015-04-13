using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class VariablesApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public VariablesApi(String basePath = "https://localhost/api")
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
    /// Get public variables Get public variables
    /// </summary>
    
    /// <returns></returns>
    public void  publicVariablesGet () {
      // create path and map variables
      var path = "/public/variables".Replace("{format}","json");

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
    /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.
    /// </summary>
    /// <param name="Search">Search query</param>
     /// <param name="EffectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
    
    /// <returns></returns>
    public void  publicVariablesSearchSearchGet (string Search, string EffectOrCause) {
      // create path and map variables
      var path = "/public/variables/search/{search}".Replace("{format}","json").Replace("{" + "search" + "}", apiInvoker.ParameterToString(Search));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (EffectOrCause != null){
        queryParams.Add("effectOrCause", apiInvoker.ParameterToString(EffectOrCause));
      }
      

      

      

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
    /// Get variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
    /// </summary>
    
    /// <returns></returns>
    public void  variableCategoriesGet () {
      // create path and map variables
      var path = "/variableCategories".Replace("{format}","json");

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
    /// Change variable user setting Change variable user setting
    /// </summary>
    /// <param name="SharingData">Variable user settings data</param>
    
    /// <returns></returns>
    public void  variableUserSettingsPost (List<VariableUserSettings> SharingData) {
      // create path and map variables
      var path = "/variableUserSettings".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "POST", queryParams, SharingData, headerParams, formParams);
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
    /// Get variables by the category name Get variables by the category name
    /// </summary>
    /// <param name="UserId">User id</param>
     /// <param name="CategoryName">Category name</param>
    
    /// <returns></returns>
    public void  variablesGet (int? UserId, string CategoryName) {
      // create path and map variables
      var path = "/variables".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (UserId != null){
        queryParams.Add("userId", apiInvoker.ParameterToString(UserId));
      }
      if (CategoryName != null){
        queryParams.Add("categoryName", apiInvoker.ParameterToString(CategoryName));
      }
      

      

      

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
    /// Set variable Allows the client to create a new variable in the `variables` table.
    /// </summary>
    /// <param name="VariableName">Original name for the variable.</param>
    
    /// <returns></returns>
    public void  variablesPost (List<Variable> VariableName) {
      // create path and map variables
      var path = "/variables".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      

      

      

      try {
        if (typeof(void) == typeof(byte[])) {
          
          
          apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
          return;
          
        } else {
          
          
          apiInvoker.invokeAPI(basePath, path, "POST", queryParams, VariableName, headerParams, formParams);
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
    /// Get variables by search query Get variables containing the search characters. Used to provide auto-complete function in variable search boxes.
    /// </summary>
    /// <param name="Search">Search query</param>
     /// <param name="CategoryName">Filter variables by category name.</param>
     /// <param name="Source">Filter variables by source name.</param>
     /// <param name="Limit">Search limit</param>
     /// <param name="Offset">Search offset</param>
    
    /// <returns></returns>
    public void  variablesSearchSearchGet (string Search, string CategoryName, string Source, int? Limit, int? Offset) {
      // create path and map variables
      var path = "/variables/search/{search}".Replace("{format}","json").Replace("{" + "search" + "}", apiInvoker.ParameterToString(Search));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (CategoryName != null){
        queryParams.Add("categoryName", apiInvoker.ParameterToString(CategoryName));
      }
      if (Source != null){
        queryParams.Add("source", apiInvoker.ParameterToString(Source));
      }
      if (Limit != null){
        queryParams.Add("limit", apiInvoker.ParameterToString(Limit));
      }
      if (Offset != null){
        queryParams.Add("offset", apiInvoker.ParameterToString(Offset));
      }
      

      

      

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
    /// Get info about a variable Get all of the settings and information about a variable by name
    /// </summary>
    /// <param name="VariableName">Variable name</param>
     /// <param name="CategoryName">categoryName` parameter allows us to filter the variables so that only ones from the specified category are returned.</param>
    
    /// <returns></returns>
    public void  variablesVariableNameGet (string VariableName, string CategoryName) {
      // create path and map variables
      var path = "/variables/{variableName}".Replace("{format}","json").Replace("{" + "variableName" + "}", apiInvoker.ParameterToString(VariableName));

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (CategoryName != null){
        queryParams.Add("categoryName", apiInvoker.ParameterToString(CategoryName));
      }
      

      

      

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
