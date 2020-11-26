# IO.Swagger.Api.AgreementsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Agreement id</p> 

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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Agreement id&lt;/p&gt;  | 

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
> QuickPayProtocolV10Agreement GETAgreementsFormat (string acceptVersion, string authorization, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null, int? pageKey = null, bool? support = null, string service = null, bool? me = null, int? accountId = null)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to id)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to desc)
            var pageKey = 56;  // int? |   (optional) 
            var support = true;  // bool? | <p>Return only or filter out support agreements</p>  (optional) 
            var service = service_example;  // string | <p>Filter by system agreement service name</p>  (optional) 
            var me = true;  // bool? | <p>If set, only show the agreement of the caller</p>  (optional) 
            var accountId = 56;  // int? | <p>If set, shows agreements for another account if current account has access.</p>  (optional) 

            try
            {
                // Get agreements
                QuickPayProtocolV10Agreement result = apiInstance.GETAgreementsFormat(acceptVersion, authorization, page, pageSize, sortBy, sortDir, pageKey, support, service, me, accountId);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to id]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to desc]
 **pageKey** | **int?**|   | [optional] 
 **support** | **bool?**| &lt;p&gt;Return only or filter out support agreements&lt;/p&gt;  | [optional] 
 **service** | **string**| &lt;p&gt;Filter by system agreement service name&lt;/p&gt;  | [optional] 
 **me** | **bool?**| &lt;p&gt;If set, only show the agreement of the caller&lt;/p&gt;  | [optional] 
 **accountId** | **int?**| &lt;p&gt;If set, shows agreements for another account if current account has access.&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Agreement**](QuickPayProtocolV10Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagreementsidactivityformat"></a>
# **GETAgreementsIdActivityFormat**
> QuickPayProtocolV10Activity GETAgreementsIdActivityFormat (string acceptVersion, string authorization, int? id, int? page = null, int? pageSize = null, string sortBy = null, string sortDir = null)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Agreement id</p> 
            var page = 56;  // int? | <p>Pagination page. Default is 1</p>  (optional)  (default to 1)
            var pageSize = 56;  // int? | <p>Items per page. Default is 20</p>  (optional)  (default to 20)
            var sortBy = sortBy_example;  // string | <p>Property to sort by</p>  (optional)  (default to created_at)
            var sortDir = sortDir_example;  // string | <p>Sort direction</p>  (optional)  (default to desc)

            try
            {
                // Get agreement activity
                QuickPayProtocolV10Activity result = apiInstance.GETAgreementsIdActivityFormat(acceptVersion, authorization, id, page, pageSize, sortBy, sortDir);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Agreement id&lt;/p&gt;  | 
 **page** | **int?**| &lt;p&gt;Pagination page. Default is 1&lt;/p&gt;  | [optional] [default to 1]
 **pageSize** | **int?**| &lt;p&gt;Items per page. Default is 20&lt;/p&gt;  | [optional] [default to 20]
 **sortBy** | **string**| &lt;p&gt;Property to sort by&lt;/p&gt;  | [optional] [default to created_at]
 **sortDir** | **string**| &lt;p&gt;Sort direction&lt;/p&gt;  | [optional] [default to desc]

### Return type

[**QuickPayProtocolV10Activity**](QuickPayProtocolV10Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagreementsidformat"></a>
# **GETAgreementsIdFormat**
> QuickPayProtocolV10Agreement GETAgreementsIdFormat (string acceptVersion, string authorization, int? id)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Agreement id</p> 

            try
            {
                // Get agreement
                QuickPayProtocolV10Agreement result = apiInstance.GETAgreementsIdFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Agreement id&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10Agreement**](QuickPayProtocolV10Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchagreementsidapikeyformat"></a>
# **PATCHAgreementsIdApiKeyFormat**
> QuickPayProtocolV10Agreement PATCHAgreementsIdApiKeyFormat (string acceptVersion, string authorization, int? id)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Agreement id</p> 

            try
            {
                // Regenerate the API key for this agreement
                QuickPayProtocolV10Agreement result = apiInstance.PATCHAgreementsIdApiKeyFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Agreement id&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10Agreement**](QuickPayProtocolV10Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchagreementsidformat"></a>
# **PATCHAgreementsIdFormat**
> QuickPayProtocolV10Agreement PATCHAgreementsIdFormat (string acceptVersion, string authorization, int? id, string ipRestrictionAddress, bool? owner = null, string description = null)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Agreement id</p> 
            var ipRestrictionAddress = ipRestrictionAddress_example;  // string | <p>IP address</p> 
            var owner = true;  // bool? | <p>Is account owner</p>  (optional) 
            var description = description_example;  // string | <p>Description of the account</p>  (optional) 

            try
            {
                // Update agreement
                QuickPayProtocolV10Agreement result = apiInstance.PATCHAgreementsIdFormat(acceptVersion, authorization, id, ipRestrictionAddress, owner, description);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Agreement id&lt;/p&gt;  | 
 **ipRestrictionAddress** | **string**| &lt;p&gt;IP address&lt;/p&gt;  | 
 **owner** | **bool?**| &lt;p&gt;Is account owner&lt;/p&gt;  | [optional] 
 **description** | **string**| &lt;p&gt;Description of the account&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Agreement**](QuickPayProtocolV10Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postagreementsformat"></a>
# **POSTAgreementsFormat**
> QuickPayProtocolV10Agreement POSTAgreementsFormat (string acceptVersion, string authorization, string aclPermissionsResource, string ipRestrictionAddress, string userEmail = null, string systemUser = null, bool? owner = null, string description = null, bool? aclPermissionsGet = null, bool? aclPermissionsPost = null, bool? aclPermissionsPut = null, bool? aclPermissionsDelete = null, bool? aclPermissionsPatch = null)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var aclPermissionsResource = aclPermissionsResource_example;  // string | <p>Resource uri</p> 
            var ipRestrictionAddress = ipRestrictionAddress_example;  // string | <p>IP address</p> 
            var userEmail = userEmail_example;  // string | <p>Email of the user to invite to this account. Only one of user_email and system_user can be specified.</p>  (optional) 
            var systemUser = systemUser_example;  // string | <p>Create a new system user with this name. Only one of user_email and system_user can be specified.</p>  (optional) 
            var owner = true;  // bool? | <p>Is account owner. Default is false</p>  (optional) 
            var description = description_example;  // string | <p>Description of the account</p>  (optional) 
            var aclPermissionsGet = true;  // bool? | <p>Allow GET</p>  (optional) 
            var aclPermissionsPost = true;  // bool? | <p>Allow POST</p>  (optional) 
            var aclPermissionsPut = true;  // bool? | <p>Allow PUT</p>  (optional) 
            var aclPermissionsDelete = true;  // bool? | <p>Allow DELETE</p>  (optional) 
            var aclPermissionsPatch = true;  // bool? | <p>Allow PATCH</p>  (optional) 

            try
            {
                // Create agreement
                QuickPayProtocolV10Agreement result = apiInstance.POSTAgreementsFormat(acceptVersion, authorization, aclPermissionsResource, ipRestrictionAddress, userEmail, systemUser, owner, description, aclPermissionsGet, aclPermissionsPost, aclPermissionsPut, aclPermissionsDelete, aclPermissionsPatch);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **aclPermissionsResource** | **string**| &lt;p&gt;Resource uri&lt;/p&gt;  | 
 **ipRestrictionAddress** | **string**| &lt;p&gt;IP address&lt;/p&gt;  | 
 **userEmail** | **string**| &lt;p&gt;Email of the user to invite to this account. Only one of user_email and system_user can be specified.&lt;/p&gt;  | [optional] 
 **systemUser** | **string**| &lt;p&gt;Create a new system user with this name. Only one of user_email and system_user can be specified.&lt;/p&gt;  | [optional] 
 **owner** | **bool?**| &lt;p&gt;Is account owner. Default is false&lt;/p&gt;  | [optional] 
 **description** | **string**| &lt;p&gt;Description of the account&lt;/p&gt;  | [optional] 
 **aclPermissionsGet** | **bool?**| &lt;p&gt;Allow GET&lt;/p&gt;  | [optional] 
 **aclPermissionsPost** | **bool?**| &lt;p&gt;Allow POST&lt;/p&gt;  | [optional] 
 **aclPermissionsPut** | **bool?**| &lt;p&gt;Allow PUT&lt;/p&gt;  | [optional] 
 **aclPermissionsDelete** | **bool?**| &lt;p&gt;Allow DELETE&lt;/p&gt;  | [optional] 
 **aclPermissionsPatch** | **bool?**| &lt;p&gt;Allow PATCH&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Agreement**](QuickPayProtocolV10Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putagreementsidformat"></a>
# **PUTAgreementsIdFormat**
> QuickPayProtocolV10Agreement PUTAgreementsIdFormat (string acceptVersion, string authorization, int? id, string aclPermissionsResource, string ipRestrictionAddress, bool? owner = null, string description = null, bool? aclPermissionsGet = null, bool? aclPermissionsPost = null, bool? aclPermissionsPut = null, bool? aclPermissionsDelete = null, bool? aclPermissionsPatch = null)

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
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Agreement id</p> 
            var aclPermissionsResource = aclPermissionsResource_example;  // string | <p>Resource uri</p> 
            var ipRestrictionAddress = ipRestrictionAddress_example;  // string | <p>IP address</p> 
            var owner = true;  // bool? | <p>Is account owner</p>  (optional) 
            var description = description_example;  // string | <p>Description of the account</p>  (optional) 
            var aclPermissionsGet = true;  // bool? | <p>Allow GET</p>  (optional) 
            var aclPermissionsPost = true;  // bool? | <p>Allow POST</p>  (optional) 
            var aclPermissionsPut = true;  // bool? | <p>Allow PUT</p>  (optional) 
            var aclPermissionsDelete = true;  // bool? | <p>Allow DELETE</p>  (optional) 
            var aclPermissionsPatch = true;  // bool? | <p>Allow PATCH</p>  (optional) 

            try
            {
                // Replace agreement
                QuickPayProtocolV10Agreement result = apiInstance.PUTAgreementsIdFormat(acceptVersion, authorization, id, aclPermissionsResource, ipRestrictionAddress, owner, description, aclPermissionsGet, aclPermissionsPost, aclPermissionsPut, aclPermissionsDelete, aclPermissionsPatch);
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
 **acceptVersion** | **string**| &lt;p&gt;Specify the version of the API&lt;/p&gt;  | 
 **authorization** | **string**| &lt;p&gt;Use Basic Auth to authorize to the API&lt;/p&gt;  | 
 **id** | **int?**| &lt;p&gt;Agreement id&lt;/p&gt;  | 
 **aclPermissionsResource** | **string**| &lt;p&gt;Resource uri&lt;/p&gt;  | 
 **ipRestrictionAddress** | **string**| &lt;p&gt;IP address&lt;/p&gt;  | 
 **owner** | **bool?**| &lt;p&gt;Is account owner&lt;/p&gt;  | [optional] 
 **description** | **string**| &lt;p&gt;Description of the account&lt;/p&gt;  | [optional] 
 **aclPermissionsGet** | **bool?**| &lt;p&gt;Allow GET&lt;/p&gt;  | [optional] 
 **aclPermissionsPost** | **bool?**| &lt;p&gt;Allow POST&lt;/p&gt;  | [optional] 
 **aclPermissionsPut** | **bool?**| &lt;p&gt;Allow PUT&lt;/p&gt;  | [optional] 
 **aclPermissionsDelete** | **bool?**| &lt;p&gt;Allow DELETE&lt;/p&gt;  | [optional] 
 **aclPermissionsPatch** | **bool?**| &lt;p&gt;Allow PATCH&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10Agreement**](QuickPayProtocolV10Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

