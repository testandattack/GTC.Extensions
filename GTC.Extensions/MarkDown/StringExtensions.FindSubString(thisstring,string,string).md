#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.FindSubString(this string, string, string) Method

Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string).endsWith')  
strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').

```csharp
public static string FindSubString(this string source, string startsAfter, string endsWith);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string).startsAfter'></a>

`startsAfter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that immediately preceeds the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string).endsWith'></a>

`endsWith` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that comes immediately after the substring to locate.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')