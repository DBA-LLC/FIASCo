# FIASCo.Api.NoticeApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSpasV20AddNoticePost**](NoticeApi.md#apispasv20addnoticepost) | **POST** /api/spas/v2.0/AddNotice | Добавление уведомления |
| [**ApiSpasV20GetNoticeItemsPost**](NoticeApi.md#apispasv20getnoticeitemspost) | **POST** /api/spas/v2.0/GetNoticeItems | Получение списка уведомлений по условию |
| [**ApiSpasV20GetNoticeStatusGet**](NoticeApi.md#apispasv20getnoticestatusget) | **GET** /api/spas/v2.0/GetNoticeStatus | Получение статуса обработки уведомления |

<a id="apispasv20addnoticepost"></a>
# **ApiSpasV20AddNoticePost**
> AddNoticeResult ApiSpasV20AddNoticePost (Notice notice = null)

Добавление уведомления

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20AddNoticePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new NoticeApi(config);
            var notice = new Notice(); // Notice |  (optional) 

            try
            {
                // Добавление уведомления
                AddNoticeResult result = apiInstance.ApiSpasV20AddNoticePost(notice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticeApi.ApiSpasV20AddNoticePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20AddNoticePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Добавление уведомления
    ApiResponse<AddNoticeResult> response = apiInstance.ApiSpasV20AddNoticePostWithHttpInfo(notice);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NoticeApi.ApiSpasV20AddNoticePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notice** | [**Notice**](Notice.md) |  | [optional]  |

### Return type

[**AddNoticeResult**](AddNoticeResult.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apispasv20getnoticeitemspost"></a>
# **ApiSpasV20GetNoticeItemsPost**
> NoticeItemsResult ApiSpasV20GetNoticeItemsPost (NoticeFilterObject noticeFilterObject = null)

Получение списка уведомлений по условию

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20GetNoticeItemsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new NoticeApi(config);
            var noticeFilterObject = new NoticeFilterObject(); // NoticeFilterObject |  (optional) 

            try
            {
                // Получение списка уведомлений по условию
                NoticeItemsResult result = apiInstance.ApiSpasV20GetNoticeItemsPost(noticeFilterObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticeApi.ApiSpasV20GetNoticeItemsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetNoticeItemsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получение списка уведомлений по условию
    ApiResponse<NoticeItemsResult> response = apiInstance.ApiSpasV20GetNoticeItemsPostWithHttpInfo(noticeFilterObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NoticeApi.ApiSpasV20GetNoticeItemsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **noticeFilterObject** | [**NoticeFilterObject**](NoticeFilterObject.md) |  | [optional]  |

### Return type

[**NoticeItemsResult**](NoticeItemsResult.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apispasv20getnoticestatusget"></a>
# **ApiSpasV20GetNoticeStatusGet**
> GetNoticeStatusResult ApiSpasV20GetNoticeStatusGet (long? id = null)

Получение статуса обработки уведомления

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20GetNoticeStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new NoticeApi(config);
            var id = 789L;  // long? |  (optional) 

            try
            {
                // Получение статуса обработки уведомления
                GetNoticeStatusResult result = apiInstance.ApiSpasV20GetNoticeStatusGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticeApi.ApiSpasV20GetNoticeStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetNoticeStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получение статуса обработки уведомления
    ApiResponse<GetNoticeStatusResult> response = apiInstance.ApiSpasV20GetNoticeStatusGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NoticeApi.ApiSpasV20GetNoticeStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long?** |  | [optional]  |

### Return type

[**GetNoticeStatusResult**](GetNoticeStatusResult.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

