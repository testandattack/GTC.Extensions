#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[DictionaryExtensions](DictionaryExtensions.md 'GTC.Extensions.DictionaryExtensions')

## DictionaryExtensions.GetKey(this Dictionary<string,string>, int) Method

Retrieves the string value for the Key from the dictionary which is stored at the specified [iIndex](DictionaryExtensions.GetKey(thisDictionary_string,string_,int).md#GTC.Extensions.DictionaryExtensions.GetKey(thisSystem.Collections.Generic.Dictionary_string,string_,int).iIndex 'GTC.Extensions.DictionaryExtensions.GetKey(this System.Collections.Generic.Dictionary<string,string>, int).iIndex').

```csharp
public static string GetKey(this System.Collections.Generic.Dictionary<string,string> source, int iIndex);
```
#### Parameters

<a name='GTC.Extensions.DictionaryExtensions.GetKey(thisSystem.Collections.Generic.Dictionary_string,string_,int).source'></a>

`source` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The `Dictionary{string, string}` to which this method is exposed.

<a name='GTC.Extensions.DictionaryExtensions.GetKey(thisSystem.Collections.Generic.Dictionary_string,string_,int).iIndex'></a>

`iIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based integer representing the index of the entry to use.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representing the KEY for the item.