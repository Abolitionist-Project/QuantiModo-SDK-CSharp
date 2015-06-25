using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IVariablesApi {
    
    /// <summary>
    /// Store or Update a Correlation Store or Update a Correlation
    /// </summary>
    /// <param name="Cause"></param>/// <param name="Effect"></param>/// <param name="Correlationcoefficient"></param>/// <param name="Vote"></param>
    /// <returns></returns>
    void CorrelationsPost (string Cause, string Effect, string Correlationcoefficient, string Vote);

    /// <summary>
    /// Store or Update a Correlation Store or Update a Correlation
    /// </summary>
    /// <param name="Cause"></param>/// <param name="Effect"></param>/// <param name="Correlationcoefficient"></param>/// <param name="Vote"></param>
    /// <returns></returns>
    Task CorrelationsPostAsync (string Cause, string Effect, string Correlationcoefficient, string Vote);
    
    /// <summary>
    /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
    /// </summary>
    
    /// <returns>Variable</returns>
    Variable PublicVariablesGet ();

    /// <summary>
    /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
    /// </summary>
    
    /// <returns>Variable</returns>
    Task<Variable> PublicVariablesGetAsync ();
    
    /// <summary>
    /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.
    /// </summary>
    /// <param name="Search">Search query can be some fraction of a variable name.</param>/// <param name="EffectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
    /// <returns>Variable</returns>
    Variable PublicVariablesSearchSearchGet (string Search, string EffectOrCause);

    /// <summary>
    /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.
    /// </summary>
    /// <param name="Search">Search query can be some fraction of a variable name.</param>/// <param name="EffectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
    /// <returns>Variable</returns>
    Task<Variable> PublicVariablesSearchSearchGetAsync (string Search, string EffectOrCause);
    
    /// <summary>
    /// Get variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
    /// </summary>
    
    /// <returns>List<VariableCategory></returns>
    List<VariableCategory> VariableCategoriesGet ();

    /// <summary>
    /// Get variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
    /// </summary>
    
    /// <returns>List<VariableCategory></returns>
    Task<List<VariableCategory>> VariableCategoriesGetAsync ();
    
    /// <summary>
    /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
    /// </summary>
    /// <param name="SharingData">Variable user settings data</param>
    /// <returns></returns>
    void VariableUserSettingsPost (VariableUserSettings SharingData);

    /// <summary>
    /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
    /// </summary>
    /// <param name="SharingData">Variable user settings data</param>
    /// <returns></returns>
    Task VariableUserSettingsPostAsync (VariableUserSettings SharingData);
    
    /// <summary>
    /// Get variables by the category name Get variables by the category name
    /// </summary>
    /// <param name="UserId">User id</param>/// <param name="CategoryName">Category name</param>
    /// <returns>Variable</returns>
    Variable VariablesGet (int? UserId, string CategoryName);

    /// <summary>
    /// Get variables by the category name Get variables by the category name
    /// </summary>
    /// <param name="UserId">User id</param>/// <param name="CategoryName">Category name</param>
    /// <returns>Variable</returns>
    Task<Variable> VariablesGetAsync (int? UserId, string CategoryName);
    
    /// <summary>
    /// Set variable Allows the client to create a new variable in the `variables` table.
    /// </summary>
    /// <param name="VariableName">Original name for the variable.</param>
    /// <returns></returns>
    void VariablesPost (VariablesNew VariableName);

    /// <summary>
    /// Set variable Allows the client to create a new variable in the `variables` table.
    /// </summary>
    /// <param name="VariableName">Original name for the variable.</param>
    /// <returns></returns>
    Task VariablesPostAsync (VariablesNew VariableName);
    
    /// <summary>
    /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
    /// </summary>
    /// <param name="Search">Search query which may be an entire variable name or a fragment of one.</param>/// <param name="CategoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param>/// <param name="Source">Specify a data source name to only return variables from a specific data source.</param>/// <param name="Limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>/// <param name="Offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
    /// <returns>List<Variable></returns>
    List<Variable> VariablesSearchSearchGet (string Search, string CategoryName, string Source, int? Limit, int? Offset);

    /// <summary>
    /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
    /// </summary>
    /// <param name="Search">Search query which may be an entire variable name or a fragment of one.</param>/// <param name="CategoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param>/// <param name="Source">Specify a data source name to only return variables from a specific data source.</param>/// <param name="Limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>/// <param name="Offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
    /// <returns>List<Variable></returns>
    Task<List<Variable>> VariablesSearchSearchGetAsync (string Search, string CategoryName, string Source, int? Limit, int? Offset);
    
    /// <summary>
    /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
    /// </summary>
    /// <param name="VariableName">Variable name</param>
    /// <returns>Variable</returns>
    Variable VariablesVariableNameGet (string VariableName);

    /// <summary>
    /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
    /// </summary>
    /// <param name="VariableName">Variable name</param>
    /// <returns>Variable</returns>
    Task<Variable> VariablesVariableNameGetAsync (string VariableName);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class VariablesApi : IVariablesApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="VariablesApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public VariablesApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VariablesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public VariablesApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Store or Update a Correlation Store or Update a Correlation
    /// </summary>
    /// <param name="Cause"></param>/// <param name="Effect"></param>/// <param name="Correlationcoefficient"></param>/// <param name="Vote"></param>
    /// <returns></returns>
    public void CorrelationsPost (string Cause, string Effect, string Correlationcoefficient, string Vote) {

      
      // verify the required parameter 'Cause' is set
      if (Cause == null) throw new ApiException(400, "Missing required parameter 'Cause' when calling CorrelationsPost");
      
      // verify the required parameter 'Effect' is set
      if (Effect == null) throw new ApiException(400, "Missing required parameter 'Effect' when calling CorrelationsPost");
      
      // verify the required parameter 'Correlationcoefficient' is set
      if (Correlationcoefficient == null) throw new ApiException(400, "Missing required parameter 'Correlationcoefficient' when calling CorrelationsPost");
      
      // verify the required parameter 'Vote' is set
      if (Vote == null) throw new ApiException(400, "Missing required parameter 'Vote' when calling CorrelationsPost");
      

      var path = "/correlations";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Cause != null) queryParams.Add("cause", apiClient.ParameterToString(Cause)); // query parameter
       if (Effect != null) queryParams.Add("effect", apiClient.ParameterToString(Effect)); // query parameter
       if (Correlationcoefficient != null) queryParams.Add("correlationcoefficient", apiClient.ParameterToString(Correlationcoefficient)); // query parameter
       if (Vote != null) queryParams.Add("vote", apiClient.ParameterToString(Vote)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsPost: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Store or Update a Correlation Store or Update a Correlation
    /// </summary>
    /// <param name="Cause"></param>/// <param name="Effect"></param>/// <param name="Correlationcoefficient"></param>/// <param name="Vote"></param>
    /// <returns></returns>
    public async Task CorrelationsPostAsync (string Cause, string Effect, string Correlationcoefficient, string Vote) {

      
          // verify the required parameter 'Cause' is set
          if (Cause == null) throw new ApiException(400, "Missing required parameter 'Cause' when calling CorrelationsPost");
      
          // verify the required parameter 'Effect' is set
          if (Effect == null) throw new ApiException(400, "Missing required parameter 'Effect' when calling CorrelationsPost");
      
          // verify the required parameter 'Correlationcoefficient' is set
          if (Correlationcoefficient == null) throw new ApiException(400, "Missing required parameter 'Correlationcoefficient' when calling CorrelationsPost");
      
          // verify the required parameter 'Vote' is set
          if (Vote == null) throw new ApiException(400, "Missing required parameter 'Vote' when calling CorrelationsPost");
      

      var path = "/correlations";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Cause != null) queryParams.Add("cause", apiClient.ParameterToString(Cause)); // query parameter
       if (Effect != null) queryParams.Add("effect", apiClient.ParameterToString(Effect)); // query parameter
       if (Correlationcoefficient != null) queryParams.Add("correlationcoefficient", apiClient.ParameterToString(Correlationcoefficient)); // query parameter
       if (Vote != null) queryParams.Add("vote", apiClient.ParameterToString(Vote)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsPost: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
    /// </summary>
    
    /// <returns>Variable</returns>
    public Variable PublicVariablesGet () {

      

      var path = "/public/variables";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicVariablesGet: " + response.Content, response.Content);
      }
      return (Variable) apiClient.Deserialize(response.Content, typeof(Variable));
    }
	
	 /// <summary>
    /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
    /// </summary>
    
    /// <returns>Variable</returns>
    public async Task<Variable> PublicVariablesGetAsync () {

      

      var path = "/public/variables";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicVariablesGet: " + response.Content, response.Content);
      }
      return (Variable) apiClient.Deserialize(response.Content, typeof(Variable));
    }
    
    /// <summary>
    /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.
    /// </summary>
    /// <param name="Search">Search query can be some fraction of a variable name.</param>/// <param name="EffectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
    /// <returns>Variable</returns>
    public Variable PublicVariablesSearchSearchGet (string Search, string EffectOrCause) {

      
      // verify the required parameter 'Search' is set
      if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling PublicVariablesSearchSearchGet");
      

      var path = "/public/variables/search/{search}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "search" + "}", apiClient.ParameterToString(Search));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (EffectOrCause != null) queryParams.Add("effectOrCause", apiClient.ParameterToString(EffectOrCause)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicVariablesSearchSearchGet: " + response.Content, response.Content);
      }
      return (Variable) apiClient.Deserialize(response.Content, typeof(Variable));
    }
	
	 /// <summary>
    /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.
    /// </summary>
    /// <param name="Search">Search query can be some fraction of a variable name.</param>/// <param name="EffectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
    /// <returns>Variable</returns>
    public async Task<Variable> PublicVariablesSearchSearchGetAsync (string Search, string EffectOrCause) {

      
          // verify the required parameter 'Search' is set
          if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling PublicVariablesSearchSearchGet");
      

      var path = "/public/variables/search/{search}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "search" + "}", apiClient.ParameterToString(Search));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (EffectOrCause != null) queryParams.Add("effectOrCause", apiClient.ParameterToString(EffectOrCause)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicVariablesSearchSearchGet: " + response.Content, response.Content);
      }
      return (Variable) apiClient.Deserialize(response.Content, typeof(Variable));
    }
    
    /// <summary>
    /// Get variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
    /// </summary>
    
    /// <returns>List<VariableCategory></returns>
    public List<VariableCategory> VariableCategoriesGet () {

      

      var path = "/variableCategories";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesGet: " + response.Content, response.Content);
      }
      return (List<VariableCategory>) apiClient.Deserialize(response.Content, typeof(List<VariableCategory>));
    }
	
	 /// <summary>
    /// Get variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
    /// </summary>
    
    /// <returns>List<VariableCategory></returns>
    public async Task<List<VariableCategory>> VariableCategoriesGetAsync () {

      

      var path = "/variableCategories";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesGet: " + response.Content, response.Content);
      }
      return (List<VariableCategory>) apiClient.Deserialize(response.Content, typeof(List<VariableCategory>));
    }
    
    /// <summary>
    /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
    /// </summary>
    /// <param name="SharingData">Variable user settings data</param>
    /// <returns></returns>
    public void VariableUserSettingsPost (VariableUserSettings SharingData) {

      
      // verify the required parameter 'SharingData' is set
      if (SharingData == null) throw new ApiException(400, "Missing required parameter 'SharingData' when calling VariableUserSettingsPost");
      

      var path = "/variableUserSettings";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(SharingData); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSettingsPost: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
    /// </summary>
    /// <param name="SharingData">Variable user settings data</param>
    /// <returns></returns>
    public async Task VariableUserSettingsPostAsync (VariableUserSettings SharingData) {

      
          // verify the required parameter 'SharingData' is set
          if (SharingData == null) throw new ApiException(400, "Missing required parameter 'SharingData' when calling VariableUserSettingsPost");
      

      var path = "/variableUserSettings";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(SharingData); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSettingsPost: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get variables by the category name Get variables by the category name
    /// </summary>
    /// <param name="UserId">User id</param>/// <param name="CategoryName">Category name</param>
    /// <returns>Variable</returns>
    public Variable VariablesGet (int? UserId, string CategoryName) {

      

      var path = "/variables";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (UserId != null) queryParams.Add("userId", apiClient.ParameterToString(UserId)); // query parameter
       if (CategoryName != null) queryParams.Add("categoryName", apiClient.ParameterToString(CategoryName)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "basicAuth", "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesGet: " + response.Content, response.Content);
      }
      return (Variable) apiClient.Deserialize(response.Content, typeof(Variable));
    }
	
	 /// <summary>
    /// Get variables by the category name Get variables by the category name
    /// </summary>
    /// <param name="UserId">User id</param>/// <param name="CategoryName">Category name</param>
    /// <returns>Variable</returns>
    public async Task<Variable> VariablesGetAsync (int? UserId, string CategoryName) {

      

      var path = "/variables";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (UserId != null) queryParams.Add("userId", apiClient.ParameterToString(UserId)); // query parameter
       if (CategoryName != null) queryParams.Add("categoryName", apiClient.ParameterToString(CategoryName)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "basicAuth", "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesGet: " + response.Content, response.Content);
      }
      return (Variable) apiClient.Deserialize(response.Content, typeof(Variable));
    }
    
    /// <summary>
    /// Set variable Allows the client to create a new variable in the `variables` table.
    /// </summary>
    /// <param name="VariableName">Original name for the variable.</param>
    /// <returns></returns>
    public void VariablesPost (VariablesNew VariableName) {

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling VariablesPost");
      

      var path = "/variables";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(VariableName); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesPost: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Set variable Allows the client to create a new variable in the `variables` table.
    /// </summary>
    /// <param name="VariableName">Original name for the variable.</param>
    /// <returns></returns>
    public async Task VariablesPostAsync (VariablesNew VariableName) {

      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling VariablesPost");
      

      var path = "/variables";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(VariableName); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesPost: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
    /// </summary>
    /// <param name="Search">Search query which may be an entire variable name or a fragment of one.</param>/// <param name="CategoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param>/// <param name="Source">Specify a data source name to only return variables from a specific data source.</param>/// <param name="Limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>/// <param name="Offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
    /// <returns>List<Variable></returns>
    public List<Variable> VariablesSearchSearchGet (string Search, string CategoryName, string Source, int? Limit, int? Offset) {

      
      // verify the required parameter 'Search' is set
      if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling VariablesSearchSearchGet");
      

      var path = "/variables/search/{search}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "search" + "}", apiClient.ParameterToString(Search));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CategoryName != null) queryParams.Add("categoryName", apiClient.ParameterToString(CategoryName)); // query parameter
       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesSearchSearchGet: " + response.Content, response.Content);
      }
      return (List<Variable>) apiClient.Deserialize(response.Content, typeof(List<Variable>));
    }
	
	 /// <summary>
    /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
    /// </summary>
    /// <param name="Search">Search query which may be an entire variable name or a fragment of one.</param>/// <param name="CategoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param>/// <param name="Source">Specify a data source name to only return variables from a specific data source.</param>/// <param name="Limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>/// <param name="Offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
    /// <returns>List<Variable></returns>
    public async Task<List<Variable>> VariablesSearchSearchGetAsync (string Search, string CategoryName, string Source, int? Limit, int? Offset) {

      
          // verify the required parameter 'Search' is set
          if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling VariablesSearchSearchGet");
      

      var path = "/variables/search/{search}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "search" + "}", apiClient.ParameterToString(Search));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (CategoryName != null) queryParams.Add("categoryName", apiClient.ParameterToString(CategoryName)); // query parameter
       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesSearchSearchGet: " + response.Content, response.Content);
      }
      return (List<Variable>) apiClient.Deserialize(response.Content, typeof(List<Variable>));
    }
    
    /// <summary>
    /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
    /// </summary>
    /// <param name="VariableName">Variable name</param>
    /// <returns>Variable</returns>
    public Variable VariablesVariableNameGet (string VariableName) {

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling VariablesVariableNameGet");
      

      var path = "/variables/{variableName}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesVariableNameGet: " + response.Content, response.Content);
      }
      return (Variable) apiClient.Deserialize(response.Content, typeof(Variable));
    }
	
	 /// <summary>
    /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
    /// </summary>
    /// <param name="VariableName">Variable name</param>
    /// <returns>Variable</returns>
    public async Task<Variable> VariablesVariableNameGetAsync (string VariableName) {

      
          // verify the required parameter 'VariableName' is set
          if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling VariablesVariableNameGet");
      

      var path = "/variables/{variableName}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "variableName" + "}", apiClient.ParameterToString(VariableName));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesVariableNameGet: " + response.Content, response.Content);
      }
      return (Variable) apiClient.Deserialize(response.Content, typeof(Variable));
    }
    
  }  
  
}
