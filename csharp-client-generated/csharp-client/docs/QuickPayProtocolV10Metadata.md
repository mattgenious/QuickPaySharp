# IO.Swagger.Model.QuickPayProtocolV10Metadata
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bin** | **string** | Card type only: Card BIN | [optional] 
**Brand** | **string** | Card type only: The card brand | [optional] 
**Corporate** | **bool?** | Card type only: Corporate status | [optional] 
**Country** | **string** | Card type only: The card country in ISO 3166-1 alpha-3 | [optional] 
**CustomerCountry** | **string** | Customer country based on IP geo-data, ISO 3166-1 alpha-2 | [optional] 
**CustomerIp** | **string** | Customer IP | [optional] 
**ExpMonth** | **int?** | Card type only: The expiration month | [optional] 
**ExpYear** | **int?** | Card type only: The expiration year (YYYY) | [optional] 
**FraudRemarks** | **List&lt;string&gt;** | Fraud remarks | [optional] 
**FraudReportDescription** | **string** | Fraud report description | [optional] 
**FraudReported** | **bool?** | Reported as fraudulent | [optional] 
**FraudReportedAt** | **string** | Fraud report description | [optional] 
**FraudSuspected** | **bool?** | Suspected fraud | [optional] 
**Hash** | **string** | Card type only: PCI safe hash of card number | [optional] 
**Is3dSecure** | **string** | Card type only: Verified via 3D-Secure | [optional] 
**IssuedTo** | **string** | Name of cardholder | [optional] 
**Last4** | **string** | Card type only: The last 4 digits of the card number | [optional] 
**NinCountryCode** | **string** | NIN type only. NIN country code, ISO 3166-1 alpha-3 | [optional] 
**NinGender** | **string** | NIN type only. NIN gender | [optional] 
**NinNumber** | **string** | NIN type only. NIN number | [optional] 
**Number** | **string** | Mobile type only: The mobile number | [optional] 
**Origin** | **string** | Origin of this transaction or card. If set, describes where it came from. | [optional] 
**ShopsystemName** | **string** | Shop system module name | [optional] 
**ShopsystemVersion** | **string** | Shop system module version | [optional] 
**Type** | **string** | Type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

