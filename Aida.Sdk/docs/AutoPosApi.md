# Aida.Sdk.Api.AutoPosApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAutoPosSettings**](AutoPosApi.md#addautopossettings) | **POST** /aida/v1/autopos | Creates a new XY Auto-Position configuration |
| [**AutoPosConfigDebugLive**](AutoPosApi.md#autoposconfigdebuglive) | **GET** /aida/v1/autopos/job/{jobTemplateId}/layout/{layoutId}/scanner/{scannerId}/debug/live | Motion JPEG stream of the camera with XY Auto-Pos overlay |
| [**AutoPosDebug**](AutoPosApi.md#autoposdebug) | **GET** /aida/v1/autopos/{id}/debug.jpg | Draws search area and best match rectangles on a camera frame and returns it as a jpeg image |
| [**AutoPosDebugLive**](AutoPosApi.md#autoposdebuglive) | **GET** /aida/v1/autopos/{id}/debug/live | Motion JPEG stream of the camera with XY Auto-Pos overlay |
| [**CreateTemplateMatchingConfiguration**](AutoPosApi.md#createtemplatematchingconfiguration) | **POST** /aida/v1/autopos/template-matching-configuration |  |
| [**DeleteJobTemplateLayoutAutoPosSettings**](AutoPosApi.md#deletejobtemplatelayoutautopossettings) | **DELETE** /aida/v1/autopos/{autoPosSettingsId} |  |
| [**DeleteTemplateMatchingConfiguration**](AutoPosApi.md#deletetemplatematchingconfiguration) | **DELETE** /aida/v1/autopos/template-matching-configuration/{id} |  |
| [**FindTemplateMatchingConfigurations**](AutoPosApi.md#findtemplatematchingconfigurations) | **GET** /aida/v1/autopos/template-matching-configuration/search |  |
| [**GetOffset**](AutoPosApi.md#getoffset) | **POST** /aida/v1/autopos/{autoPosSettingsId}/execute | Run template matching and return the distance between the reference template and  the matched template (if any) in millimeters |
| [**GetTemplateMatchingConfigurationById**](AutoPosApi.md#gettemplatematchingconfigurationbyid) | **GET** /aida/v1/autopos/template-matching-configuration/{id} |  |
| [**TemplateMatchingConfigurationDebugLivePage**](AutoPosApi.md#templatematchingconfigurationdebuglivepage) | **GET** /aida/v1/autopos/template-matching-configuration/{templateMatchingConfigurationId}/debug/live.html |  |
| [**TemplateMatchingDebugLive**](AutoPosApi.md#templatematchingdebuglive) | **GET** /aida/v1/autopos/template-matching-configuration/{templateMatchingConfigurationId}/debug/live |  |
| [**UpdateAutoPosSettings**](AutoPosApi.md#updateautopossettings) | **PUT** /aida/v1/autopos |  |
| [**UpdateTemplateMatchingConfiguration**](AutoPosApi.md#updatetemplatematchingconfiguration) | **PUT** /aida/v1/autopos/template-matching-configuration |  |

<a name="addautopossettings"></a>
# **AddAutoPosSettings**
> JobTemplateLayoutAutoPosSettingsDto AddAutoPosSettings (string scannerId = null, JobTemplateLayoutAutoPosSettingsDto jobTemplateLayoutAutoPosSettingsDto = null)

Creates a new XY Auto-Position configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class AddAutoPosSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var jobTemplateLayoutAutoPosSettingsDto = new JobTemplateLayoutAutoPosSettingsDto(); // JobTemplateLayoutAutoPosSettingsDto |  (optional) 

            try
            {
                // Creates a new XY Auto-Position configuration
                JobTemplateLayoutAutoPosSettingsDto result = apiInstance.AddAutoPosSettings(scannerId, jobTemplateLayoutAutoPosSettingsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.AddAutoPosSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAutoPosSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new XY Auto-Position configuration
    ApiResponse<JobTemplateLayoutAutoPosSettingsDto> response = apiInstance.AddAutoPosSettingsWithHttpInfo(scannerId, jobTemplateLayoutAutoPosSettingsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.AddAutoPosSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **jobTemplateLayoutAutoPosSettingsDto** | [**JobTemplateLayoutAutoPosSettingsDto**](JobTemplateLayoutAutoPosSettingsDto.md) |  | [optional]  |

### Return type

[**JobTemplateLayoutAutoPosSettingsDto**](JobTemplateLayoutAutoPosSettingsDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autoposconfigdebuglive"></a>
# **AutoPosConfigDebugLive**
> void AutoPosConfigDebugLive (int jobTemplateId, int layoutId, string scannerId, string cameraId, float? threshold = null)

Motion JPEG stream of the camera with XY Auto-Pos overlay

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class AutoPosConfigDebugLiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 
            var layoutId = 56;  // int | 
            var scannerId = "\"\"";  // string |  (default to "")
            var cameraId = "\"\"";  // string |  (default to "")
            var threshold = 0.8F;  // float? |  (optional)  (default to 0.8F)

            try
            {
                // Motion JPEG stream of the camera with XY Auto-Pos overlay
                apiInstance.AutoPosConfigDebugLive(jobTemplateId, layoutId, scannerId, cameraId, threshold);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.AutoPosConfigDebugLive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutoPosConfigDebugLiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Motion JPEG stream of the camera with XY Auto-Pos overlay
    apiInstance.AutoPosConfigDebugLiveWithHttpInfo(jobTemplateId, layoutId, scannerId, cameraId, threshold);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.AutoPosConfigDebugLiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |
| **layoutId** | **int** |  |  |
| **scannerId** | **string** |  | [default to &quot;&quot;] |
| **cameraId** | **string** |  | [default to &quot;&quot;] |
| **threshold** | **float?** |  | [optional] [default to 0.8F] |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autoposdebug"></a>
# **AutoPosDebug**
> void AutoPosDebug (int id, float? threshold = null, string scannerId = null, string cameraId = null)

Draws search area and best match rectangles on a camera frame and returns it as a jpeg image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class AutoPosDebugExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var threshold = 0.8F;  // float? |  (optional)  (default to 0.8F)
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var cameraId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // Draws search area and best match rectangles on a camera frame and returns it as a jpeg image
                apiInstance.AutoPosDebug(id, threshold, scannerId, cameraId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.AutoPosDebug: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutoPosDebugWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Draws search area and best match rectangles on a camera frame and returns it as a jpeg image
    apiInstance.AutoPosDebugWithHttpInfo(id, threshold, scannerId, cameraId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.AutoPosDebugWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **threshold** | **float?** |  | [optional] [default to 0.8F] |
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **cameraId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autoposdebuglive"></a>
# **AutoPosDebugLive**
> void AutoPosDebugLive (int id, float? threshold = null, string scannerId = null, string cameraId = null)

Motion JPEG stream of the camera with XY Auto-Pos overlay

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class AutoPosDebugLiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var threshold = 0.8F;  // float? |  (optional)  (default to 0.8F)
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var cameraId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // Motion JPEG stream of the camera with XY Auto-Pos overlay
                apiInstance.AutoPosDebugLive(id, threshold, scannerId, cameraId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.AutoPosDebugLive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutoPosDebugLiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Motion JPEG stream of the camera with XY Auto-Pos overlay
    apiInstance.AutoPosDebugLiveWithHttpInfo(id, threshold, scannerId, cameraId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.AutoPosDebugLiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **threshold** | **float?** |  | [optional] [default to 0.8F] |
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **cameraId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplatematchingconfiguration"></a>
# **CreateTemplateMatchingConfiguration**
> TemplateMatchingConfigurationDto CreateTemplateMatchingConfiguration (string scannerId = null, TemplateMatchingConfigurationDto templateMatchingConfigurationDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class CreateTemplateMatchingConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var templateMatchingConfigurationDto = new TemplateMatchingConfigurationDto(); // TemplateMatchingConfigurationDto |  (optional) 

            try
            {
                TemplateMatchingConfigurationDto result = apiInstance.CreateTemplateMatchingConfiguration(scannerId, templateMatchingConfigurationDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.CreateTemplateMatchingConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTemplateMatchingConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TemplateMatchingConfigurationDto> response = apiInstance.CreateTemplateMatchingConfigurationWithHttpInfo(scannerId, templateMatchingConfigurationDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.CreateTemplateMatchingConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **templateMatchingConfigurationDto** | [**TemplateMatchingConfigurationDto**](TemplateMatchingConfigurationDto.md) |  | [optional]  |

### Return type

[**TemplateMatchingConfigurationDto**](TemplateMatchingConfigurationDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejobtemplatelayoutautopossettings"></a>
# **DeleteJobTemplateLayoutAutoPosSettings**
> JobTemplateLayoutAutoPosSettingsDto DeleteJobTemplateLayoutAutoPosSettings (int autoPosSettingsId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class DeleteJobTemplateLayoutAutoPosSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var autoPosSettingsId = 56;  // int | 

            try
            {
                JobTemplateLayoutAutoPosSettingsDto result = apiInstance.DeleteJobTemplateLayoutAutoPosSettings(autoPosSettingsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.DeleteJobTemplateLayoutAutoPosSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteJobTemplateLayoutAutoPosSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JobTemplateLayoutAutoPosSettingsDto> response = apiInstance.DeleteJobTemplateLayoutAutoPosSettingsWithHttpInfo(autoPosSettingsId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.DeleteJobTemplateLayoutAutoPosSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoPosSettingsId** | **int** |  |  |

### Return type

[**JobTemplateLayoutAutoPosSettingsDto**](JobTemplateLayoutAutoPosSettingsDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplatematchingconfiguration"></a>
# **DeleteTemplateMatchingConfiguration**
> TemplateMatchingConfigurationDto DeleteTemplateMatchingConfiguration (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class DeleteTemplateMatchingConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                TemplateMatchingConfigurationDto result = apiInstance.DeleteTemplateMatchingConfiguration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.DeleteTemplateMatchingConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTemplateMatchingConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TemplateMatchingConfigurationDto> response = apiInstance.DeleteTemplateMatchingConfigurationWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.DeleteTemplateMatchingConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**TemplateMatchingConfigurationDto**](TemplateMatchingConfigurationDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtemplatematchingconfigurations"></a>
# **FindTemplateMatchingConfigurations**
> SearchTemplateMatchingConfigurationsResultDto FindTemplateMatchingConfigurations (int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class FindTemplateMatchingConfigurationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                SearchTemplateMatchingConfigurationsResultDto result = apiInstance.FindTemplateMatchingConfigurations(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.FindTemplateMatchingConfigurations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindTemplateMatchingConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchTemplateMatchingConfigurationsResultDto> response = apiInstance.FindTemplateMatchingConfigurationsWithHttpInfo(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.FindTemplateMatchingConfigurationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**SearchTemplateMatchingConfigurationsResultDto**](SearchTemplateMatchingConfigurationsResultDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoffset"></a>
# **GetOffset**
> AutoPosResultDto GetOffset (int autoPosSettingsId, float? threshold = null, string scannerId = null, string cameraId = null)

Run template matching and return the distance between the reference template and  the matched template (if any) in millimeters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GetOffsetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var autoPosSettingsId = 56;  // int | 
            var threshold = 0.8F;  // float? |  (optional)  (default to 0.8F)
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var cameraId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // Run template matching and return the distance between the reference template and  the matched template (if any) in millimeters
                AutoPosResultDto result = apiInstance.GetOffset(autoPosSettingsId, threshold, scannerId, cameraId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.GetOffset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOffsetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run template matching and return the distance between the reference template and  the matched template (if any) in millimeters
    ApiResponse<AutoPosResultDto> response = apiInstance.GetOffsetWithHttpInfo(autoPosSettingsId, threshold, scannerId, cameraId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.GetOffsetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoPosSettingsId** | **int** |  |  |
| **threshold** | **float?** |  | [optional] [default to 0.8F] |
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **cameraId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

[**AutoPosResultDto**](AutoPosResultDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplatematchingconfigurationbyid"></a>
# **GetTemplateMatchingConfigurationById**
> TemplateMatchingConfigurationDto GetTemplateMatchingConfigurationById (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GetTemplateMatchingConfigurationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                TemplateMatchingConfigurationDto result = apiInstance.GetTemplateMatchingConfigurationById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.GetTemplateMatchingConfigurationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTemplateMatchingConfigurationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TemplateMatchingConfigurationDto> response = apiInstance.GetTemplateMatchingConfigurationByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.GetTemplateMatchingConfigurationByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**TemplateMatchingConfigurationDto**](TemplateMatchingConfigurationDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatematchingconfigurationdebuglivepage"></a>
# **TemplateMatchingConfigurationDebugLivePage**
> void TemplateMatchingConfigurationDebugLivePage (int templateMatchingConfigurationId, float? threshold = null, string scannerId = null, string cameraId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class TemplateMatchingConfigurationDebugLivePageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var templateMatchingConfigurationId = 56;  // int | 
            var threshold = 0.8F;  // float? |  (optional)  (default to 0.8F)
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var cameraId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                apiInstance.TemplateMatchingConfigurationDebugLivePage(templateMatchingConfigurationId, threshold, scannerId, cameraId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.TemplateMatchingConfigurationDebugLivePage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateMatchingConfigurationDebugLivePageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TemplateMatchingConfigurationDebugLivePageWithHttpInfo(templateMatchingConfigurationId, threshold, scannerId, cameraId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.TemplateMatchingConfigurationDebugLivePageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateMatchingConfigurationId** | **int** |  |  |
| **threshold** | **float?** |  | [optional] [default to 0.8F] |
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **cameraId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatematchingdebuglive"></a>
# **TemplateMatchingDebugLive**
> void TemplateMatchingDebugLive (int templateMatchingConfigurationId, float? threshold = null, string scannerId = null, string cameraId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class TemplateMatchingDebugLiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var templateMatchingConfigurationId = 56;  // int | 
            var threshold = 0.8F;  // float? |  (optional)  (default to 0.8F)
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var cameraId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                apiInstance.TemplateMatchingDebugLive(templateMatchingConfigurationId, threshold, scannerId, cameraId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.TemplateMatchingDebugLive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateMatchingDebugLiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TemplateMatchingDebugLiveWithHttpInfo(templateMatchingConfigurationId, threshold, scannerId, cameraId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.TemplateMatchingDebugLiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateMatchingConfigurationId** | **int** |  |  |
| **threshold** | **float?** |  | [optional] [default to 0.8F] |
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **cameraId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateautopossettings"></a>
# **UpdateAutoPosSettings**
> JobTemplateLayoutAutoPosSettingsDto UpdateAutoPosSettings (string scannerId = null, JobTemplateLayoutAutoPosSettings jobTemplateLayoutAutoPosSettings = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class UpdateAutoPosSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var jobTemplateLayoutAutoPosSettings = new JobTemplateLayoutAutoPosSettings(); // JobTemplateLayoutAutoPosSettings |  (optional) 

            try
            {
                JobTemplateLayoutAutoPosSettingsDto result = apiInstance.UpdateAutoPosSettings(scannerId, jobTemplateLayoutAutoPosSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.UpdateAutoPosSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAutoPosSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JobTemplateLayoutAutoPosSettingsDto> response = apiInstance.UpdateAutoPosSettingsWithHttpInfo(scannerId, jobTemplateLayoutAutoPosSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.UpdateAutoPosSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **jobTemplateLayoutAutoPosSettings** | [**JobTemplateLayoutAutoPosSettings**](JobTemplateLayoutAutoPosSettings.md) |  | [optional]  |

### Return type

[**JobTemplateLayoutAutoPosSettingsDto**](JobTemplateLayoutAutoPosSettingsDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplatematchingconfiguration"></a>
# **UpdateTemplateMatchingConfiguration**
> TemplateMatchingConfigurationDto UpdateTemplateMatchingConfiguration (string scannerId = null, TemplateMatchingConfigurationDto templateMatchingConfigurationDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class UpdateTemplateMatchingConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoPosApi(httpClient, config, httpClientHandler);
            var scannerId = "\"\"";  // string |  (optional)  (default to "")
            var templateMatchingConfigurationDto = new TemplateMatchingConfigurationDto(); // TemplateMatchingConfigurationDto |  (optional) 

            try
            {
                TemplateMatchingConfigurationDto result = apiInstance.UpdateTemplateMatchingConfiguration(scannerId, templateMatchingConfigurationDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoPosApi.UpdateTemplateMatchingConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTemplateMatchingConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TemplateMatchingConfigurationDto> response = apiInstance.UpdateTemplateMatchingConfigurationWithHttpInfo(scannerId, templateMatchingConfigurationDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoPosApi.UpdateTemplateMatchingConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional] [default to &quot;&quot;] |
| **templateMatchingConfigurationDto** | [**TemplateMatchingConfigurationDto**](TemplateMatchingConfigurationDto.md) |  | [optional]  |

### Return type

[**TemplateMatchingConfigurationDto**](TemplateMatchingConfigurationDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

