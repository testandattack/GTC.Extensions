#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](GTC.Extensions.md#GTC.Extensions.StringExtensions 'GTC.Extensions.StringExtensions')

## StringExtensions.FindSubString(this string, string, string, int) Method

Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int).endsWith')  
strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').

```csharp
public static string FindSubString(this string source, string startsAfter, string endsWith, int iIndex);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).startsAfter'></a>

`startsAfter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that immediately preceeds the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).endsWith'></a>

`endsWith` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that comes immediately after the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).iIndex'></a>

`iIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the zero-based index indicating which instance of [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int).startsAfter') should be used.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')