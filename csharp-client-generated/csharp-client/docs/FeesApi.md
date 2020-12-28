# IO.Swagger.Api.FeesApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETEFeesFormulasAcquirerPaymentMethodFormat**](FeesApi.md#deletefeesformulasacquirerpaymentmethodformat) | **DELETE** /fees/formulas/{acquirer}/{payment_method} | Reset a formula to default
[**GETFeesFormulasAcquirerFormat**](FeesApi.md#getfeesformulasacquirerformat) | **GET** /fees/formulas/{acquirer} | Get fee formulas
[**GETFeesFormulasAcquirerPaymentMethodFormat**](FeesApi.md#getfeesformulasacquirerpaymentmethodformat) | **GET** /fees/formulas/{acquirer}/{payment_method} | Get fee formula
[**GETFeesFormulasFormat**](FeesApi.md#getfeesformulasformat) | **GET** /fees/formulas | Get all fee formulas
[**PATCHFeesFormulasAcquirerPaymentMethodFormat**](FeesApi.md#patchfeesformulasacquirerpaymentmethodformat) | **PATCH** /fees/formulas/{acquirer}/{payment_method} | Update a fee formula
[**POSTFeesAcquirerPaymentMethodFormat**](FeesApi.md#postfeesacquirerpaymentmethodformat) | **POST** /fees/{acquirer}/{payment_method} | Calculate fee
[**POSTFeesFormat**](FeesApi.md#postfeesformat) | **POST** /fees | Calculate fee for auth params. Requires one of card[number] or card[token]


<a name="deletefeesformulasacquirerpaymentmethodformat"></a>
# **DELETEFeesFormulasAcquirerPaymentMethodFormat**
> void DELETEFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod)

Reset a formula to default

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEFeesFormulasAcquirerPaymentMethodFormatExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var acquirer = acquirer_example;  // string | Name of acquirer 
            var paymentMethod = paymentMethod_example;  // string | Payment method 

            try
            {
                // Reset a formula to default
                apiInstance.DELETEFeesFormulasAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.DELETEFeesFormulasAcquirerPaymentMethodFormat: " + e.Message );
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
 **acquirer** | **string**| Name of acquirer  | 
 **paymentMethod** | **string**| Payment method  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeesformulasacquirerformat"></a>
# **GETFeesFormulasAcquirerFormat**
> FeeFormula GETFeesFormulasAcquirerFormat (string acceptVersion, string authorization, string acquirer)

Get fee formulas

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETFeesFormulasAcquirerFormatExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var acquirer = acquirer_example;  // string | Name of acquirer 

            try
            {
                // Get fee formulas
                FeeFormula result = apiInstance.GETFeesFormulasAcquirerFormat(acceptVersion, authorization, acquirer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GETFeesFormulasAcquirerFormat: " + e.Message );
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
 **acquirer** | **string**| Name of acquirer  | 

### Return type

[**FeeFormula**](FeeFormula.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeesformulasacquirerpaymentmethodformat"></a>
# **GETFeesFormulasAcquirerPaymentMethodFormat**
> FeeFormula GETFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod)

Get fee formula

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETFeesFormulasAcquirerPaymentMethodFormatExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var acquirer = acquirer_example;  // string | Name of acquirer 
            var paymentMethod = paymentMethod_example;  // string | Payment method 

            try
            {
                // Get fee formula
                FeeFormula result = apiInstance.GETFeesFormulasAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GETFeesFormulasAcquirerPaymentMethodFormat: " + e.Message );
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
 **acquirer** | **string**| Name of acquirer  | 
 **paymentMethod** | **string**| Payment method  | 

### Return type

[**FeeFormula**](FeeFormula.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeesformulasformat"></a>
# **GETFeesFormulasFormat**
> FeeFormula GETFeesFormulasFormat (string acceptVersion, string authorization, int? page = null, int? pageSize = null)

Get all fee formulas

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETFeesFormulasFormatExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)

            try
            {
                // Get all fee formulas
                FeeFormula result = apiInstance.GETFeesFormulasFormat(acceptVersion, authorization, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GETFeesFormulasFormat: " + e.Message );
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
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]

### Return type

[**FeeFormula**](FeeFormula.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchfeesformulasacquirerpaymentmethodformat"></a>
# **PATCHFeesFormulasAcquirerPaymentMethodFormat**
> FeeFormula PATCHFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod, string formula = null)

Update a fee formula

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHFeesFormulasAcquirerPaymentMethodFormatExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var acquirer = acquirer_example;  // string | Name of acquirer 
            var paymentMethod = paymentMethod_example;  // string | Payment method 
            var formula = formula_example;  // string | The formula  (optional) 

            try
            {
                // Update a fee formula
                FeeFormula result = apiInstance.PATCHFeesFormulasAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod, formula);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.PATCHFeesFormulasAcquirerPaymentMethodFormat: " + e.Message );
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
 **acquirer** | **string**| Name of acquirer  | 
 **paymentMethod** | **string**| Payment method  | 
 **formula** | **string**| The formula  | [optional] 

### Return type

[**FeeFormula**](FeeFormula.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfeesacquirerpaymentmethodformat"></a>
# **POSTFeesAcquirerPaymentMethodFormat**
> CalculatedFee POSTFeesAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod, int? amount)

Calculate fee

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTFeesAcquirerPaymentMethodFormatExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var acquirer = acquirer_example;  // string | Name of acquirer 
            var paymentMethod = paymentMethod_example;  // string | Payment method 
            var amount = 56;  // int? | Amount specified in smallest unit 

            try
            {
                // Calculate fee
                CalculatedFee result = apiInstance.POSTFeesAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod, amount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.POSTFeesAcquirerPaymentMethodFormat: " + e.Message );
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
 **acquirer** | **string**| Name of acquirer  | 
 **paymentMethod** | **string**| Payment method  | 
 **amount** | **int?**| Amount specified in smallest unit  | 

### Return type

[**CalculatedFee**](CalculatedFee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfeesformat"></a>
# **POSTFeesFormat**
> CalculatedFee POSTFeesFormat (string acceptVersion, string authorization, int? amount, string currency = null, string cardApplePayToken = null, string cardMobilepayOnlineToken = null, string cardToken = null, string cardNumber = null, string cardBrand = null, string acquirer = null)

Calculate fee for auth params. Requires one of card[number] or card[token]

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTFeesFormatExample
    {
        public void main()
        {
            var apiInstance = new FeesApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var amount = 56;  // int? | Amount specified in smallest unit 
            var currency = currency_example;  // string | Currency  (optional) 
            var cardApplePayToken = cardApplePayToken_example;  // string | Apple Pay payment-token  (optional) 
            var cardMobilepayOnlineToken = cardMobilepayOnlineToken_example;  // string | MobilePay Online payment-token  (optional) 
            var cardToken = cardToken_example;  // string | Card token  (optional) 
            var cardNumber = cardNumber_example;  // string | Card number  (optional) 
            var cardBrand = cardBrand_example;  // string | Brand to use on multi-brand card  (optional) 
            var acquirer = acquirer_example;  // string | If set, will force the use of this acquirer  (optional) 

            try
            {
                // Calculate fee for auth params. Requires one of card[number] or card[token]
                CalculatedFee result = apiInstance.POSTFeesFormat(acceptVersion, authorization, amount, currency, cardApplePayToken, cardMobilepayOnlineToken, cardToken, cardNumber, cardBrand, acquirer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.POSTFeesFormat: " + e.Message );
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
 **amount** | **int?**| Amount specified in smallest unit  | 
 **currency** | **string**| Currency  | [optional] 
 **cardApplePayToken** | **string**| Apple Pay payment-token  | [optional] 
 **cardMobilepayOnlineToken** | **string**| MobilePay Online payment-token  | [optional] 
 **cardToken** | **string**| Card token  | [optional] 
 **cardNumber** | **string**| Card number  | [optional] 
 **cardBrand** | **string**| Brand to use on multi-brand card  | [optional] 
 **acquirer** | **string**| If set, will force the use of this acquirer  | [optional] 

### Return type

[**CalculatedFee**](CalculatedFee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

