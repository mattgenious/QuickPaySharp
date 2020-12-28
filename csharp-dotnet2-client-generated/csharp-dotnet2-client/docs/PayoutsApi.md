# IO.Swagger.Api.PayoutsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETEPayoutsIdLinkFormat**](PayoutsApi.md#deletepayoutsidlinkformat) | **DELETE** /payouts/{id}/link | Delete payout link
[**GETPayoutsFormat**](PayoutsApi.md#getpayoutsformat) | **GET** /payouts | Get payouts
[**GETPayoutsIdFormat**](PayoutsApi.md#getpayoutsidformat) | **GET** /payouts/{id} | Get payout
[**GETPayoutsIdOperationsOperationIdFormat**](PayoutsApi.md#getpayoutsidoperationsoperationidformat) | **GET** /payouts/{id}/operations/{operation_id} | Get Operation
[**PATCHPayoutsIdFormat**](PayoutsApi.md#patchpayoutsidformat) | **PATCH** /payouts/{id} | Update payout
[**POSTPayoutsFormat**](PayoutsApi.md#postpayoutsformat) | **POST** /payouts | Create payout
[**POSTPayoutsIdCreditFormat**](PayoutsApi.md#postpayoutsidcreditformat) | **POST** /payouts/{id}/credit | Authorize a payout
[**PUTPayoutsIdLinkFormat**](PayoutsApi.md#putpayoutsidlinkformat) | **PUT** /payouts/{id}/link | Create or update a payout link


<a name="deletepayoutsidlinkformat"></a>
# **DELETEPayoutsIdLinkFormat**
> void DELETEPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id)

Delete payout link

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEPayoutsIdLinkFormatExample
    {
        public void main()
        {
            
            var apiInstance = new PayoutsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payout id 

            try
            {
                // Delete payout link
                apiInstance.DELETEPayoutsIdLinkFormat(acceptVersion, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.DELETEPayoutsIdLinkFormat: " + e.Message );
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
 **id** | **int?**| Payout id  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutsformat"></a>
# **GETPayoutsFormat**
> Payout GETPayoutsFormat (string acceptVersion, string authorization, int? dateYear, int? dateMonth, int? dateDay, int? dateHour, int? dateMinute, string timestamp, string minTime, string maxTime, int? operationsSize, bool? accepted, string orderId, string state, int? id, string acquirer, int? page, int? pageSize, string sortBy, string sortDir)

Get payouts

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETPayoutsFormatExample
    {
        public void main()
        {
            
            var apiInstance = new PayoutsApi();
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
            var accepted = true;  // bool? | Return accepted payouts  (optional) 
            var orderId = orderId_example;  // string | Find by order_id  (optional) 
            var state = state_example;  // string | Find by state  (optional) 
            var id = 56;  // int? | Find by payout id  (optional) 
            var acquirer = acquirer_example;  // string | Filter by acquirer  (optional) 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)

            try
            {
                // Get payouts
                Payout result = apiInstance.GETPayoutsFormat(acceptVersion, authorization, dateYear, dateMonth, dateDay, dateHour, dateMinute, timestamp, minTime, maxTime, operationsSize, accepted, orderId, state, id, acquirer, page, pageSize, sortBy, sortDir);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GETPayoutsFormat: " + e.Message );
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
 **accepted** | **bool?**| Return accepted payouts  | [optional] 
 **orderId** | **string**| Find by order_id  | [optional] 
 **state** | **string**| Find by state  | [optional] 
 **id** | **int?**| Find by payout id  | [optional] 
 **acquirer** | **string**| Filter by acquirer  | [optional] 
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]
 **sortBy** | **string**| Property to sort by  | [optional] [default to id]
 **sortDir** | **string**| Sort direction  | [optional] [default to desc]

### Return type

[**Payout**](Payout.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutsidformat"></a>
# **GETPayoutsIdFormat**
> Payout GETPayoutsIdFormat (string acceptVersion, string authorization, int? id, int? operationsSize)

Get payout

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETPayoutsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new PayoutsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payout id 
            var operationsSize = 56;  // int? | Maximum number of operations to retrieve  (optional) 

            try
            {
                // Get payout
                Payout result = apiInstance.GETPayoutsIdFormat(acceptVersion, authorization, id, operationsSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GETPayoutsIdFormat: " + e.Message );
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
 **id** | **int?**| Payout id  | 
 **operationsSize** | **int?**| Maximum number of operations to retrieve  | [optional] 

### Return type

[**Payout**](Payout.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutsidoperationsoperationidformat"></a>
# **GETPayoutsIdOperationsOperationIdFormat**
> Operation GETPayoutsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? id, int? operationId)

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
    public class GETPayoutsIdOperationsOperationIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new PayoutsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payout id 
            var operationId = 56;  // int? | Operations id 

            try
            {
                // Get Operation
                Operation result = apiInstance.GETPayoutsIdOperationsOperationIdFormat(acceptVersion, authorization, id, operationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.GETPayoutsIdOperationsOperationIdFormat: " + e.Message );
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
 **id** | **int?**| Payout id  | 
 **operationId** | **int?**| Operations id  | 

### Return type

[**Operation**](Operation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpayoutsidformat"></a>
# **PATCHPayoutsIdFormat**
> Payout PATCHPayoutsIdFormat (string acceptVersion, string authorization, int? id, string variables)

Update payout

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHPayoutsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new PayoutsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payout id 
            var variables = variables_example;  // string | Custom variables  (optional) 

            try
            {
                // Update payout
                Payout result = apiInstance.PATCHPayoutsIdFormat(acceptVersion, authorization, id, variables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.PATCHPayoutsIdFormat: " + e.Message );
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
 **id** | **int?**| Payout id  | 
 **variables** | **string**| Custom variables  | [optional] 

### Return type

[**Payout**](Payout.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpayoutsformat"></a>
# **POSTPayoutsFormat**
> Payout POSTPayoutsFormat (string acceptVersion, string authorization, string currency, string orderId, string variables, string textOnStatement)

Create payout

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPayoutsFormatExample
    {
        public void main()
        {
            
            var apiInstance = new PayoutsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var currency = currency_example;  // string | Currency 
            var orderId = orderId_example;  // string | Unique order id(must be between 4-20 characters) 
            var variables = variables_example;  // string | Custom variables  (optional)  (default to {})
            var textOnStatement = textOnStatement_example;  // string | Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.  (optional) 

            try
            {
                // Create payout
                Payout result = apiInstance.POSTPayoutsFormat(acceptVersion, authorization, currency, orderId, variables, textOnStatement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.POSTPayoutsFormat: " + e.Message );
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
 **currency** | **string**| Currency  | 
 **orderId** | **string**| Unique order id(must be between 4-20 characters)  | 
 **variables** | **string**| Custom variables  | [optional] [default to {}]
 **textOnStatement** | **string**| Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.  | [optional] 

### Return type

[**Payout**](Payout.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpayoutsidcreditformat"></a>
# **POSTPayoutsIdCreditFormat**
> Payout POSTPayoutsIdCreditFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, string cardApplePayToken, string cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, string acquirer, string customerIp, string extras)

Authorize a payout

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPayoutsIdCreditFormatExample
    {
        public void main()
        {
            
            var apiInstance = new PayoutsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payout id 
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
                // Authorize a payout
                Payout result = apiInstance.POSTPayoutsIdCreditFormat(acceptVersion, authorization, id, amount, quickPayCallbackUrl, synchronized, vatRate, cardNumber, cardExpiration, cardCvd, cardToken, cardApplePayToken, cardMobilepayOnlineToken, cardIssuedTo, cardBrand, cardStatus, cardEci, cardXav, cardCavv, mobileNumber, ninNumber, ninCountryCode, ninGender, personFirstName, personLastName, personEmail, acquirer, customerIp, extras);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.POSTPayoutsIdCreditFormat: " + e.Message );
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
 **id** | **int?**| Payout id  | 
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

[**Payout**](Payout.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpayoutsidlinkformat"></a>
# **PUTPayoutsIdLinkFormat**
> PaymentLinkUrl PUTPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, string brandingConfig)

Create or update a payout link

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PUTPayoutsIdLinkFormatExample
    {
        public void main()
        {
            
            var apiInstance = new PayoutsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Payout id 
            var amount = 56;  // int? | Amount to credit 
            var agreementId = 56;  // int? | Agreement to use. Defaults to the Payment Window agreement  (optional) 
            var language = language_example;  // string | Language  (optional)  (default to en)
            var continueUrl = continueUrl_example;  // string | Url that cardholder is redirected to after credit  (optional) 
            var cancelUrl = cancelUrl_example;  // string | Url that cardholder is redirected to after cancelation  (optional) 
            var callbackUrl = callbackUrl_example;  // string | Endpoint for async callback  (optional) 
            var paymentMethods = paymentMethods_example;  // string | Limit payment methods  (optional) 
            var brandingId = 56;  // int? | Override branding. Default is merchant default branding  (optional) 
            var googleAnalyticsTrackingId = googleAnalyticsTrackingId_example;  // string | Send events to Google Analytics  (optional) 
            var googleAnalyticsClientId = googleAnalyticsClientId_example;  // string | Send events to Google Analytics  (optional) 
            var acquirer = acquirer_example;  // string | Force usage of the given acquirer  (optional) 
            var framed = true;  // bool? | Allow opening in iframe  (optional) 
            var brandingConfig = brandingConfig_example;  // string | Config for branding. Will be merged with the default config in the branding  (optional) 

            try
            {
                // Create or update a payout link
                PaymentLinkUrl result = apiInstance.PUTPayoutsIdLinkFormat(acceptVersion, authorization, id, amount, agreementId, language, continueUrl, cancelUrl, callbackUrl, paymentMethods, brandingId, googleAnalyticsTrackingId, googleAnalyticsClientId, acquirer, framed, brandingConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PayoutsApi.PUTPayoutsIdLinkFormat: " + e.Message );
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
 **id** | **int?**| Payout id  | 
 **amount** | **int?**| Amount to credit  | 
 **agreementId** | **int?**| Agreement to use. Defaults to the Payment Window agreement  | [optional] 
 **language** | **string**| Language  | [optional] [default to en]
 **continueUrl** | **string**| Url that cardholder is redirected to after credit  | [optional] 
 **cancelUrl** | **string**| Url that cardholder is redirected to after cancelation  | [optional] 
 **callbackUrl** | **string**| Endpoint for async callback  | [optional] 
 **paymentMethods** | **string**| Limit payment methods  | [optional] 
 **brandingId** | **int?**| Override branding. Default is merchant default branding  | [optional] 
 **googleAnalyticsTrackingId** | **string**| Send events to Google Analytics  | [optional] 
 **googleAnalyticsClientId** | **string**| Send events to Google Analytics  | [optional] 
 **acquirer** | **string**| Force usage of the given acquirer  | [optional] 
 **framed** | **bool?**| Allow opening in iframe  | [optional] 
 **brandingConfig** | **string**| Config for branding. Will be merged with the default config in the branding  | [optional] 

### Return type

[**PaymentLinkUrl**](PaymentLinkUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

