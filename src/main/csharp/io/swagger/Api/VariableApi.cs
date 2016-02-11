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
    public interface IVariableApi
    {
        
        /// <summary>
        /// Get all Variables
        /// </summary>
        /// <remarks>
        /// Get all Variables
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="name">User-defined variable display name</param>
        /// <param name="variableCategoryId">Variable category ID</param>
        /// <param name="defaultUnitId">ID of the default unit for the variable</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="mostCommonUnitId">Most common Unit</param>
        /// <param name="standardDeviation">Standard Deviation</param>
        /// <param name="variance">Average variance for this variable based on all user data</param>
        /// <param name="mean">Mean for this variable based on all user data</param>
        /// <param name="median">Median for this variable based on all user data</param>
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param>
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param>
        /// <param name="skewness">Skewness for this variable based on all user data</param>
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="productUrl">Product URL</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="price">Price</param>
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20034</returns>
        InlineResponse20034 VariablesGet (string accessToken = null, int? id = null, string clientId = null, int? parentId = null, string name = null, int? variableCategoryId = null, int? defaultUnitId = null, string combinationOperation = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? onsetDelay = null, int? durationOfAction = null, int? _public = null, bool? causeOnly = null, double? mostCommonValue = null, int? mostCommonUnitId = null, double? standardDeviation = null, double? variance = null, double? mean = null, double? median = null, double? numberOfMeasurements = null, double? numberOfUniqueValues = null, double? skewness = null, double? kurtosis = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, string createdAt = null, string updatedAt = null, string productUrl = null, string imageUrl = null, double? price = null, int? numberOfUserVariables = null, bool? outcome = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all Variables
        /// </summary>
        /// <remarks>
        /// Get all Variables
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="name">User-defined variable display name</param>
        /// <param name="variableCategoryId">Variable category ID</param>
        /// <param name="defaultUnitId">ID of the default unit for the variable</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="mostCommonUnitId">Most common Unit</param>
        /// <param name="standardDeviation">Standard Deviation</param>
        /// <param name="variance">Average variance for this variable based on all user data</param>
        /// <param name="mean">Mean for this variable based on all user data</param>
        /// <param name="median">Median for this variable based on all user data</param>
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param>
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param>
        /// <param name="skewness">Skewness for this variable based on all user data</param>
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="productUrl">Product URL</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="price">Price</param>
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20034</returns>
        ApiResponse<InlineResponse20034> VariablesGetWithHttpInfo (string accessToken = null, int? id = null, string clientId = null, int? parentId = null, string name = null, int? variableCategoryId = null, int? defaultUnitId = null, string combinationOperation = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? onsetDelay = null, int? durationOfAction = null, int? _public = null, bool? causeOnly = null, double? mostCommonValue = null, int? mostCommonUnitId = null, double? standardDeviation = null, double? variance = null, double? mean = null, double? median = null, double? numberOfMeasurements = null, double? numberOfUniqueValues = null, double? skewness = null, double? kurtosis = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, string createdAt = null, string updatedAt = null, string productUrl = null, string imageUrl = null, double? price = null, int? numberOfUserVariables = null, bool? outcome = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Variables
        /// </summary>
        /// <remarks>
        /// Get all Variables
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="name">User-defined variable display name</param>
        /// <param name="variableCategoryId">Variable category ID</param>
        /// <param name="defaultUnitId">ID of the default unit for the variable</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="mostCommonUnitId">Most common Unit</param>
        /// <param name="standardDeviation">Standard Deviation</param>
        /// <param name="variance">Average variance for this variable based on all user data</param>
        /// <param name="mean">Mean for this variable based on all user data</param>
        /// <param name="median">Median for this variable based on all user data</param>
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param>
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param>
        /// <param name="skewness">Skewness for this variable based on all user data</param>
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="productUrl">Product URL</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="price">Price</param>
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20034</returns>
        System.Threading.Tasks.Task<InlineResponse20034> VariablesGetAsync (string accessToken = null, int? id = null, string clientId = null, int? parentId = null, string name = null, int? variableCategoryId = null, int? defaultUnitId = null, string combinationOperation = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? onsetDelay = null, int? durationOfAction = null, int? _public = null, bool? causeOnly = null, double? mostCommonValue = null, int? mostCommonUnitId = null, double? standardDeviation = null, double? variance = null, double? mean = null, double? median = null, double? numberOfMeasurements = null, double? numberOfUniqueValues = null, double? skewness = null, double? kurtosis = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, string createdAt = null, string updatedAt = null, string productUrl = null, string imageUrl = null, double? price = null, int? numberOfUserVariables = null, bool? outcome = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Variables
        /// </summary>
        /// <remarks>
        /// Get all Variables
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="name">User-defined variable display name</param>
        /// <param name="variableCategoryId">Variable category ID</param>
        /// <param name="defaultUnitId">ID of the default unit for the variable</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="mostCommonUnitId">Most common Unit</param>
        /// <param name="standardDeviation">Standard Deviation</param>
        /// <param name="variance">Average variance for this variable based on all user data</param>
        /// <param name="mean">Mean for this variable based on all user data</param>
        /// <param name="median">Median for this variable based on all user data</param>
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param>
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param>
        /// <param name="skewness">Skewness for this variable based on all user data</param>
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="productUrl">Product URL</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="price">Price</param>
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20034)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20034>> VariablesGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string clientId = null, int? parentId = null, string name = null, int? variableCategoryId = null, int? defaultUnitId = null, string combinationOperation = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? onsetDelay = null, int? durationOfAction = null, int? _public = null, bool? causeOnly = null, double? mostCommonValue = null, int? mostCommonUnitId = null, double? standardDeviation = null, double? variance = null, double? mean = null, double? median = null, double? numberOfMeasurements = null, double? numberOfUniqueValues = null, double? skewness = null, double? kurtosis = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, string createdAt = null, string updatedAt = null, string productUrl = null, string imageUrl = null, double? price = null, int? numberOfUserVariables = null, bool? outcome = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store Variable
        /// </summary>
        /// <remarks>
        /// Allows the client to create a new variable in the `variables` table.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>InlineResponse20035</returns>
        InlineResponse20035 VariablesPost (string accessToken = null, Variable body = null);
  
        /// <summary>
        /// Store Variable
        /// </summary>
        /// <remarks>
        /// Allows the client to create a new variable in the `variables` table.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20035</returns>
        ApiResponse<InlineResponse20035> VariablesPostWithHttpInfo (string accessToken = null, Variable body = null);

        /// <summary>
        /// Store Variable
        /// </summary>
        /// <remarks>
        /// Allows the client to create a new variable in the `variables` table.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>Task of InlineResponse20035</returns>
        System.Threading.Tasks.Task<InlineResponse20035> VariablesPostAsync (string accessToken = null, Variable body = null);

        /// <summary>
        /// Store Variable
        /// </summary>
        /// <remarks>
        /// Allows the client to create a new variable in the `variables` table.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20035)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20035>> VariablesPostAsyncWithHttpInfo (string accessToken = null, Variable body = null);
        
        /// <summary>
        /// Get Variable
        /// </summary>
        /// <remarks>
        /// Get Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20035</returns>
        InlineResponse20035 VariablesIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get Variable
        /// </summary>
        /// <remarks>
        /// Get Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20035</returns>
        ApiResponse<InlineResponse20035> VariablesIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get Variable
        /// </summary>
        /// <remarks>
        /// Get Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20035</returns>
        System.Threading.Tasks.Task<InlineResponse20035> VariablesIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get Variable
        /// </summary>
        /// <remarks>
        /// Get Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20035)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20035>> VariablesIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update Variable
        /// </summary>
        /// <remarks>
        /// Update Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariablesIdPut (int? id, string accessToken = null, Variable body = null);
  
        /// <summary>
        /// Update Variable
        /// </summary>
        /// <remarks>
        /// Update Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> VariablesIdPutWithHttpInfo (int? id, string accessToken = null, Variable body = null);

        /// <summary>
        /// Update Variable
        /// </summary>
        /// <remarks>
        /// Update Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariablesIdPutAsync (int? id, string accessToken = null, Variable body = null);

        /// <summary>
        /// Update Variable
        /// </summary>
        /// <remarks>
        /// Update Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariablesIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Variable body = null);
        
        /// <summary>
        /// Delete Variable
        /// </summary>
        /// <remarks>
        /// Delete Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariablesIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete Variable
        /// </summary>
        /// <remarks>
        /// Delete Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> VariablesIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete Variable
        /// </summary>
        /// <remarks>
        /// Delete Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariablesIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete Variable
        /// </summary>
        /// <remarks>
        /// Delete Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariablesIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariableApi : IVariableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariableApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VariableApi(Configuration configuration = null)
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
        /// Get all Variables Get all Variables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="id">id</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="name">User-defined variable display name</param> 
        /// <param name="variableCategoryId">Variable category ID</param> 
        /// <param name="defaultUnitId">ID of the default unit for the variable</param> 
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param> 
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="_public">Is variable public</param> 
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="mostCommonValue">Most common value</param> 
        /// <param name="mostCommonUnitId">Most common Unit</param> 
        /// <param name="standardDeviation">Standard Deviation</param> 
        /// <param name="variance">Average variance for this variable based on all user data</param> 
        /// <param name="mean">Mean for this variable based on all user data</param> 
        /// <param name="median">Median for this variable based on all user data</param> 
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param> 
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param> 
        /// <param name="skewness">Skewness for this variable based on all user data</param> 
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="productUrl">Product URL</param> 
        /// <param name="imageUrl">Image URL</param> 
        /// <param name="price">Price</param> 
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param> 
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param> 
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param> 
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20034</returns>
        public InlineResponse20034 VariablesGet (string accessToken = null, int? id = null, string clientId = null, int? parentId = null, string name = null, int? variableCategoryId = null, int? defaultUnitId = null, string combinationOperation = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? onsetDelay = null, int? durationOfAction = null, int? _public = null, bool? causeOnly = null, double? mostCommonValue = null, int? mostCommonUnitId = null, double? standardDeviation = null, double? variance = null, double? mean = null, double? median = null, double? numberOfMeasurements = null, double? numberOfUniqueValues = null, double? skewness = null, double? kurtosis = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, string createdAt = null, string updatedAt = null, string productUrl = null, string imageUrl = null, double? price = null, int? numberOfUserVariables = null, bool? outcome = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20034> response = VariablesGetWithHttpInfo(accessToken, id, clientId, parentId, name, variableCategoryId, defaultUnitId, combinationOperation, fillingValue, maximumAllowedValue, minimumAllowedValue, onsetDelay, durationOfAction, _public, causeOnly, mostCommonValue, mostCommonUnitId, standardDeviation, variance, mean, median, numberOfMeasurements, numberOfUniqueValues, skewness, kurtosis, status, errorMessage, lastSuccessfulUpdateTime, createdAt, updatedAt, productUrl, imageUrl, price, numberOfUserVariables, outcome, minimumRecordedValue, maximumRecordedValue, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all Variables Get all Variables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="id">id</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="name">User-defined variable display name</param> 
        /// <param name="variableCategoryId">Variable category ID</param> 
        /// <param name="defaultUnitId">ID of the default unit for the variable</param> 
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param> 
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="_public">Is variable public</param> 
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="mostCommonValue">Most common value</param> 
        /// <param name="mostCommonUnitId">Most common Unit</param> 
        /// <param name="standardDeviation">Standard Deviation</param> 
        /// <param name="variance">Average variance for this variable based on all user data</param> 
        /// <param name="mean">Mean for this variable based on all user data</param> 
        /// <param name="median">Median for this variable based on all user data</param> 
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param> 
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param> 
        /// <param name="skewness">Skewness for this variable based on all user data</param> 
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="productUrl">Product URL</param> 
        /// <param name="imageUrl">Image URL</param> 
        /// <param name="price">Price</param> 
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param> 
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param> 
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param> 
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20034</returns>
        public ApiResponse< InlineResponse20034 > VariablesGetWithHttpInfo (string accessToken = null, int? id = null, string clientId = null, int? parentId = null, string name = null, int? variableCategoryId = null, int? defaultUnitId = null, string combinationOperation = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? onsetDelay = null, int? durationOfAction = null, int? _public = null, bool? causeOnly = null, double? mostCommonValue = null, int? mostCommonUnitId = null, double? standardDeviation = null, double? variance = null, double? mean = null, double? median = null, double? numberOfMeasurements = null, double? numberOfUniqueValues = null, double? skewness = null, double? kurtosis = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, string createdAt = null, string updatedAt = null, string productUrl = null, string imageUrl = null, double? price = null, int? numberOfUserVariables = null, bool? outcome = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/variables";
    
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
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (parentId != null) queryParams.Add("parent_id", Configuration.ApiClient.ParameterToString(parentId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (variableCategoryId != null) queryParams.Add("variable_category_id", Configuration.ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (combinationOperation != null) queryParams.Add("combination_operation", Configuration.ApiClient.ParameterToString(combinationOperation)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", Configuration.ApiClient.ParameterToString(fillingValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", Configuration.ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", Configuration.ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (_public != null) queryParams.Add("public", Configuration.ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", Configuration.ApiClient.ParameterToString(causeOnly)); // query parameter
            if (mostCommonValue != null) queryParams.Add("most_common_value", Configuration.ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", Configuration.ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (standardDeviation != null) queryParams.Add("standard_deviation", Configuration.ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) queryParams.Add("variance", Configuration.ApiClient.ParameterToString(variance)); // query parameter
            if (mean != null) queryParams.Add("mean", Configuration.ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) queryParams.Add("median", Configuration.ApiClient.ParameterToString(median)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfUniqueValues != null) queryParams.Add("number_of_unique_values", Configuration.ApiClient.ParameterToString(numberOfUniqueValues)); // query parameter
            if (skewness != null) queryParams.Add("skewness", Configuration.ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) queryParams.Add("kurtosis", Configuration.ApiClient.ParameterToString(kurtosis)); // query parameter
            if (status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (productUrl != null) queryParams.Add("product_url", Configuration.ApiClient.ParameterToString(productUrl)); // query parameter
            if (imageUrl != null) queryParams.Add("image_url", Configuration.ApiClient.ParameterToString(imageUrl)); // query parameter
            if (price != null) queryParams.Add("price", Configuration.ApiClient.ParameterToString(price)); // query parameter
            if (numberOfUserVariables != null) queryParams.Add("number_of_user_variables", Configuration.ApiClient.ParameterToString(numberOfUserVariables)); // query parameter
            if (outcome != null) queryParams.Add("outcome", Configuration.ApiClient.ParameterToString(outcome)); // query parameter
            if (minimumRecordedValue != null) queryParams.Add("minimum_recorded_value", Configuration.ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
            if (maximumRecordedValue != null) queryParams.Add("maximum_recorded_value", Configuration.ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
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
                throw new ApiException (statusCode, "Error calling VariablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20034>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20034) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20034)));
            
        }
    
        /// <summary>
        /// Get all Variables Get all Variables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="name">User-defined variable display name</param>
        /// <param name="variableCategoryId">Variable category ID</param>
        /// <param name="defaultUnitId">ID of the default unit for the variable</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="mostCommonUnitId">Most common Unit</param>
        /// <param name="standardDeviation">Standard Deviation</param>
        /// <param name="variance">Average variance for this variable based on all user data</param>
        /// <param name="mean">Mean for this variable based on all user data</param>
        /// <param name="median">Median for this variable based on all user data</param>
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param>
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param>
        /// <param name="skewness">Skewness for this variable based on all user data</param>
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="productUrl">Product URL</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="price">Price</param>
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20034</returns>
        public async System.Threading.Tasks.Task<InlineResponse20034> VariablesGetAsync (string accessToken = null, int? id = null, string clientId = null, int? parentId = null, string name = null, int? variableCategoryId = null, int? defaultUnitId = null, string combinationOperation = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? onsetDelay = null, int? durationOfAction = null, int? _public = null, bool? causeOnly = null, double? mostCommonValue = null, int? mostCommonUnitId = null, double? standardDeviation = null, double? variance = null, double? mean = null, double? median = null, double? numberOfMeasurements = null, double? numberOfUniqueValues = null, double? skewness = null, double? kurtosis = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, string createdAt = null, string updatedAt = null, string productUrl = null, string imageUrl = null, double? price = null, int? numberOfUserVariables = null, bool? outcome = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20034> response = await VariablesGetAsyncWithHttpInfo(accessToken, id, clientId, parentId, name, variableCategoryId, defaultUnitId, combinationOperation, fillingValue, maximumAllowedValue, minimumAllowedValue, onsetDelay, durationOfAction, _public, causeOnly, mostCommonValue, mostCommonUnitId, standardDeviation, variance, mean, median, numberOfMeasurements, numberOfUniqueValues, skewness, kurtosis, status, errorMessage, lastSuccessfulUpdateTime, createdAt, updatedAt, productUrl, imageUrl, price, numberOfUserVariables, outcome, minimumRecordedValue, maximumRecordedValue, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all Variables Get all Variables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="name">User-defined variable display name</param>
        /// <param name="variableCategoryId">Variable category ID</param>
        /// <param name="defaultUnitId">ID of the default unit for the variable</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="mostCommonUnitId">Most common Unit</param>
        /// <param name="standardDeviation">Standard Deviation</param>
        /// <param name="variance">Average variance for this variable based on all user data</param>
        /// <param name="mean">Mean for this variable based on all user data</param>
        /// <param name="median">Median for this variable based on all user data</param>
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param>
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param>
        /// <param name="skewness">Skewness for this variable based on all user data</param>
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="productUrl">Product URL</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="price">Price</param>
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20034)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20034>> VariablesGetAsyncWithHttpInfo (string accessToken = null, int? id = null, string clientId = null, int? parentId = null, string name = null, int? variableCategoryId = null, int? defaultUnitId = null, string combinationOperation = null, double? fillingValue = null, double? maximumAllowedValue = null, double? minimumAllowedValue = null, int? onsetDelay = null, int? durationOfAction = null, int? _public = null, bool? causeOnly = null, double? mostCommonValue = null, int? mostCommonUnitId = null, double? standardDeviation = null, double? variance = null, double? mean = null, double? median = null, double? numberOfMeasurements = null, double? numberOfUniqueValues = null, double? skewness = null, double? kurtosis = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, string createdAt = null, string updatedAt = null, string productUrl = null, string imageUrl = null, double? price = null, int? numberOfUserVariables = null, bool? outcome = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/variables";
    
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
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (parentId != null) queryParams.Add("parent_id", Configuration.ApiClient.ParameterToString(parentId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (variableCategoryId != null) queryParams.Add("variable_category_id", Configuration.ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (combinationOperation != null) queryParams.Add("combination_operation", Configuration.ApiClient.ParameterToString(combinationOperation)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", Configuration.ApiClient.ParameterToString(fillingValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", Configuration.ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", Configuration.ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (_public != null) queryParams.Add("public", Configuration.ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", Configuration.ApiClient.ParameterToString(causeOnly)); // query parameter
            if (mostCommonValue != null) queryParams.Add("most_common_value", Configuration.ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", Configuration.ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (standardDeviation != null) queryParams.Add("standard_deviation", Configuration.ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) queryParams.Add("variance", Configuration.ApiClient.ParameterToString(variance)); // query parameter
            if (mean != null) queryParams.Add("mean", Configuration.ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) queryParams.Add("median", Configuration.ApiClient.ParameterToString(median)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfUniqueValues != null) queryParams.Add("number_of_unique_values", Configuration.ApiClient.ParameterToString(numberOfUniqueValues)); // query parameter
            if (skewness != null) queryParams.Add("skewness", Configuration.ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) queryParams.Add("kurtosis", Configuration.ApiClient.ParameterToString(kurtosis)); // query parameter
            if (status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (productUrl != null) queryParams.Add("product_url", Configuration.ApiClient.ParameterToString(productUrl)); // query parameter
            if (imageUrl != null) queryParams.Add("image_url", Configuration.ApiClient.ParameterToString(imageUrl)); // query parameter
            if (price != null) queryParams.Add("price", Configuration.ApiClient.ParameterToString(price)); // query parameter
            if (numberOfUserVariables != null) queryParams.Add("number_of_user_variables", Configuration.ApiClient.ParameterToString(numberOfUserVariables)); // query parameter
            if (outcome != null) queryParams.Add("outcome", Configuration.ApiClient.ParameterToString(outcome)); // query parameter
            if (minimumRecordedValue != null) queryParams.Add("minimum_recorded_value", Configuration.ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
            if (maximumRecordedValue != null) queryParams.Add("maximum_recorded_value", Configuration.ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
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
                throw new ApiException (statusCode, "Error calling VariablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20034>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20034) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20034)));
            
        }
        
        /// <summary>
        /// Store Variable Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Variable that should be stored</param> 
        /// <returns>InlineResponse20035</returns>
        public InlineResponse20035 VariablesPost (string accessToken = null, Variable body = null)
        {
             ApiResponse<InlineResponse20035> response = VariablesPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store Variable Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Variable that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20035</returns>
        public ApiResponse< InlineResponse20035 > VariablesPostWithHttpInfo (string accessToken = null, Variable body = null)
        {
            
    
            var path_ = "/variables";
    
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
                throw new ApiException (statusCode, "Error calling VariablesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20035>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20035) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20035)));
            
        }
    
        /// <summary>
        /// Store Variable Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>Task of InlineResponse20035</returns>
        public async System.Threading.Tasks.Task<InlineResponse20035> VariablesPostAsync (string accessToken = null, Variable body = null)
        {
             ApiResponse<InlineResponse20035> response = await VariablesPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store Variable Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20035)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20035>> VariablesPostAsyncWithHttpInfo (string accessToken = null, Variable body = null)
        {
            
    
            var path_ = "/variables";
    
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
                throw new ApiException (statusCode, "Error calling VariablesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20035>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20035) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20035)));
            
        }
        
        /// <summary>
        /// Get Variable Get Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20035</returns>
        public InlineResponse20035 VariablesIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20035> response = VariablesIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get Variable Get Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20035</returns>
        public ApiResponse< InlineResponse20035 > VariablesIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VariableApi->VariablesIdGet");
            
    
            var path_ = "/variables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariablesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20035>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20035) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20035)));
            
        }
    
        /// <summary>
        /// Get Variable Get Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20035</returns>
        public async System.Threading.Tasks.Task<InlineResponse20035> VariablesIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20035> response = await VariablesIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get Variable Get Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20035)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20035>> VariablesIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdGet");
            
    
            var path_ = "/variables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariablesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20035>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20035) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20035)));
            
        }
        
        /// <summary>
        /// Update Variable Update Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Variable that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 VariablesIdPut (int? id, string accessToken = null, Variable body = null)
        {
             ApiResponse<InlineResponse2002> response = VariablesIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update Variable Update Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Variable that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > VariablesIdPutWithHttpInfo (int? id, string accessToken = null, Variable body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VariableApi->VariablesIdPut");
            
    
            var path_ = "/variables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariablesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update Variable Update Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariablesIdPutAsync (int? id, string accessToken = null, Variable body = null)
        {
             ApiResponse<InlineResponse2002> response = await VariablesIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update Variable Update Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariablesIdPutAsyncWithHttpInfo (int? id, string accessToken = null, Variable body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdPut");
            
    
            var path_ = "/variables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariablesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete Variable Delete Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 VariablesIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = VariablesIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete Variable Delete Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > VariablesIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VariableApi->VariablesIdDelete");
            
    
            var path_ = "/variables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariablesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete Variable Delete Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariablesIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await VariablesIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete Variable Delete Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> VariablesIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdDelete");
            
    
            var path_ = "/variables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling VariablesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling VariablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
