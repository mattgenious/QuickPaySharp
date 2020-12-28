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
    public interface ISubscriptionsApi
    {
        /// <summary>
        /// Delete payment link  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Transaction id </param>
        /// <returns></returns>
        void DELETESubscriptionsIdLinkFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get subscriptions  
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
        /// <param name="accepted">Return accepted subscriptions </param>
        /// <param name="orderId">Find by order_id </param>
        /// <param name="state">Filter by state </param>
        /// <param name="id">Find by subscription id </param>
        /// <param name="acquirer">Filter by acquirer </param>
        /// <param name="groupId">Filter by subscription group </param>
        /// <param name="fraudSuspected">Filter by suspected fraud </param>
        /// <param name="expired">Filter by expiration </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <param name="pageKey"> </param>
        /// <returns>Subscription</returns>
        Subscription GETSubscriptionsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, int? groupId, bool? fraudSuspected, bool? expired, int? page, int? pageSize, string sortBy, string sortDir, string pageKey);
        /// <summary>
        /// Get subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="operationsSize">Maximum number of operations to retrieve </param>
        /// <returns>Subscription</returns>
        Subscription GETSubscriptionsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize);
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="operationId">Operations id </param>
        /// <returns>Operation</returns>
        Operation GETSubscriptionsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId);
        /// <summary>
        /// Get all subscription payments  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="accepted">Return accepted payments </param>
        /// <param name="dateYear">Year </param>
        /// <param name="dateMonth">Month </param>
        /// <param name="dateDay">Day of the month </param>
        /// <param name="dateHour">Hour of the day </param>
        /// <param name="dateMinute">Minute of the hour </param>
        /// <param name="page">Pagination page. Default is 1 </param>
        /// <param name="pageSize">Items per page. Default is 20 </param>
        /// <param name="sortBy">Property to sort by </param>
        /// <param name="sortDir">Sort direction </param>
        /// <returns>Payment</returns>
        Payment GETSubscriptionsIdPaymentsFormat (string acceptVersion, string authorization, int? id, bool? accepted, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, int? page, int? pageSize, string sortBy, string sortDir);
        /// <summary>
        /// Update subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="deadlineAt">Subscription must be authorized before this time </param>
        /// <param name="groupIds">Ids of subscription groups </param>
        /// <param name="description">Subscription description </param>
        /// <param name="invoiceAddressName">Name </param>
        /// <param name="invoiceAddressAtt">Att </param>
        /// <param name="invoiceAddressCompanyName">Company name </param>
        /// <param name="invoiceAddressStreet">Street </param>
        /// <param name="invoiceAddressHouseNumber">House number </param>
        /// <param name="invoiceAddressHouseExtension">House extension </param>
        /// <param name="invoiceAddressCity">City </param>
        /// <param name="invoiceAddressZipCode">Zip code </param>
        /// <param name="invoiceAddressRegion">Region </param>
        /// <param name="invoiceAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param>
        /// <param name="invoiceAddressVatNo">VAT registration number </param>
        /// <param name="invoiceAddressPhoneNumber">Phone number </param>
        /// <param name="invoiceAddressMobileNumber">Mobile number </param>
        /// <param name="invoiceAddressEmail">Email address </param>
        /// <param name="shippingAddressName">Name </param>
        /// <param name="shippingAddressAtt">Att </param>
        /// <param name="shippingAddressCompanyName">Company name </param>
        /// <param name="shippingAddressStreet">Street </param>
        /// <param name="shippingAddressHouseNumber">House number </param>
        /// <param name="shippingAddressHouseExtension">House extension </param>
        /// <param name="shippingAddressCity">City </param>
        /// <param name="shippingAddressZipCode">Zip code </param>
        /// <param name="shippingAddressRegion">Region </param>
        /// <param name="shippingAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param>
        /// <param name="shippingAddressVatNo">VAT registration number </param>
        /// <param name="shippingAddressPhoneNumber">Phone number </param>
        /// <param name="shippingAddressMobileNumber">Mobile number </param>
        /// <param name="shippingAddressEmail">Email address </param>
        /// <param name="variables">Custom variables </param>
        /// <returns>Subscription</returns>
        Subscription PATCHSubscriptionsIdFormat (string acceptVersion, string authorization, int? id, DateTime? deadlineAt, string groupIds, string description, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName, string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension, string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion, string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber, string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName, string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet, string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity, string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode, string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber, string shippingAddressEmail, string variables);
        /// <summary>
        /// Update operation  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="operationId">Operations id </param>
        /// <param name="pending">Aborts the operation. Only possible on cancel operations (false is the only allowed value) </param>
        /// <returns>Operation</returns>
        Operation PATCHSubscriptionsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId, bool? pending);
        /// <summary>
        /// Create subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="orderId">Unique order id(must be between 4-20 characters) </param>
        /// <param name="currency">Currency </param>
        /// <param name="description">Subscription description </param>
        /// <param name="invoiceAddressName">Name </param>
        /// <param name="invoiceAddressAtt">Att </param>
        /// <param name="invoiceAddressCompanyName">Company name </param>
        /// <param name="invoiceAddressStreet">Street </param>
        /// <param name="invoiceAddressHouseNumber">House number </param>
        /// <param name="invoiceAddressHouseExtension">House extension </param>
        /// <param name="invoiceAddressCity">City </param>
        /// <param name="invoiceAddressZipCode">Zip code </param>
        /// <param name="invoiceAddressRegion">Region </param>
        /// <param name="invoiceAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param>
        /// <param name="invoiceAddressVatNo">VAT registration number </param>
        /// <param name="invoiceAddressPhoneNumber">Phone number </param>
        /// <param name="invoiceAddressMobileNumber">Mobile number </param>
        /// <param name="invoiceAddressEmail">Email address </param>
        /// <param name="shippingAddressName">Name </param>
        /// <param name="shippingAddressAtt">Att </param>
        /// <param name="shippingAddressCompanyName">Company name </param>
        /// <param name="shippingAddressStreet">Street </param>
        /// <param name="shippingAddressHouseNumber">House number </param>
        /// <param name="shippingAddressHouseExtension">House extension </param>
        /// <param name="shippingAddressCity">City </param>
        /// <param name="shippingAddressZipCode">Zip code </param>
        /// <param name="shippingAddressRegion">Region </param>
        /// <param name="shippingAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param>
        /// <param name="shippingAddressVatNo">VAT registration number </param>
        /// <param name="shippingAddressPhoneNumber">Phone number </param>
        /// <param name="shippingAddressMobileNumber">Mobile number </param>
        /// <param name="shippingAddressEmail">Email address </param>
        /// <param name="variables">Custom variables </param>
        /// <param name="brandingId">Used branding id </param>
        /// <param name="groupIds">Ids of subscription groups </param>
        /// <param name="textOnStatement">Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only. </param>
        /// <param name="shopsystemName">Shop system module name </param>
        /// <param name="shopsystemVersion">Shop system module version </param>
        /// <returns>Subscription</returns>
        Subscription POSTSubscriptionsFormat (string acceptVersion, string authorization, string orderId, string currency, string description, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName, string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension, string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion, string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber, string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName, string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet, string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity, string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode, string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber, string shippingAddressEmail, string variables, int? brandingId, string groupIds, string textOnStatement, string shopsystemName, string shopsystemVersion);
        /// <summary>
        /// Authorize a subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
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
        /// <returns>Subscription</returns>
        Subscription POSTSubscriptionsIdAuthorizeFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, string cardApplePayToken, string cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, string acquirer, string customerIp, string extras);
        /// <summary>
        /// Cancel subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
        /// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param>
        /// <returns>Subscription</returns>
        Subscription POSTSubscriptionsIdCancelFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, bool? synchronized);
        /// <summary>
        /// Create fraud confirmation report  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
        /// <param name="description"> </param>
        /// <returns>FraudReport</returns>
        FraudReport POSTSubscriptionsIdFraudReportFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, string description);
        /// <summary>
        /// Create subscription recurring payment  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="amount">Amount </param>
        /// <param name="orderId">Unique order id(must be between 4-20 characters) </param>
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
        /// <param name="synchronized">DEPRECATED: it will be removed in v11. Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param>
        /// <param name="autoCapture">When true, payment is captured after authorization. Default is false </param>
        /// <param name="autofee">When true, fee is calculated and added to the given amount. Default is merchant autofee </param>
        /// <param name="zeroAuth">(Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false </param>
        /// <param name="textOnStatement">Text to be displayed on cardholder’s statement. This overrides text_on_statement on authorize. Max 22 ASCII chars. Currently supported by Clearhaus only. </param>
        /// <returns>Payment</returns>
        Payment POSTSubscriptionsIdRecurringFormat (string acceptVersion, string authorization, int? id, int? amount, string orderId, string quickPayCallbackUrl, bool? synchronized, bool? autoCapture, bool? autofee, bool? zeroAuth, string textOnStatement);
        /// <summary>
        /// Create subscription session  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Subscription id </param>
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
        /// <param name="acquirer">If set, will force the use of this acquirer </param>
        /// <param name="autofee">When true, fee is calculated and added to the given amount. Default is merchant autofee </param>
        /// <param name="customerIp">Customer IP </param>
        /// <param name="extras">Additional acquirer specific params </param>
        /// <returns>Subscription</returns>
        Subscription POSTSubscriptionsIdSessionFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, string acquirer, bool? autofee, string customerIp, string extras);
        /// <summary>
        /// Create or update a payment link  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param>
        /// <param name="authorization">Use Basic Auth to authorize to the API </param>
        /// <param name="id">Transaction id </param>
        /// <param name="amount">Amount to authorize </param>
        /// <param name="agreementId">Agreement to use. Defaults to the Payment Window agreement </param>
        /// <param name="language">Language </param>
        /// <param name="continueUrl">Url that cardholder is redirected to after authorize </param>
        /// <param name="cancelUrl">Url that cardholder is redirected to after cancelation </param>
        /// <param name="callbackUrl">Endpoint for async callback </param>
        /// <param name="paymentMethods">Limit payment methods </param>
        /// <param name="autoFee">Add acquirer fee to amount. Default is merchant autofee </param>
        /// <param name="brandingId">Override branding. Default is merchant default branding </param>
        /// <param name="googleAnalyticsTrackingId">Send events to Google Analytics </param>
        /// <param name="googleAnalyticsClientId">Send events to Google Analytics </param>
        /// <param name="acquirer">Force usage of the given acquirer </param>
        /// <param name="deadline">Set a deadline in seconds for the cardholder to complete </param>
        /// <param name="framed">Allow opening in iframe </param>
        /// <param name="brandingConfig">Config for branding. Will be merged with the default config in the branding </param>
        /// <param name="customerEmail">Required for PayPal. Email of customer. </param>
        /// <param name="invoiceAddressSelection">Get customer invoice address via acquirer (Currently MobilePay and PayPal only) </param>
        /// <param name="shippingAddressSelection">Get customer shipping address via acquirer (Currently MobilePay and PayPal only) </param>
        /// <returns>PaymentLinkUrl</returns>
        PaymentLinkUrl PUTSubscriptionsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, bool? autoFee, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, int? deadline, bool? framed, string brandingConfig, string customerEmail, bool? invoiceAddressSelection, bool? shippingAddressSelection);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionsApi : ISubscriptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionsApi(String basePath)
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
        /// Delete payment link  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Transaction id </param> 
        /// <returns></returns>            
        public void DELETESubscriptionsIdLinkFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETESubscriptionsIdLinkFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETESubscriptionsIdLinkFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETESubscriptionsIdLinkFormat");
            
    
            var path = "/subscriptions/{id}/link";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETESubscriptionsIdLinkFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETESubscriptionsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get subscriptions  
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
        /// <param name="accepted">Return accepted subscriptions </param> 
        /// <param name="orderId">Find by order_id </param> 
        /// <param name="state">Filter by state </param> 
        /// <param name="id">Find by subscription id </param> 
        /// <param name="acquirer">Filter by acquirer </param> 
        /// <param name="groupId">Filter by subscription group </param> 
        /// <param name="fraudSuspected">Filter by suspected fraud </param> 
        /// <param name="expired">Filter by expiration </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <param name="pageKey"> </param> 
        /// <returns>Subscription</returns>            
        public Subscription GETSubscriptionsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, int? groupId, bool? fraudSuspected, bool? expired, int? page, int? pageSize, string sortBy, string sortDir, string pageKey)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETSubscriptionsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETSubscriptionsFormat");
            
    
            var path = "/subscriptions";
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
 if (groupId != null) queryParams.Add("group_id", ApiClient.ParameterToString(groupId)); // query parameter
 if (fraudSuspected != null) queryParams.Add("fraud_suspected", ApiClient.ParameterToString(fraudSuspected)); // query parameter
 if (expired != null) queryParams.Add("expired", ApiClient.ParameterToString(expired)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Get subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="operationsSize">Maximum number of operations to retrieve </param> 
        /// <returns>Subscription</returns>            
        public Subscription GETSubscriptionsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETSubscriptionsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETSubscriptionsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETSubscriptionsIdFormat");
            
    
            var path = "/subscriptions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="operationId">Operations id </param> 
        /// <returns>Operation</returns>            
        public Operation GETSubscriptionsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETSubscriptionsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETSubscriptionsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETSubscriptionsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'operationId' is set
            if (operationId == null) throw new ApiException(400, "Missing required parameter 'operationId' when calling GETSubscriptionsIdOperationsOperationIdFormat");
            
    
            var path = "/subscriptions/{id}/operations/{operation_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionsIdOperationsOperationIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionsIdOperationsOperationIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Operation) ApiClient.Deserialize(response.Content, typeof(Operation), response.Headers);
        }
    
        /// <summary>
        /// Get all subscription payments  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="accepted">Return accepted payments </param> 
        /// <param name="dateYear">Year </param> 
        /// <param name="dateMonth">Month </param> 
        /// <param name="dateDay">Day of the month </param> 
        /// <param name="dateHour">Hour of the day </param> 
        /// <param name="dateMinute">Minute of the hour </param> 
        /// <param name="page">Pagination page. Default is 1 </param> 
        /// <param name="pageSize">Items per page. Default is 20 </param> 
        /// <param name="sortBy">Property to sort by </param> 
        /// <param name="sortDir">Sort direction </param> 
        /// <returns>Payment</returns>            
        public Payment GETSubscriptionsIdPaymentsFormat (string acceptVersion, string authorization, int? id, bool? accepted, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, int? page, int? pageSize, string sortBy, string sortDir)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETSubscriptionsIdPaymentsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETSubscriptionsIdPaymentsFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETSubscriptionsIdPaymentsFormat");
            
    
            var path = "/subscriptions/{id}/payments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accepted != null) queryParams.Add("accepted", ApiClient.ParameterToString(accepted)); // query parameter
 if (dateYear != null) queryParams.Add("date[year]", ApiClient.ParameterToString(dateYear)); // query parameter
 if (dateMonth != null) queryParams.Add("date[month]", ApiClient.ParameterToString(dateMonth)); // query parameter
 if (dateDay != null) queryParams.Add("date[day]", ApiClient.ParameterToString(dateDay)); // query parameter
 if (dateHour != null) queryParams.Add("date[hour]", ApiClient.ParameterToString(dateHour)); // query parameter
 if (dateMinute != null) queryParams.Add("date[minute]", ApiClient.ParameterToString(dateMinute)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionsIdPaymentsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETSubscriptionsIdPaymentsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Payment) ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
        }
    
        /// <summary>
        /// Update subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="deadlineAt">Subscription must be authorized before this time </param> 
        /// <param name="groupIds">Ids of subscription groups </param> 
        /// <param name="description">Subscription description </param> 
        /// <param name="invoiceAddressName">Name </param> 
        /// <param name="invoiceAddressAtt">Att </param> 
        /// <param name="invoiceAddressCompanyName">Company name </param> 
        /// <param name="invoiceAddressStreet">Street </param> 
        /// <param name="invoiceAddressHouseNumber">House number </param> 
        /// <param name="invoiceAddressHouseExtension">House extension </param> 
        /// <param name="invoiceAddressCity">City </param> 
        /// <param name="invoiceAddressZipCode">Zip code </param> 
        /// <param name="invoiceAddressRegion">Region </param> 
        /// <param name="invoiceAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param> 
        /// <param name="invoiceAddressVatNo">VAT registration number </param> 
        /// <param name="invoiceAddressPhoneNumber">Phone number </param> 
        /// <param name="invoiceAddressMobileNumber">Mobile number </param> 
        /// <param name="invoiceAddressEmail">Email address </param> 
        /// <param name="shippingAddressName">Name </param> 
        /// <param name="shippingAddressAtt">Att </param> 
        /// <param name="shippingAddressCompanyName">Company name </param> 
        /// <param name="shippingAddressStreet">Street </param> 
        /// <param name="shippingAddressHouseNumber">House number </param> 
        /// <param name="shippingAddressHouseExtension">House extension </param> 
        /// <param name="shippingAddressCity">City </param> 
        /// <param name="shippingAddressZipCode">Zip code </param> 
        /// <param name="shippingAddressRegion">Region </param> 
        /// <param name="shippingAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param> 
        /// <param name="shippingAddressVatNo">VAT registration number </param> 
        /// <param name="shippingAddressPhoneNumber">Phone number </param> 
        /// <param name="shippingAddressMobileNumber">Mobile number </param> 
        /// <param name="shippingAddressEmail">Email address </param> 
        /// <param name="variables">Custom variables </param> 
        /// <returns>Subscription</returns>            
        public Subscription PATCHSubscriptionsIdFormat (string acceptVersion, string authorization, int? id, DateTime? deadlineAt, string groupIds, string description, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName, string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension, string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion, string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber, string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName, string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet, string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity, string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode, string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber, string shippingAddressEmail, string variables)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHSubscriptionsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHSubscriptionsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHSubscriptionsIdFormat");
            
    
            var path = "/subscriptions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (deadlineAt != null) formParams.Add("deadline_at", ApiClient.ParameterToString(deadlineAt)); // form parameter
