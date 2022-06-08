#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.RemoveQuoteEscapes(this string) Method

Returns a new string without any "escaped Quotes" from the [source](StringExtensions.RemoveQuoteEscapes(thisstring).md#GTC.Extensions.StringExtensions.RemoveQuoteEscapes(thisstring).source 'GTC.Extensions.StringExtensions.RemoveQuoteEscapes(this string).source').   
This is useful when a string is copied  
from a system that requires quotes to be escaped.

```csharp
public static string RemoveQuoteEscapes(this string source);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.RemoveQuoteEscapes(thisstring).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')