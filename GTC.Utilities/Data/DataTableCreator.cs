using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace GTC.Utilities.Data
{
    public class DataTableCreator
    {
        public static DataTable CreateDataTableFromList<T>(List<T> list)
        {
            DataTable dataTable = new DataTable();
            Type type = typeof(T);
            dataTable.Columns.Add(new DataColumn(type.Name, type));
            foreach(var item in list)
            {
                dataTable.Rows.Add(item);
            }
            return dataTable;
        }

        public static DataTable CreateDataTableFromEnumerable<T>(IEnumerable<T> list)
        {
            DataTable dataTable = new DataTable();
            Type type = typeof(T);
            var properties = type.GetProperties();

            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        public static DataTable CreateDataTableFromDictionary<T>(IEnumerable<T> list)
        {
            DataTable dataTable = new DataTable();
            Type type = typeof(T);
            var properties = type.GetProperties();

            // Build the columns
            dataTable.Columns.Add(new DataColumn(properties[0].Name, Nullable.GetUnderlyingType(properties[0].PropertyType) ?? properties[0].PropertyType));
            GetColumns(properties[1].PropertyType, dataTable);

            // Add the data
            foreach (T entity in list)
            {
                object[] values = new object[dataTable.Columns.Count];
                values[0] = properties[0].GetValue(entity);

                var valueProperties = properties[1].PropertyType.GetProperties();
                object valueObject = properties[1].GetValue(entity);

                for (int i = 0; i < valueProperties.Length; i++)
                {
                    values[i + 1] = valueProperties[i].GetValue(valueObject);
                }

                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        private static void GetColumns(Type propertyType, DataTable dataTable)
        {
            var properties = propertyType.GetProperties();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }
        }
    }
}
