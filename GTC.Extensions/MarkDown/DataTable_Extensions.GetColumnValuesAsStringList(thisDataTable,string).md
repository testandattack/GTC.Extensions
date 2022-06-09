#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[DataTable_Extensions](GTC.Extensions.md#GTC.Extensions.DataTable_Extensions 'GTC.Extensions.DataTable_Extensions')

## DataTable_Extensions.GetColumnValuesAsStringList(this DataTable, string) Method

Retrieves all of the items in the specified column and adds the [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representations to  
a list object.

```csharp
public static System.Collections.Generic.List<string> GetColumnValuesAsStringList(this System.Data.DataTable table, string columnName);
```
#### Parameters

<a name='GTC.Extensions.DataTable_Extensions.GetColumnValuesAsStringList(thisSystem.Data.DataTable,string).table'></a>

`table` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')

The [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to which this method is exposed.

<a name='GTC.Extensions.DataTable_Extensions.GetColumnValuesAsStringList(thisSystem.Data.DataTable,string).columnName'></a>

`columnName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the column containing the items to retrieve.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') object.