# IO.Swagger.Api.SubscriptionGroupsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

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
> SubscriptionGroup DELETESubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription-group id 

            try
            {
                // Delete subscription group
                SubscriptionGroup result = apiInstance.DELETESubscriptionGroupsIdFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Subscription-group id  | 

### Return type

[**SubscriptionGroup**](SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiongroupsformat"></a>
# **GETSubscriptionGroupsFormat**
> SubscriptionGroup GETSubscriptionGroupsFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)

            try
            {
                // Get all subscription groups
                SubscriptionGroup result = apiInstance.GETSubscriptionGroupsFormat(acceptVersion, authorization, page, pageSize, sortBy, sortDir);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]
 **sortBy** | **string**| Property to sort by  | [optional] [default to id]
 **sortDir** | **string**| Sort direction  | [optional] [default to desc]

### Return type

[**SubscriptionGroup**](SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiongroupsidformat"></a>
# **GETSubscriptionGroupsIdFormat**
> SubscriptionGroup GETSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription-group id 

            try
            {
                // Find subscription group by id
                SubscriptionGroup result = apiInstance.GETSubscriptionGroupsIdFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Subscription-group id  | 

### Return type

[**SubscriptionGroup**](SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchsubscriptiongroupsidformat"></a>
# **PATCHSubscriptionGroupsIdFormat**
> SubscriptionGroup PATCHSubscriptionGroupsIdFormat (string acceptVersion, string authorization, int? id, string name, int? amount, string description)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription-group id 
            var name = name_example;  // string | Name of the group  (optional) 
            var amount = 56;  // int? | Amount to capture on each recurring capture  (optional) 
            var description = description_example;  // string | Descriptive text  (optional) 

            try
            {
                // Update subscription group
                SubscriptionGroup result = apiInstance.PATCHSubscriptionGroupsIdFormat(acceptVersion, authorization, id, name, amount, description);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Subscription-group id  | 
 **name** | **string**| Name of the group  | [optional] 
 **amount** | **int?**| Amount to capture on each recurring capture  | [optional] 
 **description** | **string**| Descriptive text  | [optional] 

### Return type

[**SubscriptionGroup**](SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptiongroupsformat"></a>
# **POSTSubscriptionGroupsFormat**
> SubscriptionGroup POSTSubscriptionGroupsFormat (string acceptVersion, string authorization, string name, int? amount, string currency, string description)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var name = name_example;  // string | Name of the group 
            var amount = 56;  // int? | Amount to capture on each recurring capture 
            var currency = currency_example;  // string | Currency for the amount 
            var description = description_example;  // string | Descriptive text  (optional) 

            try
            {
                // Create subscription group
                SubscriptionGroup result = apiInstance.POSTSubscriptionGroupsFormat(acceptVersion, authorization, name, amount, currency, description);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **name** | **string**| Name of the group  | 
 **amount** | **int?**| Amount to capture on each recurring capture  | 
 **currency** | **string**| Currency for the amount  | 
 **description** | **string**| Descriptive text  | [optional] 

### Return type

[**SubscriptionGroup**](SubscriptionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsubscriptiongroupsidcaptureformat"></a>
# **POSTSubscriptionGroupsIdCaptureFormat**
> SubscriptionGroupResult POSTSubscriptionGroupsIdCaptureFormat (string acceptVersion, string authorization, int? id, string orderIdPrefix)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Subscription-group id 
            var orderIdPrefix = orderIdPrefix_example;  // string | Unique prefix for the order id of the recurring payments 

            try
            {
                // Create recurring payments on subscription group
                SubscriptionGroupResult result = apiInstance.POSTSubscriptionGroupsIdCaptureFormat(acceptVersion, authorization, id, orderIdPrefix);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Subscription-group id  | 
 **orderIdPrefix** | **string**| Unique prefix for the order id of the recurring payments  | 

### Return type

[**SubscriptionGroupResult**](SubscriptionGroupResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

