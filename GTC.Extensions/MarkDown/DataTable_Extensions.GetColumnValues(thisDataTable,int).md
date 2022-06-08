#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[DataTable_Extensions](DataTable_Extensions.md 'GTC.Extensions.DataTable_Extensions')

## DataTable_Extensions.GetColumnValues(this DataTable, int) Method

Retrieves all of the items in the specified column and adds the objects to a list object.

```csharp
public static System.Collections.Generic.List<object> GetColumnValues(this System.Data.DataTable table, int columnIndex);
```
#### Parameters

<a name='GTC.Extensions.DataTable_Extensions.GetColumnValues(thisSystem.Data.DataTable,int).table'></a>

`table` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')

The [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to which this method is exposed.

<a name='GTC.Extensions.DataTable_Extensions.GetColumnValues(thisSystem.Data.DataTable,int).columnIndex'></a>

`columnIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index of the column containing the items to retrieve.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
a [System.Collections.Generic.List&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1') object, where {T} represents the column's DataType.