using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICardsApi
    {
        /// <summary>
        /// Delete card link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <returns></returns>
        void DELETECardsIdLinkFormat (string acceptVersion, string authorization, string id);
        /// <summary>
        /// Get saved cards  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="timestamp">&lt;p&gt;Timestamp field&lt;/p&gt; </param>
        /// <param name="minTime">&lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt; </param>
        /// <param name="maxTime">&lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt; </param>
        /// <param name="fraudSuspected">&lt;p&gt;Filter by suspected fraud&lt;/p&gt; </param>
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param>
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param>
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param>
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param>
        /// <param name="pageKey"> </param>
        /// <returns>Card</returns>
        Card GETCardsFormat (string acceptVersion, string authorization, string timestamp, string minTime, string maxTime, bool? fraudSuspected, int? page, int? pageSize, string sortBy, string sortDir, int? pageKey);
        /// <summary>
        /// Get saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <returns>Card</returns>
        Card GETCardsIdFormat (string acceptVersion, string authorization, string id);
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="operationId">&lt;p&gt;Operations id&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <returns>CardOperation</returns>
        CardOperation GETCardsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? operationId, string id);
        /// <summary>
        /// Update saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param>
        /// <returns>Card</returns>
        Card PATCHCardsIdFormat (string acceptVersion, string authorization, string id, Dictionary<string, string> variables);
        /// <summary>
        /// Create saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param>
        /// <returns>Card</returns>
        Card POSTCardsFormat (string acceptVersion, string authorization, Dictionary<string, string> variables);
        /// <summary>
        /// Authorize saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="cardNumber">&lt;p&gt;Card number&lt;/p&gt; </param>
        /// <param name="cardExpiration">&lt;p&gt;Expiration date (YYMM)&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param>
        /// <param name="cardCvd">&lt;p&gt;CVD/CVV&lt;/p&gt; </param>
        /// <param name="cardIssuedTo">&lt;p&gt;Card holder name&lt;/p&gt; </param>
        /// <param name="cardBrand">&lt;p&gt;Brand to use on multi-brand card&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param>
        /// <param name="customerIp">&lt;p&gt;Customer IP&lt;/p&gt; </param>
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param>
        /// <returns>Card</returns>
        Card POSTCardsIdAuthorizeFormat (string acceptVersion, string authorization, string cardNumber, string cardExpiration, string id, bool? synchronized, string cardCvd, string cardIssuedTo, string cardBrand, string acquirer, string customerIp, Dictionary<string, string> extras);
        /// <summary>
        /// Cancel saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param>
        /// <returns>Card</returns>
        Card POSTCardsIdCancelFormat (string acceptVersion, string authorization, string id, bool? synchronized);
        /// <summary>
        /// Create fraud confirmation report  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param>
        /// <param name="description"> </param>
        /// <returns>FraudReport</returns>
        FraudReport POSTCardsIdFraudReportFormat (string acceptVersion, string authorization, string id, string quickPayCallbackUrl, string description);
        /// <summary>
        /// Create card token  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <returns>CardToken</returns>
        CardToken POSTCardsIdTokensFormat (string acceptVersion, string authorization, string id);
        /// <summary>
        /// Create or update a card link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id"> </param>
        /// <param name="agreementId">&lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt; </param>
        /// <param name="language">&lt;p&gt;Language&lt;/p&gt; </param>
        /// <param name="continueurl">&lt;p&gt;Url that cardholder is redirected to after authorize&lt;/p&gt; </param>
        /// <param name="cancelurl">&lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt; </param>
        /// <param name="callbackurl">&lt;p&gt;Endpoint for async callback&lt;/p&gt; </param>
        /// <param name="paymentMethods">&lt;p&gt;Limit payment methods&lt;/p&gt; </param>
        /// <param name="brandingId">&lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt; </param>
        /// <param name="googleAnalyticsTrackingId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param>
        /// <param name="googleAnalyticsClientId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Force usage of the given acquirer&lt;/p&gt; </param>
        /// <param name="framed">&lt;p&gt;Allow opening in iframe&lt;/p&gt; </param>
        /// <param name="brandingConfig">&lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt; </param>
        /// <returns>CardLinkUrl</returns>
        CardLinkUrl PUTCardsIdLinkFormat (string acceptVersion, string authorization, string id, int? agreementId, string language, string continueurl, string cancelurl, string callbackurl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, Dictionary<string, string> brandingConfig);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CardsApi : ICardsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CardsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CardsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardsApi(String basePath)
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
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Delete card link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <returns></returns>            
        public void DELETECardsIdLinkFormat (string acceptVersion, string authorization, string id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETECardsIdLinkFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETECardsIdLinkFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETECardsIdLinkFormat");
            
    
            var path = "/cards/{id}/link";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETECardsIdLinkFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETECardsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get saved cards  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="timestamp">&lt;p&gt;Timestamp field&lt;/p&gt; </param> 
        /// <param name="minTime">&lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt; </param> 
        /// <param name="maxTime">&lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt; </param> 
        /// <param name="fraudSuspected">&lt;p&gt;Filter by suspected fraud&lt;/p&gt; </param> 
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param> 
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param> 
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param> 
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param> 
        /// <param name="pageKey"> </param> 
        /// <returns>Card</returns>            
        public Card GETCardsFormat (string acceptVersion, string authorization, string timestamp, string minTime, string maxTime, bool? fraudSuspected, int? page, int? pageSize, string sortBy, string sortDir, int? pageKey)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETCardsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETCardsFormat");
            
    
            var path = "/cards";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (timestamp != null) queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
 if (minTime != null) queryParams.Add("min_time", ApiClient.ParameterToString(minTime)); // query parameter
 if (maxTime != null) queryParams.Add("max_time", ApiClient.ParameterToString(maxTime)); // query parameter
 if (fraudSuspected != null) queryParams.Add("fraud_suspected", ApiClient.ParameterToString(fraudSuspected)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (sortBy != null) queryParams.Add("sort_by", ApiClient.ParameterToString(sortBy)); // query parameter
 if (sortDir != null) queryParams.Add("sort_dir", ApiClient.ParameterToString(sortDir)); // query parameter
 if (pageKey != null) queryParams.Add("page_key", ApiClient.ParameterToString(pageKey)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCardsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCardsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Card) ApiClient.Deserialize(response.Content, typeof(Card), response.Headers);
        }
    
        /// <summary>
        /// Get saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <returns>Card</returns>            
        public Card GETCardsIdFormat (string acceptVersion, string authorization, string id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETCardsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETCardsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETCardsIdFormat");
            
    
            var path = "/cards/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCardsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCardsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Card) ApiClient.Deserialize(response.Content, typeof(Card), response.Headers);
        }
    
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="operationId">&lt;p&gt;Operations id&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <returns>CardOperation</returns>            
        public CardOperation GETCardsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? operationId, string id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETCardsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETCardsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'operationId' is set
            if (operationId == null) throw new ApiException(400, "Missing required parameter 'operationId' when calling GETCardsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETCardsIdOperationsOperationIdFormat");
            
    
            var path = "/cards/{id}/operations/{operation_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "operation_id" + "}", ApiClient.ParameterToString(operationId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCardsIdOperationsOperationIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETCardsIdOperationsOperationIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CardOperation) ApiClient.Deserialize(response.Content, typeof(CardOperation), response.Headers);
        }
    
        /// <summary>
        /// Update saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param> 
        /// <returns>Card</returns>            
        public Card PATCHCardsIdFormat (string acceptVersion, string authorization, string id, Dictionary<string, string> variables)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHCardsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHCardsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHCardsIdFormat");
            
    
            var path = "/cards/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (variables != null) formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHCardsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHCardsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Card) ApiClient.Deserialize(response.Content, typeof(Card), response.Headers);
        }
    
        /// <summary>
        /// Create saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param> 
        /// <returns>Card</returns>            
        public Card POSTCardsFormat (string acceptVersion, string authorization, Dictionary<string, string> variables)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTCardsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTCardsFormat");
            
    
            var path = "/cards";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (variables != null) formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Card) ApiClient.Deserialize(response.Content, typeof(Card), response.Headers);
        }
    
        /// <summary>
        /// Authorize saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="cardNumber">&lt;p&gt;Card number&lt;/p&gt; </param> 
        /// <param name="cardExpiration">&lt;p&gt;Expiration date (YYMM)&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param> 
        /// <param name="cardCvd">&lt;p&gt;CVD/CVV&lt;/p&gt; </param> 
        /// <param name="cardIssuedTo">&lt;p&gt;Card holder name&lt;/p&gt; </param> 
        /// <param name="cardBrand">&lt;p&gt;Brand to use on multi-brand card&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param> 
        /// <param name="customerIp">&lt;p&gt;Customer IP&lt;/p&gt; </param> 
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param> 
        /// <returns>Card</returns>            
        public Card POSTCardsIdAuthorizeFormat (string acceptVersion, string authorization, string cardNumber, string cardExpiration, string id, bool? synchronized, string cardCvd, string cardIssuedTo, string cardBrand, string acquirer, string customerIp, Dictionary<string, string> extras)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTCardsIdAuthorizeFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTCardsIdAuthorizeFormat");
            
            // verify the required parameter 'cardNumber' is set
            if (cardNumber == null) throw new ApiException(400, "Missing required parameter 'cardNumber' when calling POSTCardsIdAuthorizeFormat");
            
            // verify the required parameter 'cardExpiration' is set
            if (cardExpiration == null) throw new ApiException(400, "Missing required parameter 'cardExpiration' when calling POSTCardsIdAuthorizeFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTCardsIdAuthorizeFormat");
            
    
            var path = "/cards/{id}/authorize";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (synchronized != null) queryParams.Add("synchronized", ApiClient.ParameterToString(synchronized)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (cardNumber != null) formParams.Add("card[number]", ApiClient.ParameterToString(cardNumber)); // form parameter
if (cardExpiration != null) formParams.Add("card[expiration]", ApiClient.ParameterToString(cardExpiration)); // form parameter
if (cardCvd != null) formParams.Add("card[cvd]", ApiClient.ParameterToString(cardCvd)); // form parameter
if (cardIssuedTo != null) formParams.Add("card[issued_to]", ApiClient.ParameterToString(cardIssuedTo)); // form parameter
if (cardBrand != null) formParams.Add("card[brand]", ApiClient.ParameterToString(cardBrand)); // form parameter
if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
if (customerIp != null) formParams.Add("customer_ip", ApiClient.ParameterToString(customerIp)); // form parameter
if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsIdAuthorizeFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsIdAuthorizeFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Card) ApiClient.Deserialize(response.Content, typeof(Card), response.Headers);
        }
    
        /// <summary>
        /// Cancel saved card  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param> 
        /// <returns>Card</returns>            
        public Card POSTCardsIdCancelFormat (string acceptVersion, string authorization, string id, bool? synchronized)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTCardsIdCancelFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTCardsIdCancelFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTCardsIdCancelFormat");
            
    
            var path = "/cards/{id}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (synchronized != null) queryParams.Add("synchronized", ApiClient.ParameterToString(synchronized)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsIdCancelFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsIdCancelFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Card) ApiClient.Deserialize(response.Content, typeof(Card), response.Headers);
        }
    
        /// <summary>
        /// Create fraud confirmation report  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param> 
        /// <param name="description"> </param> 
        /// <returns>FraudReport</returns>            
        public FraudReport POSTCardsIdFraudReportFormat (string acceptVersion, string authorization, string id, string quickPayCallbackUrl, string description)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTCardsIdFraudReportFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTCardsIdFraudReportFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTCardsIdFraudReportFormat");
            
    
            var path = "/cards/{id}/fraud-report";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (quickPayCallbackUrl != null) headerParams.Add("QuickPay-Callback-Url", ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter
            if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsIdFraudReportFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsIdFraudReportFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FraudReport) ApiClient.Deserialize(response.Content, typeof(FraudReport), response.Headers);
        }
    
        /// <summary>
        /// Create card token  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <returns>CardToken</returns>            
        public CardToken POSTCardsIdTokensFormat (string acceptVersion, string authorization, string id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTCardsIdTokensFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTCardsIdTokensFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTCardsIdTokensFormat");
            
    
            var path = "/cards/{id}/tokens";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsIdTokensFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTCardsIdTokensFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CardToken) ApiClient.Deserialize(response.Content, typeof(CardToken), response.Headers);
        }
    
        /// <summary>
        /// Create or update a card link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id"> </param> 
        /// <param name="agreementId">&lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt; </param> 
        /// <param name="language">&lt;p&gt;Language&lt;/p&gt; </param> 
        /// <param name="continueurl">&lt;p&gt;Url that cardholder is redirected to after authorize&lt;/p&gt; </param> 
        /// <param name="cancelurl">&lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt; </param> 
        /// <param name="callbackurl">&lt;p&gt;Endpoint for async callback&lt;/p&gt; </param> 
        /// <param name="paymentMethods">&lt;p&gt;Limit payment methods&lt;/p&gt; </param> 
        /// <param name="brandingId">&lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt; </param> 
        /// <param name="googleAnalyticsTrackingId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param> 
        /// <param name="googleAnalyticsClientId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Force usage of the given acquirer&lt;/p&gt; </param> 
        /// <param name="framed">&lt;p&gt;Allow opening in iframe&lt;/p&gt; </param> 
        /// <param name="brandingConfig">&lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt; </param> 
        /// <returns>CardLinkUrl</returns>            
        public CardLinkUrl PUTCardsIdLinkFormat (string acceptVersion, string authorization, string id, int? agreementId, string language, string continueurl, string cancelurl, string callbackurl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, Dictionary<string, string> brandingConfig)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PUTCardsIdLinkFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PUTCardsIdLinkFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PUTCardsIdLinkFormat");
            
    
            var path = "/cards/{id}/link";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (agreementId != null) formParams.Add("agreement_id", ApiClient.ParameterToString(agreementId)); // form parameter
