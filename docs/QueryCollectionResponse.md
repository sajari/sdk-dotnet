# Com.Sajari.Sdk.Model.QueryCollectionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregateFilters** | [**Dictionary&lt;string, QueryAggregateResult&gt;**](QueryAggregateResult.md) | The aggregates run with filters. | [optional] 
**Aggregates** | [**Dictionary&lt;string, QueryAggregateResult&gt;**](QueryAggregateResult.md) | The aggregates returned by the query. | [optional] 
**Pipeline** | [**QueryCollectionResponsePipeline**](QueryCollectionResponsePipeline.md) |  | [optional] 
**ProcessingDuration** | **string** | The total time taken to perform the query. | [optional] 
**Results** | [**List&lt;QueryResult&gt;**](QueryResult.md) | The results returned by the query. | [optional] 
**TotalSize** | **string** | The total number of results that match the query. | [optional] 
**Variables** | **Dictionary&lt;string, Object&gt;** | The modified variables returned by the pipeline after it has finished processing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

