### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[StringExtensions](GTC.Extensions.StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.IsGreaterThan(this string, string, StringComparison) Method

This method uses the [System.String.CompareTo(System.String)](https://docs.microsoft.com/en-us/dotnet/api/System.String.CompareTo#System_String_CompareTo_System_String_ 'System.String.CompareTo(System.String)') to get the  
sorted order of the two strings, then returns `True` if [source](GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).source 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).source')  
comes before [secondString](GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).secondString 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).secondString') or `False` if they are equal or [secondString](GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).secondString 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).secondString')  
comes before [source](GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).source 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).source').

```csharp
public static bool IsGreaterThan(this string source, string secondString, System.StringComparison comp=System.StringComparison.CurrentCultureIgnoreCase);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).secondString'></a>

`secondString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string to compare to [source](GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).source 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).source').

<a name='GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).comp'></a>

`comp` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')

a [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison') enum defining how to perform the comparison.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')