# FIASCo.Api.ChangesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSpasV20GetChangesGet**](ChangesApi.md#apispasv20getchangesget) | **GET** /api/spas/v2.0/GetChanges | Поставить задачу на получение списка адресных объектов, изменённых в указанный интервал времени и отобранных по критериям |
| [**ApiSpasV20GetSearchResultBlockGet**](ChangesApi.md#apispasv20getsearchresultblockget) | **GET** /api/spas/v2.0/GetSearchResultBlock | Сервис для получения типов объектов ФИАС |
| [**ApiSpasV20GetSearchTaskStatusGet**](ChangesApi.md#apispasv20getsearchtaskstatusget) | **GET** /api/spas/v2.0/GetSearchTaskStatus | Сервис для получения состояния задачи по поиску изменений |

<a id="apispasv20getchangesget"></a>
# **ApiSpasV20GetChangesGet**
> IdResult ApiSpasV20GetChangesGet (DateTime? startDate = null, DateTime? endDate = null, int? changeMask = null, int? regionCode = null)

Поставить задачу на получение списка адресных объектов, изменённых в указанный интервал времени и отобранных по критериям

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20GetChangesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ChangesApi(config);
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Дата начала поиска изменений (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Дата кокончания поиска изменений (optional) 
            var changeMask = 56;  // int? | Маска для отбора изменений (optional) 
            var regionCode = 56;  // int? | Код региона, для которого происходит поиск изменений (optional) 

            try
            {
                // Поставить задачу на получение списка адресных объектов, изменённых в указанный интервал времени и отобранных по критериям
                IdResult result = apiInstance.ApiSpasV20GetChangesGet(startDate, endDate, changeMask, regionCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChangesApi.ApiSpasV20GetChangesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetChangesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Поставить задачу на получение списка адресных объектов, изменённых в указанный интервал времени и отобранных по критериям
    ApiResponse<IdResult> response = apiInstance.ApiSpasV20GetChangesGetWithHttpInfo(startDate, endDate, changeMask, regionCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChangesApi.ApiSpasV20GetChangesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **DateTime?** | Дата начала поиска изменений | [optional]  |
| **endDate** | **DateTime?** | Дата кокончания поиска изменений | [optional]  |
| **changeMask** | **int?** | Маска для отбора изменений | [optional]  |
| **regionCode** | **int?** | Код региона, для которого происходит поиск изменений | [optional]  |

### Return type

[**IdResult**](IdResult.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apispasv20getsearchresultblockget"></a>
# **ApiSpasV20GetSearchResultBlockGet**
> IFetchChangesTaskResultBlock ApiSpasV20GetSearchResultBlockGet (long? taskId = null, int? blockIndex = null)

Сервис для получения типов объектов ФИАС

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20GetSearchResultBlockGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ChangesApi(config);
            var taskId = 789L;  // long? | Номер задачи по поиску изменений (optional) 
            var blockIndex = 56;  // int? | Только актуальные на тек момент (optional) 

            try
            {
                // Сервис для получения типов объектов ФИАС
                IFetchChangesTaskResultBlock result = apiInstance.ApiSpasV20GetSearchResultBlockGet(taskId, blockIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChangesApi.ApiSpasV20GetSearchResultBlockGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetSearchResultBlockGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Сервис для получения типов объектов ФИАС
    ApiResponse<IFetchChangesTaskResultBlock> response = apiInstance.ApiSpasV20GetSearchResultBlockGetWithHttpInfo(taskId, blockIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChangesApi.ApiSpasV20GetSearchResultBlockGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **long?** | Номер задачи по поиску изменений | [optional]  |
| **blockIndex** | **int?** | Только актуальные на тек момент | [optional]  |

### Return type

[**IFetchChangesTaskResultBlock**](IFetchChangesTaskResultBlock.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apispasv20getsearchtaskstatusget"></a>
# **ApiSpasV20GetSearchTaskStatusGet**
> IFetchChangesTaskStatus ApiSpasV20GetSearchTaskStatusGet (long? taskId = null)

Сервис для получения состояния задачи по поиску изменений

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20GetSearchTaskStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ChangesApi(config);
            var taskId = 789L;  // long? | Номер задачи по поиску изменений (optional) 

            try
            {
                // Сервис для получения состояния задачи по поиску изменений
                IFetchChangesTaskStatus result = apiInstance.ApiSpasV20GetSearchTaskStatusGet(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChangesApi.ApiSpasV20GetSearchTaskStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetSearchTaskStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Сервис для получения состояния задачи по поиску изменений
    ApiResponse<IFetchChangesTaskStatus> response = apiInstance.ApiSpasV20GetSearchTaskStatusGetWithHttpInfo(taskId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChangesApi.ApiSpasV20GetSearchTaskStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **long?** | Номер задачи по поиску изменений | [optional]  |

### Return type

[**IFetchChangesTaskStatus**](IFetchChangesTaskStatus.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

