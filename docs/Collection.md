# Com.Sajari.Sdk.Model.Collection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | Output only. The ID of the account that owns this collection. | [optional] [readonly] 
**AuthorizedQueryDomains** | **List&lt;string&gt;** | The list of authorized query domains for the collection.  Client-side / browser requests to the [QueryCollection](/docs/api#operation/QueryCollection) call can be made by any authorized query domain or any of its subdomains. This allows your interface to make search requests without having to provide an API key in the client-side request. | [optional] 
**CreateTime** | **DateTime** | Output only. Time the collection was created. | [optional] [readonly] 
**DisplayName** | **string** | The collection&#39;s display name. You can change this at any time. | 
**Id** | **string** | Output only. The collection&#39;s ID. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

