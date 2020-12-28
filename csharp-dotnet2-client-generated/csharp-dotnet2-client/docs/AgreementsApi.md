# IO.Swagger.Api.AgreementsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETEAgreementsIdFormat**](AgreementsApi.md#deleteagreementsidformat) | **DELETE** /agreements/{id} | Delete agreement
[**GETAgreementsFormat**](AgreementsApi.md#getagreementsformat) | **GET** /agreements | Get agreements
[**GETAgreementsIdActivityFormat**](AgreementsApi.md#getagreementsidactivityformat) | **GET** /agreements/{id}/activity | Get agreement activity
[**GETAgreementsIdFormat**](AgreementsApi.md#getagreementsidformat) | **GET** /agreements/{id} | Get agreement
[**PATCHAgreementsIdApiKeyFormat**](AgreementsApi.md#patchagreementsidapikeyformat) | **PATCH** /agreements/{id}/api-key | Regenerate the API key for this agreement
[**PATCHAgreementsIdFormat**](AgreementsApi.md#patchagreementsidformat) | **PATCH** /agreements/{id} | Update agreement
[**POSTAgreementsFormat**](AgreementsApi.md#postagreementsformat) | **POST** /agreements | Create agreement
[**PUTAgreementsIdFormat**](AgreementsApi.md#putagreementsidformat) | **PUT** /agreements/{id} | Replace agreement


<a name="deleteagreementsidformat"></a>
# **DELETEAgreementsIdFormat**
> void DELETEAgreementsIdFormat (string acceptVersion, string authorization, int? id)

Delete agreement

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEAgreementsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Agreement id 

            try
            {
                // Delete agreement
                apiInstance.DELETEAgreementsIdFormat(acceptVersion, authorization, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.DELETEAgreementsIdFormat: " + e.Message );
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
 **id** | **int?**| Agreement id  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagreementsformat"></a>
# **GETAgreementsFormat**
> Agreement GETAgreementsFormat (string acceptVersion, string authorization, int? page, int? pageSize, string sortBy, string sortDir, int? pageKey, bool? support, string service, bool? me, int? accountId)

Get agreements

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETAgreementsFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)
            var pageKey = 56;  // int? |   (optional) 
            var support = true;  // bool? | Return only or filter out support agreements  (optional) 
            var service = service_example;  // string | Filter by system agreement service name  (optional) 
            var me = true;  // bool? | If set, only show the agreement of the caller  (optional) 
            var accountId = 56;  // int? | If set, shows agreements for another account if current account has access.  (optional) 

            try
            {
                // Get agreements
                Agreement result = apiInstance.GETAgreementsFormat(acceptVersion, authorization, page, pageSize, sortBy, sortDir, pageKey, support, service, me, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GETAgreementsFormat: " + e.Message );
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
 **pageKey** | **int?**|   | [optional] 
 **support** | **bool?**| Return only or filter out support agreements  | [optional] 
 **service** | **string**| Filter by system agreement service name  | [optional] 
 **me** | **bool?**| If set, only show the agreement of the caller  | [optional] 
 **accountId** | **int?**| If set, shows agreements for another account if current account has access.  | [optional] 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagreementsidactivityformat"></a>
# **GETAgreementsIdActivityFormat**
> Activity GETAgreementsIdActivityFormat (string acceptVersion, string authorization, int? id, int? page, int? pageSize, string sortBy, string sortDir)

Get agreement activity

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETAgreementsIdActivityFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Agreement id 
            var page = 56;  // int? | Pagination page. Default is 1  (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page. Default is 20  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | Property to sort by  (optional)  (default to created_at)
            var sortDir = sortDir_example;  // string | Sort direction  (optional)  (default to desc)

            try
            {
                // Get agreement activity
                Activity result = apiInstance.GETAgreementsIdActivityFormat(acceptVersion, authorization, id, page, pageSize, sortBy, sortDir);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GETAgreementsIdActivityFormat: " + e.Message );
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
 **id** | **int?**| Agreement id  | 
 **page** | **int?**| Pagination page. Default is 1  | [optional] [default to 1]
 **pageSize** | **int?**| Items per page. Default is 20  | [optional] [default to 20]
 **sortBy** | **string**| Property to sort by  | [optional] [default to created_at]
 **sortDir** | **string**| Sort direction  | [optional] [default to desc]

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagreementsidformat"></a>
# **GETAgreementsIdFormat**
> Agreement GETAgreementsIdFormat (string acceptVersion, string authorization, int? id)

Get agreement

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETAgreementsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Agreement id 

            try
            {
                // Get agreement
                Agreement result = apiInstance.GETAgreementsIdFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GETAgreementsIdFormat: " + e.Message );
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
 **id** | **int?**| Agreement id  | 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchagreementsidapikeyformat"></a>
# **PATCHAgreementsIdApiKeyFormat**
> Agreement PATCHAgreementsIdApiKeyFormat (string acceptVersion, string authorization, int? id)

Regenerate the API key for this agreement

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHAgreementsIdApiKeyFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Agreement id 

            try
            {
                // Regenerate the API key for this agreement
                Agreement result = apiInstance.PATCHAgreementsIdApiKeyFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.PATCHAgreementsIdApiKeyFormat: " + e.Message );
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
 **id** | **int?**| Agreement id  | 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchagreementsidformat"></a>
# **PATCHAgreementsIdFormat**
> Agreement PATCHAgreementsIdFormat (string acceptVersion, string authorization, int? id, string ipRestrictionAddress, bool? owner, string description)

Update agreement

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHAgreementsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Agreement id 
            var ipRestrictionAddress = ipRestrictionAddress_example;  // string | IP address 
            var owner = true;  // bool? | Is account owner  (optional) 
            var description = description_example;  // string | Description of the account  (optional) 

            try
            {
                // Update agreement
                Agreement result = apiInstance.PATCHAgreementsIdFormat(acceptVersion, authorization, id, ipRestrictionAddress, owner, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.PATCHAgreementsIdFormat: " + e.Message );
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
 **id** | **int?**| Agreement id  | 
 **ipRestrictionAddress** | **string**| IP address  | 
 **owner** | **bool?**| Is account owner  | [optional] 
 **description** | **string**| Description of the account  | [optional] 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postagreementsformat"></a>
# **POSTAgreementsFormat**
> Agreement POSTAgreementsFormat (string acceptVersion, string authorization, string aclPermissionsResource, string ipRestrictionAddress, string userEmail, string systemUser, bool? owner, string description, bool? aclPermissionsGet, bool? aclPermissionsPost, bool? aclPermissionsPut, bool? aclPermissionsDelete, bool? aclPermissionsPatch)

Create agreement

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTAgreementsFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var aclPermissionsResource = aclPermissionsResource_example;  // string | Resource uri 
            var ipRestrictionAddress = ipRestrictionAddress_example;  // string | IP address 
            var userEmail = userEmail_example;  // string | Email of the user to invite to this account. Only one of user_email and system_user can be specified.  (optional) 
            var systemUser = systemUser_example;  // string | Create a new system user with this name. Only one of user_email and system_user can be specified.  (optional) 
            var owner = true;  // bool? | Is account owner. Default is false  (optional) 
            var description = description_example;  // string | Description of the account  (optional) 
            var aclPermissionsGet = true;  // bool? | Allow GET  (optional) 
            var aclPermissionsPost = true;  // bool? | Allow POST  (optional) 
            var aclPermissionsPut = true;  // bool? | Allow PUT  (optional) 
            var aclPermissionsDelete = true;  // bool? | Allow DELETE  (optional) 
            var aclPermissionsPatch = true;  // bool? | Allow PATCH  (optional) 

            try
            {
                // Create agreement
                Agreement result = apiInstance.POSTAgreementsFormat(acceptVersion, authorization, aclPermissionsResource, ipRestrictionAddress, userEmail, systemUser, owner, description, aclPermissionsGet, aclPermissionsPost, aclPermissionsPut, aclPermissionsDelete, aclPermissionsPatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.POSTAgreementsFormat: " + e.Message );
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
 **aclPermissionsResource** | **string**| Resource uri  | 
 **ipRestrictionAddress** | **string**| IP address  | 
 **userEmail** | **string**| Email of the user to invite to this account. Only one of user_email and system_user can be specified.  | [optional] 
 **systemUser** | **string**| Create a new system user with this name. Only one of user_email and system_user can be specified.  | [optional] 
 **owner** | **bool?**| Is account owner. Default is false  | [optional] 
 **description** | **string**| Description of the account  | [optional] 
 **aclPermissionsGet** | **bool?**| Allow GET  | [optional] 
 **aclPermissionsPost** | **bool?**| Allow POST  | [optional] 
 **aclPermissionsPut** | **bool?**| Allow PUT  | [optional] 
 **aclPermissionsDelete** | **bool?**| Allow DELETE  | [optional] 
 **aclPermissionsPatch** | **bool?**| Allow PATCH  | [optional] 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putagreementsidformat"></a>
# **PUTAgreementsIdFormat**
> Agreement PUTAgreementsIdFormat (string acceptVersion, string authorization, int? id, string aclPermissionsResource, string ipRestrictionAddress, bool? owner, string description, bool? aclPermissionsGet, bool? aclPermissionsPost, bool? aclPermissionsPut, bool? aclPermissionsDelete, bool? aclPermissionsPatch)

Replace agreement

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PUTAgreementsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Agreement id 
            var aclPermissionsResource = aclPermissionsResource_example;  // string | Resource uri 
            var ipRestrictionAddress = ipRestrictionAddress_example;  // string | IP address 
            var owner = true;  // bool? | Is account owner  (optional) 
            var description = description_example;  // string | Description of the account  (optional) 
            var aclPermissionsGet = true;  // bool? | Allow GET  (optional) 
            var aclPermissionsPost = true;  // bool? | Allow POST  (optional) 
            var aclPermissionsPut = true;  // bool? | Allow PUT  (optional) 
            var aclPermissionsDelete = true;  // bool? | Allow DELETE  (optional) 
            var aclPermissionsPatch = true;  // bool? | Allow PATCH  (optional) 

            try
            {
                // Replace agreement
                Agreement result = apiInstance.PUTAgreementsIdFormat(acceptVersion, authorization, id, aclPermissionsResource, ipRestrictionAddress, owner, description, aclPermissionsGet, aclPermissionsPost, aclPermissionsPut, aclPermissionsDelete, aclPermissionsPatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.PUTAgreementsIdFormat: " + e.Message );
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
 **id** | **int?**| Agreement id  | 
 **aclPermissionsResource** | **string**| Resource uri  | 
 **ipRestrictionAddress** | **string**| IP address  | 
 **owner** | **bool?**| Is account owner  | [optional] 
 **description** | **string**| Description of the account  | [optional] 
 **aclPermissionsGet** | **bool?**| Allow GET  | [optional] 
 **aclPermissionsPost** | **bool?**| Allow POST  | [optional] 
 **aclPermissionsPut** | **bool?**| Allow PUT  | [optional] 
 **aclPermissionsDelete** | **bool?**| Allow DELETE  | [optional] 
 **aclPermissionsPatch** | **bool?**| Allow PATCH  | [optional] 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

