# IO.Swagger.Model.QuickPayProtocolV10Agreement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accepted** | **bool?** | Is agreement accepted by user | [optional] 
**Account** | [**QuickPayProtocolV10AgreementAccount**](QuickPayProtocolV10AgreementAccount.md) | Account details | [optional] 
**AclPermissions** | [**List&lt;QuickPayProtocolV10AclPermission&gt;**](QuickPayProtocolV10AclPermission.md) | ACL permissions | [optional] 
**ApiKey** | **string** | API key. This will show as null unless it is owned by your user or by a system user | [optional] 
**CreatedAt** | **DateTime?** | Timestamp of creation | [optional] 
**Description** | **string** | Description | [optional] 
**Id** | **int?** | ID | [optional] 
**IpRestriction** | [**List&lt;QuickPayProtocolV10IPRestriction&gt;**](QuickPayProtocolV10IPRestriction.md) | IP restriction | [optional] 
**Locked** | **bool?** | If true, the agreement can not be changed | [optional] 
**Owner** | **bool?** | Is account owner | [optional] 
**Service** | **string** | Service name (only for system/service agreements) | [optional] 
**Support** | **bool?** | Support agreement | [optional] 
**User** | [**QuickPayProtocolV10AgreementUser**](QuickPayProtocolV10AgreementUser.md) | User details | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

