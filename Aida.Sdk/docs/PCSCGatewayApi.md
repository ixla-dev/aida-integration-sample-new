# Aida.Sdk.Api.PCSCGatewayApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EstablishContext**](PCSCGatewayApi.md#establishcontext) | **POST** /api/v1/pcsc-gateway/establish-context | AIDA Server invokes ScEstablishContext on startup. If for any reason the current context becomes invalid (usb cable  disconnected for example) you can use this endpoint to re-establish a new PcScContext. |
| [**GetReader**](PCSCGatewayApi.md#getreader) | **GET** /api/v1/pcsc-gateway/readers/{readerIndex} | Return the list of available readers |
| [**GetReaders**](PCSCGatewayApi.md#getreaders) | **GET** /api/v1/pcsc-gateway/readers | Return the list of available readers |
| [**GetSmartCardAtr**](PCSCGatewayApi.md#getsmartcardatr) | **GET** /api/v1/pcsc-gateway/{readerIndex}/smart-card/atr | Invokes SCardConnect on the specified reader and tries to read the ATR  from the card currently present in the reader |
| [**GetSmartCardStatus**](PCSCGatewayApi.md#getsmartcardstatus) | **GET** /api/v1/pcsc-gateway/{readerIndex}/smart-card/status | Invoke SCardStatus on the specified reader |
| [**ReleaseContext**](PCSCGatewayApi.md#releasecontext) | **POST** /api/v1/pcsc-gateway/release-context |  |
| [**SmartCardConnect**](PCSCGatewayApi.md#smartcardconnect) | **POST** /api/v1/pcsc-gateway/{readerIndex}/smart-card/connect | Invoke SCardConnect on the specified reader. The card handle (hCard) is held server side  until the next time Connect is invoked |
| [**SmartCardDisconnect**](PCSCGatewayApi.md#smartcarddisconnect) | **POST** /api/v1/pcsc-gateway/{readerIndex}/smart-card/disconnect | Invoke SCardDisconnect on the specified reader |
| [**SmartCardReconnect**](PCSCGatewayApi.md#smartcardreconnect) | **POST** /api/v1/pcsc-gateway/{readerIndex}/smart-card/reconnect | Invoke SCardReconnect on the specified reader |
| [**Transmit**](PCSCGatewayApi.md#transmit) | **POST** /api/v1/pcsc-gateway/{readerIndex}/smart-card/transmit | Invoke SCardTransmit on the specified reader |

<a name="establishcontext"></a>
# **EstablishContext**
> void EstablishContext (SCardEstablishContextParamsDto sCardEstablishContextParamsDto = null)

AIDA Server invokes ScEstablishContext on startup. If for any reason the current context becomes invalid (usb cable  disconnected for example) you can use this endpoint to re-establish a new PcScContext.

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
    public class EstablishContextExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);
            var sCardEstablishContextParamsDto = new SCardEstablishContextParamsDto(); // SCardEstablishContextParamsDto |  (optional) 

            try
            {
                // AIDA Server invokes ScEstablishContext on startup. If for any reason the current context becomes invalid (usb cable  disconnected for example) you can use this endpoint to re-establish a new PcScContext.
                apiInstance.EstablishContext(sCardEstablishContextParamsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.EstablishContext: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EstablishContextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // AIDA Server invokes ScEstablishContext on startup. If for any reason the current context becomes invalid (usb cable  disconnected for example) you can use this endpoint to re-establish a new PcScContext.
    apiInstance.EstablishContextWithHttpInfo(sCardEstablishContextParamsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.EstablishContextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sCardEstablishContextParamsDto** | [**SCardEstablishContextParamsDto**](SCardEstablishContextParamsDto.md) |  | [optional]  |

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

<a name="getreader"></a>
# **GetReader**
> SCardReader GetReader (int readerIndex)

Return the list of available readers

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
    public class GetReaderExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 

            try
            {
                // Return the list of available readers
                SCardReader result = apiInstance.GetReader(readerIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.GetReader: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReaderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return the list of available readers
    ApiResponse<SCardReader> response = apiInstance.GetReaderWithHttpInfo(readerIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.GetReaderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readerIndex** | **int** |  |  |

### Return type

[**SCardReader**](SCardReader.md)

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

<a name="getreaders"></a>
# **GetReaders**
> List&lt;SCardReader&gt; GetReaders ()

Return the list of available readers

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
    public class GetReadersExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);

            try
            {
                // Return the list of available readers
                List<SCardReader> result = apiInstance.GetReaders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.GetReaders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReadersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return the list of available readers
    ApiResponse<List<SCardReader>> response = apiInstance.GetReadersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.GetReadersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SCardReader&gt;**](SCardReader.md)

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

<a name="getsmartcardatr"></a>
# **GetSmartCardAtr**
> byte[] GetSmartCardAtr (int readerIndex)

Invokes SCardConnect on the specified reader and tries to read the ATR  from the card currently present in the reader

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
    public class GetSmartCardAtrExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 

            try
            {
                // Invokes SCardConnect on the specified reader and tries to read the ATR  from the card currently present in the reader
                byte[] result = apiInstance.GetSmartCardAtr(readerIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.GetSmartCardAtr: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmartCardAtrWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invokes SCardConnect on the specified reader and tries to read the ATR  from the card currently present in the reader
    ApiResponse<byte[]> response = apiInstance.GetSmartCardAtrWithHttpInfo(readerIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.GetSmartCardAtrWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readerIndex** | **int** |  |  |

### Return type

**byte[]**

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

<a name="getsmartcardstatus"></a>
# **GetSmartCardStatus**
> SCardState GetSmartCardStatus (int readerIndex)

Invoke SCardStatus on the specified reader

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
    public class GetSmartCardStatusExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 

            try
            {
                // Invoke SCardStatus on the specified reader
                SCardState result = apiInstance.GetSmartCardStatus(readerIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.GetSmartCardStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmartCardStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invoke SCardStatus on the specified reader
    ApiResponse<SCardState> response = apiInstance.GetSmartCardStatusWithHttpInfo(readerIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.GetSmartCardStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readerIndex** | **int** |  |  |

### Return type

[**SCardState**](SCardState.md)

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

<a name="releasecontext"></a>
# **ReleaseContext**
> void ReleaseContext ()



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
    public class ReleaseContextExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ReleaseContext();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.ReleaseContext: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReleaseContextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ReleaseContextWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.ReleaseContextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a name="smartcardconnect"></a>
# **SmartCardConnect**
> PcScConnectResult SmartCardConnect (int readerIndex, SCardConnectParamsDto sCardConnectParamsDto = null)

Invoke SCardConnect on the specified reader. The card handle (hCard) is held server side  until the next time Connect is invoked

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
    public class SmartCardConnectExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 
            var sCardConnectParamsDto = new SCardConnectParamsDto(); // SCardConnectParamsDto |  (optional) 

            try
            {
                // Invoke SCardConnect on the specified reader. The card handle (hCard) is held server side  until the next time Connect is invoked
                PcScConnectResult result = apiInstance.SmartCardConnect(readerIndex, sCardConnectParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.SmartCardConnect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmartCardConnectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invoke SCardConnect on the specified reader. The card handle (hCard) is held server side  until the next time Connect is invoked
    ApiResponse<PcScConnectResult> response = apiInstance.SmartCardConnectWithHttpInfo(readerIndex, sCardConnectParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.SmartCardConnectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readerIndex** | **int** |  |  |
| **sCardConnectParamsDto** | [**SCardConnectParamsDto**](SCardConnectParamsDto.md) |  | [optional]  |

### Return type

[**PcScConnectResult**](PcScConnectResult.md)

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

<a name="smartcarddisconnect"></a>
# **SmartCardDisconnect**
> PCSCActionResultDto SmartCardDisconnect (int readerIndex, SCardDisconnectParamsDto sCardDisconnectParamsDto = null)

Invoke SCardDisconnect on the specified reader

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
    public class SmartCardDisconnectExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 
            var sCardDisconnectParamsDto = new SCardDisconnectParamsDto(); // SCardDisconnectParamsDto |  (optional) 

            try
            {
                // Invoke SCardDisconnect on the specified reader
                PCSCActionResultDto result = apiInstance.SmartCardDisconnect(readerIndex, sCardDisconnectParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.SmartCardDisconnect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmartCardDisconnectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invoke SCardDisconnect on the specified reader
    ApiResponse<PCSCActionResultDto> response = apiInstance.SmartCardDisconnectWithHttpInfo(readerIndex, sCardDisconnectParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.SmartCardDisconnectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readerIndex** | **int** |  |  |
| **sCardDisconnectParamsDto** | [**SCardDisconnectParamsDto**](SCardDisconnectParamsDto.md) |  | [optional]  |

### Return type

[**PCSCActionResultDto**](PCSCActionResultDto.md)

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

<a name="smartcardreconnect"></a>
# **SmartCardReconnect**
> void SmartCardReconnect (int readerIndex, SCardReconnectParamsDto sCardReconnectParamsDto = null)

Invoke SCardReconnect on the specified reader

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
    public class SmartCardReconnectExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 
            var sCardReconnectParamsDto = new SCardReconnectParamsDto(); // SCardReconnectParamsDto |  (optional) 

            try
            {
                // Invoke SCardReconnect on the specified reader
                apiInstance.SmartCardReconnect(readerIndex, sCardReconnectParamsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.SmartCardReconnect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmartCardReconnectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invoke SCardReconnect on the specified reader
    apiInstance.SmartCardReconnectWithHttpInfo(readerIndex, sCardReconnectParamsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.SmartCardReconnectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readerIndex** | **int** |  |  |
| **sCardReconnectParamsDto** | [**SCardReconnectParamsDto**](SCardReconnectParamsDto.md) |  | [optional]  |

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

<a name="transmit"></a>
# **Transmit**
> byte[] Transmit (int readerIndex, byte[] body = null)

Invoke SCardTransmit on the specified reader

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
    public class TransmitExample
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
            var apiInstance = new PCSCGatewayApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | The reader id
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] |  (optional) 

            try
            {
                // Invoke SCardTransmit on the specified reader
                byte[] result = apiInstance.Transmit(readerIndex, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PCSCGatewayApi.Transmit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransmitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invoke SCardTransmit on the specified reader
    ApiResponse<byte[]> response = apiInstance.TransmitWithHttpInfo(readerIndex, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PCSCGatewayApi.TransmitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readerIndex** | **int** | The reader id |  |
| **body** | **byte[]** |  | [optional]  |

### Return type

**byte[]**

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

