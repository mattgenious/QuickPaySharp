# IO.Swagger.Api.ChangelogApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETChangelogFormat**](ChangelogApi.md#getchangelogformat) | **GET** /changelog | Get the QuickPay API Changelog


<a name="getchangelogformat"></a>
# **GETChangelogFormat**
> void GETChangelogFormat (string acceptVersion, string authorization)

Get the QuickPay API Changelog

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETChangelogFormatExample
    {
        public void main()
        {
            
            var apiInstance = new ChangelogApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p>  (optional) 

            try
            {
                // Get the QuickPay API Changelog
                apiInstance.GETChangelogFormat(acceptVersion, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangelogApi.GETChangelogFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

