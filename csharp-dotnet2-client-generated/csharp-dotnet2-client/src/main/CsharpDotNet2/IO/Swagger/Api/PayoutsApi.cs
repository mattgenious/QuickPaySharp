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
    public interface IPayoutsApi
    {
        /// <summary>
        /// Delete payout link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param>
        /// <returns></returns>
        void DELETEPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get payouts  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="dateYear">&lt;p&gt;Year&lt;/p&gt; </param>
        /// <param name="dateMonth">&lt;p&gt;Month&lt;/p&gt; </param>
        /// <param name="dateDay">&lt;p&gt;Day of the month&lt;/p&gt; </param>
        /// <param name="dateHour">&lt;p&gt;Hour of the day&lt;/p&gt; </param>
        /// <param name="dateMinute">&lt;p&gt;Minute of the hour&lt;/p&gt; </param>
        /// <param name="timestamp">&lt;p&gt;Timestamp field&lt;/p&gt; </param>
        /// <param name="minTime">&lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt; </param>
        /// <param name="maxTime">&lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt; </param>
        /// <param name="operationsSize">&lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt; </param>
        /// <param name="accepted">&lt;p&gt;Return accepted payouts&lt;/p&gt; </param>
        /// <param name="orderId">&lt;p&gt;Find by order_id&lt;/p&gt; </param>
        /// <param name="state">&lt;p&gt;Find by state&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Find by payout id&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Filter by acquirer&lt;/p&gt; </param>
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param>
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param>
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param>
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payout</returns>
        QuickPayProtocolV10Payout GETPayoutsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, int? page, int? pageSize, string sortBy, string sortDir);
        /// <summary>
        /// Get payout  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param>
        /// <param name="operationsSize">&lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payout</returns>
        QuickPayProtocolV10Payout GETPayoutsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize);
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param>
        /// <param name="operationId">&lt;p&gt;Operations id&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Operation</returns>
        QuickPayProtocolV10Operation GETPayoutsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId);
        /// <summary>
        /// Update payout  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param>
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payout</returns>
        QuickPayProtocolV10Payout PATCHPayoutsIdFormat (string acceptVersion, string authorization, int? id, Dictionary<string, string> variables);
        /// <summary>
        /// Create payout  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="currency">&lt;p&gt;Currency&lt;/p&gt; </param>
        /// <param name="orderId">&lt;p&gt;Unique order id(must be between 4-20 characters)&lt;/p&gt; </param>
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param>
        /// <param name="textOnStatement">&lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payout</returns>
        QuickPayProtocolV10Payout POSTPayoutsFormat (string acceptVersion, string authorization, string currency, string orderId, Dictionary<string, string> variables, string textOnStatement);
        /// <summary>
        /// Authorize a payout  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount&lt;/p&gt; </param>
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param>
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param>
        /// <param name="vatRate">&lt;p&gt;Vate rate&lt;/p&gt; </param>
        /// <param name="cardNumber">&lt;p&gt;Card number&lt;/p&gt; </param>
        /// <param name="cardExpiration">&lt;p&gt;Expiration date (YYMM)&lt;/p&gt; </param>
        /// <param name="cardCvd">&lt;p&gt;CVD/CVV&lt;/p&gt; </param>
        /// <param name="cardToken">&lt;p&gt;Card token&lt;/p&gt; </param>
        /// <param name="cardApplePayToken">&lt;p&gt;Apple Pay payment-token&lt;/p&gt; </param>
        /// <param name="cardMobilepayOnlineToken">&lt;p&gt;MobilePay Online payment-token&lt;/p&gt; </param>
        /// <param name="cardIssuedTo">&lt;p&gt;Card holder name&lt;/p&gt; </param>
        /// <param name="cardBrand">&lt;p&gt;Brand to use on multi-brand card&lt;/p&gt; </param>
        /// <param name="cardStatus">&lt;p&gt;3D-Secure status&lt;/p&gt; </param>
        /// <param name="cardEci">&lt;p&gt;3D-Secure eci&lt;/p&gt; </param>
        /// <param name="cardXav">&lt;p&gt;3D-Secure xav&lt;/p&gt; </param>
        /// <param name="cardCavv">&lt;p&gt;3D-Secure cavv&lt;/p&gt; </param>
        /// <param name="mobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param>
        /// <param name="ninNumber">&lt;p&gt;Customer NIN Number&lt;/p&gt; </param>
        /// <param name="ninCountryCode">&lt;p&gt;Customer country (ISO 3166-1 Alpha-3)&lt;/p&gt; </param>
        /// <param name="ninGender">&lt;p&gt;Customer gender&lt;/p&gt; </param>
        /// <param name="personFirstName">&lt;p&gt;Person first name&lt;/p&gt; </param>
        /// <param name="personLastName">&lt;p&gt;Person last name&lt;/p&gt; </param>
        /// <param name="personEmail">&lt;p&gt;Person email&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param>
        /// <param name="customerIp">&lt;p&gt;Customer IP&lt;/p&gt; </param>
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payout</returns>
        QuickPayProtocolV10Payout POSTPayoutsIdCreditFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, Dictionary<string, string> cardApplePayToken, Dictionary<string, string> cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, string acquirer, string customerIp, Dictionary<string, string> extras);
        /// <summary>
        /// Create or update a payout link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount to credit&lt;/p&gt; </param>
        /// <param name="agreementId">&lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt; </param>
        /// <param name="language">&lt;p&gt;Language&lt;/p&gt; </param>
        /// <param name="continueUrl">&lt;p&gt;Url that cardholder is redirected to after credit&lt;/p&gt; </param>
        /// <param name="cancelUrl">&lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt; </param>
        /// <param name="callbackUrl">&lt;p&gt;Endpoint for async callback&lt;/p&gt; </param>
        /// <param name="paymentMethods">&lt;p&gt;Limit payment methods&lt;/p&gt; </param>
        /// <param name="brandingId">&lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt; </param>
        /// <param name="googleAnalyticsTrackingId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param>
        /// <param name="googleAnalyticsClientId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Force usage of the given acquirer&lt;/p&gt; </param>
        /// <param name="framed">&lt;p&gt;Allow opening in iframe&lt;/p&gt; </param>
        /// <param name="brandingConfig">&lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10PaymentLinkUrl</returns>
        QuickPayProtocolV10PaymentLinkUrl PUTPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, Dictionary<string, string> brandingConfig);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PayoutsApi : IPayoutsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PayoutsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PayoutsApi(String basePath)
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
        /// Delete payout link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void DELETEPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETEPayoutsIdLinkFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETEPayoutsIdLinkFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETEPayoutsIdLinkFormat");
            
    
            var path = "/payouts/{id}/link";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEPayoutsIdLinkFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEPayoutsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get payouts  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="dateYear">&lt;p&gt;Year&lt;/p&gt; </param> 
        /// <param name="dateMonth">&lt;p&gt;Month&lt;/p&gt; </param> 
        /// <param name="dateDay">&lt;p&gt;Day of the month&lt;/p&gt; </param> 
        /// <param name="dateHour">&lt;p&gt;Hour of the day&lt;/p&gt; </param> 
        /// <param name="dateMinute">&lt;p&gt;Minute of the hour&lt;/p&gt; </param> 
        /// <param name="timestamp">&lt;p&gt;Timestamp field&lt;/p&gt; </param> 
        /// <param name="minTime">&lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt; </param> 
        /// <param name="maxTime">&lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt; </param> 
        /// <param name="operationsSize">&lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt; </param> 
        /// <param name="accepted">&lt;p&gt;Return accepted payouts&lt;/p&gt; </param> 
        /// <param name="orderId">&lt;p&gt;Find by order_id&lt;/p&gt; </param> 
        /// <param name="state">&lt;p&gt;Find by state&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Find by payout id&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Filter by acquirer&lt;/p&gt; </param> 
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param> 
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param> 
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param> 
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payout</returns>            
        public QuickPayProtocolV10Payout GETPayoutsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, int? page, int? pageSize, string sortBy, string sortDir)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETPayoutsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETPayoutsFormat");
            
    
            var path = "/payouts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (dateYear != null) queryParams.Add("date[year]", ApiClient.ParameterToString(dateYear)); // query parameter
 if (dateMonth != null) queryParams.Add("date[month]", ApiClient.ParameterToString(dateMonth)); // query parameter
 if (dateDay != null) queryParams.Add("date[day]", ApiClient.ParameterToString(dateDay)); // query parameter
 if (dateHour != null) queryParams.Add("date[hour]", ApiClient.ParameterToString(dateHour)); // query parameter
 if (dateMinute != null) queryParams.Add("date[minute]", ApiClient.ParameterToString(dateMinute)); // query parameter
 if (timestamp != null) queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
 if (minTime != null) queryParams.Add("min_time", ApiClient.ParameterToString(minTime)); // query parameter
 if (maxTime != null) queryParams.Add("max_time", ApiClient.ParameterToString(maxTime)); // query parameter
 if (operationsSize != null) queryParams.Add("operations_size", ApiClient.ParameterToString(operationsSize)); // query parameter
 if (accepted != null) queryParams.Add("accepted", ApiClient.ParameterToString(accepted)); // query parameter
 if (orderId != null) queryParams.Add("order_id", ApiClient.ParameterToString(orderId)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (acquirer != null) queryParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (sortBy != null) queryParams.Add("sort_by", ApiClient.ParameterToString(sortBy)); // query parameter
 if (sortDir != null) queryParams.Add("sort_dir", ApiClient.ParameterToString(sortDir)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payout) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payout), response.Headers);
        }
    
        /// <summary>
        /// Get payout  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param> 
        /// <param name="operationsSize">&lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payout</returns>            
        public QuickPayProtocolV10Payout GETPayoutsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETPayoutsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETPayoutsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETPayoutsIdFormat");
            
    
            var path = "/payouts/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (operationsSize != null) queryParams.Add("operations_size", ApiClient.ParameterToString(operationsSize)); // query parameter
             if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payout) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payout), response.Headers);
        }
    
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param> 
        /// <param name="operationId">&lt;p&gt;Operations id&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Operation</returns>            
        public QuickPayProtocolV10Operation GETPayoutsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETPayoutsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETPayoutsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETPayoutsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'operationId' is set
            if (operationId == null) throw new ApiException(400, "Missing required parameter 'operationId' when calling GETPayoutsIdOperationsOperationIdFormat");
            
    
            var path = "/payouts/{id}/operations/{operation_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "operation_id" + "}", ApiClient.ParameterToString(operationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsIdOperationsOperationIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsIdOperationsOperationIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Operation) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Operation), response.Headers);
        }
    
        /// <summary>
        /// Update payout  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param> 
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payout</returns>            
        public QuickPayProtocolV10Payout PATCHPayoutsIdFormat (string acceptVersion, string authorization, int? id, Dictionary<string, string> variables)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHPayoutsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHPayoutsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHPayoutsIdFormat");
            
    
            var path = "/payouts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHPayoutsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHPayoutsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payout) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payout), response.Headers);
        }
    
        /// <summary>
        /// Create payout  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="currency">&lt;p&gt;Currency&lt;/p&gt; </param> 
        /// <param name="orderId">&lt;p&gt;Unique order id(must be between 4-20 characters)&lt;/p&gt; </param> 
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param> 
        /// <param name="textOnStatement">&lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payout</returns>            
        public QuickPayProtocolV10Payout POSTPayoutsFormat (string acceptVersion, string authorization, string currency, string orderId, Dictionary<string, string> variables, string textOnStatement)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPayoutsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPayoutsFormat");
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling POSTPayoutsFormat");
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling POSTPayoutsFormat");
            
    
            var path = "/payouts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (currency != null) formParams.Add("currency", ApiClient.ParameterToString(currency)); // form parameter
