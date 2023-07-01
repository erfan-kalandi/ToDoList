# ListApiCli.Api.ListApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListGet**](ListApi.md#listget) | **GET** /List | 
[**ListListAddItemPost**](ListApi.md#listlistadditempost) | **POST** /List/List/AddItem | 
[**ListListDeleteIdiDelete**](ListApi.md#listlistdeleteididelete) | **DELETE** /List/List/Delete/{idi} | 
[**ListListGetIdGet**](ListApi.md#listlistgetidget) | **GET** /List/List/Get/{id} | 


<a name="listget"></a>
# **ListGet**
> List&lt;ToDoItems&gt; ListGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ListApiCli.Api;
using ListApiCli.Client;
using ListApiCli.Model;

namespace Example
{
    public class ListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ListApi(config);

            try
            {
                List<ToDoItems> result = apiInstance.ListGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListApi.ListGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ToDoItems&gt;**](ToDoItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlistadditempost"></a>
# **ListListAddItemPost**
> void ListListAddItemPost (ToDoItems toDoItems = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ListApiCli.Api;
using ListApiCli.Client;
using ListApiCli.Model;

namespace Example
{
    public class ListListAddItemPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ListApi(config);
            var toDoItems = new ToDoItems(); // ToDoItems |  (optional) 

            try
            {
                apiInstance.ListListAddItemPost(toDoItems);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListApi.ListListAddItemPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toDoItems** | [**ToDoItems**](ToDoItems.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlistdeleteididelete"></a>
# **ListListDeleteIdiDelete**
> void ListListDeleteIdiDelete (string idi)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ListApiCli.Api;
using ListApiCli.Client;
using ListApiCli.Model;

namespace Example
{
    public class ListListDeleteIdiDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ListApi(config);
            var idi = "idi_example";  // string | 

            try
            {
                apiInstance.ListListDeleteIdiDelete(idi);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListApi.ListListDeleteIdiDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idi** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlistgetidget"></a>
# **ListListGetIdGet**
> ToDoItems ListListGetIdGet (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ListApiCli.Api;
using ListApiCli.Client;
using ListApiCli.Model;

namespace Example
{
    public class ListListGetIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ListApi(config);
            var id = "id_example";  // string | 

            try
            {
                ToDoItems result = apiInstance.ListListGetIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListApi.ListListGetIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**ToDoItems**](ToDoItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

