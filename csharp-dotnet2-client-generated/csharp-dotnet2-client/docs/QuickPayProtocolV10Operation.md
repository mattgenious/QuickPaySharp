# IO.Swagger.Model.QuickPayProtocolV10Operation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_3dSecureStatus** | **string** | 3D Secure status | [optional] 
**Acquirer** | **string** | Acquirer that processed this operation | [optional] 
**Amount** | **int?** | Amount | [optional] 
**AqStatusCode** | **string** | Acquirer status code | [optional] 
**AqStatusMsg** | **string** | Acquirer status message | [optional] 
**CallbackAt** | **DateTime?** | Timestamp of callback | [optional] 
**CallbackDuration** | **int?** | Callback duration (ms) | [optional] 
**CallbackResponseCode** | **bool?** | The http response code from the callback operation | [optional] 
**CallbackSuccess** | **bool?** | Did the callback succeed | [optional] 
**CallbackUrl** | **string** | Operation callback url | [optional] 
**CreatedAt** | **DateTime?** | Timestamp of creation | [optional] 
**Data** | **Dictionary&lt;string, string&gt;** | Acquirer specific data | [optional] 
**Id** | **int?** | Operation ID | [optional] 
**Pending** | **bool?** | If the operation is pending | [optional] 
**QpStatusCode** | **string** | QuickPay status code | [optional] 
**QpStatusMsg** | **string** | QuickPay status message | [optional] 
**Type** | **string** | Type of operation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

