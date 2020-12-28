# IO.Swagger.Model.FraudRuleset
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The action that happens if this ruleset is triggered (nothing, flag, force_3d or block) | [optional] 
**Combinator** | **string** | The method used to combine filter rules (and, or) | [optional] 
**FilterRules** | [**List&lt;FraudFilterRule&gt;**](FraudFilterRule.md) | The rules of the ruleset | [optional] 
**Id** | **int?** | Unique id | [optional] 
**MerchantId** | **int?** | Owner of the ruleset | [optional] 
**Name** | **string** | Descriptive name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

