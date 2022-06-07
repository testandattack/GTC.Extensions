### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[StringExtensions](GTC.Extensions.StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.ToCamelCase(this string) Method

This method takes a string representing a namespace or object name, and creates  
a new string where all leading characters are converted to lower case.

```csharp
public static string ToCamelCase(this string source);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.ToCamelCase(thisstring).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
This method is useful for converting entries in an OpenApi document so that   
they respect camelCase validation. For instance, the value `GTC.Extensions.ToCamelCase`  
would be returned as `gTC.extensions.toCamelCase`.