#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](GTC.Extensions.md#GTC.Extensions.StringExtensions 'GTC.Extensions.StringExtensions')

## StringExtensions.FindSubString(this string, string, string, bool) Method

Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, bool).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, bool).endsWith')  
strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').

```csharp
public static string FindSubString(this string source, string startsAfter, string endsWith, bool doNotFailOnMissingEndsWith);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).startsAfter'></a>

`startsAfter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that immediately preceeds the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).endsWith'></a>

`endsWith` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that comes immediately after the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).doNotFailOnMissingEndsWith'></a>

`doNotFailOnMissingEndsWith` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true (and if there is no [endsWith](StringExtensions.FindSubString(thisstring,string,string,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, bool).endsWith') located), the routine will return everything after the located starting point of the string

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')