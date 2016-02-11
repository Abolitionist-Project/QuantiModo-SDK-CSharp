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
    public interface ITrackingReminderApi
    {
        
        /// <summary>
        /// Get tracking reminders
        /// </summary>
        /// <remarks>
        /// Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param>
        /// <param name="userId">ID of the user who created a reminder</param>
        /// <param name="variableId">Id for the variable to be tracked</param>
        /// <param name="popUp">True if the reminders should appear as a popup notification</param>
        /// <param name="sms">True if the reminders should be delivered via SMS</param>
        /// <param name="email">True if the reminders should be delivered via email</param>
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param>
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param>
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 TrackingRemindersGet (string accessToken = null, string clientId = null, int? userId = null, int? variableId = null, bool? popUp = null, bool? sms = null, bool? email = null, bool? notificationBar = null, string lastReminded = null, string lastTracked = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get tracking reminders
        /// </summary>
        /// <remarks>
        /// Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param>
        /// <param name="userId">ID of the user who created a reminder</param>
        /// <param name="variableId">Id for the variable to be tracked</param>
        /// <param name="popUp">True if the reminders should appear as a popup notification</param>
        /// <param name="sms">True if the reminders should be delivered via SMS</param>
        /// <param name="email">True if the reminders should be delivered via email</param>
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param>
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param>
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> TrackingRemindersGetWithHttpInfo (string accessToken = null, string clientId = null, int? userId = null, int? variableId = null, bool? popUp = null, bool? sms = null, bool? email = null, bool? notificationBar = null, string lastReminded = null, string lastTracked = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get tracking reminders
        /// </summary>
        /// <remarks>
        /// Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param>
        /// <param name="userId">ID of the user who created a reminder</param>
        /// <param name="variableId">Id for the variable to be tracked</param>
        /// <param name="popUp">True if the reminders should appear as a popup notification</param>
        /// <param name="sms">True if the reminders should be delivered via SMS</param>
        /// <param name="email">True if the reminders should be delivered via email</param>
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param>
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param>
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> TrackingRemindersGetAsync (string accessToken = null, string clientId = null, int? userId = null, int? variableId = null, bool? popUp = null, bool? sms = null, bool? email = null, bool? notificationBar = null, string lastReminded = null, string lastTracked = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get tracking reminders
        /// </summary>
        /// <remarks>
        /// Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param>
        /// <param name="userId">ID of the user who created a reminder</param>
        /// <param name="variableId">Id for the variable to be tracked</param>
        /// <param name="popUp">True if the reminders should appear as a popup notification</param>
        /// <param name="sms">True if the reminders should be delivered via SMS</param>
        /// <param name="email">True if the reminders should be delivered via email</param>
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param>
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param>
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> TrackingRemindersGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? userId = null, int? variableId = null, bool? popUp = null, bool? sms = null, bool? email = null, bool? notificationBar = null, string lastReminded = null, string lastTracked = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store TrackingReminder
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be stored</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 TrackingRemindersPost (string accessToken = null, TrackingReminder body = null);
  
        /// <summary>
        /// Store TrackingReminder
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20023</returns>
        ApiResponse<InlineResponse20023> TrackingRemindersPostWithHttpInfo (string accessToken = null, TrackingReminder body = null);

        /// <summary>
        /// Store TrackingReminder
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be stored</param>
        /// <returns>Task of InlineResponse20023</returns>
        System.Threading.Tasks.Task<InlineResponse20023> TrackingRemindersPostAsync (string accessToken = null, TrackingReminder body = null);

        /// <summary>
        /// Store TrackingReminder
        /// </summary>
        /// <remarks>
        /// This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20023)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20023>> TrackingRemindersPostAsyncWithHttpInfo (string accessToken = null, TrackingReminder body = null);
        
        /// <summary>
        /// Get TrackingReminder
        /// </summary>
        /// <remarks>
        /// Get TrackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 TrackingRemindersIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get TrackingReminder
        /// </summary>
        /// <remarks>
        /// Get TrackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20023</returns>
        ApiResponse<InlineResponse20023> TrackingRemindersIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get TrackingReminder
        /// </summary>
        /// <remarks>
        /// Get TrackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20023</returns>
        System.Threading.Tasks.Task<InlineResponse20023> TrackingRemindersIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get TrackingReminder
        /// </summary>
        /// <remarks>
        /// Get TrackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20023)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20023>> TrackingRemindersIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update TrackingReminder
        /// </summary>
        /// <remarks>
        /// Update TrackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 TrackingRemindersIdPut (int? id, string accessToken = null, TrackingReminder body = null);
  
        /// <summary>
        /// Update TrackingReminder
        /// </summary>
        /// <remarks>
        /// Update TrackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> TrackingRemindersIdPutWithHttpInfo (int? id, string accessToken = null, TrackingReminder body = null);

        /// <summary>
        /// Update TrackingReminder
        /// </summary>
        /// <remarks>
        /// Update TrackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> TrackingRemindersIdPutAsync (int? id, string accessToken = null, TrackingReminder body = null);

        /// <summary>
        /// Update TrackingReminder
        /// </summary>
        /// <remarks>
        /// Update TrackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> TrackingRemindersIdPutAsyncWithHttpInfo (int? id, string accessToken = null, TrackingReminder body = null);
        
        /// <summary>
        /// Delete TrackingReminder
        /// </summary>
        /// <remarks>
        /// Delete previously posted trackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 TrackingRemindersIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete TrackingReminder
        /// </summary>
        /// <remarks>
        /// Delete previously posted trackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> TrackingRemindersIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete TrackingReminder
        /// </summary>
        /// <remarks>
        /// Delete previously posted trackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> TrackingRemindersIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete TrackingReminder
        /// </summary>
        /// <remarks>
        /// Delete previously posted trackingReminder
        /// </remarks>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> TrackingRemindersIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TrackingReminderApi : ITrackingReminderApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingReminderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TrackingReminderApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingReminderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TrackingReminderApi(Configuration configuration = null)
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
        /// Get tracking reminders Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param> 
        /// <param name="userId">ID of the user who created a reminder</param> 
        /// <param name="variableId">Id for the variable to be tracked</param> 
        /// <param name="popUp">True if the reminders should appear as a popup notification</param> 
        /// <param name="sms">True if the reminders should be delivered via SMS</param> 
        /// <param name="email">True if the reminders should be delivered via email</param> 
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param> 
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param> 
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 TrackingRemindersGet (string accessToken = null, string clientId = null, int? userId = null, int? variableId = null, bool? popUp = null, bool? sms = null, bool? email = null, bool? notificationBar = null, string lastReminded = null, string lastTracked = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2006> response = TrackingRemindersGetWithHttpInfo(accessToken, clientId, userId, variableId, popUp, sms, email, notificationBar, lastReminded, lastTracked, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get tracking reminders Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param> 
        /// <param name="userId">ID of the user who created a reminder</param> 
        /// <param name="variableId">Id for the variable to be tracked</param> 
        /// <param name="popUp">True if the reminders should appear as a popup notification</param> 
        /// <param name="sms">True if the reminders should be delivered via SMS</param> 
        /// <param name="email">True if the reminders should be delivered via email</param> 
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param> 
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param> 
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > TrackingRemindersGetWithHttpInfo (string accessToken = null, string clientId = null, int? userId = null, int? variableId = null, bool? popUp = null, bool? sms = null, bool? email = null, bool? notificationBar = null, string lastReminded = null, string lastTracked = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/trackingReminders";
    
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
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (popUp != null) queryParams.Add("pop_up", Configuration.ApiClient.ParameterToString(popUp)); // query parameter
            if (sms != null) queryParams.Add("sms", Configuration.ApiClient.ParameterToString(sms)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (notificationBar != null) queryParams.Add("notification_bar", Configuration.ApiClient.ParameterToString(notificationBar)); // query parameter
            if (lastReminded != null) queryParams.Add("last_reminded", Configuration.ApiClient.ParameterToString(lastReminded)); // query parameter
            if (lastTracked != null) queryParams.Add("last_tracked", Configuration.ApiClient.ParameterToString(lastTracked)); // query parameter
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2006>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2006)));
            
        }
    
        /// <summary>
        /// Get tracking reminders Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param>
        /// <param name="userId">ID of the user who created a reminder</param>
        /// <param name="variableId">Id for the variable to be tracked</param>
        /// <param name="popUp">True if the reminders should appear as a popup notification</param>
        /// <param name="sms">True if the reminders should be delivered via SMS</param>
        /// <param name="email">True if the reminders should be delivered via email</param>
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param>
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param>
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> TrackingRemindersGetAsync (string accessToken = null, string clientId = null, int? userId = null, int? variableId = null, bool? popUp = null, bool? sms = null, bool? email = null, bool? notificationBar = null, string lastReminded = null, string lastTracked = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2006> response = await TrackingRemindersGetAsyncWithHttpInfo(accessToken, clientId, userId, variableId, popUp, sms, email, notificationBar, lastReminded, lastTracked, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get tracking reminders Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param>
        /// <param name="userId">ID of the user who created a reminder</param>
        /// <param name="variableId">Id for the variable to be tracked</param>
        /// <param name="popUp">True if the reminders should appear as a popup notification</param>
        /// <param name="sms">True if the reminders should be delivered via SMS</param>
        /// <param name="email">True if the reminders should be delivered via email</param>
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param>
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param>
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> TrackingRemindersGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? userId = null, int? variableId = null, bool? popUp = null, bool? sms = null, bool? email = null, bool? notificationBar = null, string lastReminded = null, string lastTracked = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/trackingReminders";
    
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
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (popUp != null) queryParams.Add("pop_up", Configuration.ApiClient.ParameterToString(popUp)); // query parameter
            if (sms != null) queryParams.Add("sms", Configuration.ApiClient.ParameterToString(sms)); // query parameter
            if (email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (notificationBar != null) queryParams.Add("notification_bar", Configuration.ApiClient.ParameterToString(notificationBar)); // query parameter
            if (lastReminded != null) queryParams.Add("last_reminded", Configuration.ApiClient.ParameterToString(lastReminded)); // query parameter
            if (lastTracked != null) queryParams.Add("last_tracked", Configuration.ApiClient.ParameterToString(lastTracked)); // query parameter
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2006>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2006)));
            
        }
        
        /// <summary>
        /// Store TrackingReminder This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">TrackingReminder that should be stored</param> 
        /// <returns>InlineResponse20023</returns>
        public InlineResponse20023 TrackingRemindersPost (string accessToken = null, TrackingReminder body = null)
        {
             ApiResponse<InlineResponse20023> response = TrackingRemindersPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store TrackingReminder This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">TrackingReminder that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20023</returns>
        public ApiResponse< InlineResponse20023 > TrackingRemindersPostWithHttpInfo (string accessToken = null, TrackingReminder body = null)
        {
            
    
            var path_ = "/trackingReminders";
    
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20023>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20023) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20023)));
            
        }
    
        /// <summary>
        /// Store TrackingReminder This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be stored</param>
        /// <returns>Task of InlineResponse20023</returns>
        public async System.Threading.Tasks.Task<InlineResponse20023> TrackingRemindersPostAsync (string accessToken = null, TrackingReminder body = null)
        {
             ApiResponse<InlineResponse20023> response = await TrackingRemindersPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store TrackingReminder This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20023)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20023>> TrackingRemindersPostAsyncWithHttpInfo (string accessToken = null, TrackingReminder body = null)
        {
            
    
            var path_ = "/trackingReminders";
    
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20023>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20023) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20023)));
            
        }
        
        /// <summary>
        /// Get TrackingReminder Get TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20023</returns>
        public InlineResponse20023 TrackingRemindersIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20023> response = TrackingRemindersIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get TrackingReminder Get TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20023</returns>
        public ApiResponse< InlineResponse20023 > TrackingRemindersIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TrackingReminderApi->TrackingRemindersIdGet");
            
    
            var path_ = "/trackingReminders/{id}";
    
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20023>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20023) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20023)));
            
        }
    
        /// <summary>
        /// Get TrackingReminder Get TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20023</returns>
        public async System.Threading.Tasks.Task<InlineResponse20023> TrackingRemindersIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20023> response = await TrackingRemindersIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get TrackingReminder Get TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20023)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20023>> TrackingRemindersIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrackingRemindersIdGet");
            
    
            var path_ = "/trackingReminders/{id}";
    
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20023>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20023) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20023)));
            
        }
        
        /// <summary>
        /// Update TrackingReminder Update TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">TrackingReminder that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 TrackingRemindersIdPut (int? id, string accessToken = null, TrackingReminder body = null)
        {
             ApiResponse<InlineResponse2002> response = TrackingRemindersIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update TrackingReminder Update TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">TrackingReminder that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > TrackingRemindersIdPutWithHttpInfo (int? id, string accessToken = null, TrackingReminder body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TrackingReminderApi->TrackingRemindersIdPut");
            
    
            var path_ = "/trackingReminders/{id}";
    
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update TrackingReminder Update TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> TrackingRemindersIdPutAsync (int? id, string accessToken = null, TrackingReminder body = null)
        {
             ApiResponse<InlineResponse2002> response = await TrackingRemindersIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update TrackingReminder Update TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> TrackingRemindersIdPutAsyncWithHttpInfo (int? id, string accessToken = null, TrackingReminder body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrackingRemindersIdPut");
            
    
            var path_ = "/trackingReminders/{id}";
    
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete TrackingReminder Delete previously posted trackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 TrackingRemindersIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = TrackingRemindersIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete TrackingReminder Delete previously posted trackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > TrackingRemindersIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TrackingReminderApi->TrackingRemindersIdDelete");
            
    
            var path_ = "/trackingReminders/{id}";
    
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete TrackingReminder Delete previously posted trackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> TrackingRemindersIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await TrackingRemindersIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete TrackingReminder Delete previously posted trackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> TrackingRemindersIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrackingRemindersIdDelete");
            
    
            var path_ = "/trackingReminders/{id}";
    
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
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TrackingRemindersIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
