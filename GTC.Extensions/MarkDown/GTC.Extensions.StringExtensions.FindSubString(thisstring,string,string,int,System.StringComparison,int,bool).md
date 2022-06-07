### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[StringExtensions](GTC.Extensions.StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.FindSubString(this string, string, string, int, StringComparison, int, bool) Method

Looks for, and returns (if found) a string that resides in between the given [startsAfter](GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison, int, bool).startsAfter') and [endsWith](GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison, int, bool).endsWith')  
strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').

```csharp
public static string FindSubString(this string source, string startsAfter, string endsWith, int iIndex, System.StringComparison comp, ref int subStringFoundAtLocation, bool doNotFailOnMissingEndsWith);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).startsAfter'></a>

`startsAfter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that immediately preceeds the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).endsWith'></a>

`endsWith` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that comes immediately after the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).iIndex'></a>

`iIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the zero-based index indicating which instance of [startsAfter](GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison, int, bool).startsAfter') should be used.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).comp'></a>

`comp` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')

a [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison') object that is applied to the searching.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).subStringFoundAtLocation'></a>

`subStringFoundAtLocation` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

an integer that stores the index of the first character of the returned substring.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).doNotFailOnMissingEndsWith'></a>

`doNotFailOnMissingEndsWith` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true (and if there is no [endsWith](GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison, int, bool).endsWith') located), the routine will return everything after the located starting point of the string

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks