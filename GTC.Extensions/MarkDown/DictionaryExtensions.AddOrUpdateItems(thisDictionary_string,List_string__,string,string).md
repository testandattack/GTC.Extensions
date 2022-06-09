#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[DictionaryExtensions](GTC.Extensions.md#GTC.Extensions.DictionaryExtensions 'GTC.Extensions.DictionaryExtensions')

## DictionaryExtensions.AddOrUpdateItems(this Dictionary<string,List<string>>, string, string) Method

This method allows you to manage a list of values for each specified key in a Dictionary.

```csharp
public static void AddOrUpdateItems(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.List<string>> source, string item, string value);
```
#### Parameters

<a name='GTC.Extensions.DictionaryExtensions.AddOrUpdateItems(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.List_string__,string,string).source'></a>

`source` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The `Dictionary{string, List{string}}` to which this method is exposed.

<a name='GTC.Extensions.DictionaryExtensions.AddOrUpdateItems(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.List_string__,string,string).item'></a>

`item` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key to update if present, or to add if not present.

<a name='GTC.Extensions.DictionaryExtensions.AddOrUpdateItems(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.List_string__,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the value to add.

### Remarks
This is useful if you want to maintain a collection of one or more string values for each unique string key in the Dictionary.  
For instance, you may want to maintain a list of Make and Model for cars. The Keys would be the Make (such as Ford, Chrysler, GM)  
and the Values would be lists of models, such as F150, Mustang, Explorer, etc. for the Ford key.  
NOTE: This routine does NOT check for duplicate entries in the values list.