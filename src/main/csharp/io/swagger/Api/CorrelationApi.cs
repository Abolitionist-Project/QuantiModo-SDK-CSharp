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
    public interface ICorrelationApi
    {
        
        /// <summary>
        /// Get all Correlations
        /// </summary>
        /// <remarks>
        /// Get all Correlations
        /// </remarks>
        /// <param name="timestamp">timestamp</param>
        /// <param name="userId">user_id</param>
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
        /// <param name="statisticalSignificance">statistical_significance</param>
        /// <param name="causeUnit">cause_unit</param>
        /// <param name="causeUnitId">cause_unit_id</param>
        /// <param name="causeChanges">cause_changes</param>
        /// <param name="effectChanges">effect_changes</param>
        /// <param name="qmScore">qm_score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="reversePearsonCorrelationCoefficient">reverse_pearson_correlation_coefficient</param>
        /// <param name="predictivePearsonCorrelationCoefficient">predictive_pearson_correlation_coefficient</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 CorrelationsGet (int? timestamp, int? userId, double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? qmScore, string error, string createdAt, string updatedAt, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort);
  
        /// <summary>
        /// Get all Correlations
        /// </summary>
        /// <remarks>
        /// Get all Correlations
        /// </remarks>
        /// <param name="timestamp">timestamp</param>
        /// <param name="userId">user_id</param>
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
        /// <param name="statisticalSignificance">statistical_significance</param>
        /// <param name="causeUnit">cause_unit</param>
        /// <param name="causeUnitId">cause_unit_id</param>
        /// <param name="causeChanges">cause_changes</param>
        /// <param name="effectChanges">effect_changes</param>
        /// <param name="qmScore">qm_score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="reversePearsonCorrelationCoefficient">reverse_pearson_correlation_coefficient</param>
        /// <param name="predictivePearsonCorrelationCoefficient">predictive_pearson_correlation_coefficient</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2007</returns>
        System.Threading.Tasks.Task<InlineResponse2007> CorrelationsGetAsync (int? timestamp, int? userId, double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? qmScore, string error, string createdAt, string updatedAt, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Correlation
        /// </summary>
        /// <remarks>
        /// Store Correlation
        /// </remarks>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 CorrelationsPost (Correlation body);
  
        /// <summary>
        /// Store Correlation
        /// </summary>
        /// <remarks>
        /// Store Correlation
        /// </remarks>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>InlineResponse2008</returns>
        System.Threading.Tasks.Task<InlineResponse2008> CorrelationsPostAsync (Correlation body);
        
        /// <summary>
        /// Get Correlation
        /// </summary>
        /// <remarks>
        /// Get Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 CorrelationsIdGet (int? id);
  
        /// <summary>
        /// Get Correlation
        /// </summary>
        /// <remarks>
        /// Get Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <returns>InlineResponse2008</returns>
        System.Threading.Tasks.Task<InlineResponse2008> CorrelationsIdGetAsync (int? id);
        
        /// <summary>
        /// Update Correlation
        /// </summary>
        /// <remarks>
        /// Update Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CorrelationsIdPut (int? id, Correlation body);
  
        /// <summary>
        /// Update Correlation
        /// </summary>
        /// <remarks>
        /// Update Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CorrelationsIdPutAsync (int? id, Correlation body);
        
        /// <summary>
        /// Delete Correlation
        /// </summary>
        /// <remarks>
        /// Delete Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CorrelationsIdDelete (int? id);
  
        /// <summary>
        /// Delete Correlation
        /// </summary>
        /// <remarks>
        /// Delete Correlation
        /// </remarks>
        /// <param name="id">id of Correlation</param>
        /// <returns>InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> CorrelationsIdDeleteAsync (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CorrelationApi : ICorrelationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CorrelationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CorrelationApi(String basePath)
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
        /// Get all Correlations Get all Correlations
        /// </summary>
        /// <param name="timestamp">timestamp</param> 
        /// <param name="userId">user_id</param> 
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
        /// <param name="statisticalSignificance">statistical_significance</param> 
        /// <param name="causeUnit">cause_unit</param> 
        /// <param name="causeUnitId">cause_unit_id</param> 
        /// <param name="causeChanges">cause_changes</param> 
        /// <param name="effectChanges">effect_changes</param> 
        /// <param name="qmScore">qm_score</param> 
        /// <param name="error">error</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="reversePearsonCorrelationCoefficient">reverse_pearson_correlation_coefficient</param> 
        /// <param name="predictivePearsonCorrelationCoefficient">predictive_pearson_correlation_coefficient</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse2007</returns>            
        public InlineResponse2007 CorrelationsGet (int? timestamp, int? userId, double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? qmScore, string error, string createdAt, string updatedAt, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/correlations";
    
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
            
            if (timestamp != null) queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
            if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
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
            if (statisticalSignificance != null) queryParams.Add("statistical_significance", ApiClient.ParameterToString(statisticalSignificance)); // query parameter
            if (causeUnit != null) queryParams.Add("cause_unit", ApiClient.ParameterToString(causeUnit)); // query parameter
            if (causeUnitId != null) queryParams.Add("cause_unit_id", ApiClient.ParameterToString(causeUnitId)); // query parameter
            if (causeChanges != null) queryParams.Add("cause_changes", ApiClient.ParameterToString(causeChanges)); // query parameter
            if (effectChanges != null) queryParams.Add("effect_changes", ApiClient.ParameterToString(effectChanges)); // query parameter
            if (qmScore != null) queryParams.Add("qm_score", ApiClient.ParameterToString(qmScore)); // query parameter
            if (error != null) queryParams.Add("error", ApiClient.ParameterToString(error)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2007) ApiClient.Deserialize(response, typeof(InlineResponse2007));
        }
    
        /// <summary>
        /// Get all Correlations Get all Correlations
        /// </summary>
        /// <param name="timestamp">timestamp</param>
        /// <param name="userId">user_id</param>
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
        /// <param name="statisticalSignificance">statistical_significance</param>
        /// <param name="causeUnit">cause_unit</param>
        /// <param name="causeUnitId">cause_unit_id</param>
        /// <param name="causeChanges">cause_changes</param>
        /// <param name="effectChanges">effect_changes</param>
        /// <param name="qmScore">qm_score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="reversePearsonCorrelationCoefficient">reverse_pearson_correlation_coefficient</param>
        /// <param name="predictivePearsonCorrelationCoefficient">predictive_pearson_correlation_coefficient</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2007</returns>
        public async System.Threading.Tasks.Task<InlineResponse2007> CorrelationsGetAsync (int? timestamp, int? userId, double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? qmScore, string error, string createdAt, string updatedAt, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort)
        {
            
    
            var path_ = "/correlations";
    
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
            
            if (timestamp != null) queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
            if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
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
            if (statisticalSignificance != null) queryParams.Add("statistical_significance", ApiClient.ParameterToString(statisticalSignificance)); // query parameter
            if (causeUnit != null) queryParams.Add("cause_unit", ApiClient.ParameterToString(causeUnit)); // query parameter
            if (causeUnitId != null) queryParams.Add("cause_unit_id", ApiClient.ParameterToString(causeUnitId)); // query parameter
            if (causeChanges != null) queryParams.Add("cause_changes", ApiClient.ParameterToString(causeChanges)); // query parameter
            if (effectChanges != null) queryParams.Add("effect_changes", ApiClient.ParameterToString(effectChanges)); // query parameter
            if (qmScore != null) queryParams.Add("qm_score", ApiClient.ParameterToString(qmScore)); // query parameter
            if (error != null) queryParams.Add("error", ApiClient.ParameterToString(error)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsGet: " + response.Content, response.Content);

            return (InlineResponse2007) ApiClient.Deserialize(response, typeof(InlineResponse2007));
        }
        
        /// <summary>
        /// Store Correlation Store Correlation
        /// </summary>
        /// <param name="body">Correlation that should be stored</param> 
        /// <returns>InlineResponse2008</returns>            
        public InlineResponse2008 CorrelationsPost (Correlation body)
        {
            
    
            var path_ = "/correlations";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response, typeof(InlineResponse2008));
        }
    
        /// <summary>
        /// Store Correlation Store Correlation
        /// </summary>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>InlineResponse2008</returns>
        public async System.Threading.Tasks.Task<InlineResponse2008> CorrelationsPostAsync (Correlation body)
        {
            
    
            var path_ = "/correlations";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsPost: " + response.Content, response.Content);

            return (InlineResponse2008) ApiClient.Deserialize(response, typeof(InlineResponse2008));
        }
        
        /// <summary>
        /// Get Correlation Get Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <returns>InlineResponse2008</returns>            
        public InlineResponse2008 CorrelationsIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdGet");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response, typeof(InlineResponse2008));
        }
    
        /// <summary>
        /// Get Correlation Get Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <returns>InlineResponse2008</returns>
        public async System.Threading.Tasks.Task<InlineResponse2008> CorrelationsIdGetAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdGet");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdGet: " + response.Content, response.Content);

            return (InlineResponse2008) ApiClient.Deserialize(response, typeof(InlineResponse2008));
        }
        
        /// <summary>
        /// Update Correlation Update Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="body">Correlation that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CorrelationsIdPut (int? id, Correlation body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdPut");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Update Correlation Update Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CorrelationsIdPutAsync (int? id, Correlation body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdPut");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdPut: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
        /// <summary>
        /// Delete Correlation Delete Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CorrelationsIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdDelete");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
    
        /// <summary>
        /// Delete Correlation Delete Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <returns>InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> CorrelationsIdDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdDelete");
            
    
            var path_ = "/correlations/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdDelete: " + response.Content, response.Content);

            return (InlineResponse2002) ApiClient.Deserialize(response, typeof(InlineResponse2002));
        }
        
    }
    
}
