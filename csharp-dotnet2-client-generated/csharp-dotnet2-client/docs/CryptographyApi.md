# IO.Swagger.Api.CryptographyApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETECryptographyKeysIdCertificateFormat**](CryptographyApi.md#deletecryptographykeysidcertificateformat) | **DELETE** /cryptography/keys/{id}/certificate | Delete certificate
[**DELETECryptographyKeysIdFormat**](CryptographyApi.md#deletecryptographykeysidformat) | **DELETE** /cryptography/keys/{id} | Delete key
[**GETCryptographyKeysFormat**](CryptographyApi.md#getcryptographykeysformat) | **GET** /cryptography/keys | Get keys
[**GETCryptographyKeysIdCertificateFormat**](CryptographyApi.md#getcryptographykeysidcertificateformat) | **GET** /cryptography/keys/{id}/certificate | Get certificate
[**GETCryptographyKeysIdFormat**](CryptographyApi.md#getcryptographykeysidformat) | **GET** /cryptography/keys/{id} | Get key
[**PATCHCryptographyKeysIdFormat**](CryptographyApi.md#patchcryptographykeysidformat) | **PATCH** /cryptography/keys/{id} | update key
[**POSTCryptographyKeysFormat**](CryptographyApi.md#postcryptographykeysformat) | **POST** /cryptography/keys | Create key
[**POSTCryptographyKeysIdCsrFormat**](CryptographyApi.md#postcryptographykeysidcsrformat) | **POST** /cryptography/keys/{id}/csr | Create certificate request (CSR)
[**PUTCryptographyKeysIdCertificateFormat**](CryptographyApi.md#putcryptographykeysidcertificateformat) | **PUT** /cryptography/keys/{id}/certificate | Replace certificate


<a name="deletecryptographykeysidcertificateformat"></a>
# **DELETECryptographyKeysIdCertificateFormat**
> void DELETECryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id)

Delete certificate

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETECryptographyKeysIdCertificateFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? |  

            try
            {
                // Delete certificate
                apiInstance.DELETECryptographyKeysIdCertificateFormat(acceptVersion, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.DELETECryptographyKeysIdCertificateFormat: " + e.Message );
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
 **id** | **int?**|   | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecryptographykeysidformat"></a>
# **DELETECryptographyKeysIdFormat**
> void DELETECryptographyKeysIdFormat (string acceptVersion, string authorization, int? id)

Delete key

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETECryptographyKeysIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? |  

            try
            {
                // Delete key
                apiInstance.DELETECryptographyKeysIdFormat(acceptVersion, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.DELETECryptographyKeysIdFormat: " + e.Message );
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
 **id** | **int?**|   | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcryptographykeysformat"></a>
# **GETCryptographyKeysFormat**
> MerchantCryptographyKey GETCryptographyKeysFormat (string acceptVersion, string authorization, string type, string query, string sortBy, string sortDir, int? pageSize, int? pageKey)

Get keys

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETCryptographyKeysFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var type = type_example;  // string |   (optional) 
            var query = query_example;  // string |   (optional) 
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to desc)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var pageKey = 56;  // int? |   (optional) 

            try
            {
                // Get keys
                MerchantCryptographyKey result = apiInstance.GETCryptographyKeysFormat(acceptVersion, authorization, type, query, sortBy, sortDir, pageSize, pageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.GETCryptographyKeysFormat: " + e.Message );
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
 **type** | **string**|   | [optional] 
 **query** | **string**|   | [optional] 
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to id]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to desc]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **pageKey** | **int?**|   | [optional] 

### Return type

[**MerchantCryptographyKey**](MerchantCryptographyKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcryptographykeysidcertificateformat"></a>
# **GETCryptographyKeysIdCertificateFormat**
> void GETCryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id)

Get certificate

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETCryptographyKeysIdCertificateFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? |  

            try
            {
                // Get certificate
                apiInstance.GETCryptographyKeysIdCertificateFormat(acceptVersion, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.GETCryptographyKeysIdCertificateFormat: " + e.Message );
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
 **id** | **int?**|   | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcryptographykeysidformat"></a>
# **GETCryptographyKeysIdFormat**
> MerchantCryptographyKey GETCryptographyKeysIdFormat (string acceptVersion, string authorization, int? id)

Get key

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETCryptographyKeysIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? |  

            try
            {
                // Get key
                MerchantCryptographyKey result = apiInstance.GETCryptographyKeysIdFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.GETCryptographyKeysIdFormat: " + e.Message );
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
 **id** | **int?**|   | 

### Return type

[**MerchantCryptographyKey**](MerchantCryptographyKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcryptographykeysidformat"></a>
# **PATCHCryptographyKeysIdFormat**
> MerchantCryptographyKey PATCHCryptographyKeysIdFormat (string acceptVersion, string authorization, int? id, string shortDescription)

update key

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHCryptographyKeysIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? |  
            var shortDescription = shortDescription_example;  // string |   (optional) 

            try
            {
                // update key
                MerchantCryptographyKey result = apiInstance.PATCHCryptographyKeysIdFormat(acceptVersion, authorization, id, shortDescription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.PATCHCryptographyKeysIdFormat: " + e.Message );
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
 **id** | **int?**|   | 
 **shortDescription** | **string**|   | [optional] 

### Return type

[**MerchantCryptographyKey**](MerchantCryptographyKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcryptographykeysformat"></a>
# **POSTCryptographyKeysFormat**
> MerchantCryptographyKey POSTCryptographyKeysFormat (string acceptVersion, string authorization, string type, string shortDescription, int? keySize, string curve)

Create key

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTCryptographyKeysFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var type = type_example;  // string |  
            var shortDescription = shortDescription_example;  // string |  
            var keySize = 56;  // int? |  
            var curve = curve_example;  // string |  

            try
            {
                // Create key
                MerchantCryptographyKey result = apiInstance.POSTCryptographyKeysFormat(acceptVersion, authorization, type, shortDescription, keySize, curve);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.POSTCryptographyKeysFormat: " + e.Message );
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
 **type** | **string**|   | 
 **shortDescription** | **string**|   | 
 **keySize** | **int?**|   | 
 **curve** | **string**|   | 

### Return type

[**MerchantCryptographyKey**](MerchantCryptographyKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcryptographykeysidcsrformat"></a>
# **POSTCryptographyKeysIdCsrFormat**
> void POSTCryptographyKeysIdCsrFormat (string acceptVersion, string authorization, int? id, string subjectKey, string subjectValue, string subjectEncoding)

Create certificate request (CSR)

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTCryptographyKeysIdCsrFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? |  
            var subjectKey = subjectKey_example;  // string |  
            var subjectValue = subjectValue_example;  // string |  
            var subjectEncoding = subjectEncoding_example;  // string |  

            try
            {
                // Create certificate request (CSR)
                apiInstance.POSTCryptographyKeysIdCsrFormat(acceptVersion, authorization, id, subjectKey, subjectValue, subjectEncoding);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.POSTCryptographyKeysIdCsrFormat: " + e.Message );
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
 **id** | **int?**|   | 
 **subjectKey** | **string**|   | 
 **subjectValue** | **string**|   | 
 **subjectEncoding** | **string**|   | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcryptographykeysidcertificateformat"></a>
# **PUTCryptographyKeysIdCertificateFormat**
> void PUTCryptographyKeysIdCertificateFormat (string acceptVersion, string authorization, int? id, ModelFile _file)

Replace certificate

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PUTCryptographyKeysIdCertificateFormatExample
    {
        public void main()
        {
            
            var apiInstance = new CryptographyApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? |  
            var _file = new ModelFile(); // ModelFile | <p>The file send as multipart</p> 

            try
            {
                // Replace certificate
                apiInstance.PUTCryptographyKeysIdCertificateFormat(acceptVersion, authorization, id, _file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptographyApi.PUTCryptographyKeysIdCertificateFormat: " + e.Message );
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
 **id** | **int?**|   | 
 **_file** | **ModelFile**| &lt;p&gt;The file send as multipart&lt;/p&gt;  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

