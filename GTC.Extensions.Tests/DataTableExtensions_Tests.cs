using System;
using Xunit;
using GTC.Extensions;
using System.Threading;
using System.Collections.Generic;
using Serilog;
using Xunit.Abstractions;
using System.Data;

namespace GTC.Extensions.Test
{
    // https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/

    [Collection("xUnitHelper Collection")]
    public class DataTableExtensions_Tests : IClassFixture<xUnitClassFixture>
    {
        xUnitCollectionFixture _collectionFixture;
        xUnitClassFixture _classFixture;

        public DataTableExtensions_Tests(xUnitClassFixture classFixture, xUnitCollectionFixture collectionFixture, ITestOutputHelper output)
        {
            _collectionFixture = collectionFixture;
            _classFixture = classFixture;
            collectionFixture.ConfigureLogging(output, @"c:\temp\DictionaryExtensions_Testing");
        }

        [Theory]
        [ClassData(typeof(TestDataForGetColumnValuesAsStringList))]
        public void DataTableExtensions_GetColumnValuesAsStringList_Test(DataTable table, string columnName, int columnIndex, List<string> result)
        {
            List<string> valueList = table.GetColumnValuesAsStringList(columnName);
            Assert.Equal(valueList, result);

            valueList.Clear();

            valueList = table.GetColumnValuesAsStringList(columnIndex);
            Assert.Equal(valueList, result);
        }

        [Theory]
        [ClassData(typeof(TestDataForGetColumnValues))]
        public void DataTableExtensions_GetColumnValues_Test(DataTable table, string columnName, int columnIndex, List<object> result)
        {
            List<object> valueList = table.GetColumnValues(columnName);
            Assert.Equal(valueList, result);

            valueList.Clear();

            valueList = table.GetColumnValues(columnIndex);
            Assert.Equal(valueList, result);
        }

        [Theory]
        [ClassData(typeof(TestDataForAddTableData))]
        public void DataTableExtensions_AddTableData_Test(DataTable table, DataTable tableToAdd, int expectedResult, DataTable expectedTable)
        {
            int actualResults = table.AddTableData(tableToAdd);
            // First, assert the returned row count.
            Assert.Equal(expectedResult, actualResults);

            // Second, assert that actual and expected have the same number of rows.
            Assert.Equal(expectedTable.Rows.Count, table.Rows.Count);
            
            // Finally assert that every value is the same.
            bool differenceDiscovered = false;
            for (int x = 0; x < expectedTable.Rows.Count; x++)
            {
                for (int y = 0; y < expectedTable.Columns.Count; y++)
                {
                    if (table.Rows[x].ItemArray[y].Equals(expectedTable.Rows[x].ItemArray[y]) == false)
                        differenceDiscovered = true;
                }
            }
            Assert.False(differenceDiscovered);
        }

        [Theory]
        [ClassData(typeof(TestDataForAddTableDataWithBadData))]
        public void DataTableExtensions_AddTableData_BadDataTest(DataTable table, DataTable tableToAdd)
        {
            int actualResults = table.AddTableData(tableToAdd);
            Assert.Equal(0, actualResults);
        }

    }

    #region -- TheoryData -----
    public class TestDataForGetColumnValuesAsStringList : TheoryData<DataTable, string, int, List<string>>
    {
        public TestDataForGetColumnValuesAsStringList()
        { 
            MyDataTable myData = new MyDataTable();

            // Test column 1
            Add(myData.dataTable, "StringColumn1", 0, new List<string>
            {
                "column1Value1",
                "column1Value2",
                "column1Value3",
                "column1Value4"
            });


            Add(myData.dataTable, "IntColumn", 2, new List<string>
            {
                "1",
                "10",
                "100",
                "23"
            });
        }
    }

    public class TestDataForGetColumnValues : TheoryData<DataTable, string, int, List<object>>
    {
        public TestDataForGetColumnValues()
        {
            MyDataTable myData = new MyDataTable();
            List<object> returnList1 = new List<object>
            {
                1,
                10,
                100,
                23
            };

            List<object> returnList2 = new List<object>
            {
                new MyObject(""),
                new MyObject("Value"),
                new MyObject(""),
                new MyObject()
            };
            // Test column 3
            Add(myData.dataTable, "IntColumn", 2, returnList1);
            
            // Test column 4
            Add(myData.dataTable, "ObjectColumn", 3, returnList2);
        }
    }

