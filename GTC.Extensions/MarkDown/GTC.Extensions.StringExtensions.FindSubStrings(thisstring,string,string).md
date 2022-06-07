### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[StringExtensions](GTC.Extensions.StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.FindSubStrings(this string, string, string) Method

Searches a string for all instances of a substring, using the [FindSubString(this string, string, string)](GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string).md 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string)')  
method, adding every found instance to a list.

```csharp
public static System.Collections.Generic.List<string> FindSubStrings(this string source, string startsAfter, string endsWith);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.FindSubStrings(thisstring,string,string).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.FindSubStrings(thisstring,string,string).startsAfter'></a>

`startsAfter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that immediately preceeds the substring to locate.

<a name='GTC.Extensions.StringExtensions.FindSubStrings(thisstring,string,string).endsWith'></a>

`endsWith` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that comes immediately after the substring to locate.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')