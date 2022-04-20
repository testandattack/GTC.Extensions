using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using Serilog;
using System.IO;

namespace GTC.Extensions
{
    public static class DataTable_Extensions
    {
        public static List<string> GetColumnValuesAsStringList(this DataTable table, string columnName)
        {
            List<string> items = new List<string>();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row[columnName] != null)
                        items.Add(row[columnName].ToString());
                    else
                        items.Add(string.Empty);
                }
            }
            catch (Exception ex)
            {
                Log.ForContext("Source Context", "GTC.Extensions.DataTable_Extensions")
                    .Error(ex, "GetColumnValuesAsStringList threw an exception using {columnName} as the column input.", columnName);
            }
            return items;
        }

        public static List<string> GetColumnValuesAsStringList(this DataTable table, int columnIndex)
        {
            List<string> items = new List<string>();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row[columnIndex] != null)
                        items.Add(row[columnIndex].ToString());
                    else
                        items.Add(string.Empty);
                }
            }
            catch (Exception ex)
            {
                Log.ForContext("Source Context", "GTC.Extensions.DataTable_Extensions")
                    .Error(ex, "GetColumnValuesAsStringList threw an exception using {columnIndex} as the column input.", columnIndex);
            }
            return items;
        }

        public static List<object> GetColumnValues(this DataTable table, string columnName)
        {
            List<object> items = new List<object>();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    items.Add(row[columnName]);
                }
            }
            catch (Exception ex)
            {
                Log.ForContext("Source Context", "GTC.Extensions.DataTable_Extensions")
                    .Error(ex, "GetColumnValues threw an exception using {columnName} as the column input.", columnName);
            }
            return items;
        }

        public static List<object> GetColumnValues(this DataTable table, int columnIndex)
        {
            List<object> items = new List<object>();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    items.Add(row[columnIndex]);
                }
            }
            catch (Exception ex)
            {
                Log.ForContext("Source Context", "GTC.Extensions.DataTable_Extensions")
                    .Error(ex, "GetColumnValuesAsStringList threw an exception using {columnIndex} as the column input.", columnIndex);
            }
            return items;
        }

        public static int AddTableData(this DataTable table, DataTable tableToAdd)
        {
            int numAdded = 0;
            try
            {
                if (table.Columns != null && tableToAdd.Columns != null
                    && table.Columns.Count == tableToAdd.Columns.Count
                    && table.Rows != null && tableToAdd.Rows != null)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        tableToAdd.Rows.Add(row.ItemArray);
                        numAdded++;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.ForContext("Source Context", "GTC.Extensions.DataTable_Extensions")
                    .Error(ex, "AddTableData threw an exception after adding {numRows} rows of data.", numAdded);
            }
            return numAdded;
        }

        // Need to test and validate
        public static List<string> GetRowValuesAsStringList(this DataTable table, string separator = "")
        {
            List<string> list = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                StringBuilder sb = new StringBuilder();
                //list.Add($"{row[0]}{separator}{row[1]}");
                for (int x = 0; x < row.ItemArray.Length; x++)
                {
                    sb.Append($"{row.ItemArray[x].ToString()}{separator}");
                }
                if (sb.Length > 0)
                    sb.Remove(sb.Length - 1, 1);
                list.Add(sb.ToString());
            }
            return list;
        }

        // Need to test and validate
        public static string GetRowValuesAsSingleString(this DataTable table, string columnSeparator = "", string rowSeparator = "\r\n")
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                for (int x = 0; x < row.ItemArray.Length; x++)
                {
                    sb.Append($"{row.ItemArray[x].ToString()}{columnSeparator}");
                }
                if (sb.Length > 0)
                    sb.Remove(sb.Length - 1, 1);
                sb.Append(rowSeparator);
            }
            return sb.ToString();
        }

        // Need to test and validate
        public static void SaveTableAsCsvFile(this DataTable table, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataColumn column in table.Columns)
                {
                    sb.Append($"{column.ColumnName},");
                }
                if (sb.Length > 0)
                    sb.Remove(sb.Length - 1, 1);
                sw.WriteLine(sb.ToString());

                sw.Write(table.GetRowValuesAsSingleString(",", "\r\n"));
            }
        }
    }
}
