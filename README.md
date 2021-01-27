# Com.Sajari.Sdk - the C# library for the Sajari API

Sajari is a smart, highly-configurable, real-time search service that enables thousands of businesses worldwide to provide amazing search experiences on their websites, stores, and applications.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v4
- SDK version: 4.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.sajari.com/company/contact](https://www.sajari.com/company/contact)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.4 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.7.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api-gateway.sajari.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CollectionsApi(config);
            var collectionId = collectionId_example;  // string | The ID to use for the collection.  This must start with an alphanumeric character followed by one or more alphanumeric or `-` characters. Strictly speaking, it must match the regular expression: `^[A-Za-z][A-Za-z0-9\\-]*$`.
            var collection = new Collection(); // Collection | Details of the collection to create.

            try
            {
                // Create collection
                Collection result = apiInstance.CreateCollection(collectionId, collection);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateCollection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api-gateway.sajari.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CollectionsApi* | [**CreateCollection**](docs/CollectionsApi.md#createcollection) | **POST** /v4/collections | Create collection
*CollectionsApi* | [**DeleteCollection**](docs/CollectionsApi.md#deletecollection) | **DELETE** /v4/collections/{collection_id} | Delete collection
*CollectionsApi* | [**GetCollection**](docs/CollectionsApi.md#getcollection) | **GET** /v4/collections/{collection_id} | Get collection
*CollectionsApi* | [**ListCollections**](docs/CollectionsApi.md#listcollections) | **GET** /v4/collections | List collections
*CollectionsApi* | [**QueryCollection**](docs/CollectionsApi.md#querycollection) | **POST** /v4/collections/{collection_id}:queryCollection | Query collection
*CollectionsApi* | [**UpdateCollection**](docs/CollectionsApi.md#updatecollection) | **PATCH** /v4/collections/{collection_id} | Update collection
*PipelinesApi* | [**CreatePipeline**](docs/PipelinesApi.md#createpipeline) | **POST** /v4/collections/{collection_id}/pipelines | Create pipeline
*PipelinesApi* | [**GeneratePipelines**](docs/PipelinesApi.md#generatepipelines) | **POST** /v4/collections/{collection_id}:generatePipelines | Generate pipelines
*PipelinesApi* | [**GetDefaultPipeline**](docs/PipelinesApi.md#getdefaultpipeline) | **GET** /v4/collections/{collection_id}:getDefaultPipeline | Get default pipeline
*PipelinesApi* | [**GetDefaultVersion**](docs/PipelinesApi.md#getdefaultversion) | **GET** /v4/collections/{collection_id}/pipelines/{type}/{name}:getDefaultVersion | Get default pipeline version
*PipelinesApi* | [**GetPipeline**](docs/PipelinesApi.md#getpipeline) | **GET** /v4/collections/{collection_id}/pipelines/{type}/{name}/{version} | Get pipeline
*PipelinesApi* | [**ListPipelines**](docs/PipelinesApi.md#listpipelines) | **GET** /v4/collections/{collection_id}/pipelines | List pipelines
*PipelinesApi* | [**SetDefaultPipeline**](docs/PipelinesApi.md#setdefaultpipeline) | **POST** /v4/collections/{collection_id}:setDefaultPipeline | Set default pipeline
*PipelinesApi* | [**SetDefaultVersion**](docs/PipelinesApi.md#setdefaultversion) | **POST** /v4/collections/{collection_id}/pipelines/{type}/{name}:setDefaultVersion | Set default pipeline version
*RecordsApi* | [**BatchUpsertRecords**](docs/RecordsApi.md#batchupsertrecords) | **POST** /v4/collections/{collection_id}/records:batchUpsert | Batch upsert records
*RecordsApi* | [**DeleteRecord**](docs/RecordsApi.md#deleterecord) | **POST** /v4/collections/{collection_id}/records:delete | Delete record
*RecordsApi* | [**GetRecord**](docs/RecordsApi.md#getrecord) | **POST** /v4/collections/{collection_id}/records:get | Get record
*RecordsApi* | [**UpsertRecord**](docs/RecordsApi.md#upsertrecord) | **POST** /v4/collections/{collection_id}/records:upsert | Upsert record
*SchemaApi* | [**BatchCreateSchemaFields**](docs/SchemaApi.md#batchcreateschemafields) | **POST** /v4/collections/{collection_id}/schemaFields:batchCreate | Batch create schema fields
*SchemaApi* | [**CreateSchemaField**](docs/SchemaApi.md#createschemafield) | **POST** /v4/collections/{collection_id}/schemaFields | Create schema field
*SchemaApi* | [**ListSchemaFields**](docs/SchemaApi.md#listschemafields) | **GET** /v4/collections/{collection_id}/schemaFields | List schema fields


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BatchCreateSchemaFieldsRequest](docs/BatchCreateSchemaFieldsRequest.md)
 - [Model.BatchCreateSchemaFieldsResponse](docs/BatchCreateSchemaFieldsResponse.md)
 - [Model.BatchCreateSchemaFieldsResponseError](docs/BatchCreateSchemaFieldsResponseError.md)
 - [Model.BatchUpsertRecordsRequest](docs/BatchUpsertRecordsRequest.md)
 - [Model.BatchUpsertRecordsRequestPipeline](docs/BatchUpsertRecordsRequestPipeline.md)
 - [Model.BatchUpsertRecordsResponse](docs/BatchUpsertRecordsResponse.md)
 - [Model.BatchUpsertRecordsResponseError](docs/BatchUpsertRecordsResponseError.md)
 - [Model.BatchUpsertRecordsResponseKey](docs/BatchUpsertRecordsResponseKey.md)
 - [Model.BatchUpsertRecordsResponseVariables](docs/BatchUpsertRecordsResponseVariables.md)
 - [Model.Collection](docs/Collection.md)
 - [Model.DeleteRecordRequest](docs/DeleteRecordRequest.md)
 - [Model.Error](docs/Error.md)
 - [Model.GeneratePipelinesRequest](docs/GeneratePipelinesRequest.md)
 - [Model.GeneratePipelinesResponse](docs/GeneratePipelinesResponse.md)
 - [Model.GetDefaultPipelineResponse](docs/GetDefaultPipelineResponse.md)
 - [Model.GetDefaultVersionRequestView](docs/GetDefaultVersionRequestView.md)
 - [Model.GetPipelineRequestView](docs/GetPipelineRequestView.md)
 - [Model.GetRecordRequest](docs/GetRecordRequest.md)
 - [Model.ListCollectionsResponse](docs/ListCollectionsResponse.md)
 - [Model.ListPipelinesRequestView](docs/ListPipelinesRequestView.md)
 - [Model.ListPipelinesResponse](docs/ListPipelinesResponse.md)
 - [Model.ListSchemaFieldsResponse](docs/ListSchemaFieldsResponse.md)
 - [Model.Pipeline](docs/Pipeline.md)
 - [Model.PipelineStep](docs/PipelineStep.md)
 - [Model.PipelineStepParamBinding](docs/PipelineStepParamBinding.md)
 - [Model.PipelineType](docs/PipelineType.md)
 - [Model.ProtobufAny](docs/ProtobufAny.md)
 - [Model.ProtobufNullValue](docs/ProtobufNullValue.md)
 - [Model.QueryAggregateResult](docs/QueryAggregateResult.md)
 - [Model.QueryAggregateResultAnalysis](docs/QueryAggregateResultAnalysis.md)
 - [Model.QueryAggregateResultBuckets](docs/QueryAggregateResultBuckets.md)
 - [Model.QueryAggregateResultBucketsBucket](docs/QueryAggregateResultBucketsBucket.md)
 - [Model.QueryAggregateResultCount](docs/QueryAggregateResultCount.md)
 - [Model.QueryAggregateResultDate](docs/QueryAggregateResultDate.md)
 - [Model.QueryAggregateResultMetric](docs/QueryAggregateResultMetric.md)
 - [Model.QueryCollectionRequest](docs/QueryCollectionRequest.md)
 - [Model.QueryCollectionRequestPipeline](docs/QueryCollectionRequestPipeline.md)
 - [Model.QueryCollectionRequestTracking](docs/QueryCollectionRequestTracking.md)
 - [Model.QueryCollectionRequestTrackingType](docs/QueryCollectionRequestTrackingType.md)
 - [Model.QueryCollectionResponse](docs/QueryCollectionResponse.md)
 - [Model.QueryCollectionResponsePipeline](docs/QueryCollectionResponsePipeline.md)
 - [Model.QueryResult](docs/QueryResult.md)
 - [Model.QueryResultToken](docs/QueryResultToken.md)
 - [Model.QueryResultTokenClick](docs/QueryResultTokenClick.md)
 - [Model.QueryResultTokenPosNeg](docs/QueryResultTokenPosNeg.md)
 - [Model.RecordKey](docs/RecordKey.md)
 - [Model.SchemaField](docs/SchemaField.md)
 - [Model.SchemaFieldMode](docs/SchemaFieldMode.md)
 - [Model.SchemaFieldType](docs/SchemaFieldType.md)
 - [Model.SetDefaultPipelineRequest](docs/SetDefaultPipelineRequest.md)
 - [Model.SetDefaultVersionRequest](docs/SetDefaultVersionRequest.md)
 - [Model.Status](docs/Status.md)
 - [Model.UpsertRecordRequest](docs/UpsertRecordRequest.md)
 - [Model.UpsertRecordRequestPipeline](docs/UpsertRecordRequestPipeline.md)
 - [Model.UpsertRecordResponse](docs/UpsertRecordResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="BasicAuth"></a>
### BasicAuth

- **Type**: HTTP basic authentication

