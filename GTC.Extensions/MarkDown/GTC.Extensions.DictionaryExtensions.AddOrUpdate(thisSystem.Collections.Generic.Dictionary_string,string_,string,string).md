### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[DictionaryExtensions](GTC.Extensions.DictionaryExtensions.md 'GTC.Extensions.DictionaryExtensions')

## DictionaryExtensions.AddOrUpdate(this Dictionary<string,string>, string, string) Method

```csharp
public static void AddOrUpdate(this System.Collections.Generic.Dictionary<string,string> source, string sKey, string sValue);
```
#### Parameters

<a name='GTC.Extensions.DictionaryExtensions.AddOrUpdate(thisSystem.Collections.Generic.Dictionary_string,string_,string,string).source'></a>

`source` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The `Dictionary{string, string}` to which this method is exposed.

<a name='GTC.Extensions.DictionaryExtensions.AddOrUpdate(thisSystem.Collections.Generic.Dictionary_string,string_,string,string).sKey'></a>

`sKey` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the Key-Value-Pair to add if not already present.

<a name='GTC.Extensions.DictionaryExtensions.AddOrUpdate(thisSystem.Collections.Generic.Dictionary_string,string_,string,string).sValue'></a>

`sValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value of the Key-Value-Pair to add, or update if the kley is already present.