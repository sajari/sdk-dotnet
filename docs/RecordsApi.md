# Com.Sajari.Sdk.Api.RecordsApi

All URIs are relative to *https://api-gateway.sajari.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchUpsertRecords**](RecordsApi.md#batchupsertrecords) | **POST** /v4/collections/{collection_id}/records:batchUpsert | Batch upsert records
[**DeleteRecord**](RecordsApi.md#deleterecord) | **POST** /v4/collections/{collection_id}/records:delete | Delete record
[**GetRecord**](RecordsApi.md#getrecord) | **POST** /v4/collections/{collection_id}/records:get | Get record
[**UpsertRecord**](RecordsApi.md#upsertrecord) | **POST** /v4/collections/{collection_id}/records:upsert | Upsert record


<a name="batchupsertrecords"></a>
# **BatchUpsertRecords**
> BatchUpsertRecordsResponse BatchUpsertRecords (string collectionId, BatchUpsertRecordsRequest batchUpsertRecordsRequest)

Batch upsert records

The batch version of the [UpsertRecord](/api#operation/UpsertRecord) call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class BatchUpsertRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-gateway.sajari.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordsApi(config);
            var collectionId = collectionId_example;  // string | The collection to upsert the records in, e.g. `my-collection`.
            var batchUpsertRecordsRequest = new BatchUpsertRecordsRequest(); // BatchUpsertRecordsRequest | 

            try
            {
                // Batch upsert records
                BatchUpsertRecordsResponse result = apiInstance.BatchUpsertRecords(collectionId, batchUpsertRecordsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordsApi.BatchUpsertRecords: " + e.Message );
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
 **collectionId** | **string**| The collection to upsert the records in, e.g. &#x60;my-collection&#x60;. | 
 **batchUpsertRecordsRequest** | [**BatchUpsertRecordsRequest**](BatchUpsertRecordsRequest.md)|  | 

### Return type

[**BatchUpsertRecordsResponse**](BatchUpsertRecordsResponse.md)

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
| **0** | An unexpected error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterecord"></a>
# **DeleteRecord**
> Object DeleteRecord (string collectionId, DeleteRecordRequest deleteRecordRequest)

Delete record

Delete a record with the given key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class DeleteRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-gateway.sajari.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordsApi(config);
            var collectionId = collectionId_example;  // string | The collection that contains the record to delete, e.g. `my-collection`.
            var deleteRecordRequest = new DeleteRecordRequest(); // DeleteRecordRequest | 

            try
            {
                // Delete record
                Object result = apiInstance.DeleteRecord(collectionId, deleteRecordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordsApi.DeleteRecord: " + e.Message );
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
 **collectionId** | **string**| The collection that contains the record to delete, e.g. &#x60;my-collection&#x60;. | 
 **deleteRecordRequest** | [**DeleteRecordRequest**](DeleteRecordRequest.md)|  | 

### Return type

**Object**

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
| **0** | An unexpected error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecord"></a>
# **GetRecord**
> Object GetRecord (string collectionId, GetRecordRequest getRecordRequest)

Get record

Retrieve a record with the given key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class GetRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-gateway.sajari.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordsApi(config);
            var collectionId = collectionId_example;  // string | The collection that contains the record to retrieve, e.g. `my-collection`.
            var getRecordRequest = new GetRecordRequest(); // GetRecordRequest | 

            try
            {
                // Get record
                Object result = apiInstance.GetRecord(collectionId, getRecordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordsApi.GetRecord: " + e.Message );
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
 **collectionId** | **string**| The collection that contains the record to retrieve, e.g. &#x60;my-collection&#x60;. | 
 **getRecordRequest** | [**GetRecordRequest**](GetRecordRequest.md)|  | 

### Return type

**Object**

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
| **0** | An unexpected error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertrecord"></a>
# **UpsertRecord**
> UpsertRecordResponse UpsertRecord (string collectionId, UpsertRecordRequest upsertRecordRequest)

Upsert record

If the record does not exist in your collection it is inserted. If it does exist it is updated.  If no pipeline is specified, the default record pipeline is used to process the record.  If the record is inserted, the response contains the key of the inserted record. You can use this if you need to retrieve or delete the record. If the record is updated, the response does not contain a key. Callers can use this as a signal to determine if the record is inserted/created or updated.  For example, to add a single product from your ecommerce store to a collection, use the following call:  ```json {   \"pipeline\": {     \"name\": \"my-pipeline\",     \"version\": \"1\"   },   \"record\": {     \"id\": \"54hdc7h2334h\",     \"name\": \"Smart TV\",     \"price\": 1999,     \"brand\": \"Acme\",     \"description\": \"...\",     \"in_stock\": true   } } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class UpsertRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-gateway.sajari.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordsApi(config);
            var collectionId = collectionId_example;  // string | The collection to upsert the record in, e.g. `my-collection`.
            var upsertRecordRequest = new UpsertRecordRequest(); // UpsertRecordRequest | 

            try
            {
                // Upsert record
                UpsertRecordResponse result = apiInstance.UpsertRecord(collectionId, upsertRecordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordsApi.UpsertRecord: " + e.Message );
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
 **collectionId** | **string**| The collection to upsert the record in, e.g. &#x60;my-collection&#x60;. | 
 **upsertRecordRequest** | [**UpsertRecordRequest**](UpsertRecordRequest.md)|  | 

### Return type

[**UpsertRecordResponse**](UpsertRecordResponse.md)

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
| **0** | An unexpected error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

