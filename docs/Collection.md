# Com.Sajari.Sdk.Model.Collection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Output only. The collection&#39;s ID. | [optional] [readonly] 
**AccountId** | **string** | Output only. The ID of the account that owns this collection. | [optional] [readonly] 
**CreateTime** | **DateTime** | Output only. Creation time of the collection. | [optional] [readonly] 
**DisplayName** | **string** | The collection&#39;s display name. You can change this at any time. | 
**AuthorizedQueryDomains** | **List&lt;string&gt;** | The list of authorized query domains for the collection.  Client-side / browser requests to the [QueryCollection](/api#operation/QueryCollection) call can be made by any authorized query domain or any of its subdomains. This allows your interface to make search requests without having to provide an API key in the client-side request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

