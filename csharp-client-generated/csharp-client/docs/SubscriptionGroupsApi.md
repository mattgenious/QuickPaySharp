# IO.Swagger.Api.SubscriptionGroupsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETESubscriptionGroupsIdFormat**](SubscriptionGroupsApi.md#deletesubscriptiongroupsidformat) | **DELETE** /subscription-groups/{id} | Delete subscription group
[**GETSubscriptionGroupsFormat**](SubscriptionGroupsApi.md#getsubscriptiongroupsformat) | **GET** /subscription-groups | Get all subscription groups
[**GETSubscriptionGroupsIdFormat**](SubscriptionGroupsApi.md#getsubscriptiongroupsidformat) | **GET** /subscription-groups/{id} | Find subscription group by id
[**PATCHSubscriptionGroupsIdFormat**](SubscriptionGroupsApi.md#patchsubscriptiongroupsidformat) | **PATCH** /subscription-groups/{id} | Update subscription group
[**POSTSubscriptionGroupsFormat**](SubscriptionGroupsApi.md#postsubscriptiongroupsformat) | **POST** /subscription-groups | Create subscription group
[**POSTSubscriptionGroupsIdCaptureFormat**](SubscriptionGroupsApi.md#postsubscriptiongroupsidcaptureformat) | **POST** /subscription-groups/{id}/capture | Create recurring payments on subscription group


<a name="deletesubscriptiongroupsidformat"></a>
# **DELETESubscriptionGroupsIdFormat**
> QuickPayProtocolV10SubscriptionGroup DELETESubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id)

Delete subscription group

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETESubscriptionGroupsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionGroupsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Subscription-group id</p> 

            try
            {
                // Delete subscription group
                QuickPayProtocolV10SubscriptionGroup result = apiInstance.DELETESubscriptionGroupsIdFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.DELETESubscriptionGroupsIdFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Subscription-group id&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10SubscriptionGroup**](QuickPayProtocolV10SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiongroupsformat"></a>
# **GETSubscriptionGroupsFormat**
> QuickPayProtocolV10SubscriptionGroup GETSubscriptionGroupsFormat (string acceptVersion, string authorization, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null)

Get all subscription groups

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETSubscriptionGroupsFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionGroupsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to desc)

            try
            {
                // Get all subscription groups
                QuickPayProtocolV10SubscriptionGroup result = apiInstance.GETSubscriptionGroupsFormat(acceptVersion, authorization, page, pageSize, sortBy, sortDir);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.GETSubscriptionGroupsFormat: " + e.Message );
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
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to id]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to desc]

### Return type

[**QuickPayProtocolV10SubscriptionGroup**](QuickPayProtocolV10SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiongroupsidformat"></a>
# **GETSubscriptionGroupsIdFormat**
> QuickPayProtocolV10SubscriptionGroup GETSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id)

Find subscription group by id

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETSubscriptionGroupsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionGroupsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Subscription-group id</p> 

            try
            {
                // Find subscription group by id
                QuickPayProtocolV10SubscriptionGroup result = apiInstance.GETSubscriptionGroupsIdFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.GETSubscriptionGroupsIdFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Subscription-group id&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10SubscriptionGroup**](QuickPayProtocolV10SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchsubscriptiongroupsidformat"></a>
# **PATCHSubscriptionGroupsIdFormat**
> QuickPayProtocolV10SubscriptionGroup PATCHSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id, string name = null, int? amount = null, string description = null)

Update subscription group

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHSubscriptionGroupsIdFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionGroupsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Subscription-group id</p> 
            var name = name_example;  // string | <p>Name of the group</p>  (optional) 
            var amount = 56;  // int? | <p>Amount to capture on each recurring capture</p>  (optional) 
            var description = description_example;  // string | <p>Descriptive text</p>  (optional) 

            try
            {
                // Update subscription group
                QuickPayProtocolV10SubscriptionGroup result = apiInstance.PATCHSubscriptionGroupsIdFormat(acceptVersion, authorization, id, name, amount, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.PATCHSubscriptionGroupsIdFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Subscription-group id&lt;/p&gt;  | 
 **name** | **string**| &lt;p&gt;Name of the group&lt;/p&gt;  | [optional] 
 **amount** | **int?**| &lt;p&gt;Amount to capture on each recurring capture&lt;/p&gt;  | [optional] 
 **description** | **string**| &lt;p&gt;Descriptive text&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10SubscriptionGroup**](QuickPayProtocolV10SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptiongroupsformat"></a>
# **POSTSubscriptionGroupsFormat**
> QuickPayProtocolV10SubscriptionGroup POSTSubscriptionGroupsFormat (string acceptVersion, string authorization, string name, int? amount, string currency, string description = null)

Create subscription group

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTSubscriptionGroupsFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionGroupsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var name = name_example;  // string | <p>Name of the group</p> 
            var amount = 56;  // int? | <p>Amount to capture on each recurring capture</p> 
            var currency = currency_example;  // string | <p>Currency for the amount</p> 
            var description = description_example;  // string | <p>Descriptive text</p>  (optional) 

            try
            {
                // Create subscription group
                QuickPayProtocolV10SubscriptionGroup result = apiInstance.POSTSubscriptionGroupsFormat(acceptVersion, authorization, name, amount, currency, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.POSTSubscriptionGroupsFormat: " + e.Message );
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
 **name** | **string**| &lt;p&gt;Name of the group&lt;/p&gt;  | 
 **amount** | **int?**| &lt;p&gt;Amount to capture on each recurring capture&lt;/p&gt;  | 
 **currency** | **string**| &lt;p&gt;Currency for the amount&lt;/p&gt;  | 
 **description** | **string**| &lt;p&gt;Descriptive text&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10SubscriptionGroup**](QuickPayProtocolV10SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptiongroupsidcaptureformat"></a>
# **POSTSubscriptionGroupsIdCaptureFormat**
> QuickPayProtocolV10SubscriptionGroupResult POSTSubscriptionGroupsIdCaptureFormat (string acceptVersion, string authorization, int? id, string orderIdPrefix)

Create recurring payments on subscription group

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTSubscriptionGroupsIdCaptureFormatExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionGroupsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Subscription-group id</p> 
            var orderIdPrefix = orderIdPrefix_example;  // string | <p>Unique prefix for the order id of the recurring payments</p> 

            try
            {
                // Create recurring payments on subscription group
                QuickPayProtocolV10SubscriptionGroupResult result = apiInstance.POSTSubscriptionGroupsIdCaptureFormat(acceptVersion, authorization, id, orderIdPrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionGroupsApi.POSTSubscriptionGroupsIdCaptureFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Subscription-group id&lt;/p&gt;  | 
 **orderIdPrefix** | **string**| &lt;p&gt;Unique prefix for the order id of the recurring payments&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10SubscriptionGroupResult**](QuickPayProtocolV10SubscriptionGroupResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

