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
	public interface IPaymentsApi
	{
		/// <summary>
		/// Delete payment link  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Transaction id </param>
		/// <returns></returns>
		void DELETEPaymentsIdLinkFormat(string acceptVersion, string authorization, int? id);

		/// <summary>
		/// Get all payments  
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
		/// <param name="accepted">Return accepted payments </param>
		/// <param name="orderId">Find by order_id </param>
		/// <param name="state">Find by state </param>
		/// <param name="id">Find by transaction id </param>
		/// <param name="acquirer">Filter by acquirer </param>
		/// <param name="fraudSuspected">Filter by suspected fraud </param>
		/// <param name="page">Pagination page. Default is 1 </param>
		/// <param name="pageSize">Items per page. Default is 20 </param>
		/// <param name="sortBy">Property to sort by </param>
		/// <param name="sortDir">Sort direction </param>
		/// <param name="pageKey"> </param>
		/// <returns>List&lt;Payment&gt;</returns>
		List<Payment> GETPaymentsFormat(string acceptVersion, string authorization, int? dateYear, int? dateMonth,
			int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime,
			int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer,
			bool? fraudSuspected, int? page, int? pageSize, string sortBy, string sortDir, string pageKey);

		/// <summary>
		/// Get payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="operationsSize">Maximum number of operations to retrieve </param>
		/// <returns>Payment</returns>
		Payment GETPaymentsIdFormat(string acceptVersion, string authorization, int? id, int? operationsSize);

		/// <summary>
		/// Get Operation  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="operationId">Operations id </param>
		/// <returns>Operation</returns>
		Operation GETPaymentsIdOperationsOperationIdFormat(string acceptVersion, string authorization, int? id,
			int? operationId);

		/// <summary>
		/// Update payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="basketQty">Quantity </param>
		/// <param name="basketItemNo">Item reference number </param>
		/// <param name="basketItemName">Item name </param>
		/// <param name="basketItemPrice">Per item price (incl. VAT) </param>
		/// <param name="basketVatRate">VAT rate </param>
		/// <param name="deadlineAt">Payment must be authorized before this time </param>
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
		/// <param name="shippingMethod">Shipping method </param>
		/// <param name="shippingCompany">Shipping company </param>
		/// <param name="shippingAmount">Shipping price (incl. VAT) </param>
		/// <param name="shippingVatRate">VAT rate </param>
		/// <param name="shippingTrackingNumber">Shipping tracking number </param>
		/// <param name="shippingTrackingUrl">Shipping tracking url </param>
		/// <param name="variables">Custom variables </param>
		/// <returns>Payment</returns>
		Payment PATCHPaymentsIdFormat(string acceptVersion, string authorization, int? id, int? basketQty,
			string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate,
			DateTime? deadlineAt, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName,
			string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension,
			string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion,
			string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber,
			string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName,
			string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet,
			string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity,
			string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode,
			string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber,
			string shippingAddressEmail, string shippingMethod, string shippingCompany, int? shippingAmount,
			float? shippingVatRate, string shippingTrackingNumber, string shippingTrackingUrl, string variables);

		/// <summary>
		/// Update operation  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="operationId">Operations id </param>
		/// <param name="pending">Aborts the operation. Only possible on capture, refund, recurring and cancel operations (false is the only allowed value) </param>
		/// <returns>Operation</returns>
		Operation PATCHPaymentsIdOperationsOperationIdFormat(string acceptVersion, string authorization, int? id,
			int? operationId, bool? pending);

		/// <summary>
		/// Create payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="payment">Payment</param>
		/// <returns>Payment</returns>
		Payment POSTPaymentsFormat(string acceptVersion, string authorization, Payment payment);

		/// <summary>
		/// Authorize payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
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
		/// <param name="autoCapture">When true, payment is captured after authorization. Default is false </param>
		/// <param name="acquirer">If set, will force the use of this acquirer </param>
		/// <param name="autofee">When true, fee is calculated and added to the given amount. Default is merchant autofee </param>
		/// <param name="customerIp">Customer IP </param>
		/// <param name="extras">Additional acquirer specific params </param>
		/// <param name="zeroAuth">(Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false </param>
		/// <returns>Payment</returns>
		Payment POSTPaymentsIdAuthorizeFormat(string acceptVersion, string authorization, int? id, int? amount,
			string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration,
			string cardCvd, string cardToken, string cardApplePayToken, string cardMobilepayOnlineToken,
			string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv,
			string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName,
			string personLastName, string personEmail, bool? autoCapture, string acquirer, bool? autofee,
			string customerIp, string extras, bool? zeroAuth);

		/// <summary>
		/// Cancel payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param>
		/// <returns>Payment</returns>
		Payment POSTPaymentsIdCancelFormat(string acceptVersion, string authorization, int? id,
			string quickPayCallbackUrl, bool? synchronized);

		/// <summary>
		/// Capture payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="amount">Amount </param>
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param>
		/// <param name="extras">Additional acquirer specific params </param>
		/// <returns>Payment</returns>
		Payment POSTPaymentsIdCaptureFormat(string acceptVersion, string authorization, int? id, int? amount,
			string quickPayCallbackUrl, bool? synchronized, string extras);

		/// <summary>
		/// Create fraud confirmation report  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
		/// <param name="description"> </param>
		/// <returns>FraudReport</returns>
		FraudReport POSTPaymentsIdFraudReportFormat(string acceptVersion, string authorization, int? id,
			string quickPayCallbackUrl, string description);

		/// <summary>
		/// Refund payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="amount">Amount </param>
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param>
		/// <param name="vatRate">Vate rate </param>
		/// <param name="extras">Additional acquirer specific params </param>
		/// <returns>Payment</returns>
		Payment POSTPaymentsIdRefundFormat(string acceptVersion, string authorization, int? id, int? amount,
			string quickPayCallbackUrl, bool? synchronized, float? vatRate, string extras);

		/// <summary>
		/// Renew authorization  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param>
		/// <returns>Payment</returns>
		Payment POSTPaymentsIdRenewFormat(string acceptVersion, string authorization, int? id,
			string quickPayCallbackUrl, bool? synchronized);

		/// <summary>
		/// Create payment session  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param>
		/// <param name="authorization">Use Basic Auth to authorize to the API </param>
		/// <param name="id">Payment id </param>
		/// <param name="amount">Amount </param>
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param>
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param>
		/// <param name="autoCapture">When true, payment is captured after authorization. Default is false </param>
		/// <param name="acquirer">If set, will force the use of this acquirer </param>
		/// <param name="autofee">When true, fee is calculated and added to the given amount. Default is merchant autofee </param>
		/// <param name="customerIp">Customer IP </param>
		/// <param name="personFirstName">Person first name </param>
		/// <param name="personLastName">Person last name </param>
		/// <param name="personEmail">Person email </param>
		/// <param name="extras">Additional acquirer specific params </param>
		/// <returns>Payment</returns>
		Payment POSTPaymentsIdSessionFormat(string acceptVersion, string authorization, int? id, int? amount,
			string quickPayCallbackUrl, bool? synchronized, bool? autoCapture, string acquirer, bool? autofee,
			string customerIp, string personFirstName, string personLastName, string personEmail, string extras);

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
		/// <param name="autoCapture">When true, payment is captured after authorization. Default is false </param>
		/// <returns>PaymentLinkUrl</returns>
		PaymentLinkUrl PUTPaymentsIdLinkFormat(string acceptVersion, string authorization, int? id, int? amount,
			int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl,
			string paymentMethods, bool? autoFee, int? brandingId, string googleAnalyticsTrackingId,
			string googleAnalyticsClientId, string acquirer, int? deadline, bool? framed, string brandingConfig,
			string customerEmail, bool? invoiceAddressSelection, bool? shippingAddressSelection, bool? autoCapture);
	}

	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public class PaymentsApi : IPaymentsApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PaymentsApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		/// <returns></returns>
		public PaymentsApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PaymentsApi"/> class.
		/// </summary>
		/// <returns></returns>
		public PaymentsApi(String basePath)
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
		public ApiClient ApiClient { get; set; }

		/// <summary>
		/// Delete payment link  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Transaction id </param> 
		/// <returns></returns>            
		public void DELETEPaymentsIdLinkFormat(string acceptVersion, string authorization, int? id)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling DELETEPaymentsIdLinkFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling DELETEPaymentsIdLinkFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling DELETEPaymentsIdLinkFormat");


			var path = "/payments/{id}/link";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Delete, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling DELETEPaymentsIdLinkFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling DELETEPaymentsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);

			return;
		}

		/// <summary>
		/// Get all payments  
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
		/// <param name="accepted">Return accepted payments </param> 
		/// <param name="orderId">Find by order_id </param> 
		/// <param name="state">Find by state </param> 
		/// <param name="id">Find by transaction id </param> 
		/// <param name="acquirer">Filter by acquirer </param> 
		/// <param name="fraudSuspected">Filter by suspected fraud </param> 
		/// <param name="page">Pagination page. Default is 1 </param> 
		/// <param name="pageSize">Items per page. Default is 20 </param> 
		/// <param name="sortBy">Property to sort by </param> 
		/// <param name="sortDir">Sort direction </param> 
		/// <param name="pageKey"> </param> 
		/// <returns>List&lt;Payment&gt;</returns>            
		public List<Payment> GETPaymentsFormat(string acceptVersion, string authorization, int? dateYear,
			int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime,
			string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer,
			bool? fraudSuspected, int? page, int? pageSize, string sortBy, string sortDir, string pageKey)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling GETPaymentsFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling GETPaymentsFormat");


			var path = "/payments";
			path = path.Replace("{format}", "json");

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (dateYear != null)
				queryParams.Add("date[year]", ApiClient.ParameterToString(dateYear)); // query parameter
			if (dateMonth != null)
				queryParams.Add("date[month]", ApiClient.ParameterToString(dateMonth)); // query parameter
			if (dateDay != null) queryParams.Add("date[day]", ApiClient.ParameterToString(dateDay)); // query parameter
			if (dateHour != null)
				queryParams.Add("date[hour]", ApiClient.ParameterToString(dateHour)); // query parameter
			if (dateMinute != null)
				queryParams.Add("date[minute]", ApiClient.ParameterToString(dateMinute)); // query parameter
			if (timestamp != null)
				queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
			if (minTime != null) queryParams.Add("min_time", ApiClient.ParameterToString(minTime)); // query parameter
			if (maxTime != null) queryParams.Add("max_time", ApiClient.ParameterToString(maxTime)); // query parameter
			if (operationsSize != null)
				queryParams.Add("operations_size", ApiClient.ParameterToString(operationsSize)); // query parameter
			if (accepted != null) queryParams.Add("accepted", ApiClient.ParameterToString(accepted)); // query parameter
			if (orderId != null) queryParams.Add("order_id", ApiClient.ParameterToString(orderId)); // query parameter
			if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
			if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
			if (acquirer != null) queryParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // query parameter
			if (fraudSuspected != null)
				queryParams.Add("fraud_suspected", ApiClient.ParameterToString(fraudSuspected)); // query parameter
			if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
			if (pageSize != null)
				queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
			if (sortBy != null) queryParams.Add("sort_by", ApiClient.ParameterToString(sortBy)); // query parameter
			if (sortDir != null) queryParams.Add("sort_dir", ApiClient.ParameterToString(sortDir)); // query parameter
			if (pageKey != null) queryParams.Add("page_key", ApiClient.ParameterToString(pageKey)); // query parameter
			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling GETPaymentsFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling GETPaymentsFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (List<Payment>)ApiClient.Deserialize(response.Content, typeof(List<Payment>), response.Headers);
		}

		/// <summary>
		/// Get payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="operationsSize">Maximum number of operations to retrieve </param> 
		/// <returns>Payment</returns>            
		public Payment GETPaymentsIdFormat(string acceptVersion, string authorization, int? id, int? operationsSize)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling GETPaymentsIdFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling GETPaymentsIdFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling GETPaymentsIdFormat");


			var path = "/payments/{id}";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (operationsSize != null)
				queryParams.Add("operations_size", ApiClient.ParameterToString(operationsSize)); // query parameter
			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling GETPaymentsIdFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling GETPaymentsIdFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
		}

		/// <summary>
		/// Get Operation  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="operationId">Operations id </param> 
		/// <returns>Operation</returns>            
		public Operation GETPaymentsIdOperationsOperationIdFormat(string acceptVersion, string authorization, int? id,
			int? operationId)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling GETPaymentsIdOperationsOperationIdFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling GETPaymentsIdOperationsOperationIdFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling GETPaymentsIdOperationsOperationIdFormat");

			// verify the required parameter 'operationId' is set
			if (operationId == null)
				throw new ApiException(400,
					"Missing required parameter 'operationId' when calling GETPaymentsIdOperationsOperationIdFormat");


			var path = "/payments/{id}/operations/{operation_id}";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
			path = path.Replace("{" + "operation_id" + "}", ApiClient.ParameterToString(operationId));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling GETPaymentsIdOperationsOperationIdFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling GETPaymentsIdOperationsOperationIdFormat: " + response.ErrorMessage,
					response.ErrorMessage);

			return (Operation)ApiClient.Deserialize(response.Content, typeof(Operation), response.Headers);
		}

		/// <summary>
		/// Update payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="basketQty">Quantity </param> 
		/// <param name="basketItemNo">Item reference number </param> 
		/// <param name="basketItemName">Item name </param> 
		/// <param name="basketItemPrice">Per item price (incl. VAT) </param> 
		/// <param name="basketVatRate">VAT rate </param> 
		/// <param name="deadlineAt">Payment must be authorized before this time </param> 
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
		/// <param name="shippingMethod">Shipping method </param> 
		/// <param name="shippingCompany">Shipping company </param> 
		/// <param name="shippingAmount">Shipping price (incl. VAT) </param> 
		/// <param name="shippingVatRate">VAT rate </param> 
		/// <param name="shippingTrackingNumber">Shipping tracking number </param> 
		/// <param name="shippingTrackingUrl">Shipping tracking url </param> 
		/// <param name="variables">Custom variables </param> 
		/// <returns>Payment</returns>            
		public Payment PATCHPaymentsIdFormat(string acceptVersion, string authorization, int? id, int? basketQty,
			string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate,
			DateTime? deadlineAt, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName,
			string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension,
			string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion,
			string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber,
			string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName,
			string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet,
			string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity,
			string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode,
			string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber,
			string shippingAddressEmail, string shippingMethod, string shippingCompany, int? shippingAmount,
			float? shippingVatRate, string shippingTrackingNumber, string shippingTrackingUrl, string variables)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling PATCHPaymentsIdFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling PATCHPaymentsIdFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling PATCHPaymentsIdFormat");

			// verify the required parameter 'basketQty' is set
			if (basketQty == null)
				throw new ApiException(400,
					"Missing required parameter 'basketQty' when calling PATCHPaymentsIdFormat");

			// verify the required parameter 'basketItemNo' is set
			if (basketItemNo == null)
				throw new ApiException(400,
					"Missing required parameter 'basketItemNo' when calling PATCHPaymentsIdFormat");

			// verify the required parameter 'basketItemName' is set
			if (basketItemName == null)
				throw new ApiException(400,
					"Missing required parameter 'basketItemName' when calling PATCHPaymentsIdFormat");

			// verify the required parameter 'basketItemPrice' is set
			if (basketItemPrice == null)
				throw new ApiException(400,
					"Missing required parameter 'basketItemPrice' when calling PATCHPaymentsIdFormat");

			// verify the required parameter 'basketVatRate' is set
			if (basketVatRate == null)
				throw new ApiException(400,
					"Missing required parameter 'basketVatRate' when calling PATCHPaymentsIdFormat");


			var path = "/payments/{id}";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (deadlineAt != null)
				formParams.Add("deadline_at", ApiClient.ParameterToString(deadlineAt)); // form parameter
			if (invoiceAddressName != null)
				formParams.Add("invoice_address[name]",
					ApiClient.ParameterToString(invoiceAddressName)); // form parameter
			if (invoiceAddressAtt != null)
				formParams.Add("invoice_address[att]",
					ApiClient.ParameterToString(invoiceAddressAtt)); // form parameter
			if (invoiceAddressCompanyName != null)
				formParams.Add("invoice_address[company_name]",
					ApiClient.ParameterToString(invoiceAddressCompanyName)); // form parameter
			if (invoiceAddressStreet != null)
				formParams.Add("invoice_address[street]",
					ApiClient.ParameterToString(invoiceAddressStreet)); // form parameter
			if (invoiceAddressHouseNumber != null)
				formParams.Add("invoice_address[house_number]",
					ApiClient.ParameterToString(invoiceAddressHouseNumber)); // form parameter
			if (invoiceAddressHouseExtension != null)
				formParams.Add("invoice_address[house_extension]",
					ApiClient.ParameterToString(invoiceAddressHouseExtension)); // form parameter
			if (invoiceAddressCity != null)
				formParams.Add("invoice_address[city]",
					ApiClient.ParameterToString(invoiceAddressCity)); // form parameter
			if (invoiceAddressZipCode != null)
				formParams.Add("invoice_address[zip_code]",
					ApiClient.ParameterToString(invoiceAddressZipCode)); // form parameter
			if (invoiceAddressRegion != null)
				formParams.Add("invoice_address[region]",
					ApiClient.ParameterToString(invoiceAddressRegion)); // form parameter
			if (invoiceAddressCountryCode != null)
				formParams.Add("invoice_address[country_code]",
					ApiClient.ParameterToString(invoiceAddressCountryCode)); // form parameter
			if (invoiceAddressVatNo != null)
				formParams.Add("invoice_address[vat_no]",
					ApiClient.ParameterToString(invoiceAddressVatNo)); // form parameter
			if (invoiceAddressPhoneNumber != null)
				formParams.Add("invoice_address[phone_number]",
					ApiClient.ParameterToString(invoiceAddressPhoneNumber)); // form parameter
			if (invoiceAddressMobileNumber != null)
				formParams.Add("invoice_address[mobile_number]",
					ApiClient.ParameterToString(invoiceAddressMobileNumber)); // form parameter
			if (invoiceAddressEmail != null)
				formParams.Add("invoice_address[email]",
					ApiClient.ParameterToString(invoiceAddressEmail)); // form parameter
			if (shippingAddressName != null)
				formParams.Add("shipping_address[name]",
					ApiClient.ParameterToString(shippingAddressName)); // form parameter
			if (shippingAddressAtt != null)
				formParams.Add("shipping_address[att]",
					ApiClient.ParameterToString(shippingAddressAtt)); // form parameter
			if (shippingAddressCompanyName != null)
				formParams.Add("shipping_address[company_name]",
					ApiClient.ParameterToString(shippingAddressCompanyName)); // form parameter
			if (shippingAddressStreet != null)
				formParams.Add("shipping_address[street]",
					ApiClient.ParameterToString(shippingAddressStreet)); // form parameter
			if (shippingAddressHouseNumber != null)
				formParams.Add("shipping_address[house_number]",
					ApiClient.ParameterToString(shippingAddressHouseNumber)); // form parameter
			if (shippingAddressHouseExtension != null)
				formParams.Add("shipping_address[house_extension]",
					ApiClient.ParameterToString(shippingAddressHouseExtension)); // form parameter
			if (shippingAddressCity != null)
				formParams.Add("shipping_address[city]",
					ApiClient.ParameterToString(shippingAddressCity)); // form parameter
			if (shippingAddressZipCode != null)
				formParams.Add("shipping_address[zip_code]",
					ApiClient.ParameterToString(shippingAddressZipCode)); // form parameter
			if (shippingAddressRegion != null)
				formParams.Add("shipping_address[region]",
					ApiClient.ParameterToString(shippingAddressRegion)); // form parameter
			if (shippingAddressCountryCode != null)
				formParams.Add("shipping_address[country_code]",
					ApiClient.ParameterToString(shippingAddressCountryCode)); // form parameter
			if (shippingAddressVatNo != null)
				formParams.Add("shipping_address[vat_no]",
					ApiClient.ParameterToString(shippingAddressVatNo)); // form parameter
			if (shippingAddressPhoneNumber != null)
				formParams.Add("shipping_address[phone_number]",
					ApiClient.ParameterToString(shippingAddressPhoneNumber)); // form parameter
			if (shippingAddressMobileNumber != null)
				formParams.Add("shipping_address[mobile_number]",
					ApiClient.ParameterToString(shippingAddressMobileNumber)); // form parameter
			if (shippingAddressEmail != null)
				formParams.Add("shipping_address[email]",
					ApiClient.ParameterToString(shippingAddressEmail)); // form parameter
			if (basketQty != null)
				formParams.Add("basket[][qty]", ApiClient.ParameterToString(basketQty)); // form parameter
			if (basketItemNo != null)
				formParams.Add("basket[][item_no]", ApiClient.ParameterToString(basketItemNo)); // form parameter
			if (basketItemName != null)
				formParams.Add("basket[][item_name]", ApiClient.ParameterToString(basketItemName)); // form parameter
			if (basketItemPrice != null)
				formParams.Add("basket[][item_price]", ApiClient.ParameterToString(basketItemPrice)); // form parameter
			if (basketVatRate != null)
				formParams.Add("basket[][vat_rate]", ApiClient.ParameterToString(basketVatRate)); // form parameter
			if (shippingMethod != null)
				formParams.Add("shipping[method]", ApiClient.ParameterToString(shippingMethod)); // form parameter
			if (shippingCompany != null)
				formParams.Add("shipping[company]", ApiClient.ParameterToString(shippingCompany)); // form parameter
			if (shippingAmount != null)
				formParams.Add("shipping[amount]", ApiClient.ParameterToString(shippingAmount)); // form parameter
			if (shippingVatRate != null)
				formParams.Add("shipping[vat_rate]", ApiClient.ParameterToString(shippingVatRate)); // form parameter
			if (shippingTrackingNumber != null)
				formParams.Add("shipping[tracking_number]",
					ApiClient.ParameterToString(shippingTrackingNumber)); // form parameter
			if (shippingTrackingUrl != null)
				formParams.Add("shipping[tracking_url]",
					ApiClient.ParameterToString(shippingTrackingUrl)); // form parameter
			if (variables != null)
				formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Patch, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling PATCHPaymentsIdFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling PATCHPaymentsIdFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
		}

		/// <summary>
		/// Update operation  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="operationId">Operations id </param> 
		/// <param name="pending">Aborts the operation. Only possible on capture, refund, recurring and cancel operations (false is the only allowed value) </param> 
		/// <returns>Operation</returns>            
		public Operation PATCHPaymentsIdOperationsOperationIdFormat(string acceptVersion, string authorization, int? id,
			int? operationId, bool? pending)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling PATCHPaymentsIdOperationsOperationIdFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling PATCHPaymentsIdOperationsOperationIdFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling PATCHPaymentsIdOperationsOperationIdFormat");

			// verify the required parameter 'operationId' is set
			if (operationId == null)
				throw new ApiException(400,
					"Missing required parameter 'operationId' when calling PATCHPaymentsIdOperationsOperationIdFormat");

			// verify the required parameter 'pending' is set
			if (pending == null)
				throw new ApiException(400,
					"Missing required parameter 'pending' when calling PATCHPaymentsIdOperationsOperationIdFormat");


			var path = "/payments/{id}/operations/{operation_id}";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
			path = path.Replace("{" + "operation_id" + "}", ApiClient.ParameterToString(operationId));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (pending != null) formParams.Add("pending", ApiClient.ParameterToString(pending)); // form parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Patch, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling PATCHPaymentsIdOperationsOperationIdFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling PATCHPaymentsIdOperationsOperationIdFormat: " + response.ErrorMessage,
					response.ErrorMessage);

			return (Operation)ApiClient.Deserialize(response.Content, typeof(Operation), response.Headers);
		}

		/// <summary>
		/// Create payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="payment">Payment</param> 
		/// <returns>Payment</returns>            
		public Payment POSTPaymentsFormat(string acceptVersion, string authorization, Payment payment)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling POSTPaymentsFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling POSTPaymentsFormat");

			// verify the required parameter 'payment' is set
			if (payment == null)
				throw new ApiException(400, "Missing required parameter 'payment' when calling POSTPaymentsFormat");


			var path = "/payments";
			path = path.Replace("{format}", "json");

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			postBody = ApiClient.Serialize(payment); // http body (model) parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
		}

		/// <summary>
		/// Authorize payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
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
		/// <param name="autoCapture">When true, payment is captured after authorization. Default is false </param> 
		/// <param name="acquirer">If set, will force the use of this acquirer </param> 
		/// <param name="autofee">When true, fee is calculated and added to the given amount. Default is merchant autofee </param> 
		/// <param name="customerIp">Customer IP </param> 
		/// <param name="extras">Additional acquirer specific params </param> 
		/// <param name="zeroAuth">(Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false </param> 
		/// <returns>Payment</returns>            
		public Payment POSTPaymentsIdAuthorizeFormat(string acceptVersion, string authorization, int? id, int? amount,
			string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration,
			string cardCvd, string cardToken, string cardApplePayToken, string cardMobilepayOnlineToken,
			string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv,
			string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName,
			string personLastName, string personEmail, bool? autoCapture, string acquirer, bool? autofee,
			string customerIp, string extras, bool? zeroAuth)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling POSTPaymentsIdAuthorizeFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling POSTPaymentsIdAuthorizeFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling POSTPaymentsIdAuthorizeFormat");

			// verify the required parameter 'amount' is set
			if (amount == null)
				throw new ApiException(400,
					"Missing required parameter 'amount' when calling POSTPaymentsIdAuthorizeFormat");


			var path = "/payments/{id}/authorize";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (synchronized != null)
				queryParams.Add("synchronized", ApiClient.ParameterToString(synchronized)); // query parameter
			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (quickPayCallbackUrl != null)
				headerParams.Add("QuickPay-Callback-Url",
					ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter
			if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
			if (vatRate != null) formParams.Add("vat_rate", ApiClient.ParameterToString(vatRate)); // form parameter
			if (cardNumber != null)
				formParams.Add("card[number]", ApiClient.ParameterToString(cardNumber)); // form parameter
			if (cardExpiration != null)
				formParams.Add("card[expiration]", ApiClient.ParameterToString(cardExpiration)); // form parameter
			if (cardCvd != null) formParams.Add("card[cvd]", ApiClient.ParameterToString(cardCvd)); // form parameter
			if (cardToken != null)
				formParams.Add("card[token]", ApiClient.ParameterToString(cardToken)); // form parameter
			if (cardApplePayToken != null)
				formParams.Add("card[apple_pay_token]",
					ApiClient.ParameterToString(cardApplePayToken)); // form parameter
			if (cardMobilepayOnlineToken != null)
				formParams.Add("card[mobilepay_online_token]",
					ApiClient.ParameterToString(cardMobilepayOnlineToken)); // form parameter
			if (cardIssuedTo != null)
				formParams.Add("card[issued_to]", ApiClient.ParameterToString(cardIssuedTo)); // form parameter
			if (cardBrand != null)
				formParams.Add("card[brand]", ApiClient.ParameterToString(cardBrand)); // form parameter
			if (cardStatus != null)
				formParams.Add("card[status]", ApiClient.ParameterToString(cardStatus)); // form parameter
			if (cardEci != null) formParams.Add("card[eci]", ApiClient.ParameterToString(cardEci)); // form parameter
			if (cardXav != null) formParams.Add("card[xav]", ApiClient.ParameterToString(cardXav)); // form parameter
			if (cardCavv != null) formParams.Add("card[cavv]", ApiClient.ParameterToString(cardCavv)); // form parameter
			if (mobileNumber != null)
				formParams.Add("mobile_number", ApiClient.ParameterToString(mobileNumber)); // form parameter
			if (ninNumber != null)
				formParams.Add("nin[number]", ApiClient.ParameterToString(ninNumber)); // form parameter
			if (ninCountryCode != null)
				formParams.Add("nin[country_code]", ApiClient.ParameterToString(ninCountryCode)); // form parameter
			if (ninGender != null)
				formParams.Add("nin[gender]", ApiClient.ParameterToString(ninGender)); // form parameter
			if (personFirstName != null)
				formParams.Add("person[first_name]", ApiClient.ParameterToString(personFirstName)); // form parameter
			if (personLastName != null)
				formParams.Add("person[last_name]", ApiClient.ParameterToString(personLastName)); // form parameter
			if (personEmail != null)
				formParams.Add("person[email]", ApiClient.ParameterToString(personEmail)); // form parameter
			if (autoCapture != null)
				formParams.Add("auto_capture", ApiClient.ParameterToString(autoCapture)); // form parameter
			if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
			if (autofee != null) formParams.Add("autofee", ApiClient.ParameterToString(autofee)); // form parameter
			if (customerIp != null)
				formParams.Add("customer_ip", ApiClient.ParameterToString(customerIp)); // form parameter
			if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter
			if (zeroAuth != null) formParams.Add("zero_auth", ApiClient.ParameterToString(zeroAuth)); // form parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdAuthorizeFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdAuthorizeFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
		}

		/// <summary>
		/// Cancel payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param> 
		/// <returns>Payment</returns>            
		public Payment POSTPaymentsIdCancelFormat(string acceptVersion, string authorization, int? id,
			string quickPayCallbackUrl, bool? synchronized)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling POSTPaymentsIdCancelFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling POSTPaymentsIdCancelFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdCancelFormat");


			var path = "/payments/{id}/cancel";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (synchronized != null)
				queryParams.Add("synchronized", ApiClient.ParameterToString(synchronized)); // query parameter
			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (quickPayCallbackUrl != null)
				headerParams.Add("QuickPay-Callback-Url",
					ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdCancelFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdCancelFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
		}

		/// <summary>
		/// Capture payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="amount">Amount </param> 
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param> 
		/// <param name="extras">Additional acquirer specific params </param> 
		/// <returns>Payment</returns>            
		public Payment POSTPaymentsIdCaptureFormat(string acceptVersion, string authorization, int? id, int? amount,
			string quickPayCallbackUrl, bool? synchronized, string extras)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling POSTPaymentsIdCaptureFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling POSTPaymentsIdCaptureFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdCaptureFormat");

			// verify the required parameter 'amount' is set
			if (amount == null)
				throw new ApiException(400,
					"Missing required parameter 'amount' when calling POSTPaymentsIdCaptureFormat");


			var path = "/payments/{id}/capture";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (synchronized != null)
				queryParams.Add("synchronized", ApiClient.ParameterToString(synchronized)); // query parameter
			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (quickPayCallbackUrl != null)
				headerParams.Add("QuickPay-Callback-Url",
					ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter
			if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
			if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdCaptureFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdCaptureFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
		}

		/// <summary>
		/// Create fraud confirmation report  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
		/// <param name="description"> </param> 
		/// <returns>FraudReport</returns>            
		public FraudReport POSTPaymentsIdFraudReportFormat(string acceptVersion, string authorization, int? id,
			string quickPayCallbackUrl, string description)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling POSTPaymentsIdFraudReportFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling POSTPaymentsIdFraudReportFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling POSTPaymentsIdFraudReportFormat");


			var path = "/payments/{id}/fraud-report";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (quickPayCallbackUrl != null)
				headerParams.Add("QuickPay-Callback-Url",
					ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter
			if (description != null)
				formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdFraudReportFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdFraudReportFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (FraudReport)ApiClient.Deserialize(response.Content, typeof(FraudReport), response.Headers);
		}

		/// <summary>
		/// Refund payment  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="amount">Amount </param> 
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param> 
		/// <param name="vatRate">Vate rate </param> 
		/// <param name="extras">Additional acquirer specific params </param> 
		/// <returns>Payment</returns>            
		public Payment POSTPaymentsIdRefundFormat(string acceptVersion, string authorization, int? id, int? amount,
			string quickPayCallbackUrl, bool? synchronized, float? vatRate, string extras)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling POSTPaymentsIdRefundFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling POSTPaymentsIdRefundFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdRefundFormat");

			// verify the required parameter 'amount' is set
			if (amount == null)
				throw new ApiException(400,
					"Missing required parameter 'amount' when calling POSTPaymentsIdRefundFormat");


			var path = "/payments/{id}/refund";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (synchronized != null)
				queryParams.Add("synchronized", ApiClient.ParameterToString(synchronized)); // query parameter
			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (quickPayCallbackUrl != null)
				headerParams.Add("QuickPay-Callback-Url",
					ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter
			if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
			if (vatRate != null) formParams.Add("vat_rate", ApiClient.ParameterToString(vatRate)); // form parameter
			if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdRefundFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdRefundFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
		}

		/// <summary>
		/// Renew authorization  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param> 
		/// <returns>Payment</returns>            
		public Payment POSTPaymentsIdRenewFormat(string acceptVersion, string authorization, int? id,
			string quickPayCallbackUrl, bool? synchronized)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling POSTPaymentsIdRenewFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling POSTPaymentsIdRenewFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdRenewFormat");


			var path = "/payments/{id}/renew";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (synchronized != null)
				queryParams.Add("synchronized", ApiClient.ParameterToString(synchronized)); // query parameter
			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (quickPayCallbackUrl != null)
				headerParams.Add("QuickPay-Callback-Url",
					ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdRenewFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdRenewFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
		}

		/// <summary>
		/// Create payment session  
		/// </summary>
		/// <param name="acceptVersion">Specify the version of the API </param> 
		/// <param name="authorization">Use Basic Auth to authorize to the API </param> 
		/// <param name="id">Payment id </param> 
		/// <param name="amount">Amount </param> 
		/// <param name="quickPayCallbackUrl">Specify the callback url (overrides merchant default callback-url) </param> 
		/// <param name="synchronized">Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required) </param> 
		/// <param name="autoCapture">When true, payment is captured after authorization. Default is false </param> 
		/// <param name="acquirer">If set, will force the use of this acquirer </param> 
		/// <param name="autofee">When true, fee is calculated and added to the given amount. Default is merchant autofee </param> 
		/// <param name="customerIp">Customer IP </param> 
		/// <param name="personFirstName">Person first name </param> 
		/// <param name="personLastName">Person last name </param> 
		/// <param name="personEmail">Person email </param> 
		/// <param name="extras">Additional acquirer specific params </param> 
		/// <returns>Payment</returns>            
		public Payment POSTPaymentsIdSessionFormat(string acceptVersion, string authorization, int? id, int? amount,
			string quickPayCallbackUrl, bool? synchronized, bool? autoCapture, string acquirer, bool? autofee,
			string customerIp, string personFirstName, string personLastName, string personEmail, string extras)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling POSTPaymentsIdSessionFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling POSTPaymentsIdSessionFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdSessionFormat");

			// verify the required parameter 'amount' is set
			if (amount == null)
				throw new ApiException(400,
					"Missing required parameter 'amount' when calling POSTPaymentsIdSessionFormat");


			var path = "/payments/{id}/session";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (synchronized != null)
				queryParams.Add("synchronized", ApiClient.ParameterToString(synchronized)); // query parameter
			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (quickPayCallbackUrl != null)
				headerParams.Add("QuickPay-Callback-Url",
					ApiClient.ParameterToString(quickPayCallbackUrl)); // header parameter
			if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
			if (autoCapture != null)
				formParams.Add("auto_capture", ApiClient.ParameterToString(autoCapture)); // form parameter
			if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
			if (autofee != null) formParams.Add("autofee", ApiClient.ParameterToString(autofee)); // form parameter
			if (customerIp != null)
				formParams.Add("customer_ip", ApiClient.ParameterToString(customerIp)); // form parameter
			if (personFirstName != null)
				formParams.Add("person[first_name]", ApiClient.ParameterToString(personFirstName)); // form parameter
			if (personLastName != null)
				formParams.Add("person[last_name]", ApiClient.ParameterToString(personLastName)); // form parameter
			if (personEmail != null)
				formParams.Add("person[email]", ApiClient.ParameterToString(personEmail)); // form parameter
			if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdSessionFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling POSTPaymentsIdSessionFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment), response.Headers);
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
		/// <param name="autoCapture">When true, payment is captured after authorization. Default is false </param> 
		/// <returns>PaymentLinkUrl</returns>            
		public PaymentLinkUrl PUTPaymentsIdLinkFormat(string acceptVersion, string authorization, int? id, int? amount,
			int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl,
			string paymentMethods, bool? autoFee, int? brandingId, string googleAnalyticsTrackingId,
			string googleAnalyticsClientId, string acquirer, int? deadline, bool? framed, string brandingConfig,
			string customerEmail, bool? invoiceAddressSelection, bool? shippingAddressSelection, bool? autoCapture)
		{
			// verify the required parameter 'acceptVersion' is set
			if (acceptVersion == null)
				throw new ApiException(400,
					"Missing required parameter 'acceptVersion' when calling PUTPaymentsIdLinkFormat");

			// verify the required parameter 'authorization' is set
			if (authorization == null)
				throw new ApiException(400,
					"Missing required parameter 'authorization' when calling PUTPaymentsIdLinkFormat");

			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id' when calling PUTPaymentsIdLinkFormat");

			// verify the required parameter 'amount' is set
			if (amount == null)
				throw new ApiException(400, "Missing required parameter 'amount' when calling PUTPaymentsIdLinkFormat");


			var path = "/payments/{id}/link";
			path = path.Replace("{format}", "json");
			path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));

			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();
			String postBody = null;

			if (acceptVersion != null)
				headerParams.Add("Accept-Version", ApiClient.ParameterToString(acceptVersion)); // header parameter
			if (authorization != null)
				headerParams.Add("Authorization", $"basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(":" + ApiClient.ParameterToString(authorization)))}"); // header parameter
			if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
			if (agreementId != null)
				formParams.Add("agreement_id", ApiClient.ParameterToString(agreementId)); // form parameter
			if (language != null) formParams.Add("language", ApiClient.ParameterToString(language)); // form parameter
			if (continueUrl != null)
				formParams.Add("continue_url", ApiClient.ParameterToString(continueUrl)); // form parameter
			if (cancelUrl != null)
				formParams.Add("cancel_url", ApiClient.ParameterToString(cancelUrl)); // form parameter
			if (callbackUrl != null)
				formParams.Add("callback_url", ApiClient.ParameterToString(callbackUrl)); // form parameter
			if (paymentMethods != null)
				formParams.Add("payment_methods", ApiClient.ParameterToString(paymentMethods)); // form parameter
			if (autoFee != null) formParams.Add("auto_fee", ApiClient.ParameterToString(autoFee)); // form parameter
			if (brandingId != null)
				formParams.Add("branding_id", ApiClient.ParameterToString(brandingId)); // form parameter
			if (googleAnalyticsTrackingId != null)
				formParams.Add("google_analytics_tracking_id",
					ApiClient.ParameterToString(googleAnalyticsTrackingId)); // form parameter
			if (googleAnalyticsClientId != null)
				formParams.Add("google_analytics_client_id",
					ApiClient.ParameterToString(googleAnalyticsClientId)); // form parameter
			if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
			if (deadline != null) formParams.Add("deadline", ApiClient.ParameterToString(deadline)); // form parameter
			if (framed != null) formParams.Add("framed", ApiClient.ParameterToString(framed)); // form parameter
			if (brandingConfig != null)
				formParams.Add("branding_config", ApiClient.ParameterToString(brandingConfig)); // form parameter
			if (customerEmail != null)
				formParams.Add("customer_email", ApiClient.ParameterToString(customerEmail)); // form parameter
			if (invoiceAddressSelection != null)
				formParams.Add("invoice_address_selection",
					ApiClient.ParameterToString(invoiceAddressSelection)); // form parameter
			if (shippingAddressSelection != null)
				formParams.Add("shipping_address_selection",
					ApiClient.ParameterToString(shippingAddressSelection)); // form parameter
			if (autoCapture != null)
				formParams.Add("auto_capture", ApiClient.ParameterToString(autoCapture)); // form parameter

			// authentication setting, if any
			String[] authSettings = new String[] { };

			// make the HTTP request
			RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Put, queryParams, postBody,
				headerParams, formParams, fileParams, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode,
					"Error calling PUTPaymentsIdLinkFormat: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode,
					"Error calling PUTPaymentsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);

			return (PaymentLinkUrl)ApiClient.Deserialize(response.Content, typeof(PaymentLinkUrl), response.Headers);
		}
	}
}