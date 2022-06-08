#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[DataTable_Extensions](DataTable_Extensions.md 'GTC.Extensions.DataTable_Extensions')

## DataTable_Extensions.AddTableData(this DataTable, DataTable) Method

Adds the data rows from a second table to the first table, assuming that the two schemas are the same.

```csharp
public static int AddTableData(this System.Data.DataTable table, System.Data.DataTable tableToAdd);
```
#### Parameters

<a name='GTC.Extensions.DataTable_Extensions.AddTableData(thisSystem.Data.DataTable,System.Data.DataTable).table'></a>

`table` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')

The [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable') to which this method is exposed.

<a name='GTC.Extensions.DataTable_Extensions.AddTableData(thisSystem.Data.DataTable,System.Data.DataTable).tableToAdd'></a>

`tableToAdd` [System.Data.DataTable](https://docs.microsoft.com/en-us/dotnet/api/System.Data.DataTable 'System.Data.DataTable')

The table containing the rows of data to add.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
a count of the number of rows successfully added to the main table.