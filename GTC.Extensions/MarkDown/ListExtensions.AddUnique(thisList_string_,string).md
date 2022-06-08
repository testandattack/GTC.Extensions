#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[ListExtensions](ListExtensions.md 'GTC.Extensions.ListExtensions')

## ListExtensions.AddUnique(this List<string>, string) Method

This method provides a simple way to add items to a string list without having any  
duplicate values.

```csharp
public static bool AddUnique(this System.Collections.Generic.List<string> source, string itemToAdd);
```
#### Parameters

<a name='GTC.Extensions.ListExtensions.AddUnique(thisSystem.Collections.Generic.List_string_,string).source'></a>

`source` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') to which this method is exposed.

<a name='GTC.Extensions.ListExtensions.AddUnique(thisSystem.Collections.Generic.List_string_,string).itemToAdd'></a>

`itemToAdd` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The item to be added to the [source](ListExtensions.AddUnique(thisList_string_,string).md#GTC.Extensions.ListExtensions.AddUnique(thisSystem.Collections.Generic.List_string_,string).source 'GTC.Extensions.ListExtensions.AddUnique(this System.Collections.Generic.List<string>, string).source') if it is not already in that list.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the item was added, False if the item was already present and therefore not added.