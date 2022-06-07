### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[StringExtensions](GTC.Extensions.StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.GetLeftPart(this string, string, bool) Method

Gets the left side [beginning] of a given string, up to, but not including the [delimiter](GTC.Extensions.StringExtensions.GetLeftPart(thisstring,string,bool).md#GTC.Extensions.StringExtensions.GetLeftPart(thisstring,string,bool).delimiter 'GTC.Extensions.StringExtensions.GetLeftPart(this string, string, bool).delimiter').

```csharp
public static string GetLeftPart(this string source, string delimiter, bool returnEmptyIfDelimiterNotFound=true);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.GetLeftPart(thisstring,string,bool).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.GetLeftPart(thisstring,string,bool).delimiter'></a>

`delimiter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string representing the text that marks the beginning of the text to truncate.

<a name='GTC.Extensions.StringExtensions.GetLeftPart(thisstring,string,bool).returnEmptyIfDelimiterNotFound'></a>

`returnEmptyIfDelimiterNotFound` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, the method returns an empty string if the delimiter is not found.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')