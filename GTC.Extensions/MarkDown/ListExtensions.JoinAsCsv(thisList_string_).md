#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[ListExtensions](ListExtensions.md 'GTC.Extensions.ListExtensions')

## ListExtensions.JoinAsCsv(this List<string>) Method

This method reads a list of string items and converts them into a single string.

```csharp
public static string JoinAsCsv(this System.Collections.Generic.List<string> items);
```
#### Parameters

<a name='GTC.Extensions.ListExtensions.JoinAsCsv(thisSystem.Collections.Generic.List_string_).items'></a>

`items` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') to which this method is exposed.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
a string

### Remarks
This method accounts for strings that have commas within the string by surrounding the string with  
quotes, thus making the final CSV output accurate per standard parsing techniques.