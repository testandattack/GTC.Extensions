#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.SplitCsvRowToList(this string, bool) Method

`OBSOLETE` This method is maintained for backward compatibility.   
            Call [CsvStrToList(this string, bool)](StringExtensions.CsvStrToList(thisstring,bool).md 'GTC.Extensions.StringExtensions.CsvStrToList(this string, bool)') instead.

```csharp
public static System.Collections.Generic.List<string> SplitCsvRowToList(this string source, bool escapeSingleQuotes=false);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.SplitCsvRowToList(thisstring,bool).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.SplitCsvRowToList(thisstring,bool).escapeSingleQuotes'></a>

`escapeSingleQuotes` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If `True`, single quotes are converted to T-SQL escaped quotes.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')