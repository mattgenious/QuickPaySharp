# IO.Swagger.Model.PaymentLink
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Acquirer** | **string** | Force usage of this acquirer | [optional] 
**AgreementId** | **int?** | Id of agreement that will be used in the payment window | [optional] 
**Amount** | **int?** | Amount to authorize. | [optional] 
**AutoCapture** | **bool?** | If true, will capture the transaction after authorize succeeds | [optional] 
**AutoFee** | **bool?** | If true, will add acquirer fee to the amount | [optional] 
**BrandingConfig** | **Object** | Branding config | [optional] 
**BrandingId** | **int?** | The branding to use in the payment window | [optional] 
**CallbackUrl** | **string** | Endpoint for a POST callback | [optional] 
**CancelUrl** | **string** | Where cardholder is redirected after cancel | [optional] 
**ContinueUrl** | **string** | Where cardholder is redirected after success | [optional] 
**CustomerEmail** | **string** | PayPal specific: Customer email | [optional] 
**Deadline** | **string** | Deadline in seconds for the cardholder to complete | [optional] 
**Framed** | **bool?** | Allow in iframe | [optional] 
**GoogleAnalyticsClientId** | **string** | Set this to enable Google Analytics events from the payment window | [optional] 
**GoogleAnalyticsTrackingId** | **string** | Set this to enable Google Analytics events from the payment window | [optional] 
**InvoiceAddressSelection** | **bool?** | Get customer invoice address via acquirer (Currently MobilePay and PayPal only) | [optional] 
**Language** | **string** | Two letter language code that determines the language of the payment window | [optional] 
**PaymentMethods** | **string** | Lock to these payment methods | [optional] 
**ShippingAddressSelection** | **bool?** | Get customer shipping address via acquirer (Currently MobilePay and PayPal only) | [optional] 
**Url** | **string** | Url to payment window for this payment link | [optional] 
**Version** | **string** | Version of payment window and API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

