#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[ListExtensions](GTC.Extensions.md#GTC.Extensions.ListExtensions 'GTC.Extensions.ListExtensions')

## ListExtensions.JoinAsCsv(this string[]) Method

This method reads an array of string items and converts them into a single string.

```csharp
public static string JoinAsCsv(this string[] items);
```
#### Parameters

<a name='GTC.Extensions.ListExtensions.JoinAsCsv(thisstring[]).items'></a>

`items` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The `string[]` array to which this method is exposed.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
a string

### Remarks
This method accounts for strings that have commas within the string by surrounding the string with  
quotes, thus making the final CSV output accurate per standard parsing techniques.