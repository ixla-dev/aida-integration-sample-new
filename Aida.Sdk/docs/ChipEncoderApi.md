# Aida.Sdk.Api.ChipEncoderApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetChipConfiguration**](ChipEncoderApi.md#getchipconfiguration) | **GET** /aida/v1/chipencoder/{jobTemplateId}/configuration |  |
| [**RemoveChipEncodingConfiguration**](ChipEncoderApi.md#removechipencodingconfiguration) | **DELETE** /aida/v1/chipencoder/{jobTemplateId}/configuration |  |
| [**UpdateChipConfiguration**](ChipEncoderApi.md#updatechipconfiguration) | **POST** /aida/v1/chipencoder/{jobTemplateId}/configuration |  |

<a name="getchipconfiguration"></a>
# **GetChipConfiguration**
> ChipEncodingConfigurationDto GetChipConfiguration (int jobTemplateId)



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
    public class GetChipConfigurationExample
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
            var apiInstance = new ChipEncoderApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 

            try
            {
                ChipEncodingConfigurationDto result = apiInstance.GetChipConfiguration(jobTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChipEncoderApi.GetChipConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChipConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChipEncodingConfigurationDto> response = apiInstance.GetChipConfigurationWithHttpInfo(jobTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChipEncoderApi.GetChipConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |

### Return type

[**ChipEncodingConfigurationDto**](ChipEncodingConfigurationDto.md)

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

<a name="removechipencodingconfiguration"></a>
# **RemoveChipEncodingConfiguration**
> ChipEncodingConfigurationDto RemoveChipEncodingConfiguration (int jobTemplateId)



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
    public class RemoveChipEncodingConfigurationExample
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
            var apiInstance = new ChipEncoderApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 

            try
            {
                ChipEncodingConfigurationDto result = apiInstance.RemoveChipEncodingConfiguration(jobTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChipEncoderApi.RemoveChipEncodingConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveChipEncodingConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChipEncodingConfigurationDto> response = apiInstance.RemoveChipEncodingConfigurationWithHttpInfo(jobTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChipEncoderApi.RemoveChipEncodingConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |

### Return type

[**ChipEncodingConfigurationDto**](ChipEncodingConfigurationDto.md)

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

<a name="updatechipconfiguration"></a>
# **UpdateChipConfiguration**
> void UpdateChipConfiguration (int jobTemplateId, ChipEncodingConfigurationDto chipEncodingConfigurationDto = null)



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
    public class UpdateChipConfigurationExample
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
            var apiInstance = new ChipEncoderApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 
            var chipEncodingConfigurationDto = new ChipEncodingConfigurationDto(); // ChipEncodingConfigurationDto |  (optional) 

            try
            {
                apiInstance.UpdateChipConfiguration(jobTemplateId, chipEncodingConfigurationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChipEncoderApi.UpdateChipConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateChipConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateChipConfigurationWithHttpInfo(jobTemplateId, chipEncodingConfigurationDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChipEncoderApi.UpdateChipConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |
| **chipEncodingConfigurationDto** | [**ChipEncodingConfigurationDto**](ChipEncodingConfigurationDto.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

