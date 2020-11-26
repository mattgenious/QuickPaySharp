# IO.Swagger.Api.FeesApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var acquirer = acquirer_example;  // string | <p>Name of acquirer</p> 
            var paymentMethod = paymentMethod_example;  // string | <p>Payment method</p> 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **acquirer** | **string**| &lt;p&gt;Name of acquirer&lt;/p&gt;  | 
 **paymentMethod** | **string**| &lt;p&gt;Payment method&lt;/p&gt;  | 

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
> QuickPayProtocolV10FeeFormula GETFeesFormulasAcquirerFormat (string acceptVersion, string authorization, string acquirer)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var acquirer = acquirer_example;  // string | <p>Name of acquirer</p> 

            try
            {
                // Get fee formulas
                QuickPayProtocolV10FeeFormula result = apiInstance.GETFeesFormulasAcquirerFormat(acceptVersion, authorization, acquirer);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **acquirer** | **string**| &lt;p&gt;Name of acquirer&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10FeeFormula**](QuickPayProtocolV10FeeFormula.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeesformulasacquirerpaymentmethodformat"></a>
# **GETFeesFormulasAcquirerPaymentMethodFormat**
> QuickPayProtocolV10FeeFormula GETFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var acquirer = acquirer_example;  // string | <p>Name of acquirer</p> 
            var paymentMethod = paymentMethod_example;  // string | <p>Payment method</p> 

            try
            {
                // Get fee formula
                QuickPayProtocolV10FeeFormula result = apiInstance.GETFeesFormulasAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **acquirer** | **string**| &lt;p&gt;Name of acquirer&lt;/p&gt;  | 
 **paymentMethod** | **string**| &lt;p&gt;Payment method&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10FeeFormula**](QuickPayProtocolV10FeeFormula.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeesformulasformat"></a>
# **GETFeesFormulasFormat**
> QuickPayProtocolV10FeeFormula GETFeesFormulasFormat (string acceptVersion, string authorization, int? page, int? pageSize)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)

            try
            {
                // Get all fee formulas
                QuickPayProtocolV10FeeFormula result = apiInstance.GETFeesFormulasFormat(acceptVersion, authorization, page, pageSize);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]

### Return type

[**QuickPayProtocolV10FeeFormula**](QuickPayProtocolV10FeeFormula.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchfeesformulasacquirerpaymentmethodformat"></a>
# **PATCHFeesFormulasAcquirerPaymentMethodFormat**
> QuickPayProtocolV10FeeFormula PATCHFeesFormulasAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod, string formula)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var acquirer = acquirer_example;  // string | <p>Name of acquirer</p> 
            var paymentMethod = paymentMethod_example;  // string | <p>Payment method</p> 
            var formula = formula_example;  // string | <p>The formula</p>  (optional) 

            try
            {
                // Update a fee formula
                QuickPayProtocolV10FeeFormula result = apiInstance.PATCHFeesFormulasAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod, formula);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **acquirer** | **string**| &lt;p&gt;Name of acquirer&lt;/p&gt;  | 
 **paymentMethod** | **string**| &lt;p&gt;Payment method&lt;/p&gt;  | 
 **formula** | **string**| &lt;p&gt;The formula&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10FeeFormula**](QuickPayProtocolV10FeeFormula.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfeesacquirerpaymentmethodformat"></a>
# **POSTFeesAcquirerPaymentMethodFormat**
> QuickPayProtocolV10CalculatedFee POSTFeesAcquirerPaymentMethodFormat (string acceptVersion, string authorization, string acquirer, string paymentMethod, int? amount)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var acquirer = acquirer_example;  // string | <p>Name of acquirer</p> 
            var paymentMethod = paymentMethod_example;  // string | <p>Payment method</p> 
            var amount = 56;  // int? | <p>Amount specified in smallest unit</p> 

            try
            {
                // Calculate fee
                QuickPayProtocolV10CalculatedFee result = apiInstance.POSTFeesAcquirerPaymentMethodFormat(acceptVersion, authorization, acquirer, paymentMethod, amount);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **acquirer** | **string**| &lt;p&gt;Name of acquirer&lt;/p&gt;  | 
 **paymentMethod** | **string**| &lt;p&gt;Payment method&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount specified in smallest unit&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10CalculatedFee**](QuickPayProtocolV10CalculatedFee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfeesformat"></a>
# **POSTFeesFormat**
> QuickPayProtocolV10CalculatedFee POSTFeesFormat (string acceptVersion, string authorization, int? amount, string currency, Dictionary<string, string> cardApplePayToken, Dictionary<string, string> cardMobilepayOnlineToken, string cardToken, string cardNumber, string cardBrand, string acquirer)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var amount = 56;  // int? | <p>Amount specified in smallest unit</p> 
            var currency = currency_example;  // string | <p>Currency</p>  (optional) 
            var cardApplePayToken = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Apple Pay payment-token</p>  (optional) 
            var cardMobilepayOnlineToken = new Dictionary<string, string>(); // Dictionary<string, string> | <p>MobilePay Online payment-token</p>  (optional) 
            var cardToken = cardToken_example;  // string | <p>Card token</p>  (optional) 
            var cardNumber = cardNumber_example;  // string | <p>Card number</p>  (optional) 
            var cardBrand = cardBrand_example;  // string | <p>Brand to use on multi-brand card</p>  (optional) 
            var acquirer = acquirer_example;  // string | <p>If set, will force the use of this acquirer</p>  (optional) 

            try
            {
                // Calculate fee for auth params. Requires one of card[number] or card[token]
                QuickPayProtocolV10CalculatedFee result = apiInstance.POSTFeesFormat(acceptVersion, authorization, amount, currency, cardApplePayToken, cardMobilepayOnlineToken, cardToken, cardNumber, cardBrand, acquirer);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount specified in smallest unit&lt;/p&gt;  | 
 **currency** | **string**| &lt;p&gt;Currency&lt;/p&gt;  | [optional] 
 **cardApplePayToken** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Apple Pay payment-token&lt;/p&gt;  | [optional] 
 **cardMobilepayOnlineToken** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;MobilePay Online payment-token&lt;/p&gt;  | [optional] 
 **cardToken** | **string**| &lt;p&gt;Card token&lt;/p&gt;  | [optional] 
 **cardNumber** | **string**| &lt;p&gt;Card number&lt;/p&gt;  | [optional] 
 **cardBrand** | **string**| &lt;p&gt;Brand to use on multi-brand card&lt;/p&gt;  | [optional] 
 **acquirer** | **string**| &lt;p&gt;If set, will force the use of this acquirer&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10CalculatedFee**](QuickPayProtocolV10CalculatedFee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

