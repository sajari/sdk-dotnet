# Com.Sajari.Sdk.Model.QueryCollectionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivePromotions** | [**List&lt;ActivePromotion&gt;**](ActivePromotion.md) | A list of the promotions activated when running the query. | [optional] 
**AggregateFilters** | [**Dictionary&lt;string, QueryAggregateResult&gt;**](QueryAggregateResult.md) | The aggregates run with filters. | [optional] 
**Aggregates** | [**Dictionary&lt;string, QueryAggregateResult&gt;**](QueryAggregateResult.md) | The aggregates returned by the query. | [optional] 
**Banners** | [**List&lt;Banner&gt;**](Banner.md) | Banners associated with this query. | [optional] 
**FeatureScoreWeight** | **double** | The weight applied to the features in the query, used for analyzing the index, neural and feature components for results.  For each result:  &#x60;&#x60;&#x60; score &#x3D; max(index_score, neural_score) * (1 - feature_score_weight) +         feature_score * feature_score_weight &#x60;&#x60;&#x60; | [optional] 
**Pipeline** | [**QueryCollectionResponsePipeline**](QueryCollectionResponsePipeline.md) |  | [optional] 
**ProcessingDuration** | **string** | The total time taken to perform the query. | [optional] 
**QueryId** | **string** | The query identifier.  This uniqely identifies the specific query it was returned on. This is used to link user interactions with a query. | [optional] 
**Redirects** | [**Dictionary&lt;string, RedirectResult&gt;**](RedirectResult.md) | A mapping of redirects triggered for all possible variations of the query. | [optional] 
**Results** | [**List&lt;QueryResult&gt;**](QueryResult.md) | The results returned by the query. | [optional] 
**TotalSize** | **string** | The total number of results that match the query. | [optional] 
**Variables** | **Dictionary&lt;string, Object&gt;** | The modified variables returned by the pipeline after it has finished processing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

