#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[ListExtensions](ListExtensions.md 'GTC.Extensions.ListExtensions')

## ListExtensions.GetNextString(this List<string>, string) Method

Finds the string in the list that appears right AFTER the [currentString](ListExtensions.GetNextString(thisList_string_,string).md#GTC.Extensions.ListExtensions.GetNextString(thisSystem.Collections.Generic.List_string_,string).currentString 'GTC.Extensions.ListExtensions.GetNextString(this System.Collections.Generic.List<string>, string).currentString').

```csharp
public static string GetNextString(this System.Collections.Generic.List<string> source, string currentString);
```
#### Parameters

<a name='GTC.Extensions.ListExtensions.GetNextString(thisSystem.Collections.Generic.List_string_,string).source'></a>

`source` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') to which this method is exposed.

<a name='GTC.Extensions.ListExtensions.GetNextString(thisSystem.Collections.Generic.List_string_,string).currentString'></a>

`currentString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the string that appears right BEFORE the string to retrieve

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
This method is useful if you want to walk through all of the values in a List, one at a time.