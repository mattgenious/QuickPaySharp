# IO.Swagger.Model.AcquirerSettingsMobilePaySubscriptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | True if the acquirer is active | [optional] 
**AuthState** | **string** | Identifier MobilePay Subscriptions uses to link requests to callbacks | [optional] 
**CodeVerifier** | **string** | Verifies received code challenge | [optional] 
**LastTokenRefresh** | **int?** | Unix-timestamp of last time token was refreshed | [optional] 
**Nonce** | **string** | Associate client sessions with ID Tokens to mitigate replay attacks | [optional] 
**PendingStatus** | **int?** | 0: agreement inactive, 1: flow initialised, 2: tokens received, 3: flow completed | [optional] 
**Provider** | **Object** | The MobilePay Subscriptions provider / sales-place chosen by the merchant | [optional] 
**RefreshToken** | **string** | Token to refresh access token for up to 1 year | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

