using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IPairsApi
    {
        
        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings.</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings.</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>List<Pairs></returns>
        List<Pairs> PairsGet (string cause, string effect, string causeSource, string causeUnit, string delay, string duration, string effectSource, string effectUnit, string endTime, string startTime, int? limit, int? offset, int? sort);
  
        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings.</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings.</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>List<Pairs></returns>
        System.Threading.Tasks.Task<List<Pairs>> PairsGetAsync (string cause, string effect, string causeSource, string causeUnit, string delay, string duration, string effectSource, string effectUnit, string endTime, string startTime, int? limit, int? offset, int? sort);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PairsApi : IPairsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PairsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PairsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PairsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PairsApi(String basePath)
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
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param> 
        /// <param name="effect">Original variable name for the outcome or dependent variable</param> 
        /// <param name="causeSource">Name of data source that the cause measurements should come from</param> 
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in</param> 
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings.</param> 
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings.</param> 
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from</param> 
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in</param> 
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements</param> 
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param> 
        /// <returns>List<Pairs></returns>            
        public List<Pairs> PairsGet (string cause, string effect, string causeSource, string causeUnit, string delay, string duration, string effectSource, string effectUnit, string endTime, string startTime, int? limit, int? offset, int? sort)
        {
            
            // verify the required parameter 'cause' is set
            if (cause == null) throw new ApiException(400, "Missing required parameter 'cause' when calling PairsGet");
            
            // verify the required parameter 'effect' is set
            if (effect == null) throw new ApiException(400, "Missing required parameter 'effect' when calling PairsGet");
            
    
            var path = "/pairs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
            if (causeSource != null) queryParams.Add("causeSource", ApiClient.ParameterToString(causeSource)); // query parameter
            if (causeUnit != null) queryParams.Add("causeUnit", ApiClient.ParameterToString(causeUnit)); // query parameter
            if (delay != null) queryParams.Add("delay", ApiClient.ParameterToString(delay)); // query parameter
            if (duration != null) queryParams.Add("duration", ApiClient.ParameterToString(duration)); // query parameter
            if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
            if (effectSource != null) queryParams.Add("effectSource", ApiClient.ParameterToString(effectSource)); // query parameter
            if (effectUnit != null) queryParams.Add("effectUnit", ApiClient.ParameterToString(effectUnit)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PairsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PairsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Pairs>) ApiClient.Deserialize(response.Content, typeof(List<Pairs>), response.Headers);
        }
    
        /// <summary>
        /// Get pairs Pairs cause measurements with effect measurements grouped over the duration of action after the onset delay.
        /// </summary>
        /// <param name="cause">Original variable name for the explanatory or independent variable</param>
        /// <param name="effect">Original variable name for the outcome or dependent variable</param>
        /// <param name="causeSource">Name of data source that the cause measurements should come from</param>
        /// <param name="causeUnit">Abbreviated name for the unit cause measurements to be returned in</param>
        /// <param name="delay">Delay before onset of action (in seconds) from the cause variable settings.</param>
        /// <param name="duration">Duration of action (in seconds) from the cause variable settings.</param>
        /// <param name="effectSource">Name of data source that the effectmeasurements should come from</param>
        /// <param name="effectUnit">Abbreviated name for the unit effect measurements to be returned in</param>
        /// <param name="endTime">The most recent date (in epoch time) for which we should return measurements</param>
        /// <param name="startTime">The earliest date (in epoch time) for which we should return measurements</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with `-, it will sort in descending order.</param>
        /// <returns>List<Pairs></returns>
        public async System.Threading.Tasks.Task<List<Pairs>> PairsGetAsync (string cause, string effect, string causeSource, string causeUnit, string delay, string duration, string effectSource, string effectUnit, string endTime, string startTime, int? limit, int? offset, int? sort)
        {
            // verify the required parameter 'cause' is set
            if (cause == null) throw new ApiException(400, "Missing required parameter 'cause' when calling PairsGet");
            // verify the required parameter 'effect' is set
            if (effect == null) throw new ApiException(400, "Missing required parameter 'effect' when calling PairsGet");
            
    
            var path = "/pairs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
            if (causeSource != null) queryParams.Add("causeSource", ApiClient.ParameterToString(causeSource)); // query parameter
            if (causeUnit != null) queryParams.Add("causeUnit", ApiClient.ParameterToString(causeUnit)); // query parameter
            if (delay != null) queryParams.Add("delay", ApiClient.ParameterToString(delay)); // query parameter
            if (duration != null) queryParams.Add("duration", ApiClient.ParameterToString(duration)); // query parameter
            if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
            if (effectSource != null) queryParams.Add("effectSource", ApiClient.ParameterToString(effectSource)); // query parameter
            if (effectUnit != null) queryParams.Add("effectUnit", ApiClient.ParameterToString(effectUnit)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PairsGet: " + response.Content, response.Content);

            return (List<Pairs>) ApiClient.Deserialize(response.Content, typeof(List<Pairs>), response.Headers);
        }
        
    }
    
}
