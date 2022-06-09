#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](GTC.Extensions.md#GTC.Extensions.StringExtensions 'GTC.Extensions.StringExtensions')

## StringExtensions.Shortened(this string, int) Method

Returns a shortened version of the [source](StringExtensions.Shortened(thisstring,int).md#GTC.Extensions.StringExtensions.Shortened(thisstring,int).source 'GTC.Extensions.StringExtensions.Shortened(this string, int).source') string, with the  
word "**TRUNCATED**" added to the end.

```csharp
public static string Shortened(this string source, int maxLen);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.Shortened(thisstring,int).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.Shortened(thisstring,int).maxLen'></a>

`maxLen` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the maximum length to return, including the "**TRUNCATED**" keyword.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')