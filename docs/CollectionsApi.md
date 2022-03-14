# Com.Sajari.Sdk.Api.CollectionsApi

All URIs are relative to *https://api.search.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCollection**](CollectionsApi.md#createcollection) | **POST** /v4/collections | Create collection
[**DeleteCollection**](CollectionsApi.md#deletecollection) | **DELETE** /v4/collections/{collection_id} | Delete collection
[**Experiment**](CollectionsApi.md#experiment) | **POST** /v4/collections/{collection_id}:experiment | Experiment
[**GetCollection**](CollectionsApi.md#getcollection) | **GET** /v4/collections/{collection_id} | Get collection
[**ListCollections**](CollectionsApi.md#listcollections) | **GET** /v4/collections | List collections
[**QueryCollection**](CollectionsApi.md#querycollection) | **POST** /v4/collections/{collection_id}:query | Query collection
[**QueryCollection2**](CollectionsApi.md#querycollection2) | **POST** /v4/collections/{collection_id}:queryCollection | Query collection
[**TrackEvent**](CollectionsApi.md#trackevent) | **POST** /v4/collections/{collection_id}:trackEvent | Track event
[**UpdateCollection**](CollectionsApi.md#updatecollection) | **PATCH** /v4/collections/{collection_id} | Update collection


<a name="createcollection"></a>
# **CreateCollection**
> Collection CreateCollection (string collectionId, Collection collection)

Create collection

Create an empty collection.  Before records can be added to a collection, the schema and pipelines for the collection have to be set up. Consider setting up new collections via the Search.io Console, which handles the creation of the schema and pipelines for you.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var collectionId = "collectionId_example";  // string | The ID to use for the collection.  This must start with an alphanumeric character followed by one or more alphanumeric or `-` characters. Strictly speaking, it must match the regular expression: `^[A-Za-z][A-Za-z0-9\\-]*$`.
            var collection = new Collection(); // Collection | Details of the collection to create.

            try
            {
                // Create collection
                Collection result = apiInstance.CreateCollection(collectionId, collection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateCollection: " + e.Message );
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
 **collectionId** | **string**| The ID to use for the collection.  This must start with an alphanumeric character followed by one or more alphanumeric or &#x60;-&#x60; characters. Strictly speaking, it must match the regular expression: &#x60;^[A-Za-z][A-Za-z0-9\\-]*$&#x60;. | 
 **collection** | [**Collection**](Collection.md)| Details of the collection to create. | 

### Return type

**Collection**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **400** | Returned when the request contains violations for one or more fields. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the resource does not exist. |  -  |
| **409** | Returned when the collection already exists. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollection"></a>
# **DeleteCollection**
> Object DeleteCollection (string collectionId)

Delete collection

Delete a collection and all of its associated data.  > Note: This operation cannot be reversed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection to delete, e.g. `my-collection`.

            try
            {
                // Delete collection
                Object result = apiInstance.DeleteCollection(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteCollection: " + e.Message );
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
 **collectionId** | **string**| The collection to delete, e.g. &#x60;my-collection&#x60;. | 

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
| **404** | Returned when the collection was not found. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="experiment"></a>
# **Experiment**
> ExperimentResponse Experiment (string collectionId, ExperimentRequest experimentRequest)

Experiment

Run a query on a collection with a hypothetical configuration to see what kinds of results it produces.  Saved promotions with a start date in the future are enabled during the experiment, unless they are explicitly disabled.  The following example demonstrates how to run a simple experiment for a string, against a pipeline and with a proposed promotion:  ```json {   \"pipeline\": { \"name\": \"my-pipeline\" },   \"variables\": { \"q\": \"search terms\" },   \"promotions\": [{     \"id\": \"1234\",     \"condition\": \"q = 'search terms'\",     \"pins\": [{       \"key\": { \"field\": \"id\", \"value\": \"54hdc7h2334h\" },       \"position\": 1     }]   }] } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class ExperimentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection to query, e.g. `my-collection`.
            var experimentRequest = new ExperimentRequest(); // ExperimentRequest | 

            try
            {
                // Experiment
                ExperimentResponse result = apiInstance.Experiment(collectionId, experimentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.Experiment: " + e.Message );
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
 **collectionId** | **string**| The collection to query, e.g. &#x60;my-collection&#x60;. | 
 **experimentRequest** | [**ExperimentRequest**](ExperimentRequest.md)|  | 

### Return type

[**ExperimentResponse**](ExperimentResponse.md)

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

<a name="getcollection"></a>
# **GetCollection**
> Collection GetCollection (string collectionId)

Get collection

Retrieve the details of a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class GetCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection to retrieve, e.g. `my-collection`.

            try
            {
                // Get collection
                Collection result = apiInstance.GetCollection(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetCollection: " + e.Message );
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
 **collectionId** | **string**| The collection to retrieve, e.g. &#x60;my-collection&#x60;. | 

### Return type

**Collection**

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

<a name="listcollections"></a>
# **ListCollections**
> ListCollectionsResponse ListCollections (int? pageSize = null, string pageToken = null)

List collections

Retrieve a list of collections in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class ListCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var pageSize = 56;  // int? | The maximum number of collections to return. The service may return fewer than this value.  If unspecified, at most 50 collections are returned.  The maximum value is 100; values above 100 are coerced to 100. (optional) 
            var pageToken = "pageToken_example";  // string | A page token, received from a previous [ListCollections](/docs/api#operation/ListCollections) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListCollections](/docs/api#operation/ListCollections) must match the call that provided the page token. (optional) 

            try
            {
                // List collections
                ListCollectionsResponse result = apiInstance.ListCollections(pageSize, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListCollections: " + e.Message );
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
 **pageSize** | **int?**| The maximum number of collections to return. The service may return fewer than this value.  If unspecified, at most 50 collections are returned.  The maximum value is 100; values above 100 are coerced to 100. | [optional] 
 **pageToken** | **string**| A page token, received from a previous [ListCollections](/docs/api#operation/ListCollections) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListCollections](/docs/api#operation/ListCollections) must match the call that provided the page token. | [optional] 

### Return type

[**ListCollectionsResponse**](ListCollectionsResponse.md)

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

<a name="querycollection"></a>
# **QueryCollection**
> QueryCollectionResponse QueryCollection (string collectionId, QueryCollectionRequest queryCollectionRequest, string accountId = null)

Query collection

Query the collection to search for records.  The following example demonstrates how to run a simple search for a particular string:  ```json {   \"variables\": { \"q\": \"search terms\" } } ```  For more information:  - See [filtering content](https://docs.search.io/documentation/fundamentals/integrating-search/filters-and-sort-options) - See [tracking in the Go SDK](https://github.com/sajari/sdk-go/blob/v2/session.go) - See [tracking in the JS SDK](https://github.com/sajari/sdk-js/blob/554e182e77d3ba99a9c100b208ebf3be414d2067/src/index.ts#L881)  Note: Unlike other API calls, the `QueryCollection` call can be called from a browser. When called from a browser, the `Account-Id` header must be set to your account ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class QueryCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection to query, e.g. `my-collection`.
            var queryCollectionRequest = new QueryCollectionRequest(); // QueryCollectionRequest | 
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`.  Unlike other API calls, the `QueryCollection` call can be called from a browser. When called from a browser, the `Account-Id` header must be set to your account ID. (optional) 

            try
            {
                // Query collection
                QueryCollectionResponse result = apiInstance.QueryCollection(collectionId, queryCollectionRequest, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.QueryCollection: " + e.Message );
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
 **collectionId** | **string**| The collection to query, e.g. &#x60;my-collection&#x60;. | 
 **queryCollectionRequest** | [**QueryCollectionRequest**](QueryCollectionRequest.md)|  | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;.  Unlike other API calls, the &#x60;QueryCollection&#x60; call can be called from a browser. When called from a browser, the &#x60;Account-Id&#x60; header must be set to your account ID. | [optional] 

### Return type

[**QueryCollectionResponse**](QueryCollectionResponse.md)

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

<a name="querycollection2"></a>
# **QueryCollection2**
> QueryCollectionResponse QueryCollection2 (string collectionId, QueryCollectionRequest queryCollectionRequest)

Query collection

Query the collection to search for records.  The following example demonstrates how to run a simple search for a particular string:  ```json {   \"variables\": { \"q\": \"search terms\" } } ```  For more information:  - See [filtering content](https://docs.search.io/documentation/fundamentals/integrating-search/filters-and-sort-options) - See [tracking in the Go SDK](https://github.com/sajari/sdk-go/blob/v2/session.go) - See [tracking in the JS SDK](https://github.com/sajari/sdk-js/blob/554e182e77d3ba99a9c100b208ebf3be414d2067/src/index.ts#L881)  Note: Unlike other API calls, the `QueryCollection` call can be called from a browser. When called from a browser, the `Account-Id` header must be set to your account ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class QueryCollection2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection to query, e.g. `my-collection`.
            var queryCollectionRequest = new QueryCollectionRequest(); // QueryCollectionRequest | 

            try
            {
                // Query collection
                QueryCollectionResponse result = apiInstance.QueryCollection2(collectionId, queryCollectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.QueryCollection2: " + e.Message );
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
 **collectionId** | **string**| The collection to query, e.g. &#x60;my-collection&#x60;. | 
 **queryCollectionRequest** | [**QueryCollectionRequest**](QueryCollectionRequest.md)|  | 

### Return type

[**QueryCollectionResponse**](QueryCollectionResponse.md)

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

<a name="trackevent"></a>
# **TrackEvent**
> Object TrackEvent (string accountId, string collectionId, Event _event)

Track event

Track an analytics event when a user interacts with an object returned by a [QueryCollection](/docs/api/#operation/QueryCollection) request.  An analytics event can be tracked for the following objects:  - Results - Promotion banners - Redirects  Note: You must pass an `Account-Id` header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class TrackEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`.
            var collectionId = "collectionId_example";  // string | The collection to track the event against, e.g. `my-collection`.
            var _event = new Event(); // Event | The details of the event to track.

            try
            {
                // Track event
                Object result = apiInstance.TrackEvent(accountId, collectionId, _event);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.TrackEvent: " + e.Message );
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
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | 
 **collectionId** | **string**| The collection to track the event against, e.g. &#x60;my-collection&#x60;. | 
 **_event** | [**Event**](Event.md)| The details of the event to track. | 

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
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecollection"></a>
# **UpdateCollection**
> Collection UpdateCollection (string collectionId, Collection collection, string updateMask = null)

Update collection

Update the details of a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class UpdateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection to update, e.g. `my-collection`.
            var collection = new Collection(); // Collection | The details of the collection to update.
            var updateMask = "updateMask_example";  // string | The list of fields to update, separated by a comma, e.g. `authorized_query_domains,display_name`.  Each field should be in snake case.  For each field that you want to update, provide a corresponding value in the collection object containing the new value. (optional) 

            try
            {
                // Update collection
                Collection result = apiInstance.UpdateCollection(collectionId, collection, updateMask);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.UpdateCollection: " + e.Message );
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
 **collectionId** | **string**| The collection to update, e.g. &#x60;my-collection&#x60;. | 
 **collection** | [**Collection**](Collection.md)| The details of the collection to update. | 
 **updateMask** | **string**| The list of fields to update, separated by a comma, e.g. &#x60;authorized_query_domains,display_name&#x60;.  Each field should be in snake case.  For each field that you want to update, provide a corresponding value in the collection object containing the new value. | [optional] 

### Return type

**Collection**

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
| **404** | Returned when the collection was not found. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

