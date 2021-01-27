# Com.Sajari.Sdk.Model.PipelineStep
Step creates a pipeline step.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the step template. | 
**Title** | **string** | Title for the step. Overrides the default title. | [optional] 
**Description** | **string** | Description for the step. Overrides the default description. | [optional] 
**Params** | [**Dictionary&lt;string, PipelineStepParamBinding&gt;**](PipelineStepParamBinding.md) | Bindings for the step parameters. | [optional] 
**Condition** | **string** | Condition expression to determine if the step should be run.  This is a filter expression much like the query filter expression, but it acts upon the pipeline variables.  For example, to only run the step if the pipeline &#x60;q&#x60; variable is not empty, set this to &#x60;q !&#x3D; &#39;&#39;&#x60;. | [optional] 
**Annotations** | **List&lt;string&gt;** | Annotations added to the request when the step is run. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

