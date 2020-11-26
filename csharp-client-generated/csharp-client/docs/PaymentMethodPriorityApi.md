# IO.Swagger.Api.PaymentMethodPriorityApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETPaymentMethodPriorityFormat**](PaymentMethodPriorityApi.md#getpaymentmethodpriorityformat) | **GET** /payment-method-priority | Get merchant payment method priority
[**POSTPaymentMethodPriorityFormat**](PaymentMethodPriorityApi.md#postpaymentmethodpriorityformat) | **POST** /payment-method-priority | Replaces the payment method priority of the merchant


<a name="getpaymentmethodpriorityformat"></a>
# **GETPaymentMethodPriorityFormat**
> QuickPayProtocolV10PaymentMethodPriority GETPaymentMethodPriorityFormat (string acceptVersion, string authorization)

Get merchant payment method priority

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETPaymentMethodPriorityFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentMethodPriorityApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 

            try
            {
                // Get merchant payment method priority
                QuickPayProtocolV10PaymentMethodPriority result = apiInstance.GETPaymentMethodPriorityFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentMethodPriorityApi.GETPaymentMethodPriorityFormat: " + e.Message );
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

### Return type

[**QuickPayProtocolV10PaymentMethodPriority**](QuickPayProtocolV10PaymentMethodPriority.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentmethodpriorityformat"></a>
# **POSTPaymentMethodPriorityFormat**
> void POSTPaymentMethodPriorityFormat (string acceptVersion, string authorization, Dictionary<string, string> paymentMethodPriority)

Replaces the payment method priority of the merchant

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPaymentMethodPriorityFormatExample
    {
        public void main()
        {
            var apiInstance = new PaymentMethodPriorityApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var paymentMethodPriority = new Dictionary<string, string>(); // Dictionary<string, string> | <p>A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }</p> 

            try
            {
                // Replaces the payment method priority of the merchant
                apiInstance.POSTPaymentMethodPriorityFormat(acceptVersion, authorization, paymentMethodPriority);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentMethodPriorityApi.POSTPaymentMethodPriorityFormat: " + e.Message );
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
 **paymentMethodPriority** | [**Dictionary&lt;string, string&gt;**](string.md)| &lt;p&gt;A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }&lt;/p&gt;  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

