# Com.Sajari.Sdk.Model.Promotion
Promotion contains a trigger, determining which searches it should be active for, and a list of alterations that should be made to search results when it is active.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Banners** | [**List&lt;Banner&gt;**](Banner.md) | The banners that are injected into the result set when the promotion is triggered. | [optional] 
**CollectionId** | **string** | Output only. The ID of the collection that owns this promotion. | [optional] [readonly] 
**Condition** | **string** | A condition expression applied to a search request that determines which searches the promotion is active for.  For example, to apply the promotion&#39;s pins and boosts whenever a user searches for &#39;shoes&#39; set condition to &#x60;q &#x3D; &#39;shoes&#39;&#x60;. | 
**CreateTime** | **DateTime** | Output only. Time the promotion was created. | [optional] [readonly] 
**Disabled** | **bool** | If disabled, the promotion is never triggered. | [optional] 
**DisplayName** | **string** | The promotion&#39;s display name. | 
**EndTime** | **DateTime** | If specified, the promotion is considered disabled after this time. | [optional] 
**Exclusions** | [**List&lt;PromotionExclusion&gt;**](PromotionExclusion.md) | The records to exclude from search results, if the promotion is enabled. | [optional] 
**FilterBoosts** | [**List&lt;PromotionFilterBoost&gt;**](PromotionFilterBoost.md) | The filter boosts to apply to searches, if the promotion is enabled. | [optional] 
**FilterConditions** | [**List&lt;PromotionFilterCondition&gt;**](PromotionFilterCondition.md) | The conditions applied to the filters passed from the user. A query must match at least one of these in order to trigger the promotion. | [optional] 
**Id** | **string** | The promotion&#39;s ID. | [optional] 
**Pins** | [**List&lt;PromotionPin&gt;**](PromotionPin.md) | The items to fix to specific positions in the search results. | [optional] 
**RangeBoosts** | [**List&lt;PromotionRangeBoost&gt;**](PromotionRangeBoost.md) | The range boosts to apply to searches, if the promotion is enabled. | [optional] 
**StartTime** | **DateTime** | If specified, the promotion is considered disabled before this time. | [optional] 
**UpdateTime** | **DateTime** | Output only. Time the promotion was last updated. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