if (orderId != null) formParams.Add("order_id", ApiClient.ParameterToString(orderId)); // form parameter
if (variables != null) formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter
if (textOnStatement != null) formParams.Add("text_on_statement", ApiClient.ParameterToString(textOnStatement)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPayoutsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPayoutsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payout) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payout), response.Headers);
        }
    
        /// <summary>
        /// Authorize a payout  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount&lt;/p&gt; </param> 
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param> 
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param> 
        /// <param name="vatRate">&lt;p&gt;Vate rate&lt;/p&gt; </param> 
        /// <param name="cardNumber">&lt;p&gt;Card number&lt;/p&gt; </param> 
        /// <param name="cardExpiration">&lt;p&gt;Expiration date (YYMM)&lt;/p&gt; </param> 
        /// <param name="cardCvd">&lt;p&gt;CVD/CVV&lt;/p&gt; </param> 
        /// <param name="cardToken">&lt;p&gt;Card token&lt;/p&gt; </param> 
        /// <param name="cardApplePayToken">&lt;p&gt;Apple Pay payment-token&lt;/p&gt; </param> 
        /// <param name="cardMobilepayOnlineToken">&lt;p&gt;MobilePay Online payment-token&lt;/p&gt; </param> 
        /// <param name="cardIssuedTo">&lt;p&gt;Card holder name&lt;/p&gt; </param> 
        /// <param name="cardBrand">&lt;p&gt;Brand to use on multi-brand card&lt;/p&gt; </param> 
        /// <param name="cardStatus">&lt;p&gt;3D-Secure status&lt;/p&gt; </param> 
        /// <param name="cardEci">&lt;p&gt;3D-Secure eci&lt;/p&gt; </param> 
        /// <param name="cardXav">&lt;p&gt;3D-Secure xav&lt;/p&gt; </param> 
        /// <param name="cardCavv">&lt;p&gt;3D-Secure cavv&lt;/p&gt; </param> 
        /// <param name="mobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param> 
        /// <param name="ninNumber">&lt;p&gt;Customer NIN Number&lt;/p&gt; </param> 
        /// <param name="ninCountryCode">&lt;p&gt;Customer country (ISO 3166-1 Alpha-3)&lt;/p&gt; </param> 
        /// <param name="ninGender">&lt;p&gt;Customer gender&lt;/p&gt; </param> 
        /// <param name="personFirstName">&lt;p&gt;Person first name&lt;/p&gt; </param> 
        /// <param name="personLastName">&lt;p&gt;Person last name&lt;/p&gt; </param> 
        /// <param name="personEmail">&lt;p&gt;Person email&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param> 
        /// <param name="customerIp">&lt;p&gt;Customer IP&lt;/p&gt; </param> 
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payout</returns>            
        public QuickPayProtocolV10Payout POSTPayoutsIdCreditFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, Dictionary<string, string> cardApplePayToken, Dictionary<string, string> cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, string acquirer, string customerIp, Dictionary<string, string> extras)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPayoutsIdCreditFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPayoutsIdCreditFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTPayoutsIdCreditFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTPayoutsIdCreditFormat");
            
    
            var path = "/payouts/{id}/credit";
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
 if (quickPayCallbackUrl != null) headerParams.Add("QuickPay-Callback-Url", ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter
            if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
if (vatRate != null) formParams.Add("vat_rate", ApiClient.ParameterToString(vatRate)); // form parameter
if (cardNumber != null) formParams.Add("card[number]", ApiClient.ParameterToString(cardNumber)); // form parameter
if (cardExpiration != null) formParams.Add("card[expiration]", ApiClient.ParameterToString(cardExpiration)); // form parameter
if (cardCvd != null) formParams.Add("card[cvd]", ApiClient.ParameterToString(cardCvd)); // form parameter
if (cardToken != null) formParams.Add("card[token]", ApiClient.ParameterToString(cardToken)); // form parameter
if (cardApplePayToken != null) formParams.Add("card[apple_pay_token]", ApiClient.ParameterToString(cardApplePayToken)); // form parameter
if (cardMobilepayOnlineToken != null) formParams.Add("card[mobilepay_online_token]", ApiClient.ParameterToString(cardMobilepayOnlineToken)); // form parameter
if (cardIssuedTo != null) formParams.Add("card[issued_to]", ApiClient.ParameterToString(cardIssuedTo)); // form parameter
if (cardBrand != null) formParams.Add("card[brand]", ApiClient.ParameterToString(cardBrand)); // form parameter
if (cardStatus != null) formParams.Add("card[status]", ApiClient.ParameterToString(cardStatus)); // form parameter
if (cardEci != null) formParams.Add("card[eci]", ApiClient.ParameterToString(cardEci)); // form parameter
if (cardXav != null) formParams.Add("card[xav]", ApiClient.ParameterToString(cardXav)); // form parameter
if (cardCavv != null) formParams.Add("card[cavv]", ApiClient.ParameterToString(cardCavv)); // form parameter
if (mobileNumber != null) formParams.Add("mobile_number", ApiClient.ParameterToString(mobileNumber)); // form parameter
if (ninNumber != null) formParams.Add("nin[number]", ApiClient.ParameterToString(ninNumber)); // form parameter
if (ninCountryCode != null) formParams.Add("nin[country_code]", ApiClient.ParameterToString(ninCountryCode)); // form parameter
if (ninGender != null) formParams.Add("nin[gender]", ApiClient.ParameterToString(ninGender)); // form parameter
if (personFirstName != null) formParams.Add("person[first_name]", ApiClient.ParameterToString(personFirstName)); // form parameter
if (personLastName != null) formParams.Add("person[last_name]", ApiClient.ParameterToString(personLastName)); // form parameter
if (personEmail != null) formParams.Add("person[email]", ApiClient.ParameterToString(personEmail)); // form parameter
if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
if (customerIp != null) formParams.Add("customer_ip", ApiClient.ParameterToString(customerIp)); // form parameter
if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPayoutsIdCreditFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPayoutsIdCreditFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payout) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payout), response.Headers);
        }
    
        /// <summary>
        /// Create or update a payout link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payout id&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount to credit&lt;/p&gt; </param> 
        /// <param name="agreementId">&lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt; </param> 
        /// <param name="language">&lt;p&gt;Language&lt;/p&gt; </param> 
        /// <param name="continueUrl">&lt;p&gt;Url that cardholder is redirected to after credit&lt;/p&gt; </param> 
        /// <param name="cancelUrl">&lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt; </param> 
        /// <param name="callbackUrl">&lt;p&gt;Endpoint for async callback&lt;/p&gt; </param> 
        /// <param name="paymentMethods">&lt;p&gt;Limit payment methods&lt;/p&gt; </param> 
        /// <param name="brandingId">&lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt; </param> 
        /// <param name="googleAnalyticsTrackingId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param> 
        /// <param name="googleAnalyticsClientId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Force usage of the given acquirer&lt;/p&gt; </param> 
        /// <param name="framed">&lt;p&gt;Allow opening in iframe&lt;/p&gt; </param> 
        /// <param name="brandingConfig">&lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10PaymentLinkUrl</returns>            
        public QuickPayProtocolV10PaymentLinkUrl PUTPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, Dictionary<string, string> brandingConfig)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PUTPayoutsIdLinkFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PUTPayoutsIdLinkFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PUTPayoutsIdLinkFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling PUTPayoutsIdLinkFormat");
            
    
            var path = "/payouts/{id}/link";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
if (agreementId != null) formParams.Add("agreement_id", ApiClient.ParameterToString(agreementId)); // form parameter
if (language != null) formParams.Add("language", ApiClient.ParameterToString(language)); // form parameter
if (continueUrl != null) formParams.Add("continue_url", ApiClient.ParameterToString(continueUrl)); // form parameter
if (cancelUrl != null) formParams.Add("cancel_url", ApiClient.ParameterToString(cancelUrl)); // form parameter
if (callbackUrl != null) formParams.Add("callback_url", ApiClient.ParameterToString(callbackUrl)); // form parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling PUTPayoutsIdLinkFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTPayoutsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10PaymentLinkUrl) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10PaymentLinkUrl), response.Headers);
        }
    
    }
}
