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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var logoType = logoType_example;  // string | Type of logo  (optional)  (default to payment_window)

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **logoType** | **string**| Type of logo  | [optional] [default to payment_window]

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var logoType = logoType_example;  // string | Type of logo  (optional)  (default to payment_window)

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **logoType** | **string**| Type of logo  | [optional] [default to payment_window]

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 

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
> Merchant PATCHAccountFormat (string acceptVersion, string authorization, string customerAddressName, string customerAddressAtt, string customerAddressStreet, string customerAddressCity, string customerAddressZipCode, string customerAddressRegion, string customerAddressCountryCode, string customerAddressVatNo, string billingAddressName, string billingAddressAtt, string billingAddressStreet, string billingAddressCity, string billingAddressZipCode, string billingAddressRegion, string billingAddressCountryCode, string billingAddressVatNo, string callbackUrl, bool? acquirerSettingsBamboraActive, string acquirerSettingsBamboraIdentificationCode, string acquirerSettingsBamboraIdentificationCodeInt, string acquirerSettingsBamboraBusinessCode, bool? acquirerSettingsBamboraRecurring, bool? acquirerSettingsBamboraAmericanexpress, bool? acquirerSettingsBamboraDinersclub, bool? acquirerSettingsBamboraSecurepay, string acquirerSettingsBamboraVisaMpiMerchantId, string acquirerSettingsBamboraMastercardMpiMerchantId, string acquirerSettingsBamboraVisaBin, string acquirerSettingsBamboraMastercardBin, bool? acquirerSettingsClearhausActive, string acquirerSettingsClearhausApiKey, bool? acquirerSettingsClearhausRecurring, bool? acquirerSettingsClearhausPayout, bool? acquirerSettingsClearhausApplePay, bool? acquirerSettingsElavonActive, string acquirerSettingsElavonIdentificationCode, string acquirerSettingsElavonIdentificationCodeInt, string acquirerSettingsElavonBusinessCode, bool? acquirerSettingsElavonRecurring, bool? acquirerSettingsElavonAmericanexpress, bool? acquirerSettingsElavonDinersclub, bool? acquirerSettingsElavonSecurepay, string acquirerSettingsElavonVisaMpiMerchantId, string acquirerSettingsElavonMastercardMpiMerchantId, string acquirerSettingsElavonVisaBin, string acquirerSettingsElavonMastercardBin, bool? acquirerSettingsHandelsbankenActive, string acquirerSettingsHandelsbankenIdentificationCode, string acquirerSettingsHandelsbankenIdentificationCodeInt, string acquirerSettingsHandelsbankenBusinessCode, bool? acquirerSettingsHandelsbankenRecurring, bool? acquirerSettingsHandelsbankenAmericanexpress, bool? acquirerSettingsHandelsbankenDinersclub, bool? acquirerSettingsHandelsbankenSecurepay, string acquirerSettingsHandelsbankenVisaMpiMerchantId, string acquirerSettingsHandelsbankenMastercardMpiMerchantId, string acquirerSettingsHandelsbankenVisaBin, string acquirerSettingsHandelsbankenMastercardBin, bool? acquirerSettingsKlarnaActive, int? acquirerSettingsKlarnaEid, string acquirerSettingsKlarnaSharedSecret, bool? acquirerSettingsMobilepayActive, string acquirerSettingsMobilepayDeliveryLimitedTo, bool? acquirerSettingsMobilepaysubscriptionsActive, string acquirerSettingsMobilepaysubscriptionsAuthState, string acquirerSettingsMobilepaysubscriptionsCodeVerifier, int? acquirerSettingsMobilepaysubscriptionsLastTokenRefresh, string acquirerSettingsMobilepaysubscriptionsNonce, int? acquirerSettingsMobilepaysubscriptionsPendingStatus, string acquirerSettingsMobilepaysubscriptionsProvider, string acquirerSettingsMobilepaysubscriptionsRefreshToken, bool? acquirerSettingsNetsActive, string acquirerSettingsNetsIdentificationCode, string acquirerSettingsNetsBusinessCode, bool? acquirerSettingsNetsRecurring, bool? acquirerSettingsNetsFbg1886, bool? acquirerSettingsNetsSecuredByNets, string acquirerSettingsNetsIdentificationCodeInt, bool? acquirerSettingsNetsAmericanexpress, bool? acquirerSettingsNetsDinersclub, bool? acquirerSettingsNetsSecurepay, string acquirerSettingsNetsVisaBin, string acquirerSettingsNetsMastercardBin, bool? acquirerSettingsPaypalActive, bool? acquirerSettingsPaypalRecurring, bool? acquirerSettingsPaypalCreditCard, string acquirerSettingsPaypalToken, string acquirerSettingsPaypalTokenSecret, string acquirerSettingsPaypalScope, bool? acquirerSettingsSofortActive, int? acquirerSettingsSofortCustomerNumber, int? acquirerSettingsSofortProjectId, string acquirerSettingsSofortApiKey, bool? acquirerSettingsSofortGateway, bool? acquirerSettingsSofortIdeal, int? acquirerSettingsSofortIdealProjectId, string acquirerSettingsSofortIdealProjectPassword, string acquirerSettingsSofortIdealNotificationPassword, bool? acquirerSettingsSwedbankActive, string acquirerSettingsSwedbankIdentificationCode, string acquirerSettingsSwedbankIdentificationCodeInt, string acquirerSettingsSwedbankBusinessCode, bool? acquirerSettingsSwedbankRecurring, bool? acquirerSettingsSwedbankAmericanexpress, bool? acquirerSettingsSwedbankDinersclub, bool? acquirerSettingsSwedbankSecurepay, string acquirerSettingsSwedbankVisaMpiMerchantId, string acquirerSettingsSwedbankMastercardMpiMerchantId, string acquirerSettingsSwedbankVisaBin, string acquirerSettingsSwedbankMastercardBin, bool? acquirerSettingsTellerActive, string acquirerSettingsTellerIdentificationCode, string acquirerSettingsTellerIdentificationCodeInt, string acquirerSettingsTellerBusinessCode, bool? acquirerSettingsTellerRecurring, bool? acquirerSettingsTellerAmericanexpress, bool? acquirerSettingsTellerDinersclub, bool? acquirerSettingsTellerSecurepay, string acquirerSettingsTellerVisaMpiMerchantId, string acquirerSettingsTellerMastercardMpiMerchantId, string acquirerSettingsTellerVisaBin, string acquirerSettingsTellerMastercardBin, bool? acquirerSettingsValitorActive, string acquirerSettingsValitorIdentificationCode, string acquirerSettingsValitorIdentificationCodeInt, string acquirerSettingsValitorBusinessCode, bool? acquirerSettingsValitorRecurring, bool? acquirerSettingsValitorAmericanexpress, bool? acquirerSettingsValitorDinersclub, bool? acquirerSettingsValitorSecurepay, string acquirerSettingsValitorVisaMpiMerchantId, string acquirerSettingsValitorMastercardMpiMerchantId, string acquirerSettingsValitorVisaBin, string acquirerSettingsValitorMastercardBin, bool? acquirerSettingsViabillActive, string acquirerSettingsViabillApiKey, bool? integrationSettingsEconomicActive, string integrationSettingsEconomicAgreement, string integrationSettingsEconomicAgreementToken, bool? pciSaqA, bool? pciSaqAEp, bool? pciSaqB, bool? pciSaqBIp, bool? pciSaqC, bool? pciSaqCVt, bool? pciSaqDMerchant, bool? pciSaqDServiceProvider, bool? pciSaqP2peHw, bool? autofee, string defaultPaymentMethods, string shopUrl, string shopUrls, string contactEmail, string shopName, string shopsystem, string timezone, string locale, int? defaultBrandingId, string loggingStopsAt, bool? allowTestTransactions, string defaultPaymentLanguage, string defaultTextOnStatement, string defaultBrandingConfig)

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var customerAddressName = customerAddressName_example;  // string | Name  (optional) 
            var customerAddressAtt = customerAddressAtt_example;  // string | Att  (optional) 
            var customerAddressStreet = customerAddressStreet_example;  // string | Street  (optional) 
            var customerAddressCity = customerAddressCity_example;  // string | City  (optional) 
            var customerAddressZipCode = customerAddressZipCode_example;  // string | Zip code  (optional) 
            var customerAddressRegion = customerAddressRegion_example;  // string | Region  (optional) 
            var customerAddressCountryCode = customerAddressCountryCode_example;  // string | Three letter country code according to ISO 3166-1 Alpha-3  (optional) 
            var customerAddressVatNo = customerAddressVatNo_example;  // string | VAT registration number  (optional) 
            var billingAddressName = billingAddressName_example;  // string | Name  (optional) 
            var billingAddressAtt = billingAddressAtt_example;  // string | Att  (optional) 
            var billingAddressStreet = billingAddressStreet_example;  // string | Street  (optional) 
            var billingAddressCity = billingAddressCity_example;  // string | City  (optional) 
            var billingAddressZipCode = billingAddressZipCode_example;  // string | Zip code  (optional) 
            var billingAddressRegion = billingAddressRegion_example;  // string | Region  (optional) 
            var billingAddressCountryCode = billingAddressCountryCode_example;  // string | Three letter country code according to ISO 3166-1 Alpha-3  (optional) 
            var billingAddressVatNo = billingAddressVatNo_example;  // string | VAT registration number  (optional) 
            var callbackUrl = callbackUrl_example;  // string | Callback url  (optional) 
            var acquirerSettingsBamboraActive = true;  // bool? | Enable Bambora payments  (optional) 
            var acquirerSettingsBamboraIdentificationCode = acquirerSettingsBamboraIdentificationCode_example;  // string | Bambora identification number  (optional) 
            var acquirerSettingsBamboraIdentificationCodeInt = acquirerSettingsBamboraIdentificationCodeInt_example;  // string | Bambora international identification number  (optional) 
            var acquirerSettingsBamboraBusinessCode = acquirerSettingsBamboraBusinessCode_example;  // string | Business code (assigned by Bambora)  (optional) 
            var acquirerSettingsBamboraRecurring = true;  // bool? | Enable recurring payments (requires agreement with Bambora)  (optional) 
            var acquirerSettingsBamboraAmericanexpress = true;  // bool? | Enable AMEX payments (requires agreement with Bambora)  (optional) 
            var acquirerSettingsBamboraDinersclub = true;  // bool? | Enable Diners Club payments (requires agreement with Bambora)  (optional) 
            var acquirerSettingsBamboraSecurepay = true;  // bool? | Enable SecurePay fraud protection.  (optional) 
            var acquirerSettingsBamboraVisaMpiMerchantId = acquirerSettingsBamboraVisaMpiMerchantId_example;  // string | VISA MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsBamboraMastercardMpiMerchantId = acquirerSettingsBamboraMastercardMpiMerchantId_example;  // string | Mastercard MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsBamboraVisaBin = acquirerSettingsBamboraVisaBin_example;  // string | VISA acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsBamboraMastercardBin = acquirerSettingsBamboraMastercardBin_example;  // string | Mastercard acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsClearhausActive = true;  // bool? | Enable ClearHaus payments  (optional) 
            var acquirerSettingsClearhausApiKey = acquirerSettingsClearhausApiKey_example;  // string | Clearhaus API key (is required but may be left empty)  (optional) 
            var acquirerSettingsClearhausRecurring = true;  // bool? | Enable recurring payments (requires agreement with Clearhaus)  (optional) 
            var acquirerSettingsClearhausPayout = true;  // bool? | Enable payouts (requires agreement with Clearhaus)  (optional) 
            var acquirerSettingsClearhausApplePay = true;  // bool? | Enable Apple Pay (requires agreement with Clearhaus)  (optional) 
            var acquirerSettingsElavonActive = true;  // bool? | Enable Elavon payments  (optional) 
            var acquirerSettingsElavonIdentificationCode = acquirerSettingsElavonIdentificationCode_example;  // string | Elavon identification number  (optional) 
            var acquirerSettingsElavonIdentificationCodeInt = acquirerSettingsElavonIdentificationCodeInt_example;  // string | Elavon international identification number  (optional) 
            var acquirerSettingsElavonBusinessCode = acquirerSettingsElavonBusinessCode_example;  // string | Business code (assigned by Elavon)  (optional) 
            var acquirerSettingsElavonRecurring = true;  // bool? | Enable recurring payments (requires agreement with Elavon)  (optional) 
            var acquirerSettingsElavonAmericanexpress = true;  // bool? | Enable AMEX payments (requires agreement with Elavon)  (optional) 
            var acquirerSettingsElavonDinersclub = true;  // bool? | Enable Diners Club payments (requires agreement with Elavon)  (optional) 
            var acquirerSettingsElavonSecurepay = true;  // bool? | Enable SecurePay fraud protection.  (optional) 
            var acquirerSettingsElavonVisaMpiMerchantId = acquirerSettingsElavonVisaMpiMerchantId_example;  // string | VISA MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsElavonMastercardMpiMerchantId = acquirerSettingsElavonMastercardMpiMerchantId_example;  // string | Mastercard MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsElavonVisaBin = acquirerSettingsElavonVisaBin_example;  // string | VISA acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsElavonMastercardBin = acquirerSettingsElavonMastercardBin_example;  // string | Mastercard acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsHandelsbankenActive = true;  // bool? | Enable Handelsbanken payments  (optional) 
            var acquirerSettingsHandelsbankenIdentificationCode = acquirerSettingsHandelsbankenIdentificationCode_example;  // string | Handelsbanken identification number  (optional) 
            var acquirerSettingsHandelsbankenIdentificationCodeInt = acquirerSettingsHandelsbankenIdentificationCodeInt_example;  // string | Handelsbanken international identification number  (optional) 
            var acquirerSettingsHandelsbankenBusinessCode = acquirerSettingsHandelsbankenBusinessCode_example;  // string | Business code (assigned by Handelsbanken)  (optional) 
            var acquirerSettingsHandelsbankenRecurring = true;  // bool? | Enable recurring payments (requires agreement with Handelsbanken)  (optional) 
            var acquirerSettingsHandelsbankenAmericanexpress = true;  // bool? | Enable AMEX payments (requires agreement with Handelsbanken)  (optional) 
            var acquirerSettingsHandelsbankenDinersclub = true;  // bool? | Enable Diners Club payments (requires agreement with Handelsbanken)  (optional) 
            var acquirerSettingsHandelsbankenSecurepay = true;  // bool? | Enable SecurePay fraud protection.  (optional) 
            var acquirerSettingsHandelsbankenVisaMpiMerchantId = acquirerSettingsHandelsbankenVisaMpiMerchantId_example;  // string | VISA MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsHandelsbankenMastercardMpiMerchantId = acquirerSettingsHandelsbankenMastercardMpiMerchantId_example;  // string | Mastercard MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsHandelsbankenVisaBin = acquirerSettingsHandelsbankenVisaBin_example;  // string | VISA acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsHandelsbankenMastercardBin = acquirerSettingsHandelsbankenMastercardBin_example;  // string | Mastercard acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsKlarnaActive = true;  // bool? | Enable Klarna payments  (optional) 
            var acquirerSettingsKlarnaEid = 56;  // int? | Klarna merchant ID  (optional) 
            var acquirerSettingsKlarnaSharedSecret = acquirerSettingsKlarnaSharedSecret_example;  // string | Klarna shared secret  (optional) 
            var acquirerSettingsMobilepayActive = true;  // bool? | Enable MobilePay payments  (optional) 
            var acquirerSettingsMobilepayDeliveryLimitedTo = acquirerSettingsMobilepayDeliveryLimitedTo_example;  // string | Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI)  (optional) 
            var acquirerSettingsMobilepaysubscriptionsActive = true;  // bool? | Enable MobilePay Subscriptions payments  (optional) 
            var acquirerSettingsMobilepaysubscriptionsAuthState = acquirerSettingsMobilepaysubscriptionsAuthState_example;  // string | Identifier MobilePay Subscriptions uses to link requests to callbacks  (optional) 
            var acquirerSettingsMobilepaysubscriptionsCodeVerifier = acquirerSettingsMobilepaysubscriptionsCodeVerifier_example;  // string | Verifies received code challenge  (optional) 
            var acquirerSettingsMobilepaysubscriptionsLastTokenRefresh = 56;  // int? | Unix Timestamp of last time the tokens were refreshed  (optional) 
            var acquirerSettingsMobilepaysubscriptionsNonce = acquirerSettingsMobilepaysubscriptionsNonce_example;  // string | Associate client sessions with ID Tokens to mitigate replay attacks  (optional) 
            var acquirerSettingsMobilepaysubscriptionsPendingStatus = 56;  // int? | 0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed  (optional)  (default to 0)
            var acquirerSettingsMobilepaysubscriptionsProvider = acquirerSettingsMobilepaysubscriptionsProvider_example;  // string | The provider / sales-place chosen by the merchant  (optional) 
            var acquirerSettingsMobilepaysubscriptionsRefreshToken = acquirerSettingsMobilepaysubscriptionsRefreshToken_example;  // string | Token to refresh access token for up to 1 year  (optional) 
            var acquirerSettingsNetsActive = true;  // bool? | Enable Nets/Teller payments  (optional) 
            var acquirerSettingsNetsIdentificationCode = acquirerSettingsNetsIdentificationCode_example;  // string | Nets TOF number  (optional) 
            var acquirerSettingsNetsBusinessCode = acquirerSettingsNetsBusinessCode_example;  // string | Business code (assigned by Nets)  (optional) 
            var acquirerSettingsNetsRecurring = true;  // bool? | Enable recurring payments (requires agreement with Nets)  (optional) 
            var acquirerSettingsNetsFbg1886 = true;  // bool? | Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen)  (optional) 
            var acquirerSettingsNetsSecuredByNets = true;  // bool? | Enable SecuredByNets fraud protection.  (optional) 
            var acquirerSettingsNetsIdentificationCodeInt = acquirerSettingsNetsIdentificationCodeInt_example;  // string | (Depricated; use Teller acquirer)  (optional) 
            var acquirerSettingsNetsAmericanexpress = true;  // bool? | (Depricated; use Teller acquirer)  (optional) 
            var acquirerSettingsNetsDinersclub = true;  // bool? | (Depricated; use Teller acquirer)  (optional) 
            var acquirerSettingsNetsSecurepay = true;  // bool? | (Depricated; use Teller acquirer)  (optional)  (default to true)
            var acquirerSettingsNetsVisaBin = acquirerSettingsNetsVisaBin_example;  // string | (Depricated; use Teller acquirer)  (optional) 
            var acquirerSettingsNetsMastercardBin = acquirerSettingsNetsMastercardBin_example;  // string | (Depricated; use Teller acquirer)  (optional) 
            var acquirerSettingsPaypalActive = true;  // bool? | Enable PayPal payments  (optional) 
            var acquirerSettingsPaypalRecurring = true;  // bool? | Enable recurring payments  (optional) 
            var acquirerSettingsPaypalCreditCard = true;  // bool? | Allow credit-card payments. (Only for US/CA/UK merchants)  (optional) 
            var acquirerSettingsPaypalToken = acquirerSettingsPaypalToken_example;  // string | Authentication token  (optional) 
            var acquirerSettingsPaypalTokenSecret = acquirerSettingsPaypalTokenSecret_example;  // string | Authentication token secret  (optional) 
            var acquirerSettingsPaypalScope = acquirerSettingsPaypalScope_example;  // string | Authentication scope  (optional) 
            var acquirerSettingsSofortActive = true;  // bool? | Enable Sofort payments  (optional) 
            var acquirerSettingsSofortCustomerNumber = 56;  // int? | Sofort customer number  (optional) 
            var acquirerSettingsSofortProjectId = 56;  // int? | Sofort Gateway project id  (optional) 
            var acquirerSettingsSofortApiKey = acquirerSettingsSofortApiKey_example;  // string | Sofort API key  (optional) 
            var acquirerSettingsSofortGateway = true;  // bool? | Enable Sofort Gateway feature  (optional)  (default to true)
            var acquirerSettingsSofortIdeal = true;  // bool? | Enable Sofort iDeal feature  (optional) 
            var acquirerSettingsSofortIdealProjectId = 56;  // int? | Sofort iDeal project id  (optional) 
            var acquirerSettingsSofortIdealProjectPassword = acquirerSettingsSofortIdealProjectPassword_example;  // string | Sofort iDeal project password  (optional) 
            var acquirerSettingsSofortIdealNotificationPassword = acquirerSettingsSofortIdealNotificationPassword_example;  // string | Sofort iDeal notification password  (optional) 
            var acquirerSettingsSwedbankActive = true;  // bool? | Enable Swedbank payments  (optional) 
            var acquirerSettingsSwedbankIdentificationCode = acquirerSettingsSwedbankIdentificationCode_example;  // string | Swedbank identification number  (optional) 
            var acquirerSettingsSwedbankIdentificationCodeInt = acquirerSettingsSwedbankIdentificationCodeInt_example;  // string | Swedbank international identification number  (optional) 
            var acquirerSettingsSwedbankBusinessCode = acquirerSettingsSwedbankBusinessCode_example;  // string | Business code (assigned by Swedbank)  (optional) 
            var acquirerSettingsSwedbankRecurring = true;  // bool? | Enable recurring payments (requires agreement with Swedbank)  (optional) 
            var acquirerSettingsSwedbankAmericanexpress = true;  // bool? | Enable AMEX payments (requires agreement with Swedbank)  (optional) 
            var acquirerSettingsSwedbankDinersclub = true;  // bool? | Enable Diners Club payments (requires agreement with Swedbank)  (optional) 
            var acquirerSettingsSwedbankSecurepay = true;  // bool? | Enable SecurePay fraud protection.  (optional) 
            var acquirerSettingsSwedbankVisaMpiMerchantId = acquirerSettingsSwedbankVisaMpiMerchantId_example;  // string | VISA MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsSwedbankMastercardMpiMerchantId = acquirerSettingsSwedbankMastercardMpiMerchantId_example;  // string | Mastercard MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsSwedbankVisaBin = acquirerSettingsSwedbankVisaBin_example;  // string | VISA acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsSwedbankMastercardBin = acquirerSettingsSwedbankMastercardBin_example;  // string | Mastercard acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsTellerActive = true;  // bool? | Enable Teller payments  (optional) 
            var acquirerSettingsTellerIdentificationCode = acquirerSettingsTellerIdentificationCode_example;  // string | Teller TOF number  (optional) 
            var acquirerSettingsTellerIdentificationCodeInt = acquirerSettingsTellerIdentificationCodeInt_example;  // string | Teller international identification number  (optional) 
            var acquirerSettingsTellerBusinessCode = acquirerSettingsTellerBusinessCode_example;  // string | Business code (assigned by Teller)  (optional) 
            var acquirerSettingsTellerRecurring = true;  // bool? | Enable recurring payments (requires agreement with Teller)  (optional) 
            var acquirerSettingsTellerAmericanexpress = true;  // bool? | Enable AMEX payments (requires agreement with Teller)  (optional) 
            var acquirerSettingsTellerDinersclub = true;  // bool? | Enable Diners Club payments (requires agreement with Teller)  (optional) 
            var acquirerSettingsTellerSecurepay = true;  // bool? | Enable SecurePay fraud protection. (disabling requires agreement with Teller)  (optional)  (default to true)
            var acquirerSettingsTellerVisaMpiMerchantId = acquirerSettingsTellerVisaMpiMerchantId_example;  // string | VISA MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsTellerMastercardMpiMerchantId = acquirerSettingsTellerMastercardMpiMerchantId_example;  // string | Mastercard MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsTellerVisaBin = acquirerSettingsTellerVisaBin_example;  // string | Teller VISA acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsTellerMastercardBin = acquirerSettingsTellerMastercardBin_example;  // string | Teller Mastercard acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsValitorActive = true;  // bool? | Enable Valitor payments  (optional) 
            var acquirerSettingsValitorIdentificationCode = acquirerSettingsValitorIdentificationCode_example;  // string | Valitor identification number  (optional) 
            var acquirerSettingsValitorIdentificationCodeInt = acquirerSettingsValitorIdentificationCodeInt_example;  // string | Valitor international identification number  (optional) 
            var acquirerSettingsValitorBusinessCode = acquirerSettingsValitorBusinessCode_example;  // string | Business code (assigned by Valitor)  (optional) 
            var acquirerSettingsValitorRecurring = true;  // bool? | Enable recurring payments (requires agreement with Valitor)  (optional) 
            var acquirerSettingsValitorAmericanexpress = true;  // bool? | Enable AMEX payments (requires agreement with Valitor)  (optional) 
            var acquirerSettingsValitorDinersclub = true;  // bool? | Enable Diners Club payments (requires agreement with Valitor)  (optional) 
            var acquirerSettingsValitorSecurepay = true;  // bool? | Enable SecurePay fraud protection.  (optional) 
            var acquirerSettingsValitorVisaMpiMerchantId = acquirerSettingsValitorVisaMpiMerchantId_example;  // string | VISA MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsValitorMastercardMpiMerchantId = acquirerSettingsValitorMastercardMpiMerchantId_example;  // string | Mastercard MPI merchant id. Used for 3D secure transactions  (optional) 
            var acquirerSettingsValitorVisaBin = acquirerSettingsValitorVisaBin_example;  // string | VISA acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsValitorMastercardBin = acquirerSettingsValitorMastercardBin_example;  // string | Mastercard acquirer bin used for 3D Secure  (optional) 
            var acquirerSettingsViabillActive = true;  // bool? | Enable ViaBill payments  (optional) 
            var acquirerSettingsViabillApiKey = acquirerSettingsViabillApiKey_example;  // string | ViaBill API key  (optional) 
            var integrationSettingsEconomicActive = true;  // bool? | Enable e-conomic integration  (optional) 
            var integrationSettingsEconomicAgreement = integrationSettingsEconomicAgreement_example;  // string | e-conomic agreement no.  (optional) 
            var integrationSettingsEconomicAgreementToken = integrationSettingsEconomicAgreementToken_example;  // string | economic agreement grant token  (optional) 
            var pciSaqA = true;  // bool? | Enable SAQ A  (optional) 
            var pciSaqAEp = true;  // bool? | Enable SAQ A-EP  (optional) 
            var pciSaqB = true;  // bool? | Enable SAQ B  (optional) 
            var pciSaqBIp = true;  // bool? | Enable SAQ B-IP  (optional) 
            var pciSaqC = true;  // bool? | Enable SAQ C  (optional) 
            var pciSaqCVt = true;  // bool? | Enable SAQ C-VT  (optional) 
            var pciSaqDMerchant = true;  // bool? | Enable SAQ D Merchant  (optional) 
            var pciSaqDServiceProvider = true;  // bool? | Enable SAQ D Service Provider  (optional) 
            var pciSaqP2peHw = true;  // bool? | Enable SAQ P2PE-HW  (optional) 
            var autofee = true;  // bool? | Add automatic fee on all payments  (optional) 
            var defaultPaymentMethods = defaultPaymentMethods_example;  // string | Comma separated list of default payment methods  (optional) 
            var shopUrl = shopUrl_example;  // string | Shop URL (deprecated, use shop_urls instead)  (optional) 
            var shopUrls = shopUrls_example;  // string | Shop URLs  (optional) 
            var contactEmail = contactEmail_example;  // string | Contact email  (optional) 
            var shopName = shopName_example;  // string | Shop name  (optional) 
            var shopsystem = shopsystem_example;  // string | Shop system  (optional) 
            var timezone = timezone_example;  // string | <table>   <tbody>     <tr>       <td>Timezone UTC offsets in Zulu (+</td>       <td>-)hh:mm</td>     </tr>   </tbody> </table>  (optional) 
            var locale = locale_example;  // string | Locale as a two letter language code  (optional) 
            var defaultBrandingId = 56;  // int? | Id of default branding  (optional) 
            var loggingStopsAt = loggingStopsAt_example;  // string | Timestamp when logging is active  (optional) 
            var allowTestTransactions = true;  // bool? | Allow test transactions  (optional) 
            var defaultPaymentLanguage = defaultPaymentLanguage_example;  // string | Default payment language (Two letter language code, ISO-639-1)  (optional) 
            var defaultTextOnStatement = defaultTextOnStatement_example;  // string | Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.  (optional) 
            var defaultBrandingConfig = defaultBrandingConfig_example;  // string | Default branding config. Can be overwritten in branding or in request to payment window  (optional) 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **customerAddressName** | **string**| Name  | [optional] 
 **customerAddressAtt** | **string**| Att  | [optional] 
 **customerAddressStreet** | **string**| Street  | [optional] 
 **customerAddressCity** | **string**| City  | [optional] 
 **customerAddressZipCode** | **string**| Zip code  | [optional] 
 **customerAddressRegion** | **string**| Region  | [optional] 
 **customerAddressCountryCode** | **string**| Three letter country code according to ISO 3166-1 Alpha-3  | [optional] 
 **customerAddressVatNo** | **string**| VAT registration number  | [optional] 
 **billingAddressName** | **string**| Name  | [optional] 
 **billingAddressAtt** | **string**| Att  | [optional] 
 **billingAddressStreet** | **string**| Street  | [optional] 
 **billingAddressCity** | **string**| City  | [optional] 
 **billingAddressZipCode** | **string**| Zip code  | [optional] 
 **billingAddressRegion** | **string**| Region  | [optional] 
 **billingAddressCountryCode** | **string**| Three letter country code according to ISO 3166-1 Alpha-3  | [optional] 
 **billingAddressVatNo** | **string**| VAT registration number  | [optional] 
 **callbackUrl** | **string**| Callback url  | [optional] 
 **acquirerSettingsBamboraActive** | **bool?**| Enable Bambora payments  | [optional] 
 **acquirerSettingsBamboraIdentificationCode** | **string**| Bambora identification number  | [optional] 
 **acquirerSettingsBamboraIdentificationCodeInt** | **string**| Bambora international identification number  | [optional] 
 **acquirerSettingsBamboraBusinessCode** | **string**| Business code (assigned by Bambora)  | [optional] 
 **acquirerSettingsBamboraRecurring** | **bool?**| Enable recurring payments (requires agreement with Bambora)  | [optional] 
 **acquirerSettingsBamboraAmericanexpress** | **bool?**| Enable AMEX payments (requires agreement with Bambora)  | [optional] 
 **acquirerSettingsBamboraDinersclub** | **bool?**| Enable Diners Club payments (requires agreement with Bambora)  | [optional] 
 **acquirerSettingsBamboraSecurepay** | **bool?**| Enable SecurePay fraud protection.  | [optional] 
 **acquirerSettingsBamboraVisaMpiMerchantId** | **string**| VISA MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsBamboraMastercardMpiMerchantId** | **string**| Mastercard MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsBamboraVisaBin** | **string**| VISA acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsBamboraMastercardBin** | **string**| Mastercard acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsClearhausActive** | **bool?**| Enable ClearHaus payments  | [optional] 
 **acquirerSettingsClearhausApiKey** | **string**| Clearhaus API key (is required but may be left empty)  | [optional] 
 **acquirerSettingsClearhausRecurring** | **bool?**| Enable recurring payments (requires agreement with Clearhaus)  | [optional] 
 **acquirerSettingsClearhausPayout** | **bool?**| Enable payouts (requires agreement with Clearhaus)  | [optional] 
 **acquirerSettingsClearhausApplePay** | **bool?**| Enable Apple Pay (requires agreement with Clearhaus)  | [optional] 
 **acquirerSettingsElavonActive** | **bool?**| Enable Elavon payments  | [optional] 
 **acquirerSettingsElavonIdentificationCode** | **string**| Elavon identification number  | [optional] 
 **acquirerSettingsElavonIdentificationCodeInt** | **string**| Elavon international identification number  | [optional] 
 **acquirerSettingsElavonBusinessCode** | **string**| Business code (assigned by Elavon)  | [optional] 
 **acquirerSettingsElavonRecurring** | **bool?**| Enable recurring payments (requires agreement with Elavon)  | [optional] 
 **acquirerSettingsElavonAmericanexpress** | **bool?**| Enable AMEX payments (requires agreement with Elavon)  | [optional] 
 **acquirerSettingsElavonDinersclub** | **bool?**| Enable Diners Club payments (requires agreement with Elavon)  | [optional] 
 **acquirerSettingsElavonSecurepay** | **bool?**| Enable SecurePay fraud protection.  | [optional] 
 **acquirerSettingsElavonVisaMpiMerchantId** | **string**| VISA MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsElavonMastercardMpiMerchantId** | **string**| Mastercard MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsElavonVisaBin** | **string**| VISA acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsElavonMastercardBin** | **string**| Mastercard acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsHandelsbankenActive** | **bool?**| Enable Handelsbanken payments  | [optional] 
 **acquirerSettingsHandelsbankenIdentificationCode** | **string**| Handelsbanken identification number  | [optional] 
 **acquirerSettingsHandelsbankenIdentificationCodeInt** | **string**| Handelsbanken international identification number  | [optional] 
 **acquirerSettingsHandelsbankenBusinessCode** | **string**| Business code (assigned by Handelsbanken)  | [optional] 
 **acquirerSettingsHandelsbankenRecurring** | **bool?**| Enable recurring payments (requires agreement with Handelsbanken)  | [optional] 
 **acquirerSettingsHandelsbankenAmericanexpress** | **bool?**| Enable AMEX payments (requires agreement with Handelsbanken)  | [optional] 
 **acquirerSettingsHandelsbankenDinersclub** | **bool?**| Enable Diners Club payments (requires agreement with Handelsbanken)  | [optional] 
 **acquirerSettingsHandelsbankenSecurepay** | **bool?**| Enable SecurePay fraud protection.  | [optional] 
 **acquirerSettingsHandelsbankenVisaMpiMerchantId** | **string**| VISA MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsHandelsbankenMastercardMpiMerchantId** | **string**| Mastercard MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsHandelsbankenVisaBin** | **string**| VISA acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsHandelsbankenMastercardBin** | **string**| Mastercard acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsKlarnaActive** | **bool?**| Enable Klarna payments  | [optional] 
 **acquirerSettingsKlarnaEid** | **int?**| Klarna merchant ID  | [optional] 
 **acquirerSettingsKlarnaSharedSecret** | **string**| Klarna shared secret  | [optional] 
 **acquirerSettingsMobilepayActive** | **bool?**| Enable MobilePay payments  | [optional] 
 **acquirerSettingsMobilepayDeliveryLimitedTo** | **string**| Limit MobilePay delivery address selection to theses countries. (ISO 3166-1 alpha-2 without delimiter ‘DKNOSEFI’) (Valid options are DK,NO,SE,FI)  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsActive** | **bool?**| Enable MobilePay Subscriptions payments  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsAuthState** | **string**| Identifier MobilePay Subscriptions uses to link requests to callbacks  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsCodeVerifier** | **string**| Verifies received code challenge  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsLastTokenRefresh** | **int?**| Unix Timestamp of last time the tokens were refreshed  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsNonce** | **string**| Associate client sessions with ID Tokens to mitigate replay attacks  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsPendingStatus** | **int?**| 0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed  | [optional] [default to 0]
 **acquirerSettingsMobilepaysubscriptionsProvider** | **string**| The provider / sales-place chosen by the merchant  | [optional] 
 **acquirerSettingsMobilepaysubscriptionsRefreshToken** | **string**| Token to refresh access token for up to 1 year  | [optional] 
 **acquirerSettingsNetsActive** | **bool?**| Enable Nets/Teller payments  | [optional] 
 **acquirerSettingsNetsIdentificationCode** | **string**| Nets TOF number  | [optional] 
 **acquirerSettingsNetsBusinessCode** | **string**| Business code (assigned by Nets)  | [optional] 
 **acquirerSettingsNetsRecurring** | **bool?**| Enable recurring payments (requires agreement with Nets)  | [optional] 
 **acquirerSettingsNetsFbg1886** | **bool?**| Enable Forbrugsforeningen payments (requires agreement with Nets and Forbrugsforeningen)  | [optional] 
 **acquirerSettingsNetsSecuredByNets** | **bool?**| Enable SecuredByNets fraud protection.  | [optional] 
 **acquirerSettingsNetsIdentificationCodeInt** | **string**| (Depricated; use Teller acquirer)  | [optional] 
 **acquirerSettingsNetsAmericanexpress** | **bool?**| (Depricated; use Teller acquirer)  | [optional] 
 **acquirerSettingsNetsDinersclub** | **bool?**| (Depricated; use Teller acquirer)  | [optional] 
 **acquirerSettingsNetsSecurepay** | **bool?**| (Depricated; use Teller acquirer)  | [optional] [default to true]
 **acquirerSettingsNetsVisaBin** | **string**| (Depricated; use Teller acquirer)  | [optional] 
 **acquirerSettingsNetsMastercardBin** | **string**| (Depricated; use Teller acquirer)  | [optional] 
 **acquirerSettingsPaypalActive** | **bool?**| Enable PayPal payments  | [optional] 
 **acquirerSettingsPaypalRecurring** | **bool?**| Enable recurring payments  | [optional] 
 **acquirerSettingsPaypalCreditCard** | **bool?**| Allow credit-card payments. (Only for US/CA/UK merchants)  | [optional] 
 **acquirerSettingsPaypalToken** | **string**| Authentication token  | [optional] 
 **acquirerSettingsPaypalTokenSecret** | **string**| Authentication token secret  | [optional] 
 **acquirerSettingsPaypalScope** | **string**| Authentication scope  | [optional] 
 **acquirerSettingsSofortActive** | **bool?**| Enable Sofort payments  | [optional] 
 **acquirerSettingsSofortCustomerNumber** | **int?**| Sofort customer number  | [optional] 
 **acquirerSettingsSofortProjectId** | **int?**| Sofort Gateway project id  | [optional] 
 **acquirerSettingsSofortApiKey** | **string**| Sofort API key  | [optional] 
 **acquirerSettingsSofortGateway** | **bool?**| Enable Sofort Gateway feature  | [optional] [default to true]
 **acquirerSettingsSofortIdeal** | **bool?**| Enable Sofort iDeal feature  | [optional] 
 **acquirerSettingsSofortIdealProjectId** | **int?**| Sofort iDeal project id  | [optional] 
 **acquirerSettingsSofortIdealProjectPassword** | **string**| Sofort iDeal project password  | [optional] 
 **acquirerSettingsSofortIdealNotificationPassword** | **string**| Sofort iDeal notification password  | [optional] 
 **acquirerSettingsSwedbankActive** | **bool?**| Enable Swedbank payments  | [optional] 
 **acquirerSettingsSwedbankIdentificationCode** | **string**| Swedbank identification number  | [optional] 
 **acquirerSettingsSwedbankIdentificationCodeInt** | **string**| Swedbank international identification number  | [optional] 
 **acquirerSettingsSwedbankBusinessCode** | **string**| Business code (assigned by Swedbank)  | [optional] 
 **acquirerSettingsSwedbankRecurring** | **bool?**| Enable recurring payments (requires agreement with Swedbank)  | [optional] 
 **acquirerSettingsSwedbankAmericanexpress** | **bool?**| Enable AMEX payments (requires agreement with Swedbank)  | [optional] 
 **acquirerSettingsSwedbankDinersclub** | **bool?**| Enable Diners Club payments (requires agreement with Swedbank)  | [optional] 
 **acquirerSettingsSwedbankSecurepay** | **bool?**| Enable SecurePay fraud protection.  | [optional] 
 **acquirerSettingsSwedbankVisaMpiMerchantId** | **string**| VISA MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsSwedbankMastercardMpiMerchantId** | **string**| Mastercard MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsSwedbankVisaBin** | **string**| VISA acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsSwedbankMastercardBin** | **string**| Mastercard acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsTellerActive** | **bool?**| Enable Teller payments  | [optional] 
 **acquirerSettingsTellerIdentificationCode** | **string**| Teller TOF number  | [optional] 
 **acquirerSettingsTellerIdentificationCodeInt** | **string**| Teller international identification number  | [optional] 
 **acquirerSettingsTellerBusinessCode** | **string**| Business code (assigned by Teller)  | [optional] 
 **acquirerSettingsTellerRecurring** | **bool?**| Enable recurring payments (requires agreement with Teller)  | [optional] 
 **acquirerSettingsTellerAmericanexpress** | **bool?**| Enable AMEX payments (requires agreement with Teller)  | [optional] 
 **acquirerSettingsTellerDinersclub** | **bool?**| Enable Diners Club payments (requires agreement with Teller)  | [optional] 
 **acquirerSettingsTellerSecurepay** | **bool?**| Enable SecurePay fraud protection. (disabling requires agreement with Teller)  | [optional] [default to true]
 **acquirerSettingsTellerVisaMpiMerchantId** | **string**| VISA MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsTellerMastercardMpiMerchantId** | **string**| Mastercard MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsTellerVisaBin** | **string**| Teller VISA acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsTellerMastercardBin** | **string**| Teller Mastercard acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsValitorActive** | **bool?**| Enable Valitor payments  | [optional] 
 **acquirerSettingsValitorIdentificationCode** | **string**| Valitor identification number  | [optional] 
 **acquirerSettingsValitorIdentificationCodeInt** | **string**| Valitor international identification number  | [optional] 
 **acquirerSettingsValitorBusinessCode** | **string**| Business code (assigned by Valitor)  | [optional] 
 **acquirerSettingsValitorRecurring** | **bool?**| Enable recurring payments (requires agreement with Valitor)  | [optional] 
 **acquirerSettingsValitorAmericanexpress** | **bool?**| Enable AMEX payments (requires agreement with Valitor)  | [optional] 
 **acquirerSettingsValitorDinersclub** | **bool?**| Enable Diners Club payments (requires agreement with Valitor)  | [optional] 
 **acquirerSettingsValitorSecurepay** | **bool?**| Enable SecurePay fraud protection.  | [optional] 
 **acquirerSettingsValitorVisaMpiMerchantId** | **string**| VISA MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsValitorMastercardMpiMerchantId** | **string**| Mastercard MPI merchant id. Used for 3D secure transactions  | [optional] 
 **acquirerSettingsValitorVisaBin** | **string**| VISA acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsValitorMastercardBin** | **string**| Mastercard acquirer bin used for 3D Secure  | [optional] 
 **acquirerSettingsViabillActive** | **bool?**| Enable ViaBill payments  | [optional] 
 **acquirerSettingsViabillApiKey** | **string**| ViaBill API key  | [optional] 
 **integrationSettingsEconomicActive** | **bool?**| Enable e-conomic integration  | [optional] 
 **integrationSettingsEconomicAgreement** | **string**| e-conomic agreement no.  | [optional] 
 **integrationSettingsEconomicAgreementToken** | **string**| economic agreement grant token  | [optional] 
 **pciSaqA** | **bool?**| Enable SAQ A  | [optional] 
 **pciSaqAEp** | **bool?**| Enable SAQ A-EP  | [optional] 
 **pciSaqB** | **bool?**| Enable SAQ B  | [optional] 
 **pciSaqBIp** | **bool?**| Enable SAQ B-IP  | [optional] 
 **pciSaqC** | **bool?**| Enable SAQ C  | [optional] 
 **pciSaqCVt** | **bool?**| Enable SAQ C-VT  | [optional] 
 **pciSaqDMerchant** | **bool?**| Enable SAQ D Merchant  | [optional] 
 **pciSaqDServiceProvider** | **bool?**| Enable SAQ D Service Provider  | [optional] 
 **pciSaqP2peHw** | **bool?**| Enable SAQ P2PE-HW  | [optional] 
 **autofee** | **bool?**| Add automatic fee on all payments  | [optional] 
 **defaultPaymentMethods** | **string**| Comma separated list of default payment methods  | [optional] 
 **shopUrl** | **string**| Shop URL (deprecated, use shop_urls instead)  | [optional] 
 **shopUrls** | **string**| Shop URLs  | [optional] 
 **contactEmail** | **string**| Contact email  | [optional] 
 **shopName** | **string**| Shop name  | [optional] 
 **shopsystem** | **string**| Shop system  | [optional] 
 **timezone** | **string**| &lt;table&gt;   &lt;tbody&gt;     &lt;tr&gt;       &lt;td&gt;Timezone UTC offsets in Zulu (+&lt;/td&gt;       &lt;td&gt;-)hh:mm&lt;/td&gt;     &lt;/tr&gt;   &lt;/tbody&gt; &lt;/table&gt;  | [optional] 
 **locale** | **string**| Locale as a two letter language code  | [optional] 
 **defaultBrandingId** | **int?**| Id of default branding  | [optional] 
 **loggingStopsAt** | **string**| Timestamp when logging is active  | [optional] 
 **allowTestTransactions** | **bool?**| Allow test transactions  | [optional] 
 **defaultPaymentLanguage** | **string**| Default payment language (Two letter language code, ISO-639-1)  | [optional] 
 **defaultTextOnStatement** | **string**| Text to be displayed on cardholder’s statement. Max 22 ASCII chars. Currently supported by Clearhaus only.  | [optional] 
 **defaultBrandingConfig** | **string**| Default branding config. Can be overwritten in branding or in request to payment window  | [optional] 

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 

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
            var acceptVersion = acceptVersion_example;  // string | Specify the version of the API 
            var authorization = authorization_example;  // string | Use Basic Auth to authorize to the API 
            var _file = _file_example;  // string | The logo as a multipart file. If the logo_type is ‘mobilepay’, the logo must be a 250px x 250px PNG file 
            var logoType = logoType_example;  // string | Type of logo  (optional)  (default to payment_window)

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
 **acceptVersion** | **string**| Specify the version of the API  | 
 **authorization** | **string**| Use Basic Auth to authorize to the API  | 
 **_file** | **string**| The logo as a multipart file. If the logo_type is ‘mobilepay’, the logo must be a 250px x 250px PNG file  | 
 **logoType** | **string**| Type of logo  | [optional] [default to payment_window]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/xml, application/json, application/octet-stream, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