if (groupIds != null) formParams.Add("group_ids", ApiClient.ParameterToString(groupIds)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
if (invoiceAddressName != null) formParams.Add("invoice_address[name]", ApiClient.ParameterToString(invoiceAddressName)); // form parameter
if (invoiceAddressAtt != null) formParams.Add("invoice_address[att]", ApiClient.ParameterToString(invoiceAddressAtt)); // form parameter
if (invoiceAddressCompanyName != null) formParams.Add("invoice_address[company_name]", ApiClient.ParameterToString(invoiceAddressCompanyName)); // form parameter
if (invoiceAddressStreet != null) formParams.Add("invoice_address[street]", ApiClient.ParameterToString(invoiceAddressStreet)); // form parameter
if (invoiceAddressHouseNumber != null) formParams.Add("invoice_address[house_number]", ApiClient.ParameterToString(invoiceAddressHouseNumber)); // form parameter
if (invoiceAddressHouseExtension != null) formParams.Add("invoice_address[house_extension]", ApiClient.ParameterToString(invoiceAddressHouseExtension)); // form parameter
if (invoiceAddressCity != null) formParams.Add("invoice_address[city]", ApiClient.ParameterToString(invoiceAddressCity)); // form parameter
if (invoiceAddressZipCode != null) formParams.Add("invoice_address[zip_code]", ApiClient.ParameterToString(invoiceAddressZipCode)); // form parameter
if (invoiceAddressRegion != null) formParams.Add("invoice_address[region]", ApiClient.ParameterToString(invoiceAddressRegion)); // form parameter
if (invoiceAddressCountryCode != null) formParams.Add("invoice_address[country_code]", ApiClient.ParameterToString(invoiceAddressCountryCode)); // form parameter
if (invoiceAddressVatNo != null) formParams.Add("invoice_address[vat_no]", ApiClient.ParameterToString(invoiceAddressVatNo)); // form parameter
if (invoiceAddressPhoneNumber != null) formParams.Add("invoice_address[phone_number]", ApiClient.ParameterToString(invoiceAddressPhoneNumber)); // form parameter
if (invoiceAddressMobileNumber != null) formParams.Add("invoice_address[mobile_number]", ApiClient.ParameterToString(invoiceAddressMobileNumber)); // form parameter
if (invoiceAddressEmail != null) formParams.Add("invoice_address[email]", ApiClient.ParameterToString(invoiceAddressEmail)); // form parameter
if (shippingAddressName != null) formParams.Add("shipping_address[name]", ApiClient.ParameterToString(shippingAddressName)); // form parameter
if (shippingAddressAtt != null) formParams.Add("shipping_address[att]", ApiClient.ParameterToString(shippingAddressAtt)); // form parameter
if (shippingAddressCompanyName != null) formParams.Add("shipping_address[company_name]", ApiClient.ParameterToString(shippingAddressCompanyName)); // form parameter
if (shippingAddressStreet != null) formParams.Add("shipping_address[street]", ApiClient.ParameterToString(shippingAddressStreet)); // form parameter
if (shippingAddressHouseNumber != null) formParams.Add("shipping_address[house_number]", ApiClient.ParameterToString(shippingAddressHouseNumber)); // form parameter
if (shippingAddressHouseExtension != null) formParams.Add("shipping_address[house_extension]", ApiClient.ParameterToString(shippingAddressHouseExtension)); // form parameter
if (shippingAddressCity != null) formParams.Add("shipping_address[city]", ApiClient.ParameterToString(shippingAddressCity)); // form parameter
if (shippingAddressZipCode != null) formParams.Add("shipping_address[zip_code]", ApiClient.ParameterToString(shippingAddressZipCode)); // form parameter
if (shippingAddressRegion != null) formParams.Add("shipping_address[region]", ApiClient.ParameterToString(shippingAddressRegion)); // form parameter
if (shippingAddressCountryCode != null) formParams.Add("shipping_address[country_code]", ApiClient.ParameterToString(shippingAddressCountryCode)); // form parameter
if (shippingAddressVatNo != null) formParams.Add("shipping_address[vat_no]", ApiClient.ParameterToString(shippingAddressVatNo)); // form parameter
if (shippingAddressPhoneNumber != null) formParams.Add("shipping_address[phone_number]", ApiClient.ParameterToString(shippingAddressPhoneNumber)); // form parameter
if (shippingAddressMobileNumber != null) formParams.Add("shipping_address[mobile_number]", ApiClient.ParameterToString(shippingAddressMobileNumber)); // form parameter
if (shippingAddressEmail != null) formParams.Add("shipping_address[email]", ApiClient.ParameterToString(shippingAddressEmail)); // form parameter
if (variables != null) formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHSubscriptionsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHSubscriptionsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Update operation  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="operationId">Operations id </param> 
        /// <param name="pending">Aborts the operation. Only possible on cancel operations (false is the only allowed value) </param> 
        /// <returns>Operation</returns>            
        public Operation PATCHSubscriptionsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId, bool? pending)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHSubscriptionsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHSubscriptionsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHSubscriptionsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'operationId' is set
            if (operationId == null) throw new ApiException(400, "Missing required parameter 'operationId' when calling PATCHSubscriptionsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'pending' is set
            if (pending == null) throw new ApiException(400, "Missing required parameter 'pending' when calling PATCHSubscriptionsIdOperationsOperationIdFormat");
            
    
            var path = "/subscriptions/{id}/operations/{operation_id}";
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
            if (pending != null) formParams.Add("pending", ApiClient.ParameterToString(pending)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHSubscriptionsIdOperationsOperationIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHSubscriptionsIdOperationsOperationIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Operation) ApiClient.Deserialize(response.Content, typeof(Operation), response.Headers);
        }
    
        /// <summary>
        /// Create subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="orderId">Unique order id(must be between 4-20 characters) </param> 
        /// <param name="currency">Currency </param> 
        /// <param name="description">Subscription description </param> 
        /// <param name="invoiceAddressName">Name </param> 
        /// <param name="invoiceAddressAtt">Att </param> 
        /// <param name="invoiceAddressCompanyName">Company name </param> 
        /// <param name="invoiceAddressStreet">Street </param> 
        /// <param name="invoiceAddressHouseNumber">House number </param> 
        /// <param name="invoiceAddressHouseExtension">House extension </param> 
        /// <param name="invoiceAddressCity">City </param> 
        /// <param name="invoiceAddressZipCode">Zip code </param> 
        /// <param name="invoiceAddressRegion">Region </param> 
        /// <param name="invoiceAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param> 
        /// <param name="invoiceAddressVatNo">VAT registration number </param> 
        /// <param name="invoiceAddressPhoneNumber">Phone number </param> 
        /// <param name="invoiceAddressMobileNumber">Mobile number </param> 
        /// <param name="invoiceAddressEmail">Email address </param> 
        /// <param name="shippingAddressName">Name </param> 
        /// <param name="shippingAddressAtt">Att </param> 
        /// <param name="shippingAddressCompanyName">Company name </param> 
        /// <param name="shippingAddressStreet">Street </param> 
        /// <param name="shippingAddressHouseNumber">House number </param> 
        /// <param name="shippingAddressHouseExtension">House extension </param> 
        /// <param name="shippingAddressCity">City </param> 
        /// <param name="shippingAddressZipCode">Zip code </param> 
        /// <param name="shippingAddressRegion">Region </param> 
        /// <param name="shippingAddressCountryCode">Three letter country code according to ISO 3166-1 Alpha-3 </param> 
        /// <param name="shippingAddressVatNo">VAT registration number </param> 
        /// <param name="shippingAddressPhoneNumber">Phone number </param> 
        /// <param name="shippingAddressMobileNumber">Mobile number </param> 
        /// <param name="shippingAddressEmail">Email address </param> 
        /// <param name="variables">Custom variables </param> 
        /// <param name="brandingId">Used branding id </param> 
        /// <param name="groupIds">Ids of subscription groups </param> 
        /// <param name="textOnStatement">Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only. </param> 
        /// <param name="shopsystemName">Shop system module name </param> 
        /// <param name="shopsystemVersion">Shop system module version </param> 
        /// <returns>Subscription</returns>            
        public Subscription POSTSubscriptionsFormat (string acceptVersion, string authorization, string orderId, string currency, string description, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName, string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension, string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion, string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber, string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName, string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet, string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity, string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode, string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber, string shippingAddressEmail, string variables, int? brandingId, string groupIds, string textOnStatement, string shopsystemName, string shopsystemVersion)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTSubscriptionsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTSubscriptionsFormat");
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling POSTSubscriptionsFormat");
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling POSTSubscriptionsFormat");
            
            // verify the required parameter 'description' is set
            if (description == null) throw new ApiException(400, "Missing required parameter 'description' when calling POSTSubscriptionsFormat");
            
    
            var path = "/subscriptions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptVersion != null) headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
 if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
            if (orderId != null) formParams.Add("order_id", ApiClient.ParameterToString(orderId)); // form parameter
