# FIASCo.Api.AddressInfoApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSpasV20GetAddressItemByCadastralNumberGet**](AddressInfoApi.md#apispasv20getaddressitembycadastralnumberget) | **GET** /api/spas/v2.0/GetAddressItemByCadastralNumber | Получение адресного элемента по кадастровому номеру |
| [**ApiSpasV20GetAddressItemByGuidGet**](AddressInfoApi.md#apispasv20getaddressitembyguidget) | **GET** /api/spas/v2.0/GetAddressItemByGuid | Получение адресного элемента по уникальному идентификатору ФИАС |
| [**ApiSpasV20GetAddressItemByIdGet**](AddressInfoApi.md#apispasv20getaddressitembyidget) | **GET** /api/spas/v2.0/GetAddressItemById | Получение адресного элемента по идентификатору |
| [**ApiSpasV20GetAddressItemsPost**](AddressInfoApi.md#apispasv20getaddressitemspost) | **POST** /api/spas/v2.0/GetAddressItems | Получить список дочерних элементов, соответствующих заданным фильтрам |
| [**ApiSpasV20GetDetailsGet**](AddressInfoApi.md#apispasv20getdetailsget) | **GET** /api/spas/v2.0/GetDetails | Получить дополнительную информацию для заданного адресного элемента |
| [**ApiSpasV20GetFiasObjectTypesGet**](AddressInfoApi.md#apispasv20getfiasobjecttypesget) | **GET** /api/spas/v2.0/GetFiasObjectTypes | Получение типов объектов ФИАС |
| [**ApiSpasV20GetRegionsGet**](AddressInfoApi.md#apispasv20getregionsget) | **GET** /api/spas/v2.0/GetRegions | Получить список регионов |
| [**ApiSpasV20HasDescendantsGet**](AddressInfoApi.md#apispasv20hasdescendantsget) | **GET** /api/spas/v2.0/HasDescendants | Проверка, имеет ли элемент parent дочерние элементы до уровня up_to_level |
| [**ApiSpasV20IsDescendantGet**](AddressInfoApi.md#apispasv20isdescendantget) | **GET** /api/spas/v2.0/IsDescendant | Проверка, является ли элемент ancestor родительским элементом в иерархии для элемента descendant |

<a id="apispasv20getaddressitembycadastralnumberget"></a>
# **ApiSpasV20GetAddressItemByCadastralNumberGet**
> AddressesResult ApiSpasV20GetAddressItemByCadastralNumberGet (string cadastralNumber = null, AddressType? addressType = null)

Получение адресного элемента по кадастровому номеру

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20GetAddressItemByCadastralNumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);
            var cadastralNumber = "cadastralNumber_example";  // string |  (optional) 
            var addressType = (AddressType) "1";  // AddressType? |  (optional) 

            try
            {
                // Получение адресного элемента по кадастровому номеру
                AddressesResult result = apiInstance.ApiSpasV20GetAddressItemByCadastralNumberGet(cadastralNumber, addressType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetAddressItemByCadastralNumberGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetAddressItemByCadastralNumberGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получение адресного элемента по кадастровому номеру
    ApiResponse<AddressesResult> response = apiInstance.ApiSpasV20GetAddressItemByCadastralNumberGetWithHttpInfo(cadastralNumber, addressType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetAddressItemByCadastralNumberGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cadastralNumber** | **string** |  | [optional]  |
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

<a id="apispasv20getaddressitembyguidget"></a>
# **ApiSpasV20GetAddressItemByGuidGet**
> AddressesResult ApiSpasV20GetAddressItemByGuidGet (Guid? objectGuid = null, AddressType? addressType = null)

Получение адресного элемента по уникальному идентификатору ФИАС

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using FIASCo.Model;

namespace Example
{
    public class ApiSpasV20GetAddressItemByGuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);
            var objectGuid = "objectGuid_example";  // Guid? |  (optional) 
            var addressType = (AddressType) "1";  // AddressType? |  (optional) 

            try
            {
                // Получение адресного элемента по уникальному идентификатору ФИАС
                AddressesResult result = apiInstance.ApiSpasV20GetAddressItemByGuidGet(objectGuid, addressType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetAddressItemByGuidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetAddressItemByGuidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получение адресного элемента по уникальному идентификатору ФИАС
    ApiResponse<AddressesResult> response = apiInstance.ApiSpasV20GetAddressItemByGuidGetWithHttpInfo(objectGuid, addressType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetAddressItemByGuidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectGuid** | **Guid?** |  | [optional]  |
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

<a id="apispasv20getaddressitembyidget"></a>
# **ApiSpasV20GetAddressItemByIdGet**
> AddressesResult ApiSpasV20GetAddressItemByIdGet (long? objectId = null, AddressType? addressType = null)

Получение адресного элемента по идентификатору

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FIASCo.Api;
using FIASCo.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20GetAddressItemByIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);
            var objectId = 789L;  // long? |  (optional) 
            var addressType = (AddressType) "1";  // AddressType? |  (optional) 

            try
            {
                // Получение адресного элемента по идентификатору
                AddressesResult result = apiInstance.ApiSpasV20GetAddressItemByIdGet(objectId, addressType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetAddressItemByIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetAddressItemByIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получение адресного элемента по идентификатору
    ApiResponse<AddressesResult> response = apiInstance.ApiSpasV20GetAddressItemByIdGetWithHttpInfo(objectId, addressType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetAddressItemByIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **long?** |  | [optional]  |
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

<a id="apispasv20getaddressitemspost"></a>
# **ApiSpasV20GetAddressItemsPost**
> AddressesResult ApiSpasV20GetAddressItemsPost (FilterObject filterObject = null)

Получить список дочерних элементов, соответствующих заданным фильтрам

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20GetAddressItemsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);
            var filterObject = new FilterObject(); // FilterObject |  (optional) 

            try
            {
                // Получить список дочерних элементов, соответствующих заданным фильтрам
                AddressesResult result = apiInstance.ApiSpasV20GetAddressItemsPost(filterObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetAddressItemsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetAddressItemsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить список дочерних элементов, соответствующих заданным фильтрам
    ApiResponse<AddressesResult> response = apiInstance.ApiSpasV20GetAddressItemsPostWithHttpInfo(filterObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetAddressItemsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterObject** | [**FilterObject**](FilterObject.md) |  | [optional]  |

### Return type

[**AddressesResult**](AddressesResult.md)

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

<a id="apispasv20getdetailsget"></a>
# **ApiSpasV20GetDetailsGet**
> AddressDetailsResult ApiSpasV20GetDetailsGet (long? objectId = null)

Получить дополнительную информацию для заданного адресного элемента

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20GetDetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);
            var objectId = 789L;  // long? | Идентификатор адресного элемента (optional) 

            try
            {
                // Получить дополнительную информацию для заданного адресного элемента
                AddressDetailsResult result = apiInstance.ApiSpasV20GetDetailsGet(objectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить дополнительную информацию для заданного адресного элемента
    ApiResponse<AddressDetailsResult> response = apiInstance.ApiSpasV20GetDetailsGetWithHttpInfo(objectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetDetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **long?** | Идентификатор адресного элемента | [optional]  |

### Return type

[**AddressDetailsResult**](AddressDetailsResult.md)

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

<a id="apispasv20getfiasobjecttypesget"></a>
# **ApiSpasV20GetFiasObjectTypesGet**
> FiasTypesResult ApiSpasV20GetFiasObjectTypesGet ()

Получение типов объектов ФИАС

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20GetFiasObjectTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);

            try
            {
                // Получение типов объектов ФИАС
                FiasTypesResult result = apiInstance.ApiSpasV20GetFiasObjectTypesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetFiasObjectTypesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetFiasObjectTypesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получение типов объектов ФИАС
    ApiResponse<FiasTypesResult> response = apiInstance.ApiSpasV20GetFiasObjectTypesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetFiasObjectTypesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FiasTypesResult**](FiasTypesResult.md)

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

<a id="apispasv20getregionsget"></a>
# **ApiSpasV20GetRegionsGet**
> AddressesResult ApiSpasV20GetRegionsGet ()

Получить список регионов

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20GetRegionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);

            try
            {
                // Получить список регионов
                AddressesResult result = apiInstance.ApiSpasV20GetRegionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetRegionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20GetRegionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Получить список регионов
    ApiResponse<AddressesResult> response = apiInstance.ApiSpasV20GetRegionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20GetRegionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="apispasv20hasdescendantsget"></a>
# **ApiSpasV20HasDescendantsGet**
> CheckResult ApiSpasV20HasDescendantsGet (long? parent = null, int? upToLevel = null, AddressType? addressType = null)

Проверка, имеет ли элемент parent дочерние элементы до уровня up_to_level

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20HasDescendantsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);
            var parent = 789L;  // long? |  (optional) 
            var upToLevel = 56;  // int? |  (optional) 
            var addressType = (AddressType) "1";  // AddressType? |  (optional) 

            try
            {
                // Проверка, имеет ли элемент parent дочерние элементы до уровня up_to_level
                CheckResult result = apiInstance.ApiSpasV20HasDescendantsGet(parent, upToLevel, addressType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20HasDescendantsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20HasDescendantsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Проверка, имеет ли элемент parent дочерние элементы до уровня up_to_level
    ApiResponse<CheckResult> response = apiInstance.ApiSpasV20HasDescendantsGetWithHttpInfo(parent, upToLevel, addressType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20HasDescendantsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parent** | **long?** |  | [optional]  |
| **upToLevel** | **int?** |  | [optional]  |
| **addressType** | **AddressType?** |  | [optional]  |

### Return type

[**CheckResult**](CheckResult.md)

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

<a id="apispasv20isdescendantget"></a>
# **ApiSpasV20IsDescendantGet**
> CheckResult ApiSpasV20IsDescendantGet (long? ancestor = null, long? descendant = null, AddressType? addressType = null)

Проверка, является ли элемент ancestor родительским элементом в иерархии для элемента descendant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSpasV20IsDescendantGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: master-token
            config.AddApiKey("master-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("master-token", "Bearer");

            var apiInstance = new AddressInfoApi(config);
            var ancestor = 789L;  // long? | Идентификатор родительского элемента (optional) 
            var descendant = 789L;  // long? | Идентификатор дочернего элемента (optional) 
            var addressType = (AddressType) "1";  // AddressType? | Вид представления адреса: 1 - административное деление 2 - муниципальное деление (optional) 

            try
            {
                // Проверка, является ли элемент ancestor родительским элементом в иерархии для элемента descendant
                CheckResult result = apiInstance.ApiSpasV20IsDescendantGet(ancestor, descendant, addressType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20IsDescendantGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSpasV20IsDescendantGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Проверка, является ли элемент ancestor родительским элементом в иерархии для элемента descendant
    ApiResponse<CheckResult> response = apiInstance.ApiSpasV20IsDescendantGetWithHttpInfo(ancestor, descendant, addressType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressInfoApi.ApiSpasV20IsDescendantGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ancestor** | **long?** | Идентификатор родительского элемента | [optional]  |
| **descendant** | **long?** | Идентификатор дочернего элемента | [optional]  |
| **addressType** | **AddressType?** | Вид представления адреса: 1 - административное деление 2 - муниципальное деление | [optional]  |

### Return type

[**CheckResult**](CheckResult.md)

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

