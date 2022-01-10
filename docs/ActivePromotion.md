# Com.Sajari.Sdk.Model.ActivePromotion
ActivePromotion is a promotion that is active for a given search.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveExclusions** | [**List&lt;PromotionExclusion&gt;**](PromotionExclusion.md) | The records that are excluded from the result set by the active promotion. | [optional] 
**ActivePins** | [**List&lt;PromotionPin&gt;**](PromotionPin.md) | The pins that belong to the active promotion. Note that the positions in these pins are the positions specified at pin creation time, which is not necessarily the position that a pin ends up in. For example, if a pin is created at position 2, but the query that the pin is active in has zero results, the pinned result actually appears in position 1. | [optional] 
**PromotionId** | **string** | The ID of the active promotion. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

