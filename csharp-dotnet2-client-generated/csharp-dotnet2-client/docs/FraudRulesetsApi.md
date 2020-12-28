# IO.Swagger.Api.FraudRulesetsApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETEFraudRulesetsIdFormat**](FraudRulesetsApi.md#deletefraudrulesetsidformat) | **DELETE** /fraud-rulesets/{id} | Delete ruleset
[**GETFraudRulesetsFormat**](FraudRulesetsApi.md#getfraudrulesetsformat) | **GET** /fraud-rulesets | Get custom defined fraud rulesets
[**GETFraudRulesetsIdFormat**](FraudRulesetsApi.md#getfraudrulesetsidformat) | **GET** /fraud-rulesets/{id} | Get ruleset by id
[**PATCHFraudRulesetsIdFormat**](FraudRulesetsApi.md#patchfraudrulesetsidformat) | **PATCH** /fraud-rulesets/{id} | Update a ruleset
[**POSTFraudRulesetsFormat**](FraudRulesetsApi.md#postfraudrulesetsformat) | **POST** /fraud-rulesets | Create a custom fraud ruleset


<a name="deletefraudrulesetsidformat"></a>
# **DELETEFraudRulesetsIdFormat**
> FraudRuleset DELETEFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Ruleset id 

            try
            {
                // Delete ruleset
                FraudRuleset result = apiInstance.DELETEFraudRulesetsIdFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Ruleset id  | 

### Return type

[**FraudRuleset**](FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfraudrulesetsformat"></a>
# **GETFraudRulesetsFormat**
> FraudRuleset GETFraudRulesetsFormat (string acceptVersion, string authorization)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 

            try
            {
                // Get custom defined fraud rulesets
                FraudRuleset result = apiInstance.GETFraudRulesetsFormat(acceptVersion, authorization);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 

### Return type

[**FraudRuleset**](FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfraudrulesetsidformat"></a>
# **GETFraudRulesetsIdFormat**
> FraudRuleset GETFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Ruleset id 

            try
            {
                // Get ruleset by id
                FraudRuleset result = apiInstance.GETFraudRulesetsIdFormat(acceptVersion, authorization, id);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Ruleset id  | 

### Return type

[**FraudRuleset**](FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchfraudrulesetsidformat"></a>
# **PATCHFraudRulesetsIdFormat**
> FraudRuleset PATCHFraudRulesetsIdFormat (string acceptVersion, string authorization, int? id, string filterRulesMetricName, string filterRulesOperator, string filterRulesValue, string name, string action, string combinator)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var id = 56;  // int? | Ruleset id 
            var filterRulesMetricName = filterRulesMetricName_example;  // string | Name af variable metric 
            var filterRulesOperator = filterRulesOperator_example;  // string | Operator 
            var filterRulesValue = filterRulesValue_example;  // string | String representation of the value to compare to the metric 
            var name = name_example;  // string | Descriptive name  (optional) 
            var action = action_example;  // string | Action to take when ruleset triggers  (optional) 
            var combinator = combinator_example;  // string | Method to combine filter rules  (optional) 

            try
            {
                // Update a ruleset
                FraudRuleset result = apiInstance.PATCHFraudRulesetsIdFormat(acceptVersion, authorization, id, filterRulesMetricName, filterRulesOperator, filterRulesValue, name, action, combinator);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **id** | **int?**| Ruleset id  | 
 **filterRulesMetricName** | **string**| Name af variable metric  | 
 **filterRulesOperator** | **string**| Operator  | 
 **filterRulesValue** | **string**| String representation of the value to compare to the metric  | 
 **name** | **string**| Descriptive name  | [optional] 
 **action** | **string**| Action to take when ruleset triggers  | [optional] 
 **combinator** | **string**| Method to combine filter rules  | [optional] 

### Return type

[**FraudRuleset**](FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfraudrulesetsformat"></a>
# **POSTFraudRulesetsFormat**
> FraudRuleset POSTFraudRulesetsFormat (string acceptVersion, string authorization, string name, string filterRulesMetricName, string filterRulesOperator, string filterRulesValue, string action, string combinator)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var name = name_example;  // string | Descriptive name 
            var filterRulesMetricName = filterRulesMetricName_example;  // string | Name af variable metric 
            var filterRulesOperator = filterRulesOperator_example;  // string | Operator 
            var filterRulesValue = filterRulesValue_example;  // string | String representation of the value to compare to the metric, e.g. ‘DNK’, ‘42’ or ‘DNK, DEU’ 
            var action = action_example;  // string | Action to take when ruleset triggers 
            var combinator = combinator_example;  // string | Method to combine filter rules 

            try
            {
                // Create a custom fraud ruleset
                FraudRuleset result = apiInstance.POSTFraudRulesetsFormat(acceptVersion, authorization, name, filterRulesMetricName, filterRulesOperator, filterRulesValue, action, combinator);
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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **name** | **string**| Descriptive name  | 
 **filterRulesMetricName** | **string**| Name af variable metric  | 
 **filterRulesOperator** | **string**| Operator  | 
 **filterRulesValue** | **string**| String representation of the value to compare to the metric, e.g. ‘DNK’, ‘42’ or ‘DNK, DEU’  | 
 **action** | **string**| Action to take when ruleset triggers  | 
 **combinator** | **string**| Method to combine filter rules  | 

### Return type

[**FraudRuleset**](FraudRuleset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

