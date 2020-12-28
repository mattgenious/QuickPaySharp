# IO.Swagger.Api.PingApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETPingFormat**](PingApi.md#getpingformat) | **GET** /ping | Use this to test connectivity to the API
[**POSTPingFormat**](PingApi.md#postpingformat) | **POST** /ping | Use this to test connectivity to the API


<a name="getpingformat"></a>
# **GETPingFormat**
> Pong GETPingFormat (string acceptVersion, string authorization = null)

Use this to test connectivity to the API

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETPingFormatExample
    {
        public void main()
        {
            var apiInstance = new PingApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API  (optional) 

            try
            {
                // Use this to test connectivity to the API
                Pong result = apiInstance.GETPingFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PingApi.GETPingFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | [optional] 

### Return type

[**Pong**](Pong.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpingformat"></a>
# **POSTPingFormat**
> Pong POSTPingFormat (string acceptVersion, string authorization = null)

Use this to test connectivity to the API

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTPingFormatExample
    {
        public void main()
        {
            var apiInstance = new PingApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API  (optional) 

            try
            {
                // Use this to test connectivity to the API
                Pong result = apiInstance.POSTPingFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PingApi.POSTPingFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | [optional] 

### Return type

[**Pong**](Pong.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

