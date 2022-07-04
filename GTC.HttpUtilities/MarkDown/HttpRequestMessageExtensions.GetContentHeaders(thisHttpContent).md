#### [GTC.HttpUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')
### [GTC.HttpUtilities](GTC.HttpUtilities.md#GTC.HttpUtilities 'GTC.HttpUtilities').[HttpRequestMessageExtensions](GTC.HttpUtilities.md#GTC.HttpUtilities.HttpRequestMessageExtensions 'GTC.HttpUtilities.HttpRequestMessageExtensions')

## HttpRequestMessageExtensions.GetContentHeaders(this HttpContent) Method

Retrieves the headers associated with a [System.Net.Http.HttpContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpContent 'System.Net.Http.HttpContent') object.

```csharp
public static System.Collections.Generic.Dictionary<string,string> GetContentHeaders(this System.Net.Http.HttpContent source);
```
#### Parameters

<a name='GTC.HttpUtilities.HttpRequestMessageExtensions.GetContentHeaders(thisSystem.Net.Http.HttpContent).source'></a>

`source` [System.Net.Http.HttpContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpContent 'System.Net.Http.HttpContent')

The HttpContent to which this method is exposed.

#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')