if (language != null) formParams.Add("language", ApiClient.ParameterToString(language)); // form parameter
if (continueurl != null) formParams.Add("continueurl", ApiClient.ParameterToString(continueurl)); // form parameter
if (cancelurl != null) formParams.Add("cancelurl", ApiClient.ParameterToString(cancelurl)); // form parameter
if (callbackurl != null) formParams.Add("callbackurl", ApiClient.ParameterToString(callbackurl)); // form parameter
if (paymentMethods != null) formParams.Add("payment_methods", ApiClient.ParameterToString(paymentMethods)); // form parameter
if (brandingId != null) formParams.Add("branding_id", ApiClient.ParameterToString(brandingId)); // form parameter
if (googleAnalyticsTrackingId != null) formParams.Add("google_analytics_tracking_id", ApiClient.ParameterToString(googleAnalyticsTrackingId)); // form parameter
if (googleAnalyticsClientId != null) formParams.Add("google_analytics_client_id", ApiClient.ParameterToString(googleAnalyticsClientId)); // form parameter
if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
if (framed != null) formParams.Add("framed", ApiClient.ParameterToString(framed)); // form parameter
if (brandingConfig != null) formParams.Add("branding_config", ApiClient.ParameterToString(brandingConfig)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCardsIdLinkFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTCardsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CardLinkUrl) ApiClient.Deserialize(response.Content, typeof(CardLinkUrl), response.Headers);
        }
    
    }
}
