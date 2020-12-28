# IO.Swagger.Api.AclResourcesApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETAclResourcesFormat**](AclResourcesApi.md#getaclresourcesformat) | **GET** /acl-resources | Get acl resources


<a name="getaclresourcesformat"></a>
# **GETAclResourcesFormat**
> AclResource GETAclResourcesFormat (string acceptVersion, string authorization, int? page, int? pageSize)

Get acl resources

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETAclResourcesFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AclResourcesApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API  (optional) 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)

            try
            {
                // Get acl resources
                AclResource result = apiInstance.GETAclResourcesFormat(acceptVersion, authorization, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AclResourcesApi.GETAclResourcesFormat: " + e.Message );
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
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]

### Return type

[**AclResource**](AclResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

