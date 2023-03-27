#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')

## GTC.Extensions Assembly
### Namespaces

<a name='GTC.Extensions'></a>

## GTC.Extensions Namespace
### Classes

<a name='GTC.Extensions.CharArrayExtensions'></a>

## CharArrayExtensions Class

Extension class for `char[]` objects that exposes extra methods.

```csharp
public static class CharArrayExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CharArrayExtensions

| Methods | |
| :--- | :--- |
| [AsString(this char[])](CharArrayExtensions.AsString(thischar[]).md 'GTC.Extensions.CharArrayExtensions.AsString(this char[])') | Creates a string object from the character array. |
| [Contains(this char[], char)](CharArrayExtensions.Contains(thischar[],char).md 'GTC.Extensions.CharArrayExtensions.Contains(this char[], char)') | Searches the array for the specified character. |
| [Location(this char[], char)](CharArrayExtensions.Location(thischar[],char).md 'GTC.Extensions.CharArrayExtensions.Location(this char[], char)') | Searches the array for the specified character, getting the index of the first instance of the character. |

<a name='GTC.Extensions.DataTable_Extensions'></a>

## DataTable_Extensions Class

Extension class for [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') objects that exposes methods for modifying data and retrieving subsets of data.

```csharp
public static class DataTable_Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DataTable_Extensions

