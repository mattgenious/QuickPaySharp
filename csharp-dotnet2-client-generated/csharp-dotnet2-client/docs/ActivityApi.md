# IO.Swagger.Api.ActivityApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GETActivityFormat**](ActivityApi.md#getactivityformat) | **GET** /activity | Get activity
[**GETActivityIdFormat**](ActivityApi.md#getactivityidformat) | **GET** /activity/{id} | Get a single activity entry


<a name="getactivityformat"></a>
# **GETActivityFormat**
> QuickPayProtocolV10Activity GETActivityFormat (string acceptVersion, string authorization, int? userId, string targetType, int? targetId, bool? support, int? page, int? pageSize, string sortBy, string sortDir, string pageKey)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var userId = 56;  // int? | <p>Limit to activity by user_id</p>  (optional) 
            var targetType = targetType_example;  // string | <p>Filter by target type, e.g. ‘Payment’</p>  (optional) 
            var targetId = 56;  // int? | <p>Filter by target id, e.g. id of payment</p>  (optional) 
            var support = true;  // bool? | <p>Filter by whether a support user made the activity</p>  (optional) 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to created_at)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to desc)
            var pageKey = pageKey_example;  // string |   (optional) 

            try
            {
                // Get activity
                QuickPayProtocolV10Activity result = apiInstance.GETActivityFormat(acceptVersion, authorization, userId, targetType, targetId, support, page, pageSize, sortBy, sortDir, pageKey);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **userId** | **int?**| &lt;p&gt;Limit to activity by user_id&lt;/p&gt;  | [optional] 
 **targetType** | **string**| &lt;p&gt;Filter by target type, e.g. ‘Payment’&lt;/p&gt;  | [optional] 
 **targetId** | **int?**| &lt;p&gt;Filter by target id, e.g. id of payment&lt;/p&gt;  | [optional] 
 **support** | **bool?**| &lt;p&gt;Filter by whether a support user made the activity&lt;/p&gt;  | [optional] 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to created_at]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to desc]
 **pageKey** | **string**|   | [optional] 

### Return type

[**QuickPayProtocolV10Activity**](QuickPayProtocolV10Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivityidformat"></a>
# **GETActivityIdFormat**
> QuickPayProtocolV10Activity GETActivityIdFormat (string acceptVersion, string authorization, string id)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = id_example;  // string | <p>Activity entry id</p> 

            try
            {
                // Get a single activity entry
                QuickPayProtocolV10Activity result = apiInstance.GETActivityIdFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **string**| &lt;p&gt;Activity entry id&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10Activity**](QuickPayProtocolV10Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

