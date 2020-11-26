# IO.Swagger.Model.QuickPayProtocolV10Card
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accepted** | **bool?** | Accepted by acquirer | [optional] 
**Acquirer** | **string** | Acquirer that processed the card | [optional] 
**CreatedAt** | **DateTime?** | Timestamp of creation | [optional] 
**Id** | **int?** | Card id | [optional] 
**Link** | [**QuickPayProtocolV10CardLink**](QuickPayProtocolV10CardLink.md) | Sharable link to payment window | [optional] 
**MerchantId** | **int?** | Merchant id | [optional] 
**Metadata** | [**QuickPayProtocolV10Metadata**](QuickPayProtocolV10Metadata.md) | Card metadata | [optional] 
**Operations** | [**List&lt;QuickPayProtocolV10CardOperation&gt;**](QuickPayProtocolV10CardOperation.md) | Operations | [optional] 
**TestMode** | **bool?** | Test mode | [optional] 
**Type** | **string** | Type of transaction | [optional] 
**Variables** | **Dictionary&lt;string, string&gt;** | Custom variables | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

