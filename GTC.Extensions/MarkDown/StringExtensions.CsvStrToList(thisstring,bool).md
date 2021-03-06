#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](GTC.Extensions.md#GTC.Extensions.StringExtensions 'GTC.Extensions.StringExtensions')

## StringExtensions.CsvStrToList(this string, bool) Method

Returns a list of strings from a single string that is CSV formatted. For more information, see  
[
            this article](https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings 'https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings').

```csharp
public static System.Collections.Generic.List<string> CsvStrToList(this string source, bool escapeSingleQuotes=false);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.CsvStrToList(thisstring,bool).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.CsvStrToList(thisstring,bool).escapeSingleQuotes'></a>

`escapeSingleQuotes` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If `True`, single quotes are converted to T-SQL escaped quotes.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')