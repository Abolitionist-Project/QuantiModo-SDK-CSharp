using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICredentialApi
    {
        
        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this credential</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 CredentialsGet (string accessToken = null, int? userId = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this credential</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        ApiResponse<InlineResponse2004> CredentialsGetWithHttpInfo (string accessToken = null, int? userId = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this credential</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2004</returns>
        System.Threading.Tasks.Task<InlineResponse2004> CredentialsGetAsync (string accessToken = null, int? userId = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this credential</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> CredentialsGetAsyncWithHttpInfo (string accessToken = null, int? userId = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store Credential
        /// </summary>
        /// <remarks>
        /// Store Credential
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>InlineResponse20019</returns>
        InlineResponse20019 CredentialsPost (string accessToken = null, Credential body = null);
  
        /// <summary>
        /// Store Credential
        /// </summary>
        /// <remarks>
        /// Store Credential
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20019</returns>
        ApiResponse<InlineResponse20019> CredentialsPostWithHttpInfo (string accessToken = null, Credential body = null);

        /// <summary>
        /// Store Credential
        /// </summary>
        /// <remarks>
        /// Store Credential
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>Task of InlineResponse20019</returns>
        System.Threading.Tasks.Task<InlineResponse20019> CredentialsPostAsync (string accessToken = null, Credential body = null);

        /// <summary>
        /// Store Credential
        /// </summary>
        /// <remarks>
        /// Store Credential
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20019>> CredentialsPostAsyncWithHttpInfo (string accessToken = null, Credential body = null);
        
        /// <summary>
        /// Get Credential
        /// </summary>
        /// <remarks>
        /// Get Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20019</returns>
        InlineResponse20019 CredentialsIdGet (int? id, string attrKey, string accessToken = null);
  
        /// <summary>
        /// Get Credential
        /// </summary>
        /// <remarks>
        /// Get Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20019</returns>
        ApiResponse<InlineResponse20019> CredentialsIdGetWithHttpInfo (int? id, string attrKey, string accessToken = null);

        /// <summary>
        /// Get Credential
        /// </summary>
        /// <remarks>
        /// Get Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20019</returns>
        System.Threading.Tasks.Task<InlineResponse20019> CredentialsIdGetAsync (int? id, string attrKey, string accessToken = null);

        /// <summary>
        /// Get Credential
        /// </summary>
        /// <remarks>
        /// Get Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20019)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20019>> CredentialsIdGetAsyncWithHttpInfo (int? id, string attrKey, string accessToken = null);
        
        /// <summary>
        /// Update Credential
        /// </summary>
        /// <remarks>
        /// Update Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CredentialsIdPut (int? id, string attrKey, string accessToken = null, Credential body = null);
  
        /// <summary>
        /// Update Credential
        /// </summary>
        /// <remarks>
        /// Update Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> CredentialsIdPutWithHttpInfo (int? id, string attrKey, string accessToken = null, Credential body = null);

        /// <summary>
        /// Update Credential
        /// </summary>
        /// <remarks>
        /// Update Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CredentialsIdPutAsync (int? id, string attrKey, string accessToken = null, Credential body = null);

        /// <summary>
        /// Update Credential
        /// </summary>
        /// <remarks>
        /// Update Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CredentialsIdPutAsyncWithHttpInfo (int? id, string attrKey, string accessToken = null, Credential body = null);
        
        /// <summary>
        /// Delete Credential
        /// </summary>
        /// <remarks>
        /// Delete Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CredentialsIdDelete (int? id, string attrKey, string accessToken = null);
  
        /// <summary>
        /// Delete Credential
        /// </summary>
        /// <remarks>
        /// Delete Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> CredentialsIdDeleteWithHttpInfo (int? id, string attrKey, string accessToken = null);

        /// <summary>
        /// Delete Credential
        /// </summary>
        /// <remarks>
        /// Delete Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CredentialsIdDeleteAsync (int? id, string attrKey, string accessToken = null);

        /// <summary>
        /// Delete Credential
        /// </summary>
        /// <remarks>
        /// Delete Credential
        /// </remarks>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CredentialsIdDeleteAsyncWithHttpInfo (int? id, string attrKey, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CredentialApi : ICredentialApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CredentialApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CredentialApi(Configuration configuration = null)
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
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="userId">ID of user that owns this credential</param> 
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param> 
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param> 
        /// <param name="attrValue">Encrypted value for the attribute specified</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 CredentialsGet (string accessToken = null, int? userId = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2004> response = CredentialsGetWithHttpInfo(accessToken, userId, connectorId, attrKey, attrValue, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="userId">ID of user that owns this credential</param> 
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param> 
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param> 
        /// <param name="attrValue">Encrypted value for the attribute specified</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse2004</returns>
        public ApiResponse< InlineResponse2004 > CredentialsGetWithHttpInfo (string accessToken = null, int? userId = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/credentials";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (attrKey != null) queryParams.Add("attr_key", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            if (attrValue != null) queryParams.Add("attr_value", Configuration.ApiClient.ParameterToString(attrValue)); // query parameter
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2004>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2004) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2004)));
            
        }
    
        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this credential</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2004</returns>
        public async System.Threading.Tasks.Task<InlineResponse2004> CredentialsGetAsync (string accessToken = null, int? userId = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2004> response = await CredentialsGetAsyncWithHttpInfo(accessToken, userId, connectorId, attrKey, attrValue, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this credential</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> CredentialsGetAsyncWithHttpInfo (string accessToken = null, int? userId = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/credentials";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (attrKey != null) queryParams.Add("attr_key", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            if (attrValue != null) queryParams.Add("attr_value", Configuration.ApiClient.ParameterToString(attrValue)); // query parameter
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2004>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2004) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2004)));
            
        }
        
        /// <summary>
        /// Store Credential Store Credential
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Credential that should be stored</param> 
        /// <returns>InlineResponse20019</returns>
        public InlineResponse20019 CredentialsPost (string accessToken = null, Credential body = null)
        {
             ApiResponse<InlineResponse20019> response = CredentialsPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store Credential Store Credential
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Credential that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20019</returns>
        public ApiResponse< InlineResponse20019 > CredentialsPostWithHttpInfo (string accessToken = null, Credential body = null)
        {
            
    
            var path_ = "/credentials";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20019>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20019) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20019)));
            
        }
    
        /// <summary>
        /// Store Credential Store Credential
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>Task of InlineResponse20019</returns>
        public async System.Threading.Tasks.Task<InlineResponse20019> CredentialsPostAsync (string accessToken = null, Credential body = null)
        {
             ApiResponse<InlineResponse20019> response = await CredentialsPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store Credential Store Credential
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20019>> CredentialsPostAsyncWithHttpInfo (string accessToken = null, Credential body = null)
        {
            
    
            var path_ = "/credentials";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20019>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20019) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20019)));
            
        }
        
        /// <summary>
        /// Get Credential Get Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20019</returns>
        public InlineResponse20019 CredentialsIdGet (int? id, string attrKey, string accessToken = null)
        {
             ApiResponse<InlineResponse20019> response = CredentialsIdGetWithHttpInfo(id, attrKey, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get Credential Get Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20019</returns>
        public ApiResponse< InlineResponse20019 > CredentialsIdGetWithHttpInfo (int? id, string attrKey, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CredentialApi->CredentialsIdGet");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null)
                throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialApi->CredentialsIdGet");
            
    
            var path_ = "/credentials/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (attrKey != null) queryParams.Add("attrKey", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20019>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20019) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20019)));
            
        }
    
        /// <summary>
        /// Get Credential Get Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20019</returns>
        public async System.Threading.Tasks.Task<InlineResponse20019> CredentialsIdGetAsync (int? id, string attrKey, string accessToken = null)
        {
             ApiResponse<InlineResponse20019> response = await CredentialsIdGetAsyncWithHttpInfo(id, attrKey, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get Credential Get Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20019)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20019>> CredentialsIdGetAsyncWithHttpInfo (int? id, string attrKey, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdGet");
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdGet");
            
    
            var path_ = "/credentials/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (attrKey != null) queryParams.Add("attrKey", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20019>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20019) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20019)));
            
        }
        
        /// <summary>
        /// Update Credential Update Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Credential that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 CredentialsIdPut (int? id, string attrKey, string accessToken = null, Credential body = null)
        {
             ApiResponse<InlineResponse2002> response = CredentialsIdPutWithHttpInfo(id, attrKey, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update Credential Update Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Credential that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > CredentialsIdPutWithHttpInfo (int? id, string attrKey, string accessToken = null, Credential body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CredentialApi->CredentialsIdPut");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null)
                throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialApi->CredentialsIdPut");
            
    
            var path_ = "/credentials/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (attrKey != null) queryParams.Add("attrKey", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update Credential Update Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CredentialsIdPutAsync (int? id, string attrKey, string accessToken = null, Credential body = null)
        {
             ApiResponse<InlineResponse2002> response = await CredentialsIdPutAsyncWithHttpInfo(id, attrKey, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update Credential Update Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CredentialsIdPutAsyncWithHttpInfo (int? id, string attrKey, string accessToken = null, Credential body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdPut");
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdPut");
            
    
            var path_ = "/credentials/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (attrKey != null) queryParams.Add("attrKey", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete Credential Delete Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 CredentialsIdDelete (int? id, string attrKey, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = CredentialsIdDeleteWithHttpInfo(id, attrKey, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete Credential Delete Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > CredentialsIdDeleteWithHttpInfo (int? id, string attrKey, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CredentialApi->CredentialsIdDelete");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null)
                throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialApi->CredentialsIdDelete");
            
    
            var path_ = "/credentials/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (attrKey != null) queryParams.Add("attrKey", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            

            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete Credential Delete Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CredentialsIdDeleteAsync (int? id, string attrKey, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await CredentialsIdDeleteAsyncWithHttpInfo(id, attrKey, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete Credential Delete Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> CredentialsIdDeleteAsyncWithHttpInfo (int? id, string attrKey, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdDelete");
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdDelete");
            
    
            var path_ = "/credentials/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (attrKey != null) queryParams.Add("attrKey", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CredentialsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CredentialsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
