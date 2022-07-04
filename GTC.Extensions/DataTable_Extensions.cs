using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using Serilog;
using System.IO;

namespace GTC.Extensions
{
    /// <summary>
    /// Extension class for <see cref="DataTable"/> objects that exposes methods for modifying data and retrieving subsets of data.
    /// </summary>
    public static class DataTable_Extensions
    {
        /// <summary>
        /// Retrieves all of the items in the specified column and adds the <see cref="String"/> representations to
        /// a list object.
        /// </summary>
        /// <param name="table">The <see cref="DataTable"/> to which this method is exposed.</param>
        /// <param name="columnName">The name of the column containing the items to retrieve.</param>
        /// <returns>a <see cref="List{String}"/> object.</returns>
        public static List<string> GetColumnValuesAsStringList(this DataTable table, string columnName)
        {
            try
            {
                int iIndex = table.Columns[columnName].Ordinal;
                return table.GetColumnValuesAsStringList(iIndex);
            }
            catch (Exception ex)
            {
                Log.ForContext("Source Context", "GTC.Extensions.DataTable_Extensions")
                    .Error(ex, "GetColumnValuesAsStringList threw an exception using {columnName} as the column input.", columnName);
            }
            return null;
        }

        /// <summary>
        /// Retrieves all of the items in the specified column and adds the <see cref="String"/> representations to
        /// a list object.
        /// </summary>
        /// <param name="table">The <see cref="DataTable"/> to which this method is exposed.</param>
        /// <param name="columnIndex">The index of the column containing the items to retrieve.</param>
        /// <returns>a <see cref="List{String}"/> object.</returns>
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

        /// <summary>
        /// Retrieves all of the items in the specified column and adds the objects to a list object.
        /// </summary>
        /// <param name="table">The <see cref="DataTable"/> to which this method is exposed.</param>
        /// <param name="columnName">The name of the column containing the items to retrieve.</param>
        /// <returns>a <see cref="List{T}"/> object, where {T} represents the column's DataType.</returns>
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

        /// <summary>
        /// Retrieves all of the items in the specified column and adds the objects to a list object.
        /// </summary>
        /// <param name="table">The <see cref="DataTable"/> to which this method is exposed.</param>
        /// <param name="columnIndex">The index of the column containing the items to retrieve.</param>
        /// <returns>a <see cref="List{T}"/> object, where {T} represents the column's DataType.</returns>
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

        /// <summary>
        /// Adds the data rows from a second table to the first table, assuming that the two schemas are the same.
        /// </summary>
        /// <param name="table">The <see cref="DataTable"/> to which this method is exposed.</param>
        /// <param name="tableToAdd">The table containing the rows of data to add.</param>
        /// <returns>a count of the number of rows successfully added to the main table.</returns>
        public static int AddTableData(this DataTable table, DataTable tableToAdd)
        {
            int numAdded = 0;
            try
            {
                if (table.Columns != null && tableToAdd.Columns != null
                    && table.Columns.Count == tableToAdd.Columns.Count
                    && table.Rows != null && tableToAdd.Rows != null)
                {
                    foreach (DataRow row in tableToAdd.Rows)
                    {
                        table.Rows.Add(row.ItemArray);
                        numAdded++;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.ForContext("Source Context", "GTC.Extensions.DataTable_Extensions")
                    .Warning(ex, "AddTableData threw an exception after adding {numRows} rows of data. The exception was caught, and the extension was allowed to complete the work.", numAdded);
            }
            return numAdded;
        }

        /// <summary>
        /// Converts the data in a DataTable into a String List of values with each string representing a full
        /// row of data, separated by the character specified in the <paramref name="separator"/> parameter.
        /// </summary>
        /// <param name="table">the DataTable to which this extension method is exposed. </param>
        /// <param name="separator">The string separator for each data item in a row.</param>
        /// <returns>a String List of values.</returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table">the DataTable to which this extension method is exposed. </param>
        /// <param name="columnSeparator"></param>
        /// <param name="rowSeparator"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table">the DataTable to which this extension method is exposed. </param>
        /// <param name="fileName"></param>
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
        */
    }
}
