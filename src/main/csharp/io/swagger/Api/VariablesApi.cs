using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class VariablesApi {
    string basePath;
    protected RestClient restClient;

    public VariablesApi(String basePath = "https://localhost/api")
    {
      this.basePath = basePath;
      this.restClient = new RestClient(basePath);
    }

    /// <summary>
    /// Sets the endpoint base url for the services being accessed
    /// </summary>
    /// <param name="basePath"> Base URL
    /// <returns></returns>
    public void SetBasePath(string basePath) {
      this.basePath = basePath;
    }

    /// <summary>
    /// Gets the endpoint base url for the services being accessed
    /// <returns>Base URL</returns>
    /// </summary>
    public String GetBasePath() {
      return this.basePath;
    }

    
    
    /// <summary>
    /// Store or Update a Correlation Store or Update a Correlation
    /// </summary>
    /// <param name="Cause"></param>
    /// <param name="Effect"></param>
    /// <param name="Correlationcoefficient"></param>
    /// <param name="Vote"></param>
    /// <returns></returns>
    public void CorrelationsPost (string Cause, string Effect, string Correlationcoefficient, string Vote) {

      var _request = new RestRequest("/correlations", Method.POST);

      
      // verify the required parameter 'Cause' is set
      if (Cause == null) throw new ApiException(400, "Missing required parameter 'Cause' when calling CorrelationsPost");
      
      // verify the required parameter 'Effect' is set
      if (Effect == null) throw new ApiException(400, "Missing required parameter 'Effect' when calling CorrelationsPost");
      
      // verify the required parameter 'Correlationcoefficient' is set
      if (Correlationcoefficient == null) throw new ApiException(400, "Missing required parameter 'Correlationcoefficient' when calling CorrelationsPost");
      
      // verify the required parameter 'Vote' is set
      if (Vote == null) throw new ApiException(400, "Missing required parameter 'Vote' when calling CorrelationsPost");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (Cause != null) _request.AddParameter("cause", ApiInvoker.ParameterToString(Cause)); // query parameter
       if (Effect != null) _request.AddParameter("effect", ApiInvoker.ParameterToString(Effect)); // query parameter
       if (Correlationcoefficient != null) _request.AddParameter("correlationcoefficient", ApiInvoker.ParameterToString(Correlationcoefficient)); // query parameter
       if (Vote != null) _request.AddParameter("vote", ApiInvoker.ParameterToString(Vote)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsPost: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get public variables This endpoint retrieves an array of all public variables. Public variables are things like foods, medications, symptoms, conditions, and anything not unique to a particular user. For instance, a telephone number or name would not be a public variable.
    /// </summary>
    /// <returns></returns>
    public void PublicVariablesGet () {

      var _request = new RestRequest("/public/variables", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicVariablesGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get top 5 PUBLIC variables with the most correlations Get top 5 PUBLIC variables with the most correlations containing the entered search characters. For example, search for &#39;mood&#39; as an effect. Since &#39;Overall Mood&#39; has a lot of correlations with other variables, it should be in the autocomplete list.
    /// </summary>
    /// <param name="Search">Search query can be some fraction of a variable name.</param>
    /// <param name="EffectOrCause">Allows us to specify which column in the `correlations` table will be searched. Choices are effect or cause.</param>
    /// <returns></returns>
    public void PublicVariablesSearchSearchGet (string Search, string EffectOrCause) {

      var _request = new RestRequest("/public/variables/search/{search}", Method.GET);

      
      // verify the required parameter 'Search' is set
      if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling PublicVariablesSearchSearchGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("search", ApiInvoker.ParameterToString(Search)); // path (url segment) parameter
      
       if (EffectOrCause != null) _request.AddParameter("effectOrCause", ApiInvoker.ParameterToString(EffectOrCause)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PublicVariablesSearchSearchGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get variable categories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
    /// </summary>
    /// <returns></returns>
    public void VariableCategoriesGet () {

      var _request = new RestRequest("/variableCategories", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Update User Settings for a Variable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
    /// </summary>
    /// <param name="SharingData">Variable user settings data</param>
    /// <returns></returns>
    public void VariableUserSettingsPost (List<VariableUserSettings> SharingData) {

      var _request = new RestRequest("/variableUserSettings", Method.POST);

      
      // verify the required parameter 'SharingData' is set
      if (SharingData == null) throw new ApiException(400, "Missing required parameter 'SharingData' when calling VariableUserSettingsPost");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      _request.AddParameter("application/json", ApiInvoker.Serialize(SharingData), ParameterType.RequestBody); // http body (model) parameter
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariableUserSettingsPost: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get variables by the category name Get variables by the category name
    /// </summary>
    /// <param name="UserId">User id</param>
    /// <param name="CategoryName">Category name</param>
    /// <returns></returns>
    public void VariablesGet (int? UserId, string CategoryName) {

      var _request = new RestRequest("/variables", Method.GET);

      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (UserId != null) _request.AddParameter("userId", ApiInvoker.ParameterToString(UserId)); // query parameter
       if (CategoryName != null) _request.AddParameter("categoryName", ApiInvoker.ParameterToString(CategoryName)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Set variable Allows the client to create a new variable in the `variables` table.
    /// </summary>
    /// <param name="VariableName">Original name for the variable.</param>
    /// <returns></returns>
    public void VariablesPost (List<Variable> VariableName) {

      var _request = new RestRequest("/variables", Method.POST);

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling VariablesPost");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
      
      
      
      _request.AddParameter("application/json", ApiInvoker.Serialize(VariableName), ParameterType.RequestBody); // http body (model) parameter
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesPost: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get variables by search query Get variables containing the search characters for which the currently logged in user has measurements. Used to provide auto-complete function in variable search boxes.
    /// </summary>
    /// <param name="Search">Search query which may be an entire variable name or a fragment of one.</param>
    /// <param name="CategoryName">Filter variables by category name. The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.</param>
    /// <param name="Source">Specify a data source name to only return variables from a specific data source.</param>
    /// <param name="Limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
    /// <param name="Offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
    /// <returns></returns>
    public void VariablesSearchSearchGet (string Search, string CategoryName, string Source, int? Limit, int? Offset) {

      var _request = new RestRequest("/variables/search/{search}", Method.GET);

      
      // verify the required parameter 'Search' is set
      if (Search == null) throw new ApiException(400, "Missing required parameter 'Search' when calling VariablesSearchSearchGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("search", ApiInvoker.ParameterToString(Search)); // path (url segment) parameter
      
       if (CategoryName != null) _request.AddParameter("categoryName", ApiInvoker.ParameterToString(CategoryName)); // query parameter
       if (Source != null) _request.AddParameter("source", ApiInvoker.ParameterToString(Source)); // query parameter
       if (Limit != null) _request.AddParameter("limit", ApiInvoker.ParameterToString(Limit)); // query parameter
       if (Offset != null) _request.AddParameter("offset", ApiInvoker.ParameterToString(Offset)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesSearchSearchGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Get info about a variable Get all of the settings and information about a variable by its name. If the logged in user has modified the settings for the variable, these will be provided instead of the default settings for that variable.
    /// </summary>
    /// <param name="VariableName">Variable name</param>
    /// <returns></returns>
    public void VariablesVariableNameGet (string VariableName) {

      var _request = new RestRequest("/variables/{variableName}", Method.GET);

      
      // verify the required parameter 'VariableName' is set
      if (VariableName == null) throw new ApiException(400, "Missing required parameter 'VariableName' when calling VariablesVariableNameGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      _request.AddUrlSegment("variableName", ApiInvoker.ParameterToString(VariableName)); // path (url segment) parameter
      
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling VariablesVariableNameGet: " + response.Content);
      }
      
      return;
    }
    
  }
  
}
