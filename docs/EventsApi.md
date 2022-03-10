# Com.Sajari.Sdk.Api.EventsApi

All URIs are relative to *https://api.search.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendEvent**](EventsApi.md#sendevent) | **POST** /v4/events:send | Send event
[**SendEvent2**](EventsApi.md#sendevent2) | **POST** /v4/events:sendEvent | Send event


<a name="sendevent"></a>
# **SendEvent**
> Object SendEvent (string accountId, SendEventRequest sendEventRequest)

Send event

Send an event to the ranking system after a user interacts with a search result.  When querying a collection, you can set the tracking type of the query request. When it is `CLICK` or `POS_NEG`, a token is generated for each result in the query response. You can use this token to provide feedback to the ranking system. Each time you want to record an event on a particular search result, use the send event call and provide:  - The `name` of the event, e.g. `click`, `purchase`. - The `token` from the search result. - The `weight` to assign to the event, e.g. `1`. - An object containing any additional `metadata`.  For example, to send an event where a customer purchased a product, use the following call:  ```json {   \"name\": \"purchase\",   \"token\": \"eyJ...\",   \"weight\": 1,   \"metadata\": {     \"discount\": 0.2,     \"margin\": 30.0,     \"customer_id\": \"12345\",     \"ui_test_segment\": \"A\"   } } ```  Note: You must pass an `Account-Id` header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class SendEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new EventsApi(config);
            var accountId = "accountId_example";  // string | The account that owns the collection, e.g. `1618535966441231024`.
            var sendEventRequest = new SendEventRequest(); // SendEventRequest | 

            try
            {
                // Send event
                Object result = apiInstance.SendEvent(accountId, sendEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.SendEvent: " + e.Message );
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
 **sendEventRequest** | [**SendEventRequest**](SendEventRequest.md)|  | 

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
| **400** | Returned when the request contains violations for one or more fields. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the resource does not exist. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendevent2"></a>
# **SendEvent2**
> Object SendEvent2 (SendEventRequest sendEventRequest)

Send event

Send an event to the ranking system after a user interacts with a search result.  When querying a collection, you can set the tracking type of the query request. When it is `CLICK` or `POS_NEG`, a token is generated for each result in the query response. You can use this token to provide feedback to the ranking system. Each time you want to record an event on a particular search result, use the send event call and provide:  - The `name` of the event, e.g. `click`, `purchase`. - The `token` from the search result. - The `weight` to assign to the event, e.g. `1`. - An object containing any additional `metadata`.  For example, to send an event where a customer purchased a product, use the following call:  ```json {   \"name\": \"purchase\",   \"token\": \"eyJ...\",   \"weight\": 1,   \"metadata\": {     \"discount\": 0.2,     \"margin\": 30.0,     \"customer_id\": \"12345\",     \"ui_test_segment\": \"A\"   } } ```  Note: You must pass an `Account-Id` header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Sajari.Sdk.Api;
using Com.Sajari.Sdk.Client;
using Com.Sajari.Sdk.Model;

namespace Example
{
    public class SendEvent2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.search.io";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new EventsApi(config);
            var sendEventRequest = new SendEventRequest(); // SendEventRequest | 

            try
            {
                // Send event
                Object result = apiInstance.SendEvent2(sendEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.SendEvent2: " + e.Message );
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
 **sendEventRequest** | [**SendEventRequest**](SendEventRequest.md)|  | 

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
| **400** | Returned when the request contains violations for one or more fields. |  -  |
| **401** | Returned when the request does not have valid authentication credentials. |  -  |
| **403** | Returned when the user does not have permission to access the resource. |  -  |
| **404** | Returned when the resource does not exist. |  -  |
| **500** | Returned when the API encounters an internal error. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

