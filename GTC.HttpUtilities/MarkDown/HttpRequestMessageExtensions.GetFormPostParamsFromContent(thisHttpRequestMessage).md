#### [GTC.HttpUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')
### [GTC.HttpUtilities](GTC.HttpUtilities.md#GTC.HttpUtilities 'GTC.HttpUtilities').[HttpRequestMessageExtensions](GTC.HttpUtilities.md#GTC.HttpUtilities.HttpRequestMessageExtensions 'GTC.HttpUtilities.HttpRequestMessageExtensions')

## HttpRequestMessageExtensions.GetFormPostParamsFromContent(this HttpRequestMessage) Method

If the request has a [System.Net.Http.FormUrlEncodedContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.FormUrlEncodedContent 'System.Net.Http.FormUrlEncodedContent') body, this method will read it and  
return a dictionary of Key-Value-Pairs representing all of the items in the body.

```csharp
public static System.Collections.Generic.Dictionary<string,string> GetFormPostParamsFromContent(this System.Net.Http.HttpRequestMessage source);
```
#### Parameters

<a name='GTC.HttpUtilities.HttpRequestMessageExtensions.GetFormPostParamsFromContent(thisSystem.Net.Http.HttpRequestMessage).source'></a>

`source` [System.Net.Http.HttpRequestMessage](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage')

The HttpRequestMessage to which this method is exposed.

#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

### Remarks
This method differs from [GetRequestContentBody(this HttpRequestMessage)](HttpRequestMessageExtensions.GetRequestContentBody(thisHttpRequestMessage).md 'GTC.HttpUtilities.HttpRequestMessageExtensions.GetRequestContentBody(this System.Net.Http.HttpRequestMessage)') in that it formats the values and   
inserts them into a Dictionary.