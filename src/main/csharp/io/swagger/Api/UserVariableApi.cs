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
    public interface IUserVariableApi
    {
        
        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <param name="clientId">client_id</param>
        /// <param name="variableId">variable_id</param>
        /// <param name="defaultUnitId">default_unit_id</param>
        /// <param name="minimumAllowedValue">minimum_allowed_value</param>
        /// <param name="maximumAllowedValue">maximum_allowed_value</param>
        /// <param name="fillingValue">filling_value</param>
        /// <param name="joinWith">join_with</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="variableCategoryId">variable_category_id</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">public</param>
        /// <param name="causeOnly">cause_only</param>
        /// <param name="fillingType">filling_type</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="numberOfProcessedMeasurements">number_of_processed_measurements</param>
        /// <param name="measurementsAtLastAnalysis">measurements_at_last_analysis</param>
        /// <param name="lastUnitId">last_unit_id</param>
        /// <param name="lastOriginalUnitId">last_original_unit_id</param>
        /// <param name="lastOriginalValue">last_original_value</param>
        /// <param name="lastValue">last_value</param>
        /// <param name="lastSourceId">last_source_id</param>
        /// <param name="numberOfCorrelations">number_of_correlations</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="standardDeviation">standard_deviation</param>
        /// <param name="variance">variance</param>
        /// <param name="minimumRecordedDailyValue">minimum_recorded_daily_value</param>
        /// <param name="maximumRecordedDailyValue">maximum_recorded_daily_value</param>
        /// <param name="mean">mean</param>
        /// <param name="median">median</param>
        /// <param name="mostCommonUnitId">most_common_unit_id</param>
        /// <param name="mostCommonValue">most_common_value</param>
        /// <param name="numberOfUniqueDailyValues">number_of_unique_daily_values</param>
        /// <param name="numberOfChanges">number_of_changes</param>
        /// <param name="skewness">skewness</param>
        /// <param name="kurtosis">kurtosis</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="outcome">outcome</param>
        /// <param name="sources">sources</param>
        /// <param name="earliestSourceTime">earliest_source_time</param>
        /// <param name="latestSourceTime">latest_source_time</param>
        /// <param name="earliestMeasurementTime">earliest_measurement_time</param>
        /// <param name="latestMeasurementTime">latest_measurement_time</param>
        /// <param name="earliestFillingTime">earliest_filling_time</param>
        /// <param name="latestFillingTime">latest_filling_time</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20021</returns>
        InlineResponse20021 UserVariablesGet (string clientId, int? variableId, int? defaultUnitId, double? minimumAllowedValue, double? maximumAllowedValue, double? fillingValue, int? joinWith, int? onsetDelay, int? durationOfAction, int? variableCategoryId, int? updated, int? _public, bool? causeOnly, string fillingType, int? numberOfMeasurements, int? numberOfProcessedMeasurements, int? measurementsAtLastAnalysis, int? lastUnitId, int? lastOriginalUnitId, int? lastOriginalValue, double? lastValue, int? lastSourceId, int? numberOfCorrelations, string status, string errorMessage, string lastSuccessfulUpdateTime, double? standardDeviation, double? variance, double? minimumRecordedDailyValue, double? maximumRecordedDailyValue, double? mean, double? median, int? mostCommonUnitId, double? mostCommonValue, double? numberOfUniqueDailyValues, int? numberOfChanges, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string createdAt, string updatedAt, bool? outcome, string sources, int? earliestSourceTime, int? latestSourceTime, int? earliestMeasurementTime, int? latestMeasurementTime, int? earliestFillingTime, int? latestFillingTime, int? limit, int? offset, string sort);
  
        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <param name="clientId">client_id</param>
        /// <param name="variableId">variable_id</param>
        /// <param name="defaultUnitId">default_unit_id</param>
        /// <param name="minimumAllowedValue">minimum_allowed_value</param>
        /// <param name="maximumAllowedValue">maximum_allowed_value</param>
        /// <param name="fillingValue">filling_value</param>
        /// <param name="joinWith">join_with</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="variableCategoryId">variable_category_id</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">public</param>
        /// <param name="causeOnly">cause_only</param>
        /// <param name="fillingType">filling_type</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="numberOfProcessedMeasurements">number_of_processed_measurements</param>
        /// <param name="measurementsAtLastAnalysis">measurements_at_last_analysis</param>
        /// <param name="lastUnitId">last_unit_id</param>
        /// <param name="lastOriginalUnitId">last_original_unit_id</param>
        /// <param name="lastOriginalValue">last_original_value</param>
        /// <param name="lastValue">last_value</param>
        /// <param name="lastSourceId">last_source_id</param>
        /// <param name="numberOfCorrelations">number_of_correlations</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="standardDeviation">standard_deviation</param>
        /// <param name="variance">variance</param>
        /// <param name="minimumRecordedDailyValue">minimum_recorded_daily_value</param>
        /// <param name="maximumRecordedDailyValue">maximum_recorded_daily_value</param>
        /// <param name="mean">mean</param>
        /// <param name="median">median</param>
        /// <param name="mostCommonUnitId">most_common_unit_id</param>
        /// <param name="mostCommonValue">most_common_value</param>
        /// <param name="numberOfUniqueDailyValues">number_of_unique_daily_values</param>
        /// <param name="numberOfChanges">number_of_changes</param>
        /// <param name="skewness">skewness</param>
        /// <param name="kurtosis">kurtosis</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="outcome">outcome</param>
        /// <param name="sources">sources</param>
        /// <param name="earliestSourceTime">earliest_source_time</param>
        /// <param name="latestSourceTime">latest_source_time</param>
        /// <param name="earliestMeasurementTime">earliest_measurement_time</param>
        /// <param name="latestMeasurementTime">latest_measurement_time</param>
        /// <param name="earliestFillingTime">earliest_filling_time</param>
        /// <param name="latestFillingTime">latest_filling_time</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20021</returns>
        System.Threading.Tasks.Task<InlineResponse20021> UserVariablesGetAsync (string clientId, int? variableId, int? defaultUnitId, double? minimumAllowedValue, double? maximumAllowedValue, double? fillingValue, int? joinWith, int? onsetDelay, int? durationOfAction, int? variableCategoryId, int? updated, int? _public, bool? causeOnly, string fillingType, int? numberOfMeasurements, int? numberOfProcessedMeasurements, int? measurementsAtLastAnalysis, int? lastUnitId, int? lastOriginalUnitId, int? lastOriginalValue, double? lastValue, int? lastSourceId, int? numberOfCorrelations, string status, string errorMessage, string lastSuccessfulUpdateTime, double? standardDeviation, double? variance, double? minimumRecordedDailyValue, double? maximumRecordedDailyValue, double? mean, double? median, int? mostCommonUnitId, double? mostCommonValue, double? numberOfUniqueDailyValues, int? numberOfChanges, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string createdAt, string updatedAt, bool? outcome, string sources, int? earliestSourceTime, int? latestSourceTime, int? earliestMeasurementTime, int? latestMeasurementTime, int? earliestFillingTime, int? latestFillingTime, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store UserVariable
        /// </summary>
        /// <remarks>
        /// Store UserVariable
        /// </remarks>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 UserVariablesPost (UserVariable body);
  
        /// <summary>
        /// Store UserVariable
        /// </summary>
        /// <remarks>
        /// Store UserVariable
        /// </remarks>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>InlineResponse20022</returns>
        System.Threading.Tasks.Task<InlineResponse20022> UserVariablesPostAsync (UserVariable body);
        
        /// <summary>
        /// Get UserVariable
        /// </summary>
        /// <remarks>
        /// Get UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 UserVariablesIdGet (int? id);
  
        /// <summary>
        /// Get UserVariable
        /// </summary>
        /// <remarks>
        /// Get UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <returns>InlineResponse20022</returns>
        System.Threading.Tasks.Task<InlineResponse20022> UserVariablesIdGetAsync (int? id);
        
        /// <summary>
        /// Update UserVariable
        /// </summary>
        /// <remarks>
        /// Update UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariablesIdPut (int? id, UserVariable body);
  
        /// <summary>
        /// Update UserVariable
        /// </summary>
        /// <remarks>
        /// Update UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> UserVariablesIdPutAsync (int? id, UserVariable body);
        
        /// <summary>
        /// Delete UserVariable
        /// </summary>
        /// <remarks>
        /// Delete UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariablesIdDelete (int? id);
  
        /// <summary>
        /// Delete UserVariable
        /// </summary>
        /// <remarks>
        /// Delete UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> UserVariablesIdDeleteAsync (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserVariableApi : IUserVariableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserVariableApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserVariableApi(String basePath)
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
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="clientId">client_id</param> 
        /// <param name="variableId">variable_id</param> 
        /// <param name="defaultUnitId">default_unit_id</param> 
        /// <param name="minimumAllowedValue">minimum_allowed_value</param> 
        /// <param name="maximumAllowedValue">maximum_allowed_value</param> 
        /// <param name="fillingValue">filling_value</param> 
        /// <param name="joinWith">join_with</param> 
        /// <param name="onsetDelay">onset_delay</param> 
        /// <param name="durationOfAction">duration_of_action</param> 
        /// <param name="variableCategoryId">variable_category_id</param> 
        /// <param name="updated">updated</param> 
        /// <param name="_public">public</param> 
        /// <param name="causeOnly">cause_only</param> 
        /// <param name="fillingType">filling_type</param> 
        /// <param name="numberOfMeasurements">number_of_measurements</param> 
        /// <param name="numberOfProcessedMeasurements">number_of_processed_measurements</param> 
        /// <param name="measurementsAtLastAnalysis">measurements_at_last_analysis</param> 
        /// <param name="lastUnitId">last_unit_id</param> 
        /// <param name="lastOriginalUnitId">last_original_unit_id</param> 
        /// <param name="lastOriginalValue">last_original_value</param> 
        /// <param name="lastValue">last_value</param> 
        /// <param name="lastSourceId">last_source_id</param> 
        /// <param name="numberOfCorrelations">number_of_correlations</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param> 
        /// <param name="standardDeviation">standard_deviation</param> 
        /// <param name="variance">variance</param> 
        /// <param name="minimumRecordedDailyValue">minimum_recorded_daily_value</param> 
        /// <param name="maximumRecordedDailyValue">maximum_recorded_daily_value</param> 
        /// <param name="mean">mean</param> 
        /// <param name="median">median</param> 
        /// <param name="mostCommonUnitId">most_common_unit_id</param> 
        /// <param name="mostCommonValue">most_common_value</param> 
        /// <param name="numberOfUniqueDailyValues">number_of_unique_daily_values</param> 
        /// <param name="numberOfChanges">number_of_changes</param> 
        /// <param name="skewness">skewness</param> 
        /// <param name="kurtosis">kurtosis</param> 
        /// <param name="latitude">latitude</param> 
        /// <param name="longitude">longitude</param> 
        /// <param name="location">location</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="outcome">outcome</param> 
        /// <param name="sources">sources</param> 
        /// <param name="earliestSourceTime">earliest_source_time</param> 
        /// <param name="latestSourceTime">latest_source_time</param> 
        /// <param name="earliestMeasurementTime">earliest_measurement_time</param> 
        /// <param name="latestMeasurementTime">latest_measurement_time</param> 
        /// <param name="earliestFillingTime">earliest_filling_time</param> 
        /// <param name="latestFillingTime">latest_filling_time</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20021</returns>            
        public InlineResponse20021 UserVariablesGet (string clientId, int? variableId, int? defaultUnitId, double? minimumAllowedValue, double? maximumAllowedValue, double? fillingValue, int? joinWith, int? onsetDelay, int? durationOfAction, int? variableCategoryId, int? updated, int? _public, bool? causeOnly, string fillingType, int? numberOfMeasurements, int? numberOfProcessedMeasurements, int? measurementsAtLastAnalysis, int? lastUnitId, int? lastOriginalUnitId, int? lastOriginalValue, double? lastValue, int? lastSourceId, int? numberOfCorrelations, string status, string errorMessage, string lastSuccessfulUpdateTime, double? standardDeviation, double? variance, double? minimumRecordedDailyValue, double? maximumRecordedDailyValue, double? mean, double? median, int? mostCommonUnitId, double? mostCommonValue, double? numberOfUniqueDailyValues, int? numberOfChanges, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string createdAt, string updatedAt, bool? outcome, string sources, int? earliestSourceTime, int? latestSourceTime, int? earliestMeasurementTime, int? latestMeasurementTime, int? earliestFillingTime, int? latestFillingTime, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/userVariables";
    
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
            
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", ApiClient.ParameterToString(fillingValue)); // query parameter
            if (joinWith != null) queryParams.Add("join_with", ApiClient.ParameterToString(joinWith)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (variableCategoryId != null) queryParams.Add("variable_category_id", ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (updated != null) queryParams.Add("updated", ApiClient.ParameterToString(updated)); // query parameter
            if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", ApiClient.ParameterToString(causeOnly)); // query parameter
            if (fillingType != null) queryParams.Add("filling_type", ApiClient.ParameterToString(fillingType)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfProcessedMeasurements != null) queryParams.Add("number_of_processed_measurements", ApiClient.ParameterToString(numberOfProcessedMeasurements)); // query parameter
            if (measurementsAtLastAnalysis != null) queryParams.Add("measurements_at_last_analysis", ApiClient.ParameterToString(measurementsAtLastAnalysis)); // query parameter
            if (lastUnitId != null) queryParams.Add("last_unit_id", ApiClient.ParameterToString(lastUnitId)); // query parameter
            if (lastOriginalUnitId != null) queryParams.Add("last_original_unit_id", ApiClient.ParameterToString(lastOriginalUnitId)); // query parameter
            if (lastOriginalValue != null) queryParams.Add("last_original_value", ApiClient.ParameterToString(lastOriginalValue)); // query parameter
            if (lastValue != null) queryParams.Add("last_value", ApiClient.ParameterToString(lastValue)); // query parameter
            if (lastSourceId != null) queryParams.Add("last_source_id", ApiClient.ParameterToString(lastSourceId)); // query parameter
            if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (standardDeviation != null) queryParams.Add("standard_deviation", ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) queryParams.Add("variance", ApiClient.ParameterToString(variance)); // query parameter
            if (minimumRecordedDailyValue != null) queryParams.Add("minimum_recorded_daily_value", ApiClient.ParameterToString(minimumRecordedDailyValue)); // query parameter
            if (maximumRecordedDailyValue != null) queryParams.Add("maximum_recorded_daily_value", ApiClient.ParameterToString(maximumRecordedDailyValue)); // query parameter
            if (mean != null) queryParams.Add("mean", ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) queryParams.Add("median", ApiClient.ParameterToString(median)); // query parameter
            if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (mostCommonValue != null) queryParams.Add("most_common_value", ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (numberOfUniqueDailyValues != null) queryParams.Add("number_of_unique_daily_values", ApiClient.ParameterToString(numberOfUniqueDailyValues)); // query parameter
            if (numberOfChanges != null) queryParams.Add("number_of_changes", ApiClient.ParameterToString(numberOfChanges)); // query parameter
            if (skewness != null) queryParams.Add("skewness", ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) queryParams.Add("kurtosis", ApiClient.ParameterToString(kurtosis)); // query parameter
            if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (outcome != null) queryParams.Add("outcome", ApiClient.ParameterToString(outcome)); // query parameter
            if (sources != null) queryParams.Add("sources", ApiClient.ParameterToString(sources)); // query parameter
            if (earliestSourceTime != null) queryParams.Add("earliest_source_time", ApiClient.ParameterToString(earliestSourceTime)); // query parameter
            if (latestSourceTime != null) queryParams.Add("latest_source_time", ApiClient.ParameterToString(latestSourceTime)); // query parameter
            if (earliestMeasurementTime != null) queryParams.Add("earliest_measurement_time", ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) queryParams.Add("latest_measurement_time", ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (earliestFillingTime != null) queryParams.Add("earliest_filling_time", ApiClient.ParameterToString(earliestFillingTime)); // query parameter
            if (latestFillingTime != null) queryParams.Add("latest_filling_time", ApiClient.ParameterToString(latestFillingTime)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20021) ApiClient.Deserialize(response, typeof(InlineResponse20021));
        }
    
        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="clientId">client_id</param>
        /// <param name="variableId">variable_id</param>
        /// <param name="defaultUnitId">default_unit_id</param>
        /// <param name="minimumAllowedValue">minimum_allowed_value</param>
        /// <param name="maximumAllowedValue">maximum_allowed_value</param>
        /// <param name="fillingValue">filling_value</param>
        /// <param name="joinWith">join_with</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="variableCategoryId">variable_category_id</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">public</param>
        /// <param name="causeOnly">cause_only</param>
        /// <param name="fillingType">filling_type</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="numberOfProcessedMeasurements">number_of_processed_measurements</param>
        /// <param name="measurementsAtLastAnalysis">measurements_at_last_analysis</param>
        /// <param name="lastUnitId">last_unit_id</param>
        /// <param name="lastOriginalUnitId">last_original_unit_id</param>
        /// <param name="lastOriginalValue">last_original_value</param>
        /// <param name="lastValue">last_value</param>
        /// <param name="lastSourceId">last_source_id</param>
        /// <param name="numberOfCorrelations">number_of_correlations</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="standardDeviation">standard_deviation</param>
        /// <param name="variance">variance</param>
        /// <param name="minimumRecordedDailyValue">minimum_recorded_daily_value</param>
        /// <param name="maximumRecordedDailyValue">maximum_recorded_daily_value</param>
        /// <param name="mean">mean</param>
        /// <param name="median">median</param>
        /// <param name="mostCommonUnitId">most_common_unit_id</param>
        /// <param name="mostCommonValue">most_common_value</param>
        /// <param name="numberOfUniqueDailyValues">number_of_unique_daily_values</param>
        /// <param name="numberOfChanges">number_of_changes</param>
        /// <param name="skewness">skewness</param>
        /// <param name="kurtosis">kurtosis</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="outcome">outcome</param>
        /// <param name="sources">sources</param>
        /// <param name="earliestSourceTime">earliest_source_time</param>
        /// <param name="latestSourceTime">latest_source_time</param>
        /// <param name="earliestMeasurementTime">earliest_measurement_time</param>
        /// <param name="latestMeasurementTime">latest_measurement_time</param>
        /// <param name="earliestFillingTime">earliest_filling_time</param>
        /// <param name="latestFillingTime">latest_filling_time</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20021</returns>
        public async System.Threading.Tasks.Task<InlineResponse20021> UserVariablesGetAsync (string clientId, int? variableId, int? defaultUnitId, double? minimumAllowedValue, double? maximumAllowedValue, double? fillingValue, int? joinWith, int? onsetDelay, int? durationOfAction, int? variableCategoryId, int? updated, int? _public, bool? causeOnly, string fillingType, int? numberOfMeasurements, int? numberOfProcessedMeasurements, int? measurementsAtLastAnalysis, int? lastUnitId, int? lastOriginalUnitId, int? lastOriginalValue, double? lastValue, int? lastSourceId, int? numberOfCorrelations, string status, string errorMessage, string lastSuccessfulUpdateTime, double? standardDeviation, double? variance, double? minimumRecordedDailyValue, double? maximumRecordedDailyValue, double? mean, double? median, int? mostCommonUnitId, double? mostCommonValue, double? numberOfUniqueDailyValues, int? numberOfChanges, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string createdAt, string updatedAt, bool? outcome, string sources, int? earliestSourceTime, int? latestSourceTime, int? earliestMeasurementTime, int? latestMeasurementTime, int? earliestFillingTime, int? latestFillingTime, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/userVariables";
    
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
            
            if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", ApiClient.ParameterToString(fillingValue)); // query parameter
            if (joinWith != null) queryParams.Add("join_with", ApiClient.ParameterToString(joinWith)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (variableCategoryId != null) queryParams.Add("variable_category_id", ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (updated != null) queryParams.Add("updated", ApiClient.ParameterToString(updated)); // query parameter
            if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", ApiClient.ParameterToString(causeOnly)); // query parameter
            if (fillingType != null) queryParams.Add("filling_type", ApiClient.ParameterToString(fillingType)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfProcessedMeasurements != null) queryParams.Add("number_of_processed_measurements", ApiClient.ParameterToString(numberOfProcessedMeasurements)); // query parameter
            if (measurementsAtLastAnalysis != null) queryParams.Add("measurements_at_last_analysis", ApiClient.ParameterToString(measurementsAtLastAnalysis)); // query parameter
            if (lastUnitId != null) queryParams.Add("last_unit_id", ApiClient.ParameterToString(lastUnitId)); // query parameter
            if (lastOriginalUnitId != null) queryParams.Add("last_original_unit_id", ApiClient.ParameterToString(lastOriginalUnitId)); // query parameter
            if (lastOriginalValue != null) queryParams.Add("last_original_value", ApiClient.ParameterToString(lastOriginalValue)); // query parameter
            if (lastValue != null) queryParams.Add("last_value", ApiClient.ParameterToString(lastValue)); // query parameter
            if (lastSourceId != null) queryParams.Add("last_source_id", ApiClient.ParameterToString(lastSourceId)); // query parameter
            if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (standardDeviation != null) queryParams.Add("standard_deviation", ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) queryParams.Add("variance", ApiClient.ParameterToString(variance)); // query parameter
            if (minimumRecordedDailyValue != null) queryParams.Add("minimum_recorded_daily_value", ApiClient.ParameterToString(minimumRecordedDailyValue)); // query parameter
            if (maximumRecordedDailyValue != null) queryParams.Add("maximum_recorded_daily_value", ApiClient.ParameterToString(maximumRecordedDailyValue)); // query parameter
            if (mean != null) queryParams.Add("mean", ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) queryParams.Add("median", ApiClient.ParameterToString(median)); // query parameter
            if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (mostCommonValue != null) queryParams.Add("most_common_value", ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (numberOfUniqueDailyValues != null) queryParams.Add("number_of_unique_daily_values", ApiClient.ParameterToString(numberOfUniqueDailyValues)); // query parameter
            if (numberOfChanges != null) queryParams.Add("number_of_changes", ApiClient.ParameterToString(numberOfChanges)); // query parameter
            if (skewness != null) queryParams.Add("skewness", ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) queryParams.Add("kurtosis", ApiClient.ParameterToString(kurtosis)); // query parameter
            if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (outcome != null) queryParams.Add("outcome", ApiClient.ParameterToString(outcome)); // query parameter
            if (sources != null) queryParams.Add("sources", ApiClient.ParameterToString(sources)); // query parameter
            if (earliestSourceTime != null) queryParams.Add("earliest_source_time", ApiClient.ParameterToString(earliestSourceTime)); // query parameter
            if (latestSourceTime != null) queryParams.Add("latest_source_time", ApiClient.ParameterToString(latestSourceTime)); // query parameter
            if (earliestMeasurementTime != null) queryParams.Add("earliest_measurement_time", ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) queryParams.Add("latest_measurement_time", ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (earliestFillingTime != null) queryParams.Add("earliest_filling_time", ApiClient.ParameterToString(earliestFillingTime)); // query parameter
            if (latestFillingTime != null) queryParams.Add("latest_filling_time", ApiClient.ParameterToString(latestFillingTime)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesGet: " + response.Content, response.Content);

            return (InlineResponse20021) ApiClient.Deserialize(response, typeof(InlineResponse20021));
        }
        
        /// <summary>
        /// Store UserVariable Store UserVariable
        /// </summary>
        /// <param name="body">UserVariable that should be stored</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 UserVariablesPost (UserVariable body)
        {
            
    
            var path_ = "/userVariables";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response, typeof(InlineResponse20022));
        }
    
        /// <summary>
        /// Store UserVariable Store UserVariable
        /// </summary>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>InlineResponse20022</returns>
        public async System.Threading.Tasks.Task<InlineResponse20022> UserVariablesPostAsync (UserVariable body)
        {
            
    
            var path_ = "/userVariables";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesPost: " + response.Content, response.Content);

            return (InlineResponse20022) ApiClient.Deserialize(response, typeof(InlineResponse20022));
        }
        
        /// <summary>
        /// Get UserVariable Get UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 UserVariablesIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdGet");
            
    
            var path_ = "/userVariables/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response, typeof(InlineResponse20022));
        }
    
        /// <summary>
        /// Get UserVariable Get UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <returns>InlineResponse20022</returns>
        public async System.Threading.Tasks.Task<InlineResponse20022> UserVariablesIdGetAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdGet");
            
    
            var path_ = "/userVariables/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdGet: " + response.Content, response.Content);

            return (InlineResponse20022) ApiClient.Deserialize(response, typeof(InlineResponse20022));
        }
        
        /// <summary>
        /// Update UserVariable Update UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="body">UserVariable that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UserVariablesIdPut (int? id, UserVariable body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdPut");
            
    
            var path_ = "/userVariables/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Update UserVariable Update UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> UserVariablesIdPutAsync (int? id, UserVariable body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdPut");
            
    
            var path_ = "/userVariables/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdPut: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
        /// <summary>
        /// Delete UserVariable Delete UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UserVariablesIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdDelete");
            
    
            var path_ = "/userVariables/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Delete UserVariable Delete UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> UserVariablesIdDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdDelete");
            
    
            var path_ = "/userVariables/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdDelete: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
    }
    
}
