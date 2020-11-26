# IO.Swagger.Api.CardsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
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
> QuickPayProtocolV10Card GETCardsFormat (string acceptVersion, string authorization, string timestamp, string minTime, string maxTime, bool? fraudSuspected, int? page, int? pageSize, string sortBy, string sortDir, int? pageKey)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var timestamp = timestamp_example;  // string | <p>Timestamp field</p>  (optional)  (default to created_at)
            var minTime = minTime_example;  // string | <p>Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”</p>  (optional) 
            var maxTime = maxTime_example;  // string | <p>Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”</p>  (optional) 
            var fraudSuspected = true;  // bool? | <p>Filter by suspected fraud</p>  (optional) 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to desc)
            var pageKey = 56;  // int? |   (optional) 

            try
            {
                // Get saved cards
                QuickPayProtocolV10Card result = apiInstance.GETCardsFormat(acceptVersion, authorization, timestamp, minTime, maxTime, fraudSuspected, page, pageSize, sortBy, sortDir, pageKey);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **timestamp** | **string**| &lt;p&gt;Timestamp field&lt;/p&gt;  | [optional] [default to created_at]
 **minTime** | **string**| &lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt;  | [optional] 
 **maxTime** | **string**| &lt;p&gt;Filter payments after the given time. Supported format: “%Y-%m-%d %H:%M:%S %z”&lt;/p&gt;  | [optional] 
 **fraudSuspected** | **bool?**| &lt;p&gt;Filter by suspected fraud&lt;/p&gt;  | [optional] 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to id]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to desc]
 **pageKey** | **int?**|   | [optional] 

### Return type

