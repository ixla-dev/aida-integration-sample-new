# Aida.Sdk.Api.MachineEventsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LaserBoardStateChanged**](MachineEventsApi.md#laserboardstatechanged) | **POST** /aida/v1/machine-events/laser-board/state-changed |  |

<a name="laserboardstatechanged"></a>
# **LaserBoardStateChanged**
> void LaserBoardStateChanged (LaserBoardStateChangedEventNotification laserBoardStateChangedEventNotification = null)



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
    public class LaserBoardStateChangedExample
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
            var apiInstance = new MachineEventsApi(httpClient, config, httpClientHandler);
            var laserBoardStateChangedEventNotification = new LaserBoardStateChangedEventNotification(); // LaserBoardStateChangedEventNotification |  (optional) 

            try
            {
                apiInstance.LaserBoardStateChanged(laserBoardStateChangedEventNotification);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MachineEventsApi.LaserBoardStateChanged: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LaserBoardStateChangedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LaserBoardStateChangedWithHttpInfo(laserBoardStateChangedEventNotification);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MachineEventsApi.LaserBoardStateChangedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **laserBoardStateChangedEventNotification** | [**LaserBoardStateChangedEventNotification**](LaserBoardStateChangedEventNotification.md) |  | [optional]  |

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

