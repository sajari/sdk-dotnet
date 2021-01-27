# Com.Sajari.Sdk.Model.Pipeline
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateTime** | **DateTime** | Output only. Creation time of the pipeline. | [optional] [readonly] 
**Type** | **PipelineType** |  | 
**Name** | **string** | The pipeline&#39;s name.  Must start with an alphanumeric character followed by one or more alphanumeric, &#x60;_&#x60;, &#x60;-&#x60; or &#x60;.&#x60; characters. Strictly speaking, it must match the regular expression: &#x60;^[a-zA-Z0-9][a-zA-Z0-9_\\-\\.]+$&#x60;. | 
**Version** | **string** | The pipeline&#39;s version.  Must start with an alphanumeric character followed by one or more alphanumeric, &#x60;_&#x60;, &#x60;-&#x60; or &#x60;.&#x60; characters. Strictly speaking, it must match the regular expression: &#x60;^[a-zA-Z0-9][a-zA-Z0-9_\\-\\.]+$&#x60;. | 
**Description** | **string** | Description of the pipeline. | [optional] 
**PreSteps** | [**List&lt;PipelineStep&gt;**](PipelineStep.md) | Pre-steps are run before an indexing operation or query request is sent to the search index. | [optional] 
**PostSteps** | [**List&lt;PipelineStep&gt;**](PipelineStep.md) | Post-steps are run after an indexing operation or query request has been sent to the search index.  For indexing operations, the post-steps only run when creating new records. They do not run when updating records.  For querying, the post-steps have access to the result-set. This makes it possible to act on the results before sending them back to the caller. | [optional] 
**CollectionDefault** | **bool** | Output only. Indicates if the pipeline is the collection default pipeline. | [optional] [readonly] 
**DefaultVersion** | **bool** | Output only. Indicates if the pipeline is the default version. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

