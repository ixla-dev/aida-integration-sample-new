# Aida.Sdk.Api.AuditApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetJobTemplateAudit**](AuditApi.md#getjobtemplateaudit) | **GET** /aida/v1/audit/job-templates |  |
| [**GetWorkflowAudit**](AuditApi.md#getworkflowaudit) | **GET** /aida/v1/audit/workflows |  |

<a name="getjobtemplateaudit"></a>
# **GetJobTemplateAudit**
> List&lt;JobTemplateAuditEntryDto&gt; GetJobTemplateAudit (DateTime? startTimeStamp = null, DateTime? endTimeStamp = null, int? jobTemplateId = null, List<string> operation = null, string layoutName = null, string ocrName = null, string autoposName = null, string webhookName = null, int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



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
    public class GetJobTemplateAuditExample
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
            var apiInstance = new AuditApi(httpClient, config, httpClientHandler);
            var startTimeStamp = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTimeStamp = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var jobTemplateId = 56;  // int? |  (optional) 
            var operation = new List<string>(); // List<string> |  (optional) 
            var layoutName = "layoutName_example";  // string |  (optional) 
            var ocrName = "ocrName_example";  // string |  (optional) 
            var autoposName = "autoposName_example";  // string |  (optional) 
            var webhookName = "webhookName_example";  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                List<JobTemplateAuditEntryDto> result = apiInstance.GetJobTemplateAudit(startTimeStamp, endTimeStamp, jobTemplateId, operation, layoutName, ocrName, autoposName, webhookName, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditApi.GetJobTemplateAudit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJobTemplateAuditWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<JobTemplateAuditEntryDto>> response = apiInstance.GetJobTemplateAuditWithHttpInfo(startTimeStamp, endTimeStamp, jobTemplateId, operation, layoutName, ocrName, autoposName, webhookName, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuditApi.GetJobTemplateAuditWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTimeStamp** | **DateTime?** |  | [optional]  |
| **endTimeStamp** | **DateTime?** |  | [optional]  |
| **jobTemplateId** | **int?** |  | [optional]  |
| **operation** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **layoutName** | **string** |  | [optional]  |
| **ocrName** | **string** |  | [optional]  |
| **autoposName** | **string** |  | [optional]  |
| **webhookName** | **string** |  | [optional]  |
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**List&lt;JobTemplateAuditEntryDto&gt;**](JobTemplateAuditEntryDto.md)

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

<a name="getworkflowaudit"></a>
# **GetWorkflowAudit**
> List&lt;WorkflowAuditEntryDto&gt; GetWorkflowAudit (DateTime? startTimeStamp = null, DateTime? endTimeStamp = null, int? jobTemplateId = null, string workflowId = null, int? recordId = null, string sessionId = null, List<string> operation = null, string layoutName = null, string ocrName = null, string autoposName = null, string webhookName = null, string sourcePosition = null, string position = null, bool? success = null, string result = null, int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



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
    public class GetWorkflowAuditExample
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
            var apiInstance = new AuditApi(httpClient, config, httpClientHandler);
            var startTimeStamp = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTimeStamp = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var jobTemplateId = 56;  // int? |  (optional) 
            var workflowId = "workflowId_example";  // string |  (optional) 
            var recordId = 56;  // int? |  (optional) 
            var sessionId = "sessionId_example";  // string |  (optional) 
            var operation = new List<string>(); // List<string> |  (optional) 
            var layoutName = "layoutName_example";  // string |  (optional) 
            var ocrName = "ocrName_example";  // string |  (optional) 
            var autoposName = "autoposName_example";  // string |  (optional) 
            var webhookName = "webhookName_example";  // string |  (optional) 
            var sourcePosition = "sourcePosition_example";  // string |  (optional) 
            var position = "position_example";  // string |  (optional) 
            var success = true;  // bool? |  (optional) 
            var result = "result_example";  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                List<WorkflowAuditEntryDto> result = apiInstance.GetWorkflowAudit(startTimeStamp, endTimeStamp, jobTemplateId, workflowId, recordId, sessionId, operation, layoutName, ocrName, autoposName, webhookName, sourcePosition, position, success, result, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditApi.GetWorkflowAudit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkflowAuditWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WorkflowAuditEntryDto>> response = apiInstance.GetWorkflowAuditWithHttpInfo(startTimeStamp, endTimeStamp, jobTemplateId, workflowId, recordId, sessionId, operation, layoutName, ocrName, autoposName, webhookName, sourcePosition, position, success, result, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuditApi.GetWorkflowAuditWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTimeStamp** | **DateTime?** |  | [optional]  |
| **endTimeStamp** | **DateTime?** |  | [optional]  |
| **jobTemplateId** | **int?** |  | [optional]  |
| **workflowId** | **string** |  | [optional]  |
| **recordId** | **int?** |  | [optional]  |
| **sessionId** | **string** |  | [optional]  |
| **operation** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **layoutName** | **string** |  | [optional]  |
| **ocrName** | **string** |  | [optional]  |
| **autoposName** | **string** |  | [optional]  |
| **webhookName** | **string** |  | [optional]  |
| **sourcePosition** | **string** |  | [optional]  |
| **position** | **string** |  | [optional]  |
| **success** | **bool?** |  | [optional]  |
| **result** | **string** |  | [optional]  |
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**List&lt;WorkflowAuditEntryDto&gt;**](WorkflowAuditEntryDto.md)

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