if (invoiceAddressName != null) formParams.Add("invoice_address[name]", ApiClient.ParameterToString(invoiceAddressName)); // form parameter
if (invoiceAddressAtt != null) formParams.Add("invoice_address[att]", ApiClient.ParameterToString(invoiceAddressAtt)); // form parameter
if (invoiceAddressCompanyName != null) formParams.Add("invoice_address[company_name]", ApiClient.ParameterToString(invoiceAddressCompanyName)); // form parameter
if (invoiceAddressStreet != null) formParams.Add("invoice_address[street]", ApiClient.ParameterToString(invoiceAddressStreet)); // form parameter
if (invoiceAddressHouseNumber != null) formParams.Add("invoice_address[house_number]", ApiClient.ParameterToString(invoiceAddressHouseNumber)); // form parameter
if (invoiceAddressHouseExtension != null) formParams.Add("invoice_address[house_extension]", ApiClient.ParameterToString(invoiceAddressHouseExtension)); // form parameter
if (invoiceAddressCity != null) formParams.Add("invoice_address[city]", ApiClient.ParameterToString(invoiceAddressCity)); // form parameter
if (invoiceAddressZipCode != null) formParams.Add("invoice_address[zip_code]", ApiClient.ParameterToString(invoiceAddressZipCode)); // form parameter
if (invoiceAddressRegion != null) formParams.Add("invoice_address[region]", ApiClient.ParameterToString(invoiceAddressRegion)); // form parameter
if (invoiceAddressCountryCode != null) formParams.Add("invoice_address[country_code]", ApiClient.ParameterToString(invoiceAddressCountryCode)); // form parameter
if (invoiceAddressVatNo != null) formParams.Add("invoice_address[vat_no]", ApiClient.ParameterToString(invoiceAddressVatNo)); // form parameter
if (invoiceAddressPhoneNumber != null) formParams.Add("invoice_address[phone_number]", ApiClient.ParameterToString(invoiceAddressPhoneNumber)); // form parameter
if (invoiceAddressMobileNumber != null) formParams.Add("invoice_address[mobile_number]", ApiClient.ParameterToString(invoiceAddressMobileNumber)); // form parameter
if (invoiceAddressEmail != null) formParams.Add("invoice_address[email]", ApiClient.ParameterToString(invoiceAddressEmail)); // form parameter
if (shippingAddressName != null) formParams.Add("shipping_address[name]", ApiClient.ParameterToString(shippingAddressName)); // form parameter
if (shippingAddressAtt != null) formParams.Add("shipping_address[att]", ApiClient.ParameterToString(shippingAddressAtt)); // form parameter
if (shippingAddressCompanyName != null) formParams.Add("shipping_address[company_name]", ApiClient.ParameterToString(shippingAddressCompanyName)); // form parameter
if (shippingAddressStreet != null) formParams.Add("shipping_address[street]", ApiClient.ParameterToString(shippingAddressStreet)); // form parameter
if (shippingAddressHouseNumber != null) formParams.Add("shipping_address[house_number]", ApiClient.ParameterToString(shippingAddressHouseNumber)); // form parameter
if (shippingAddressHouseExtension != null) formParams.Add("shipping_address[house_extension]", ApiClient.ParameterToString(shippingAddressHouseExtension)); // form parameter
if (shippingAddressCity != null) formParams.Add("shipping_address[city]", ApiClient.ParameterToString(shippingAddressCity)); // form parameter
if (shippingAddressZipCode != null) formParams.Add("shipping_address[zip_code]", ApiClient.ParameterToString(shippingAddressZipCode)); // form parameter
if (shippingAddressRegion != null) formParams.Add("shipping_address[region]", ApiClient.ParameterToString(shippingAddressRegion)); // form parameter
if (shippingAddressCountryCode != null) formParams.Add("shipping_address[country_code]", ApiClient.ParameterToString(shippingAddressCountryCode)); // form parameter
if (shippingAddressVatNo != null) formParams.Add("shipping_address[vat_no]", ApiClient.ParameterToString(shippingAddressVatNo)); // form parameter
if (shippingAddressPhoneNumber != null) formParams.Add("shipping_address[phone_number]", ApiClient.ParameterToString(shippingAddressPhoneNumber)); // form parameter
if (shippingAddressMobileNumber != null) formParams.Add("shipping_address[mobile_number]", ApiClient.ParameterToString(shippingAddressMobileNumber)); // form parameter
if (shippingAddressEmail != null) formParams.Add("shipping_address[email]", ApiClient.ParameterToString(shippingAddressEmail)); // form parameter
if (variables != null) formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter
if (currency != null) formParams.Add("currency", ApiClient.ParameterToString(currency)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
if (brandingId != null) formParams.Add("branding_id", ApiClient.ParameterToString(brandingId)); // form parameter
if (groupIds != null) formParams.Add("group_ids", ApiClient.ParameterToString(groupIds)); // form parameter
if (textOnStatement != null) formParams.Add("text_on_statement", ApiClient.ParameterToString(textOnStatement)); // form parameter
if (shopsystemName != null) formParams.Add("shopsystem[name]", ApiClient.ParameterToString(shopsystemName)); // form parameter
if (shopsystemVersion != null) formParams.Add("shopsystem[version]", ApiClient.ParameterToString(shopsystemVersion)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Authorize a subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
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
        /// <returns>Subscription</returns>            
        public Subscription POSTSubscriptionsIdAuthorizeFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, string cardApplePayToken, string cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, string acquirer, string customerIp, string extras)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTSubscriptionsIdAuthorizeFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTSubscriptionsIdAuthorizeFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTSubscriptionsIdAuthorizeFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTSubscriptionsIdAuthorizeFormat");
            
    
            var path = "/subscriptions/{id}/authorize";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdAuthorizeFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdAuthorizeFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Cancel subscription  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
        /// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param> 
        /// <returns>Subscription</returns>            
        public Subscription POSTSubscriptionsIdCancelFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, bool? synchronized)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTSubscriptionsIdCancelFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTSubscriptionsIdCancelFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTSubscriptionsIdCancelFormat");
            
    
            var path = "/subscriptions/{id}/cancel";
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
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdCancelFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdCancelFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Create fraud confirmation report  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
        /// <param name="description"> </param> 
        /// <returns>FraudReport</returns>            
        public FraudReport POSTSubscriptionsIdFraudReportFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, string description)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTSubscriptionsIdFraudReportFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTSubscriptionsIdFraudReportFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTSubscriptionsIdFraudReportFormat");
            
    
            var path = "/subscriptions/{id}/fraud-report";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdFraudReportFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdFraudReportFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FraudReport) ApiClient.Deserialize(response.Content, typeof(FraudReport), response.Headers);
        }
    
        /// <summary>
        /// Create subscription recurring payment  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="amount">Amount </param> 
        /// <param name="orderId">Unique order id(must be between 4-20 characters) </param> 
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
        /// <param name="synchronized">DEPRECATED: it will be removed in v11. Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param> 
        /// <param name="autoCapture">When true, payment is captured after authorization. Default is false </param> 
        /// <param name="autofee">When true, fee is calculated and added to the given amount. Default is merchant autofee </param> 
        /// <param name="zeroAuth">(Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false </param> 
        /// <param name="textOnStatement">Text to be displayed on cardholder’s statement. This overrides text_on_statement on authorize. Max 22 ASCII chars. Currently supported by Clearhaus only. </param> 
        /// <returns>Payment</returns>            
        public Payment POSTSubscriptionsIdRecurringFormat (string acceptVersion, string authorization, int? id, int? amount, string orderId, string quickPayCallbackUrl, bool? synchronized, bool? autoCapture, bool? autofee, bool? zeroAuth, string textOnStatement)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTSubscriptionsIdRecurringFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTSubscriptionsIdRecurringFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTSubscriptionsIdRecurringFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTSubscriptionsIdRecurringFormat");
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling POSTSubscriptionsIdRecurringFormat");
            
    
            var path = "/subscriptions/{id}/recurring";
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
if (orderId != null) formParams.Add("order_id", ApiClient.ParameterToString(orderId)); // form parameter
if (autoCapture != null) formParams.Add("auto_capture", ApiClient.ParameterToString(autoCapture)); // form parameter
if (autofee != null) formParams.Add("autofee", ApiClient.ParameterToString(autofee)); // form parameter
if (zeroAuth != null) formParams.Add("zero_auth", ApiClient.ParameterToString(zeroAuth)); // form parameter
if (textOnStatement != null) formParams.Add("text_on_statement", ApiClient.ParameterToString(textOnStatement)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdRecurringFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdRecurringFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Payment) ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
        }
    
        /// <summary>
        /// Create subscription session  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Subscription id </param> 
        /// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
        /// <param name="acquirer">If set, will force the use of this acquirer </param> 
        /// <param name="autofee">When true, fee is calculated and added to the given amount. Default is merchant autofee </param> 
        /// <param name="customerIp">Customer IP </param> 
        /// <param name="extras">Additional acquirer specific params </param> 
        /// <returns>Subscription</returns>            
        public Subscription POSTSubscriptionsIdSessionFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, string acquirer, bool? autofee, string customerIp, string extras)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTSubscriptionsIdSessionFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTSubscriptionsIdSessionFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTSubscriptionsIdSessionFormat");
            
    
            var path = "/subscriptions/{id}/session";
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
            if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
