#### [GTC.HttpUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')
### [GTC.HttpUtilities](GTC.HttpUtilities.md#GTC.HttpUtilities 'GTC.HttpUtilities').[HttpRequestMessageExtensions](GTC.HttpUtilities.md#GTC.HttpUtilities.HttpRequestMessageExtensions 'GTC.HttpUtilities.HttpRequestMessageExtensions')

## HttpRequestMessageExtensions.GetRequestContentBody(this HttpRequestMessage) Method

Allows you to synchronously retrieve the content body from an HttpRequestMessage as a string.

```csharp
public static string GetRequestContentBody(this System.Net.Http.HttpRequestMessage source);
```
#### Parameters

<a name='GTC.HttpUtilities.HttpRequestMessageExtensions.GetRequestContentBody(thisSystem.Net.Http.HttpRequestMessage).source'></a>

`source` [System.Net.Http.HttpRequestMessage](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage')

The HttpRequestMessage to which this method is exposed.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
Currently this method detects and converts the following content:  
- [System.Net.Http.StringContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.StringContent 'System.Net.Http.StringContent')  
- [System.Net.Http.ByteArrayContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.ByteArrayContent 'System.Net.Http.ByteArrayContent')  
- [System.Net.Http.FormUrlEncodedContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.FormUrlEncodedContent 'System.Net.Http.FormUrlEncodedContent')  
The method also detects [System.Net.Http.MultipartFormDataContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') data, but does not convert it to a string. Instead it throws  
a [System.NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotImplementedException 'System.NotImplementedException'). NOTE, to retrieve FormUrlEncodedContent as a dictionary of Key-Value-Pairs, please  
use [GetContentHeaders(this HttpRequestMessage)](HttpRequestMessageExtensions.GetContentHeaders(thisHttpRequestMessage).md 'GTC.HttpUtilities.HttpRequestMessageExtensions.GetContentHeaders(this System.Net.Http.HttpRequestMessage)').