[**QuickPayProtocolV10Card**](QuickPayProtocolV10Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcardsidformat"></a>
# **GETCardsIdFormat**
> QuickPayProtocolV10Card GETCardsIdFormat (string acceptVersion, string authorization, string id)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = id_example;  // string |  

            try
            {
                // Get saved card
                QuickPayProtocolV10Card result = apiInstance.GETCardsIdFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **string**|   | 

### Return type

[**QuickPayProtocolV10Card**](QuickPayProtocolV10Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcardsidoperationsoperationidformat"></a>
# **GETCardsIdOperationsOperationIdFormat**
> QuickPayProtocolV10CardOperation GETCardsIdOperationsOperationIdFormat (string acceptVersion, string authorization, int? operationId, string id)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var operationId = 56;  // int? | <p>Operations id</p> 
            var id = id_example;  // string |  

            try
            {
                // Get Operation
                QuickPayProtocolV10CardOperation result = apiInstance.GETCardsIdOperationsOperationIdFormat(acceptVersion, authorization, operationId, id);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **operationId** | **int?**| &lt;p&gt;Operations id&lt;/p&gt;  | 
 **id** | **string**|   | 

### Return type

[**QuickPayProtocolV10CardOperation**](QuickPayProtocolV10CardOperation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcardsidformat"></a>
# **PATCHCardsIdFormat**
> QuickPayProtocolV10Card PATCHCardsIdFormat (string acceptVersion, string authorization, string id, Dictionary<string, string> variables)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = id_example;  // string |  
            var variables = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Custom variables</p>  (optional) 

            try
            {
                // Update saved card
                QuickPayProtocolV10Card result = apiInstance.PATCHCardsIdFormat(acceptVersion, authorization, id, variables);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **string**|   | 
 **variables** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Custom variables&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Card**](QuickPayProtocolV10Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardsformat"></a>
# **POSTCardsFormat**
> QuickPayProtocolV10Card POSTCardsFormat (string acceptVersion, string authorization, Dictionary<string, string> variables)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var variables = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Custom variables</p>  (optional)  (default to {})

            try
            {
                // Create saved card
                QuickPayProtocolV10Card result = apiInstance.POSTCardsFormat(acceptVersion, authorization, variables);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **variables** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Custom variables&lt;/p&gt;  | [optional] [default to {}]

### Return type

[**QuickPayProtocolV10Card**](QuickPayProtocolV10Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardsidauthorizeformat"></a>
# **POSTCardsIdAuthorizeFormat**
> QuickPayProtocolV10Card POSTCardsIdAuthorizeFormat (string acceptVersion, string authorization, string cardNumber, string cardExpiration, string id, bool? synchronized, string cardCvd, string cardIssuedTo, string cardBrand, string acquirer, string customerIp, Dictionary<string, string> extras)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var cardNumber = cardNumber_example;  // string | <p>Card number</p> 
            var cardExpiration = cardExpiration_example;  // string | <p>Expiration date (YYMM)</p> 
            var id = id_example;  // string |  
            var synchronized = true;  // bool? | <p>Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)</p>  (optional) 
            var cardCvd = cardCvd_example;  // string | <p>CVD/CVV</p>  (optional) 
            var cardIssuedTo = cardIssuedTo_example;  // string | <p>Card holder name</p>  (optional) 
            var cardBrand = cardBrand_example;  // string | <p>Brand to use on multi-brand card</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>If set, will force the use of this acquirer</p>  (optional) 
            var customerIp = customerIp_example;  // string | <p>Customer IP</p>  (optional) 
            var extras = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Additional acquirer specific params</p>  (optional) 

            try
            {
                // Authorize saved card
                QuickPayProtocolV10Card result = apiInstance.POSTCardsIdAuthorizeFormat(acceptVersion, authorization, cardNumber, cardExpiration, id, synchronized, cardCvd, cardIssuedTo, cardBrand, acquirer, customerIp, extras);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **cardNumber** | **string**| &lt;p&gt;Card number&lt;/p&gt;  | 
 **cardExpiration** | **string**| &lt;p&gt;Expiration date (YYMM)&lt;/p&gt;  | 
 **id** | **string**|   | 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 
 **cardCvd** | **string**| &lt;p&gt;CVD/CVV&lt;/p&gt;  | [optional] 
 **cardIssuedTo** | **string**| &lt;p&gt;Card holder name&lt;/p&gt;  | [optional] 
 **cardBrand** | **string**| &lt;p&gt;Brand to use on multi-brand card&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt;  | [optional] 
 **customerIp** | **string**| &lt;p&gt;Customer IP&lt;/p&gt;  | [optional] 
 **extras** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Additional acquirer specific params&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Card**](QuickPayProtocolV10Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardsidcancelformat"></a>
# **POSTCardsIdCancelFormat**
> QuickPayProtocolV10Card POSTCardsIdCancelFormat (string acceptVersion, string authorization, string id, bool? synchronized)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = id_example;  // string |  
            var synchronized = true;  // bool? | <p>Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)</p>  (optional) 

            try
            {
                // Cancel saved card
                QuickPayProtocolV10Card result = apiInstance.POSTCardsIdCancelFormat(acceptVersion, authorization, id, synchronized);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **string**|   | 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Card**](QuickPayProtocolV10Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcardsidfraudreportformat"></a>
# **POSTCardsIdFraudReportFormat**
> QuickPayProtocolV10FraudReport POSTCardsIdFraudReportFormat (string acceptVersion, string authorization, string id, string quickPayCallbackUrl, string description)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = id_example;  // string |  
            var quickPayCallbackUrl = quickPayCallbackUrl_example;  // string | <p>Specify the callback url (overrides merchant default callback-url)</p>  (optional) 
            var description = description_example;  // string |   (optional) 

            try
            {
                // Create fraud confirmation report
                QuickPayProtocolV10FraudReport result = apiInstance.POSTCardsIdFraudReportFormat(acceptVersion, authorization, id, quickPayCallbackUrl, description);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **string**|   | 
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

<a name="postcardsidtokensformat"></a>
# **POSTCardsIdTokensFormat**
> QuickPayProtocolV10CardToken POSTCardsIdTokensFormat (string acceptVersion, string authorization, string id)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = id_example;  // string |  

            try
            {
                // Create card token
                QuickPayProtocolV10CardToken result = apiInstance.POSTCardsIdTokensFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **string**|   | 

### Return type

[**QuickPayProtocolV10CardToken**](QuickPayProtocolV10CardToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcardsidlinkformat"></a>
# **PUTCardsIdLinkFormat**
> QuickPayProtocolV10CardLinkUrl PUTCardsIdLinkFormat (string acceptVersion, string authorization, string id, int? agreementId, string language, string continueurl, string cancelurl, string callbackurl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, Dictionary<string, string> brandingConfig)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = id_example;  // string |  
            var agreementId = 56;  // int? | <p>Agreement to use. Defaults to the Payment Window agreement</p>  (optional) 
            var language = language_example;  // string | <p>Language</p>  (optional)  (default to en)
            var continueurl = continueurl_example;  // string | <p>Url that cardholder is redirected to after authorize</p>  (optional) 
            var cancelurl = cancelurl_example;  // string | <p>Url that cardholder is redirected to after cancelation</p>  (optional) 
            var callbackurl = callbackurl_example;  // string | <p>Endpoint for async callback</p>  (optional) 
            var paymentMethods = paymentMethods_example;  // string | <p>Limit payment methods</p>  (optional)  (default to creditcard)
            var brandingId = 56;  // int? | <p>Override branding. Default is merchant default branding</p>  (optional) 
            var googleAnalyticsTrackingId = googleAnalyticsTrackingId_example;  // string | <p>Send events to Google Analytics</p>  (optional) 
            var googleAnalyticsClientId = googleAnalyticsClientId_example;  // string | <p>Send events to Google Analytics</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>Force usage of the given acquirer</p>  (optional) 
            var framed = true;  // bool? | <p>Allow opening in iframe</p>  (optional) 
            var brandingConfig = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Config for branding. Will be merged with the default config in the branding</p>  (optional) 

            try
            {
                // Create or update a card link
                QuickPayProtocolV10CardLinkUrl result = apiInstance.PUTCardsIdLinkFormat(acceptVersion, authorization, id, agreementId, language, continueurl, cancelurl, callbackurl, paymentMethods, brandingId, googleAnalyticsTrackingId, googleAnalyticsClientId, acquirer, framed, brandingConfig);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **string**|   | 
 **agreementId** | **int?**| &lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt;  | [optional] 
 **language** | **string**| &lt;p&gt;Language&lt;/p&gt;  | [optional] [default to en]
 **continueurl** | **string**| &lt;p&gt;Url that cardholder is redirected to after authorize&lt;/p&gt;  | [optional] 
 **cancelurl** | **string**| &lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt;  | [optional] 
 **callbackurl** | **string**| &lt;p&gt;Endpoint for async callback&lt;/p&gt;  | [optional] 
 **paymentMethods** | **string**| &lt;p&gt;Limit payment methods&lt;/p&gt;  | [optional] [default to creditcard]
 **brandingId** | **int?**| &lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt;  | [optional] 
 **googleAnalyticsTrackingId** | **string**| &lt;p&gt;Send events to Google Analytics&lt;/p&gt;  | [optional] 
 **googleAnalyticsClientId** | **string**| &lt;p&gt;Send events to Google Analytics&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;Force usage of the given acquirer&lt;/p&gt;  | [optional] 
 **framed** | **bool?**| &lt;p&gt;Allow opening in iframe&lt;/p&gt;  | [optional] 
 **brandingConfig** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10CardLinkUrl**](QuickPayProtocolV10CardLinkUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