if (autofee != null) formParams.Add("autofee", ApiClient.ParameterToString(autofee)); // form parameter
if (customerIp != null) formParams.Add("customer_ip", ApiClient.ParameterToString(customerIp)); // form parameter
if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdSessionFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTSubscriptionsIdSessionFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Create or update a payment link  
        /// </summary>
        /// <param name="acceptVersion">Specify the version of the API </param> 
        /// <param name="authorization">Use Basic Auth to authorize to the API </param> 
        /// <param name="id">Transaction id </param> 
        /// <param name="amount">Amount to authorize </param> 
        /// <param name="agreementId">Agreement to use. Defaults to the Payment Window agreement </param> 
        /// <param name="language">Language </param> 
        /// <param name="continueUrl">Url that cardholder is redirected to after authorize </param> 
        /// <param name="cancelUrl">Url that cardholder is redirected to after cancelation </param> 
        /// <param name="callbackUrl">Endpoint for async callback </param> 
        /// <param name="paymentMethods">Limit payment methods </param> 
        /// <param name="autoFee">Add acquirer fee to amount. Default is merchant autofee </param> 
        /// <param name="brandingId">Override branding. Default is merchant default branding </param> 
        /// <param name="googleAnalyticsTrackingId">Send events to Google Analytics </param> 
        /// <param name="googleAnalyticsClientId">Send events to Google Analytics </param> 
        /// <param name="acquirer">Force usage of the given acquirer </param> 
        /// <param name="deadline">Set a deadline in seconds for the cardholder to complete </param> 
        /// <param name="framed">Allow opening in iframe </param> 
        /// <param name="brandingConfig">Config for branding. Will be merged with the default config in the branding </param> 
        /// <param name="customerEmail">Required for PayPal. Email of customer. </param> 
        /// <param name="invoiceAddressSelection">Get customer invoice address via acquirer (Currently MobilePay and PayPal only) </param> 
        /// <param name="shippingAddressSelection">Get customer shipping address via acquirer (Currently MobilePay and PayPal only) </param> 
        /// <returns>PaymentLinkUrl</returns>            
        public PaymentLinkUrl PUTSubscriptionsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, bool? autoFee, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, int? deadline, bool? framed, string brandingConfig, string customerEmail, bool? invoiceAddressSelection, bool? shippingAddressSelection)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PUTSubscriptionsIdLinkFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PUTSubscriptionsIdLinkFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PUTSubscriptionsIdLinkFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling PUTSubscriptionsIdLinkFormat");
            
    
            var path = "/subscriptions/{id}/link";
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
if (autoFee != null) formParams.Add("auto_fee", ApiClient.ParameterToString(autoFee)); // form parameter
if (brandingId != null) formParams.Add("branding_id", ApiClient.ParameterToString(brandingId)); // form parameter
if (googleAnalyticsTrackingId != null) formParams.Add("google_analytics_tracking_id", ApiClient.ParameterToString(googleAnalyticsTrackingId)); // form parameter
if (googleAnalyticsClientId != null) formParams.Add("google_analytics_client_id", ApiClient.ParameterToString(googleAnalyticsClientId)); // form parameter
if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
if (deadline != null) formParams.Add("deadline", ApiClient.ParameterToString(deadline)); // form parameter
if (framed != null) formParams.Add("framed", ApiClient.ParameterToString(framed)); // form parameter
if (brandingConfig != null) formParams.Add("branding_config", ApiClient.ParameterToString(brandingConfig)); // form parameter
if (customerEmail != null) formParams.Add("customer_email", ApiClient.ParameterToString(customerEmail)); // form parameter
if (invoiceAddressSelection != null) formParams.Add("invoice_address_selection", ApiClient.ParameterToString(invoiceAddressSelection)); // form parameter
if (shippingAddressSelection != null) formParams.Add("shipping_address_selection", ApiClient.ParameterToString(shippingAddressSelection)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSubscriptionsIdLinkFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTSubscriptionsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaymentLinkUrl) ApiClient.Deserialize(response.Content, typeof(PaymentLinkUrl), response.Headers);
        }
    
    }
}
