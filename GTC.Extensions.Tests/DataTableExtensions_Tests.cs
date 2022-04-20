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
        public void GetColumnValuesAsStringList_Test(DataTable table, string columnName, int columnIndex, List<string> result)
        {
            List<string> valueList = table.GetColumnValuesAsStringList(columnName);
            Assert.Equal(valueList, result);

            valueList.Clear();

            valueList = table.GetColumnValuesAsStringList(columnIndex);
            Assert.Equal(valueList, result);
        }

        [Theory]
        [ClassData(typeof(TestDataForGetColumnValues))]
        public void GetColumnValues_Test(DataTable table, string columnName, int columnIndex, List<object> result)
        {
            List<object> valueList = table.GetColumnValues(columnName);
            Assert.Equal(valueList, result);

            valueList.Clear();

            valueList = table.GetColumnValues(columnIndex);
            Assert.Equal(valueList, result);
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

    public class MyObject : IComparable
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
    }
    #endregion
}
