
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

[assembly: CLSCompliant(true)]
namespace GTC.Utilities.Data
{
    public class TalkToSql
    {
        #region public properties
        public bool setArithAbortOn { get; private set; }
        #endregion

        #region Private Properties
        /// <summary>
        /// This command exists to set overall SQL settings that can drastically impact performance
        /// </summary>
        private const string Sql_SET_COMMAND = @"SET ARITHABORT ON";
        private string _sqlConn;
        private int _sqlCmdTimeout = 60;
        private DateTime nullDateTime = DateTime.MinValue;
        private SqlConnection conn;
        #endregion

        #region constructors
        /// <summary>
        /// Initiates the properties to have the proper SQL Connection string
        /// </summary>
        /// <param name="SqlConn"></param>
        public TalkToSql(string SqlConn)
        {
            _sqlConn = SqlConn;
            setArithAbortOn = true;
            InitializeSqlConnection();
        }

        public TalkToSql(string SqlConn, int SqlCmdTimeout)
        {
            _sqlConn = SqlConn;
            _sqlCmdTimeout = SqlCmdTimeout;
            setArithAbortOn = true;
            InitializeSqlConnection();
        }

        public TalkToSql(string SqlConn, int SqlCmdTimeout, bool setArithAbort)
        {
            _sqlConn = SqlConn;
            _sqlCmdTimeout = SqlCmdTimeout;
            setArithAbortOn = setArithAbort;
            InitializeSqlConnection();
        }

        ~TalkToSql()
        {
            DisposeSqlConnection();
        }
        #endregion

        #region public methods
        public void CloseConnection()
        {
            DisposeSqlConnection();
        }

        /*
        NOTE: ExecuteStoredProcedure is currently not implemented
        */
        //public TimeSpan ExecuteSprocStringList(string queryEntireTable, out List<string> _list, string NullValueToUse = "")
        //{
        //    DateTime dt = DateTime.Now;
        //    _list = new List<string>();

        //    using (SqlConnection conn = new SqlConnection(sqlConn))
        //    {
        //        conn.Open();
        //        using (SqlCommand comm = new SqlCommand(Sql_SET_COMMAND, conn))
        //        {
        //            comm.ExecuteNonQuery();
        //        }

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = conn;
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandTimeout = _sqlCmdTimeout;
        //            using (SqlDataReader _rdr = cmd.ExecuteReader())
        //            {
        //                while (_rdr.Read())
        //                {
        //                    _list.Add(_rdr.IsDBNull(0) ? NullValueToUse : _rdr.GetString(0));
        //                }
        //            }
        //        }
        //    }
        //    return DateTime.Now - dt;
        //}


