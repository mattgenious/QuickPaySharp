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
    public interface IPaymentsApi
    {
        /// <summary>
        /// Delete payment link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Transaction id&lt;/p&gt; </param>
        /// <returns></returns>
        void DELETEPaymentsIdLinkFormat (string acceptVersion, string authorization, int? id);
        /// <summary>
        /// Get all payments  
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
        /// <param name="accepted">&lt;p&gt;Return accepted payments&lt;/p&gt; </param>
        /// <param name="orderId">&lt;p&gt;Find by order_id&lt;/p&gt; </param>
        /// <param name="state">&lt;p&gt;Find by state&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Find by transaction id&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Filter by acquirer&lt;/p&gt; </param>
        /// <param name="fraudSuspected">&lt;p&gt;Filter by suspected fraud&lt;/p&gt; </param>
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param>
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param>
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param>
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param>
        /// <param name="pageKey"> </param>
        /// <returns>List&lt;QuickPayProtocolV10Payment&gt;</returns>
        List<QuickPayProtocolV10Payment> GETPaymentsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, bool? fraudSuspected, int? page, int? pageSize, string sortBy, string sortDir, string pageKey);
        /// <summary>
        /// Get payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="operationsSize">&lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment GETPaymentsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize);
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="operationId">&lt;p&gt;Operations id&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Operation</returns>
        QuickPayProtocolV10Operation GETPaymentsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId);
        /// <summary>
        /// Update payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="basketQty">&lt;p&gt;Quantity&lt;/p&gt; </param>
        /// <param name="basketItemNo">&lt;p&gt;Item reference number&lt;/p&gt; </param>
        /// <param name="basketItemName">&lt;p&gt;Item name&lt;/p&gt; </param>
        /// <param name="basketItemPrice">&lt;p&gt;Per item price (incl. VAT)&lt;/p&gt; </param>
        /// <param name="basketVatRate">&lt;p&gt;VAT rate&lt;/p&gt; </param>
        /// <param name="deadlineAt">&lt;p&gt;Payment must be authorized before this time&lt;/p&gt; </param>
        /// <param name="invoiceAddressName">&lt;p&gt;Name&lt;/p&gt; </param>
        /// <param name="invoiceAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param>
        /// <param name="invoiceAddressCompanyName">&lt;p&gt;Company name&lt;/p&gt; </param>
        /// <param name="invoiceAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param>
        /// <param name="invoiceAddressHouseNumber">&lt;p&gt;House number&lt;/p&gt; </param>
        /// <param name="invoiceAddressHouseExtension">&lt;p&gt;House extension&lt;/p&gt; </param>
        /// <param name="invoiceAddressCity">&lt;p&gt;City&lt;/p&gt; </param>
        /// <param name="invoiceAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param>
        /// <param name="invoiceAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param>
        /// <param name="invoiceAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param>
        /// <param name="invoiceAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param>
        /// <param name="invoiceAddressPhoneNumber">&lt;p&gt;Phone number&lt;/p&gt; </param>
        /// <param name="invoiceAddressMobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param>
        /// <param name="invoiceAddressEmail">&lt;p&gt;Email address&lt;/p&gt; </param>
        /// <param name="shippingAddressName">&lt;p&gt;Name&lt;/p&gt; </param>
        /// <param name="shippingAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param>
        /// <param name="shippingAddressCompanyName">&lt;p&gt;Company name&lt;/p&gt; </param>
        /// <param name="shippingAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param>
        /// <param name="shippingAddressHouseNumber">&lt;p&gt;House number&lt;/p&gt; </param>
        /// <param name="shippingAddressHouseExtension">&lt;p&gt;House extension&lt;/p&gt; </param>
        /// <param name="shippingAddressCity">&lt;p&gt;City&lt;/p&gt; </param>
        /// <param name="shippingAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param>
        /// <param name="shippingAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param>
        /// <param name="shippingAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param>
        /// <param name="shippingAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param>
        /// <param name="shippingAddressPhoneNumber">&lt;p&gt;Phone number&lt;/p&gt; </param>
        /// <param name="shippingAddressMobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param>
        /// <param name="shippingAddressEmail">&lt;p&gt;Email address&lt;/p&gt; </param>
        /// <param name="shippingMethod">&lt;p&gt;Shipping method&lt;/p&gt; </param>
        /// <param name="shippingCompany">&lt;p&gt;Shipping company&lt;/p&gt; </param>
        /// <param name="shippingAmount">&lt;p&gt;Shipping price (incl. VAT)&lt;/p&gt; </param>
        /// <param name="shippingVatRate">&lt;p&gt;VAT rate&lt;/p&gt; </param>
        /// <param name="shippingTrackingNumber">&lt;p&gt;Shipping tracking number&lt;/p&gt; </param>
        /// <param name="shippingTrackingUrl">&lt;p&gt;Shipping tracking url&lt;/p&gt; </param>
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment PATCHPaymentsIdFormat (string acceptVersion, string authorization, int? id, int? basketQty, string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate, DateTime? deadlineAt, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName, string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension, string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion, string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber, string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName, string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet, string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity, string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode, string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber, string shippingAddressEmail, string shippingMethod, string shippingCompany, int? shippingAmount, float? shippingVatRate, string shippingTrackingNumber, string shippingTrackingUrl, Dictionary<string, string> variables);
        /// <summary>
        /// Update operation  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="operationId">&lt;p&gt;Operations id&lt;/p&gt; </param>
        /// <param name="pending">&lt;p&gt;Aborts the operation. Only possible on capture, refund, recurring and cancel operations (false is the only allowed value)&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Operation</returns>
        QuickPayProtocolV10Operation PATCHPaymentsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId, bool? pending);
        /// <summary>
        /// Create payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="currency">&lt;p&gt;Currency&lt;/p&gt; </param>
        /// <param name="orderId">&lt;p&gt;Unique order id(must be between 4-20 characters)&lt;/p&gt; </param>
        /// <param name="basketQty">&lt;p&gt;Quantity&lt;/p&gt; </param>
        /// <param name="basketItemNo">&lt;p&gt;Item reference number&lt;/p&gt; </param>
        /// <param name="basketItemName">&lt;p&gt;Item name&lt;/p&gt; </param>
        /// <param name="basketItemPrice">&lt;p&gt;Per item price (incl. VAT)&lt;/p&gt; </param>
        /// <param name="basketVatRate">&lt;p&gt;VAT rate&lt;/p&gt; </param>
        /// <param name="invoiceAddressName">&lt;p&gt;Name&lt;/p&gt; </param>
        /// <param name="invoiceAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param>
        /// <param name="invoiceAddressCompanyName">&lt;p&gt;Company name&lt;/p&gt; </param>
        /// <param name="invoiceAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param>
        /// <param name="invoiceAddressHouseNumber">&lt;p&gt;House number&lt;/p&gt; </param>
        /// <param name="invoiceAddressHouseExtension">&lt;p&gt;House extension&lt;/p&gt; </param>
        /// <param name="invoiceAddressCity">&lt;p&gt;City&lt;/p&gt; </param>
        /// <param name="invoiceAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param>
        /// <param name="invoiceAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param>
        /// <param name="invoiceAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param>
        /// <param name="invoiceAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param>
        /// <param name="invoiceAddressPhoneNumber">&lt;p&gt;Phone number&lt;/p&gt; </param>
        /// <param name="invoiceAddressMobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param>
        /// <param name="invoiceAddressEmail">&lt;p&gt;Email address&lt;/p&gt; </param>
        /// <param name="shippingAddressName">&lt;p&gt;Name&lt;/p&gt; </param>
        /// <param name="shippingAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param>
        /// <param name="shippingAddressCompanyName">&lt;p&gt;Company name&lt;/p&gt; </param>
        /// <param name="shippingAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param>
        /// <param name="shippingAddressHouseNumber">&lt;p&gt;House number&lt;/p&gt; </param>
        /// <param name="shippingAddressHouseExtension">&lt;p&gt;House extension&lt;/p&gt; </param>
        /// <param name="shippingAddressCity">&lt;p&gt;City&lt;/p&gt; </param>
        /// <param name="shippingAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param>
        /// <param name="shippingAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param>
        /// <param name="shippingAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param>
        /// <param name="shippingAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param>
        /// <param name="shippingAddressPhoneNumber">&lt;p&gt;Phone number&lt;/p&gt; </param>
        /// <param name="shippingAddressMobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param>
        /// <param name="shippingAddressEmail">&lt;p&gt;Email address&lt;/p&gt; </param>
        /// <param name="brandingId">&lt;p&gt;Used branding id&lt;/p&gt; </param>
        /// <param name="shippingMethod">&lt;p&gt;Shipping method&lt;/p&gt; </param>
        /// <param name="shippingCompany">&lt;p&gt;Shipping company&lt;/p&gt; </param>
        /// <param name="shippingAmount">&lt;p&gt;Shipping price (incl. VAT)&lt;/p&gt; </param>
        /// <param name="shippingVatRate">&lt;p&gt;VAT rate&lt;/p&gt; </param>
        /// <param name="shippingTrackingNumber">&lt;p&gt;Shipping tracking number&lt;/p&gt; </param>
        /// <param name="shippingTrackingUrl">&lt;p&gt;Shipping tracking url&lt;/p&gt; </param>
        /// <param name="shopsystemName">&lt;p&gt;Shop system module name&lt;/p&gt; </param>
        /// <param name="shopsystemVersion">&lt;p&gt;Shop system module version&lt;/p&gt; </param>
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param>
        /// <param name="textOnStatement">&lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment POSTPaymentsFormat (string acceptVersion, string authorization, string currency, string orderId, int? basketQty, string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName, string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension, string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion, string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber, string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName, string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet, string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity, string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode, string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber, string shippingAddressEmail, int? brandingId, string shippingMethod, string shippingCompany, int? shippingAmount, float? shippingVatRate, string shippingTrackingNumber, string shippingTrackingUrl, string shopsystemName, string shopsystemVersion, Dictionary<string, string> variables, string textOnStatement);
        /// <summary>
        /// Authorize payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
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
        /// <param name="autoCapture">&lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param>
        /// <param name="autofee">&lt;p&gt;When true, fee is calculated and added to the given amount. Default is merchant autofee&lt;/p&gt; </param>
        /// <param name="customerIp">&lt;p&gt;Customer IP&lt;/p&gt; </param>
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param>
        /// <param name="zeroAuth">&lt;p&gt;(Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment POSTPaymentsIdAuthorizeFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, Dictionary<string, string> cardApplePayToken, Dictionary<string, string> cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, bool? autoCapture, string acquirer, bool? autofee, string customerIp, Dictionary<string, string> extras, bool? zeroAuth);
        /// <summary>
        /// Cancel payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param>
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment POSTPaymentsIdCancelFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, bool? synchronized);
        /// <summary>
        /// Capture payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount&lt;/p&gt; </param>
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param>
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param>
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment POSTPaymentsIdCaptureFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, Dictionary<string, string> extras);
        /// <summary>
        /// Create fraud confirmation report  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param>
        /// <param name="description"> </param>
        /// <returns>QuickPayProtocolV10FraudReport</returns>
        QuickPayProtocolV10FraudReport POSTPaymentsIdFraudReportFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, string description);
        /// <summary>
        /// Refund payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount&lt;/p&gt; </param>
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param>
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param>
        /// <param name="vatRate">&lt;p&gt;Vate rate&lt;/p&gt; </param>
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment POSTPaymentsIdRefundFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, Dictionary<string, string> extras);
        /// <summary>
        /// Renew authorization  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param>
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment POSTPaymentsIdRenewFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, bool? synchronized);
        /// <summary>
        /// Create payment session  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount&lt;/p&gt; </param>
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param>
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param>
        /// <param name="autoCapture">&lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param>
        /// <param name="autofee">&lt;p&gt;When true, fee is calculated and added to the given amount. Default is merchant autofee&lt;/p&gt; </param>
        /// <param name="customerIp">&lt;p&gt;Customer IP&lt;/p&gt; </param>
        /// <param name="personFirstName">&lt;p&gt;Person first name&lt;/p&gt; </param>
        /// <param name="personLastName">&lt;p&gt;Person last name&lt;/p&gt; </param>
        /// <param name="personEmail">&lt;p&gt;Person email&lt;/p&gt; </param>
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10Payment</returns>
        QuickPayProtocolV10Payment POSTPaymentsIdSessionFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, bool? autoCapture, string acquirer, bool? autofee, string customerIp, string personFirstName, string personLastName, string personEmail, Dictionary<string, string> extras);
        /// <summary>
        /// Create or update a payment link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param>
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param>
        /// <param name="id">&lt;p&gt;Transaction id&lt;/p&gt; </param>
        /// <param name="amount">&lt;p&gt;Amount to authorize&lt;/p&gt; </param>
        /// <param name="agreementId">&lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt; </param>
        /// <param name="language">&lt;p&gt;Language&lt;/p&gt; </param>
        /// <param name="continueUrl">&lt;p&gt;Url that cardholder is redirected to after authorize&lt;/p&gt; </param>
        /// <param name="cancelUrl">&lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt; </param>
        /// <param name="callbackUrl">&lt;p&gt;Endpoint for async callback&lt;/p&gt; </param>
        /// <param name="paymentMethods">&lt;p&gt;Limit payment methods&lt;/p&gt; </param>
        /// <param name="autoFee">&lt;p&gt;Add acquirer fee to amount. Default is merchant autofee&lt;/p&gt; </param>
        /// <param name="brandingId">&lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt; </param>
        /// <param name="googleAnalyticsTrackingId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param>
        /// <param name="googleAnalyticsClientId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param>
        /// <param name="acquirer">&lt;p&gt;Force usage of the given acquirer&lt;/p&gt; </param>
        /// <param name="deadline">&lt;p&gt;Set a deadline in seconds for the cardholder to complete&lt;/p&gt; </param>
        /// <param name="framed">&lt;p&gt;Allow opening in iframe&lt;/p&gt; </param>
        /// <param name="brandingConfig">&lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt; </param>
        /// <param name="customerEmail">&lt;p&gt;Required for PayPal. Email of customer.&lt;/p&gt; </param>
        /// <param name="invoiceAddressSelection">&lt;p&gt;Get customer invoice address via acquirer (Currently MobilePay and PayPal only)&lt;/p&gt; </param>
        /// <param name="shippingAddressSelection">&lt;p&gt;Get customer shipping address via acquirer (Currently MobilePay and PayPal only)&lt;/p&gt; </param>
        /// <param name="autoCapture">&lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt; </param>
        /// <returns>QuickPayProtocolV10PaymentLinkUrl</returns>
        QuickPayProtocolV10PaymentLinkUrl PUTPaymentsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, bool? autoFee, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, int? deadline, bool? framed, Dictionary<string, string> brandingConfig, string customerEmail, bool? invoiceAddressSelection, bool? shippingAddressSelection, bool? autoCapture);
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
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Delete payment link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Transaction id&lt;/p&gt; </param> 
        /// <returns></returns>            
        public void DELETEPaymentsIdLinkFormat (string acceptVersion, string authorization, int? id)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling DELETEPaymentsIdLinkFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling DELETEPaymentsIdLinkFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DELETEPaymentsIdLinkFormat");
            
    
            var path = "/payments/{id}/link";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEPaymentsIdLinkFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DELETEPaymentsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get all payments  
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
        /// <param name="accepted">&lt;p&gt;Return accepted payments&lt;/p&gt; </param> 
        /// <param name="orderId">&lt;p&gt;Find by order_id&lt;/p&gt; </param> 
        /// <param name="state">&lt;p&gt;Find by state&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Find by transaction id&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Filter by acquirer&lt;/p&gt; </param> 
        /// <param name="fraudSuspected">&lt;p&gt;Filter by suspected fraud&lt;/p&gt; </param> 
        /// <param name="page">&lt;p&gt;Pagination page. Default is 1&lt;/p&gt; </param> 
        /// <param name="pageSize">&lt;p&gt;Items per page. Default is 20&lt;/p&gt; </param> 
        /// <param name="sortBy">&lt;p&gt;Property to sort by&lt;/p&gt; </param> 
        /// <param name="sortDir">&lt;p&gt;Sort direction&lt;/p&gt; </param> 
        /// <param name="pageKey"> </param> 
        /// <returns>List&lt;QuickPayProtocolV10Payment&gt;</returns>            
        public List<QuickPayProtocolV10Payment> GETPaymentsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, bool? fraudSuspected, int? page, int? pageSize, string sortBy, string sortDir, string pageKey)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETPaymentsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETPaymentsFormat");
            
    
            var path = "/payments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<QuickPayProtocolV10Payment>) ApiClient.Deserialize(response.Content, typeof(List<QuickPayProtocolV10Payment>), response.Headers);
        }
    
        /// <summary>
        /// Get payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="operationsSize">&lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment GETPaymentsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETPaymentsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETPaymentsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETPaymentsIdFormat");
            
    
            var path = "/payments/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Get Operation  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="operationId">&lt;p&gt;Operations id&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Operation</returns>            
        public QuickPayProtocolV10Operation GETPaymentsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling GETPaymentsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GETPaymentsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GETPaymentsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'operationId' is set
            if (operationId == null) throw new ApiException(400, "Missing required parameter 'operationId' when calling GETPaymentsIdOperationsOperationIdFormat");
            
    
            var path = "/payments/{id}/operations/{operation_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentsIdOperationsOperationIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GETPaymentsIdOperationsOperationIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Operation) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Operation), response.Headers);
        }
    
        /// <summary>
        /// Update payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="basketQty">&lt;p&gt;Quantity&lt;/p&gt; </param> 
        /// <param name="basketItemNo">&lt;p&gt;Item reference number&lt;/p&gt; </param> 
        /// <param name="basketItemName">&lt;p&gt;Item name&lt;/p&gt; </param> 
        /// <param name="basketItemPrice">&lt;p&gt;Per item price (incl. VAT)&lt;/p&gt; </param> 
        /// <param name="basketVatRate">&lt;p&gt;VAT rate&lt;/p&gt; </param> 
        /// <param name="deadlineAt">&lt;p&gt;Payment must be authorized before this time&lt;/p&gt; </param> 
        /// <param name="invoiceAddressName">&lt;p&gt;Name&lt;/p&gt; </param> 
        /// <param name="invoiceAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param> 
        /// <param name="invoiceAddressCompanyName">&lt;p&gt;Company name&lt;/p&gt; </param> 
        /// <param name="invoiceAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param> 
        /// <param name="invoiceAddressHouseNumber">&lt;p&gt;House number&lt;/p&gt; </param> 
        /// <param name="invoiceAddressHouseExtension">&lt;p&gt;House extension&lt;/p&gt; </param> 
        /// <param name="invoiceAddressCity">&lt;p&gt;City&lt;/p&gt; </param> 
        /// <param name="invoiceAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param> 
        /// <param name="invoiceAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param> 
        /// <param name="invoiceAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param> 
        /// <param name="invoiceAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param> 
        /// <param name="invoiceAddressPhoneNumber">&lt;p&gt;Phone number&lt;/p&gt; </param> 
        /// <param name="invoiceAddressMobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param> 
        /// <param name="invoiceAddressEmail">&lt;p&gt;Email address&lt;/p&gt; </param> 
        /// <param name="shippingAddressName">&lt;p&gt;Name&lt;/p&gt; </param> 
        /// <param name="shippingAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param> 
        /// <param name="shippingAddressCompanyName">&lt;p&gt;Company name&lt;/p&gt; </param> 
        /// <param name="shippingAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param> 
        /// <param name="shippingAddressHouseNumber">&lt;p&gt;House number&lt;/p&gt; </param> 
        /// <param name="shippingAddressHouseExtension">&lt;p&gt;House extension&lt;/p&gt; </param> 
        /// <param name="shippingAddressCity">&lt;p&gt;City&lt;/p&gt; </param> 
        /// <param name="shippingAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param> 
        /// <param name="shippingAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param> 
        /// <param name="shippingAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param> 
        /// <param name="shippingAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param> 
        /// <param name="shippingAddressPhoneNumber">&lt;p&gt;Phone number&lt;/p&gt; </param> 
        /// <param name="shippingAddressMobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param> 
        /// <param name="shippingAddressEmail">&lt;p&gt;Email address&lt;/p&gt; </param> 
        /// <param name="shippingMethod">&lt;p&gt;Shipping method&lt;/p&gt; </param> 
        /// <param name="shippingCompany">&lt;p&gt;Shipping company&lt;/p&gt; </param> 
        /// <param name="shippingAmount">&lt;p&gt;Shipping price (incl. VAT)&lt;/p&gt; </param> 
        /// <param name="shippingVatRate">&lt;p&gt;VAT rate&lt;/p&gt; </param> 
        /// <param name="shippingTrackingNumber">&lt;p&gt;Shipping tracking number&lt;/p&gt; </param> 
        /// <param name="shippingTrackingUrl">&lt;p&gt;Shipping tracking url&lt;/p&gt; </param> 
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment PATCHPaymentsIdFormat (string acceptVersion, string authorization, int? id, int? basketQty, string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate, DateTime? deadlineAt, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName, string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension, string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion, string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber, string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName, string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet, string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity, string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode, string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber, string shippingAddressEmail, string shippingMethod, string shippingCompany, int? shippingAmount, float? shippingVatRate, string shippingTrackingNumber, string shippingTrackingUrl, Dictionary<string, string> variables)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHPaymentsIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHPaymentsIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHPaymentsIdFormat");
            
            // verify the required parameter 'basketQty' is set
            if (basketQty == null) throw new ApiException(400, "Missing required parameter 'basketQty' when calling PATCHPaymentsIdFormat");
            
            // verify the required parameter 'basketItemNo' is set
            if (basketItemNo == null) throw new ApiException(400, "Missing required parameter 'basketItemNo' when calling PATCHPaymentsIdFormat");
            
            // verify the required parameter 'basketItemName' is set
            if (basketItemName == null) throw new ApiException(400, "Missing required parameter 'basketItemName' when calling PATCHPaymentsIdFormat");
            
            // verify the required parameter 'basketItemPrice' is set
            if (basketItemPrice == null) throw new ApiException(400, "Missing required parameter 'basketItemPrice' when calling PATCHPaymentsIdFormat");
            
            // verify the required parameter 'basketVatRate' is set
            if (basketVatRate == null) throw new ApiException(400, "Missing required parameter 'basketVatRate' when calling PATCHPaymentsIdFormat");
            
    
            var path = "/payments/{id}";
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
if (basketQty != null) formParams.Add("basket[][qty]", ApiClient.ParameterToString(basketQty)); // form parameter
if (basketItemNo != null) formParams.Add("basket[][item_no]", ApiClient.ParameterToString(basketItemNo)); // form parameter
if (basketItemName != null) formParams.Add("basket[][item_name]", ApiClient.ParameterToString(basketItemName)); // form parameter
if (basketItemPrice != null) formParams.Add("basket[][item_price]", ApiClient.ParameterToString(basketItemPrice)); // form parameter
if (basketVatRate != null) formParams.Add("basket[][vat_rate]", ApiClient.ParameterToString(basketVatRate)); // form parameter
if (shippingMethod != null) formParams.Add("shipping[method]", ApiClient.ParameterToString(shippingMethod)); // form parameter
if (shippingCompany != null) formParams.Add("shipping[company]", ApiClient.ParameterToString(shippingCompany)); // form parameter
if (shippingAmount != null) formParams.Add("shipping[amount]", ApiClient.ParameterToString(shippingAmount)); // form parameter
if (shippingVatRate != null) formParams.Add("shipping[vat_rate]", ApiClient.ParameterToString(shippingVatRate)); // form parameter
if (shippingTrackingNumber != null) formParams.Add("shipping[tracking_number]", ApiClient.ParameterToString(shippingTrackingNumber)); // form parameter
if (shippingTrackingUrl != null) formParams.Add("shipping[tracking_url]", ApiClient.ParameterToString(shippingTrackingUrl)); // form parameter
if (variables != null) formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHPaymentsIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHPaymentsIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Update operation  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="operationId">&lt;p&gt;Operations id&lt;/p&gt; </param> 
        /// <param name="pending">&lt;p&gt;Aborts the operation. Only possible on capture, refund, recurring and cancel operations (false is the only allowed value)&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Operation</returns>            
        public QuickPayProtocolV10Operation PATCHPaymentsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId, bool? pending)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PATCHPaymentsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PATCHPaymentsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PATCHPaymentsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'operationId' is set
            if (operationId == null) throw new ApiException(400, "Missing required parameter 'operationId' when calling PATCHPaymentsIdOperationsOperationIdFormat");
            
            // verify the required parameter 'pending' is set
            if (pending == null) throw new ApiException(400, "Missing required parameter 'pending' when calling PATCHPaymentsIdOperationsOperationIdFormat");
            
    
            var path = "/payments/{id}/operations/{operation_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHPaymentsIdOperationsOperationIdFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PATCHPaymentsIdOperationsOperationIdFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Operation) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Operation), response.Headers);
        }
    
        /// <summary>
        /// Create payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="currency">&lt;p&gt;Currency&lt;/p&gt; </param> 
        /// <param name="orderId">&lt;p&gt;Unique order id(must be between 4-20 characters)&lt;/p&gt; </param> 
        /// <param name="basketQty">&lt;p&gt;Quantity&lt;/p&gt; </param> 
        /// <param name="basketItemNo">&lt;p&gt;Item reference number&lt;/p&gt; </param> 
        /// <param name="basketItemName">&lt;p&gt;Item name&lt;/p&gt; </param> 
        /// <param name="basketItemPrice">&lt;p&gt;Per item price (incl. VAT)&lt;/p&gt; </param> 
        /// <param name="basketVatRate">&lt;p&gt;VAT rate&lt;/p&gt; </param> 
        /// <param name="invoiceAddressName">&lt;p&gt;Name&lt;/p&gt; </param> 
        /// <param name="invoiceAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param> 
        /// <param name="invoiceAddressCompanyName">&lt;p&gt;Company name&lt;/p&gt; </param> 
        /// <param name="invoiceAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param> 
        /// <param name="invoiceAddressHouseNumber">&lt;p&gt;House number&lt;/p&gt; </param> 
        /// <param name="invoiceAddressHouseExtension">&lt;p&gt;House extension&lt;/p&gt; </param> 
        /// <param name="invoiceAddressCity">&lt;p&gt;City&lt;/p&gt; </param> 
        /// <param name="invoiceAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param> 
        /// <param name="invoiceAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param> 
        /// <param name="invoiceAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param> 
        /// <param name="invoiceAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param> 
        /// <param name="invoiceAddressPhoneNumber">&lt;p&gt;Phone number&lt;/p&gt; </param> 
        /// <param name="invoiceAddressMobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param> 
        /// <param name="invoiceAddressEmail">&lt;p&gt;Email address&lt;/p&gt; </param> 
        /// <param name="shippingAddressName">&lt;p&gt;Name&lt;/p&gt; </param> 
        /// <param name="shippingAddressAtt">&lt;p&gt;Att&lt;/p&gt; </param> 
        /// <param name="shippingAddressCompanyName">&lt;p&gt;Company name&lt;/p&gt; </param> 
        /// <param name="shippingAddressStreet">&lt;p&gt;Street&lt;/p&gt; </param> 
        /// <param name="shippingAddressHouseNumber">&lt;p&gt;House number&lt;/p&gt; </param> 
        /// <param name="shippingAddressHouseExtension">&lt;p&gt;House extension&lt;/p&gt; </param> 
        /// <param name="shippingAddressCity">&lt;p&gt;City&lt;/p&gt; </param> 
        /// <param name="shippingAddressZipCode">&lt;p&gt;Zip code&lt;/p&gt; </param> 
        /// <param name="shippingAddressRegion">&lt;p&gt;Region&lt;/p&gt; </param> 
        /// <param name="shippingAddressCountryCode">&lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt; </param> 
        /// <param name="shippingAddressVatNo">&lt;p&gt;VAT registration number&lt;/p&gt; </param> 
        /// <param name="shippingAddressPhoneNumber">&lt;p&gt;Phone number&lt;/p&gt; </param> 
        /// <param name="shippingAddressMobileNumber">&lt;p&gt;Mobile number&lt;/p&gt; </param> 
        /// <param name="shippingAddressEmail">&lt;p&gt;Email address&lt;/p&gt; </param> 
        /// <param name="brandingId">&lt;p&gt;Used branding id&lt;/p&gt; </param> 
        /// <param name="shippingMethod">&lt;p&gt;Shipping method&lt;/p&gt; </param> 
        /// <param name="shippingCompany">&lt;p&gt;Shipping company&lt;/p&gt; </param> 
        /// <param name="shippingAmount">&lt;p&gt;Shipping price (incl. VAT)&lt;/p&gt; </param> 
        /// <param name="shippingVatRate">&lt;p&gt;VAT rate&lt;/p&gt; </param> 
        /// <param name="shippingTrackingNumber">&lt;p&gt;Shipping tracking number&lt;/p&gt; </param> 
        /// <param name="shippingTrackingUrl">&lt;p&gt;Shipping tracking url&lt;/p&gt; </param> 
        /// <param name="shopsystemName">&lt;p&gt;Shop system module name&lt;/p&gt; </param> 
        /// <param name="shopsystemVersion">&lt;p&gt;Shop system module version&lt;/p&gt; </param> 
        /// <param name="variables">&lt;p&gt;Custom variables&lt;/p&gt; </param> 
        /// <param name="textOnStatement">&lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment POSTPaymentsFormat (string acceptVersion, string authorization, string currency, string orderId, int? basketQty, string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate, string invoiceAddressName, string invoiceAddressAtt, string invoiceAddressCompanyName, string invoiceAddressStreet, string invoiceAddressHouseNumber, string invoiceAddressHouseExtension, string invoiceAddressCity, string invoiceAddressZipCode, string invoiceAddressRegion, string invoiceAddressCountryCode, string invoiceAddressVatNo, string invoiceAddressPhoneNumber, string invoiceAddressMobileNumber, string invoiceAddressEmail, string shippingAddressName, string shippingAddressAtt, string shippingAddressCompanyName, string shippingAddressStreet, string shippingAddressHouseNumber, string shippingAddressHouseExtension, string shippingAddressCity, string shippingAddressZipCode, string shippingAddressRegion, string shippingAddressCountryCode, string shippingAddressVatNo, string shippingAddressPhoneNumber, string shippingAddressMobileNumber, string shippingAddressEmail, int? brandingId, string shippingMethod, string shippingCompany, int? shippingAmount, float? shippingVatRate, string shippingTrackingNumber, string shippingTrackingUrl, string shopsystemName, string shopsystemVersion, Dictionary<string, string> variables, string textOnStatement)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentsFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentsFormat");
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling POSTPaymentsFormat");
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling POSTPaymentsFormat");
            
            // verify the required parameter 'basketQty' is set
            if (basketQty == null) throw new ApiException(400, "Missing required parameter 'basketQty' when calling POSTPaymentsFormat");
            
            // verify the required parameter 'basketItemNo' is set
            if (basketItemNo == null) throw new ApiException(400, "Missing required parameter 'basketItemNo' when calling POSTPaymentsFormat");
            
            // verify the required parameter 'basketItemName' is set
            if (basketItemName == null) throw new ApiException(400, "Missing required parameter 'basketItemName' when calling POSTPaymentsFormat");
            
            // verify the required parameter 'basketItemPrice' is set
            if (basketItemPrice == null) throw new ApiException(400, "Missing required parameter 'basketItemPrice' when calling POSTPaymentsFormat");
            
            // verify the required parameter 'basketVatRate' is set
            if (basketVatRate == null) throw new ApiException(400, "Missing required parameter 'basketVatRate' when calling POSTPaymentsFormat");
            
    
            var path = "/payments";
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
if (brandingId != null) formParams.Add("branding_id", ApiClient.ParameterToString(brandingId)); // form parameter
if (basketQty != null) formParams.Add("basket[][qty]", ApiClient.ParameterToString(basketQty)); // form parameter
if (basketItemNo != null) formParams.Add("basket[][item_no]", ApiClient.ParameterToString(basketItemNo)); // form parameter
if (basketItemName != null) formParams.Add("basket[][item_name]", ApiClient.ParameterToString(basketItemName)); // form parameter
if (basketItemPrice != null) formParams.Add("basket[][item_price]", ApiClient.ParameterToString(basketItemPrice)); // form parameter
if (basketVatRate != null) formParams.Add("basket[][vat_rate]", ApiClient.ParameterToString(basketVatRate)); // form parameter
if (shippingMethod != null) formParams.Add("shipping[method]", ApiClient.ParameterToString(shippingMethod)); // form parameter
if (shippingCompany != null) formParams.Add("shipping[company]", ApiClient.ParameterToString(shippingCompany)); // form parameter
if (shippingAmount != null) formParams.Add("shipping[amount]", ApiClient.ParameterToString(shippingAmount)); // form parameter
if (shippingVatRate != null) formParams.Add("shipping[vat_rate]", ApiClient.ParameterToString(shippingVatRate)); // form parameter
if (shippingTrackingNumber != null) formParams.Add("shipping[tracking_number]", ApiClient.ParameterToString(shippingTrackingNumber)); // form parameter
if (shippingTrackingUrl != null) formParams.Add("shipping[tracking_url]", ApiClient.ParameterToString(shippingTrackingUrl)); // form parameter
if (shopsystemName != null) formParams.Add("shopsystem[name]", ApiClient.ParameterToString(shopsystemName)); // form parameter
if (shopsystemVersion != null) formParams.Add("shopsystem[version]", ApiClient.ParameterToString(shopsystemVersion)); // form parameter
if (variables != null) formParams.Add("variables", ApiClient.ParameterToString(variables)); // form parameter
if (textOnStatement != null) formParams.Add("text_on_statement", ApiClient.ParameterToString(textOnStatement)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Authorize payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
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
        /// <param name="autoCapture">&lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param> 
        /// <param name="autofee">&lt;p&gt;When true, fee is calculated and added to the given amount. Default is merchant autofee&lt;/p&gt; </param> 
        /// <param name="customerIp">&lt;p&gt;Customer IP&lt;/p&gt; </param> 
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param> 
        /// <param name="zeroAuth">&lt;p&gt;(Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment POSTPaymentsIdAuthorizeFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, Dictionary<string, string> cardApplePayToken, Dictionary<string, string> cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, bool? autoCapture, string acquirer, bool? autofee, string customerIp, Dictionary<string, string> extras, bool? zeroAuth)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentsIdAuthorizeFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentsIdAuthorizeFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdAuthorizeFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTPaymentsIdAuthorizeFormat");
            
    
            var path = "/payments/{id}/authorize";
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
if (autoCapture != null) formParams.Add("auto_capture", ApiClient.ParameterToString(autoCapture)); // form parameter
if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
if (autofee != null) formParams.Add("autofee", ApiClient.ParameterToString(autofee)); // form parameter
if (customerIp != null) formParams.Add("customer_ip", ApiClient.ParameterToString(customerIp)); // form parameter
if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter
if (zeroAuth != null) formParams.Add("zero_auth", ApiClient.ParameterToString(zeroAuth)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdAuthorizeFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdAuthorizeFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Cancel payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param> 
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment POSTPaymentsIdCancelFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, bool? synchronized)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentsIdCancelFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentsIdCancelFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdCancelFormat");
            
    
            var path = "/payments/{id}/cancel";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdCancelFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdCancelFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Capture payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount&lt;/p&gt; </param> 
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param> 
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param> 
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment POSTPaymentsIdCaptureFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, Dictionary<string, string> extras)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentsIdCaptureFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentsIdCaptureFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdCaptureFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTPaymentsIdCaptureFormat");
            
    
            var path = "/payments/{id}/capture";
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
if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdCaptureFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdCaptureFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Create fraud confirmation report  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param> 
        /// <param name="description"> </param> 
        /// <returns>QuickPayProtocolV10FraudReport</returns>            
        public QuickPayProtocolV10FraudReport POSTPaymentsIdFraudReportFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, string description)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentsIdFraudReportFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentsIdFraudReportFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdFraudReportFormat");
            
    
            var path = "/payments/{id}/fraud-report";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdFraudReportFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdFraudReportFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10FraudReport) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10FraudReport), response.Headers);
        }
    
        /// <summary>
        /// Refund payment  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount&lt;/p&gt; </param> 
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param> 
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param> 
        /// <param name="vatRate">&lt;p&gt;Vate rate&lt;/p&gt; </param> 
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment POSTPaymentsIdRefundFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, Dictionary<string, string> extras)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentsIdRefundFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentsIdRefundFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdRefundFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTPaymentsIdRefundFormat");
            
    
            var path = "/payments/{id}/refund";
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
if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdRefundFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdRefundFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Renew authorization  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param> 
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment POSTPaymentsIdRenewFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl, bool? synchronized)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentsIdRenewFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentsIdRenewFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdRenewFormat");
            
    
            var path = "/payments/{id}/renew";
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
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdRenewFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdRenewFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Create payment session  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Payment id&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount&lt;/p&gt; </param> 
        /// <param name="quickPayCallbackUrl">&lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt; </param> 
        /// <param name="synchronized">&lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt; </param> 
        /// <param name="autoCapture">&lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt; </param> 
        /// <param name="autofee">&lt;p&gt;When true, fee is calculated and added to the given amount. Default is merchant autofee&lt;/p&gt; </param> 
        /// <param name="customerIp">&lt;p&gt;Customer IP&lt;/p&gt; </param> 
        /// <param name="personFirstName">&lt;p&gt;Person first name&lt;/p&gt; </param> 
        /// <param name="personLastName">&lt;p&gt;Person last name&lt;/p&gt; </param> 
        /// <param name="personEmail">&lt;p&gt;Person email&lt;/p&gt; </param> 
        /// <param name="extras">&lt;p&gt;Additional acquirer specific params&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10Payment</returns>            
        public QuickPayProtocolV10Payment POSTPaymentsIdSessionFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, bool? autoCapture, string acquirer, bool? autofee, string customerIp, string personFirstName, string personLastName, string personEmail, Dictionary<string, string> extras)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling POSTPaymentsIdSessionFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling POSTPaymentsIdSessionFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling POSTPaymentsIdSessionFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling POSTPaymentsIdSessionFormat");
            
    
            var path = "/payments/{id}/session";
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
if (autoCapture != null) formParams.Add("auto_capture", ApiClient.ParameterToString(autoCapture)); // form parameter
if (acquirer != null) formParams.Add("acquirer", ApiClient.ParameterToString(acquirer)); // form parameter
if (autofee != null) formParams.Add("autofee", ApiClient.ParameterToString(autofee)); // form parameter
if (customerIp != null) formParams.Add("customer_ip", ApiClient.ParameterToString(customerIp)); // form parameter
if (personFirstName != null) formParams.Add("person[first_name]", ApiClient.ParameterToString(personFirstName)); // form parameter
if (personLastName != null) formParams.Add("person[last_name]", ApiClient.ParameterToString(personLastName)); // form parameter
if (personEmail != null) formParams.Add("person[email]", ApiClient.ParameterToString(personEmail)); // form parameter
if (extras != null) formParams.Add("extras", ApiClient.ParameterToString(extras)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdSessionFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling POSTPaymentsIdSessionFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10Payment) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10Payment), response.Headers);
        }
    
        /// <summary>
        /// Create or update a payment link  
        /// </summary>
        /// <param name="acceptVersion">&lt;p&gt;Specify the version of the API&lt;/p&gt; </param> 
        /// <param name="authorization">&lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt; </param> 
        /// <param name="id">&lt;p&gt;Transaction id&lt;/p&gt; </param> 
        /// <param name="amount">&lt;p&gt;Amount to authorize&lt;/p&gt; </param> 
        /// <param name="agreementId">&lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt; </param> 
        /// <param name="language">&lt;p&gt;Language&lt;/p&gt; </param> 
        /// <param name="continueUrl">&lt;p&gt;Url that cardholder is redirected to after authorize&lt;/p&gt; </param> 
        /// <param name="cancelUrl">&lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt; </param> 
        /// <param name="callbackUrl">&lt;p&gt;Endpoint for async callback&lt;/p&gt; </param> 
        /// <param name="paymentMethods">&lt;p&gt;Limit payment methods&lt;/p&gt; </param> 
        /// <param name="autoFee">&lt;p&gt;Add acquirer fee to amount. Default is merchant autofee&lt;/p&gt; </param> 
        /// <param name="brandingId">&lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt; </param> 
        /// <param name="googleAnalyticsTrackingId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param> 
        /// <param name="googleAnalyticsClientId">&lt;p&gt;Send events to Google Analytics&lt;/p&gt; </param> 
        /// <param name="acquirer">&lt;p&gt;Force usage of the given acquirer&lt;/p&gt; </param> 
        /// <param name="deadline">&lt;p&gt;Set a deadline in seconds for the cardholder to complete&lt;/p&gt; </param> 
        /// <param name="framed">&lt;p&gt;Allow opening in iframe&lt;/p&gt; </param> 
        /// <param name="brandingConfig">&lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt; </param> 
        /// <param name="customerEmail">&lt;p&gt;Required for PayPal. Email of customer.&lt;/p&gt; </param> 
        /// <param name="invoiceAddressSelection">&lt;p&gt;Get customer invoice address via acquirer (Currently MobilePay and PayPal only)&lt;/p&gt; </param> 
        /// <param name="shippingAddressSelection">&lt;p&gt;Get customer shipping address via acquirer (Currently MobilePay and PayPal only)&lt;/p&gt; </param> 
        /// <param name="autoCapture">&lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt; </param> 
        /// <returns>QuickPayProtocolV10PaymentLinkUrl</returns>            
        public QuickPayProtocolV10PaymentLinkUrl PUTPaymentsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, bool? autoFee, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, int? deadline, bool? framed, Dictionary<string, string> brandingConfig, string customerEmail, bool? invoiceAddressSelection, bool? shippingAddressSelection, bool? autoCapture)
        {
            
            // verify the required parameter 'acceptVersion' is set
            if (acceptVersion == null) throw new ApiException(400, "Missing required parameter 'acceptVersion' when calling PUTPaymentsIdLinkFormat");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PUTPaymentsIdLinkFormat");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PUTPaymentsIdLinkFormat");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling PUTPaymentsIdLinkFormat");
            
    
            var path = "/payments/{id}/link";
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
if (autoCapture != null) formParams.Add("auto_capture", ApiClient.ParameterToString(autoCapture)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTPaymentsIdLinkFormat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PUTPaymentsIdLinkFormat: " + response.ErrorMessage, response.ErrorMessage);
    
            return (QuickPayProtocolV10PaymentLinkUrl) ApiClient.Deserialize(response.Content, typeof(QuickPayProtocolV10PaymentLinkUrl), response.Headers);
        }
    
    }
}
