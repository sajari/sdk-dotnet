# Com.Sajari.Sdk.Model.QueryResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Banner** | [**Banner**](Banner.md) |  | [optional] 
**FeatureScore** | **double** | The feature score of the result.  This is a value between 0 and 1 representing the business-specific ranking of the result as determined by the ranking adjustments. See [Ranking adjustments](https://docs.search.io/documentation/fundamentals/search-settings/ranking-adjustments) for more information. | [optional] 
**IndexScore** | **double** | The index score of the result.  This is a value between 0 and 1 representing the relevance of the result using traditional keyword search. The higher the score the more relevant the result is. | [optional] 
**NeuralScore** | **double** | The neural score of the result.  This is a value between 0 and 1 representing the relevance of the result using Neuralsearch®, using AI-based search. | [optional] 
**Record** | **Object** | An object made up of field-value pairs that contains the record data. | [optional] 
**RelevanceScore** | **double** | The relevance score of the result.  This is the best of &#x60;index_score&#x60; and &#x60;neural_score&#x60; with any index boosts applied on top. | [optional] 
**Score** | **double** | The overall relevance of the result.  This is a value between 0 and 1 that combines the index, neural and feature scores. The higher the score the more relevant the result is. | [optional] 
**Token** | [**QueryResultToken**](QueryResultToken.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

