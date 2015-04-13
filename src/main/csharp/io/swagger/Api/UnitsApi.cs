using System;
using System.Collections.Generic;
using io.swagger.client;
using io.swagger.Model;

namespace io.swagger.Api {
  
  public class UnitsApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public UnitsApi(String basePath = "https://localhost/api")
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
    /// Get unit categories 
    /// </summary>
    
    /// <returns></returns>
    public void  unitCategoriesGet () {
      // create path and map variables
      var path = "/unitCategories".Replace("{format}","json");

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
    /// Get all available units Get all available units
    /// </summary>
    /// <param name="UnitName">Unit name</param>
     /// <param name="AbbreviatedUnitName">Unit abbreviation</param>
     /// <param name="CategoryName">Unit category</param>
    
    /// <returns></returns>
    public void  unitsGet (string UnitName, string AbbreviatedUnitName, string CategoryName) {
      // create path and map variables
      var path = "/units".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (UnitName != null){
        queryParams.Add("unitName", apiInvoker.ParameterToString(UnitName));
      }
      if (AbbreviatedUnitName != null){
        queryParams.Add("abbreviatedUnitName", apiInvoker.ParameterToString(AbbreviatedUnitName));
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
    /// Get all available units for variable Get all available units for variable
    /// </summary>
    /// <param name="Variable">Variable name</param>
     /// <param name="UnitName">Unit name</param>
     /// <param name="CabbreviatedUnitName">Unit abbreviation</param>
     /// <param name="CategoryName">Unit category</param>
    
    /// <returns></returns>
    public void  unitsVariableGet (string Variable, string UnitName, string CabbreviatedUnitName, string CategoryName) {
      // create path and map variables
      var path = "/unitsVariable".Replace("{format}","json");

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      

      if (Variable != null){
        queryParams.Add("variable", apiInvoker.ParameterToString(Variable));
      }
      if (UnitName != null){
        queryParams.Add("unitName", apiInvoker.ParameterToString(UnitName));
      }
      if (CabbreviatedUnitName != null){
        queryParams.Add("cabbreviatedUnitName", apiInvoker.ParameterToString(CabbreviatedUnitName));
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
    
  }
  
}
