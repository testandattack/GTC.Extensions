### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[StringExtensions](GTC.Extensions.StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.GetUrlWithoutQuery(this string) Method

Gets the URL portion of a string, removing any query parameter text that might  
be part of the string.

```csharp
public static string GetUrlWithoutQuery(this string source);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.GetUrlWithoutQuery(thisstring).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representing the left portion of the source string, up to but not including the `?` delimiter

### Remarks
This extension method acts the same way that [System.Uri.GetLeftPart(System.UriPartial)](https://docs.microsoft.com/en-us/dotnet/api/System.Uri.GetLeftPart#System_Uri_GetLeftPart_System_UriPartial_ 'System.Uri.GetLeftPart(System.UriPartial)') works, but  
performs the operation on a string.