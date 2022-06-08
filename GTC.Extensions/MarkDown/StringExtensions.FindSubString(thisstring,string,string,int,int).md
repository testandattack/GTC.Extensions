#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.FindSubString(this string, string, string, int, int) Method

Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, int).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,int,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, int).endsWith')  
strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').

```csharp
public static string FindSubString(this string source, string startsAfter, string endsWith, int iIndex, ref int subStringFoundAtLocation);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).startsAfter'></a>

`startsAfter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that immediately preceeds the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).endsWith'></a>

`endsWith` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that comes immediately after the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).iIndex'></a>

`iIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the zero-based index indicating which instance of [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, int).startsAfter') should be used.

<a name='GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).subStringFoundAtLocation'></a>

`subStringFoundAtLocation` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

an integer that stores the index of the first character of the returned substring.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')