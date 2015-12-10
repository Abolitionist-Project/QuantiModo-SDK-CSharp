using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationApi
    {
        
        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 OrganizationConnectionsGet (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> OrganizationConnectionsGetWithHttpInfo (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> OrganizationConnectionsGetAsync (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Connections
        /// </summary>
        /// <remarks>
        /// Get all Connections
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> OrganizationConnectionsGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 OrganizationCredentialsGet (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20011</returns>
        ApiResponse<InlineResponse20011> OrganizationCredentialsGetWithHttpInfo (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20011</returns>
        System.Threading.Tasks.Task<InlineResponse20011> OrganizationCredentialsGetAsync (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Credentials
        /// </summary>
        /// <remarks>
        /// Get all Credentials
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20011>> OrganizationCredentialsGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Get measurements for all users using your application
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 OrganizationMeasurementsGet (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get measurements for all users using your application
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> OrganizationMeasurementsGetWithHttpInfo (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get measurements for all users using your application
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> OrganizationMeasurementsGetAsync (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get measurements for all users using your application
        /// </summary>
        /// <remarks>
        /// Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> OrganizationMeasurementsGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Get all Updates
        /// </summary>
        /// <remarks>
        /// Get all Updates
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="success">success</param>
        /// <param name="message">message</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 OrganizationUpdatesGet (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all Updates
        /// </summary>
        /// <remarks>
        /// Get all Updates
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="success">success</param>
        /// <param name="message">message</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20015</returns>
        ApiResponse<InlineResponse20015> OrganizationUpdatesGetWithHttpInfo (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Updates
        /// </summary>
        /// <remarks>
        /// Get all Updates
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="success">success</param>
        /// <param name="message">message</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20015</returns>
        System.Threading.Tasks.Task<InlineResponse20015> OrganizationUpdatesGetAsync (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all Updates
        /// </summary>
        /// <remarks>
        /// Get all Updates
        /// </remarks>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="success">success</param>
        /// <param name="message">message</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20015)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20015>> OrganizationUpdatesGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="defaultUnitId">D of unit to use for this variable</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="variableCategoryId">ID of variable category</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param>
        /// <param name="numberOfMeasurements">Number of measurements</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param>
        /// <param name="lastUnitId">ID of last Unit</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit</param>
        /// <param name="lastOriginalValue">Last original value which is stored</param>
        /// <param name="lastValue">Last Value</param>
        /// <param name="lastOriginalValue2">Last original value which is stored</param>
        /// <param name="lastSourceId">ID of last source</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="standardDeviation">Standard deviation</param>
        /// <param name="variance">Variance</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param>
        /// <param name="mean">Mean</param>
        /// <param name="median">Median</param>
        /// <param name="mostCommonUnitId">Most common Unit ID</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param>
        /// <param name="numberOfChanges">Number of changes</param>
        /// <param name="skewness">Skewness</param>
        /// <param name="kurtosis">Kurtosis</param>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="location">Location</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param>
        /// <param name="earliestSourceTime">Earliest source time</param>
        /// <param name="latestSourceTime">Latest source time</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="earliestFillingTime">Earliest filling time</param>
        /// <param name="latestFillingTime">Latest filling time</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 OrganizationUserVariablesGet (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);
  
        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="defaultUnitId">D of unit to use for this variable</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="variableCategoryId">ID of variable category</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param>
        /// <param name="numberOfMeasurements">Number of measurements</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param>
        /// <param name="lastUnitId">ID of last Unit</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit</param>
        /// <param name="lastOriginalValue">Last original value which is stored</param>
        /// <param name="lastValue">Last Value</param>
        /// <param name="lastOriginalValue2">Last original value which is stored</param>
        /// <param name="lastSourceId">ID of last source</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="standardDeviation">Standard deviation</param>
        /// <param name="variance">Variance</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param>
        /// <param name="mean">Mean</param>
        /// <param name="median">Median</param>
        /// <param name="mostCommonUnitId">Most common Unit ID</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param>
        /// <param name="numberOfChanges">Number of changes</param>
        /// <param name="skewness">Skewness</param>
        /// <param name="kurtosis">Kurtosis</param>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="location">Location</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param>
        /// <param name="earliestSourceTime">Earliest source time</param>
        /// <param name="latestSourceTime">Latest source time</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="earliestFillingTime">Earliest filling time</param>
        /// <param name="latestFillingTime">Latest filling time</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>ApiResponse of InlineResponse20016</returns>
        ApiResponse<InlineResponse20016> OrganizationUserVariablesGetWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="defaultUnitId">D of unit to use for this variable</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="variableCategoryId">ID of variable category</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param>
        /// <param name="numberOfMeasurements">Number of measurements</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param>
        /// <param name="lastUnitId">ID of last Unit</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit</param>
        /// <param name="lastOriginalValue">Last original value which is stored</param>
        /// <param name="lastValue">Last Value</param>
        /// <param name="lastOriginalValue2">Last original value which is stored</param>
        /// <param name="lastSourceId">ID of last source</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="standardDeviation">Standard deviation</param>
        /// <param name="variance">Variance</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param>
        /// <param name="mean">Mean</param>
        /// <param name="median">Median</param>
        /// <param name="mostCommonUnitId">Most common Unit ID</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param>
        /// <param name="numberOfChanges">Number of changes</param>
        /// <param name="skewness">Skewness</param>
        /// <param name="kurtosis">Kurtosis</param>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="location">Location</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param>
        /// <param name="earliestSourceTime">Earliest source time</param>
        /// <param name="latestSourceTime">Latest source time</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="earliestFillingTime">Earliest filling time</param>
        /// <param name="latestFillingTime">Latest filling time</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20016</returns>
        System.Threading.Tasks.Task<InlineResponse20016> OrganizationUserVariablesGetAsync (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);

        /// <summary>
        /// Get all UserVariables
        /// </summary>
        /// <remarks>
        /// Get all UserVariables
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="defaultUnitId">D of unit to use for this variable</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="variableCategoryId">ID of variable category</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param>
        /// <param name="numberOfMeasurements">Number of measurements</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param>
        /// <param name="lastUnitId">ID of last Unit</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit</param>
        /// <param name="lastOriginalValue">Last original value which is stored</param>
        /// <param name="lastValue">Last Value</param>
        /// <param name="lastOriginalValue2">Last original value which is stored</param>
        /// <param name="lastSourceId">ID of last source</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="standardDeviation">Standard deviation</param>
        /// <param name="variance">Variance</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param>
        /// <param name="mean">Mean</param>
        /// <param name="median">Median</param>
        /// <param name="mostCommonUnitId">Most common Unit ID</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param>
        /// <param name="numberOfChanges">Number of changes</param>
        /// <param name="skewness">Skewness</param>
        /// <param name="kurtosis">Kurtosis</param>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="location">Location</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param>
        /// <param name="earliestSourceTime">Earliest source time</param>
        /// <param name="latestSourceTime">Latest source time</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="earliestFillingTime">Earliest filling time</param>
        /// <param name="latestFillingTime">Latest filling time</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20016)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20016>> OrganizationUserVariablesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrganizationApi : IOrganizationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrganizationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrganizationApi(Configuration configuration = null)
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
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param> 
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param> 
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param> 
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param> 
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param> 
        /// <param name="updateError">Indicates if there was an error during the update.</param> 
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 OrganizationConnectionsGet (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2005> response = OrganizationConnectionsGetWithHttpInfo(accessToken, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param> 
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param> 
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param> 
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param> 
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param> 
        /// <param name="updateError">Indicates if there was an error during the update.</param> 
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > OrganizationConnectionsGetWithHttpInfo (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/connections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (connectStatus != null) queryParams.Add("connect_status", Configuration.ApiClient.ParameterToString(connectStatus)); // query parameter
            if (connectError != null) queryParams.Add("connect_error", Configuration.ApiClient.ParameterToString(connectError)); // query parameter
            if (updateRequestedAt != null) queryParams.Add("update_requested_at", Configuration.ApiClient.ParameterToString(updateRequestedAt)); // query parameter
            if (updateStatus != null) queryParams.Add("update_status", Configuration.ApiClient.ParameterToString(updateStatus)); // query parameter
            if (updateError != null) queryParams.Add("update_error", Configuration.ApiClient.ParameterToString(updateError)); // query parameter
            if (lastSuccessfulUpdatedAt != null) queryParams.Add("last_successful_updated_at", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationConnectionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationConnectionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2005>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2005)));
            
        }
    
        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> OrganizationConnectionsGetAsync (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse2005> response = await OrganizationConnectionsGetAsyncWithHttpInfo(accessToken, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> OrganizationConnectionsGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, string connectStatus = null, string connectError = null, string updateRequestedAt = null, string updateStatus = null, string updateError = null, string lastSuccessfulUpdatedAt = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/connections";
    
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (connectStatus != null) queryParams.Add("connect_status", Configuration.ApiClient.ParameterToString(connectStatus)); // query parameter
            if (connectError != null) queryParams.Add("connect_error", Configuration.ApiClient.ParameterToString(connectError)); // query parameter
            if (updateRequestedAt != null) queryParams.Add("update_requested_at", Configuration.ApiClient.ParameterToString(updateRequestedAt)); // query parameter
            if (updateStatus != null) queryParams.Add("update_status", Configuration.ApiClient.ParameterToString(updateStatus)); // query parameter
            if (updateError != null) queryParams.Add("update_error", Configuration.ApiClient.ParameterToString(updateError)); // query parameter
            if (lastSuccessfulUpdatedAt != null) queryParams.Add("last_successful_updated_at", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationConnectionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationConnectionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2005>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2005)));
            
        }
        
        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param> 
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param> 
        /// <param name="attrValue">Encrypted value for the attribute specified</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20011</returns>
        public InlineResponse20011 OrganizationCredentialsGet (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20011> response = OrganizationCredentialsGetWithHttpInfo(accessToken, connectorId, attrKey, attrValue, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param> 
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param> 
        /// <param name="attrValue">Encrypted value for the attribute specified</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20011</returns>
        public ApiResponse< InlineResponse20011 > OrganizationCredentialsGetWithHttpInfo (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/credentials";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (attrKey != null) queryParams.Add("attr_key", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            if (attrValue != null) queryParams.Add("attr_value", Configuration.ApiClient.ParameterToString(attrValue)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationCredentialsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationCredentialsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20011>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20011) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20011)));
            
        }
    
        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20011</returns>
        public async System.Threading.Tasks.Task<InlineResponse20011> OrganizationCredentialsGetAsync (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20011> response = await OrganizationCredentialsGetAsyncWithHttpInfo(accessToken, connectorId, attrKey, attrValue, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20011>> OrganizationCredentialsGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, string attrKey = null, string attrValue = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/credentials";
    
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (attrKey != null) queryParams.Add("attr_key", Configuration.ApiClient.ParameterToString(attrKey)); // query parameter
            if (attrValue != null) queryParams.Add("attr_value", Configuration.ApiClient.ParameterToString(attrValue)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationCredentialsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationCredentialsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20011>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20011) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20011)));
            
        }
        
        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param> 
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param> 
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param> 
        /// <param name="sourceId">Application or device used to record the measurement values</param> 
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param> 
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param> 
        /// <param name="unitId">The default unit id for the variable</param> 
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param> 
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param> 
        /// <param name="duration">Duration of the event being measurement in seconds</param> 
        /// <param name="note">An optional note the user may include with their measurement</param> 
        /// <param name="latitude">Latitude at which the measurement was taken</param> 
        /// <param name="longitude">Longitude at which the measurement was taken</param> 
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="error">An error message if there is a problem with the measurement</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 OrganizationMeasurementsGet (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20013> response = OrganizationMeasurementsGetWithHttpInfo(accessToken, clientId, connectorId, variableId, sourceId, startTime, value, unitId, originalValue, originalUnitId, duration, note, latitude, longitude, location, createdAt, updatedAt, error, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param> 
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param> 
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param> 
        /// <param name="sourceId">Application or device used to record the measurement values</param> 
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param> 
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param> 
        /// <param name="unitId">The default unit id for the variable</param> 
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param> 
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param> 
        /// <param name="duration">Duration of the event being measurement in seconds</param> 
        /// <param name="note">An optional note the user may include with their measurement</param> 
        /// <param name="latitude">Latitude at which the measurement was taken</param> 
        /// <param name="longitude">Longitude at which the measurement was taken</param> 
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="error">An error message if there is a problem with the measurement</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public ApiResponse< InlineResponse20013 > OrganizationMeasurementsGetWithHttpInfo (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/measurements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            if (startTime != null) queryParams.Add("start_time", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (value != null) queryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (unitId != null) queryParams.Add("unit_id", Configuration.ApiClient.ParameterToString(unitId)); // query parameter
            if (originalValue != null) queryParams.Add("original_value", Configuration.ApiClient.ParameterToString(originalValue)); // query parameter
            if (originalUnitId != null) queryParams.Add("original_unit_id", Configuration.ApiClient.ParameterToString(originalUnitId)); // query parameter
            if (duration != null) queryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (note != null) queryParams.Add("note", Configuration.ApiClient.ParameterToString(note)); // query parameter
            if (latitude != null) queryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (error != null) queryParams.Add("error", Configuration.ApiClient.ParameterToString(error)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationMeasurementsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationMeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
    
        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> OrganizationMeasurementsGetAsync (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20013> response = await OrganizationMeasurementsGetAsyncWithHttpInfo(accessToken, clientId, connectorId, variableId, sourceId, startTime, value, unitId, originalValue, originalUnitId, duration, note, latitude, longitude, location, createdAt, updatedAt, error, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> OrganizationMeasurementsGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? connectorId = null, int? variableId = null, int? sourceId = null, string startTime = null, double? value = null, int? unitId = null, double? originalValue = null, int? originalUnitId = null, int? duration = null, string note = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, string error = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/measurements";
    
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (sourceId != null) queryParams.Add("source_id", Configuration.ApiClient.ParameterToString(sourceId)); // query parameter
            if (startTime != null) queryParams.Add("start_time", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (value != null) queryParams.Add("value", Configuration.ApiClient.ParameterToString(value)); // query parameter
            if (unitId != null) queryParams.Add("unit_id", Configuration.ApiClient.ParameterToString(unitId)); // query parameter
            if (originalValue != null) queryParams.Add("original_value", Configuration.ApiClient.ParameterToString(originalValue)); // query parameter
            if (originalUnitId != null) queryParams.Add("original_unit_id", Configuration.ApiClient.ParameterToString(originalUnitId)); // query parameter
            if (duration != null) queryParams.Add("duration", Configuration.ApiClient.ParameterToString(duration)); // query parameter
            if (note != null) queryParams.Add("note", Configuration.ApiClient.ParameterToString(note)); // query parameter
            if (latitude != null) queryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (error != null) queryParams.Add("error", Configuration.ApiClient.ParameterToString(error)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationMeasurementsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationMeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20013>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20013) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20013)));
            
        }
        
        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">connector_id</param> 
        /// <param name="numberOfMeasurements">number_of_measurements</param> 
        /// <param name="success">success</param> 
        /// <param name="message">message</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20015</returns>
        public InlineResponse20015 OrganizationUpdatesGet (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20015> response = OrganizationUpdatesGetWithHttpInfo(accessToken, connectorId, numberOfMeasurements, success, message, createdAt, updatedAt, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">connector_id</param> 
        /// <param name="numberOfMeasurements">number_of_measurements</param> 
        /// <param name="success">success</param> 
        /// <param name="message">message</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20015</returns>
        public ApiResponse< InlineResponse20015 > OrganizationUpdatesGetWithHttpInfo (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/updates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (success != null) queryParams.Add("success", Configuration.ApiClient.ParameterToString(success)); // query parameter
            if (message != null) queryParams.Add("message", Configuration.ApiClient.ParameterToString(message)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationUpdatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationUpdatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20015>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20015) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20015)));
            
        }
    
        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="success">success</param>
        /// <param name="message">message</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20015</returns>
        public async System.Threading.Tasks.Task<InlineResponse20015> OrganizationUpdatesGetAsync (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20015> response = await OrganizationUpdatesGetAsyncWithHttpInfo(accessToken, connectorId, numberOfMeasurements, success, message, createdAt, updatedAt, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <param name="accessToken">Organization&#39;s OAuth2 access token</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="success">success</param>
        /// <param name="message">message</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20015)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20015>> OrganizationUpdatesGetAsyncWithHttpInfo (string accessToken = null, int? connectorId = null, int? numberOfMeasurements = null, bool? success = null, string message = null, string createdAt = null, string updatedAt = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/updates";
    
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (connectorId != null) queryParams.Add("connector_id", Configuration.ApiClient.ParameterToString(connectorId)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (success != null) queryParams.Add("success", Configuration.ApiClient.ParameterToString(success)); // query parameter
            if (message != null) queryParams.Add("message", Configuration.ApiClient.ParameterToString(message)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationUpdatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationUpdatesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20015>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20015) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20015)));
            
        }
        
        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="variableId">ID of variable</param> 
        /// <param name="defaultUnitId">D of unit to use for this variable</param> 
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param> 
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="variableCategoryId">ID of variable category</param> 
        /// <param name="updated">updated</param> 
        /// <param name="_public">Is variable public</param> 
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param> 
        /// <param name="numberOfMeasurements">Number of measurements</param> 
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param> 
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param> 
        /// <param name="lastUnitId">ID of last Unit</param> 
        /// <param name="lastOriginalUnitId">ID of last original Unit</param> 
        /// <param name="lastOriginalValue">Last original value which is stored</param> 
        /// <param name="lastValue">Last Value</param> 
        /// <param name="lastOriginalValue2">Last original value which is stored</param> 
        /// <param name="lastSourceId">ID of last source</param> 
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param> 
        /// <param name="standardDeviation">Standard deviation</param> 
        /// <param name="variance">Variance</param> 
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param> 
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param> 
        /// <param name="mean">Mean</param> 
        /// <param name="median">Median</param> 
        /// <param name="mostCommonUnitId">Most common Unit ID</param> 
        /// <param name="mostCommonValue">Most common value</param> 
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param> 
        /// <param name="numberOfChanges">Number of changes</param> 
        /// <param name="skewness">Skewness</param> 
        /// <param name="kurtosis">Kurtosis</param> 
        /// <param name="latitude">Latitude</param> 
        /// <param name="longitude">Longitude</param> 
        /// <param name="location">Location</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param> 
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param> 
        /// <param name="earliestSourceTime">Earliest source time</param> 
        /// <param name="latestSourceTime">Latest source time</param> 
        /// <param name="earliestMeasurementTime">Earliest measurement time</param> 
        /// <param name="latestMeasurementTime">Latest measurement time</param> 
        /// <param name="earliestFillingTime">Earliest filling time</param> 
        /// <param name="latestFillingTime">Latest filling time</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20016</returns>
        public InlineResponse20016 OrganizationUserVariablesGet (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20016> response = OrganizationUserVariablesGetWithHttpInfo(accessToken, clientId, parentId, variableId, defaultUnitId, minimumAllowedValue, maximumAllowedValue, fillingValue, joinWith, onsetDelay, durationOfAction, variableCategoryId, updated, _public, causeOnly, fillingType, numberOfMeasurements, numberOfProcessedMeasurements, measurementsAtLastAnalysis, lastUnitId, lastOriginalUnitId, lastOriginalValue, lastValue, lastOriginalValue2, lastSourceId, numberOfCorrelations, status, errorMessage, lastSuccessfulUpdateTime, standardDeviation, variance, minimumRecordedValue, maximumRecordedValue, mean, median, mostCommonUnitId, mostCommonValue, numberOfUniqueDailyValues, numberOfChanges, skewness, kurtosis, latitude, longitude, location, createdAt, updatedAt, outcome, sources, earliestSourceTime, latestSourceTime, earliestMeasurementTime, latestMeasurementTime, earliestFillingTime, latestFillingTime, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="variableId">ID of variable</param> 
        /// <param name="defaultUnitId">D of unit to use for this variable</param> 
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param> 
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="variableCategoryId">ID of variable category</param> 
        /// <param name="updated">updated</param> 
        /// <param name="_public">Is variable public</param> 
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param> 
        /// <param name="numberOfMeasurements">Number of measurements</param> 
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param> 
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param> 
        /// <param name="lastUnitId">ID of last Unit</param> 
        /// <param name="lastOriginalUnitId">ID of last original Unit</param> 
        /// <param name="lastOriginalValue">Last original value which is stored</param> 
        /// <param name="lastValue">Last Value</param> 
        /// <param name="lastOriginalValue2">Last original value which is stored</param> 
        /// <param name="lastSourceId">ID of last source</param> 
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param> 
        /// <param name="standardDeviation">Standard deviation</param> 
        /// <param name="variance">Variance</param> 
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param> 
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param> 
        /// <param name="mean">Mean</param> 
        /// <param name="median">Median</param> 
        /// <param name="mostCommonUnitId">Most common Unit ID</param> 
        /// <param name="mostCommonValue">Most common value</param> 
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param> 
        /// <param name="numberOfChanges">Number of changes</param> 
        /// <param name="skewness">Skewness</param> 
        /// <param name="kurtosis">Kurtosis</param> 
        /// <param name="latitude">Latitude</param> 
        /// <param name="longitude">Longitude</param> 
        /// <param name="location">Location</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param> 
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param> 
        /// <param name="earliestSourceTime">Earliest source time</param> 
        /// <param name="latestSourceTime">Latest source time</param> 
        /// <param name="earliestMeasurementTime">Earliest measurement time</param> 
        /// <param name="latestMeasurementTime">Latest measurement time</param> 
        /// <param name="earliestFillingTime">Earliest filling time</param> 
        /// <param name="latestFillingTime">Latest filling time</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>ApiResponse of InlineResponse20016</returns>
        public ApiResponse< InlineResponse20016 > OrganizationUserVariablesGetWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/userVariables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (parentId != null) queryParams.Add("parent_id", Configuration.ApiClient.ParameterToString(parentId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", Configuration.ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", Configuration.ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", Configuration.ApiClient.ParameterToString(fillingValue)); // query parameter
            if (joinWith != null) queryParams.Add("join_with", Configuration.ApiClient.ParameterToString(joinWith)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (variableCategoryId != null) queryParams.Add("variable_category_id", Configuration.ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (updated != null) queryParams.Add("updated", Configuration.ApiClient.ParameterToString(updated)); // query parameter
            if (_public != null) queryParams.Add("public", Configuration.ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", Configuration.ApiClient.ParameterToString(causeOnly)); // query parameter
            if (fillingType != null) queryParams.Add("filling_type", Configuration.ApiClient.ParameterToString(fillingType)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfProcessedMeasurements != null) queryParams.Add("number_of_processed_measurements", Configuration.ApiClient.ParameterToString(numberOfProcessedMeasurements)); // query parameter
            if (measurementsAtLastAnalysis != null) queryParams.Add("measurements_at_last_analysis", Configuration.ApiClient.ParameterToString(measurementsAtLastAnalysis)); // query parameter
            if (lastUnitId != null) queryParams.Add("last_unit_id", Configuration.ApiClient.ParameterToString(lastUnitId)); // query parameter
            if (lastOriginalUnitId != null) queryParams.Add("last_original_unit_id", Configuration.ApiClient.ParameterToString(lastOriginalUnitId)); // query parameter
            if (lastOriginalValue != null) queryParams.Add("last_original_value", Configuration.ApiClient.ParameterToString(lastOriginalValue)); // query parameter
            if (lastValue != null) queryParams.Add("last_value", Configuration.ApiClient.ParameterToString(lastValue)); // query parameter
            if (lastOriginalValue2 != null) queryParams.Add("last_original_value", Configuration.ApiClient.ParameterToString(lastOriginalValue2)); // query parameter
            if (lastSourceId != null) queryParams.Add("last_source_id", Configuration.ApiClient.ParameterToString(lastSourceId)); // query parameter
            if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", Configuration.ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (standardDeviation != null) queryParams.Add("standard_deviation", Configuration.ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) queryParams.Add("variance", Configuration.ApiClient.ParameterToString(variance)); // query parameter
            if (minimumRecordedValue != null) queryParams.Add("minimum_recorded_value", Configuration.ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
            if (maximumRecordedValue != null) queryParams.Add("maximum_recorded_value", Configuration.ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
            if (mean != null) queryParams.Add("mean", Configuration.ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) queryParams.Add("median", Configuration.ApiClient.ParameterToString(median)); // query parameter
            if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", Configuration.ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (mostCommonValue != null) queryParams.Add("most_common_value", Configuration.ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (numberOfUniqueDailyValues != null) queryParams.Add("number_of_unique_daily_values", Configuration.ApiClient.ParameterToString(numberOfUniqueDailyValues)); // query parameter
            if (numberOfChanges != null) queryParams.Add("number_of_changes", Configuration.ApiClient.ParameterToString(numberOfChanges)); // query parameter
            if (skewness != null) queryParams.Add("skewness", Configuration.ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) queryParams.Add("kurtosis", Configuration.ApiClient.ParameterToString(kurtosis)); // query parameter
            if (latitude != null) queryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (outcome != null) queryParams.Add("outcome", Configuration.ApiClient.ParameterToString(outcome)); // query parameter
            if (sources != null) queryParams.Add("sources", Configuration.ApiClient.ParameterToString(sources)); // query parameter
            if (earliestSourceTime != null) queryParams.Add("earliest_source_time", Configuration.ApiClient.ParameterToString(earliestSourceTime)); // query parameter
            if (latestSourceTime != null) queryParams.Add("latest_source_time", Configuration.ApiClient.ParameterToString(latestSourceTime)); // query parameter
            if (earliestMeasurementTime != null) queryParams.Add("earliest_measurement_time", Configuration.ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) queryParams.Add("latest_measurement_time", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (earliestFillingTime != null) queryParams.Add("earliest_filling_time", Configuration.ApiClient.ParameterToString(earliestFillingTime)); // query parameter
            if (latestFillingTime != null) queryParams.Add("latest_filling_time", Configuration.ApiClient.ParameterToString(latestFillingTime)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationUserVariablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationUserVariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20016>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20016) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20016)));
            
        }
    
        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="defaultUnitId">D of unit to use for this variable</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="variableCategoryId">ID of variable category</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param>
        /// <param name="numberOfMeasurements">Number of measurements</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param>
        /// <param name="lastUnitId">ID of last Unit</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit</param>
        /// <param name="lastOriginalValue">Last original value which is stored</param>
        /// <param name="lastValue">Last Value</param>
        /// <param name="lastOriginalValue2">Last original value which is stored</param>
        /// <param name="lastSourceId">ID of last source</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="standardDeviation">Standard deviation</param>
        /// <param name="variance">Variance</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param>
        /// <param name="mean">Mean</param>
        /// <param name="median">Median</param>
        /// <param name="mostCommonUnitId">Most common Unit ID</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param>
        /// <param name="numberOfChanges">Number of changes</param>
        /// <param name="skewness">Skewness</param>
        /// <param name="kurtosis">Kurtosis</param>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="location">Location</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param>
        /// <param name="earliestSourceTime">Earliest source time</param>
        /// <param name="latestSourceTime">Latest source time</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="earliestFillingTime">Earliest filling time</param>
        /// <param name="latestFillingTime">Latest filling time</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of InlineResponse20016</returns>
        public async System.Threading.Tasks.Task<InlineResponse20016> OrganizationUserVariablesGetAsync (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20016> response = await OrganizationUserVariablesGetAsyncWithHttpInfo(accessToken, clientId, parentId, variableId, defaultUnitId, minimumAllowedValue, maximumAllowedValue, fillingValue, joinWith, onsetDelay, durationOfAction, variableCategoryId, updated, _public, causeOnly, fillingType, numberOfMeasurements, numberOfProcessedMeasurements, measurementsAtLastAnalysis, lastUnitId, lastOriginalUnitId, lastOriginalValue, lastValue, lastOriginalValue2, lastSourceId, numberOfCorrelations, status, errorMessage, lastSuccessfulUpdateTime, standardDeviation, variance, minimumRecordedValue, maximumRecordedValue, mean, median, mostCommonUnitId, mostCommonValue, numberOfUniqueDailyValues, numberOfChanges, skewness, kurtosis, latitude, longitude, location, createdAt, updatedAt, outcome, sources, earliestSourceTime, latestSourceTime, earliestMeasurementTime, latestMeasurementTime, earliestFillingTime, latestFillingTime, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="defaultUnitId">D of unit to use for this variable</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="variableCategoryId">ID of variable category</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param>
        /// <param name="numberOfMeasurements">Number of measurements</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param>
        /// <param name="lastUnitId">ID of last Unit</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit</param>
        /// <param name="lastOriginalValue">Last original value which is stored</param>
        /// <param name="lastValue">Last Value</param>
        /// <param name="lastOriginalValue2">Last original value which is stored</param>
        /// <param name="lastSourceId">ID of last source</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="standardDeviation">Standard deviation</param>
        /// <param name="variance">Variance</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param>
        /// <param name="mean">Mean</param>
        /// <param name="median">Median</param>
        /// <param name="mostCommonUnitId">Most common Unit ID</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param>
        /// <param name="numberOfChanges">Number of changes</param>
        /// <param name="skewness">Skewness</param>
        /// <param name="kurtosis">Kurtosis</param>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="location">Location</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param>
        /// <param name="earliestSourceTime">Earliest source time</param>
        /// <param name="latestSourceTime">Latest source time</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="earliestFillingTime">Earliest filling time</param>
        /// <param name="latestFillingTime">Latest filling time</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>Task of ApiResponse (InlineResponse20016)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20016>> OrganizationUserVariablesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/organization/userVariables";
    
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            if (clientId != null) queryParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // query parameter
            if (parentId != null) queryParams.Add("parent_id", Configuration.ApiClient.ParameterToString(parentId)); // query parameter
            if (variableId != null) queryParams.Add("variable_id", Configuration.ApiClient.ParameterToString(variableId)); // query parameter
            if (defaultUnitId != null) queryParams.Add("default_unit_id", Configuration.ApiClient.ParameterToString(defaultUnitId)); // query parameter
            if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", Configuration.ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
            if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", Configuration.ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
            if (fillingValue != null) queryParams.Add("filling_value", Configuration.ApiClient.ParameterToString(fillingValue)); // query parameter
            if (joinWith != null) queryParams.Add("join_with", Configuration.ApiClient.ParameterToString(joinWith)); // query parameter
            if (onsetDelay != null) queryParams.Add("onset_delay", Configuration.ApiClient.ParameterToString(onsetDelay)); // query parameter
            if (durationOfAction != null) queryParams.Add("duration_of_action", Configuration.ApiClient.ParameterToString(durationOfAction)); // query parameter
            if (variableCategoryId != null) queryParams.Add("variable_category_id", Configuration.ApiClient.ParameterToString(variableCategoryId)); // query parameter
            if (updated != null) queryParams.Add("updated", Configuration.ApiClient.ParameterToString(updated)); // query parameter
            if (_public != null) queryParams.Add("public", Configuration.ApiClient.ParameterToString(_public)); // query parameter
            if (causeOnly != null) queryParams.Add("cause_only", Configuration.ApiClient.ParameterToString(causeOnly)); // query parameter
            if (fillingType != null) queryParams.Add("filling_type", Configuration.ApiClient.ParameterToString(fillingType)); // query parameter
            if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", Configuration.ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
            if (numberOfProcessedMeasurements != null) queryParams.Add("number_of_processed_measurements", Configuration.ApiClient.ParameterToString(numberOfProcessedMeasurements)); // query parameter
            if (measurementsAtLastAnalysis != null) queryParams.Add("measurements_at_last_analysis", Configuration.ApiClient.ParameterToString(measurementsAtLastAnalysis)); // query parameter
            if (lastUnitId != null) queryParams.Add("last_unit_id", Configuration.ApiClient.ParameterToString(lastUnitId)); // query parameter
            if (lastOriginalUnitId != null) queryParams.Add("last_original_unit_id", Configuration.ApiClient.ParameterToString(lastOriginalUnitId)); // query parameter
            if (lastOriginalValue != null) queryParams.Add("last_original_value", Configuration.ApiClient.ParameterToString(lastOriginalValue)); // query parameter
            if (lastValue != null) queryParams.Add("last_value", Configuration.ApiClient.ParameterToString(lastValue)); // query parameter
            if (lastOriginalValue2 != null) queryParams.Add("last_original_value", Configuration.ApiClient.ParameterToString(lastOriginalValue2)); // query parameter
            if (lastSourceId != null) queryParams.Add("last_source_id", Configuration.ApiClient.ParameterToString(lastSourceId)); // query parameter
            if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", Configuration.ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
            if (status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (errorMessage != null) queryParams.Add("error_message", Configuration.ApiClient.ParameterToString(errorMessage)); // query parameter
            if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", Configuration.ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
            if (standardDeviation != null) queryParams.Add("standard_deviation", Configuration.ApiClient.ParameterToString(standardDeviation)); // query parameter
            if (variance != null) queryParams.Add("variance", Configuration.ApiClient.ParameterToString(variance)); // query parameter
            if (minimumRecordedValue != null) queryParams.Add("minimum_recorded_value", Configuration.ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
            if (maximumRecordedValue != null) queryParams.Add("maximum_recorded_value", Configuration.ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
            if (mean != null) queryParams.Add("mean", Configuration.ApiClient.ParameterToString(mean)); // query parameter
            if (median != null) queryParams.Add("median", Configuration.ApiClient.ParameterToString(median)); // query parameter
            if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", Configuration.ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
            if (mostCommonValue != null) queryParams.Add("most_common_value", Configuration.ApiClient.ParameterToString(mostCommonValue)); // query parameter
            if (numberOfUniqueDailyValues != null) queryParams.Add("number_of_unique_daily_values", Configuration.ApiClient.ParameterToString(numberOfUniqueDailyValues)); // query parameter
            if (numberOfChanges != null) queryParams.Add("number_of_changes", Configuration.ApiClient.ParameterToString(numberOfChanges)); // query parameter
            if (skewness != null) queryParams.Add("skewness", Configuration.ApiClient.ParameterToString(skewness)); // query parameter
            if (kurtosis != null) queryParams.Add("kurtosis", Configuration.ApiClient.ParameterToString(kurtosis)); // query parameter
            if (latitude != null) queryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (longitude != null) queryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (location != null) queryParams.Add("location", Configuration.ApiClient.ParameterToString(location)); // query parameter
            if (createdAt != null) queryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) queryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (outcome != null) queryParams.Add("outcome", Configuration.ApiClient.ParameterToString(outcome)); // query parameter
            if (sources != null) queryParams.Add("sources", Configuration.ApiClient.ParameterToString(sources)); // query parameter
            if (earliestSourceTime != null) queryParams.Add("earliest_source_time", Configuration.ApiClient.ParameterToString(earliestSourceTime)); // query parameter
            if (latestSourceTime != null) queryParams.Add("latest_source_time", Configuration.ApiClient.ParameterToString(latestSourceTime)); // query parameter
            if (earliestMeasurementTime != null) queryParams.Add("earliest_measurement_time", Configuration.ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
            if (latestMeasurementTime != null) queryParams.Add("latest_measurement_time", Configuration.ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
            if (earliestFillingTime != null) queryParams.Add("earliest_filling_time", Configuration.ApiClient.ParameterToString(earliestFillingTime)); // query parameter
            if (latestFillingTime != null) queryParams.Add("latest_filling_time", Configuration.ApiClient.ParameterToString(latestFillingTime)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (sort != null) queryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling OrganizationUserVariablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling OrganizationUserVariablesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20016>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20016) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20016)));
            
        }
        
    }
    
}
