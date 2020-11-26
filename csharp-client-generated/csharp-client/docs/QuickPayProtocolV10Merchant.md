# IO.Swagger.Model.QuickPayProtocolV10Merchant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcquirerSettings** | [**QuickPayProtocolV10AcquirerSettings**](QuickPayProtocolV10AcquirerSettings.md) | Acquirer settings | [optional] 
**AllowTestTransactions** | **bool?** | Allow test transactions | [optional] 
**Autofee** | **bool?** | Include acquirer fee on payments | [optional] 
**BillingAddress** | [**QuickPayProtocolV10Address**](QuickPayProtocolV10Address.md) | Billing address | [optional] 
**CallbackUrl** | **string** | Callback url | [optional] 
**ContactEmail** | **string** | Contact email | [optional] 
**CreatedAt** | **DateTime?** | Timestamp of creation | [optional] 
**CustomerAddress** | [**QuickPayProtocolV10Address**](QuickPayProtocolV10Address.md) | Customer address | [optional] 
**DefaultBrandingConfig** | **Object** | Default branding config | [optional] 
**DefaultBrandingId** | **int?** | Id of default branding, or null | [optional] 
**DefaultPaymentLanguage** | **string** | Default payment language (Two letter language code, ISO-639-1) | [optional] 
**DefaultPaymentMethods** | **string** | Comma separated list of default payment methods | [optional] 
**DefaultTextOnStatement** | **string** | Text to be displayed on cardholder&#39;s statement. Currently supported by Clearhaus only | [optional] 
**Id** | **int?** | ID | [optional] 
**IntegrationSettings** | [**QuickPayProtocolV10IntegrationSettings**](QuickPayProtocolV10IntegrationSettings.md) | Integration settings | [optional] 
**Locale** | **string** | Locale | [optional] 
**LoggingStopsAt** | **DateTime?** | Timestamp when logging is active  | [optional] 
**Pci** | [**QuickPayProtocolV10PciSettings**](QuickPayProtocolV10PciSettings.md) | PCI settings | [optional] 
**Reseller** | [**QuickPayProtocolV10MerchantReseller**](QuickPayProtocolV10MerchantReseller.md) | Reseller of Merchant | [optional] 
**ShopName** | **string** | Shop name | [optional] 
**ShopUrl** | **string** | Shop url (deprecated, use shop_urls instead) | [optional] 
**ShopUrls** | **List&lt;Object&gt;** | Shop urls | [optional] 
**Shopsystem** | **string** | Shop system | [optional] 
**SuspendedAt** | **DateTime?** | Timestamp when merchant was suspended or null if it is not suspended | [optional] 
**Timezone** | **string** | Timezone | [optional] 
**Type** | **string** | Type of account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

