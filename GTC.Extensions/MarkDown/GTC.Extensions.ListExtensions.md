### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')

## ListExtensions Class

Extension class for [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') objects that exposes methods for modifying data and retrieving subsets of data.

```csharp
public static class ListExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ListExtensions

| Methods | |
| :--- | :--- |
| [AddUnique(this List&lt;string&gt;, string)](GTC.Extensions.ListExtensions.AddUnique(thisSystem.Collections.Generic.List_string_,string).md 'GTC.Extensions.ListExtensions.AddUnique(this System.Collections.Generic.List<string>, string)') | This method provides a simple way to add items to a string list without having any<br/>duplicate values. |
| [GetNextString(this List&lt;string&gt;, string)](GTC.Extensions.ListExtensions.GetNextString(thisSystem.Collections.Generic.List_string_,string).md 'GTC.Extensions.ListExtensions.GetNextString(this System.Collections.Generic.List<string>, string)') | Finds the string in the list that appears right AFTER the [currentString](GTC.Extensions.ListExtensions.GetNextString(thisSystem.Collections.Generic.List_string_,string).md#GTC.Extensions.ListExtensions.GetNextString(thisSystem.Collections.Generic.List_string_,string).currentString 'GTC.Extensions.ListExtensions.GetNextString(this System.Collections.Generic.List<string>, string).currentString'). |
| [JoinAsCsv(this string[])](GTC.Extensions.ListExtensions.JoinAsCsv(thisstring[]).md 'GTC.Extensions.ListExtensions.JoinAsCsv(this string[])') | This method reads an array of string items and converts them into a single string. |
| [JoinAsCsv(this List&lt;string&gt;)](GTC.Extensions.ListExtensions.JoinAsCsv(thisSystem.Collections.Generic.List_string_).md 'GTC.Extensions.ListExtensions.JoinAsCsv(this System.Collections.Generic.List<string>)') | This method reads a list of string items and converts them into a single string. |
| [ToString(this IEnumerable&lt;int&gt;, string)](GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.IEnumerable_int_,string).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.IEnumerable<int>, string)') | Creates a single string from a list of integers, using the defined separator |
| [ToString(this IEnumerable&lt;int&gt;, string, bool)](GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.IEnumerable_int_,string,bool).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.IEnumerable<int>, string, bool)') | Creates a single string from a list of integers, using the defined separator |
| [ToString(this IEnumerable&lt;string&gt;, string)](GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.IEnumerable_string_,string).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.IEnumerable<string>, string)') | Creates a single string from a list of strings, using the defined separator |
| [ToString(this IEnumerable&lt;string&gt;, string, bool)](GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.IEnumerable_string_,string,bool).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.IEnumerable<string>, string, bool)') | Creates a single string from a list of strings, using the defined separator |
| [ToString(this List&lt;int&gt;, string)](GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.List_int_,string).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.List<int>, string)') | Creates a single string from a list of integers, using the defined separator |
| [ToString(this List&lt;int&gt;, string, bool)](GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.List_int_,string,bool).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.List<int>, string, bool)') | Creates a single string from a list of integers, using the defined separator |
| [ToString(this List&lt;string&gt;, string)](GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.List_string_,string).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.List<string>, string)') | Creates a single string from a list of strings, using the defined separator |
| [ToString(this List&lt;string&gt;, string, bool)](GTC.Extensions.ListExtensions.ToString(thisSystem.Collections.Generic.List_string_,string,bool).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.List<string>, string, bool)') | Creates a single string from a list of strings, using the defined separator |
| [XOR(this List&lt;string&gt;, List&lt;string&gt;)](GTC.Extensions.ListExtensions.XOR(thisSystem.Collections.Generic.List_string_,System.Collections.Generic.List_string_).md 'GTC.Extensions.ListExtensions.XOR(this System.Collections.Generic.List<string>, System.Collections.Generic.List<string>)') | This method performs an "Exclusive OR" operation on two lists, returning only those items<br/>that show up in a single list. |