# Com.Sajari.Sdk.Api.SchemaApi

All URIs are relative to *https://api.search.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchCreateSchemaFields**](SchemaApi.md#batchcreateschemafields) | **POST** /v4/collections/{collection_id}/schemaFields:batchCreate | Batch create schema fields
[**CreateSchemaField**](SchemaApi.md#createschemafield) | **POST** /v4/collections/{collection_id}/schemaFields | Create schema field
[**DeleteSchemaField**](SchemaApi.md#deleteschemafield) | **DELETE** /v4/collections/{collection_id}/schemaFields/{schema_field_name} | Delete schema field
[**ListSchemaFields**](SchemaApi.md#listschemafields) | **GET** /v4/collections/{collection_id}/schemaFields | List schema fields
[**UpdateSchemaField**](SchemaApi.md#updateschemafield) | **PATCH** /v4/collections/{collection_id}/schemaFields/{schema_field_name} | Update schema field


<a name="batchcreateschemafields"></a>
# **BatchCreateSchemaFields**
> BatchCreateSchemaFieldsResponse BatchCreateSchemaFields (string collectionId, BatchCreateSchemaFieldsRequest batchCreateSchemaFieldsRequest)

Batch create schema fields

The batch version of the [CreateSchemaField](/docs/api#operation/CreateSchemaField) call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class BatchCreateSchemaFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SchemaApi(config);
            var collectionId = "collectionId_example";  // string | The collection to create the schema fields in, e.g. `my-collection`.
            var batchCreateSchemaFieldsRequest = new BatchCreateSchemaFieldsRequest(); // BatchCreateSchemaFieldsRequest | 

            try
            {
                // Batch create schema fields
                BatchCreateSchemaFieldsResponse result = apiInstance.BatchCreateSchemaFields(collectionId, batchCreateSchemaFieldsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.BatchCreateSchemaFields: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection to create the schema fields in, e.g. &#x60;my-collection&#x60;. | 
 **batchCreateSchemaFieldsRequest** | [**BatchCreateSchemaFieldsRequest**](BatchCreateSchemaFieldsRequest.md)|  | 

### Return type

[**BatchCreateSchemaFieldsResponse**](BatchCreateSchemaFieldsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the resource does not exist. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createschemafield"></a>
# **CreateSchemaField**
> SchemaField CreateSchemaField (string collectionId, SchemaField schemaField)

Create schema field

Create a new field in a collection's schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class CreateSchemaFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SchemaApi(config);
            var collectionId = "collectionId_example";  // string | The collection to create a schema field in, e.g. `my-collection`.
            var schemaField = new SchemaField(); // SchemaField | The schema field to create.

            try
            {
                // Create schema field
                SchemaField result = apiInstance.CreateSchemaField(collectionId, schemaField);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.CreateSchemaField: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection to create a schema field in, e.g. &#x60;my-collection&#x60;. | 
 **schemaField** | [**SchemaField**](SchemaField.md)| The schema field to create. | 

### Return type

[**SchemaField**](SchemaField.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the resource does not exist. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteschemafield"></a>
# **DeleteSchemaField**
> Object DeleteSchemaField (string collectionId, string schemaFieldName)

Delete schema field

Deleting a schema field removes it from all records within the collection, however, references to the schema field in pipelines are not removed.  > Note: This operation cannot be reversed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class DeleteSchemaFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SchemaApi(config);
            var collectionId = "collectionId_example";  // string | The collection the schema field belongs to, e.g. `my-collection`.
            var schemaFieldName = "schemaFieldName_example";  // string | The name of the schema field to delete.

            try
            {
                // Delete schema field
                Object result = apiInstance.DeleteSchemaField(collectionId, schemaFieldName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.DeleteSchemaField: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection the schema field belongs to, e.g. &#x60;my-collection&#x60;. | 
 **schemaFieldName** | **string**| The name of the schema field to delete. | 

### Return type

**Object**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the resource does not exist. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listschemafields"></a>
# **ListSchemaFields**
> ListSchemaFieldsResponse ListSchemaFields (string collectionId, int? pageSize = null, string pageToken = null)

List schema fields

Retrieve a list of schema fields in a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class ListSchemaFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SchemaApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns this set of schema fields, e.g. `my-collection`.
            var pageSize = 56;  // int? | The maximum number of schema fields to return. The service may return fewer than this value.  If unspecified, at most 50 schema fields are returned.  The maximum value is 1000; values above 1000 are coerced to 1000. (optional) 
            var pageToken = "pageToken_example";  // string | A page token, received from a previous [ListSchemaFields](/docs/api#operation/ListSchemaFields) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListSchemaFields](/docs/api#operation/ListSchemaFields) must match the call that provided the page token. (optional) 

            try
            {
                // List schema fields
                ListSchemaFieldsResponse result = apiInstance.ListSchemaFields(collectionId, pageSize, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.ListSchemaFields: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection that owns this set of schema fields, e.g. &#x60;my-collection&#x60;. | 
 **pageSize** | **int?**| The maximum number of schema fields to return. The service may return fewer than this value.  If unspecified, at most 50 schema fields are returned.  The maximum value is 1000; values above 1000 are coerced to 1000. | [optional] 
 **pageToken** | **string**| A page token, received from a previous [ListSchemaFields](/docs/api#operation/ListSchemaFields) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListSchemaFields](/docs/api#operation/ListSchemaFields) must match the call that provided the page token. | [optional] 

### Return type

[**ListSchemaFieldsResponse**](ListSchemaFieldsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the resource does not exist. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateschemafield"></a>
# **UpdateSchemaField**
> SchemaField UpdateSchemaField (string collectionId, string schemaFieldName, SchemaField schemaField, string updateMask = null)

Update schema field

Update the details of a schema field.  Only `name` and `description` can be updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class UpdateSchemaFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SchemaApi(config);
            var collectionId = "collectionId_example";  // string | The collection the schema field belongs to, e.g. `my-collection`.
            var schemaFieldName = "schemaFieldName_example";  // string | The name of the schema field to update.
            var schemaField = new SchemaField(); // SchemaField | The schema field details to update.
            var updateMask = "updateMask_example";  // string | The list of fields to update, separated by a comma, e.g. `name,description`.  Each field should be in snake case.  For each field that you want to update, provide a corresponding value in the schema field object containing the new value. (optional) 

            try
            {
                // Update schema field
                SchemaField result = apiInstance.UpdateSchemaField(collectionId, schemaFieldName, schemaField, updateMask);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.UpdateSchemaField: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection the schema field belongs to, e.g. &#x60;my-collection&#x60;. | 
 **schemaFieldName** | **string**| The name of the schema field to update. | 
 **schemaField** | [**SchemaField**](SchemaField.md)| The schema field details to update. | 
 **updateMask** | **string**| The list of fields to update, separated by a comma, e.g. &#x60;name,description&#x60;.  Each field should be in snake case.  For each field that you want to update, provide a corresponding value in the schema field object containing the new value. | [optional] 

### Return type

[**SchemaField**](SchemaField.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the resource does not exist. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

