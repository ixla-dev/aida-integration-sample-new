# Aida.Sdk.Api.MagneticEncoderApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMagneticConfiguration**](MagneticEncoderApi.md#getmagneticconfiguration) | **GET** /aida/v1/magneticencoder/{jobTemplateId}/configuration |  |
| [**ReadData**](MagneticEncoderApi.md#readdata) | **GET** /aida/v1/magneticencoder/read |  |
| [**UpdateMagneticConfiguration**](MagneticEncoderApi.md#updatemagneticconfiguration) | **POST** /aida/v1/magneticencoder/{jobTemplateId}/configuration |  |
| [**WriteData**](MagneticEncoderApi.md#writedata) | **POST** /aida/v1/magneticencoder/write |  |

<a name="getmagneticconfiguration"></a>
# **GetMagneticConfiguration**
> MagneticStripeConfigurationDto GetMagneticConfiguration (int jobTemplateId)



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
    public class GetMagneticConfigurationExample
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
            var apiInstance = new MagneticEncoderApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 

            try
            {
                MagneticStripeConfigurationDto result = apiInstance.GetMagneticConfiguration(jobTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagneticEncoderApi.GetMagneticConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMagneticConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MagneticStripeConfigurationDto> response = apiInstance.GetMagneticConfigurationWithHttpInfo(jobTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MagneticEncoderApi.GetMagneticConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |

### Return type

[**MagneticStripeConfigurationDto**](MagneticStripeConfigurationDto.md)

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

<a name="readdata"></a>
# **ReadData**
> MagStripeDataDto ReadData ()



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
    public class ReadDataExample
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
            var apiInstance = new MagneticEncoderApi(httpClient, config, httpClientHandler);

            try
            {
                MagStripeDataDto result = apiInstance.ReadData();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagneticEncoderApi.ReadData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MagStripeDataDto> response = apiInstance.ReadDataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MagneticEncoderApi.ReadDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MagStripeDataDto**](MagStripeDataDto.md)

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

<a name="updatemagneticconfiguration"></a>
# **UpdateMagneticConfiguration**
> void UpdateMagneticConfiguration (int jobTemplateId, MagneticStripeConfigurationDto magneticStripeConfigurationDto = null)



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
    public class UpdateMagneticConfigurationExample
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
            var apiInstance = new MagneticEncoderApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 
            var magneticStripeConfigurationDto = new MagneticStripeConfigurationDto(); // MagneticStripeConfigurationDto |  (optional) 

            try
            {
                apiInstance.UpdateMagneticConfiguration(jobTemplateId, magneticStripeConfigurationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagneticEncoderApi.UpdateMagneticConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMagneticConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateMagneticConfigurationWithHttpInfo(jobTemplateId, magneticStripeConfigurationDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MagneticEncoderApi.UpdateMagneticConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |
| **magneticStripeConfigurationDto** | [**MagneticStripeConfigurationDto**](MagneticStripeConfigurationDto.md) |  | [optional]  |

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

<a name="writedata"></a>
# **WriteData**
> void WriteData (bool? useHiCoercivity = null, MagStripeDataDto magStripeDataDto = null)



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
    public class WriteDataExample
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
            var apiInstance = new MagneticEncoderApi(httpClient, config, httpClientHandler);
            var useHiCoercivity = false;  // bool? |  (optional)  (default to false)
            var magStripeDataDto = new MagStripeDataDto(); // MagStripeDataDto |  (optional) 

            try
            {
                apiInstance.WriteData(useHiCoercivity, magStripeDataDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MagneticEncoderApi.WriteData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteDataWithHttpInfo(useHiCoercivity, magStripeDataDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MagneticEncoderApi.WriteDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **useHiCoercivity** | **bool?** |  | [optional] [default to false] |
| **magStripeDataDto** | [**MagStripeDataDto**](MagStripeDataDto.md) |  | [optional]  |

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

