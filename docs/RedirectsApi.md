# Com.Sajari.Sdk.Api.RedirectsApi

All URIs are relative to *https://api.search.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRedirect**](RedirectsApi.md#createredirect) | **POST** /v4/collections/{collection_id}/redirects | Create redirect
[**DeleteRedirect**](RedirectsApi.md#deleteredirect) | **DELETE** /v4/collections/{collection_id}/redirects/{redirect_id} | Delete redirect
[**GetRedirect**](RedirectsApi.md#getredirect) | **GET** /v4/collections/{collection_id}/redirects/{redirect_id} | Get redirect
[**ListRedirects**](RedirectsApi.md#listredirects) | **GET** /v4/collections/{collection_id}/redirects | List redirects
[**UpdateRedirect**](RedirectsApi.md#updateredirect) | **PATCH** /v4/collections/{collection_id}/redirects/{redirect_id} | Update redirect


<a name="createredirect"></a>
# **CreateRedirect**
> Redirect CreateRedirect (string collectionId, Redirect redirect)

Create redirect

Create a new redirect in a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class CreateRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RedirectsApi(config);
            var collectionId = "collectionId_example";  // string | The collection to create a redirect in, e.g. `my-collection`.
            var redirect = new Redirect(); // Redirect | The redirect to create.

            try
            {
                // Create redirect
                Redirect result = apiInstance.CreateRedirect(collectionId, redirect);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.CreateRedirect: " + e.Message );
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
 **collectionId** | **string**| The collection to create a redirect in, e.g. &#x60;my-collection&#x60;. | 
 **redirect** | [**Redirect**](Redirect.md)| The redirect to create. | 

### Return type

[**Redirect**](Redirect.md)

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

<a name="deleteredirect"></a>
# **DeleteRedirect**
> Object DeleteRedirect (string collectionId, string redirectId)

Delete redirect

Delete a redirect and all of its associated data.  > Note: This operation cannot be reversed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class DeleteRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RedirectsApi(config);
            var collectionId = "collectionId_example";  // string | The collection the redirect belongs to, e.g. `my-collection`.
            var redirectId = "redirectId_example";  // string | The redirect to delete, e.g. `1234`.

            try
            {
                // Delete redirect
                Object result = apiInstance.DeleteRedirect(collectionId, redirectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.DeleteRedirect: " + e.Message );
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
 **collectionId** | **string**| The collection the redirect belongs to, e.g. &#x60;my-collection&#x60;. | 
 **redirectId** | **string**| The redirect to delete, e.g. &#x60;1234&#x60;. | 

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
| **404** | Returned when the redirect was not found. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getredirect"></a>
# **GetRedirect**
> Redirect GetRedirect (string collectionId, string redirectId)

Get redirect

Retrieve the details of a redirect.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class GetRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RedirectsApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns the redirect, e.g. `my-collection`.
            var redirectId = "redirectId_example";  // string | The redirect to retrieve, e.g. `1234`.

            try
            {
                // Get redirect
                Redirect result = apiInstance.GetRedirect(collectionId, redirectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.GetRedirect: " + e.Message );
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
 **collectionId** | **string**| The collection that owns the redirect, e.g. &#x60;my-collection&#x60;. | 
 **redirectId** | **string**| The redirect to retrieve, e.g. &#x60;1234&#x60;. | 

### Return type

[**Redirect**](Redirect.md)

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

<a name="listredirects"></a>
# **ListRedirects**
> ListRedirectsResponse ListRedirects (string collectionId, int? pageSize = null, string pageToken = null)

List redirects

Retrieve a list of redirects in a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class ListRedirectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RedirectsApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns this set of redirects, e.g. `my-collection`.
            var pageSize = 56;  // int? | The maximum number of redirects to return. The service may return fewer than this value.  If unspecified, at most 50 redirects are returned.  The maximum value is 1000; values above 1000 are coerced to 1000. (optional) 
            var pageToken = "pageToken_example";  // string | A page token, received from a previous [ListRedirects](/docs/api#operation/ListRedirects) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListRedirects](/docs/api#operation/ListRedirects) must match the call that provided the page token. (optional) 

            try
            {
                // List redirects
                ListRedirectsResponse result = apiInstance.ListRedirects(collectionId, pageSize, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.ListRedirects: " + e.Message );
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
 **collectionId** | **string**| The collection that owns this set of redirects, e.g. &#x60;my-collection&#x60;. | 
 **pageSize** | **int?**| The maximum number of redirects to return. The service may return fewer than this value.  If unspecified, at most 50 redirects are returned.  The maximum value is 1000; values above 1000 are coerced to 1000. | [optional] 
 **pageToken** | **string**| A page token, received from a previous [ListRedirects](/docs/api#operation/ListRedirects) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListRedirects](/docs/api#operation/ListRedirects) must match the call that provided the page token. | [optional] 

### Return type

[**ListRedirectsResponse**](ListRedirectsResponse.md)

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

<a name="updateredirect"></a>
# **UpdateRedirect**
> Redirect UpdateRedirect (string collectionId, string redirectId, string updateMask, Redirect redirect)

Update redirect

Update the details of a redirect.  Pass each field that you want to update in the request body. Also specify the name of each field that you want to update in the `update_mask` in the request URL query string. Separate multiple fields with a comma. Fields included in the request body, but not included in the field mask are not updated.  For example, to update the `condition` field, make a `PATCH` request to the URL:  ``` /v4/collections/{collection_id}/redirects/{redirect_id}?update_mask=condition ```  With the JSON body:  ``` {   \"condition\": \"new value\",   \"target\": \"...\" } ```  > Note: In this example `target` is not updated because it is not specified in the `update_mask`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class UpdateRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RedirectsApi(config);
            var collectionId = "collectionId_example";  // string | The collection the redirect belongs to, e.g. `my-collection`.
            var redirectId = "redirectId_example";  // string | The redirect to update, e.g. `1234`.
            var updateMask = "updateMask_example";  // string | The list of fields to be updated, separated by a comma, e.g. `field1,field2`.  Each field should be in snake case, e.g. `condition`, `target`.  For each field that you want to update, provide a corresponding value in the redirect object containing the new value.
            var redirect = new Redirect(); // Redirect | Details of the redirect to update.

            try
            {
                // Update redirect
                Redirect result = apiInstance.UpdateRedirect(collectionId, redirectId, updateMask, redirect);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.UpdateRedirect: " + e.Message );
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
 **collectionId** | **string**| The collection the redirect belongs to, e.g. &#x60;my-collection&#x60;. | 
 **redirectId** | **string**| The redirect to update, e.g. &#x60;1234&#x60;. | 
 **updateMask** | **string**| The list of fields to be updated, separated by a comma, e.g. &#x60;field1,field2&#x60;.  Each field should be in snake case, e.g. &#x60;condition&#x60;, &#x60;target&#x60;.  For each field that you want to update, provide a corresponding value in the redirect object containing the new value. | 
 **redirect** | [**Redirect**](Redirect.md)| Details of the redirect to update. | 

### Return type

[**Redirect**](Redirect.md)

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
| **404** | Returned when the redirect was not found. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

