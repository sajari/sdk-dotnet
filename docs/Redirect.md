# Com.Sajari.Sdk.Model.Redirect
Redirect contains a target that you can redirect users to if their search query matches a certain condition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionId** | **string** | Output only. The ID of the collection that owns this redirect. | [optional] [readonly] 
**Condition** | **string** | A condition expression applied to a search request that determines whether a search is redirected.  For example, to redirect if the user&#39;s query is &#x60;apples&#x60;, set condition to &#x60;q &#x3D; &#39;apples&#39;&#x60;. | 
**CreateTime** | **DateTime** | Output only. Time the redirect was created. | [optional] [readonly] 
**Disabled** | **bool** | If disabled, the redirect is never triggered. | [optional] 
**Id** | **string** | Output only. The redirect&#39;s ID. | [optional] [readonly] 
**Target** | **string** | The target to redirect the user to if their query matches &#x60;condition&#x60;.  For searches performed in a browser, target is usually a URL but it can be any value that your integration can interpret as a redirect.  For example, for URLs that you need to resolve at runtime, target might be a URL template string. For apps, target might be a unique identifier used to send the user to the correct view. | 
**UpdateTime** | **DateTime** | Output only. Time the redirect was last updated. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

