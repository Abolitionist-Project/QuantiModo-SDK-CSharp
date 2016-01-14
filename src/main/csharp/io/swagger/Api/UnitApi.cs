using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUnitApi
    {
        
        /// <summary>
        /// Get all available units
        /// </summary>
        /// <remarks>
        /// Get all available units
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param>
        /// <param name="name">Unit name</param>
        /// <param name="abbreviatedName">Unit abbreviation</param>
        /// <param name="categoryId">Unit category ID</param>
        /// <param name="minimumValue">Minimum value permitted for this unit</param>
        /// <param name="maximumValue">Maximum value permitted for this unit</param>
        /// <param name="updated">updated</param>
        /// <param name="defaultUnitId">ID of default unit for this units category</param>
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param>
        /// <param name="add">Value which should be added to convert to default unit</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 UnitsGet (string accessToken = null, string clientId = null, string name = null, string abbreviatedName = null, int? categoryId = null, double? minimumValue = null, double? maximumValue = null, int? updated = null, int? defaultUnitId = null, double? multiply = null, double? add = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all available units
        /// </summary>
        /// <remarks>
        /// Get all available units
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param>
        /// <param name="name">Unit name</param>
        /// <param name="abbreviatedName">Unit abbreviation</param>
        /// <param name="categoryId">Unit category ID</param>
        /// <param name="minimumValue">Minimum value permitted for this unit</param>
        /// <param name="maximumValue">Maximum value permitted for this unit</param>
        /// <param name="updated">updated</param>
        /// <param name="defaultUnitId">ID of default unit for this units category</param>
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param>
        /// <param name="add">Value which should be added to convert to default unit</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20026</returns>
        ApiResponse<InlineResponse20026> UnitsGetWithHttpInfo (string accessToken = null, string clientId = null, string name = null, string abbreviatedName = null, int? categoryId = null, double? minimumValue = null, double? maximumValue = null, int? updated = null, int? defaultUnitId = null, double? multiply = null, double? add = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all available units
        /// </summary>
        /// <remarks>
        /// Get all available units
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param>
        /// <param name="name">Unit name</param>
        /// <param name="abbreviatedName">Unit abbreviation</param>
        /// <param name="categoryId">Unit category ID</param>
        /// <param name="minimumValue">Minimum value permitted for this unit</param>
        /// <param name="maximumValue">Maximum value permitted for this unit</param>
        /// <param name="updated">updated</param>
        /// <param name="defaultUnitId">ID of default unit for this units category</param>
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param>
        /// <param name="add">Value which should be added to convert to default unit</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20026</returns>
        System.Threading.Tasks.Task<InlineResponse20026> UnitsGetAsync (string accessToken = null, string clientId = null, string name = null, string abbreviatedName = null, int? categoryId = null, double? minimumValue = null, double? maximumValue = null, int? updated = null, int? defaultUnitId = null, double? multiply = null, double? add = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all available units
        /// </summary>
        /// <remarks>
        /// Get all available units
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param>
        /// <param name="name">Unit name</param>
        /// <param name="abbreviatedName">Unit abbreviation</param>
        /// <param name="categoryId">Unit category ID</param>
        /// <param name="minimumValue">Minimum value permitted for this unit</param>
        /// <param name="maximumValue">Maximum value permitted for this unit</param>
        /// <param name="updated">updated</param>
        /// <param name="defaultUnitId">ID of default unit for this units category</param>
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param>
        /// <param name="add">Value which should be added to convert to default unit</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20026)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20026>> UnitsGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, string name = null, string abbreviatedName = null, int? categoryId = null, double? minimumValue = null, double? maximumValue = null, int? updated = null, int? defaultUnitId = null, double? multiply = null, double? add = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store Unit
        /// </summary>
        /// <remarks>
        /// Store Unit
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be stored</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 UnitsPost (string accessToken = null, Unit body = null);
  
        /// <summary>
        /// Store Unit
        /// </summary>
        /// <remarks>
        /// Store Unit
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20027</returns>
        ApiResponse<InlineResponse20027> UnitsPostWithHttpInfo (string accessToken = null, Unit body = null);

        /// <summary>
        /// Store Unit
        /// </summary>
        /// <remarks>
        /// Store Unit
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be stored</param>
        /// <returns>Task of InlineResponse20027</returns>
        System.Threading.Tasks.Task<InlineResponse20027> UnitsPostAsync (string accessToken = null, Unit body = null);

        /// <summary>
        /// Store Unit
        /// </summary>
        /// <remarks>
        /// Store Unit
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20027)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20027>> UnitsPostAsyncWithHttpInfo (string accessToken = null, Unit body = null);
        
        /// <summary>
        /// Get Unit
        /// </summary>
        /// <remarks>
        /// Get Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 UnitsIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get Unit
        /// </summary>
        /// <remarks>
        /// Get Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20027</returns>
        ApiResponse<InlineResponse20027> UnitsIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get Unit
        /// </summary>
        /// <remarks>
        /// Get Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20027</returns>
        System.Threading.Tasks.Task<InlineResponse20027> UnitsIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get Unit
        /// </summary>
        /// <remarks>
        /// Get Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20027)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20027>> UnitsIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update Unit
        /// </summary>
        /// <remarks>
        /// Update Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UnitsIdPut (int? id, string accessToken = null, Unit body = null);
  
        /// <summary>
        /// Update Unit
        /// </summary>
        /// <remarks>
        /// Update Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> UnitsIdPutWithHttpInfo (int? id, string accessToken = null, Unit body = null);

        /// <summary>
        /// Update Unit
        /// </summary>
        /// <remarks>
        /// Update Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> UnitsIdPutAsync (int? id, string accessToken = null, Unit body = null);

        /// <summary>
        /// Update Unit
        /// </summary>
        /// <remarks>
        /// Update Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UnitsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Unit body = null);
        
        /// <summary>
        /// Delete Unit
        /// </summary>
        /// <remarks>
        /// Delete Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UnitsIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete Unit
        /// </summary>
        /// <remarks>
        /// Delete Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> UnitsIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete Unit
        /// </summary>
        /// <remarks>
        /// Delete Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> UnitsIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete Unit
        /// </summary>
        /// <remarks>
        /// Delete Unit
        /// </remarks>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UnitsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UnitApi : IUnitApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UnitApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UnitApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param> 
        /// <param name="name">Unit name</param> 
        /// <param name="abbreviatedName">Unit abbreviation</param> 
        /// <param name="categoryId">Unit category ID</param> 
        /// <param name="minimumValue">Minimum value permitted for this unit</param> 
        /// <param name="maximumValue">Maximum value permitted for this unit</param> 
        /// <param name="updated">updated</param> 
        /// <param name="defaultUnitId">ID of default unit for this units category</param> 
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param> 
        /// <param name="add">Value which should be added to convert to default unit</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20026</returns>
        public InlineResponse20026 UnitsGet (string accessToken = null, string clientId = null, string name = null, string abbreviatedName = null, int? categoryId = null, double? minimumValue = null, double? maximumValue = null, int? updated = null, int? defaultUnitId = null, double? multiply = null, double? add = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20026> response = UnitsGetWithHttpInfo(accessToken, clientId, name, abbreviatedName, categoryId, minimumValue, maximumValue, updated, defaultUnitId, multiply, add, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param> 
        /// <param name="name">Unit name</param> 
        /// <param name="abbreviatedName">Unit abbreviation</param> 
        /// <param name="categoryId">Unit category ID</param> 
        /// <param name="minimumValue">Minimum value permitted for this unit</param> 
        /// <param name="maximumValue">Maximum value permitted for this unit</param> 
        /// <param name="updated">updated</param> 
        /// <param name="defaultUnitId">ID of default unit for this units category</param> 
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param> 
        /// <param name="add">Value which should be added to convert to default unit</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20026</returns>
        public ApiResponse< InlineResponse20026 > UnitsGetWithHttpInfo (string accessToken = null, string clientId = null, string name = null, string abbreviatedName = null, int? categoryId = null, double? minimumValue = null, double? maximumValue = null, int? updated = null, int? defaultUnitId = null, double? multiply = null, double? add = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/units";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (abbreviatedName != null) queryParams.Add("abbreviated_name", Configuration.ApiClient.ParameterToString(abbreviatedName)); // query parameter
            if (categoryId != null) queryParams.Add("category_id", Configuration.ApiClient.ParameterToString(categoryId)); // query parameter
            if (minimumValue != null) queryParams.Add("minimum_value", Configuration.ApiClient.ParameterToString(minimumValue)); // query parameter
            if (maximumValue != null) queryParams.Add("maximum_value", Configuration.ApiClient.ParameterToString(maximumValue)); // query parameter
            if (updated != null) queryParams.Add("updated", Configuration.ApiClient.ParameterToString(updated)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (multiply != null) queryParams.Add("multiply", Configuration.ApiClient.ParameterToString(multiply)); // query parameter
            if (add != null) queryParams.Add("add", Configuration.ApiClient.ParameterToString(add)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20026>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20026) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20026)));
            
        }
    
        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param>
        /// <param name="name">Unit name</param>
        /// <param name="abbreviatedName">Unit abbreviation</param>
        /// <param name="categoryId">Unit category ID</param>
        /// <param name="minimumValue">Minimum value permitted for this unit</param>
        /// <param name="maximumValue">Maximum value permitted for this unit</param>
        /// <param name="updated">updated</param>
        /// <param name="defaultUnitId">ID of default unit for this units category</param>
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param>
        /// <param name="add">Value which should be added to convert to default unit</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20026</returns>
        public async System.Threading.Tasks.Task<InlineResponse20026> UnitsGetAsync (string accessToken = null, string clientId = null, string name = null, string abbreviatedName = null, int? categoryId = null, double? minimumValue = null, double? maximumValue = null, int? updated = null, int? defaultUnitId = null, double? multiply = null, double? add = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20026> response = await UnitsGetAsyncWithHttpInfo(accessToken, clientId, name, abbreviatedName, categoryId, minimumValue, maximumValue, updated, defaultUnitId, multiply, add, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param>
        /// <param name="name">Unit name</param>
        /// <param name="abbreviatedName">Unit abbreviation</param>
        /// <param name="categoryId">Unit category ID</param>
        /// <param name="minimumValue">Minimum value permitted for this unit</param>
        /// <param name="maximumValue">Maximum value permitted for this unit</param>
        /// <param name="updated">updated</param>
        /// <param name="defaultUnitId">ID of default unit for this units category</param>
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param>
        /// <param name="add">Value which should be added to convert to default unit</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20026)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20026>> UnitsGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, string name = null, string abbreviatedName = null, int? categoryId = null, double? minimumValue = null, double? maximumValue = null, int? updated = null, int? defaultUnitId = null, double? multiply = null, double? add = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/units";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (abbreviatedName != null) queryParams.Add("abbreviated_name", Configuration.ApiClient.ParameterToString(abbreviatedName)); // query parameter
            if (categoryId != null) queryParams.Add("category_id", Configuration.ApiClient.ParameterToString(categoryId)); // query parameter
            if (minimumValue != null) queryParams.Add("minimum_value", Configuration.ApiClient.ParameterToString(minimumValue)); // query parameter
            if (maximumValue != null) queryParams.Add("maximum_value", Configuration.ApiClient.ParameterToString(maximumValue)); // query parameter
            if (updated != null) queryParams.Add("updated", Configuration.ApiClient.ParameterToString(updated)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (multiply != null) queryParams.Add("multiply", Configuration.ApiClient.ParameterToString(multiply)); // query parameter
            if (add != null) queryParams.Add("add", Configuration.ApiClient.ParameterToString(add)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20026>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20026) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20026)));
            
        }
        
        /// <summary>
        /// Store Unit Store Unit
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Unit that should be stored</param> 
        /// <returns>InlineResponse20027</returns>
        public InlineResponse20027 UnitsPost (string accessToken = null, Unit body = null)
        {
             ApiResponse<InlineResponse20027> response = UnitsPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store Unit Store Unit
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Unit that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20027</returns>
        public ApiResponse< InlineResponse20027 > UnitsPostWithHttpInfo (string accessToken = null, Unit body = null)
        {
            
    
            var path_ = "/units";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20027>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20027) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20027)));
            
        }
    
        /// <summary>
        /// Store Unit Store Unit
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be stored</param>
        /// <returns>Task of InlineResponse20027</returns>
        public async System.Threading.Tasks.Task<InlineResponse20027> UnitsPostAsync (string accessToken = null, Unit body = null)
        {
             ApiResponse<InlineResponse20027> response = await UnitsPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store Unit Store Unit
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20027)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20027>> UnitsPostAsyncWithHttpInfo (string accessToken = null, Unit body = null)
        {
            
    
            var path_ = "/units";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20027>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20027) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20027)));
            
        }
        
        /// <summary>
        /// Get Unit Get Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20027</returns>
        public InlineResponse20027 UnitsIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20027> response = UnitsIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get Unit Get Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20027</returns>
        public ApiResponse< InlineResponse20027 > UnitsIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdGet");
            
    
            var path_ = "/units/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20027>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20027) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20027)));
            
        }
    
        /// <summary>
        /// Get Unit Get Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20027</returns>
        public async System.Threading.Tasks.Task<InlineResponse20027> UnitsIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20027> response = await UnitsIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get Unit Get Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20027)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20027>> UnitsIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdGet");
            
    
            var path_ = "/units/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20027>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20027) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20027)));
            
        }
        
        /// <summary>
        /// Update Unit Update Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Unit that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 UnitsIdPut (int? id, string accessToken = null, Unit body = null)
        {
             ApiResponse<InlineResponse2002> response = UnitsIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update Unit Update Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Unit that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > UnitsIdPutWithHttpInfo (int? id, string accessToken = null, Unit body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdPut");
            
    
            var path_ = "/units/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update Unit Update Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> UnitsIdPutAsync (int? id, string accessToken = null, Unit body = null)
        {
             ApiResponse<InlineResponse2002> response = await UnitsIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update Unit Update Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UnitsIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Unit body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdPut");
            
    
            var path_ = "/units/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete Unit Delete Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 UnitsIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = UnitsIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete Unit Delete Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > UnitsIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdDelete");
            
    
            var path_ = "/units/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete Unit Delete Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> UnitsIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await UnitsIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete Unit Delete Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UnitsIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdDelete");
            
    
            var path_ = "/units/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UnitsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UnitsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
