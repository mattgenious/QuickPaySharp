# IO.Swagger.Api.BrandingsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETEBrandingsIdFormat**](BrandingsApi.md#deletebrandingsidformat) | **DELETE** /brandings/{id} | Delete a branding
[**DELETEBrandingsIdresourceNameFormat**](BrandingsApi.md#deletebrandingsidresourcenameformat) | **DELETE** /brandings/{id}/*resource_name | Deletes a branding resource
[**GETBrandingsFormat**](BrandingsApi.md#getbrandingsformat) | **GET** /brandings | Get brandings
[**GETBrandingsIdFormat**](BrandingsApi.md#getbrandingsidformat) | **GET** /brandings/{id} | Get a branding
[**GETBrandingsIdresourceNameFormat**](BrandingsApi.md#getbrandingsidresourcenameformat) | **GET** /brandings/{id}/*resource_name | Gets a branding resource as a file
[**PATCHBrandingsIdFormat**](BrandingsApi.md#patchbrandingsidformat) | **PATCH** /brandings/{id} | Update a branding
[**POSTBrandingsFormat**](BrandingsApi.md#postbrandingsformat) | **POST** /brandings | Create a branding
[**POSTBrandingsIdCopyFormat**](BrandingsApi.md#postbrandingsidcopyformat) | **POST** /brandings/{id}/copy | Copies branding and returns the new branding
[**PUTBrandingsIdresourceNameFormat**](BrandingsApi.md#putbrandingsidresourcenameformat) | **PUT** /brandings/{id}/*resource_name | Uploads a file and creates or replaces a resource


<a name="deletebrandingsidformat"></a>
# **DELETEBrandingsIdFormat**
> void DELETEBrandingsIdFormat (int? id)

Delete a branding

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEBrandingsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var id = 56;  // int? | <p>Branding id</p> 

            try
            {
                // Delete a branding
                apiInstance.DELETEBrandingsIdFormat(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.DELETEBrandingsIdFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| &lt;p&gt;Branding id&lt;/p&gt;  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebrandingsidresourcenameformat"></a>
# **DELETEBrandingsIdresourceNameFormat**
> void DELETEBrandingsIdresourceNameFormat (int? id, string resourceName = null)

Deletes a branding resource

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEBrandingsIdresourceNameFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var id = 56;  // int? | <p>Branding id</p> 
            var resourceName = resourceName_example;  // string |   (optional) 

            try
            {
                // Deletes a branding resource
                apiInstance.DELETEBrandingsIdresourceNameFormat(id, resourceName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.DELETEBrandingsIdresourceNameFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| &lt;p&gt;Branding id&lt;/p&gt;  | 
 **resourceName** | **string**|   | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrandingsformat"></a>
# **GETBrandingsFormat**
> Branding GETBrandingsFormat (string acceptVersion, string authorization, string except = null, string only = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null)

Get brandings

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETBrandingsFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var except = except_example;  // string | <p>Specifies which attributes to skip. Default is ‘resources.data’</p>  (optional) 
            var only = only_example;  // string | <p>Specifies which attributes to include. (Overrides except default)</p>  (optional) 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to name)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to asc)

            try
            {
                // Get brandings
                Branding result = apiInstance.GETBrandingsFormat(acceptVersion, authorization, except, only, page, pageSize, sortBy, sortDir);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.GETBrandingsFormat: " + e.Message );
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
 **except** | **string**| &lt;p&gt;Specifies which attributes to skip. Default is ‘resources.data’&lt;/p&gt;  | [optional] 
 **only** | **string**| &lt;p&gt;Specifies which attributes to include. (Overrides except default)&lt;/p&gt;  | [optional] 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to name]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to asc]

### Return type

[**Branding**](Branding.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrandingsidformat"></a>
# **GETBrandingsIdFormat**
> Branding GETBrandingsIdFormat (string acceptVersion, string authorization, int? id, string except = null, string only = null)

Get a branding

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETBrandingsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Branding id</p> 
            var except = except_example;  // string | <p>Specifies which attributes to skip. Default is ‘resources.data’</p>  (optional) 
            var only = only_example;  // string | <p>Specifies which attributes to include. (Overrides except default)</p>  (optional) 

            try
            {
                // Get a branding
                Branding result = apiInstance.GETBrandingsIdFormat(acceptVersion, authorization, id, except, only);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.GETBrandingsIdFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Branding id&lt;/p&gt;  | 
 **except** | **string**| &lt;p&gt;Specifies which attributes to skip. Default is ‘resources.data’&lt;/p&gt;  | [optional] 
 **only** | **string**| &lt;p&gt;Specifies which attributes to include. (Overrides except default)&lt;/p&gt;  | [optional] 

### Return type

[**Branding**](Branding.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrandingsidresourcenameformat"></a>
# **GETBrandingsIdresourceNameFormat**
> void GETBrandingsIdresourceNameFormat (int? id, string resourceName = null)

Gets a branding resource as a file

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETBrandingsIdresourceNameFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var id = 56;  // int? | <p>Branding id</p> 
            var resourceName = resourceName_example;  // string |   (optional) 

            try
            {
                // Gets a branding resource as a file
                apiInstance.GETBrandingsIdresourceNameFormat(id, resourceName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.GETBrandingsIdresourceNameFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| &lt;p&gt;Branding id&lt;/p&gt;  | 
 **resourceName** | **string**|   | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchbrandingsidformat"></a>
# **PATCHBrandingsIdFormat**
> Branding PATCHBrandingsIdFormat (string acceptVersion, string authorization, int? id, string name = null, string except = null, string only = null)

Update a branding

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHBrandingsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Branding id</p> 
            var name = name_example;  // string | <p>Descriptive name of the branding</p>  (optional) 
            var except = except_example;  // string | <p>Specifies which attributes to skip. Default is ‘resources.data’</p>  (optional) 
            var only = only_example;  // string | <p>Specifies which attributes to include. (Overrides except default)</p>  (optional) 

            try
            {
                // Update a branding
                Branding result = apiInstance.PATCHBrandingsIdFormat(acceptVersion, authorization, id, name, except, only);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.PATCHBrandingsIdFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Branding id&lt;/p&gt;  | 
 **name** | **string**| &lt;p&gt;Descriptive name of the branding&lt;/p&gt;  | [optional] 
 **except** | **string**| &lt;p&gt;Specifies which attributes to skip. Default is ‘resources.data’&lt;/p&gt;  | [optional] 
 **only** | **string**| &lt;p&gt;Specifies which attributes to include. (Overrides except default)&lt;/p&gt;  | [optional] 

### Return type

[**Branding**](Branding.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postbrandingsformat"></a>
# **POSTBrandingsFormat**
> Branding POSTBrandingsFormat (string acceptVersion, string authorization, string name)

Create a branding

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTBrandingsFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var name = name_example;  // string | <p>Descriptive name of the branding</p> 

            try
            {
                // Create a branding
                Branding result = apiInstance.POSTBrandingsFormat(acceptVersion, authorization, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.POSTBrandingsFormat: " + e.Message );
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
 **name** | **string**| &lt;p&gt;Descriptive name of the branding&lt;/p&gt;  | 

### Return type

[**Branding**](Branding.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postbrandingsidcopyformat"></a>
# **POSTBrandingsIdCopyFormat**
> Branding POSTBrandingsIdCopyFormat (string acceptVersion, string authorization, int? id, string except = null, string only = null)

Copies branding and returns the new branding

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTBrandingsIdCopyFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Branding id</p> 
            var except = except_example;  // string | <p>Specifies which attributes to skip. Default is ‘resources.data’</p>  (optional) 
            var only = only_example;  // string | <p>Specifies which attributes to include. (Overrides except default)</p>  (optional) 

            try
            {
                // Copies branding and returns the new branding
                Branding result = apiInstance.POSTBrandingsIdCopyFormat(acceptVersion, authorization, id, except, only);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.POSTBrandingsIdCopyFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Branding id&lt;/p&gt;  | 
 **except** | **string**| &lt;p&gt;Specifies which attributes to skip. Default is ‘resources.data’&lt;/p&gt;  | [optional] 
 **only** | **string**| &lt;p&gt;Specifies which attributes to include. (Overrides except default)&lt;/p&gt;  | [optional] 

### Return type

[**Branding**](Branding.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbrandingsidresourcenameformat"></a>
# **PUTBrandingsIdresourceNameFormat**
> void PUTBrandingsIdresourceNameFormat (string acceptVersion, string authorization, int? id, string _file, string resourceName = null)

Uploads a file and creates or replaces a resource

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PUTBrandingsIdresourceNameFormatExample
    {
        public void main()
        {
            var apiInstance = new BrandingsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Branding id</p> 
            var _file = _file_example;  // string | <p>The file send as multipart</p> 
            var resourceName = resourceName_example;  // string |   (optional) 

            try
            {
                // Uploads a file and creates or replaces a resource
                apiInstance.PUTBrandingsIdresourceNameFormat(acceptVersion, authorization, id, _file, resourceName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandingsApi.PUTBrandingsIdresourceNameFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Branding id&lt;/p&gt;  | 
 **_file** | **string**| &lt;p&gt;The file send as multipart&lt;/p&gt;  | 
 **resourceName** | **string**|   | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

