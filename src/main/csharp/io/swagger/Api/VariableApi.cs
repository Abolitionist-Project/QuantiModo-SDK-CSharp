using System;
using System.IO;
using System.Collections.Generic;
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
        /// <param name="id">id</param>
        /// <param name="clientId">client_id</param>
        /// <param name="parentId">parent_id</param>
        /// <param name="name">name</param>
        /// <param name="variableCategoryId">variable_category_id</param>
        /// <param name="defaultUnitId">default_unit_id</param>
        /// <param name="combinationOperation">combination_operation</param>
        /// <param name="fillingValue">filling_value</param>
        /// <param name="maximumAllowedValue">maximum_allowed_value</param>
        /// <param name="minimumAllowedValue">minimum_allowed_value</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="_public">public</param>
        /// <param name="causeOnly">cause_only</param>
        /// <param name="mostCommonValue">most_common_value</param>
        /// <param name="mostCommonUnitId">most_common_unit_id</param>
        /// <param name="standardDeviation">standard_deviation</param>
        /// <param name="variance">variance</param>
        /// <param name="mean">mean</param>
        /// <param name="median">median</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="numberOfUniqueValues">number_of_unique_values</param>
        /// <param name="skewness">skewness</param>
        /// <param name="kurtosis">kurtosis</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="productUrl">product_url</param>
        /// <param name="imageUrl">image_url</param>
        /// <param name="price">price</param>
        /// <param name="numberOfUserVariables">number_of_user_variables</param>
        /// <param name="outcome">outcome</param>
        /// <param name="minimumRecordedValue">minimum_recorded_value</param>
        /// <param name="maximumRecordedValue">maximum_recorded_value</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 VariablesGet (int? id, string clientId, int? parentId, string name, int? variableCategoryId, int? defaultUnitId, string combinationOperation, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? onsetDelay, int? durationOfAction, int? _public, bool? causeOnly, double? mostCommonValue, int? mostCommonUnitId, double? standardDeviation, double? variance, double? mean, double? median, double? numberOfMeasurements, double? numberOfUniqueValues, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string status, string errorMessage, string lastSuccessfulUpdateTime, string createdAt, string updatedAt, string productUrl, string imageUrl, double? price, int? numberOfUserVariables, bool? outcome, double? minimumRecordedValue, double? maximumRecordedValue, int? limit, int? offset, string sort);
  
        /// <summary>
        /// Get all Variables
        /// </summary>
        /// <remarks>
        /// Get all Variables
        /// </remarks>
        /// <param name="id">id</param>
        /// <param name="clientId">client_id</param>
        /// <param name="parentId">parent_id</param>
        /// <param name="name">name</param>
        /// <param name="variableCategoryId">variable_category_id</param>
        /// <param name="defaultUnitId">default_unit_id</param>
        /// <param name="combinationOperation">combination_operation</param>
        /// <param name="fillingValue">filling_value</param>
        /// <param name="maximumAllowedValue">maximum_allowed_value</param>
        /// <param name="minimumAllowedValue">minimum_allowed_value</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="_public">public</param>
        /// <param name="causeOnly">cause_only</param>
        /// <param name="mostCommonValue">most_common_value</param>
        /// <param name="mostCommonUnitId">most_common_unit_id</param>
        /// <param name="standardDeviation">standard_deviation</param>
        /// <param name="variance">variance</param>
        /// <param name="mean">mean</param>
        /// <param name="median">median</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="numberOfUniqueValues">number_of_unique_values</param>
        /// <param name="skewness">skewness</param>
        /// <param name="kurtosis">kurtosis</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="productUrl">product_url</param>
        /// <param name="imageUrl">image_url</param>
        /// <param name="price">price</param>
        /// <param name="numberOfUserVariables">number_of_user_variables</param>
        /// <param name="outcome">outcome</param>
        /// <param name="minimumRecordedValue">minimum_recorded_value</param>
        /// <param name="maximumRecordedValue">maximum_recorded_value</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20027</returns>
        System.Threading.Tasks.Task<InlineResponse20027> VariablesGetAsync (int? id, string clientId, int? parentId, string name, int? variableCategoryId, int? defaultUnitId, string combinationOperation, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? onsetDelay, int? durationOfAction, int? _public, bool? causeOnly, double? mostCommonValue, int? mostCommonUnitId, double? standardDeviation, double? variance, double? mean, double? median, double? numberOfMeasurements, double? numberOfUniqueValues, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string status, string errorMessage, string lastSuccessfulUpdateTime, string createdAt, string updatedAt, string productUrl, string imageUrl, double? price, int? numberOfUserVariables, bool? outcome, double? minimumRecordedValue, double? maximumRecordedValue, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Variable
        /// </summary>
        /// <remarks>
        /// Store Variable
        /// </remarks>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 VariablesPost (Variable body);
  
        /// <summary>
        /// Store Variable
        /// </summary>
        /// <remarks>
        /// Store Variable
        /// </remarks>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>InlineResponse20028</returns>
        System.Threading.Tasks.Task<InlineResponse20028> VariablesPostAsync (Variable body);
        
        /// <summary>
        /// Get Variable
        /// </summary>
        /// <remarks>
        /// Get Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 VariablesIdGet (int? id);
  
        /// <summary>
        /// Get Variable
        /// </summary>
        /// <remarks>
        /// Get Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <returns>InlineResponse20028</returns>
        System.Threading.Tasks.Task<InlineResponse20028> VariablesIdGetAsync (int? id);
        
        /// <summary>
        /// Update Variable
        /// </summary>
        /// <remarks>
        /// Update Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariablesIdPut (int? id, Variable body);
  
        /// <summary>
        /// Update Variable
        /// </summary>
        /// <remarks>
        /// Update Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariablesIdPutAsync (int? id, Variable body);
        
        /// <summary>
        /// Delete Variable
        /// </summary>
        /// <remarks>
        /// Delete Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariablesIdDelete (int? id);
  
        /// <summary>
        /// Delete Variable
        /// </summary>
        /// <remarks>
        /// Delete Variable
        /// </remarks>
        /// <param name="id">id of Variable</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> VariablesIdDeleteAsync (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariableApi : IVariableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VariableApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariableApi(String basePath)
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
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get all Variables Get all Variables
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="clientId">client_id</param> 
        /// <param name="parentId">parent_id</param> 
        /// <param name="name">name</param> 
        /// <param name="variableCategoryId">variable_category_id</param> 
        /// <param name="defaultUnitId">default_unit_id</param> 
        /// <param name="combinationOperation">combination_operation</param> 
        /// <param name="fillingValue">filling_value</param> 
        /// <param name="maximumAllowedValue">maximum_allowed_value</param> 
        /// <param name="minimumAllowedValue">minimum_allowed_value</param> 
        /// <param name="onsetDelay">onset_delay</param> 
        /// <param name="durationOfAction">duration_of_action</param> 
        /// <param name="_public">public</param> 
        /// <param name="causeOnly">cause_only</param> 
        /// <param name="mostCommonValue">most_common_value</param> 
        /// <param name="mostCommonUnitId">most_common_unit_id</param> 
        /// <param name="standardDeviation">standard_deviation</param> 
        /// <param name="variance">variance</param> 
        /// <param name="mean">mean</param> 
        /// <param name="median">median</param> 
        /// <param name="numberOfMeasurements">number_of_measurements</param> 
        /// <param name="numberOfUniqueValues">number_of_unique_values</param> 
        /// <param name="skewness">skewness</param> 
        /// <param name="kurtosis">kurtosis</param> 
        /// <param name="latitude">latitude</param> 
        /// <param name="longitude">longitude</param> 
        /// <param name="location">location</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="productUrl">product_url</param> 
        /// <param name="imageUrl">image_url</param> 
        /// <param name="price">price</param> 
        /// <param name="numberOfUserVariables">number_of_user_variables</param> 
        /// <param name="outcome">outcome</param> 
        /// <param name="minimumRecordedValue">minimum_recorded_value</param> 
        /// <param name="maximumRecordedValue">maximum_recorded_value</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 VariablesGet (int? id, string clientId, int? parentId, string name, int? variableCategoryId, int? defaultUnitId, string combinationOperation, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? onsetDelay, int? durationOfAction, int? _public, bool? causeOnly, double? mostCommonValue, int? mostCommonUnitId, double? standardDeviation, double? variance, double? mean, double? median, double? numberOfMeasurements, double? numberOfUniqueValues, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string status, string errorMessage, string lastSuccessfulUpdateTime, string createdAt, string updatedAt, string productUrl, string imageUrl, double? price, int? numberOfUserVariables, bool? outcome, double? minimumRecordedValue, double? maximumRecordedValue, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/variables";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (parentId != null) queryParams.Add("parent_id", ApiClient.ParameterToString(parentId)); // query parameter
            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
            if (variableCategoryId != null) queryParams.Add("variable_category_id", ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (combinationOperation != null) queryParams.Add("combination_operation", ApiClient.ParameterToString(combinationOperation)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", ApiClient.ParameterToString(fillingValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", ApiClient.ParameterToString(causeOnly)); // query parameter
            if (mostCommonValue != null) queryParams.Add("most_common_value", ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (standardDeviation != null) queryParams.Add("standard_deviation", ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) queryParams.Add("variance", ApiClient.ParameterToString(variance)); // query parameter
            if (mean != null) queryParams.Add("mean", ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) queryParams.Add("median", ApiClient.ParameterToString(median)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfUniqueValues != null) queryParams.Add("number_of_unique_values", ApiClient.ParameterToString(numberOfUniqueValues)); // query parameter
            if (skewness != null) queryParams.Add("skewness", ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) queryParams.Add("kurtosis", ApiClient.ParameterToString(kurtosis)); // query parameter
            if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
            if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (productUrl != null) queryParams.Add("product_url", ApiClient.ParameterToString(productUrl)); // query parameter
            if (imageUrl != null) queryParams.Add("image_url", ApiClient.ParameterToString(imageUrl)); // query parameter
            if (price != null) queryParams.Add("price", ApiClient.ParameterToString(price)); // query parameter
            if (numberOfUserVariables != null) queryParams.Add("number_of_user_variables", ApiClient.ParameterToString(numberOfUserVariables)); // query parameter
            if (outcome != null) queryParams.Add("outcome", ApiClient.ParameterToString(outcome)); // query parameter
            if (minimumRecordedValue != null) queryParams.Add("minimum_recorded_value", ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
            if (maximumRecordedValue != null) queryParams.Add("maximum_recorded_value", ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response, typeof(InlineResponse20027));
        }
    
        /// <summary>
        /// Get all Variables Get all Variables
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="clientId">client_id</param>
        /// <param name="parentId">parent_id</param>
        /// <param name="name">name</param>
        /// <param name="variableCategoryId">variable_category_id</param>
        /// <param name="defaultUnitId">default_unit_id</param>
        /// <param name="combinationOperation">combination_operation</param>
        /// <param name="fillingValue">filling_value</param>
        /// <param name="maximumAllowedValue">maximum_allowed_value</param>
        /// <param name="minimumAllowedValue">minimum_allowed_value</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="_public">public</param>
        /// <param name="causeOnly">cause_only</param>
        /// <param name="mostCommonValue">most_common_value</param>
        /// <param name="mostCommonUnitId">most_common_unit_id</param>
        /// <param name="standardDeviation">standard_deviation</param>
        /// <param name="variance">variance</param>
        /// <param name="mean">mean</param>
        /// <param name="median">median</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="numberOfUniqueValues">number_of_unique_values</param>
        /// <param name="skewness">skewness</param>
        /// <param name="kurtosis">kurtosis</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="productUrl">product_url</param>
        /// <param name="imageUrl">image_url</param>
        /// <param name="price">price</param>
        /// <param name="numberOfUserVariables">number_of_user_variables</param>
        /// <param name="outcome">outcome</param>
        /// <param name="minimumRecordedValue">minimum_recorded_value</param>
        /// <param name="maximumRecordedValue">maximum_recorded_value</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20027</returns>
        public async System.Threading.Tasks.Task<InlineResponse20027> VariablesGetAsync (int? id, string clientId, int? parentId, string name, int? variableCategoryId, int? defaultUnitId, string combinationOperation, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? onsetDelay, int? durationOfAction, int? _public, bool? causeOnly, double? mostCommonValue, int? mostCommonUnitId, double? standardDeviation, double? variance, double? mean, double? median, double? numberOfMeasurements, double? numberOfUniqueValues, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string status, string errorMessage, string lastSuccessfulUpdateTime, string createdAt, string updatedAt, string productUrl, string imageUrl, double? price, int? numberOfUserVariables, bool? outcome, double? minimumRecordedValue, double? maximumRecordedValue, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/variables";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (parentId != null) queryParams.Add("parent_id", ApiClient.ParameterToString(parentId)); // query parameter
            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
            if (variableCategoryId != null) queryParams.Add("variable_category_id", ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (combinationOperation != null) queryParams.Add("combination_operation", ApiClient.ParameterToString(combinationOperation)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", ApiClient.ParameterToString(fillingValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", ApiClient.ParameterToString(causeOnly)); // query parameter
            if (mostCommonValue != null) queryParams.Add("most_common_value", ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (standardDeviation != null) queryParams.Add("standard_deviation", ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) queryParams.Add("variance", ApiClient.ParameterToString(variance)); // query parameter
            if (mean != null) queryParams.Add("mean", ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) queryParams.Add("median", ApiClient.ParameterToString(median)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfUniqueValues != null) queryParams.Add("number_of_unique_values", ApiClient.ParameterToString(numberOfUniqueValues)); // query parameter
            if (skewness != null) queryParams.Add("skewness", ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) queryParams.Add("kurtosis", ApiClient.ParameterToString(kurtosis)); // query parameter
            if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
            if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (productUrl != null) queryParams.Add("product_url", ApiClient.ParameterToString(productUrl)); // query parameter
            if (imageUrl != null) queryParams.Add("image_url", ApiClient.ParameterToString(imageUrl)); // query parameter
            if (price != null) queryParams.Add("price", ApiClient.ParameterToString(price)); // query parameter
            if (numberOfUserVariables != null) queryParams.Add("number_of_user_variables", ApiClient.ParameterToString(numberOfUserVariables)); // query parameter
            if (outcome != null) queryParams.Add("outcome", ApiClient.ParameterToString(outcome)); // query parameter
            if (minimumRecordedValue != null) queryParams.Add("minimum_recorded_value", ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
            if (maximumRecordedValue != null) queryParams.Add("maximum_recorded_value", ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesGet: " + response.Content, response.Content);

            return (InlineResponse20027) ApiClient.Deserialize(response, typeof(InlineResponse20027));
        }
        
        /// <summary>
        /// Store Variable Store Variable
        /// </summary>
        /// <param name="body">Variable that should be stored</param> 
        /// <returns>InlineResponse20028</returns>            
        public InlineResponse20028 VariablesPost (Variable body)
        {
            
    
            var path_ = "/variables";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response, typeof(InlineResponse20028));
        }
    
        /// <summary>
        /// Store Variable Store Variable
        /// </summary>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>InlineResponse20028</returns>
        public async System.Threading.Tasks.Task<InlineResponse20028> VariablesPostAsync (Variable body)
        {
            
    
            var path_ = "/variables";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesPost: " + response.Content, response.Content);

            return (InlineResponse20028) ApiClient.Deserialize(response, typeof(InlineResponse20028));
        }
        
        /// <summary>
        /// Get Variable Get Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <returns>InlineResponse20028</returns>            
        public InlineResponse20028 VariablesIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdGet");
            
    
            var path_ = "/variables/{id}";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response, typeof(InlineResponse20028));
        }
    
        /// <summary>
        /// Get Variable Get Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <returns>InlineResponse20028</returns>
        public async System.Threading.Tasks.Task<InlineResponse20028> VariablesIdGetAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdGet");
            
    
            var path_ = "/variables/{id}";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdGet: " + response.Content, response.Content);

            return (InlineResponse20028) ApiClient.Deserialize(response, typeof(InlineResponse20028));
        }
        
        /// <summary>
        /// Update Variable Update Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="body">Variable that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariablesIdPut (int? id, Variable body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdPut");
            
    
            var path_ = "/variables/{id}";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Update Variable Update Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariablesIdPutAsync (int? id, Variable body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdPut");
            
    
            var path_ = "/variables/{id}";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdPut: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
        /// <summary>
        /// Delete Variable Delete Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariablesIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdDelete");
            
    
            var path_ = "/variables/{id}";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Delete Variable Delete Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> VariablesIdDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdDelete");
            
    
            var path_ = "/variables/{id}";
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdDelete: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
    }
    
}
