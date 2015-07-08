using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IOauthApi {
    
    /// <summary>
    /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then be used to query different API endpoints of QuantiModo.
    /// </summary>
    /// <param name="ClientId">Client id</param>/// <param name="ClientSecret">Client secret</param>/// <param name="GrantType">Grant Type can be &#39;authorization_code&#39; or &#39;refresh_token&#39;</param>/// <param name="ResponseType">Response type</param>/// <param name="Scope">Scope</param>/// <param name="RedirectUri">Redirect uri</param>/// <param name="State">State</param>/// <param name="Realm">Realm</param>
    /// <returns></returns>
    void Oauth2AccesstokenGet (string ClientId, string ClientSecret, string GrantType, string ResponseType, string Scope, string RedirectUri, string State, string Realm);

    /// <summary>
    /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then be used to query different API endpoints of QuantiModo.
    /// </summary>
    /// <param name="ClientId">Client id</param>/// <param name="ClientSecret">Client secret</param>/// <param name="GrantType">Grant Type can be &#39;authorization_code&#39; or &#39;refresh_token&#39;</param>/// <param name="ResponseType">Response type</param>/// <param name="Scope">Scope</param>/// <param name="RedirectUri">Redirect uri</param>/// <param name="State">State</param>/// <param name="Realm">Realm</param>
    /// <returns></returns>
    Task Oauth2AccesstokenGetAsync (string ClientId, string ClientSecret, string GrantType, string ResponseType, string Scope, string RedirectUri, string State, string Realm);
    
    /// <summary>
    /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM account. It will redirect the user to the url provided by the client application with the code as a query parameter or error in case of an error.
    /// </summary>
    /// <param name="ClientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param>/// <param name="ClientSecret">This is the secret for your obtained clietn_id. QuantiModo uses this to validate that only your application uses the client_id.</param>/// <param name="ResponseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param>/// <param name="Scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param>/// <param name="RedirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param>/// <param name="State">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param>/// <param name="Realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param>
    /// <returns></returns>
    void Oauth2AuthorizeGet (string ClientId, string ClientSecret, string ResponseType, string Scope, string RedirectUri, string State, string Realm);

    /// <summary>
    /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM account. It will redirect the user to the url provided by the client application with the code as a query parameter or error in case of an error.
    /// </summary>
    /// <param name="ClientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param>/// <param name="ClientSecret">This is the secret for your obtained clietn_id. QuantiModo uses this to validate that only your application uses the client_id.</param>/// <param name="ResponseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param>/// <param name="Scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param>/// <param name="RedirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param>/// <param name="State">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param>/// <param name="Realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param>
    /// <returns></returns>
    Task Oauth2AuthorizeGetAsync (string ClientId, string ClientSecret, string ResponseType, string Scope, string RedirectUri, string State, string Realm);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class OauthApi : IOauthApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="OauthApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public OauthApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OauthApi"/> class.
    /// </summary>
    /// <returns></returns>
    public OauthApi(String basePath)
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
    /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then be used to query different API endpoints of QuantiModo.
    /// </summary>
    /// <param name="ClientId">Client id</param>/// <param name="ClientSecret">Client secret</param>/// <param name="GrantType">Grant Type can be &#39;authorization_code&#39; or &#39;refresh_token&#39;</param>/// <param name="ResponseType">Response type</param>/// <param name="Scope">Scope</param>/// <param name="RedirectUri">Redirect uri</param>/// <param name="State">State</param>/// <param name="Realm">Realm</param>
    /// <returns></returns>
    public void Oauth2AccesstokenGet (string ClientId, string ClientSecret, string GrantType, string ResponseType, string Scope, string RedirectUri, string State, string Realm) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling Oauth2AccesstokenGet");
      
      // verify the required parameter 'ClientSecret' is set
      if (ClientSecret == null) throw new ApiException(400, "Missing required parameter 'ClientSecret' when calling Oauth2AccesstokenGet");
      
      // verify the required parameter 'GrantType' is set
      if (GrantType == null) throw new ApiException(400, "Missing required parameter 'GrantType' when calling Oauth2AccesstokenGet");
      

      var path = "/oauth2/accesstoken";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (ClientId != null) queryParams.Add("client_id", apiClient.ParameterToString(ClientId)); // query parameter
       if (ClientSecret != null) queryParams.Add("client_secret", apiClient.ParameterToString(ClientSecret)); // query parameter
       if (GrantType != null) queryParams.Add("grant_type", apiClient.ParameterToString(GrantType)); // query parameter
       if (ResponseType != null) queryParams.Add("response_type", apiClient.ParameterToString(ResponseType)); // query parameter
       if (Scope != null) queryParams.Add("scope", apiClient.ParameterToString(Scope)); // query parameter
       if (RedirectUri != null) queryParams.Add("redirect_uri", apiClient.ParameterToString(RedirectUri)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (Realm != null) queryParams.Add("realm", apiClient.ParameterToString(Realm)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AccesstokenGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then be used to query different API endpoints of QuantiModo.
    /// </summary>
    /// <param name="ClientId">Client id</param>/// <param name="ClientSecret">Client secret</param>/// <param name="GrantType">Grant Type can be &#39;authorization_code&#39; or &#39;refresh_token&#39;</param>/// <param name="ResponseType">Response type</param>/// <param name="Scope">Scope</param>/// <param name="RedirectUri">Redirect uri</param>/// <param name="State">State</param>/// <param name="Realm">Realm</param>
    /// <returns></returns>
    public async Task Oauth2AccesstokenGetAsync (string ClientId, string ClientSecret, string GrantType, string ResponseType, string Scope, string RedirectUri, string State, string Realm) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling Oauth2AccesstokenGet");
      
          // verify the required parameter 'ClientSecret' is set
          if (ClientSecret == null) throw new ApiException(400, "Missing required parameter 'ClientSecret' when calling Oauth2AccesstokenGet");
      
          // verify the required parameter 'GrantType' is set
          if (GrantType == null) throw new ApiException(400, "Missing required parameter 'GrantType' when calling Oauth2AccesstokenGet");
      

      var path = "/oauth2/accesstoken";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (ClientId != null) queryParams.Add("client_id", apiClient.ParameterToString(ClientId)); // query parameter
       if (ClientSecret != null) queryParams.Add("client_secret", apiClient.ParameterToString(ClientSecret)); // query parameter
       if (GrantType != null) queryParams.Add("grant_type", apiClient.ParameterToString(GrantType)); // query parameter
       if (ResponseType != null) queryParams.Add("response_type", apiClient.ParameterToString(ResponseType)); // query parameter
       if (Scope != null) queryParams.Add("scope", apiClient.ParameterToString(Scope)); // query parameter
       if (RedirectUri != null) queryParams.Add("redirect_uri", apiClient.ParameterToString(RedirectUri)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (Realm != null) queryParams.Add("realm", apiClient.ParameterToString(Realm)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AccesstokenGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
    /// <summary>
    /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM account. It will redirect the user to the url provided by the client application with the code as a query parameter or error in case of an error.
    /// </summary>
    /// <param name="ClientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param>/// <param name="ClientSecret">This is the secret for your obtained clietn_id. QuantiModo uses this to validate that only your application uses the client_id.</param>/// <param name="ResponseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param>/// <param name="Scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param>/// <param name="RedirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param>/// <param name="State">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param>/// <param name="Realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param>
    /// <returns></returns>
    public void Oauth2AuthorizeGet (string ClientId, string ClientSecret, string ResponseType, string Scope, string RedirectUri, string State, string Realm) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling Oauth2AuthorizeGet");
      
      // verify the required parameter 'ClientSecret' is set
      if (ClientSecret == null) throw new ApiException(400, "Missing required parameter 'ClientSecret' when calling Oauth2AuthorizeGet");
      
      // verify the required parameter 'ResponseType' is set
      if (ResponseType == null) throw new ApiException(400, "Missing required parameter 'ResponseType' when calling Oauth2AuthorizeGet");
      
      // verify the required parameter 'Scope' is set
      if (Scope == null) throw new ApiException(400, "Missing required parameter 'Scope' when calling Oauth2AuthorizeGet");
      

      var path = "/oauth2/authorize";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (ClientId != null) queryParams.Add("client_id", apiClient.ParameterToString(ClientId)); // query parameter
       if (ClientSecret != null) queryParams.Add("client_secret", apiClient.ParameterToString(ClientSecret)); // query parameter
       if (ResponseType != null) queryParams.Add("response_type", apiClient.ParameterToString(ResponseType)); // query parameter
       if (Scope != null) queryParams.Add("scope", apiClient.ParameterToString(Scope)); // query parameter
       if (RedirectUri != null) queryParams.Add("redirect_uri", apiClient.ParameterToString(RedirectUri)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (Realm != null) queryParams.Add("realm", apiClient.ParameterToString(Realm)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AuthorizeGet: " + response.Content, response.Content);
      }
      
      return;
    }
	
	 /// <summary>
    /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM account. It will redirect the user to the url provided by the client application with the code as a query parameter or error in case of an error.
    /// </summary>
    /// <param name="ClientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param>/// <param name="ClientSecret">This is the secret for your obtained clietn_id. QuantiModo uses this to validate that only your application uses the client_id.</param>/// <param name="ResponseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param>/// <param name="Scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param>/// <param name="RedirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param>/// <param name="State">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param>/// <param name="Realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param>
    /// <returns></returns>
    public async Task Oauth2AuthorizeGetAsync (string ClientId, string ClientSecret, string ResponseType, string Scope, string RedirectUri, string State, string Realm) {

      
          // verify the required parameter 'ClientId' is set
          if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling Oauth2AuthorizeGet");
      
          // verify the required parameter 'ClientSecret' is set
          if (ClientSecret == null) throw new ApiException(400, "Missing required parameter 'ClientSecret' when calling Oauth2AuthorizeGet");
      
          // verify the required parameter 'ResponseType' is set
          if (ResponseType == null) throw new ApiException(400, "Missing required parameter 'ResponseType' when calling Oauth2AuthorizeGet");
      
          // verify the required parameter 'Scope' is set
          if (Scope == null) throw new ApiException(400, "Missing required parameter 'Scope' when calling Oauth2AuthorizeGet");
      

      var path = "/oauth2/authorize";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (ClientId != null) queryParams.Add("client_id", apiClient.ParameterToString(ClientId)); // query parameter
       if (ClientSecret != null) queryParams.Add("client_secret", apiClient.ParameterToString(ClientSecret)); // query parameter
       if (ResponseType != null) queryParams.Add("response_type", apiClient.ParameterToString(ResponseType)); // query parameter
       if (Scope != null) queryParams.Add("scope", apiClient.ParameterToString(Scope)); // query parameter
       if (RedirectUri != null) queryParams.Add("redirect_uri", apiClient.ParameterToString(RedirectUri)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (Realm != null) queryParams.Add("realm", apiClient.ParameterToString(Realm)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "oauth2" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AuthorizeGet: " + response.Content, response.Content);
      }
      
      return;
    }
    
  }  
  
}
