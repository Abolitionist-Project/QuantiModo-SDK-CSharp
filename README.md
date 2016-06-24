# IO.Swagger - the C# library for the QuantiModo

Welcome to QuantiModo API! QuantiModo makes it easy to retrieve normalized user data from a wide array of devices and applications. [Learn about QuantiModo](https://quantimo.do) or contact us at <api@quantimo.do>.         Before you get started, you will need to: * Sign in/Sign up, and add some data at [https://app.quantimo.do/api/v2/account/connectors](https://app.quantimo.do/api/v2/account/connectors) to try out the API for yourself * Create an app to get your client id and secret at [https://app.quantimo.do/api/v2/apps](https://app.quantimo.do/api/v2/apps) * As long as you're signed in, it will use your browser's cookie for authentication.  However, client applications must use OAuth2 tokens to access the API.     ## Application Endpoints These endpoints give you access to all authorized users' data for that application. ### Getting Application Token Make a `POST` request to `/api/v2/oauth/access_token`         * `grant_type` Must be `client_credentials`.         * `clientId` Your application's clientId.         * `client_secret` Your application's client_secret.         * `redirect_uri` Your application's redirect url.                ## Example Queries ### Query Options The standard query options for QuantiModo API are as described in the table below. These are the available query options in QuantiModo API: <table>            <thead>                <tr>                    <th>Parameter</th>                    <th>Description</th>                </tr>            </thead>            <tbody>                <tr>                    <td>limit</td>                    <td>The LIMIT is used to limit the number of results returned.  So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</td>                </tr>                <tr>                    <td>offset</td>                    <td>Suppose you wanted to show results 11-20. You'd set the    offset to 10 and the limit to 10.</td>                </tr>                <tr>                    <td>sort</td>                    <td>Sort by given field. If the field is prefixed with '-', it    will sort in descending order.</td>                </tr>            </tbody>        </table>         ### Pagination Conventions Since the maximum limit is 200 records, to get more than that you'll have to make multiple API calls and page through the results. To retrieve all the data, you can iterate through data by using the `limit` and `offset` query parameters.For example, if you want to retrieve data from 61-80 then you can use a query with the following parameters,         `/v2/variables?limit=20&offset=60`         Generally, you'll be retrieving new or updated user data. To avoid unnecessary API calls, you'll want to store your last refresh time locally.  Initially, it should be set to 0. Then whenever you make a request to get new data, you should limit the returned results to those updated since your last refresh by appending append         `?lastUpdated=(ge)&quot2013-01-D01T01:01:01&quot`         to your request.         Also for better pagination, you can get link to the records of first, last, next and previous page from response headers: * `Total-Count` - Total number of results for given query * `Link-First` - Link to get first page records * `Link-Last` - Link to get last page records * `Link-Prev` - Link to get previous records set * `Link-Next` - Link to get next records set         Remember, response header will be only sent when the record set is available. e.g. You will not get a ```Link-Last``` & ```Link-Next``` when you query for the last page.         ### Filter operators support API supports the following operators with filter parameters: <br> **Comparison operators**         Comparison operators allow you to limit results to those greater than, less than, or equal to a specified value for a specified attribute. These operators can be used with strings, numbers, and dates. The following comparison operators are available: * `gt` for `greater than` comparison * `ge` for `greater than or equal` comparison * `lt` for `less than` comparison * `le` for `less than or equal` comparison         They are included in queries using the following format:         `(<operator>)<value>`         For example, in order to filter value which is greater than 21, the following query parameter should be used:         `?value=(gt)21` <br><br> **Equals/In Operators**         It also allows filtering by the exact value of an attribute or by a set of values, depending on the type of value passed as a query parameter. If the value contains commas, the parameter is split on commas and used as array input for `IN` filtering, otherwise the exact match is applied. In order to only show records which have the value 42, the following query should be used:         `?value=42`         In order to filter records which have value 42 or 43, the following query should be used:         `?value=42,43` <br><br> **Like operators**         Like operators allow filtering using `LIKE` query. This operator is triggered if exact match operator is used, but value contains `%` sign as the first or last character. In order to filter records which category that start with `Food`, the following query should be used:         `?category=Food%` <br><br> **Negation operator**         It is possible to get negated results of a query by prefixed the operator with `!`. Some examples:         `//filter records except those with value are not 42 or 43`<br> `?value=!42,43`         `//filter records with value not greater than 21`<br> `?value=!(ge)21` <br><br> **Multiple constraints for single attribute**         It is possible to apply multiple constraints by providing an array of query filters:         Filter all records which value is greater than 20.2 and less than 20.3<br> `?value[]=(gt)20.2&value[]=(lt)20.3`         Filter all records which value is greater than 20.2 and less than 20.3 but not 20.2778<br> `?value[]=(gt)20.2&value[]=(lt)20.3&value[]=!20.2778`<br><br> 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.6
- SDK version: 1.0.0
- Build date: 2016-06-24T22:07:49.406Z
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';
            // Configure API key authorization: internalApiKey
            Configuration.Default.ApiKey.Add('api_key', 'YOUR_API_KEY');
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add('api_key', 'Bearer');

            var apiInstance = new ApplicationEndpointsApi();
            var accessToken = accessToken_example;  // string | Application's OAuth2 access token (optional) 
            var connectorId = 56;  // int? | The id for the connector data source for which the connection is connected (optional) 
            var connectStatus = connectStatus_example;  // string | Indicates whether a connector is currently connected to a service for a user. (optional) 
            var connectError = connectError_example;  // string | Error message if there is a problem with authorizing this connection. (optional) 
            var updateRequestedAt = updateRequestedAt_example;  // string | Time at which an update was requested by a user. (optional) 
            var updateStatus = updateStatus_example;  // string | Indicates whether a connector is currently updated. (optional) 
            var updateError = updateError_example;  // string | Indicates if there was an error during the update. (optional) 
            var lastSuccessfulUpdatedAt = lastSuccessfulUpdatedAt_example;  // string | The time at which the connector was last successfully updated. (optional) 
            var createdAt = createdAt_example;  // string | When the record was first created. Use ISO 8601 datetime format  (optional) 
            var updatedAt = updatedAt_example;  // string | When the record was last updated. Use ISO 8601 datetime format  (optional) 
            var limit = 56;  // int? | The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records. (optional) 
            var offset = 56;  // int? | OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned. (optional) 
            var sort = sort_example;  // string | Sort by given field. If the field is prefixed with '-', it will sort in descending order. (optional) 

            try
            {
                // Get all Connections
                InlineResponse2003 result = apiInstance.V2ApplicationConnectionsGet(accessToken, connectorId, connectStatus, connectError, updateRequestedAt, updateStatus, updateError, lastSuccessfulUpdatedAt, createdAt, updatedAt, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationEndpointsApi.V2ApplicationConnectionsGet: " + e.Message );
            }
        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://app.quantimo.do/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApplicationEndpointsApi* | [**V2ApplicationConnectionsGet**](docs/ApplicationEndpointsApi.md#v2applicationconnectionsget) | **GET** /v2/application/connections | Get all Connections
*ApplicationEndpointsApi* | [**V2ApplicationCredentialsGet**](docs/ApplicationEndpointsApi.md#v2applicationcredentialsget) | **GET** /v2/application/credentials | Get all Credentials
*ApplicationEndpointsApi* | [**V2ApplicationMeasurementsGet**](docs/ApplicationEndpointsApi.md#v2applicationmeasurementsget) | **GET** /v2/application/measurements | Get measurements for all users using your application
*ApplicationEndpointsApi* | [**V2ApplicationTrackingRemindersGet**](docs/ApplicationEndpointsApi.md#v2applicationtrackingremindersget) | **GET** /v2/application/trackingReminders | Get tracking reminders
*ApplicationEndpointsApi* | [**V2ApplicationUpdatesGet**](docs/ApplicationEndpointsApi.md#v2applicationupdatesget) | **GET** /v2/application/updates | Get all Updates
*ApplicationEndpointsApi* | [**V2ApplicationUserVariableRelationshipsGet**](docs/ApplicationEndpointsApi.md#v2applicationuservariablerelationshipsget) | **GET** /v2/application/userVariableRelationships | Get all UserVariableRelationships
*ApplicationEndpointsApi* | [**V2ApplicationUserVariablesGet**](docs/ApplicationEndpointsApi.md#v2applicationuservariablesget) | **GET** /v2/application/userVariables | Get all UserVariables
*ApplicationEndpointsApi* | [**V2ApplicationVariableUserSourcesGet**](docs/ApplicationEndpointsApi.md#v2applicationvariableusersourcesget) | **GET** /v2/application/variableUserSources | Get all VariableUserSources
*ApplicationEndpointsApi* | [**V2ApplicationVotesGet**](docs/ApplicationEndpointsApi.md#v2applicationvotesget) | **GET** /v2/application/votes | Get all Votes
*AuthenticationApi* | [**V2AuthSocialAuthorizeCodeGet**](docs/AuthenticationApi.md#v2authsocialauthorizecodeget) | **GET** /v2/auth/social/authorizeCode | Second Step in Social Authentication flow with JWT Token
*AuthenticationApi* | [**V2AuthSocialAuthorizeTokenGet**](docs/AuthenticationApi.md#v2authsocialauthorizetokenget) | **GET** /v2/auth/social/authorizeToken | Native Social Authentication
*AuthenticationApi* | [**V2AuthSocialLoginGet**](docs/AuthenticationApi.md#v2authsocialloginget) | **GET** /v2/auth/social/login | First Setp in Social Authentication flow with JWT Token
*AuthenticationApi* | [**V2Oauth2AccessTokenGet**](docs/AuthenticationApi.md#v2oauth2accesstokenget) | **GET** /v2/oauth2/access_token | Get a user access token
*AuthenticationApi* | [**V2OauthAuthorizeGet**](docs/AuthenticationApi.md#v2oauthauthorizeget) | **GET** /v2/oauth/authorize | Request Authorization Code
*ConnectorsApi* | [**V1ConnectJsGet**](docs/ConnectorsApi.md#v1connectjsget) | **GET** /v1/connect.js | Get embeddable connect javascript
*ConnectorsApi* | [**V1ConnectMobileGet**](docs/ConnectorsApi.md#v1connectmobileget) | **GET** /v1/connect/mobile | Mobile connect page
*ConnectorsApi* | [**V1ConnectorsConnectorConnectGet**](docs/ConnectorsApi.md#v1connectorsconnectorconnectget) | **GET** /v1/connectors/{connector}/connect | Obtain a token from 3rd party data source
*ConnectorsApi* | [**V1ConnectorsConnectorConnectInstructionsGet**](docs/ConnectorsApi.md#v1connectorsconnectorconnectinstructionsget) | **GET** /v1/connectors/{connector}/connectInstructions | Connection Instructions
*ConnectorsApi* | [**V1ConnectorsConnectorConnectParameterGet**](docs/ConnectorsApi.md#v1connectorsconnectorconnectparameterget) | **GET** /v1/connectors/{connector}/connectParameter | Connect Parameter
*ConnectorsApi* | [**V1ConnectorsConnectorDisconnectGet**](docs/ConnectorsApi.md#v1connectorsconnectordisconnectget) | **GET** /v1/connectors/{connector}/disconnect | Delete stored connection info
*ConnectorsApi* | [**V1ConnectorsConnectorInfoGet**](docs/ConnectorsApi.md#v1connectorsconnectorinfoget) | **GET** /v1/connectors/{connector}/info | Get connector info for user
*ConnectorsApi* | [**V1ConnectorsConnectorUpdateGet**](docs/ConnectorsApi.md#v1connectorsconnectorupdateget) | **GET** /v1/connectors/{connector}/update | Sync with data source
*ConnectorsApi* | [**V1ConnectorsListGet**](docs/ConnectorsApi.md#v1connectorslistget) | **GET** /v1/connectors/list | List of Connectors
*CorrelationsApi* | [**V1AggregatedCorrelationsGet**](docs/CorrelationsApi.md#v1aggregatedcorrelationsget) | **GET** /v1/aggregatedCorrelations | Get aggregated correlations
*CorrelationsApi* | [**V1AggregatedCorrelationsPost**](docs/CorrelationsApi.md#v1aggregatedcorrelationspost) | **POST** /v1/aggregatedCorrelations | Store or Update a Correlation
*CorrelationsApi* | [**V1CorrelationsGet**](docs/CorrelationsApi.md#v1correlationsget) | **GET** /v1/correlations | Get correlations
*CorrelationsApi* | [**V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet**](docs/CorrelationsApi.md#v1organizationsorganizationidusersuseridvariablesvariablenamecausesget) | **GET** /v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes | Search user correlations for a given cause
*CorrelationsApi* | [**V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet**](docs/CorrelationsApi.md#v1organizationsorganizationidusersuseridvariablesvariablenameeffectsget) | **GET** /v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects | Search user correlations for a given cause
*CorrelationsApi* | [**V1PublicCorrelationsSearchSearchGet**](docs/CorrelationsApi.md#v1publiccorrelationssearchsearchget) | **GET** /v1/public/correlations/search/{search} | Get average correlations for variables containing search term
*CorrelationsApi* | [**V1VariablesVariableNameCausesGet**](docs/CorrelationsApi.md#v1variablesvariablenamecausesget) | **GET** /v1/variables/{variableName}/causes | Search user correlations for a given effect
*CorrelationsApi* | [**V1VariablesVariableNameEffectsGet**](docs/CorrelationsApi.md#v1variablesvariablenameeffectsget) | **GET** /v1/variables/{variableName}/effects | Search user correlations for a given cause
*CorrelationsApi* | [**V1VariablesVariableNamePublicCausesGet**](docs/CorrelationsApi.md#v1variablesvariablenamepubliccausesget) | **GET** /v1/variables/{variableName}/public/causes | Search public correlations for a given effect
*CorrelationsApi* | [**V1VariablesVariableNamePublicEffectsGet**](docs/CorrelationsApi.md#v1variablesvariablenamepubliceffectsget) | **GET** /v1/variables/{variableName}/public/effects | Search public correlations for a given cause
*CorrelationsApi* | [**V1VotesDeletePost**](docs/CorrelationsApi.md#v1votesdeletepost) | **POST** /v1/votes/delete | Delete vote
*CorrelationsApi* | [**V1VotesPost**](docs/CorrelationsApi.md#v1votespost) | **POST** /v1/votes | Post or update vote
*MeasurementsApi* | [**V1MeasurementSourcesGet**](docs/MeasurementsApi.md#v1measurementsourcesget) | **GET** /v1/measurementSources | Get measurement sources
*MeasurementsApi* | [**V1MeasurementSourcesPost**](docs/MeasurementsApi.md#v1measurementsourcespost) | **POST** /v1/measurementSources | Add a data source
*MeasurementsApi* | [**V1MeasurementsDailyGet**](docs/MeasurementsApi.md#v1measurementsdailyget) | **GET** /v1/measurements/daily | Get daily measurements for this user
*MeasurementsApi* | [**V1MeasurementsDeletePost**](docs/MeasurementsApi.md#v1measurementsdeletepost) | **POST** /v1/measurements/delete | Delete a measurement
*MeasurementsApi* | [**V1MeasurementsGet**](docs/MeasurementsApi.md#v1measurementsget) | **GET** /v1/measurements | Get measurements for this user
*MeasurementsApi* | [**V1MeasurementsPost**](docs/MeasurementsApi.md#v1measurementspost) | **POST** /v1/measurements | Post a new set or update existing measurements to the database
*MeasurementsApi* | [**V1MeasurementsRangeGet**](docs/MeasurementsApi.md#v1measurementsrangeget) | **GET** /v1/measurementsRange | Get measurements range for this user
*MeasurementsApi* | [**V2MeasurementsCsvGet**](docs/MeasurementsApi.md#v2measurementscsvget) | **GET** /v2/measurements/csv | Get Measurements CSV
*MeasurementsApi* | [**V2MeasurementsIdDelete**](docs/MeasurementsApi.md#v2measurementsiddelete) | **DELETE** /v2/measurements/{id} | Delete Measurement
*MeasurementsApi* | [**V2MeasurementsIdGet**](docs/MeasurementsApi.md#v2measurementsidget) | **GET** /v2/measurements/{id} | Get Measurement
*MeasurementsApi* | [**V2MeasurementsIdPut**](docs/MeasurementsApi.md#v2measurementsidput) | **PUT** /v2/measurements/{id} | Update Measurement
*MeasurementsApi* | [**V2MeasurementsRequestCsvPost**](docs/MeasurementsApi.md#v2measurementsrequestcsvpost) | **POST** /v2/measurements/request_csv | Post Request for Measurements CSV
*MeasurementsApi* | [**V2MeasurementsRequestPdfPost**](docs/MeasurementsApi.md#v2measurementsrequestpdfpost) | **POST** /v2/measurements/request_pdf | Post Request for Measurements PDF
*MeasurementsApi* | [**V2MeasurementsRequestXlsPost**](docs/MeasurementsApi.md#v2measurementsrequestxlspost) | **POST** /v2/measurements/request_xls | Post Request for Measurements XLS
*OrganizationsApi* | [**V1OrganizationsOrganizationIdUsersPost**](docs/OrganizationsApi.md#v1organizationsorganizationiduserspost) | **POST** /v1/organizations/{organizationId}/users | Get user tokens for existing users, create new users
*PairsApi* | [**V1PairsCsvGet**](docs/PairsApi.md#v1pairscsvget) | **GET** /v1/pairsCsv | Get pairs
*PairsApi* | [**V1PairsGet**](docs/PairsApi.md#v1pairsget) | **GET** /v1/pairs | Get pairs
*RemindersApi* | [**V1TrackingReminderNotificationsGet**](docs/RemindersApi.md#v1trackingremindernotificationsget) | **GET** /v1/trackingReminderNotifications | Get specific pending tracking reminders
*RemindersApi* | [**V1TrackingReminderNotificationsSkipPost**](docs/RemindersApi.md#v1trackingremindernotificationsskippost) | **POST** /v1/trackingReminderNotifications/skip | Skip a pending tracking reminder
*RemindersApi* | [**V1TrackingReminderNotificationsSnoozePost**](docs/RemindersApi.md#v1trackingremindernotificationssnoozepost) | **POST** /v1/trackingReminderNotifications/snooze | Snooze a pending tracking reminder
*RemindersApi* | [**V1TrackingReminderNotificationsTrackPost**](docs/RemindersApi.md#v1trackingremindernotificationstrackpost) | **POST** /v1/trackingReminderNotifications/track | Track a pending tracking reminder
*RemindersApi* | [**V1TrackingRemindersDeletePost**](docs/RemindersApi.md#v1trackingremindersdeletepost) | **POST** /v1/trackingReminders/delete | Delete tracking reminder
*RemindersApi* | [**V1TrackingRemindersGet**](docs/RemindersApi.md#v1trackingremindersget) | **GET** /v1/trackingReminders | Get repeating tracking reminder settings
*RemindersApi* | [**V1TrackingRemindersPost**](docs/RemindersApi.md#v1trackingreminderspost) | **POST** /v1/trackingReminders | Store a Tracking Reminder
*TagsApi* | [**V1UserTagsDeletePost**](docs/TagsApi.md#v1usertagsdeletepost) | **POST** /v1/userTags/delete | Delete user tag or ingredient
*TagsApi* | [**V1UserTagsPost**](docs/TagsApi.md#v1usertagspost) | **POST** /v1/userTags | Post or update user tags or ingredients
*UnitsApi* | [**V1UnitCategoriesGet**](docs/UnitsApi.md#v1unitcategoriesget) | **GET** /v1/unitCategories | Get unit categories
*UnitsApi* | [**V1UnitsGet**](docs/UnitsApi.md#v1unitsget) | **GET** /v1/units | Get all available units
*UnitsApi* | [**V1UnitsVariableGet**](docs/UnitsApi.md#v1unitsvariableget) | **GET** /v1/unitsVariable | Units for Variable
*UserApi* | [**V1OrganizationsOrganizationIdUsersPost**](docs/UserApi.md#v1organizationsorganizationiduserspost) | **POST** /v1/organizations/{organizationId}/users | Get user tokens for existing users, create new users
*UserApi* | [**V1UserMeGet**](docs/UserApi.md#v1usermeget) | **GET** /v1/user/me | Get all available units for variableGet authenticated user
*VariablesApi* | [**V1PublicVariablesGet**](docs/VariablesApi.md#v1publicvariablesget) | **GET** /v1/public/variables | Get public variables
*VariablesApi* | [**V1PublicVariablesSearchSearchGet**](docs/VariablesApi.md#v1publicvariablessearchsearchget) | **GET** /v1/public/variables/search/{search} | Get top 5 PUBLIC variables with the most correlations
*VariablesApi* | [**V1UserVariablesPost**](docs/VariablesApi.md#v1uservariablespost) | **POST** /v1/userVariables | Update User Settings for a Variable
*VariablesApi* | [**V1VariableCategoriesGet**](docs/VariablesApi.md#v1variablecategoriesget) | **GET** /v1/variableCategories | Variable categories
*VariablesApi* | [**V1VariablesGet**](docs/VariablesApi.md#v1variablesget) | **GET** /v1/variables | Get variables by the category name
*VariablesApi* | [**V1VariablesPost**](docs/VariablesApi.md#v1variablespost) | **POST** /v1/variables | Create Variables
*VariablesApi* | [**V1VariablesSearchSearchGet**](docs/VariablesApi.md#v1variablessearchsearchget) | **GET** /v1/variables/search/{search} | Get variables by search query
*VariablesApi* | [**V1VariablesVariableNameGet**](docs/VariablesApi.md#v1variablesvariablenameget) | **GET** /v1/variables/{variableName} | Get info about a variable
*VotesApi* | [**V1VotesDeletePost**](docs/VotesApi.md#v1votesdeletepost) | **POST** /v1/votes/delete | Delete vote
*VotesApi* | [**V1VotesPost**](docs/VotesApi.md#v1votespost) | **POST** /v1/votes | Post or update vote


## Documentation for Models

 - [Model.CommonResponse](docs/CommonResponse.md)
 - [Model.Connection](docs/Connection.md)
 - [Model.Connector](docs/Connector.md)
 - [Model.ConnectorInfo](docs/ConnectorInfo.md)
 - [Model.ConnectorInfoHistoryItem](docs/ConnectorInfoHistoryItem.md)
 - [Model.ConnectorInstruction](docs/ConnectorInstruction.md)
 - [Model.ConversionStep](docs/ConversionStep.md)
 - [Model.Correlation](docs/Correlation.md)
 - [Model.Credential](docs/Credential.md)
 - [Model.HumanTime](docs/HumanTime.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse20010](docs/InlineResponse20010.md)
 - [Model.InlineResponse20011](docs/InlineResponse20011.md)
 - [Model.InlineResponse20012](docs/InlineResponse20012.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse2009](docs/InlineResponse2009.md)
 - [Model.JsonErrorResponse](docs/JsonErrorResponse.md)
 - [Model.Measurement](docs/Measurement.md)
 - [Model.MeasurementDelete](docs/MeasurementDelete.md)
 - [Model.MeasurementRange](docs/MeasurementRange.md)
 - [Model.MeasurementSet](docs/MeasurementSet.md)
 - [Model.MeasurementSource](docs/MeasurementSource.md)
 - [Model.Pairs](docs/Pairs.md)
 - [Model.Permission](docs/Permission.md)
 - [Model.PostCorrelation](docs/PostCorrelation.md)
 - [Model.PostVote](docs/PostVote.md)
 - [Model.TrackingReminder](docs/TrackingReminder.md)
 - [Model.TrackingReminderDelete](docs/TrackingReminderDelete.md)
 - [Model.TrackingReminderNotification](docs/TrackingReminderNotification.md)
 - [Model.TrackingReminderNotificationSkip](docs/TrackingReminderNotificationSkip.md)
 - [Model.TrackingReminderNotificationSnooze](docs/TrackingReminderNotificationSnooze.md)
 - [Model.TrackingReminderNotificationTrack](docs/TrackingReminderNotificationTrack.md)
 - [Model.Unit](docs/Unit.md)
 - [Model.UnitCategory](docs/UnitCategory.md)
 - [Model.Update](docs/Update.md)
 - [Model.User](docs/User.md)
 - [Model.UserTag](docs/UserTag.md)
 - [Model.UserTokenFailedResponse](docs/UserTokenFailedResponse.md)
 - [Model.UserTokenRequest](docs/UserTokenRequest.md)
 - [Model.UserTokenRequestInnerUserField](docs/UserTokenRequestInnerUserField.md)
 - [Model.UserTokenSuccessfulResponse](docs/UserTokenSuccessfulResponse.md)
 - [Model.UserTokenSuccessfulResponseInnerUserField](docs/UserTokenSuccessfulResponseInnerUserField.md)
 - [Model.UserVariable](docs/UserVariable.md)
 - [Model.UserVariableRelationship](docs/UserVariableRelationship.md)
 - [Model.UserVariables](docs/UserVariables.md)
 - [Model.ValueObject](docs/ValueObject.md)
 - [Model.Variable](docs/Variable.md)
 - [Model.VariableCategory](docs/VariableCategory.md)
 - [Model.VariableNew](docs/VariableNew.md)
 - [Model.VariableUserSource](docs/VariableUserSource.md)
 - [Model.VariablesNew](docs/VariablesNew.md)
 - [Model.Vote](docs/Vote.md)
 - [Model.VoteDelete](docs/VoteDelete.md)


## Documentation for Authorization


### oauth2

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://app.quantimo.do/api/v1/oauth2/authorize
- **Scopes**: 
  - basic: Basic authentication
  - readmeasurements: Grants read access to measurements and variables. Allows the client app to obtain the user&#39;s data.
  - writemeasurements: Grants write access to measurements and variables. Allows the client app to store user data.

### quantimodo_oauth2

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: /api/v2/oauth/authorize
- **Scopes**: 
  - basic: allows you to read user info (displayname, email, etc).
  - readmeasurements: allows one to read a user&#39;s data
  - writemeasurements: allows you to write user data

### basicAuth

- **Type**: HTTP basic authentication

### internalApiKey

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: HTTP header