    public class TestDataForAddTableData : TheoryData<DataTable, DataTable, int, DataTable>
    {
        public TestDataForAddTableData()
        {
            MyDataTable myData = new MyDataTable();
            AdditionalDataTable newData = new AdditionalDataTable();
            FinalDataTable finalData = new FinalDataTable();

            Add(myData.dataTable, newData.dataTable, 2, finalData.dataTable);
        }
    }

    public class TestDataForAddTableDataWithBadData : TheoryData<DataTable, DataTable>
    {
        public TestDataForAddTableDataWithBadData()
        {
            MyDataTable myData = new MyDataTable();
            IncorrectDataTable newData = new IncorrectDataTable();

            Add(myData.dataTable, newData.dataTable);
        }
    }

    public class MyDataTable
    {
        public DataTable dataTable { get; set; }

        public MyDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("StringColumn1", typeof(System.String));
            dataTable.Columns.Add("StringColumn2", typeof(System.String));
            dataTable.Columns.Add("IntColumn", typeof(System.Int32));
            dataTable.Columns.Add("ObjectColumn", typeof(MyObject));

            dataTable.Rows.Add("column1Value1", "column2Value1", 1, new MyObject(""));
            dataTable.Rows.Add("column1Value2", "column2Value2", 10, new MyObject("Value"));
            dataTable.Rows.Add("column1Value3", "column2Value3", 100, new MyObject(""));
            dataTable.Rows.Add("column1Value4", "column2Value4", 23, new MyObject());
        }
    }

    public class AdditionalDataTable
    {
        public DataTable dataTable { get; set; }

        public AdditionalDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("StringColumn1", typeof(System.String));
            dataTable.Columns.Add("StringColumn2", typeof(System.String));
            dataTable.Columns.Add("IntColumn", typeof(System.Int32));
            dataTable.Columns.Add("ObjectColumn", typeof(MyObject));

            dataTable.Rows.Add("column1Value5", "column2Value5", 5, new MyObject(""));
            dataTable.Rows.Add("column1Value6", "column2Value6", 6, new MyObject("Value6"));
        }
    }

    public class IncorrectDataTable
    {
        public DataTable dataTable { get; set; }

        public IncorrectDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("StringColumn1", typeof(System.String));
            dataTable.Columns.Add("IntColumn", typeof(System.Int32));
            dataTable.Columns.Add("StringColumn2", typeof(System.String));
            dataTable.Columns.Add("ObjectColumn", typeof(MyObject));

            dataTable.Rows.Add("column1Value5", 5, "column3Value5", new MyObject(""));
            dataTable.Rows.Add("column1Value6", 6, "column3Value6", new MyObject("Value6"));
        }
    }

    public class FinalDataTable
    {
        public DataTable dataTable { get; set; }

        public FinalDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("StringColumn1", typeof(System.String));
            dataTable.Columns.Add("StringColumn2", typeof(System.String));
            dataTable.Columns.Add("IntColumn", typeof(System.Int32));
            dataTable.Columns.Add("ObjectColumn", typeof(MyObject));

            dataTable.Rows.Add("column1Value1", "column2Value1", 1, new MyObject(""));
            dataTable.Rows.Add("column1Value2", "column2Value2", 10, new MyObject("Value"));
            dataTable.Rows.Add("column1Value3", "column2Value3", 100, new MyObject(""));
            dataTable.Rows.Add("column1Value4", "column2Value4", 23, new MyObject());
            dataTable.Rows.Add("column1Value5", "column2Value5", 5, new MyObject(""));
            dataTable.Rows.Add("column1Value6", "column2Value6", 6, new MyObject("Value6"));
        }
    }

    public class MyObject : IComparable, IEquatable<object>
    {
        public string MyItem { get; set; }
       
        public MyObject() { }

        public MyObject(string initialValue)
        {
            MyItem = initialValue;
        }

        public int CompareTo(object obj)
        {
            if (this.MyItem == null && (obj as MyObject).MyItem == null)
                return 0;
            else if (this.MyItem == null && (obj as MyObject).MyItem != null)
                return -1;
            else if (this.MyItem != null && (obj as MyObject).MyItem == null)
                return 1;
            else
                return MyItem.CompareTo((obj as MyObject).MyItem);
        }

        public override bool Equals(object obj)
        {
            if (this.MyItem == null && (obj as MyObject).MyItem == null)
                return true;
            else if (this.MyItem != null && (obj as MyObject).MyItem != null)
                if (this.MyItem == (obj as MyObject).MyItem)
                    return true;
                else
                    return false;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 19;
            hash = hash * 31 + this.MyItem.GetHashCode();

            return hash;
        }
    }
    #endregion
}
