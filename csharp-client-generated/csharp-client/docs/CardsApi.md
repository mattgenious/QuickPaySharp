# IO.Swagger.Api.CardsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETECardsIdLinkFormat**](CardsApi.md#deletecardsidlinkformat) | **DELETE** /cards/{id}/link | Delete card link
[**GETCardsFormat**](CardsApi.md#getcardsformat) | **GET** /cards | Get saved cards
[**GETCardsIdFormat**](CardsApi.md#getcardsidformat) | **GET** /cards/{id} | Get saved card
[**GETCardsIdOperationsOperationIdFormat**](CardsApi.md#getcardsidoperationsoperationidformat) | **GET** /cards/{id}/operations/{operation_id} | Get Operation
[**PATCHCardsIdFormat**](CardsApi.md#patchcardsidformat) | **PATCH** /cards/{id} | Update saved card
[**POSTCardsFormat**](CardsApi.md#postcardsformat) | **POST** /cards | Create saved card
[**POSTCardsIdAuthorizeFormat**](CardsApi.md#postcardsidauthorizeformat) | **POST** /cards/{id}/authorize | Authorize saved card
[**POSTCardsIdCancelFormat**](CardsApi.md#postcardsidcancelformat) | **POST** /cards/{id}/cancel | Cancel saved card
[**POSTCardsIdFraudReportFormat**](CardsApi.md#postcardsidfraudreportformat) | **POST** /cards/{id}/fraud-report | Create fraud confirmation report
[**POSTCardsIdTokensFormat**](CardsApi.md#postcardsidtokensformat) | **POST** /cards/{id}/tokens | Create card token
[**PUTCardsIdLinkFormat**](CardsApi.md#putcardsidlinkformat) | **PUT** /cards/{id}/link | Create or update a card link


<a name="deletecardsidlinkformat"></a>
# **DELETECardsIdLinkFormat**
> void DELETECardsIdLinkFormat (string acceptVersion, string authorization, string id)

Delete card link

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETECardsIdLinkFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = id_example;  // string |  

            try
            {
                // Delete card link
                apiInstance.DELETECardsIdLinkFormat(acceptVersion, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.DELETECardsIdLinkFormat: " + e.Message );
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
 **id** | **string**|   | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcardsformat"></a>
# **GETCardsFormat**
> Card GETCardsFormat (string acceptVersion, string authorization, string timestamp = null, string minTime = null, string maxTime = null, bool? fraudSuspected = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, int? pageKey = null)

Get saved cards

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETCardsFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var timestamp = timestamp_example;  // string | Timestamp field  (optional)  (default to created_at)
            var minTime = minTime_example;  // string | Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”  (optional) 
            var maxTime = maxTime_example;  // string | Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”  (optional) 
            var fraudSuspected = true;  // bool? | Filter by suspected fraud  (optional) 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)
            var pageKey = 56;  // int? |   (optional) 

            try
            {
                // Get saved cards
                Card result = apiInstance.GETCardsFormat(acceptVersion, authorization, timestamp, minTime, maxTime, fraudSuspected, page, pageSize, sortBy, sortDir, pageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.GETCardsFormat: " + e.Message );
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
 **timestamp** | **string**| Timestamp field  | [optional] [default to created_at]
 **minTime** | **string**| Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”  | [optional] 
 **maxTime** | **string**| Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”  | [optional] 
 **fraudSuspected** | **bool?**| Filter by suspected fraud  | [optional] 
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]
 **sortBy** | **string**| Property to sort by  | [optional] [default to id]
 **sortDir** | **string**| Sort direction  | [optional] [default to desc]
 **pageKey** | **int?**|   | [optional] 

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcardsidformat"></a>
# **GETCardsIdFormat**
> Card GETCardsIdFormat (string acceptVersion, string authorization, string id)

Get saved card

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETCardsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = id_example;  // string |  

            try
            {
                // Get saved card
                Card result = apiInstance.GETCardsIdFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.GETCardsIdFormat: " + e.Message );
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
 **id** | **string**|   | 

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcardsidoperationsoperationidformat"></a>
# **GETCardsIdOperationsOperationIdFormat**
> CardOperation GETCardsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? operationId, string id)

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
    public class GETCardsIdOperationsOperationIdFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var operationId = 56;  // int? | Operations id 
            var id = id_example;  // string |  

            try
            {
                // Get Operation
                CardOperation result = apiInstance.GETCardsIdOperationsOperationIdFormat(acceptVersion, authorization, operationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.GETCardsIdOperationsOperationIdFormat: " + e.Message );
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
 **operationId** | **int?**| Operations id  | 
 **id** | **string**|   | 

### Return type

[**CardOperation**](CardOperation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcardsidformat"></a>
# **PATCHCardsIdFormat**
> Card PATCHCardsIdFormat (string acceptVersion, string authorization, string id, string variables = null)

Update saved card

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHCardsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = id_example;  // string |  
            var variables = variables_example;  // string | Custom variables  (optional) 

            try
            {
                // Update saved card
                Card result = apiInstance.PATCHCardsIdFormat(acceptVersion, authorization, id, variables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.PATCHCardsIdFormat: " + e.Message );
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
 **id** | **string**|   | 
 **variables** | **string**| Custom variables  | [optional] 

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardsformat"></a>
# **POSTCardsFormat**
> Card POSTCardsFormat (string acceptVersion, string authorization, string variables = null)

Create saved card

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTCardsFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var variables = variables_example;  // string | Custom variables  (optional)  (default to {})

            try
            {
                // Create saved card
                Card result = apiInstance.POSTCardsFormat(acceptVersion, authorization, variables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.POSTCardsFormat: " + e.Message );
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
 **variables** | **string**| Custom variables  | [optional] [default to {}]

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardsidauthorizeformat"></a>
# **POSTCardsIdAuthorizeFormat**
> Card POSTCardsIdAuthorizeFormat (string acceptVersion, string authorization, string cardNumber, string cardExpiration, string id, bool? synchronized = null, string cardCvd = null, string cardIssuedTo = null, string cardBrand = null, string acquirer = null, string customerIp = null, string extras = null)

Authorize saved card

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTCardsIdAuthorizeFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var cardNumber = cardNumber_example;  // string | Card number 
            var cardExpiration = cardExpiration_example;  // string | Expiration date (YYMM) 
            var id = id_example;  // string |  
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 
            var cardCvd = cardCvd_example;  // string | CVD/CVV  (optional) 
            var cardIssuedTo = cardIssuedTo_example;  // string | Card holder name  (optional) 
            var cardBrand = cardBrand_example;  // string | Brand to use on multi-brand card  (optional) 
            var acquirer = acquirer_example;  // string | If set, will force the use of this acquirer  (optional) 
            var customerIp = customerIp_example;  // string | Customer IP  (optional) 
            var extras = extras_example;  // string | Additional acquirer specific params  (optional) 

            try
            {
                // Authorize saved card
                Card result = apiInstance.POSTCardsIdAuthorizeFormat(acceptVersion, authorization, cardNumber, cardExpiration, id, synchronized, cardCvd, cardIssuedTo, cardBrand, acquirer, customerIp, extras);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.POSTCardsIdAuthorizeFormat: " + e.Message );
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
 **cardNumber** | **string**| Card number  | 
 **cardExpiration** | **string**| Expiration date (YYMM)  | 
 **id** | **string**|   | 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 
 **cardCvd** | **string**| CVD/CVV  | [optional] 
 **cardIssuedTo** | **string**| Card holder name  | [optional] 
 **cardBrand** | **string**| Brand to use on multi-brand card  | [optional] 
 **acquirer** | **string**| If set, will force the use of this acquirer  | [optional] 
 **customerIp** | **string**| Customer IP  | [optional] 
 **extras** | **string**| Additional acquirer specific params  | [optional] 

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardsidcancelformat"></a>
# **POSTCardsIdCancelFormat**
> Card POSTCardsIdCancelFormat (string acceptVersion, string authorization, string id, bool? synchronized = null)

Cancel saved card

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTCardsIdCancelFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = id_example;  // string |  
            var synchronized = true;  // bool? | Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  (optional) 

            try
            {
                // Cancel saved card
                Card result = apiInstance.POSTCardsIdCancelFormat(acceptVersion, authorization, id, synchronized);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.POSTCardsIdCancelFormat: " + e.Message );
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
 **id** | **string**|   | 
 **synchronized** | **bool?**| Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)  | [optional] 

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardsidfraudreportformat"></a>
# **POSTCardsIdFraudReportFormat**
> FraudReport POSTCardsIdFraudReportFormat (string acceptVersion, string authorization, string id, string quickPayCallbackUrl = null, string description = null)

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
    public class POSTCardsIdFraudReportFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = id_example;  // string |  
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | Specify the callback url (overrides merchant default callback-url)  (optional) 
            var description = description_example;  // string |   (optional) 

            try
            {
                // Create fraud confirmation report
                FraudReport result = apiInstance.POSTCardsIdFraudReportFormat(acceptVersion, authorization, id, quickPayCallbackUrl, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.POSTCardsIdFraudReportFormat: " + e.Message );
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
 **id** | **string**|   | 
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

<a name="postcardsidtokensformat"></a>
# **POSTCardsIdTokensFormat**
> CardToken POSTCardsIdTokensFormat (string acceptVersion, string authorization, string id)

Create card token

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTCardsIdTokensFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = id_example;  // string |  

            try
            {
                // Create card token
                CardToken result = apiInstance.POSTCardsIdTokensFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.POSTCardsIdTokensFormat: " + e.Message );
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
 **id** | **string**|   | 

### Return type

[**CardToken**](CardToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcardsidlinkformat"></a>
# **PUTCardsIdLinkFormat**
> CardLinkUrl PUTCardsIdLinkFormat (string acceptVersion, string authorization, string id, int? agreementId = null, string language = null, string continueurl = null, string cancelurl = null, string callbackurl = null, string paymentMethods = null, int? brandingId = null, string googleAnalyticsTrackingId = null, string googleAnalyticsClientId = null, string acquirer = null, bool? framed = null, string brandingConfig = null)

Create or update a card link

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PUTCardsIdLinkFormatExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = id_example;  // string |  
            var agreementId = 56;  // int? | Agreement to use. Defaults to the Payment Window agreement  (optional) 
            var language = language_example;  // string | Language  (optional)  (default to en)
            var continueurl = continueurl_example;  // string | Url that cardholder is redirected to after authorize  (optional) 
            var cancelurl = cancelurl_example;  // string | Url that cardholder is redirected to after cancelation  (optional) 
            var callbackurl = callbackurl_example;  // string | Endpoint for async callback  (optional) 
            var paymentMethods = paymentMethods_example;  // string | Limit payment methods  (optional)  (default to creditcard)
            var brandingId = 56;  // int? | Override branding. Default is merchant default branding  (optional) 
            var googleAnalyticsTrackingId = googleAnalyticsTrackingId_example;  // string | Send events to Google Analytics  (optional) 
            var googleAnalyticsClientId = googleAnalyticsClientId_example;  // string | Send events to Google Analytics  (optional) 
            var acquirer = acquirer_example;  // string | Force usage of the given acquirer  (optional) 
            var framed = true;  // bool? | Allow opening in iframe  (optional) 
            var brandingConfig = brandingConfig_example;  // string | Config for branding. Will be merged with the default config in the branding  (optional) 

            try
            {
                // Create or update a card link
                CardLinkUrl result = apiInstance.PUTCardsIdLinkFormat(acceptVersion, authorization, id, agreementId, language, continueurl, cancelurl, callbackurl, paymentMethods, brandingId, googleAnalyticsTrackingId, googleAnalyticsClientId, acquirer, framed, brandingConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.PUTCardsIdLinkFormat: " + e.Message );
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
 **id** | **string**|   | 
 **agreementId** | **int?**| Agreement to use. Defaults to the Payment Window agreement  | [optional] 
 **language** | **string**| Language  | [optional] [default to en]
 **continueurl** | **string**| Url that cardholder is redirected to after authorize  | [optional] 
 **cancelurl** | **string**| Url that cardholder is redirected to after cancelation  | [optional] 
 **callbackurl** | **string**| Endpoint for async callback  | [optional] 
 **paymentMethods** | **string**| Limit payment methods  | [optional] [default to creditcard]
 **brandingId** | **int?**| Override branding. Default is merchant default branding  | [optional] 
 **googleAnalyticsTrackingId** | **string**| Send events to Google Analytics  | [optional] 
 **googleAnalyticsClientId** | **string**| Send events to Google Analytics  | [optional] 
 **acquirer** | **string**| Force usage of the given acquirer  | [optional] 
 **framed** | **bool?**| Allow opening in iframe  | [optional] 
 **brandingConfig** | **string**| Config for branding. Will be merged with the default config in the branding  | [optional] 

### Return type

[**CardLinkUrl**](CardLinkUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

