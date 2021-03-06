# IO.Swagger.Model.Subscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accepted** | **bool?** | Accepted by acquirer | [optional] 
**Acquirer** | **string** | Acquirer that processed the transaction | [optional] 
**Basket** | [**Basket**](Basket.md) | Order items | [optional] 
**BrandingId** | **int?** | Branding id | 
**CreatedAt** | **DateTime?** | Timestamp of creation | [optional] 
**Currency** | **string** | Currency | [optional] 
**DeadlineAt** | **DateTime?** | Authorize deadline | [optional] 
**Description** | **string** | Description | [optional] 
**Facilitator** | **string** | Facilitator that facilitated the transaction | [optional] 
**GroupIds** | **List&lt;int?&gt;** | Ids of subscription groups | [optional] 
**Id** | **int?** | Id | [optional] 
**InvoiceAddress** | [**OptionalAddress**](OptionalAddress.md) | Invoice address set on payment creation | [optional] 
**Link** | [**PaymentLink**](PaymentLink.md) | PaymentLink | [optional] 
**MerchantId** | **int?** | Merchant id | [optional] 
**Metadata** | [**Metadata**](Metadata.md) | Metadata | [optional] 
**Operations** | [**List&lt;Operation&gt;**](Operation.md) | Operations | [optional] 
**OrderId** | **string** | Order number | [optional] 
**RetentedAt** | **DateTime?** | Timestamp of retention | [optional] 
**Shipping** | [**Shipping**](Shipping.md) | Shipping | [optional] 
**ShippingAddress** | [**OptionalAddress**](OptionalAddress.md) | Shipping address set on payment creation | [optional] 
**State** | **string** | State of transaction | [optional] 
**TestMode** | **bool?** | Test mode | [optional] 
**TextOnStatement** | **string** | Text on statement | [optional] 
**Type** | **string** | transaction type | [optional] 
**UpdatedAt** | **DateTime?** | Timestamp of last updated | [optional] 
**Variables** | **Dictionary&lt;string, string&gt;** | Custom variables | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

