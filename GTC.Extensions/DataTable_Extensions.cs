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
    /// Extension class for <see cref="DataTable"/> objects that exposes extra methods.
    /// </summary>
    public static class DataTable_Extensions
    {
        /// <summary>
        /// Reads all the values from the specified column in the DataTable and adds them to a <see cref="List{string}"/>.
        /// </summary>
        /// <param name="table">the DataTable to which this extension method is exposed. </param>
        /// <param name="columnName">The name of the column whose values will be added to list.</param>
        /// <returns>a String List that contains all of the values from the specified column.</returns>
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
        /// Reads all the values from the specified column in the DataTable and adds them to a <see cref="List{string}"/>.
        /// </summary>
        /// <param name="table">the DataTable to which this extension method is exposed. </param>
        /// <param name="columnIndex">The index of the column whose values will be added to list.</param>
        /// <returns>a String List that contains all of the values from the specified column.</returns>
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
        /// Reads all the values from the specified column in the DataTable and adds them to a <see cref="List{T}"/> that matches the
        /// type of the specified column.
        /// </summary>
        /// <param name="table">the DataTable to which this extension method is exposed. </param>
        /// <param name="columnName">The name of the column whose values will be added to list.</param>
        /// <returns>an Object List that contains all of the values from the specified column.</returns>
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
        /// Reads all the values from the specified column in the DataTable and adds them to a <see cref="List{T}"/> that matches the
        /// type of the specified column.
        /// </summary>
        /// <param name="table">the DataTable to which this extension method is exposed. </param>
        /// <param name="columnIndex">The index of the column whose values will be added to list.</param>
        /// <returns>an Object List that contains all of the values from the specified column.</returns>
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
        /// Adds all data from the the <paramref name="tableToAdd"/> table to the end of the <paramref name="table"/>.
        /// </summary>
        /// <remarks>
        /// This method does not validate the data types for each column. Therefore you should be sure the two tables 
        /// have the same schema.
        /// </remarks>
        /// <param name="table">the DataTable to which this extension method is exposed. </param>
        /// <param name="tableToAdd">the DataTable whose data will be appended to the original table</param>
        /// <returns>a number indicating how many rows were appended to the original DataTable.</returns>
        public static int AppendTableData(this DataTable table, DataTable tableToAdd)
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
    }
}
