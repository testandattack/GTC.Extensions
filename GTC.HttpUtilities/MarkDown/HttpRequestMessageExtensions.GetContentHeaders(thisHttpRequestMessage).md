#### [GTC.HttpUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')
### [GTC.HttpUtilities](GTC.HttpUtilities.md#GTC.HttpUtilities 'GTC.HttpUtilities').[HttpRequestMessageExtensions](GTC.HttpUtilities.md#GTC.HttpUtilities.HttpRequestMessageExtensions 'GTC.HttpUtilities.HttpRequestMessageExtensions')

## HttpRequestMessageExtensions.GetContentHeaders(this HttpRequestMessage) Method

Retrieves the headers associated with an HttpRequestMessage's [System.Net.Http.HttpContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpContent 'System.Net.Http.HttpContent').

```csharp
public static System.Collections.Generic.Dictionary<string,string> GetContentHeaders(this System.Net.Http.HttpRequestMessage source);
```
#### Parameters

<a name='GTC.HttpUtilities.HttpRequestMessageExtensions.GetContentHeaders(thisSystem.Net.Http.HttpRequestMessage).source'></a>

`source` [System.Net.Http.HttpRequestMessage](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage')

The HttpRequestMessage to which this method is exposed.

#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')