# Com.Sajari.Sdk.Api.PromotionsApi

All URIs are relative to *https://api.search.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePromotion**](PromotionsApi.md#createpromotion) | **POST** /v4/collections/{collection_id}/promotions | Create promotion
[**DeletePromotion**](PromotionsApi.md#deletepromotion) | **DELETE** /v4/collections/{collection_id}/promotions/{promotion_id} | Delete promotion
[**GetPromotion**](PromotionsApi.md#getpromotion) | **GET** /v4/collections/{collection_id}/promotions/{promotion_id} | Get promotion
[**ListPromotions**](PromotionsApi.md#listpromotions) | **GET** /v4/collections/{collection_id}/promotions | List promotions
[**UpdatePromotion**](PromotionsApi.md#updatepromotion) | **PATCH** /v4/collections/{collection_id}/promotions/{promotion_id} | Update promotion


<a name="createpromotion"></a>
# **CreatePromotion**
> Promotion CreatePromotion (string collectionId, Promotion promotion, string accountId = null)

Create promotion

Create a new promotion in a collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class CreatePromotionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PromotionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection to create a promotion in, e.g. `my-collection`.
            var promotion = new Promotion(); // Promotion | The promotion to create.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 

            try
            {
                // Create promotion
                Promotion result = apiInstance.CreatePromotion(collectionId, promotion, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.CreatePromotion: " + e.Message );
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
 **collectionId** | **string**| The collection to create a promotion in, e.g. &#x60;my-collection&#x60;. | 
 **promotion** | [**Promotion**](Promotion.md)| The promotion to create. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 

### Return type

[**Promotion**](Promotion.md)

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

<a name="deletepromotion"></a>
# **DeletePromotion**
> Object DeletePromotion (string collectionId, string promotionId, string accountId = null)

Delete promotion

Delete a promotion and all of its associated data.  > Note: This operation cannot be reversed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class DeletePromotionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PromotionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection the promotion belongs to, e.g. `my-collection`.
            var promotionId = "promotionId_example";  // string | The promotion to delete, e.g. `1234`.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 

            try
            {
                // Delete promotion
                Object result = apiInstance.DeletePromotion(collectionId, promotionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.DeletePromotion: " + e.Message );
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
 **collectionId** | **string**| The collection the promotion belongs to, e.g. &#x60;my-collection&#x60;. | 
 **promotionId** | **string**| The promotion to delete, e.g. &#x60;1234&#x60;. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 

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
| **404** | Returned when the promotion was not found. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpromotion"></a>
# **GetPromotion**
> Promotion GetPromotion (string collectionId, string promotionId, string accountId = null)

Get promotion

Retrieve the details of a promotion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class GetPromotionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PromotionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns the promotion, e.g. `my-collection`.
            var promotionId = "promotionId_example";  // string | The promotion to retrieve, e.g. `1234`.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 

            try
            {
                // Get promotion
                Promotion result = apiInstance.GetPromotion(collectionId, promotionId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.GetPromotion: " + e.Message );
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
 **collectionId** | **string**| The collection that owns the promotion, e.g. &#x60;my-collection&#x60;. | 
 **promotionId** | **string**| The promotion to retrieve, e.g. &#x60;1234&#x60;. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 

### Return type

[**Promotion**](Promotion.md)

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

<a name="listpromotions"></a>
# **ListPromotions**
> ListPromotionsResponse ListPromotions (string collectionId, string accountId = null, int? pageSize = null, string pageToken = null, string view = null)

List promotions

Retrieve a list of promotions in a collection.  Promotion pins, exclusions and filter boosts are not returned in this call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class ListPromotionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PromotionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection that owns this set of promotions, e.g. `my-collection`.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 
            var pageSize = 56;  // int? | The maximum number of promotions to return. The service may return fewer than this value.  If unspecified, at most 50 promotions are returned.  The maximum value is 1000; values above 1000 are coerced to 1000. (optional) 
            var pageToken = "pageToken_example";  // string | A page token, received from a previous [ListPromotions](/docs/api#operation/ListPromotions) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListPromotions](/docs/api#operation/ListPromotions) must match the call that provided the page token. (optional) 
            var view = "PROMOTION_VIEW_UNSPECIFIED";  // string | The amount of information to include in each retrieved promotion.   - PROMOTION_VIEW_UNSPECIFIED: The default / unset value. The API defaults to the `FULL` view.  - BASIC: Include basic information including name, start time and end time, but not detailed information about the promotion effects.  - FULL: Returns all information about a promotion. This is the default value. (optional)  (default to PROMOTION_VIEW_UNSPECIFIED)

            try
            {
                // List promotions
                ListPromotionsResponse result = apiInstance.ListPromotions(collectionId, accountId, pageSize, pageToken, view);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ListPromotions: " + e.Message );
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
 **collectionId** | **string**| The collection that owns this set of promotions, e.g. &#x60;my-collection&#x60;. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 
 **pageSize** | **int?**| The maximum number of promotions to return. The service may return fewer than this value.  If unspecified, at most 50 promotions are returned.  The maximum value is 1000; values above 1000 are coerced to 1000. | [optional] 
 **pageToken** | **string**| A page token, received from a previous [ListPromotions](/docs/api#operation/ListPromotions) call.  Provide this to retrieve the subsequent page.  When paginating, all other parameters provided to [ListPromotions](/docs/api#operation/ListPromotions) must match the call that provided the page token. | [optional] 
 **view** | **string**| The amount of information to include in each retrieved promotion.   - PROMOTION_VIEW_UNSPECIFIED: The default / unset value. The API defaults to the &#x60;FULL&#x60; view.  - BASIC: Include basic information including name, start time and end time, but not detailed information about the promotion effects.  - FULL: Returns all information about a promotion. This is the default value. | [optional] [default to PROMOTION_VIEW_UNSPECIFIED]

### Return type

[**ListPromotionsResponse**](ListPromotionsResponse.md)

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

<a name="updatepromotion"></a>
# **UpdatePromotion**
> Promotion UpdatePromotion (string collectionId, string promotionId, string updateMask, Promotion promotion, string accountId = null)

Update promotion

Update the details of a promotion.  Pass each field that you want to update in the request body. Also specify the name of each field that you want to update in the `update_mask` in the request URL query string. Separate multiple fields with a comma. Fields included in the request body, but not included in the field mask are not updated.  For example, to update the `display_name` and `start_time` fields, make a `PATCH` request to the URL:  ``` /v4/collections/{collection_id}/promotions/{promotion_id}?update_mask=display_name,start_time ```  With the JSON body:  ``` {   \"display_name\": \"new value\",   \"start_time\": \"2006-01-02T15:04:05Z07:00\",   \"end_time\": \"2006-01-02T15:04:05Z07:00\" } ```  > Note: In this example `end_time` is not updated because it is not specified in the `update_mask`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class UpdatePromotionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PromotionsApi(config);
            var collectionId = "collectionId_example";  // string | The collection the promotion belongs to, e.g. `my-collection`.
            var promotionId = "promotionId_example";  // string | The promotion to update, e.g. `1234`.
            var updateMask = "updateMask_example";  // string | The list of fields to be updated, separated by a comma, e.g. `field1,field2`.  Each field should be in snake case, e.g. `display_name`, `filter_boosts`.  For each field that you want to update, provide a corresponding value in the promotion object containing the new value.
            var promotion = new Promotion(); // Promotion | Details of the promotion to update.
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`. (optional) 

            try
            {
                // Update promotion
                Promotion result = apiInstance.UpdatePromotion(collectionId, promotionId, updateMask, promotion, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.UpdatePromotion: " + e.Message );
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
 **collectionId** | **string**| The collection the promotion belongs to, e.g. &#x60;my-collection&#x60;. | 
 **promotionId** | **string**| The promotion to update, e.g. &#x60;1234&#x60;. | 
 **updateMask** | **string**| The list of fields to be updated, separated by a comma, e.g. &#x60;field1,field2&#x60;.  Each field should be in snake case, e.g. &#x60;display_name&#x60;, &#x60;filter_boosts&#x60;.  For each field that you want to update, provide a corresponding value in the promotion object containing the new value. | 
 **promotion** | [**Promotion**](Promotion.md)| Details of the promotion to update. | 
 **accountId** | **string**| The account that owns the collection, e.g. &#x60;1618535966441231024&#x60;. | [optional] 

### Return type

[**Promotion**](Promotion.md)

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
| **404** | Returned when the promotion was not found. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

