#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[DictionaryExtensions](GTC.Extensions.md#GTC.Extensions.DictionaryExtensions 'GTC.Extensions.DictionaryExtensions')

## DictionaryExtensions.GetKey(this Dictionary<string,IEnumerable<string>>, int) Method

Retrieves the string value for the Key from the dictionary which is stored at the specified [iIndex](DictionaryExtensions.GetKey(thisDictionary_string,IEnumerable_string__,int).md#GTC.Extensions.DictionaryExtensions.GetKey(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,int).iIndex 'GTC.Extensions.DictionaryExtensions.GetKey(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, int).iIndex').

```csharp
public static string GetKey(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> source, int iIndex);
```
#### Parameters

<a name='GTC.Extensions.DictionaryExtensions.GetKey(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,int).source'></a>

`source` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The `Dictionary{string, IEnumerable{string}}` to which this method is exposed.

<a name='GTC.Extensions.DictionaryExtensions.GetKey(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,int).iIndex'></a>

`iIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based integer representing the index of the entry to use.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string representing the KEY for the item.

### Remarks
Useful when generating nested lists and objects where the keys are based on sequential ids.  
For instance, parsing Tree View items via 'SelectedItemChanged' and getting the associated   
property name and value. Consider the following code snippet:  
  
```csharp  
WTI_Request parent = GetParentRequest(tvi);  
int x = Int32.Parse(tvi.Name.Substring(TVI_Name_Headers.Length));  
Dictionary{string, object} props = new Dictionary{string, object}();  
props.Add("Header Name", parent.Headers.GetKey(x));  
props.Add("Header Value", parent.Headers.GetValue(x));  
```  
- Line 1 gets a WTI_Request object. That object contains a dictionary of request headers.  
- When adding items to the treeview, they are named by using a constant value with an index appended to the end (in this case `TVI_Name_Headers`). Line 2 retrieves the appended index and converts it to an integer.  
- Line 3 Creates a new Dictionary that will hold the Key and Value from the request's selected header.  
- Line 4 gets the key by calling `parent.Headers.GetKey(x)`.  
- Line 5 gets the value by calling `parent.Headers.GetValue(x)`.