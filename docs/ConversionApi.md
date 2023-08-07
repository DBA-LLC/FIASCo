# FIASCo.Api.ConversionApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSpasV20AddConversionDataPost**](ConversionApi.md#apispasv20addconversiondatapost) | **POST** /api/spas/v2.0/AddConversionData | Добавить данные в задачу на конвертацию адресов |
| [**ApiSpasV20CancelConversionTaskGet**](ConversionApi.md#apispasv20cancelconversiontaskget) | **GET** /api/spas/v2.0/CancelConversionTask | Отменить задачу на конвертацию адресов |
| [**ApiSpasV20CreateConversionTaskGet**](ConversionApi.md#apispasv20createconversiontaskget) | **GET** /api/spas/v2.0/CreateConversionTask | Создать задачу на конвертацию адресов |
| [**ApiSpasV20GetConversionTaskStatusGet**](ConversionApi.md#apispasv20getconversiontaskstatusget) | **GET** /api/spas/v2.0/GetConversionTaskStatus | Получить статус задачи и статистику выполнения |
| [**ApiSpasV20GetConvertionResultBlockGet**](ConversionApi.md#apispasv20getconvertionresultblockget) | **GET** /api/spas/v2.0/GetConvertionResultBlock | Получить блок идентификаторов адресных элементов, полученных при конвертации |
| [**ApiSpasV20SearchByPartsPost**](ConversionApi.md#apispasv20searchbypartspost) | **POST** /api/spas/v2.0/SearchByParts | Поиск объекта ФИАС по частям его адреса |
| [**ApiSpasV20StartConversionTaskGet**](ConversionApi.md#apispasv20startconversiontaskget) | **GET** /api/spas/v2.0/StartConversionTask | Запустить задачу на конвертацию адресов |

<a id="apispasv20addconversiondatapost"></a>
# **ApiSpasV20AddConversionDataPost**
> SuccessResult ApiSpasV20AddConversionDataPost (AddConversionDataInput addConversionDataInput = null)

Добавить данные в задачу на конвертацию адресов

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20AddConversionDataPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ConversionApi(config);
            var addConversionDataInput = new AddConversionDataInput(); // AddConversionDataInput | Входные параметры (optional) 

            try
            {
                // Добавить данные в задачу на конвертацию адресов
                SuccessResult result = apiInstance.ApiSpasV20AddConversionDataPost(addConversionDataInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversionApi.ApiSpasV20AddConversionDataPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20AddConversionDataPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Добавить данные в задачу на конвертацию адресов
    ApiResponse<SuccessResult> response = apiInstance.ApiSpasV20AddConversionDataPostWithHttpInfo(addConversionDataInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversionApi.ApiSpasV20AddConversionDataPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addConversionDataInput** | [**AddConversionDataInput**](AddConversionDataInput.md) | Входные параметры | [optional]  |

### Return type

[**SuccessResult**](SuccessResult.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apispasv20cancelconversiontaskget"></a>
# **ApiSpasV20CancelConversionTaskGet**
> SuccessResult ApiSpasV20CancelConversionTaskGet (Guid? taskGuid = null)

Отменить задачу на конвертацию адресов

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20CancelConversionTaskGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ConversionApi(config);
            var taskGuid = "taskGuid_example";  // Guid? | Идентификатор задачи (optional) 

            try
            {
                // Отменить задачу на конвертацию адресов
                SuccessResult result = apiInstance.ApiSpasV20CancelConversionTaskGet(taskGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversionApi.ApiSpasV20CancelConversionTaskGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20CancelConversionTaskGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Отменить задачу на конвертацию адресов
    ApiResponse<SuccessResult> response = apiInstance.ApiSpasV20CancelConversionTaskGetWithHttpInfo(taskGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversionApi.ApiSpasV20CancelConversionTaskGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGuid** | **Guid?** | Идентификатор задачи | [optional]  |

### Return type

[**SuccessResult**](SuccessResult.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apispasv20createconversiontaskget"></a>
# **ApiSpasV20CreateConversionTaskGet**
> CreateConversionTaskResult ApiSpasV20CreateConversionTaskGet ()

Создать задачу на конвертацию адресов

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20CreateConversionTaskGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ConversionApi(config);

            try
            {
                // Создать задачу на конвертацию адресов
                CreateConversionTaskResult result = apiInstance.ApiSpasV20CreateConversionTaskGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversionApi.ApiSpasV20CreateConversionTaskGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20CreateConversionTaskGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Создать задачу на конвертацию адресов
    ApiResponse<CreateConversionTaskResult> response = apiInstance.ApiSpasV20CreateConversionTaskGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversionApi.ApiSpasV20CreateConversionTaskGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CreateConversionTaskResult**](CreateConversionTaskResult.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apispasv20getconversiontaskstatusget"></a>
# **ApiSpasV20GetConversionTaskStatusGet**
> ConversionTaskStatusAndStatistics ApiSpasV20GetConversionTaskStatusGet (Guid? taskGuid = null)

Получить статус задачи и статистику выполнения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20GetConversionTaskStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ConversionApi(config);
            var taskGuid = "taskGuid_example";  // Guid? | Идентификатор задачи (optional) 

            try
            {
                // Получить статус задачи и статистику выполнения
                ConversionTaskStatusAndStatistics result = apiInstance.ApiSpasV20GetConversionTaskStatusGet(taskGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversionApi.ApiSpasV20GetConversionTaskStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetConversionTaskStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить статус задачи и статистику выполнения
    ApiResponse<ConversionTaskStatusAndStatistics> response = apiInstance.ApiSpasV20GetConversionTaskStatusGetWithHttpInfo(taskGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversionApi.ApiSpasV20GetConversionTaskStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGuid** | **Guid?** | Идентификатор задачи | [optional]  |

### Return type

[**ConversionTaskStatusAndStatistics**](ConversionTaskStatusAndStatistics.md)

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

<a id="apispasv20getconvertionresultblockget"></a>
# **ApiSpasV20GetConvertionResultBlockGet**
> ConvertionResultBlockResult ApiSpasV20GetConvertionResultBlockGet (Guid? taskGuid = null, long? blockIndex = null)

Получить блок идентификаторов адресных элементов, полученных при конвертации

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20GetConvertionResultBlockGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ConversionApi(config);
            var taskGuid = "taskGuid_example";  // Guid? | Идентификатор задачи (optional) 
            var blockIndex = 789L;  // long? | Номер блока данных (optional) 

            try
            {
                // Получить блок идентификаторов адресных элементов, полученных при конвертации
                ConvertionResultBlockResult result = apiInstance.ApiSpasV20GetConvertionResultBlockGet(taskGuid, blockIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversionApi.ApiSpasV20GetConvertionResultBlockGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetConvertionResultBlockGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить блок идентификаторов адресных элементов, полученных при конвертации
    ApiResponse<ConvertionResultBlockResult> response = apiInstance.ApiSpasV20GetConvertionResultBlockGetWithHttpInfo(taskGuid, blockIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversionApi.ApiSpasV20GetConvertionResultBlockGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGuid** | **Guid?** | Идентификатор задачи | [optional]  |
| **blockIndex** | **long?** | Номер блока данных | [optional]  |

### Return type

[**ConvertionResultBlockResult**](ConvertionResultBlockResult.md)

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

<a id="apispasv20searchbypartspost"></a>
# **ApiSpasV20SearchByPartsPost**
> SearchByPartsResult ApiSpasV20SearchByPartsPost (StructuredAddress structuredAddress = null)

Поиск объекта ФИАС по частям его адреса

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20SearchByPartsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ConversionApi(config);
            var structuredAddress = new StructuredAddress(); // StructuredAddress | Входные данные (optional) 

            try
            {
                // Поиск объекта ФИАС по частям его адреса
                SearchByPartsResult result = apiInstance.ApiSpasV20SearchByPartsPost(structuredAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversionApi.ApiSpasV20SearchByPartsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20SearchByPartsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Поиск объекта ФИАС по частям его адреса
    ApiResponse<SearchByPartsResult> response = apiInstance.ApiSpasV20SearchByPartsPostWithHttpInfo(structuredAddress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversionApi.ApiSpasV20SearchByPartsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **structuredAddress** | [**StructuredAddress**](StructuredAddress.md) | Входные данные | [optional]  |

### Return type

[**SearchByPartsResult**](SearchByPartsResult.md)

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

<a id="apispasv20startconversiontaskget"></a>
# **ApiSpasV20StartConversionTaskGet**
> SuccessResult ApiSpasV20StartConversionTaskGet (Guid? taskGuid = null)

Запустить задачу на конвертацию адресов

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20StartConversionTaskGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new ConversionApi(config);
            var taskGuid = "taskGuid_example";  // Guid? | Идентификатор задачи (optional) 

            try
            {
                // Запустить задачу на конвертацию адресов
                SuccessResult result = apiInstance.ApiSpasV20StartConversionTaskGet(taskGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversionApi.ApiSpasV20StartConversionTaskGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20StartConversionTaskGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Запустить задачу на конвертацию адресов
    ApiResponse<SuccessResult> response = apiInstance.ApiSpasV20StartConversionTaskGetWithHttpInfo(taskGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversionApi.ApiSpasV20StartConversionTaskGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGuid** | **Guid?** | Идентификатор задачи | [optional]  |

### Return type

[**SuccessResult**](SuccessResult.md)

### Authorization

[master-token](../README.md#master-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

