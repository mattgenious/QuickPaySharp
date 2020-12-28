# IO.Swagger.Api.ActivityApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETActivityFormat**](ActivityApi.md#getactivityformat) | **GET** /activity | Get activity
[**GETActivityIdFormat**](ActivityApi.md#getactivityidformat) | **GET** /activity/{id} | Get a single activity entry


<a name="getactivityformat"></a>
# **GETActivityFormat**
> Activity GETActivityFormat (string acceptVersion, string authorization, int? userId = null, string targetType = null, int? targetId = null, bool? support = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, string pageKey = null)

Get activity

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETActivityFormatExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var userId = 56;  // int? | Limit to activity by user_id  (optional) 
            var targetType = targetType_example;  // string | Filter by target type, e.g. ‘Payment’  (optional) 
            var targetId = 56;  // int? | Filter by target id, e.g. id of payment  (optional) 
            var support = true;  // bool? | Filter by whether a support user made the activity  (optional) 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to created_at)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)
            var pageKey = pageKey_example;  // string |   (optional) 

            try
            {
                // Get activity
                Activity result = apiInstance.GETActivityFormat(acceptVersion, authorization, userId, targetType, targetId, support, page, pageSize, sortBy, sortDir, pageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.GETActivityFormat: " + e.Message );
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
 **userId** | **int?**| Limit to activity by user_id  | [optional] 
 **targetType** | **string**| Filter by target type, e.g. ‘Payment’  | [optional] 
 **targetId** | **int?**| Filter by target id, e.g. id of payment  | [optional] 
 **support** | **bool?**| Filter by whether a support user made the activity  | [optional] 
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]
 **sortBy** | **string**| Property to sort by  | [optional] [default to created_at]
 **sortDir** | **string**| Sort direction  | [optional] [default to desc]
 **pageKey** | **string**|   | [optional] 

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivityidformat"></a>
# **GETActivityIdFormat**
> Activity GETActivityIdFormat (string acceptVersion, string authorization, string id)

Get a single activity entry

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETActivityIdFormatExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = id_example;  // string | Activity entry id 

            try
            {
                // Get a single activity entry
                Activity result = apiInstance.GETActivityIdFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.GETActivityIdFormat: " + e.Message );
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
 **id** | **string**| Activity entry id  | 

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

