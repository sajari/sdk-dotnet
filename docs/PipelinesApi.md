# Com.Sajari.Sdk.Api.PipelinesApi

All URIs are relative to *https://api.search.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePipeline**](PipelinesApi.md#createpipeline) | **POST** /v4/collections/{collection_id}/pipelines | Create pipeline
[**GeneratePipelines**](PipelinesApi.md#generatepipelines) | **POST** /v4/collections/{collection_id}:generatePipelines | Generate pipelines
[**GetDefaultPipeline**](PipelinesApi.md#getdefaultpipeline) | **GET** /v4/collections/{collection_id}:getDefaultPipeline | Get default pipeline
[**GetDefaultVersion**](PipelinesApi.md#getdefaultversion) | **GET** /v4/collections/{collection_id}/pipelines/{type}/{name}:getDefaultVersion | Get default pipeline version
[**GetPipeline**](PipelinesApi.md#getpipeline) | **GET** /v4/collections/{collection_id}/pipelines/{type}/{name}/{version} | Get pipeline
[**ListPipelines**](PipelinesApi.md#listpipelines) | **GET** /v4/collections/{collection_id}/pipelines | List pipelines
[**SetDefaultPipeline**](PipelinesApi.md#setdefaultpipeline) | **POST** /v4/collections/{collection_id}:setDefaultPipeline | Set default pipeline
[**SetDefaultVersion**](PipelinesApi.md#setdefaultversion) | **POST** /v4/collections/{collection_id}/pipelines/{type}/{name}:setDefaultVersion | Set default pipeline version


<a name="createpipeline"></a>
# **CreatePipeline**
> Pipeline CreatePipeline (string collectionId, Pipeline pipeline, string accountId = null)

Create pipeline

Create a new pipeline.  Pipelines are immutable once created. If you want to change a pipeline e.g. to add or change some steps, you need to create a new version of that pipeline.  To start using a new pipeline you need to update your record ingestion calls and/or your query calls to specify the new pipeline.  To create the pipeline from YAML, set the request's `Content-Type` header to `application/yaml` and submit the pipeline's YAML in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class CreatePipelineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PipelinesApi(config);
            var collectionId = "collectionId_example";  // string | The collection to create the pipeline in, e.g. `my-collection`.
            var pipeline = new Pipeline(); // Pipeline | The pipeline to create.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 

            try
            {
                // Create pipeline
                Pipeline result = apiInstance.CreatePipeline(collectionId, pipeline, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.CreatePipeline: " + e.Message );
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
 **collectionId** | **string**| The collection to create the pipeline in, e.g. &#x60;my-collection&#x60;. | 
 **pipeline** | [**Pipeline**](Pipeline.md)| The pipeline to create. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 

### Return type

[**Pipeline**](Pipeline.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml
 - **Accept**: application/json, application/yaml


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

<a name="generatepipelines"></a>
# **GeneratePipelines**
> GeneratePipelinesResponse GeneratePipelines (string collectionId, GeneratePipelinesRequest generatePipelinesRequest)

Generate pipelines

Generate basic record, query and autocomplete pipeline templates. Use these templates as a starting point for your collection's pipelines.  This call returns a set of pipelines that you can pass directly to the create pipeline call.  The generated templates can be returned in JSON, the default, or YAML. To return the generated pipelines in YAML, set the request's `Accept` header to `application/yaml`. The three pipelines in the YAML response are separated by three dashes (`- --`).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class GeneratePipelinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PipelinesApi(config);
            var collectionId = "collectionId_example";  // string | The collection, e.g. `my-collection`.
            var generatePipelinesRequest = new GeneratePipelinesRequest(); // GeneratePipelinesRequest | 

            try
            {
                // Generate pipelines
                GeneratePipelinesResponse result = apiInstance.GeneratePipelines(collectionId, generatePipelinesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.GeneratePipelines: " + e.Message );
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
 **collectionId** | **string**| The collection, e.g. &#x60;my-collection&#x60;. | 
 **generatePipelinesRequest** | [**GeneratePipelinesRequest**](GeneratePipelinesRequest.md)|  | 

### Return type

[**GeneratePipelinesResponse**](GeneratePipelinesResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/yaml


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

<a name="getdefaultpipeline"></a>
# **GetDefaultPipeline**
> GetDefaultPipelineResponse GetDefaultPipeline (string collectionId, string type)

Get default pipeline

Get the default pipeline for a collection.  Every collection has a default record pipeline and a default query pipeline.  When a pipeline is required to complete an operation, it can be omitted from the request if a default pipeline has been set. When adding a record to a collection, the default record pipeline is used if none is provided. When querying a collection, the default query pipeline is used if none is provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class GetDefaultPipelineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PipelinesApi(config);
            var collectionId = "collectionId_example";  // string | The collection to get the default query pipeline of, e.g. `my-collection`.
            var type = "TYPE_UNSPECIFIED";  // string | The type of the pipeline to get.   - TYPE_UNSPECIFIED: Pipeline type not specified.  - RECORD: Record pipeline.  - QUERY: Query pipeline. (default to TYPE_UNSPECIFIED)

            try
            {
                // Get default pipeline
                GetDefaultPipelineResponse result = apiInstance.GetDefaultPipeline(collectionId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.GetDefaultPipeline: " + e.Message );
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
 **collectionId** | **string**| The collection to get the default query pipeline of, e.g. &#x60;my-collection&#x60;. | 
 **type** | **string**| The type of the pipeline to get.   - TYPE_UNSPECIFIED: Pipeline type not specified.  - RECORD: Record pipeline.  - QUERY: Query pipeline. | [default to TYPE_UNSPECIFIED]

### Return type

[**GetDefaultPipelineResponse**](GetDefaultPipelineResponse.md)

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

<a name="getdefaultversion"></a>
# **GetDefaultVersion**
> Pipeline GetDefaultVersion (string collectionId, string type, string name, string accountId = null, string view = null)

Get default pipeline version

Get the default version for a given pipeline.  The default version of a pipeline is used when a pipeline is referred to without specifying a version.  This allows you to change the pipeline version used for requests without having to change your code.  To retrieve the pipeline in YAML, set the request's `Accept` header to `application/yaml`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class GetDefaultVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PipelinesApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns the pipeline to get the default version of, e.g. `my-collection`.
            var type = "TYPE_UNSPECIFIED";  // string | The type of the pipeline to get the default version of.
            var name = "name_example";  // string | The name of the pipeline to get the default version of, e.g. `my-pipeline`.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 
            var view = "VIEW_UNSPECIFIED";  // string | The amount of information to include in the retrieved pipeline.   - VIEW_UNSPECIFIED: The default / unset value. The API defaults to the `BASIC` view.  - BASIC: Include basic information including type, name, version and description but not the full step configuration. This is the default value (for both [ListPipelines](/docs/api#operation/ListPipelines) and [GetPipeline](/docs/api#operation/GetPipeline)).  - FULL: Include the information from `BASIC`, plus full step configuration. (optional)  (default to VIEW_UNSPECIFIED)

            try
            {
                // Get default pipeline version
                Pipeline result = apiInstance.GetDefaultVersion(collectionId, type, name, accountId, view);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.GetDefaultVersion: " + e.Message );
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
 **collectionId** | **string**| The collection that owns the pipeline to get the default version of, e.g. &#x60;my-collection&#x60;. | 
 **type** | **string**| The type of the pipeline to get the default version of. | 
 **name** | **string**| The name of the pipeline to get the default version of, e.g. &#x60;my-pipeline&#x60;. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 
 **view** | **string**| The amount of information to include in the retrieved pipeline.   - VIEW_UNSPECIFIED: The default / unset value. The API defaults to the &#x60;BASIC&#x60; view.  - BASIC: Include basic information including type, name, version and description but not the full step configuration. This is the default value (for both [ListPipelines](/docs/api#operation/ListPipelines) and [GetPipeline](/docs/api#operation/GetPipeline)).  - FULL: Include the information from &#x60;BASIC&#x60;, plus full step configuration. | [optional] [default to VIEW_UNSPECIFIED]

### Return type

[**Pipeline**](Pipeline.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/yaml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the pipeline does not have a default version. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpipeline"></a>
# **GetPipeline**
> Pipeline GetPipeline (string collectionId, string type, string name, string version, string accountId = null, string view = null)

Get pipeline

Retrieve the details of a pipeline. Supply the type, name and version.  To retrieve the pipeline in YAML, set the request's `Accept` header to `application/yaml`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class GetPipelineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PipelinesApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns the pipeline, e.g. `my-collection`.
            var type = "TYPE_UNSPECIFIED";  // string | The type of the pipeline to retrieve.
            var name = "name_example";  // string | The name of the pipeline to retrieve, e.g. `my-pipeline`.
            var version = "version_example";  // string | The version of the pipeline to retrieve, e.g. `42`.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 
            var view = "VIEW_UNSPECIFIED";  // string | The amount of information to include in the retrieved pipeline.   - VIEW_UNSPECIFIED: The default / unset value. The API defaults to the `BASIC` view.  - BASIC: Include basic information including type, name, version and description but not the full step configuration. This is the default value (for both [ListPipelines](/docs/api#operation/ListPipelines) and [GetPipeline](/docs/api#operation/GetPipeline)).  - FULL: Include the information from `BASIC`, plus full step configuration. (optional)  (default to VIEW_UNSPECIFIED)

            try
            {
                // Get pipeline
                Pipeline result = apiInstance.GetPipeline(collectionId, type, name, version, accountId, view);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.GetPipeline: " + e.Message );
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
 **collectionId** | **string**| The collection that owns the pipeline, e.g. &#x60;my-collection&#x60;. | 
 **type** | **string**| The type of the pipeline to retrieve. | 
 **name** | **string**| The name of the pipeline to retrieve, e.g. &#x60;my-pipeline&#x60;. | 
 **version** | **string**| The version of the pipeline to retrieve, e.g. &#x60;42&#x60;. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 
 **view** | **string**| The amount of information to include in the retrieved pipeline.   - VIEW_UNSPECIFIED: The default / unset value. The API defaults to the &#x60;BASIC&#x60; view.  - BASIC: Include basic information including type, name, version and description but not the full step configuration. This is the default value (for both [ListPipelines](/docs/api#operation/ListPipelines) and [GetPipeline](/docs/api#operation/GetPipeline)).  - FULL: Include the information from &#x60;BASIC&#x60;, plus full step configuration. | [optional] [default to VIEW_UNSPECIFIED]

### Return type

[**Pipeline**](Pipeline.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/yaml


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

<a name="listpipelines"></a>
# **ListPipelines**
> ListPipelinesResponse ListPipelines (string collectionId, string accountId = null, int? pageSize = null, string pageToken = null, string view = null)

List pipelines

Retrieve a list of pipelines in a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class ListPipelinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PipelinesApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns this set of pipelines, e.g. `my-collection`.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 
            var pageSize = 56;  // int? | The maximum number of pipelines to return. The service may return fewer than this value.  If unspecified, at most 50 pipelines are returned.  The maximum value is 1000; values above 1000 are coerced to 1000. (optional) 
            var pageToken = "pageToken_example";  // string | A page token, received from a previous [ListPipelines](/docs/api#operation/ListPipelines) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListPipelines](/docs/api#operation/ListPipelines) must match the call that provided the page token. (optional) 
            var view = "VIEW_UNSPECIFIED";  // string | The amount of information to include in each retrieved pipeline.   - VIEW_UNSPECIFIED: The default / unset value. The API defaults to the `BASIC` view.  - BASIC: Include basic information including type, name, version and description but not the full step configuration. This is the default value (for both [ListPipelines](/docs/api#operation/ListPipelines) and [GetPipeline](/docs/api#operation/GetPipeline)).  - FULL: Include the information from `BASIC`, plus full step configuration. (optional)  (default to VIEW_UNSPECIFIED)

            try
            {
                // List pipelines
                ListPipelinesResponse result = apiInstance.ListPipelines(collectionId, accountId, pageSize, pageToken, view);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.ListPipelines: " + e.Message );
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
 **collectionId** | **string**| The collection that owns this set of pipelines, e.g. &#x60;my-collection&#x60;. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 
 **pageSize** | **int?**| The maximum number of pipelines to return. The service may return fewer than this value.  If unspecified, at most 50 pipelines are returned.  The maximum value is 1000; values above 1000 are coerced to 1000. | [optional] 
 **pageToken** | **string**| A page token, received from a previous [ListPipelines](/docs/api#operation/ListPipelines) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListPipelines](/docs/api#operation/ListPipelines) must match the call that provided the page token. | [optional] 
 **view** | **string**| The amount of information to include in each retrieved pipeline.   - VIEW_UNSPECIFIED: The default / unset value. The API defaults to the &#x60;BASIC&#x60; view.  - BASIC: Include basic information including type, name, version and description but not the full step configuration. This is the default value (for both [ListPipelines](/docs/api#operation/ListPipelines) and [GetPipeline](/docs/api#operation/GetPipeline)).  - FULL: Include the information from &#x60;BASIC&#x60;, plus full step configuration. | [optional] [default to VIEW_UNSPECIFIED]

### Return type

[**ListPipelinesResponse**](ListPipelinesResponse.md)

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

<a name="setdefaultpipeline"></a>
# **SetDefaultPipeline**
> Object SetDefaultPipeline (string collectionId, SetDefaultPipelineRequest setDefaultPipelineRequest)

Set default pipeline

Set the default pipeline for a collection.  Every collection has a default record pipeline and a default query pipeline.  When a pipeline is required to complete an operation, it can be omitted from the request if a default pipeline has been set. When adding a record to a collection, the default record pipeline is used if none is provided. When querying a collection, the default query pipeline is used if none is provided.  Once a default pipeline has been set it cannot be cleared, only set to another pipeline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class SetDefaultPipelineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PipelinesApi(config);
            var collectionId = "collectionId_example";  // string | The collection to set the default query pipeline of, e.g. `my-collection`.
            var setDefaultPipelineRequest = new SetDefaultPipelineRequest(); // SetDefaultPipelineRequest | 

            try
            {
                // Set default pipeline
                Object result = apiInstance.SetDefaultPipeline(collectionId, setDefaultPipelineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.SetDefaultPipeline: " + e.Message );
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
 **collectionId** | **string**| The collection to set the default query pipeline of, e.g. &#x60;my-collection&#x60;. | 
 **setDefaultPipelineRequest** | [**SetDefaultPipelineRequest**](SetDefaultPipelineRequest.md)|  | 

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

<a name="setdefaultversion"></a>
# **SetDefaultVersion**
> Object SetDefaultVersion (string collectionId, string type, string name, SetDefaultVersionRequest setDefaultVersionRequest)

Set default pipeline version

Set the default version for a given pipeline.  The default version of a pipeline is used when a pipeline is referred to without specifying a version.  This allows you to change the pipeline version used for requests without having to change your code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class SetDefaultVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PipelinesApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns the pipeline to set the default version of, e.g. `my-collection`.
            var type = "TYPE_UNSPECIFIED";  // string | The type of the pipeline to set the default version of.
            var name = "name_example";  // string | The name of the pipeline to set the default version of, e.g. `my-pipeline`.
            var setDefaultVersionRequest = new SetDefaultVersionRequest(); // SetDefaultVersionRequest | 

            try
            {
                // Set default pipeline version
                Object result = apiInstance.SetDefaultVersion(collectionId, type, name, setDefaultVersionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PipelinesApi.SetDefaultVersion: " + e.Message );
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
 **collectionId** | **string**| The collection that owns the pipeline to set the default version of, e.g. &#x60;my-collection&#x60;. | 
 **type** | **string**| The type of the pipeline to set the default version of. | 
 **name** | **string**| The name of the pipeline to set the default version of, e.g. &#x60;my-pipeline&#x60;. | 
 **setDefaultVersionRequest** | [**SetDefaultVersionRequest**](SetDefaultVersionRequest.md)|  | 

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

