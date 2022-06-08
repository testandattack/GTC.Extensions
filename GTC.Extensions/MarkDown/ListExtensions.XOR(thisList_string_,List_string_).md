#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[ListExtensions](ListExtensions.md 'GTC.Extensions.ListExtensions')

## ListExtensions.XOR(this List<string>, List<string>) Method

This method performs an "Exclusive OR" operation on two lists, returning only those items  
that show up in a single list.

```csharp
public static System.Collections.Generic.List<string> XOR(this System.Collections.Generic.List<string> source, System.Collections.Generic.List<string> secondList);
```
#### Parameters

<a name='GTC.Extensions.ListExtensions.XOR(thisSystem.Collections.Generic.List_string_,System.Collections.Generic.List_string_).source'></a>

`source` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') to which this method is exposed.

<a name='GTC.Extensions.ListExtensions.XOR(thisSystem.Collections.Generic.List_string_,System.Collections.Generic.List_string_).secondList'></a>

`secondList` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The second [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') that will be compared against the [source](ListExtensions.XOR(thisList_string_,List_string_).md#GTC.Extensions.ListExtensions.XOR(thisSystem.Collections.Generic.List_string_,System.Collections.Generic.List_string_).source 'GTC.Extensions.ListExtensions.XOR(this System.Collections.Generic.List<string>, System.Collections.Generic.List<string>).source') list.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
a new [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') with the rtesults.

### Remarks
If list1 contains `"one", "two", "three", "four"` and list2 contains `"two", "four", "six"`  
then the returned list will contain `"one", "three", "six"`.