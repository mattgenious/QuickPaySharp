# IO.Swagger.Api.SubscriptionsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETESubscriptionsIdLinkFormat**](SubscriptionsApi.md#deletesubscriptionsidlinkformat) | **DELETE** /subscriptions/{id}/link | Delete payment link
[**GETSubscriptionsFormat**](SubscriptionsApi.md#getsubscriptionsformat) | **GET** /subscriptions | Get subscriptions
[**GETSubscriptionsIdFormat**](SubscriptionsApi.md#getsubscriptionsidformat) | **GET** /subscriptions/{id} | Get subscription
[**GETSubscriptionsIdOperationsOperationIdFormat**](SubscriptionsApi.md#getsubscriptionsidoperationsoperationidformat) | **GET** /subscriptions/{id}/operations/{operation_id} | Get Operation
[**GETSubscriptionsIdPaymentsFormat**](SubscriptionsApi.md#getsubscriptionsidpaymentsformat) | **GET** /subscriptions/{id}/payments | Get all subscription payments
[**PATCHSubscriptionsIdFormat**](SubscriptionsApi.md#patchsubscriptionsidformat) | **PATCH** /subscriptions/{id} | Update subscription
[**PATCHSubscriptionsIdOperationsOperationIdFormat**](SubscriptionsApi.md#patchsubscriptionsidoperationsoperationidformat) | **PATCH** /subscriptions/{id}/operations/{operation_id} | Update operation
[**POSTSubscriptionsFormat**](SubscriptionsApi.md#postsubscriptionsformat) | **POST** /subscriptions | Create subscription
[**POSTSubscriptionsIdAuthorizeFormat**](SubscriptionsApi.md#postsubscriptionsidauthorizeformat) | **POST** /subscriptions/{id}/authorize | Authorize a subscription
[**POSTSubscriptionsIdCancelFormat**](SubscriptionsApi.md#postsubscriptionsidcancelformat) | **POST** /subscriptions/{id}/cancel | Cancel subscription
[**POSTSubscriptionsIdFraudReportFormat**](SubscriptionsApi.md#postsubscriptionsidfraudreportformat) | **POST** /subscriptions/{id}/fraud-report | Create fraud confirmation report
[**POSTSubscriptionsIdRecurringFormat**](SubscriptionsApi.md#postsubscriptionsidrecurringformat) | **POST** /subscriptions/{id}/recurring | Create subscription recurring payment
[**POSTSubscriptionsIdSessionFormat**](SubscriptionsApi.md#postsubscriptionsidsessionformat) | **POST** /subscriptions/{id}/session | Create subscription session
[**PUTSubscriptionsIdLinkFormat**](SubscriptionsApi.md#putsubscriptionsidlinkformat) | **PUT** /subscriptions/{id}/link | Create or update a payment link


<a name="deletesubscriptionsidlinkformat"></a>
# **DELETESubscriptionsIdLinkFormat**
> void DELETESubscriptionsIdLinkFormat (string acceptVersion, string authorization, int? id)

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
    public class DELETESubscriptionsIdLinkFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Transaction id 

            try
            {
                // Delete payment link
                apiInstance.DELETESubscriptionsIdLinkFormat(acceptVersion, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.DELETESubscriptionsIdLinkFormat: " + e.Message );
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

<a name="getsubscriptionsformat"></a>
# **GETSubscriptionsFormat**
> Subscription GETSubscriptionsFormat (string acceptVersion, string authorization, int? dateYear = null, int? dateMonth = null, int? dateDay = null, int? dateHour = null, int? dateMinute = null, string timestamp = null, string minTime = null, string maxTime = null, int? operationsSize = null, bool? accepted = null, string orderId = null, string state = null, int? id = null, string acquirer = null, int? groupId = null, bool? fraudSuspected = null, bool? expired = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null)

Get subscriptions

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETSubscriptionsFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
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
            var accepted = true;  // bool? | Return accepted subscriptions  (optional) 
            var orderId = orderId_example;  // string | Find by order_id  (optional) 
            var state = state_example;  // string | Filter by state  (optional) 
            var id = 56;  // int? | Find by subscription id  (optional) 
            var acquirer = acquirer_example;  // string | Filter by acquirer  (optional) 
            var groupId = 56;  // int? | Filter by subscription group  (optional) 
            var fraudSuspected = true;  // bool? | Filter by suspected fraud  (optional) 
            var expired = true;  // bool? | Filter by expiration  (optional) 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)
            var pageKey = pageKey_example;  // string |   (optional) 

            try
            {
                // Get subscriptions
                Subscription result = apiInstance.GETSubscriptionsFormat(acceptVersion, authorization, dateYear, dateMonth, dateDay, dateHour, dateMinute, timestamp, minTime, maxTime, operationsSize, accepted, orderId, state, id, acquirer, groupId, fraudSuspected, expired, page, pageSize, sortBy, sortDir, pageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GETSubscriptionsFormat: " + e.Message );
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
 **accepted** | **bool?**| Return accepted subscriptions  | [optional] 
 **orderId** | **string**| Find by order_id  | [optional] 
 **state** | **string**| Filter by state  | [optional] 
 **id** | **int?**| Find by subscription id  | [optional] 
 **acquirer** | **string**| Filter by acquirer  | [optional] 
 **groupId** | **int?**| Filter by subscription group  | [optional] 
 **fraudSuspected** | **bool?**| Filter by suspected fraud  | [optional] 
 **expired** | **bool?**| Filter by expiration  | [optional] 
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]
 **sortBy** | **string**| Property to sort by  | [optional] [default to id]
 **sortDir** | **string**| Sort direction  | [optional] [default to desc]
 **pageKey** | **string**|   | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionsidformat"></a>
# **GETSubscriptionsIdFormat**
> Subscription GETSubscriptionsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize = null)

Get subscription

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETSubscriptionsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var operationsSize = 56;  // int? | Maximum number of operations to retrieve  (optional) 

            try
            {
                // Get subscription
                Subscription result = apiInstance.GETSubscriptionsIdFormat(acceptVersion, authorization, id, operationsSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GETSubscriptionsIdFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
 **operationsSize** | **int?**| Maximum number of operations to retrieve  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionsidoperationsoperationidformat"></a>
# **GETSubscriptionsIdOperationsOperationIdFormat**
> Operation GETSubscriptionsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId)

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
    public class GETSubscriptionsIdOperationsOperationIdFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var operationId = 56;  // int? | Operations id 

            try
            {
                // Get Operation
                Operation result = apiInstance.GETSubscriptionsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GETSubscriptionsIdOperationsOperationIdFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
 **operationId** | **int?**| Operations id  | 

### Return type

[**Operation**](Operation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionsidpaymentsformat"></a>
# **GETSubscriptionsIdPaymentsFormat**
> Payment GETSubscriptionsIdPaymentsFormat (string acceptVersion, string authorization, int? id, bool? accepted = null, int? dateYear = null, int? dateMonth = null, int? dateDay = null, int? dateHour = null, int? dateMinute = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null)

Get all subscription payments

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETSubscriptionsIdPaymentsFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var accepted = true;  // bool? | Return accepted payments  (optional) 
            var dateYear = 56;  // int? | Year  (optional) 
            var dateMonth = 56;  // int? | Month  (optional) 
            var dateDay = 56;  // int? | Day of the month  (optional) 
            var dateHour = 56;  // int? | Hour of the day  (optional) 
            var dateMinute = 56;  // int? | Minute of the hour  (optional) 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to payment_id)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)

            try
            {
                // Get all subscription payments
                Payment result = apiInstance.GETSubscriptionsIdPaymentsFormat(acceptVersion, authorization, id, accepted, dateYear, dateMonth, dateDay, dateHour, dateMinute, page, pageSize, sortBy, sortDir);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GETSubscriptionsIdPaymentsFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
 **accepted** | **bool?**| Return accepted payments  | [optional] 
 **dateYear** | **int?**| Year  | [optional] 
 **dateMonth** | **int?**| Month  | [optional] 
 **dateDay** | **int?**| Day of the month  | [optional] 
 **dateHour** | **int?**| Hour of the day  | [optional] 
 **dateMinute** | **int?**| Minute of the hour  | [optional] 
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]
 **sortBy** | **string**| Property to sort by  | [optional] [default to payment_id]
 **sortDir** | **string**| Sort direction  | [optional] [default to desc]

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchsubscriptionsidformat"></a>
# **PATCHSubscriptionsIdFormat**
> Subscription PATCHSubscriptionsIdFormat (string acceptVersion, string authorization, int? id, DateTime? deadlineAt = null, string groupIds = null, string description = null, string invoiceAddressName = null, string invoiceAddressAtt = null, string invoiceAddressCompanyName = null, string invoiceAddressStreet = null, string invoiceAddressHouseNumber = null, string invoiceAddressHouseExtension = null, string invoiceAddressCity = null, string invoiceAddressZipCode = null, string invoiceAddressRegion = null, string invoiceAddressCountryCode = null, string invoiceAddressVatNo = null, string invoiceAddressPhoneNumber = null, string invoiceAddressMobileNumber = null, string invoiceAddressEmail = null, string shippingAddressName = null, string shippingAddressAtt = null, string shippingAddressCompanyName = null, string shippingAddressStreet = null, string shippingAddressHouseNumber = null, string shippingAddressHouseExtension = null, string shippingAddressCity = null, string shippingAddressZipCode = null, string shippingAddressRegion = null, string shippingAddressCountryCode = null, string shippingAddressVatNo = null, string shippingAddressPhoneNumber = null, string shippingAddressMobileNumber = null, string shippingAddressEmail = null, string variables = null)

Update subscription

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHSubscriptionsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var deadlineAt = 2013-10-20T19:20:30+01:00;  // DateTime? | Subscription must be authorized before this time  (optional) 
            var groupIds = groupIds_example;  // string | Ids of subscription groups  (optional) 
            var description = description_example;  // string | Subscription description  (optional) 
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
            var variables = variables_example;  // string | Custom variables  (optional) 

            try
            {
                // Update subscription
                Subscription result = apiInstance.PATCHSubscriptionsIdFormat(acceptVersion, authorization, id, deadlineAt, groupIds, description, invoiceAddressName, invoiceAddressAtt, invoiceAddressCompanyName, invoiceAddressStreet, invoiceAddressHouseNumber, invoiceAddressHouseExtension, invoiceAddressCity, invoiceAddressZipCode, invoiceAddressRegion, invoiceAddressCountryCode, invoiceAddressVatNo, invoiceAddressPhoneNumber, invoiceAddressMobileNumber, invoiceAddressEmail, shippingAddressName, shippingAddressAtt, shippingAddressCompanyName, shippingAddressStreet, shippingAddressHouseNumber, shippingAddressHouseExtension, shippingAddressCity, shippingAddressZipCode, shippingAddressRegion, shippingAddressCountryCode, shippingAddressVatNo, shippingAddressPhoneNumber, shippingAddressMobileNumber, shippingAddressEmail, variables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.PATCHSubscriptionsIdFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
 **deadlineAt** | **DateTime?**| Subscription must be authorized before this time  | [optional] 
 **groupIds** | **string**| Ids of subscription groups  | [optional] 
 **description** | **string**| Subscription description  | [optional] 
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
 **variables** | **string**| Custom variables  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchsubscriptionsidoperationsoperationidformat"></a>
# **PATCHSubscriptionsIdOperationsOperationIdFormat**
> Operation PATCHSubscriptionsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId, bool? pending)

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
    public class PATCHSubscriptionsIdOperationsOperationIdFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var operationId = 56;  // int? | Operations id 
            var pending = true;  // bool? | Aborts the operation. Only possible on cancel operations (false is the only allowed value) 

            try
            {
                // Update operation
                Operation result = apiInstance.PATCHSubscriptionsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId, pending);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.PATCHSubscriptionsIdOperationsOperationIdFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
 **operationId** | **int?**| Operations id  | 
 **pending** | **bool?**| Aborts the operation. Only possible on cancel operations (false is the only allowed value)  | 

### Return type

[**Operation**](Operation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptionsformat"></a>
# **POSTSubscriptionsFormat**
> Subscription POSTSubscriptionsFormat (string acceptVersion, string authorization, string orderId, string currency, string description, string invoiceAddressName = null, string invoiceAddressAtt = null, string invoiceAddressCompanyName = null, string invoiceAddressStreet = null, string invoiceAddressHouseNumber = null, string invoiceAddressHouseExtension = null, string invoiceAddressCity = null, string invoiceAddressZipCode = null, string invoiceAddressRegion = null, string invoiceAddressCountryCode = null, string invoiceAddressVatNo = null, string invoiceAddressPhoneNumber = null, string invoiceAddressMobileNumber = null, string invoiceAddressEmail = null, string shippingAddressName = null, string shippingAddressAtt = null, string shippingAddressCompanyName = null, string shippingAddressStreet = null, string shippingAddressHouseNumber = null, string shippingAddressHouseExtension = null, string shippingAddressCity = null, string shippingAddressZipCode = null, string shippingAddressRegion = null, string shippingAddressCountryCode = null, string shippingAddressVatNo = null, string shippingAddressPhoneNumber = null, string shippingAddressMobileNumber = null, string shippingAddressEmail = null, string variables = null, int? brandingId = null, string groupIds = null, string textOnStatement = null, string shopsystemName = null, string shopsystemVersion = null)

Create subscription

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTSubscriptionsFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var orderId = orderId_example;  // string | Unique order id(must be between 4-20 characters) 
            var currency = currency_example;  // string | Currency 
            var description = description_example;  // string | Subscription description 
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
            var variables = variables_example;  // string | Custom variables  (optional)  (default to {})
            var brandingId = 56;  // int? | Used branding id  (optional) 
            var groupIds = groupIds_example;  // string | Ids of subscription groups  (optional) 
            var textOnStatement = textOnStatement_example;  // string | Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.  (optional) 
            var shopsystemName = shopsystemName_example;  // string | Shop system module name  (optional) 
            var shopsystemVersion = shopsystemVersion_example;  // string | Shop system module version  (optional) 

            try
            {
                // Create subscription
                Subscription result = apiInstance.POSTSubscriptionsFormat(acceptVersion, authorization, orderId, currency, description, invoiceAddressName, invoiceAddressAtt, invoiceAddressCompanyName, invoiceAddressStreet, invoiceAddressHouseNumber, invoiceAddressHouseExtension, invoiceAddressCity, invoiceAddressZipCode, invoiceAddressRegion, invoiceAddressCountryCode, invoiceAddressVatNo, invoiceAddressPhoneNumber, invoiceAddressMobileNumber, invoiceAddressEmail, shippingAddressName, shippingAddressAtt, shippingAddressCompanyName, shippingAddressStreet, shippingAddressHouseNumber, shippingAddressHouseExtension, shippingAddressCity, shippingAddressZipCode, shippingAddressRegion, shippingAddressCountryCode, shippingAddressVatNo, shippingAddressPhoneNumber, shippingAddressMobileNumber, shippingAddressEmail, variables, brandingId, groupIds, textOnStatement, shopsystemName, shopsystemVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.POSTSubscriptionsFormat: " + e.Message );
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
 **orderId** | **string**| Unique order id(must be between 4-20 characters)  | 
 **currency** | **string**| Currency  | 
 **description** | **string**| Subscription description  | 
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
 **variables** | **string**| Custom variables  | [optional] [default to {}]
 **brandingId** | **int?**| Used branding id  | [optional] 
 **groupIds** | **string**| Ids of subscription groups  | [optional] 
 **textOnStatement** | **string**| Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.  | [optional] 
 **shopsystemName** | **string**| Shop system module name  | [optional] 
 **shopsystemVersion** | **string**| Shop system module version  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptionsidauthorizeformat"></a>
# **POSTSubscriptionsIdAuthorizeFormat**
> Subscription POSTSubscriptionsIdAuthorizeFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl = null, bool? synchronized = null, float? vatRate = null, string cardNumber = null, string cardExpiration = null, string cardCvd = null, string cardToken = null, string cardApplePayToken = null, string cardMobilepayOnlineToken = null, string cardIssuedTo = null, string cardBrand = null, string cardStatus = null, string cardEci = null, string cardXav = null, string cardCavv = null, string mobileNumber = null, string ninNumber = null, string ninCountryCode = null, string ninGender = null, string personFirstName = null, string personLastName = null, string personEmail = null, string acquirer = null, string customerIp = null, string extras = null)

Authorize a subscription

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTSubscriptionsIdAuthorizeFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
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
            var acquirer = acquirer_example;  // string | If set, will force the use of this acquirer  (optional) 
            var customerIp = customerIp_example;  // string | Customer IP  (optional) 
            var extras = extras_example;  // string | Additional acquirer specific params  (optional) 

            try
            {
                // Authorize a subscription
                Subscription result = apiInstance.POSTSubscriptionsIdAuthorizeFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, cardNumber, cardExpiration, cardCvd, cardToken, cardApplePayToken, cardMobilepayOnlineToken, cardIssuedTo, cardBrand, cardStatus, cardEci, cardXav, cardCavv, mobileNumber, ninNumber, ninCountryCode, ninGender, personFirstName, personLastName, personEmail, acquirer, customerIp, extras);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.POSTSubscriptionsIdAuthorizeFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
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
 **acquirer** | **string**| If set, will force the use of this acquirer  | [optional] 
 **customerIp** | **string**| Customer IP  | [optional] 
 **extras** | **string**| Additional acquirer specific params  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptionsidcancelformat"></a>
# **POSTSubscriptionsIdCancelFormat**
> Subscription POSTSubscriptionsIdCancelFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, bool? synchronized = null)

Cancel subscription

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTSubscriptionsIdCancelFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 

            try
            {
                // Cancel subscription
                Subscription result = apiInstance.POSTSubscriptionsIdCancelFormat(acceptVersion, authorization, id, quickPayCallbackUrl, synchronized);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.POSTSubscriptionsIdCancelFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptionsidfraudreportformat"></a>
# **POSTSubscriptionsIdFraudReportFormat**
> FraudReport POSTSubscriptionsIdFraudReportFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, string description = null)

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
    public class POSTSubscriptionsIdFraudReportFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var description = description_example;  // string |   (optional) 

            try
            {
                // Create fraud confirmation report
                FraudReport result = apiInstance.POSTSubscriptionsIdFraudReportFormat(acceptVersion, authorization, id, quickPayCallbackUrl, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.POSTSubscriptionsIdFraudReportFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
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

<a name="postsubscriptionsidrecurringformat"></a>
# **POSTSubscriptionsIdRecurringFormat**
> Payment POSTSubscriptionsIdRecurringFormat (string acceptVersion, string authorization, int? id, int? amount, string orderId, string quickPayCallbackUrl = null, bool? synchronized = null, bool? autoCapture = null, bool? autofee = null, bool? zeroAuth = null, string textOnStatement = null)

Create subscription recurring payment

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTSubscriptionsIdRecurringFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var amount = 56;  // int? | Amount 
            var orderId = orderId_example;  // string | Unique order id(must be between 4-20 characters) 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var synchronized = true;  // bool? | DEPRECATED: it will be removed in v11. Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 
            var autoCapture = true;  // bool? | When true, payment is captured after authorization. Default is false  (optional) 
            var autofee = true;  // bool? | When true, fee is calculated and added to the given amount. Default is merchant autofee  (optional) 
            var zeroAuth = true;  // bool? | (Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false  (optional) 
            var textOnStatement = textOnStatement_example;  // string | Text to be displayed on cardholder’s statement. This overrides text_on_statement on authorize. Max 22 ASCII chars. Currently supported by Clearhaus only.  (optional) 

            try
            {
                // Create subscription recurring payment
                Payment result = apiInstance.POSTSubscriptionsIdRecurringFormat(acceptVersion, authorization, id, amount, orderId, quickPayCallbackUrl, synchronized, autoCapture, autofee, zeroAuth, textOnStatement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.POSTSubscriptionsIdRecurringFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
 **amount** | **int?**| Amount  | 
 **orderId** | **string**| Unique order id(must be between 4-20 characters)  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **synchronized** | **bool?**| DEPRECATED: it will be removed in v11. Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 
 **autoCapture** | **bool?**| When true, payment is captured after authorization. Default is false  | [optional] 
 **autofee** | **bool?**| When true, fee is calculated and added to the given amount. Default is merchant autofee  | [optional] 
 **zeroAuth** | **bool?**| (Nets only) When true, will perform an initial authorize of zero, then authorize the full amount on capture. Default is false  | [optional] 
 **textOnStatement** | **string**| Text to be displayed on cardholder’s statement. This overrides text_on_statement on authorize. Max 22 ASCII chars. Currently supported by Clearhaus only.  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptionsidsessionformat"></a>
# **POSTSubscriptionsIdSessionFormat**
> Subscription POSTSubscriptionsIdSessionFormat (string acceptVersion, string authorization, int? id, string quickPayCallbackUrl = null, string acquirer = null, bool? autofee = null, string customerIp = null, string extras = null)

Create subscription session

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTSubscriptionsIdSessionFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription id 
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var acquirer = acquirer_example;  // string | If set, will force the use of this acquirer  (optional) 
            var autofee = true;  // bool? | When true, fee is calculated and added to the given amount. Default is merchant autofee  (optional) 
            var customerIp = customerIp_example;  // string | Customer IP  (optional) 
            var extras = extras_example;  // string | Additional acquirer specific params  (optional) 

            try
            {
                // Create subscription session
                Subscription result = apiInstance.POSTSubscriptionsIdSessionFormat(acceptVersion, authorization, id, quickPayCallbackUrl, acquirer, autofee, customerIp, extras);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.POSTSubscriptionsIdSessionFormat: " + e.Message );
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
 **id** | **int?**| Subscription id  | 
 **quickPayCallbackUrl** | **string**| Specify the callback url (overrides merchant default callback-url)  | [optional] 
 **acquirer** | **string**| If set, will force the use of this acquirer  | [optional] 
 **autofee** | **bool?**| When true, fee is calculated and added to the given amount. Default is merchant autofee  | [optional] 
 **customerIp** | **string**| Customer IP  | [optional] 
 **extras** | **string**| Additional acquirer specific params  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsubscriptionsidlinkformat"></a>
# **PUTSubscriptionsIdLinkFormat**
> PaymentLinkUrl PUTSubscriptionsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId = null, string language = null, string continueUrl = null, string cancelUrl = null, string callbackUrl = null, string paymentMethods = null, bool? autoFee = null, int? brandingId = null, string googleAnalyticsTrackingId = null, string googleAnalyticsClientId = null, string acquirer = null, int? deadline = null, bool? framed = null, string brandingConfig = null, string customerEmail = null, bool? invoiceAddressSelection = null, bool? shippingAddressSelection = null)

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
    public class PUTSubscriptionsIdLinkFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
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

            try
            {
                // Create or update a payment link
                PaymentLinkUrl result = apiInstance.PUTSubscriptionsIdLinkFormat(acceptVersion, authorization, id, amount, agreementId, language, continueUrl, cancelUrl, callbackUrl, paymentMethods, autoFee, brandingId, googleAnalyticsTrackingId, googleAnalyticsClientId, acquirer, deadline, framed, brandingConfig, customerEmail, invoiceAddressSelection, shippingAddressSelection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.PUTSubscriptionsIdLinkFormat: " + e.Message );
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

### Return type

[**PaymentLinkUrl**](PaymentLinkUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

