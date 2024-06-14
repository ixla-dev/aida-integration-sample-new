# Aida.Sdk.Mini.Api.IntegrationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateJobTemplate**](IntegrationApi.md#createjobtemplate) | **POST** /aida/v1/scanner/job-templates |  |
| [**CreateWebhooksTarget**](IntegrationApi.md#createwebhookstarget) | **POST** /aida/v1/webhooks-targets |  |
| [**DeleteInkjetLayout**](IntegrationApi.md#deleteinkjetlayout) | **DELETE** /aida/v1/inkjet/layouts/{id} |  |
| [**DeleteJobTemplate**](IntegrationApi.md#deletejobtemplate) | **DELETE** /aida/v1/scanner/job-templates/{id} |  |
| [**DeleteLayout**](IntegrationApi.md#deletelayout) | **DELETE** /aida/v1/scanner/layouts/{id} |  |
| [**DeleteWebhooksTarget**](IntegrationApi.md#deletewebhookstarget) | **DELETE** /aida/v1/webhooks-targets/{id} |  |
| [**EstablishContext**](IntegrationApi.md#establishcontext) | **POST** /api/v1/pcsc-gateway/establish-context | AIDA Server invokes ScEstablishContext on startup. If for any reason the current context becomes invalid (usb cable  disconnected for example) you can use this endpoint to re-establish a new PcScContext. |
| [**FindInkjetLayouts**](IntegrationApi.md#findinkjetlayouts) | **GET** /aida/v1/inkjet/layouts/find |  |
| [**FindJobTemplates**](IntegrationApi.md#findjobtemplates) | **GET** /aida/v1/scanner/job-templates |  |
| [**FindLayouts**](IntegrationApi.md#findlayouts) | **GET** /aida/v1/scanner/layouts |  |
| [**FindWebhooksTargets**](IntegrationApi.md#findwebhookstargets) | **GET** /aida/v1/webhooks-targets |  |
| [**GetAssignableInkjetLayoutsByJobTemplateId**](IntegrationApi.md#getassignableinkjetlayoutsbyjobtemplateid) | **GET** /aida/v1/inkjet/job-templates/{id}/layouts/available |  |
| [**GetAssignableLayoutsByJobTemplateId**](IntegrationApi.md#getassignablelayoutsbyjobtemplateid) | **GET** /aida/v1/scanner/job-templates/{id}/layouts/available |  |
| [**GetAssignedLayoutsByJobTemplateId**](IntegrationApi.md#getassignedlayoutsbyjobtemplateid) | **GET** /aida/v1/scanner/job-templates/{id}/layouts/assigned |  |
| [**GetDataExchangeTableDefinition**](IntegrationApi.md#getdataexchangetabledefinition) | **GET** /aida/v1/etl/{jobId}/exchange-table-ddl |  |
| [**GetEntityDescriptorsByJobTemplateId**](IntegrationApi.md#getentitydescriptorsbyjobtemplateid) | **GET** /aida/v1/etl/{jobId}/entities |  |
| [**GetJobTemplateById**](IntegrationApi.md#getjobtemplatebyid) | **GET** /aida/v1/scanner/job-templates/{id} |  |
| [**GetLayoutById**](IntegrationApi.md#getlayoutbyid) | **GET** /aida/v1/scanner/layouts/{id} |  |
| [**GetMetrics**](IntegrationApi.md#getmetrics) | **GET** /aida/v1/workflow-scheduler/metrics |  |
| [**GetQueuedJobs**](IntegrationApi.md#getqueuedjobs) | **GET** /aida/v1/workflow-scheduler/queued-jobs |  |
| [**GetReader**](IntegrationApi.md#getreader) | **GET** /api/v1/pcsc-gateway/readers/{readerIndex} | Return the list of available readers |
| [**GetReaders**](IntegrationApi.md#getreaders) | **GET** /api/v1/pcsc-gateway/readers | Return the list of available readers |
| [**GetRunningWorkflows**](IntegrationApi.md#getrunningworkflows) | **GET** /aida/v1/workflow-scheduler/workflows/running |  |
| [**GetSmartCardAtr**](IntegrationApi.md#getsmartcardatr) | **GET** /api/v1/pcsc-gateway/{readerIndex}/smart-card/atr | Invokes SCardConnect on the specified reader and tries to read the ATR  from the card currently present in the reader |
| [**GetSmartCardStatus**](IntegrationApi.md#getsmartcardstatus) | **GET** /api/v1/pcsc-gateway/{readerIndex}/smart-card/status | Invoke SCardStatus on the specified reader |
| [**GetWebhooksTargetById**](IntegrationApi.md#getwebhookstargetbyid) | **GET** /aida/v1/webhooks-targets/{id} |  |
| [**GetWorkflowRegistry**](IntegrationApi.md#getworkflowregistry) | **GET** /aida/v1/workflow-scheduler/workflow-registry |  |
| [**GetWorkflowSchedulerState**](IntegrationApi.md#getworkflowschedulerstate) | **GET** /aida/v1/workflow-scheduler/state |  |
| [**ImportLayoutFile**](IntegrationApi.md#importlayoutfile) | **POST** /aida/v1/scanner/layouts/import |  |
| [**ImportLayoutFileValidation**](IntegrationApi.md#importlayoutfilevalidation) | **GET** /aida/v1/scanner/layouts/import/_validate |  |
| [**ReleaseContext**](IntegrationApi.md#releasecontext) | **POST** /api/v1/pcsc-gateway/release-context |  |
| [**RenameInkjetLayout**](IntegrationApi.md#renameinkjetlayout) | **PUT** /aida/v1/inkjet/layouts/{id} |  |
| [**RenameLayout**](IntegrationApi.md#renamelayout) | **PUT** /aida/v1/scanner/layouts/{id} |  |
| [**ResumeWorkflowScheduler**](IntegrationApi.md#resumeworkflowscheduler) | **POST** /aida/v1/workflow-scheduler/resume |  |
| [**SignalExternalProcessCompleted**](IntegrationApi.md#signalexternalprocesscompleted) | **POST** /aida/v1/workflow-scheduler/workflows/signal/external-process-completed | Notifies a suspended workflow instance when that the external process has completed execution |
| [**SmartCardConnect**](IntegrationApi.md#smartcardconnect) | **POST** /api/v1/pcsc-gateway/{readerIndex}/smart-card/connect | Invoke SCardConnect on the specified reader. The card handle (hCard) is held server side  until the next time Connect is invoked |
| [**SmartCardDisconnect**](IntegrationApi.md#smartcarddisconnect) | **POST** /api/v1/pcsc-gateway/{readerIndex}/smart-card/disconnect | Invoke SCardDisconnect on the specified reader |
| [**SmartCardReconnect**](IntegrationApi.md#smartcardreconnect) | **POST** /api/v1/pcsc-gateway/{readerIndex}/smart-card/reconnect | Invoke SCardReconnect on the specified reader |
| [**StartWorkflowScheduler**](IntegrationApi.md#startworkflowscheduler) | **POST** /aida/v1/workflow-scheduler/start |  |
| [**StopWorkflowScheduler**](IntegrationApi.md#stopworkflowscheduler) | **POST** /aida/v1/workflow-scheduler/stop |  |
| [**TestWebhookTarget**](IntegrationApi.md#testwebhooktarget) | **POST** /aida/v1/webhooks-targets/{id} |  |
| [**Transmit**](IntegrationApi.md#transmit) | **POST** /api/v1/pcsc-gateway/{readerIndex}/smart-card/transmit | Invoke SCardTransmit on the specified reader |
| [**UpdateWebhooksTarget**](IntegrationApi.md#updatewebhookstarget) | **PUT** /aida/v1/webhooks-targets |  |
| [**UploadLayoutFile**](IntegrationApi.md#uploadlayoutfile) | **POST** /aida/v1/scanner/layouts/upload |  |
| [**ValidateInkjetLayoutName**](IntegrationApi.md#validateinkjetlayoutname) | **POST** /aida/v1/inkjet/layouts/validate-name |  |
| [**ValidateJobTemplateName**](IntegrationApi.md#validatejobtemplatename) | **POST** /aida/v1/scanner/job-templates/validate-name |  |
| [**ValidateLayoutName**](IntegrationApi.md#validatelayoutname) | **POST** /aida/v1/scanner/layouts/validate-name |  |

<a name="createjobtemplate"></a>
# **CreateJobTemplate**
> JobTemplateDto CreateJobTemplate (string scannerId = null, CreateJobTemplateDto createJobTemplateDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class CreateJobTemplateExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var createJobTemplateDto = new CreateJobTemplateDto(); // CreateJobTemplateDto |  (optional) 

            try
            {
                JobTemplateDto result = apiInstance.CreateJobTemplate(scannerId, createJobTemplateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.CreateJobTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateJobTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JobTemplateDto> response = apiInstance.CreateJobTemplateWithHttpInfo(scannerId, createJobTemplateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.CreateJobTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **createJobTemplateDto** | [**CreateJobTemplateDto**](CreateJobTemplateDto.md) |  | [optional]  |

### Return type

[**JobTemplateDto**](JobTemplateDto.md)

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

<a name="createwebhookstarget"></a>
# **CreateWebhooksTarget**
> WebhooksTargetDto CreateWebhooksTarget (WebhooksTargetDto webhooksTargetDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class CreateWebhooksTargetExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var webhooksTargetDto = new WebhooksTargetDto(); // WebhooksTargetDto |  (optional) 

            try
            {
                WebhooksTargetDto result = apiInstance.CreateWebhooksTarget(webhooksTargetDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.CreateWebhooksTarget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWebhooksTargetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebhooksTargetDto> response = apiInstance.CreateWebhooksTargetWithHttpInfo(webhooksTargetDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.CreateWebhooksTargetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhooksTargetDto** | [**WebhooksTargetDto**](WebhooksTargetDto.md) |  | [optional]  |

### Return type

[**WebhooksTargetDto**](WebhooksTargetDto.md)

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

<a name="deleteinkjetlayout"></a>
# **DeleteInkjetLayout**
> void DeleteInkjetLayout (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class DeleteInkjetLayoutExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                apiInstance.DeleteInkjetLayout(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteInkjetLayoutWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.DeleteInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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

<a name="deletejobtemplate"></a>
# **DeleteJobTemplate**
> void DeleteJobTemplate (int id, string scannerId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class DeleteJobTemplateExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var scannerId = "scannerId_example";  // string |  (optional) 

            try
            {
                apiInstance.DeleteJobTemplate(id, scannerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteJobTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteJobTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteJobTemplateWithHttpInfo(id, scannerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.DeleteJobTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **scannerId** | **string** |  | [optional]  |

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

<a name="deletelayout"></a>
# **DeleteLayout**
> void DeleteLayout (int id, string scannerId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class DeleteLayoutExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var scannerId = "scannerId_example";  // string |  (optional) 

            try
            {
                apiInstance.DeleteLayout(id, scannerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteLayoutWithHttpInfo(id, scannerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.DeleteLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **scannerId** | **string** |  | [optional]  |

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

<a name="deletewebhookstarget"></a>
# **DeleteWebhooksTarget**
> WebhooksTargetDto DeleteWebhooksTarget (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class DeleteWebhooksTargetExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                WebhooksTargetDto result = apiInstance.DeleteWebhooksTarget(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteWebhooksTarget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhooksTargetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebhooksTargetDto> response = apiInstance.DeleteWebhooksTargetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.DeleteWebhooksTargetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**WebhooksTargetDto**](WebhooksTargetDto.md)

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

<a name="establishcontext"></a>
# **EstablishContext**
> void EstablishContext (SCardEstablishContextParamsDto sCardEstablishContextParamsDto = null)

AIDA Server invokes ScEstablishContext on startup. If for any reason the current context becomes invalid (usb cable  disconnected for example) you can use this endpoint to re-establish a new PcScContext.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var sCardEstablishContextParamsDto = new SCardEstablishContextParamsDto(); // SCardEstablishContextParamsDto |  (optional) 

            try
            {
                // AIDA Server invokes ScEstablishContext on startup. If for any reason the current context becomes invalid (usb cable  disconnected for example) you can use this endpoint to re-establish a new PcScContext.
                apiInstance.EstablishContext(sCardEstablishContextParamsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.EstablishContext: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.EstablishContextWithHttpInfo: " + e.Message);
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

<a name="findinkjetlayouts"></a>
# **FindInkjetLayouts**
> SearchInkjetLayoutsResultDto FindInkjetLayouts (bool? includeFile = null, bool? includeEntities = null, int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class FindInkjetLayoutsExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var includeFile = true;  // bool? |  (optional) 
            var includeEntities = true;  // bool? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                SearchInkjetLayoutsResultDto result = apiInstance.FindInkjetLayouts(includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.FindInkjetLayouts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindInkjetLayoutsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchInkjetLayoutsResultDto> response = apiInstance.FindInkjetLayoutsWithHttpInfo(includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.FindInkjetLayoutsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeFile** | **bool?** |  | [optional]  |
| **includeEntities** | **bool?** |  | [optional]  |
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**SearchInkjetLayoutsResultDto**](SearchInkjetLayoutsResultDto.md)

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

<a name="findjobtemplates"></a>
# **FindJobTemplates**
> SearchJobTemplatesResultDto FindJobTemplates (string scannerId = null, bool? includeLayouts = null, bool? includeFile = null, bool? includeEntities = null, int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class FindJobTemplatesExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var includeLayouts = true;  // bool? |  (optional) 
            var includeFile = true;  // bool? |  (optional) 
            var includeEntities = true;  // bool? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                SearchJobTemplatesResultDto result = apiInstance.FindJobTemplates(scannerId, includeLayouts, includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.FindJobTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindJobTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchJobTemplatesResultDto> response = apiInstance.FindJobTemplatesWithHttpInfo(scannerId, includeLayouts, includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.FindJobTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **includeLayouts** | **bool?** |  | [optional]  |
| **includeFile** | **bool?** |  | [optional]  |
| **includeEntities** | **bool?** |  | [optional]  |
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**SearchJobTemplatesResultDto**](SearchJobTemplatesResultDto.md)

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

<a name="findlayouts"></a>
# **FindLayouts**
> SearchLayoutsResultDto FindLayouts (string scannerId = null, bool? includeFile = null, bool? includeEntities = null, int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class FindLayoutsExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var includeFile = true;  // bool? |  (optional) 
            var includeEntities = true;  // bool? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                SearchLayoutsResultDto result = apiInstance.FindLayouts(scannerId, includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.FindLayouts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindLayoutsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchLayoutsResultDto> response = apiInstance.FindLayoutsWithHttpInfo(scannerId, includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.FindLayoutsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **includeFile** | **bool?** |  | [optional]  |
| **includeEntities** | **bool?** |  | [optional]  |
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**SearchLayoutsResultDto**](SearchLayoutsResultDto.md)

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

<a name="findwebhookstargets"></a>
# **FindWebhooksTargets**
> SearchWebhooksTargetsResultDto FindWebhooksTargets (int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class FindWebhooksTargetsExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                SearchWebhooksTargetsResultDto result = apiInstance.FindWebhooksTargets(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.FindWebhooksTargets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindWebhooksTargetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchWebhooksTargetsResultDto> response = apiInstance.FindWebhooksTargetsWithHttpInfo(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.FindWebhooksTargetsWithHttpInfo: " + e.Message);
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

[**SearchWebhooksTargetsResultDto**](SearchWebhooksTargetsResultDto.md)

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

<a name="getassignableinkjetlayoutsbyjobtemplateid"></a>
# **GetAssignableInkjetLayoutsByJobTemplateId**
> SearchInkjetLayoutsResultDto GetAssignableInkjetLayoutsByJobTemplateId (int id, int? page = null, int? pageSize = null, string supportSide = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetAssignableInkjetLayoutsByJobTemplateIdExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 15;  // int? |  (optional)  (default to 15)
            var supportSide = "supportSide_example";  // string |  (optional) 

            try
            {
                SearchInkjetLayoutsResultDto result = apiInstance.GetAssignableInkjetLayoutsByJobTemplateId(id, page, pageSize, supportSide);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetAssignableInkjetLayoutsByJobTemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchInkjetLayoutsResultDto> response = apiInstance.GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo(id, page, pageSize, supportSide);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 15] |
| **supportSide** | **string** |  | [optional]  |

### Return type

[**SearchInkjetLayoutsResultDto**](SearchInkjetLayoutsResultDto.md)

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

<a name="getassignablelayoutsbyjobtemplateid"></a>
# **GetAssignableLayoutsByJobTemplateId**
> SearchLayoutsResultDto GetAssignableLayoutsByJobTemplateId (int id, int? page = null, int? pageSize = null, string supportSide = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetAssignableLayoutsByJobTemplateIdExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 15;  // int? |  (optional)  (default to 15)
            var supportSide = "supportSide_example";  // string |  (optional) 

            try
            {
                SearchLayoutsResultDto result = apiInstance.GetAssignableLayoutsByJobTemplateId(id, page, pageSize, supportSide);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetAssignableLayoutsByJobTemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssignableLayoutsByJobTemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchLayoutsResultDto> response = apiInstance.GetAssignableLayoutsByJobTemplateIdWithHttpInfo(id, page, pageSize, supportSide);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetAssignableLayoutsByJobTemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 15] |
| **supportSide** | **string** |  | [optional]  |

### Return type

[**SearchLayoutsResultDto**](SearchLayoutsResultDto.md)

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

<a name="getassignedlayoutsbyjobtemplateid"></a>
# **GetAssignedLayoutsByJobTemplateId**
> SearchJobLayoutsResultDto GetAssignedLayoutsByJobTemplateId (int id, int? page = null, int? pageSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetAssignedLayoutsByJobTemplateIdExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 15;  // int? |  (optional)  (default to 15)

            try
            {
                SearchJobLayoutsResultDto result = apiInstance.GetAssignedLayoutsByJobTemplateId(id, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetAssignedLayoutsByJobTemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssignedLayoutsByJobTemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchJobLayoutsResultDto> response = apiInstance.GetAssignedLayoutsByJobTemplateIdWithHttpInfo(id, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetAssignedLayoutsByJobTemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 15] |

### Return type

[**SearchJobLayoutsResultDto**](SearchJobLayoutsResultDto.md)

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

<a name="getdataexchangetabledefinition"></a>
# **GetDataExchangeTableDefinition**
> DataExchangeTableDefinition GetDataExchangeTableDefinition (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetDataExchangeTableDefinitionExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                DataExchangeTableDefinition result = apiInstance.GetDataExchangeTableDefinition(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetDataExchangeTableDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataExchangeTableDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DataExchangeTableDefinition> response = apiInstance.GetDataExchangeTableDefinitionWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetDataExchangeTableDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

[**DataExchangeTableDefinition**](DataExchangeTableDefinition.md)

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

<a name="getentitydescriptorsbyjobtemplateid"></a>
# **GetEntityDescriptorsByJobTemplateId**
> List&lt;EntityDescriptor&gt; GetEntityDescriptorsByJobTemplateId (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetEntityDescriptorsByJobTemplateIdExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                List<EntityDescriptor> result = apiInstance.GetEntityDescriptorsByJobTemplateId(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetEntityDescriptorsByJobTemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEntityDescriptorsByJobTemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<EntityDescriptor>> response = apiInstance.GetEntityDescriptorsByJobTemplateIdWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetEntityDescriptorsByJobTemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

[**List&lt;EntityDescriptor&gt;**](EntityDescriptor.md)

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

<a name="getjobtemplatebyid"></a>
# **GetJobTemplateById**
> JobTemplateDto GetJobTemplateById (int id, string scannerId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetJobTemplateByIdExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var scannerId = "scannerId_example";  // string |  (optional) 

            try
            {
                JobTemplateDto result = apiInstance.GetJobTemplateById(id, scannerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetJobTemplateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJobTemplateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JobTemplateDto> response = apiInstance.GetJobTemplateByIdWithHttpInfo(id, scannerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetJobTemplateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **scannerId** | **string** |  | [optional]  |

### Return type

[**JobTemplateDto**](JobTemplateDto.md)

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

<a name="getlayoutbyid"></a>
# **GetLayoutById**
> LayoutDto GetLayoutById (int id, string scannerId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetLayoutByIdExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var scannerId = "scannerId_example";  // string |  (optional) 

            try
            {
                LayoutDto result = apiInstance.GetLayoutById(id, scannerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetLayoutById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLayoutByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LayoutDto> response = apiInstance.GetLayoutByIdWithHttpInfo(id, scannerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetLayoutByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **scannerId** | **string** |  | [optional]  |

### Return type

[**LayoutDto**](LayoutDto.md)

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

<a name="getmetrics"></a>
# **GetMetrics**
> RuntimeMetrics GetMetrics ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetMetricsExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);

            try
            {
                RuntimeMetrics result = apiInstance.GetMetrics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetMetrics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RuntimeMetrics> response = apiInstance.GetMetricsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetMetricsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RuntimeMetrics**](RuntimeMetrics.md)

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

<a name="getqueuedjobs"></a>
# **GetQueuedJobs**
> List&lt;int&gt; GetQueuedJobs ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetQueuedJobsExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);

            try
            {
                List<int> result = apiInstance.GetQueuedJobs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetQueuedJobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQueuedJobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<int>> response = apiInstance.GetQueuedJobsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetQueuedJobsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<int>**

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

<a name="getreader"></a>
# **GetReader**
> SCardReader GetReader (int readerIndex)

Return the list of available readers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 

            try
            {
                // Return the list of available readers
                SCardReader result = apiInstance.GetReader(readerIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetReader: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.GetReaderWithHttpInfo: " + e.Message);
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
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);

            try
            {
                // Return the list of available readers
                List<SCardReader> result = apiInstance.GetReaders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetReaders: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.GetReadersWithHttpInfo: " + e.Message);
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

<a name="getrunningworkflows"></a>
# **GetRunningWorkflows**
> List&lt;WorkflowInstanceSummaryModel&gt; GetRunningWorkflows ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetRunningWorkflowsExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);

            try
            {
                List<WorkflowInstanceSummaryModel> result = apiInstance.GetRunningWorkflows();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetRunningWorkflows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunningWorkflowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WorkflowInstanceSummaryModel>> response = apiInstance.GetRunningWorkflowsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetRunningWorkflowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;WorkflowInstanceSummaryModel&gt;**](WorkflowInstanceSummaryModel.md)

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
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 

            try
            {
                // Invokes SCardConnect on the specified reader and tries to read the ATR  from the card currently present in the reader
                byte[] result = apiInstance.GetSmartCardAtr(readerIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetSmartCardAtr: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.GetSmartCardAtrWithHttpInfo: " + e.Message);
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
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 

            try
            {
                // Invoke SCardStatus on the specified reader
                SCardState result = apiInstance.GetSmartCardStatus(readerIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetSmartCardStatus: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.GetSmartCardStatusWithHttpInfo: " + e.Message);
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

<a name="getwebhookstargetbyid"></a>
# **GetWebhooksTargetById**
> WebhooksTargetDto GetWebhooksTargetById (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetWebhooksTargetByIdExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                WebhooksTargetDto result = apiInstance.GetWebhooksTargetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetWebhooksTargetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksTargetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebhooksTargetDto> response = apiInstance.GetWebhooksTargetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetWebhooksTargetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**WebhooksTargetDto**](WebhooksTargetDto.md)

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

<a name="getworkflowregistry"></a>
# **GetWorkflowRegistry**
> WorkflowBlueprintSummaryModelPagedList GetWorkflowRegistry ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetWorkflowRegistryExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);

            try
            {
                WorkflowBlueprintSummaryModelPagedList result = apiInstance.GetWorkflowRegistry();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetWorkflowRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowBlueprintSummaryModelPagedList> response = apiInstance.GetWorkflowRegistryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetWorkflowRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkflowBlueprintSummaryModelPagedList**](WorkflowBlueprintSummaryModelPagedList.md)

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

<a name="getworkflowschedulerstate"></a>
# **GetWorkflowSchedulerState**
> WorkflowSchedulerStateDto GetWorkflowSchedulerState ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class GetWorkflowSchedulerStateExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);

            try
            {
                WorkflowSchedulerStateDto result = apiInstance.GetWorkflowSchedulerState();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetWorkflowSchedulerState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowSchedulerStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowSchedulerStateDto> response = apiInstance.GetWorkflowSchedulerStateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.GetWorkflowSchedulerStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WorkflowSchedulerStateDto**](WorkflowSchedulerStateDto.md)

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

<a name="importlayoutfile"></a>
# **ImportLayoutFile**
> LayoutDto ImportLayoutFile (string scannerId = null, string layoutName = null, string filename = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class ImportLayoutFileExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var layoutName = "layoutName_example";  // string |  (optional) 
            var filename = "filename_example";  // string |  (optional) 

            try
            {
                LayoutDto result = apiInstance.ImportLayoutFile(scannerId, layoutName, filename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportLayoutFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportLayoutFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LayoutDto> response = apiInstance.ImportLayoutFileWithHttpInfo(scannerId, layoutName, filename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.ImportLayoutFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **layoutName** | **string** |  | [optional]  |
| **filename** | **string** |  | [optional]  |

### Return type

[**LayoutDto**](LayoutDto.md)

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

<a name="importlayoutfilevalidation"></a>
# **ImportLayoutFileValidation**
> void ImportLayoutFileValidation (string layoutName = null, string filename = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class ImportLayoutFileValidationExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var layoutName = "layoutName_example";  // string |  (optional) 
            var filename = "filename_example";  // string |  (optional) 

            try
            {
                apiInstance.ImportLayoutFileValidation(layoutName, filename);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ImportLayoutFileValidation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportLayoutFileValidationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ImportLayoutFileValidationWithHttpInfo(layoutName, filename);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.ImportLayoutFileValidationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **layoutName** | **string** |  | [optional]  |
| **filename** | **string** |  | [optional]  |

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

<a name="releasecontext"></a>
# **ReleaseContext**
> void ReleaseContext ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ReleaseContext();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ReleaseContext: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.ReleaseContextWithHttpInfo: " + e.Message);
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

<a name="renameinkjetlayout"></a>
# **RenameInkjetLayout**
> InkjetLayoutDto RenameInkjetLayout (int id, string name = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class RenameInkjetLayoutExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var name = "name_example";  // string |  (optional) 

            try
            {
                InkjetLayoutDto result = apiInstance.RenameInkjetLayout(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.RenameInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetLayoutDto> response = apiInstance.RenameInkjetLayoutWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.RenameInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **name** | **string** |  | [optional]  |

### Return type

[**InkjetLayoutDto**](InkjetLayoutDto.md)

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

<a name="renamelayout"></a>
# **RenameLayout**
> LayoutDto RenameLayout (int id, string name = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class RenameLayoutExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var name = "name_example";  // string |  (optional) 

            try
            {
                LayoutDto result = apiInstance.RenameLayout(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.RenameLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LayoutDto> response = apiInstance.RenameLayoutWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.RenameLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **name** | **string** |  | [optional]  |

### Return type

[**LayoutDto**](LayoutDto.md)

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

<a name="resumeworkflowscheduler"></a>
# **ResumeWorkflowScheduler**
> List&lt;JobInstance&gt; ResumeWorkflowScheduler ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class ResumeWorkflowSchedulerExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);

            try
            {
                List<JobInstance> result = apiInstance.ResumeWorkflowScheduler();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ResumeWorkflowScheduler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResumeWorkflowSchedulerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<JobInstance>> response = apiInstance.ResumeWorkflowSchedulerWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.ResumeWorkflowSchedulerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;JobInstance&gt;**](JobInstance.md)

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

<a name="signalexternalprocesscompleted"></a>
# **SignalExternalProcessCompleted**
> List&lt;JobInstance&gt; SignalExternalProcessCompleted (bool? waitForCompletion = null, ExternalProcessCompletedMessage externalProcessCompletedMessage = null)

Notifies a suspended workflow instance when that the external process has completed execution

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class SignalExternalProcessCompletedExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var waitForCompletion = false;  // bool? | If true, the server will respond once the workflow enters the completed/faulted state (optional)  (default to false)
            var externalProcessCompletedMessage = new ExternalProcessCompletedMessage(); // ExternalProcessCompletedMessage | The External process completed message payload (optional) 

            try
            {
                // Notifies a suspended workflow instance when that the external process has completed execution
                List<JobInstance> result = apiInstance.SignalExternalProcessCompleted(waitForCompletion, externalProcessCompletedMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.SignalExternalProcessCompleted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignalExternalProcessCompletedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notifies a suspended workflow instance when that the external process has completed execution
    ApiResponse<List<JobInstance>> response = apiInstance.SignalExternalProcessCompletedWithHttpInfo(waitForCompletion, externalProcessCompletedMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.SignalExternalProcessCompletedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **waitForCompletion** | **bool?** | If true, the server will respond once the workflow enters the completed/faulted state | [optional] [default to false] |
| **externalProcessCompletedMessage** | [**ExternalProcessCompletedMessage**](ExternalProcessCompletedMessage.md) | The External process completed message payload | [optional]  |

### Return type

[**List&lt;JobInstance&gt;**](JobInstance.md)

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

<a name="smartcardconnect"></a>
# **SmartCardConnect**
> PcScConnectResult SmartCardConnect (int readerIndex, SCardConnectParamsDto sCardConnectParamsDto = null)

Invoke SCardConnect on the specified reader. The card handle (hCard) is held server side  until the next time Connect is invoked

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
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
                Debug.Print("Exception when calling IntegrationApi.SmartCardConnect: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.SmartCardConnectWithHttpInfo: " + e.Message);
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
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
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
                Debug.Print("Exception when calling IntegrationApi.SmartCardDisconnect: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.SmartCardDisconnectWithHttpInfo: " + e.Message);
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
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var readerIndex = 56;  // int | 
            var sCardReconnectParamsDto = new SCardReconnectParamsDto(); // SCardReconnectParamsDto |  (optional) 

            try
            {
                // Invoke SCardReconnect on the specified reader
                apiInstance.SmartCardReconnect(readerIndex, sCardReconnectParamsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.SmartCardReconnect: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.SmartCardReconnectWithHttpInfo: " + e.Message);
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

<a name="startworkflowscheduler"></a>
# **StartWorkflowScheduler**
> WorkflowSchedulerStateDto StartWorkflowScheduler (WorkflowSchedulerStartupParamsDto workflowSchedulerStartupParamsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class StartWorkflowSchedulerExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var workflowSchedulerStartupParamsDto = new WorkflowSchedulerStartupParamsDto(); // WorkflowSchedulerStartupParamsDto |  (optional) 

            try
            {
                WorkflowSchedulerStateDto result = apiInstance.StartWorkflowScheduler(workflowSchedulerStartupParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.StartWorkflowScheduler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartWorkflowSchedulerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowSchedulerStateDto> response = apiInstance.StartWorkflowSchedulerWithHttpInfo(workflowSchedulerStartupParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.StartWorkflowSchedulerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowSchedulerStartupParamsDto** | [**WorkflowSchedulerStartupParamsDto**](WorkflowSchedulerStartupParamsDto.md) |  | [optional]  |

### Return type

[**WorkflowSchedulerStateDto**](WorkflowSchedulerStateDto.md)

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

<a name="stopworkflowscheduler"></a>
# **StopWorkflowScheduler**
> WorkflowSchedulerStateDto StopWorkflowScheduler (bool? stopAllRunningWorkflows = null, JobErrorCodes? errorCode = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class StopWorkflowSchedulerExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var stopAllRunningWorkflows = true;  // bool? |  (optional) 
            var errorCode = (JobErrorCodes) "NoErrors";  // JobErrorCodes? |  (optional) 

            try
            {
                WorkflowSchedulerStateDto result = apiInstance.StopWorkflowScheduler(stopAllRunningWorkflows, errorCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.StopWorkflowScheduler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopWorkflowSchedulerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WorkflowSchedulerStateDto> response = apiInstance.StopWorkflowSchedulerWithHttpInfo(stopAllRunningWorkflows, errorCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.StopWorkflowSchedulerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stopAllRunningWorkflows** | **bool?** |  | [optional]  |
| **errorCode** | **JobErrorCodes?** |  | [optional]  |

### Return type

[**WorkflowSchedulerStateDto**](WorkflowSchedulerStateDto.md)

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

<a name="testwebhooktarget"></a>
# **TestWebhookTarget**
> WebhookTargetTestResultDto TestWebhookTarget (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class TestWebhookTargetExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                WebhookTargetTestResultDto result = apiInstance.TestWebhookTarget(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.TestWebhookTarget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestWebhookTargetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebhookTargetTestResultDto> response = apiInstance.TestWebhookTargetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.TestWebhookTargetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**WebhookTargetTestResultDto**](WebhookTargetTestResultDto.md)

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

<a name="transmit"></a>
# **Transmit**
> byte[] Transmit (int readerIndex, byte[] body = null)

Invoke SCardTransmit on the specified reader

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
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
                Debug.Print("Exception when calling IntegrationApi.Transmit: " + e.Message);
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
    Debug.Print("Exception when calling IntegrationApi.TransmitWithHttpInfo: " + e.Message);
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

<a name="updatewebhookstarget"></a>
# **UpdateWebhooksTarget**
> WebhooksTargetDto UpdateWebhooksTarget (WebhooksTargetDto webhooksTargetDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class UpdateWebhooksTargetExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var webhooksTargetDto = new WebhooksTargetDto(); // WebhooksTargetDto |  (optional) 

            try
            {
                WebhooksTargetDto result = apiInstance.UpdateWebhooksTarget(webhooksTargetDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateWebhooksTarget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWebhooksTargetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebhooksTargetDto> response = apiInstance.UpdateWebhooksTargetWithHttpInfo(webhooksTargetDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.UpdateWebhooksTargetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhooksTargetDto** | [**WebhooksTargetDto**](WebhooksTargetDto.md) |  | [optional]  |

### Return type

[**WebhooksTargetDto**](WebhooksTargetDto.md)

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

<a name="uploadlayoutfile"></a>
# **UploadLayoutFile**
> LayoutDto UploadLayoutFile (string layoutName = null, string supportSide = null, string scannerId = null, List<FileParameter> files = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class UploadLayoutFileExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var layoutName = "layoutName_example";  // string |  (optional) 
            var supportSide = "supportSide_example";  // string |  (optional) 
            var scannerId = "scannerId_example";  // string |  (optional) 
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                LayoutDto result = apiInstance.UploadLayoutFile(layoutName, supportSide, scannerId, files);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.UploadLayoutFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadLayoutFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LayoutDto> response = apiInstance.UploadLayoutFileWithHttpInfo(layoutName, supportSide, scannerId, files);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.UploadLayoutFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **layoutName** | **string** |  | [optional]  |
| **supportSide** | **string** |  | [optional]  |
| **scannerId** | **string** |  | [optional]  |
| **files** | **List&lt;FileParameter&gt;** |  | [optional]  |

### Return type

[**LayoutDto**](LayoutDto.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validateinkjetlayoutname"></a>
# **ValidateInkjetLayoutName**
> NameValidationResultDto ValidateInkjetLayoutName (string scannerId = null, string body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class ValidateInkjetLayoutNameExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var body = "body_example";  // string |  (optional) 

            try
            {
                NameValidationResultDto result = apiInstance.ValidateInkjetLayoutName(scannerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ValidateInkjetLayoutName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateInkjetLayoutNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NameValidationResultDto> response = apiInstance.ValidateInkjetLayoutNameWithHttpInfo(scannerId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.ValidateInkjetLayoutNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **body** | **string** |  | [optional]  |

### Return type

[**NameValidationResultDto**](NameValidationResultDto.md)

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

<a name="validatejobtemplatename"></a>
# **ValidateJobTemplateName**
> NameValidationResultDto ValidateJobTemplateName (string scannerId = null, string body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class ValidateJobTemplateNameExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var body = "body_example";  // string |  (optional) 

            try
            {
                NameValidationResultDto result = apiInstance.ValidateJobTemplateName(scannerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ValidateJobTemplateName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateJobTemplateNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NameValidationResultDto> response = apiInstance.ValidateJobTemplateNameWithHttpInfo(scannerId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.ValidateJobTemplateNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **body** | **string** |  | [optional]  |

### Return type

[**NameValidationResultDto**](NameValidationResultDto.md)

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

<a name="validatelayoutname"></a>
# **ValidateLayoutName**
> NameValidationResultDto ValidateLayoutName (string scannerId = null, string body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;

namespace Example
{
    public class ValidateLayoutNameExample
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
            var apiInstance = new IntegrationApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var body = "body_example";  // string |  (optional) 

            try
            {
                NameValidationResultDto result = apiInstance.ValidateLayoutName(scannerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationApi.ValidateLayoutName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateLayoutNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NameValidationResultDto> response = apiInstance.ValidateLayoutNameWithHttpInfo(scannerId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IntegrationApi.ValidateLayoutNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **body** | **string** |  | [optional]  |

### Return type

[**NameValidationResultDto**](NameValidationResultDto.md)

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

