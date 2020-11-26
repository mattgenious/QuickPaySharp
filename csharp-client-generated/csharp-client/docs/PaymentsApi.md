# IO.Swagger.Api.PaymentsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETEPaymentsIdLinkFormat**](PaymentsApi.md#deletepaymentsidlinkformat) | **DELETE** /payments/{id}/link | Delete payment link
[**GETPaymentsFormat**](PaymentsApi.md#getpaymentsformat) | **GET** /payments | Get all payments
[**GETPaymentsIdFormat**](PaymentsApi.md#getpaymentsidformat) | **GET** /payments/{id} | Get payment
[**GETPaymentsIdOperationsOperationIdFormat**](PaymentsApi.md#getpaymentsidoperationsoperationidformat) | **GET** /payments/{id}/operations/{operation_id} | Get Operation
[**PATCHPaymentsIdFormat**](PaymentsApi.md#patchpaymentsidformat) | **PATCH** /payments/{id} | Update payment
[**PATCHPaymentsIdOperationsOperationIdFormat**](PaymentsApi.md#patchpaymentsidoperationsoperationidformat) | **PATCH** /payments/{id}/operations/{operation_id} | Update operation
[**POSTPaymentsFormat**](PaymentsApi.md#postpaymentsformat) | **POST** /payments | Create payment
[**POSTPaymentsIdAuthorizeFormat**](PaymentsApi.md#postpaymentsidauthorizeformat) | **POST** /payments/{id}/authorize | Authorize payment
[**POSTPaymentsIdCancelFormat**](PaymentsApi.md#postpaymentsidcancelformat) | **POST** /payments/{id}/cancel | Cancel payment
[**POSTPaymentsIdCaptureFormat**](PaymentsApi.md#postpaymentsidcaptureformat) | **POST** /payments/{id}/capture | Capture payment
[**POSTPaymentsIdFraudReportFormat**](PaymentsApi.md#postpaymentsidfraudreportformat) | **POST** /payments/{id}/fraud-report | Create fraud confirmation report
[**POSTPaymentsIdRefundFormat**](PaymentsApi.md#postpaymentsidrefundformat) | **POST** /payments/{id}/refund | Refund payment
[**POSTPaymentsIdRenewFormat**](PaymentsApi.md#postpaymentsidrenewformat) | **POST** /payments/{id}/renew | Renew authorization
[**POSTPaymentsIdSessionFormat**](PaymentsApi.md#postpaymentsidsessionformat) | **POST** /payments/{id}/session | Create payment session
[**PUTPaymentsIdLinkFormat**](PaymentsApi.md#putpaymentsidlinkformat) | **PUT** /payments/{id}/link | Create or update a payment link


<a name="deletepaymentsidlinkformat"></a>
# **DELETEPaymentsIdLinkFormat**
> void DELETEPaymentsIdLinkFormat (string acceptVersion, string authorization, int? id)

Delete payment link

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEPaymentsIdLinkFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Transaction id</p> 

            try
            {
                // Delete payment link
                apiInstance.DELETEPaymentsIdLinkFormat(acceptVersion, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.DELETEPaymentsIdLinkFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Transaction id&lt;/p&gt;  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsformat"></a>
# **GETPaymentsFormat**
> List<QuickPayProtocolV10Payment> GETPaymentsFormat (string acceptVersion, string authorization, int? dateYear = null, int? dateMonth = null, int? dateDay = null, int? dateHour = null, int? dateMinute = null, string timestamp = null, string minTime = null, string maxTime = null, int? operationsSize = null, bool? accepted = null, string orderId = null, string state = null, int? id = null, string acquirer = null, bool? fraudSuspected = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null)

Get all payments

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETPaymentsFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var dateYear = 56;  // int? | <p>Year</p>  (optional) 
            var dateMonth = 56;  // int? | <p>Month</p>  (optional) 
            var dateDay = 56;  // int? | <p>Day of the month</p>  (optional) 
            var dateHour = 56;  // int? | <p>Hour of the day</p>  (optional) 
            var dateMinute = 56;  // int? | <p>Minute of the hour</p>  (optional) 
            var timestamp = timestamp_example;  // string | <p>Timestamp field</p>  (optional)  (default to created_at)
            var minTime = minTime_example;  // string | <p>Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”</p>  (optional) 
            var maxTime = maxTime_example;  // string | <p>Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”</p>  (optional) 
            var operationsSize = 56;  // int? | <p>Maximum number of operations to retrieve</p>  (optional) 
            var accepted = true;  // bool? | <p>Return accepted payments</p>  (optional) 
            var orderId = orderId_example;  // string | <p>Find by order_id</p>  (optional) 
            var state = state_example;  // string | <p>Find by state</p>  (optional) 
            var id = 56;  // int? | <p>Find by transaction id</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>Filter by acquirer</p>  (optional) 
            var fraudSuspected = true;  // bool? | <p>Filter by suspected fraud</p>  (optional) 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to desc)
            var pageKey = pageKey_example;  // string |   (optional) 

            try
            {
                // Get all payments
                List&lt;QuickPayProtocolV10Payment&gt; result = apiInstance.GETPaymentsFormat(acceptVersion, authorization, dateYear, dateMonth, dateDay, dateHour, dateMinute, timestamp, minTime, maxTime, operationsSize, accepted, orderId, state, id, acquirer, fraudSuspected, page, pageSize, sortBy, sortDir, pageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GETPaymentsFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **dateYear** | **int?**| &lt;p&gt;Year&lt;/p&gt;  | [optional] 
 **dateMonth** | **int?**| &lt;p&gt;Month&lt;/p&gt;  | [optional] 
 **dateDay** | **int?**| &lt;p&gt;Day of the month&lt;/p&gt;  | [optional] 
 **dateHour** | **int?**| &lt;p&gt;Hour of the day&lt;/p&gt;  | [optional] 
 **dateMinute** | **int?**| &lt;p&gt;Minute of the hour&lt;/p&gt;  | [optional] 
 **timestamp** | **string**| &lt;p&gt;Timestamp field&lt;/p&gt;  | [optional] [default to created_at]
 **minTime** | **string**| &lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt;  | [optional] 
 **maxTime** | **string**| &lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt;  | [optional] 
 **operationsSize** | **int?**| &lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt;  | [optional] 
 **accepted** | **bool?**| &lt;p&gt;Return accepted payments&lt;/p&gt;  | [optional] 
 **orderId** | **string**| &lt;p&gt;Find by order_id&lt;/p&gt;  | [optional] 
 **state** | **string**| &lt;p&gt;Find by state&lt;/p&gt;  | [optional] 
 **id** | **int?**| &lt;p&gt;Find by transaction id&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;Filter by acquirer&lt;/p&gt;  | [optional] 
 **fraudSuspected** | **bool?**| &lt;p&gt;Filter by suspected fraud&lt;/p&gt;  | [optional] 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to id]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to desc]
 **pageKey** | **string**|   | [optional] 

### Return type

[**List<QuickPayProtocolV10Payment>**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsidformat"></a>
# **GETPaymentsIdFormat**
> QuickPayProtocolV10Payment GETPaymentsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize = null)

Get payment

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETPaymentsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var operationsSize = 56;  // int? | <p>Maximum number of operations to retrieve</p>  (optional) 

            try
            {
                // Get payment
                QuickPayProtocolV10Payment result = apiInstance.GETPaymentsIdFormat(acceptVersion, authorization, id, operationsSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GETPaymentsIdFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **operationsSize** | **int?**| &lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsidoperationsoperationidformat"></a>
# **GETPaymentsIdOperationsOperationIdFormat**
> QuickPayProtocolV10Operation GETPaymentsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId)

Get Operation

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETPaymentsIdOperationsOperationIdFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var operationId = 56;  // int? | <p>Operations id</p> 

            try
            {
                // Get Operation
                QuickPayProtocolV10Operation result = apiInstance.GETPaymentsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GETPaymentsIdOperationsOperationIdFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **operationId** | **int?**| &lt;p&gt;Operations id&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10Operation**](QuickPayProtocolV10Operation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpaymentsidformat"></a>
# **PATCHPaymentsIdFormat**
> QuickPayProtocolV10Payment PATCHPaymentsIdFormat (string acceptVersion, string authorization, int? id, int? basketQty, string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate, DateTime? deadlineAt = null, string invoiceAddressName = null, string invoiceAddressAtt = null, string invoiceAddressCompanyName = null, string invoiceAddressStreet = null, string invoiceAddressHouseNumber = null, string invoiceAddressHouseExtension = null, string invoiceAddressCity = null, string invoiceAddressZipCode = null, string invoiceAddressRegion = null, string invoiceAddressCountryCode = null, string invoiceAddressVatNo = null, string invoiceAddressPhoneNumber = null, string invoiceAddressMobileNumber = null, string invoiceAddressEmail = null, string shippingAddressName = null, string shippingAddressAtt = null, string shippingAddressCompanyName = null, string shippingAddressStreet = null, string shippingAddressHouseNumber = null, string shippingAddressHouseExtension = null, string shippingAddressCity = null, string shippingAddressZipCode = null, string shippingAddressRegion = null, string shippingAddressCountryCode = null, string shippingAddressVatNo = null, string shippingAddressPhoneNumber = null, string shippingAddressMobileNumber = null, string shippingAddressEmail = null, string shippingMethod = null, string shippingCompany = null, int? shippingAmount = null, float? shippingVatRate = null, string shippingTrackingNumber = null, string shippingTrackingUrl = null, Dictionary<string, string> variables = null)

Update payment

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHPaymentsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var basketQty = 56;  // int? | <p>Quantity</p> 
            var basketItemNo = basketItemNo_example;  // string | <p>Item reference number</p> 
            var basketItemName = basketItemName_example;  // string | <p>Item name</p> 
            var basketItemPrice = 56;  // int? | <p>Per item price (incl. VAT)</p> 
            var basketVatRate = 3.4;  // float? | <p>VAT rate</p> 
            var deadlineAt = 2013-10-20T19:20:30+01:00;  // DateTime? | <p>Payment must be authorized before this time</p>  (optional) 
            var invoiceAddressName = invoiceAddressName_example;  // string | <p>Name</p>  (optional) 
            var invoiceAddressAtt = invoiceAddressAtt_example;  // string | <p>Att</p>  (optional) 
            var invoiceAddressCompanyName = invoiceAddressCompanyName_example;  // string | <p>Company name</p>  (optional) 
            var invoiceAddressStreet = invoiceAddressStreet_example;  // string | <p>Street</p>  (optional) 
            var invoiceAddressHouseNumber = invoiceAddressHouseNumber_example;  // string | <p>House number</p>  (optional) 
            var invoiceAddressHouseExtension = invoiceAddressHouseExtension_example;  // string | <p>House extension</p>  (optional) 
            var invoiceAddressCity = invoiceAddressCity_example;  // string | <p>City</p>  (optional) 
            var invoiceAddressZipCode = invoiceAddressZipCode_example;  // string | <p>Zip code</p>  (optional) 
            var invoiceAddressRegion = invoiceAddressRegion_example;  // string | <p>Region</p>  (optional) 
            var invoiceAddressCountryCode = invoiceAddressCountryCode_example;  // string | <p>Three letter country code according to ISO 3166-1 Alpha-3</p>  (optional) 
            var invoiceAddressVatNo = invoiceAddressVatNo_example;  // string | <p>VAT registration number</p>  (optional) 
            var invoiceAddressPhoneNumber = invoiceAddressPhoneNumber_example;  // string | <p>Phone number</p>  (optional) 
            var invoiceAddressMobileNumber = invoiceAddressMobileNumber_example;  // string | <p>Mobile number</p>  (optional) 
            var invoiceAddressEmail = invoiceAddressEmail_example;  // string | <p>Email address</p>  (optional) 
            var shippingAddressName = shippingAddressName_example;  // string | <p>Name</p>  (optional) 
            var shippingAddressAtt = shippingAddressAtt_example;  // string | <p>Att</p>  (optional) 
            var shippingAddressCompanyName = shippingAddressCompanyName_example;  // string | <p>Company name</p>  (optional) 
            var shippingAddressStreet = shippingAddressStreet_example;  // string | <p>Street</p>  (optional) 
            var shippingAddressHouseNumber = shippingAddressHouseNumber_example;  // string | <p>House number</p>  (optional) 
            var shippingAddressHouseExtension = shippingAddressHouseExtension_example;  // string | <p>House extension</p>  (optional) 
            var shippingAddressCity = shippingAddressCity_example;  // string | <p>City</p>  (optional) 
            var shippingAddressZipCode = shippingAddressZipCode_example;  // string | <p>Zip code</p>  (optional) 
            var shippingAddressRegion = shippingAddressRegion_example;  // string | <p>Region</p>  (optional) 
            var shippingAddressCountryCode = shippingAddressCountryCode_example;  // string | <p>Three letter country code according to ISO 3166-1 Alpha-3</p>  (optional) 
            var shippingAddressVatNo = shippingAddressVatNo_example;  // string | <p>VAT registration number</p>  (optional) 
            var shippingAddressPhoneNumber = shippingAddressPhoneNumber_example;  // string | <p>Phone number</p>  (optional) 
            var shippingAddressMobileNumber = shippingAddressMobileNumber_example;  // string | <p>Mobile number</p>  (optional) 
            var shippingAddressEmail = shippingAddressEmail_example;  // string | <p>Email address</p>  (optional) 
            var shippingMethod = shippingMethod_example;  // string | <p>Shipping method</p>  (optional) 
            var shippingCompany = shippingCompany_example;  // string | <p>Shipping company</p>  (optional) 
            var shippingAmount = 56;  // int? | <p>Shipping price (incl. VAT)</p>  (optional) 
            var shippingVatRate = 3.4;  // float? | <p>VAT rate</p>  (optional) 
            var shippingTrackingNumber = shippingTrackingNumber_example;  // string | <p>Shipping tracking number</p>  (optional) 
            var shippingTrackingUrl = shippingTrackingUrl_example;  // string | <p>Shipping tracking url</p>  (optional) 
            var variables = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Custom variables</p>  (optional) 

            try
            {
                // Update payment
                QuickPayProtocolV10Payment result = apiInstance.PATCHPaymentsIdFormat(acceptVersion, authorization, id, basketQty, basketItemNo, basketItemName, basketItemPrice, basketVatRate, deadlineAt, invoiceAddressName, invoiceAddressAtt, invoiceAddressCompanyName, invoiceAddressStreet, invoiceAddressHouseNumber, invoiceAddressHouseExtension, invoiceAddressCity, invoiceAddressZipCode, invoiceAddressRegion, invoiceAddressCountryCode, invoiceAddressVatNo, invoiceAddressPhoneNumber, invoiceAddressMobileNumber, invoiceAddressEmail, shippingAddressName, shippingAddressAtt, shippingAddressCompanyName, shippingAddressStreet, shippingAddressHouseNumber, shippingAddressHouseExtension, shippingAddressCity, shippingAddressZipCode, shippingAddressRegion, shippingAddressCountryCode, shippingAddressVatNo, shippingAddressPhoneNumber, shippingAddressMobileNumber, shippingAddressEmail, shippingMethod, shippingCompany, shippingAmount, shippingVatRate, shippingTrackingNumber, shippingTrackingUrl, variables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.PATCHPaymentsIdFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **basketQty** | **int?**| &lt;p&gt;Quantity&lt;/p&gt;  | 
 **basketItemNo** | **string**| &lt;p&gt;Item reference number&lt;/p&gt;  | 
 **basketItemName** | **string**| &lt;p&gt;Item name&lt;/p&gt;  | 
 **basketItemPrice** | **int?**| &lt;p&gt;Per item price (incl. VAT)&lt;/p&gt;  | 
 **basketVatRate** | **float?**| &lt;p&gt;VAT rate&lt;/p&gt;  | 
 **deadlineAt** | **DateTime?**| &lt;p&gt;Payment must be authorized before this time&lt;/p&gt;  | [optional] 
 **invoiceAddressName** | **string**| &lt;p&gt;Name&lt;/p&gt;  | [optional] 
 **invoiceAddressAtt** | **string**| &lt;p&gt;Att&lt;/p&gt;  | [optional] 
 **invoiceAddressCompanyName** | **string**| &lt;p&gt;Company name&lt;/p&gt;  | [optional] 
 **invoiceAddressStreet** | **string**| &lt;p&gt;Street&lt;/p&gt;  | [optional] 
 **invoiceAddressHouseNumber** | **string**| &lt;p&gt;House number&lt;/p&gt;  | [optional] 
 **invoiceAddressHouseExtension** | **string**| &lt;p&gt;House extension&lt;/p&gt;  | [optional] 
 **invoiceAddressCity** | **string**| &lt;p&gt;City&lt;/p&gt;  | [optional] 
 **invoiceAddressZipCode** | **string**| &lt;p&gt;Zip code&lt;/p&gt;  | [optional] 
 **invoiceAddressRegion** | **string**| &lt;p&gt;Region&lt;/p&gt;  | [optional] 
 **invoiceAddressCountryCode** | **string**| &lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt;  | [optional] 
 **invoiceAddressVatNo** | **string**| &lt;p&gt;VAT registration number&lt;/p&gt;  | [optional] 
 **invoiceAddressPhoneNumber** | **string**| &lt;p&gt;Phone number&lt;/p&gt;  | [optional] 
 **invoiceAddressMobileNumber** | **string**| &lt;p&gt;Mobile number&lt;/p&gt;  | [optional] 
 **invoiceAddressEmail** | **string**| &lt;p&gt;Email address&lt;/p&gt;  | [optional] 
 **shippingAddressName** | **string**| &lt;p&gt;Name&lt;/p&gt;  | [optional] 
 **shippingAddressAtt** | **string**| &lt;p&gt;Att&lt;/p&gt;  | [optional] 
 **shippingAddressCompanyName** | **string**| &lt;p&gt;Company name&lt;/p&gt;  | [optional] 
 **shippingAddressStreet** | **string**| &lt;p&gt;Street&lt;/p&gt;  | [optional] 
 **shippingAddressHouseNumber** | **string**| &lt;p&gt;House number&lt;/p&gt;  | [optional] 
 **shippingAddressHouseExtension** | **string**| &lt;p&gt;House extension&lt;/p&gt;  | [optional] 
 **shippingAddressCity** | **string**| &lt;p&gt;City&lt;/p&gt;  | [optional] 
 **shippingAddressZipCode** | **string**| &lt;p&gt;Zip code&lt;/p&gt;  | [optional] 
 **shippingAddressRegion** | **string**| &lt;p&gt;Region&lt;/p&gt;  | [optional] 
 **shippingAddressCountryCode** | **string**| &lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt;  | [optional] 
 **shippingAddressVatNo** | **string**| &lt;p&gt;VAT registration number&lt;/p&gt;  | [optional] 
 **shippingAddressPhoneNumber** | **string**| &lt;p&gt;Phone number&lt;/p&gt;  | [optional] 
 **shippingAddressMobileNumber** | **string**| &lt;p&gt;Mobile number&lt;/p&gt;  | [optional] 
 **shippingAddressEmail** | **string**| &lt;p&gt;Email address&lt;/p&gt;  | [optional] 
 **shippingMethod** | **string**| &lt;p&gt;Shipping method&lt;/p&gt;  | [optional] 
 **shippingCompany** | **string**| &lt;p&gt;Shipping company&lt;/p&gt;  | [optional] 
 **shippingAmount** | **int?**| &lt;p&gt;Shipping price (incl. VAT)&lt;/p&gt;  | [optional] 
 **shippingVatRate** | **float?**| &lt;p&gt;VAT rate&lt;/p&gt;  | [optional] 
 **shippingTrackingNumber** | **string**| &lt;p&gt;Shipping tracking number&lt;/p&gt;  | [optional] 
 **shippingTrackingUrl** | **string**| &lt;p&gt;Shipping tracking url&lt;/p&gt;  | [optional] 
 **variables** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;Custom variables&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpaymentsidoperationsoperationidformat"></a>
# **PATCHPaymentsIdOperationsOperationIdFormat**
> QuickPayProtocolV10Operation PATCHPaymentsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId, bool? pending)

Update operation

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHPaymentsIdOperationsOperationIdFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var operationId = 56;  // int? | <p>Operations id</p> 
            var pending = true;  // bool? | <p>Aborts the operation. Only possible on capture, refund, recurring and cancel operations (false is the only allowed value)</p> 

            try
            {
                // Update operation
                QuickPayProtocolV10Operation result = apiInstance.PATCHPaymentsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId, pending);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.PATCHPaymentsIdOperationsOperationIdFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **operationId** | **int?**| &lt;p&gt;Operations id&lt;/p&gt;  | 
 **pending** | **bool?**| &lt;p&gt;Aborts the operation. Only possible on capture, refund, recurring and cancel operations (false is the only allowed value)&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10Operation**](QuickPayProtocolV10Operation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsformat"></a>
# **POSTPaymentsFormat**
> QuickPayProtocolV10Payment POSTPaymentsFormat (string acceptVersion, string authorization, string currency, string orderId, int? basketQty, string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate, string invoiceAddressName = null, string invoiceAddressAtt = null, string invoiceAddressCompanyName = null, string invoiceAddressStreet = null, string invoiceAddressHouseNumber = null, string invoiceAddressHouseExtension = null, string invoiceAddressCity = null, string invoiceAddressZipCode = null, string invoiceAddressRegion = null, string invoiceAddressCountryCode = null, string invoiceAddressVatNo = null, string invoiceAddressPhoneNumber = null, string invoiceAddressMobileNumber = null, string invoiceAddressEmail = null, string shippingAddressName = null, string shippingAddressAtt = null, string shippingAddressCompanyName = null, string shippingAddressStreet = null, string shippingAddressHouseNumber = null, string shippingAddressHouseExtension = null, string shippingAddressCity = null, string shippingAddressZipCode = null, string shippingAddressRegion = null, string shippingAddressCountryCode = null, string shippingAddressVatNo = null, string shippingAddressPhoneNumber = null, string shippingAddressMobileNumber = null, string shippingAddressEmail = null, int? brandingId = null, string shippingMethod = null, string shippingCompany = null, int? shippingAmount = null, float? shippingVatRate = null, string shippingTrackingNumber = null, string shippingTrackingUrl = null, string shopsystemName = null, string shopsystemVersion = null, Dictionary<string, string> variables = null, string textOnStatement = null)

Create payment

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentsFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var currency = currency_example;  // string | <p>Currency</p> 
            var orderId = orderId_example;  // string | <p>Unique order id(must be between 4-20 characters)</p> 
            var basketQty = 56;  // int? | <p>Quantity</p> 
            var basketItemNo = basketItemNo_example;  // string | <p>Item reference number</p> 
            var basketItemName = basketItemName_example;  // string | <p>Item name</p> 
            var basketItemPrice = 56;  // int? | <p>Per item price (incl. VAT)</p> 
            var basketVatRate = 3.4;  // float? | <p>VAT rate</p> 
            var invoiceAddressName = invoiceAddressName_example;  // string | <p>Name</p>  (optional) 
            var invoiceAddressAtt = invoiceAddressAtt_example;  // string | <p>Att</p>  (optional) 
            var invoiceAddressCompanyName = invoiceAddressCompanyName_example;  // string | <p>Company name</p>  (optional) 
            var invoiceAddressStreet = invoiceAddressStreet_example;  // string | <p>Street</p>  (optional) 
            var invoiceAddressHouseNumber = invoiceAddressHouseNumber_example;  // string | <p>House number</p>  (optional) 
            var invoiceAddressHouseExtension = invoiceAddressHouseExtension_example;  // string | <p>House extension</p>  (optional) 
            var invoiceAddressCity = invoiceAddressCity_example;  // string | <p>City</p>  (optional) 
            var invoiceAddressZipCode = invoiceAddressZipCode_example;  // string | <p>Zip code</p>  (optional) 
            var invoiceAddressRegion = invoiceAddressRegion_example;  // string | <p>Region</p>  (optional) 
            var invoiceAddressCountryCode = invoiceAddressCountryCode_example;  // string | <p>Three letter country code according to ISO 3166-1 Alpha-3</p>  (optional) 
            var invoiceAddressVatNo = invoiceAddressVatNo_example;  // string | <p>VAT registration number</p>  (optional) 
            var invoiceAddressPhoneNumber = invoiceAddressPhoneNumber_example;  // string | <p>Phone number</p>  (optional) 
            var invoiceAddressMobileNumber = invoiceAddressMobileNumber_example;  // string | <p>Mobile number</p>  (optional) 
            var invoiceAddressEmail = invoiceAddressEmail_example;  // string | <p>Email address</p>  (optional) 
            var shippingAddressName = shippingAddressName_example;  // string | <p>Name</p>  (optional) 
            var shippingAddressAtt = shippingAddressAtt_example;  // string | <p>Att</p>  (optional) 
            var shippingAddressCompanyName = shippingAddressCompanyName_example;  // string | <p>Company name</p>  (optional) 
            var shippingAddressStreet = shippingAddressStreet_example;  // string | <p>Street</p>  (optional) 
            var shippingAddressHouseNumber = shippingAddressHouseNumber_example;  // string | <p>House number</p>  (optional) 
            var shippingAddressHouseExtension = shippingAddressHouseExtension_example;  // string | <p>House extension</p>  (optional) 
            var shippingAddressCity = shippingAddressCity_example;  // string | <p>City</p>  (optional) 
            var shippingAddressZipCode = shippingAddressZipCode_example;  // string | <p>Zip code</p>  (optional) 
            var shippingAddressRegion = shippingAddressRegion_example;  // string | <p>Region</p>  (optional) 
            var shippingAddressCountryCode = shippingAddressCountryCode_example;  // string | <p>Three letter country code according to ISO 3166-1 Alpha-3</p>  (optional) 
            var shippingAddressVatNo = shippingAddressVatNo_example;  // string | <p>VAT registration number</p>  (optional) 
            var shippingAddressPhoneNumber = shippingAddressPhoneNumber_example;  // string | <p>Phone number</p>  (optional) 
            var shippingAddressMobileNumber = shippingAddressMobileNumber_example;  // string | <p>Mobile number</p>  (optional) 
            var shippingAddressEmail = shippingAddressEmail_example;  // string | <p>Email address</p>  (optional) 
            var brandingId = 56;  // int? | <p>Used branding id</p>  (optional) 
            var shippingMethod = shippingMethod_example;  // string | <p>Shipping method</p>  (optional) 
            var shippingCompany = shippingCompany_example;  // string | <p>Shipping company</p>  (optional) 
            var shippingAmount = 56;  // int? | <p>Shipping price (incl. VAT)</p>  (optional) 
            var shippingVatRate = 3.4;  // float? | <p>VAT rate</p>  (optional) 
            var shippingTrackingNumber = shippingTrackingNumber_example;  // string | <p>Shipping tracking number</p>  (optional) 
            var shippingTrackingUrl = shippingTrackingUrl_example;  // string | <p>Shipping tracking url</p>  (optional) 
            var shopsystemName = shopsystemName_example;  // string | <p>Shop system module name</p>  (optional) 
            var shopsystemVersion = shopsystemVersion_example;  // string | <p>Shop system module version</p>  (optional) 
            var variables = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Custom variables</p>  (optional)  (default to {})
            var textOnStatement = textOnStatement_example;  // string | <p>Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.</p>  (optional) 

            try
            {
                // Create payment
                QuickPayProtocolV10Payment result = apiInstance.POSTPaymentsFormat(acceptVersion, authorization, currency, orderId, basketQty, basketItemNo, basketItemName, basketItemPrice, basketVatRate, invoiceAddressName, invoiceAddressAtt, invoiceAddressCompanyName, invoiceAddressStreet, invoiceAddressHouseNumber, invoiceAddressHouseExtension, invoiceAddressCity, invoiceAddressZipCode, invoiceAddressRegion, invoiceAddressCountryCode, invoiceAddressVatNo, invoiceAddressPhoneNumber, invoiceAddressMobileNumber, invoiceAddressEmail, shippingAddressName, shippingAddressAtt, shippingAddressCompanyName, shippingAddressStreet, shippingAddressHouseNumber, shippingAddressHouseExtension, shippingAddressCity, shippingAddressZipCode, shippingAddressRegion, shippingAddressCountryCode, shippingAddressVatNo, shippingAddressPhoneNumber, shippingAddressMobileNumber, shippingAddressEmail, brandingId, shippingMethod, shippingCompany, shippingAmount, shippingVatRate, shippingTrackingNumber, shippingTrackingUrl, shopsystemName, shopsystemVersion, variables, textOnStatement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.POSTPaymentsFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **currency** | **string**| &lt;p&gt;Currency&lt;/p&gt;  | 
 **orderId** | **string**| &lt;p&gt;Unique order id(must be between 4-20 characters)&lt;/p&gt;  | 
 **basketQty** | **int?**| &lt;p&gt;Quantity&lt;/p&gt;  | 
 **basketItemNo** | **string**| &lt;p&gt;Item reference number&lt;/p&gt;  | 
 **basketItemName** | **string**| &lt;p&gt;Item name&lt;/p&gt;  | 
 **basketItemPrice** | **int?**| &lt;p&gt;Per item price (incl. VAT)&lt;/p&gt;  | 
 **basketVatRate** | **float?**| &lt;p&gt;VAT rate&lt;/p&gt;  | 
 **invoiceAddressName** | **string**| &lt;p&gt;Name&lt;/p&gt;  | [optional] 
 **invoiceAddressAtt** | **string**| &lt;p&gt;Att&lt;/p&gt;  | [optional] 
 **invoiceAddressCompanyName** | **string**| &lt;p&gt;Company name&lt;/p&gt;  | [optional] 
 **invoiceAddressStreet** | **string**| &lt;p&gt;Street&lt;/p&gt;  | [optional] 
 **invoiceAddressHouseNumber** | **string**| &lt;p&gt;House number&lt;/p&gt;  | [optional] 
 **invoiceAddressHouseExtension** | **string**| &lt;p&gt;House extension&lt;/p&gt;  | [optional] 
 **invoiceAddressCity** | **string**| &lt;p&gt;City&lt;/p&gt;  | [optional] 
 **invoiceAddressZipCode** | **string**| &lt;p&gt;Zip code&lt;/p&gt;  | [optional] 
 **invoiceAddressRegion** | **string**| &lt;p&gt;Region&lt;/p&gt;  | [optional] 
 **invoiceAddressCountryCode** | **string**| &lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt;  | [optional] 
 **invoiceAddressVatNo** | **string**| &lt;p&gt;VAT registration number&lt;/p&gt;  | [optional] 
 **invoiceAddressPhoneNumber** | **string**| &lt;p&gt;Phone number&lt;/p&gt;  | [optional] 
 **invoiceAddressMobileNumber** | **string**| &lt;p&gt;Mobile number&lt;/p&gt;  | [optional] 
 **invoiceAddressEmail** | **string**| &lt;p&gt;Email address&lt;/p&gt;  | [optional] 
 **shippingAddressName** | **string**| &lt;p&gt;Name&lt;/p&gt;  | [optional] 
 **shippingAddressAtt** | **string**| &lt;p&gt;Att&lt;/p&gt;  | [optional] 
 **shippingAddressCompanyName** | **string**| &lt;p&gt;Company name&lt;/p&gt;  | [optional] 
 **shippingAddressStreet** | **string**| &lt;p&gt;Street&lt;/p&gt;  | [optional] 
 **shippingAddressHouseNumber** | **string**| &lt;p&gt;House number&lt;/p&gt;  | [optional] 
 **shippingAddressHouseExtension** | **string**| &lt;p&gt;House extension&lt;/p&gt;  | [optional] 
 **shippingAddressCity** | **string**| &lt;p&gt;City&lt;/p&gt;  | [optional] 
 **shippingAddressZipCode** | **string**| &lt;p&gt;Zip code&lt;/p&gt;  | [optional] 
 **shippingAddressRegion** | **string**| &lt;p&gt;Region&lt;/p&gt;  | [optional] 
 **shippingAddressCountryCode** | **string**| &lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt;  | [optional] 
 **shippingAddressVatNo** | **string**| &lt;p&gt;VAT registration number&lt;/p&gt;  | [optional] 
 **shippingAddressPhoneNumber** | **string**| &lt;p&gt;Phone number&lt;/p&gt;  | [optional] 
 **shippingAddressMobileNumber** | **string**| &lt;p&gt;Mobile number&lt;/p&gt;  | [optional] 
 **shippingAddressEmail** | **string**| &lt;p&gt;Email address&lt;/p&gt;  | [optional] 
 **brandingId** | **int?**| &lt;p&gt;Used branding id&lt;/p&gt;  | [optional] 
 **shippingMethod** | **string**| &lt;p&gt;Shipping method&lt;/p&gt;  | [optional] 
 **shippingCompany** | **string**| &lt;p&gt;Shipping company&lt;/p&gt;  | [optional] 
 **shippingAmount** | **int?**| &lt;p&gt;Shipping price (incl. VAT)&lt;/p&gt;  | [optional] 
 **shippingVatRate** | **float?**| &lt;p&gt;VAT rate&lt;/p&gt;  | [optional] 
 **shippingTrackingNumber** | **string**| &lt;p&gt;Shipping tracking number&lt;/p&gt;  | [optional] 
 **shippingTrackingUrl** | **string**| &lt;p&gt;Shipping tracking url&lt;/p&gt;  | [optional] 
 **shopsystemName** | **string**| &lt;p&gt;Shop system module name&lt;/p&gt;  | [optional] 
 **shopsystemVersion** | **string**| &lt;p&gt;Shop system module version&lt;/p&gt;  | [optional] 
 **variables** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;Custom variables&lt;/p&gt;  | [optional] [default to {}]
 **textOnStatement** | **string**| &lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidauthorizeformat"></a>
# **POSTPaymentsIdAuthorizeFormat**
> QuickPayProtocolV10Payment POSTPaymentsIdAuthorizeFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, float? vatRate = null, string cardNumber = null, string cardExpiration = null, string cardCvd = null, string cardToken = null, Dictionary<string, string> cardApplePayToken = null, Dictionary<string, string> cardMobilepayOnlineToken = null, string cardIssuedTo = null, string cardBrand = null, string cardStatus = null, string cardEci = null, string cardXav = null, string cardCavv = null, string mobileNumber = null, string ninNumber = null, string ninCountryCode = null, string ninGender = null, string personFirstName = null, string personLastName = null, string personEmail = null, bool? autoCapture = null, string acquirer = null, bool? autofee = null, string customerIp = null, Dictionary<string, string> extras = null, bool? zeroAuth = null)

Authorize payment

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentsIdAuthorizeFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var amount = 56;  // int? | <p>Amount</p> 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | <p>Specify the callback url (overrides merchant default callback-url)</p>  (optional) 
            var synchronized = true;  // bool? | <p>Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)</p>  (optional) 
            var vatRate = 3.4;  // float? | <p>Vate rate</p>  (optional) 
            var cardNumber = cardNumber_example;  // string | <p>Card number</p>  (optional) 
            var cardExpiration = cardExpiration_example;  // string | <p>Expiration date (YYMM)</p>  (optional) 
            var cardCvd = cardCvd_example;  // string | <p>CVD/CVV</p>  (optional) 
            var cardToken = cardToken_example;  // string | <p>Card token</p>  (optional) 
            var cardApplePayToken = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Apple Pay payment-token</p>  (optional) 
            var cardMobilepayOnlineToken = new Dictionary<string, string>(); // Dictionary<string, string> | <p>MobilePay Online payment-token</p>  (optional) 
            var cardIssuedTo = cardIssuedTo_example;  // string | <p>Card holder name</p>  (optional) 
            var cardBrand = cardBrand_example;  // string | <p>Brand to use on multi-brand card</p>  (optional) 
            var cardStatus = cardStatus_example;  // string | <p>3D-Secure status</p>  (optional) 
            var cardEci = cardEci_example;  // string | <p>3D-Secure eci</p>  (optional) 
            var cardXav = cardXav_example;  // string | <p>3D-Secure xav</p>  (optional) 
            var cardCavv = cardCavv_example;  // string | <p>3D-Secure cavv</p>  (optional) 
            var mobileNumber = mobileNumber_example;  // string | <p>Mobile number</p>  (optional) 
            var ninNumber = ninNumber_example;  // string | <p>Customer NIN Number</p>  (optional) 
            var ninCountryCode = ninCountryCode_example;  // string | <p>Customer country (ISO 3166-1 Alpha-3)</p>  (optional) 
            var ninGender = ninGender_example;  // string | <p>Customer gender</p>  (optional) 
            var personFirstName = personFirstName_example;  // string | <p>Person first name</p>  (optional) 
            var personLastName = personLastName_example;  // string | <p>Person last name</p>  (optional) 
            var personEmail = personEmail_example;  // string | <p>Person email</p>  (optional) 
            var autoCapture = true;  // bool? | <p>When true, payment is captured after authorization. Default is false</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>If set, will force the use of this acquirer</p>  (optional) 
            var autofee = true;  // bool? | <p>When true, fee is calculated and added to the given amount. Default is merchant autofee</p>  (optional) 
            var customerIp = customerIp_example;  // string | <p>Customer IP</p>  (optional) 
            var extras = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Additional acquirer specific params</p>  (optional) 
            var zeroAuth = true;  // bool? | <p>(Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false</p>  (optional) 

            try
            {
                // Authorize payment
                QuickPayProtocolV10Payment result = apiInstance.POSTPaymentsIdAuthorizeFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, cardNumber, cardExpiration, cardCvd, cardToken, cardApplePayToken, cardMobilepayOnlineToken, cardIssuedTo, cardBrand, cardStatus, cardEci, cardXav, cardCavv, mobileNumber, ninNumber, ninCountryCode, ninGender, personFirstName, personLastName, personEmail, autoCapture, acquirer, autofee, customerIp, extras, zeroAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.POSTPaymentsIdAuthorizeFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount&lt;/p&gt;  | 
 **quickPayCallbackUrl** | **string**| &lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt;  | [optional] 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 
 **vatRate** | **float?**| &lt;p&gt;Vate rate&lt;/p&gt;  | [optional] 
 **cardNumber** | **string**| &lt;p&gt;Card number&lt;/p&gt;  | [optional] 
 **cardExpiration** | **string**| &lt;p&gt;Expiration date (YYMM)&lt;/p&gt;  | [optional] 
 **cardCvd** | **string**| &lt;p&gt;CVD/CVV&lt;/p&gt;  | [optional] 
 **cardToken** | **string**| &lt;p&gt;Card token&lt;/p&gt;  | [optional] 
 **cardApplePayToken** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;Apple Pay payment-token&lt;/p&gt;  | [optional] 
 **cardMobilepayOnlineToken** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;MobilePay Online payment-token&lt;/p&gt;  | [optional] 
 **cardIssuedTo** | **string**| &lt;p&gt;Card holder name&lt;/p&gt;  | [optional] 
 **cardBrand** | **string**| &lt;p&gt;Brand to use on multi-brand card&lt;/p&gt;  | [optional] 
 **cardStatus** | **string**| &lt;p&gt;3D-Secure status&lt;/p&gt;  | [optional] 
 **cardEci** | **string**| &lt;p&gt;3D-Secure eci&lt;/p&gt;  | [optional] 
 **cardXav** | **string**| &lt;p&gt;3D-Secure xav&lt;/p&gt;  | [optional] 
 **cardCavv** | **string**| &lt;p&gt;3D-Secure cavv&lt;/p&gt;  | [optional] 
 **mobileNumber** | **string**| &lt;p&gt;Mobile number&lt;/p&gt;  | [optional] 
 **ninNumber** | **string**| &lt;p&gt;Customer NIN Number&lt;/p&gt;  | [optional] 
 **ninCountryCode** | **string**| &lt;p&gt;Customer country (ISO 3166-1 Alpha-3)&lt;/p&gt;  | [optional] 
 **ninGender** | **string**| &lt;p&gt;Customer gender&lt;/p&gt;  | [optional] 
 **personFirstName** | **string**| &lt;p&gt;Person first name&lt;/p&gt;  | [optional] 
 **personLastName** | **string**| &lt;p&gt;Person last name&lt;/p&gt;  | [optional] 
 **personEmail** | **string**| &lt;p&gt;Person email&lt;/p&gt;  | [optional] 
 **autoCapture** | **bool?**| &lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt;  | [optional] 
 **autofee** | **bool?**| &lt;p&gt;When true, fee is calculated and added to the given amount. Default is merchant autofee&lt;/p&gt;  | [optional] 
 **customerIp** | **string**| &lt;p&gt;Customer IP&lt;/p&gt;  | [optional] 
 **extras** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;Additional acquirer specific params&lt;/p&gt;  | [optional] 
 **zeroAuth** | **bool?**| &lt;p&gt;(Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidcancelformat"></a>
# **POSTPaymentsIdCancelFormat**
> QuickPayProtocolV10Payment POSTPaymentsIdCancelFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, bool? synchronized = null)

Cancel payment

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentsIdCancelFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | <p>Specify the callback url (overrides merchant default callback-url)</p>  (optional) 
            var synchronized = true;  // bool? | <p>Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)</p>  (optional) 

            try
            {
                // Cancel payment
                QuickPayProtocolV10Payment result = apiInstance.POSTPaymentsIdCancelFormat(acceptVersion, authorization, id, quickPayCallbackUrl, synchronized);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.POSTPaymentsIdCancelFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **quickPayCallbackUrl** | **string**| &lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt;  | [optional] 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidcaptureformat"></a>
# **POSTPaymentsIdCaptureFormat**
> QuickPayProtocolV10Payment POSTPaymentsIdCaptureFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, Dictionary<string, string> extras = null)

Capture payment

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentsIdCaptureFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var amount = 56;  // int? | <p>Amount</p> 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | <p>Specify the callback url (overrides merchant default callback-url)</p>  (optional) 
            var synchronized = true;  // bool? | <p>Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)</p>  (optional) 
            var extras = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Additional acquirer specific params</p>  (optional) 

            try
            {
                // Capture payment
                QuickPayProtocolV10Payment result = apiInstance.POSTPaymentsIdCaptureFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, extras);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.POSTPaymentsIdCaptureFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount&lt;/p&gt;  | 
 **quickPayCallbackUrl** | **string**| &lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt;  | [optional] 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 
 **extras** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;Additional acquirer specific params&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidfraudreportformat"></a>
# **POSTPaymentsIdFraudReportFormat**
> QuickPayProtocolV10FraudReport POSTPaymentsIdFraudReportFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, string description = null)

Create fraud confirmation report

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentsIdFraudReportFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | <p>Specify the callback url (overrides merchant default callback-url)</p>  (optional) 
            var description = description_example;  // string |   (optional) 

            try
            {
                // Create fraud confirmation report
                QuickPayProtocolV10FraudReport result = apiInstance.POSTPaymentsIdFraudReportFormat(acceptVersion, authorization, id, quickPayCallbackUrl, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.POSTPaymentsIdFraudReportFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **quickPayCallbackUrl** | **string**| &lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt;  | [optional] 
 **description** | **string**|   | [optional] 

### Return type

[**QuickPayProtocolV10FraudReport**](QuickPayProtocolV10FraudReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidrefundformat"></a>
# **POSTPaymentsIdRefundFormat**
> QuickPayProtocolV10Payment POSTPaymentsIdRefundFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, float? vatRate = null, Dictionary<string, string> extras = null)

Refund payment

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentsIdRefundFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var amount = 56;  // int? | <p>Amount</p> 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | <p>Specify the callback url (overrides merchant default callback-url)</p>  (optional) 
            var synchronized = true;  // bool? | <p>Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)</p>  (optional) 
            var vatRate = 3.4;  // float? | <p>Vate rate</p>  (optional) 
            var extras = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Additional acquirer specific params</p>  (optional) 

            try
            {
                // Refund payment
                QuickPayProtocolV10Payment result = apiInstance.POSTPaymentsIdRefundFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, extras);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.POSTPaymentsIdRefundFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount&lt;/p&gt;  | 
 **quickPayCallbackUrl** | **string**| &lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt;  | [optional] 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 
 **vatRate** | **float?**| &lt;p&gt;Vate rate&lt;/p&gt;  | [optional] 
 **extras** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;Additional acquirer specific params&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidrenewformat"></a>
# **POSTPaymentsIdRenewFormat**
> QuickPayProtocolV10Payment POSTPaymentsIdRenewFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, bool? synchronized = null)

Renew authorization

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentsIdRenewFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | <p>Specify the callback url (overrides merchant default callback-url)</p>  (optional) 
            var synchronized = true;  // bool? | <p>Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)</p>  (optional) 

            try
            {
                // Renew authorization
                QuickPayProtocolV10Payment result = apiInstance.POSTPaymentsIdRenewFormat(acceptVersion, authorization, id, quickPayCallbackUrl, synchronized);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.POSTPaymentsIdRenewFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **quickPayCallbackUrl** | **string**| &lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt;  | [optional] 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidsessionformat"></a>
# **POSTPaymentsIdSessionFormat**
> QuickPayProtocolV10Payment POSTPaymentsIdSessionFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, bool? autoCapture = null, string acquirer = null, bool? autofee = null, string customerIp = null, string personFirstName = null, string personLastName = null, string personEmail = null, Dictionary<string, string> extras = null)

Create payment session

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentsIdSessionFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payment id</p> 
            var amount = 56;  // int? | <p>Amount</p> 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | <p>Specify the callback url (overrides merchant default callback-url)</p>  (optional) 
            var synchronized = true;  // bool? | <p>Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)</p>  (optional) 
            var autoCapture = true;  // bool? | <p>When true, payment is captured after authorization. Default is false</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>If set, will force the use of this acquirer</p>  (optional) 
            var autofee = true;  // bool? | <p>When true, fee is calculated and added to the given amount. Default is merchant autofee</p>  (optional) 
            var customerIp = customerIp_example;  // string | <p>Customer IP</p>  (optional) 
            var personFirstName = personFirstName_example;  // string | <p>Person first name</p>  (optional) 
            var personLastName = personLastName_example;  // string | <p>Person last name</p>  (optional) 
            var personEmail = personEmail_example;  // string | <p>Person email</p>  (optional) 
            var extras = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Additional acquirer specific params</p>  (optional) 

            try
            {
                // Create payment session
                QuickPayProtocolV10Payment result = apiInstance.POSTPaymentsIdSessionFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, autoCapture, acquirer, autofee, customerIp, personFirstName, personLastName, personEmail, extras);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.POSTPaymentsIdSessionFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payment id&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount&lt;/p&gt;  | 
 **quickPayCallbackUrl** | **string**| &lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt;  | [optional] 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 
 **autoCapture** | **bool?**| &lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt;  | [optional] 
 **autofee** | **bool?**| &lt;p&gt;When true, fee is calculated and added to the given amount. Default is merchant autofee&lt;/p&gt;  | [optional] 
 **customerIp** | **string**| &lt;p&gt;Customer IP&lt;/p&gt;  | [optional] 
 **personFirstName** | **string**| &lt;p&gt;Person first name&lt;/p&gt;  | [optional] 
 **personLastName** | **string**| &lt;p&gt;Person last name&lt;/p&gt;  | [optional] 
 **personEmail** | **string**| &lt;p&gt;Person email&lt;/p&gt;  | [optional] 
 **extras** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;Additional acquirer specific params&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Payment**](QuickPayProtocolV10Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpaymentsidlinkformat"></a>
# **PUTPaymentsIdLinkFormat**
> QuickPayProtocolV10PaymentLinkUrl PUTPaymentsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId = null, string language = null, string continueUrl = null, string cancelUrl = null, string callbackUrl = null, string paymentMethods = null, bool? autoFee = null, int? brandingId = null, string googleAnalyticsTrackingId = null, string googleAnalyticsClientId = null, string acquirer = null, int? deadline = null, bool? framed = null, Dictionary<string, string> brandingConfig = null, string customerEmail = null, bool? invoiceAddressSelection = null, bool? shippingAddressSelection = null, bool? autoCapture = null)

Create or update a payment link

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PUTPaymentsIdLinkFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Transaction id</p> 
            var amount = 56;  // int? | <p>Amount to authorize</p> 
            var agreementId = 56;  // int? | <p>Agreement to use. Defaults to the Payment Window agreement</p>  (optional) 
            var language = language_example;  // string | <p>Language</p>  (optional)  (default to en)
            var continueUrl = continueUrl_example;  // string | <p>Url that cardholder is redirected to after authorize</p>  (optional) 
            var cancelUrl = cancelUrl_example;  // string | <p>Url that cardholder is redirected to after cancelation</p>  (optional) 
            var callbackUrl = callbackUrl_example;  // string | <p>Endpoint for async callback</p>  (optional) 
            var paymentMethods = paymentMethods_example;  // string | <p>Limit payment methods</p>  (optional) 
            var autoFee = true;  // bool? | <p>Add acquirer fee to amount. Default is merchant autofee</p>  (optional) 
            var brandingId = 56;  // int? | <p>Override branding. Default is merchant default branding</p>  (optional) 
            var googleAnalyticsTrackingId = googleAnalyticsTrackingId_example;  // string | <p>Send events to Google Analytics</p>  (optional) 
            var googleAnalyticsClientId = googleAnalyticsClientId_example;  // string | <p>Send events to Google Analytics</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>Force usage of the given acquirer</p>  (optional) 
            var deadline = 56;  // int? | <p>Set a deadline in seconds for the cardholder to complete</p>  (optional) 
            var framed = true;  // bool? | <p>Allow opening in iframe</p>  (optional) 
            var brandingConfig = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Config for branding. Will be merged with the default config in the branding</p>  (optional) 
            var customerEmail = customerEmail_example;  // string | <p>Required for PayPal. Email of customer.</p>  (optional) 
            var invoiceAddressSelection = true;  // bool? | <p>Get customer invoice address via acquirer (Currently MobilePay and PayPal only)</p>  (optional) 
            var shippingAddressSelection = true;  // bool? | <p>Get customer shipping address via acquirer (Currently MobilePay and PayPal only)</p>  (optional) 
            var autoCapture = true;  // bool? | <p>When true, payment is captured after authorization. Default is false</p>  (optional) 

            try
            {
                // Create or update a payment link
                QuickPayProtocolV10PaymentLinkUrl result = apiInstance.PUTPaymentsIdLinkFormat(acceptVersion, authorization, id, amount, agreementId, language, continueUrl, cancelUrl, callbackUrl, paymentMethods, autoFee, brandingId, googleAnalyticsTrackingId, googleAnalyticsClientId, acquirer, deadline, framed, brandingConfig, customerEmail, invoiceAddressSelection, shippingAddressSelection, autoCapture);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.PUTPaymentsIdLinkFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Transaction id&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount to authorize&lt;/p&gt;  | 
 **agreementId** | **int?**| &lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt;  | [optional] 
 **language** | **string**| &lt;p&gt;Language&lt;/p&gt;  | [optional] [default to en]
 **continueUrl** | **string**| &lt;p&gt;Url that cardholder is redirected to after authorize&lt;/p&gt;  | [optional] 
 **cancelUrl** | **string**| &lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt;  | [optional] 
 **callbackUrl** | **string**| &lt;p&gt;Endpoint for async callback&lt;/p&gt;  | [optional] 
 **paymentMethods** | **string**| &lt;p&gt;Limit payment methods&lt;/p&gt;  | [optional] 
 **autoFee** | **bool?**| &lt;p&gt;Add acquirer fee to amount. Default is merchant autofee&lt;/p&gt;  | [optional] 
 **brandingId** | **int?**| &lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt;  | [optional] 
 **googleAnalyticsTrackingId** | **string**| &lt;p&gt;Send events to Google Analytics&lt;/p&gt;  | [optional] 
 **googleAnalyticsClientId** | **string**| &lt;p&gt;Send events to Google Analytics&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;Force usage of the given acquirer&lt;/p&gt;  | [optional] 
 **deadline** | **int?**| &lt;p&gt;Set a deadline in seconds for the cardholder to complete&lt;/p&gt;  | [optional] 
 **framed** | **bool?**| &lt;p&gt;Allow opening in iframe&lt;/p&gt;  | [optional] 
 **brandingConfig** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt;  | [optional] 
 **customerEmail** | **string**| &lt;p&gt;Required for PayPal. Email of customer.&lt;/p&gt;  | [optional] 
 **invoiceAddressSelection** | **bool?**| &lt;p&gt;Get customer invoice address via acquirer (Currently MobilePay and PayPal only)&lt;/p&gt;  | [optional] 
 **shippingAddressSelection** | **bool?**| &lt;p&gt;Get customer shipping address via acquirer (Currently MobilePay and PayPal only)&lt;/p&gt;  | [optional] 
 **autoCapture** | **bool?**| &lt;p&gt;When true, payment is captured after authorization. Default is false&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10PaymentLinkUrl**](QuickPayProtocolV10PaymentLinkUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

