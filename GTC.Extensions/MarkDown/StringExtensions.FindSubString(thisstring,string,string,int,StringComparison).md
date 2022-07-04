#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](GTC.Extensions.md#GTC.Extensions.StringExtensions 'GTC.Extensions.StringExtensions')

## StringExtensions.FindSubString(this string, string, string, int, StringComparison) Method

Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison).endsWith')  
strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').

```csharp
public static string FindSubString(this string source, string startsAfter, string endsWith, int iIndex, System.StringComparison comp);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).startsAfter'></a>

`startsAfter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that immediately preceeds the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).endsWith'></a>

`endsWith` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that comes immediately after the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).iIndex'></a>

`iIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the zero-based index indicating which instance of [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison).startsAfter') should be used.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).comp'></a>

`comp` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')

a [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison') object that is applied to the searching.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')