| Methods | |
| :--- | :--- |
| [AddTableData(this DataTable, DataTable)](DataTable_Extensions.AddTableData(thisDataTable,DataTable).md 'GTC.Extensions.DataTable_Extensions.AddTableData(this System.Data.DataTable, System.Data.DataTable)') | Adds the data rows from a second table to the first table, assuming that the two schemas are the same. |
| [GetColumnValues(this DataTable, int)](DataTable_Extensions.GetColumnValues(thisDataTable,int).md 'GTC.Extensions.DataTable_Extensions.GetColumnValues(this System.Data.DataTable, int)') | Retrieves all of the items in the specified column and adds the objects to a list object. |
| [GetColumnValues(this DataTable, string)](DataTable_Extensions.GetColumnValues(thisDataTable,string).md 'GTC.Extensions.DataTable_Extensions.GetColumnValues(this System.Data.DataTable, string)') | Retrieves all of the items in the specified column and adds the objects to a list object. |
| [GetColumnValuesAsStringList(this DataTable, int)](DataTable_Extensions.GetColumnValuesAsStringList(thisDataTable,int).md 'GTC.Extensions.DataTable_Extensions.GetColumnValuesAsStringList(this System.Data.DataTable, int)') | Retrieves all of the items in the specified column and adds the [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representations to<br/>a list object. |
| [GetColumnValuesAsStringList(this DataTable, string)](DataTable_Extensions.GetColumnValuesAsStringList(thisDataTable,string).md 'GTC.Extensions.DataTable_Extensions.GetColumnValuesAsStringList(this System.Data.DataTable, string)') | Retrieves all of the items in the specified column and adds the [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representations to<br/>a list object. |

<a name='GTC.Extensions.DateTimeExtensions'></a>

## DateTimeExtensions Class

A set of extension methods for [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime') objects.

```csharp
public static class DateTimeExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DateTimeExtensions

| Methods | |
| :--- | :--- |
| [DaysSince2000(this DateTime)](DateTimeExtensions.DaysSince2000(thisDateTime).md 'GTC.Extensions.DateTimeExtensions.DaysSince2000(this System.DateTime)') | Calculates the number of days since January 1, 2000. |
| [GetElapsedSeconds(this DateTime, bool)](DateTimeExtensions.GetElapsedSeconds(thisDateTime,bool).md 'GTC.Extensions.DateTimeExtensions.GetElapsedSeconds(this System.DateTime, bool)') | Calculates the number of seconds between the object's creation time and [System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'). |
| [GetElapsedSecondsForDisplay(this DateTime)](DateTimeExtensions.GetElapsedSecondsForDisplay(thisDateTime).md 'GTC.Extensions.DateTimeExtensions.GetElapsedSecondsForDisplay(this System.DateTime)') | Calculates the number of seconds between the object's creation time and [System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'), formatting it as<br/>a string using the [https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString 'https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString')<br/>string formatter. |

<a name='GTC.Extensions.DictionaryExtensions'></a>

## DictionaryExtensions Class

A collection of extension methods for certain Dictionary objects.

```csharp
public static class DictionaryExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DictionaryExtensions

### Remarks
These extension methods are designed only for a few combinations of dictionaries and will not work on  
many combinations. Please refer to the information provided in each method's documentation to determine  
if it will work for you.

| Methods | |
| :--- | :--- |
| [AddOrUpdate(this Dictionary&lt;string,string&gt;, string, string)](DictionaryExtensions.AddOrUpdate(thisDictionary_string,string_,string,string).md 'GTC.Extensions.DictionaryExtensions.AddOrUpdate(this System.Collections.Generic.Dictionary<string,string>, string, string)') | This method checks for the existence of [sKey](DictionaryExtensions.AddOrUpdate(thisDictionary_string,string_,string,string).md#GTC.Extensions.DictionaryExtensions.AddOrUpdate(thisSystem.Collections.Generic.Dictionary_string,string_,string,string).sKey 'GTC.Extensions.DictionaryExtensions.AddOrUpdate(this System.Collections.Generic.Dictionary<string,string>, string, string).sKey') in the dictionary. If present, the<br/>current value is replaced with the new [sValue](DictionaryExtensions.AddOrUpdate(thisDictionary_string,string_,string,string).md#GTC.Extensions.DictionaryExtensions.AddOrUpdate(thisSystem.Collections.Generic.Dictionary_string,string_,string,string).sValue 'GTC.Extensions.DictionaryExtensions.AddOrUpdate(this System.Collections.Generic.Dictionary<string,string>, string, string).sValue'). Otherwise, the key and value are added<br/>to the Dictionary. |
| [AddOrUpdateCount(this Dictionary&lt;string,int&gt;, string)](DictionaryExtensions.AddOrUpdateCount(thisDictionary_string,int_,string).md 'GTC.Extensions.DictionaryExtensions.AddOrUpdateCount(this System.Collections.Generic.Dictionary<string,int>, string)') | This method allows you to manage a `Dictionary{string,int}` that stores a list of strings and a quantity that <br/>indicates how many times each string has been found, counted, added, etc. |
| [AddOrUpdateItems(this Dictionary&lt;string,List&lt;string&gt;&gt;, string, string)](DictionaryExtensions.AddOrUpdateItems(thisDictionary_string,List_string__,string,string).md 'GTC.Extensions.DictionaryExtensions.AddOrUpdateItems(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.List<string>>, string, string)') | This method allows you to manage a list of values for each specified key in a Dictionary. |
| [AddSafely(this Dictionary&lt;string,string&gt;, string, string)](DictionaryExtensions.AddSafely(thisDictionary_string,string_,string,string).md 'GTC.Extensions.DictionaryExtensions.AddSafely(this System.Collections.Generic.Dictionary<string,string>, string, string)') | This method checks for the existence of the given key. If the key is NOT present<br/>in the dictionary, then the Key-Value-Pair is added. If the key IS present, then no action<br/>is taken. |
| [AsString(this Dictionary&lt;string,string&gt;, string, string)](DictionaryExtensions.AsString(thisDictionary_string,string_,string,string).md 'GTC.Extensions.DictionaryExtensions.AsString(this System.Collections.Generic.Dictionary<string,string>, string, string)') | This method converts all of the Key-Value-Pair entries into a single string,<br/>using the provided separators between the entries. |
| [GetKey(this Dictionary&lt;string,string&gt;, int)](DictionaryExtensions.GetKey(thisDictionary_string,string_,int).md 'GTC.Extensions.DictionaryExtensions.GetKey(this System.Collections.Generic.Dictionary<string,string>, int)') | Retrieves the string value for the Key from the dictionary which is stored at the specified [iIndex](DictionaryExtensions.GetKey(thisDictionary_string,string_,int).md#GTC.Extensions.DictionaryExtensions.GetKey(thisSystem.Collections.Generic.Dictionary_string,string_,int).iIndex 'GTC.Extensions.DictionaryExtensions.GetKey(this System.Collections.Generic.Dictionary<string,string>, int).iIndex'). |
| [GetKey(this Dictionary&lt;string,IEnumerable&lt;string&gt;&gt;, int)](DictionaryExtensions.GetKey(thisDictionary_string,IEnumerable_string__,int).md 'GTC.Extensions.DictionaryExtensions.GetKey(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, int)') | Retrieves the string value for the Key from the dictionary which is stored at the specified [iIndex](DictionaryExtensions.GetKey(thisDictionary_string,IEnumerable_string__,int).md#GTC.Extensions.DictionaryExtensions.GetKey(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,int).iIndex 'GTC.Extensions.DictionaryExtensions.GetKey(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, int).iIndex'). |
| [GetValue(this Dictionary&lt;string,string&gt;, int)](DictionaryExtensions.GetValue(thisDictionary_string,string_,int).md 'GTC.Extensions.DictionaryExtensions.GetValue(this System.Collections.Generic.Dictionary<string,string>, int)') | Retrieves the string value from the dictionary which is stored at the specified [iIndex](DictionaryExtensions.GetValue(thisDictionary_string,string_,int).md#GTC.Extensions.DictionaryExtensions.GetValue(thisSystem.Collections.Generic.Dictionary_string,string_,int).iIndex 'GTC.Extensions.DictionaryExtensions.GetValue(this System.Collections.Generic.Dictionary<string,string>, int).iIndex'). |
| [GetValue(this Dictionary&lt;string,IEnumerable&lt;string&gt;&gt;, int)](DictionaryExtensions.GetValue(thisDictionary_string,IEnumerable_string__,int).md 'GTC.Extensions.DictionaryExtensions.GetValue(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, int)') | Retrieves the IEnumerable value from the dictionary which is stored at the specified [iIndex](DictionaryExtensions.GetValue(thisDictionary_string,IEnumerable_string__,int).md#GTC.Extensions.DictionaryExtensions.GetValue(thisSystem.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,int).iIndex 'GTC.Extensions.DictionaryExtensions.GetValue(this System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, int).iIndex'). |

<a name='GTC.Extensions.ListExtensions'></a>

## ListExtensions Class

Extension class for [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') objects that exposes methods for modifying data and retrieving subsets of data.

```csharp
public static class ListExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ListExtensions

| Methods | |
| :--- | :--- |
| [AddUnique(this List&lt;string&gt;, string)](ListExtensions.AddUnique(thisList_string_,string).md 'GTC.Extensions.ListExtensions.AddUnique(this System.Collections.Generic.List<string>, string)') | This method provides a simple way to add items to a string list without having any<br/>duplicate values. |
| [Except(this List&lt;string&gt;, string)](ListExtensions.Except(thisList_string_,string).md 'GTC.Extensions.ListExtensions.Except(this System.Collections.Generic.List<string>, string)') | Returns a new list that does not contain the [itemToExclude](ListExtensions.Except(thisList_string_,string).md#GTC.Extensions.ListExtensions.Except(thisSystem.Collections.Generic.List_string_,string).itemToExclude 'GTC.Extensions.ListExtensions.Except(this System.Collections.Generic.List<string>, string).itemToExclude'). |
| [GetNextString(this List&lt;string&gt;, string)](ListExtensions.GetNextString(thisList_string_,string).md 'GTC.Extensions.ListExtensions.GetNextString(this System.Collections.Generic.List<string>, string)') | Finds the string in the list that appears right AFTER the [currentString](ListExtensions.GetNextString(thisList_string_,string).md#GTC.Extensions.ListExtensions.GetNextString(thisSystem.Collections.Generic.List_string_,string).currentString 'GTC.Extensions.ListExtensions.GetNextString(this System.Collections.Generic.List<string>, string).currentString'). |
| [JoinAsCsv(this string[])](ListExtensions.JoinAsCsv(thisstring[]).md 'GTC.Extensions.ListExtensions.JoinAsCsv(this string[])') | This method reads an array of string items and converts them into a single string. |
| [JoinAsCsv(this List&lt;string&gt;)](ListExtensions.JoinAsCsv(thisList_string_).md 'GTC.Extensions.ListExtensions.JoinAsCsv(this System.Collections.Generic.List<string>)') | This method reads a list of string items and converts them into a single string. |
| [ToString(this IEnumerable&lt;int&gt;, string)](ListExtensions.ToString(thisIEnumerable_int_,string).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.IEnumerable<int>, string)') | Creates a single string from a list of integers, using the defined separator |
| [ToString(this IEnumerable&lt;int&gt;, string, bool)](ListExtensions.ToString(thisIEnumerable_int_,string,bool).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.IEnumerable<int>, string, bool)') | Creates a single string from a list of integers, using the defined separator |
| [ToString(this IEnumerable&lt;string&gt;, string)](ListExtensions.ToString(thisIEnumerable_string_,string).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.IEnumerable<string>, string)') | Creates a single string from a list of strings, using the defined separator |
| [ToString(this IEnumerable&lt;string&gt;, string, bool)](ListExtensions.ToString(thisIEnumerable_string_,string,bool).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.IEnumerable<string>, string, bool)') | Creates a single string from a list of strings, using the defined separator |
| [ToString(this List&lt;int&gt;, string)](ListExtensions.ToString(thisList_int_,string).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.List<int>, string)') | Creates a single string from a list of integers, using the defined separator |
| [ToString(this List&lt;int&gt;, string, bool)](ListExtensions.ToString(thisList_int_,string,bool).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.List<int>, string, bool)') | Creates a single string from a list of integers, using the defined separator |
| [ToString(this List&lt;string&gt;, string)](ListExtensions.ToString(thisList_string_,string).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.List<string>, string)') | Creates a single string from a list of strings, using the defined separator |
| [ToString(this List&lt;string&gt;, string, bool)](ListExtensions.ToString(thisList_string_,string,bool).md 'GTC.Extensions.ListExtensions.ToString(this System.Collections.Generic.List<string>, string, bool)') | Creates a single string from a list of strings, using the defined separator |
| [XOR(this List&lt;string&gt;, List&lt;string&gt;)](ListExtensions.XOR(thisList_string_,List_string_).md 'GTC.Extensions.ListExtensions.XOR(this System.Collections.Generic.List<string>, System.Collections.Generic.List<string>)') | This method performs an "Exclusive OR" operation on two lists, returning only those items<br/>that show up in a single list. |

<a name='GTC.Extensions.MathExtensions'></a>

## MathExtensions Class

Extension class for [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') objects that exposes Statistical mathematics methods.

```csharp
public static class MathExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MathExtensions

| Methods | |
| :--- | :--- |
| [NormalStdDev(this IEnumerable&lt;double&gt;)](MathExtensions.NormalStdDev(thisIEnumerable_double_).md 'GTC.Extensions.MathExtensions.NormalStdDev(this System.Collections.Generic.IEnumerable<double>)') | NORMAL Std Dev<br/>https://stackoverflow.com/questions/2253874/standard-deviation-in-linq  <br/>Divide by n instead of divide by n-1 |
| [PercentileValue(this IEnumerable&lt;double&gt;, double, int)](MathExtensions.PercentileValue(thisIEnumerable_double_,double,int).md 'GTC.Extensions.MathExtensions.PercentileValue(this System.Collections.Generic.IEnumerable<double>, double, int)') | Returns the value from the list that is the largest value<br/>within the subset of percentile values sorted by<br/>smallest to largest. |
| [SampleStdDev(this IEnumerable&lt;double&gt;)](MathExtensions.SampleStdDev(thisIEnumerable_double_).md 'GTC.Extensions.MathExtensions.SampleStdDev(this System.Collections.Generic.IEnumerable<double>)') | SAMPLE Std Dev<br/>https://stackoverflow.com/questions/2253874/standard-deviation-in-linq |
| [StdDev(this IEnumerable&lt;double&gt;, bool, int)](MathExtensions.StdDev(thisIEnumerable_double_,bool,int).md 'GTC.Extensions.MathExtensions.StdDev(this System.Collections.Generic.IEnumerable<double>, bool, int)') | Allows you to call either Sample based or Normal Std Dev methods that are based on this article:<br/>https://stackoverflow.com/questions/2253874/standard-deviation-in-linq |

<a name='GTC.Extensions.StringExtensions'></a>

## StringExtensions Class

This class contains a series of methods to perform various operations on strings.

```csharp
public static class StringExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StringExtensions

| Methods | |
| :--- | :--- |
| [AddBraces(this string)](StringExtensions.AddBraces(thisstring).md 'GTC.Extensions.StringExtensions.AddBraces(this string)') | Returns a new string that contains the [source](StringExtensions.AddBraces(thisstring).md#GTC.Extensions.StringExtensions.AddBraces(thisstring).source 'GTC.Extensions.StringExtensions.AddBraces(this string).source') string<br/>surrounded by double curly braces. This is used for defining context<br/>parameters in some test engines. |
| [Base64Decode(this string)](StringExtensions.Base64Decode(thisstring).md 'GTC.Extensions.StringExtensions.Base64Decode(this string)') | Returns a new string that has been converted from a Base64 Encoded string format<br/>into its original format. |
| [Base64Encode(this string)](StringExtensions.Base64Encode(thisstring).md 'GTC.Extensions.StringExtensions.Base64Encode(this string)') | Returns a new string that has been converted to a Base64 Encoded string format. |
| [CsvStrToList(this string)](StringExtensions.CsvStrToList(thisstring).md 'GTC.Extensions.StringExtensions.CsvStrToList(this string)') | Returns a list of strings from a single string that is CSV formatted. For more information, see<br/>[
            this article](https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings 'https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings'). |
| [CsvStrToList(this string, bool)](StringExtensions.CsvStrToList(thisstring,bool).md 'GTC.Extensions.StringExtensions.CsvStrToList(this string, bool)') | Returns a list of strings from a single string that is CSV formatted. For more information, see<br/>[
            this article](https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings 'https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings'). |
| [CsvStrToStringArray(this string, bool)](StringExtensions.CsvStrToStringArray(thisstring,bool).md 'GTC.Extensions.StringExtensions.CsvStrToStringArray(this string, bool)') | Returns an array of strings from a single string that is CSV formatted. For more information, see<br/>[
            this article](https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings 'https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings'). |
| [DelimitedStringToIntArray(this string, string)](StringExtensions.DelimitedStringToIntArray(thisstring,string).md 'GTC.Extensions.StringExtensions.DelimitedStringToIntArray(this string, string)') | Converts a string that has numbers separated by a defined delimiter into an<br/>array of integers. |
| [FileNameWithoutPath(this string)](StringExtensions.FileNameWithoutPath(thisstring).md 'GTC.Extensions.StringExtensions.FileNameWithoutPath(this string)') | Gets the name of a file from a fully qualified fileName, dropping any path info present. |
| [FindSubString(this string, string, string)](StringExtensions.FindSubString(thisstring,string,string).md 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string)') | Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string).endsWith')<br/>strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty'). |
| [FindSubString(this string, string, string, bool)](StringExtensions.FindSubString(thisstring,string,string,bool).md 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, bool)') | Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, bool).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,bool).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, bool).endsWith')<br/>strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty'). |
| [FindSubString(this string, string, string, int)](StringExtensions.FindSubString(thisstring,string,string,int).md 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int)') | Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int).endsWith')<br/>strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty'). |
| [FindSubString(this string, string, string, int, int)](StringExtensions.FindSubString(thisstring,string,string,int,int).md 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, int)') | Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, int).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,int,int).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,int).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, int).endsWith')<br/>strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty'). |
| [FindSubString(this string, string, string, int, StringComparison)](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison).md 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison)') | Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison).endsWith')<br/>strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty'). |
| [FindSubString(this string, string, string, int, StringComparison, int, bool)](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison,int,bool).md 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison, int, bool)') | Looks for, and returns (if found) a string that resides in between the given [startsAfter](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison,int,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).startsAfter 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison, int, bool).startsAfter') and [endsWith](StringExtensions.FindSubString(thisstring,string,string,int,StringComparison,int,bool).md#GTC.Extensions.StringExtensions.FindSubString(thisstring,string,string,int,System.StringComparison,int,bool).endsWith 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string, int, System.StringComparison, int, bool).endsWith')<br/>strings. If the given start anbd ends strings are noit found, the method returns [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty'). |
| [FindSubStrings(this string, char)](StringExtensions.FindSubStrings(thisstring,char).md 'GTC.Extensions.StringExtensions.FindSubStrings(this string, char)') | Searches a string for all instances of substrings surrounded by a specific character |
| [FindSubStrings(this string, char, bool)](StringExtensions.FindSubStrings(thisstring,char,bool).md 'GTC.Extensions.StringExtensions.FindSubStrings(this string, char, bool)') | |
| [FindSubStrings(this string, string, string)](StringExtensions.FindSubStrings(thisstring,string,string).md 'GTC.Extensions.StringExtensions.FindSubStrings(this string, string, string)') | Searches a string for all instances of a substring, using the [FindSubString(this string, string, string)](StringExtensions.FindSubString(thisstring,string,string).md 'GTC.Extensions.StringExtensions.FindSubString(this string, string, string)')<br/>method, adding every found instance to a list. |
| [Flattened(this string, int)](StringExtensions.Flattened(thisstring,int).md 'GTC.Extensions.StringExtensions.Flattened(this string, int)') | returns a new string with all carriage returns and line feeds removed. |
| [GetLeftPart(this string, string, bool)](StringExtensions.GetLeftPart(thisstring,string,bool).md 'GTC.Extensions.StringExtensions.GetLeftPart(this string, string, bool)') | Gets the left side [beginning] of a given string, up to, but not including the [delimiter](StringExtensions.GetLeftPart(thisstring,string,bool).md#GTC.Extensions.StringExtensions.GetLeftPart(thisstring,string,bool).delimiter 'GTC.Extensions.StringExtensions.GetLeftPart(this string, string, bool).delimiter'). |
| [GetRightPart(this string, string)](StringExtensions.GetRightPart(thisstring,string).md 'GTC.Extensions.StringExtensions.GetRightPart(this string, string)') | Gets the right side [end] of a given string, starting with the text AFTER the [delimiter](StringExtensions.GetRightPart(thisstring,string).md#GTC.Extensions.StringExtensions.GetRightPart(thisstring,string).delimiter 'GTC.Extensions.StringExtensions.GetRightPart(this string, string).delimiter'). |
| [GetUrlWithoutQuery(this string)](StringExtensions.GetUrlWithoutQuery(thisstring).md 'GTC.Extensions.StringExtensions.GetUrlWithoutQuery(this string)') | Gets the URL portion of a string, removing any query parameter text that might<br/>be part of the string. |
| [IsBoolean(this string)](StringExtensions.IsBoolean(thisstring).md 'GTC.Extensions.StringExtensions.IsBoolean(this string)') | Checks the value of the string to see if it represents a boolean value. |
| [IsGreaterThan(this string, string, StringComparison)](StringExtensions.IsGreaterThan(thisstring,string,StringComparison).md 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison)') | This method uses the [System.String.CompareTo(System.String)](https://docs.microsoft.com/en-us/dotnet/api/System.String.CompareTo#System_String_CompareTo_System_String_ 'System.String.CompareTo(System.String)') to get the<br/>sorted order of the two strings, then returns `True` if [source](StringExtensions.IsGreaterThan(thisstring,string,StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).source 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).source')<br/>comes before [secondString](StringExtensions.IsGreaterThan(thisstring,string,StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).secondString 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).secondString') or `False` if they are equal or [secondString](StringExtensions.IsGreaterThan(thisstring,string,StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).secondString 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).secondString')<br/>comes before [source](StringExtensions.IsGreaterThan(thisstring,string,StringComparison).md#GTC.Extensions.StringExtensions.IsGreaterThan(thisstring,string,System.StringComparison).source 'GTC.Extensions.StringExtensions.IsGreaterThan(this string, string, System.StringComparison).source'). |
| [IsLessThan(this string, string, StringComparison)](StringExtensions.IsLessThan(thisstring,string,StringComparison).md 'GTC.Extensions.StringExtensions.IsLessThan(this string, string, System.StringComparison)') | This method uses the [System.String.CompareTo(System.String)](https://docs.microsoft.com/en-us/dotnet/api/System.String.CompareTo#System_String_CompareTo_System_String_ 'System.String.CompareTo(System.String)') to get the<br/>sorted order of the two strings, then returns `True` if [source](StringExtensions.IsLessThan(thisstring,string,StringComparison).md#GTC.Extensions.StringExtensions.IsLessThan(thisstring,string,System.StringComparison).source 'GTC.Extensions.StringExtensions.IsLessThan(this string, string, System.StringComparison).source')<br/>comes after [secondString](StringExtensions.IsLessThan(thisstring,string,StringComparison).md#GTC.Extensions.StringExtensions.IsLessThan(thisstring,string,System.StringComparison).secondString 'GTC.Extensions.StringExtensions.IsLessThan(this string, string, System.StringComparison).secondString') or `False` if they are equal or [secondString](StringExtensions.IsLessThan(thisstring,string,StringComparison).md#GTC.Extensions.StringExtensions.IsLessThan(thisstring,string,System.StringComparison).secondString 'GTC.Extensions.StringExtensions.IsLessThan(this string, string, System.StringComparison).secondString')<br/>comes after [source](StringExtensions.IsLessThan(thisstring,string,StringComparison).md#GTC.Extensions.StringExtensions.IsLessThan(thisstring,string,System.StringComparison).source 'GTC.Extensions.StringExtensions.IsLessThan(this string, string, System.StringComparison).source'). |
| [IsNumeric(this string)](StringExtensions.IsNumeric(thisstring).md 'GTC.Extensions.StringExtensions.IsNumeric(this string)') | Checks the value of the string to see if it represents an <br/>[
            integral or numeric](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types') value. |
| [RemoveEncapsulatingQuotes(this string)](StringExtensions.RemoveEncapsulatingQuotes(thisstring).md 'GTC.Extensions.StringExtensions.RemoveEncapsulatingQuotes(this string)') | If the string has quotes at the beginning and end locations, this method returns a <br/>new string without those quotes. |
| [RemoveQuoteEscapes(this string)](StringExtensions.RemoveQuoteEscapes(thisstring).md 'GTC.Extensions.StringExtensions.RemoveQuoteEscapes(this string)') | Returns a new string without any "escaped Quotes" from the [source](StringExtensions.RemoveQuoteEscapes(thisstring).md#GTC.Extensions.StringExtensions.RemoveQuoteEscapes(thisstring).source 'GTC.Extensions.StringExtensions.RemoveQuoteEscapes(this string).source'). <br/>This is useful when a string is copied<br/>from a system that requires quotes to be escaped. |
| [Shortened(this string, int)](StringExtensions.Shortened(thisstring,int).md 'GTC.Extensions.StringExtensions.Shortened(this string, int)') | Returns a shortened version of the [source](StringExtensions.Shortened(thisstring,int).md#GTC.Extensions.StringExtensions.Shortened(thisstring,int).source 'GTC.Extensions.StringExtensions.Shortened(this string, int).source') string, with the<br/>word "**TRUNCATED**" added to the end. |
| [SplitCsvRowToArray(this string, bool)](StringExtensions.SplitCsvRowToArray(thisstring,bool).md 'GTC.Extensions.StringExtensions.SplitCsvRowToArray(this string, bool)') | `OBSOLETE` This method is maintained for backward compatibility. <br/>            Call [CsvStrToStringArray(this string, bool)](StringExtensions.CsvStrToStringArray(thisstring,bool).md 'GTC.Extensions.StringExtensions.CsvStrToStringArray(this string, bool)') instead. |
| [SplitCsvRowToList(this string, bool)](StringExtensions.SplitCsvRowToList(thisstring,bool).md 'GTC.Extensions.StringExtensions.SplitCsvRowToList(this string, bool)') | `OBSOLETE` This method is maintained for backward compatibility. <br/>            Call [CsvStrToList(this string, bool)](StringExtensions.CsvStrToList(thisstring,bool).md 'GTC.Extensions.StringExtensions.CsvStrToList(this string, bool)') instead. |
| [ToCamelCase(this string)](StringExtensions.ToCamelCase(thisstring).md 'GTC.Extensions.StringExtensions.ToCamelCase(this string)') | This method takes a string representing a namespace or object name, and creates<br/>a new string where all leading characters are converted to lower case. |
| [ToStream(this string)](StringExtensions.ToStream(thisstring).md 'GTC.Extensions.StringExtensions.ToStream(this string)') | Converts a string to a Memory Stream. |
| [ToStream(this string, bool)](StringExtensions.ToStream(thisstring,bool).md 'GTC.Extensions.StringExtensions.ToStream(this string, bool)') | Converts a string to a Memory Stream. |
| [UrlDecode(this string)](StringExtensions.UrlDecode(thisstring).md 'GTC.Extensions.StringExtensions.UrlDecode(this string)') | Returns a new string that has been processed by a call to [System.Web.HttpUtility.UrlDecode(System.String)](https://docs.microsoft.com/en-us/dotnet/api/System.Web.HttpUtility.UrlDecode#System_Web_HttpUtility_UrlDecode_System_String_ 'System.Web.HttpUtility.UrlDecode(System.String)'). |
