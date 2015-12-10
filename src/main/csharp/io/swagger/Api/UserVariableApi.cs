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
    public interface IUserVariableApi
    {
        
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
        /// <param name="userId">User ID</param>
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
        InlineResponse20016 UserVariablesGet (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? userId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);
  
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
        /// <param name="userId">User ID</param>
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
        ApiResponse<InlineResponse20016> UserVariablesGetWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? userId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);

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
        /// <param name="userId">User ID</param>
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
        System.Threading.Tasks.Task<InlineResponse20016> UserVariablesGetAsync (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? userId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);

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
        /// <param name="userId">User ID</param>
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
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20016>> UserVariablesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? userId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null);
        
        /// <summary>
        /// Store UserVariable
        /// </summary>
        /// <remarks>
        /// Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 UserVariablesPost (string accessToken = null, UserVariable body = null);
  
        /// <summary>
        /// Store UserVariable
        /// </summary>
        /// <remarks>
        /// Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>ApiResponse of InlineResponse20026</returns>
        ApiResponse<InlineResponse20026> UserVariablesPostWithHttpInfo (string accessToken = null, UserVariable body = null);

        /// <summary>
        /// Store UserVariable
        /// </summary>
        /// <remarks>
        /// Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>Task of InlineResponse20026</returns>
        System.Threading.Tasks.Task<InlineResponse20026> UserVariablesPostAsync (string accessToken = null, UserVariable body = null);

        /// <summary>
        /// Store UserVariable
        /// </summary>
        /// <remarks>
        /// Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </remarks>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20026)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20026>> UserVariablesPostAsyncWithHttpInfo (string accessToken = null, UserVariable body = null);
        
        /// <summary>
        /// Get UserVariable
        /// </summary>
        /// <remarks>
        /// Get UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 UserVariablesIdGet (int? id, string accessToken = null);
  
        /// <summary>
        /// Get UserVariable
        /// </summary>
        /// <remarks>
        /// Get UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse20026</returns>
        ApiResponse<InlineResponse20026> UserVariablesIdGetWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Get UserVariable
        /// </summary>
        /// <remarks>
        /// Get UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20026</returns>
        System.Threading.Tasks.Task<InlineResponse20026> UserVariablesIdGetAsync (int? id, string accessToken = null);

        /// <summary>
        /// Get UserVariable
        /// </summary>
        /// <remarks>
        /// Get UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20026)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20026>> UserVariablesIdGetAsyncWithHttpInfo (int? id, string accessToken = null);
        
        /// <summary>
        /// Update UserVariable
        /// </summary>
        /// <remarks>
        /// Update UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariablesIdPut (int? id, string accessToken = null, UserVariable body = null);
  
        /// <summary>
        /// Update UserVariable
        /// </summary>
        /// <remarks>
        /// Update UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> UserVariablesIdPutWithHttpInfo (int? id, string accessToken = null, UserVariable body = null);

        /// <summary>
        /// Update UserVariable
        /// </summary>
        /// <remarks>
        /// Update UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> UserVariablesIdPutAsync (int? id, string accessToken = null, UserVariable body = null);

        /// <summary>
        /// Update UserVariable
        /// </summary>
        /// <remarks>
        /// Update UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UserVariablesIdPutAsyncWithHttpInfo (int? id, string accessToken = null, UserVariable body = null);
        
        /// <summary>
        /// Delete UserVariable
        /// </summary>
        /// <remarks>
        /// Delete UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariablesIdDelete (int? id, string accessToken = null);
  
        /// <summary>
        /// Delete UserVariable
        /// </summary>
        /// <remarks>
        /// Delete UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> UserVariablesIdDeleteWithHttpInfo (int? id, string accessToken = null);

        /// <summary>
        /// Delete UserVariable
        /// </summary>
        /// <remarks>
        /// Delete UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> UserVariablesIdDeleteAsync (int? id, string accessToken = null);

        /// <summary>
        /// Delete UserVariable
        /// </summary>
        /// <remarks>
        /// Delete UserVariable
        /// </remarks>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UserVariablesIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserVariableApi : IUserVariableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserVariableApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserVariableApi(Configuration configuration = null)
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
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="variableId">ID of variable</param> 
        /// <param name="userId">User ID</param> 
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
        public InlineResponse20016 UserVariablesGet (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? userId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20016> response = UserVariablesGetWithHttpInfo(accessToken, clientId, parentId, variableId, userId, defaultUnitId, minimumAllowedValue, maximumAllowedValue, fillingValue, joinWith, onsetDelay, durationOfAction, variableCategoryId, updated, _public, causeOnly, fillingType, numberOfMeasurements, numberOfProcessedMeasurements, measurementsAtLastAnalysis, lastUnitId, lastOriginalUnitId, lastOriginalValue, lastValue, lastOriginalValue2, lastSourceId, numberOfCorrelations, status, errorMessage, lastSuccessfulUpdateTime, standardDeviation, variance, minimumRecordedValue, maximumRecordedValue, mean, median, mostCommonUnitId, mostCommonValue, numberOfUniqueDailyValues, numberOfChanges, skewness, kurtosis, latitude, longitude, location, createdAt, updatedAt, outcome, sources, earliestSourceTime, latestSourceTime, earliestMeasurementTime, latestMeasurementTime, earliestFillingTime, latestFillingTime, limit, offset, sort);
             return response.Data;
        }

        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="variableId">ID of variable</param> 
        /// <param name="userId">User ID</param> 
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
        public ApiResponse< InlineResponse20016 > UserVariablesGetWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? userId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
            
    
            var path_ = "/userVariables";
    
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
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
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
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <param name="userId">User ID</param>
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
        public async System.Threading.Tasks.Task<InlineResponse20016> UserVariablesGetAsync (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? userId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
        {
             ApiResponse<InlineResponse20016> response = await UserVariablesGetAsyncWithHttpInfo(accessToken, clientId, parentId, variableId, userId, defaultUnitId, minimumAllowedValue, maximumAllowedValue, fillingValue, joinWith, onsetDelay, durationOfAction, variableCategoryId, updated, _public, causeOnly, fillingType, numberOfMeasurements, numberOfProcessedMeasurements, measurementsAtLastAnalysis, lastUnitId, lastOriginalUnitId, lastOriginalValue, lastValue, lastOriginalValue2, lastSourceId, numberOfCorrelations, status, errorMessage, lastSuccessfulUpdateTime, standardDeviation, variance, minimumRecordedValue, maximumRecordedValue, mean, median, mostCommonUnitId, mostCommonValue, numberOfUniqueDailyValues, numberOfChanges, skewness, kurtosis, latitude, longitude, location, createdAt, updatedAt, outcome, sources, earliestSourceTime, latestSourceTime, earliestMeasurementTime, latestMeasurementTime, earliestFillingTime, latestFillingTime, limit, offset, sort);
             return response.Data;

        }

        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="userId">User ID</param>
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
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20016>> UserVariablesGetAsyncWithHttpInfo (string accessToken = null, string clientId = null, int? parentId = null, int? variableId = null, int? userId = null, int? defaultUnitId = null, double? minimumAllowedValue = null, double? maximumAllowedValue = null, double? fillingValue = null, int? joinWith = null, int? onsetDelay = null, int? durationOfAction = null, int? variableCategoryId = null, int? updated = null, int? _public = null, bool? causeOnly = null, string fillingType = null, int? numberOfMeasurements = null, int? numberOfProcessedMeasurements = null, int? measurementsAtLastAnalysis = null, int? lastUnitId = null, int? lastOriginalUnitId = null, int? lastOriginalValue = null, double? lastValue = null, double? lastOriginalValue2 = null, int? lastSourceId = null, int? numberOfCorrelations = null, string status = null, string errorMessage = null, string lastSuccessfulUpdateTime = null, double? standardDeviation = null, double? variance = null, double? minimumRecordedValue = null, double? maximumRecordedValue = null, double? mean = null, double? median = null, int? mostCommonUnitId = null, double? mostCommonValue = null, double? numberOfUniqueDailyValues = null, int? numberOfChanges = null, double? skewness = null, double? kurtosis = null, double? latitude = null, double? longitude = null, string location = null, string createdAt = null, string updatedAt = null, bool? outcome = null, string sources = null, int? earliestSourceTime = null, int? latestSourceTime = null, int? earliestMeasurementTime = null, int? latestMeasurementTime = null, int? earliestFillingTime = null, int? latestFillingTime = null, int? limit = null, int? offset = null, string sort = null)
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
            if (userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // query parameter
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
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20016>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20016) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20016)));
            
        }
        
        /// <summary>
        /// Store UserVariable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariable that should be stored</param> 
        /// <returns>InlineResponse20026</returns>
        public InlineResponse20026 UserVariablesPost (string accessToken = null, UserVariable body = null)
        {
             ApiResponse<InlineResponse20026> response = UserVariablesPostWithHttpInfo(accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Store UserVariable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariable that should be stored</param> 
        /// <returns>ApiResponse of InlineResponse20026</returns>
        public ApiResponse< InlineResponse20026 > UserVariablesPostWithHttpInfo (string accessToken = null, UserVariable body = null)
        {
            
    
            var path_ = "/userVariables";
    
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
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20026>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20026) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20026)));
            
        }
    
        /// <summary>
        /// Store UserVariable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>Task of InlineResponse20026</returns>
        public async System.Threading.Tasks.Task<InlineResponse20026> UserVariablesPostAsync (string accessToken = null, UserVariable body = null)
        {
             ApiResponse<InlineResponse20026> response = await UserVariablesPostAsyncWithHttpInfo(accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Store UserVariable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>Task of ApiResponse (InlineResponse20026)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20026>> UserVariablesPostAsyncWithHttpInfo (string accessToken = null, UserVariable body = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20026>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20026) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20026)));
            
        }
        
        /// <summary>
        /// Get UserVariable Get UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20026</returns>
        public InlineResponse20026 UserVariablesIdGet (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20026> response = UserVariablesIdGetWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Get UserVariable Get UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse20026</returns>
        public ApiResponse< InlineResponse20026 > UserVariablesIdGetWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdGet");
            
    
            var path_ = "/userVariables/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20026>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20026) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20026)));
            
        }
    
        /// <summary>
        /// Get UserVariable Get UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse20026</returns>
        public async System.Threading.Tasks.Task<InlineResponse20026> UserVariablesIdGetAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse20026> response = await UserVariablesIdGetAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Get UserVariable Get UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse20026)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20026>> UserVariablesIdGetAsyncWithHttpInfo (int? id, string accessToken = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20026>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20026) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20026)));
            
        }
        
        /// <summary>
        /// Update UserVariable Update UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariable that should be updated</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 UserVariablesIdPut (int? id, string accessToken = null, UserVariable body = null)
        {
             ApiResponse<InlineResponse2002> response = UserVariablesIdPutWithHttpInfo(id, accessToken, body);
             return response.Data;
        }

        /// <summary>
        /// Update UserVariable Update UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariable that should be updated</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > UserVariablesIdPutWithHttpInfo (int? id, string accessToken = null, UserVariable body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdPut");
            
    
            var path_ = "/userVariables/{id}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Update UserVariable Update UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> UserVariablesIdPutAsync (int? id, string accessToken = null, UserVariable body = null)
        {
             ApiResponse<InlineResponse2002> response = await UserVariablesIdPutAsyncWithHttpInfo(id, accessToken, body);
             return response.Data;

        }

        /// <summary>
        /// Update UserVariable Update UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UserVariablesIdPutAsyncWithHttpInfo (int? id, string accessToken = null, UserVariable body = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
        /// <summary>
        /// Delete UserVariable Delete UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 UserVariablesIdDelete (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = UserVariablesIdDeleteWithHttpInfo(id, accessToken);
             return response.Data;
        }

        /// <summary>
        /// Delete UserVariable Delete UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > UserVariablesIdDeleteWithHttpInfo (int? id, string accessToken = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdDelete");
            
    
            var path_ = "/userVariables/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (accessToken != null) queryParams.Add("access_token", Configuration.ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            

            
            // authentication (quantimodo_oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
    
        /// <summary>
        /// Delete UserVariable Delete UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> UserVariablesIdDeleteAsync (int? id, string accessToken = null)
        {
             ApiResponse<InlineResponse2002> response = await UserVariablesIdDeleteAsyncWithHttpInfo(id, accessToken);
             return response.Data;

        }

        /// <summary>
        /// Delete UserVariable Delete UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> UserVariablesIdDeleteAsyncWithHttpInfo (int? id, string accessToken = null)
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UserVariablesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UserVariablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2002>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2002)));
            
        }
        
    }
    
}
