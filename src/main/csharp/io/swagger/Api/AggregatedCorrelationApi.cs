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
    public interface IAggregatedCorrelationApi
    {
        
        /// <summary>
        /// Get all AggregatedCorrelations
        /// </summary>
        /// <remarks>
        /// Get all AggregatedCorrelations
        /// </remarks>
        /// <param name="correlation">correlation</param>
        /// <param name="causeId">cause_id</param>
        /// <param name="effectId">effect_id</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="numberOfPairs">number_of_pairs</param>
        /// <param name="valuePredictingHighOutcome">value_predicting_high_outcome</param>
        /// <param name="valuePredictingLowOutcome">value_predicting_low_outcome</param>
        /// <param name="optimalPearsonProduct">optimal_pearson_product</param>
        /// <param name="vote">vote</param>
        /// <param name="numberOfUsers">number_of_users</param>
        /// <param name="numberOfCorrelations">number_of_correlations</param>
        /// <param name="statisticalSignificance">statistical_significance</param>
        /// <param name="causeUnit">cause_unit</param>
        /// <param name="causeUnitId">cause_unit_id</param>
        /// <param name="causeChanges">cause_changes</param>
        /// <param name="effectChanges">effect_changes</param>
        /// <param name="aggregateQmScore">aggregate_qm_score</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="reversePearsonCorrelationCoefficient">reverse_pearson_correlation_coefficient</param>
        /// <param name="predictivePearsonCorrelationCoefficient">predictive_pearson_correlation_coefficient</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AggregatedCorrelationsGet (double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, int? numberOfUsers, int? numberOfCorrelations, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? aggregateQmScore, string createdAt, string updatedAt, string status, string errorMessage, string lastSuccessfulUpdateTime, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort);
  
        /// <summary>
        /// Get all AggregatedCorrelations
        /// </summary>
        /// <remarks>
        /// Get all AggregatedCorrelations
        /// </remarks>
        /// <param name="correlation">correlation</param>
        /// <param name="causeId">cause_id</param>
        /// <param name="effectId">effect_id</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="numberOfPairs">number_of_pairs</param>
        /// <param name="valuePredictingHighOutcome">value_predicting_high_outcome</param>
        /// <param name="valuePredictingLowOutcome">value_predicting_low_outcome</param>
        /// <param name="optimalPearsonProduct">optimal_pearson_product</param>
        /// <param name="vote">vote</param>
        /// <param name="numberOfUsers">number_of_users</param>
        /// <param name="numberOfCorrelations">number_of_correlations</param>
        /// <param name="statisticalSignificance">statistical_significance</param>
        /// <param name="causeUnit">cause_unit</param>
        /// <param name="causeUnitId">cause_unit_id</param>
        /// <param name="causeChanges">cause_changes</param>
        /// <param name="effectChanges">effect_changes</param>
        /// <param name="aggregateQmScore">aggregate_qm_score</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="reversePearsonCorrelationCoefficient">reverse_pearson_correlation_coefficient</param>
        /// <param name="predictivePearsonCorrelationCoefficient">predictive_pearson_correlation_coefficient</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> AggregatedCorrelationsGetAsync (double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, int? numberOfUsers, int? numberOfCorrelations, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? aggregateQmScore, string createdAt, string updatedAt, string status, string errorMessage, string lastSuccessfulUpdateTime, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Store AggregatedCorrelation
        /// </remarks>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AggregatedCorrelationsPost (AggregatedCorrelation body);
  
        /// <summary>
        /// Store AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Store AggregatedCorrelation
        /// </remarks>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> AggregatedCorrelationsPostAsync (AggregatedCorrelation body);
        
        /// <summary>
        /// Get AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Get AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AggregatedCorrelationsIdGet (int? id);
  
        /// <summary>
        /// Get AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Get AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <returns>InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> AggregatedCorrelationsIdGetAsync (int? id);
        
        /// <summary>
        /// Update AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Update AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 AggregatedCorrelationsIdPut (int? id, AggregatedCorrelation body);
  
        /// <summary>
        /// Update AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Update AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> AggregatedCorrelationsIdPutAsync (int? id, AggregatedCorrelation body);
        
        /// <summary>
        /// Delete AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Delete AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 AggregatedCorrelationsIdDelete (int? id);
  
        /// <summary>
        /// Delete AggregatedCorrelation
        /// </summary>
        /// <remarks>
        /// Delete AggregatedCorrelation
        /// </remarks>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> AggregatedCorrelationsIdDeleteAsync (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AggregatedCorrelationApi : IAggregatedCorrelationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedCorrelationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AggregatedCorrelationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedCorrelationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AggregatedCorrelationApi(String basePath)
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
        /// Get all AggregatedCorrelations Get all AggregatedCorrelations
        /// </summary>
        /// <param name="correlation">correlation</param> 
        /// <param name="causeId">cause_id</param> 
        /// <param name="effectId">effect_id</param> 
        /// <param name="onsetDelay">onset_delay</param> 
        /// <param name="durationOfAction">duration_of_action</param> 
        /// <param name="numberOfPairs">number_of_pairs</param> 
        /// <param name="valuePredictingHighOutcome">value_predicting_high_outcome</param> 
        /// <param name="valuePredictingLowOutcome">value_predicting_low_outcome</param> 
        /// <param name="optimalPearsonProduct">optimal_pearson_product</param> 
        /// <param name="vote">vote</param> 
        /// <param name="numberOfUsers">number_of_users</param> 
        /// <param name="numberOfCorrelations">number_of_correlations</param> 
        /// <param name="statisticalSignificance">statistical_significance</param> 
        /// <param name="causeUnit">cause_unit</param> 
        /// <param name="causeUnitId">cause_unit_id</param> 
        /// <param name="causeChanges">cause_changes</param> 
        /// <param name="effectChanges">effect_changes</param> 
        /// <param name="aggregateQmScore">aggregate_qm_score</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param> 
        /// <param name="reversePearsonCorrelationCoefficient">reverse_pearson_correlation_coefficient</param> 
        /// <param name="predictivePearsonCorrelationCoefficient">predictive_pearson_correlation_coefficient</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 AggregatedCorrelationsGet (double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, int? numberOfUsers, int? numberOfCorrelations, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? aggregateQmScore, string createdAt, string updatedAt, string status, string errorMessage, string lastSuccessfulUpdateTime, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/aggregatedCorrelations";
    
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
            
            if (correlation != null) queryParams.Add("correlation", ApiClient.ParameterToString(correlation)); // query parameter
            if (causeId != null) queryParams.Add("cause_id", ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) queryParams.Add("effect_id", ApiClient.ParameterToString(effectId)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (numberOfPairs != null) queryParams.Add("number_of_pairs", ApiClient.ParameterToString(numberOfPairs)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (optimalPearsonProduct != null) queryParams.Add("optimal_pearson_product", ApiClient.ParameterToString(optimalPearsonProduct)); // query parameter
            if (vote != null) queryParams.Add("vote", ApiClient.ParameterToString(vote)); // query parameter
            if (numberOfUsers != null) queryParams.Add("number_of_users", ApiClient.ParameterToString(numberOfUsers)); // query parameter
            if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (statisticalSignificance != null) queryParams.Add("statistical_significance", ApiClient.ParameterToString(statisticalSignificance)); // query parameter
            if (causeUnit != null) queryParams.Add("cause_unit", ApiClient.ParameterToString(causeUnit)); // query parameter
            if (causeUnitId != null) queryParams.Add("cause_unit_id", ApiClient.ParameterToString(causeUnitId)); // query parameter
            if (causeChanges != null) queryParams.Add("cause_changes", ApiClient.ParameterToString(causeChanges)); // query parameter
            if (effectChanges != null) queryParams.Add("effect_changes", ApiClient.ParameterToString(effectChanges)); // query parameter
            if (aggregateQmScore != null) queryParams.Add("aggregate_qm_score", ApiClient.ParameterToString(aggregateQmScore)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (reversePearsonCorrelationCoefficient != null) queryParams.Add("reverse_pearson_correlation_coefficient", ApiClient.ParameterToString(reversePearsonCorrelationCoefficient)); // query parameter
            if (predictivePearsonCorrelationCoefficient != null) queryParams.Add("predictive_pearson_correlation_coefficient", ApiClient.ParameterToString(predictivePearsonCorrelationCoefficient)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response, typeof(InlineResponse200));
        }
    
        /// <summary>
        /// Get all AggregatedCorrelations Get all AggregatedCorrelations
        /// </summary>
        /// <param name="correlation">correlation</param>
        /// <param name="causeId">cause_id</param>
        /// <param name="effectId">effect_id</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="numberOfPairs">number_of_pairs</param>
        /// <param name="valuePredictingHighOutcome">value_predicting_high_outcome</param>
        /// <param name="valuePredictingLowOutcome">value_predicting_low_outcome</param>
        /// <param name="optimalPearsonProduct">optimal_pearson_product</param>
        /// <param name="vote">vote</param>
        /// <param name="numberOfUsers">number_of_users</param>
        /// <param name="numberOfCorrelations">number_of_correlations</param>
        /// <param name="statisticalSignificance">statistical_significance</param>
        /// <param name="causeUnit">cause_unit</param>
        /// <param name="causeUnitId">cause_unit_id</param>
        /// <param name="causeChanges">cause_changes</param>
        /// <param name="effectChanges">effect_changes</param>
        /// <param name="aggregateQmScore">aggregate_qm_score</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">last_successful_update_time</param>
        /// <param name="reversePearsonCorrelationCoefficient">reverse_pearson_correlation_coefficient</param>
        /// <param name="predictivePearsonCorrelationCoefficient">predictive_pearson_correlation_coefficient</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> AggregatedCorrelationsGetAsync (double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, int? numberOfUsers, int? numberOfCorrelations, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? aggregateQmScore, string createdAt, string updatedAt, string status, string errorMessage, string lastSuccessfulUpdateTime, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/aggregatedCorrelations";
    
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
            
            if (correlation != null) queryParams.Add("correlation", ApiClient.ParameterToString(correlation)); // query parameter
            if (causeId != null) queryParams.Add("cause_id", ApiClient.ParameterToString(causeId)); // query parameter
            if (effectId != null) queryParams.Add("effect_id", ApiClient.ParameterToString(effectId)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (numberOfPairs != null) queryParams.Add("number_of_pairs", ApiClient.ParameterToString(numberOfPairs)); // query parameter
            if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
            if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
            if (optimalPearsonProduct != null) queryParams.Add("optimal_pearson_product", ApiClient.ParameterToString(optimalPearsonProduct)); // query parameter
            if (vote != null) queryParams.Add("vote", ApiClient.ParameterToString(vote)); // query parameter
            if (numberOfUsers != null) queryParams.Add("number_of_users", ApiClient.ParameterToString(numberOfUsers)); // query parameter
            if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (statisticalSignificance != null) queryParams.Add("statistical_significance", ApiClient.ParameterToString(statisticalSignificance)); // query parameter
            if (causeUnit != null) queryParams.Add("cause_unit", ApiClient.ParameterToString(causeUnit)); // query parameter
            if (causeUnitId != null) queryParams.Add("cause_unit_id", ApiClient.ParameterToString(causeUnitId)); // query parameter
            if (causeChanges != null) queryParams.Add("cause_changes", ApiClient.ParameterToString(causeChanges)); // query parameter
            if (effectChanges != null) queryParams.Add("effect_changes", ApiClient.ParameterToString(effectChanges)); // query parameter
            if (aggregateQmScore != null) queryParams.Add("aggregate_qm_score", ApiClient.ParameterToString(aggregateQmScore)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
            if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (reversePearsonCorrelationCoefficient != null) queryParams.Add("reverse_pearson_correlation_coefficient", ApiClient.ParameterToString(reversePearsonCorrelationCoefficient)); // query parameter
            if (predictivePearsonCorrelationCoefficient != null) queryParams.Add("predictive_pearson_correlation_coefficient", ApiClient.ParameterToString(predictivePearsonCorrelationCoefficient)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsGet: " + response.Content, response.Content);

            return (InlineResponse200) ApiClient.Deserialize(response, typeof(InlineResponse200));
        }
        
        /// <summary>
        /// Store AggregatedCorrelation Store AggregatedCorrelation
        /// </summary>
        /// <param name="body">AggregatedCorrelation that should be stored</param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 AggregatedCorrelationsPost (AggregatedCorrelation body)
        {
            
    
            var path_ = "/aggregatedCorrelations";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response, typeof(InlineResponse2001));
        }
    
        /// <summary>
        /// Store AggregatedCorrelation Store AggregatedCorrelation
        /// </summary>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> AggregatedCorrelationsPostAsync (AggregatedCorrelation body)
        {
            
    
            var path_ = "/aggregatedCorrelations";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsPost: " + response.Content, response.Content);

            return (InlineResponse2001) ApiClient.Deserialize(response, typeof(InlineResponse2001));
        }
        
        /// <summary>
        /// Get AggregatedCorrelation Get AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 AggregatedCorrelationsIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdGet");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response, typeof(InlineResponse2001));
        }
    
        /// <summary>
        /// Get AggregatedCorrelation Get AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <returns>InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> AggregatedCorrelationsIdGetAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdGet");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdGet: " + response.Content, response.Content);

            return (InlineResponse2001) ApiClient.Deserialize(response, typeof(InlineResponse2001));
        }
        
        /// <summary>
        /// Update AggregatedCorrelation Update AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="body">AggregatedCorrelation that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 AggregatedCorrelationsIdPut (int? id, AggregatedCorrelation body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdPut");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Update AggregatedCorrelation Update AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> AggregatedCorrelationsIdPutAsync (int? id, AggregatedCorrelation body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdPut");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdPut: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
        /// <summary>
        /// Delete AggregatedCorrelation Delete AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 AggregatedCorrelationsIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdDelete");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Delete AggregatedCorrelation Delete AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> AggregatedCorrelationsIdDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdDelete");
            
    
            var path_ = "/aggregatedCorrelations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
    }
    
}
