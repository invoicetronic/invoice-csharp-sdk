# Invoicetronic.Invoice.Sdk.Api.UpdateApi

All URIs are relative to *https://api.invoicetronic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvoiceV1UpdateGet**](UpdateApi.md#invoicev1updateget) | **GET** /invoice/v1/update | List updates |
| [**InvoiceV1UpdateIdGet**](UpdateApi.md#invoicev1updateidget) | **GET** /invoice/v1/update/{id} | Get an update by id |

<a id="invoicev1updateget"></a>
# **InvoiceV1UpdateGet**
> List&lt;Update&gt; InvoiceV1UpdateGet (int? companyId = null, string identifier = null, bool? unread = null, int? sendId = null, string state = null, DateTime? lastUpdateFrom = null, DateTime? lastUpdateTo = null, DateTime? dateSentFrom = null, DateTime? dateSentTo = null, int? page = null, int? pageSize = null)

List updates

Updates are notifications that are sent by the SDI about the status of sent invoices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1UpdateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new UpdateApi(config);
            var companyId = 56;  // int? | Company id (optional) 
            var identifier = "identifier_example";  // string | SDI identifier. (optional) 
            var unread = true;  // bool? | Unread items only. (optional) 
            var sendId = 56;  // int? | Send item's id. (optional) 
            var state = "Inviato";  // string | SDI state (optional) 
            var lastUpdateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var lastUpdateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var dateSentTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | UTC ISO 8601 (2024-11-29T12:34:56Z) (optional) 
            var page = 1;  // int? | Page number. Defaults to 1. (optional)  (default to 1)
            var pageSize = 100;  // int? | Items per page. Defaults to 50. Cannot be greater than 200. (optional)  (default to 100)

            try
            {
                // List updates
                List<Update> result = apiInstance.InvoiceV1UpdateGet(companyId, identifier, unread, sendId, state, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdateApi.InvoiceV1UpdateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1UpdateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List updates
    ApiResponse<List<Update>> response = apiInstance.InvoiceV1UpdateGetWithHttpInfo(companyId, identifier, unread, sendId, state, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UpdateApi.InvoiceV1UpdateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int?** | Company id | [optional]  |
| **identifier** | **string** | SDI identifier. | [optional]  |
| **unread** | **bool?** | Unread items only. | [optional]  |
| **sendId** | **int?** | Send item&#39;s id. | [optional]  |
| **state** | **string** | SDI state | [optional]  |
| **lastUpdateFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **lastUpdateTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentFrom** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **dateSentTo** | **DateTime?** | UTC ISO 8601 (2024-11-29T12:34:56Z) | [optional]  |
| **page** | **int?** | Page number. Defaults to 1. | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page. Defaults to 50. Cannot be greater than 200. | [optional] [default to 100] |

### Return type

[**List&lt;Update&gt;**](Update.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicev1updateidget"></a>
# **InvoiceV1UpdateIdGet**
> Update InvoiceV1UpdateIdGet (int id)

Get an update by id

Updates are notifications that are sent by the SDI about the status of sent invoices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Invoicetronic.Invoice.Sdk.Api;
using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Model;

namespace Example
{
    public class InvoiceV1UpdateIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.invoicetronic.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new UpdateApi(config);
            var id = 56;  // int | Item id

            try
            {
                // Get an update by id
                Update result = apiInstance.InvoiceV1UpdateIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdateApi.InvoiceV1UpdateIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoiceV1UpdateIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an update by id
    ApiResponse<Update> response = apiInstance.InvoiceV1UpdateIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UpdateApi.InvoiceV1UpdateIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Item id |  |

### Return type

[**Update**](Update.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

