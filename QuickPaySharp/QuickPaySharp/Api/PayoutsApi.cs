using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using QuickPaySharp.Client;
using QuickPaySharp.Model;

namespace QuickPaySharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPayoutsApi
    {
        /// <summary>
        /// Delete payout link  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Payout id </param>
        /// <returns></returns>
        void DELETEPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get payouts  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="dateYear">Year </param>
        /// <param name="dateMonth">Month </param>
        /// <param name="dateDay">Day of the month </param>
        /// <param name="dateHour">Hour of the day </param>
        /// <param name="dateMinute">Minute of the hour </param>
        /// <param name="timestamp">Timestamp field </param>
        /// <param name="minTime">Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z” </param>
        /// <param name="maxTime">Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z” </param>
        /// <param name="operationsSize">Maximum number of operations to retrieve </param>
        /// <param name="accepted">Return accepted payouts </param>
        /// <param name="orderId">Find by order_id </param>
        /// <param name="state">Find by state </param>
        /// <param name="id">Find by payout id </param>
        /// <param name="acquirer">Filter by acquirer </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <returns>Payout</returns>
        Payout GETPayoutsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, int? page, int? pageSize, string sortBy, string sortDir);
        /// <summary>
        /// Get payout  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Payout id </param>
        /// <param name="operationsSize">Maximum number of operations to retrieve </param>
        /// <returns>Payout</returns>
        Payout GETPayoutsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize);
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Payout id </param>
        /// <param name="operationId">Operations id </param>
        /// <returns>Operation</returns>
        Operation GETPayoutsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId);
        /// <summary>
        /// Update payout  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Payout id </param>
        /// <param name="variables">Custom variables </param>
        /// <returns>Payout</returns>
        Payout PATCHPayoutsIdFormat (string acceptVersion, string authorization, int? id, string variables);
        /// <summary>
        /// Create payout  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="currency">Currency </param>
        /// <param name="orderId">Unique order id(must be between 4-20 characters) </param>
        /// <param name="variables">Custom variables </param>
        /// <param name="textOnStatement">Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only. </param>
        /// <returns>Payout</returns>
        Payout POSTPayoutsFormat (string acceptVersion, string authorization, string currency, string orderId, string variables, string textOnStatement);
        /// <summary>
        /// Authorize a payout  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Payout id </param>
        /// <param name="amount">Amount </param>
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
        /// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param>
        /// <param name="vatRate">Vate rate </param>
        /// <param name="cardNumber">Card number </param>
        /// <param name="cardExpiration">Expiration date (YYMM) </param>
        /// <param name="cardCvd">CVD/CVV </param>
        /// <param name="cardToken">Card token </param>
        /// <param name="cardApplePayToken">Apple Pay payment-token </param>
        /// <param name="cardMobilepayOnlineToken">MobilePay Online payment-token </param>
        /// <param name="cardIssuedTo">Card holder name </param>
        /// <param name="cardBrand">Brand to use on multi-brand card </param>
        /// <param name="cardStatus">3D-Secure status </param>
        /// <param name="cardEci">3D-Secure eci </param>
        /// <param name="cardXav">3D-Secure xav </param>
        /// <param name="cardCavv">3D-Secure cavv </param>
        /// <param name="mobileNumber">Mobile number </param>
        /// <param name="ninNumber">Customer NIN Number </param>
        /// <param name="ninCountryCode">Customer country (ISO 3166-1 Alpha-3) </param>
        /// <param name="ninGender">Customer gender </param>
        /// <param name="personFirstName">Person first name </param>
        /// <param name="personLastName">Person last name </param>
        /// <param name="personEmail">Person email </param>
        /// <param name="acquirer">If set, will force the use of this acquirer </param>
        /// <param name="customerIp">Customer IP </param>
        /// <param name="extras">Additional acquirer specific params </param>
        /// <returns>Payout</returns>
        Payout POSTPayoutsIdCreditFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, string cardApplePayToken, string cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, string acquirer, string customerIp, string extras);
        /// <summary>
        /// Create or update a payout link  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Payout id </param>
        /// <param name="amount">Amount to credit </param>
        /// <param name="agreementId">Agreement to use. Defaults to the Payment Window agreement </param>
        /// <param name="language">Language </param>
        /// <param name="continueUrl">Url that cardholder is redirected to after credit </param>
        /// <param name="cancelUrl">Url that cardholder is redirected to after cancelation </param>
        /// <param name="callbackUrl">Endpoint for async callback </param>
        /// <param name="paymentMethods">Limit payment methods </param>
        /// <param name="brandingId">Override branding. Default is merchant default branding </param>
        /// <param name="googleAnalyticsTrackingId">Send events to Google Analytics </param>
        /// <param name="googleAnalyticsClientId">Send events to Google Analytics </param>
        /// <param name="acquirer">Force usage of the given acquirer </param>
        /// <param name="framed">Allow opening in iframe </param>
        /// <param name="brandingConfig">Config for branding. Will be merged with the default config in the branding </param>
        /// <returns>PaymentLinkUrl</returns>
        PaymentLinkUrl PUTPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, string brandingConfig);
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
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Payout id </param> 
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
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
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="dateYear">Year </param> 
        /// <param name="dateMonth">Month </param> 
        /// <param name="dateDay">Day of the month </param> 
        /// <param name="dateHour">Hour of the day </param> 
        /// <param name="dateMinute">Minute of the hour </param> 
        /// <param name="timestamp">Timestamp field </param> 
        /// <param name="minTime">Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z” </param> 
        /// <param name="maxTime">Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z” </param> 
        /// <param name="operationsSize">Maximum number of operations to retrieve </param> 
        /// <param name="accepted">Return accepted payouts </param> 
        /// <param name="orderId">Find by order_id </param> 
        /// <param name="state">Find by state </param> 
        /// <param name="id">Find by payout id </param> 
        /// <param name="acquirer">Filter by acquirer </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <returns>Payout</returns>            
        public Payout GETPayoutsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, int? page, int? pageSize, string sortBy, string sortDir)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Payout) ApiClient.Deserialize(response.Content, typeof(Payout), response.Headers);
        }
    
        /// <summary>
        /// Get payout  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Payout id </param> 
        /// <param name="operationsSize">Maximum number of operations to retrieve </param> 
        /// <returns>Payout</returns>            
        public Payout GETPayoutsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Payout) ApiClient.Deserialize(response.Content, typeof(Payout), response.Headers);
        }
    
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Payout id </param> 
        /// <param name="operationId">Operations id </param> 
        /// <returns>Operation</returns>            
        public Operation GETPayoutsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsIdOperationsOperationIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPayoutsIdOperationsOperationIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Operation) ApiClient.Deserialize(response.Content, typeof(Operation), response.Headers);
        }
    
        /// <summary>
        /// Update payout  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Payout id </param> 
        /// <param name="variables">Custom variables </param> 
        /// <returns>Payout</returns>            
        public Payout PATCHPayoutsIdFormat (string acceptVersion, string authorization, int? id, string variables)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
            if (variables != null) formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHPayoutsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHPayoutsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Payout) ApiClient.Deserialize(response.Content, typeof(Payout), response.Headers);
        }
    
        /// <summary>
        /// Create payout  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="currency">Currency </param> 
        /// <param name="orderId">Unique order id(must be between 4-20 characters) </param> 
        /// <param name="variables">Custom variables </param> 
        /// <param name="textOnStatement">Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only. </param> 
        /// <returns>Payout</returns>            
        public Payout POSTPayoutsFormat (string acceptVersion, string authorization, string currency, string orderId, string variables, string textOnStatement)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
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
    
            return (Payout) ApiClient.Deserialize(response.Content, typeof(Payout), response.Headers);
        }
    
        /// <summary>
        /// Authorize a payout  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Payout id </param> 
        /// <param name="amount">Amount </param> 
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
        /// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param> 
        /// <param name="vatRate">Vate rate </param> 
        /// <param name="cardNumber">Card number </param> 
        /// <param name="cardExpiration">Expiration date (YYMM) </param> 
        /// <param name="cardCvd">CVD/CVV </param> 
        /// <param name="cardToken">Card token </param> 
        /// <param name="cardApplePayToken">Apple Pay payment-token </param> 
        /// <param name="cardMobilepayOnlineToken">MobilePay Online payment-token </param> 
        /// <param name="cardIssuedTo">Card holder name </param> 
        /// <param name="cardBrand">Brand to use on multi-brand card </param> 
        /// <param name="cardStatus">3D-Secure status </param> 
        /// <param name="cardEci">3D-Secure eci </param> 
        /// <param name="cardXav">3D-Secure xav </param> 
        /// <param name="cardCavv">3D-Secure cavv </param> 
        /// <param name="mobileNumber">Mobile number </param> 
        /// <param name="ninNumber">Customer NIN Number </param> 
        /// <param name="ninCountryCode">Customer country (ISO 3166-1 Alpha-3) </param> 
        /// <param name="ninGender">Customer gender </param> 
        /// <param name="personFirstName">Person first name </param> 
        /// <param name="personLastName">Person last name </param> 
        /// <param name="personEmail">Person email </param> 
        /// <param name="acquirer">If set, will force the use of this acquirer </param> 
        /// <param name="customerIp">Customer IP </param> 
        /// <param name="extras">Additional acquirer specific params </param> 
        /// <returns>Payout</returns>            
        public Payout POSTPayoutsIdCreditFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, string cardApplePayToken, string cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, string acquirer, string customerIp, string extras)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
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
    
            return (Payout) ApiClient.Deserialize(response.Content, typeof(Payout), response.Headers);
        }
    
        /// <summary>
        /// Create or update a payout link  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Payout id </param> 
        /// <param name="amount">Amount to credit </param> 
        /// <param name="agreementId">Agreement to use. Defaults to the Payment Window agreement </param> 
        /// <param name="language">Language </param> 
        /// <param name="continueUrl">Url that cardholder is redirected to after credit </param> 
        /// <param name="cancelUrl">Url that cardholder is redirected to after cancelation </param> 
        /// <param name="callbackUrl">Endpoint for async callback </param> 
        /// <param name="paymentMethods">Limit payment methods </param> 
        /// <param name="brandingId">Override branding. Default is merchant default branding </param> 
        /// <param name="googleAnalyticsTrackingId">Send events to Google Analytics </param> 
        /// <param name="googleAnalyticsClientId">Send events to Google Analytics </param> 
        /// <param name="acquirer">Force usage of the given acquirer </param> 
        /// <param name="framed">Allow opening in iframe </param> 
        /// <param name="brandingConfig">Config for branding. Will be merged with the default config in the branding </param> 
        /// <returns>PaymentLinkUrl</returns>            
        public PaymentLinkUrl PUTPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, string brandingConfig)
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
 if (authorization != null) headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
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
    
            return (PaymentLinkUrl) ApiClient.Deserialize(response.Content, typeof(PaymentLinkUrl), response.Headers);
        }
    
    }
}
