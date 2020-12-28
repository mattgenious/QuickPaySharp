# IO.Swagger.Api.PayoutsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payout id</p> 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payout id&lt;/p&gt;  | 

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
            var accepted = true;  // bool? | <p>Return accepted payouts</p>  (optional) 
            var orderId = orderId_example;  // string | <p>Find by order_id</p>  (optional) 
            var state = state_example;  // string | <p>Find by state</p>  (optional) 
            var id = 56;  // int? | <p>Find by payout id</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>Filter by acquirer</p>  (optional) 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to desc)

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
 **accepted** | **bool?**| &lt;p&gt;Return accepted payouts&lt;/p&gt;  | [optional] 
 **orderId** | **string**| &lt;p&gt;Find by order_id&lt;/p&gt;  | [optional] 
 **state** | **string**| &lt;p&gt;Find by state&lt;/p&gt;  | [optional] 
 **id** | **int?**| &lt;p&gt;Find by payout id&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;Filter by acquirer&lt;/p&gt;  | [optional] 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to id]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to desc]

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payout id</p> 
            var operationsSize = 56;  // int? | <p>Maximum number of operations to retrieve</p>  (optional) 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payout id&lt;/p&gt;  | 
 **operationsSize** | **int?**| &lt;p&gt;Maximum number of operations to retrieve&lt;/p&gt;  | [optional] 

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payout id</p> 
            var operationId = 56;  // int? | <p>Operations id</p> 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payout id&lt;/p&gt;  | 
 **operationId** | **int?**| &lt;p&gt;Operations id&lt;/p&gt;  | 

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
> Payout PATCHPayoutsIdFormat (string acceptVersion, string authorization, int? id, Dictionary<string, string> variables)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payout id</p> 
            var variables = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Custom variables</p>  (optional) 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payout id&lt;/p&gt;  | 
 **variables** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Custom variables&lt;/p&gt;  | [optional] 

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
> Payout POSTPayoutsFormat (string acceptVersion, string authorization, string currency, string orderId, Dictionary<string, string> variables, string textOnStatement)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var currency = currency_example;  // string | <p>Currency</p> 
            var orderId = orderId_example;  // string | <p>Unique order id(must be between 4-20 characters)</p> 
            var variables = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Custom variables</p>  (optional)  (default to {})
            var textOnStatement = textOnStatement_example;  // string | <p>Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.</p>  (optional) 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **currency** | **string**| &lt;p&gt;Currency&lt;/p&gt;  | 
 **orderId** | **string**| &lt;p&gt;Unique order id(must be between 4-20 characters)&lt;/p&gt;  | 
 **variables** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Custom variables&lt;/p&gt;  | [optional] [default to {}]
 **textOnStatement** | **string**| &lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt;  | [optional] 

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
> Payout POSTPayoutsIdCreditFormat (string acceptVersion, string authorization, int? id, int? amount, string quickPayCallbackUrl, bool? synchronized, float? vatRate, string cardNumber, string cardExpiration, string cardCvd, string cardToken, Dictionary<string, string> cardApplePayToken, Dictionary<string, string> cardMobilepayOnlineToken, string cardIssuedTo, string cardBrand, string cardStatus, string cardEci, string cardXav, string cardCavv, string mobileNumber, string ninNumber, string ninCountryCode, string ninGender, string personFirstName, string personLastName, string personEmail, string acquirer, string customerIp, Dictionary<string, string> extras)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payout id</p> 
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
            var acquirer = acquirer_example;  // string | <p>If set, will force the use of this acquirer</p>  (optional) 
            var customerIp = customerIp_example;  // string | <p>Customer IP</p>  (optional) 
            var extras = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Additional acquirer specific params</p>  (optional) 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payout id&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount&lt;/p&gt;  | 
 **quickPayCallbackUrl** | **string**| &lt;p&gt;Specify the callback url (overrides merchant default callback-url)&lt;/p&gt;  | [optional] 
 **synchronized** | **bool?**| &lt;p&gt;Disables asynchronious behaviour and returns the transaction with completed operation (ex. see GET /payments/{id}). MUST be used as a query parameter “?synchronized” (value not required)&lt;/p&gt;  | [optional] 
 **vatRate** | **float?**| &lt;p&gt;Vate rate&lt;/p&gt;  | [optional] 
 **cardNumber** | **string**| &lt;p&gt;Card number&lt;/p&gt;  | [optional] 
 **cardExpiration** | **string**| &lt;p&gt;Expiration date (YYMM)&lt;/p&gt;  | [optional] 
 **cardCvd** | **string**| &lt;p&gt;CVD/CVV&lt;/p&gt;  | [optional] 
 **cardToken** | **string**| &lt;p&gt;Card token&lt;/p&gt;  | [optional] 
 **cardApplePayToken** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Apple Pay payment-token&lt;/p&gt;  | [optional] 
 **cardMobilepayOnlineToken** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;MobilePay Online payment-token&lt;/p&gt;  | [optional] 
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
 **acquirer** | **string**| &lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt;  | [optional] 
 **customerIp** | **string**| &lt;p&gt;Customer IP&lt;/p&gt;  | [optional] 
 **extras** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Additional acquirer specific params&lt;/p&gt;  | [optional] 

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
> PaymentLinkUrl PUTPayoutsIdLinkFormat (string acceptVersion, string authorization, int? id, int? amount, int? agreementId, string language, string continueUrl, string cancelUrl, string callbackUrl, string paymentMethods, int? brandingId, string googleAnalyticsTrackingId, string googleAnalyticsClientId, string acquirer, bool? framed, Dictionary<string, string> brandingConfig)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Payout id</p> 
            var amount = 56;  // int? | <p>Amount to credit</p> 
            var agreementId = 56;  // int? | <p>Agreement to use. Defaults to the Payment Window agreement</p>  (optional) 
            var language = language_example;  // string | <p>Language</p>  (optional)  (default to en)
            var continueUrl = continueUrl_example;  // string | <p>Url that cardholder is redirected to after credit</p>  (optional) 
            var cancelUrl = cancelUrl_example;  // string | <p>Url that cardholder is redirected to after cancelation</p>  (optional) 
            var callbackUrl = callbackUrl_example;  // string | <p>Endpoint for async callback</p>  (optional) 
            var paymentMethods = paymentMethods_example;  // string | <p>Limit payment methods</p>  (optional) 
            var brandingId = 56;  // int? | <p>Override branding. Default is merchant default branding</p>  (optional) 
            var googleAnalyticsTrackingId = googleAnalyticsTrackingId_example;  // string | <p>Send events to Google Analytics</p>  (optional) 
            var googleAnalyticsClientId = googleAnalyticsClientId_example;  // string | <p>Send events to Google Analytics</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>Force usage of the given acquirer</p>  (optional) 
            var framed = true;  // bool? | <p>Allow opening in iframe</p>  (optional) 
            var brandingConfig = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Config for branding. Will be merged with the default config in the branding</p>  (optional) 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Payout id&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount to credit&lt;/p&gt;  | 
 **agreementId** | **int?**| &lt;p&gt;Agreement to use. Defaults to the Payment Window agreement&lt;/p&gt;  | [optional] 
 **language** | **string**| &lt;p&gt;Language&lt;/p&gt;  | [optional] [default to en]
 **continueUrl** | **string**| &lt;p&gt;Url that cardholder is redirected to after credit&lt;/p&gt;  | [optional] 
 **cancelUrl** | **string**| &lt;p&gt;Url that cardholder is redirected to after cancelation&lt;/p&gt;  | [optional] 
 **callbackUrl** | **string**| &lt;p&gt;Endpoint for async callback&lt;/p&gt;  | [optional] 
 **paymentMethods** | **string**| &lt;p&gt;Limit payment methods&lt;/p&gt;  | [optional] 
 **brandingId** | **int?**| &lt;p&gt;Override branding. Default is merchant default branding&lt;/p&gt;  | [optional] 
 **googleAnalyticsTrackingId** | **string**| &lt;p&gt;Send events to Google Analytics&lt;/p&gt;  | [optional] 
 **googleAnalyticsClientId** | **string**| &lt;p&gt;Send events to Google Analytics&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;Force usage of the given acquirer&lt;/p&gt;  | [optional] 
 **framed** | **bool?**| &lt;p&gt;Allow opening in iframe&lt;/p&gt;  | [optional] 
 **brandingConfig** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Config for branding. Will be merged with the default config in the branding&lt;/p&gt;  | [optional] 

### Return type

[**PaymentLinkUrl**](PaymentLinkUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

