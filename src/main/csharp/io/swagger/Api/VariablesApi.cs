using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IVariablesApi
    {
        
        /// <summary>
        /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </summary>
        /// <returns>Variable</returns>
        Variable V1PublicVariablesGet ();
  
        /// <summary>
        /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </summary>
        /// <returns>Variable</returns>
        System.Threading.Tasks.Task<Variable> V1PublicVariablesGetAsync ();
        
        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="effectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Variable</returns>
        Variable V1PublicVariablesSearchSearchGet (string search, string effectOrCause, int? limit, int? offset, int? sort);
  
        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="effectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Variable</returns>
        System.Threading.Tasks.Task<Variable> V1PublicVariablesSearchSearchGetAsync (string search, string effectOrCause, int? limit, int? offset, int? sort);
        
        /// <summary>
        /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="sharingData">Variable user settings data</param>
        /// <returns></returns>
        void V1UserVariablesPost (UserVariables sharingData);
  
        /// <summary>
        /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="sharingData">Variable user settings data</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1UserVariablesPostAsync (UserVariables sharingData);
        
        /// <summary>
        /// Variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <returns>List<VariableCategory></returns>
        List<VariableCategory> V1VariableCategoriesGet ();
  
        /// <summary>
        /// Variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <returns>List<VariableCategory></returns>
        System.Threading.Tasks.Task<List<VariableCategory>> V1VariableCategoriesGetAsync ();
        
        /// <summary>
        /// Get variables by the category name Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="category">Filter data by category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Variable</returns>
        Variable V1VariablesGet (int? userId, string category, int? limit, int? offset, int? sort);
  
        /// <summary>
        /// Get variables by the category name Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="category">Filter data by category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Variable</returns>
        System.Threading.Tasks.Task<Variable> V1VariablesGetAsync (int? userId, string category, int? limit, int? offset, int? sort);
        
        /// <summary>
        /// Create Variables Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="variableName">Original name for the variable.</param>
        /// <returns></returns>
        void V1VariablesPost (VariablesNew variableName);
  
        /// <summary>
        /// Create Variables Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="variableName">Original name for the variable.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task V1VariablesPostAsync (VariablesNew variableName);
        
        /// <summary>
        /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </summary>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source.</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <returns>List<Variable></returns>
        List<Variable> V1VariablesSearchSearchGet (string search, string categoryName, string source, int? limit, int? offset);
  
        /// <summary>
        /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </summary>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source.</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <returns>List<Variable></returns>
        System.Threading.Tasks.Task<List<Variable>> V1VariablesSearchSearchGetAsync (string search, string categoryName, string source, int? limit, int? offset);
        
        /// <summary>
        /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </summary>
        /// <param name="variableName">Variable name</param>
        /// <returns>Variable</returns>
        Variable V1VariablesVariableNameGet (string variableName);
  
        /// <summary>
        /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </summary>
        /// <param name="variableName">Variable name</param>
        /// <returns>Variable</returns>
        System.Threading.Tasks.Task<Variable> V1VariablesVariableNameGetAsync (string variableName);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariablesApi : IVariablesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariablesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VariablesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariablesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariablesApi(String basePath)
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
        /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </summary>
        /// <returns>Variable</returns>            
        public Variable V1PublicVariablesGet ()
        {
            
    
            var path = "/v1/public/variables";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicVariablesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicVariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Variable) ApiClient.Deserialize(response.Content, typeof(Variable), response.Headers);
        }
    
        /// <summary>
        /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
        /// </summary>
        /// <returns>Variable</returns>
        public async System.Threading.Tasks.Task<Variable> V1PublicVariablesGetAsync ()
        {
            
    
            var path = "/v1/public/variables";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicVariablesGet: " + response.Content, response.Content);

            return (Variable) ApiClient.Deserialize(response.Content, typeof(Variable), response.Headers);
        }
        
        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="search">Search query can be some fraction of a variable name.</param> 
        /// <param name="effectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param> 
        /// <returns>Variable</returns>            
        public Variable V1PublicVariablesSearchSearchGet (string search, string effectOrCause, int? limit, int? offset, int? sort)
        {
            
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling V1PublicVariablesSearchSearchGet");
            
    
            var path = "/v1/public/variables/search/{search}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (search != null) pathParams.Add("search", ApiClient.ParameterToString(search)); // path parameter
            
            if (effectOrCause != null) queryParams.Add("effectOrCause", ApiClient.ParameterToString(effectOrCause)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicVariablesSearchSearchGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicVariablesSearchSearchGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Variable) ApiClient.Deserialize(response.Content, typeof(Variable), response.Headers);
        }
    
        /// <summary>
        /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;category&lt;/b&gt; - Category of Variable&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="search">Search query can be some fraction of a variable name.</param>
        /// <param name="effectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Variable</returns>
        public async System.Threading.Tasks.Task<Variable> V1PublicVariablesSearchSearchGetAsync (string search, string effectOrCause, int? limit, int? offset, int? sort)
        {
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling V1PublicVariablesSearchSearchGet");
            
    
            var path = "/v1/public/variables/search/{search}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (search != null) pathParams.Add("search", ApiClient.ParameterToString(search)); // path parameter
            
            if (effectOrCause != null) queryParams.Add("effectOrCause", ApiClient.ParameterToString(effectOrCause)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicVariablesSearchSearchGet: " + response.Content, response.Content);

            return (Variable) ApiClient.Deserialize(response.Content, typeof(Variable), response.Headers);
        }
        
        /// <summary>
        /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="sharingData">Variable user settings data</param> 
        /// <returns></returns>            
        public void V1UserVariablesPost (UserVariables sharingData)
        {
            
            // verify the required parameter 'sharingData' is set
            if (sharingData == null) throw new ApiException(400, "Missing required parameter 'sharingData' when calling V1UserVariablesPost");
            
    
            var path = "/v1/userVariables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(sharingData); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserVariablesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserVariablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="sharingData">Variable user settings data</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1UserVariablesPostAsync (UserVariables sharingData)
        {
            // verify the required parameter 'sharingData' is set
            if (sharingData == null) throw new ApiException(400, "Missing required parameter 'sharingData' when calling V1UserVariablesPost");
            
    
            var path = "/v1/userVariables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(sharingData); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserVariablesPost: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <returns>List<VariableCategory></returns>            
        public List<VariableCategory> V1VariableCategoriesGet ()
        {
            
    
            var path = "/v1/variableCategories";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariableCategoriesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariableCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<VariableCategory>) ApiClient.Deserialize(response.Content, typeof(List<VariableCategory>), response.Headers);
        }
    
        /// <summary>
        /// Variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <returns>List<VariableCategory></returns>
        public async System.Threading.Tasks.Task<List<VariableCategory>> V1VariableCategoriesGetAsync ()
        {
            
    
            var path = "/v1/variableCategories";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariableCategoriesGet: " + response.Content, response.Content);

            return (List<VariableCategory>) ApiClient.Deserialize(response.Content, typeof(List<VariableCategory>), response.Headers);
        }
        
        /// <summary>
        /// Get variables by the category name Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="userId">User id</param> 
        /// <param name="category">Filter data by category</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param> 
        /// <returns>Variable</returns>            
        public Variable V1VariablesGet (int? userId, string category, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/variables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (category != null) queryParams.Add("category", ApiClient.ParameterToString(category)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Variable) ApiClient.Deserialize(response.Content, typeof(Variable), response.Headers);
        }
    
        /// <summary>
        /// Get variables by the category name Get variables by the category name. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;name&lt;/b&gt; - Original name of the variable (supports exact name match only)&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - Filter by the last time any of the properties of the variable were changed. Uses UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;source&lt;/b&gt; - The name of the data source that created the variable (supports exact name match only). So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here&lt;/li&gt;&lt;li&gt;&lt;b&gt;latestMeasurementTime&lt;/b&gt; - Filter variables based on the last time a measurement for them was created or updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;li&gt;&lt;b&gt;numberOfMeasurements&lt;/b&gt; - Filter variables by the total number of measurements that they have. This could be used of you want to filter or sort by popularity.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastSource&lt;/b&gt; - Limit variables to those which measurements were last submitted by a specific source. So if you have a client application and you only want variables that were last updated by your app, you can include the name of your app here. (supports exact name match only)&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="category">Filter data by category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>Variable</returns>
        public async System.Threading.Tasks.Task<Variable> V1VariablesGetAsync (int? userId, string category, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/variables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (category != null) queryParams.Add("category", ApiClient.ParameterToString(category)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesGet: " + response.Content, response.Content);

            return (Variable) ApiClient.Deserialize(response.Content, typeof(Variable), response.Headers);
        }
        
        /// <summary>
        /// Create Variables Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="variableName">Original name for the variable.</param> 
        /// <returns></returns>            
        public void V1VariablesPost (VariablesNew variableName)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesPost");
            
    
            var path = "/v1/variables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(variableName); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create Variables Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="variableName">Original name for the variable.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task V1VariablesPostAsync (VariablesNew variableName)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesPost");
            
    
            var path = "/v1/variables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(variableName); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesPost: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </summary>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param> 
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param> 
        /// <param name="source">Specify a data source name to only return variables from a specific data source.</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <returns>List<Variable></returns>            
        public List<Variable> V1VariablesSearchSearchGet (string search, string categoryName, string source, int? limit, int? offset)
        {
            
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling V1VariablesSearchSearchGet");
            
    
            var path = "/v1/variables/search/{search}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (search != null) pathParams.Add("search", ApiClient.ParameterToString(search)); // path parameter
            
            if (categoryName != null) queryParams.Add("categoryName", ApiClient.ParameterToString(categoryName)); // query parameter
            if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesSearchSearchGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesSearchSearchGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Variable>) ApiClient.Deserialize(response.Content, typeof(List<Variable>), response.Headers);
        }
    
        /// <summary>
        /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
        /// </summary>
        /// <param name="search">Search query which may be an entire variable name or a fragment of one.</param>
        /// <param name="categoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param>
        /// <param name="source">Specify a data source name to only return variables from a specific data source.</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <returns>List<Variable></returns>
        public async System.Threading.Tasks.Task<List<Variable>> V1VariablesSearchSearchGetAsync (string search, string categoryName, string source, int? limit, int? offset)
        {
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling V1VariablesSearchSearchGet");
            
    
            var path = "/v1/variables/search/{search}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (search != null) pathParams.Add("search", ApiClient.ParameterToString(search)); // path parameter
            
            if (categoryName != null) queryParams.Add("categoryName", ApiClient.ParameterToString(categoryName)); // query parameter
            if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesSearchSearchGet: " + response.Content, response.Content);

            return (List<Variable>) ApiClient.Deserialize(response.Content, typeof(List<Variable>), response.Headers);
        }
        
        /// <summary>
        /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </summary>
        /// <param name="variableName">Variable name</param> 
        /// <returns>Variable</returns>            
        public Variable V1VariablesVariableNameGet (string variableName)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNameGet");
            
    
            var path = "/v1/variables/{variableName}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Variable) ApiClient.Deserialize(response.Content, typeof(Variable), response.Headers);
        }
    
        /// <summary>
        /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
        /// </summary>
        /// <param name="variableName">Variable name</param>
        /// <returns>Variable</returns>
        public async System.Threading.Tasks.Task<Variable> V1VariablesVariableNameGetAsync (string variableName)
        {
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNameGet");
            
    
            var path = "/v1/variables/{variableName}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (variableName != null) pathParams.Add("variableName", ApiClient.ParameterToString(variableName)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameGet: " + response.Content, response.Content);

            return (Variable) ApiClient.Deserialize(response.Content, typeof(Variable), response.Headers);
        }
        
    }
    
}
