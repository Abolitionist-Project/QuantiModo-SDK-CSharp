using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  
  public class OauthApi {
    string basePath;
    protected RestClient restClient;

    public OauthApi(String basePath = "https://localhost/api")
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
    /// Access Token Client provides authorization token obtained from /api/oauth2/authorize to this endpoint and receives an access token. Access token can then
    /// </summary>
    /// <param name="ResponseType">Response type</param>
    /// <param name="RedirectUri">Redirect uri</param>
    /// <param name="Realm">Realm</param>
    /// <param name="ClientId">Client id</param>
    /// <param name="Scope">Scope</param>
    /// <param name="State">State</param>
    /// <returns></returns>
    public void Oauth2AccesstokenGet (string ResponseType, string RedirectUri, string Realm, string ClientId, string Scope, string State) {

      var _request = new RestRequest("/oauth2/accesstoken", Method.GET);

      
      // verify the required parameter 'ResponseType' is set
      if (ResponseType == null) throw new ApiException(400, "Missing required parameter 'ResponseType' when calling Oauth2AccesstokenGet");
      
      // verify the required parameter 'RedirectUri' is set
      if (RedirectUri == null) throw new ApiException(400, "Missing required parameter 'RedirectUri' when calling Oauth2AccesstokenGet");
      
      // verify the required parameter 'Realm' is set
      if (Realm == null) throw new ApiException(400, "Missing required parameter 'Realm' when calling Oauth2AccesstokenGet");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling Oauth2AccesstokenGet");
      
      // verify the required parameter 'Scope' is set
      if (Scope == null) throw new ApiException(400, "Missing required parameter 'Scope' when calling Oauth2AccesstokenGet");
      
      // verify the required parameter 'State' is set
      if (State == null) throw new ApiException(400, "Missing required parameter 'State' when calling Oauth2AccesstokenGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (ResponseType != null) _request.AddParameter("response_type", ApiInvoker.ParameterToString(ResponseType)); // query parameter
       if (RedirectUri != null) _request.AddParameter("redirect_uri", ApiInvoker.ParameterToString(RedirectUri)); // query parameter
       if (Realm != null) _request.AddParameter("realm", ApiInvoker.ParameterToString(Realm)); // query parameter
       if (ClientId != null) _request.AddParameter("client_id", ApiInvoker.ParameterToString(ClientId)); // query parameter
       if (Scope != null) _request.AddParameter("scope", ApiInvoker.ParameterToString(Scope)); // query parameter
       if (State != null) _request.AddParameter("state", ApiInvoker.ParameterToString(State)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AccesstokenGet: " + response.Content);
      }
      
      return;
    }
    
    
    /// <summary>
    /// Authorize Ask the user if they want to allow a client applications to submit or obtain data from their QM  account.
    /// </summary>
    /// <param name="ClientId">This is the unique ID that QuantiModo uses to identify your application. Obtain a client id by emailing info@quantimo.do.</param>
    /// <param name="Realm">Name of the realm representing the users of your distributed applications and services. A \&quot;realm\&quot; attribute MAY be included to indicate the scope of protection.</param>
    /// <param name="RedirectUri">The redirect URI is the URL within your client application that will receive the OAuth2 credentials.</param>
    /// <param name="ResponseType">If the value is code, launches a Basic flow, requiring a POST to the token endpoint to obtain the tokens. If the value is token id_token or id_token token, launches an Implicit flow, requiring the use of Javascript at the redirect URI to retrieve tokens from the URI #fragment.</param>
    /// <param name="Scope">Scopes include basic, readmeasurements, and writemeasurements. The \&quot;basic\&quot; scope allows you to read user info (displayname, email, etc). The \&quot;readmeasurements\&quot; scope allows one to read a user&#39;s data. The \&quot;writemeasurements\&quot; scope allows you to write user data. Separate multiple scopes by a space.</param>
    /// <param name="State">An opaque string that is round-tripped in the protocol; that is to say, it is returned as a URI parameter in the Basic flow, and in the URI</param>
    /// <returns></returns>
    public void Oauth2AuthorizeGet (string ClientId, string Realm, string RedirectUri, string ResponseType, string Scope, string State) {

      var _request = new RestRequest("/oauth2/authorize", Method.GET);

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling Oauth2AuthorizeGet");
      
      // verify the required parameter 'Realm' is set
      if (Realm == null) throw new ApiException(400, "Missing required parameter 'Realm' when calling Oauth2AuthorizeGet");
      
      // verify the required parameter 'RedirectUri' is set
      if (RedirectUri == null) throw new ApiException(400, "Missing required parameter 'RedirectUri' when calling Oauth2AuthorizeGet");
      
      // verify the required parameter 'ResponseType' is set
      if (ResponseType == null) throw new ApiException(400, "Missing required parameter 'ResponseType' when calling Oauth2AuthorizeGet");
      
      // verify the required parameter 'Scope' is set
      if (Scope == null) throw new ApiException(400, "Missing required parameter 'Scope' when calling Oauth2AuthorizeGet");
      
      // verify the required parameter 'State' is set
      if (State == null) throw new ApiException(400, "Missing required parameter 'State' when calling Oauth2AuthorizeGet");
      

      // add default header, if any
      foreach(KeyValuePair<string, string> defaultHeader in ApiInvoker.GetDefaultHeader())
      {
        _request.AddHeader(defaultHeader.Key, defaultHeader.Value);
      }

      _request.AddUrlSegment("format", "json"); // set format to json by default
      
       if (ClientId != null) _request.AddParameter("client_id", ApiInvoker.ParameterToString(ClientId)); // query parameter
       if (Realm != null) _request.AddParameter("realm", ApiInvoker.ParameterToString(Realm)); // query parameter
       if (RedirectUri != null) _request.AddParameter("redirect_uri", ApiInvoker.ParameterToString(RedirectUri)); // query parameter
       if (ResponseType != null) _request.AddParameter("response_type", ApiInvoker.ParameterToString(ResponseType)); // query parameter
       if (Scope != null) _request.AddParameter("scope", ApiInvoker.ParameterToString(Scope)); // query parameter
       if (State != null) _request.AddParameter("state", ApiInvoker.ParameterToString(State)); // query parameter
      
      
      
      

      // make the HTTP request
      IRestResponse response = restClient.Execute(_request);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling Oauth2AuthorizeGet: " + response.Content);
      }
      
      return;
    }
    
  }
  
}
