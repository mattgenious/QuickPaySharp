# IO.Swagger.Api.PaymentMethodPriorityApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETPaymentMethodPriorityFormat**](PaymentMethodPriorityApi.md#getpaymentmethodpriorityformat) | **GET** /payment-method-priority | Get merchant payment method priority
[**POSTPaymentMethodPriorityFormat**](PaymentMethodPriorityApi.md#postpaymentmethodpriorityformat) | **POST** /payment-method-priority | Replaces the payment method priority of the merchant


<a name="getpaymentmethodpriorityformat"></a>
# **GETPaymentMethodPriorityFormat**
> PaymentMethodPriority GETPaymentMethodPriorityFormat (string acceptVersion, string authorization)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 

            try
            {
                // Get merchant payment method priority
                PaymentMethodPriority result = apiInstance.GETPaymentMethodPriorityFormat(acceptVersion, authorization);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 

### Return type

[**PaymentMethodPriority**](PaymentMethodPriority.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpaymentmethodpriorityformat"></a>
# **POSTPaymentMethodPriorityFormat**
> void POSTPaymentMethodPriorityFormat (string acceptVersion, string authorization, string paymentMethodPriority)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var paymentMethodPriority = paymentMethodPriority_example;  // string | A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … } 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **paymentMethodPriority** | **string**| A map of payment method to acquirers, e.g. { “visa”: [“clearhaus”, “nets”], … }  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

