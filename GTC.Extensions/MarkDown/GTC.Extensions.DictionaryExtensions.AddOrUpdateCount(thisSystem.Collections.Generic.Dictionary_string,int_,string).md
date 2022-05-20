### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[DictionaryExtensions](GTC.Extensions.DictionaryExtensions.md 'GTC.Extensions.DictionaryExtensions')

## DictionaryExtensions.AddOrUpdateCount(this Dictionary<string,int>, string) Method

This method allows you to manage a `Dictionary{string,int}` that stores a list of strings and a quantity that   
indicates how many times each string has been found, counted, added, etc.

```csharp
public static void AddOrUpdateCount(this System.Collections.Generic.Dictionary<string,int> source, string item);
```
#### Parameters

<a name='GTC.Extensions.DictionaryExtensions.AddOrUpdateCount(thisSystem.Collections.Generic.Dictionary_string,int_,string).source'></a>

`source` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The `Dictionary{string, int}` to which this method is exposed.

<a name='GTC.Extensions.DictionaryExtensions.AddOrUpdateCount(thisSystem.Collections.Generic.Dictionary_string,int_,string).item'></a>

`item` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to either add or update the count.