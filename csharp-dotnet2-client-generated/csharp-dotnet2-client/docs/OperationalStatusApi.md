# IO.Swagger.Api.OperationalStatusApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETOperationalStatusAcquirersFormat**](OperationalStatusApi.md#getoperationalstatusacquirersformat) | **GET** /operational-status/acquirers | Gets operational status of all acquirers


<a name="getoperationalstatusacquirersformat"></a>
# **GETOperationalStatusAcquirersFormat**
> AcquirerStatus GETOperationalStatusAcquirersFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir)

Gets operational status of all acquirers

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETOperationalStatusAcquirersFormatExample
    {
        public void main()
        {
            
            var apiInstance = new OperationalStatusApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to acquirer)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to asc)

            try
            {
                // Gets operational status of all acquirers
                AcquirerStatus result = apiInstance.GETOperationalStatusAcquirersFormat(acceptVersion, authorization, page, pageSize, sortBy, sortDir);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationalStatusApi.GETOperationalStatusAcquirersFormat: " + e.Message );
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
 **sortBy** | **string**| Property to sort by  | [optional] [default to acquirer]
 **sortDir** | **string**| Sort direction  | [optional] [default to asc]

### Return type

[**AcquirerStatus**](AcquirerStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

