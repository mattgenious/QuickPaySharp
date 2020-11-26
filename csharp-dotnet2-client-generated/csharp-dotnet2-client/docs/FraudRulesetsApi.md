# IO.Swagger.Api.FraudRulesetsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/merchant*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETEFraudRulesetsIdFormat**](FraudRulesetsApi.md#deletefraudrulesetsidformat) | **DELETE** /fraud-rulesets/{id} | Delete ruleset
[**GETFraudRulesetsFormat**](FraudRulesetsApi.md#getfraudrulesetsformat) | **GET** /fraud-rulesets | Get custom defined fraud rulesets
[**GETFraudRulesetsIdFormat**](FraudRulesetsApi.md#getfraudrulesetsidformat) | **GET** /fraud-rulesets/{id} | Get ruleset by id
[**PATCHFraudRulesetsIdFormat**](FraudRulesetsApi.md#patchfraudrulesetsidformat) | **PATCH** /fraud-rulesets/{id} | Update a ruleset
[**POSTFraudRulesetsFormat**](FraudRulesetsApi.md#postfraudrulesetsformat) | **POST** /fraud-rulesets | Create a custom fraud ruleset


<a name="deletefraudrulesetsidformat"></a>
# **DELETEFraudRulesetsIdFormat**
> QuickPayProtocolV10FraudRuleset DELETEFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id)

Delete ruleset

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEFraudRulesetsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new FraudRulesetsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Ruleset id</p> 

            try
            {
                // Delete ruleset
                QuickPayProtocolV10FraudRuleset result = apiInstance.DELETEFraudRulesetsIdFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FraudRulesetsApi.DELETEFraudRulesetsIdFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Ruleset id&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10FraudRuleset**](QuickPayProtocolV10FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfraudrulesetsformat"></a>
# **GETFraudRulesetsFormat**
> QuickPayProtocolV10FraudRuleset GETFraudRulesetsFormat (string acceptVersion, string authorization)

Get custom defined fraud rulesets

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETFraudRulesetsFormatExample
    {
        public void main()
        {
            
            var apiInstance = new FraudRulesetsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 

            try
            {
                // Get custom defined fraud rulesets
                QuickPayProtocolV10FraudRuleset result = apiInstance.GETFraudRulesetsFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FraudRulesetsApi.GETFraudRulesetsFormat: " + e.Message );
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

### Return type

[**QuickPayProtocolV10FraudRuleset**](QuickPayProtocolV10FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfraudrulesetsidformat"></a>
# **GETFraudRulesetsIdFormat**
> QuickPayProtocolV10FraudRuleset GETFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id)

Get ruleset by id

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETFraudRulesetsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new FraudRulesetsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Ruleset id</p> 

            try
            {
                // Get ruleset by id
                QuickPayProtocolV10FraudRuleset result = apiInstance.GETFraudRulesetsIdFormat(acceptVersion, authorization, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FraudRulesetsApi.GETFraudRulesetsIdFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Ruleset id&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10FraudRuleset**](QuickPayProtocolV10FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchfraudrulesetsidformat"></a>
# **PATCHFraudRulesetsIdFormat**
> QuickPayProtocolV10FraudRuleset PATCHFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id, string filterRulesMetricName, string filterRulesOperator, string filterRulesValue, string name, string action, string combinator)

Update a ruleset

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHFraudRulesetsIdFormatExample
    {
        public void main()
        {
            
            var apiInstance = new FraudRulesetsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var id = 56;  // int? | <p>Ruleset id</p> 
            var filterRulesMetricName = filterRulesMetricName_example;  // string | <p>Name af variable metric</p> 
            var filterRulesOperator = filterRulesOperator_example;  // string | <p>Operator</p> 
            var filterRulesValue = filterRulesValue_example;  // string | <p>String representation of the value to compare to the metric</p> 
            var name = name_example;  // string | <p>Descriptive name</p>  (optional) 
            var action = action_example;  // string | <p>Action to take when ruleset triggers</p>  (optional) 
            var combinator = combinator_example;  // string | <p>Method to combine filter rules</p>  (optional) 

            try
            {
                // Update a ruleset
                QuickPayProtocolV10FraudRuleset result = apiInstance.PATCHFraudRulesetsIdFormat(acceptVersion, authorization, id, filterRulesMetricName, filterRulesOperator, filterRulesValue, name, action, combinator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FraudRulesetsApi.PATCHFraudRulesetsIdFormat: " + e.Message );
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
 **id** | **int?**| &lt;p&gt;Ruleset id&lt;/p&gt;  | 
 **filterRulesMetricName** | **string**| &lt;p&gt;Name af variable metric&lt;/p&gt;  | 
 **filterRulesOperator** | **string**| &lt;p&gt;Operator&lt;/p&gt;  | 
 **filterRulesValue** | **string**| &lt;p&gt;String representation of the value to compare to the metric&lt;/p&gt;  | 
 **name** | **string**| &lt;p&gt;Descriptive name&lt;/p&gt;  | [optional] 
 **action** | **string**| &lt;p&gt;Action to take when ruleset triggers&lt;/p&gt;  | [optional] 
 **combinator** | **string**| &lt;p&gt;Method to combine filter rules&lt;/p&gt;  | [optional] 

### Return type

[**QuickPayProtocolV10FraudRuleset**](QuickPayProtocolV10FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfraudrulesetsformat"></a>
# **POSTFraudRulesetsFormat**
> QuickPayProtocolV10FraudRuleset POSTFraudRulesetsFormat (string acceptVersion, string authorization, string name, string filterRulesMetricName, string filterRulesOperator, string filterRulesValue, string action, string combinator)

Create a custom fraud ruleset

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class POSTFraudRulesetsFormatExample
    {
        public void main()
        {
            
            var apiInstance = new FraudRulesetsApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var name = name_example;  // string | <p>Descriptive name</p> 
            var filterRulesMetricName = filterRulesMetricName_example;  // string | <p>Name af variable metric</p> 
            var filterRulesOperator = filterRulesOperator_example;  // string | <p>Operator</p> 
            var filterRulesValue = filterRulesValue_example;  // string | <p>String representation of the value to compare to the metric, e.g. ‘DNK’, ‘42’ or ‘DNK, DEU’</p> 
            var action = action_example;  // string | <p>Action to take when ruleset triggers</p> 
            var combinator = combinator_example;  // string | <p>Method to combine filter rules</p> 

            try
            {
                // Create a custom fraud ruleset
                QuickPayProtocolV10FraudRuleset result = apiInstance.POSTFraudRulesetsFormat(acceptVersion, authorization, name, filterRulesMetricName, filterRulesOperator, filterRulesValue, action, combinator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FraudRulesetsApi.POSTFraudRulesetsFormat: " + e.Message );
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
 **name** | **string**| &lt;p&gt;Descriptive name&lt;/p&gt;  | 
 **filterRulesMetricName** | **string**| &lt;p&gt;Name af variable metric&lt;/p&gt;  | 
 **filterRulesOperator** | **string**| &lt;p&gt;Operator&lt;/p&gt;  | 
 **filterRulesValue** | **string**| &lt;p&gt;String representation of the value to compare to the metric, e.g. ‘DNK’, ‘42’ or ‘DNK, DEU’&lt;/p&gt;  | 
 **action** | **string**| &lt;p&gt;Action to take when ruleset triggers&lt;/p&gt;  | 
 **combinator** | **string**| &lt;p&gt;Method to combine filter rules&lt;/p&gt;  | 

### Return type

[**QuickPayProtocolV10FraudRuleset**](QuickPayProtocolV10FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

