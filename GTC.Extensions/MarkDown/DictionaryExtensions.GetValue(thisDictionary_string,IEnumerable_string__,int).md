#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[DictionaryExtensions](GTC.Extensions.md#GTC.Extensions.DictionaryExtensions 'GTC.Extensions.DictionaryExtensions')

## DictionaryExtensions.GetValue(this Dictionary<string,IEnumerable<string>>, int) Method

Retrieves the IEnumerable value from the dictionary which is stored at the specified [iIndex](DictionaryExtensions.GetValue(thisDictionary_string,IEnumerable_string__,int).md#GTC.Extensions.DictionaryExtensions.GetValue(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,int).iIndex 'GTC.Extensions.DictionaryExtensions.GetValue(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, int).iIndex').

```csharp
public static string GetValue(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> source, int iIndex);
```
#### Parameters

<a name='GTC.Extensions.DictionaryExtensions.GetValue(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,int).source'></a>

`source` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The `Dictionary{string, IEnumerable{string}}` to which this method is exposed.

<a name='GTC.Extensions.DictionaryExtensions.GetValue(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,int).iIndex'></a>

`iIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based integer representing the index of the entry to use.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representing the concatenated values for the item, using a semicolon as the separator.