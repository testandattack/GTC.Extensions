#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.CsvStrToStringArray(this string, bool) Method

Returns an array of strings from a single string that is CSV formatted. For more information, see  
[
            this article](https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings 'https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings').

```csharp
public static string[] CsvStrToStringArray(this string source, bool escapeSingleQuotes=false);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.CsvStrToStringArray(thisstring,bool).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.CsvStrToStringArray(thisstring,bool).escapeSingleQuotes'></a>

`escapeSingleQuotes` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')