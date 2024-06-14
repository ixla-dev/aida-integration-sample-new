# Aida.Sdk.Api.DataSourceConfigurationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDataSourceConfiguration**](DataSourceConfigurationApi.md#adddatasourceconfiguration) | **POST** /aida/v1/datasource-configuration |  |
| [**DeleteDataSourceConfiguration**](DataSourceConfigurationApi.md#deletedatasourceconfiguration) | **DELETE** /aida/v1/datasource-configuration/{id} |  |
| [**FindDataSourceConfigurations**](DataSourceConfigurationApi.md#finddatasourceconfigurations) | **GET** /aida/v1/datasource-configuration |  |
| [**UpdateMysqlDataSourceConfiguration**](DataSourceConfigurationApi.md#updatemysqldatasourceconfiguration) | **PUT** /aida/v1/datasource-configuration/mysql |  |
| [**UpdateNpgSqlDataSourceConfiguration**](DataSourceConfigurationApi.md#updatenpgsqldatasourceconfiguration) | **PUT** /aida/v1/datasource-configuration/npgsql |  |

<a name="adddatasourceconfiguration"></a>
# **AddDataSourceConfiguration**
> AddDataSourceConfiguration200Response AddDataSourceConfiguration (CreateDataSourceDto createDataSourceDto = null)



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
    public class AddDataSourceConfigurationExample
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
            var apiInstance = new DataSourceConfigurationApi(httpClient, config, httpClientHandler);
            var createDataSourceDto = new CreateDataSourceDto(); // CreateDataSourceDto |  (optional) 

            try
            {
                AddDataSourceConfiguration200Response result = apiInstance.AddDataSourceConfiguration(createDataSourceDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourceConfigurationApi.AddDataSourceConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDataSourceConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddDataSourceConfiguration200Response> response = apiInstance.AddDataSourceConfigurationWithHttpInfo(createDataSourceDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourceConfigurationApi.AddDataSourceConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDataSourceDto** | [**CreateDataSourceDto**](CreateDataSourceDto.md) |  | [optional]  |

### Return type

[**AddDataSourceConfiguration200Response**](AddDataSourceConfiguration200Response.md)

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

<a name="deletedatasourceconfiguration"></a>
# **DeleteDataSourceConfiguration**
> void DeleteDataSourceConfiguration (int id)



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
    public class DeleteDataSourceConfigurationExample
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
            var apiInstance = new DataSourceConfigurationApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                apiInstance.DeleteDataSourceConfiguration(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourceConfigurationApi.DeleteDataSourceConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDataSourceConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteDataSourceConfigurationWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourceConfigurationApi.DeleteDataSourceConfigurationWithHttpInfo: " + e.Message);
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

<a name="finddatasourceconfigurations"></a>
# **FindDataSourceConfigurations**
> SearchDataSourceConfigurationResultDto FindDataSourceConfigurations (int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



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
    public class FindDataSourceConfigurationsExample
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
            var apiInstance = new DataSourceConfigurationApi(httpClient, config, httpClientHandler);
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                SearchDataSourceConfigurationResultDto result = apiInstance.FindDataSourceConfigurations(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourceConfigurationApi.FindDataSourceConfigurations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindDataSourceConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchDataSourceConfigurationResultDto> response = apiInstance.FindDataSourceConfigurationsWithHttpInfo(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourceConfigurationApi.FindDataSourceConfigurationsWithHttpInfo: " + e.Message);
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

[**SearchDataSourceConfigurationResultDto**](SearchDataSourceConfigurationResultDto.md)

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

<a name="updatemysqldatasourceconfiguration"></a>
# **UpdateMysqlDataSourceConfiguration**
> MySqlDataSourceConfigurationDto UpdateMysqlDataSourceConfiguration (MySqlDataSourceConfigurationDto mySqlDataSourceConfigurationDto = null)



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
    public class UpdateMysqlDataSourceConfigurationExample
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
            var apiInstance = new DataSourceConfigurationApi(httpClient, config, httpClientHandler);
            var mySqlDataSourceConfigurationDto = new MySqlDataSourceConfigurationDto(); // MySqlDataSourceConfigurationDto |  (optional) 

            try
            {
                MySqlDataSourceConfigurationDto result = apiInstance.UpdateMysqlDataSourceConfiguration(mySqlDataSourceConfigurationDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourceConfigurationApi.UpdateMysqlDataSourceConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMysqlDataSourceConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MySqlDataSourceConfigurationDto> response = apiInstance.UpdateMysqlDataSourceConfigurationWithHttpInfo(mySqlDataSourceConfigurationDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourceConfigurationApi.UpdateMysqlDataSourceConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mySqlDataSourceConfigurationDto** | [**MySqlDataSourceConfigurationDto**](MySqlDataSourceConfigurationDto.md) |  | [optional]  |

### Return type

[**MySqlDataSourceConfigurationDto**](MySqlDataSourceConfigurationDto.md)

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

<a name="updatenpgsqldatasourceconfiguration"></a>
# **UpdateNpgSqlDataSourceConfiguration**
> NpgSqlDataSourceConfigurationDto UpdateNpgSqlDataSourceConfiguration (NpgSqlDataSourceConfigurationDto npgSqlDataSourceConfigurationDto = null)



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
    public class UpdateNpgSqlDataSourceConfigurationExample
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
            var apiInstance = new DataSourceConfigurationApi(httpClient, config, httpClientHandler);
            var npgSqlDataSourceConfigurationDto = new NpgSqlDataSourceConfigurationDto(); // NpgSqlDataSourceConfigurationDto |  (optional) 

            try
            {
                NpgSqlDataSourceConfigurationDto result = apiInstance.UpdateNpgSqlDataSourceConfiguration(npgSqlDataSourceConfigurationDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSourceConfigurationApi.UpdateNpgSqlDataSourceConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateNpgSqlDataSourceConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NpgSqlDataSourceConfigurationDto> response = apiInstance.UpdateNpgSqlDataSourceConfigurationWithHttpInfo(npgSqlDataSourceConfigurationDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSourceConfigurationApi.UpdateNpgSqlDataSourceConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **npgSqlDataSourceConfigurationDto** | [**NpgSqlDataSourceConfigurationDto**](NpgSqlDataSourceConfigurationDto.md) |  | [optional]  |

### Return type

[**NpgSqlDataSourceConfigurationDto**](NpgSqlDataSourceConfigurationDto.md)

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

