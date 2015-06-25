using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IUnitsApi {
    
    /// <summary>
    /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
    /// </summary>
    
    /// <returns>UnitCategory</returns>
    UnitCategory UnitCategoriesGet ();

    /// <summary>
    /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
    /// </summary>
    
    /// <returns>UnitCategory</returns>
    Task<UnitCategory> UnitCategoriesGetAsync ();
    
    /// <summary>
    /// Get all available units Get all available units
    /// </summary>
    /// <param name="UnitName">Unit name</param>/// <param name="AbbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation.</param>/// <param name="CategoryName">Restrict the results to a specific unit category by providing the unit category name.</param>
    /// <returns>List<Unit></returns>
    List<Unit> UnitsGet (string UnitName, string AbbreviatedUnitName, string CategoryName);

    /// <summary>
    /// Get all available units Get all available units
    /// </summary>
    /// <param name="UnitName">Unit name</param>/// <param name="AbbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation.</param>/// <param name="CategoryName">Restrict the results to a specific unit category by providing the unit category name.</param>
    /// <returns>List<Unit></returns>
    Task<List<Unit>> UnitsGetAsync (string UnitName, string AbbreviatedUnitName, string CategoryName);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class UnitsApi : IUnitsApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitsApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public UnitsApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public UnitsApi(String basePath)
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
    /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
    /// </summary>
    
    /// <returns>UnitCategory</returns>
    public UnitCategory UnitCategoriesGet () {

      

      var path = "/unitCategories";
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
        throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesGet: " + response.Content, response.Content);
      }
      return (UnitCategory) apiClient.Deserialize(response.Content, typeof(UnitCategory));
    }
	
	 /// <summary>
    /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
    /// </summary>
    
    /// <returns>UnitCategory</returns>
    public async Task<UnitCategory> UnitCategoriesGetAsync () {

      

      var path = "/unitCategories";
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
        throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesGet: " + response.Content, response.Content);
      }
      return (UnitCategory) apiClient.Deserialize(response.Content, typeof(UnitCategory));
    }
    
    /// <summary>
    /// Get all available units Get all available units
    /// </summary>
    /// <param name="UnitName">Unit name</param>/// <param name="AbbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation.</param>/// <param name="CategoryName">Restrict the results to a specific unit category by providing the unit category name.</param>
    /// <returns>List<Unit></returns>
    public List<Unit> UnitsGet (string UnitName, string AbbreviatedUnitName, string CategoryName) {

      

      var path = "/units";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (UnitName != null) queryParams.Add("unitName", apiClient.ParameterToString(UnitName)); // query parameter
       if (AbbreviatedUnitName != null) queryParams.Add("abbreviatedUnitName", apiClient.ParameterToString(AbbreviatedUnitName)); // query parameter
       if (CategoryName != null) queryParams.Add("categoryName", apiClient.ParameterToString(CategoryName)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UnitsGet: " + response.Content, response.Content);
      }
      return (List<Unit>) apiClient.Deserialize(response.Content, typeof(List<Unit>));
    }
	
	 /// <summary>
    /// Get all available units Get all available units
    /// </summary>
    /// <param name="UnitName">Unit name</param>/// <param name="AbbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation.</param>/// <param name="CategoryName">Restrict the results to a specific unit category by providing the unit category name.</param>
    /// <returns>List<Unit></returns>
    public async Task<List<Unit>> UnitsGetAsync (string UnitName, string AbbreviatedUnitName, string CategoryName) {

      

      var path = "/units";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (UnitName != null) queryParams.Add("unitName", apiClient.ParameterToString(UnitName)); // query parameter
       if (AbbreviatedUnitName != null) queryParams.Add("abbreviatedUnitName", apiClient.ParameterToString(AbbreviatedUnitName)); // query parameter
       if (CategoryName != null) queryParams.Add("categoryName", apiClient.ParameterToString(CategoryName)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UnitsGet: " + response.Content, response.Content);
      }
      return (List<Unit>) apiClient.Deserialize(response.Content, typeof(List<Unit>));
    }
    
  }  
  
}
