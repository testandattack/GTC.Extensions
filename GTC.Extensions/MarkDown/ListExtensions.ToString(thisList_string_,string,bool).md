#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[ListExtensions](ListExtensions.md 'GTC.Extensions.ListExtensions')

## ListExtensions.ToString(this List<string>, string, bool) Method

Creates a single string from a list of strings, using the defined separator

```csharp
public static string ToString(this System.Collections.Generic.List<string> source, string separator, bool AddSpace);
```
#### Parameters

<a name='GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.List_string_,string,bool).source'></a>

`source` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') to which this method is exposed.

<a name='GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.List_string_,string,bool).separator'></a>

`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The character or string to place between each entry.

<a name='GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.List_string_,string,bool).AddSpace'></a>

`AddSpace` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, then a space is added after each separator. This makes the final string more human readable.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
a string.