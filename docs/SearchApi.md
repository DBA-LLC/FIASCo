# FIASCo.Api.SearchApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSpasV20GetAddressHintGet**](SearchApi.md#apispasv20getaddresshintget) | **GET** /api/spas/v2.0/GetAddressHint | Сервис для организации стандартизированного ввода и поиск адреса (унифицированная адресная строка) |
| [**ApiSpasV20SearchAddressItemsGet**](SearchApi.md#apispasv20searchaddressitemsget) | **GET** /api/spas/v2.0/SearchAddressItems | Получение адресных элементов, соответствующих заданной произвольной строке адреса |

<a id="apispasv20getaddresshintget"></a>
# **ApiSpasV20GetAddressHintGet**
> HintResult ApiSpasV20GetAddressHintGet (string searchString = null, AddressType? addressType = null)

Сервис для организации стандартизированного ввода и поиск адреса (унифицированная адресная строка)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20GetAddressHintGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new SearchApi(config);
            var searchString = "searchString_example";  // string |  (optional) 
            var addressType = (AddressType) "1";  // AddressType? |  (optional) 

            try
            {
                // Сервис для организации стандартизированного ввода и поиск адреса (унифицированная адресная строка)
                HintResult result = apiInstance.ApiSpasV20GetAddressHintGet(searchString, addressType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.ApiSpasV20GetAddressHintGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetAddressHintGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Сервис для организации стандартизированного ввода и поиск адреса (унифицированная адресная строка)
    ApiResponse<HintResult> response = apiInstance.ApiSpasV20GetAddressHintGetWithHttpInfo(searchString, addressType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.ApiSpasV20GetAddressHintGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchString** | **string** |  | [optional]  |
| **addressType** | **AddressType?** |  | [optional]  |

### Return type

[**HintResult**](HintResult.md)

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

<a id="apispasv20searchaddressitemsget"></a>
# **ApiSpasV20SearchAddressItemsGet**
> AddressesResult ApiSpasV20SearchAddressItemsGet (string searchString = null, AddressType? addressType = null)

Получение адресных элементов, соответствующих заданной произвольной строке адреса

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20SearchAddressItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new SearchApi(config);
            var searchString = "searchString_example";  // string |  (optional) 
            var addressType = (AddressType) "1";  // AddressType? |  (optional) 

            try
            {
                // Получение адресных элементов, соответствующих заданной произвольной строке адреса
                AddressesResult result = apiInstance.ApiSpasV20SearchAddressItemsGet(searchString, addressType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.ApiSpasV20SearchAddressItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20SearchAddressItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получение адресных элементов, соответствующих заданной произвольной строке адреса
    ApiResponse<AddressesResult> response = apiInstance.ApiSpasV20SearchAddressItemsGetWithHttpInfo(searchString, addressType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.ApiSpasV20SearchAddressItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchString** | **string** |  | [optional]  |
| **addressType** | **AddressType?** |  | [optional]  |

### Return type

[**AddressesResult**](AddressesResult.md)

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

