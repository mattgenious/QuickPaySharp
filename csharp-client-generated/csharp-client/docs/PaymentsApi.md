# IO.Swagger.Api.PaymentsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Transaction id 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Transaction id  | 

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
> List<Payment> GETPaymentsFormat (string acceptVersion, string authorization, int? dateYear = null, int? dateMonth = null, int? dateDay = null, int? dateHour = null, int? dateMinute = null, string timestamp = null, string minTime = null, string maxTime = null, int? operationsSize = null, bool? accepted = null, string orderId = null, string state = null, int? id = null, string acquirer = null, bool? fraudSuspected = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var dateYear = 56;  // int? | Year  (optional) 
            var dateMonth = 56;  // int? | Month  (optional) 
            var dateDay = 56;  // int? | Day of the month  (optional) 
            var dateHour = 56;  // int? | Hour of the day  (optional) 
            var dateMinute = 56;  // int? | Minute of the hour  (optional) 
            var timestamp = timestamp_example;  // string | Timestamp field  (optional)  (default to created_at)
            var minTime = minTime_example;  // string | Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”  (optional) 
            var maxTime = maxTime_example;  // string | Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”  (optional) 
            var operationsSize = 56;  // int? | Maximum number of operations to retrieve  (optional) 
            var accepted = true;  // bool? | Return accepted payments  (optional) 
            var orderId = orderId_example;  // string | Find by order_id  (optional) 
            var state = state_example;  // string | Find by state  (optional) 
            var id = 56;  // int? | Find by transaction id  (optional) 
            var acquirer = acquirer_example;  // string | Filter by acquirer  (optional) 
            var fraudSuspected = true;  // bool? | Filter by suspected fraud  (optional) 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)
            var pageKey = pageKey_example;  // string |   (optional) 

            try
            {
                // Get all payments
                List&lt;Payment&gt; result = apiInstance.GETPaymentsFormat(acceptVersion, authorization, dateYear, dateMonth, dateDay, dateHour, dateMinute, timestamp, minTime, maxTime, operationsSize, accepted, orderId, state, id, acquirer, fraudSuspected, page, pageSize, sortBy, sortDir, pageKey);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **dateYear** | **int?**| Year  | [optional] 
 **dateMonth** | **int?**| Month  | [optional] 
 **dateDay** | **int?**| Day of the month  | [optional] 
 **dateHour** | **int?**| Hour of the day  | [optional] 
 **dateMinute** | **int?**| Minute of the hour  | [optional] 
 **timestamp** | **string**| Timestamp field  | [optional] [default to created_at]
 **minTime** | **string**| Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”  | [optional] 
 **maxTime** | **string**| Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”  | [optional] 
 **operationsSize** | **int?**| Maximum number of operations to retrieve  | [optional] 
 **accepted** | **bool?**| Return accepted payments  | [optional] 
 **orderId** | **string**| Find by order_id  | [optional] 
 **state** | **string**| Find by state  | [optional] 
 **id** | **int?**| Find by transaction id  | [optional] 
 **acquirer** | **string**| Filter by acquirer  | [optional] 
 **fraudSuspected** | **bool?**| Filter by suspected fraud  | [optional] 
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]
 **sortBy** | **string**| Property to sort by  | [optional] [default to id]
 **sortDir** | **string**| Sort direction  | [optional] [default to desc]
 **pageKey** | **string**|   | [optional] 

### Return type

[**List<Payment>**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsidformat"></a>
# **GETPaymentsIdFormat**
> Payment GETPaymentsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var operationsSize = 56;  // int? | Maximum number of operations to retrieve  (optional) 

            try
            {
                // Get payment
                Payment result = apiInstance.GETPaymentsIdFormat(acceptVersion, authorization, id, operationsSize);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **operationsSize** | **int?**| Maximum number of operations to retrieve  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsidoperationsoperationidformat"></a>
# **GETPaymentsIdOperationsOperationIdFormat**
> Operation GETPaymentsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var operationId = 56;  // int? | Operations id 

            try
            {
                // Get Operation
                Operation result = apiInstance.GETPaymentsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **operationId** | **int?**| Operations id  | 

### Return type

[**Operation**](Operation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpaymentsidformat"></a>
# **PATCHPaymentsIdFormat**
> Payment PATCHPaymentsIdFormat (string acceptVersion, string authorization, int? id, int? basketQty, string basketItemNo, string basketItemName, int? basketItemPrice, float? basketVatRate, DateTime? deadlineAt = null, string invoiceAddressName = null, string invoiceAddressAtt = null, string invoiceAddressCompanyName = null, string invoiceAddressStreet = null, string invoiceAddressHouseNumber = null, string invoiceAddressHouseExtension = null, string invoiceAddressCity = null, string invoiceAddressZipCode = null, string invoiceAddressRegion = null, string invoiceAddressCountryCode = null, string invoiceAddressVatNo = null, string invoiceAddressPhoneNumber = null, string invoiceAddressMobileNumber = null, string invoiceAddressEmail = null, string shippingAddressName = null, string shippingAddressAtt = null, string shippingAddressCompanyName = null, string shippingAddressStreet = null, string shippingAddressHouseNumber = null, string shippingAddressHouseExtension = null, string shippingAddressCity = null, string shippingAddressZipCode = null, string shippingAddressRegion = null, string shippingAddressCountryCode = null, string shippingAddressVatNo = null, string shippingAddressPhoneNumber = null, string shippingAddressMobileNumber = null, string shippingAddressEmail = null, string shippingMethod = null, string shippingCompany = null, int? shippingAmount = null, float? shippingVatRate = null, string shippingTrackingNumber = null, string shippingTrackingUrl = null, string variables = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var basketQty = 56;  // int? | Quantity 
            var basketItemNo = basketItemNo_example;  // string | Item reference number 
            var basketItemName = basketItemName_example;  // string | Item name 
            var basketItemPrice = 56;  // int? | Per item price (incl. VAT) 
            var basketVatRate = 3.4;  // float? | VAT rate 
            var deadlineAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Payment must be authorized before this time  (optional) 
            var invoiceAddressName = invoiceAddressName_example;  // string | Name  (optional) 
            var invoiceAddressAtt = invoiceAddressAtt_example;  // string | Att  (optional) 
            var invoiceAddressCompanyName = invoiceAddressCompanyName_example;  // string | Company name  (optional) 
            var invoiceAddressStreet = invoiceAddressStreet_example;  // string | Street  (optional) 
            var invoiceAddressHouseNumber = invoiceAddressHouseNumber_example;  // string | House number  (optional) 
            var invoiceAddressHouseExtension = invoiceAddressHouseExtension_example;  // string | House extension  (optional) 
            var invoiceAddressCity = invoiceAddressCity_example;  // string | City  (optional) 
            var invoiceAddressZipCode = invoiceAddressZipCode_example;  // string | Zip code  (optional) 
            var invoiceAddressRegion = invoiceAddressRegion_example;  // string | Region  (optional) 
            var invoiceAddressCountryCode = invoiceAddressCountryCode_example;  // string | Three letter country code according to ISO 3166-1 Alpha-3  (optional) 
            var invoiceAddressVatNo = invoiceAddressVatNo_example;  // string | VAT registration number  (optional) 
            var invoiceAddressPhoneNumber = invoiceAddressPhoneNumber_example;  // string | Phone number  (optional) 
            var invoiceAddressMobileNumber = invoiceAddressMobileNumber_example;  // string | Mobile number  (optional) 
            var invoiceAddressEmail = invoiceAddressEmail_example;  // string | Email address  (optional) 
            var shippingAddressName = shippingAddressName_example;  // string | Name  (optional) 
            var shippingAddressAtt = shippingAddressAtt_example;  // string | Att  (optional) 
            var shippingAddressCompanyName = shippingAddressCompanyName_example;  // string | Company name  (optional) 
            var shippingAddressStreet = shippingAddressStreet_example;  // string | Street  (optional) 
            var shippingAddressHouseNumber = shippingAddressHouseNumber_example;  // string | House number  (optional) 
            var shippingAddressHouseExtension = shippingAddressHouseExtension_example;  // string | House extension  (optional) 
            var shippingAddressCity = shippingAddressCity_example;  // string | City  (optional) 
            var shippingAddressZipCode = shippingAddressZipCode_example;  // string | Zip code  (optional) 
            var shippingAddressRegion = shippingAddressRegion_example;  // string | Region  (optional) 
            var shippingAddressCountryCode = shippingAddressCountryCode_example;  // string | Three letter country code according to ISO 3166-1 Alpha-3  (optional) 
            var shippingAddressVatNo = shippingAddressVatNo_example;  // string | VAT registration number  (optional) 
            var shippingAddressPhoneNumber = shippingAddressPhoneNumber_example;  // string | Phone number  (optional) 
            var shippingAddressMobileNumber = shippingAddressMobileNumber_example;  // string | Mobile number  (optional) 
            var shippingAddressEmail = shippingAddressEmail_example;  // string | Email address  (optional) 
            var shippingMethod = shippingMethod_example;  // string | Shipping method  (optional) 
            var shippingCompany = shippingCompany_example;  // string | Shipping company  (optional) 
            var shippingAmount = 56;  // int? | Shipping price (incl. VAT)  (optional) 
            var shippingVatRate = 3.4;  // float? | VAT rate  (optional) 
            var shippingTrackingNumber = shippingTrackingNumber_example;  // string | Shipping tracking number  (optional) 
            var shippingTrackingUrl = shippingTrackingUrl_example;  // string | Shipping tracking url  (optional) 
            var variables = variables_example;  // string | Custom variables  (optional) 

            try
            {
                // Update payment
                Payment result = apiInstance.PATCHPaymentsIdFormat(acceptVersion, authorization, id, basketQty, basketItemNo, basketItemName, basketItemPrice, basketVatRate, deadlineAt, invoiceAddressName, invoiceAddressAtt, invoiceAddressCompanyName, invoiceAddressStreet, invoiceAddressHouseNumber, invoiceAddressHouseExtension, invoiceAddressCity, invoiceAddressZipCode, invoiceAddressRegion, invoiceAddressCountryCode, invoiceAddressVatNo, invoiceAddressPhoneNumber, invoiceAddressMobileNumber, invoiceAddressEmail, shippingAddressName, shippingAddressAtt, shippingAddressCompanyName, shippingAddressStreet, shippingAddressHouseNumber, shippingAddressHouseExtension, shippingAddressCity, shippingAddressZipCode, shippingAddressRegion, shippingAddressCountryCode, shippingAddressVatNo, shippingAddressPhoneNumber, shippingAddressMobileNumber, shippingAddressEmail, shippingMethod, shippingCompany, shippingAmount, shippingVatRate, shippingTrackingNumber, shippingTrackingUrl, variables);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **basketQty** | **int?**| Quantity  | 
 **basketItemNo** | **string**| Item reference number  | 
 **basketItemName** | **string**| Item name  | 
 **basketItemPrice** | **int?**| Per item price (incl. VAT)  | 
 **basketVatRate** | **float?**| VAT rate  | 
 **deadlineAt** | **DateTime?**| Payment must be authorized before this time  | [optional] 
 **invoiceAddressName** | **string**| Name  | [optional] 
 **invoiceAddressAtt** | **string**| Att  | [optional] 
 **invoiceAddressCompanyName** | **string**| Company name  | [optional] 
 **invoiceAddressStreet** | **string**| Street  | [optional] 
 **invoiceAddressHouseNumber** | **string**| House number  | [optional] 
 **invoiceAddressHouseExtension** | **string**| House extension  | [optional] 
 **invoiceAddressCity** | **string**| City  | [optional] 
 **invoiceAddressZipCode** | **string**| Zip code  | [optional] 
 **invoiceAddressRegion** | **string**| Region  | [optional] 
 **invoiceAddressCountryCode** | **string**| Three letter country code according to ISO 3166-1 Alpha-3  | [optional] 
 **invoiceAddressVatNo** | **string**| VAT registration number  | [optional] 
 **invoiceAddressPhoneNumber** | **string**| Phone number  | [optional] 
 **invoiceAddressMobileNumber** | **string**| Mobile number  | [optional] 
 **invoiceAddressEmail** | **string**| Email address  | [optional] 
 **shippingAddressName** | **string**| Name  | [optional] 
 **shippingAddressAtt** | **string**| Att  | [optional] 
 **shippingAddressCompanyName** | **string**| Company name  | [optional] 
 **shippingAddressStreet** | **string**| Street  | [optional] 
 **shippingAddressHouseNumber** | **string**| House number  | [optional] 
 **shippingAddressHouseExtension** | **string**| House extension  | [optional] 
 **shippingAddressCity** | **string**| City  | [optional] 
 **shippingAddressZipCode** | **string**| Zip code  | [optional] 
 **shippingAddressRegion** | **string**| Region  | [optional] 
 **shippingAddressCountryCode** | **string**| Three letter country code according to ISO 3166-1 Alpha-3  | [optional] 
 **shippingAddressVatNo** | **string**| VAT registration number  | [optional] 
 **shippingAddressPhoneNumber** | **string**| Phone number  | [optional] 
 **shippingAddressMobileNumber** | **string**| Mobile number  | [optional] 
 **shippingAddressEmail** | **string**| Email address  | [optional] 
 **shippingMethod** | **string**| Shipping method  | [optional] 
 **shippingCompany** | **string**| Shipping company  | [optional] 
 **shippingAmount** | **int?**| Shipping price (incl. VAT)  | [optional] 
 **shippingVatRate** | **float?**| VAT rate  | [optional] 
 **shippingTrackingNumber** | **string**| Shipping tracking number  | [optional] 
 **shippingTrackingUrl** | **string**| Shipping tracking url  | [optional] 
 **variables** | **string**| Custom variables  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpaymentsidoperationsoperationidformat"></a>
# **PATCHPaymentsIdOperationsOperationIdFormat**
> Operation PATCHPaymentsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId, bool? pending)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var operationId = 56;  // int? | Operations id 
            var pending = true;  // bool? | Aborts the operation. Only possible on capture, refund, recurring and cancel operations (false is the only allowed value) 

            try
            {
                // Update operation
                Operation result = apiInstance.PATCHPaymentsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId, pending);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **operationId** | **int?**| Operations id  | 
 **pending** | **bool?**| Aborts the operation. Only possible on capture, refund, recurring and cancel operations (false is the only allowed value)  | 

### Return type

[**Operation**](Operation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsformat"></a>
# **POSTPaymentsFormat**
> Payment POSTPaymentsFormat (string acceptVersion, string authorization, Payment payment)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var payment = new Payment(); // Payment | Payment

            try
            {
                // Create payment
                Payment result = apiInstance.POSTPaymentsFormat(acceptVersion, authorization, payment);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **payment** | [**Payment**](Payment.md)| Payment | 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidauthorizeformat"></a>
# **POSTPaymentsIdAuthorizeFormat**
> Payment POSTPaymentsIdAuthorizeFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, float? vatRate = null, string cardNumber = null, string cardExpiration = null, string cardCvd = null, string cardToken = null, string cardApplePayToken = null, string cardMobilepayOnlineToken = null, string cardIssuedTo = null, string cardBrand = null, string cardStatus = null, string cardEci = null, string cardXav = null, string cardCavv = null, string mobileNumber = null, string ninNumber = null, string ninCountryCode = null, string ninGender = null, string personFirstName = null, string personLastName = null, string personEmail = null, bool? autoCapture = null, string acquirer = null, bool? autofee = null, string customerIp = null, string extras = null, bool? zeroAuth = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var amount = 56;  // int? | Amount 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 
            var vatRate = 3.4;  // float? | Vate rate  (optional) 
            var cardNumber = cardNumber_example;  // string | Card number  (optional) 
            var cardExpiration = cardExpiration_example;  // string | Expiration date (YYMM)  (optional) 
            var cardCvd = cardCvd_example;  // string | CVD/CVV  (optional) 
            var cardToken = cardToken_example;  // string | Card token  (optional) 
            var cardApplePayToken = cardApplePayToken_example;  // string | Apple Pay payment-token  (optional) 
            var cardMobilepayOnlineToken = cardMobilepayOnlineToken_example;  // string | MobilePay Online payment-token  (optional) 
            var cardIssuedTo = cardIssuedTo_example;  // string | Card holder name  (optional) 
            var cardBrand = cardBrand_example;  // string | Brand to use on multi-brand card  (optional) 
            var cardStatus = cardStatus_example;  // string | 3D-Secure status  (optional) 
            var cardEci = cardEci_example;  // string | 3D-Secure eci  (optional) 
            var cardXav = cardXav_example;  // string | 3D-Secure xav  (optional) 
            var cardCavv = cardCavv_example;  // string | 3D-Secure cavv  (optional) 
            var mobileNumber = mobileNumber_example;  // string | Mobile number  (optional) 
            var ninNumber = ninNumber_example;  // string | Customer NIN Number  (optional) 
            var ninCountryCode = ninCountryCode_example;  // string | Customer country (ISO 3166-1 Alpha-3)  (optional) 
            var ninGender = ninGender_example;  // string | Customer gender  (optional) 
            var personFirstName = personFirstName_example;  // string | Person first name  (optional) 
            var personLastName = personLastName_example;  // string | Person last name  (optional) 
            var personEmail = personEmail_example;  // string | Person email  (optional) 
            var autoCapture = true;  // bool? | When true, payment is captured after authorization. Default is false  (optional) 
            var acquirer = acquirer_example;  // string | If set, will force the use of this acquirer  (optional) 
            var autofee = true;  // bool? | When true, fee is calculated and added to the given amount. Default is merchant autofee  (optional) 
            var customerIp = customerIp_example;  // string | Customer IP  (optional) 
            var extras = extras_example;  // string | Additional acquirer specific params  (optional) 
            var zeroAuth = true;  // bool? | (Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false  (optional) 

            try
            {
                // Authorize payment
                Payment result = apiInstance.POSTPaymentsIdAuthorizeFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, cardNumber, cardExpiration, cardCvd, cardToken, cardApplePayToken, cardMobilepayOnlineToken, cardIssuedTo, cardBrand, cardStatus, cardEci, cardXav, cardCavv, mobileNumber, ninNumber, ninCountryCode, ninGender, personFirstName, personLastName, personEmail, autoCapture, acquirer, autofee, customerIp, extras, zeroAuth);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **amount** | **int?**| Amount  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 
 **vatRate** | **float?**| Vate rate  | [optional] 
 **cardNumber** | **string**| Card number  | [optional] 
 **cardExpiration** | **string**| Expiration date (YYMM)  | [optional] 
 **cardCvd** | **string**| CVD/CVV  | [optional] 
 **cardToken** | **string**| Card token  | [optional] 
 **cardApplePayToken** | **string**| Apple Pay payment-token  | [optional] 
 **cardMobilepayOnlineToken** | **string**| MobilePay Online payment-token  | [optional] 
 **cardIssuedTo** | **string**| Card holder name  | [optional] 
 **cardBrand** | **string**| Brand to use on multi-brand card  | [optional] 
 **cardStatus** | **string**| 3D-Secure status  | [optional] 
 **cardEci** | **string**| 3D-Secure eci  | [optional] 
 **cardXav** | **string**| 3D-Secure xav  | [optional] 
 **cardCavv** | **string**| 3D-Secure cavv  | [optional] 
 **mobileNumber** | **string**| Mobile number  | [optional] 
 **ninNumber** | **string**| Customer NIN Number  | [optional] 
 **ninCountryCode** | **string**| Customer country (ISO 3166-1 Alpha-3)  | [optional] 
 **ninGender** | **string**| Customer gender  | [optional] 
 **personFirstName** | **string**| Person first name  | [optional] 
 **personLastName** | **string**| Person last name  | [optional] 
 **personEmail** | **string**| Person email  | [optional] 
 **autoCapture** | **bool?**| When true, payment is captured after authorization. Default is false  | [optional] 
 **acquirer** | **string**| If set, will force the use of this acquirer  | [optional] 
 **autofee** | **bool?**| When true, fee is calculated and added to the given amount. Default is merchant autofee  | [optional] 
 **customerIp** | **string**| Customer IP  | [optional] 
 **extras** | **string**| Additional acquirer specific params  | [optional] 
 **zeroAuth** | **bool?**| (Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidcancelformat"></a>
# **POSTPaymentsIdCancelFormat**
> Payment POSTPaymentsIdCancelFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, bool? synchronized = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 

            try
            {
                // Cancel payment
                Payment result = apiInstance.POSTPaymentsIdCancelFormat(acceptVersion, authorization, id, quickPayCallbackUrl, synchronized);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidcaptureformat"></a>
# **POSTPaymentsIdCaptureFormat**
> Payment POSTPaymentsIdCaptureFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, string extras = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var amount = 56;  // int? | Amount 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 
            var extras = extras_example;  // string | Additional acquirer specific params  (optional) 

            try
            {
                // Capture payment
                Payment result = apiInstance.POSTPaymentsIdCaptureFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, extras);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **amount** | **int?**| Amount  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 
 **extras** | **string**| Additional acquirer specific params  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidfraudreportformat"></a>
# **POSTPaymentsIdFraudReportFormat**
> FraudReport POSTPaymentsIdFraudReportFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, string description = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var description = description_example;  // string |   (optional) 

            try
            {
                // Create fraud confirmation report
                FraudReport result = apiInstance.POSTPaymentsIdFraudReportFormat(acceptVersion, authorization, id, quickPayCallbackUrl, description);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **description** | **string**|   | [optional] 

### Return type

[**FraudReport**](FraudReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidrefundformat"></a>
# **POSTPaymentsIdRefundFormat**
> Payment POSTPaymentsIdRefundFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, float? vatRate = null, string extras = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var amount = 56;  // int? | Amount 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 
            var vatRate = 3.4;  // float? | Vate rate  (optional) 
            var extras = extras_example;  // string | Additional acquirer specific params  (optional) 

            try
            {
                // Refund payment
                Payment result = apiInstance.POSTPaymentsIdRefundFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, extras);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **amount** | **int?**| Amount  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 
 **vatRate** | **float?**| Vate rate  | [optional] 
 **extras** | **string**| Additional acquirer specific params  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidrenewformat"></a>
# **POSTPaymentsIdRenewFormat**
> Payment POSTPaymentsIdRenewFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, bool? synchronized = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 

            try
            {
                // Renew authorization
                Payment result = apiInstance.POSTPaymentsIdRenewFormat(acceptVersion, authorization, id, quickPayCallbackUrl, synchronized);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentsidsessionformat"></a>
# **POSTPaymentsIdSessionFormat**
> Payment POSTPaymentsIdSessionFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, bool? autoCapture = null, string acquirer = null, bool? autofee = null, string customerIp = null, string personFirstName = null, string personLastName = null, string personEmail = null, string extras = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payment id 
            var amount = 56;  // int? | Amount 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 
            var autoCapture = true;  // bool? | When true, payment is captured after authorization. Default is false  (optional) 
            var acquirer = acquirer_example;  // string | If set, will force the use of this acquirer  (optional) 
            var autofee = true;  // bool? | When true, fee is calculated and added to the given amount. Default is merchant autofee  (optional) 
            var customerIp = customerIp_example;  // string | Customer IP  (optional) 
            var personFirstName = personFirstName_example;  // string | Person first name  (optional) 
            var personLastName = personLastName_example;  // string | Person last name  (optional) 
            var personEmail = personEmail_example;  // string | Person email  (optional) 
            var extras = extras_example;  // string | Additional acquirer specific params  (optional) 

            try
            {
                // Create payment session
                Payment result = apiInstance.POSTPaymentsIdSessionFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, autoCapture, acquirer, autofee, customerIp, personFirstName, personLastName, personEmail, extras);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Payment id  | 
 **amount** | **int?**| Amount  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 
 **autoCapture** | **bool?**| When true, payment is captured after authorization. Default is false  | [optional] 
 **acquirer** | **string**| If set, will force the use of this acquirer  | [optional] 
 **autofee** | **bool?**| When true, fee is calculated and added to the given amount. Default is merchant autofee  | [optional] 
 **customerIp** | **string**| Customer IP  | [optional] 
 **personFirstName** | **string**| Person first name  | [optional] 
 **personLastName** | **string**| Person last name  | [optional] 
 **personEmail** | **string**| Person email  | [optional] 
 **extras** | **string**| Additional acquirer specific params  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpaymentsidlinkformat"></a>
# **PUTPaymentsIdLinkFormat**
> PaymentLinkUrl PUTPaymentsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId = null, string language = null, string continueUrl = null, string cancelUrl = null, string callbackUrl = null, string paymentMethods = null, bool? autoFee = null, int? brandingId = null, string googleAnalyticsTrackingId = null, string googleAnalyticsClientId = null, string acquirer = null, int? deadline = null, bool? framed = null, string brandingConfig = null, string customerEmail = null, bool? invoiceAddressSelection = null, bool? shippingAddressSelection = null, bool? autoCapture = null)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Transaction id 
            var amount = 56;  // int? | Amount to authorize 
            var agreementId = 56;  // int? | Agreement to use. Defaults to the Payment Window agreement  (optional) 
            var language = language_example;  // string | Language  (optional)  (default to en)
            var continueUrl = continueUrl_example;  // string | Url that cardholder is redirected to after authorize  (optional) 
            var cancelUrl = cancelUrl_example;  // string | Url that cardholder is redirected to after cancelation  (optional) 
            var callbackUrl = callbackUrl_example;  // string | Endpoint for async callback  (optional) 
            var paymentMethods = paymentMethods_example;  // string | Limit payment methods  (optional) 
            var autoFee = true;  // bool? | Add acquirer fee to amount. Default is merchant autofee  (optional) 
            var brandingId = 56;  // int? | Override branding. Default is merchant default branding  (optional) 
            var googleAnalyticsTrackingId = googleAnalyticsTrackingId_example;  // string | Send events to Google Analytics  (optional) 
            var googleAnalyticsClientId = googleAnalyticsClientId_example;  // string | Send events to Google Analytics  (optional) 
            var acquirer = acquirer_example;  // string | Force usage of the given acquirer  (optional) 
            var deadline = 56;  // int? | Set a deadline in seconds for the cardholder to complete  (optional) 
            var framed = true;  // bool? | Allow opening in iframe  (optional) 
            var brandingConfig = brandingConfig_example;  // string | Config for branding. Will be merged with the default config in the branding  (optional) 
            var customerEmail = customerEmail_example;  // string | Required for PayPal. Email of customer.  (optional) 
            var invoiceAddressSelection = true;  // bool? | Get customer invoice address via acquirer (Currently MobilePay and PayPal only)  (optional) 
            var shippingAddressSelection = true;  // bool? | Get customer shipping address via acquirer (Currently MobilePay and PayPal only)  (optional) 
            var autoCapture = true;  // bool? | When true, payment is captured after authorization. Default is false  (optional) 

            try
            {
                // Create or update a payment link
                PaymentLinkUrl result = apiInstance.PUTPaymentsIdLinkFormat(acceptVersion, authorization, id, amount, agreementId, language, continueUrl, cancelUrl, callbackUrl, paymentMethods, autoFee, brandingId, googleAnalyticsTrackingId, googleAnalyticsClientId, acquirer, deadline, framed, brandingConfig, customerEmail, invoiceAddressSelection, shippingAddressSelection, autoCapture);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Transaction id  | 
 **amount** | **int?**| Amount to authorize  | 
 **agreementId** | **int?**| Agreement to use. Defaults to the Payment Window agreement  | [optional] 
 **language** | **string**| Language  | [optional] [default to en]
 **continueUrl** | **string**| Url that cardholder is redirected to after authorize  | [optional] 
 **cancelUrl** | **string**| Url that cardholder is redirected to after cancelation  | [optional] 
 **callbackUrl** | **string**| Endpoint for async callback  | [optional] 
 **paymentMethods** | **string**| Limit payment methods  | [optional] 
 **autoFee** | **bool?**| Add acquirer fee to amount. Default is merchant autofee  | [optional] 
 **brandingId** | **int?**| Override branding. Default is merchant default branding  | [optional] 
 **googleAnalyticsTrackingId** | **string**| Send events to Google Analytics  | [optional] 
 **googleAnalyticsClientId** | **string**| Send events to Google Analytics  | [optional] 
 **acquirer** | **string**| Force usage of the given acquirer  | [optional] 
 **deadline** | **int?**| Set a deadline in seconds for the cardholder to complete  | [optional] 
 **framed** | **bool?**| Allow opening in iframe  | [optional] 
 **brandingConfig** | **string**| Config for branding. Will be merged with the default config in the branding  | [optional] 
 **customerEmail** | **string**| Required for PayPal. Email of customer.  | [optional] 
 **invoiceAddressSelection** | **bool?**| Get customer invoice address via acquirer (Currently MobilePay and PayPal only)  | [optional] 
 **shippingAddressSelection** | **bool?**| Get customer shipping address via acquirer (Currently MobilePay and PayPal only)  | [optional] 
 **autoCapture** | **bool?**| When true, payment is captured after authorization. Default is false  | [optional] 

### Return type

[**PaymentLinkUrl**](PaymentLinkUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

