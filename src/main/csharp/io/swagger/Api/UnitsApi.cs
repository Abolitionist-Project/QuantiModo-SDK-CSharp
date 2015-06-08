using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class UnitsApi {
    string basePath;
    protected RestClient restClient;

    public UnitsApi(String basePath = "https://localhost/api")
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
    /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
    /// </summary>
    /// <returns></returns>
    public void UnitCategoriesGet () {

      var _request = new RestRequest("/unitCategories", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get all available units Get all available units
    /// </summary>
    /// <param name="UnitName">Unit name</param>
    /// <param name="AbbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation.</param>
    /// <param name="CategoryName">Restrict the results to a specific unit category by providing the unit category name.</param>
    /// <returns></returns>
    public void UnitsGet (string UnitName, string AbbreviatedUnitName, string CategoryName) {

      var _request = new RestRequest("/units", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (UnitName != null) _request.AddParameter("unitName", ApiInvoker.ParameterToString(UnitName)); // query parameter
       if (AbbreviatedUnitName != null) _request.AddParameter("abbreviatedUnitName", ApiInvoker.ParameterToString(AbbreviatedUnitName)); // query parameter
       if (CategoryName != null) _request.AddParameter("categoryName", ApiInvoker.ParameterToString(CategoryName)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UnitsGet: " + response.Content);
      }
      
      return;
    }
    
  }
  
}
