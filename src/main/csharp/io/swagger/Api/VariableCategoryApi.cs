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
    public interface IVariableCategoryApi
    {
        
        /// <summary>
        /// Get all VariableCategories
        /// </summary>
        /// <remarks>
        /// The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="name">Name of the category</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param>
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="updated">updated</param>
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param>
        /// <param name="_public">Is category public</param>
        /// <param name="outcome">outcome</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="defaultUnitId">ID of the default unit for the category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20031</returns>
        InlineResponse20031 VariableCategoriesGet (string accessToken = null, string name = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? durationOfAction = null, int? onsetDelay = null, string combinationOperation = null, int? updated = null, bool? causeOnly = null, int? _public = null, bool? outcome = null, string createdAt = null, string updatedAt = null, string imageUrl = null, int? defaultUnitId = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all VariableCategories
        /// </summary>
        /// <remarks>
        /// The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="name">Name of the category</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param>
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="updated">updated</param>
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param>
        /// <param name="_public">Is category public</param>
        /// <param name="outcome">outcome</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="defaultUnitId">ID of the default unit for the category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20031</returns>
        ApiResponse<InlineResponse20031> VariableCategoriesGetWithHttpInfo (string accessToken = null, string name = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? durationOfAction = null, int? onsetDelay = null, string combinationOperation = null, int? updated = null, bool? causeOnly = null, int? _public = null, bool? outcome = null, string createdAt = null, string updatedAt = null, string imageUrl = null, int? defaultUnitId = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all VariableCategories
        /// </summary>
        /// <remarks>
        /// The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="name">Name of the category</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param>
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="updated">updated</param>
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param>
        /// <param name="_public">Is category public</param>
        /// <param name="outcome">outcome</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="defaultUnitId">ID of the default unit for the category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20031</returns>
        System.Threading.Tasks.Task<InlineResponse20031> VariableCategoriesGetAsync (string accessToken = null, string name = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? durationOfAction = null, int? onsetDelay = null, string combinationOperation = null, int? updated = null, bool? causeOnly = null, int? _public = null, bool? outcome = null, string createdAt = null, string updatedAt = null, string imageUrl = null, int? defaultUnitId = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all VariableCategories
        /// </summary>
        /// <remarks>
        /// The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="name">Name of the category</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param>
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="updated">updated</param>
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param>
        /// <param name="_public">Is category public</param>
        /// <param name="outcome">outcome</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="defaultUnitId">ID of the default unit for the category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20031)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20031>> VariableCategoriesGetAsyncWithHttpInfo (string accessToken = null, string name = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? durationOfAction = null, int? onsetDelay = null, string combinationOperation = null, int? updated = null, bool? causeOnly = null, int? _public = null, bool? outcome = null, string createdAt = null, string updatedAt = null, string imageUrl = null, int? defaultUnitId = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store VariableCategory
        /// </summary>
        /// <remarks>
        /// Store VariableCategory
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be stored</param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 VariableCategoriesPost (string accessToken = null, VariableCategory body = null);
  
        /// <summary>
        /// Store VariableCategory
        /// </summary>
        /// <remarks>
        /// Store VariableCategory
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20032</returns>
        ApiResponse<InlineResponse20032> VariableCategoriesPostWithHttpInfo (string accessToken = null, VariableCategory body = null);

        /// <summary>
        /// Store VariableCategory
        /// </summary>
        /// <remarks>
        /// Store VariableCategory
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be stored</param>
        /// <returns>Task of InlineResponse20032</returns>
        System.Threading.Tasks.Task<InlineResponse20032> VariableCategoriesPostAsync (string accessToken = null, VariableCategory body = null);

        /// <summary>
        /// Store VariableCategory
        /// </summary>
        /// <remarks>
        /// Store VariableCategory
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20032)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20032>> VariableCategoriesPostAsyncWithHttpInfo (string accessToken = null, VariableCategory body = null);
        
        /// <summary>
        /// Get VariableCategory
        /// </summary>
        /// <remarks>
        /// Get VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 VariableCategoriesIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get VariableCategory
        /// </summary>
        /// <remarks>
        /// Get VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20032</returns>
        ApiResponse<InlineResponse20032> VariableCategoriesIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get VariableCategory
        /// </summary>
        /// <remarks>
        /// Get VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20032</returns>
        System.Threading.Tasks.Task<InlineResponse20032> VariableCategoriesIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get VariableCategory
        /// </summary>
        /// <remarks>
        /// Get VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20032)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20032>> VariableCategoriesIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update VariableCategory
        /// </summary>
        /// <remarks>
        /// Update VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableCategoriesIdPut (int? id, string accessToken = null, VariableCategory body = null);
  
        /// <summary>
        /// Update VariableCategory
        /// </summary>
        /// <remarks>
        /// Update VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> VariableCategoriesIdPutWithHttpInfo (int? id, string accessToken = null, VariableCategory body = null);

        /// <summary>
        /// Update VariableCategory
        /// </summary>
        /// <remarks>
        /// Update VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariableCategoriesIdPutAsync (int? id, string accessToken = null, VariableCategory body = null);

        /// <summary>
        /// Update VariableCategory
        /// </summary>
        /// <remarks>
        /// Update VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariableCategoriesIdPutAsyncWithHttpInfo (int? id, string accessToken = null, VariableCategory body = null);
        
        /// <summary>
        /// Delete VariableCategory
        /// </summary>
        /// <remarks>
        /// Delete VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableCategoriesIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete VariableCategory
        /// </summary>
        /// <remarks>
        /// Delete VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> VariableCategoriesIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete VariableCategory
        /// </summary>
        /// <remarks>
        /// Delete VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariableCategoriesIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete VariableCategory
        /// </summary>
        /// <remarks>
        /// Delete VariableCategory
        /// </remarks>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariableCategoriesIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariableCategoryApi : IVariableCategoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableCategoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariableCategoryApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableCategoryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VariableCategoryApi(Configuration configuration = null)
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
        /// Get all VariableCategories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="name">Name of the category</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param> 
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param> 
        /// <param name="updated">updated</param> 
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="_public">Is category public</param> 
        /// <param name="outcome">outcome</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="imageUrl">Image URL</param> 
        /// <param name="defaultUnitId">ID of the default unit for the category</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20031</returns>
        public InlineResponse20031 VariableCategoriesGet (string accessToken = null, string name = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? durationOfAction = null, int? onsetDelay = null, string combinationOperation = null, int? updated = null, bool? causeOnly = null, int? _public = null, bool? outcome = null, string createdAt = null, string updatedAt = null, string imageUrl = null, int? defaultUnitId = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20031> response = VariableCategoriesGetWithHttpInfo(accessToken, name, fillingValue, maximumAllowedValue, minimumAllowedValue, durationOfAction, onsetDelay, combinationOperation, updated, causeOnly, _public, outcome, createdAt, updatedAt, imageUrl, defaultUnitId, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all VariableCategories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="name">Name of the category</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param> 
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param> 
        /// <param name="updated">updated</param> 
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="_public">Is category public</param> 
        /// <param name="outcome">outcome</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="imageUrl">Image URL</param> 
        /// <param name="defaultUnitId">ID of the default unit for the category</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20031</returns>
        public ApiResponse< InlineResponse20031 > VariableCategoriesGetWithHttpInfo (string accessToken = null, string name = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? durationOfAction = null, int? onsetDelay = null, string combinationOperation = null, int? updated = null, bool? causeOnly = null, int? _public = null, bool? outcome = null, string createdAt = null, string updatedAt = null, string imageUrl = null, int? defaultUnitId = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/variableCategories";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", Configuration.ApiClient.ParameterToString(fillingValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", Configuration.ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", Configuration.ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (combinationOperation != null) queryParams.Add("combination_operation", Configuration.ApiClient.ParameterToString(combinationOperation)); // query parameter
            if (updated != null) queryParams.Add("updated", Configuration.ApiClient.ParameterToString(updated)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", Configuration.ApiClient.ParameterToString(causeOnly)); // query parameter
            if (_public != null) queryParams.Add("public", Configuration.ApiClient.ParameterToString(_public)); // query parameter
            if (outcome != null) queryParams.Add("outcome", Configuration.ApiClient.ParameterToString(outcome)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (imageUrl != null) queryParams.Add("image_url", Configuration.ApiClient.ParameterToString(imageUrl)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20031>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20031) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20031)));
            
        }
    
        /// <summary>
        /// Get all VariableCategories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="name">Name of the category</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param>
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="updated">updated</param>
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param>
        /// <param name="_public">Is category public</param>
        /// <param name="outcome">outcome</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="defaultUnitId">ID of the default unit for the category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20031</returns>
        public async System.Threading.Tasks.Task<InlineResponse20031> VariableCategoriesGetAsync (string accessToken = null, string name = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? durationOfAction = null, int? onsetDelay = null, string combinationOperation = null, int? updated = null, bool? causeOnly = null, int? _public = null, bool? outcome = null, string createdAt = null, string updatedAt = null, string imageUrl = null, int? defaultUnitId = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20031> response = await VariableCategoriesGetAsyncWithHttpInfo(accessToken, name, fillingValue, maximumAllowedValue, minimumAllowedValue, durationOfAction, onsetDelay, combinationOperation, updated, causeOnly, _public, outcome, createdAt, updatedAt, imageUrl, defaultUnitId, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all VariableCategories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="name">Name of the category</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param>
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="updated">updated</param>
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param>
        /// <param name="_public">Is category public</param>
        /// <param name="outcome">outcome</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="defaultUnitId">ID of the default unit for the category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20031)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20031>> VariableCategoriesGetAsyncWithHttpInfo (string accessToken = null, string name = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? durationOfAction = null, int? onsetDelay = null, string combinationOperation = null, int? updated = null, bool? causeOnly = null, int? _public = null, bool? outcome = null, string createdAt = null, string updatedAt = null, string imageUrl = null, int? defaultUnitId = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/variableCategories";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", Configuration.ApiClient.ParameterToString(fillingValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", Configuration.ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", Configuration.ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (combinationOperation != null) queryParams.Add("combination_operation", Configuration.ApiClient.ParameterToString(combinationOperation)); // query parameter
            if (updated != null) queryParams.Add("updated", Configuration.ApiClient.ParameterToString(updated)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", Configuration.ApiClient.ParameterToString(causeOnly)); // query parameter
            if (_public != null) queryParams.Add("public", Configuration.ApiClient.ParameterToString(_public)); // query parameter
            if (outcome != null) queryParams.Add("outcome", Configuration.ApiClient.ParameterToString(outcome)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (imageUrl != null) queryParams.Add("image_url", Configuration.ApiClient.ParameterToString(imageUrl)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20031>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20031) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20031)));
            
        }
        
        /// <summary>
        /// Store VariableCategory Store VariableCategory
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableCategory that should be stored</param> 
        /// <returns>InlineResponse20032</returns>
        public InlineResponse20032 VariableCategoriesPost (string accessToken = null, VariableCategory body = null)
        {
             ApiResponse<InlineResponse20032> response = VariableCategoriesPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store VariableCategory Store VariableCategory
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableCategory that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20032</returns>
        public ApiResponse< InlineResponse20032 > VariableCategoriesPostWithHttpInfo (string accessToken = null, VariableCategory body = null)
        {
            
    
            var path_ = "/variableCategories";
    
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20032>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20032) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20032)));
            
        }
    
        /// <summary>
        /// Store VariableCategory Store VariableCategory
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be stored</param>
        /// <returns>Task of InlineResponse20032</returns>
        public async System.Threading.Tasks.Task<InlineResponse20032> VariableCategoriesPostAsync (string accessToken = null, VariableCategory body = null)
        {
             ApiResponse<InlineResponse20032> response = await VariableCategoriesPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store VariableCategory Store VariableCategory
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20032)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20032>> VariableCategoriesPostAsyncWithHttpInfo (string accessToken = null, VariableCategory body = null)
        {
            
    
            var path_ = "/variableCategories";
    
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20032>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20032) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20032)));
            
        }
        
        /// <summary>
        /// Get VariableCategory Get VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20032</returns>
        public InlineResponse20032 VariableCategoriesIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20032> response = VariableCategoriesIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get VariableCategory Get VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20032</returns>
        public ApiResponse< InlineResponse20032 > VariableCategoriesIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoryApi->VariableCategoriesIdGet");
            
    
            var path_ = "/variableCategories/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20032>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20032) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20032)));
            
        }
    
        /// <summary>
        /// Get VariableCategory Get VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20032</returns>
        public async System.Threading.Tasks.Task<InlineResponse20032> VariableCategoriesIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20032> response = await VariableCategoriesIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get VariableCategory Get VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20032)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20032>> VariableCategoriesIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdGet");
            
    
            var path_ = "/variableCategories/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20032>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20032) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20032)));
            
        }
        
        /// <summary>
        /// Update VariableCategory Update VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableCategory that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 VariableCategoriesIdPut (int? id, string accessToken = null, VariableCategory body = null)
        {
             ApiResponse<InlineResponse2002> response = VariableCategoriesIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update VariableCategory Update VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableCategory that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > VariableCategoriesIdPutWithHttpInfo (int? id, string accessToken = null, VariableCategory body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoryApi->VariableCategoriesIdPut");
            
    
            var path_ = "/variableCategories/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update VariableCategory Update VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariableCategoriesIdPutAsync (int? id, string accessToken = null, VariableCategory body = null)
        {
             ApiResponse<InlineResponse2002> response = await VariableCategoriesIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update VariableCategory Update VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariableCategoriesIdPutAsyncWithHttpInfo (int? id, string accessToken = null, VariableCategory body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdPut");
            
    
            var path_ = "/variableCategories/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete VariableCategory Delete VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 VariableCategoriesIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = VariableCategoriesIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete VariableCategory Delete VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > VariableCategoriesIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoryApi->VariableCategoriesIdDelete");
            
    
            var path_ = "/variableCategories/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete VariableCategory Delete VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariableCategoriesIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await VariableCategoriesIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete VariableCategory Delete VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariableCategoriesIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdDelete");
            
    
            var path_ = "/variableCategories/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariableCategoriesIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
