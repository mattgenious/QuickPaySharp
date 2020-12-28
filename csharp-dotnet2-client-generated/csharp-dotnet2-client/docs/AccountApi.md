# IO.Swagger.Api.AccountApi

All URIs are relative to *https://api.quickpay.net/docs/v10/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DELETEAccount04PlatformFormat**](AccountApi.md#deleteaccount04platformformat) | **DELETE** /account/04-platform | Delete 04 platform settings
[**DELETEAccountFormat**](AccountApi.md#deleteaccountformat) | **DELETE** /account | Delete merchant account
[**DELETEAccountLogoFormat**](AccountApi.md#deleteaccountlogoformat) | **DELETE** /account/logo | Deletes the current merchant logo
[**GETAccount04PlatformFormat**](AccountApi.md#getaccount04platformformat) | **GET** /account/04-platform | Get 04 platform settings
[**GETAccountFormat**](AccountApi.md#getaccountformat) | **GET** /account | Get merchant account
[**GETAccountLogoFormat**](AccountApi.md#getaccountlogoformat) | **GET** /account/logo | Gets the merchant logo as a raw download or a 404 if none exists
[**GETAccountPrivateKeyFormat**](AccountApi.md#getaccountprivatekeyformat) | **GET** /account/private-key | Gets the private key of the merchant
[**PATCHAccountFormat**](AccountApi.md#patchaccountformat) | **PATCH** /account | Update merchant account
[**PATCHAccountPrivateKeyFormat**](AccountApi.md#patchaccountprivatekeyformat) | **PATCH** /account/private-key | Regenerates the private key of the merchant
[**PUTAccountLogoFormat**](AccountApi.md#putaccountlogoformat) | **PUT** /account/logo | Creates or replaces the current merchant logo


<a name="deleteaccount04platformformat"></a>
# **DELETEAccount04PlatformFormat**
> Zero4PlatformSettings DELETEAccount04PlatformFormat (string acceptVersion, string authorization)

Delete 04 platform settings

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEAccount04PlatformFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 

            try
            {
                // Delete 04 platform settings
                Zero4PlatformSettings result = apiInstance.DELETEAccount04PlatformFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DELETEAccount04PlatformFormat: " + e.Message );
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

[**Zero4PlatformSettings**](Zero4PlatformSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountformat"></a>
# **DELETEAccountFormat**
> void DELETEAccountFormat (string acceptVersion, string authorization)

Delete merchant account

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEAccountFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 

            try
            {
                // Delete merchant account
                apiInstance.DELETEAccountFormat(acceptVersion, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DELETEAccountFormat: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccountlogoformat"></a>
# **DELETEAccountLogoFormat**
> void DELETEAccountLogoFormat (string acceptVersion, string authorization, string logoType)

Deletes the current merchant logo

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DELETEAccountLogoFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var logoType = logoType_example;  // string | <p>Type of logo</p>  (optional)  (default to payment_window)

            try
            {
                // Deletes the current merchant logo
                apiInstance.DELETEAccountLogoFormat(acceptVersion, authorization, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.DELETEAccountLogoFormat: " + e.Message );
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
 **logoType** | **string**| &lt;p&gt;Type of logo&lt;/p&gt;  | [optional] [default to payment_window]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount04platformformat"></a>
# **GETAccount04PlatformFormat**
> Zero4PlatformSettings GETAccount04PlatformFormat (string acceptVersion, string authorization)

Get 04 platform settings

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETAccount04PlatformFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 

            try
            {
                // Get 04 platform settings
                Zero4PlatformSettings result = apiInstance.GETAccount04PlatformFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GETAccount04PlatformFormat: " + e.Message );
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

[**Zero4PlatformSettings**](Zero4PlatformSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountformat"></a>
# **GETAccountFormat**
> Merchant GETAccountFormat (string acceptVersion, string authorization)

Get merchant account

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETAccountFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 

            try
            {
                // Get merchant account
                Merchant result = apiInstance.GETAccountFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GETAccountFormat: " + e.Message );
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

[**Merchant**](Merchant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountlogoformat"></a>
# **GETAccountLogoFormat**
> void GETAccountLogoFormat (string acceptVersion, string authorization, string logoType)

Gets the merchant logo as a raw download or a 404 if none exists

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETAccountLogoFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var logoType = logoType_example;  // string | <p>Type of logo</p>  (optional)  (default to payment_window)

            try
            {
                // Gets the merchant logo as a raw download or a 404 if none exists
                apiInstance.GETAccountLogoFormat(acceptVersion, authorization, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GETAccountLogoFormat: " + e.Message );
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
 **logoType** | **string**| &lt;p&gt;Type of logo&lt;/p&gt;  | [optional] [default to payment_window]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountprivatekeyformat"></a>
# **GETAccountPrivateKeyFormat**
> PrivateKey GETAccountPrivateKeyFormat (string acceptVersion, string authorization)

Gets the private key of the merchant

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GETAccountPrivateKeyFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 

            try
            {
                // Gets the private key of the merchant
                PrivateKey result = apiInstance.GETAccountPrivateKeyFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GETAccountPrivateKeyFormat: " + e.Message );
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

[**PrivateKey**](PrivateKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchaccountformat"></a>
# **PATCHAccountFormat**
> Merchant PATCHAccountFormat (string acceptVersion, string authorization, string customerAddressName, string customerAddressAtt, string customerAddressStreet, string customerAddressCity, string customerAddressZipCode, string customerAddressRegion, string customerAddressCountryCode, string customerAddressVatNo, string billingAddressName, string billingAddressAtt, string billingAddressStreet, string billingAddressCity, string billingAddressZipCode, string billingAddressRegion, string billingAddressCountryCode, string billingAddressVatNo, string callbackUrl, bool? acquirerSettingsBamboraActive, string acquirerSettingsBamboraIdentificationCode, string acquirerSettingsBamboraIdentificationCodeInt, string acquirerSettingsBamboraBusinessCode, bool? acquirerSettingsBamboraRecurring, bool? acquirerSettingsBamboraAmericanexpress, bool? acquirerSettingsBamboraDinersclub, bool? acquirerSettingsBamboraSecurepay, string acquirerSettingsBamboraVisaMpiMerchantId, string acquirerSettingsBamboraMastercardMpiMerchantId, string acquirerSettingsBamboraVisaBin, string acquirerSettingsBamboraMastercardBin, bool? acquirerSettingsClearhausActive, string acquirerSettingsClearhausApiKey, bool? acquirerSettingsClearhausRecurring, bool? acquirerSettingsClearhausPayout, bool? acquirerSettingsClearhausApplePay, bool? acquirerSettingsElavonActive, string acquirerSettingsElavonIdentificationCode, string acquirerSettingsElavonIdentificationCodeInt, string acquirerSettingsElavonBusinessCode, bool? acquirerSettingsElavonRecurring, bool? acquirerSettingsElavonAmericanexpress, bool? acquirerSettingsElavonDinersclub, bool? acquirerSettingsElavonSecurepay, string acquirerSettingsElavonVisaMpiMerchantId, string acquirerSettingsElavonMastercardMpiMerchantId, string acquirerSettingsElavonVisaBin, string acquirerSettingsElavonMastercardBin, bool? acquirerSettingsHandelsbankenActive, string acquirerSettingsHandelsbankenIdentificationCode, string acquirerSettingsHandelsbankenIdentificationCodeInt, string acquirerSettingsHandelsbankenBusinessCode, bool? acquirerSettingsHandelsbankenRecurring, bool? acquirerSettingsHandelsbankenAmericanexpress, bool? acquirerSettingsHandelsbankenDinersclub, bool? acquirerSettingsHandelsbankenSecurepay, string acquirerSettingsHandelsbankenVisaMpiMerchantId, string acquirerSettingsHandelsbankenMastercardMpiMerchantId, string acquirerSettingsHandelsbankenVisaBin, string acquirerSettingsHandelsbankenMastercardBin, bool? acquirerSettingsKlarnaActive, int? acquirerSettingsKlarnaEid, string acquirerSettingsKlarnaSharedSecret, bool? acquirerSettingsMobilepayActive, string acquirerSettingsMobilepayDeliveryLimitedTo, bool? acquirerSettingsMobilepaysubscriptionsActive, string acquirerSettingsMobilepaysubscriptionsAuthState, string acquirerSettingsMobilepaysubscriptionsCodeVerifier, int? acquirerSettingsMobilepaysubscriptionsLastTokenRefresh, string acquirerSettingsMobilepaysubscriptionsNonce, int? acquirerSettingsMobilepaysubscriptionsPendingStatus, Dictionary<string, string> acquirerSettingsMobilepaysubscriptionsProvider, string acquirerSettingsMobilepaysubscriptionsRefreshToken, bool? acquirerSettingsNetsActive, string acquirerSettingsNetsIdentificationCode, string acquirerSettingsNetsBusinessCode, bool? acquirerSettingsNetsRecurring, bool? acquirerSettingsNetsFbg1886, bool? acquirerSettingsNetsSecuredByNets, string acquirerSettingsNetsIdentificationCodeInt, bool? acquirerSettingsNetsAmericanexpress, bool? acquirerSettingsNetsDinersclub, bool? acquirerSettingsNetsSecurepay, string acquirerSettingsNetsVisaBin, string acquirerSettingsNetsMastercardBin, bool? acquirerSettingsPaypalActive, bool? acquirerSettingsPaypalRecurring, bool? acquirerSettingsPaypalCreditCard, string acquirerSettingsPaypalToken, string acquirerSettingsPaypalTokenSecret, List<string> acquirerSettingsPaypalScope, bool? acquirerSettingsSofortActive, int? acquirerSettingsSofortCustomerNumber, int? acquirerSettingsSofortProjectId, string acquirerSettingsSofortApiKey, bool? acquirerSettingsSofortGateway, bool? acquirerSettingsSofortIdeal, int? acquirerSettingsSofortIdealProjectId, string acquirerSettingsSofortIdealProjectPassword, string acquirerSettingsSofortIdealNotificationPassword, bool? acquirerSettingsSwedbankActive, string acquirerSettingsSwedbankIdentificationCode, string acquirerSettingsSwedbankIdentificationCodeInt, string acquirerSettingsSwedbankBusinessCode, bool? acquirerSettingsSwedbankRecurring, bool? acquirerSettingsSwedbankAmericanexpress, bool? acquirerSettingsSwedbankDinersclub, bool? acquirerSettingsSwedbankSecurepay, string acquirerSettingsSwedbankVisaMpiMerchantId, string acquirerSettingsSwedbankMastercardMpiMerchantId, string acquirerSettingsSwedbankVisaBin, string acquirerSettingsSwedbankMastercardBin, bool? acquirerSettingsTellerActive, string acquirerSettingsTellerIdentificationCode, string acquirerSettingsTellerIdentificationCodeInt, string acquirerSettingsTellerBusinessCode, bool? acquirerSettingsTellerRecurring, bool? acquirerSettingsTellerAmericanexpress, bool? acquirerSettingsTellerDinersclub, bool? acquirerSettingsTellerSecurepay, string acquirerSettingsTellerVisaMpiMerchantId, string acquirerSettingsTellerMastercardMpiMerchantId, string acquirerSettingsTellerVisaBin, string acquirerSettingsTellerMastercardBin, bool? acquirerSettingsValitorActive, string acquirerSettingsValitorIdentificationCode, string acquirerSettingsValitorIdentificationCodeInt, string acquirerSettingsValitorBusinessCode, bool? acquirerSettingsValitorRecurring, bool? acquirerSettingsValitorAmericanexpress, bool? acquirerSettingsValitorDinersclub, bool? acquirerSettingsValitorSecurepay, string acquirerSettingsValitorVisaMpiMerchantId, string acquirerSettingsValitorMastercardMpiMerchantId, string acquirerSettingsValitorVisaBin, string acquirerSettingsValitorMastercardBin, bool? acquirerSettingsViabillActive, string acquirerSettingsViabillApiKey, bool? integrationSettingsEconomicActive, string integrationSettingsEconomicAgreement, string integrationSettingsEconomicAgreementToken, bool? pciSaqA, bool? pciSaqAEp, bool? pciSaqB, bool? pciSaqBIp, bool? pciSaqC, bool? pciSaqCVt, bool? pciSaqDMerchant, bool? pciSaqDServiceProvider, bool? pciSaqP2peHw, bool? autofee, string defaultPaymentMethods, string shopUrl, List<string> shopUrls, string contactEmail, string shopName, string shopsystem, string timezone, string locale, int? defaultBrandingId, string loggingStopsAt, bool? allowTestTransactions, string defaultPaymentLanguage, string defaultTextOnStatement, Dictionary<string, string> defaultBrandingConfig)

Update merchant account

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHAccountFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var customerAddressName = customerAddressName_example;  // string | <p>Name</p>  (optional) 
            var customerAddressAtt = customerAddressAtt_example;  // string | <p>Att</p>  (optional) 
            var customerAddressStreet = customerAddressStreet_example;  // string | <p>Street</p>  (optional) 
            var customerAddressCity = customerAddressCity_example;  // string | <p>City</p>  (optional) 
            var customerAddressZipCode = customerAddressZipCode_example;  // string | <p>Zip code</p>  (optional) 
            var customerAddressRegion = customerAddressRegion_example;  // string | <p>Region</p>  (optional) 
            var customerAddressCountryCode = customerAddressCountryCode_example;  // string | <p>Three letter country code according to ISO 3166-1 Alpha-3</p>  (optional) 
            var customerAddressVatNo = customerAddressVatNo_example;  // string | <p>VAT registration number</p>  (optional) 
            var billingAddressName = billingAddressName_example;  // string | <p>Name</p>  (optional) 
            var billingAddressAtt = billingAddressAtt_example;  // string | <p>Att</p>  (optional) 
            var billingAddressStreet = billingAddressStreet_example;  // string | <p>Street</p>  (optional) 
            var billingAddressCity = billingAddressCity_example;  // string | <p>City</p>  (optional) 
            var billingAddressZipCode = billingAddressZipCode_example;  // string | <p>Zip code</p>  (optional) 
            var billingAddressRegion = billingAddressRegion_example;  // string | <p>Region</p>  (optional) 
            var billingAddressCountryCode = billingAddressCountryCode_example;  // string | <p>Three letter country code according to ISO 3166-1 Alpha-3</p>  (optional) 
            var billingAddressVatNo = billingAddressVatNo_example;  // string | <p>VAT registration number</p>  (optional) 
            var callbackUrl = callbackUrl_example;  // string | <p>Callback url</p>  (optional) 
            var acquirerSettingsBamboraActive = true;  // bool? | <p>Enable Bambora payments</p>  (optional) 
            var acquirerSettingsBamboraIdentificationCode = acquirerSettingsBamboraIdentificationCode_example;  // string | <p>Bambora identification number</p>  (optional) 
            var acquirerSettingsBamboraIdentificationCodeInt = acquirerSettingsBamboraIdentificationCodeInt_example;  // string | <p>Bambora international identification number</p>  (optional) 
            var acquirerSettingsBamboraBusinessCode = acquirerSettingsBamboraBusinessCode_example;  // string | <p>Business code (assigned by Bambora)</p>  (optional) 
            var acquirerSettingsBamboraRecurring = true;  // bool? | <p>Enable recurring payments (requires agreement with Bambora)</p>  (optional) 
            var acquirerSettingsBamboraAmericanexpress = true;  // bool? | <p>Enable AMEX payments (requires agreement with Bambora)</p>  (optional) 
            var acquirerSettingsBamboraDinersclub = true;  // bool? | <p>Enable Diners Club payments (requires agreement with Bambora)</p>  (optional) 
            var acquirerSettingsBamboraSecurepay = true;  // bool? | <p>Enable SecurePay fraud protection.</p>  (optional) 
            var acquirerSettingsBamboraVisaMpiMerchantId = acquirerSettingsBamboraVisaMpiMerchantId_example;  // string | <p>VISA MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsBamboraMastercardMpiMerchantId = acquirerSettingsBamboraMastercardMpiMerchantId_example;  // string | <p>Mastercard MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsBamboraVisaBin = acquirerSettingsBamboraVisaBin_example;  // string | <p>VISA acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsBamboraMastercardBin = acquirerSettingsBamboraMastercardBin_example;  // string | <p>Mastercard acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsClearhausActive = true;  // bool? | <p>Enable ClearHaus payments</p>  (optional) 
            var acquirerSettingsClearhausApiKey = acquirerSettingsClearhausApiKey_example;  // string | <p>Clearhaus API key (is required but may be left empty)</p>  (optional) 
            var acquirerSettingsClearhausRecurring = true;  // bool? | <p>Enable recurring payments (requires agreement with Clearhaus)</p>  (optional) 
            var acquirerSettingsClearhausPayout = true;  // bool? | <p>Enable payouts (requires agreement with Clearhaus)</p>  (optional) 
            var acquirerSettingsClearhausApplePay = true;  // bool? | <p>Enable Apple Pay (requires agreement with Clearhaus)</p>  (optional) 
            var acquirerSettingsElavonActive = true;  // bool? | <p>Enable Elavon payments</p>  (optional) 
            var acquirerSettingsElavonIdentificationCode = acquirerSettingsElavonIdentificationCode_example;  // string | <p>Elavon identification number</p>  (optional) 
            var acquirerSettingsElavonIdentificationCodeInt = acquirerSettingsElavonIdentificationCodeInt_example;  // string | <p>Elavon international identification number</p>  (optional) 
            var acquirerSettingsElavonBusinessCode = acquirerSettingsElavonBusinessCode_example;  // string | <p>Business code (assigned by Elavon)</p>  (optional) 
            var acquirerSettingsElavonRecurring = true;  // bool? | <p>Enable recurring payments (requires agreement with Elavon)</p>  (optional) 
            var acquirerSettingsElavonAmericanexpress = true;  // bool? | <p>Enable AMEX payments (requires agreement with Elavon)</p>  (optional) 
            var acquirerSettingsElavonDinersclub = true;  // bool? | <p>Enable Diners Club payments (requires agreement with Elavon)</p>  (optional) 
            var acquirerSettingsElavonSecurepay = true;  // bool? | <p>Enable SecurePay fraud protection.</p>  (optional) 
            var acquirerSettingsElavonVisaMpiMerchantId = acquirerSettingsElavonVisaMpiMerchantId_example;  // string | <p>VISA MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsElavonMastercardMpiMerchantId = acquirerSettingsElavonMastercardMpiMerchantId_example;  // string | <p>Mastercard MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsElavonVisaBin = acquirerSettingsElavonVisaBin_example;  // string | <p>VISA acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsElavonMastercardBin = acquirerSettingsElavonMastercardBin_example;  // string | <p>Mastercard acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsHandelsbankenActive = true;  // bool? | <p>Enable Handelsbanken payments</p>  (optional) 
            var acquirerSettingsHandelsbankenIdentificationCode = acquirerSettingsHandelsbankenIdentificationCode_example;  // string | <p>Handelsbanken identification number</p>  (optional) 
            var acquirerSettingsHandelsbankenIdentificationCodeInt = acquirerSettingsHandelsbankenIdentificationCodeInt_example;  // string | <p>Handelsbanken international identification number</p>  (optional) 
            var acquirerSettingsHandelsbankenBusinessCode = acquirerSettingsHandelsbankenBusinessCode_example;  // string | <p>Business code (assigned by Handelsbanken)</p>  (optional) 
            var acquirerSettingsHandelsbankenRecurring = true;  // bool? | <p>Enable recurring payments (requires agreement with Handelsbanken)</p>  (optional) 
            var acquirerSettingsHandelsbankenAmericanexpress = true;  // bool? | <p>Enable AMEX payments (requires agreement with Handelsbanken)</p>  (optional) 
            var acquirerSettingsHandelsbankenDinersclub = true;  // bool? | <p>Enable Diners Club payments (requires agreement with Handelsbanken)</p>  (optional) 
            var acquirerSettingsHandelsbankenSecurepay = true;  // bool? | <p>Enable SecurePay fraud protection.</p>  (optional) 
            var acquirerSettingsHandelsbankenVisaMpiMerchantId = acquirerSettingsHandelsbankenVisaMpiMerchantId_example;  // string | <p>VISA MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsHandelsbankenMastercardMpiMerchantId = acquirerSettingsHandelsbankenMastercardMpiMerchantId_example;  // string | <p>Mastercard MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsHandelsbankenVisaBin = acquirerSettingsHandelsbankenVisaBin_example;  // string | <p>VISA acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsHandelsbankenMastercardBin = acquirerSettingsHandelsbankenMastercardBin_example;  // string | <p>Mastercard acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsKlarnaActive = true;  // bool? | <p>Enable Klarna payments</p>  (optional) 
            var acquirerSettingsKlarnaEid = 56;  // int? | <p>Klarna merchant ID</p>  (optional) 
            var acquirerSettingsKlarnaSharedSecret = acquirerSettingsKlarnaSharedSecret_example;  // string | <p>Klarna shared secret</p>  (optional) 
            var acquirerSettingsMobilepayActive = true;  // bool? | <p>Enable MobilePay payments</p>  (optional) 
            var acquirerSettingsMobilepayDeliveryLimitedTo = acquirerSettingsMobilepayDeliveryLimitedTo_example;  // string | <p>Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI)</p>  (optional) 
            var acquirerSettingsMobilepaysubscriptionsActive = true;  // bool? | <p>Enable MobilePay Subscriptions payments</p>  (optional) 
            var acquirerSettingsMobilepaysubscriptionsAuthState = acquirerSettingsMobilepaysubscriptionsAuthState_example;  // string | <p>Identifier MobilePay Subscriptions uses to link requests to callbacks</p>  (optional) 
            var acquirerSettingsMobilepaysubscriptionsCodeVerifier = acquirerSettingsMobilepaysubscriptionsCodeVerifier_example;  // string | <p>Verifies received code challenge</p>  (optional) 
            var acquirerSettingsMobilepaysubscriptionsLastTokenRefresh = 56;  // int? | <p>Unix Timestamp of last time the tokens were refreshed</p>  (optional) 
            var acquirerSettingsMobilepaysubscriptionsNonce = acquirerSettingsMobilepaysubscriptionsNonce_example;  // string | <p>Associate client sessions with ID Tokens to mitigate replay attacks</p>  (optional) 
            var acquirerSettingsMobilepaysubscriptionsPendingStatus = 56;  // int? | <p>0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed</p>  (optional)  (default to 0)
            var acquirerSettingsMobilepaysubscriptionsProvider = new Dictionary<string, string>(); // Dictionary<string, string> | <p>The provider / sales-place chosen by the merchant</p>  (optional) 
            var acquirerSettingsMobilepaysubscriptionsRefreshToken = acquirerSettingsMobilepaysubscriptionsRefreshToken_example;  // string | <p>Token to refresh access token for up to 1 year</p>  (optional) 
            var acquirerSettingsNetsActive = true;  // bool? | <p>Enable Nets/Teller payments</p>  (optional) 
            var acquirerSettingsNetsIdentificationCode = acquirerSettingsNetsIdentificationCode_example;  // string | <p>Nets TOF number</p>  (optional) 
            var acquirerSettingsNetsBusinessCode = acquirerSettingsNetsBusinessCode_example;  // string | <p>Business code (assigned by Nets)</p>  (optional) 
            var acquirerSettingsNetsRecurring = true;  // bool? | <p>Enable recurring payments (requires agreement with Nets)</p>  (optional) 
            var acquirerSettingsNetsFbg1886 = true;  // bool? | <p>Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen)</p>  (optional) 
            var acquirerSettingsNetsSecuredByNets = true;  // bool? | <p>Enable SecuredByNets fraud protection.</p>  (optional) 
            var acquirerSettingsNetsIdentificationCodeInt = acquirerSettingsNetsIdentificationCodeInt_example;  // string | <p>(Depricated; use Teller acquirer)</p>  (optional) 
            var acquirerSettingsNetsAmericanexpress = true;  // bool? | <p>(Depricated; use Teller acquirer)</p>  (optional) 
            var acquirerSettingsNetsDinersclub = true;  // bool? | <p>(Depricated; use Teller acquirer)</p>  (optional) 
            var acquirerSettingsNetsSecurepay = true;  // bool? | <p>(Depricated; use Teller acquirer)</p>  (optional)  (default to true)
            var acquirerSettingsNetsVisaBin = acquirerSettingsNetsVisaBin_example;  // string | <p>(Depricated; use Teller acquirer)</p>  (optional) 
            var acquirerSettingsNetsMastercardBin = acquirerSettingsNetsMastercardBin_example;  // string | <p>(Depricated; use Teller acquirer)</p>  (optional) 
            var acquirerSettingsPaypalActive = true;  // bool? | <p>Enable PayPal payments</p>  (optional) 
            var acquirerSettingsPaypalRecurring = true;  // bool? | <p>Enable recurring payments</p>  (optional) 
            var acquirerSettingsPaypalCreditCard = true;  // bool? | <p>Allow credit-card payments. (Only for US/CA/UK merchants)</p>  (optional) 
            var acquirerSettingsPaypalToken = acquirerSettingsPaypalToken_example;  // string | <p>Authentication token</p>  (optional) 
            var acquirerSettingsPaypalTokenSecret = acquirerSettingsPaypalTokenSecret_example;  // string | <p>Authentication token secret</p>  (optional) 
            var acquirerSettingsPaypalScope = ;  // List<string> | <p>Authentication scope</p>  (optional) 
            var acquirerSettingsSofortActive = true;  // bool? | <p>Enable Sofort payments</p>  (optional) 
            var acquirerSettingsSofortCustomerNumber = 56;  // int? | <p>Sofort customer number</p>  (optional) 
            var acquirerSettingsSofortProjectId = 56;  // int? | <p>Sofort Gateway project id</p>  (optional) 
            var acquirerSettingsSofortApiKey = acquirerSettingsSofortApiKey_example;  // string | <p>Sofort API key</p>  (optional) 
            var acquirerSettingsSofortGateway = true;  // bool? | <p>Enable Sofort Gateway feature</p>  (optional)  (default to true)
            var acquirerSettingsSofortIdeal = true;  // bool? | <p>Enable Sofort iDeal feature</p>  (optional) 
            var acquirerSettingsSofortIdealProjectId = 56;  // int? | <p>Sofort iDeal project id</p>  (optional) 
            var acquirerSettingsSofortIdealProjectPassword = acquirerSettingsSofortIdealProjectPassword_example;  // string | <p>Sofort iDeal project password</p>  (optional) 
            var acquirerSettingsSofortIdealNotificationPassword = acquirerSettingsSofortIdealNotificationPassword_example;  // string | <p>Sofort iDeal notification password</p>  (optional) 
            var acquirerSettingsSwedbankActive = true;  // bool? | <p>Enable Swedbank payments</p>  (optional) 
            var acquirerSettingsSwedbankIdentificationCode = acquirerSettingsSwedbankIdentificationCode_example;  // string | <p>Swedbank identification number</p>  (optional) 
            var acquirerSettingsSwedbankIdentificationCodeInt = acquirerSettingsSwedbankIdentificationCodeInt_example;  // string | <p>Swedbank international identification number</p>  (optional) 
            var acquirerSettingsSwedbankBusinessCode = acquirerSettingsSwedbankBusinessCode_example;  // string | <p>Business code (assigned by Swedbank)</p>  (optional) 
            var acquirerSettingsSwedbankRecurring = true;  // bool? | <p>Enable recurring payments (requires agreement with Swedbank)</p>  (optional) 
            var acquirerSettingsSwedbankAmericanexpress = true;  // bool? | <p>Enable AMEX payments (requires agreement with Swedbank)</p>  (optional) 
            var acquirerSettingsSwedbankDinersclub = true;  // bool? | <p>Enable Diners Club payments (requires agreement with Swedbank)</p>  (optional) 
            var acquirerSettingsSwedbankSecurepay = true;  // bool? | <p>Enable SecurePay fraud protection.</p>  (optional) 
            var acquirerSettingsSwedbankVisaMpiMerchantId = acquirerSettingsSwedbankVisaMpiMerchantId_example;  // string | <p>VISA MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsSwedbankMastercardMpiMerchantId = acquirerSettingsSwedbankMastercardMpiMerchantId_example;  // string | <p>Mastercard MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsSwedbankVisaBin = acquirerSettingsSwedbankVisaBin_example;  // string | <p>VISA acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsSwedbankMastercardBin = acquirerSettingsSwedbankMastercardBin_example;  // string | <p>Mastercard acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsTellerActive = true;  // bool? | <p>Enable Teller payments</p>  (optional) 
            var acquirerSettingsTellerIdentificationCode = acquirerSettingsTellerIdentificationCode_example;  // string | <p>Teller TOF number</p>  (optional) 
            var acquirerSettingsTellerIdentificationCodeInt = acquirerSettingsTellerIdentificationCodeInt_example;  // string | <p>Teller international identification number</p>  (optional) 
            var acquirerSettingsTellerBusinessCode = acquirerSettingsTellerBusinessCode_example;  // string | <p>Business code (assigned by Teller)</p>  (optional) 
            var acquirerSettingsTellerRecurring = true;  // bool? | <p>Enable recurring payments (requires agreement with Teller)</p>  (optional) 
            var acquirerSettingsTellerAmericanexpress = true;  // bool? | <p>Enable AMEX payments (requires agreement with Teller)</p>  (optional) 
            var acquirerSettingsTellerDinersclub = true;  // bool? | <p>Enable Diners Club payments (requires agreement with Teller)</p>  (optional) 
            var acquirerSettingsTellerSecurepay = true;  // bool? | <p>Enable SecurePay fraud protection. (disabling requires agreement with Teller)</p>  (optional)  (default to true)
            var acquirerSettingsTellerVisaMpiMerchantId = acquirerSettingsTellerVisaMpiMerchantId_example;  // string | <p>VISA MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsTellerMastercardMpiMerchantId = acquirerSettingsTellerMastercardMpiMerchantId_example;  // string | <p>Mastercard MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsTellerVisaBin = acquirerSettingsTellerVisaBin_example;  // string | <p>Teller VISA acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsTellerMastercardBin = acquirerSettingsTellerMastercardBin_example;  // string | <p>Teller Mastercard acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsValitorActive = true;  // bool? | <p>Enable Valitor payments</p>  (optional) 
            var acquirerSettingsValitorIdentificationCode = acquirerSettingsValitorIdentificationCode_example;  // string | <p>Valitor identification number</p>  (optional) 
            var acquirerSettingsValitorIdentificationCodeInt = acquirerSettingsValitorIdentificationCodeInt_example;  // string | <p>Valitor international identification number</p>  (optional) 
            var acquirerSettingsValitorBusinessCode = acquirerSettingsValitorBusinessCode_example;  // string | <p>Business code (assigned by Valitor)</p>  (optional) 
            var acquirerSettingsValitorRecurring = true;  // bool? | <p>Enable recurring payments (requires agreement with Valitor)</p>  (optional) 
            var acquirerSettingsValitorAmericanexpress = true;  // bool? | <p>Enable AMEX payments (requires agreement with Valitor)</p>  (optional) 
            var acquirerSettingsValitorDinersclub = true;  // bool? | <p>Enable Diners Club payments (requires agreement with Valitor)</p>  (optional) 
            var acquirerSettingsValitorSecurepay = true;  // bool? | <p>Enable SecurePay fraud protection.</p>  (optional) 
            var acquirerSettingsValitorVisaMpiMerchantId = acquirerSettingsValitorVisaMpiMerchantId_example;  // string | <p>VISA MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsValitorMastercardMpiMerchantId = acquirerSettingsValitorMastercardMpiMerchantId_example;  // string | <p>Mastercard MPI merchant id. Used for 3D secure transactions</p>  (optional) 
            var acquirerSettingsValitorVisaBin = acquirerSettingsValitorVisaBin_example;  // string | <p>VISA acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsValitorMastercardBin = acquirerSettingsValitorMastercardBin_example;  // string | <p>Mastercard acquirer bin used for 3D Secure</p>  (optional) 
            var acquirerSettingsViabillActive = true;  // bool? | <p>Enable ViaBill payments</p>  (optional) 
            var acquirerSettingsViabillApiKey = acquirerSettingsViabillApiKey_example;  // string | <p>ViaBill API key</p>  (optional) 
            var integrationSettingsEconomicActive = true;  // bool? | <p>Enable e-conomic integration</p>  (optional) 
            var integrationSettingsEconomicAgreement = integrationSettingsEconomicAgreement_example;  // string | <p>e-conomic agreement no.</p>  (optional) 
            var integrationSettingsEconomicAgreementToken = integrationSettingsEconomicAgreementToken_example;  // string | <p>economic agreement grant token</p>  (optional) 
            var pciSaqA = true;  // bool? | <p>Enable SAQ A</p>  (optional) 
            var pciSaqAEp = true;  // bool? | <p>Enable SAQ A-EP</p>  (optional) 
            var pciSaqB = true;  // bool? | <p>Enable SAQ B</p>  (optional) 
            var pciSaqBIp = true;  // bool? | <p>Enable SAQ B-IP</p>  (optional) 
            var pciSaqC = true;  // bool? | <p>Enable SAQ C</p>  (optional) 
            var pciSaqCVt = true;  // bool? | <p>Enable SAQ C-VT</p>  (optional) 
            var pciSaqDMerchant = true;  // bool? | <p>Enable SAQ D Merchant</p>  (optional) 
            var pciSaqDServiceProvider = true;  // bool? | <p>Enable SAQ D Service Provider</p>  (optional) 
            var pciSaqP2peHw = true;  // bool? | <p>Enable SAQ P2PE-HW</p>  (optional) 
            var autofee = true;  // bool? | <p>Add automatic fee on all payments</p>  (optional) 
            var defaultPaymentMethods = defaultPaymentMethods_example;  // string | <p>Comma separated list of default payment methods</p>  (optional) 
            var shopUrl = shopUrl_example;  // string | <p>Shop URL (deprecated, use shop_urls instead)</p>  (optional) 
            var shopUrls = ;  // List<string> | <p>Shop URLs</p>  (optional) 
            var contactEmail = contactEmail_example;  // string | <p>Contact email</p>  (optional) 
            var shopName = shopName_example;  // string | <p>Shop name</p>  (optional) 
            var shopsystem = shopsystem_example;  // string | <p>Shop system</p>  (optional) 
            var timezone = timezone_example;  // string | <table>   <tbody>     <tr>       <td>Timezone UTC offsets in Zulu (+</td>       <td>-)hh:mm</td>     </tr>   </tbody> </table>  (optional) 
            var locale = locale_example;  // string | <p>Locale as a two letter language code</p>  (optional) 
            var defaultBrandingId = 56;  // int? | <p>Id of default branding</p>  (optional) 
            var loggingStopsAt = loggingStopsAt_example;  // string | <p>Timestamp when logging is active</p>  (optional) 
            var allowTestTransactions = true;  // bool? | <p>Allow test transactions</p>  (optional) 
            var defaultPaymentLanguage = defaultPaymentLanguage_example;  // string | <p>Default payment language (Two letter language code, ISO-639-1)</p>  (optional) 
            var defaultTextOnStatement = defaultTextOnStatement_example;  // string | <p>Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.</p>  (optional) 
            var defaultBrandingConfig = new Dictionary<string, string>(); // Dictionary<string, string> | <p>Default branding config. Can be overwritten in branding or in request to payment window</p>  (optional) 

            try
            {
                // Update merchant account
                Merchant result = apiInstance.PATCHAccountFormat(acceptVersion, authorization, customerAddressName, customerAddressAtt, customerAddressStreet, customerAddressCity, customerAddressZipCode, customerAddressRegion, customerAddressCountryCode, customerAddressVatNo, billingAddressName, billingAddressAtt, billingAddressStreet, billingAddressCity, billingAddressZipCode, billingAddressRegion, billingAddressCountryCode, billingAddressVatNo, callbackUrl, acquirerSettingsBamboraActive, acquirerSettingsBamboraIdentificationCode, acquirerSettingsBamboraIdentificationCodeInt, acquirerSettingsBamboraBusinessCode, acquirerSettingsBamboraRecurring, acquirerSettingsBamboraAmericanexpress, acquirerSettingsBamboraDinersclub, acquirerSettingsBamboraSecurepay, acquirerSettingsBamboraVisaMpiMerchantId, acquirerSettingsBamboraMastercardMpiMerchantId, acquirerSettingsBamboraVisaBin, acquirerSettingsBamboraMastercardBin, acquirerSettingsClearhausActive, acquirerSettingsClearhausApiKey, acquirerSettingsClearhausRecurring, acquirerSettingsClearhausPayout, acquirerSettingsClearhausApplePay, acquirerSettingsElavonActive, acquirerSettingsElavonIdentificationCode, acquirerSettingsElavonIdentificationCodeInt, acquirerSettingsElavonBusinessCode, acquirerSettingsElavonRecurring, acquirerSettingsElavonAmericanexpress, acquirerSettingsElavonDinersclub, acquirerSettingsElavonSecurepay, acquirerSettingsElavonVisaMpiMerchantId, acquirerSettingsElavonMastercardMpiMerchantId, acquirerSettingsElavonVisaBin, acquirerSettingsElavonMastercardBin, acquirerSettingsHandelsbankenActive, acquirerSettingsHandelsbankenIdentificationCode, acquirerSettingsHandelsbankenIdentificationCodeInt, acquirerSettingsHandelsbankenBusinessCode, acquirerSettingsHandelsbankenRecurring, acquirerSettingsHandelsbankenAmericanexpress, acquirerSettingsHandelsbankenDinersclub, acquirerSettingsHandelsbankenSecurepay, acquirerSettingsHandelsbankenVisaMpiMerchantId, acquirerSettingsHandelsbankenMastercardMpiMerchantId, acquirerSettingsHandelsbankenVisaBin, acquirerSettingsHandelsbankenMastercardBin, acquirerSettingsKlarnaActive, acquirerSettingsKlarnaEid, acquirerSettingsKlarnaSharedSecret, acquirerSettingsMobilepayActive, acquirerSettingsMobilepayDeliveryLimitedTo, acquirerSettingsMobilepaysubscriptionsActive, acquirerSettingsMobilepaysubscriptionsAuthState, acquirerSettingsMobilepaysubscriptionsCodeVerifier, acquirerSettingsMobilepaysubscriptionsLastTokenRefresh, acquirerSettingsMobilepaysubscriptionsNonce, acquirerSettingsMobilepaysubscriptionsPendingStatus, acquirerSettingsMobilepaysubscriptionsProvider, acquirerSettingsMobilepaysubscriptionsRefreshToken, acquirerSettingsNetsActive, acquirerSettingsNetsIdentificationCode, acquirerSettingsNetsBusinessCode, acquirerSettingsNetsRecurring, acquirerSettingsNetsFbg1886, acquirerSettingsNetsSecuredByNets, acquirerSettingsNetsIdentificationCodeInt, acquirerSettingsNetsAmericanexpress, acquirerSettingsNetsDinersclub, acquirerSettingsNetsSecurepay, acquirerSettingsNetsVisaBin, acquirerSettingsNetsMastercardBin, acquirerSettingsPaypalActive, acquirerSettingsPaypalRecurring, acquirerSettingsPaypalCreditCard, acquirerSettingsPaypalToken, acquirerSettingsPaypalTokenSecret, acquirerSettingsPaypalScope, acquirerSettingsSofortActive, acquirerSettingsSofortCustomerNumber, acquirerSettingsSofortProjectId, acquirerSettingsSofortApiKey, acquirerSettingsSofortGateway, acquirerSettingsSofortIdeal, acquirerSettingsSofortIdealProjectId, acquirerSettingsSofortIdealProjectPassword, acquirerSettingsSofortIdealNotificationPassword, acquirerSettingsSwedbankActive, acquirerSettingsSwedbankIdentificationCode, acquirerSettingsSwedbankIdentificationCodeInt, acquirerSettingsSwedbankBusinessCode, acquirerSettingsSwedbankRecurring, acquirerSettingsSwedbankAmericanexpress, acquirerSettingsSwedbankDinersclub, acquirerSettingsSwedbankSecurepay, acquirerSettingsSwedbankVisaMpiMerchantId, acquirerSettingsSwedbankMastercardMpiMerchantId, acquirerSettingsSwedbankVisaBin, acquirerSettingsSwedbankMastercardBin, acquirerSettingsTellerActive, acquirerSettingsTellerIdentificationCode, acquirerSettingsTellerIdentificationCodeInt, acquirerSettingsTellerBusinessCode, acquirerSettingsTellerRecurring, acquirerSettingsTellerAmericanexpress, acquirerSettingsTellerDinersclub, acquirerSettingsTellerSecurepay, acquirerSettingsTellerVisaMpiMerchantId, acquirerSettingsTellerMastercardMpiMerchantId, acquirerSettingsTellerVisaBin, acquirerSettingsTellerMastercardBin, acquirerSettingsValitorActive, acquirerSettingsValitorIdentificationCode, acquirerSettingsValitorIdentificationCodeInt, acquirerSettingsValitorBusinessCode, acquirerSettingsValitorRecurring, acquirerSettingsValitorAmericanexpress, acquirerSettingsValitorDinersclub, acquirerSettingsValitorSecurepay, acquirerSettingsValitorVisaMpiMerchantId, acquirerSettingsValitorMastercardMpiMerchantId, acquirerSettingsValitorVisaBin, acquirerSettingsValitorMastercardBin, acquirerSettingsViabillActive, acquirerSettingsViabillApiKey, integrationSettingsEconomicActive, integrationSettingsEconomicAgreement, integrationSettingsEconomicAgreementToken, pciSaqA, pciSaqAEp, pciSaqB, pciSaqBIp, pciSaqC, pciSaqCVt, pciSaqDMerchant, pciSaqDServiceProvider, pciSaqP2peHw, autofee, defaultPaymentMethods, shopUrl, shopUrls, contactEmail, shopName, shopsystem, timezone, locale, defaultBrandingId, loggingStopsAt, allowTestTransactions, defaultPaymentLanguage, defaultTextOnStatement, defaultBrandingConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.PATCHAccountFormat: " + e.Message );
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
 **customerAddressName** | **string**| &lt;p&gt;Name&lt;/p&gt;  | [optional] 
 **customerAddressAtt** | **string**| &lt;p&gt;Att&lt;/p&gt;  | [optional] 
 **customerAddressStreet** | **string**| &lt;p&gt;Street&lt;/p&gt;  | [optional] 
 **customerAddressCity** | **string**| &lt;p&gt;City&lt;/p&gt;  | [optional] 
 **customerAddressZipCode** | **string**| &lt;p&gt;Zip code&lt;/p&gt;  | [optional] 
 **customerAddressRegion** | **string**| &lt;p&gt;Region&lt;/p&gt;  | [optional] 
 **customerAddressCountryCode** | **string**| &lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt;  | [optional] 
 **customerAddressVatNo** | **string**| &lt;p&gt;VAT registration number&lt;/p&gt;  | [optional] 
 **billingAddressName** | **string**| &lt;p&gt;Name&lt;/p&gt;  | [optional] 
 **billingAddressAtt** | **string**| &lt;p&gt;Att&lt;/p&gt;  | [optional] 
 **billingAddressStreet** | **string**| &lt;p&gt;Street&lt;/p&gt;  | [optional] 
 **billingAddressCity** | **string**| &lt;p&gt;City&lt;/p&gt;  | [optional] 
 **billingAddressZipCode** | **string**| &lt;p&gt;Zip code&lt;/p&gt;  | [optional] 
 **billingAddressRegion** | **string**| &lt;p&gt;Region&lt;/p&gt;  | [optional] 
 **billingAddressCountryCode** | **string**| &lt;p&gt;Three letter country code according to ISO 3166-1 Alpha-3&lt;/p&gt;  | [optional] 
 **billingAddressVatNo** | **string**| &lt;p&gt;VAT registration number&lt;/p&gt;  | [optional] 
 **callbackUrl** | **string**| &lt;p&gt;Callback url&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraActive** | **bool?**| &lt;p&gt;Enable Bambora payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraIdentificationCode** | **string**| &lt;p&gt;Bambora identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraIdentificationCodeInt** | **string**| &lt;p&gt;Bambora international identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraBusinessCode** | **string**| &lt;p&gt;Business code (assigned by Bambora)&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraRecurring** | **bool?**| &lt;p&gt;Enable recurring payments (requires agreement with Bambora)&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraAmericanexpress** | **bool?**| &lt;p&gt;Enable AMEX payments (requires agreement with Bambora)&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraDinersclub** | **bool?**| &lt;p&gt;Enable Diners Club payments (requires agreement with Bambora)&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraSecurepay** | **bool?**| &lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraVisaMpiMerchantId** | **string**| &lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraMastercardMpiMerchantId** | **string**| &lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraVisaBin** | **string**| &lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsBamboraMastercardBin** | **string**| &lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsClearhausActive** | **bool?**| &lt;p&gt;Enable ClearHaus payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsClearhausApiKey** | **string**| &lt;p&gt;Clearhaus API key (is required but may be left empty)&lt;/p&gt;  | [optional] 
 **acquirerSettingsClearhausRecurring** | **bool?**| &lt;p&gt;Enable recurring payments (requires agreement with Clearhaus)&lt;/p&gt;  | [optional] 
 **acquirerSettingsClearhausPayout** | **bool?**| &lt;p&gt;Enable payouts (requires agreement with Clearhaus)&lt;/p&gt;  | [optional] 
 **acquirerSettingsClearhausApplePay** | **bool?**| &lt;p&gt;Enable Apple Pay (requires agreement with Clearhaus)&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonActive** | **bool?**| &lt;p&gt;Enable Elavon payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonIdentificationCode** | **string**| &lt;p&gt;Elavon identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonIdentificationCodeInt** | **string**| &lt;p&gt;Elavon international identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonBusinessCode** | **string**| &lt;p&gt;Business code (assigned by Elavon)&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonRecurring** | **bool?**| &lt;p&gt;Enable recurring payments (requires agreement with Elavon)&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonAmericanexpress** | **bool?**| &lt;p&gt;Enable AMEX payments (requires agreement with Elavon)&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonDinersclub** | **bool?**| &lt;p&gt;Enable Diners Club payments (requires agreement with Elavon)&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonSecurepay** | **bool?**| &lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonVisaMpiMerchantId** | **string**| &lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonMastercardMpiMerchantId** | **string**| &lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonVisaBin** | **string**| &lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsElavonMastercardBin** | **string**| &lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenActive** | **bool?**| &lt;p&gt;Enable Handelsbanken payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenIdentificationCode** | **string**| &lt;p&gt;Handelsbanken identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenIdentificationCodeInt** | **string**| &lt;p&gt;Handelsbanken international identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenBusinessCode** | **string**| &lt;p&gt;Business code (assigned by Handelsbanken)&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenRecurring** | **bool?**| &lt;p&gt;Enable recurring payments (requires agreement with Handelsbanken)&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenAmericanexpress** | **bool?**| &lt;p&gt;Enable AMEX payments (requires agreement with Handelsbanken)&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenDinersclub** | **bool?**| &lt;p&gt;Enable Diners Club payments (requires agreement with Handelsbanken)&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenSecurepay** | **bool?**| &lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenVisaMpiMerchantId** | **string**| &lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenMastercardMpiMerchantId** | **string**| &lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenVisaBin** | **string**| &lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsHandelsbankenMastercardBin** | **string**| &lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsKlarnaActive** | **bool?**| &lt;p&gt;Enable Klarna payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsKlarnaEid** | **int?**| &lt;p&gt;Klarna merchant ID&lt;/p&gt;  | [optional] 
 **acquirerSettingsKlarnaSharedSecret** | **string**| &lt;p&gt;Klarna shared secret&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepayActive** | **bool?**| &lt;p&gt;Enable MobilePay payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepayDeliveryLimitedTo** | **string**| &lt;p&gt;Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI)&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsActive** | **bool?**| &lt;p&gt;Enable MobilePay Subscriptions payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsAuthState** | **string**| &lt;p&gt;Identifier MobilePay Subscriptions uses to link requests to callbacks&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsCodeVerifier** | **string**| &lt;p&gt;Verifies received code challenge&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsLastTokenRefresh** | **int?**| &lt;p&gt;Unix Timestamp of last time the tokens were refreshed&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsNonce** | **string**| &lt;p&gt;Associate client sessions with ID Tokens to mitigate replay attacks&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsPendingStatus** | **int?**| &lt;p&gt;0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed&lt;/p&gt;  | [optional] [default to 0]
 **acquirerSettingsMobilepaysubscriptionsProvider** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;The provider / sales-place chosen by the merchant&lt;/p&gt;  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsRefreshToken** | **string**| &lt;p&gt;Token to refresh access token for up to 1 year&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsActive** | **bool?**| &lt;p&gt;Enable Nets/Teller payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsIdentificationCode** | **string**| &lt;p&gt;Nets TOF number&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsBusinessCode** | **string**| &lt;p&gt;Business code (assigned by Nets)&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsRecurring** | **bool?**| &lt;p&gt;Enable recurring payments (requires agreement with Nets)&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsFbg1886** | **bool?**| &lt;p&gt;Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen)&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsSecuredByNets** | **bool?**| &lt;p&gt;Enable SecuredByNets fraud protection.&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsIdentificationCodeInt** | **string**| &lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsAmericanexpress** | **bool?**| &lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsDinersclub** | **bool?**| &lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsSecurepay** | **bool?**| &lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt;  | [optional] [default to true]
 **acquirerSettingsNetsVisaBin** | **string**| &lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt;  | [optional] 
 **acquirerSettingsNetsMastercardBin** | **string**| &lt;p&gt;(Depricated; use Teller acquirer)&lt;/p&gt;  | [optional] 
 **acquirerSettingsPaypalActive** | **bool?**| &lt;p&gt;Enable PayPal payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsPaypalRecurring** | **bool?**| &lt;p&gt;Enable recurring payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsPaypalCreditCard** | **bool?**| &lt;p&gt;Allow credit-card payments. (Only for US/CA/UK merchants)&lt;/p&gt;  | [optional] 
 **acquirerSettingsPaypalToken** | **string**| &lt;p&gt;Authentication token&lt;/p&gt;  | [optional] 
 **acquirerSettingsPaypalTokenSecret** | **string**| &lt;p&gt;Authentication token secret&lt;/p&gt;  | [optional] 
 **acquirerSettingsPaypalScope** | **List<string>**| &lt;p&gt;Authentication scope&lt;/p&gt;  | [optional] 
 **acquirerSettingsSofortActive** | **bool?**| &lt;p&gt;Enable Sofort payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsSofortCustomerNumber** | **int?**| &lt;p&gt;Sofort customer number&lt;/p&gt;  | [optional] 
 **acquirerSettingsSofortProjectId** | **int?**| &lt;p&gt;Sofort Gateway project id&lt;/p&gt;  | [optional] 
 **acquirerSettingsSofortApiKey** | **string**| &lt;p&gt;Sofort API key&lt;/p&gt;  | [optional] 
 **acquirerSettingsSofortGateway** | **bool?**| &lt;p&gt;Enable Sofort Gateway feature&lt;/p&gt;  | [optional] [default to true]
 **acquirerSettingsSofortIdeal** | **bool?**| &lt;p&gt;Enable Sofort iDeal feature&lt;/p&gt;  | [optional] 
 **acquirerSettingsSofortIdealProjectId** | **int?**| &lt;p&gt;Sofort iDeal project id&lt;/p&gt;  | [optional] 
 **acquirerSettingsSofortIdealProjectPassword** | **string**| &lt;p&gt;Sofort iDeal project password&lt;/p&gt;  | [optional] 
 **acquirerSettingsSofortIdealNotificationPassword** | **string**| &lt;p&gt;Sofort iDeal notification password&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankActive** | **bool?**| &lt;p&gt;Enable Swedbank payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankIdentificationCode** | **string**| &lt;p&gt;Swedbank identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankIdentificationCodeInt** | **string**| &lt;p&gt;Swedbank international identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankBusinessCode** | **string**| &lt;p&gt;Business code (assigned by Swedbank)&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankRecurring** | **bool?**| &lt;p&gt;Enable recurring payments (requires agreement with Swedbank)&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankAmericanexpress** | **bool?**| &lt;p&gt;Enable AMEX payments (requires agreement with Swedbank)&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankDinersclub** | **bool?**| &lt;p&gt;Enable Diners Club payments (requires agreement with Swedbank)&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankSecurepay** | **bool?**| &lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankVisaMpiMerchantId** | **string**| &lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankMastercardMpiMerchantId** | **string**| &lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankVisaBin** | **string**| &lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsSwedbankMastercardBin** | **string**| &lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerActive** | **bool?**| &lt;p&gt;Enable Teller payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerIdentificationCode** | **string**| &lt;p&gt;Teller TOF number&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerIdentificationCodeInt** | **string**| &lt;p&gt;Teller international identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerBusinessCode** | **string**| &lt;p&gt;Business code (assigned by Teller)&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerRecurring** | **bool?**| &lt;p&gt;Enable recurring payments (requires agreement with Teller)&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerAmericanexpress** | **bool?**| &lt;p&gt;Enable AMEX payments (requires agreement with Teller)&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerDinersclub** | **bool?**| &lt;p&gt;Enable Diners Club payments (requires agreement with Teller)&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerSecurepay** | **bool?**| &lt;p&gt;Enable SecurePay fraud protection. (disabling requires agreement with Teller)&lt;/p&gt;  | [optional] [default to true]
 **acquirerSettingsTellerVisaMpiMerchantId** | **string**| &lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerMastercardMpiMerchantId** | **string**| &lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerVisaBin** | **string**| &lt;p&gt;Teller VISA acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsTellerMastercardBin** | **string**| &lt;p&gt;Teller Mastercard acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorActive** | **bool?**| &lt;p&gt;Enable Valitor payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorIdentificationCode** | **string**| &lt;p&gt;Valitor identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorIdentificationCodeInt** | **string**| &lt;p&gt;Valitor international identification number&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorBusinessCode** | **string**| &lt;p&gt;Business code (assigned by Valitor)&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorRecurring** | **bool?**| &lt;p&gt;Enable recurring payments (requires agreement with Valitor)&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorAmericanexpress** | **bool?**| &lt;p&gt;Enable AMEX payments (requires agreement with Valitor)&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorDinersclub** | **bool?**| &lt;p&gt;Enable Diners Club payments (requires agreement with Valitor)&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorSecurepay** | **bool?**| &lt;p&gt;Enable SecurePay fraud protection.&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorVisaMpiMerchantId** | **string**| &lt;p&gt;VISA MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorMastercardMpiMerchantId** | **string**| &lt;p&gt;Mastercard MPI merchant id. Used for 3D secure transactions&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorVisaBin** | **string**| &lt;p&gt;VISA acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsValitorMastercardBin** | **string**| &lt;p&gt;Mastercard acquirer bin used for 3D Secure&lt;/p&gt;  | [optional] 
 **acquirerSettingsViabillActive** | **bool?**| &lt;p&gt;Enable ViaBill payments&lt;/p&gt;  | [optional] 
 **acquirerSettingsViabillApiKey** | **string**| &lt;p&gt;ViaBill API key&lt;/p&gt;  | [optional] 
 **integrationSettingsEconomicActive** | **bool?**| &lt;p&gt;Enable e-conomic integration&lt;/p&gt;  | [optional] 
 **integrationSettingsEconomicAgreement** | **string**| &lt;p&gt;e-conomic agreement no.&lt;/p&gt;  | [optional] 
 **integrationSettingsEconomicAgreementToken** | **string**| &lt;p&gt;economic agreement grant token&lt;/p&gt;  | [optional] 
 **pciSaqA** | **bool?**| &lt;p&gt;Enable SAQ A&lt;/p&gt;  | [optional] 
 **pciSaqAEp** | **bool?**| &lt;p&gt;Enable SAQ A-EP&lt;/p&gt;  | [optional] 
 **pciSaqB** | **bool?**| &lt;p&gt;Enable SAQ B&lt;/p&gt;  | [optional] 
 **pciSaqBIp** | **bool?**| &lt;p&gt;Enable SAQ B-IP&lt;/p&gt;  | [optional] 
 **pciSaqC** | **bool?**| &lt;p&gt;Enable SAQ C&lt;/p&gt;  | [optional] 
 **pciSaqCVt** | **bool?**| &lt;p&gt;Enable SAQ C-VT&lt;/p&gt;  | [optional] 
 **pciSaqDMerchant** | **bool?**| &lt;p&gt;Enable SAQ D Merchant&lt;/p&gt;  | [optional] 
 **pciSaqDServiceProvider** | **bool?**| &lt;p&gt;Enable SAQ D Service Provider&lt;/p&gt;  | [optional] 
 **pciSaqP2peHw** | **bool?**| &lt;p&gt;Enable SAQ P2PE-HW&lt;/p&gt;  | [optional] 
 **autofee** | **bool?**| &lt;p&gt;Add automatic fee on all payments&lt;/p&gt;  | [optional] 
 **defaultPaymentMethods** | **string**| &lt;p&gt;Comma separated list of default payment methods&lt;/p&gt;  | [optional] 
 **shopUrl** | **string**| &lt;p&gt;Shop URL (deprecated, use shop_urls instead)&lt;/p&gt;  | [optional] 
 **shopUrls** | **List<string>**| &lt;p&gt;Shop URLs&lt;/p&gt;  | [optional] 
 **contactEmail** | **string**| &lt;p&gt;Contact email&lt;/p&gt;  | [optional] 
 **shopName** | **string**| &lt;p&gt;Shop name&lt;/p&gt;  | [optional] 
 **shopsystem** | **string**| &lt;p&gt;Shop system&lt;/p&gt;  | [optional] 
 **timezone** | **string**| &lt;table&gt;   &lt;tbody&gt;     &lt;tr&gt;       &lt;td&gt;Timezone UTC offsets in Zulu (+&lt;/td&gt;       &lt;td&gt;-)hh:mm&lt;/td&gt;     &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt;  | [optional] 
 **locale** | **string**| &lt;p&gt;Locale as a two letter language code&lt;/p&gt;  | [optional] 
 **defaultBrandingId** | **int?**| &lt;p&gt;Id of default branding&lt;/p&gt;  | [optional] 
 **loggingStopsAt** | **string**| &lt;p&gt;Timestamp when logging is active&lt;/p&gt;  | [optional] 
 **allowTestTransactions** | **bool?**| &lt;p&gt;Allow test transactions&lt;/p&gt;  | [optional] 
 **defaultPaymentLanguage** | **string**| &lt;p&gt;Default payment language (Two letter language code, ISO-639-1)&lt;/p&gt;  | [optional] 
 **defaultTextOnStatement** | **string**| &lt;p&gt;Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.&lt;/p&gt;  | [optional] 
 **defaultBrandingConfig** | [**Dictionary<string, string>**](string.md)| &lt;p&gt;Default branding config. Can be overwritten in branding or in request to payment window&lt;/p&gt;  | [optional] 

### Return type

[**Merchant**](Merchant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchaccountprivatekeyformat"></a>
# **PATCHAccountPrivateKeyFormat**
> PrivateKey PATCHAccountPrivateKeyFormat (string acceptVersion, string authorization)

Regenerates the private key of the merchant

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PATCHAccountPrivateKeyFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 

            try
            {
                // Regenerates the private key of the merchant
                PrivateKey result = apiInstance.PATCHAccountPrivateKeyFormat(acceptVersion, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.PATCHAccountPrivateKeyFormat: " + e.Message );
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

[**PrivateKey**](PrivateKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putaccountlogoformat"></a>
# **PUTAccountLogoFormat**
> void PUTAccountLogoFormat (string acceptVersion, string authorization, string _file, string logoType)

Creates or replaces the current merchant logo

 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PUTAccountLogoFormatExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var acceptVersion = acceptVersion_example;  // string | <p>Specify the version of the API</p> 
            var authorization = authorization_example;  // string | <p>Use Basic Auth to authorize to the API</p> 
            var _file = _file_example;  // string | <p>The logo as a multipart file. If the logo_type is ‘mobilepay’, the logo must be a 250px x 250px PNG file</p> 
            var logoType = logoType_example;  // string | <p>Type of logo</p>  (optional)  (default to payment_window)

            try
            {
                // Creates or replaces the current merchant logo
                apiInstance.PUTAccountLogoFormat(acceptVersion, authorization, _file, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.PUTAccountLogoFormat: " + e.Message );
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
 **_file** | **string**| &lt;p&gt;The logo as a multipart file. If the logo_type is ‘mobilepay’, the logo must be a 250px x 250px PNG file&lt;/p&gt;  | 
 **logoType** | **string**| &lt;p&gt;Type of logo&lt;/p&gt;  | [optional] [default to payment_window]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

