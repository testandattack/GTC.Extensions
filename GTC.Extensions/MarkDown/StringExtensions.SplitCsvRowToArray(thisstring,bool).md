#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](GTC.Extensions.md#GTC.Extensions.StringExtensions 'GTC.Extensions.StringExtensions')

## StringExtensions.SplitCsvRowToArray(this string, bool) Method

`OBSOLETE` This method is maintained for backward compatibility.   
            Call [CsvStrToStringArray(this string, bool)](StringExtensions.CsvStrToStringArray(thisstring,bool).md 'GTC.Extensions.StringExtensions.CsvStrToStringArray(this string, bool)') instead.

```csharp
public static string[] SplitCsvRowToArray(this string source, bool escapeSingleQuotes=false);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.SplitCsvRowToArray(thisstring,bool).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.SplitCsvRowToArray(thisstring,bool).escapeSingleQuotes'></a>

`escapeSingleQuotes` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If `True`, single quotes are converted to T-SQL escaped quotes.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')