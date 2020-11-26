# IO.Swagger.Model.QuickPayProtocolV10Payout
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accepted** | **bool?** | Accepted by acquirer | [optional] 
**Acquirer** | **string** | Acquirer that processed the transaction | [optional] 
**Balance** | **int?** | Balance | [optional] 
**BrandingId** | **int?** | Branding id | 
**CreatedAt** | **DateTime?** | Timestamp of creation | [optional] 
**Currency** | **string** | Currency | [optional] 
**Facilitator** | **string** | Facilitator that facilitated the transaction | [optional] 
**Id** | **int?** | Id | [optional] 
**Link** | [**QuickPayProtocolV10PaymentLink**](QuickPayProtocolV10PaymentLink.md) | PaymentLink | [optional] 
**MerchantId** | **int?** | Merchant id | [optional] 
**Metadata** | [**QuickPayProtocolV10Metadata**](QuickPayProtocolV10Metadata.md) | Metadata | [optional] 
**Operations** | [**List&lt;QuickPayProtocolV10Operation&gt;**](QuickPayProtocolV10Operation.md) | Operations | [optional] 
**OrderId** | **string** | Order number | [optional] 
**RetentedAt** | **DateTime?** | Timestamp of retention | [optional] 
**State** | **string** | State of transaction | [optional] 
**TestMode** | **bool?** | Test mode | [optional] 
**TextOnStatement** | **string** | Text on statement | [optional] 
**Type** | **string** | transaction type | [optional] 
**UpdatedAt** | **DateTime?** | Timestamp of last updated | [optional] 
**Variables** | **Dictionary&lt;string, string&gt;** | Custom variables | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

