# IO.Swagger.Api.OperationalStatusApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETOperationalStatusAcquirersFormat**](OperationalStatusApi.md#getoperationalstatusacquirersformat) | **GET** /operational-status/acquirers | Gets operational status of all acquirers


<a name="getoperationalstatusacquirersformat"></a>
# **GETOperationalStatusAcquirersFormat**
> QuickPayProtocolV10AcquirerStatus GETOperationalStatusAcquirersFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to acquirer)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to asc)

            try
            {
                // Gets operational status of all acquirers
                QuickPayProtocolV10AcquirerStatus result = apiInstance.GETOperationalStatusAcquirersFormat(acceptVersion, authorization, page, pageSize, sortBy, sortDir);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to acquirer]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to asc]

### Return type

[**QuickPayProtocolV10AcquirerStatus**](QuickPayProtocolV10AcquirerStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

