#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[DictionaryExtensions](DictionaryExtensions.md 'GTC.Extensions.DictionaryExtensions')

## DictionaryExtensions.GetValue(this Dictionary<string,string>, int) Method

Retrieves the string value from the dictionary which is stored at the specified [iIndex](DictionaryExtensions.GetValue(thisDictionary_string,string_,int).md#GTC.Extensions.DictionaryExtensions.GetValue(thisSystem.Collections.Generic.Dictionary_string,string_,int).iIndex 'GTC.Extensions.DictionaryExtensions.GetValue(this System.Collections.Generic.Dictionary<string,string>, int).iIndex').

```csharp
public static string GetValue(this System.Collections.Generic.Dictionary<string,string> source, int iIndex);
```
#### Parameters

<a name='GTC.Extensions.DictionaryExtensions.GetValue(thisSystem.Collections.Generic.Dictionary_string,string_,int).source'></a>

`source` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The `Dictionary{string, string}` to which this method is exposed.

<a name='GTC.Extensions.DictionaryExtensions.GetValue(thisSystem.Collections.Generic.Dictionary_string,string_,int).iIndex'></a>

`iIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based integer representing the index of the entry to use.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
An IEnumerable representing the VALUE for the item.