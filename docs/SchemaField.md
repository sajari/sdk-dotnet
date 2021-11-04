# Com.Sajari.Sdk.Model.SchemaField
SchemaField defines the properties of a field in the schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Array** | **bool** | Array indicates if the field is an array of values.  For example, if &#x60;type&#x60; is string and &#x60;array&#x60; is &#x60;true&#x60;, then the field is an array of strings. | [optional] 
**ArrayLength** | **int** | The required length of the array, if &#x60;array&#x60; is &#x60;true&#x60;.  This allows you to enforce that an array contains an exact number of items.  For example, to store a 2x2 vector, you could set &#x60;type&#x60; to float, &#x60;array&#x60; to &#x60;true&#x60; and &#x60;array_length&#x60; to &#x60;4&#x60;. | [optional] 
**Description** | **string** | The description of the field. | [optional] 
**Mode** | **SchemaFieldMode** |  | 
**Name** | **string** | The name of the field. | 
**Type** | **SchemaFieldType** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

