### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[DictionaryExtensions](GTC.Extensions.DictionaryExtensions.md 'GTC.Extensions.DictionaryExtensions')

## DictionaryExtensions.AsString(this Dictionary<string,string>, string, string) Method

This method converts all of the Key-Value-Pair entries into a single string,  
using the provided separators between the entries.

```csharp
public static string AsString(this System.Collections.Generic.Dictionary<string,string> source, string entrySeparator="\r\n", string kvpSeparator="=");
```
#### Parameters

<a name='GTC.Extensions.DictionaryExtensions.AsString(thisSystem.Collections.Generic.Dictionary_string,string_,string,string).source'></a>

`source` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The `Dictionary{string, string}` to which this method is exposed.

<a name='GTC.Extensions.DictionaryExtensions.AsString(thisSystem.Collections.Generic.Dictionary_string,string_,string,string).entrySeparator'></a>

`entrySeparator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the separator value to use between each KVP entry.  
            The default value is '\r\n'

<a name='GTC.Extensions.DictionaryExtensions.AsString(thisSystem.Collections.Generic.Dictionary_string,string_,string,string).kvpSeparator'></a>

`kvpSeparator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the separator value to use between the key and value of each entry.  
            The default value is '='

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')