        /// <summary>
        /// Executes the passed in SQL command and ignores any response from SQL server 
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteNoReturn(string sqlCmd)
        {
            DateTime dt = DateTime.Now;
            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the number of affected rows in the rowCount property 
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="rowCount">[out] param that receives the row count affected by the query</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteAndReturnRowCount(string sqlCmd, out int rowCount)
        {
            DateTime dt = DateTime.Now;
            rowCount = 0;
            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                rowCount = cmd.ExecuteNonQuery();
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the values from column 0 into the provided decimal List.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="_list">A .NET collection object of type List'decimal'. This list is initialized/cleared before use.</param>
        /// <param name="NullValueToUse">[optional] The value to place in the List for every null value returned from SQL</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteReaderDecimalList(string sqlCmd, out List<decimal> _list, decimal NullValueToUse = 0)
        {
            DateTime dt = DateTime.Now;
            _list = new List<decimal>();

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                using (SqlDataReader _rdr = cmd.ExecuteReader())
                {
                    while (_rdr.Read())
                    {
                        _list.Add(_rdr.IsDBNull(0) ? NullValueToUse : _rdr.GetDecimal(0));
                    }
                }
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the values from column 0 into the provided integer List.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="_list">A .NET collection object of type List'int'. This list is initialized/cleared before use.</param>
        /// <param name="NullValueToUse">[optional] The value to place in the List for every null value returned from SQL</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteReaderIntList(string sqlCmd, out List<int> _list, int NullValueToUse = 0)
        {
            DateTime dt = DateTime.Now;
            _list = new List<int>();

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                using (SqlDataReader _rdr = cmd.ExecuteReader())
                {
                    while (_rdr.Read())
                    {
                        _list.Add(_rdr.IsDBNull(0) ? NullValueToUse : _rdr.GetInt32(0));
                    }
                }
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the values from column 0 into the provided string List.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="_list">A .NET collection object of type List'string'. This list is initialized/cleared before use.</param>
        /// <param name="NullValueToUse">[optional] The value to place in the List for every null value returned from SQL</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteReaderStringList(string sqlCmd, out List<string> _list, string NullValueToUse = "")
        {
            DateTime dt = DateTime.Now;
            _list = new List<string>();

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                using (SqlDataReader _rdr = cmd.ExecuteReader())
                {
                    while (_rdr.Read())
                    {
                        _list.Add(_rdr.IsDBNull(0) ? NullValueToUse : _rdr.GetString(0));
                    }
                }
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the values from column 0 into the provided string List.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="_list">A .NET collection object of type List'string'. This list is initialized/cleared before use.</param>
        /// <param name="NullValueToUse">[optional] The value to place in the List for every null value returned from SQL</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteReaderStringCollection(string sqlCmd, out Collection<String> _list, string NullValueToUse = "")
        {
            DateTime dt = DateTime.Now;

            _list = new Collection<string>();

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                using (SqlDataReader _rdr = cmd.ExecuteReader())
                {
                    while (_rdr.Read())
                    {
                        _list.Add(_rdr.IsDBNull(0) ? NullValueToUse : _rdr.GetString(0));
                    }
                }
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and uses the .NET DataTable.Load() method to transfer all results to the provided DataTable
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="_list">A .NET DataTable object. This list is initialized/cleared before use.</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteReaderTable(string sqlCmd, out DataTable _table)
        {
            DateTime dt = DateTime.Now;
            _table = new DataTable();

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                using (SqlDataReader _rdr = cmd.ExecuteReader())
                {
                    _table.Load(_rdr);
                }
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the SQL command passed in and adds all of the table results to the passed in data set
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="_dataset">A DataSet that will receive the data tables returned from the queries</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuterReaderMultiTable(string sqlCmd, out DataSet _dataset)
        {
            DateTime dt = DateTime.Now;
            _dataset = new DataSet();

            conn.Open();
            CheckAndSetArithAbort(conn);

            SqlCommand _cmd = new SqlCommand(sqlCmd, conn);
            _cmd.CommandTimeout = _sqlCmdTimeout;

            SqlDataReader _rdr = _cmd.ExecuteReader();
            do
            {
                DataTable tbl = new DataTable();
                tbl.Load(_rdr);
                _dataset.Tables.Add(tbl);
            } while (!_rdr.IsClosed);
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided boolean.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">A boolean that receives the returned value. It is initialized to <paramref name="NullValueToUse"/> before the SQL is executed</param>
        /// <param name="NullValueToUse">[optional] The value to place in <paramref name="returnValue"/> if the value returned from SQL is null or not a boolean</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarBool(string sqlCmd, out bool returnValue, bool NullValueToUse = false)
        {
            DateTime dt = DateTime.Now;
            returnValue = NullValueToUse;

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                returnValue = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided DateTime property.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">A DateTime that receives the returned value. It is initialized to 'DateTime.MinValue' before the SQL is executed</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarDateTime(string sqlCmd, out DateTime returnValue)
        {
            DateTime dt = DateTime.Now;
            ExecuteScalarDateTime(sqlCmd, out returnValue, nullDateTime);
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided DateTime property.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">A DateTime property that receives the returned value. It is initialized to <paramref name="NullValueToUse"/> before the SQL is executed</param>
        /// <param name="NullValueToUse">[optional] The value to place in <paramref name="returnValue"/> if the value returned from SQL is null or not a DateTime property.</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarDateTime(string sqlCmd, out DateTime returnValue, DateTime NullValueToUse)
        {
            DateTime dt = DateTime.Now;
            returnValue = NullValueToUse;

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                returnValue = Convert.ToDateTime(cmd.ExecuteScalar());
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided decimal.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">A decimal that receives the returned value. It is initialized to <paramref name="NullValueToUse"/> before the SQL is executed</param>
        /// <param name="NullValueToUse">[optional] The value to place in <paramref name="returnValue"/> if the value returned from SQL is null or not a decimal</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarDecimal(string sqlCmd, out decimal returnValue, decimal NullValueToUse = 0)
        {
            DateTime dt = DateTime.Now;
            returnValue = NullValueToUse;

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                returnValue = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided Int32.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">An Int32 that receives the returned value. It is initialized to <paramref name="NullValueToUse"/> before the SQL is executed</param>
        /// <param name="NullValueToUse">[optional] The value to place in <paramref name="returnValue"/> if the value returned from SQL is null or not an Int32</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarInt32(string sqlCmd, out Int32 returnValue, Int32 NullValueToUse = 0)
        {
            DateTime dt = DateTime.Now;
            returnValue = NullValueToUse;

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                returnValue = Convert.ToInt32(cmd.ExecuteScalar());
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided Int64.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">An Int64 that receives the returned value. It is initialized to <paramref name="NullValueToUse"/> before the SQL is executed</param>
        /// <param name="NullValueToUse">[optional] The value to place in <paramref name="returnValue"/> if the value returned from SQL is null or not an Int64</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarInt64(string sqlCmd, out Int64 returnValue, Int64 NullValueToUse = 0)
        {
            DateTime dt = DateTime.Now;
            returnValue = NullValueToUse;

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                returnValue = Convert.ToInt64(cmd.ExecuteScalar());
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided Int64.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">An Single that receives the returned value. It is initialized to <paramref name="NullValueToUse"/> before the SQL is executed</param>
        /// <param name="NullValueToUse">[optional] The value to place in <paramref name="returnValue"/> if the value returned from SQL is null or not an Int64</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarSingle(string sqlCmd, out Single returnValue, Single NullValueToUse = 0)
        {
            DateTime dt = DateTime.Now;
            returnValue = NullValueToUse;

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                returnValue = Convert.ToSingle(cmd.ExecuteScalar());
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided System Object.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">A boolean that receives the returned value. It is initialized to an Empty Object before the SQL is executed</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarSystemObject(string sqlCmd, out System.Object returnValue)
        {
            DateTime dt = DateTime.Now;
            ///TODO: How do I check to see if this is already initialized?
            returnValue = new System.Object();

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                returnValue = cmd.ExecuteScalar();
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes the passed in SQL command and places the value from row 0, column 0 into the provided string.
        /// </summary>
        /// <param name="queryEntireTable">The T-SQL Command to pass to the database</param>
        /// <param name="returnValue">A string that receives the returned value. It is initialized to <paramref name="NullValueToUse"/> before the SQL is executed</param>
        /// <param name="NullValueToUse">[optional] The value to place in <paramref name="returnValue"/> if the value returned from SQL is null or not a string</param>
        /// <returns>a TimeSpan object that represents the amount of time spent inside this method</returns>
        public TimeSpan ExecuteScalarString(string sqlCmd, out string returnValue, string NullValueToUse = "")
        {
            DateTime dt = DateTime.Now;
            returnValue = NullValueToUse;

            conn.Open();
            CheckAndSetArithAbort(conn);

            using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
            {
                cmd.CommandTimeout = _sqlCmdTimeout;
                returnValue = Convert.ToString(cmd.ExecuteScalar());
            }
            conn.Close();
            return DateTime.Now - dt;
        }

        /// <summary>
        /// Executes a SqlBulkCopy to the specified table in the DB
        /// </summary>
        /// <param name="sqlTableName">The name of the table in SQL to copy the data into</param>
        /// <param name="rows">the collection of data to write to the table</param>
        /// <param name="errorMessage">a string that contains any error or exception that gets thrown during the bulk copy, or empty if it succeeds.</param>
        /// <returns>the amount of time the operation took.</returns>
        public TimeSpan ExecuteSqlBulkCopy(string sqlTableName, DataTable rows, out string errorMessage)
        {
            DateTime dt = DateTime.Now;
            errorMessage = "";

            conn.Open();
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
            {
                bulkCopy.DestinationTableName = sqlTableName;

                try
                {
                    // Write from the source to the destination.
                    bulkCopy.WriteToServer(rows);
                }
                catch (Exception ex)
                {
                    errorMessage = ex.ToString();
                }
            }
            conn.Close();
            return DateTime.Now - dt;
        }
        #endregion

        #region Private Methods
        private void CheckAndSetArithAbort(SqlConnection conn)
        {
            if (setArithAbortOn)
            {
                using (SqlCommand comm = new SqlCommand(Sql_SET_COMMAND, conn))
                {
                    comm.ExecuteNonQuery();
                }
            }
        }

        private void InitializeSqlConnection()
        {
            conn = new SqlConnection(_sqlConn);
        }

        private void DisposeSqlConnection()
        {
            conn.Dispose();
        }
        #endregion
    }
}
